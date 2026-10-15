namespace Brutal.OpenGlApi;

using static OpenGl;

[Flags]
public enum GlClearBit : uint
{
    Color = GL_COLOR_BUFFER_BIT,
    Depth = GL_DEPTH_BUFFER_BIT,
    Stencil = GL_STENCIL_BUFFER_BIT,
}
