namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDefaultVertexAttributeValueKHR.html">VkDefaultVertexAttributeValueKHR</see> - Values returned for unbound vertex attributes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The possible values returned by the implementation when the vertex shader
    ///         reads an unbound vertex attribute are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance9
    ///         typedef enum VkDefaultVertexAttributeValueKHR {
    ///             VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ZERO_KHR = 0,
    ///             VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ONE_KHR = 1,
    ///         } VkDefaultVertexAttributeValueKHR;
    ///     </code>
    /// </remarks>
    public enum VkDefaultVertexAttributeValueKHR : int
    {
        /// <summary>
        ///     <c>ZeroZeroZeroZeroKHR</c> - the value read for an unbound vertex attribute is (0,0,0,0).
        /// </summary>
        ZeroZeroZeroZeroKHR = 0,

        /// <summary>
        ///     <c>ZeroZeroZeroOneKHR</c> - the value read for an unbound vertex attribute is (0,0,0,1).
        /// </summary>
        ZeroZeroZeroOneKHR = 1,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
