// Input reference
// https://www.glfw.org/docs/latest/group__input.html

// Hand-written members of the Input library: the managed callback delegate types, the
// JoystickCallback event, GetJoystickHats (ptr+count -> ReadOnlySpan with a Span.Cast to enum,
// not yet a generator transform), the clipboard accessors (glfwGet/SetClipboardString are in
// ManualMethods and hardcode a null window), and the Time property (Get/Set pairing -> property,
// not yet a generator transform). The mechanical wrappers - including the non-cast span returns
// GetJoystickAxes/GetJoystickButtons - are generated into Generated/Libraries/Glfw.Input.gen.cs
// and merge into this same partial class.

namespace Brutal.GlfwApi;

/// <summary>The function pointer type for mouse button callbacks.</summary>
/// <seealso cref="GlfwWindow.OnMouseButton">GlfwWindow.OnMouseButton</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_mouse_button">Mouse button input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="button">The mouse button that was pressed or released.</param>
/// <param name="action">One of <see cref="GlfwButtonAction.Press" /> or <see cref="GlfwButtonAction.Release" />.</param>
/// <param name="mods">Bit field describing which modifier keys were held down.</param>
public delegate void GlfwMouseButtonCallback(
    GlfwWindow window,
    GlfwMouseButton button,
    GlfwButtonAction action,
    GlfwModifier mods
);

/// <summary>The function pointer type for cursor position callbacks.</summary>
/// <seealso cref="GlfwWindow.OnCursorPos">GlfwWindow.OnCursorPos</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_pos">Cursor position</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="pos">The new cursor coordinates, relative to the left edge of the content area.</param>
public delegate void GlfwCursorPosCallback(GlfwWindow window, double2 pos);

/// <summary>The function pointer type for cursor enter/leave callbacks.</summary>
/// <seealso cref="GlfwWindow.OnCursorEnter">GlfwWindow.OnCursorEnter</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#cursor_enter">Cursor enter/leave events</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="entered">
///     <see cref="Glfw.Constants.GLFW_TRUE" /> if the cursor entered the window's content area, or
///     <see cref="Glfw.Constants.GLFW_FALSE" /> if it left it.
/// </param>
public delegate void GlfwCursorEnterCallback(GlfwWindow window, bool entered);

/// <summary>The function pointer type for scroll callbacks.</summary>
/// <seealso cref="GlfwWindow.OnScroll">GlfwWindow.OnScroll</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#scrolling">Scroll input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="offset">The scroll offset.</param>
public delegate void GlfwScrollCallback(GlfwWindow window, double2 offset);

/// <summary>The function pointer type for scroll detail callbacks.</summary>
/// <seealso cref="GlfwWindow.OnScrollDetail">GlfwWindow.OnScrollDetail</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#scrolling">Scroll input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="offset">The scroll offset, zero when the event only marks a gesture boundary.</param>
/// <param name="flags">Where the offset came from and which gesture phase it belongs to.</param>
public delegate void GlfwScrollDetailCallback(GlfwWindow window, double2 offset, GlfwScrollFlags flags);

/// <summary>The function pointer type for trackpad zoom callbacks.</summary>
/// <seealso cref="GlfwWindow.OnTrackpadZoom">GlfwWindow.OnTrackpadZoom</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="scale">The zoom since the previous event, as a factor to multiply the current scale by.</param>
public delegate void GlfwTrackpadZoomCallback(GlfwWindow window, double scale);

/// <summary>The function pointer type for trackpad rotate callbacks.</summary>
/// <seealso cref="GlfwWindow.OnTrackpadRotate">GlfwWindow.OnTrackpadRotate</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="angle">The rotation since the previous event, in degrees, positive counter-clockwise.</param>
public delegate void GlfwTrackpadRotateCallback(GlfwWindow window, double angle);

/// <summary>The function pointer type for keyboard key callbacks.</summary>
/// <seealso cref="GlfwWindow.OnKey">GlfwWindow.OnKey</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_key">Key input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="key">The keyboard key that was pressed or released.</param>
/// <param name="scancode">The system-specific scancode of the key.</param>
/// <param name="action">
///     <see cref="GlfwKeyAction.Press" />, <see cref="GlfwKeyAction.Release" /> or
///     <see cref="GlfwKeyAction.Repeat" />. Future releases may add more actions.
/// </param>
/// <param name="mods">Bit field describing which modifier keys were held down.</param>
public delegate void GlfwKeyCallback(
    GlfwWindow window,
    GlfwKey key,
    int scancode,
    GlfwKeyAction action,
    GlfwModifier mods
);

/// <summary>The function pointer type for Unicode character callbacks.</summary>
/// <seealso cref="GlfwWindow.OnChar">GlfwWindow.OnChar</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_char">Text input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="codepoint">The Unicode code point of the character.</param>
public delegate void GlfwCharCallback(GlfwWindow window, uint codepoint);

/// <summary>The function pointer type for Unicode character with modifiers callbacks.</summary>
/// <seealso cref="GlfwWindow.OnCharMods">GlfwWindow.OnCharMods</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#input_char">Text input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="codepoint">The Unicode code point of the character.</param>
/// <param name="mods">Bit field describing which modifier keys were held down.</param>
public delegate void GlfwCharModsCallback(GlfwWindow window, uint codepoint, GlfwModifier mods);

/// <summary>The function pointer type for path drop callbacks.</summary>
/// <seealso cref="GlfwWindow.OnDrop">GlfwWindow.OnDrop</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#path_drop">Path drop input</seealso>
/// <param name="window">The window that received the event.</param>
/// <param name="count">The number of dropped paths.</param>
/// <param name="paths">An array of UTF-8 encoded file and directory path names.</param>
public delegate void GlfwDropCallback(GlfwWindow window, int count, string[] paths);

/// <summary>The function pointer type for joystick configuration callbacks.</summary>
/// <seealso cref="Glfw.JoystickCallback">Glfw.JoystickCallback</seealso>
/// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#joystick_event">Joystick configuration changes</seealso>
/// <param name="inJoystickId">The joystick that was connected or disconnected.</param>
/// <param name="inEvent">
///     One of <see cref="GlfwJoystickEvent.Connected" /> or
///     <see cref="GlfwJoystickEvent.Disconnected" />. Future releases may add more events.
/// </param>
public delegate void GlfwJoystickCallback(int inJoystickId, GlfwJoystickEvent inEvent);

public static unsafe partial class Glfw
{
    /// <summary>Sets the joystick configuration callback.</summary>
    /// <remarks>
    ///     This function sets the joystick configuration callback, or removes the currently set callback. This is called when
    ///     a joystick is connected to or disconnected from the system.
    ///     <para />
    ///     For joystick connection and disconnection events to be delivered on all platforms, you need to call one of the
    ///     <see href="https://www.glfw.org/docs/latest/input_guide.html#events">event processing functions</see>. Joystick
    ///     disconnection may also be detected and the callback called by joystick functions. The function will then return
    ///     whatever it returns if the joystick is not present.
    /// </remarks>
    /// <returns>The previously set callback, or <c>null</c> if no callback was set or the library had not been initialized.</returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#joystick_event">Joystick configuration changes</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public static event GlfwJoystickCallback? JoystickCallback;

    /// <summary>Returns the state of all hats of the specified joystick.</summary>
    /// <remarks>
    ///     This function returns the state of all hats of the specified joystick.
    ///     <para />
    ///     The diagonal directions are bitwise combinations of the primary (up, right, down and left) directions and you can
    ///     test for these individually by ANDing it with the corresponding direction.
    ///     <para />
    ///     If the specified joystick is not present this function will return <c>null</c> but will not generate an error. This
    ///     can be used instead of first calling <see cref="JoystickPresent(int)">Glfw.JoystickPresent</see>.
    /// </remarks>
    /// <param name="joystickId">The joystick ID to query.</param>
    /// <returns>An array of hat states, or <c>null</c> if the joystick is not present or an error occurred.</returns>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#joystick_hat">Joystick hat states</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.InvalidEnum" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    public static ReadOnlySpan<GlfwJoystickHat> GetJoystickHats(int joystickId)
    {
        return new ReadOnlySpan<byte>(PInvoke.GetJoystickHats(joystickId, out var count), count).Cast<
            byte,
            GlfwJoystickHat
        >();
    }

    /// <summary>Sets the clipboard to the specified string.</summary>
    /// <remarks>
    ///     This function sets the system clipboard to the specified, UTF-8 encoded string.
    /// </remarks>
    /// <param name="string">The string to set the clipboard to.</param>
    /// <seealso cref="Clipboard" />
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#clipboard">Clipboard input and output</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    public static void SetClipboard(string @string)
    {
        PInvoke.SetClipboardString(null, @string);
    }

    /// <summary>Returns the contents of the clipboard as a string.</summary>
    /// <remarks>
    ///     This function returns the contents of the system clipboard, if it contains or is convertible to a UTF-8 encoded
    ///     string. If the clipboard is empty or if its contents cannot be converted, <see langword="null" /> is returned and
    ///     a <see cref="GlfwErrorCode.FormatUnavailable" /> error is generated.
    /// </remarks>
    /// <returns>
    ///     The contents of the clipboard, or <see langword="null" /> if the clipboard is empty, its contents cannot be
    ///     converted, or an error occurred.
    /// </returns>
    /// <threadSafety>This function must only be called from the main thread.</threadSafety>
    /// <seealso cref="SetClipboard" />
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#clipboard">Clipboard input and output</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    ///     <see cref="GlfwErrorCode.FormatUnavailable" />
    ///     <see cref="GlfwErrorCode.PlatformError" />
    /// </possibleErrors>
    public static string? Clipboard
    {
        get => PInvoke.GetClipboardString(null);
        set
        {
            ArgumentNullException.ThrowIfNull(value);
            PInvoke.SetClipboardString(null, value);
        }
    }

    /// <summary>Returns the GLFW time.</summary>
    /// <remarks>
    ///     This function returns the current GLFW time, in seconds. Unless the time has been set using <see cref="SetTime" />
    ///     it measures time elapsed since GLFW was initialized.
    ///     <para />
    ///     This function and <see cref="SetTime" /> are helper functions on top of <see cref="GetTimerFrequency" /> and
    ///     <see cref="GetTimerValue" />.
    ///     <para />
    ///     The resolution of the timer is system dependent, but is usually on the order of a few micro- or nanoseconds. It
    ///     uses the highest-resolution monotonic time source on each supported platform.
    /// </remarks>
    /// <returns>The current time, in seconds, or zero if an error occurred.</returns>
    /// <threadSafety>
    ///     This function may be called from any thread. Reading and writing of the internal base time is not atomic,
    ///     so it needs to be externally synchronized with calls to <see cref="SetTime" />.
    /// </threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/input_guide.html#time">Time input</seealso>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />
    /// </possibleErrors>
    public static double Time
    {
        get => PInvoke.GetTime();
        set => PInvoke.SetTime(value);
    }
}
