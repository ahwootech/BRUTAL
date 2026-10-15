namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSystemAllocationScope.html">VkSystemAllocationScope</see> - Allocation scope
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         [[memory-host-allocation-scope]]
    ///         Each allocation has an <i>allocation scope</i> defining its lifetime and which
    ///         object it is associated with.
    ///         Possible values passed to the <c>allocationScope</c> parameter of the
    ///         callback functions specified by <c>VkAllocationCallbacks</c>, indicating the
    ///         allocation scope, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSystemAllocationScope {
    ///             VK_SYSTEM_ALLOCATION_SCOPE_COMMAND = 0,
    ///             VK_SYSTEM_ALLOCATION_SCOPE_OBJECT = 1,
    ///             VK_SYSTEM_ALLOCATION_SCOPE_CACHE = 2,
    ///             VK_SYSTEM_ALLOCATION_SCOPE_DEVICE = 3,
    ///             VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE = 4,
    ///         } VkSystemAllocationScope;
    ///     </code>
    /// </remarks>
    public enum VkSystemAllocationScope : int
    {
        /// <summary>
        ///     <c>Command</c> specifies that the allocation is scoped to the duration of the Vulkan command.
        /// </summary>
        Command = 0,

        /// <summary>
        ///     <c>Object</c> specifies that the allocation is scoped to the lifetime of the Vulkan object that is being created or used.
        /// </summary>
        Object = 1,

        /// <summary>
        ///     <c>Cache</c> specifies that the allocation is scoped to the lifetime of a <c>VkPipelineCache</c> object.
        /// </summary>
        Cache = 2,

        /// <summary>
        ///     <c>Device</c> specifies that the allocation is scoped to the lifetime of the Vulkan device.
        /// </summary>
        Device = 3,

        /// <summary>
        ///     <c>Instance</c> specifies that the allocation is scoped to the lifetime of the Vulkan instance.  Most Vulkan commands operate on a single object, or there is a sole object that is being created or manipulated. When an allocation uses an allocation scope of <c>VK_SYSTEM_ALLOCATION_SCOPE_OBJECT</c> or <c>VK_SYSTEM_ALLOCATION_SCOPE_CACHE</c>, the allocation is scoped to the object being created or manipulated.  When an implementation requires host memory, it will make callbacks to the application using the most specific allocator and allocation scope available:
        /// </summary>
        Instance = 4,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
