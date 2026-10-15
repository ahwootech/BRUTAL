namespace Brutal.OpenGlApi;

using static OpenGl;

public enum GlHint : uint
{
    LineSmooth = GL_LINE_SMOOTH_HINT,
    PolygonSmooth = GL_POLYGON_SMOOTH_HINT,
    TextureCompression = GL_TEXTURE_COMPRESSION_HINT,
    FragmentShaderDerivative = GL_FRAGMENT_SHADER_DERIVATIVE_HINT,
}
