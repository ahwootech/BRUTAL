namespace Brutal.OpenGlApi;

using static OpenGl;

public enum GlStencilOp : uint
{
    Keep = GL_KEEP,
    Zero = GL_ZERO,
    Replace = GL_REPLACE,
    Incr = GL_INCR,
    IncrWrap = GL_INCR_WRAP,
    Decr = GL_DECR,
    DecrWrap = GL_DECR_WRAP,
    Invert = GL_INVERT,
}
