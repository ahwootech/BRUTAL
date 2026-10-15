namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderFloat16Int8Features.html">VkPhysicalDeviceShaderFloat16Int8Features</see> - Structure describing features supported by VK_KHR_shader_float16_int8
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderFloat16Int8Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceShaderFloat16Int8Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderFloat16;
    ///             VkBool32           shaderInt8;
    ///         } VkPhysicalDeviceShaderFloat16Int8Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderFloat16Int8Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderFloat16</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderFloat16;

        /// <summary>
        ///     <c>ShaderInt8</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderInt8;
    }
}
