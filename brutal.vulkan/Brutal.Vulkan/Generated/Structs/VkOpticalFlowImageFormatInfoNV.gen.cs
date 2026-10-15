namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowImageFormatInfoNV.html">VkOpticalFlowImageFormatInfoNV</see> - Structure describing optical flow image format info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkOpticalFlowImageFormatInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_optical_flow
    ///         typedef struct VkOpticalFlowImageFormatInfoNV {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             VkOpticalFlowUsageFlagsNV    usage;
    ///         } VkOpticalFlowImageFormatInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkOpticalFlowImageFormatInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.OpticalFlowImageFormatInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Usage</c>
        /// </summary>
        [FieldOffset(16)]
        public VkOpticalFlowUsageFlagsNV Usage;
    }
}
