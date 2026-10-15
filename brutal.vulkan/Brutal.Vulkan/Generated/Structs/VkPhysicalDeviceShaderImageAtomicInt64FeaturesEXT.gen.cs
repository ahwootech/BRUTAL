namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT.html">VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT</see> - Structure describing features supported by VK_EXT_shader_image_atomic_int64
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT</c> structure is
    ///         defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_image_atomic_int64
    ///         typedef struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderImageInt64Atomics;
    ///             VkBool32           sparseImageInt64Atomics;
    ///         } VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderImageInt64Atomics</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderImageInt64Atomics;

        /// <summary>
        ///     <c>SparseImageInt64Atomics</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 SparseImageInt64Atomics;
    }
}
