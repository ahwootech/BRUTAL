namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerAddressMode.html">VkSamplerAddressMode</see> - Specify behavior of sampling with texture coordinates outside an image
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>VkSamplerCreateInfo</c>::ptext:addressMode*
    ///         parameters, corresponding to different <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-wrapping-operation">wrapping operations^</see> used during sampling, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSamplerAddressMode {
    ///             VK_SAMPLER_ADDRESS_MODE_REPEAT = 0,
    ///             VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = 1,
    ///             VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = 2,
    ///             VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = 3,
    ///             // Provided by VK_VERSION_1_2, VK_KHR_sampler_mirror_clamp_to_edge
    ///             VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = 4,
    ///             // Provided by VK_KHR_sampler_mirror_clamp_to_edge
    ///             // VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE_KHR is a legacy alias
    ///             VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE_KHR = VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE,
    ///         } VkSamplerAddressMode;
    ///     </code>
    /// </remarks>
    public enum VkSamplerAddressMode : int
    {
        /// <summary>
        ///     <c>Repeat</c> specifies that the repeat wrap mode will be used.
        /// </summary>
        Repeat = 0,

        /// <summary>
        ///     <c>MirroredRepeat</c> specifies that the mirrored repeat wrap mode will be used.
        /// </summary>
        MirroredRepeat = 1,

        /// <summary>
        ///     <c>ClampToEdge</c> specifies that the clamp to edge wrap mode will be used.
        /// </summary>
        ClampToEdge = 2,

        /// <summary>
        ///     <c>ClampToBorder</c> specifies that the clamp to border wrap mode will be used.
        /// </summary>
        ClampToBorder = 3,

        /// <summary>
        ///     <c>MirrorClampToEdge</c>
        /// </summary>
        MirrorClampToEdge = 4,

        /// <summary>
        ///     <c>MirrorClampToEdgeKHR</c>
        /// </summary>
        MirrorClampToEdgeKHR = MirrorClampToEdge,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
