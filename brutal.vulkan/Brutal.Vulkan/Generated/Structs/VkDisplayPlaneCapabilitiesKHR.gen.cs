namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneCapabilitiesKHR.html">VkDisplayPlaneCapabilitiesKHR</see> - Structure describing capabilities of a mode and plane combination
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPlaneCapabilitiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplayPlaneCapabilitiesKHR {
    ///             VkDisplayPlaneAlphaFlagsKHR    supportedAlpha;
    ///             VkOffset2D                     minSrcPosition;
    ///             VkOffset2D                     maxSrcPosition;
    ///             VkExtent2D                     minSrcExtent;
    ///             VkExtent2D                     maxSrcExtent;
    ///             VkOffset2D                     minDstPosition;
    ///             VkOffset2D                     maxDstPosition;
    ///             VkExtent2D                     minDstExtent;
    ///             VkExtent2D                     maxDstExtent;
    ///         } VkDisplayPlaneCapabilitiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial struct VkDisplayPlaneCapabilitiesKHR()
    {
        /// <summary>
        ///     <c>SupportedAlpha</c> is a bitmask of <c>VkDisplayPlaneAlphaFlagsKHR</c> describing the supported alpha blending modes.
        /// </summary>
        [FieldOffset(0)]
        public VkDisplayPlaneAlphaFlagsKHR SupportedAlpha;

        /// <summary>
        ///     <c>MinSrcPosition</c> is the minimum source rectangle offset supported by this plane using the specified mode.
        /// </summary>
        [FieldOffset(4)]
        public VkOffset2D MinSrcPosition;

        /// <summary>
        ///     <c>MaxSrcPosition</c> is the maximum source rectangle offset supported by this plane using the specified mode. The <c>x</c> and <c>y</c> components of <c>maxSrcPosition</c> <i>must</i> each be greater than or equal to the <c>x</c> and <c>y</c> components of <c>minSrcPosition</c>, respectively.
        /// </summary>
        [FieldOffset(12)]
        public VkOffset2D MaxSrcPosition;

        /// <summary>
        ///     <c>MinSrcExtent</c> is the minimum source rectangle size supported by this plane using the specified mode.
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D MinSrcExtent;

        /// <summary>
        ///     <c>MaxSrcExtent</c> is the maximum source rectangle size supported by this plane using the specified mode.
        /// </summary>
        [FieldOffset(28)]
        public VkExtent2D MaxSrcExtent;

        /// <summary>
        ///     <c>MinDstPosition</c>
        /// </summary>
        [FieldOffset(36)]
        public VkOffset2D MinDstPosition;

        /// <summary>
        ///     <c>MaxDstPosition</c>
        /// </summary>
        [FieldOffset(44)]
        public VkOffset2D MaxDstPosition;

        /// <summary>
        ///     <c>MinDstExtent</c>
        /// </summary>
        [FieldOffset(52)]
        public VkExtent2D MinDstExtent;

        /// <summary>
        ///     <c>MaxDstExtent</c>
        /// </summary>
        [FieldOffset(60)]
        public VkExtent2D MaxDstExtent;
    }
}
