namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderOCPMicroscalingTypesFeaturesEXT.html">VkPhysicalDeviceShaderOCPMicroscalingTypesFeaturesEXT</see> - Structure describing OCP microscaling types features that can be supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderOCPMicroscalingTypesFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_ocp_microscaling_types
    ///         typedef struct VkPhysicalDeviceShaderOCPMicroscalingTypesFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderFloat4;
    ///             VkBool32           shaderFloat6;
    ///             VkBool32           shaderFloat8UnsignedE8M0;
    ///             VkBool32           shaderMXInt8;
    ///         } VkPhysicalDeviceShaderOCPMicroscalingTypesFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderOCPMicroscalingTypesFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderOcpMicroscalingTypesFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderFloat4</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderFloat4;

        /// <summary>
        ///     <c>ShaderFloat6</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderFloat6;

        /// <summary>
        ///     <c>ShaderFloat8UnsignedE8M0</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderFloat8UnsignedE8M0;

        /// <summary>
        ///     <c>ShaderMXInt8</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderMXInt8;
    }
}
