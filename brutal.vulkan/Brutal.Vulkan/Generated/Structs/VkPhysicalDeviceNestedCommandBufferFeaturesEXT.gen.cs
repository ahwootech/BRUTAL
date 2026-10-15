namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceNestedCommandBufferFeaturesEXT.html">VkPhysicalDeviceNestedCommandBufferFeaturesEXT</see> - Structure describing whether nested command buffers are supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceNestedCommandBufferFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_nested_command_buffer
    ///         typedef struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           nestedCommandBuffer;
    ///             VkBool32           nestedCommandBufferRendering;
    ///             VkBool32           nestedCommandBufferSimultaneousUse;
    ///         } VkPhysicalDeviceNestedCommandBufferFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceNestedCommandBufferFeaturesEXT;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NestedCommandBuffer</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 NestedCommandBuffer;

        /// <summary>
        ///     <c>NestedCommandBufferRendering</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 NestedCommandBufferRendering;

        /// <summary>
        ///     <c>NestedCommandBufferSimultaneousUse</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 NestedCommandBufferSimultaneousUse;
    }
}
