namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkQueryLowLatencySupportNV.html">VkQueryLowLatencySupportNV</see> - Structure used for NVIDIA Reflex Support
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkQueryLowLatencySupportNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_low_latency
    ///         typedef struct VkQueryLowLatencySupportNV {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             void*              pQueriedLowLatencyData;
    ///         } VkQueryLowLatencySupportNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkQueryLowLatencySupportNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.QueryLowLatencySupportNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>QueriedLowLatencyData</c> is used for NVIDIA Reflex Support.
        /// </summary>
        [FieldOffset(16)]
        public void* QueriedLowLatencyData;
    }
}
