namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerYcbcrConversion.html">VkSamplerYcbcrConversion</see> - Opaque handle to a device-specific sampler {YCbCr} conversion description
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         A sampler {YCbCr} conversion is an opaque representation of a
    ///         device-specific sampler {YCbCr} conversion description, represented as a
    ///         <c>VkSamplerYcbcrConversion</c> handle:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkSamplerYcbcrConversion)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkSamplerYCbCrConversion : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.SamplerYCbCrConversion;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkSamplerYCbCrConversion(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkSamplerYCbCrConversion NullHandle = new();
    }
}
