namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphOpticalFlowImageFormatInfoARM.html">VkDataGraphOpticalFlowImageFormatInfoARM</see> - Structure describing data graph optical flow image format info
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphOpticalFlowImageFormatInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph_optical_flow
    ///         typedef struct VkDataGraphOpticalFlowImageFormatInfoARM {
    ///             VkStructureType                             sType;
    ///             const void*                                 pNext;
    ///             VkDataGraphOpticalFlowImageUsageFlagsARM    usage;
    ///         } VkDataGraphOpticalFlowImageFormatInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDataGraphOpticalFlowImageFormatInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DataGraphOpticalFlowImageFormatInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Usage</c>
        /// </summary>
        [FieldOffset(16)]
        public VkDataGraphOpticalFlowImageUsageFlagsARM Usage;
    }
}
