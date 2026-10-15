namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL.html">VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL</see> - Structure describing shader integer functions that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_INTEL_shader_integer_functions2
    ///         typedef struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderIntegerFunctions2;
    ///         } VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderIntegerFunctions2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderIntegerFunctions2;
    }
}
