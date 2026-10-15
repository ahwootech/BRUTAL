using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalFormatANDROID.html">VkExternalFormatANDROID</see> - Structure containing an Android hardware buffer external format
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <c>VkExternalFormatANDROID</c> is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///         typedef struct VkExternalFormatANDROID {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           externalFormat;
    ///         } VkExternalFormatANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkExternalFormatANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalFormatANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalFormat</c> is an implementation-defined identifier for the external format
        /// </summary>
        [FieldOffset(16)]
        public nint ExternalFormat;
    }
}
