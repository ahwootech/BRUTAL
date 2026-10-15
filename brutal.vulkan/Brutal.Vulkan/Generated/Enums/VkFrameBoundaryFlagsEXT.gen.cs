namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFrameBoundaryFlagBitsEXT.html">VkFrameBoundaryFlagBitsEXT</see> - Bitmask specifying whether a queue submission is the last one for a given frame
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The bit which <i>can</i> be set in <c>VkFrameBoundaryEXT::flags</c> is:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_frame_boundary
    ///         typedef enum VkFrameBoundaryFlagBitsEXT {
    ///             VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT = 0x00000001,
    ///         } VkFrameBoundaryFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkFrameBoundaryFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>FrameEndBitEXT</c> specifies that this queue submission is the last one for this frame, i.e. once this queue submission has terminated, then the work for this frame is completed.
        /// </summary>
        FrameEndBitEXT = 0x00000001,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
