namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterScopeKHR.html">VkPerformanceCounterScopeKHR</see> - Supported counter scope types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Performance counters have an associated scope.
    ///         This scope describes the granularity of a performance counter.
    ///     </para>
    ///     <para>
    ///         The performance counter scope types which may: be returned in
    ///         <c>VkPerformanceCounterKHR::scope</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_performance_query
    ///         typedef enum VkPerformanceCounterScopeKHR {
    ///             VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR = 0,
    ///             VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR = 1,
    ///             VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR = 2,
    ///             // VK_QUERY_SCOPE_COMMAND_BUFFER_KHR is a legacy alias
    ///             VK_QUERY_SCOPE_COMMAND_BUFFER_KHR = VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR,
    ///             // VK_QUERY_SCOPE_RENDER_PASS_KHR is a legacy alias
    ///             VK_QUERY_SCOPE_RENDER_PASS_KHR = VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR,
    ///             // VK_QUERY_SCOPE_COMMAND_KHR is a legacy alias
    ///             VK_QUERY_SCOPE_COMMAND_KHR = VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR,
    ///         } VkPerformanceCounterScopeKHR;
    ///     </code>
    /// </remarks>
    public enum VkPerformanceCounterScopeKHR : int
    {
        /// <summary>
        ///     <c>CommandBufferKHR</c> - the performance counter scope is a single complete command buffer.
        /// </summary>
        CommandBufferKHR = 0,

        /// <summary>
        ///     <c>RenderPassKHR</c> - the performance counter scope is zero or more complete render passes. The performance query containing the performance counter <i>must</i> begin and end outside a render pass instance.
        /// </summary>
        RenderPassKHR = 1,

        /// <summary>
        ///     <c>CommandKHR</c> - the performance counter scope is zero or more commands.
        /// </summary>
        CommandKHR = 2,

        /// <summary>
        ///     <c>MaxEnumKHR</c>
        /// </summary>
        MaxEnumKHR = 0x7FFFFFFF,
    }
}
