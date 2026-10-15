using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFormatResolvePropertiesANDROID.html">VkPhysicalDeviceExternalFormatResolvePropertiesANDROID</see> - Structure describing external format resolve supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalFormatResolvePropertiesANDROID</c> structure
    ///         is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_format_resolve
    ///         typedef struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID {
    ///             VkStructureType     sType;
    ///             void*               pNext;
    ///             VkBool32            nullColorAttachmentWithExternalFormatResolve;
    ///             VkChromaLocation    externalFormatResolveChromaOffsetX;
    ///             VkChromaLocation    externalFormatResolveChromaOffsetY;
    ///         } VkPhysicalDeviceExternalFormatResolvePropertiesANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalFormatResolvePropertiesANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NullColorAttachmentWithExternalFormatResolve</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 NullColorAttachmentWithExternalFormatResolve;

        /// <summary>
        ///     <c>ExternalFormatResolveChromaOffsetX</c>
        /// </summary>
        [FieldOffset(20)]
        public VkChromaLocation ExternalFormatResolveChromaOffsetX;

        /// <summary>
        ///     <c>ExternalFormatResolveChromaOffsetY</c>
        /// </summary>
        [FieldOffset(24)]
        public VkChromaLocation ExternalFormatResolveChromaOffsetY;
    }
}
