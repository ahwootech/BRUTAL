namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMaintenance5Properties.html">VkPhysicalDeviceMaintenance5Properties</see> - Structure describing various implementation-defined properties introduced with VK_KHR_maintenance5
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMaintenance5Properties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceMaintenance5Properties {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           earlyFragmentMultisampleCoverageAfterSampleCounting;
    ///             VkBool32           earlyFragmentSampleMaskTestBeforeSampleCounting;
    ///             VkBool32           depthStencilSwizzleOneSupport;
    ///             VkBool32           polygonModePointSize;
    ///             VkBool32           nonStrictSinglePixelWideLinesUseParallelogram;
    ///             VkBool32           nonStrictWideLinesUseParallelogram;
    ///         } VkPhysicalDeviceMaintenance5Properties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VkPhysicalDeviceMaintenance5Properties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMaintenance5Properties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>EarlyFragmentMultisampleCoverageAfterSampleCounting</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 EarlyFragmentMultisampleCoverageAfterSampleCounting;

        /// <summary>
        ///     <c>EarlyFragmentSampleMaskTestBeforeSampleCounting</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 EarlyFragmentSampleMaskTestBeforeSampleCounting;

        /// <summary>
        ///     <c>DepthStencilSwizzleOneSupport</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 DepthStencilSwizzleOneSupport;

        /// <summary>
        ///     <c>PolygonModePointSize</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 PolygonModePointSize;

        /// <summary>
        ///     <c>NonStrictSinglePixelWideLinesUseParallelogram</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 NonStrictSinglePixelWideLinesUseParallelogram;

        /// <summary>
        ///     <c>NonStrictWideLinesUseParallelogram</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 NonStrictWideLinesUseParallelogram;
    }
}
