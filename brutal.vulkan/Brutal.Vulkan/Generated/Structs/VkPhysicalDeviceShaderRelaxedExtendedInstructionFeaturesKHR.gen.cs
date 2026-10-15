namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR.html">VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR</see> - Structure describing support for VK_KHR_shader_relaxed_extended_instruction an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_relaxed_extended_instruction
    ///         typedef struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderRelaxedExtendedInstruction;
    ///         } VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderRelaxedExtendedInstruction</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderRelaxedExtendedInstruction;
    }
}
