namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSampleLocationsPropertiesEXT.html">VkPhysicalDeviceSampleLocationsPropertiesEXT</see> - Structure describing sample location limits that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSampleLocationsPropertiesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkPhysicalDeviceSampleLocationsPropertiesEXT {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkSampleCountFlags    sampleLocationSampleCounts;
    ///             VkExtent2D            maxSampleLocationGridSize;
    ///             float                 sampleLocationCoordinateRange[2];
    ///             uint32_t              sampleLocationSubPixelBits;
    ///             VkBool32              variableSampleLocations;
    ///         } VkPhysicalDeviceSampleLocationsPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSampleLocationsPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SampleLocationSampleCounts</c>
        /// </summary>
        [FieldOffset(16)]
        public VkSampleCountFlags SampleLocationSampleCounts;

        /// <summary>
        ///     <c>MaxSampleLocationGridSize</c>
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D MaxSampleLocationGridSize;

        /// <summary>
        ///     <c>SampleLocationCoordinateRange</c>
        /// </summary>
        [FieldOffset(28)]
        public float2 SampleLocationCoordinateRange;

        /// <summary>
        ///     <c>SampleLocationSubPixelBits</c>
        /// </summary>
        [FieldOffset(36)]
        public int SampleLocationSubPixelBits;

        /// <summary>
        ///     <c>VariableSampleLocations</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 VariableSampleLocations;
    }
}
