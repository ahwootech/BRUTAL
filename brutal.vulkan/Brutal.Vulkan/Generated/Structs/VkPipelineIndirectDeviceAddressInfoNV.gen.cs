namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineIndirectDeviceAddressInfoNV.html">VkPipelineIndirectDeviceAddressInfoNV</see> - Structure specifying the pipeline to query an address for
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkPipelineIndirectDeviceAddressInfoNV
    ///     </para>
    ///     <para>
    ///         The <c>VkPipelineIndirectDeviceAddressInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands_compute
    ///         typedef struct VkPipelineIndirectDeviceAddressInfoNV {
    ///             VkStructureType        sType;
    ///             const void*            pNext;
    ///             VkPipelineBindPoint    pipelineBindPoint;
    ///             VkPipeline             pipeline;
    ///         } VkPipelineIndirectDeviceAddressInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineIndirectDeviceAddressInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PipelineIndirectDeviceAddressInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PipelineBindPoint</c> is a <c>VkPipelineBindPoint</c> value specifying the type of pipeline whose device address is being queried.
        /// </summary>
        [FieldOffset(16)]
        public VkPipelineBindPoint PipelineBindPoint;

        /// <summary>
        ///     <c>Pipeline</c> specifies the pipeline whose device address is being queried.
        /// </summary>
        [FieldOffset(24)]
        public VkPipeline Pipeline;
    }
}
