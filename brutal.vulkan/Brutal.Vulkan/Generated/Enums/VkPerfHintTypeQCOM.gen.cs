namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerfHintTypeQCOM.html">VkPerfHintTypeQCOM</see> - Specifies the performance hint type
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values of <c>VkPerfHintInfoQCOM::type</c>, specifying the type
    ///         of performance hint to apply, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_queue_perf_hint
    ///         typedef enum VkPerfHintTypeQCOM {
    ///             VK_PERF_HINT_TYPE_DEFAULT_QCOM = 0,
    ///             VK_PERF_HINT_TYPE_FREQUENCY_MIN_QCOM = 1,
    ///             VK_PERF_HINT_TYPE_FREQUENCY_MAX_QCOM = 2,
    ///             VK_PERF_HINT_TYPE_FREQUENCY_SCALED_QCOM = 3,
    ///         } VkPerfHintTypeQCOM;
    ///     </code>
    /// </remarks>
    public enum VkPerfHintTypeQCOM : int
    {
        /// <summary>
        ///     <c>DefaultQCOM</c> resets the performance hint state back to default for the queue.
        /// </summary>
        DefaultQCOM = 0,

        /// <summary>
        ///     <c>FrequencyMinQCOM</c> specifies the queue <i>should</i> prioritize power and sets the frequency constraints `f~min~` and `f~max~` to `F~min~`.
        /// </summary>
        FrequencyMinQCOM = 1,

        /// <summary>
        ///     <c>FrequencyMaxQCOM</c> specifies the queue <i>should</i> prioritize performance and sets the frequency constraints `f~min~` and `f~max~` to `F~max~`.
        /// </summary>
        FrequencyMaxQCOM = 2,

        /// <summary>
        ///     <c>FrequencyScaledQCOM</c> specifies the queue <i>should</i> be balanced between performance and power and sets the frequency constraint `f~min~` by applying a scale factor to `F~max~`. No constraint is applied to `f~max~`.
        /// </summary>
        FrequencyScaledQCOM = 3,

        /// <summary>
        ///     <c>MaxEnumQCOM</c>
        /// </summary>
        MaxEnumQCOM = 0x7FFFFFFF,
    }
}
