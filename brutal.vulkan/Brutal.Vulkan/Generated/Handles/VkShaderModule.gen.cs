namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderModule.html">VkShaderModule</see> - Opaque handle to a shader module object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         <i>Shader modules</i> contain <i>shader code</i> and one or more entry points.
    ///         Shaders are selected from a shader module by specifying an entry point as
    ///         part of <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#pipelines">pipeline^</see> creation.
    ///         The stages of a pipeline <i>can</i> use shaders that come from different modules.
    ///         The shader code defining a shader module <i>must</i> be in the SPIR-V format, as
    ///         described by the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#spirvenv">Vulkan Environment for SPIR-V^</see> appendix.
    ///     </para>
    ///     <para>
    ///         Shader modules are represented by <c>VkShaderModule</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkShaderModule)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkShaderModule : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.ShaderModule;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkShaderModule(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkShaderModule NullHandle = new();
    }
}
