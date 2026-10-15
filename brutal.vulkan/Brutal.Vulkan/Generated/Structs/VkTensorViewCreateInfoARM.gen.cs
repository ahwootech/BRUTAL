namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorViewCreateInfoARM.html">VkTensorViewCreateInfoARM</see> - Structure specifying parameters of a newly created tensor view
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorViewCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_descriptor_heap, VK_ARM_tensors
    ///         typedef struct VkTensorViewCreateInfoARM {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkTensorViewCreateFlagsARM    flags;
    ///             VkTensorARM                   tensor;
    ///             VkFormat                      format;
    ///         } VkTensorViewCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkTensorViewCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorViewCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorViewCreateFlagsARM Flags;

        /// <summary>
        ///     <c>Tensor</c> is a <c>VkTensorARM</c> on which the view will be created.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorARM Tensor;

        /// <summary>
        ///     <c>Format</c> is a <c>VkFormat</c> describing the format and type used to interpret elements in the tensor.
        /// </summary>
        [FieldOffset(32)]
        public VkFormat Format;
    }
}
