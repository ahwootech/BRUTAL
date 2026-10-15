namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceDeviceMemoryReportCreateInfoEXT.html">VkDeviceDeviceMemoryReportCreateInfoEXT</see> - Register device memory report callbacks for a Vulkan device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To register callbacks for underlying device memory events of type
    ///         <c>VkDeviceMemoryReportEventTypeEXT</c>, add one or multiple
    ///         <c>VkDeviceDeviceMemoryReportCreateInfoEXT</c> structures to the <c>pNext</c>
    ///         chain of the <c>VkDeviceCreateInfo</c> structure.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_memory_report
    ///         typedef struct VkDeviceDeviceMemoryReportCreateInfoEXT {
    ///             VkStructureType                        sType;
    ///             const void*                            pNext;
    ///             VkDeviceMemoryReportFlagsEXT           flags;
    ///             PFN_vkDeviceMemoryReportCallbackEXT    pfnUserCallback;
    ///             void*                                  pUserData;
    ///         } VkDeviceDeviceMemoryReportCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDeviceDeviceMemoryReportCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceDeviceMemoryReportCreateInfoEXT;

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
        ///     <c>PfnUserCallback</c> is the application callback function to call.
        /// </summary>
        [FieldOffset(24)]
        public PfnVkDeviceMemoryReportCallbackEXT PfnUserCallback;

        /// <summary>
        ///     <c>UserData</c> is NULL or an application-defined user data pointer to be passed to the callback.
        /// </summary>
        [FieldOffset(32)]
        public void* UserData;
    }
}
