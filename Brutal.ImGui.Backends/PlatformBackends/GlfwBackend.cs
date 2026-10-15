using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Brutal.Collections;
using Brutal.GlfwApi;
using Brutal.Memory;
using Brutal.Numerics;
using Brutal.Pointers;
using Brutal.Strings;

namespace Brutal.ImGuiApi.Backends;

public partial class GlfwBackend : IPlatformBackend
{
    private readonly GlfwWindow _window;
    private readonly ImGuiContextPtr _context;

    private readonly GlfwMouseButtonCallback _mouseButtonCallback;
    private readonly GlfwScrollCallback _scrollCallback;
    private readonly GlfwCursorPosCallback _cursorPosCallback;
    private readonly GlfwCursorEnterCallback _cursorEnterCallback;
    private readonly GlfwKeyCallback _keyCallback;
    private readonly GlfwCharCallback _charCallback;
    private readonly GlfwWindowFocusCallback _focusCallback;
    private readonly GlfwWindowCloseCallback _closeCallback;
    private readonly GlfwWindowPosCallback _posCallback;
    private readonly GlfwWindowSizeCallback _sizeCallback;

    // ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
    private readonly ImGuiPlatformIO.GetClipboardTextFnDelegate _getClipboardTextFunction;
    private readonly ImGuiPlatformIO.SetClipboardTextFnDelegate _setClipboardTextFunction;

    private double _lastTime;
    private double2 _lastValidMousePos;

    private bool _mouseIgnoreButtonUp;
    private bool _mouseIgnoreButtonUpWaitForFocusLoss;
    private nint _prevWndProc;
    private readonly WeakReference<GlfwWindow?> _mouseWindow = new(null);

    // Our Glfw.Clipboard returns a managed string, which can't be passed back to ImGui, so
    // need to cache a stable version here from which we can hand ImGui a byte*
    private readonly NativeList<byte> _cachedClipboardText = [];

    private readonly GlfwCursor[] _mouseCursors = new GlfwCursor[(int)ImGuiMouseCursor.COUNT];

    private readonly NativeList<byte> _backendName;

    public enum ClientApi
    {
        Unknown,
        OpenGL,
        Vulkan,
    }

    private readonly ClientApi _clientApi;

    private class WindowData
    {
        public readonly HashSet<GlfwKey> OwnedKeys = [];
        public required nint PlatformHandle;
    }

    private readonly ConditionalWeakTable<GlfwWindow, WindowData> _windowData = [];

    public GlfwBackend(GlfwWindow window, ClientApi clientApi)
    {
        _window = window;
        _context = ImGui.GetCurrentContext();

        var backendName = $"Brutal.ImGui.GlfwBackend - GlfwVersion: {Glfw.VersionString}";
        _backendName = new NativeList<byte>(Utf8.GetByteCount(backendName) + 1);
        Utf8.FromUtf16(backendName, _backendName.AsSpan(), out _, out _);

        var io = ImGui.GetIO();

        if (io.BackendPlatformUserData is not 0)
            throw new InvalidOperationException("ImGui backend already initialized");
        io.BackendPlatformUserData = (nint)GCHandle.Alloc(this);

        io.BackendPlatformName = _backendName.Ptr;

        io.BackendFlags |= ImGuiBackendFlags.HasMouseCursors; // We can honor GetMouseCursor() values (optional)
        io.BackendFlags |= ImGuiBackendFlags.HasSetMousePos; // We can honor io.WantSetMousePos requests (optional, rarely used)
        io.BackendFlags |= ImGuiBackendFlags.PlatformHasViewports; // We can create multi-viewports on the Platform side (optional)
        io.BackendFlags |= ImGuiBackendFlags.HasMouseHoveredViewport; // We can call io.AddMouseViewportEvent() with correct data (optional)

        unsafe
        {
            _getClipboardTextFunction = GetClipboardText;
            _setClipboardTextFunction = SetClipboardText;

            var platformIo = ImGui.GetPlatformIO();
            platformIo.Platform_GetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(_getClipboardTextFunction);
            platformIo.Platform_SetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(_setClipboardTextFunction);
        }

        InitMouseCursors();

        _mouseButtonCallback = OnMouseButton;
        _scrollCallback = OnScroll;
        _cursorPosCallback = OnCursorPos;
        _cursorEnterCallback = OnCursorEnter;
        _keyCallback = OnKey;
        _charCallback = OnChar;
        _focusCallback = OnFocus;

        _closeCallback = WindowCloseCallback;
        _posCallback = WindowPosCallback;
        _sizeCallback = WindowSizeCallback;

        _window.OnMouseButton += _mouseButtonCallback;
        _window.OnScroll += _scrollCallback;
        _window.OnCursorPos += _cursorPosCallback;
        _window.OnCursorEnter += _cursorEnterCallback;
        _window.OnKey += _keyCallback;
        _window.OnChar += _charCallback;
        _window.OnFocus += _focusCallback;

        // Update monitor a first time during init
        UpdateMonitors();

        // Set platform dependent data in viewport
        var mainViewport = ImGui.GetMainViewport();
        mainViewport.PlatformHandle = (nint)GCHandle.Alloc(window);
        _windowData.Add(window, new WindowData { PlatformHandle = mainViewport.PlatformHandle });

        if (OperatingSystem.IsWindows())
        {
            mainViewport.PlatformHandleRaw = GlfwInterop.GetWin32Window(_window.NativeHandle);
        }
        else if (OperatingSystem.IsMacOS())
        {
            mainViewport.PlatformHandleRaw = GlfwInterop.GetCocoaWindow(_window.NativeHandle);
        }

        InitMultiViewportSupport();

        // Windows: register a WndProc hook so we can intercept some messages.
        if (OperatingSystem.IsWindows())
        {
            var handle = GCHandle.Alloc(this);
            WindowsNative.SetPropA(mainViewport.PlatformHandleRaw, "IMGUI_BACKEND_DATA"u8, (nint)handle);
            _prevWndProc = WindowsNative.GetWindowLongPtrW(
                mainViewport.PlatformHandleRaw,
                WindowsNative.Constants.GWLP_WNDPROC
            );

            if (_prevWndProc == 0)
                throw new InvalidOperationException("Failed to get previous WndProc");

            unsafe
            {
                WindowsNative.SetWindowLongPtrW(
                    mainViewport.PlatformHandleRaw,
                    WindowsNative.Constants.GWLP_WNDPROC,
                    (nint)WindowsNative.WndProcDelegate
                );
            }
        }

        _clientApi = clientApi;
    }

    public void NewFrame()
    {
        var io = GetIO(_context);

        // Setup main viewport size (every frame to accommodate for window resizing).
        // DisplayFramebufferScale is the framebuffer/window ratio, matching the C++ reference and
        // the viewport render path.
        io.DisplaySize = float2.Unpack(_window.Size);
        io.DisplayFramebufferScale = GetFramebufferScale(_window);

        UpdateMonitors();

        // Setup time step
        // (Accept glfwGetTime() not returning a monotonically increasing value. Seems to happens on disconnecting peripherals and probably on VMs and Emscripten, see #6491, #6189, #6114, #3644)
        var time = Glfw.Time;
        if (time <= _lastTime)
            time = _lastTime + 0.00001f;
        io.DeltaTime = _lastTime > 0.0d ? (float)(time - _lastTime) : 1.0f / 60.0f;
        _lastTime = time;

        _mouseIgnoreButtonUp = false;

        UpdateMouseData();
        UpdateMouseCursor();
        UpdateGamepads();
    }

    public void Dispose()
    {
        var mainViewport = ImGui.GetMainViewport();
        if (mainViewport.PlatformHandle is not 0)
        {
            GCHandle.FromIntPtr(mainViewport.PlatformHandle).Free();
            mainViewport.PlatformHandle = 0;
        }

        ImGui.DestroyPlatformWindows();

        _window.OnMouseButton -= _mouseButtonCallback;
        _window.OnScroll -= _scrollCallback;
        _window.OnCursorPos -= _cursorPosCallback;
        _window.OnKey -= _keyCallback;
        _window.OnChar -= _charCallback;
        _window.OnFocus -= _focusCallback;
        _window.OnCursorEnter -= _cursorEnterCallback;

        foreach (var cursor in _mouseCursors)
            cursor.Dispose();

        mainViewport = ImGui.GetMainViewport();

        // Windows: restore our WndProc hook
        if (OperatingSystem.IsWindows())
        {
            WindowsNative.SetPropA(mainViewport.PlatformHandleRaw, "IMGUI_BACKEND_DATA"u8, 0);
            var backend = GetBackend();
            WindowsNative.SetWindowLongPtrW(
                mainViewport.PlatformHandleRaw,
                WindowsNative.Constants.GWLP_WNDPROC,
                backend._prevWndProc
            );
            backend._prevWndProc = 0;
        }

        var io = ImGui.GetIO();
        unsafe
        {
            io.BackendPlatformName = null;
        }

        io.BackendFlags &= ~(
            ImGuiBackendFlags.HasMouseCursors
            | ImGuiBackendFlags.HasSetMousePos
            | ImGuiBackendFlags.HasGamepad
            | ImGuiBackendFlags.PlatformHasViewports
            | ImGuiBackendFlags.HasMouseHoveredViewport
        );

        io.BackendPlatformUserData = 0;
    }

    private void InitMouseCursors()
    {
        void SetCursor(ImGuiMouseCursor imGuiCursor, GlfwStandardCursor glfwCursor)
        {
            _mouseCursors[(int)imGuiCursor] = Glfw.CreateCursor(glfwCursor);
        }

        SetCursor(ImGuiMouseCursor.Arrow, GlfwStandardCursor.Arrow);
        SetCursor(ImGuiMouseCursor.TextInput, GlfwStandardCursor.IBeam);
        SetCursor(ImGuiMouseCursor.ResizeNS, GlfwStandardCursor.VResize);
        SetCursor(ImGuiMouseCursor.ResizeEW, GlfwStandardCursor.HResize);
        SetCursor(ImGuiMouseCursor.Hand, GlfwStandardCursor.Hand);
        SetCursor(ImGuiMouseCursor.ResizeAll, GlfwStandardCursor.ResizeAll);
        SetCursor(ImGuiMouseCursor.ResizeNESW, GlfwStandardCursor.ResizeNesw);
        SetCursor(ImGuiMouseCursor.ResizeNWSE, GlfwStandardCursor.ResizeNwse);
        SetCursor(ImGuiMouseCursor.NotAllowed, GlfwStandardCursor.NotAllowed);
    }

    // ReSharper disable once UnusedParameter.Local
    private static ImGuiIOPtr GetIO(ImGuiContextPtr context)
    {
        // If we expose imgui_internal this should wrap the function overload GetIO(ImGuiContext* context)
        return ImGui.GetIO();
    }

    private unsafe void SetClipboardText(ImGuiContextPtr context, byte* text)
    {
        var span = Utf8.GetNullTerminatedSpan(text);
        Glfw.SetClipboard(Utf8.GetString(span));
    }

    private unsafe byte* GetClipboardText(ImGuiContextPtr context)
    {
        var str = Glfw.Clipboard;
        if (str is null)
            return null;

        var byteCount = Utf8.GetByteCount(str);
        _cachedClipboardText.Count = byteCount + 1;
        Utf8.FromUtf16(str, _cachedClipboardText.AsSpan(), out _, out _);
        _cachedClipboardText[byteCount] = 0; // Add null terminator
        return _cachedClipboardText.Ptr;
    }

    private void OnMouseButton(GlfwWindow window, GlfwMouseButton button, GlfwButtonAction action, GlfwModifier mods)
    {
        // Workaround for Linux: ignore mouse up events which are following an focus loss following a viewport creation
        if (_mouseIgnoreButtonUp && action is GlfwButtonAction.Release)
            return;

        var io = GetIO(_context);
        UpdateKeyModifiers(io, window);

        var buttonValue = (int)button;
        if (buttonValue is >= 0 and < (int)ImGuiMouseButton.COUNT)
            io.AddMouseButtonEvent(buttonValue, action is GlfwButtonAction.Press);
    }

    private void OnScroll(GlfwWindow glfwWindow, double2 offset)
    {
        GetIO(_context).AddMouseWheelEvent((float)offset.X, (float)offset.Y);
    }

    private void OnCursorPos(GlfwWindow window, double2 pos)
    {
        var io = GetIO(_context);
        if (io.ConfigFlags.HasFlag(ImGuiConfigFlags.ViewportsEnable))
        {
            pos.X += window.X;
            pos.Y += window.Y;
        }
        io.AddMousePosEvent((float)pos.X, (float)pos.Y);
        _lastValidMousePos = pos;
    }

    private void OnCursorEnter(GlfwWindow window, bool entered)
    {
        var io = GetIO(_context);
        if (entered)
        {
            _mouseWindow.SetTarget(window);
            io.AddMousePosEvent((float)_lastValidMousePos.X, (float)_lastValidMousePos.Y);
        }
        else if (!entered && _mouseWindow.TryGetTarget(out var mouseWindow) && mouseWindow == window)
        {
            _lastValidMousePos = new double2(io.MousePos.X, io.MousePos.Y);
            _mouseWindow.SetTarget(null);
            io.AddMousePosEvent(-float.MaxValue, -float.MaxValue);
        }
    }

    private void OnKey(GlfwWindow window, GlfwKey key, int scancode, GlfwKeyAction action, GlfwModifier mods)
    {
        if (action is not GlfwKeyAction.Press and not GlfwKeyAction.Release)
            return;

        var io = GetIO(_context);
        UpdateKeyModifiers(io, window);

        if ((int)key is >= 0 and <= (int)GlfwKey.Last)
        {
            if (_windowData.TryGetValue(window, out var data))
            {
                if (action is GlfwKeyAction.Press)
                    data.OwnedKeys.Add(key);
                else
                    data.OwnedKeys.Remove(key);
            }
        }

        key = TranslateUntranslatedKey(key, scancode);

        io.AddKeyEvent(Convert(key), action is GlfwKeyAction.Press);
    }

    private void OnChar(GlfwWindow window, uint codepoint)
    {
        GetIO(_context).AddInputCharacter(codepoint);
    }

    private void OnFocus(GlfwWindow window, GlfwFocusEvent focusEvent)
    {
        // Workaround for Linux: when losing focus with MouseIgnoreButtonUpWaitForFocusLoss set, we will temporarily ignore subsequent Mouse Up events
        _mouseIgnoreButtonUp = _mouseIgnoreButtonUpWaitForFocusLoss && focusEvent is GlfwFocusEvent.LostFocus;
        _mouseIgnoreButtonUpWaitForFocusLoss = false;

        GetIO(_context).AddFocusEvent(focusEvent is GlfwFocusEvent.GainFocus);
    }

    private static void UpdateMonitors()
    {
        var platformIO = ImGui.GetPlatformIO();
        var monitors = Glfw.GetMonitors();
        if (monitors.Length == 0) // Preserve existing monitor list if there are none. Happens on macOS sleeping (#5683)
            return;

        platformIO.Monitors.Count = 0;

        foreach (var monitor in monitors)
        {
            var pos = monitor.Position;
            var vidMode = monitor.VideoMode;
            if (vidMode.IsNull())
                continue; // Failed to get Video mode (e.g. Emscripten does not support this function)

            var floatPos = float2.Unpack(pos);
            var size = new float2(vidMode.Width, vidMode.Height);
            var imGuiMonitor = new ImGuiPlatformMonitor
            {
                MainPos = floatPos,
                WorkPos = floatPos,
                MainSize = size,
                WorkSize = size,
            };

            monitor.GetMonitorWorkArea(out var workAreaPos, out var workAreaSize);

            if (workAreaSize is { X: > 0, Y: > 0 }) // Workaround a small GLFW issue reporting zero on monitor changes: https://github.com/glfw/glfw/pull/1761
            {
                imGuiMonitor.WorkPos = float2.Unpack(workAreaPos);
                imGuiMonitor.WorkSize = float2.Unpack(workAreaSize);
            }

            var scale = GetContentScaleForMonitor(monitor);

            if (scale == 0.0f)
                continue; // Some accessibility applications are declaring virtual monitors with a DPI of 0, see #7902.

            imGuiMonitor.DpiScale = scale;
            imGuiMonitor.PlatformHandle = monitor.NativeHandle; // [...] GLFW doc states: "guaranteed to be valid only until the monitor configuration changes"
            platformIO.Monitors.Add(imGuiMonitor);
        }
    }

    private static void UpdateKeyModifiers(ImGuiIOPtr io, GlfwWindow window)
    {
        io.AddKeyEvent(
            ImGuiKey.Mod_Ctrl,
            window.GetKey(GlfwKey.LeftControl) is GlfwKeyAction.Press
                || window.GetKey(GlfwKey.RightControl) is GlfwKeyAction.Press
        );
        io.AddKeyEvent(
            ImGuiKey.Mod_Shift,
            window.GetKey(GlfwKey.LeftShift) is GlfwKeyAction.Press
                || window.GetKey(GlfwKey.RightShift) is GlfwKeyAction.Press
        );
        io.AddKeyEvent(
            ImGuiKey.Mod_Alt,
            window.GetKey(GlfwKey.LeftAlt) is GlfwKeyAction.Press
                || window.GetKey(GlfwKey.RightAlt) is GlfwKeyAction.Press
        );
        io.AddKeyEvent(
            ImGuiKey.Mod_Super,
            window.GetKey(GlfwKey.LeftSuper) is GlfwKeyAction.Press
                || window.GetKey(GlfwKey.RightSuper) is GlfwKeyAction.Press
        );
    }

    private void UpdateMouseData()
    {
        var io = ImGui.GetIO();
        var platformIo = ImGui.GetPlatformIO();

        ImGuiID mouseViewportId = 0;
        var mousePosPrev = io.MousePos;
        foreach (var viewport in platformIo.Viewports)
        {
            if (viewport.PlatformHandle is 0)
                continue;

            var window = viewport.GetWindow();

            var isWindowFocused = window.GetAttribute(GlfwWindowAttribute.Focused) != 0;
            if (isWindowFocused)
            {
                // (Optional) Set OS mouse position from Dear ImGui if requested (rarely used, only when io.ConfigNavMoveSetMousePos is enabled by user)
                // When multi-viewports are enabled, all Dear ImGui positions are same as OS positions.
                if (io.WantSetMousePos)
                    window.CursorPos = new double2(mousePosPrev.X - viewport.Pos.X, mousePosPrev.Y - viewport.Pos.Y);

                // (Optional) Fallback to provide mouse position when focused (ImGui_ImplGlfw_CursorPosCallback already provides this when hovered or captured)
                if (!_mouseWindow.TryGetTarget(out _))
                {
                    var mousePos = window.CursorPos;
                    if (io.ConfigFlags.HasFlag(ImGuiConfigFlags.ViewportsEnable))
                    {
                        // Single viewport mode: mouse position in client window coordinates (io.MousePos is (0,0) when the mouse is on the upper-left corner of the app window)
                        // Multi-viewport mode: mouse position in OS absolute coordinates (io.MousePos is (0,0) when the mouse is on the upper-left of the primary monitor)
                        mousePos += double2.Unpack(window.Position);
                    }
                    _lastValidMousePos = mousePos;
                    io.AddMousePosEvent((float)mousePos.X, (float)mousePos.Y);
                }
            }

            // (Optional) When using multiple viewports: call io.AddMouseViewportEvent() with the viewport the OS mouse cursor is hovering.
            // If ImGuiBackendFlags_HasMouseHoveredViewport is not set by the backend, Dear imGui will ignore this field and infer the information using its flawed heuristic.
            // - [X] GLFW >= 3.3 backend ON WINDOWS ONLY does correctly ignore viewports with the _NoInputs flag (since we implement hit via our WndProc hook)
            //       On other platforms we rely on the library fallbacking to its own search when reporting a viewport with _NoInputs flag.
            // - [!] GLFW <= 3.2 backend CANNOT correctly ignore viewports with the _NoInputs flag, and CANNOT reported Hovered Viewport because of mouse capture.
            //       Some backend are not able to handle that correctly. If a backend report an hovered viewport that has the _NoInputs flag (e.g. when dragging a window
            //       for docking, the viewport has the _NoInputs flag in order to allow us to find the viewport under), then Dear ImGui is forced to ignore the value reported
            //       by the backend, and use its flawed heuristic to guess the viewport behind.
            // - [X] GLFW backend correctly reports this regardless of another viewport behind focused and dragged from (we need this to find a useful drag and drop target).
            // FIXME: This is currently only correct on Win32. See what we do below with the WM_NCHITTEST, missing an equivalent for other systems.
            // See https://github.com/glfw/glfw/issues/1236 if you want to help in making this a GLFW feature.
            var windowNoInput = viewport.Flags.HasFlag(ImGuiViewportFlags.NoInputs);
            window.SetAttribute(GlfwWindowAttribute.MousePassthrough, windowNoInput ? 1 : 0);
            if (window.GetAttribute(GlfwWindowAttribute.Hovered) is 1)
                mouseViewportId = viewport.ID;
        }

        if (io.BackendFlags.HasFlag(ImGuiBackendFlags.HasMouseHoveredViewport))
            io.AddMouseViewportEvent(mouseViewportId);
    }

    private void UpdateMouseCursor()
    {
        var io = GetIO(_context);
        if (
            io.ConfigFlags.HasFlag(ImGuiConfigFlags.NoMouseCursorChange)
            || _window.GetInputMode(GlfwInputMode.Cursor) is (int)GlfwCursorMode.Disabled
        )
            return;

        var cursor = ImGui.GetMouseCursor();
        var platformIO = ImGui.GetPlatformIO();

        foreach (var viewport in platformIO.Viewports)
        {
            if (viewport.PlatformHandle is not 0)
            {
                var window = viewport.GetWindow();
                if (cursor is ImGuiMouseCursor.None || io.MouseDrawCursor)
                {
                    // Hide OS mouse cursor if imgui is drawing it or if it wants no cursor
                    window.SetInputMode(GlfwInputMode.Cursor, (int)GlfwCursorMode.Hidden);
                }
                else
                {
                    // Fall back to Arrow for any slot we don't initialize (Wait/Progress), matching
                    // the reference backend.
                    var glfwCursor = _mouseCursors[(int)cursor];
                    if (glfwCursor.IsNull())
                        glfwCursor = _mouseCursors[(int)ImGuiMouseCursor.Arrow];

                    // Show OS mouse cursor
                    window.SetCursor(glfwCursor);
                    window.SetInputMode(GlfwInputMode.Cursor, (int)GlfwCursorMode.Normal);
                }
            }
        }
    }

    private static void UpdateGamepads()
    {
        var io = ImGui.GetIO();

        if (!io.ConfigFlags.HasFlag(ImGuiConfigFlags.NavEnableGamepad)) // FIXME: Technically feeding gamepad shouldn't depend on this now that they are regular inputs, but see #8075
            return;

        io.BackendFlags &= ~ImGuiBackendFlags.HasGamepad;

        if (!Glfw.GetGamepadState(Glfw.Constants.GLFW_JOYSTICK_1, out var gamepad))
            return;

        io.BackendFlags |= ImGuiBackendFlags.HasGamepad;

        void MapButton(ImGuiKey key, GlfwGamepadButton button)
        {
            io.AddKeyEvent(key, gamepad.IsButtonPressed(button));
        }

        void MapAnalog(ImGuiKey key, GlfwGamepadAxis axis, float v0, float v1)
        {
            var v = gamepad.GetAxis(axis);
            v = (v - v0) / (v1 - v0);
            v = float.Clamp(v, 0.0f, 1.0f);
            io.AddKeyAnalogEvent(key, v > 0.1f, v);
        }

        MapButton(ImGuiKey.GamepadStart, GlfwGamepadButton.Start);
        MapButton(ImGuiKey.GamepadBack, GlfwGamepadButton.Back);
        MapButton(ImGuiKey.GamepadFaceLeft, GlfwGamepadButton.X); // Xbox X, PS Square
        MapButton(ImGuiKey.GamepadFaceRight, GlfwGamepadButton.B); // Xbox B, PS Circle
        MapButton(ImGuiKey.GamepadFaceUp, GlfwGamepadButton.Y); // Xbox Y, PS Triangle
        MapButton(ImGuiKey.GamepadFaceDown, GlfwGamepadButton.A); // Xbox A, PS Cross
        MapButton(ImGuiKey.GamepadDpadLeft, GlfwGamepadButton.DpadLeft);
        MapButton(ImGuiKey.GamepadDpadRight, GlfwGamepadButton.DpadRight);
        MapButton(ImGuiKey.GamepadDpadUp, GlfwGamepadButton.DpadUp);
        MapButton(ImGuiKey.GamepadDpadDown, GlfwGamepadButton.DpadDown);
        MapButton(ImGuiKey.GamepadL1, GlfwGamepadButton.LeftBumper);
        MapButton(ImGuiKey.GamepadR1, GlfwGamepadButton.RightBumper);
        MapAnalog(ImGuiKey.GamepadL2, GlfwGamepadAxis.LeftTrigger, -0.75f, +1.0f);
        MapAnalog(ImGuiKey.GamepadR2, GlfwGamepadAxis.RightTrigger, -0.75f, +1.0f);
        MapButton(ImGuiKey.GamepadL3, GlfwGamepadButton.LeftThumb);
        MapButton(ImGuiKey.GamepadR3, GlfwGamepadButton.RightThumb);
        MapAnalog(ImGuiKey.GamepadLStickLeft, GlfwGamepadAxis.LeftX, -0.25f, -1.0f);
        MapAnalog(ImGuiKey.GamepadLStickRight, GlfwGamepadAxis.LeftX, +0.25f, +1.0f);
        MapAnalog(ImGuiKey.GamepadLStickUp, GlfwGamepadAxis.LeftY, -0.25f, -1.0f);
        MapAnalog(ImGuiKey.GamepadLStickDown, GlfwGamepadAxis.LeftY, +0.25f, +1.0f);
        MapAnalog(ImGuiKey.GamepadRStickLeft, GlfwGamepadAxis.RightX, -0.25f, -1.0f);
        MapAnalog(ImGuiKey.GamepadRStickRight, GlfwGamepadAxis.RightX, +0.25f, +1.0f);
        MapAnalog(ImGuiKey.GamepadRStickUp, GlfwGamepadAxis.RightY, -0.25f, -1.0f);
        MapAnalog(ImGuiKey.GamepadRStickDown, GlfwGamepadAxis.RightY, +0.25f, +1.0f);
    }

    private static float2 GetFramebufferScale(GlfwWindow window)
    {
        var size = window.Size;
        if (size.X is 0 || size.Y is 0)
            return float2.One;

        var framebufferSize = window.FramebufferSize;
        return float2.Unpack(framebufferSize) / float2.Unpack(window.Size);
    }

    private static float GetContentScaleForMonitor(GlfwMonitor monitor)
    {
        if (OperatingSystem.IsMacOS())
        {
            return 1.0f;
        }

        return monitor.ContentScale.X;
    }

    private static ImGuiKey Convert(GlfwKey key)
    {
        return key switch
        {
            GlfwKey.Tab => ImGuiKey.Tab,
            GlfwKey.Left => ImGuiKey.LeftArrow,
            GlfwKey.Right => ImGuiKey.RightArrow,
            GlfwKey.Up => ImGuiKey.UpArrow,
            GlfwKey.Down => ImGuiKey.DownArrow,
            GlfwKey.PageUp => ImGuiKey.PageUp,
            GlfwKey.PageDown => ImGuiKey.PageDown,
            GlfwKey.Home => ImGuiKey.Home,
            GlfwKey.End => ImGuiKey.End,
            GlfwKey.Insert => ImGuiKey.Insert,
            GlfwKey.Delete => ImGuiKey.Delete,
            GlfwKey.Backspace => ImGuiKey.Backspace,
            GlfwKey.Space => ImGuiKey.Space,
            GlfwKey.Enter => ImGuiKey.Enter,
            GlfwKey.Escape => ImGuiKey.Escape,
            GlfwKey.Apostrophe => ImGuiKey.Apostrophe,
            GlfwKey.Comma => ImGuiKey.Comma,
            GlfwKey.Minus => ImGuiKey.Minus,
            GlfwKey.Period => ImGuiKey.Period,
            GlfwKey.Slash => ImGuiKey.Slash,
            GlfwKey.Semicolon => ImGuiKey.Semicolon,
            GlfwKey.Equal => ImGuiKey.Equal,
            GlfwKey.LeftBracket => ImGuiKey.LeftBracket,
            GlfwKey.Backslash => ImGuiKey.Backslash,
            GlfwKey.World1 => ImGuiKey.Oem102,
            GlfwKey.World2 => ImGuiKey.Oem102,
            GlfwKey.RightBracket => ImGuiKey.RightBracket,
            GlfwKey.GraveAccent => ImGuiKey.GraveAccent,
            GlfwKey.CapsLock => ImGuiKey.CapsLock,
            GlfwKey.ScrollLock => ImGuiKey.ScrollLock,
            GlfwKey.NumLock => ImGuiKey.NumLock,
            GlfwKey.PrintScreen => ImGuiKey.PrintScreen,
            GlfwKey.Pause => ImGuiKey.Pause,
            GlfwKey.Kp0 => ImGuiKey.Keypad0,
            GlfwKey.Kp1 => ImGuiKey.Keypad1,
            GlfwKey.Kp2 => ImGuiKey.Keypad2,
            GlfwKey.Kp3 => ImGuiKey.Keypad3,
            GlfwKey.Kp4 => ImGuiKey.Keypad4,
            GlfwKey.Kp5 => ImGuiKey.Keypad5,
            GlfwKey.Kp6 => ImGuiKey.Keypad6,
            GlfwKey.Kp7 => ImGuiKey.Keypad7,
            GlfwKey.Kp8 => ImGuiKey.Keypad8,
            GlfwKey.Kp9 => ImGuiKey.Keypad9,
            GlfwKey.KpDecimal => ImGuiKey.KeypadDecimal,
            GlfwKey.KpDivide => ImGuiKey.KeypadDivide,
            GlfwKey.KpMultiply => ImGuiKey.KeypadMultiply,
            GlfwKey.KpSubtract => ImGuiKey.KeypadSubtract,
            GlfwKey.KpAdd => ImGuiKey.KeypadAdd,
            GlfwKey.KpEnter => ImGuiKey.KeypadEnter,
            GlfwKey.KpEqual => ImGuiKey.KeypadEqual,
            GlfwKey.LeftShift => ImGuiKey.LeftShift,
            GlfwKey.LeftControl => ImGuiKey.LeftCtrl,
            GlfwKey.LeftAlt => ImGuiKey.LeftAlt,
            GlfwKey.LeftSuper => ImGuiKey.LeftSuper,
            GlfwKey.RightShift => ImGuiKey.RightShift,
            GlfwKey.RightControl => ImGuiKey.RightCtrl,
            GlfwKey.RightAlt => ImGuiKey.RightAlt,
            GlfwKey.RightSuper => ImGuiKey.RightSuper,
            GlfwKey.Menu => ImGuiKey.Menu,
            GlfwKey.Number0 => ImGuiKey._0,
            GlfwKey.Number1 => ImGuiKey._1,
            GlfwKey.Number2 => ImGuiKey._2,
            GlfwKey.Number3 => ImGuiKey._3,
            GlfwKey.Number4 => ImGuiKey._4,
            GlfwKey.Number5 => ImGuiKey._5,
            GlfwKey.Number6 => ImGuiKey._6,
            GlfwKey.Number7 => ImGuiKey._7,
            GlfwKey.Number8 => ImGuiKey._8,
            GlfwKey.Number9 => ImGuiKey._9,
            GlfwKey.A => ImGuiKey.A,
            GlfwKey.B => ImGuiKey.B,
            GlfwKey.C => ImGuiKey.C,
            GlfwKey.D => ImGuiKey.D,
            GlfwKey.E => ImGuiKey.E,
            GlfwKey.F => ImGuiKey.F,
            GlfwKey.G => ImGuiKey.G,
            GlfwKey.H => ImGuiKey.H,
            GlfwKey.I => ImGuiKey.I,
            GlfwKey.J => ImGuiKey.J,
            GlfwKey.K => ImGuiKey.K,
            GlfwKey.L => ImGuiKey.L,
            GlfwKey.M => ImGuiKey.M,
            GlfwKey.N => ImGuiKey.N,
            GlfwKey.O => ImGuiKey.O,
            GlfwKey.P => ImGuiKey.P,
            GlfwKey.Q => ImGuiKey.Q,
            GlfwKey.R => ImGuiKey.R,
            GlfwKey.S => ImGuiKey.S,
            GlfwKey.T => ImGuiKey.T,
            GlfwKey.U => ImGuiKey.U,
            GlfwKey.V => ImGuiKey.V,
            GlfwKey.W => ImGuiKey.W,
            GlfwKey.X => ImGuiKey.X,
            GlfwKey.Y => ImGuiKey.Y,
            GlfwKey.Z => ImGuiKey.Z,
            GlfwKey.F1 => ImGuiKey.F1,
            GlfwKey.F2 => ImGuiKey.F2,
            GlfwKey.F3 => ImGuiKey.F3,
            GlfwKey.F4 => ImGuiKey.F4,
            GlfwKey.F5 => ImGuiKey.F5,
            GlfwKey.F6 => ImGuiKey.F6,
            GlfwKey.F7 => ImGuiKey.F7,
            GlfwKey.F8 => ImGuiKey.F8,
            GlfwKey.F9 => ImGuiKey.F9,
            GlfwKey.F10 => ImGuiKey.F10,
            GlfwKey.F11 => ImGuiKey.F11,
            GlfwKey.F12 => ImGuiKey.F12,
            GlfwKey.F13 => ImGuiKey.F13,
            GlfwKey.F14 => ImGuiKey.F14,
            GlfwKey.F15 => ImGuiKey.F15,
            GlfwKey.F16 => ImGuiKey.F16,
            GlfwKey.F17 => ImGuiKey.F17,
            GlfwKey.F18 => ImGuiKey.F18,
            GlfwKey.F19 => ImGuiKey.F19,
            GlfwKey.F20 => ImGuiKey.F20,
            GlfwKey.F21 => ImGuiKey.F21,
            GlfwKey.F22 => ImGuiKey.F22,
            GlfwKey.F23 => ImGuiKey.F23,
            GlfwKey.F24 => ImGuiKey.F24,
            _ => ImGuiKey.None,
        };
    }

#if FALSE
    private const string CharNames = "`-=[]\\,;\'./";
    private static readonly GlfwKey[] CharKeys =
    [
        GlfwKey.GraveAccent,
        GlfwKey.Minus,
        GlfwKey.Equal,
        GlfwKey.LeftBracket,
        GlfwKey.RightBracket,
        GlfwKey.Backslash,
        GlfwKey.Comma,
        GlfwKey.Semicolon,
        GlfwKey.Apostrophe,
        GlfwKey.Period,
        GlfwKey.Slash,
        0,
    ];
#endif

    private static GlfwKey TranslateUntranslatedKey(GlfwKey key, int scancode)
    {
#if FALSE
        // TODO: With our current Glfw C# wrapper we can't perform this conversion without undue heap allocation. Consider whether we want to support this translation and reimplement as required.
        // GLFW 3.1+ attempts to "untranslate" keys, which goes the opposite of what every other framework does, making using lettered shortcuts difficult.
        // (It had reasons to do so: namely GLFW is/was more likely to be used for WASD-type game controls rather than lettered shortcuts, but IHMO the 3.1 change could have been done differently)
        // See https://github.com/glfw/glfw/issues/1502 for details.
        // Adding a workaround to undo this (so our keys are translated->untranslated->translated, likely a lossy process).
        // This won't cover edge cases but this is at least going to cover common cases.
        if (key is >= GlfwKey.Kp0 and <= GlfwKey.KpEqual)
            return key;

        // TODO: We can't currently 'temporarily suppress then eat' Glfw errors like this
        // var prevErrorCallback = glfwSetErrorCallback(nullptr);
        var keyName = Glfw.GetKeyName(key, scancode); // TODO: Returns string, not appropriate here
        // glfwSetErrorCallback(prev_error_callback);
        // (void)glfwGetError(nullptr);

        if (keyName.Length is 1)
        {
            var keyChar = keyName[0];
            if (keyChar is >= '0' and <= '9')
            {
                key = GlfwKey.Number0 + (keyChar - '0');
            }
            else if (keyChar is >= 'A' and <= 'Z')
            {
                key = GlfwKey.A + (keyChar - 'A');
            }
            else if (keyChar is >= 'a' and <= 'z')
            {
                key = GlfwKey.A + (keyChar - 'a');
            }
            else
            {
                var index = CharNames.IndexOf(keyChar);
                if (index is not -1)
                    key = CharKeys[index];
            }
        }
#endif

        return key;
    }

    #region MultiViewport

    // Helper structure we store in the void* PlatformUserData field of each ImGuiViewport to easily retrieve our backend data.
    internal struct ViewportData
    {
        public nint Window;
        public bool WindowOwned;
        public int IgnoreWindowPosEventFrame;
        public int IgnoreWindowSizeEventFrame;
        public nint PrevWndProc;

        public GlfwWindow GetWindow()
        {
            return GCHandle.FromIntPtr(Window).Target as GlfwWindow
                ?? throw new InvalidOperationException("Invalid window handle");
        }
    }

    private static GlfwBackend GetBackend()
    {
        var handle = GCHandle.FromIntPtr(ImGui.GetIO().BackendPlatformUserData);
        if (handle.Target is not GlfwBackend backend)
            throw new Exception("ImGui platform backend is not a GlfwBackend.");
        return backend;
    }

    private unsafe void InitMultiViewportSupport()
    {
        // Register platform interface (will be coupled with a renderer interface)
        var platformIo = ImGui.GetPlatformIO();
        platformIo.Platform_CreateWindow = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void>)&CreateWindow;
        platformIo.Platform_DestroyWindow = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void>)&DestroyWindow;
        platformIo.Platform_ShowWindow = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void>)&ShowWindow;
        platformIo.Platform_SetWindowPos = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float2, void>)&SetWindowPos;
        platformIo.Platform_GetWindowPos = Interop.CreateTrampoline(&GetWindowPos, "GetWindowPos");
        platformIo.Platform_SetWindowSize = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float2, void>)&SetWindowSize;
        platformIo.Platform_GetWindowSize = Interop.CreateTrampoline(&GetWindowSize, "GetWindowSize");
        platformIo.Platform_GetWindowFramebufferScale = Interop.CreateTrampoline(
            &GetWindowFramebufferScale,
            "GetWindowFramebufferScale"
        );
        platformIo.Platform_SetWindowFocus = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void>)&SetWindowFocus;
        platformIo.Platform_GetWindowFocus = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, Bool8>)&GetWindowFocus;
        platformIo.Platform_GetWindowMinimized = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, Bool8>)&GetWindowMinimized;
        platformIo.Platform_SetWindowTitle = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, byte*, void>)&SetWindowTitle;
        platformIo.Platform_RenderWindow = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void*, void>)&RenderWindow;
        platformIo.Platform_SwapBuffers = (nint)(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, void*, void>)&SwapBuffers;
        platformIo.Platform_SetWindowAlpha = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float, void>)&SetWindowAlpha;
        platformIo.Platform_CreateVkSurface = (nint)
            (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, nint, nint, nint*, int>)&CreateVkSurface;

        // Register main window handle (which is owned by the main application, not by us)
        // This is mostly for simplicity and consistency, so that our code (e.g. mouse handling etc.) can use same logic for main and secondary viewports.
        var mainViewport = ImGui.GetMainViewport();

        var windowHandle = GCHandle.Alloc(_window);
        var viewportData = Mem.AllocAndCopy(
            new ViewportData
            {
                Window = (nint)windowHandle,
                WindowOwned = false,
                IgnoreWindowPosEventFrame = -1,
                IgnoreWindowSizeEventFrame = -1,
            }
        );
        mainViewport.PlatformUserData = (nint)viewportData;
    }

    private unsafe ImGuiViewportPtr GetViewport(GlfwWindow window)
    {
        return _windowData.TryGetValue(window, out var handle)
            ? ImGui.FindViewportByPlatformHandle((void*)handle.PlatformHandle)
            : null;
    }

    private void WindowCloseCallback(GlfwWindow window)
    {
        var viewport = GetViewport(window);
        if (viewport.IsNotNull())
            viewport.PlatformRequestClose = true;
    }

    // GLFW may dispatch window pos/size events after calling glfwSetWindowPos()/glfwSetWindowSize().
    // However: depending on the platform the callback may be invoked at different time:
    // - on Windows it appears to be called within the glfwSetWindowPos()/glfwSetWindowSize() call
    // - on Linux it is queued and invoked during glfwPollEvents()
    // Because the event doesn't always fire on glfwSetWindowXXX() we use a frame counter tag to only
    // ignore recent glfwSetWindowXXX() calls.
    private unsafe void WindowPosCallback(GlfwWindow window, int2 pos)
    {
        var viewport = GetViewport(window);
        if (viewport.IsNotNull())
        {
            var viewportData = (ViewportData*)viewport.PlatformUserData;
            if (viewportData is not null)
            {
                var ignoreEvent = ImGui.GetFrameCount() <= viewportData->IgnoreWindowPosEventFrame + 1;
                if (ignoreEvent)
                    return;
            }
            viewport.PlatformRequestMove = true;
        }
    }

    private unsafe void WindowSizeCallback(GlfwWindow window, int2 size)
    {
        var viewport = GetViewport(window);
        if (viewport.IsNotNull())
        {
            var viewportData = (ViewportData*)viewport.PlatformUserData;
            if (viewportData is not null)
            {
                var ignoreEvent = ImGui.GetFrameCount() <= viewportData->IgnoreWindowSizeEventFrame + 1;
                if (ignoreEvent)
                    return;
            }
            viewport.PlatformRequestResize = true;
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void CreateWindow(ImGuiViewportPtr viewport)
    {
        var backend = GetBackend();
        // Zero the allocation, then set the ignore-event counters to -1, the "nothing to ignore"
        // sentinel used by the reference backend; 0 would swallow real move/resize events on the
        // first frames (the ignore test is GetFrameCount() <= counter + 1).
        var viewportData = Mem.AllocZeroed<ViewportData>();
        viewportData.Value.IgnoreWindowPosEventFrame = -1;
        viewportData.Value.IgnoreWindowSizeEventFrame = -1;
        viewport.PlatformUserData = (nint)viewportData;

        // GLFW 3.2 unfortunately always set focus on glfwCreateWindow() if GLFW_VISIBLE is set, regardless of GLFW_FOCUSED
        // With GLFW 3.3, the hint GLFW_FOCUS_ON_SHOW fixes this problem
        Glfw.WindowHint(GlfwWindowHint.Visible, 0);
        Glfw.WindowHint(GlfwWindowHint.Focused, 0);
        Glfw.WindowHint(GlfwWindowHint.FocusOnShow, 0);
        Glfw.WindowHint(GlfwWindowHint.Decorated, viewport.Flags.HasFlag(ImGuiViewportFlags.NoDecoration) ? 0 : 1);
        Glfw.WindowHint(GlfwWindowHint.Floating, viewport.Flags.HasFlag(ImGuiViewportFlags.TopMost) ? 1 : 0);
        var shareWindow = backend._clientApi is ClientApi.OpenGL ? backend._window : null;
        var window = Glfw.CreateWindow(
            new GlfwWindow.CreateInfo
            {
                Size = new int2((int)viewport.Size.X, (int)viewport.Size.Y),
                Title = "",
                Share = shareWindow,
            }
        );

        viewportData.Value.Window = (nint)GCHandle.Alloc(window);
        viewportData.Value.WindowOwned = true;
        viewport.PlatformHandle = (nint)GCHandle.Alloc(window);
        backend._windowData.Add(window, new WindowData { PlatformHandle = viewport.PlatformHandle });

        if (OperatingSystem.IsWindows())
        {
            viewport.PlatformHandleRaw = GlfwInterop.GetWin32Window(window.NativeHandle);
            WindowsNative.SetPropA(
                viewport.PlatformHandleRaw,
                "IMGUI_BACKEND_DATA"u8,
                ImGui.GetIO().BackendPlatformUserData
            );
        }
        else if (OperatingSystem.IsMacOS())
        {
            viewport.PlatformHandleRaw = GlfwInterop.GetCocoaWindow(window.NativeHandle);
        }

        window.Position = new int2((int)viewport.Pos.X, (int)viewport.Pos.Y);

        // Install GLFW callbacks for secondary viewports
        window.OnFocus += backend._focusCallback;
        window.OnCursorEnter += backend._cursorEnterCallback;
        window.OnCursorPos += backend._cursorPosCallback;
        window.OnMouseButton += backend._mouseButtonCallback;
        window.OnScroll += backend._scrollCallback;
        window.OnKey += backend._keyCallback;
        window.OnChar += backend._charCallback;

        window.OnClose += backend._closeCallback;
        window.OnPosition += backend._posCallback;
        window.OnSize += backend._sizeCallback;

        if (backend._clientApi is ClientApi.OpenGL)
        {
            window.MakeContextCurrent();
            Glfw.SwapInterval(0);
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void DestroyWindow(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        if (viewportData is not null)
        {
            if (viewportData->WindowOwned)
            {
                var window = viewportData->GetWindow();

                // Release any keys that were pressed in the window being destroyed and are still held down,
                // because we will not receive any release events after window is destroyed.
                var backend = GetBackend();
                if (backend._windowData.TryGetValue(window, out var data))
                {
                    foreach (var key in data.OwnedKeys)
                    {
                        backend.OnKey(window, key, 0, GlfwKeyAction.Release, 0); // Later params are only used for main viewport, on which this function is never called.
                    }
                }

                // Remove callbacks
                window.OnFocus -= backend._focusCallback;
                window.OnCursorEnter -= backend._cursorEnterCallback;
                window.OnCursorPos -= backend._cursorPosCallback;
                window.OnMouseButton -= backend._mouseButtonCallback;
                window.OnScroll -= backend._scrollCallback;
                window.OnKey -= backend._keyCallback;
                window.OnChar -= backend._charCallback;
                window.OnClose -= backend._closeCallback;
                window.OnPosition -= backend._posCallback;
                window.OnSize -= backend._sizeCallback;

                window.Dispose();

                GCHandle.FromIntPtr(viewportData->Window).Free();
            }
            Mem.Free(viewportData);
        }

        if (viewport.PlatformHandle is not 0)
        {
            GCHandle.FromIntPtr(viewport.PlatformHandle).Free();
        }

        viewport.PlatformUserData = viewport.PlatformHandle = 0;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void ShowWindow(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;

        if (OperatingSystem.IsWindows())
        {
            // GLFW hack: Hide icon from task bar
            var hwnd = viewport.PlatformHandleRaw;
            if (viewport.Flags.HasFlag(ImGuiViewportFlags.NoTaskBarIcon))
            {
                var exStyle = WindowsNative.GetWindowLong(hwnd, WindowsNative.Constants.GWL_EXSTYLE);
                exStyle &= ~WindowsNative.Constants.WS_EX_APPWINDOW;
                exStyle |= WindowsNative.Constants.WS_EX_TOOLWINDOW;
                var windowLong = WindowsNative.SetWindowLong(hwnd, WindowsNative.Constants.GWL_EXSTYLE, exStyle);
            }

            // GLFW hack: install WndProc for mouse source event and WM_NCHITTEST message handler.
            WindowsNative.SetPropA(hwnd, "IMGUI_VIEWPORT"u8, (nint)viewport.Ptr);
            viewportData->PrevWndProc = WindowsNative.GetWindowLongPtrW(hwnd, WindowsNative.Constants.GWLP_WNDPROC);
            WindowsNative.SetWindowLongPtrW(
                hwnd,
                WindowsNative.Constants.GWLP_WNDPROC,
                (nint)WindowsNative.WndProcDelegate
            );
        }

        viewportData->GetWindow().Visible = true;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe float2 GetWindowPos(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        var pos = viewportData->GetWindow().Position;
        return new float2(pos.X, pos.Y);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SetWindowPos(ImGuiViewportPtr viewport, float2 pos)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        var window = viewportData->GetWindow();
        viewportData->IgnoreWindowPosEventFrame = ImGui.GetFrameCount();
        window.Position = new int2((int)pos.X, (int)pos.Y);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe float2 GetWindowSize(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        var window = viewportData->GetWindow();
        return new float2(window.Size.X, window.Size.Y);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SetWindowSize(ImGuiViewportPtr viewport, float2 size)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        viewportData->IgnoreWindowSizeEventFrame = ImGui.GetFrameCount();
        var window = viewportData->GetWindow();
        window.Size = new int2((int)size.X, (int)size.Y);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe float2 GetWindowFramebufferScale(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        var window = viewportData->GetWindow();
        return GetFramebufferScale(window);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SetWindowTitle(ImGuiViewportPtr viewport, byte* title)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        var window = viewportData->GetWindow();
        window.Title = Utf8.GetString(title);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SetWindowFocus(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        viewportData->GetWindow().Focus();
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe Bool8 GetWindowFocus(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        return viewportData->GetWindow().GetAttribute(GlfwWindowAttribute.Focused) is not 0;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe Bool8 GetWindowMinimized(ImGuiViewportPtr viewport)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        return viewportData->GetWindow().GetAttribute(GlfwWindowAttribute.Iconified) is not 0;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SetWindowAlpha(ImGuiViewportPtr viewport, float alpha)
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        viewportData->GetWindow().Opacity = alpha;
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void RenderWindow(ImGuiViewportPtr viewport, void* _)
    {
        var backend = GetBackend();
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        if (backend._clientApi is ClientApi.OpenGL)
            viewportData->GetWindow().MakeContextCurrent();
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static unsafe void SwapBuffers(ImGuiViewportPtr viewport, void* _)
    {
        var backend = GetBackend();
        var viewportData = (ViewportData*)viewport.PlatformUserData;
        if (backend._clientApi is ClientApi.OpenGL)
        {
            var window = viewportData->GetWindow();
            window.MakeContextCurrent();
            window.SwapBuffers();
        }
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    public static unsafe int CreateVkSurface(
        ImGuiViewportPtr viewport,
        nint vkInstance,
        nint allocator,
        nint* outVkSurface
    )
    {
        var viewportData = (ViewportData*)viewport.PlatformUserData;

        var handle = GCHandle.FromIntPtr(viewportData->Window);
        if (handle.Target is not GlfwWindow window)
            throw new Exception("Window handle is not a GlfwWindow");

        var result = Glfw.CreateWindowSurface(vkInstance, window, out var surface);
        *outVkSurface = (nint)surface;
        return result;
    }

    #endregion
}

internal static class GlfwExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe bool IsButtonPressed(this GlfwGamepadState state, GlfwGamepadButton button)
    {
        return state.Buttons[(int)button] is (byte)GlfwButtonAction.Press;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe float GetAxis(this GlfwGamepadState state, GlfwGamepadAxis axis)
    {
        return state.Axes[(int)axis];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsNull(this GlfwVidMode vidMode)
    {
        return vidMode.Width is 0
            && vidMode.Height is 0
            && vidMode.RedBits is 0
            && vidMode.GreenBits is 0
            && vidMode.BlueBits is 0
            && vidMode.RefreshRate is 0;
    }

    internal static GlfwWindow GetWindow(this ImGuiViewportPtr viewport)
    {
        var handle = GCHandle.FromIntPtr(viewport.PlatformHandle);
        return handle.Target as GlfwWindow ?? throw new InvalidOperationException("Invalid window handle");
    }
}
