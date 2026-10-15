namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkValidationCacheEXT.html">VkValidationCacheEXT</see> - Opaque handle to a validation cache object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Validation cache objects allow the result of internal validation to be
    ///         reused, both within a single application run and between multiple runs.
    ///         Reuse within a single run is achieved by passing the same validation cache
    ///         object when creating supported Vulkan objects.
    ///         Reuse across runs of an application is achieved by retrieving validation
    ///         cache contents in one run of an application, saving the contents, and using
    ///         them to preinitialize a validation cache on a subsequent run.
    ///         The contents of the validation cache objects are managed by the validation
    ///         layers.
    ///         Applications <i>can</i> manage the host memory consumed by a validation cache
    ///         object and control the amount of data retrieved from a validation cache
    ///         object.
    ///     </para>
    ///     <para>
    ///         Validation cache objects are represented by <c>VkValidationCacheEXT</c>
    ///         handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_validation_cache
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkValidationCacheEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkValidationCacheEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.ValidationCacheEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkValidationCacheEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkValidationCacheEXT NullHandle = new();
    }
}
