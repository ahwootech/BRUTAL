namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance10PropertiesKHR.html">VkPhysicalDeviceMaintenance10PropertiesKHR</see> - Structure describing various implementation-defined properties introduced with VK_KHR_maintenance10
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance10PropertiesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef struct VkPhysicalDeviceMaintenance10PropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           rgba4OpaqueBlackSwizzled;
    ///             VkBool32           resolveSrgbFormatAppliesTransferFunction;
    ///             VkBool32           resolveSrgbFormatSupportsTransferFunctionControl;
    ///         } VkPhysicalDeviceMaintenance10PropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceMaintenance10PropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance10PropertiesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Rgba4OpaqueBlackSwizzled</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Rgba4OpaqueBlackSwizzled;

        /// <summary>
        ///     <c>ResolveSrgbFormatAppliesTransferFunction</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ResolveSrgbFormatAppliesTransferFunction;

        /// <summary>
        ///     <c>ResolveSrgbFormatSupportsTransferFunctionControl</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ResolveSrgbFormatSupportsTransferFunctionControl;
    }
}
