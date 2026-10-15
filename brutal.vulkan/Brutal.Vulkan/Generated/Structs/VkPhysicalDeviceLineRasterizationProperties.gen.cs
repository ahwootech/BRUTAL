namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceLineRasterizationProperties.html">VkPhysicalDeviceLineRasterizationProperties</see> - Structure describing line rasterization properties supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceLineRasterizationProperties</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceLineRasterizationProperties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           lineSubPixelPrecisionBits;
    ///         } VkPhysicalDeviceLineRasterizationProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceLineRasterizationProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceLineRasterizationProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>LineSubPixelPrecisionBits</c>
        /// </summary>
        [FieldOffset(16)]
        public int LineSubPixelPrecisionBits;
    }
}
