namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance7PropertiesKHR.html">VkPhysicalDeviceMaintenance7PropertiesKHR</see> - Structure describing various implementation-defined properties introduced with VK_KHR_maintenance7
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance7PropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance7
    ///         typedef struct VkPhysicalDeviceMaintenance7PropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           robustFragmentShadingRateAttachmentAccess;
    ///             VkBool32           separateDepthStencilAttachmentAccess;
    ///             uint32_t           maxDescriptorSetTotalUniformBuffersDynamic;
    ///             uint32_t           maxDescriptorSetTotalStorageBuffersDynamic;
    ///             uint32_t           maxDescriptorSetTotalBuffersDynamic;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
    ///             uint32_t           maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
    ///         } VkPhysicalDeviceMaintenance7PropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceMaintenance7PropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance7PropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RobustFragmentShadingRateAttachmentAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RobustFragmentShadingRateAttachmentAccess;

        /// <summary>
        ///     <c>SeparateDepthStencilAttachmentAccess</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 SeparateDepthStencilAttachmentAccess;

        /// <summary>
        ///     <c>MaxDescriptorSetTotalUniformBuffersDynamic</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxDescriptorSetTotalUniformBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetTotalStorageBuffersDynamic</c>
        /// </summary>
        [FieldOffset(28)]
        public int MaxDescriptorSetTotalStorageBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetTotalBuffersDynamic</c>
        /// </summary>
        [FieldOffset(32)]
        public int MaxDescriptorSetTotalBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic</c>
        /// </summary>
        [FieldOffset(36)]
        public int MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic</c>
        /// </summary>
        [FieldOffset(40)]
        public int MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

        /// <summary>
        ///     <c>MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic</c>
        /// </summary>
        [FieldOffset(44)]
        public int MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
    }
}
