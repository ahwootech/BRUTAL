namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedbackFlagBits.html">VkPipelineCreationFeedbackFlagBits</see> - Bitmask specifying pipeline or pipeline stage creation feedback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of the <c>flags</c> member of
    ///         <c>VkPipelineCreationFeedback</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef enum VkPipelineCreationFeedbackFlagBits {
    ///             VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT = 0x00000001,
    ///             VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT = 0x00000002,
    ///             VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT = 0x00000004,
    ///             // Provided by VK_EXT_pipeline_creation_feedback
    ///             VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT,
    ///             // Provided by VK_EXT_pipeline_creation_feedback
    ///             VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT,
    ///             // Provided by VK_EXT_pipeline_creation_feedback
    ///             VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT_EXT = VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT,
    ///         } VkPipelineCreationFeedbackFlagBits;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkPipelineCreationFeedbackFlags : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>ValidBit</c> specifies that the feedback information is valid.
        /// </summary>
        ValidBit = 0x00000001,

        /// <summary>
        ///     <c>ApplicationPipelineCacheHitBit</c>  specifies that a readily usable pipeline or pipeline stage was found in the <c>pipelineCache</c> specified by the application in the pipeline creation command. + An implementation <i>should</i> set the <c>VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT</c> bit if it was able to avoid the large majority of pipeline or pipeline stage creation work by using the <c>pipelineCache</c> parameter of <c>vkCreateGraphicsPipelines</c>, or <c>vkCreateComputePipelines</c>. When an implementation sets this bit for the entire pipeline, it may: leave it unset for any stage. + [NOTE]
        /// </summary>
        ApplicationPipelineCacheHitBit = 0x00000002,

        /// <summary>
        ///     <c>BasePipelineAccelerationBit</c>
        /// </summary>
        BasePipelineAccelerationBit = 0x00000004,

        /// <summary>
        ///     <c>ValidBitEXT</c>
        /// </summary>
        ValidBitEXT = ValidBit,

        /// <summary>
        ///     <c>ApplicationPipelineCacheHitBitEXT</c>
        /// </summary>
        ApplicationPipelineCacheHitBitEXT = ApplicationPipelineCacheHitBit,

        /// <summary>
        ///     <c>BasePipelineAccelerationBitEXT</c>
        /// </summary>
        BasePipelineAccelerationBitEXT = BasePipelineAccelerationBit,

        /// <summary>
        ///     <c>FlagBitsMaxEnum</c>
        /// </summary>
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
