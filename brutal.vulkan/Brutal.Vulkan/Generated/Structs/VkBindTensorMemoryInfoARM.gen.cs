namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindTensorMemoryInfoARM.html">VkBindTensorMemoryInfoARM</see> - Structure specifying how to bind a tensor to memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindTensorMemoryInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkBindTensorMemoryInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTensorARM        tensor;
    ///             VkDeviceMemory     memory;
    ///             VkDeviceSize       memoryOffset;
    ///         } VkBindTensorMemoryInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkBindTensorMemoryInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindTensorMemoryInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Tensor</c> is the tensor to be attached to memory.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorARM Tensor;

        /// <summary>
        ///     <c>Memory</c> is a <c>VkDeviceMemory</c> object describing the device memory to attach.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory Memory;

        /// <summary>
        ///     <c>MemoryOffset</c> is the start offset of the region of <c>memory</c> which is to be bound to the tensor. The number of bytes returned in the <c>VkMemoryRequirements::size</c> member in <c>memory</c>, starting from <c>memoryOffset</c> bytes, will be bound to the specified tensor.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 MemoryOffset;
    }
}
