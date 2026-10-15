namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDepthBiasControlFeaturesEXT.html">VkPhysicalDeviceDepthBiasControlFeaturesEXT</see> - Structure indicating support for depth bias scaling and representation control
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDepthBiasControlFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_depth_bias_control
    ///         typedef struct VkPhysicalDeviceDepthBiasControlFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           depthBiasControl;
    ///             VkBool32           leastRepresentableValueForceUnormRepresentation;
    ///             VkBool32           floatRepresentation;
    ///             VkBool32           depthBiasExact;
    ///         } VkPhysicalDeviceDepthBiasControlFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceDepthBiasControlFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDepthBiasControlFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DepthBiasControl</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DepthBiasControl;

        /// <summary>
        ///     <c>LeastRepresentableValueForceUnormRepresentation</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 LeastRepresentableValueForceUnormRepresentation;

        /// <summary>
        ///     <c>FloatRepresentation</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 FloatRepresentation;

        /// <summary>
        ///     <c>DepthBiasExact</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 DepthBiasExact;
    }
}
