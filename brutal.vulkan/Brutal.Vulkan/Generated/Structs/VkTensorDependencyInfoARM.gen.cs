namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorDependencyInfoARM.html">VkTensorDependencyInfoARM</see> - Structure specifying tensor dependency information for a synchronization command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorDependencyInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkTensorDependencyInfoARM {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             uint32_t                           tensorMemoryBarrierCount;
    ///             const VkTensorMemoryBarrierARM*    pTensorMemoryBarriers;
    ///         } VkTensorDependencyInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkTensorDependencyInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorDependencyInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TensorMemoryBarrierCount</c> is the length of the <c>pTensorMemoryBarriers</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int TensorMemoryBarrierCount;

        /// <summary>
        ///     <c>TensorMemoryBarriers</c> is a pointer to an array of <c>VkTensorMemoryBarrierARM</c> structures defining memory dependencies between tensors.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorMemoryBarrierARM* TensorMemoryBarriers;
    }
}
