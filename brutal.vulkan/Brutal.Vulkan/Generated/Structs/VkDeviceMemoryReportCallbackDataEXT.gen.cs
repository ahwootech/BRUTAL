namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceMemoryReportCallbackDataEXT.html">VkDeviceMemoryReportCallbackDataEXT</see> - Structure specifying parameters returned to the callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The definition of <c>VkDeviceMemoryReportCallbackDataEXT</c> is:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_memory_report
    ///         typedef struct VkDeviceMemoryReportCallbackDataEXT {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkDeviceMemoryReportFlagsEXT        flags;
    ///             VkDeviceMemoryReportEventTypeEXT    type;
    ///             uint64_t                            memoryObjectId;
    ///             VkDeviceSize                        size;
    ///             VkObjectType                        objectType;
    ///             uint64_t                            objectHandle;
    ///             uint32_t                            heapIndex;
    ///         } VkDeviceMemoryReportCallbackDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceMemoryReportCallbackDataEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is 0 and reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemoryReportFlagsEXT Flags;

        /// <summary>
        ///     <c>Type</c> is a <c>VkDeviceMemoryReportEventTypeEXT</c> type specifying the type of event reported in this <c>VkDeviceMemoryReportCallbackDataEXT</c> structure.
        /// </summary>
        [FieldOffset(20)]
        public VkDeviceMemoryReportEventTypeEXT Type;

        /// <summary>
        ///     <c>MemoryObjectId</c> is the unique id for the underlying memory object as described below.
        /// </summary>
        [FieldOffset(24)]
        public nint MemoryObjectId;

        /// <summary>
        ///     <c>Size</c> is the size of the memory object in bytes. If <c>type</c> is <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT</c>, <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT</c> or <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT</c>, <c>size</c> is a valid basetype:VkDeviceSize value. Otherwise, <c>size</c> is undefined:.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>ObjectType</c> is a <c>VkObjectType</c> value specifying the type of the object associated with this device memory report event. If <c>type</c> is <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT</c>, <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT</c>, <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT</c>, <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT</c> or <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT</c>, <c>objectType</c> is a valid <c>VkObjectType</c> enum. Otherwise, <c>objectType</c> is undefined:.
        /// </summary>
        [FieldOffset(40)]
        public VkObjectType ObjectType;

        /// <summary>
        ///     <c>ObjectHandle</c> is the object this device memory report event is attributed to. If <c>type</c> is <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT</c>, <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT</c>, <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT</c> or <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT</c>, <c>objectHandle</c> is a valid Vulkan handle of the type associated with <c>objectType</c> as defined in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#debugging-object-types">`VkObjectType` and Vulkan Handle Relationship^</see> table. Otherwise, <c>objectHandle</c> is undefined:.
        /// </summary>
        [FieldOffset(48)]
        public nint ObjectHandle;

        /// <summary>
        ///     <c>HeapIndex</c> describes which memory heap this device memory allocation is made from. If <c>type</c> is <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT</c> or <c>VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT</c>, <c>heapIndex</c> corresponds to one of the valid heaps from the <c>VkPhysicalDeviceMemoryProperties</c> structure. Otherwise, <c>heapIndex</c> is undefined:.
        /// </summary>
        [FieldOffset(56)]
        public int HeapIndex;
    }
}
