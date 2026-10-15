namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStencilOpState.html">VkStencilOpState</see> - Structure specifying stencil operation state
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkStencilOpState</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkStencilOpState {
    ///             VkStencilOp    failOp;
    ///             VkStencilOp    passOp;
    ///             VkStencilOp    depthFailOp;
    ///             VkCompareOp    compareOp;
    ///             uint32_t       compareMask;
    ///             uint32_t       writeMask;
    ///             uint32_t       reference;
    ///         } VkStencilOpState;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct VkStencilOpState()
    {
        /// <summary>
        ///     <c>FailOp</c> is a <c>VkStencilOp</c> value specifying the action performed on samples that fail the stencil test.
        /// </summary>
        [FieldOffset(0)]
        public VkStencilOp FailOp;

        /// <summary>
        ///     <c>PassOp</c> is a <c>VkStencilOp</c> value specifying the action performed on samples that pass both the depth and stencil tests.
        /// </summary>
        [FieldOffset(4)]
        public VkStencilOp PassOp;

        /// <summary>
        ///     <c>DepthFailOp</c> is a <c>VkStencilOp</c> value specifying the action performed on samples that pass the stencil test and fail the depth test.
        /// </summary>
        [FieldOffset(8)]
        public VkStencilOp DepthFailOp;

        /// <summary>
        ///     <c>CompareOp</c> is a <c>VkCompareOp</c> value specifying the comparison operator used in the stencil test.
        /// </summary>
        [FieldOffset(12)]
        public VkCompareOp CompareOp;

        /// <summary>
        ///     <c>CompareMask</c> selects the bits of the unsigned integer stencil values participating in the stencil test.
        /// </summary>
        [FieldOffset(16)]
        public int CompareMask;

        /// <summary>
        ///     <c>WriteMask</c> selects the bits of the unsigned integer stencil values updated by the stencil test in the stencil framebuffer attachment.
        /// </summary>
        [FieldOffset(20)]
        public int WriteMask;

        /// <summary>
        ///     <c>Reference</c> is an integer stencil reference value that is used in the unsigned stencil comparison.
        /// </summary>
        [FieldOffset(24)]
        public int Reference;
    }
}
