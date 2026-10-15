namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicInt64Features.html">VkPhysicalDeviceShaderAtomicInt64Features</see> - Structure describing features supported by VK_KHR_shader_atomic_int64
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderAtomicInt64Features</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceShaderAtomicInt64Features {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderBufferInt64Atomics;
    ///             VkBool32           shaderSharedInt64Atomics;
    ///         } VkPhysicalDeviceShaderAtomicInt64Features;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64Features()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderAtomicInt64Features;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderBufferInt64Atomics</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderBufferInt64Atomics;

        /// <summary>
        ///     <c>ShaderSharedInt64Atomics</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderSharedInt64Atomics;
    }
}
