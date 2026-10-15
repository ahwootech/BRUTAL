namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderInstrumentationARM.html">VkShaderInstrumentationARM</see> - Opaque handle to a shader instrumentation object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Shader instrumentation metrics are captured via instrumentation objects.
    ///     </para>
    ///     <para>
    ///         Shader instrumentation objects are represented by
    ///         <c>VkShaderInstrumentationARM</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_instrumentation
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkShaderInstrumentationARM)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkShaderInstrumentationARM : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.ShaderInstrumentationARM;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkShaderInstrumentationARM(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkShaderInstrumentationARM NullHandle = new();
    }
}
