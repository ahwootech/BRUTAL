namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFaultFeaturesEXT.html">VkPhysicalDeviceFaultFeaturesEXT</see> - Structure indicating support for device fault reporting
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFaultFeaturesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_fault
    ///         typedef struct VkPhysicalDeviceFaultFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           deviceFault;
    ///             VkBool32           deviceFaultVendorBinary;
    ///         } VkPhysicalDeviceFaultFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFaultFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFaultFeaturesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DeviceFault</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DeviceFault;

        /// <summary>
        ///     <c>DeviceFaultVendorBinary</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 DeviceFaultVendorBinary;
    }
}
