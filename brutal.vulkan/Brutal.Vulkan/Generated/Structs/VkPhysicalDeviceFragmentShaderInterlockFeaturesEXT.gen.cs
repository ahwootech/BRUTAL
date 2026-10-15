namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT.html">VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT</see> - Structure describing fragment shader interlock features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_fragment_shader_interlock
    ///         typedef struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           fragmentShaderSampleInterlock;
    ///             VkBool32           fragmentShaderPixelInterlock;
    ///             VkBool32           fragmentShaderShadingRateInterlock;
    ///         } VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShaderInterlockFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentShaderSampleInterlock</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FragmentShaderSampleInterlock;

        /// <summary>
        ///     <c>FragmentShaderPixelInterlock</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 FragmentShaderPixelInterlock;

        /// <summary>
        ///     <c>FragmentShaderShadingRateInterlock</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 FragmentShaderShadingRateInterlock;
    }
}
