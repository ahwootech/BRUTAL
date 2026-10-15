namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderFloatControls2Features.html">VkPhysicalDeviceShaderFloatControls2Features</see> - Structure describing shader float controls 2 features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderFloatControls2Features</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceShaderFloatControls2Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderFloatControls2;
    ///         } VkPhysicalDeviceShaderFloatControls2Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderFloatControls2Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderFloatControls2Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderFloatControls2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderFloatControls2;
    }
}
