namespace Brutal.OpenGlApi;

using static OpenGl;

public readonly record struct GlBuffer(uint Id)
{
    public unsafe GlBuffer Bind(GlBindTarget target)
    {
        Native.glBindBuffer((uint)target, this);
        return this;
    }
}
