namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkThrottleHintSubmitInfoSEC.html">VkThrottleHintSubmitInfoSEC</see> - Stub description of VkThrottleHintSubmitInfoSEC
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_SEC_throttle_hint
    ///         typedef struct VkThrottleHintSubmitInfoSEC {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             VkThrottleHintTypeSEC    throttleHint;
    ///         } VkThrottleHintSubmitInfoSEC;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkThrottleHintSubmitInfoSEC()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ThrottleHintSubmitInfoSEC;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ThrottleHint</c>
        /// </summary>
        [FieldOffset(16)]
        public VkThrottleHintTypeSEC ThrottleHint;
    }
}
