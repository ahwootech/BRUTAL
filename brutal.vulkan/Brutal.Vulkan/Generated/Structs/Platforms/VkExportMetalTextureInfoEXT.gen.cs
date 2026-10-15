using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExportMetalTextureInfoEXT.html">VkExportMetalTextureInfoEXT</see> - Structure that identifies a VkImage, VkImageView, or VkBufferView object and corresponding Metal MTLTexture object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To export a Metal <c>MTLTexture</c> object underlying a <c>VkImage</c>,
    ///         <c>VkImageView</c>, or <c>VkBufferView</c> object, include a
    ///         <c>VkExportMetalTextureInfoEXT</c> structure in the <c>pNext</c> chain of the
    ///         <c>pMetalObjectsInfo</c> parameter of a <c>vkExportMetalObjectsEXT</c> call.
    ///     </para>
    ///     <para>
    ///         The <c>VkExportMetalTextureInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_metal_objects
    ///         typedef struct VkExportMetalTextureInfoEXT {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkImage                  image;
    ///             VkImageView              imageView;
    ///             VkBufferView             bufferView;
    ///             VkImageAspectFlagBits    plane;
    ///             MTLTexture_id            mtlTexture;
    ///         } VkExportMetalTextureInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
    public unsafe partial struct VkExportMetalTextureInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExportMetalTextureInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image</c> is <c>VK_NULL_HANDLE</c> or a <c>VkImage</c>.
        /// </summary>
        [FieldOffset(16)]
        public VkImage Image;

        /// <summary>
        ///     <c>ImageView</c> is <c>VK_NULL_HANDLE</c> or a <c>VkImageView</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkImageView ImageView;

        /// <summary>
        ///     <c>BufferView</c> is <c>VK_NULL_HANDLE</c> or a <c>VkBufferView</c>.
        /// </summary>
        [FieldOffset(32)]
        public VkBufferView BufferView;

        /// <summary>
        ///     <c>Plane</c> specifies the plane of a multi-planar <c>VkImage</c> or <c>VkImageView</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkImageAspectFlags Plane;

        /// <summary>
        ///     <c>MtlTexture</c> is the Metal `id&lt;MTLTexture&gt;` object underlying the <c>VkImage</c>, <c>VkImageView</c>, or <c>VkBufferView</c> object in <c>image</c>, <c>imageView</c>, or <c>bufferView</c>, respectively, at the plane indicated in <c>aspectMask</c>. The implementation will return the <c>MTLTexture</c> in this member, or it will return `NULL` if no <c>MTLTexture</c> could be found underlying the <c>VkImage</c>, <c>VkImageView</c>, or <c>VkBufferView</c> object, at the plane indicated in <c>aspectMask</c>.
        /// </summary>
        [FieldOffset(48)]
        public nint MtlTexture;
    }
}
