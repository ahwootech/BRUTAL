namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSubpassShadingPropertiesHUAWEI.html">VkPhysicalDeviceSubpassShadingPropertiesHUAWEI</see> - Structure describing subpass shading properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSubpassShadingPropertiesHUAWEI</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_HUAWEI_subpass_shading
    ///         typedef struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxSubpassShadingWorkgroupSizeAspectRatio;
    ///         } VkPhysicalDeviceSubpassShadingPropertiesHUAWEI;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSubpassShadingPropertiesHUAWEI;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxSubpassShadingWorkgroupSizeAspectRatio</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxSubpassShadingWorkgroupSizeAspectRatio;
    }
}
