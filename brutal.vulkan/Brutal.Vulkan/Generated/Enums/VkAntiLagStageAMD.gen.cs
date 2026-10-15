namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAntiLagStageAMD.html">VkAntiLagStageAMD</see> - Report the application stage
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkAntiLagPresentationInfoAMD::stage</c>,
    ///         specifying the current application stage, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_anti_lag
    ///         typedef enum VkAntiLagStageAMD {
    ///             VK_ANTI_LAG_STAGE_INPUT_AMD = 0,
    ///             VK_ANTI_LAG_STAGE_PRESENT_AMD = 1,
    ///         } VkAntiLagStageAMD;
    ///     </code>
    /// </remarks>
    public enum VkAntiLagStageAMD : int
    {
        /// <summary>
        ///     <c>InputAMD</c> specifies the stage before processing input.
        /// </summary>
        InputAMD = 0,

        /// <summary>
        ///     <c>PresentAMD</c> specifies the stage before <c>vkQueuePresentKHR</c>.
        /// </summary>
        PresentAMD = 1,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
