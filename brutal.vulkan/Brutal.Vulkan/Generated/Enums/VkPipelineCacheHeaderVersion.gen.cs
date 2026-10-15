namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheHeaderVersion.html">VkPipelineCacheHeaderVersion</see> - Encode pipeline cache version
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>headerVersion</c> value of the pipeline cache
    ///         header are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkPipelineCacheHeaderVersion {
    ///             VK_PIPELINE_CACHE_HEADER_VERSION_ONE = 1,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_PIPELINE_CACHE_HEADER_VERSION_DATA_GRAPH_QCOM = 1000629000,
    ///         } VkPipelineCacheHeaderVersion;
    ///     </code>
    /// </remarks>
    public enum VkPipelineCacheHeaderVersion : int
    {
        /// <summary>
        ///     <c>One</c> specifies version one of the pipeline cache, described by <c>VkPipelineCacheHeaderVersionOne</c>.
        /// </summary>
        One = 1,

        /// <summary>
        ///     <c>DataGraphQCOM</c>
        /// </summary>
        DataGraphQCOM = 1000629000,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
