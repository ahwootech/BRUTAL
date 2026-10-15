namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryTensorCreateInfoARM.html">VkExternalMemoryTensorCreateInfoARM</see> - Specify that a tensor may be backed by external memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To define a set of external memory handle types that may: be used as backing
    ///         store for a tensor, add a <c>VkExternalMemoryTensorCreateInfoARM</c>
    ///         structure to the <c>pNext</c> chain of the <c>VkTensorCreateInfoARM</c>
    ///         structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkExternalMemoryTensorCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkExternalMemoryTensorCreateInfoARM {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkExternalMemoryHandleTypeFlags    handleTypes;
    ///         } VkExternalMemoryTensorCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkExternalMemoryTensorCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalMemoryTensorCreateInfoARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleTypes</c>
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleTypes;
    }
}
