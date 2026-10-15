namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkRenderPassSampleLocationsBeginInfoEXT.html">VkRenderPassSampleLocationsBeginInfoEXT</see> - Structure specifying sample locations to use for the layout transition of custom sample locations compatible depth/stencil attachments
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The image layout of the depth aspect of a depth/stencil attachment referring
    ///         to an image created with
    ///         <c>VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT</c> is dependent
    ///         on the last sample locations used to render to the image subresource, thus
    ///         preserving the contents of such depth/stencil attachments across subpass
    ///         boundaries requires the application to specify these sample locations
    ///         whenever a layout transition of the attachment may: occur.
    ///         This information <i>can</i> be provided by adding a
    ///         <c>VkRenderPassSampleLocationsBeginInfoEXT</c> structure to the <c>pNext</c>
    ///         chain of <c>VkRenderPassBeginInfo</c>.
    ///     </para>
    ///     <para>
    ///         The <c>VkRenderPassSampleLocationsBeginInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_sample_locations
    ///         typedef struct VkRenderPassSampleLocationsBeginInfoEXT {
    ///             VkStructureType                          sType;
    ///             const void*                              pNext;
    ///             uint32_t                                 attachmentInitialSampleLocationsCount;
    ///             const VkAttachmentSampleLocationsEXT*    pAttachmentInitialSampleLocations;
    ///             uint32_t                                 postSubpassSampleLocationsCount;
    ///             const VkSubpassSampleLocationsEXT*       pPostSubpassSampleLocations;
    ///         } VkRenderPassSampleLocationsBeginInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.RenderPassSampleLocationsBeginInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AttachmentInitialSampleLocationsCount</c> is the number of elements in the <c>pAttachmentInitialSampleLocations</c> array.
        /// </summary>
        [FieldOffset(16)]
        public int AttachmentInitialSampleLocationsCount;

        /// <summary>
        ///     <c>AttachmentInitialSampleLocations</c> is a pointer to an array of <c>attachmentInitialSampleLocationsCount</c> <c>VkAttachmentSampleLocationsEXT</c> structures specifying the attachment indices and their corresponding sample location state. Each element of <c>pAttachmentInitialSampleLocations</c> <i>can</i> specify the sample location state to use in the automatic layout transition performed to transition a depth/stencil attachment from the initial layout of the attachment to the image layout specified for the attachment in the first subpass using it.
        /// </summary>
        [FieldOffset(24)]
        public VkAttachmentSampleLocationsEXT* AttachmentInitialSampleLocations;

        /// <summary>
        ///     <c>PostSubpassSampleLocationsCount</c> is the number of elements in the <c>pPostSubpassSampleLocations</c> array.
        /// </summary>
        [FieldOffset(32)]
        public int PostSubpassSampleLocationsCount;

        /// <summary>
        ///     <c>PostSubpassSampleLocations</c> is a pointer to an array of <c>postSubpassSampleLocationsCount</c> <c>VkSubpassSampleLocationsEXT</c> structures specifying the subpass indices and their corresponding sample location state. Each element of <c>pPostSubpassSampleLocations</c> <i>can</i> specify the sample location state to use in the automatic layout transition performed to transition the depth/stencil attachment used by the specified subpass to the image layout specified in a dependent subpass or to the final layout of the attachment in case the specified subpass is the last subpass using that attachment. In addition, if <c>VkPhysicalDeviceSampleLocationsPropertiesEXT::variableSampleLocations</c> is <c>VK_FALSE</c>, each element of <c>pPostSubpassSampleLocations</c> <i>must</i> specify the sample location state that matches the sample locations used by all pipelines that will be bound to a command buffer during the specified subpass. If <c>variableSampleLocations</c> is <c>VK_TRUE</c>, the sample locations used for rasterization do not depend on <c>pPostSubpassSampleLocations</c>.
        /// </summary>
        [FieldOffset(40)]
        public VkSubpassSampleLocationsEXT* PostSubpassSampleLocations;
    }
}
