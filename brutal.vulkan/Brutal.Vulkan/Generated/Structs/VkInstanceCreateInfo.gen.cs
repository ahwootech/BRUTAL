namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkInstanceCreateInfo.html">VkInstanceCreateInfo</see> - Structure specifying parameters of a newly created instance
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkInstanceCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkInstanceCreateInfo {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkInstanceCreateFlags       flags;
    ///             const VkApplicationInfo*    pApplicationInfo;
    ///             uint32_t                    enabledLayerCount;
    ///             const char* const*          ppEnabledLayerNames;
    ///             uint32_t                    enabledExtensionCount;
    ///             const char* const*          ppEnabledExtensionNames;
    ///         } VkInstanceCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkInstanceCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.InstanceCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkInstanceCreateFlags</c> indicating the behavior of the instance.
        /// </summary>
        [FieldOffset(16)]
        public VkInstanceCreateFlags Flags;

        /// <summary>
        ///     <c>ApplicationInfo</c> is `NULL` or a pointer to a <c>VkApplicationInfo</c> structure. If not `NULL`, this information helps implementations recognize behavior inherent to classes of applications. <c>VkApplicationInfo</c> is defined in detail below.
        /// </summary>
        [FieldOffset(24)]
        public VkApplicationInfo* ApplicationInfo;

        /// <summary>
        ///     <c>EnabledLayerCount</c> is the number of global layers to enable.
        /// </summary>
        [FieldOffset(32)]
        public int EnabledLayerCount;

        /// <summary>
        ///     <c>ppEnabledLayerNames</c> is a pointer to an array of <c>enabledLayerCount</c> null-terminated UTF-8 strings containing the names of layers to enable for the created instance. The layers are loaded in the order they are listed in this array, with the first array element being the closest to the application, and the last array element being the closest to the driver. See the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#extendingvulkan-layers">here</see> section for further details.
        /// </summary>
        [FieldOffset(40)]
        public byte** ppEnabledLayerNames;

        /// <summary>
        ///     <c>EnabledExtensionCount</c> is the number of global extensions to enable.
        /// </summary>
        [FieldOffset(48)]
        public int EnabledExtensionCount;

        /// <summary>
        ///     <c>ppEnabledExtensionNames</c> is a pointer to an array of <c>enabledExtensionCount</c> null-terminated UTF-8 strings containing the names of extensions to enable.
        /// </summary>
        [FieldOffset(56)]
        public byte** ppEnabledExtensionNames;
    }
}
