namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderUntypedPointersFeaturesKHR.html">VkPhysicalDeviceShaderUntypedPointersFeaturesKHR</see> - Structure describing support for untyped pointers in shader by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderUntypedPointersFeaturesKHR</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_untyped_pointers
    ///         typedef struct VkPhysicalDeviceShaderUntypedPointersFeaturesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderUntypedPointers;
    ///         } VkPhysicalDeviceShaderUntypedPointersFeaturesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderUntypedPointersFeaturesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderUntypedPointersFeaturesKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderUntypedPointers</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderUntypedPointers;
    }
}
