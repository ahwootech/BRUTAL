namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance10FeaturesKHR.html">VkPhysicalDeviceMaintenance10FeaturesKHR</see> - Structure describing whether the implementation supports maintenance10 functionality
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance10FeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef struct VkPhysicalDeviceMaintenance10FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           maintenance10;
    ///         } VkPhysicalDeviceMaintenance10FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMaintenance10FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance10FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Maintenance10</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Maintenance10;
    }
}
