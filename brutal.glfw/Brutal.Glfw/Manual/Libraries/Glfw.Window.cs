// Window reference
// https://www.glfw.org/docs/latest/group__window.html

using System.Runtime.InteropServices.Marshalling;

namespace Brutal.GlfwApi;

/// <summary>The function pointer type for window position callbacks</summary>
/// <param name="window">The window that was moved.</param>
/// <param name="pos">
///     The new coordinates, in screen coordinates, of the upper-left corner of the client area of the
///     window.
/// </param>
/// <seealso cref="GlfwWindow.OnPosition" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_pos">Window position</seealso>
public delegate void GlfwWindowPosCallback(GlfwWindow window, int2 pos);

/// <summary>The function pointer type for window size callbacks</summary>
/// <param name="window">The window that was resized.</param>
/// <param name="size">The new size, in screen coordinates, of the window.</param>
/// <seealso cref="GlfwWindow.OnSize" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_size">Window size</seealso>
public delegate void GlfwWindowSizeCallback(GlfwWindow window, int2 size);

/// <summary>The function pointer type for window close callbacks</summary>
/// <param name="window">The window that the user attempted to close.</param>
/// <seealso cref="GlfwWindow.OnClose" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_close">Window closing and close flag</seealso>
public delegate void GlfwWindowCloseCallback(GlfwWindow window);

/// <summary>The function pointer type for window content refresh callbacks</summary>
/// <param name="window">The window whose content needs to be refreshed.</param>
/// <seealso cref="GlfwWindow.OnRefresh" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_refresh">Window damage and refresh</seealso>
public delegate void GlfwWindowRefreshCallback(GlfwWindow window);

/// <summary>The function pointer type for window focus callbacks</summary>
/// <param name="window">The window that gained or lost input focus.</param>
/// <param name="focusEvent">Enumerator describing the focus event.</param>
/// <seealso cref="GlfwWindow.OnFocus" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_focus">Window input focus</seealso>
public delegate void GlfwWindowFocusCallback(GlfwWindow window, GlfwFocusEvent focusEvent);

/// <summary>The function pointer type for window iconify callbacks</summary>
/// <param name="window">The window that was iconified or restored.</param>
/// <param name="iconifyEvent">Enumerator describing the iconify event.</param>
/// <seealso cref="GlfwWindow.OnIconify" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_iconify">Window iconification</seealso>
public delegate void GlfwWindowIconifyCallback(GlfwWindow window, GlfwIconifyEvent iconifyEvent);

/// <summary>The function pointer type for window maximize callbacks</summary>
/// <param name="window">The window that was maximized or restored.</param>
/// <param name="maximizeEvent">Enumerator describing the maximize event.</param>
/// <seealso cref="GlfwWindow.OnMaximize" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_maximize">Window maximization</seealso>
public delegate void GlfwWindowMaximizeCallback(GlfwWindow window, GlfwMaximizeEvent maximizeEvent);

/// <summary>The function pointer type for framebuffer size callbacks</summary>
/// <param name="window">The window whose framebuffer was resized.</param>
/// <param name="size">The new size, in pixels, of the framebuffer.</param>
/// <seealso cref="GlfwWindow.OnFramebufferSize" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_fbsize">Framebuffer size</seealso>
public delegate void GlfwFramebufferSizeCallback(GlfwWindow window, int2 size);

/// <summary>The function pointer type for window content scale callbacks</summary>
/// <param name="window">The window whose content scale changed.</param>
/// <param name="scale">The new content scale of the window.</param>
/// <seealso cref="GlfwWindow.OnContentScale" />
/// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_scale">Window content scale</seealso>
public delegate void GlfwWindowContentScaleCallback(GlfwWindow window, float2 scale);

public static partial class Glfw
{
    /// <summary>Creates a window and its associated context.</summary>
    /// <returns>The handle of the created window, or <c>null</c> if an error occurred.</returns>
    /// <remarks>
    ///     This function creates a window and its associated OpenGL or OpenGL ES context. Most of the options controlling
    ///     how the window and its context should be created are specified with
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_hints">window hints</see>.
    ///     <para />
    ///     Successful creation does not change which context is current. Before you can use the nely created context, you need
    ///     to <see href="https://www.glfw.org/docs/latest/context_guide.html#context_current">make it current</see>. For
    ///     information about the share parameter, see
    ///     <see href="https://www.glfw.org/docs/latest/context_guide.html#context_sharing">Context object sharing</see>.
    ///     <para />
    ///     The created window, framebuffer and context may differ from what you requested, as not all parameters and hints are
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_hints_hard">hard constraints</see>. This includes
    ///     the
    ///     size of the window, especially for full screen windows. To query the actual attributes of the created window,
    ///     framebuffer
    ///     and context, see <see cref="GlfwWindow.GetAttribute(Brutal.GlfwApi.GlfwWindowAttribute)">GlfwWindow.GetAttribute</see>,
    ///     <see cref="GlfwWindow.Size">GlfwWindow.Size</see> and <see cref="GlfwWindow.FramebufferSize">GlfwWindow.FramebufferSize</see>.
    ///     <para />
    ///     To create a full screen window, you need to specify the monitor the window will cover. If no monitor is specified,
    ///     the window will be windowed mode. Unless you have a way for the user to choose a specific monitor, it is
    ///     recommended
    ///     you pick the primary monitor. For more information on how to query connected monitors, see
    ///     <see href="https://www.glfw.org/docs/latest/monitor_guide.html#monitor_monitors">Retrieving monitors</see>.
    ///     <para />
    ///     For full screen windows, the specified size becomes the resolution of the window's <i>desired video mode</i>. As
    ///     long as the full screen window is not iconified, the supported video mode most closely matching the desired video
    ///     mode
    ///     is set for the specified monitor. For more information about full screen windows, including the creation of so
    ///     called
    ///     <i>windowed full screen</i> or <i>borderless full screen</i> windows, see
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_windowed_full_screen">
    ///         "Windowed full screen"
    ///         windows
    ///     </see>
    ///     .
    ///     <para />
    ///     Once you have created the window, you can switch it between windowed and full screen mode with
    ///     <see cref="GlfwWindow.SetWindowed">GlfwWindow.SetWindowed</see>
    ///     and <see cref="GlfwWindow.SetFullscreen">GlfwWindow.SetFullscreen</see>. This will not affect its OpenGL or OpenGL ES context.
    ///     <para />
    ///     By default, newly created windows uses the placement recommended by the window system. To create the window at a
    ///     specified position, make it initially invisible using the <see cref="GlfwWindowHint.Visible" /> window hint, set
    ///     its <see href="https://www.glfw.org/docs/latest/window_guide.html#window_pos">position</see> and then
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_hide">show</see> it.
    ///     <para />
    ///     As long as at least once full screen window is not iconified, the screensaver is prohibited from starting.
    ///     <para />
    ///     Window systems put limits on window sizes. Very large or very small window dimensions may be overridden by the
    ///     window
    ///     system on creation. Check the actual
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_size">size</see>
    ///     after creation.
    ///     <para />
    ///     The <see href="https://www.glfw.org/docs/latest/window_guide.html#buffer_swap">swap interval</see> is not set during
    ///     window creation and the initial value may vary depending on driver settings and defaults.
    /// </remarks>
    /// <windows>
    ///     <list type="bullet">
    ///         <item>Window creation will fail if the Microsoft GDI software OpenGL implementation is the only one available.</item>
    ///         <item>
    ///             If the executable has an icon resource named <c>GLFW_ICON</c>, it will be set as the initial icon for the
    ///             window.
    ///             If no such icon is present, the <c>IDE_APPLICATION</c> icon will be used instead. To set a different icon,
    ///             see
    ///             <see cref="GlfwWindow.SetIcon">GlfwWindow.SetIcon</see>.
    ///         </item>
    ///         <item>The context to share resources must not be current on any other thread.</item>
    ///     </list>
    /// </windows>
    /// <macOS>
    ///     <list type="bullet">
    ///         <item>
    ///             The OS only supports forward-compatible core profile contexts for OpenGL versions 3.2 and later. Before
    ///             creating an OpenGL context of version 3.2 or later you must set the
    ///             <see cref="GlfwContextAttribute.OpenGlForwardCompat" />
    ///             and <see cref="GlfwContextAttribute.OpenGlProfile" /> hints accordingly. OpenGL 3.0 and 3.1 contexts are
    ///             not supported
    ///             at all on macOS.
    ///         </item>
    ///         <item>
    ///             The GLFW window has no icon, as it is not a document window, but the dock icon will be the same as the
    ///             application bundle's icon. For more information on bundles, see the
    ///             <see
    ///                 href="https://developer.apple.com/library/archive/documentation/CoreFoundation/Conceptual/CFBundles/Introduction/Introduction.html">
    ///                 Bundle
    ///                 Programming Guide
    ///             </see>
    ///             in the Mac Developer Library.
    ///         </item>
    ///         <item>
    ///             The first time a window is created the menu bar is created. If GLFW finds a <c>MainMenu.nib</c> it is
    ///             loaded and assumed to contain a menu bar. Otherwise a minimal menu bar is created manually with common
    ///             commands like
    ///             Hide, Quit and About. The About entry opens a minimal about dialog with information from the application's
    ///             bundle.
    ///             Menu bar creation can be disabled entirely with the <see cref="GlfwInitHint.CocoaMenubar" /> init hint.
    ///         </item>
    ///         <item>
    ///             On OS X 10.10 and later the window frame will not be rendered at full resolution on Retina displays
    ///             unless the <see cref="GlfwWindowHint.CocoaRetinaFramebuffer" /> hint is true and the
    ///             <c>NSHighResolutionCapable</c>
    ///             key is enabled in the application bundle's <c>Info.plist</c>. For more information, see
    ///             <see
    ///                 href="https://developer.apple.com/library/archive/documentation/GraphicsAnimation/Conceptual/HighResolutionOSX/Explained/Explained.html">
    ///                 High
    ///                 Resolution Guidelines for OS X
    ///             </see>
    ///             in the Mac Developer Library. The GLFW test and example programs use a custom <c>Info.plist</c> template
    ///             for this,
    ///             which can be found as <c>CMake/MacOSXBundleInfo.plist.in</c> in the source tree.
    ///         </item>
    ///         <item>
    ///             When activating frame autosaving with <see cref="GlfwWindowHint.CocoaFrameName" />, the specified window
    ///             size and position may be overridden by previously saved values.
    ///         </item>
    ///     </list>
    /// </macOS>
    /// <x11>
    ///     <list type="bullet">
    ///         <item>Some window managers will not respect the placement of initially hidden windows.</item>
    ///         <item>
    ///             Due to the asynchronous nature of X1, it may take a moment for a window to reach its requested
    ///             state. This means you may not be able to query the final size, position or other attributes directly after
    ///             window creation.
    ///         </item>
    ///         <item>
    ///             The class part of the <c>WM_CLASS</c> window property will by default be set to the window title
    ///             passed to this function. The instance part will use the contents of the <c>RESOURCE_NAME</c> environment
    ///             variable,
    ///             if present and not empty, or fall back to the window title. Set the
    ///             <see cref="GlfwWindowHint.X11ClassName" />
    ///             and <see cref="GlfwWindowHint.X11InstanceName" /> window hints to override this.
    ///         </item>
    ///     </list>
    /// </x11>
    /// <wayland>
    ///     <list type="bullet">
    ///         <item>
    ///             Compositors should implement the xdg-decoration protocol for GLFW to decorate the window properly.
    ///             If this protocol isn't supported, or if the compositor prefers client-side decorations, a very simple
    ///             fallback
    ///             frame will be drawn using the wp_viewporter protocol. A compositor can still emit close, maximize or
    ///             fullscreen events, using
    ///             for instance a keybind mechanism.
    ///         </item>
    ///         <item>
    ///             A full screen window will not attempt to change the mode, no matter what the requested size or
    ///             refresh rate.
    ///         </item>
    ///         <item>Screensaver inhibition requires the idle-inhibit protocol to be implemented in the user's compositor.</item>
    ///     </list>
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.InvalidEnum" />,
    ///     <see cref="GlfwErrorCode.InvalidValue" />,
    ///     <see cref="GlfwErrorCode.ApiUnavailable" />,
    ///     <see cref="GlfwErrorCode.VersionUnavailable" />,
    ///     <see cref="GlfwErrorCode.FormatUnavailable" />,
    ///     <see cref="GlfwErrorCode.NoWindowContext" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="GlfwWindow.Dispose">GlfwWindow.Dispose</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_creation">Window creation</seealso>
    public static GlfwWindow CreateWindow(in GlfwWindow.CreateInfo info)
    {
        return new GlfwWindow(info);
    }

    /// <summary>Processes all pending events.</summary>
    /// <remarks>
    ///     This function processes only those events that are already in the event queue and then returns immediately.
    ///     Processing events will cause the window and input callbacks associated with those events to be called.
    ///     <para />
    ///     On some platforms, a window move, resize or menu operation will cause event processing to block. This is due to
    ///     how event processing is designed on those platforms. You can use the
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_refresh">window refresh callback</see> to
    ///     redraw the contents of your window when necessary during such operations.
    ///     <para />
    ///     Do not assume that callbacks you set will <i>only</i> be called in response to event processing functions like this
    ///     one. While it is necessary to poll for events, window systems that require GLFW to register callbacks of its own
    ///     can
    ///     pass events to GLFW in response to many window system function calls. GLFW will pass those events on to the
    ///     application
    ///     callbacks before returning.
    ///     <para />
    ///     Event processing is not required for joystick input to work.
    /// </remarks>
    /// <reentrancy>This function must not be called from a callback.</reentrancy>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="WaitEvents">Glfw.WaitEvents</seealso>
    /// <seealso cref="WaitEventsTimeout">Glfw.WaitEventsTimeout</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#events">Event processing</seealso>
    public static void PollEvents()
    {
        PInvoke.PollEvents();
        ExceptionAggregator.CheckExceptions();
    }
}

/// <summary>
///     A window created by the GLFW library.
/// </summary>
[NativeMarshalling(typeof(GlfwWindowMarshaller))]
public sealed unsafe partial class GlfwWindow : IDisposable, INullable
{
    /// <summary>
    /// Details for creating a <see cref="GlfwWindow" />.
    /// </summary>
    public struct CreateInfo
    {
        /// <summary>
        /// The title of the window.
        /// </summary>
        public required string Title;

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        public required int2 Size;

        /// <summary>
        /// The monitor to use for full screen windows.
        /// </summary>
        public GlfwMonitor Monitor;

        /// <summary>
        /// A window to share resources with.
        /// </summary>
        public GlfwWindow? Share;
    }

    internal GlfwWindowHandle* Pointer { get; private set; }
    private readonly GCHandle[] _callbackHandles;

    internal GlfwWindow(CreateInfo info)
    {
        Pointer = Glfw.PInvoke.CreateWindow(
            info.Size.X,
            info.Size.Y,
            info.Title,
            info.Monitor,
            info.Share is null ? null : info.Share.Pointer
        );

        if (Pointer is null)
        {
            var errorCode = Glfw.GetError(out var errorDescription);
            var message =
                errorCode == GlfwErrorCode.NoError
                    ? "Failed to create window."
                    : $"Failed to create window: {errorCode} ({errorDescription}).";
            throw new InvalidOperationException(message);
        }

        _title = info.Title;
        _size = info.Size;
        _monitor = info.Monitor;

        GlfwWindowSizeUnmanagedCallback onWindowSize = (_, width, height) =>
        {
            try
            {
                _size = new int2(width, height);
                OnSize?.Invoke(this, _size);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnSize callback", ex);
            }
        };
        GlfwWindowRefreshUnmanagedCallback onRefresh = _ =>
        {
            try
            {
                Refresh();
                OnRefresh?.Invoke(this);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnRefresh callback", ex);
            }
        };
        GlfwWindowPosUnmanagedCallback onPosition = (_, xPos, yPos) =>
        {
            try
            {
                _position = new int2(xPos, yPos);
                OnPosition?.Invoke(this, _position);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnPosition", ex);
            }
        };
        GlfwWindowMaximizeUnmanagedCallback onMaximize = (_, maximizedEvent) =>
        {
            try
            {
                _isMaximised = maximizedEvent != GLFW_FALSE;
                OnMaximize?.Invoke(this, (GlfwMaximizeEvent)maximizedEvent);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnMaximize callback", ex);
            }
        };
        GlfwWindowIconifyUnmanagedCallback onIconify = (_, iconifiedEvent) =>
        {
            try
            {
                _isIconified = iconifiedEvent != GLFW_FALSE;
                OnIconify?.Invoke(this, (GlfwIconifyEvent)iconifiedEvent);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnIconify callback", ex);
            }
        };
        GlfwWindowFocusUnmanagedCallback onFocus = (_, focusEvent) =>
        {
            try
            {
                _isFocused = focusEvent != GLFW_FALSE;
                OnFocus?.Invoke(this, (GlfwFocusEvent)focusEvent);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnFocus callback", ex);
            }
        };
        GlfwWindowContentScaleUnmanagedCallback onContentScale = (_, xScale, yScale) =>
        {
            try
            {
                _contentScale = new float2(xScale, yScale);
                OnContentScale?.Invoke(this, _contentScale);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnContentScale callback", ex);
            }
        };
        GlfwWindowCloseUnmanagedCallback onClose = _ =>
        {
            try
            {
                _shouldClose = true;
                OnClose?.Invoke(this);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnClose callback", ex);
            }
        };
        GlfwScrollUnmanagedCallback onScroll = (_, xOffset, yOffset) =>
        {
            try
            {
                OnScroll?.Invoke(this, new double2(xOffset, yOffset));
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnScroll callback", ex);
            }
        };
        GlfwScrollDetailUnmanagedCallback onScrollDetail = (_, xOffset, yOffset, flags) =>
        {
            try
            {
                OnScrollDetail?.Invoke(this, new double2(xOffset, yOffset), (GlfwScrollFlags)flags);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnScrollDetail callback", ex);
            }
        };
        GlfwTrackpadZoomUnmanagedCallback onTrackpadZoom = (_, scale) =>
        {
            try
            {
                OnTrackpadZoom?.Invoke(this, scale);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnTrackpadZoom callback", ex);
            }
        };
        GlfwTrackpadRotateUnmanagedCallback onTrackpadRotate = (_, angle) =>
        {
            try
            {
                OnTrackpadRotate?.Invoke(this, angle);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnTrackpadRotate callback", ex);
            }
        };
        GlfwMouseButtonUnmanagedCallback onMouseButton = (_, button, action, mods) =>
        {
            try
            {
                OnMouseButton?.Invoke(this, (GlfwMouseButton)button, (GlfwButtonAction)action, (GlfwModifier)mods);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnMouseButton callback", ex);
            }
        };
        GlfwKeyUnmanagedCallback onKey = (_, key, scanCode, action, mods) =>
        {
            try
            {
                OnKey?.Invoke(this, (GlfwKey)key, scanCode, (GlfwKeyAction)action, (GlfwModifier)mods);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnKey callback", ex);
            }
        };
        GlfwFramebufferSizeUnmanagedCallback onFramebufferSize = (_, width, height) =>
        {
            try
            {
                _framebufferSize = new int2(width, height);
                OnFramebufferSize?.Invoke(this, _framebufferSize);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnFramebufferSize callback", ex);
            }
        };
        GlfwCursorPosUnmanagedCallback onCursorPos = (_, xPos, yPos) =>
        {
            try
            {
                _cursorPos = new double2(xPos, yPos);
                OnCursorPos?.Invoke(this, _cursorPos);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnCursorPos callback", ex);
            }
        };
        GlfwCursorEnterUnmanagedCallback onCursorEnter = (_, enteredEvent) =>
        {
            try
            {
                OnCursorEnter?.Invoke(this, enteredEvent != GLFW_FALSE);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnCursorEnter callback", ex);
            }
        };
        GlfwDropUnmanagedCallback onDrop = (_, count, paths) =>
        {
            try
            {
                if (OnDrop == null)
                    return;
                var pathArray = new string[count];
                for (var i = 0; i < count; i++)
                    pathArray[i] = Marshal.PtrToStringUTF8((nint)paths[i]) ?? string.Empty;
                OnDrop.Invoke(this, count, pathArray);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnDrop callback", ex);
            }
        };
        GlfwCharUnmanagedCallback onChar = (_, point) =>
        {
            try
            {
                OnChar?.Invoke(this, (char)point);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnChar callback", ex);
            }
        };
        GlfwCharModsUnmanagedCallback onCharMods = (_, point, mods) =>
        {
            try
            {
                OnCharMods?.Invoke(this, (char)point, (GlfwModifier)mods);
            }
            catch (Exception ex)
            {
                Glfw.ExceptionAggregator.Push("Error in Window.OnCharMods callback", ex);
            }
        };

        // pinning the callbacks to prevent them from being garbage collected
        _callbackHandles =
        [
            GCHandle.Alloc(onWindowSize),
            GCHandle.Alloc(onRefresh),
            GCHandle.Alloc(onPosition),
            GCHandle.Alloc(onMaximize),
            GCHandle.Alloc(onIconify),
            GCHandle.Alloc(onFocus),
            GCHandle.Alloc(onContentScale),
            GCHandle.Alloc(onClose),
            GCHandle.Alloc(onScroll),
            GCHandle.Alloc(onScrollDetail),
            GCHandle.Alloc(onTrackpadZoom),
            GCHandle.Alloc(onTrackpadRotate),
            GCHandle.Alloc(onMouseButton),
            GCHandle.Alloc(onKey),
            GCHandle.Alloc(onFramebufferSize),
            GCHandle.Alloc(onCursorPos),
            GCHandle.Alloc(onCursorEnter),
            GCHandle.Alloc(onDrop),
            GCHandle.Alloc(onChar),
            GCHandle.Alloc(onCharMods),
        ];

        Glfw.PInvoke.SetWindowSizeCallback(this, onWindowSize);
        Glfw.PInvoke.SetWindowRefreshCallback(this, onRefresh);
        Glfw.PInvoke.SetWindowPosCallback(this, onPosition);
        Glfw.PInvoke.SetWindowMaximizeCallback(this, onMaximize);
        Glfw.PInvoke.SetWindowIconifyCallback(this, onIconify);
        Glfw.PInvoke.SetWindowFocusCallback(this, onFocus);
        Glfw.PInvoke.SetWindowContentScaleCallback(this, onContentScale);
        Glfw.PInvoke.SetWindowCloseCallback(this, onClose);
        Glfw.PInvoke.SetScrollCallback(this, onScroll);
        Glfw.PInvoke.SetScrollDetailCallback(this, onScrollDetail);
        Glfw.PInvoke.SetTrackpadZoomCallback(this, onTrackpadZoom);
        Glfw.PInvoke.SetTrackpadRotateCallback(this, onTrackpadRotate);
        Glfw.PInvoke.SetMouseButtonCallback(this, onMouseButton);
        Glfw.PInvoke.SetKeyCallback(this, onKey);
        Glfw.PInvoke.SetFramebufferSizeCallback(this, onFramebufferSize);
        Glfw.PInvoke.SetCursorPosCallback(this, onCursorPos);
        Glfw.PInvoke.SetCursorEnterCallback(this, onCursorEnter);
        Glfw.PInvoke.SetDropCallback(this, onDrop);
        Glfw.PInvoke.SetCharCallback(this, onChar);
        Glfw.PInvoke.SetCharModsCallback(this, onCharMods);

        Refresh();
    }

    /// <summary>
    ///     Gets the native Glfw handle for this window
    /// </summary>
    public nint NativeHandle => (nint)Pointer;

    /// <summary>Sets/gets the title of the window</summary>
    /// <remarks>
    ///     This property gets/ssets the window title, encoded as UTF-8, of the window.
    /// </remarks>
    /// <threadSafety>This property must only be invoked from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_title">Window title</seealso>
    public string Title
    {
        get => _title;
        set
        {
            Glfw.PInvoke.SetWindowTitle(this, value);
            RefreshTitle();
        }
    }

    /// <summary>Gets/sets the position of the content area of the window</summary>
    /// <remarks>
    ///     This property gets/sets the position, in screen coordinates, of the upper-left corner of the content area of the
    ///     windowed mode window. If the window is a full screen window, this property does nothing.
    ///     <para />
    ///     <b>Do not use this property</b> to move an already visible window unless you have very good reasons for doing so,
    ///     as it will confuse and annoy the user.
    ///     <para />
    ///     The window manager may put limits on what positions are allowed. GLFW cannot and should not override these limits.
    /// </remarks>
    /// <wayland>
    ///     There is no way for an application to get/set the global position of its windows, this property will always emit
    ///     <see cref="GlfwErrorCode.PlatformError" />.
    /// </wayland>
    /// <threadSafety>This property must only be invoked from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_pos">Window position</seealso>
    public int2 Position
    {
        get => _position;
        set
        {
            if (value == _position)
                return;
            Glfw.PInvoke.SetWindowPos(this, value.X, value.Y);
        }
    }

    /// <summary>The X coordinate of the window's top-left corner, in screen coordinates.</summary>
    public int X
    {
        get => _position.X;
        set => Position = new int2(value, Y);
    }

    /// <summary>The Y coordinate of the window's top-left corner, in screen coordinates.</summary>
    public int Y
    {
        get => _position.Y;
        set => Position = new int2(X, value);
    }

    /// <summary>Retrieves the size of the content area of the window</summary>
    /// <remarks>
    ///     This function gets/sets the size, in screen coordinates, of the content area of the window. If you wish
    ///     to retrieve the size of the framebuffer of the window in pixels, see <see cref="FramebufferSize">GlfwWindow.FramebufferSize</see>.
    ///     <para />
    ///     For full screen windows, this function updates the resolution of its desired video mode and switches to the video
    ///     mode closest to it, without affecting the window's context. As the context is unaffected, the bit depths of the
    ///     framebuffer remain unchanged.
    ///     <para />
    ///     If you wish to update the refresh rate of the desired video mode in addition to its resolution, see
    ///     <see cref="SetFullscreen">GlfwWindow.SetFullscreen</see>.
    ///     <para />
    ///     The window manager may put limits on what sizes are allowed. GLFW cannot and should not override these limits.
    /// </remarks>
    /// <wayland>
    ///     A full screen window will not attempt to change the mode, no matter what the requested size.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="Size">GlfwWindow.Size</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_size">Window size</seealso>
    /// <summary>Sets the size of the content area of the window</summary>
    public int2 Size
    {
        get => _size;
        set
        {
            if (value == _size)
                return;
            Glfw.PInvoke.SetWindowSize(this, value.X, value.Y);
        }
    }

    /// <summary>The width of the window's content area, in screen coordinates.</summary>
    public int Width
    {
        get => _size.X;
        set => Size = new int2(value, Height);
    }

    /// <summary>The height of the window's content area, in screen coordinates.</summary>
    public int Height
    {
        get => _size.Y;
        set => Size = new int2(Width, value);
    }

    /// <summary>Retrieves the size of the framebuffer of the window</summary>
    /// <remarks>
    ///     This function retrieves the size, in pixels, of the framebuffer of the window. If you wish to retrieve
    ///     the size of the window in screen coordinates, see <see cref="Size">GlfwWindow.Size</see>.
    ///     <para />
    ///     Any or all of the size arguments may be <c>null</c>. If an error occurs, the values of the size arguments will
    ///     be set to zero.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_fbsize">Framebuffer size</seealso>
    public int2 FramebufferSize => _framebufferSize;

    /// <summary>Gets/sets the aspect ratio of the window</summary>
    /// <remarks>
    ///     This function sets the required aspect ratio of the content area of the window. If the window is full
    ///     screen, the aspect ratio only takes effect once it is made windowed. If the window is not resizable, this function
    ///     does nothing.
    ///     <para />
    ///     The aspect ratio is specified as a numerator and a denominator and both values must be greater than zero. For
    ///     example, the common 16:9 aspect ratio is specified as 16 and 9, respectively.
    ///     <para />
    ///     If the numerator and denominator is set to <see cref="GLFW_DONT_CARE" /> then the aspect ratio limit is
    ///     disabled.
    ///     <para />
    ///     The aspect ratio is applied immediately to a windowed mode window and may cause it to be resized.
    ///     <para />
    ///     If you set size limits and an aspect ratio that conflict, the results are undefined.
    /// </remarks>
    /// <wayland>
    ///     The aspect ratio will not be applied until the window is actually resized, either by the user or by the compositor.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.InvalidValue" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="SetSizeLimits">GlfwWindow.SetSizeLimits</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_sizelimits">Window size limits</seealso>
    public float AspectRatio
    {
        get => _framebufferSize.Y == 0 ? 0f : _framebufferSize.X / (float)_framebufferSize.Y;
        set
        {
            var numerator = (int)(_framebufferSize.Y * value);
            var denominator = _framebufferSize.Y;
            Glfw.PInvoke.SetWindowAspectRatio(this, numerator, denominator);
        }
    }

    /// <summary>Gets the content scale</summary>
    /// <remarks>
    ///     This function retrieves the content scale for the window. The content scale is the ratio between the
    ///     current DPI and the platform's default DPI. This is especially important for text and any UI elements. If the
    ///     pixel dimensions of your UI scaled by this look appropriate on your machine then it should appear at a reasonable
    ///     size on other machines regardless of their DPI and scaling settings. This relies on the system DPI and scaling
    ///     settings being somewhat correct.
    ///     <para />
    ///     ON systems where each monitors can have its own content scale, the window content scale will depend on which
    ///     monitor
    ///     the system considers the window to be on.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="ContentScale">GlfwMonitor.ContentScale</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_scale">Window content scale</seealso>
    public float2 ContentScale => _contentScale;

    /// <summary>Gets/sets the position of the cursor relative to the content area of the window.</summary>
    /// <remarks>
    ///     This function sets/gets the position of the cursor, in screen coordinates, relative to the upper-left corner of the
    ///     content area of the specified window.
    ///     <para />
    ///     The window must have input focus when setting this property. If the window does not have input focus
    ///     when this function is called, it fails silently.
    ///     <para />
    ///     If the cursor is <see cref="GlfwCursorMode.Disabled" /> then the cursor position is unbounded and limited only by
    ///     the minimum and maximum values of a double.
    ///     <para />
    ///     The coordinate can be converted to their integer equivalents with the <c>floor</c> function. Casting directly to an
    ///     integer type works for positive coordinates, but fails for negative ones.
    ///     <para />
    ///     If an error occurs, the returned position will be <c>0, 0</c>.
    ///     <para />
    ///     <b>Do not use this function</b> to implement things like camera controls. GLFW already provides the
    ///     <see cref="GlfwCursorMode.Disabled" /> cursor mode that hides the cursor, transparently re-centers it and provides
    ///     unconstrained cursor motion. See <see cref="SetInputMode">GlfwWindow.SetInputMode</see> for more information.
    ///     <para />
    ///     If the cursor mode is <see cref="GlfwCursorMode.Disabled" /> then the cursor position is unconstrained and limited
    ///     only by the minimum and maximum values of a <c>double</c>.
    /// </remarks>
    /// <param name="value">The desired position of the cursor, relative to the top-left edge of the content area.</param>
    /// <wayland>
    ///     This function will only work when the cursor mode is <see cref="GlfwCursorMode.Disabled" />, otherwise it will
    ///     do nothing.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_pos">Cursor position</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    public double2 CursorPos
    {
        get => _cursorPos;
        set
        {
            if (value == _cursorPos)
                return;
            Glfw.PInvoke.SetCursorPos(this, value.X, value.Y);
        }
    }

    /// <summary>The X coordinate of the cursor, relative to the top-left of the window's content area.</summary>
    public double CursorX
    {
        get => _cursorPos.X;
        set => CursorPos = new double2(value, CursorY);
    }

    /// <summary>The Y coordinate of the cursor, relative to the top-left of the window's content area.</summary>
    public double CursorY
    {
        get => _cursorPos.Y;
        set => CursorPos = new double2(CursorX, value);
    }

    /// <summary>Gets/sets the opacity of the whole window</summary>
    /// <remarks>
    ///     This function gets/sets the opacity of the window, including any decorations.
    ///     <para />
    ///     The opacity (or alpha) value is a positive finite number between zero and one, where zero is fully transparent and
    ///     one is fully opaque. If the system does not support whole window transparency, this function always returns one.
    ///     <para />
    ///     The initial opacity value for newly created windows is one.
    ///     <para />
    ///     The opacity (or alpha) value is a positive finite number between zero and one, where zero is fully transparent
    ///     and one is fully opaque. If the system does not support whole window transparency, this function always returns
    ///     one.
    ///     <para />
    ///     A window created with framebuffer transparency may not use whole window transparency. The results of doing this
    ///     are undefined.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="Opacity">GlfwWindow.Opacity</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_transparency">Window transparency</seealso>
    public float Opacity
    {
        get => _opacity;
        set
        {
            if (Math.Abs(value - _opacity) < 0.00001f)
                return;
            Glfw.PInvoke.SetWindowOpacity(this, value);
            RefreshOpacity();
        }
    }

    /// <summary>Returns the monitor that the window uses for full screen mode</summary>
    /// <remarks>
    ///     This function returns the handle of the monitor that the window is in full screen on.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso cref="SetFullscreen">GlfwWindow.SetFullscreen</seealso>
    /// <seealso cref="SetWindowed">GlfwWindow.SetWindowed</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_monitor">Window monitor</seealso>
    public GlfwMonitor Monitor
    {
        get => _monitor;
        set
        {
            if (value.Pointer == _monitor.Pointer)
                return;

            if (value.IsNull())
            {
                SetWindowed(Position, Size);
            }
            else
            {
                SetFullscreen(value, Size, GLFW_DONT_CARE);
            }
        }
    }

    private GlfwMonitor _monitor;

    /// <summary>True if the window is currently maximised to fill the available screen area.</summary>
    public bool IsMaximised => _isMaximised;

    /// <summary>True if the window is currently iconified (minimised) to the taskbar or dock.</summary>
    public bool IsIconified => _isIconified;

    /// <summary>True if the window currently has input focus.</summary>
    public bool IsFocused => _isFocused;

    /// <summary>True if the window is currently in full screen mode on a monitor.</summary>
    public bool IsFullscreen => Monitor.IsNotNull();

    /// <summary>True if the window is currently in windowed (non-full-screen) mode.</summary>
    public bool IsWindowed => !IsFullscreen;

    /// <summary>Checks/sets the close flag of the window</summary>
    /// <remarks>
    ///     Setting this can be used to override the user's attempt to close the window, or to signal that it should be closed.
    /// </remarks>
    /// <threadSafety>This function may be called from any thread. Access is not synchronized.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_close">Window closing and close flag</seealso>
    public bool ShouldClose
    {
        get => _shouldClose;
        set
        {
            if (value == _shouldClose)
                return;
            Glfw.PInvoke.SetWindowShouldClose(this, value ? GLFW_TRUE : GLFW_FALSE);
            _shouldClose = Glfw.PInvoke.WindowShouldClose(this) != GLFW_FALSE;
        }
    }

    /// <summary>Gets/sets the user pointer of the window</summary>
    /// <remarks>
    ///     This function returns the current value of the user-defined pointer of the window. The initial value is
    ///     <c>null</c>.
    /// </remarks>
    /// <threadSafety>This function may be called from any thread. Access is not synchronized.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_userptr">Window user pointer</seealso>
    /// <summary>Sets the user pointer of the window</summary>
    /// <remarks>
    ///     This function sets the user-defined pointer of the window. The current value is retained until the window
    ///     is destroyed. The initial value is <c>null</c>.
    /// </remarks>
    /// <threadSafety>This function may be called from any thread. Access is not synchronized.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_userptr">Window user pointer</seealso>
    public void* UserPointer
    {
        get => _userPointer;
        set
        {
            if (_userPointer == value)
                return;
            Glfw.PInvoke.SetWindowUserPointer(this, value);
            RefreshUserPointer();
        }
    }

    /// <summary>Makes the window visible/hidden</summary>
    /// <remarks>
    ///     This function makes the window visible/hidden if it was previously hidden/visible. If the window is already hidden/visible,
    ///     or is in full screen mode, this function does nothing.
    ///     <para />
    ///     By default, windowed mode windows are focused when shown. Set the <see cref="GlfwWindowHint.FocusOnShow" /> window
    ///     hint to change this behaviour for all newly created windows, or change the behaviour for an existing window with
    ///     <see cref="SetAttribute">GlfwWindow.SetAttribute</see>.
    /// </remarks>
    /// <wayland>
    ///     Because Wayland wants every frame of the desktop to be complete, this function does not immediately make the
    ///     window visible. Instead it will become visible the next time the window framebuffer is updated after this call.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_hide">Window visibility</seealso>
    public bool Visible
    {
        get => _isVisible;
        set
        {
            if (Visible == value)
                return;

            if (value)
                Glfw.PInvoke.ShowWindow(this);
            else
                Glfw.PInvoke.HideWindow(this);
            RefreshVisible();
        }
    }

    private string _title;
    private int2 _position;
    private int2 _size;
    private double2 _cursorPos;
    private int2 _framebufferSize;
    private float2 _contentScale;
    private bool _shouldClose;
    private bool _isMaximised;
    private bool _isIconified;
    private bool _isFocused;
    private bool _isVisible;
    private float _opacity;
    private void* _userPointer;

    /// <summary>Destroy the window and its context</summary>
    /// <remarks>
    ///     This function destroys the window and its context. On calling this function, no further callbacks will
    ///     be called for that
    ///     <para />
    ///     If the context of the window is current on the main thread, it is detached before being destroyed.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="GlfwWindow">GlfwWindow.GlfwWindow</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_creation">Window creation</seealso>
    public void Dispose()
    {
        if (Pointer != null)
        {
            Glfw.PInvoke.DestroyWindow(this);
            Pointer = null;
        }

        foreach (var handle in _callbackHandles)
        {
            if (handle.IsAllocated)
                handle.Free();
        }
    }

    /// <summary>Returns whether this window handle is null (uninitialised or already destroyed).</summary>
    /// <returns><c>true</c> if the underlying native handle is null; otherwise <c>false</c>.</returns>
    public bool IsNull()
    {
        return Pointer == null;
    }

    /// <summary>Sets the icon</summary>
    /// <remarks>
    ///     This function sets the icon of the window. If passed an array of candidate images, those of or closest
    ///     to the sizes desired by the system are selected. If no images are specified, the window reverts to its default
    ///     icon.
    ///     <para />
    ///     The pixels are 32-bit, little-endian, non-premultiplied RGBA, i.e. eight bits per channel with the red channel
    ///     first.
    ///     They are arranged canonically as packed sequential rows, starting from the top-left corner.
    ///     <para />
    ///     The desired image sizes varies depending on platform and system settings. The selected images will be rescaled as
    ///     needed. Good sizes include 16x16, 32x32, and 48x48.
    /// </remarks>
    /// <macOS>
    ///     The GLFW window has no icon, as it is a document window, so this function does nothing. The dock icon will be the
    ///     same as the application bundle's icon. For more information on bundles, see the
    ///     <see
    ///         href="https://developer.apple.com/library/archive/documentation/CoreFoundation/Conceptual/CFBundles/Introduction/Introduction.html">
    ///         Bundle
    ///         Programming Guide
    ///     </see>
    ///     in the Mac Developer Library.
    /// </macOS>
    /// <wayland>
    ///     There is no existing protocol to change an icon, the window will thus inherit the one defined in the application's
    ///     desktop file. This function always emits <see cref="GlfwErrorCode.PlatformError" />.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.InvalidValue" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_icon">Window icon</seealso>
    public void SetIcon(int count, GlfwImage image)
    {
        Glfw.PInvoke.SetWindowIcon(this, count, &image);
    }

    /// <summary>Set the size limits of the window</summary>
    /// <remarks>
    ///     This function sets the size limits of the content area of the window. If the window is full screen, the
    ///     size limits only take effect once it is made windowed. If the window is not resizable, this function does nothing.
    ///     <para />
    ///     The size limits are applied immediately to a windowed mode window and may cause it to be resized.
    ///     <para />
    ///     The maximum dimensions must be greater than or equal to the minimum dimensions and all must be greater than or
    ///     equal to zero.
    ///     <para />
    ///     If you set size limits and an aspect ratio that conflict, the results are undefined.
    ///     <wayland>
    ///         The size limits will not be applied until the window is actually resized, either by the user or by the
    ///         compositor.
    ///     </wayland>
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.InvalidValue" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="AspectRatio">GlfwWindow.AspectRatio</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_sizelimits">Window size limits</seealso>
    public void SetSizeLimits(int2 minSize, int2 maxSize)
    {
        Glfw.PInvoke.SetWindowSizeLimits(this, minSize.X, minSize.Y, maxSize.X, maxSize.Y);
    }

    /// <summary>Sets a window into full-screen mode</summary>
    /// <remarks>
    ///     This function sets the monitor that the window uses for full screen mode.
    ///     <para />
    ///     This function updates the width, height and refresh rate of the desired video mode and switches to the video mode
    ///     closest to it.
    ///     <para />
    ///     If you only wish to update the resolution of a full screen window, see <see cref="Size">GlfwWindow.Size</see>.
    ///     <para />
    /// </remarks>
    /// <openGL>
    ///     The OpenGL or OpenGL ES context will not be destroyed or otherwise affected by any resizing or mode switching,
    ///     although you may need to update your viewport if the framebuffer size has changed.
    /// </openGL>
    /// <wayland>
    ///     Setting the window to full screen will not attempt to change the mode, no matter what the requested size or
    ///     refresh rate.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="SetWindowed">GlfwWindow.SetWindowed</seealso>
    /// <seealso cref="Monitor">GlfwWindow.Monitor</seealso>
    /// <seealso cref="Size">GlfwWindow.Size</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_monitor">Window monitor</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_full_screen">Full screen windows</seealso>
    public void SetFullscreen(GlfwMonitor monitor, int2 size, int refreshRate)
    {
        if (monitor.IsNull())
            throw new ArgumentNullException(nameof(monitor));

        Glfw.PInvoke.SetWindowMonitor(this, monitor, 0, 0, size.X, size.Y, refreshRate);
        RefreshMonitor();
    }

    /// <summary>Sets the window into windowed mode</summary>
    /// <remarks>
    ///     This function sets the window into windowed mode.
    ///     <para />
    ///     The position, width and height are used to place the window content area.
    ///     <para />
    ///     If you only wish to update the size of a windowed window, see <see cref="Size">GlfwWindow.Size</see>.
    ///     <para />
    ///     When a window transitions from full screen to windowed mode, this function restores any previous window settings
    ///     such as whether it is decorated ,floating, resizable, has size or aspect ratio limits, etc.
    /// </remarks>
    /// <openGL>
    ///     The OpenGL or OpenGL ES context will not be destroyed or otherwise affected by any resizing or mode switching,
    ///     although you may need to update your viewport if the framebuffer size has changed.
    /// </openGL>
    /// <wayland>
    ///     The desired window position is ignored, as there is no way for an application to set this properly.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="SetFullscreen">GlfwWindow.SetFullscreen</seealso>
    /// <seealso cref="Monitor">GlfwWindow.GetMonitor</seealso>
    /// <seealso cref="Size">GlfwWindow.Size</seealso>
    public void SetWindowed(int2 pos, int2 size)
    {
        Glfw.PInvoke.SetWindowMonitor(this, default, pos.X, pos.Y, size.X, size.Y, 0);
        RefreshMonitor();
    }

    /// <summary>Returns an attribute of the window</summary>
    /// <remarks>
    ///     This function returns the value of an attribute of the window
    ///     <para />
    ///     Framebuffer related hints are not window attributes. See
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_attribs_fb">Framebuffer related attributes</see>
    ///     for more information.
    ///     <para />
    ///     Zero is a valid value for many windows related attributes so you cannot use a return value of zero as
    ///     indication of errors. However, this function should not fail as long as it passed valid arguments and the library
    ///     has been initialized.
    /// </remarks>
    /// <wayland>
    ///     The Wayland protocol provides no way to check whether a window is iconified, so
    ///     <see cref="GlfwWindowAttribute.Iconified" />
    ///     will always return zero.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.InvalidEnum" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="SetAttribute">GlfwWindow.SetAttribute</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_attribs">Window attributes</seealso>
    public int GetAttribute(GlfwWindowAttribute attribute)
    {
        return Glfw.PInvoke.GetWindowAttrib(this, (int)attribute);
    }

    /// <summary>Returns an attribute of the window's context</summary>
    /// <remarks>
    ///     This function returns the value of an attribute of the window's OpenGL or OpenGL ES context.
    ///     <para />
    ///     Framebuffer related hints are not window attributes. See
    ///     <see href="https://www.glfw.org/docs/latest/window_guide.html#window_attribs_fb">Framebuffer related attributes</see>
    ///     for more information.
    ///     <para />
    ///     Zero is a valid value for many context related attributes so you cannot use a return value of zero as
    ///     indication of errors. However, this function should not fail as long as it passed valid arguments and the library
    ///     has been initialized.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.InvalidEnum" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    /// <seealso cref="SetAttribute">GlfwWindow.SetAttribute</seealso>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_attribs">Window attributes</seealso>
    public int GetAttribute(GlfwContextAttribute attribute)
    {
        return Glfw.PInvoke.GetWindowAttrib(this, (int)attribute);
    }

    /// <summary>
    /// Blocks the calling thread, pumping events, until the window's framebuffer has a non-zero size.
    /// Useful for waiting out an iconified (minimised) state before resuming rendering.
    /// </summary>
    public void WaitForWindow()
    {
        while (true)
        {
            Glfw.PInvoke.WaitEvents();
            if (FramebufferSize is { X: > 0, Y: > 0 })
                break;
        }
    }

    /// <summary>
    ///     Centers the window to the specified monitor.
    /// </summary>
    public void CenterToMonitor(GlfwMonitor monitor)
    {
        var monitorSize = monitor.Size;
        var monitorPos = monitor.Position;

        Position = new int2(monitorPos.X + (monitorSize.X - Size.X) / 2, monitorPos.Y + (monitorSize.Y - Size.Y) / 2);
    }

    /// <summary>Sets the Unicode character callbacks</summary>
    /// <remarks>
    ///     This function sets the character callback of the window, which is called when a Unicode character is
    ///     input.
    ///     <para />
    ///     The character callback is intended for Unicode text input. As it deals with characters, it is keyboard layout
    ///     dependent, whereas the <see cref="GlfwKeyCallback">key callback</see> is not. Characters do not map 1:1 to physical
    ///     keys, as a key may produce zero, one or more characters. If you want to know whether a specific physical key was
    ///     pressed or released, see the key callback instead.
    ///     <para />
    ///     The character callback behaves as system text input normally does and will not be called if modifier keys are held
    ///     down that would prevent normal text input on that platform, for example a Super (Command) key on macOS or Alt key
    ///     on Windows.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_char">Text input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwCharCallback? OnChar;

    /// <summary>Sets the Unicode character with modifiers callbacks</summary>
    /// <remarks>
    ///     This function sets the character with modifiers callback of the window, which is called when a Unicode
    ///     character is input regardless of what modifier keys are used.
    ///     <para />
    ///     The character with modifiers callback is intended for implementing custom Unicode character input. For regular
    ///     Unicode text input, see the <see cref="GlfwCharCallback">character callback</see>. Like the character callback, the
    ///     character with modifiers callback deals with characters and is keyboard layout dependent. Characters do not map 1:1
    ///     to physical keys, as a key may produce zero, one or more characters. If you want to know whether a specific
    ///     physical key was pressed or released, see the <see cref="GlfwKeyCallback">key callback</see> instead.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_char">Text input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwCharModsCallback? OnCharMods;

    /// <summary>Sets the cursor enter/leave callback</summary>
    /// <remarks>
    ///     This function sets the cursor boundary crossing callback of the window, which is called when the cursor
    ///     enters or leaves the content area of the
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_enter">Cursor enter/leave events</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwCursorEnterCallback? OnCursorEnter;

    /// <summary>Sets the cursor position callback</summary>
    /// <remarks>
    ///     This function sets the cursor position callback of the window, which is called when the cursor is moved.
    ///     The callback is provided with the position, in screen coordinates, relative to the upper-left corner of the content
    ///     area of the
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_pos">Cursor position</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwCursorPosCallback? OnCursorPos;

    /// <summary>Sets the path drop callback</summary>
    /// <remarks>
    ///     This function sets the path drop callback of the window, which is called when one or more dragged paths
    ///     are dropped on the window.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <wayland>File drop is currently unimplemented.</wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#path_drop">Path drop input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwDropCallback? OnDrop;

    /// <summary>Sets the framebuffer resize callback</summary>
    /// <remarks>
    ///     This function sets the framebuffer resize callback of the window, which is called when the framebuffer
    ///     of the window is resized.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_fbsize">Framebuffer size</seealso>
    public event GlfwFramebufferSizeCallback? OnFramebufferSize;

    /// <summary>Sets the key callback</summary>
    /// <remarks>
    ///     This function sets the key callback of the window, which is called when a key is pressed, repeated or
    ///     released.
    ///     <para />
    ///     The key functions deal with physical keys, with layout independent
    ///     <see href="https://www.glfw.org/docs/latest/group__keys.html">key tokens</see> named after their values in the
    ///     standard US keyboard layout. If you want to input text, use the
    ///     <see cref="GlfwCharCallback">character callback</see> instead.
    ///     <para />
    ///     When a window loses input focus, it will generate synthetic key release events for all pressed keys with associated
    ///     key tokens. You can tell these events from user-generated events by the fact that the synthetic ones are generated
    ///     after the focus loss event has been processed, i.e. after the
    ///     <see cref="GlfwWindowFocusCallback">window focus callback</see> has been called.
    ///     <para />
    ///     The scancode of a key is specific to that platform or sometimes even to that machine. Scancodes are intended to
    ///     allow users to bind keys that don't have a GLFW key token. Such keys have key set to <see cref="GlfwKey.Unknown" />
    ///     , their state is not saved and so it cannot be queried with <see cref="GetKey">GlfwWindow.GetKey</see>.
    ///     <para />
    ///     Sometimes GLFW needs to generate synthetic key events, in which case the scancode may be zero.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_key">Key input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwKeyCallback? OnKey;

    /// <summary>Sets the mouse button callback</summary>
    /// <remarks>
    ///     This function sets the mouse button callback of the window, which is called when a mouse button is
    ///     pressed or released.
    ///     <para />
    ///     When a window loses input focus, it will generate synthetic mouse button release events for all pressed mouse
    ///     buttons. You can tell these events from user-generated events by the fact that the synthetic ones are generated
    ///     after the focus loss event has been processed, i.e. after the
    ///     <see cref="GlfwWindowFocusCallback">window focus callback</see> has been called.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_mouse_button">Mouse button input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwMouseButtonCallback? OnMouseButton;

    /// <summary>Sets the scroll callback</summary>
    /// <remarks>
    ///     This function sets the scroll callback of the window, which is called when a scrolling device is used,
    ///     such as a mouse wheel or scrolling area of a touchpad.
    ///     <para />
    ///     The scroll callback receives all scrolling input, like that from a mouse wheel or a touchpad scrolling area.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#scrolling">Scroll input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwScrollCallback? OnScroll;

    /// <summary>Sets the scroll detail callback</summary>
    /// <remarks>
    ///     This event receives the same scrolling input as <see cref="OnScroll" />, together with flags describing
    ///     whether the offset came from a trackpad and which gesture phase it belongs to.
    ///     <para />
    ///     When a gesture begins or ends, the event may also be raised with a zero offset so that the gesture
    ///     boundary is reported; <see cref="OnScroll" /> is not raised for these. An end may arrive without a
    ///     matching begin when a gesture is cancelled before it starts.
    ///     <para />
    ///     Only macOS reports flags. Other platforms raise this event with the same offsets as
    ///     <see cref="OnScroll" /> and no flags set.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#scrolling">Scroll input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwScrollDetailCallback? OnScrollDetail;

    /// <summary>Sets the trackpad zoom callback</summary>
    /// <remarks>
    ///     This event is raised when a pinch gesture is made on a trackpad. The scale is a factor to multiply the
    ///     current zoom by. It is reported on macOS and Wayland.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwTrackpadZoomCallback? OnTrackpadZoom;

    /// <summary>Sets the trackpad rotate callback</summary>
    /// <remarks>
    ///     This event is raised when a two-finger rotate gesture is made on a trackpad. The angle is in degrees since
    ///     the previous event, positive counter-clockwise. It is reported on macOS and Wayland.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public event GlfwTrackpadRotateCallback? OnTrackpadRotate;

    /// <summary>Sets the close callback</summary>
    /// <remarks>
    ///     This function sets the close callback of the window, which is called when the user attempts to close the
    ///     window, for example by clicking the close widget in the title bar.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_close">Window closing and close flag</seealso>
    public event GlfwWindowCloseCallback? OnClose;

    /// <summary>Sets the window content scale callback</summary>
    /// <remarks>
    ///     This function sets the window content scale callback of the window, which is called when the content
    ///     scale of the window changes.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_scale">Window content scale</seealso>
    public event GlfwWindowContentScaleCallback? OnContentScale;

    /// <summary>Sets the focus callback</summary>
    /// <remarks>
    ///     This function sets the focus callback of the window, which is called when the window gains or loses input
    ///     focus.
    ///     <para />
    ///     After the focus callback is called for a window that lost input focus, synthetic key and mouse button release
    ///     events
    ///     will be generated for all such that had been pressed.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_focus">Window input focus</seealso>
    public event GlfwWindowFocusCallback? OnFocus;

    /// <summary>Sets the iconify callback</summary>
    /// <remarks>
    ///     This function sets the iconification callback of the window, which is called when the window is iconified
    ///     or restored.
    /// </remarks>
    /// <wayland>
    ///     The XDG-shell protocol has no event for iconification, so this callback will never be called.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_iconify">Window iconification</seealso>
    public event GlfwWindowIconifyCallback? OnIconify;

    /// <summary>Sets the maximize callback</summary>
    /// <remarks>
    ///     This function sets the maximization callback of the window, which is called when the window is maximized
    ///     or restored.
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_maximize">Window maximization</seealso>
    public event GlfwWindowMaximizeCallback? OnMaximize;

    /// <summary>Sets the position callback</summary>
    /// <remarks>
    ///     This function sets the position callback of the window, which is called when the window is moved. The
    ///     callback is provided with the position, in screen coordinates, of the upper-left corner of the content area of
    ///     the
    /// </remarks>
    /// <wayland>
    ///     This callback will never be called, as there is no way for an application to know its global position.
    /// </wayland>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_pos">Window position</seealso>
    public event GlfwWindowPosCallback? OnPosition;

    /// <summary>Sets the refresh callback</summary>
    /// <remarks>
    ///     This function sets the refresh callback of the window, which is called when the content area of the
    ///     window needs to be redrawn, for example if the window has been exposed after being covered by another
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_refresh">Window damage and refresh</seealso>
    public event GlfwWindowRefreshCallback? OnRefresh;

    /// <summary>Sets the size callback</summary>
    /// <remarks>
    ///     This function sets the size callback of the window, which is called when the window is resized. The
    ///     callback
    ///     is provided with the size, in screen coordinates, of the content area of the
    /// </remarks>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    /// <seealso href="https://www.glfw.org/docs/latest/window_guide.html#window_size">Window size</seealso>
    public event GlfwWindowSizeCallback? OnSize;

    private void RefreshPosition()
    {
        Glfw.PInvoke.GetWindowPos(this, out var posX, out var posY);
        _position = new int2(posX, posY);
    }

    private void RefreshTitle()
    {
        // A window always has a title (required at creation, always set via the Title setter), so
        // glfwGetWindowTitle reads back a non-null value; forgive the null-preserving marshaller here.
        _title = Glfw.PInvoke.GetWindowTitle(this)!;
    }

    private void RefreshMonitor()
    {
        _monitor = Glfw.PInvoke.GetWindowMonitor(this);
    }

    private void RefreshSize()
    {
        RefreshMonitor();
        Glfw.PInvoke.GetWindowSize(this, out var width, out var height);
        _size = new int2(width, height);
        Glfw.PInvoke.GetFramebufferSize(this, out var fbWidth, out var fbHeight);
        _framebufferSize = new int2(fbWidth, fbHeight);
        Glfw.PInvoke.GetWindowContentScale(this, out var scaleX, out var scaleY);
        _contentScale = new float2(scaleX, scaleY);
    }

    private void RefreshCursorPos()
    {
        Glfw.PInvoke.GetCursorPos(this, out var cursorX, out var cursorY);
        _cursorPos = new double2(cursorX, cursorY);
    }

    private void RefreshShouldClose()
    {
        _shouldClose = Glfw.PInvoke.WindowShouldClose(this) == GLFW_TRUE;
    }

    private void RefreshVisible()
    {
        _isVisible = GetAttribute(GlfwWindowAttribute.Visible) == GLFW_TRUE;
    }

    private void RefreshMaximised()
    {
        _isMaximised = GetAttribute(GlfwWindowAttribute.Maximized) == GLFW_TRUE;
    }

    private void RefreshIconified()
    {
        _isIconified = GetAttribute(GlfwWindowAttribute.Iconified) == GLFW_TRUE;
    }

    private void RefreshFocused()
    {
        _isFocused = GetAttribute(GlfwWindowAttribute.Focused) == GLFW_TRUE;
    }

    private void RefreshOpacity()
    {
        _opacity = Glfw.PInvoke.GetWindowOpacity(this);
    }

    private void RefreshUserPointer()
    {
        _userPointer = Glfw.PInvoke.GetWindowUserPointer(this);
    }

    /// <summary>
    /// Refresh all cached properties of the window from the native implementation.
    /// </summary>
    public void Refresh()
    {
        RefreshPosition();
        RefreshTitle();
        RefreshSize();
        RefreshCursorPos();
        RefreshShouldClose();
        RefreshVisible();
        RefreshMaximised();
        RefreshIconified();
        RefreshFocused();
        RefreshOpacity();
        RefreshUserPointer();
    }
}

[CustomMarshaller(
    managedType: typeof(GlfwWindow),
    marshalMode: MarshalMode.ManagedToUnmanagedIn,
    marshallerType: typeof(GlfwWindowMarshaller)
)]
internal static unsafe class GlfwWindowMarshaller
{
    internal static GlfwWindowHandle* ConvertToUnmanaged(GlfwWindow? managed)
    {
        return managed != null ? managed.Pointer : null;
    }
}
