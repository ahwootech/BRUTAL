namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRayTracingLssPrimitiveEndCapsModeNV.html">VkRayTracingLssPrimitiveEndCapsModeNV</see> - LSS endcaps mode
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The default behavior with endcaps in a LSS chain is that both endcaps will
    ///         be enabled for all beginning and end points.
    ///         To change the LSS chain&apos;s endcaps mode use
    ///         <c>VkAccelerationStructureGeometryLinearSweptSpheresDataNV::endCapsMode</c>.
    ///         The possible values for <c>endCapsMode</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///         typedef enum VkRayTracingLssPrimitiveEndCapsModeNV {
    ///             VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_NONE_NV = 0,
    ///             VK_RAY_TRACING_LSS_PRIMITIVE_END_CAPS_MODE_CHAINED_NV = 1,
    ///         } VkRayTracingLssPrimitiveEndCapsModeNV;
    ///     </code>
    /// </remarks>
    public enum VkRayTracingLssPrimitiveEndCapsModeNV : int
    {
        /// <summary>
        ///     <c>NoneNV</c> disables all endcaps and the chain boundaries have no influence.
        /// </summary>
        NoneNV = 0,

        /// <summary>
        ///     <c>ChainedNV</c> specifies that when <c>VK_RAY_TRACING_LSS_INDEXING_MODE_SUCCESSIVE_NV</c> is used as indexing mode for the LSS primitive, the first primitive in each chain will have both endcaps enabled, and every following primitive in the chain only has endcaps at the trailing position enabled.
        /// </summary>
        ChainedNV = 1,

        /// <summary>
        ///     <c>MaxEnumNV</c>
        /// </summary>
        MaxEnumNV = 0x7FFFFFFF,
    }
}
