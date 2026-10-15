namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorDescriptionARM.html">VkTensorDescriptionARM</see> - Structure describing a tensor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorDescriptionARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkTensorDescriptionARM {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkTensorTilingARM        tiling;
    ///             VkFormat                 format;
    ///             uint32_t                 dimensionCount;
    ///             const int64_t*           pDimensions;
    ///             const int64_t*           pStrides;
    ///             VkTensorUsageFlagsARM    usage;
    ///         } VkTensorDescriptionARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkTensorDescriptionARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorDescriptionARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Tiling</c> is a <c>VkTensorTilingARM</c> value specifying the tiling of the tensor
        /// </summary>
        [FieldOffset(16)]
        public VkTensorTilingARM Tiling;

        /// <summary>
        ///     <c>Format</c> is a one component <c>VkFormat</c> describing the format and type of the data elements that will be contained in the tensor.
        /// </summary>
        [FieldOffset(20)]
        public VkFormat Format;

        /// <summary>
        ///     <c>DimensionCount</c> is the number of dimensions for the tensor.
        /// </summary>
        [FieldOffset(24)]
        public int DimensionCount;

        /// <summary>
        ///     <c>Dimensions</c> is a pointer to an array of integers of size <c>dimensionCount</c> providing the number of data elements in each dimension.
        /// </summary>
        [FieldOffset(32)]
        public long* Dimensions;

        /// <summary>
        ///     <c>Strides</c> is either `NULL` or is an array of size <c>dimensionCount</c> providing the strides in bytes for the tensor in each dimension.
        /// </summary>
        [FieldOffset(40)]
        public long* Strides;

        /// <summary>
        ///     <c>Usage</c> is a bitmask of <c>VkTensorUsageFlagsARM</c> specifying the usage of the tensor.
        /// </summary>
        [FieldOffset(48)]
        public VkTensorUsageFlagsARM Usage;
    }
}
