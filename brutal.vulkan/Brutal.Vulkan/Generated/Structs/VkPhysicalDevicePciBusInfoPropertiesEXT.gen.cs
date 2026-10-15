namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePCIBusInfoPropertiesEXT.html">VkPhysicalDevicePCIBusInfoPropertiesEXT</see> - Structure containing PCI bus information of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDevicePCIBusInfoPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_pci_bus_info
    ///         typedef struct VkPhysicalDevicePCIBusInfoPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           pciDomain;
    ///             uint32_t           pciBus;
    ///             uint32_t           pciDevice;
    ///             uint32_t           pciFunction;
    ///         } VkPhysicalDevicePCIBusInfoPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDevicePciBusInfoPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDevicePciBusInfoPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PciDomain</c> is the PCI bus domain.
        /// </summary>
        [FieldOffset(16)]
        public int PciDomain;

        /// <summary>
        ///     <c>PciBus</c> is the PCI bus identifier.
        /// </summary>
        [FieldOffset(20)]
        public int PciBus;

        /// <summary>
        ///     <c>PciDevice</c> is the PCI device identifier.
        /// </summary>
        [FieldOffset(24)]
        public int PciDevice;

        /// <summary>
        ///     <c>PciFunction</c> is the PCI device function identifier.
        /// </summary>
        [FieldOffset(28)]
        public int PciFunction;
    }
}
