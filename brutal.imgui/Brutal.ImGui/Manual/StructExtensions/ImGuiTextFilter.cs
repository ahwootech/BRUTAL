namespace Brutal.ImGuiApi;

public partial struct ImGuiTextFilter
{
    private static int InputBufSize => 256;

    public unsafe ImGuiTextFilter(ImString defaultFilter = default)
        : this()
    {
        if (!defaultFilter.IsNull())
        {
            fixed (byte* inputBufPtr = InputBuf)
            {
                var target = new Span<byte>(inputBufPtr, InputBufSize);
                var source = defaultFilter.AsSpan();
                if (source.Length > InputBufSize)
                    source = source[..InputBufSize];
                source.CopyTo(target);
                this.Build();
            }
        }
    }
}
