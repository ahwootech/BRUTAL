namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderingEndInfoKHR.html">VkRenderingEndInfoKHR</see> - Structure specifying render pass end information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkRenderingEndInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_maintenance10
    ///         typedef struct VkRenderingEndInfoKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///         } VkRenderingEndInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VkRenderingEndInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderingEndInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;
    }
}
