namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkShaderEXT.html">VkShaderEXT</see> - Opaque handle to a shader object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Shader objects are represented by <c>VkShaderEXT</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_shader_object
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkShaderEXT)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkShaderEXT : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.ShaderEXT;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkShaderEXT(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkShaderEXT NullHandle = new();
    }
}
