namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheHeaderVersionOne.html">VkPipelineCacheHeaderVersionOne</see> - Structure describing the layout of the pipeline cache header
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Version one of the pipeline cache header is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkPipelineCacheHeaderVersionOne {
    ///             uint32_t                        headerSize;
    ///             VkPipelineCacheHeaderVersion    headerVersion;
    ///             uint32_t                        vendorID;
    ///             uint32_t                        deviceID;
    ///             uint8_t                         pipelineCacheUUID[VK_UUID_SIZE];
    ///         } VkPipelineCacheHeaderVersionOne;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPipelineCacheHeaderVersionOne()
    {
        /// <summary>
        ///     <c>HeaderSize</c> is the length in bytes of the pipeline cache header.
        /// </summary>
        [FieldOffset(0)]
        public int HeaderSize;

        /// <summary>
        ///     <c>HeaderVersion</c> is a <c>VkPipelineCacheHeaderVersion</c> value specifying the version of the header. A consumer of the pipeline cache <i>should</i> use the cache version to interpret the remainder of the cache header. <c>headerVersion</c> <i>must</i> be written as exactly 4 bytes.
        /// </summary>
        [FieldOffset(4)]
        public VkPipelineCacheHeaderVersion HeaderVersion;

        /// <summary>
        ///     <c>VendorID</c> is the <c>VkPhysicalDeviceProperties::vendorID</c> of the implementation.
        /// </summary>
        [FieldOffset(8)]
        public int VendorID;

        /// <summary>
        ///     <c>DeviceID</c> is the <c>VkPhysicalDeviceProperties::deviceID</c> of the implementation.
        /// </summary>
        [FieldOffset(12)]
        public int DeviceID;

        ///
        [FieldOffset(16)]
        public fixed byte PipelineCacheUUID[16];
    }
}
