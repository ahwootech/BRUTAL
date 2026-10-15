namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM.html">VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM</see> - Structure containing scheduling control dispatch parameters properties of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_scheduling_controls
    ///         typedef struct VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           schedulingControlsMaxWarpsCount;
    ///             uint32_t           schedulingControlsMaxQueuedBatchesCount;
    ///             uint32_t           schedulingControlsMaxWorkGroupBatchSize;
    ///         } VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SchedulingControlsMaxWarpsCount</c>
        /// </summary>
        [FieldOffset(16)]
        public int SchedulingControlsMaxWarpsCount;

        /// <summary>
        ///     <c>SchedulingControlsMaxQueuedBatchesCount</c>
        /// </summary>
        [FieldOffset(20)]
        public int SchedulingControlsMaxQueuedBatchesCount;

        /// <summary>
        ///     <c>SchedulingControlsMaxWorkGroupBatchSize</c>
        /// </summary>
        [FieldOffset(24)]
        public int SchedulingControlsMaxWorkGroupBatchSize;
    }
}
