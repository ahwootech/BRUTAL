namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryReportEventTypeEXT.html">VkDeviceMemoryReportEventTypeEXT</see> - Events that can occur on a device memory object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkDeviceMemoryReportCallbackDataEXT::type</c>,
    ///         specifying event types which cause the device driver to call the callback,
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_memory_report
    ///         typedef enum VkDeviceMemoryReportEventTypeEXT {
    ///             VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = 0,
    ///             VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = 1,
    ///             VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = 2,
    ///             VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = 3,
    ///             VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = 4,
    ///         } VkDeviceMemoryReportEventTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDeviceMemoryReportEventTypeEXT : int
    {
        /// <summary>
        ///     <c>AllocateEXT</c> specifies this event corresponds to the allocation of an internal device memory object or a <c>VkDeviceMemory</c>.
        /// </summary>
        AllocateEXT = 0,

        /// <summary>
        ///     <c>FreeEXT</c> specifies this event corresponds to the deallocation of an internally-allocated device memory object or a <c>VkDeviceMemory</c>.
        /// </summary>
        FreeEXT = 1,

        /// <summary>
        ///     <c>ImportEXT</c> specifies this event corresponds to the import of an external memory object.
        /// </summary>
        ImportEXT = 2,

        /// <summary>
        ///     <c>UnimportEXT</c> specifies this event is the release of an imported external memory object.
        /// </summary>
        UnimportEXT = 3,

        /// <summary>
        ///     <c>AllocationFailedEXT</c> specifies this event corresponds to the failed allocation of an internal device memory object or a <c>VkDeviceMemory</c>.
        /// </summary>
        AllocationFailedEXT = 4,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
