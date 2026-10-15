namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceConditionalRenderingFeaturesEXT.html">VkPhysicalDeviceConditionalRenderingFeaturesEXT</see> - Structure describing if a secondary command buffer can be executed if conditional rendering is active in the primary command buffer
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceConditionalRenderingFeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conditional_rendering
    ///         typedef struct VkPhysicalDeviceConditionalRenderingFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           conditionalRendering;
    ///             VkBool32           inheritedConditionalRendering;
    ///         } VkPhysicalDeviceConditionalRenderingFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ConditionalRendering</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ConditionalRendering;

        /// <summary>
        ///     <c>InheritedConditionalRendering</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 InheritedConditionalRendering;
    }
}
