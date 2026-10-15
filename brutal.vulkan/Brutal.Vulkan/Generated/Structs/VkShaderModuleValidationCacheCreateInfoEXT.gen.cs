namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderModuleValidationCacheCreateInfoEXT.html">VkShaderModuleValidationCacheCreateInfoEXT</see> - Specify validation cache to use during shader module creation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To use a <c>VkValidationCacheEXT</c> to cache shader validation results, add
    ///         a <c>VkShaderModuleValidationCacheCreateInfoEXT</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkShaderModuleCreateInfo</c> structure,
    ///         specifying the cache object to use.
    ///     </para>
    ///     <para>
    ///         The <c>VkShaderModuleValidationCacheCreateInfoEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_cache
    ///         typedef struct VkShaderModuleValidationCacheCreateInfoEXT {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkValidationCacheEXT    validationCache;
    ///         } VkShaderModuleValidationCacheCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderModuleValidationCacheCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ValidationCache</c> is the validation cache object from which the results of prior validation attempts will be written, and to which new validation results for this <c>VkShaderModule</c> will be written (if not already present). The implementation <i>must</i> not access this object outside of the duration of the command this structure is passed to.
        /// </summary>
        [FieldOffset(16)]
        public VkValidationCacheEXT ValidationCache;
    }
}
