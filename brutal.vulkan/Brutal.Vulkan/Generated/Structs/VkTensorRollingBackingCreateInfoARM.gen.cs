namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorRollingBackingCreateInfoARM.html">VkTensorRollingBackingCreateInfoARM</see> - Structure specifying the parameters of a newly created tensor object with rolling backing
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To create a tensor for which only a rolling window is backed by memory, add
    ///         a <c>VkTensorRollingBackingCreateInfoARM</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkTensorCreateInfoARM</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkTensorRollingBackingCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensor_controls
    ///         typedef struct VkTensorRollingBackingCreateInfoARM {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint32_t           wraps[VK_MAX_TENSOR_CREATE_INFO_ROLLING_BACKING_WRAP_COUNT_ARM];
    ///         } VkTensorRollingBackingCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkTensorRollingBackingCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorRollingBackingCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Wraps</c> is an array of <c>VK_MAX_TENSOR_CREATE_INFO_ROLLING_BACKING_WRAP_COUNT_ARM</c> 32-bit integers specifying the size of the rolling window for the tensor along each of its dimensions.
        /// </summary>
        [FieldOffset(16)]
        public uint4 Wraps;
    }
}
