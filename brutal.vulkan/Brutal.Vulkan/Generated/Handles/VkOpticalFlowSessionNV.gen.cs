namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionNV.html">VkOpticalFlowSessionNV</see> - Opaque handle to an optical flow session object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Optical flow session objects are abstracted and represented by
    ///         <c>VkOpticalFlowSessionNV</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkOpticalFlowSessionNV)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkOpticalFlowSessionNV : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.OpticalFlowSessionNV;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkOpticalFlowSessionNV(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkOpticalFlowSessionNV NullHandle = new();
    }
}
