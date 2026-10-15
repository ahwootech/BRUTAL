namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTraceRaysIndirectCommandKHR.html">VkTraceRaysIndirectCommandKHR</see> - Structure specifying the parameters of an indirect ray tracing command
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkTraceRaysIndirectCommandKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkTraceRaysIndirectCommandKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_ray_tracing_pipeline
    ///         typedef struct VkTraceRaysIndirectCommandKHR {
    ///             uint32_t    width;
    ///             uint32_t    height;
    ///             uint32_t    depth;
    ///         } VkTraceRaysIndirectCommandKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct VkTraceRaysIndirectCommandKHR()
    {
        /// <summary>
        ///     <c>Width</c> is the width of the ray trace query dimensions.
        /// </summary>
        [FieldOffset(0)]
        public int Width;

        /// <summary>
        ///     <c>Height</c> is height of the ray trace query dimensions.
        /// </summary>
        [FieldOffset(4)]
        public int Height;

        /// <summary>
        ///     <c>Depth</c> is depth of the ray trace query dimensions.
        /// </summary>
        [FieldOffset(8)]
        public int Depth;
    }
}
