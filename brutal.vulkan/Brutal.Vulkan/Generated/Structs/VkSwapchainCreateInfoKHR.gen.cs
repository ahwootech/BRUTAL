namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSwapchainCreateInfoKHR.html">VkSwapchainCreateInfoKHR</see> - Structure specifying parameters of a newly created swapchain object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSwapchainCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_swapchain
    ///         typedef struct VkSwapchainCreateInfoKHR {
    ///             VkStructureType                  sType;
    ///             const void*                      pNext;
    ///             VkSwapchainCreateFlagsKHR        flags;
    ///             VkSurfaceKHR                     surface;
    ///             uint32_t                         minImageCount;
    ///             VkFormat                         imageFormat;
    ///             VkColorSpaceKHR                  imageColorSpace;
    ///             VkExtent2D                       imageExtent;
    ///             uint32_t                         imageArrayLayers;
    ///             VkImageUsageFlags                imageUsage;
    ///             VkSharingMode                    imageSharingMode;
    ///             uint32_t                         queueFamilyIndexCount;
    ///             const uint32_t*                  pQueueFamilyIndices;
    ///             VkSurfaceTransformFlagBitsKHR    preTransform;
    ///             VkCompositeAlphaFlagBitsKHR      compositeAlpha;
    ///             VkPresentModeKHR                 presentMode;
    ///             VkBool32                         clipped;
    ///             VkSwapchainKHR                   oldSwapchain;
    ///         } VkSwapchainCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct VkSwapchainCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SwapchainCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSwapchainCreateFlagsKHR</c> indicating parameters of the swapchain creation.
        /// </summary>
        [FieldOffset(16)]
        public VkSwapchainCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Surface</c> is the surface onto which the swapchain will present images. If the creation succeeds, the swapchain becomes associated with <c>surface</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkSurfaceKHR Surface;

        /// <summary>
        ///     <c>MinImageCount</c> is the minimum number of presentable images that the application needs. The implementation will either create the swapchain with at least that many images, or it will fail to create the swapchain.
        /// </summary>
        [FieldOffset(32)]
        public int MinImageCount;

        /// <summary>
        ///     <c>ImageFormat</c> is a <c>VkFormat</c> value specifying the format the swapchain image(s) will be created with.
        /// </summary>
        [FieldOffset(36)]
        public VkFormat ImageFormat;

        /// <summary>
        ///     <c>ImageColorSpace</c> is a <c>VkColorSpaceKHR</c> value specifying the way the swapchain interprets image data.
        /// </summary>
        [FieldOffset(40)]
        public VkColorSpaceKHR ImageColorSpace;

        /// <summary>
        ///     <c>ImageExtent</c> is the size (in pixels) of the swapchain image(s). The behavior is platform-dependent if the image extent does not match the surface&apos;s <c>currentExtent</c> as returned by <c>vkGetPhysicalDeviceSurfaceCapabilitiesKHR</c>. + [NOTE]
        /// </summary>
        [FieldOffset(44)]
        public VkExtent2D ImageExtent;

        /// <summary>
        ///     <c>ImageArrayLayers</c>
        /// </summary>
        [FieldOffset(52)]
        public int ImageArrayLayers;

        /// <summary>
        ///     <c>ImageUsage</c>
        /// </summary>
        [FieldOffset(56)]
        public VkImageUsageFlags ImageUsage;

        /// <summary>
        ///     <c>ImageSharingMode</c>
        /// </summary>
        [FieldOffset(60)]
        public VkSharingMode ImageSharingMode;

        /// <summary>
        ///     <c>QueueFamilyIndexCount</c>
        /// </summary>
        [FieldOffset(64)]
        public int QueueFamilyIndexCount;

        /// <summary>
        ///     <c>QueueFamilyIndices</c>
        /// </summary>
        [FieldOffset(72)]
        public int* QueueFamilyIndices;

        /// <summary>
        ///     <c>PreTransform</c>
        /// </summary>
        [FieldOffset(80)]
        public VkSurfaceTransformFlagsKHR PreTransform;

        /// <summary>
        ///     <c>CompositeAlpha</c>
        /// </summary>
        [FieldOffset(84)]
        public VkCompositeAlphaFlagsKHR CompositeAlpha;

        /// <summary>
        ///     <c>PresentMode</c>
        /// </summary>
        [FieldOffset(88)]
        public VkPresentModeKHR PresentMode;

        /// <summary>
        ///     <c>Clipped</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 Clipped;

        /// <summary>
        ///     <c>OldSwapchain</c>
        /// </summary>
        [FieldOffset(96)]
        public VkSwapchainKHR OldSwapchain;
    }
}
