namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkTileShadingRenderPassFlagBitsQCOM.html">VkTileShadingRenderPassFlagBitsQCOM</see> - Bitmask specifying flags for tile shading
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Bits which <i>can</i> be set in
    ///         <c>VkRenderPassTileShadingCreateInfoQCOM::flags</c> describing
    ///         additional properties of the render pass are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_QCOM_tile_shading
    ///         typedef enum VkTileShadingRenderPassFlagBitsQCOM {
    ///             VK_TILE_SHADING_RENDER_PASS_ENABLE_BIT_QCOM = 0x00000001,
    ///             VK_TILE_SHADING_RENDER_PASS_PER_TILE_EXECUTION_BIT_QCOM = 0x00000002,
    ///         } VkTileShadingRenderPassFlagBitsQCOM;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkTileShadingRenderPassFlagsQCOM : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>EnableBitQCOM</c> specifies that the render pass has tile shading enabled.
        /// </summary>
        EnableBitQCOM = 0x00000001,

        /// <summary>
        ///     <c>PerTileExecutionBitQCOM</c> specifies that the secondary command buffer will be executed within a <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#renderpass-per-tile-execution-model">per-tile execution block^</see>.
        /// </summary>
        PerTileExecutionBitQCOM = 0x00000002,

        /// <summary>
        ///     <c>FlagBitsMaxEnumQCOM</c>
        /// </summary>
        FlagBitsMaxEnumQCOM = 0x7FFFFFFF,
    }
}
