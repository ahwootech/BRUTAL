namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPrimitiveTopology.html">VkPrimitiveTopology</see> - Supported primitive topologies
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The primitive topologies defined by <c>VkPrimitiveTopology</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPrimitiveTopology {
    ///             VK_PRIMITIVE_TOPOLOGY_POINT_LIST = 0,
    ///             VK_PRIMITIVE_TOPOLOGY_LINE_LIST = 1,
    ///             VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = 2,
    ///             VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = 3,
    ///             VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = 4,
    ///             VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = 5,
    ///             VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY = 6,
    ///             VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY = 7,
    ///             VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY = 8,
    ///             VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY = 9,
    ///             VK_PRIMITIVE_TOPOLOGY_PATCH_LIST = 10,
    ///         } VkPrimitiveTopology;
    ///     </code>
    /// </remarks>
    public enum VkPrimitiveTopology : int
    {
        /// <summary>
        ///     <c>PointList</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-point-lists">separate point primitives^</see>.
        /// </summary>
        PointList = 0,

        /// <summary>
        ///     <c>LineList</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-line-lists">separate line primitives^</see>.
        /// </summary>
        LineList = 1,

        /// <summary>
        ///     <c>LineStrip</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-line-strips">connected line primitives^</see> with consecutive lines sharing a vertex.
        /// </summary>
        LineStrip = 2,

        /// <summary>
        ///     <c>TriangleList</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-triangle-lists">separate triangle primitives^</see>.
        /// </summary>
        TriangleList = 3,

        /// <summary>
        ///     <c>TriangleStrip</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-triangle-strips">connected triangle primitives^</see> with consecutive triangles sharing an edge.
        /// </summary>
        TriangleStrip = 4,

        /// <summary>
        ///     <c>TriangleFan</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-triangle-fans">connected triangle primitives^</see> with all triangles sharing a common vertex.
        /// </summary>
        TriangleFan = 5,

        /// <summary>
        ///     <c>LineListWithAdjacency</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-line-lists-with-adjacency">separate line primitives with adjacency^</see>.
        /// </summary>
        LineListWithAdjacency = 6,

        /// <summary>
        ///     <c>LineStripWithAdjacency</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-line-strips-with-adjacency">connected line primitives with adjacency^</see>, with consecutive primitives sharing three vertices.
        /// </summary>
        LineStripWithAdjacency = 7,

        /// <summary>
        ///     <c>TriangleListWithAdjacency</c> specifies a series of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-triangle-lists-with-adjacency">separate triangle primitives with adjacency^</see>.
        /// </summary>
        TriangleListWithAdjacency = 8,

        /// <summary>
        ///     <c>TriangleStripWithAdjacency</c> specifies <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-triangle-strips-with-adjacency">connected triangle primitives with adjacency^</see>, with consecutive triangles sharing an edge.
        /// </summary>
        TriangleStripWithAdjacency = 9,

        /// <summary>
        ///     <c>PatchList</c> specifies <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-patch-lists">separate patch primitives^</see>.  Each primitive topology, and its construction from a list of vertices, is described in detail below with a supporting diagram, according to the following key:  [cols=&quot;1,2,9&quot;] |
        /// </summary>
        PatchList = 10,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
