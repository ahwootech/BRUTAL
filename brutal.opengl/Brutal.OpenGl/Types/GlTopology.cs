namespace Brutal.OpenGlApi;

using static OpenGl;

[Flags]
public enum GlTopology : uint
{
    Points = GL_POINTS,
    LineStrip = GL_LINE_STRIP,
    LineLoop = GL_LINE_LOOP,
    Lines = GL_LINES,
    LineStripAdjacency = GL_LINE_STRIP_ADJACENCY,
    LinesAdjacency = GL_LINES_ADJACENCY,
    TriangleStrip = GL_TRIANGLE_STRIP,
    TriangleFan = GL_TRIANGLE_FAN,
    Triangles = GL_TRIANGLES,
    TriangleStripAdjacency = GL_TRIANGLE_STRIP_ADJACENCY,
    TrianglesAdjacency = GL_TRIANGLES_ADJACENCY,
    Patches = GL_PATCHES,
}
