using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFormatResolveFeaturesANDROID.html">VkPhysicalDeviceExternalFormatResolveFeaturesANDROID</see> - Structure describing whether external format resolves are supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceExternalFormatResolveFeaturesANDROID</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_format_resolve
    ///         typedef struct VkPhysicalDeviceExternalFormatResolveFeaturesANDROID {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           externalFormatResolve;
    ///         } VkPhysicalDeviceExternalFormatResolveFeaturesANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkPhysicalDeviceExternalFormatResolveFeaturesANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceExternalFormatResolveFeaturesANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalFormatResolve</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ExternalFormatResolve;
    }
}
