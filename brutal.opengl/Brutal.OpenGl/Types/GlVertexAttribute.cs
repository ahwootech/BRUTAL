namespace Brutal.OpenGlApi;

using static OpenGl;

public enum GlVertexAttribute : uint
{
    ArrayBufferBinding = GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING,
    ArrayEnabled = GL_VERTEX_ATTRIB_ARRAY_ENABLED,
    ArraySize = GL_VERTEX_ATTRIB_ARRAY_SIZE,
    ArrayStride = GL_VERTEX_ATTRIB_ARRAY_STRIDE,
    ArrayType = GL_VERTEX_ATTRIB_ARRAY_TYPE,
    ArrayNormalized = GL_VERTEX_ATTRIB_ARRAY_NORMALIZED,
    ArrayInteger = GL_VERTEX_ATTRIB_ARRAY_INTEGER,
    ArrayLong = GL_VERTEX_ATTRIB_ARRAY_LONG,
    ArrayDivisor = GL_VERTEX_ATTRIB_ARRAY_DIVISOR,
    Binding = GL_VERTEX_ATTRIB_BINDING,
    RelativeOffset = GL_VERTEX_ATTRIB_RELATIVE_OFFSET,
    Current = GL_CURRENT_VERTEX_ATTRIB,
}
