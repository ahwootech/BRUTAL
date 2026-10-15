namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTensorCreateInfoARM.html">VkTensorCreateInfoARM</see> - Structure specifying the parameters of a newly created tensor object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkTensorCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkTensorCreateInfoARM {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkTensorCreateFlagsARM           flags;
    ///             const VkTensorDescriptionARM*    pDescription;
    ///             VkSharingMode                    sharingMode;
    ///             uint32_t                         queueFamilyIndexCount;
    ///             const uint32_t*                  pQueueFamilyIndices;
    ///         } VkTensorCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkTensorCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.TensorCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkTensorCreateFlagsARM</c> describing additional parameters of the tensor.
        /// </summary>
        [FieldOffset(16)]
        public VkTensorCreateFlagsARM Flags;

        /// <summary>
        ///     <c>Description</c> is a pointer to an instance of <c>VkTensorDescriptionARM</c> describing the tensor.
        /// </summary>
        [FieldOffset(24)]
        public VkTensorDescriptionARM* Description;

        /// <summary>
        ///     <c>SharingMode</c> is a <c>VkSharingMode</c> value specifying the sharing mode of the tensor when it will be accessed by multiple queue families.
        /// </summary>
        [FieldOffset(32)]
        public VkSharingMode SharingMode;

        /// <summary>
        ///     <c>QueueFamilyIndexCount</c> is the number of entries in the <c>pQueueFamilyIndices</c> array.
        /// </summary>
        [FieldOffset(36)]
        public int QueueFamilyIndexCount;

        /// <summary>
        ///     <c>QueueFamilyIndices</c> is a list of queue families that will access this tensor (ignored if <c>sharingMode</c> is not <c>VK_SHARING_MODE_CONCURRENT</c>).
        /// </summary>
        [FieldOffset(40)]
        public int* QueueFamilyIndices;
    }
}
