namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGeometryInstanceFlagBitsKHR.html">VkGeometryInstanceFlagBitsKHR</see> - Instance flag bits
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkGeometryInstanceFlagBitsKHR
    ///     </para>
    ///     <para>
    ///         Possible values of <c>flags</c> in the instance modifying the behavior of
    ///         that instance are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef enum VkGeometryInstanceFlagBitsKHR {
    ///             VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR = 0x00000001,
    ///             VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR = 0x00000002,
    ///             VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR = 0x00000004,
    ///             VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR = 0x00000008,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_BIT_KHR = 0x00000010,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_KHR = 0x00000020,
    ///             VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_INSTANCE_TRIANGLE_CULL_DISABLE_BIT_NV = VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV = VK_GEOMETRY_INSTANCE_TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_NV = VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_NV = VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_BIT_EXT = VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_BIT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             // VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT is a legacy alias
    ///             VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT = VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_BIT_EXT,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_EXT = VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_KHR,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             // VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT is a legacy alias
    ///             VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT = VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_BIT_EXT,
    ///         } VkGeometryInstanceFlagBitsKHR;
    ///     </code>
    /// </remarks>
    [Flags]
    public enum VkGeometryInstanceFlagsKHR : int
    {
        /// No flags set.
        None = 0,

        /// <summary>
        ///     <c>TriangleFacingCullDisableBitKHR</c> disables face culling for this instance.
        /// </summary>
        TriangleFacingCullDisableBitKHR = 0x00000001,

        /// <summary>
        ///     <c>TriangleFlipFacingBitKHR</c> specifies that the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#ray-traversal-culling-face">facing determination^</see> for geometry in this instance is inverted. Because the facing is determined in object space, an instance transform does not change the winding, but a geometry transform does.
        /// </summary>
        TriangleFlipFacingBitKHR = 0x00000002,

        /// <summary>
        ///     <c>ForceOpaqueBitKHR</c> causes this instance to act as though <c>VK_GEOMETRY_OPAQUE_BIT_KHR</c> were specified on all geometries referenced by this instance. This behavior <i>can</i> be overridden by the SPIR-V <c>NoOpaqueKHR</c> ray flag.
        /// </summary>
        ForceOpaqueBitKHR = 0x00000004,

        /// <summary>
        ///     <c>ForceNoOpaqueBitKHR</c> causes this instance to act as though <c>VK_GEOMETRY_OPAQUE_BIT_KHR</c> were not specified on all geometries referenced by this instance. This behavior <i>can</i> be overridden by the SPIR-V <c>OpaqueKHR</c> ray flag.  <c>VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR</c> and <c>VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR</c> <i>must</i> not be used in the same flag.
        /// </summary>
        ForceNoOpaqueBitKHR = 0x00000008,

        /// <summary>
        ///     <c>ForceOpacityMicromap2StateBitKHR</c>
        /// </summary>
        ForceOpacityMicromap2StateBitKHR = 0x00000010,

        /// <summary>
        ///     <c>DisableOpacityMicromapsBitKHR</c>
        /// </summary>
        DisableOpacityMicromapsBitKHR = 0x00000020,

        /// <summary>
        ///     <c>TriangleFrontCounterclockwiseBitKHR</c>
        /// </summary>
        TriangleFrontCounterclockwiseBitKHR = TriangleFlipFacingBitKHR,

        /// <summary>
        ///     <c>TriangleCullDisableBitNV</c>
        /// </summary>
        TriangleCullDisableBitNV = TriangleFacingCullDisableBitKHR,

        /// <summary>
        ///     <c>TriangleFrontCounterclockwiseBitNV</c>
        /// </summary>
        TriangleFrontCounterclockwiseBitNV = TriangleFrontCounterclockwiseBitKHR,

        /// <summary>
        ///     <c>ForceOpaqueBitNV</c>
        /// </summary>
        ForceOpaqueBitNV = ForceOpaqueBitKHR,

        /// <summary>
        ///     <c>ForceNoOpaqueBitNV</c>
        /// </summary>
        ForceNoOpaqueBitNV = ForceNoOpaqueBitKHR,

        /// <summary>
        ///     <c>ForceOpacityMicromap2StateBitEXT</c>
        /// </summary>
        ForceOpacityMicromap2StateBitEXT = ForceOpacityMicromap2StateBitKHR,

        /// <summary>
        ///     <c>ForceOpacityMicromap2StateEXT</c>
        /// </summary>
        ForceOpacityMicromap2StateEXT = ForceOpacityMicromap2StateBitEXT,

        /// <summary>
        ///     <c>DisableOpacityMicromapsBitEXT</c>
        /// </summary>
        DisableOpacityMicromapsBitEXT = DisableOpacityMicromapsBitKHR,

        /// <summary>
        ///     <c>DisableOpacityMicromapsEXT</c>
        /// </summary>
        DisableOpacityMicromapsEXT = DisableOpacityMicromapsBitEXT,

        /// <summary>
        ///     <c>FlagBitsMaxEnumKHR</c>
        /// </summary>
        FlagBitsMaxEnumKHR = 0x7FFFFFFF,
    }
}
