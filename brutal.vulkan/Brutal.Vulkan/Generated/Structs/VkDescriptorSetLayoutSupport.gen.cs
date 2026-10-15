namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDescriptorSetLayoutSupport.html">VkDescriptorSetLayoutSupport</see> - Structure returning information about whether a descriptor set layout can be supported
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Information about support for the descriptor set layout is returned in a
    ///         <c>VkDescriptorSetLayoutSupport</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkDescriptorSetLayoutSupport {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           supported;
    ///         } VkDescriptorSetLayoutSupport;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDescriptorSetLayoutSupport()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DescriptorSetLayoutSupport;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Supported</c> specifies whether the descriptor set layout <i>can</i> be created.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Supported;
    }
}
