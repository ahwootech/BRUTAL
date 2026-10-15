namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindImagePlaneMemoryInfo.html">VkBindImagePlaneMemoryInfo</see> - Structure specifying how to bind an image plane to memory
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         In order to bind <i>planes</i> of a <i>disjoint image</i>, add a
    ///         <c>VkBindImagePlaneMemoryInfo</c> structure to the <c>pNext</c> chain of
    ///         <c>VkBindImageMemoryInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkBindImagePlaneMemoryInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkBindImagePlaneMemoryInfo {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkImageAspectFlagBits    planeAspect;
    ///         } VkBindImagePlaneMemoryInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkBindImagePlaneMemoryInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.BindImagePlaneMemoryInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PlaneAspect</c> is a <c>VkImageAspectFlags</c> value specifying the aspect of the disjoint image plane to bind.
        /// </summary>
        [FieldOffset(16)]
        public VkImageAspectFlags PlaneAspect;
    }
}
