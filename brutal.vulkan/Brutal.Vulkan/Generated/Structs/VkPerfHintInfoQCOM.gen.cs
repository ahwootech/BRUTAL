namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPerfHintInfoQCOM.html">VkPerfHintInfoQCOM</see> - Structure specifying the parameters used for setting a performance hint on a queue
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPerfHintInfoQCOM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_queue_perf_hint
    ///         typedef struct VkPerfHintInfoQCOM {
    ///             VkStructureType       sType;
    ///             void*                 pNext;
    ///             VkPerfHintTypeQCOM    type;
    ///             uint32_t              scale;
    ///         } VkPerfHintInfoQCOM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPerfHintInfoQCOM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PerfHintInfoQCOM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Type</c> is a <c>VkPerfHintTypeQCOM</c> value indicating the type of performance hint to apply.
        /// </summary>
        [FieldOffset(16)]
        public VkPerfHintTypeQCOM Type;

        /// <summary>
        ///     <c>Scale</c> is a normalized fixed-point scale factor.
        /// </summary>
        [FieldOffset(20)]
        public int Scale;
    }
}
