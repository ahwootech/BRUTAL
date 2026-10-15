namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayPlaneInfo2KHR.html">VkDisplayPlaneInfo2KHR</see> - Structure defining the intended configuration of a display plane
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayPlaneInfo2KHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_get_display_properties2
    ///         typedef struct VkDisplayPlaneInfo2KHR {
    ///             VkStructureType     sType;
    ///             const void*         pNext;
    ///             VkDisplayModeKHR    mode;
    ///             uint32_t            planeIndex;
    ///         } VkDisplayPlaneInfo2KHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDisplayPlaneInfo2KHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayPlaneInfo2KHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Mode</c> is the display mode the application intends to program when using the specified plane.
        /// </summary>
        [FieldOffset(16)]
        public VkDisplayModeKHR Mode;

        /// <summary>
        ///     <c>PlaneIndex</c>
        /// </summary>
        [FieldOffset(24)]
        public int PlaneIndex;
    }
}
