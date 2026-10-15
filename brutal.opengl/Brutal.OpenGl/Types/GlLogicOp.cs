namespace Brutal.OpenGlApi;

using static OpenGl;

public enum GlLogicOp : uint
{
    Clear = GL_CLEAR,
    Set = GL_SET,
    Copy = GL_COPY,
    CopyInverted = GL_COPY_INVERTED,
    NoOp = GL_NOOP,
    Invert = GL_INVERT,
    And = GL_AND,
    NAnd = GL_NAND,
    Or = GL_OR,
    NOr = GL_NOR,
    XOr = GL_XOR,
    Equiv = GL_EQUIV,
    AndReverse = GL_AND_REVERSE,
    AndInverted = GL_AND_INVERTED,
    OrReverse = GL_OR_REVERSE,
    OrInverted = GL_OR_INVERTED,
}
