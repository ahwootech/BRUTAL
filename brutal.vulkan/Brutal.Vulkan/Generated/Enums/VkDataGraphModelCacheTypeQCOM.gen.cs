namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphModelCacheTypeQCOM.html">VkDataGraphModelCacheTypeQCOM</see> - Encode pipeline data graph cache type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDataGraphModelCacheTypeQCOM</c> enumeration determines the contents
    ///         of the pipeline data graph cache.
    ///     </para>
    ///     <para>
    ///         Possible values are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_data_graph_model
    ///         typedef enum VkDataGraphModelCacheTypeQCOM {
    ///             VK_DATA_GRAPH_MODEL_CACHE_TYPE_GENERIC_BINARY_QCOM = 0,
    ///         } VkDataGraphModelCacheTypeQCOM;
    ///     </code>
    /// </remarks>
    public enum VkDataGraphModelCacheTypeQCOM : int
    {
        /// <summary>
        ///     <c>GenericBinaryQCOM</c> specifies a general binary layout type.
        /// </summary>
        GenericBinaryQCOM = 0,

        /// <summary>
        ///     <c>MaxEnumQCOM</c>
        /// </summary>
        MaxEnumQCOM = 0x7FFFFFFF,
    }
}
