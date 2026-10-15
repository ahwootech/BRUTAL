using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportMetalTextureInfoEXT.html">VkImportMetalTextureInfoEXT</see> - Structure that identifies Metal MTLTexture objects to use when creating a VkImage.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import one or more existing Metal <c>MTLTexture</c> objects to underlie a
    ///         <c>VkImage</c> object, include one or more <c>VkImportMetalTextureInfoEXT</c>
    ///         structures in the <c>pNext</c> chain of the <c>VkImageCreateInfo</c> structure
    ///         in a <c>vkCreateImage</c> command.
    ///     </para>
    ///     <para>
    ///         The <c>VkImportMetalTextureInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkImportMetalTextureInfoEXT {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkImageAspectFlagBits    plane;
    ///             MTLTexture_id            mtlTexture;
    ///         } VkImportMetalTextureInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkImportMetalTextureInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportMetalTextureInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Plane</c> specifies the plane of the <c>VkImage</c> that the `id&lt;MTLTexture&gt;` object should be attached to.
        /// </summary>
        [FieldOffset(16)]
        public VkImageAspectFlags Plane;

        /// <summary>
        ///     <c>MtlTexture</c> is a the Metal `id&lt;MTLTexture&gt;` object that is to underlie the <c>VkImage</c> plane.
        /// </summary>
        [FieldOffset(24)]
        public nint MtlTexture;
    }
}
