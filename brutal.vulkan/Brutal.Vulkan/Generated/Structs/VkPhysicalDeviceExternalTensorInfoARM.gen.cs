namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalTensorInfoARM.html">VkPhysicalDeviceExternalTensorInfoARM</see> - Structure specifying tensor creation parameters.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalTensorInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkPhysicalDeviceExternalTensorInfoARM {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkTensorCreateFlagsARM                flags;
    ///             const VkTensorDescriptionARM*         pDescription;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkPhysicalDeviceExternalTensorInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceExternalTensorInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalTensorInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkTensorCreateFlagsARM</c> describing additional parameters of the tensor, corresponding to <c>VkTensorCreateInfoARM::flags</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorCreateFlagsARM Flags;

        /// <summary>
        ///     <c>Description</c> is a <c>VkTensorDescriptionARM</c> structure describing the tensor, corresponding to <c>VkTensorCreateInfoARM::pDescription</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorDescriptionARM* Description;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the external memory handle type for which capabilities will be returned.
        /// </summary>
        [FieldOffset(32)]
        public VkExternalMemoryHandleTypeFlags HandleType;
    }
}
