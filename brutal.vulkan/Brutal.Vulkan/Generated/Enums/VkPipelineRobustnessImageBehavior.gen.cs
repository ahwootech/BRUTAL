namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineRobustnessImageBehavior.html">VkPipelineRobustnessImageBehavior</see> - Enum controlling the robustness of image accesses in a pipeline stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>images</c> member of
    ///         <c>VkPipelineRobustnessCreateInfo</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef enum VkPipelineRobustnessImageBehavior {
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT = 0,
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED = 1,
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS = 2,
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2 = 3,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT = VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT = VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT = VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT = VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2,
    ///         } VkPipelineRobustnessImageBehavior;
    ///     </code>
    /// </remarks>
    public enum VkPipelineRobustnessImageBehavior : int
    {
        /// <summary>
        ///     <c>DeviceDefault</c> specifies that <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-execution-memory-access-bounds">out of bounds^</see> image accesses follow the behavior of robust image access features enabled for the device.
        /// </summary>
        DeviceDefault = 0,

        /// <summary>
        ///     <c>Disabled</c> specifies that image accesses <i>must</i> not be <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-execution-memory-access-bounds">out of bounds^</see>.
        /// </summary>
        Disabled = 1,

        /// <summary>
        ///     <c>RobustImageAccess</c>  specifies that image accesses conform to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-robust-image-access">here</see> guarantees.
        /// </summary>
        RobustImageAccess = 2,

        /// <summary>
        ///     <c>RobustImageAccess2</c>  specifies that image accesses conform to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#shaders-robust-image-access2">here</see> guarantees.
        /// </summary>
        RobustImageAccess2 = 3,

        /// <summary>
        ///     <c>DeviceDefaultEXT</c>
        /// </summary>
        DeviceDefaultEXT = DeviceDefault,

        /// <summary>
        ///     <c>DisabledEXT</c>
        /// </summary>
        DisabledEXT = Disabled,

        /// <summary>
        ///     <c>RobustImageAccessEXT</c>
        /// </summary>
        RobustImageAccessEXT = RobustImageAccess,

        /// <summary>
        ///     <c>RobustImageAccess2EXT</c>
        /// </summary>
        RobustImageAccess2EXT = RobustImageAccess2,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
