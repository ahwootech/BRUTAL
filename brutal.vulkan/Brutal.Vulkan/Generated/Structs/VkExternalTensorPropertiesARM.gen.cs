namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkExternalTensorPropertiesARM.html">VkExternalTensorPropertiesARM</see> - Structure specifying supported external handle capabilities for a tensor
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkExternalTensorPropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_tensors
    ///         typedef struct VkExternalTensorPropertiesARM {
    ///             VkStructureType               sType;
    ///             const void*                   pNext;
    ///             VkExternalMemoryProperties    externalMemoryProperties;
    ///         } VkExternalTensorPropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkExternalTensorPropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ExternalTensorPropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ExternalMemoryProperties</c> is a <c>VkExternalMemoryProperties</c> structure specifying various capabilities of the external handle type when used with the specified tensor creation parameters.
        /// </summary>
        [FieldOffset(16)]
        public VkExternalMemoryProperties ExternalMemoryProperties;
    }
}
