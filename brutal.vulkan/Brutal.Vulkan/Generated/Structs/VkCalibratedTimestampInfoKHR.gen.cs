namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCalibratedTimestampInfoKHR.html">VkCalibratedTimestampInfoKHR</see> - Structure specifying the input parameters of a calibrated timestamp query
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkCalibratedTimestampInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_calibrated_timestamps
    ///         typedef struct VkCalibratedTimestampInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkTimeDomainKHR    timeDomain;
    ///         } VkCalibratedTimestampInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkCalibratedTimestampInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CalibratedTimestampInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>TimeDomain</c> is a <c>VkTimeDomainKHR</c> value specifying the time domain from which the calibrated timestamp value should be returned.
        /// </summary>
        [FieldOffset(16)]
        public VkTimeDomainKHR TimeDomain;
    }
}
