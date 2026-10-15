namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderInstrumentationMetricDescriptionARM.html">VkShaderInstrumentationMetricDescriptionARM</see> - Structure specifying shader instrumentation metric properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkShaderInstrumentationMetricDescriptionARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_instrumentation
    ///         typedef struct VkShaderInstrumentationMetricDescriptionARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             char               name[VK_MAX_DESCRIPTION_SIZE];
    ///             char               description[VK_MAX_DESCRIPTION_SIZE];
    ///         } VkShaderInstrumentationMetricDescriptionARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 528)]
    public unsafe partial struct VkShaderInstrumentationMetricDescriptionARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ShaderInstrumentationMetricDescriptionARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        ///
        [FieldOffset(16)]
        public fixed byte Name[256];

        ///
        [FieldOffset(272)]
        public fixed byte Description[256];
    }
}
