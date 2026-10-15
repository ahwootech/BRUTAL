namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderIntegerDotProductFeatures.html">VkPhysicalDeviceShaderIntegerDotProductFeatures</see> - Structure describing integer dot product features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderIntegerDotProductFeatures</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkPhysicalDeviceShaderIntegerDotProductFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderIntegerDotProduct;
    ///         } VkPhysicalDeviceShaderIntegerDotProductFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderIntegerDotProductFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderIntegerDotProduct</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderIntegerDotProduct;
    }
}
