using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMemoryGetAndroidHardwareBufferInfoANDROID.html">VkMemoryGetAndroidHardwareBufferInfoANDROID</see> - Structure describing an Android hardware buffer memory export operation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMemoryGetAndroidHardwareBufferInfoANDROID</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///         typedef struct VkMemoryGetAndroidHardwareBufferInfoANDROID {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkDeviceMemory     memory;
    ///         } VkMemoryGetAndroidHardwareBufferInfoANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MemoryGetANDROIDHardwareBufferInfoANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Memory</c> is the memory object from which the Android hardware buffer will be exported.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceMemory Memory;
    }
}
