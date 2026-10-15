namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkResolveImageModeInfoKHR.html">VkResolveImageModeInfoKHR</see> - Structure specifying additional control for VkResolveImageInfo2
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkResolveImageModeInfoKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkResolveImageModeInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef struct VkResolveImageModeInfoKHR {
    ///             VkStructureType           sType;
    ///             const void*               pNext;
    ///             VkResolveImageFlagsKHR    flags;
    ///             VkResolveModeFlagBits     resolveMode;
    ///             VkResolveModeFlagBits     stencilResolveMode;
    ///         } VkResolveImageModeInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkResolveImageModeInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ResolveImageModeInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkResolveImageFlagsKHR</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkResolveImageFlagsKHR Flags;

        /// <summary>
        ///     <c>ResolveMode</c> is a <c>VkResolveModeFlags</c> value defining how <c>srcImage</c> will be resolved into <c>dstImage</c> when resolving non-stencil values.
        /// </summary>
        [FieldOffset(20)]
        public VkResolveModeFlags ResolveMode;

        /// <summary>
        ///     <c>StencilResolveMode</c> is a <c>VkResolveModeFlags</c> value defining how <c>srcImage</c> will be resolved into <c>dstImage</c> when resolving stencil values.
        /// </summary>
        [FieldOffset(24)]
        public VkResolveModeFlags StencilResolveMode;
    }
}
