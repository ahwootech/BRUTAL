namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSubpassMergeStatusEXT.html">VkSubpassMergeStatusEXT</see> - Specify a subpass merging status
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of
    ///         <c>VkRenderPassSubpassFeedbackInfoEXT</c>:subpassMergeStatus are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_subpass_merge_feedback
    ///         typedef enum VkSubpassMergeStatusEXT {
    ///             VK_SUBPASS_MERGE_STATUS_MERGED_EXT = 0,
    ///             VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT = 1,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT = 2,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT = 3,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT = 4,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT = 5,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT = 6,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT = 7,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT = 8,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT = 9,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT = 10,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT = 11,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT = 12,
    ///             VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT = 13,
    ///         } VkSubpassMergeStatusEXT;
    ///     </code>
    /// </remarks>
    public enum VkSubpassMergeStatusEXT : int
    {
        /// <summary>
        ///     <c>MergedEXT</c> specifies that the subpass is merged with a previous subpass.
        /// </summary>
        MergedEXT = 0,

        /// <summary>
        ///     <c>DisallowedEXT</c> specifies that the subpass is not merged because merging was disabled using <c>VkRenderPassCreationControlEXT</c>. If the render pass does not allow subpass merging, then all subpass statuses are set to this value. If a subpass description does not allow subpass merging, then only that subpass&apos;s status is set to this value.
        /// </summary>
        DisallowedEXT = 1,

        /// <summary>
        ///     <c>NotMergedSideEffectsEXT</c> specifies that the subpass is not merged because it contains side effects.
        /// </summary>
        NotMergedSideEffectsEXT = 2,

        /// <summary>
        ///     <c>NotMergedSamplesMismatchEXT</c> specifies that the subpass is not merged because sample count is not compatible with the previous subpass.
        /// </summary>
        NotMergedSamplesMismatchEXT = 3,

        /// <summary>
        ///     <c>NotMergedViewsMismatchEXT</c> specifies that the subpass is not merged because view masks do not match with previous subpass.
        /// </summary>
        NotMergedViewsMismatchEXT = 4,

        /// <summary>
        ///     <c>NotMergedAliasingEXT</c> specifies that the subpass is not merged because of attachments aliasing between them.
        /// </summary>
        NotMergedAliasingEXT = 5,

        /// <summary>
        ///     <c>NotMergedDependenciesEXT</c> specifies that the subpass is not merged because subpass dependencies do not allow merging.
        /// </summary>
        NotMergedDependenciesEXT = 6,

        /// <summary>
        ///     <c>NotMergedIncompatibleInputAttachmentEXT</c>  specifies that the subpass is not merged because input attachment is not a color attachment from previous subpass or the formats are incompatible.
        /// </summary>
        NotMergedIncompatibleInputAttachmentEXT = 7,

        /// <summary>
        ///     <c>NotMergedTooManyAttachmentsEXT</c>  specifies that the subpass is not merged because of too many attachments.
        /// </summary>
        NotMergedTooManyAttachmentsEXT = 8,

        /// <summary>
        ///     <c>NotMergedInsufficientStorageEXT</c>  specifies that the subpass is not merged because of insufficient memory.
        /// </summary>
        NotMergedInsufficientStorageEXT = 9,

        /// <summary>
        ///     <c>NotMergedDepthStencilCountEXT</c>  specifies that the subpass is not merged because of too many depth/stencil attachments.
        /// </summary>
        NotMergedDepthStencilCountEXT = 10,

        /// <summary>
        ///     <c>NotMergedResolveAttachmentReuseEXT</c>  specifies that the subpass is not merged because a resolve attachment is reused as an input attachment in a subsequent subpass.
        /// </summary>
        NotMergedResolveAttachmentReuseEXT = 11,

        /// <summary>
        ///     <c>NotMergedSingleSubpassEXT</c> specifies that the subpass is not merged because the render pass has only one subpass.
        /// </summary>
        NotMergedSingleSubpassEXT = 12,

        /// <summary>
        ///     <c>NotMergedUnspecifiedEXT</c> specifies that the subpass is not merged for unspecified reasons. Implementations <i>should</i> return this value when no other <c>VkSubpassMergeStatusEXT</c> value is appropriate.
        /// </summary>
        NotMergedUnspecifiedEXT = 13,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
