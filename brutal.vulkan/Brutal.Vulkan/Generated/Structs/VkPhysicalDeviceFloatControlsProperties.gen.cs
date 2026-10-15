namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceFloatControlsProperties.html">VkPhysicalDeviceFloatControlsProperties</see> - Structure describing properties supported by VK_KHR_shader_float_controls
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceFloatControlsProperties</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkPhysicalDeviceFloatControlsProperties {
    ///             VkStructureType                      sType;
    ///             void*                                pNext;
    ///             VkShaderFloatControlsIndependence    denormBehaviorIndependence;
    ///             VkShaderFloatControlsIndependence    roundingModeIndependence;
    ///             VkBool32                             shaderSignedZeroInfNanPreserveFloat16;
    ///             VkBool32                             shaderSignedZeroInfNanPreserveFloat32;
    ///             VkBool32                             shaderSignedZeroInfNanPreserveFloat64;
    ///             VkBool32                             shaderDenormPreserveFloat16;
    ///             VkBool32                             shaderDenormPreserveFloat32;
    ///             VkBool32                             shaderDenormPreserveFloat64;
    ///             VkBool32                             shaderDenormFlushToZeroFloat16;
    ///             VkBool32                             shaderDenormFlushToZeroFloat32;
    ///             VkBool32                             shaderDenormFlushToZeroFloat64;
    ///             VkBool32                             shaderRoundingModeRTEFloat16;
    ///             VkBool32                             shaderRoundingModeRTEFloat32;
    ///             VkBool32                             shaderRoundingModeRTEFloat64;
    ///             VkBool32                             shaderRoundingModeRTZFloat16;
    ///             VkBool32                             shaderRoundingModeRTZFloat32;
    ///             VkBool32                             shaderRoundingModeRTZFloat64;
    ///         } VkPhysicalDeviceFloatControlsProperties;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct VkPhysicalDeviceFloatControlsProperties()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceFloatControlsProperties;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DenormBehaviorIndependence</c>
        /// </summary>
        [FieldOffset(16)]
        public VkShaderFloatControlsIndependence DenormBehaviorIndependence;

        /// <summary>
        ///     <c>RoundingModeIndependence</c>
        /// </summary>
        [FieldOffset(20)]
        public VkShaderFloatControlsIndependence RoundingModeIndependence;

        /// <summary>
        ///     <c>ShaderSignedZeroInfNanPreserveFloat16</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 ShaderSignedZeroInfNanPreserveFloat16;

        /// <summary>
        ///     <c>ShaderSignedZeroInfNanPreserveFloat32</c>
        /// </summary>
        [FieldOffset(28)]
        public Brutal.Bool32 ShaderSignedZeroInfNanPreserveFloat32;

        /// <summary>
        ///     <c>ShaderSignedZeroInfNanPreserveFloat64</c>
        /// </summary>
        [FieldOffset(32)]
        public Brutal.Bool32 ShaderSignedZeroInfNanPreserveFloat64;

        /// <summary>
        ///     <c>ShaderDenormPreserveFloat16</c>
        /// </summary>
        [FieldOffset(36)]
        public Brutal.Bool32 ShaderDenormPreserveFloat16;

        /// <summary>
        ///     <c>ShaderDenormPreserveFloat32</c>
        /// </summary>
        [FieldOffset(40)]
        public Brutal.Bool32 ShaderDenormPreserveFloat32;

        /// <summary>
        ///     <c>ShaderDenormPreserveFloat64</c>
        /// </summary>
        [FieldOffset(44)]
        public Brutal.Bool32 ShaderDenormPreserveFloat64;

        /// <summary>
        ///     <c>ShaderDenormFlushToZeroFloat16</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 ShaderDenormFlushToZeroFloat16;

        /// <summary>
        ///     <c>ShaderDenormFlushToZeroFloat32</c>
        /// </summary>
        [FieldOffset(52)]
        public Brutal.Bool32 ShaderDenormFlushToZeroFloat32;

        /// <summary>
        ///     <c>ShaderDenormFlushToZeroFloat64</c>
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 ShaderDenormFlushToZeroFloat64;

        /// <summary>
        ///     <c>ShaderRoundingModeRTEFloat16</c>
        /// </summary>
        [FieldOffset(60)]
        public Brutal.Bool32 ShaderRoundingModeRTEFloat16;

        /// <summary>
        ///     <c>ShaderRoundingModeRTEFloat32</c>
        /// </summary>
        [FieldOffset(64)]
        public Brutal.Bool32 ShaderRoundingModeRTEFloat32;

        /// <summary>
        ///     <c>ShaderRoundingModeRTEFloat64</c>
        /// </summary>
        [FieldOffset(68)]
        public Brutal.Bool32 ShaderRoundingModeRTEFloat64;

        /// <summary>
        ///     <c>ShaderRoundingModeRTZFloat16</c>
        /// </summary>
        [FieldOffset(72)]
        public Brutal.Bool32 ShaderRoundingModeRTZFloat16;

        /// <summary>
        ///     <c>ShaderRoundingModeRTZFloat32</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 ShaderRoundingModeRTZFloat32;

        /// <summary>
        ///     <c>ShaderRoundingModeRTZFloat64</c>
        /// </summary>
        [FieldOffset(80)]
        public Brutal.Bool32 ShaderRoundingModeRTZFloat64;
    }
}
