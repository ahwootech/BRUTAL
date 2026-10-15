namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDataGraphPipelineSessionARM.html">VkDataGraphPipelineSessionARM</see> - Opaque handle to a data graph pipeline session object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkDataGraphPipelineSessionARM
    ///     </para>
    ///     <para>
    ///         Graph pipeline sessions are represented by
    ///         <c>VkDataGraphPipelineSessionARM</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_data_graph
    ///         VK_DEFINE_NON_DISPATCHABLE_HANDLE(VkDataGraphPipelineSessionARM)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDataGraphPipelineSessionARM : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.DataGraphPipelineSessionARM;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDataGraphPipelineSessionARM(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDataGraphPipelineSessionARM NullHandle = new();
    }
}
