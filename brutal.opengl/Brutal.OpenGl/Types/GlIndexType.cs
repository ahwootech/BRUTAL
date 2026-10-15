namespace Brutal.OpenGlApi;

using static OpenGl;

[Flags]
public enum GlIndexType : uint
{
    Byte = GL_UNSIGNED_BYTE,
    UShort = GL_UNSIGNED_SHORT,
    UInt = GL_UNSIGNED_INT,
}
