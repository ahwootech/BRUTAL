namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaDeviceClockModeInfoAMD.html">VkGpaDeviceClockModeInfoAMD</see> - Structure containing returned clock ratios or clock mode to set
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGpaDeviceClockModeInfoAMD
    ///     </para>
    ///     <para>
    ///         The <c>VkGpaDeviceClockModeInfoAMD</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef struct VkGpaDeviceClockModeInfoAMD {
    ///             VkStructureType            sType;
    ///             const void*                pNext;
    ///             VkGpaDeviceClockModeAMD    clockMode;
    ///             float                      memoryClockRatioToPeak;
    ///             float                      engineClockRatioToPeak;
    ///         } VkGpaDeviceClockModeInfoAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkGpaDeviceClockModeInfoAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.GpaDeviceClockModeInfoAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ClockMode</c> is a enum:VkGpaDeviceClockModeAMD value specify which clock mode to set, or whether to query the current clocks.
        /// </summary>
        [FieldOffset(16)]
        public VkGpaDeviceClockModeAMD ClockMode;

        /// <summary>
        ///     <c>MemoryClockRatioToPeak</c> is the returned ratio of the current memory clock to the maximum memory clock, if <c>clockMode</c> is <c>VK_GPA_DEVICE_CLOCK_MODE_QUERY_AMD</c>.
        /// </summary>
        [FieldOffset(20)]
        public float MemoryClockRatioToPeak;

        /// <summary>
        ///     <c>EngineClockRatioToPeak</c> is the returned ratio of the current engine clock to the maximum engine clock, if <c>clockMode</c> is <c>VK_GPA_DEVICE_CLOCK_MODE_QUERY_AMD</c>.
        /// </summary>
        [FieldOffset(24)]
        public float EngineClockRatioToPeak;
    }
}
