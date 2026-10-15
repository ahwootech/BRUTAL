namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryDedicatedAllocateInfoTensorARM.html">VkMemoryDedicatedAllocateInfoTensorARM</see> - Specify a dedicated memory allocation tensor resource
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain includes a
    ///         <c>VkMemoryDedicatedAllocateInfoTensorARM</c> structure, then that structure
    ///         includes a handle of the sole tensor resource that the memory <i>can</i> be bound
    ///         to.
    ///     </para>
    ///     <para>
    ///         The <c>VkMemoryDedicatedAllocateInfoTensorARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkMemoryDedicatedAllocateInfoTensorARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTensorARM        tensor;
    ///         } VkMemoryDedicatedAllocateInfoTensorARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMemoryDedicatedAllocateInfoTensorARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryDedicatedAllocateInfoTensorARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Tensor</c> is a handle of a tensor which this memory will be bound to.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorARM Tensor;
    }
}
