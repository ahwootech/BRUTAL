namespace Brutal.OpenGlApi;

using static OpenGl;

public enum GlFunc : uint
{
    Never = GL_NEVER,
    Less = GL_LESS,
    LessEqual = GL_LEQUAL,
    Greater = GL_GREATER,
    GreaterEqual = GL_GEQUAL,
    Equal = GL_EQUAL,
    NotEqual = GL_NOTEQUAL,
    Always = GL_ALWAYS,
}
