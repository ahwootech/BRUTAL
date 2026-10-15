namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCommandBufferInheritanceConditionalRenderingInfoEXT.html">VkCommandBufferInheritanceConditionalRenderingInfoEXT</see> - Structure specifying command buffer inheritance information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         If the <c>pNext</c> chain of <c>VkCommandBufferInheritanceInfo</c> includes a
    ///         <c>VkCommandBufferInheritanceConditionalRenderingInfoEXT</c> structure, then
    ///         that structure controls whether a command buffer <i>can</i> be executed while
    ///         conditional rendering is <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#active-conditional-rendering">active^</see> in the
    ///         primary command buffer.
    ///     </para>
    ///     <para>
    ///         The <c>VkCommandBufferInheritanceConditionalRenderingInfoEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_conditional_rendering
    ///         typedef struct VkCommandBufferInheritanceConditionalRenderingInfoEXT {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           conditionalRenderingEnable;
    ///         } VkCommandBufferInheritanceConditionalRenderingInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ConditionalRenderingEnable</c> specifies whether the command buffer <i>can</i> be executed while conditional rendering is active in the primary command buffer. If this is <c>VK_TRUE</c>, then this command buffer <i>can</i> be executed whether the primary command buffer has active conditional rendering or not. If this is <c>VK_FALSE</c>, then the primary command buffer <i>must</i> not have conditional rendering active.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ConditionalRenderingEnable;
    }
}
