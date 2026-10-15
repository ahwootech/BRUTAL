namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSharingMode.html">VkSharingMode</see> - Buffer and image sharing modes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Buffer and image objects are created with a <i>sharing mode</i> controlling how
    ///         they <i>can</i> be accessed from queues.
    ///         The supported sharing modes are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkSharingMode {
    ///             VK_SHARING_MODE_EXCLUSIVE = 0,
    ///             VK_SHARING_MODE_CONCURRENT = 1,
    ///         } VkSharingMode;
    ///     </code>
    /// </remarks>
    public enum VkSharingMode : int
    {
        /// <summary>
        ///     <c>Exclusive</c> specifies that access to any range or image subresource of the object will be exclusive to a single queue family at a time.
        /// </summary>
        Exclusive = 0,

        /// <summary>
        ///     <c>Concurrent</c> specifies that concurrent access to any range or image subresource of the object from multiple queue families is supported.  [NOTE]
        /// </summary>
        Concurrent = 1,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
