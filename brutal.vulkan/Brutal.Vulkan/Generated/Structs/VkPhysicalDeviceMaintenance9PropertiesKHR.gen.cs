namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance9PropertiesKHR.html">VkPhysicalDeviceMaintenance9PropertiesKHR</see> - Structure describing various implementation-defined properties introduced with VK_KHR_maintenance9
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance9PropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance9
    ///         typedef struct VkPhysicalDeviceMaintenance9PropertiesKHR {
    ///             VkStructureType                     sType;
    ///             void*                               pNext;
    ///             VkBool32                            image2DViewOf3DSparse;
    ///             VkDefaultVertexAttributeValueKHR    defaultVertexAttributeValue;
    ///         } VkPhysicalDeviceMaintenance9PropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceMaintenance9PropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance9PropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image2DViewOf3DSparse</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Image2DViewOf3DSparse;

        /// <summary>
        ///     <c>DefaultVertexAttributeValue</c>
        /// </summary>
        [FieldOffset(20)]
        public VkDefaultVertexAttributeValueKHR DefaultVertexAttributeValue;
    }
}
