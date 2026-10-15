using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectTypeFlagBitsEXT.html">VkExportMetalObjectTypeFlagBitsEXT</see> - Bitmask specifying Metal object types that can be exported from a Vulkan object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which indicate the types of Metal objects that may be exported from a
    ///         corresponding Vulkan object are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef enum VkExportMetalObjectTypeFlagBitsEXT {
    ///             VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT = 0x00000001,
    ///             VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT = 0x00000002,
    ///             VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT = 0x00000004,
    ///             VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT = 0x00000008,
    ///             VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT = 0x00000010,
    ///             VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT = 0x00000020,
    ///         } VkExportMetalObjectTypeFlagBitsEXT;
    ///     </code>
    /// </remarks>
    [Flags]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public enum VkExportMetalObjectTypeFlagsEXT : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>MetalDeviceBitEXT</c> specifies that a Metal <c>MTLDevice</c> may be exported.
        /// </summary>
        MetalDeviceBitEXT = 0x00000001,

        /// <summary>
        ///     <c>MetalCommandQueueBitEXT</c> specifies that a Metal <c>MTLCommandQueue</c> may be exported.
        /// </summary>
        MetalCommandQueueBitEXT = 0x00000002,

        /// <summary>
        ///     <c>MetalBufferBitEXT</c> specifies that a Metal <c>MTLBuffer</c> may be exported.
        /// </summary>
        MetalBufferBitEXT = 0x00000004,

        /// <summary>
        ///     <c>MetalTextureBitEXT</c> specifies that a Metal <c>MTLTexture</c> may be exported.
        /// </summary>
        MetalTextureBitEXT = 0x00000008,

        /// <summary>
        ///     <c>MetalIosurfaceBitEXT</c> specifies that a Metal <c>IOSurface</c> may be exported.
        /// </summary>
        MetalIosurfaceBitEXT = 0x00000010,

        /// <summary>
        ///     <c>MetalSharedEventBitEXT</c> specifies that a Metal <c>MTLSharedEvent</c> may be exported.
        /// </summary>
        MetalSharedEventBitEXT = 0x00000020,

        /// <summary>
        ///     <c>FlagBitsMaxEnumEXT</c>
        /// </summary>
        FlagBitsMaxEnumEXT = 0x7FFFFFFF,
    }
}
