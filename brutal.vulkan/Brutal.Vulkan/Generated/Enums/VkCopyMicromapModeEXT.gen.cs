namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCopyMicromapModeEXT.html">VkCopyMicromapModeEXT</see> - Micromap copy mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkCopyMicromapModeEXT
    ///     </para>
    ///     <para>
    ///         Possible values of <c>mode</c> specifying additional operations to perform
    ///         during the copy, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef enum VkCopyMicromapModeEXT {
    ///             VK_COPY_MICROMAP_MODE_CLONE_EXT = 0,
    ///             VK_COPY_MICROMAP_MODE_SERIALIZE_EXT = 1,
    ///             VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT = 2,
    ///             VK_COPY_MICROMAP_MODE_COMPACT_EXT = 3,
    ///         } VkCopyMicromapModeEXT;
    ///     </code>
    /// </remarks>
    public enum VkCopyMicromapModeEXT : int
    {
        /// <summary>
        ///     <c>CloneEXT</c> creates a direct copy of the micromap specified in <c>src</c> into the one specified by <c>dst</c>. The <c>dst</c> micromap <i>must</i> have been created with the same parameters as <c>src</c>.
        /// </summary>
        CloneEXT = 0,

        /// <summary>
        ///     <c>SerializeEXT</c> serializes the micromap to a semi-opaque format which can be reloaded on a compatible implementation.
        /// </summary>
        SerializeEXT = 1,

        /// <summary>
        ///     <c>DeserializeEXT</c> deserializes the semi-opaque serialization format in the buffer to the micromap.
        /// </summary>
        DeserializeEXT = 2,

        /// <summary>
        ///     <c>CompactEXT</c> creates a more compact version of a micromap <c>src</c> into <c>dst</c>. The micromap <c>dst</c> <i>must</i> have been created with a size at least as large as that returned by <c>vkCmdWriteMicromapsPropertiesEXT</c> after the build of the micromap specified by <c>src</c>.
        /// </summary>
        CompactEXT = 3,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
