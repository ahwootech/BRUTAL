namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVertexInputRate.html">VkVertexInputRate</see> - Specify rate at which vertex attributes are pulled from buffers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkVertexInputBindingDescription::inputRate</c>,
    ///         specifying the rate at which vertex attributes are pulled from buffers, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkVertexInputRate {
    ///             VK_VERTEX_INPUT_RATE_VERTEX = 0,
    ///             VK_VERTEX_INPUT_RATE_INSTANCE = 1,
    ///         } VkVertexInputRate;
    ///     </code>
    /// </remarks>
    public enum VkVertexInputRate : int
    {
        /// <summary>
        ///     <c>Vertex</c> specifies that vertex attribute addressing is a function of the vertex index.
        /// </summary>
        Vertex = 0,

        /// <summary>
        ///     <c>Instance</c> specifies that vertex attribute addressing is a function of the instance index.
        /// </summary>
        Instance = 1,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
