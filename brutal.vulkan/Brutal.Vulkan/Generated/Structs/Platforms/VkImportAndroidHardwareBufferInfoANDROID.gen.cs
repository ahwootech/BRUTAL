using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkImportAndroidHardwareBufferInfoANDROID.html">VkImportAndroidHardwareBufferInfoANDROID</see> - Import memory from an Android hardware buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To import memory created outside of the current Vulkan instance from an
    ///         Android hardware buffer, add a
    ///         <c>VkImportAndroidHardwareBufferInfoANDROID</c> structure to the <c>pNext</c>
    ///         chain of the <c>VkMemoryAllocateInfo</c> structure.
    ///         The <c>VkImportAndroidHardwareBufferInfoANDROID</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///         typedef struct VkImportAndroidHardwareBufferInfoANDROID {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             struct AHardwareBuffer*    buffer;
    ///         } VkImportAndroidHardwareBufferInfoANDROID;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ImportANDROIDHardwareBufferInfoANDROID;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Buffer</c> is the Android hardware buffer to import.
        /// </summary>
        [FieldOffset(16)]
        public void* Buffer;
    }
}
