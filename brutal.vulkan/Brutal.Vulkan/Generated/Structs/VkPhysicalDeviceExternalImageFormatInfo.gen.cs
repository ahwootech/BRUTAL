namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalImageFormatInfo.html">VkPhysicalDeviceExternalImageFormatInfo</see> - Structure specifying external image creation parameters
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To determine the image capabilities compatible with an external memory
    ///         handle type, add a <c>VkPhysicalDeviceExternalImageFormatInfo</c> structure
    ///         to the <c>pNext</c> chain of the <c>VkPhysicalDeviceImageFormatInfo2</c>
    ///         structure and a <c>VkExternalImageFormatProperties</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkImageFormatProperties2</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalImageFormatInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceExternalImageFormatInfo {
    ///             VkStructureType                       sType;
    ///             const void*                           pNext;
    ///             VkExternalMemoryHandleTypeFlagBits    handleType;
    ///         } VkPhysicalDeviceExternalImageFormatInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalImageFormatInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HandleType</c> is a <c>VkExternalMemoryHandleTypeFlags</c> value specifying the memory handle type that will be used with the memory associated with the image.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryHandleTypeFlags HandleType;
    }
}
