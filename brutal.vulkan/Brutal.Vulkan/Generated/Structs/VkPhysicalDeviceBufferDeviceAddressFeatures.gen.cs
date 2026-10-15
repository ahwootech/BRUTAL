namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBufferDeviceAddressFeatures.html">VkPhysicalDeviceBufferDeviceAddressFeatures</see> - Structure describing buffer address features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceBufferDeviceAddressFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceBufferDeviceAddressFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           bufferDeviceAddress;
    ///             VkBool32           bufferDeviceAddressCaptureReplay;
    ///             VkBool32           bufferDeviceAddressMultiDevice;
    ///         } VkPhysicalDeviceBufferDeviceAddressFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>BufferDeviceAddress</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 BufferDeviceAddress;

        /// <summary>
        ///     <c>BufferDeviceAddressCaptureReplay</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 BufferDeviceAddressCaptureReplay;

        /// <summary>
        ///     <c>BufferDeviceAddressMultiDevice</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 BufferDeviceAddressMultiDevice;
    }
}
