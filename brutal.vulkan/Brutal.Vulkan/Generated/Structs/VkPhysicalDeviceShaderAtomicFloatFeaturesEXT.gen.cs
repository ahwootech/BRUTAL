namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloatFeaturesEXT.html">VkPhysicalDeviceShaderAtomicFloatFeaturesEXT</see> - Structure describing features supported by VK_EXT_shader_atomic_float
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderAtomicFloatFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_atomic_float
    ///         typedef struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderBufferFloat32Atomics;
    ///             VkBool32           shaderBufferFloat32AtomicAdd;
    ///             VkBool32           shaderBufferFloat64Atomics;
    ///             VkBool32           shaderBufferFloat64AtomicAdd;
    ///             VkBool32           shaderSharedFloat32Atomics;
    ///             VkBool32           shaderSharedFloat32AtomicAdd;
    ///             VkBool32           shaderSharedFloat64Atomics;
    ///             VkBool32           shaderSharedFloat64AtomicAdd;
    ///             VkBool32           shaderImageFloat32Atomics;
    ///             VkBool32           shaderImageFloat32AtomicAdd;
    ///             VkBool32           sparseImageFloat32Atomics;
    ///             VkBool32           sparseImageFloat32AtomicAdd;
    ///         } VkPhysicalDeviceShaderAtomicFloatFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderAtomicFloatFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderBufferFloat32Atomics</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderBufferFloat32Atomics;

        /// <summary>
        ///     <c>ShaderBufferFloat32AtomicAdd</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderBufferFloat32AtomicAdd;

        /// <summary>
        ///     <c>ShaderBufferFloat64Atomics</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderBufferFloat64Atomics;

        /// <summary>
        ///     <c>ShaderBufferFloat64AtomicAdd</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderBufferFloat64AtomicAdd;

        /// <summary>
        ///     <c>ShaderSharedFloat32Atomics</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ShaderSharedFloat32Atomics;

        /// <summary>
        ///     <c>ShaderSharedFloat32AtomicAdd</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderSharedFloat32AtomicAdd;

        /// <summary>
        ///     <c>ShaderSharedFloat64Atomics</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ShaderSharedFloat64Atomics;

        /// <summary>
        ///     <c>ShaderSharedFloat64AtomicAdd</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ShaderSharedFloat64AtomicAdd;

        /// <summary>
        ///     <c>ShaderImageFloat32Atomics</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ShaderImageFloat32Atomics;

        /// <summary>
        ///     <c>ShaderImageFloat32AtomicAdd</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 ShaderImageFloat32AtomicAdd;

        /// <summary>
        ///     <c>SparseImageFloat32Atomics</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 SparseImageFloat32Atomics;

        /// <summary>
        ///     <c>SparseImageFloat32AtomicAdd</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 SparseImageFloat32AtomicAdd;
    }
}
