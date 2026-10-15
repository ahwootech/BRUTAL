namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDispatchParametersARM.html">VkDispatchParametersARM</see> - Structure specifying parameters that affect dispatch commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDispatchParametersARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_scheduling_controls
    ///         typedef struct VkDispatchParametersARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           workGroupBatchSize;
    ///             uint32_t           maxQueuedWorkGroupBatches;
    ///             uint32_t           maxWarpsPerShaderCore;
    ///         } VkDispatchParametersARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkDispatchParametersARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DispatchParametersARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>WorkGroupBatchSize</c>
        /// </summary>
        [FieldOffset(16)]
        public int WorkGroupBatchSize;

        /// <summary>
        ///     <c>MaxQueuedWorkGroupBatches</c>
        /// </summary>
        [FieldOffset(20)]
        public int MaxQueuedWorkGroupBatches;

        /// <summary>
        ///     <c>MaxWarpsPerShaderCore</c>
        /// </summary>
        [FieldOffset(24)]
        public int MaxWarpsPerShaderCore;
    }
}
