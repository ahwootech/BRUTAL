namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDisplayNativeHdrSurfaceCapabilitiesAMD.html">VkDisplayNativeHdrSurfaceCapabilitiesAMD</see> - Structure describing display native HDR specific capabilities of a surface
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDisplayNativeHdrSurfaceCapabilitiesAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_display_native_hdr
    ///         typedef struct VkDisplayNativeHdrSurfaceCapabilitiesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           localDimmingSupport;
    ///         } VkDisplayNativeHdrSurfaceCapabilitiesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LocalDimmingSupport</c> specifies whether the surface supports local dimming. If this is <c>VK_TRUE</c>, <c>VkSwapchainDisplayNativeHdrCreateInfoAMD</c> <i>can</i> be used to explicitly enable or disable local dimming for the surface. Local dimming may also be overridden by <c>vkSetLocalDimmingAMD</c> during the lifetime of the swapchain.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 LocalDimmingSupport;
    }
}
