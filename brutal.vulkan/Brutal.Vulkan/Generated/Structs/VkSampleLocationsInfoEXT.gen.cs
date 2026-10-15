namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSampleLocationsInfoEXT.html">VkSampleLocationsInfoEXT</see> - Structure specifying a set of sample locations
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSampleLocationsInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkSampleLocationsInfoEXT {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkSampleCountFlagBits         sampleLocationsPerPixel;
    ///             VkExtent2D                    sampleLocationGridSize;
    ///             uint32_t                      sampleLocationsCount;
    ///             const VkSampleLocationEXT*    pSampleLocations;
    ///         } VkSampleLocationsInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkSampleLocationsInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SampleLocationsInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SampleLocationsPerPixel</c> is a <c>VkSampleCountFlags</c> value specifying the number of sample locations per pixel.
        /// </summary>
        [FieldOffset(16)]
        public VkSampleCountFlags SampleLocationsPerPixel;

        /// <summary>
        ///     <c>SampleLocationGridSize</c> is the size of the sample location grid to select custom sample locations for.
        /// </summary>
        [FieldOffset(20)]
        public VkExtent2D SampleLocationGridSize;

        /// <summary>
        ///     <c>SampleLocationsCount</c> is the number of sample locations in <c>pSampleLocations</c>.
        /// </summary>
        [FieldOffset(28)]
        public int SampleLocationsCount;

        /// <summary>
        ///     <c>SampleLocations</c> is a pointer to an array of <c>sampleLocationsCount</c> <c>VkSampleLocationEXT</c> structures.
        /// </summary>
        [FieldOffset(32)]
        public VkSampleLocationEXT* SampleLocations;
    }
}
