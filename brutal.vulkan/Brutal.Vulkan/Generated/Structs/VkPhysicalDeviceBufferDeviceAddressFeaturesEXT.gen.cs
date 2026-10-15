namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBufferDeviceAddressFeaturesEXT.html">VkPhysicalDeviceBufferDeviceAddressFeaturesEXT</see> - Structure describing buffer address features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceBufferDeviceAddressFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_buffer_device_address
    ///         typedef struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           bufferDeviceAddress;
    ///             VkBool32           bufferDeviceAddressCaptureReplay;
    ///             VkBool32           bufferDeviceAddressMultiDevice;
    ///         } VkPhysicalDeviceBufferDeviceAddressFeaturesEXT;
    ///     </code>
    ///     <code>
    ///         // Provided by VK_EXT_buffer_device_address
    ///         // Equivalent to VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    ///         typedef VkPhysicalDeviceBufferDeviceAddressFeaturesEXT VkPhysicalDeviceBufferAddressFeaturesEXT;
    ///         </code>
    ///     </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT;

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
