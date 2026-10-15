namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkProvokingVertexModeEXT.html">VkProvokingVertexModeEXT</see> - Specify which vertex in a primitive is the provoking vertex
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineRasterizationProvokingVertexStateCreateInfoEXT::provokingVertexMode</c>
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_provoking_vertex
    ///         typedef enum VkProvokingVertexModeEXT {
    ///             VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT = 0,
    ///             VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT = 1,
    ///         } VkProvokingVertexModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkProvokingVertexModeEXT : int
    {
        /// <summary>
        ///     <c>FirstVertexEXT</c> specifies that the provoking vertex is the first non-adjacency vertex in the list of vertices used by a primitive.
        /// </summary>
        FirstVertexEXT = 0,

        /// <summary>
        ///     <c>LastVertexEXT</c> specifies that the provoking vertex is the last non-adjacency vertex in the list of vertices used by a primitive.  These modes are described more precisely in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#drawing-primitive-topologies">Primitive Topologies^</see>.
        /// </summary>
        LastVertexEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
