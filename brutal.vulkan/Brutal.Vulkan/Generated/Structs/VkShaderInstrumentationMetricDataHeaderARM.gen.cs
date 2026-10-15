namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderInstrumentationMetricDataHeaderARM.html">VkShaderInstrumentationMetricDataHeaderARM</see> - Structure describing the header of a metric block
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The shader instrumentation metrics block header is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_instrumentation
    ///         typedef struct VkShaderInstrumentationMetricDataHeaderARM {
    ///             uint32_t              resultIndex;
    ///             uint32_t              resultSubIndex;
    ///             VkShaderStageFlags    stages;
    ///             uint32_t              basicBlockIndex;
    ///         } VkShaderInstrumentationMetricDataHeaderARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct VkShaderInstrumentationMetricDataHeaderARM()
    {
        /// <summary>
        ///     <c>ResultIndex</c> is the result index of the metric block, as captured when the command was recorded.
        /// </summary>
        [FieldOffset(0)]
        public int ResultIndex;

        /// <summary>
        ///     <c>ResultSubIndex</c> is a secondary index with the result index, explained further below.
        /// </summary>
        [FieldOffset(4)]
        public int ResultSubIndex;

        /// <summary>
        ///     <c>Stages</c> is a bitfield of <c>VkShaderStageFlags</c> describing the shader stages that the metric block is for.
        /// </summary>
        [FieldOffset(8)]
        public VkShaderStageFlags Stages;

        /// <summary>
        ///     <c>BasicBlockIndex</c> is the index of the basic block within the shader that the metric block is for.
        /// </summary>
        [FieldOffset(12)]
        public int BasicBlockIndex;
    }
}
