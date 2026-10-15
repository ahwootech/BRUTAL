namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSampler.html">VkSampler</see> - Opaque handle to a sampler object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkSampler</c> objects represent the state of an image sampler which is
    ///         used by the implementation to read image data and apply filtering and other
    ///         transformations for the shader.
    ///     </para>
    ///     <para>
    ///         Samplers are represented by <c>VkSampler</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkSampler)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkSampler : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Sampler;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkSampler(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkSampler NullHandle = new();
    }
}
