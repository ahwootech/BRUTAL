namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBlendOverlapEXT.html">VkBlendOverlapEXT</see> - Enumerant specifying the blend overlap parameter
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The weighting functions <c>p~0~</c>, <c>p~1~</c>, and <c>p~2~</c> are defined
    ///         in table <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#framebuffer-blend-advanced-overlap-modes">Advanced Blend Overlap
    ///         Modes^</see>.
    ///         In these functions, the A components of the source and destination colors
    ///         are taken to indicate the portion of the pixel covered by the fragment
    ///         (source) and the fragments previously accumulated in the pixel
    ///         (destination).
    ///         The functions <c>p~0~</c>, <c>p~1~</c>, and <c>p~2~</c> approximate the
    ///         relative portion of the pixel covered by the intersection of the source and
    ///         destination, covered only by the source, and covered only by the
    ///         destination, respectively.
    ///     </para>
    ///     <para>
    ///         Possible values of
    ///         <c>VkPipelineColorBlendAdvancedStateCreateInfoEXT::blendOverlap</c>,
    ///         specifying the blend overlap functions, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_blend_operation_advanced
    ///         typedef enum VkBlendOverlapEXT {
    ///             VK_BLEND_OVERLAP_UNCORRELATED_EXT = 0,
    ///             VK_BLEND_OVERLAP_DISJOINT_EXT = 1,
    ///             VK_BLEND_OVERLAP_CONJOINT_EXT = 2,
    ///         } VkBlendOverlapEXT;
    ///     </code>
    /// </remarks>
    public enum VkBlendOverlapEXT : int
    {
        /// <summary>
        ///     <c>UncorrelatedEXT</c> specifies that there is no correlation between the source and destination coverage.
        /// </summary>
        UncorrelatedEXT = 0,

        /// <summary>
        ///     <c>DisjointEXT</c> specifies that the source and destination coverage are considered to have minimal overlap.  [[framebuffer-blend-advanced-overlap-modes]] .Advanced Blend Overlap Modes [width=&quot;80%&quot;,options=&quot;header&quot;] |
        /// </summary>
        DisjointEXT = 1,

        /// <summary>
        ///     <c>ConjointEXT</c> specifies that the source and destination coverage are considered to have maximal overlap.
        /// </summary>
        ConjointEXT = 2,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
