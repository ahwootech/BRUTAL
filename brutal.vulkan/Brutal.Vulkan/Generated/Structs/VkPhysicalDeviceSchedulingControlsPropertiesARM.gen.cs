namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSchedulingControlsPropertiesARM.html">VkPhysicalDeviceSchedulingControlsPropertiesARM</see> - Structure containing scheduling control properties of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSchedulingControlsPropertiesARM</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_scheduling_controls
    ///         typedef struct VkPhysicalDeviceSchedulingControlsPropertiesARM {
    ///             VkStructureType                               sType;
    ///             void*                                         pNext;
    ///             VkPhysicalDeviceSchedulingControlsFlagsARM    schedulingControlsFlags;
    ///         } VkPhysicalDeviceSchedulingControlsPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSchedulingControlsPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSchedulingControlsPropertiesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SchedulingControlsFlags</c>
        /// </summary>
        [FieldOffset(16)]
        public VkPhysicalDeviceSchedulingControlsFlagsARM SchedulingControlsFlags;
    }
}
