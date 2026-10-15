namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHeadlessSurfaceCreateInfoEXT.html">VkHeadlessSurfaceCreateInfoEXT</see> - Structure specifying parameters of a newly created headless surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkHeadlessSurfaceCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_headless_surface
    ///         typedef struct VkHeadlessSurfaceCreateInfoEXT {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkHeadlessSurfaceCreateFlagsEXT    flags;
    ///         } VkHeadlessSurfaceCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.HeadlessSurfaceCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkHeadlessSurfaceCreateFlagsEXT Flags;
    }
}
