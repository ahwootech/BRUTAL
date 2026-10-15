namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderQuadControlFeaturesKHR.html">VkPhysicalDeviceShaderQuadControlFeaturesKHR</see> - Structure describing whether quad scopes are supported by the implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderQuadControlFeaturesKHR</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_quad_control
    ///         typedef struct VkPhysicalDeviceShaderQuadControlFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderQuadControl;
    ///         } VkPhysicalDeviceShaderQuadControlFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderQuadControlFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderQuadControlFeaturesKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderQuadControl</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderQuadControl;
    }
}
