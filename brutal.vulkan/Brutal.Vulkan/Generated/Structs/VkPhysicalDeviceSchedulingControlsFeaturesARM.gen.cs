namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSchedulingControlsFeaturesARM.html">VkPhysicalDeviceSchedulingControlsFeaturesARM</see> - Structure describing scheduling controls features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSchedulingControlsFeaturesARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_scheduling_controls
    ///         typedef struct VkPhysicalDeviceSchedulingControlsFeaturesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           schedulingControls;
    ///         } VkPhysicalDeviceSchedulingControlsFeaturesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSchedulingControlsFeaturesARM()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSchedulingControlsFeaturesARM;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>SchedulingControls</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 SchedulingControls;
    }
}
