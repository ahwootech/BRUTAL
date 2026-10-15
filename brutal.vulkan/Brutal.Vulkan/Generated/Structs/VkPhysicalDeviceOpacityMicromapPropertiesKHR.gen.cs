namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceOpacityMicromapPropertiesKHR.html">VkPhysicalDeviceOpacityMicromapPropertiesKHR</see> - Structure describing the opacity micromap properties of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceOpacityMicromapPropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_opacity_micromap
    ///         typedef struct VkPhysicalDeviceOpacityMicromapPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           maxOpacity2StateSubdivisionLevel;
    ///             uint32_t           maxOpacity4StateSubdivisionLevel;
    ///             uint32_t           maxOpacityLossy4StateSubdivisionLevel;
    ///             uint64_t           maxMicromapTriangles;
    ///         } VkPhysicalDeviceOpacityMicromapPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceOpacityMicromapPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceOpacityMicromapPropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxOpacity2StateSubdivisionLevel</c>
        /// </summary>
        [FieldOffset(16)]
        public int MaxOpacity2StateSubdivisionLevel;

        /// <summary>
        ///     <c>MaxOpacity4StateSubdivisionLevel</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxOpacity4StateSubdivisionLevel;

        /// <summary>
        ///     <c>MaxOpacityLossy4StateSubdivisionLevel</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxOpacityLossy4StateSubdivisionLevel;

        /// <summary>
        ///     <c>MaxMicromapTriangles</c>
        /// </summary>
        [FieldOffset(32)]
        public nint MaxMicromapTriangles;
    }
}
