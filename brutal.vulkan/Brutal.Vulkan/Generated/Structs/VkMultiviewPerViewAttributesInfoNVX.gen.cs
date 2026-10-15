namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMultiviewPerViewAttributesInfoNVX.html">VkMultiviewPerViewAttributesInfoNVX</see> - Structure specifying the multiview per-attribute properties
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkMultiviewPerViewAttributesInfoNVX</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_multiview_per_view_attributes with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///         typedef struct VkMultiviewPerViewAttributesInfoNVX {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           perViewAttributes;
    ///             VkBool32           perViewAttributesPositionXOnly;
    ///         } VkMultiviewPerViewAttributesInfoNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkMultiviewPerViewAttributesInfoNVX()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MultiviewPerViewAttributesInfoNVX;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PerViewAttributes</c> specifies that shaders compiled for this pipeline write the attributes for all views in a single invocation of each vertex processing stage. All pipelines executed within a render pass instance that includes this bit <i>must</i> write per-view attributes to the `*PerViewNV[]` shader outputs, in addition to the non-per-view (e.g. <c>Position</c>) outputs.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 PerViewAttributes;

        /// <summary>
        ///     <c>PerViewAttributesPositionXOnly</c> specifies that shaders compiled for this pipeline use per-view positions which only differ in value in the x component. Per-view viewport mask <i>can</i> also be used.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 PerViewAttributesPositionXOnly;
    }
}
