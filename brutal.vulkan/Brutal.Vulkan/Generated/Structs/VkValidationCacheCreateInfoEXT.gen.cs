namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationCacheCreateInfoEXT.html">VkValidationCacheCreateInfoEXT</see> - Structure specifying parameters of a newly created validation cache
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkValidationCacheCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_cache
    ///         typedef struct VkValidationCacheCreateInfoEXT {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkValidationCacheCreateFlagsEXT    flags;
    ///             size_t                             initialDataSize;
    ///             const void*                        pInitialData;
    ///         } VkValidationCacheCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkValidationCacheCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ValidationCacheCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkValidationCacheCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>InitialDataSize</c> is the number of bytes in <c>pInitialData</c>. If <c>initialDataSize</c> is zero, the validation cache will initially be empty.
        /// </summary>
        [FieldOffset(24)]
        public nuint InitialDataSize;

        /// <summary>
        ///     <c>InitialData</c> is a pointer to previously retrieved validation cache data. If the validation cache data is incompatible (as defined below) with the device, the validation cache will be initially empty. If <c>initialDataSize</c> is zero, <c>pInitialData</c> is ignored.
        /// </summary>
        [FieldOffset(32)]
        public void* InitialData;
    }
}
