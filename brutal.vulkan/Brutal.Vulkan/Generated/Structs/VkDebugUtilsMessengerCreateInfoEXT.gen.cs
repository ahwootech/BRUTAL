namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerCreateInfoEXT.html">VkDebugUtilsMessengerCreateInfoEXT</see> - Structure specifying parameters of a newly created debug messenger
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The definition of <c>VkDebugUtilsMessengerCreateInfoEXT</c> is:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         typedef struct VkDebugUtilsMessengerCreateInfoEXT {
    ///             VkStructureType                         sType;
    ///             const void*                             pNext;
    ///             VkDebugUtilsMessengerCreateFlagsEXT     flags;
    ///             VkDebugUtilsMessageSeverityFlagsEXT     messageSeverity;
    ///             VkDebugUtilsMessageTypeFlagsEXT         messageType;
    ///             PFN_vkDebugUtilsMessengerCallbackEXT    pfnUserCallback;
    ///             void*                                   pUserData;
    ///         } VkDebugUtilsMessengerCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugUtilsMessengerCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is `0` and is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDebugUtilsMessengerCreateFlagsEXT Flags;

        /// <summary>
        ///     <c>MessageSeverity</c> is a bitmask of <c>VkDebugUtilsMessageSeverityFlagsEXT</c> specifying which severity of event(s) will cause this callback to be called.
        /// </summary>
        [FieldOffset(20)]
        public VkDebugUtilsMessageSeverityFlagsEXT MessageSeverity;

        /// <summary>
        ///     <c>MessageType</c> is a bitmask of <c>VkDebugUtilsMessageTypeFlagsEXT</c> specifying which type of event(s) will cause this callback to be called.
        /// </summary>
        [FieldOffset(24)]
        public VkDebugUtilsMessageTypeFlagsEXT MessageType;

        /// <summary>
        ///     <c>PfnUserCallback</c> is the application callback function to call.
        /// </summary>
        [FieldOffset(32)]
        public PfnVkDebugUtilsMessengerCallbackEXT PfnUserCallback;

        /// <summary>
        ///     <c>UserData</c> is NULL or an application-defined user data pointer to be passed to the callback.
        /// </summary>
        [FieldOffset(40)]
        public void* UserData;
    }
}
