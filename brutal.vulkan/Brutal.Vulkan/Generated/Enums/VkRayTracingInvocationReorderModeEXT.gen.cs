namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingInvocationReorderModeEXT.html">VkRayTracingInvocationReorderModeEXT</see> - Enum providing a hint on how the application may: reorder
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which may: be returned in the
    ///         <c>rayTracingInvocationReorderReorderingHint</c> field of
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_ray_tracing_invocation_reorder
    ///         typedef enum VkRayTracingInvocationReorderModeEXT {
    ///             VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_EXT = 0,
    ///             VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_EXT = 1,
    ///             // Provided by VK_NV_ray_tracing_invocation_reorder
    ///             VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV = VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_EXT,
    ///             // Provided by VK_NV_ray_tracing_invocation_reorder
    ///             VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV = VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_EXT,
    ///         } VkRayTracingInvocationReorderModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkRayTracingInvocationReorderModeEXT : int
    {
        /// <summary>
        ///     <c>NoneEXT</c> specifies that the implementation does not reorder at reorder calls.
        /// </summary>
        NoneEXT = 0,

        /// <summary>
        ///     <c>ReorderEXT</c> specifies that the implementation may: reorder at reorder calls.
        /// </summary>
        ReorderEXT = 1,

        /// <summary>
        ///     <c>NoneNV</c>
        /// </summary>
        NoneNV = NoneEXT,

        /// <summary>
        ///     <c>ReorderNV</c>
        /// </summary>
        ReorderNV = ReorderEXT,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
