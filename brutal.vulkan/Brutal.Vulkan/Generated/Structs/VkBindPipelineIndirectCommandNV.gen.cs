namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBindPipelineIndirectCommandNV.html">VkBindPipelineIndirectCommandNV</see> - Structure specifying input data for the compute pipeline dispatch token
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBindPipelineIndirectCommandNV</c> structure specifies the input data
    ///         for the <c>VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV</c> token.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands_compute
    ///         typedef struct VkBindPipelineIndirectCommandNV {
    ///             VkDeviceAddress    pipelineAddress;
    ///         } VkBindPipelineIndirectCommandNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct VkBindPipelineIndirectCommandNV()
    {
        /// <summary>
        ///     <c>PipelineAddress</c> specifies the pipeline address of the compute pipeline that will be used in device generated rendering.
        /// </summary>
        [FieldOffset(0)]
        public VkDeviceAddress PipelineAddress;
    }
}
