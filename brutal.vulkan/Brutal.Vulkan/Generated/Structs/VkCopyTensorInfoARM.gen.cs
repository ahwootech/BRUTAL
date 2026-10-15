namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyTensorInfoARM.html">VkCopyTensorInfoARM</see> - Structure specifying an tensor copy operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCopyTensorInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkCopyTensorInfoARM {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkTensorARM               srcTensor;
    ///             VkTensorARM               dstTensor;
    ///             uint32_t                  regionCount;
    ///             const VkTensorCopyARM*    pRegions;
    ///         } VkCopyTensorInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkCopyTensorInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CopyTensorInfoARM;

        /// <summary>
        ///     <c>Next</c> is NULL or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcTensor</c> is the source tensor.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorARM SrcTensor;

        /// <summary>
        ///     <c>DstTensor</c> is the destination tensor.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorARM DstTensor;

        /// <summary>
        ///     <c>RegionCount</c> is the number of regions to copy.
        /// </summary>
        [FieldOffset(32)]
        public int RegionCount;

        /// <summary>
        ///     <c>Regions</c> is a pointer to an array of <c>VkTensorCopyARM</c> structures specifying the regions to copy.
        /// </summary>
        [FieldOffset(40)]
        public VkTensorCopyARM* Regions;
    }
}
