namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugReportCallbackCreateInfoEXT.html">VkDebugReportCallbackCreateInfoEXT</see> - Structure specifying parameters of a newly created debug report callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The definition of <c>VkDebugReportCallbackCreateInfoEXT</c> is:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_report
    ///         typedef struct VkDebugReportCallbackCreateInfoEXT {
    ///             VkStructureType                 sType;
    ///             const void*                     pNext;
    ///             VkDebugReportFlagsEXT           flags;
    ///             PFN_vkDebugReportCallbackEXT    pfnCallback;
    ///             void*                           pUserData;
    ///         } VkDebugReportCallbackCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkDebugReportCallbackCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugReportCallbackCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkDebugReportFlagsEXT</c> specifying which event(s) will cause this callback to be called.
        /// </summary>
        [FieldOffset(16)]
        public VkDebugReportFlagsEXT Flags;

        /// <summary>
        ///     <c>PfnCallback</c> is the application callback function to call.
        /// </summary>
        [FieldOffset(24)]
        public PfnVkDebugReportCallbackEXT PfnCallback;

        /// <summary>
        ///     <c>UserData</c> is NULL or an application-defined user data pointer to be passed to the callback.
        /// </summary>
        [FieldOffset(32)]
        public void* UserData;
    }
}
