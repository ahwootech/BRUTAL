namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAccessFlagBits3KHR.html">VkAccessFlagBits3KHR</see> - Access flags for VkAccessFlags3KHR
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in the <c>srcAccessMask3</c> and <c>dstAccessMask3</c>
    ///         members of <c>VkMemoryBarrierAccessFlags3KHR</c>, specifying access behavior,
    ///         are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance8
    ///         // Flag bits for VkAccessFlagBits3KHR
    ///         typedef VkFlags64 VkAccessFlagBits3KHR;
    ///             static const VkAccessFlagBits3KHR VK_ACCESS_3_NONE_KHR = 0ULL;
    ///         </code>
    ///     </remarks>
    [Flags]
    public enum VkAccessFlags3KHR : ulong
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>NoneKHR</c> specifies no additional accesses.
        /// </summary>
        NoneKHR = 0,
    }
}
