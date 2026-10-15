using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferUsageANDROID.html">VkAndroidHardwareBufferUsageANDROID</see> - Struct containing Android hardware buffer usage flags
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To obtain optimal Android hardware buffer usage flags for specific image
    ///         creation parameters, add a <c>VkAndroidHardwareBufferUsageANDROID</c>
    ///         structure to the <c>pNext</c> chain of a <c>VkImageFormatProperties2</c>
    ///         structure passed to <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
    ///         This structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///         typedef struct VkAndroidHardwareBufferUsageANDROID {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           androidHardwareBufferUsage;
    ///         } VkAndroidHardwareBufferUsageANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkAndroidHardwareBufferUsageANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ANDROIDHardwareBufferUsageANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AndroidHardwareBufferUsage</c> returns the Android hardware buffer usage flags.
        /// </summary>
        [FieldOffset(16)]
        public nint AndroidHardwareBufferUsage;
    }
}
