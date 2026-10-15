namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRobustness2FeaturesKHR.html">VkPhysicalDeviceRobustness2FeaturesKHR</see> - Structure describing the out-of-bounds behavior for an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceRobustness2FeaturesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_robustness2
    ///         typedef struct VkPhysicalDeviceRobustness2FeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           robustBufferAccess2;
    ///             VkBool32           robustImageAccess2;
    ///             VkBool32           nullDescriptor;
    ///         } VkPhysicalDeviceRobustness2FeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceRobustness2FeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>RobustBufferAccess2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 RobustBufferAccess2;

        /// <summary>
        ///     <c>RobustImageAccess2</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 RobustImageAccess2;

        /// <summary>
        ///     <c>NullDescriptor</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 NullDescriptor;
    }
}
