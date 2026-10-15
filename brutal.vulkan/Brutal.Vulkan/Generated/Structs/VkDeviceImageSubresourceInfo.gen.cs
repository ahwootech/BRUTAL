namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceImageSubresourceInfo.html">VkDeviceImageSubresourceInfo</see> - Image creation information for querying subresource layout
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDeviceImageSubresourceInfo
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceImageSubresourceInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkDeviceImageSubresourceInfo {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             const VkImageCreateInfo*      pCreateInfo;
    ///             const VkImageSubresource2*    pSubresource;
    ///         } VkDeviceImageSubresourceInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceImageSubresourceInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceImageSubresourceInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CreateInfo</c> is a pointer to a <c>VkImageCreateInfo</c> structure containing parameters affecting creation of the image to query.
        /// </summary>
        [FieldOffset(16)]
        public VkImageCreateInfo* CreateInfo;

        /// <summary>
        ///     <c>Subresource</c> is a pointer to a <c>VkImageSubresource2</c> structure selecting a specific image subresource for the query.
        /// </summary>
        [FieldOffset(24)]
        public VkImageSubresource2* Subresource;
    }
}
