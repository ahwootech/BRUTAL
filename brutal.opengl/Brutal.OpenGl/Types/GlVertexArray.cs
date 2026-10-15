using System.Runtime.CompilerServices;

namespace Brutal.OpenGlApi;

using static OpenGl;

public readonly record struct GlVertexArray(uint Id)
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe GlVertexArray Bind()
    {
        Native.glBindVertexArray(this);
        return this;
    }
}
