namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPropertiesKHR.html">VkDisplayPropertiesKHR</see> - Structure describing an available display device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplayPropertiesKHR {
    ///             VkDisplayKHR                  display;
    ///             const char*                   displayName;
    ///             VkExtent2D                    physicalDimensions;
    ///             VkExtent2D                    physicalResolution;
    ///             VkSurfaceTransformFlagsKHR    supportedTransforms;
    ///             VkBool32                      planeReorderPossible;
    ///             VkBool32                      persistentContent;
    ///         } VkDisplayPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDisplayPropertiesKHR()
    {
        /// <summary>
        ///     <c>Display</c> is a handle that is used to refer to the display described here. This handle will be valid for the lifetime of the Vulkan instance.
        /// </summary>
        [FieldOffset(0)]
        public VkDisplayKHR Display;

        /// <summary>
        ///     <c>DisplayName</c> is `NULL` or a pointer to a null-terminated UTF-8 string containing the name of the display. Generally, this will be the name provided by the display&apos;s EDID. If `NULL`, no suitable name is available. If not `NULL`, the string pointed to <i>must</i> remain accessible and unmodified as long as <c>display</c> is valid.
        /// </summary>
        [FieldOffset(8)]
        public byte* DisplayName;

        /// <summary>
        ///     <c>PhysicalDimensions</c> describes the physical width and height of the visible portion of the display, in millimeters.
        /// </summary>
        [FieldOffset(16)]
        public VkExtent2D PhysicalDimensions;

        /// <summary>
        ///     <c>PhysicalResolution</c> describes the physical, native, or preferred resolution of the display.
        /// </summary>
        [FieldOffset(24)]
        public VkExtent2D PhysicalResolution;

        /// <summary>
        ///     <c>SupportedTransforms</c>
        /// </summary>
        [FieldOffset(32)]
        public VkSurfaceTransformFlagsKHR SupportedTransforms;

        /// <summary>
        ///     <c>PlaneReorderPossible</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 PlaneReorderPossible;

        /// <summary>
        ///     <c>PersistentContent</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 PersistentContent;
    }
}
