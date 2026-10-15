namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderDrawParametersFeatures.html">VkPhysicalDeviceShaderDrawParametersFeatures</see> - Structure describing shader draw parameter features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderDrawParametersFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceShaderDrawParametersFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderDrawParameters;
    ///         } VkPhysicalDeviceShaderDrawParametersFeatures;
    ///     </code>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         // Equivalent to VkPhysicalDeviceShaderDrawParametersFeatures
    ///         typedef VkPhysicalDeviceShaderDrawParametersFeatures VkPhysicalDeviceShaderDrawParameterFeatures;
    ///         </code>
    ///     </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderDrawParameters</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderDrawParameters;
    }
}
