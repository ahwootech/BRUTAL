namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVulkan11Properties.html">VkPhysicalDeviceVulkan11Properties</see> - Structure specifying physical device properties for functionality promoted to Vulkan 1.1
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVulkan11Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceVulkan11Properties {
    ///             VkStructureType            sType;
    ///             void*                      pNext;
    ///             uint8_t                    deviceUUID[VK_UUID_SIZE];
    ///             uint8_t                    driverUUID[VK_UUID_SIZE];
    ///             uint8_t                    deviceLUID[VK_LUID_SIZE];
    ///             uint32_t                   deviceNodeMask;
    ///             VkBool32                   deviceLUIDValid;
    ///             uint32_t                   subgroupSize;
    ///             VkShaderStageFlags         subgroupSupportedStages;
    ///             VkSubgroupFeatureFlags     subgroupSupportedOperations;
    ///             VkBool32                   subgroupQuadOperationsInAllStages;
    ///             VkPointClippingBehavior    pointClippingBehavior;
    ///             uint32_t                   maxMultiviewViewCount;
    ///             uint32_t                   maxMultiviewInstanceIndex;
    ///             VkBool32                   protectedNoFault;
    ///             uint32_t                   maxPerSetDescriptors;
    ///             VkDeviceSize               maxMemoryAllocationSize;
    ///         } VkPhysicalDeviceVulkan11Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public unsafe partial struct VkPhysicalDeviceVulkan11Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVulkan11Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte DeviceUUID[16];

        ///
        [FieldOffset(32)]
        public fixed byte DriverUUID[16];

        ///
        [FieldOffset(48)]
        public fixed byte DeviceLUID[8];

        /// <summary>
        ///     <c>DeviceNodeMask</c>
        /// </summary>
        [FieldOffset(56)]
        public int DeviceNodeMask;

        /// <summary>
        ///     <c>DeviceLUIDValid</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 DeviceLUIDValid;

        /// <summary>
        ///     <c>SubgroupSize</c>
        /// </summary>
        [FieldOffset(64)]
        public int SubgroupSize;

        /// <summary>
        ///     <c>SubgroupSupportedStages</c>
        /// </summary>
        [FieldOffset(68)]
        public VkShaderStageFlags SubgroupSupportedStages;

        /// <summary>
        ///     <c>SubgroupSupportedOperations</c>
        /// </summary>
        [FieldOffset(72)]
        public VkSubgroupFeatureFlags SubgroupSupportedOperations;

        /// <summary>
        ///     <c>SubgroupQuadOperationsInAllStages</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 SubgroupQuadOperationsInAllStages;

        /// <summary>
        ///     <c>PointClippingBehavior</c>
        /// </summary>
        [FieldOffset(80)]
        public VkPointClippingBehavior PointClippingBehavior;

        /// <summary>
        ///     <c>MaxMultiviewViewCount</c>
        /// </summary>
        [FieldOffset(84)]
        public int MaxMultiviewViewCount;

        /// <summary>
        ///     <c>MaxMultiviewInstanceIndex</c>
        /// </summary>
        [FieldOffset(88)]
        public int MaxMultiviewInstanceIndex;

        /// <summary>
        ///     <c>ProtectedNoFault</c>
        /// </summary>
        [FieldOffset(92)]
        public Brutal.Bool32 ProtectedNoFault;

        /// <summary>
        ///     <c>MaxPerSetDescriptors</c>
        /// </summary>
        [FieldOffset(96)]
        public int MaxPerSetDescriptors;

        /// <summary>
        ///     <c>MaxMemoryAllocationSize</c>
        /// </summary>
        [FieldOffset(104)]
        public ByteSize64 MaxMemoryAllocationSize;
    }
}
