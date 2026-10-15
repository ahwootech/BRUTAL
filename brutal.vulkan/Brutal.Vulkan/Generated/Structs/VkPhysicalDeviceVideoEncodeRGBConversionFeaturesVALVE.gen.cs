namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE.html">VkPhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE</see> - Structure describing the video encode RGB conversion features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VALVE_video_encode_rgb_conversion
    ///         typedef struct VkPhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           videoEncodeRgbConversion;
    ///         } VkPhysicalDeviceVideoEncodeRgbConversionFeaturesVALVE;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceVideoEncodeRGBConversionFeaturesVALVE()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceVideoEncodeRGBConversionFeaturesVALVE;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>VideoEncodeRgbConversion</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 VideoEncodeRgbConversion;
    }
}
