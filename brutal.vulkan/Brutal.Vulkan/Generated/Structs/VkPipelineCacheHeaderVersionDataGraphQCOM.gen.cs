namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheHeaderVersionDataGraphQCOM.html">VkPipelineCacheHeaderVersionDataGraphQCOM</see> - Structure describing the layout of the pipeline cache header for data graphs
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The data graph pipeline cache header is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_data_graph_model
    ///         typedef struct VkPipelineCacheHeaderVersionDataGraphQCOM {
    ///             uint32_t                         headerSize;
    ///             VkPipelineCacheHeaderVersion     headerVersion;
    ///             VkDataGraphModelCacheTypeQCOM    cacheType;
    ///             uint32_t                         cacheVersion;
    ///             uint32_t                         toolchainVersion[VK_DATA_GRAPH_MODEL_TOOLCHAIN_VERSION_LENGTH_QCOM];
    ///         } VkPipelineCacheHeaderVersionDataGraphQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct VkPipelineCacheHeaderVersionDataGraphQCOM()
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
        ///     <c>CacheType</c> is the <c>VkDataGraphModelCacheTypeQCOM</c> type of data graph cache encoded in the data.
        /// </summary>
        [FieldOffset(8)]
        public VkDataGraphModelCacheTypeQCOM CacheType;

        /// <summary>
        ///     <c>CacheVersion</c> is the version of the encoding of the data graph cache.
        /// </summary>
        [FieldOffset(12)]
        public int CacheVersion;

        /// <summary>
        ///     <c>ToolchainVersion</c> is a null-terminated UTF-8 string specifying the version of the compiler that built the data graph cache.
        /// </summary>
        [FieldOffset(16)]
        public uint3 ToolchainVersion;
    }
}
