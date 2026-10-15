namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkComputePipelineIndirectBufferInfoNV.html">VkComputePipelineIndirectBufferInfoNV</see> - Structure describing the device address where pipeline&amp;apos;s metadata will be saved
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkComputePipelineIndirectBufferInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_generated_commands_compute
    ///         typedef struct VkComputePipelineIndirectBufferInfoNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceAddress    deviceAddress;
    ///             VkDeviceSize       size;
    ///             VkDeviceAddress    pipelineDeviceAddressCaptureReplay;
    ///         } VkComputePipelineIndirectBufferInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkComputePipelineIndirectBufferInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ComputePipelineIndirectBufferInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceAddress</c> is the address where the pipeline&apos;s metadata will be stored.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddress DeviceAddress;

        /// <summary>
        ///     <c>Size</c> is the size of pipeline&apos;s metadata that was queried using <c>vkGetPipelineIndirectMemoryRequirementsNV</c>.
        /// </summary>
        [FieldOffset(24)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>PipelineDeviceAddressCaptureReplay</c> is the device address where pipeline&apos;s metadata was originally saved and can now be used to re-populate <c>deviceAddress</c> for replay.
        /// </summary>
        [FieldOffset(32)]
        public VkDeviceAddress PipelineDeviceAddressCaptureReplay;
    }
}
