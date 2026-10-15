using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferPropertiesANDROID.html">VkAndroidHardwareBufferPropertiesANDROID</see> - Properties of External Memory Android Hardware Buffers
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAndroidHardwareBufferPropertiesANDROID</c> structure returned is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///         typedef struct VkAndroidHardwareBufferPropertiesANDROID {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkDeviceSize       allocationSize;
    ///             uint32_t           memoryTypeBits;
    ///         } VkAndroidHardwareBufferPropertiesANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ANDROIDHardwareBufferPropertiesANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AllocationSize</c> is the size of the external memory
        /// </summary>
        [FieldOffset(16)]
        public ByteSize64 AllocationSize;

        /// <summary>
        ///     <c>MemoryTypeBits</c> is a bitmask containing one bit set for every memory type which the specified Android hardware buffer <i>can</i> be imported as.
        /// </summary>
        [FieldOffset(24)]
        public int MemoryTypeBits;
    }
}
