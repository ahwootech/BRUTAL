namespace Brutal.ImGuiApi;

public partial class ImGui
{
    // Manually wrap PInvoke.TextUnformatted() as Managed.Text(), as rules don't have renaming support.

    /// <summary>
    ///   <para>raw text without formatting. Roughly equivalent to Text(&quot;%s&quot;, text) but: A) doesn&apos;t require null terminated string if &apos;text_end&apos; is specified, B) it&apos;s faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.</para>
    ///   <para>
    ///     C++: <a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L614">imgui.h:614</a>, <a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_widgets.cpp#L268">imgui_widgets.cpp:268</a>
    ///     <br/>
    ///     <c>void TextUnformatted(const char* text, const char* text_end = NULL)</c>
    ///   </para>
    /// </summary>
    /// <remarks>Widgets: Text</remarks>
    public static void Text(ImString text)
    {
        unsafe
        {
            fixed (byte* text_fixed = text)
            {
                PInvoke.TextUnformatted(text_fixed, null);
            }
        }
    }

    public partial class Internal
    {
        /// <summary>
        ///   <para>
        ///     C++: <a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui.h#L616">imgui.h:616</a>, <a href="https://github.com/ocornut/imgui/blob/v1.92.2-docking/imgui_widgets.cpp#L281">imgui_widgets.cpp:281</a>
        ///     <br/>
        ///     <c>void TextV(const char* fmt, va_list args) IM_FMTLIST(1)</c>
        ///   </para>
        /// </summary>
        /// <remarks>Uses C++/printf-style formatting: %d, %f etc.
        /// <br/>C# has better options, but this could be useful for compatibility, porting C++ code etc.</remarks>
        public static unsafe void TextFormatted(ImString fmt, params ReadOnlySpan<VariadicArgument> args)
        {
            fixed (byte* fmt_fixed = fmt)
            fixed (byte* vaList_fixed = VaList.Pack(stackalloc byte[VaList.GetSize(args)], args))
                PInvoke.TextV(fmt_fixed, vaList_fixed);
        }
    }
}
