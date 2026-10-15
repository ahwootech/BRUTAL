namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationCacheHeaderVersionEXT.html">VkValidationCacheHeaderVersionEXT</see> - Encode validation cache version
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the second group of four bytes in the header returned by
    ///         <c>vkGetValidationCacheDataEXT</c>, encoding the validation cache version,
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_cache
    ///         typedef enum VkValidationCacheHeaderVersionEXT {
    ///             VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT = 1,
    ///         } VkValidationCacheHeaderVersionEXT;
    ///     </code>
    /// </remarks>
    public enum VkValidationCacheHeaderVersionEXT : int
    {
        /// <summary>
        ///     <c>OneEXT</c> specifies version one of the validation cache.
        /// </summary>
        OneEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
