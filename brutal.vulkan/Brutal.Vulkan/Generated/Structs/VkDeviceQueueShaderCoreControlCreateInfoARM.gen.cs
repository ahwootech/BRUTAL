namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceQueueShaderCoreControlCreateInfoARM.html">VkDeviceQueueShaderCoreControlCreateInfoARM</see> - Control the number of shader cores used by queues
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The number of shader cores used by a queue <i>can</i> be controlled by adding a
    ///         <c>VkDeviceQueueShaderCoreControlCreateInfoARM</c> structure to the
    ///         <c>pNext</c> chain of <c>VkDeviceQueueCreateInfo</c> structures.
    ///     </para>
    ///     <para>
    ///         The <c>VkDeviceQueueShaderCoreControlCreateInfoARM</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_scheduling_controls
    ///         typedef struct VkDeviceQueueShaderCoreControlCreateInfoARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           shaderCoreCount;
    ///         } VkDeviceQueueShaderCoreControlCreateInfoARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceQueueShaderCoreControlCreateInfoARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceQueueShaderCoreControlCreateInfoARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderCoreCount</c> is the number of shader cores this queue uses.
        /// </summary>
        [FieldOffset(16)]
        public int ShaderCoreCount;
    }
}
