namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkIndexType.html">VkIndexType</see> - Type of index buffer indices
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>vkCmdBindIndexBuffer::indexType</c>, specifying the size of indices,
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkIndexType {
    ///             VK_INDEX_TYPE_UINT16 = 0,
    ///             VK_INDEX_TYPE_UINT32 = 1,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_INDEX_TYPE_UINT8 = 1000265000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_INDEX_TYPE_NONE_KHR = 1000165000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_INDEX_TYPE_NONE_NV = VK_INDEX_TYPE_NONE_KHR,
    ///             // Provided by VK_EXT_index_type_uint8
    ///             VK_INDEX_TYPE_UINT8_EXT = VK_INDEX_TYPE_UINT8,
    ///             // Provided by VK_KHR_index_type_uint8
    ///             VK_INDEX_TYPE_UINT8_KHR = VK_INDEX_TYPE_UINT8,
    ///         } VkIndexType;
    ///     </code>
    /// </remarks>
    public enum VkIndexType : int
    {
        /// <summary>
        ///     <c>UInt16</c> specifies that indices are 16-bit unsigned integer values.
        /// </summary>
        UInt16 = 0,

        /// <summary>
        ///     <c>UInt32</c> specifies that indices are 32-bit unsigned integer values.
        /// </summary>
        UInt32 = 1,

        /// <summary>
        ///     <c>UInt8</c>
        /// </summary>
        UInt8 = 1000265000,

        /// <summary>
        ///     <c>NoneKHR</c>
        /// </summary>
        NoneKHR = 1000165000,

        /// <summary>
        ///     <c>NoneNV</c>
        /// </summary>
        NoneNV = NoneKHR,

        /// <summary>
        ///     <c>UInt8EXT</c>
        /// </summary>
        UInt8EXT = UInt8,

        /// <summary>
        ///     <c>UInt8KHR</c>
        /// </summary>
        UInt8KHR = UInt8,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
