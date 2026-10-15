namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDiscardRectangleModeEXT.html">VkDiscardRectangleModeEXT</see> - Specify the discard rectangle mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkDiscardRectangleModeEXT</c> values are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_discard_rectangles
    ///         typedef enum VkDiscardRectangleModeEXT {
    ///             VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT = 0,
    ///             VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT = 1,
    ///         } VkDiscardRectangleModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDiscardRectangleModeEXT : int
    {
        /// <summary>
        ///     <c>InclusiveEXT</c> specifies that the discard rectangle test is inclusive.
        /// </summary>
        InclusiveEXT = 0,

        /// <summary>
        ///     <c>ExclusiveEXT</c> specifies that the discard rectangle test is exclusive.
        /// </summary>
        ExclusiveEXT = 1,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
