namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPresentInfoKHR.html">VkDisplayPresentInfoKHR</see> - Structure describing parameters of a queue presentation to a swapchain
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPresentInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display_swapchain
    ///         typedef struct VkDisplayPresentInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkRect2D           srcRect;
    ///             VkRect2D           dstRect;
    ///             VkBool32           persistent;
    ///         } VkDisplayPresentInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkDisplayPresentInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayPresentInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SrcRect</c> is a rectangular region of pixels to present. It <i>must</i> be a subset of the image being presented. If <c>VkDisplayPresentInfoKHR</c> is not specified, this region will be assumed to be the entire presentable image.
        /// </summary>
        [FieldOffset(16)]
        public VkRect2D SrcRect;

        /// <summary>
        ///     <c>DstRect</c> is a rectangular region within the visible region of the swapchain&apos;s display mode. If <c>VkDisplayPresentInfoKHR</c> is not specified, this region will be assumed to be the entire visible region of the swapchain&apos;s mode. If the specified rectangle is a subset of the display mode&apos;s visible region, content from display planes below the swapchain&apos;s plane will be visible outside the rectangle. If there are no planes below the swapchain&apos;s, the area outside the specified rectangle will be black. If portions of the specified rectangle are outside of the display&apos;s visible region, pixels mapping only to those portions of the rectangle will be discarded.
        /// </summary>
        [FieldOffset(32)]
        public VkRect2D DstRect;

        /// <summary>
        ///     <c>Persistent</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 Persistent;
    }
}
