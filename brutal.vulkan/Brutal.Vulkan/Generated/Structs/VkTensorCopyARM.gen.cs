namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorCopyARM.html">VkTensorCopyARM</see> - Structure specifying an tensor copy region
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorCopyARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkTensorCopyARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           dimensionCount;
    ///             const uint64_t*    pSrcOffset;
    ///             const uint64_t*    pDstOffset;
    ///             const uint64_t*    pExtent;
    ///         } VkTensorCopyARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkTensorCopyARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorCopyARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DimensionCount</c> is the number of elements in the <c>pSrcOffset</c>, <c>pDstOffset</c> and <c>pExtent</c> arrays.
        /// </summary>
        [FieldOffset(16)]
        public int DimensionCount;

        /// <summary>
        ///     <c>SrcOffset</c> is `NULL` or an array of size <c>dimensionCount</c> providing an offset into the source tensor. When <c>pSrcOffset</c> is `NULL`, the offset into the source tensor is `0` in all dimensions.
        /// </summary>
        [FieldOffset(24)]
        public nint* SrcOffset;

        /// <summary>
        ///     <c>DstOffset</c> is `NULL` or an array of size <c>dimensionCount</c> providing an offset into the destination tensor. When <c>pDstOffset</c> is `NULL`, the offset into the destination tensor is `0` in all dimensions.
        /// </summary>
        [FieldOffset(32)]
        public nint* DstOffset;

        /// <summary>
        ///     <c>Extent</c> is `NULL` or an array of size <c>dimensionCount</c> providing the number of elements to copy in each dimension. When <c>pExtent</c> is `NULL`, the number of elements to copy is taken as the total number of elements in each dimension of the source tensor.
        /// </summary>
        [FieldOffset(40)]
        public nint* Extent;
    }
}
