namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderInstrumentationCreateInfoARM.html">VkShaderInstrumentationCreateInfoARM</see> - Structure specifying parameters of a newly created shader instrumentation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkShaderInstrumentationCreateInfoARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_instrumentation
    ///         typedef struct VkShaderInstrumentationCreateInfoARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///         } VkShaderInstrumentationCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkShaderInstrumentationCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderInstrumentationCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
