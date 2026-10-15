namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceSynchronization2Features.html">VkPhysicalDeviceSynchronization2Features</see> - Structure describing whether the implementation supports v2 synchronization commands
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceSynchronization2Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceSynchronization2Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           synchronization2;
    ///         } VkPhysicalDeviceSynchronization2Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceSynchronization2Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceSynchronization2Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Synchronization2</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Synchronization2;
    }
}
