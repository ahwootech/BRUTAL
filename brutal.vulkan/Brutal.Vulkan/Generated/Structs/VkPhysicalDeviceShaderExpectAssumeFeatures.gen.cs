namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderExpectAssumeFeatures.html">VkPhysicalDeviceShaderExpectAssumeFeatures</see> - Structure describing shader expect assume features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderExpectAssumeFeatures</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkPhysicalDeviceShaderExpectAssumeFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderExpectAssume;
    ///         } VkPhysicalDeviceShaderExpectAssumeFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderExpectAssumeFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderExpectAssumeFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderExpectAssume</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderExpectAssume;
    }
}
