namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImageRobustnessFeatures.html">VkPhysicalDeviceImageRobustnessFeatures</see> - Structure describing the out-of-bounds behavior for an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImageRobustnessFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceImageRobustnessFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           robustImageAccess;
    ///         } VkPhysicalDeviceImageRobustnessFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImageRobustnessFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImageRobustnessFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RobustImageAccess</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RobustImageAccess;
    }
}
