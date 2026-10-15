namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceImageMemoryRequirements.html">VkDeviceImageMemoryRequirements</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceImageMemoryRequirements</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkDeviceImageMemoryRequirements {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             const VkImageCreateInfo*    pCreateInfo;
    ///             VkImageAspectFlagBits       planeAspect;
    ///         } VkDeviceImageMemoryRequirements;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDeviceImageMemoryRequirements()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceImageMemoryRequirements;

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
        ///     <c>PlaneAspect</c> is a <c>VkImageAspectFlags</c> value specifying the aspect corresponding to the image plane to query. This parameter is ignored unless <c>pCreateInfo</c>-&gt;flags has <c>VK_IMAGE_CREATE_DISJOINT_BIT</c> set.
        /// </summary>
        [FieldOffset(24)]
        public VkImageAspectFlags PlaneAspect;
    }
}
