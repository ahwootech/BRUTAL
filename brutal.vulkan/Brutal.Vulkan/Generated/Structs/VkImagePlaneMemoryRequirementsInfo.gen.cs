namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImagePlaneMemoryRequirementsInfo.html">VkImagePlaneMemoryRequirementsInfo</see> - Structure specifying image plane for memory requirements
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To determine the memory requirements for a plane of a disjoint image, add a
    ///         <c>VkImagePlaneMemoryRequirementsInfo</c> structure to the <c>pNext</c> chain
    ///         of the <c>VkImageMemoryRequirementsInfo2</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkImagePlaneMemoryRequirementsInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkImagePlaneMemoryRequirementsInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkImageAspectFlagBits    planeAspect;
    ///         } VkImagePlaneMemoryRequirementsInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkImagePlaneMemoryRequirementsInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImagePlaneMemoryRequirementsInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PlaneAspect</c> is a <c>VkImageAspectFlags</c> value specifying the aspect corresponding to the image plane to query.
        /// </summary>
        [FieldOffset(16)]
        public VkImageAspectFlags PlaneAspect;
    }
}
