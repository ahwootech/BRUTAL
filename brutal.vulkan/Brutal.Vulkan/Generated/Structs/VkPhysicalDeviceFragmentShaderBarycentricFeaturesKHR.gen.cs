namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR.html">VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR</see> - Structure describing barycentric support in fragment shaders that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_fragment_shader_barycentric
    ///         typedef struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           fragmentShaderBarycentric;
    ///         } VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>FragmentShaderBarycentric</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 FragmentShaderBarycentric;
    }
}
