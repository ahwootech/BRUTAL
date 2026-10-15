namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPresentWait2InfoKHR.html">VkPresentWait2InfoKHR</see> - Structure describing parameters of a presentation wait
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPresentWait2InfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_present_wait2
    ///         typedef struct VkPresentWait2InfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             uint64_t           presentId;
    ///             uint64_t           timeout;
    ///         } VkPresentWait2InfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPresentWait2InfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PresentWait2InfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PresentId</c> is the presentation presentId to wait for.
        /// </summary>
        [FieldOffset(16)]
        public nint PresentId;

        /// <summary>
        ///     <c>Timeout</c> is the timeout period in units of nanoseconds. <c>timeout</c> is adjusted to the closest value allowed by the implementation-dependent timeout accuracy, which may: be substantially longer than one nanosecond, and may: be longer than the requested period.
        /// </summary>
        [FieldOffset(24)]
        public nint Timeout;
    }
}
