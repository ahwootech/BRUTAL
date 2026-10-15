namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkBlockMatchWindowCompareModeQCOM.html">VkBlockMatchWindowCompareModeQCOM</see> - Block match window compare modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkBlockMatchWindowCompareModeQCOM</c> enum describes how block match
    ///         values within the window are compared.
    ///         <c>VkBlockMatchWindowCompareModeQCOM</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_image_processing2
    ///         typedef enum VkBlockMatchWindowCompareModeQCOM {
    ///             VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM = 0,
    ///             VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM = 1,
    ///         } VkBlockMatchWindowCompareModeQCOM;
    ///     </code>
    /// </remarks>
    public enum VkBlockMatchWindowCompareModeQCOM : int
    {
        /// <summary>
        ///     <c>MinQCOM</c> specifies that windowed block match operations return the minimum error within the window.
        /// </summary>
        MinQCOM = 0,

        /// <summary>
        ///     <c>MaxQCOM</c> specifies that windowed block match operations return the maximum error within the window.
        /// </summary>
        MaxQCOM = 1,

        /// <summary>
        ///     <c>MaxEnumQCOM</c>
        /// </summary>
        MaxEnumQCOM = 0x7FFFFFFF,
    }
}
