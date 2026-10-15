namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessBufferBehavior.html">VkPipelineRobustnessBufferBehavior</see> - Enum controlling the robustness of buffer accesses in a pipeline stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>storageBuffers</c>, <c>uniformBuffers</c>, and
    ///         <c>vertexInputs</c> members of <c>VkPipelineRobustnessCreateInfo</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef enum VkPipelineRobustnessBufferBehavior {
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT = 0,
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED = 1,
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS = 2,
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2 = 3,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT = VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT = VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT = VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT = VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2,
    ///         } VkPipelineRobustnessBufferBehavior;
    ///     </code>
    /// </remarks>
    public enum VkPipelineRobustnessBufferBehavior : int
    {
        /// <summary>
        ///     <c>DeviceDefault</c> specifies that <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-execution-memory-access-bounds">out of bounds^</see> buffer accesses follow the behavior of robust buffer access features enabled for the device.
        /// </summary>
        DeviceDefault = 0,

        /// <summary>
        ///     <c>Disabled</c> specifies that buffer accesses <i>must</i> not be <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-execution-memory-access-bounds">out of bounds^</see>.
        /// </summary>
        Disabled = 1,

        /// <summary>
        ///     <c>RobustBufferAccess</c>  specifies that buffer accesses conform to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-robust-buffer-access">here</see> guarantees.
        /// </summary>
        RobustBufferAccess = 2,

        /// <summary>
        ///     <c>RobustBufferAccess2</c>  specifies that buffer accesses conform to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-robust-buffer-access2">here</see> guarantees.
        /// </summary>
        RobustBufferAccess2 = 3,

        /// <summary>
        ///     <c>DeviceDefaultEXT</c>
        /// </summary>
        DeviceDefaultEXT = DeviceDefault,

        /// <summary>
        ///     <c>DisabledEXT</c>
        /// </summary>
        DisabledEXT = Disabled,

        /// <summary>
        ///     <c>RobustBufferAccessEXT</c>
        /// </summary>
        RobustBufferAccessEXT = RobustBufferAccess,

        /// <summary>
        ///     <c>RobustBufferAccess2EXT</c>
        /// </summary>
        RobustBufferAccess2EXT = RobustBufferAccess2,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
