namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD.html">VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD</see> - Structure describing whether early and late fragment tests can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD</c>
    ///         structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_shader_early_and_late_fragment_tests
    ///         typedef struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderEarlyAndLateFragmentTests;
    ///         } VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType =
            VkStructureType.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderEarlyAndLateFragmentTests</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderEarlyAndLateFragmentTests;
    }
}
