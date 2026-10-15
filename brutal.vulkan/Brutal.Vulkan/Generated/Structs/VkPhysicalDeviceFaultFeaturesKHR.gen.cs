namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFaultFeaturesKHR.html">VkPhysicalDeviceFaultFeaturesKHR</see> - Structure indicating support for device fault reporting
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFaultFeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_device_fault
    ///         typedef struct VkPhysicalDeviceFaultFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           deviceFault;
    ///             VkBool32           deviceFaultVendorBinary;
    ///             VkBool32           deviceFaultReportMasked;
    ///             VkBool32           deviceFaultDeviceLostOnMasked;
    ///         } VkPhysicalDeviceFaultFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceFaultFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFaultFeaturesKHR;

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

        /// <summary>
        ///     <c>DeviceFaultReportMasked</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DeviceFaultReportMasked;

        /// <summary>
        ///     <c>DeviceFaultDeviceLostOnMasked</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 DeviceFaultDeviceLostOnMasked;
    }
}
