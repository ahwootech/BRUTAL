namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderTerminateInvocationFeatures.html">VkPhysicalDeviceShaderTerminateInvocationFeatures</see> - Structure describing support for the SPIR-V &lt;c&gt;SPV_KHR_terminate_invocation&lt;/c&gt; extension
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderTerminateInvocationFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceShaderTerminateInvocationFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderTerminateInvocation;
    ///         } VkPhysicalDeviceShaderTerminateInvocationFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderTerminateInvocationFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderTerminateInvocationFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderTerminateInvocation</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderTerminateInvocation;
    }
}
