namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapBuildInfoEXT.html">VkMicromapBuildInfoEXT</see> - Structure specifying the  data used to build a micromap
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapBuildInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkMicromapBuildInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkMicromapBuildInfoEXT {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkMicromapTypeEXT                   type;
    ///             VkBuildMicromapFlagsEXT             flags;
    ///             VkBuildMicromapModeEXT              mode;
    ///             VkMicromapEXT                       dstMicromap;
    ///             uint32_t                            usageCountsCount;
    ///             const VkMicromapUsageEXT*           pUsageCounts;
    ///             const VkMicromapUsageEXT* const*    ppUsageCounts;
    ///             VkDeviceOrHostAddressConstKHR       data;
    ///             VkDeviceOrHostAddressKHR            scratchData;
    ///             VkDeviceOrHostAddressConstKHR       triangleArray;
    ///             VkDeviceSize                        triangleArrayStride;
    ///         } VkMicromapBuildInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkMicromapBuildInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MicromapBuildInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is a <c>VkMicromapTypeEXT</c> value specifying the type of micromap being built.
        /// </summary>
        [FieldOffset(16)]
        public VkMicromapTypeEXT Type;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkBuildMicromapFlagsEXT</c> specifying additional parameters of the micromap.
        /// </summary>
        [FieldOffset(20)]
        public VkBuildMicromapFlagsEXT Flags;

        /// <summary>
        ///     <c>Mode</c> is a <c>VkBuildMicromapModeEXT</c> value specifying the type of operation to perform.
        /// </summary>
        [FieldOffset(24)]
        public VkBuildMicromapModeEXT Mode;

        /// <summary>
        ///     <c>DstMicromap</c> is a pointer to the target micromap for the build.
        /// </summary>
        [FieldOffset(32)]
        public VkMicromapEXT DstMicromap;

        /// <summary>
        ///     <c>UsageCountsCount</c> specifies the number of usage counts structures that will be used to determine the size of this micromap.
        /// </summary>
        [FieldOffset(40)]
        public int UsageCountsCount;

        /// <summary>
        ///     <c>UsageCounts</c> is a pointer to an array of <c>VkMicromapUsageEXT</c> structures.
        /// </summary>
        [FieldOffset(48)]
        public VkMicromapUsageEXT* UsageCounts;

        /// <summary>
        ///     <c>ppUsageCounts</c> is a pointer to an array of pointers to <c>VkMicromapUsageEXT</c> structures.
        /// </summary>
        [FieldOffset(56)]
        public VkMicromapUsageEXT** ppUsageCounts;

        /// <summary>
        ///     <c>Data</c> is the device or host address of memory which contains the data for the micromap.
        /// </summary>
        [FieldOffset(64)]
        public VkDeviceOrHostAddressConstKHR Data;

        /// <summary>
        ///     <c>ScratchData</c> is the device or host address of memory that will be used as scratch memory for the build.
        /// </summary>
        [FieldOffset(72)]
        public VkDeviceOrHostAddressKHR ScratchData;

        /// <summary>
        ///     <c>TriangleArray</c> is the device or host address of memory containing the <c>VkMicromapTriangleEXT</c> data
        /// </summary>
        [FieldOffset(80)]
        public VkDeviceOrHostAddressConstKHR TriangleArray;

        /// <summary>
        ///     <c>TriangleArrayStride</c> is the stride in bytes between each element of <c>triangleArray</c>
        /// </summary>
        [FieldOffset(88)]
        public ByteSize64 TriangleArrayStride;
    }
}
