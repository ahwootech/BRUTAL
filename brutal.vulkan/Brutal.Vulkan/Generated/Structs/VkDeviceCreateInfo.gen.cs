namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceCreateInfo.html">VkDeviceCreateInfo</see> - Structure specifying parameters of a newly created device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkDeviceCreateInfo {
    ///             VkStructureType                    sType;
    ///             const void*                        pNext;
    ///             VkDeviceCreateFlags                flags;
    ///             uint32_t                           queueCreateInfoCount;
    ///             const VkDeviceQueueCreateInfo*     pQueueCreateInfos;
    ///             // enabledLayerCount is legacy and not used
    ///             uint32_t                           enabledLayerCount;
    ///             // ppEnabledLayerNames is legacy and not used
    ///             const char* const*                 ppEnabledLayerNames;
    ///             uint32_t                           enabledExtensionCount;
    ///             const char* const*                 ppEnabledExtensionNames;
    ///             const VkPhysicalDeviceFeatures*    pEnabledFeatures;
    ///         } VkDeviceCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public unsafe partial struct VkDeviceCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceCreateFlags Flags;

        /// <summary>
        ///     <c>QueueCreateInfoCount</c> is the unsigned integer size of the <c>pQueueCreateInfos</c> array. Refer to the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#devsandqueues-queue-creation">Queue Creation^</see> section below for further details.
        /// </summary>
        [FieldOffset(20)]
        public int QueueCreateInfoCount;

        /// <summary>
        ///     <c>QueueCreateInfos</c> is a pointer to an array of <c>VkDeviceQueueCreateInfo</c> structures describing the queues that are requested to be created along with the logical device. Refer to the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#devsandqueues-queue-creation">Queue Creation^</see> section below for further details.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceQueueCreateInfo* QueueCreateInfos;

        /// <summary>
        ///     <c>EnabledLayerCount</c> is legacy and not used. Implementations <i>must</i> not access this parameter. It <i>must</i> be 0. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#legacy-devicelayers">here</see>.
        /// </summary>
        [FieldOffset(32)]
        public int EnabledLayerCount;

        /// <summary>
        ///     <c>ppEnabledLayerNames</c> is legacy and not used. Implementations <i>must</i> not access this parameter. It <i>must</i> be `NULL`. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#legacy-devicelayers">here</see>.
        /// </summary>
        [FieldOffset(40)]
        public byte** ppEnabledLayerNames;

        /// <summary>
        ///     <c>EnabledExtensionCount</c> is the number of device extensions to enable.
        /// </summary>
        [FieldOffset(48)]
        public int EnabledExtensionCount;

        /// <summary>
        ///     <c>ppEnabledExtensionNames</c> is a pointer to an array of <c>enabledExtensionCount</c> null-terminated UTF-8 strings containing the names of extensions to enable for the created device. See the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#extendingvulkan-extensions">here</see> section for further details.
        /// </summary>
        [FieldOffset(56)]
        public byte** ppEnabledExtensionNames;

        /// <summary>
        ///     <c>EnabledFeatures</c> is `NULL` or a pointer to a <c>VkPhysicalDeviceFeatures</c> structure containing boolean indicators of all the features to be enabled. Refer to the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features">Features^</see> section for further details.
        /// </summary>
        [FieldOffset(64)]
        public VkPhysicalDeviceFeatures* EnabledFeatures;
    }
}
