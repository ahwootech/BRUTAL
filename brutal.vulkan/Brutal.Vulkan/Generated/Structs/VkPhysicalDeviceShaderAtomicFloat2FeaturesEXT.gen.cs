namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT.html">VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT</see> - Structure describing features supported by VK_EXT_shader_atomic_float2
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_atomic_float2
    ///         typedef struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           shaderBufferFloat16Atomics;
    ///             VkBool32           shaderBufferFloat16AtomicAdd;
    ///             VkBool32           shaderBufferFloat16AtomicMinMax;
    ///             VkBool32           shaderBufferFloat32AtomicMinMax;
    ///             VkBool32           shaderBufferFloat64AtomicMinMax;
    ///             VkBool32           shaderSharedFloat16Atomics;
    ///             VkBool32           shaderSharedFloat16AtomicAdd;
    ///             VkBool32           shaderSharedFloat16AtomicMinMax;
    ///             VkBool32           shaderSharedFloat32AtomicMinMax;
    ///             VkBool32           shaderSharedFloat64AtomicMinMax;
    ///             VkBool32           shaderImageFloat32AtomicMinMax;
    ///             VkBool32           sparseImageFloat32AtomicMinMax;
    ///         } VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderAtomicFloat2FeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ShaderBufferFloat16Atomics</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 ShaderBufferFloat16Atomics;

        /// <summary>
        ///     <c>ShaderBufferFloat16AtomicAdd</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 ShaderBufferFloat16AtomicAdd;

        /// <summary>
        ///     <c>ShaderBufferFloat16AtomicMinMax</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderBufferFloat16AtomicMinMax;

        /// <summary>
        ///     <c>ShaderBufferFloat32AtomicMinMax</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderBufferFloat32AtomicMinMax;

        /// <summary>
        ///     <c>ShaderBufferFloat64AtomicMinMax</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ShaderBufferFloat64AtomicMinMax;

        /// <summary>
        ///     <c>ShaderSharedFloat16Atomics</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderSharedFloat16Atomics;

        /// <summary>
        ///     <c>ShaderSharedFloat16AtomicAdd</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ShaderSharedFloat16AtomicAdd;

        /// <summary>
        ///     <c>ShaderSharedFloat16AtomicMinMax</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ShaderSharedFloat16AtomicMinMax;

        /// <summary>
        ///     <c>ShaderSharedFloat32AtomicMinMax</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ShaderSharedFloat32AtomicMinMax;

        /// <summary>
        ///     <c>ShaderSharedFloat64AtomicMinMax</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 ShaderSharedFloat64AtomicMinMax;

        /// <summary>
        ///     <c>ShaderImageFloat32AtomicMinMax</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 ShaderImageFloat32AtomicMinMax;

        /// <summary>
        ///     <c>SparseImageFloat32AtomicMinMax</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 SparseImageFloat32AtomicMinMax;
    }
}
