using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferFormatResolvePropertiesANDROID.html">VkAndroidHardwareBufferFormatResolvePropertiesANDROID</see> - Structure defining properties of resolves using an external format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAndroidHardwareBufferFormatResolvePropertiesANDROID</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_format_resolve
    ///         typedef struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkFormat           colorAttachmentFormat;
    ///         } VkAndroidHardwareBufferFormatResolvePropertiesANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ANDROIDHardwareBufferFormatResolvePropertiesANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ColorAttachmentFormat</c> is a <c>VkFormat</c> specifying the format of color attachment images that <i>must</i> be used for color attachments when resolving to the specified external format. If the implementation supports external format resolves for the specified external format, this value will be a color format supporting the <c>VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT</c> in <c>VkFormatProperties::optimalTilingFeatures</c> as returned by <c>vkGetPhysicalDeviceFormatProperties</c> with <c>format</c> equal to <c>colorAttachmentFormat</c> If external format resolves are not supported, this value will be <c>VK_FORMAT_UNDEFINED</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkFormat ColorAttachmentFormat;
    }
}
