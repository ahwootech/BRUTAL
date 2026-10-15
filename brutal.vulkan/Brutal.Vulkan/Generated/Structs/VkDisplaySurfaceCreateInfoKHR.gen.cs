namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceCreateInfoKHR.html">VkDisplaySurfaceCreateInfoKHR</see> - Structure specifying parameters of a newly created display plane surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplaySurfaceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_display
    ///         typedef struct VkDisplaySurfaceCreateInfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkDisplaySurfaceCreateFlagsKHR    flags;
    ///             VkDisplayModeKHR                  displayMode;
    ///             uint32_t                          planeIndex;
    ///             uint32_t                          planeStackIndex;
    ///             VkSurfaceTransformFlagBitsKHR     transform;
    ///             float                             globalAlpha;
    ///             VkDisplayPlaneAlphaFlagBitsKHR    alphaMode;
    ///             VkExtent2D                        imageExtent;
    ///         } VkDisplaySurfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkDisplaySurfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplaySurfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use, and <i>must</i> be zero.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplaySurfaceCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>DisplayMode</c> is a <c>VkDisplayModeKHR</c> handle specifying the mode to use when displaying this surface.
        /// </summary>
        [FieldOffset(24)]
        public VkDisplayModeKHR DisplayMode;

        /// <summary>
        ///     <c>PlaneIndex</c> is the plane on which this surface appears.
        /// </summary>
        [FieldOffset(32)]
        public int PlaneIndex;

        /// <summary>
        ///     <c>PlaneStackIndex</c> is the z-order of the plane.
        /// </summary>
        [FieldOffset(36)]
        public int PlaneStackIndex;

        /// <summary>
        ///     <c>Transform</c> is a <c>VkSurfaceTransformFlagsKHR</c> value specifying the transformation to apply to images as part of the scanout operation.
        /// </summary>
        [FieldOffset(40)]
        public VkSurfaceTransformFlagsKHR Transform;

        /// <summary>
        ///     <c>GlobalAlpha</c> is the global alpha value. This value is ignored if <c>alphaMode</c> is not <c>VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR</c>.
        /// </summary>
        [FieldOffset(44)]
        public float GlobalAlpha;

        /// <summary>
        ///     <c>AlphaMode</c> is a <c>VkDisplayPlaneAlphaFlagsKHR</c> value specifying the type of alpha blending to use.
        /// </summary>
        [FieldOffset(48)]
        public VkDisplayPlaneAlphaFlagsKHR AlphaMode;

        /// <summary>
        ///     <c>ImageExtent</c> is the size of the presentable images to use with the surface.
        /// </summary>
        [FieldOffset(52)]
        public VkExtent2D ImageExtent;
    }
}
