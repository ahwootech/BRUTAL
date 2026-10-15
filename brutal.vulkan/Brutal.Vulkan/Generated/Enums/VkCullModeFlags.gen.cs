namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCullModeFlagBits.html">VkCullModeFlagBits</see> - Bitmask controlling triangle culling
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Once the orientation of triangles is determined, they are culled according
    ///         to the <c>VkPipelineRasterizationStateCreateInfo::cullMode</c> property
    ///         of the currently active pipeline.
    ///         Possible values are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkCullModeFlagBits {
    ///             VK_CULL_MODE_NONE = 0,
    ///             VK_CULL_MODE_FRONT_BIT = 0x00000001,
    ///             VK_CULL_MODE_BACK_BIT = 0x00000002,
    ///             VK_CULL_MODE_FRONT_AND_BACK = 0x00000003,
    ///         } VkCullModeFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkCullModeFlags : int
    {
        /// <summary>
        ///     <c>None</c> specifies that no triangles are discarded
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>FrontBit</c> specifies that front-facing triangles are discarded
        /// </summary>
        FrontBit = 0x00000001,

        /// <summary>
        ///     <c>BackBit</c> specifies that back-facing triangles are discarded
        /// </summary>
        BackBit = 0x00000002,

        /// <summary>
        ///     <c>FrontAndBack</c> specifies that all triangles are discarded.  Following culling, fragments are produced for any triangles which have not been discarded.
        /// </summary>
        FrontAndBack = 0x00000003,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
