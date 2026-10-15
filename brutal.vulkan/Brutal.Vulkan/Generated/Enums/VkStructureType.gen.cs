namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkStructureType.html">VkStructureType</see> - Vulkan structure types (&lt;c&gt;sType&lt;/c&gt;)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Each value corresponds to a particular structure with a <c>sType</c> member
    ///         with a matching name.
    ///         As a general rule, the name of each <c>VkStructureType</c> value is obtained
    ///         by taking the name of the structure, stripping the leading etext:Vk,
    ///         prefixing each capital letter except the first with etext:_, converting the
    ///         entire resulting string to upper case, and prefixing it with
    ///         etext:VK_STRUCTURE_TYPE_.
    ///         For example, structures of type <c>VkImageCreateInfo</c> correspond to a
    ///         <c>VkStructureType</c> value of <c>VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO</c>,
    ///         and thus a structure of this type <i>must</i> have its <c>sType</c> member set to
    ///         this value before it is passed to the API.
    ///     </para>
    ///     <para>
    ///         The values <c>VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO</c> and
    ///         <c>VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO</c> are reserved for internal
    ///         use by the loader, and do not have corresponding Vulkan structures in this
    ///         Specification.
    ///     </para>
    ///     <para>
    ///         Structure types supported by the Vulkan API include:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkStructureType {
    ///             VK_STRUCTURE_TYPE_APPLICATION_INFO = 0,
    ///             VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1,
    ///             VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2,
    ///             VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3,
    ///             VK_STRUCTURE_TYPE_SUBMIT_INFO = 4,
    ///             VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = 5,
    ///             VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 6,
    ///             VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = 7,
    ///             VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 8,
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 9,
    ///             VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 10,
    ///             VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 11,
    ///             VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 12,
    ///             VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 13,
    ///             VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 14,
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 15,
    ///             VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 16,
    ///             VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 17,
    ///             VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 18,
    ///             VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 19,
    ///             VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 20,
    ///             VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 21,
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 22,
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = 23,
    ///             VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 24,
    ///             VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 25,
    ///             VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 26,
    ///             VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = 27,
    ///             VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 28,
    ///             VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 29,
    ///             VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 30,
    ///             VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 31,
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 32,
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 33,
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = 34,
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 35,
    ///             VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 36,
    ///             VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 37,
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 38,
    ///             VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = 39,
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = 40,
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = 41,
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = 42,
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 43,
    ///             VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 44,
    ///             VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 45,
    ///             VK_STRUCTURE_TYPE_MEMORY_BARRIER = 46,
    ///             VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = 47,
    ///             VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = 48,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO = 1000157000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO = 1000157001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS = 1000127000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO = 1000127001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO = 1000060000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO = 1000060004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO = 1000060005,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO = 1000060006,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO = 1000060013,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO = 1000060014,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES = 1000070000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO = 1000070001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2 = 1000146000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2 = 1000146001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2 = 1000146002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2 = 1000146003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2 = 1000146004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2 = 1000059000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2 = 1000059001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2 = 1000059002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2 = 1000059003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2 = 1000059004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2 = 1000059005,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2 = 1000059006,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2 = 1000059007,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2 = 1000059008,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO = 1000117002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO = 1000145000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES = 1000145001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES = 1000145002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2 = 1000145003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO = 1000071000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES = 1000071001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO = 1000071002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES = 1000071003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES = 1000071004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO = 1000072000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO = 1000072001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO = 1000072002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO = 1000112000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES = 1000112001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO = 1000113000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO = 1000077000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO = 1000076000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES = 1000076001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES = 1000094000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES = 1000083000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES = 1000120000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO = 1000085000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES = 1000168000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT = 1000168001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO = 1000156000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO = 1000156001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO = 1000156002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO = 1000156003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES = 1000156004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES = 1000156005,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO = 1000060003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES = 1000117000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO = 1000117001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO = 1000117003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO = 1000053000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES = 1000053001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES = 1000053002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES = 1000063000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES = 1000196000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES = 49,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES = 50,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES = 51,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES = 52,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO = 1000147000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES = 1000211000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES = 1000261000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES = 1000207000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES = 1000207001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO = 1000207002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO = 1000207003,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO = 1000207004,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO = 1000207005,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES = 1000257000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO = 1000244001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO = 1000257002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO = 1000257003,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO = 1000257004,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES = 1000177000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES = 1000180000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES = 1000082000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES = 1000197000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO = 1000161000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES = 1000161001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES = 1000161002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO = 1000161003,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT = 1000161004,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES = 1000221000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES = 1000130000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO = 1000130001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES = 1000253000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES = 1000175000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2 = 1000109000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2 = 1000109001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2 = 1000109002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2 = 1000109003,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2 = 1000109004,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO = 1000109005,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SUBPASS_END_INFO = 1000109006,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES = 1000199000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE = 1000199001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO = 1000246000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES = 1000108000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO = 1000108001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO = 1000108002,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO = 1000108003,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES = 1000241000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT = 1000241001,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT = 1000241002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES = 53,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES = 54,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES = 1000245000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES = 1000295000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO = 1000295001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO = 1000295002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_MEMORY_BARRIER_2 = 1000314000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2 = 1000314001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2 = 1000314002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_DEPENDENCY_INFO = 1000314003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_SUBMIT_INFO_2 = 1000314004,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO = 1000314005,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO = 1000314006,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES = 1000314007,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2 = 1000337000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2 = 1000337001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2 = 1000337002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2 = 1000337003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_BUFFER_COPY_2 = 1000337006,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_IMAGE_COPY_2 = 1000337007,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2 = 1000337009,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES = 1000066000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3 = 1000360000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES = 1000413000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES = 1000413001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS = 1000413002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS = 1000413003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO = 1000192000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES = 1000215000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES = 1000276000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES = 1000297000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES = 1000325000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES = 1000335000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES = 1000225000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO = 1000225001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES = 1000225002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES = 1000138000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES = 1000138001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK = 1000138002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO = 1000138003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES = 1000280000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES = 1000280001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES = 1000281001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2 = 1000337004,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2 = 1000337005,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_IMAGE_BLIT_2 = 1000337008,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2 = 1000337010,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_RENDERING_INFO = 1000044000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO = 1000044001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO = 1000044002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES = 1000044003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO = 1000044004,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_FEATURES = 55,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_4_PROPERTIES = 56,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO = 1000174000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES = 1000388000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES = 1000388001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES = 1000265000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_MEMORY_MAP_INFO = 1000271000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO = 1000271001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES = 1000470000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES = 1000470001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO = 1000470004,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2 = 1000338002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2 = 1000338003,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO = 1000470006,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES = 1000545000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES = 1000545001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS = 1000545002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES = 1000270000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES = 1000270001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY = 1000270002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY = 1000270003,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO = 1000270004,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO = 1000270005,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO = 1000270006,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO = 1000270007,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE = 1000270008,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY = 1000270009,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES = 1000416000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES = 1000528000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES = 1000544000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO = 1000470005,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES = 1000080000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO = 1000545003,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO = 1000545004,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO = 1000545005,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO = 1000545006,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES = 1000466000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO = 1000068000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES = 1000068001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES = 1000068002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES = 1000259000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO = 1000259001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES = 1000259002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES = 1000525000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO = 1000190001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES = 1000190002,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_RENDERING_AREA_INFO = 1000470003,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES = 1000232000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO = 1000232001,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO = 1000232002,
    ///             // Provided by VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = 1000001000,
    ///             // Provided by VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = 1000001001,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_surface
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = 1000060007,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = 1000060008,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = 1000060009,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = 1000060010,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = 1000060011,
    ///             // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_swapchain
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = 1000060012,
    ///             // Provided by VK_KHR_display
    ///             VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = 1000002000,
    ///             // Provided by VK_KHR_display
    ///             VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = 1000002001,
    ///             // Provided by VK_KHR_display_swapchain
    ///             VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = 1000003000,
    ///             // Provided by VK_KHR_xlib_surface
    ///             VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = 1000004000,
    ///             // Provided by VK_KHR_xcb_surface
    ///             VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = 1000005000,
    ///             // Provided by VK_KHR_wayland_surface
    ///             VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = 1000006000,
    ///             // Provided by VK_KHR_android_surface
    ///             VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = 1000008000,
    ///             // Provided by VK_KHR_win32_surface
    ///             VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = 1000009000,
    ///             // Provided by VK_EXT_debug_report
    ///             VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = 1000011000,
    ///             // Provided by VK_AMD_rasterization_order
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = 1000018000,
    ///             // Provided by VK_EXT_debug_marker
    ///             VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = 1000022000,
    ///             // Provided by VK_EXT_debug_marker
    ///             VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = 1000022001,
    ///             // Provided by VK_EXT_debug_marker
    ///             VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = 1000022002,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR = 1000023000,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR = 1000023001,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR = 1000023002,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR = 1000023003,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR = 1000023004,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR = 1000023005,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000023006,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR = 1000023007,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR = 1000023008,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR = 1000023009,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR = 1000023010,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR = 1000023011,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR = 1000023012,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR = 1000023013,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR = 1000023014,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR = 1000023015,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR = 1000023016,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR = 1000024000,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR = 1000024001,
    ///             // Provided by VK_KHR_video_decode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR = 1000024002,
    ///             // Provided by VK_NV_dedicated_allocation
    ///             VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = 1000026000,
    ///             // Provided by VK_NV_dedicated_allocation
    ///             VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = 1000026001,
    ///             // Provided by VK_NV_dedicated_allocation
    ///             VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = 1000026002,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = 1000028000,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = 1000028001,
    ///             // Provided by VK_EXT_transform_feedback
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = 1000028002,
    ///             // Provided by VK_NVX_binary_import
    ///             VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX = 1000029000,
    ///             // Provided by VK_NVX_binary_import
    ///             VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX = 1000029001,
    ///             // Provided by VK_NVX_binary_import
    ///             VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX = 1000029002,
    ///             // Provided by VK_NVX_binary_import
    ///             VK_STRUCTURE_TYPE_CU_MODULE_TEXTURING_MODE_CREATE_INFO_NVX = 1000029004,
    ///             // Provided by VK_NVX_image_view_handle
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = 1000030000,
    ///             // Provided by VK_NVX_image_view_handle
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX = 1000030001,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_KHR = 1000038000,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000038001,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000038002,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR = 1000038003,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_KHR = 1000038004,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_KHR = 1000038005,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_KHR = 1000038006,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR = 1000038007,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR = 1000038008,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR = 1000038009,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_KHR = 1000038010,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR = 1000038011,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR = 1000038012,
    ///             // Provided by VK_KHR_video_encode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000038013,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_KHR = 1000039000,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000039001,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000039002,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR = 1000039003,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_KHR = 1000039004,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_KHR = 1000039005,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_KHR = 1000039006,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_KHR = 1000039007,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_KHR = 1000039009,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_KHR = 1000039010,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR = 1000039011,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_KHR = 1000039012,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR = 1000039013,
    ///             // Provided by VK_KHR_video_encode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000039014,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR = 1000040000,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR = 1000040001,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR = 1000040003,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000040004,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000040005,
    ///             // Provided by VK_KHR_video_decode_h264
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR = 1000040006,
    ///             // Provided by VK_AMD_texture_gather_bias_lod
    ///             VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = 1000041000,
    ///             // Provided by VK_GGP_stream_descriptor_surface
    ///             VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = 1000049000,
    ///             // Provided by VK_NV_corner_sampled_image
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = 1000050000,
    ///             // Provided by VK_NV_external_memory
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = 1000056000,
    ///             // Provided by VK_NV_external_memory
    ///             VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = 1000056001,
    ///             // Provided by VK_NV_external_memory_win32
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057000,
    ///             // Provided by VK_NV_external_memory_win32
    ///             VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057001,
    ///             // Provided by VK_NV_win32_keyed_mutex
    ///             VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = 1000058000,
    ///             // Provided by VK_EXT_validation_flags
    ///             VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = 1000061000,
    ///             // Provided by VK_NN_vi_surface
    ///             VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = 1000062000,
    ///             // Provided by VK_EXT_astc_decode_mode
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = 1000067000,
    ///             // Provided by VK_EXT_astc_decode_mode
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = 1000067001,
    ///             // Provided by VK_KHR_external_memory_win32
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073000,
    ///             // Provided by VK_KHR_external_memory_win32
    ///             VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073001,
    ///             // Provided by VK_KHR_external_memory_win32
    ///             VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = 1000073002,
    ///             // Provided by VK_KHR_external_memory_win32
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = 1000073003,
    ///             // Provided by VK_KHR_external_memory_fd
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = 1000074000,
    ///             // Provided by VK_KHR_external_memory_fd
    ///             VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = 1000074001,
    ///             // Provided by VK_KHR_external_memory_fd
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = 1000074002,
    ///             // Provided by VK_KHR_win32_keyed_mutex
    ///             VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = 1000075000,
    ///             // Provided by VK_KHR_external_semaphore_win32
    ///             VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078000,
    ///             // Provided by VK_KHR_external_semaphore_win32
    ///             VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078001,
    ///             // Provided by VK_KHR_external_semaphore_win32
    ///             VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = 1000078002,
    ///             // Provided by VK_KHR_external_semaphore_win32
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = 1000078003,
    ///             // Provided by VK_KHR_external_semaphore_fd
    ///             VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = 1000079000,
    ///             // Provided by VK_KHR_external_semaphore_fd
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = 1000079001,
    ///             // Provided by VK_EXT_conditional_rendering
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = 1000081000,
    ///             // Provided by VK_EXT_conditional_rendering
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = 1000081001,
    ///             // Provided by VK_EXT_conditional_rendering
    ///             VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = 1000081002,
    ///             // Provided by VK_KHR_incremental_present
    ///             VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = 1000084000,
    ///             // Provided by VK_NV_clip_space_w_scaling
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = 1000087000,
    ///             // Provided by VK_EXT_display_surface_counter
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = 1000090000,
    ///             // Provided by VK_EXT_display_control
    ///             VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = 1000091000,
    ///             // Provided by VK_EXT_display_control
    ///             VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = 1000091001,
    ///             // Provided by VK_EXT_display_control
    ///             VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = 1000091002,
    ///             // Provided by VK_EXT_display_control
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = 1000091003,
    ///             // Provided by VK_GOOGLE_display_timing
    ///             VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = 1000092000,
    ///             // Provided by VK_NVX_multiview_per_view_attributes
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = 1000097000,
    ///             // Provided by VK_NVX_multiview_per_view_attributes with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX = 1000044009,
    ///             // Provided by VK_NV_viewport_swizzle
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = 1000098000,
    ///             // Provided by VK_EXT_discard_rectangles
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = 1000099000,
    ///             // Provided by VK_EXT_discard_rectangles
    ///             VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = 1000099001,
    ///             // Provided by VK_EXT_conservative_rasterization
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = 1000101000,
    ///             // Provided by VK_EXT_conservative_rasterization
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = 1000101001,
    ///             // Provided by VK_EXT_depth_clip_enable
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = 1000102000,
    ///             // Provided by VK_EXT_depth_clip_enable
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = 1000102001,
    ///             // Provided by VK_EXT_hdr_metadata
    ///             VK_STRUCTURE_TYPE_HDR_METADATA_EXT = 1000105000,
    ///             // Provided by VK_IMG_relaxed_line_rasterization
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RELAXED_LINE_RASTERIZATION_FEATURES_IMG = 1000110000,
    ///             // Provided by VK_KHR_shared_presentable_image
    ///             VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = 1000111000,
    ///             // Provided by VK_KHR_external_fence_win32
    ///             VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114000,
    ///             // Provided by VK_KHR_external_fence_win32
    ///             VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114001,
    ///             // Provided by VK_KHR_external_fence_win32
    ///             VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = 1000114002,
    ///             // Provided by VK_KHR_external_fence_fd
    ///             VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = 1000115000,
    ///             // Provided by VK_KHR_external_fence_fd
    ///             VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = 1000115001,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR = 1000116000,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR = 1000116001,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR = 1000116002,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR = 1000116003,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR = 1000116004,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR = 1000116005,
    ///             // Provided by VK_KHR_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR = 1000116006,
    ///             // Provided by VK_KHR_get_surface_capabilities2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = 1000119000,
    ///             // Provided by VK_KHR_get_surface_capabilities2
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = 1000119001,
    ///             // Provided by VK_KHR_get_surface_capabilities2
    ///             VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = 1000119002,
    ///             // Provided by VK_KHR_get_display_properties2
    ///             VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = 1000121000,
    ///             // Provided by VK_KHR_get_display_properties2
    ///             VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = 1000121001,
    ///             // Provided by VK_KHR_get_display_properties2
    ///             VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = 1000121002,
    ///             // Provided by VK_KHR_get_display_properties2
    ///             VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = 1000121003,
    ///             // Provided by VK_KHR_get_display_properties2
    ///             VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = 1000121004,
    ///             // Provided by VK_MVK_ios_surface
    ///             VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = 1000122000,
    ///             // Provided by VK_MVK_macos_surface
    ///             VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = 1000123000,
    ///             // Provided by VK_EXT_debug_utils
    ///             VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = 1000128000,
    ///             // Provided by VK_EXT_debug_utils
    ///             VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = 1000128001,
    ///             // Provided by VK_EXT_debug_utils
    ///             VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = 1000128002,
    ///             // Provided by VK_EXT_debug_utils
    ///             VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = 1000128003,
    ///             // Provided by VK_EXT_debug_utils
    ///             VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = 1000128004,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = 1000129000,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = 1000129001,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = 1000129002,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129003,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129004,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer
    ///             VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = 1000129005,
    ///             // Provided by VK_ANDROID_external_memory_android_hardware_buffer with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID = 1000129006,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_FEATURES_AMD = 1000133000,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_PROPERTIES_AMD = 1000133001,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_GPA_SAMPLE_BEGIN_INFO_AMD = 1000133002,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_GPA_SESSION_CREATE_INFO_AMD = 1000133003,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_GPA_DEVICE_CLOCK_MODE_INFO_AMD = 1000133004,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GPA_PROPERTIES_2_AMD = 1000133005,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_STRUCTURE_TYPE_GPA_DEVICE_GET_CLOCK_INFO_AMD = 1000133006,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_FEATURES_AMDX = 1000134000,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_PROPERTIES_AMDX = 1000134001,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_SCRATCH_SIZE_AMDX = 1000134002,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_CREATE_INFO_AMDX = 1000134003,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_shader_enqueue
    ///             VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_NODE_CREATE_INFO_AMDX = 1000134004,
    ///             #endif
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_TEXEL_BUFFER_DESCRIPTOR_INFO_EXT = 1000135000,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_IMAGE_DESCRIPTOR_INFO_EXT = 1000135001,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_RESOURCE_DESCRIPTOR_INFO_EXT = 1000135002,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_BIND_HEAP_INFO_EXT = 1000135003,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_PUSH_DATA_INFO_EXT = 1000135004,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_AND_BINDING_MAPPING_EXT = 1000135005,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_SHADER_DESCRIPTOR_SET_AND_BINDING_MAPPING_INFO_EXT = 1000135006,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DATA_CREATE_INFO_EXT = 1000135007,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_PROPERTIES_EXT = 1000135008,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_FEATURES_EXT = 1000135009,
    ///             // Provided by VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_DESCRIPTOR_HEAP_INFO_EXT = 1000135010,
    ///             // Provided by VK_EXT_custom_border_color with VK_EXT_descriptor_heap
    ///             VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_INDEX_CREATE_INFO_EXT = 1000135011,
    ///             // Provided by VK_EXT_descriptor_heap with VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_PUSH_DATA_TOKEN_NV = 1000135012,
    ///             // Provided by VK_EXT_descriptor_heap with VK_EXT_fragment_density_map
    ///             VK_STRUCTURE_TYPE_SUBSAMPLED_IMAGE_FORMAT_PROPERTIES_EXT = 1000135013,
    ///             // Provided by VK_EXT_descriptor_heap with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_HEAP_TENSOR_PROPERTIES_ARM = 1000135014,
    ///             // Provided by VK_AMD_mixed_attachment_samples with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD = 1000044008,
    ///             // Provided by VK_KHR_shader_bfloat16
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_BFLOAT16_FEATURES_KHR = 1000141000,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = 1000143000,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = 1000143001,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = 1000143002,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = 1000143003,
    ///             // Provided by VK_EXT_sample_locations
    ///             VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = 1000143004,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = 1000148000,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = 1000148001,
    ///             // Provided by VK_EXT_blend_operation_advanced
    ///             VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = 1000148002,
    ///             // Provided by VK_NV_fragment_coverage_to_color
    ///             VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = 1000149000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR = 1000150007,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR = 1000150000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR = 1000150002,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR = 1000150003,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR = 1000150004,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR = 1000150005,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR = 1000150006,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR = 1000150009,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR = 1000150010,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR = 1000150011,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR = 1000150012,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR = 1000150013,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR = 1000150014,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR = 1000150017,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR = 1000150020,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR = 1000347000,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR = 1000347001,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR = 1000150015,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR = 1000150016,
    ///             // Provided by VK_KHR_ray_tracing_pipeline
    ///             VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR = 1000150018,
    ///             // Provided by VK_KHR_ray_query
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR = 1000348013,
    ///             // Provided by VK_NV_framebuffer_mixed_samples
    ///             VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = 1000152000,
    ///             // Provided by VK_NV_shader_sm_builtins
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV = 1000154000,
    ///             // Provided by VK_NV_shader_sm_builtins
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV = 1000154001,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = 1000158000,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = 1000158002,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = 1000158003,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = 1000158004,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = 1000158005,
    ///             // Provided by VK_EXT_image_drm_format_modifier with VK_KHR_format_feature_flags2 or VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT = 1000158006,
    ///             // Provided by VK_EXT_validation_cache
    ///             VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160000,
    ///             // Provided by VK_EXT_validation_cache
    ///             VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160001,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_KHR_portability_subset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR = 1000163000,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_KHR_portability_subset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR = 1000163001,
    ///             #endif
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = 1000164000,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = 1000164001,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = 1000164002,
    ///             // Provided by VK_NV_shading_rate_image
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = 1000164005,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = 1000165000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000165001,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_GEOMETRY_NV = 1000165003,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = 1000165004,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = 1000165005,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = 1000165006,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = 1000165007,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = 1000165008,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = 1000165009,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = 1000165011,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = 1000165012,
    ///             // Provided by VK_NV_representative_fragment_test
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = 1000166000,
    ///             // Provided by VK_NV_representative_fragment_test
    ///             VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = 1000166001,
    ///             // Provided by VK_EXT_filter_cubic
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = 1000170000,
    ///             // Provided by VK_EXT_filter_cubic
    ///             VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = 1000170001,
    ///             // Provided by VK_QCOM_cooperative_matrix_conversion
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_CONVERSION_FEATURES_QCOM = 1000172000,
    ///             // Provided by VK_QCOM_elapsed_timer_query
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ELAPSED_TIMER_QUERY_FEATURES_QCOM = 1000173000,
    ///             // Provided by VK_EXT_external_memory_host
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = 1000178000,
    ///             // Provided by VK_EXT_external_memory_host
    ///             VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = 1000178001,
    ///             // Provided by VK_EXT_external_memory_host
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = 1000178002,
    ///             // Provided by VK_KHR_shader_clock
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR = 1000181000,
    ///             // Provided by VK_AMD_pipeline_compiler_control
    ///             VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD = 1000183000,
    ///             // Provided by VK_AMD_shader_core_properties
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = 1000185000,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR = 1000187000,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000187001,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000187002,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR = 1000187003,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR = 1000187004,
    ///             // Provided by VK_KHR_video_decode_h265
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR = 1000187005,
    ///             // Provided by VK_AMD_memory_overallocation_behavior
    ///             VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = 1000189000,
    ///             // Provided by VK_EXT_vertex_attribute_divisor
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = 1000190000,
    ///             // Provided by VK_GGP_frame_token
    ///             VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = 1000191000,
    ///             // Provided by VK_NV_mesh_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = 1000202000,
    ///             // Provided by VK_NV_mesh_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = 1000202001,
    ///             // Provided by VK_NV_shader_image_footprint
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = 1000204000,
    ///             // Provided by VK_NV_scissor_exclusive
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = 1000205000,
    ///             // Provided by VK_NV_scissor_exclusive
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = 1000205002,
    ///             // Provided by VK_NV_device_diagnostic_checkpoints
    ///             VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = 1000206000,
    ///             // Provided by VK_NV_device_diagnostic_checkpoints
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = 1000206001,
    ///             // Provided by VK_NV_device_diagnostic_checkpoints with VK_VERSION_1_3 or VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV = 1000314008,
    ///             // Provided by VK_NV_device_diagnostic_checkpoints with VK_VERSION_1_3 or VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV = 1000314009,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_TIMING_FEATURES_EXT = 1000208000,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_TIMING_PROPERTIES_EXT = 1000208001,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_TIME_DOMAIN_PROPERTIES_EXT = 1000208002,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PRESENT_TIMINGS_INFO_EXT = 1000208003,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PRESENT_TIMING_INFO_EXT = 1000208004,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_INFO_EXT = 1000208005,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_PROPERTIES_EXT = 1000208006,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PAST_PRESENTATION_TIMING_EXT = 1000208007,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_PRESENT_TIMING_SURFACE_CAPABILITIES_EXT = 1000208008,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_CALIBRATED_TIMESTAMP_INFO_EXT = 1000208009,
    ///             // Provided by VK_INTEL_shader_integer_functions2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL = 1000209000,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL = 1000210000,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL = 1000210001,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL = 1000210002,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL = 1000210003,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL = 1000210004,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL = 1000210005,
    ///             // Provided by VK_EXT_pci_bus_info
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = 1000212000,
    ///             // Provided by VK_AMD_display_native_hdr
    ///             VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = 1000213000,
    ///             // Provided by VK_AMD_display_native_hdr
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = 1000213001,
    ///             // Provided by VK_FUCHSIA_imagepipe_surface
    ///             VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = 1000214000,
    ///             // Provided by VK_EXT_metal_surface
    ///             VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = 1000217000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = 1000218000,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = 1000218001,
    ///             // Provided by VK_EXT_fragment_density_map
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = 1000218002,
    ///             // Provided by VK_EXT_fragment_density_map with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT = 1000044007,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000226000,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR = 1000226001,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR = 1000226002,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR = 1000226003,
    ///             // Provided by VK_KHR_fragment_shading_rate
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR = 1000226004,
    ///             // Provided by VK_KHR_fragment_shading_rate with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000044006,
    ///             // Provided by VK_AMD_shader_core_properties2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD = 1000227000,
    ///             // Provided by VK_AMD_device_coherent_memory
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD = 1000229000,
    ///             // Provided by VK_KHR_shader_constant_data
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CONSTANT_DATA_FEATURES_KHR = 1000231000,
    ///             // Provided by VK_KHR_shader_abort
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ABORT_FEATURES_KHR = 1000233000,
    ///             // Provided by VK_KHR_shader_abort
    ///             VK_STRUCTURE_TYPE_DEVICE_FAULT_SHADER_ABORT_MESSAGE_INFO_KHR = 1000233001,
    ///             // Provided by VK_KHR_shader_abort
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ABORT_PROPERTIES_KHR = 1000233002,
    ///             // Provided by VK_EXT_shader_image_atomic_int64
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT = 1000234000,
    ///             // Provided by VK_KHR_shader_quad_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_QUAD_CONTROL_FEATURES_KHR = 1000235000,
    ///             // Provided by VK_EXT_memory_budget
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = 1000237000,
    ///             // Provided by VK_EXT_memory_priority
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = 1000238000,
    ///             // Provided by VK_EXT_memory_priority
    ///             VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = 1000238001,
    ///             // Provided by VK_KHR_surface_protected_capabilities
    ///             VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = 1000239000,
    ///             // Provided by VK_NV_dedicated_allocation_image_aliasing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = 1000240000,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = 1000244000,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = 1000244002,
    ///             // Provided by VK_EXT_validation_features
    ///             VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = 1000247000,
    ///             // Provided by VK_KHR_present_wait
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR = 1000248000,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = 1000249000,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249001,
    ///             // Provided by VK_NV_cooperative_matrix
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249002,
    ///             // Provided by VK_NV_coverage_reduction_mode
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV = 1000250000,
    ///             // Provided by VK_NV_coverage_reduction_mode
    ///             VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV = 1000250001,
    ///             // Provided by VK_NV_coverage_reduction_mode
    ///             VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV = 1000250002,
    ///             // Provided by VK_EXT_fragment_shader_interlock
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT = 1000251000,
    ///             // Provided by VK_EXT_ycbcr_image_arrays
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = 1000252000,
    ///             // Provided by VK_EXT_provoking_vertex
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT = 1000254000,
    ///             // Provided by VK_EXT_provoking_vertex
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT = 1000254001,
    ///             // Provided by VK_EXT_provoking_vertex
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT = 1000254002,
    ///             // Provided by VK_EXT_full_screen_exclusive
    ///             VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = 1000255000,
    ///             // Provided by VK_EXT_full_screen_exclusive
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = 1000255002,
    ///             // Provided by VK_KHR_win32_surface with VK_EXT_full_screen_exclusive
    ///             VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = 1000255001,
    ///             // Provided by VK_EXT_headless_surface
    ///             VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT = 1000256000,
    ///             // Provided by VK_EXT_shader_atomic_float
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT = 1000260000,
    ///             // Provided by VK_EXT_extended_dynamic_state
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT = 1000267000,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR = 1000269000,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR = 1000269001,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR = 1000269002,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR = 1000269003,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR = 1000269004,
    ///             // Provided by VK_KHR_pipeline_executable_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR = 1000269005,
    ///             // Provided by VK_EXT_map_memory_placed
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_FEATURES_EXT = 1000272000,
    ///             // Provided by VK_EXT_map_memory_placed
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAP_MEMORY_PLACED_PROPERTIES_EXT = 1000272001,
    ///             // Provided by VK_EXT_map_memory_placed
    ///             VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT = 1000272002,
    ///             // Provided by VK_EXT_shader_atomic_float2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT = 1000273000,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV = 1000277000,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV = 1000277001,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV = 1000277002,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV = 1000277003,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV = 1000277004,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV = 1000277005,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV = 1000277006,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV = 1000277007,
    ///             // Provided by VK_NV_inherited_viewport_scissor
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV = 1000278000,
    ///             // Provided by VK_NV_inherited_viewport_scissor
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV = 1000278001,
    ///             // Provided by VK_EXT_texel_buffer_alignment
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT = 1000281000,
    ///             // Provided by VK_QCOM_render_pass_transform
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM = 1000282000,
    ///             // Provided by VK_QCOM_render_pass_transform
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM = 1000282001,
    ///             // Provided by VK_EXT_depth_bias_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT = 1000283000,
    ///             // Provided by VK_EXT_depth_bias_control
    ///             VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT = 1000283001,
    ///             // Provided by VK_EXT_depth_bias_control
    ///             VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT = 1000283002,
    ///             // Provided by VK_EXT_device_memory_report
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT = 1000284000,
    ///             // Provided by VK_EXT_device_memory_report
    ///             VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT = 1000284001,
    ///             // Provided by VK_EXT_device_memory_report
    ///             VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT = 1000284002,
    ///             // Provided by VK_EXT_custom_border_color
    ///             VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT = 1000287000,
    ///             // Provided by VK_EXT_custom_border_color
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT = 1000287001,
    ///             // Provided by VK_EXT_custom_border_color
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT = 1000287002,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_3D_FEATURES_EXT = 1000288000,
    ///             // Provided by VK_KHR_pipeline_library
    ///             VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR = 1000290000,
    ///             // Provided by VK_NV_present_barrier
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV = 1000292000,
    ///             // Provided by VK_NV_present_barrier
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV = 1000292001,
    ///             // Provided by VK_NV_present_barrier
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV = 1000292002,
    ///             // Provided by VK_KHR_present_id
    ///             VK_STRUCTURE_TYPE_PRESENT_ID_KHR = 1000294000,
    ///             // Provided by VK_KHR_present_id
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR = 1000294001,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR = 1000299000,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR = 1000299001,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR = 1000299002,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR = 1000299003,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR = 1000299004,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR = 1000299005,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = 1000299006,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR = 1000299007,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = 1000299008,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR = 1000299009,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = 1000299010,
    ///             // Provided by VK_NV_device_diagnostics_config
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV = 1000300000,
    ///             // Provided by VK_NV_device_diagnostics_config
    ///             VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV = 1000300001,
    ///             // Provided by VK_QCOM_queue_perf_hint
    ///             VK_STRUCTURE_TYPE_PERF_HINT_INFO_QCOM = 1000302000,
    ///             // Provided by VK_QCOM_queue_perf_hint
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_PERF_HINT_FEATURES_QCOM = 1000302001,
    ///             // Provided by VK_QCOM_queue_perf_hint
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_PERF_HINT_PROPERTIES_QCOM = 1000302002,
    ///             // Provided by VK_QCOM_image_processing3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_3_FEATURES_QCOM = 1000303000,
    ///             // Provided by VK_QCOM_shader_multiple_wait_queues
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MULTIPLE_WAIT_QUEUES_FEATURES_QCOM = 1000304000,
    ///             // Provided by VK_QCOM_shader_multiple_wait_queues
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MULTIPLE_WAIT_QUEUES_PROPERTIES_QCOM = 1000304001,
    ///             // Provided by VK_EXT_shader_split_barrier
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SPLIT_BARRIER_FEATURES_EXT = 1000305000,
    ///             // Provided by VK_EXT_shader_split_barrier
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SPLIT_BARRIER_PROPERTIES_EXT = 1000305001,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_STRUCTURE_TYPE_CUDA_MODULE_CREATE_INFO_NV = 1000307000,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_STRUCTURE_TYPE_CUDA_FUNCTION_CREATE_INFO_NV = 1000307001,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_STRUCTURE_TYPE_CUDA_LAUNCH_INFO_NV = 1000307002,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUDA_KERNEL_LAUNCH_FEATURES_NV = 1000307003,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUDA_KERNEL_LAUNCH_PROPERTIES_NV = 1000307004,
    ///             #endif
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_FEATURES_QCOM = 1000309000,
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_SHADING_PROPERTIES_QCOM = 1000309001,
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_TILE_SHADING_CREATE_INFO_QCOM = 1000309002,
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_STRUCTURE_TYPE_PER_TILE_BEGIN_INFO_QCOM = 1000309003,
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_STRUCTURE_TYPE_PER_TILE_END_INFO_QCOM = 1000309004,
    ///             // Provided by VK_QCOM_tile_shading
    ///             VK_STRUCTURE_TYPE_DISPATCH_TILE_INFO_QCOM = 1000309005,
    ///             // Provided by VK_NV_low_latency
    ///             VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV = 1000310000,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT = 1000311000,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT = 1000311001,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT = 1000311002,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT = 1000311003,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT = 1000311004,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT = 1000311005,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT = 1000311006,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT = 1000311007,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT = 1000311008,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT = 1000311009,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311010,
    ///             // Provided by VK_EXT_metal_objects
    ///             VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311011,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT = 1000316000,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT = 1000316001,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT = 1000316002,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT = 1000316003,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT = 1000316004,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316005,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316006,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316007,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316008,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT = 1000316010,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT = 1000316011,
    ///             // Provided by VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT = 1000316012,
    ///             // Provided by VK_EXT_descriptor_buffer with VK_KHR_acceleration_structure or VK_NV_ray_tracing
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316009,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_DEVICE_MEMORY_COPY_KHR = 1000318000,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_COPY_DEVICE_MEMORY_INFO_KHR = 1000318001,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_DEVICE_MEMORY_IMAGE_COPY_KHR = 1000318002,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_COPY_DEVICE_MEMORY_IMAGE_INFO_KHR = 1000318003,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_MEMORY_RANGE_BARRIERS_INFO_KHR = 1000318004,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_MEMORY_RANGE_BARRIER_KHR = 1000318005,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_ADDRESS_COMMANDS_FEATURES_KHR = 1000318006,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_BIND_INDEX_BUFFER_3_INFO_KHR = 1000318007,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_BIND_VERTEX_BUFFER_3_INFO_KHR = 1000318008,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_DRAW_INDIRECT_2_INFO_KHR = 1000318009,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_DRAW_INDIRECT_COUNT_2_INFO_KHR = 1000318010,
    ///             // Provided by VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_DISPATCH_INDIRECT_2_INFO_KHR = 1000318011,
    ///             // Provided by VK_KHR_device_address_commands with VK_EXT_conditional_rendering
    ///             VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_2_EXT = 1000318012,
    ///             // Provided by VK_KHR_device_address_commands with VK_EXT_transform_feedback
    ///             VK_STRUCTURE_TYPE_BIND_TRANSFORM_FEEDBACK_BUFFER_2_INFO_EXT = 1000318013,
    ///             // Provided by VK_KHR_device_address_commands with VK_AMD_buffer_marker
    ///             VK_STRUCTURE_TYPE_MEMORY_MARKER_INFO_AMD = 1000318014,
    ///             // Provided by VK_KHR_acceleration_structure with VK_KHR_device_address_commands
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_2_KHR = 1000318015,
    ///             // Provided by VK_EXT_graphics_pipeline_library
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT = 1000320000,
    ///             // Provided by VK_EXT_graphics_pipeline_library
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT = 1000320001,
    ///             // Provided by VK_EXT_graphics_pipeline_library
    ///             VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT = 1000320002,
    ///             // Provided by VK_AMD_shader_early_and_late_fragment_tests
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD = 1000321000,
    ///             // Provided by VK_KHR_fragment_shader_barycentric
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR = 1000203000,
    ///             // Provided by VK_KHR_fragment_shader_barycentric with VK_EXT_provoking_vertex
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR = 1000322000,
    ///             // Provided by VK_KHR_shader_subgroup_uniform_control_flow
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR = 1000323000,
    ///             // Provided by VK_NV_fragment_shading_rate_enums
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV = 1000326000,
    ///             // Provided by VK_NV_fragment_shading_rate_enums
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV = 1000326001,
    ///             // Provided by VK_NV_fragment_shading_rate_enums
    ///             VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV = 1000326002,
    ///             // Provided by VK_NV_ray_tracing_motion_blur
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV = 1000327000,
    ///             // Provided by VK_NV_ray_tracing_motion_blur
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV = 1000327001,
    ///             // Provided by VK_NV_ray_tracing_motion_blur
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV = 1000327002,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT = 1000328000,
    ///             // Provided by VK_EXT_mesh_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT = 1000328001,
    ///             // Provided by VK_EXT_ycbcr_2plane_444_formats
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT = 1000330000,
    ///             // Provided by VK_EXT_fragment_density_map2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT = 1000332000,
    ///             // Provided by VK_EXT_fragment_density_map2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT = 1000332001,
    ///             // Provided by VK_QCOM_rotated_copy_commands
    ///             VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM = 1000333000,
    ///             // Provided by VK_KHR_workgroup_memory_explicit_layout
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR = 1000336000,
    ///             // Provided by VK_EXT_image_compression_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT = 1000338000,
    ///             // Provided by VK_EXT_image_compression_control
    ///             VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT = 1000338001,
    ///             // Provided by VK_EXT_image_compression_control
    ///             VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT = 1000338004,
    ///             // Provided by VK_EXT_attachment_feedback_loop_layout
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT = 1000339000,
    ///             // Provided by VK_EXT_4444_formats
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT = 1000340000,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT = 1000341000,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT = 1000341001,
    ///             // Provided by VK_EXT_device_fault
    ///             VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT = 1000341002,
    ///             // Provided by VK_EXT_rgba10x6_formats
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT = 1000344000,
    ///             // Provided by VK_EXT_directfb_surface
    ///             VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT = 1000346000,
    ///             // Provided by VK_EXT_vertex_input_dynamic_state
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT = 1000352000,
    ///             // Provided by VK_EXT_shader_object, VK_EXT_vertex_input_dynamic_state
    ///             VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT = 1000352001,
    ///             // Provided by VK_EXT_shader_object, VK_EXT_vertex_input_dynamic_state
    ///             VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT = 1000352002,
    ///             // Provided by VK_EXT_physical_device_drm
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT = 1000353000,
    ///             // Provided by VK_EXT_device_address_binding_report
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT = 1000354000,
    ///             // Provided by VK_EXT_device_address_binding_report
    ///             VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT = 1000354001,
    ///             // Provided by VK_EXT_depth_clip_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT = 1000355000,
    ///             // Provided by VK_EXT_depth_clip_control
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT = 1000355001,
    ///             // Provided by VK_EXT_primitive_topology_list_restart
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT = 1000356000,
    ///             // Provided by VK_FUCHSIA_external_memory
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364000,
    ///             // Provided by VK_FUCHSIA_external_memory
    ///             VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA = 1000364001,
    ///             // Provided by VK_FUCHSIA_external_memory
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364002,
    ///             // Provided by VK_FUCHSIA_external_semaphore
    ///             VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365000,
    ///             // Provided by VK_FUCHSIA_external_semaphore
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365001,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA = 1000366000,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA = 1000366001,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA = 1000366002,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA = 1000366003,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA = 1000366004,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA = 1000366005,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA = 1000366006,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA = 1000366007,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA = 1000366008,
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA = 1000366009,
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI = 1000369000,
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI = 1000369001,
    ///             // Provided by VK_HUAWEI_subpass_shading
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI = 1000369002,
    ///             // Provided by VK_HUAWEI_invocation_mask
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI = 1000370000,
    ///             // Provided by VK_NV_external_memory_rdma
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV = 1000371000,
    ///             // Provided by VK_NV_external_memory_rdma
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV = 1000371001,
    ///             // Provided by VK_EXT_pipeline_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT = 1000372000,
    ///             // Provided by VK_EXT_pipeline_properties
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT = 1000372001,
    ///             // Provided by VK_EXT_frame_boundary
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT = 1000375000,
    ///             // Provided by VK_EXT_frame_boundary
    ///             VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT = 1000375001,
    ///             // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT = 1000376000,
    ///             // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///             VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT = 1000376001,
    ///             // Provided by VK_EXT_multisampled_render_to_single_sampled
    ///             VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT = 1000376002,
    ///             // Provided by VK_EXT_extended_dynamic_state2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT = 1000377000,
    ///             // Provided by VK_QNX_screen_surface
    ///             VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX = 1000378000,
    ///             // Provided by VK_EXT_color_write_enable
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT = 1000381000,
    ///             // Provided by VK_EXT_color_write_enable
    ///             VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT = 1000381001,
    ///             // Provided by VK_EXT_primitives_generated_query
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT = 1000382000,
    ///             // Provided by VK_KHR_ray_tracing_maintenance1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR = 1000386000,
    ///             // Provided by VK_KHR_shader_untyped_pointers
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNTYPED_POINTERS_FEATURES_KHR = 1000387000,
    ///             // Provided by VK_VALVE_video_encode_rgb_conversion
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_RGB_CONVERSION_FEATURES_VALVE = 1000390000,
    ///             // Provided by VK_VALVE_video_encode_rgb_conversion
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_RGB_CONVERSION_CAPABILITIES_VALVE = 1000390001,
    ///             // Provided by VK_VALVE_video_encode_rgb_conversion
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_PROFILE_RGB_CONVERSION_INFO_VALVE = 1000390002,
    ///             // Provided by VK_VALVE_video_encode_rgb_conversion
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_RGB_CONVERSION_CREATE_INFO_VALVE = 1000390003,
    ///             // Provided by VK_EXT_image_view_min_lod
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT = 1000391000,
    ///             // Provided by VK_EXT_image_view_min_lod
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT = 1000391001,
    ///             // Provided by VK_EXT_multi_draw
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT = 1000392000,
    ///             // Provided by VK_EXT_multi_draw
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT = 1000392001,
    ///             // Provided by VK_EXT_image_2d_view_of_3d
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT = 1000393000,
    ///             // Provided by VK_EXT_shader_tile_image
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT = 1000395000,
    ///             // Provided by VK_EXT_shader_tile_image
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT = 1000395001,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT = 1000396000,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT = 1000396001,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT = 1000396002,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT = 1000396003,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT = 1000396004,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT = 1000396005,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT = 1000396006,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT = 1000396007,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT = 1000396008,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT = 1000396009,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_FEATURES_NV = 1000397000,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_PROPERTIES_NV = 1000397001,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_displacement_micromap
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_DISPLACEMENT_MICROMAP_NV = 1000397002,
    ///             #endif
    ///             // Provided by VK_HUAWEI_cluster_culling_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI = 1000404000,
    ///             // Provided by VK_HUAWEI_cluster_culling_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI = 1000404001,
    ///             // Provided by VK_HUAWEI_cluster_culling_shader
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_VRS_FEATURES_HUAWEI = 1000404002,
    ///             // Provided by VK_EXT_border_color_swizzle
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT = 1000411000,
    ///             // Provided by VK_EXT_border_color_swizzle
    ///             VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT = 1000411001,
    ///             // Provided by VK_EXT_pageable_device_local_memory
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT = 1000412000,
    ///             // Provided by VK_ARM_shader_core_properties
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM = 1000415000,
    ///             // Provided by VK_ARM_scheduling_controls
    ///             VK_STRUCTURE_TYPE_DEVICE_QUEUE_SHADER_CORE_CONTROL_CREATE_INFO_ARM = 1000417000,
    ///             // Provided by VK_ARM_scheduling_controls
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_FEATURES_ARM = 1000417001,
    ///             // Provided by VK_ARM_scheduling_controls
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_PROPERTIES_ARM = 1000417002,
    ///             // Provided by VK_ARM_scheduling_controls
    ///             VK_STRUCTURE_TYPE_DISPATCH_PARAMETERS_ARM = 1000417003,
    ///             // Provided by VK_ARM_scheduling_controls
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCHEDULING_CONTROLS_DISPATCH_PARAMETERS_PROPERTIES_ARM = 1000417004,
    ///             // Provided by VK_EXT_image_sliced_view_of_3d
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT = 1000418000,
    ///             // Provided by VK_EXT_image_sliced_view_of_3d
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT = 1000418001,
    ///             // Provided by VK_VALVE_descriptor_set_host_mapping
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE = 1000420000,
    ///             // Provided by VK_VALVE_descriptor_set_host_mapping
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE = 1000420001,
    ///             // Provided by VK_VALVE_descriptor_set_host_mapping
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE = 1000420002,
    ///             // Provided by VK_EXT_non_seamless_cube_map
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT = 1000422000,
    ///             // Provided by VK_ARM_render_pass_striped
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_FEATURES_ARM = 1000424000,
    ///             // Provided by VK_ARM_render_pass_striped
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RENDER_PASS_STRIPED_PROPERTIES_ARM = 1000424001,
    ///             // Provided by VK_ARM_render_pass_striped
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_BEGIN_INFO_ARM = 1000424002,
    ///             // Provided by VK_ARM_render_pass_striped
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_INFO_ARM = 1000424003,
    ///             // Provided by VK_ARM_render_pass_striped
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_STRIPE_SUBMIT_INFO_ARM = 1000424004,
    ///             // Provided by VK_NV_copy_memory_indirect
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV = 1000426000,
    ///             // Provided by VK_NV_device_generated_commands_compute
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV = 1000428000,
    ///             // Provided by VK_NV_device_generated_commands_compute
    ///             VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV = 1000428001,
    ///             // Provided by VK_NV_device_generated_commands_compute
    ///             VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV = 1000428002,
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_LINEAR_SWEPT_SPHERES_FEATURES_NV = 1000429008,
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_LINEAR_SWEPT_SPHERES_DATA_NV = 1000429009,
    ///             // Provided by VK_NV_ray_tracing_linear_swept_spheres
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_SPHERES_DATA_NV = 1000429010,
    ///             // Provided by VK_NV_linear_color_attachment
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV = 1000430000,
    ///             // Provided by VK_KHR_shader_maximal_reconvergence
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MAXIMAL_RECONVERGENCE_FEATURES_KHR = 1000434000,
    ///             // Provided by VK_EXT_image_compression_control_swapchain
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT = 1000437000,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM = 1000440000,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM = 1000440001,
    ///             // Provided by VK_QCOM_image_processing
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM = 1000440002,
    ///             // Provided by VK_EXT_nested_command_buffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_FEATURES_EXT = 1000451000,
    ///             // Provided by VK_EXT_nested_command_buffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NESTED_COMMAND_BUFFER_PROPERTIES_EXT = 1000451001,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_STRUCTURE_TYPE_NATIVE_BUFFER_USAGE_OHOS = 1000452000,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_STRUCTURE_TYPE_NATIVE_BUFFER_PROPERTIES_OHOS = 1000452001,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_STRUCTURE_TYPE_NATIVE_BUFFER_FORMAT_PROPERTIES_OHOS = 1000452002,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_STRUCTURE_TYPE_IMPORT_NATIVE_BUFFER_INFO_OHOS = 1000452003,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_NATIVE_BUFFER_INFO_OHOS = 1000452004,
    ///             // Provided by VK_OHOS_external_memory
    ///             VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_OHOS = 1000452005,
    ///             // Provided by VK_EXT_external_memory_acquire_unmodified
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT = 1000453000,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT = 1000455000,
    ///             // Provided by VK_EXT_extended_dynamic_state3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT = 1000455001,
    ///             // Provided by VK_EXT_subpass_merge_feedback
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT = 1000458000,
    ///             // Provided by VK_EXT_subpass_merge_feedback
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT = 1000458001,
    ///             // Provided by VK_EXT_subpass_merge_feedback
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT = 1000458002,
    ///             // Provided by VK_EXT_subpass_merge_feedback
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT = 1000458003,
    ///             // Provided by VK_LUNARG_direct_driver_loading
    ///             VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG = 1000459000,
    ///             // Provided by VK_LUNARG_direct_driver_loading
    ///             VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG = 1000459001,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_CREATE_INFO_ARM = 1000460000,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_VIEW_CREATE_INFO_ARM = 1000460001,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_BIND_TENSOR_MEMORY_INFO_ARM = 1000460002,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_TENSOR_ARM = 1000460003,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_PROPERTIES_ARM = 1000460004,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_FORMAT_PROPERTIES_ARM = 1000460005,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_DESCRIPTION_ARM = 1000460006,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_MEMORY_REQUIREMENTS_INFO_ARM = 1000460007,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_MEMORY_BARRIER_ARM = 1000460008,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TENSOR_FEATURES_ARM = 1000460009,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_DEVICE_TENSOR_MEMORY_REQUIREMENTS_ARM = 1000460010,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_COPY_TENSOR_INFO_ARM = 1000460011,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_COPY_ARM = 1000460012,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_DEPENDENCY_INFO_ARM = 1000460013,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_TENSOR_ARM = 1000460014,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_TENSOR_INFO_ARM = 1000460015,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_EXTERNAL_TENSOR_PROPERTIES_ARM = 1000460016,
    ///             // Provided by VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_TENSOR_CREATE_INFO_ARM = 1000460017,
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_FEATURES_ARM = 1000460018,
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_TENSOR_PROPERTIES_ARM = 1000460019,
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_GET_TENSOR_INFO_ARM = 1000460020,
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_CAPTURE_DESCRIPTOR_DATA_INFO_ARM = 1000460021,
    ///             // Provided by VK_EXT_descriptor_buffer with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_TENSOR_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_ARM = 1000460022,
    ///             // Provided by VK_EXT_frame_boundary with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_FRAME_BOUNDARY_TENSORS_ARM = 1000460023,
    ///             // Provided by VK_EXT_shader_module_identifier
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT = 1000462000,
    ///             // Provided by VK_EXT_shader_module_identifier
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT = 1000462001,
    ///             // Provided by VK_EXT_shader_module_identifier
    ///             VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT = 1000462002,
    ///             // Provided by VK_EXT_shader_module_identifier
    ///             VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT = 1000462003,
    ///             // Provided by VK_EXT_rasterization_order_attachment_access
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT = 1000342000,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV = 1000464000,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV = 1000464001,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV = 1000464002,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV = 1000464003,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV = 1000464004,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV = 1000464005,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV = 1000464010,
    ///             // Provided by VK_EXT_legacy_dithering
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT = 1000465000,
    ///             // Provided by VK_ANDROID_external_format_resolve
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_FEATURES_ANDROID = 1000468000,
    ///             // Provided by VK_ANDROID_external_format_resolve
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID = 1000468001,
    ///             // Provided by VK_ANDROID_external_format_resolve
    ///             VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID = 1000468002,
    ///             // Provided by VK_AMD_anti_lag
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ANTI_LAG_FEATURES_AMD = 1000476000,
    ///             // Provided by VK_AMD_anti_lag
    ///             VK_STRUCTURE_TYPE_ANTI_LAG_DATA_AMD = 1000476001,
    ///             // Provided by VK_AMD_anti_lag
    ///             VK_STRUCTURE_TYPE_ANTI_LAG_PRESENTATION_INFO_AMD = 1000476002,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_dense_geometry_format
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DENSE_GEOMETRY_FORMAT_FEATURES_AMDX = 1000478000,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_AMDX_dense_geometry_format
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DENSE_GEOMETRY_FORMAT_TRIANGLES_DATA_AMDX = 1000478001,
    ///             #endif
    ///             // Provided by VK_KHR_present_id2
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_ID_2_KHR = 1000479000,
    ///             // Provided by VK_KHR_present_id2
    ///             VK_STRUCTURE_TYPE_PRESENT_ID_2_KHR = 1000479001,
    ///             // Provided by VK_KHR_present_id2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_2_FEATURES_KHR = 1000479002,
    ///             // Provided by VK_KHR_present_wait2
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_WAIT_2_KHR = 1000480000,
    ///             // Provided by VK_KHR_present_wait2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_2_FEATURES_KHR = 1000480001,
    ///             // Provided by VK_KHR_present_wait2
    ///             VK_STRUCTURE_TYPE_PRESENT_WAIT_2_INFO_KHR = 1000480002,
    ///             // Provided by VK_KHR_ray_tracing_position_fetch
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR = 1000481000,
    ///             // Provided by VK_EXT_shader_object
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT = 1000482000,
    ///             // Provided by VK_EXT_shader_object
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT = 1000482001,
    ///             // Provided by VK_EXT_shader_object
    ///             VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT = 1000482002,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_FEATURES_KHR = 1000483000,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR = 1000483001,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR = 1000483002,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PIPELINE_BINARY_KEY_KHR = 1000483003,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_BINARY_PROPERTIES_KHR = 1000483004,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_RELEASE_CAPTURED_PIPELINE_DATA_INFO_KHR = 1000483005,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PIPELINE_BINARY_DATA_INFO_KHR = 1000483006,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PIPELINE_CREATE_INFO_KHR = 1000483007,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_DEVICE_PIPELINE_BINARY_INTERNAL_CACHE_CONTROL_KHR = 1000483008,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_STRUCTURE_TYPE_PIPELINE_BINARY_HANDLES_INFO_KHR = 1000483009,
    ///             // Provided by VK_QCOM_tile_properties
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM = 1000484000,
    ///             // Provided by VK_QCOM_tile_properties
    ///             VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM = 1000484001,
    ///             // Provided by VK_SEC_amigo_profiling
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC = 1000485000,
    ///             // Provided by VK_SEC_amigo_profiling
    ///             VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC = 1000485001,
    ///             // Provided by VK_KHR_surface_maintenance1
    ///             VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR = 1000274000,
    ///             // Provided by VK_KHR_surface_maintenance1
    ///             VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR = 1000274001,
    ///             // Provided by VK_KHR_surface_maintenance1
    ///             VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR = 1000274002,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_KHR = 1000275000,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_KHR = 1000275001,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_KHR = 1000275002,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_KHR = 1000275003,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_KHR = 1000275004,
    ///             // Provided by VK_KHR_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_KHR = 1000275005,
    ///             // Provided by VK_QCOM_multiview_per_view_viewports
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM = 1000488000,
    ///             // Provided by VK_NV_ray_tracing_invocation_reorder
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV = 1000490000,
    ///             // Provided by VK_NV_ray_tracing_invocation_reorder
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV = 1000490001,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_FEATURES_NV = 1000491000,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_VECTOR_PROPERTIES_NV = 1000491001,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_STRUCTURE_TYPE_COOPERATIVE_VECTOR_PROPERTIES_NV = 1000491002,
    ///             // Provided by VK_NV_cooperative_vector
    ///             VK_STRUCTURE_TYPE_CONVERT_COOPERATIVE_VECTOR_MATRIX_INFO_NV = 1000491004,
    ///             // Provided by VK_NV_extended_sparse_address_space
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_FEATURES_NV = 1000492000,
    ///             // Provided by VK_NV_extended_sparse_address_space
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV = 1000492001,
    ///             // Provided by VK_EXT_mutable_descriptor_type
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT = 1000351000,
    ///             // Provided by VK_EXT_mutable_descriptor_type
    ///             VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT = 1000351002,
    ///             // Provided by VK_EXT_legacy_vertex_attributes
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_FEATURES_EXT = 1000495000,
    ///             // Provided by VK_EXT_legacy_vertex_attributes
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_VERTEX_ATTRIBUTES_PROPERTIES_EXT = 1000495001,
    ///             // Provided by VK_EXT_layer_settings
    ///             VK_STRUCTURE_TYPE_LAYER_SETTINGS_CREATE_INFO_EXT = 1000496000,
    ///             // Provided by VK_ARM_shader_core_builtins
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM = 1000497000,
    ///             // Provided by VK_ARM_shader_core_builtins
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM = 1000497001,
    ///             // Provided by VK_EXT_pipeline_library_group_handles
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT = 1000498000,
    ///             // Provided by VK_EXT_dynamic_rendering_unused_attachments
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT = 1000499000,
    ///             // Provided by VK_KHR_internally_synchronized_queues
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INTERNALLY_SYNCHRONIZED_QUEUES_FEATURES_KHR = 1000504000,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV = 1000505000,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV = 1000505001,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV = 1000505002,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV = 1000505003,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_LATENCY_TIMINGS_FRAME_REPORT_NV = 1000505004,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV = 1000505005,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_OUT_OF_BAND_QUEUE_TYPE_INFO_NV = 1000505006,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_LATENCY_CREATE_INFO_NV = 1000505007,
    ///             // Provided by VK_NV_low_latency2
    ///             VK_STRUCTURE_TYPE_LATENCY_SURFACE_CAPABILITIES_NV = 1000505008,
    ///             // Provided by VK_KHR_cooperative_matrix
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR = 1000506000,
    ///             // Provided by VK_KHR_cooperative_matrix
    ///             VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR = 1000506001,
    ///             // Provided by VK_KHR_cooperative_matrix
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR = 1000506002,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CREATE_INFO_ARM = 1000507000,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_CREATE_INFO_ARM = 1000507001,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_ARM = 1000507002,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_ARM = 1000507003,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_MEMORY_REQUIREMENTS_INFO_ARM = 1000507004,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_BIND_DATA_GRAPH_PIPELINE_SESSION_MEMORY_INFO_ARM = 1000507005,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_FEATURES_ARM = 1000507006,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SHADER_MODULE_CREATE_INFO_ARM = 1000507007,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_PROPERTY_QUERY_RESULT_ARM = 1000507008,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_INFO_ARM = 1000507009,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_COMPILER_CONTROL_CREATE_INFO_ARM = 1000507010,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENTS_INFO_ARM = 1000507011,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_BIND_POINT_REQUIREMENT_ARM = 1000507012,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_IDENTIFIER_CREATE_INFO_ARM = 1000507013,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_DISPATCH_INFO_ARM = 1000507014,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PROCESSING_ENGINE_CREATE_INFO_ARM = 1000507016,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_PROPERTIES_ARM = 1000507017,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_PROPERTIES_ARM = 1000507018,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_QUEUE_FAMILY_DATA_GRAPH_PROCESSING_ENGINE_INFO_ARM = 1000507019,
    ///             // Provided by VK_ARM_data_graph with VK_ARM_tensors
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_CONSTANT_TENSOR_SEMI_STRUCTURED_SPARSITY_INFO_ARM = 1000507015,
    ///             // Provided by VK_ARM_data_graph_instruction_set_tosa
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_TOSA_PROPERTIES_ARM = 1000508000,
    ///             // Provided by VK_QCOM_multiview_per_view_render_areas
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM = 1000510000,
    ///             // Provided by VK_QCOM_multiview_per_view_render_areas
    ///             VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM = 1000510001,
    ///             // Provided by VK_KHR_compute_shader_derivatives
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR = 1000201000,
    ///             // Provided by VK_KHR_compute_shader_derivatives
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_PROPERTIES_KHR = 1000511000,
    ///             // Provided by VK_KHR_video_decode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_CAPABILITIES_KHR = 1000512000,
    ///             // Provided by VK_KHR_video_decode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR = 1000512001,
    ///             // Provided by VK_KHR_video_decode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR = 1000512003,
    ///             // Provided by VK_KHR_video_decode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000512004,
    ///             // Provided by VK_KHR_video_decode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_DPB_SLOT_INFO_KHR = 1000512005,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_CAPABILITIES_KHR = 1000513000,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000513001,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PICTURE_INFO_KHR = 1000513002,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_DPB_SLOT_INFO_KHR = 1000513003,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_AV1_FEATURES_KHR = 1000513004,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_PROFILE_INFO_KHR = 1000513005,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR = 1000513006,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR = 1000513007,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR = 1000513008,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR = 1000513009,
    ///             // Provided by VK_KHR_video_encode_av1
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_GOP_REMAINING_FRAME_INFO_KHR = 1000513010,
    ///             // Provided by VK_KHR_video_decode_vp9
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_DECODE_VP9_FEATURES_KHR = 1000514000,
    ///             // Provided by VK_KHR_video_decode_vp9
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_CAPABILITIES_KHR = 1000514001,
    ///             // Provided by VK_KHR_video_decode_vp9
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PICTURE_INFO_KHR = 1000514002,
    ///             // Provided by VK_KHR_video_decode_vp9
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_VP9_PROFILE_INFO_KHR = 1000514003,
    ///             // Provided by VK_KHR_video_maintenance1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_1_FEATURES_KHR = 1000515000,
    ///             // Provided by VK_KHR_video_maintenance1
    ///             VK_STRUCTURE_TYPE_VIDEO_INLINE_QUERY_INFO_KHR = 1000515001,
    ///             // Provided by VK_NV_per_stage_descriptor_set
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV = 1000516000,
    ///             // Provided by VK_QCOM_image_processing2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM = 1000518000,
    ///             // Provided by VK_QCOM_image_processing2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM = 1000518001,
    ///             // Provided by VK_QCOM_image_processing2
    ///             VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM = 1000518002,
    ///             // Provided by VK_QCOM_filter_cubic_weights
    ///             VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM = 1000519000,
    ///             // Provided by VK_QCOM_filter_cubic_weights
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM = 1000519001,
    ///             // Provided by VK_QCOM_filter_cubic_weights
    ///             VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM = 1000519002,
    ///             // Provided by VK_QCOM_ycbcr_degamma
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM = 1000520000,
    ///             // Provided by VK_QCOM_ycbcr_degamma
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM = 1000520001,
    ///             // Provided by VK_QCOM_filter_cubic_clamp
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM = 1000521000,
    ///             // Provided by VK_EXT_attachment_feedback_loop_dynamic_state
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT = 1000524000,
    ///             // Provided by VK_KHR_unified_image_layouts
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFIED_IMAGE_LAYOUTS_FEATURES_KHR = 1000527000,
    ///             // Provided by VK_KHR_unified_image_layouts with VK_EXT_attachment_feedback_loop_layout and (VK_VERSION_1_3 or VK_KHR_dynamic_rendering)
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_FEEDBACK_LOOP_INFO_EXT = 1000527001,
    ///             // Provided by VK_QNX_external_memory_screen_buffer
    ///             VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX = 1000529000,
    ///             // Provided by VK_QNX_external_memory_screen_buffer
    ///             VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX = 1000529001,
    ///             // Provided by VK_QNX_external_memory_screen_buffer
    ///             VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX = 1000529002,
    ///             // Provided by VK_QNX_external_memory_screen_buffer
    ///             VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX = 1000529003,
    ///             // Provided by VK_QNX_external_memory_screen_buffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX = 1000529004,
    ///             // Provided by VK_MSFT_layered_driver
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT = 1000530000,
    ///             // Provided by VK_KHR_calibrated_timestamps
    ///             VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR = 1000184000,
    ///             // Provided by VK_KHR_maintenance6 with VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_SET_DESCRIPTOR_BUFFER_OFFSETS_INFO_EXT = 1000545007,
    ///             // Provided by VK_KHR_maintenance6 with VK_EXT_descriptor_buffer
    ///             VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT = 1000545008,
    ///             // Provided by VK_NV_descriptor_pool_overallocation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV = 1000546000,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_FEATURES_QCOM = 1000547000,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_MEMORY_HEAP_PROPERTIES_QCOM = 1000547001,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_STRUCTURE_TYPE_TILE_MEMORY_REQUIREMENTS_QCOM = 1000547002,
    ///             // Provided by VK_QCOM_tile_memory_heap
    ///             VK_STRUCTURE_TYPE_TILE_MEMORY_BIND_INFO_QCOM = 1000547003,
    ///             // Provided by VK_QCOM_tile_memory_heap with VK_QCOM_tile_properties
    ///             VK_STRUCTURE_TYPE_TILE_MEMORY_SIZE_INFO_QCOM = 1000547004,
    ///             // Provided by VK_KHR_copy_memory_indirect
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_KHR = 1000549000,
    ///             // Provided by VK_KHR_copy_memory_indirect
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR = 1000426001,
    ///             // Provided by VK_KHR_copy_memory_indirect
    ///             VK_STRUCTURE_TYPE_COPY_MEMORY_INDIRECT_INFO_KHR = 1000549002,
    ///             // Provided by VK_KHR_copy_memory_indirect
    ///             VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INDIRECT_INFO_KHR = 1000549003,
    ///             // Provided by VK_EXT_memory_decompression
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT = 1000427000,
    ///             // Provided by VK_EXT_memory_decompression
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT = 1000427001,
    ///             // Provided by VK_EXT_memory_decompression
    ///             VK_STRUCTURE_TYPE_DECOMPRESS_MEMORY_INFO_EXT = 1000550002,
    ///             // Provided by VK_NV_display_stereo
    ///             VK_STRUCTURE_TYPE_DISPLAY_SURFACE_STEREO_CREATE_INFO_NV = 1000551000,
    ///             // Provided by VK_NV_display_stereo
    ///             VK_STRUCTURE_TYPE_DISPLAY_MODE_STEREO_PROPERTIES_NV = 1000551001,
    ///             // Provided by VK_KHR_video_encode_intra_refresh
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_CAPABILITIES_KHR = 1000552000,
    ///             // Provided by VK_KHR_video_encode_intra_refresh
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_INTRA_REFRESH_CREATE_INFO_KHR = 1000552001,
    ///             // Provided by VK_KHR_video_encode_intra_refresh
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_INTRA_REFRESH_INFO_KHR = 1000552002,
    ///             // Provided by VK_KHR_video_encode_intra_refresh
    ///             VK_STRUCTURE_TYPE_VIDEO_REFERENCE_INTRA_REFRESH_INFO_KHR = 1000552003,
    ///             // Provided by VK_KHR_video_encode_intra_refresh
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_INTRA_REFRESH_FEATURES_KHR = 1000552004,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553000,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_FORMAT_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553001,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_INFO_KHR = 1000553002,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUANTIZATION_MAP_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000553005,
    ///             // Provided by VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUANTIZATION_MAP_FEATURES_KHR = 1000553009,
    ///             // Provided by VK_KHR_video_encode_h264 with VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553003,
    ///             // Provided by VK_KHR_video_encode_h265 with VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553004,
    ///             // Provided by VK_KHR_video_encode_h265 with VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_FORMAT_H265_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553006,
    ///             // Provided by VK_KHR_video_encode_av1 with VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUANTIZATION_MAP_CAPABILITIES_KHR = 1000553007,
    ///             // Provided by VK_KHR_video_encode_av1 with VK_KHR_video_encode_quantization_map
    ///             VK_STRUCTURE_TYPE_VIDEO_FORMAT_AV1_QUANTIZATION_MAP_PROPERTIES_KHR = 1000553008,
    ///             // Provided by VK_NV_raw_access_chains
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAW_ACCESS_CHAINS_FEATURES_NV = 1000555000,
    ///             // Provided by VK_NV_external_compute_queue
    ///             VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DEVICE_CREATE_INFO_NV = 1000556000,
    ///             // Provided by VK_NV_external_compute_queue
    ///             VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_CREATE_INFO_NV = 1000556001,
    ///             // Provided by VK_NV_external_compute_queue
    ///             VK_STRUCTURE_TYPE_EXTERNAL_COMPUTE_QUEUE_DATA_PARAMS_NV = 1000556002,
    ///             // Provided by VK_NV_external_compute_queue
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_COMPUTE_QUEUE_PROPERTIES_NV = 1000556003,
    ///             // Provided by VK_KHR_shader_relaxed_extended_instruction
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_RELAXED_EXTENDED_INSTRUCTION_FEATURES_KHR = 1000558000,
    ///             // Provided by VK_NV_command_buffer_inheritance
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMMAND_BUFFER_INHERITANCE_FEATURES_NV = 1000559000,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_FEATURES_KHR = 1000562000,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_7_PROPERTIES_KHR = 1000562001,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_LIST_KHR = 1000562002,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_PROPERTIES_KHR = 1000562003,
    ///             // Provided by VK_KHR_maintenance7
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_API_VULKAN_PROPERTIES_KHR = 1000562004,
    ///             // Provided by VK_NV_shader_atomic_float16_vector
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT16_VECTOR_FEATURES_NV = 1000563000,
    ///             // Provided by VK_EXT_shader_replicated_composites
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_REPLICATED_COMPOSITES_FEATURES_EXT = 1000564000,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_STRUCTURE_TYPE_TENSOR_EXPLICIT_TILING_FORMAT_PROPERTIES_ARM = 1000565000,
    ///             // Provided by VK_ARM_tensor_controls
    ///             VK_STRUCTURE_TYPE_TENSOR_ROLLING_BACKING_CREATE_INFO_ARM = 1000565001,
    ///             // Provided by VK_EXT_shader_float8
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT8_FEATURES_EXT = 1000567000,
    ///             // Provided by VK_NV_ray_tracing_validation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_VALIDATION_FEATURES_NV = 1000568000,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_FEATURES_NV = 1000569000,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_ACCELERATION_STRUCTURE_PROPERTIES_NV = 1000569001,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_CLUSTERS_BOTTOM_LEVEL_INPUT_NV = 1000569002,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_TRIANGLE_CLUSTER_INPUT_NV = 1000569003,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_MOVE_OBJECTS_INPUT_NV = 1000569004,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_INPUT_INFO_NV = 1000569005,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_CLUSTER_ACCELERATION_STRUCTURE_COMMANDS_INFO_NV = 1000569006,
    ///             // Provided by VK_NV_cluster_acceleration_structure
    ///             VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CLUSTER_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000569007,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_FEATURES_NV = 1000570000,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PARTITIONED_ACCELERATION_STRUCTURE_PROPERTIES_NV = 1000570001,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_PARTITIONED_ACCELERATION_STRUCTURE_NV = 1000570002,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCES_INPUT_NV = 1000570003,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_STRUCTURE_TYPE_BUILD_PARTITIONED_ACCELERATION_STRUCTURE_INFO_NV = 1000570004,
    ///             // Provided by VK_NV_partitioned_acceleration_structure
    ///             VK_STRUCTURE_TYPE_PARTITIONED_ACCELERATION_STRUCTURE_FLAGS_NV = 1000570005,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_EXT = 1000572000,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_EXT = 1000572001,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT = 1000572002,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_CREATE_INFO_EXT = 1000572003,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT = 1000572004,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT = 1000572006,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT = 1000572007,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_PIPELINE_EXT = 1000572008,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT = 1000572009,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_PIPELINE_INFO_EXT = 1000572010,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT = 1000572011,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT = 1000572012,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GENERATED_COMMANDS_PIPELINE_INFO_EXT = 1000572013,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT = 1000572014,
    ///             // Provided by VK_KHR_device_fault
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_KHR = 1000573000,
    ///             // Provided by VK_KHR_device_fault
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_PROPERTIES_KHR = 1000573001,
    ///             // Provided by VK_KHR_device_fault
    ///             VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_KHR = 1000573002,
    ///             // Provided by VK_KHR_device_fault
    ///             VK_STRUCTURE_TYPE_DEVICE_FAULT_DEBUG_INFO_KHR = 1000573003,
    ///             // Provided by VK_KHR_maintenance8
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_8_FEATURES_KHR = 1000574000,
    ///             // Provided by VK_KHR_maintenance8
    ///             VK_STRUCTURE_TYPE_MEMORY_BARRIER_ACCESS_FLAGS_3_KHR = 1000574002,
    ///             // Provided by VK_MESA_image_alignment_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_FEATURES_MESA = 1000575000,
    ///             // Provided by VK_MESA_image_alignment_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ALIGNMENT_CONTROL_PROPERTIES_MESA = 1000575001,
    ///             // Provided by VK_MESA_image_alignment_control
    ///             VK_STRUCTURE_TYPE_IMAGE_ALIGNMENT_CONTROL_CREATE_INFO_MESA = 1000575002,
    ///             // Provided by VK_KHR_shader_fma
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FMA_FEATURES_KHR = 1000579000,
    ///             // Provided by VK_NV_push_constant_bank
    ///             VK_STRUCTURE_TYPE_PUSH_CONSTANT_BANK_INFO_NV = 1000580000,
    ///             // Provided by VK_NV_push_constant_bank
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_CONSTANT_BANK_FEATURES_NV = 1000580001,
    ///             // Provided by VK_NV_push_constant_bank
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_CONSTANT_BANK_PROPERTIES_NV = 1000580002,
    ///             // Provided by VK_EXT_ray_tracing_invocation_reorder
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_EXT = 1000581000,
    ///             // Provided by VK_EXT_ray_tracing_invocation_reorder
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_EXT = 1000581001,
    ///             // Provided by VK_EXT_depth_clamp_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_CONTROL_FEATURES_EXT = 1000582000,
    ///             // Provided by VK_EXT_depth_clamp_control
    ///             VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLAMP_CONTROL_CREATE_INFO_EXT = 1000582001,
    ///             // Provided by VK_KHR_maintenance9
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_FEATURES_KHR = 1000584000,
    ///             // Provided by VK_KHR_maintenance9
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_9_PROPERTIES_KHR = 1000584001,
    ///             // Provided by VK_KHR_maintenance9
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_OWNERSHIP_TRANSFER_PROPERTIES_KHR = 1000584002,
    ///             // Provided by VK_KHR_video_maintenance2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_MAINTENANCE_2_FEATURES_KHR = 1000586000,
    ///             // Provided by VK_KHR_video_decode_h264 with VK_KHR_video_maintenance2
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586001,
    ///             // Provided by VK_KHR_video_decode_h265 with VK_KHR_video_maintenance2
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586002,
    ///             // Provided by VK_KHR_video_decode_av1 with VK_KHR_video_maintenance2
    ///             VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_INLINE_SESSION_PARAMETERS_INFO_KHR = 1000586003,
    ///             // Provided by VK_OHOS_surface
    ///             VK_STRUCTURE_TYPE_SURFACE_CREATE_INFO_OHOS = 1000685000,
    ///             // Provided by VK_HUAWEI_hdr_vivid
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HDR_VIVID_FEATURES_HUAWEI = 1000590000,
    ///             // Provided by VK_HUAWEI_hdr_vivid
    ///             VK_STRUCTURE_TYPE_HDR_VIVID_DYNAMIC_METADATA_HUAWEI = 1000590001,
    ///             // Provided by VK_NV_cooperative_matrix2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_FEATURES_NV = 1000593000,
    ///             // Provided by VK_NV_cooperative_matrix2
    ///             VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_FLEXIBLE_DIMENSIONS_PROPERTIES_NV = 1000593001,
    ///             // Provided by VK_NV_cooperative_matrix2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_2_PROPERTIES_NV = 1000593002,
    ///             // Provided by VK_ARM_pipeline_opacity_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_OPACITY_MICROMAP_FEATURES_ARM = 1000596000,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_FEEDBACK_2_FEATURES_KHR = 1000598000,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_STRUCTURE_TYPE_VIDEO_ENCODE_FEEDBACK_2_CAPABILITIES_KHR = 1000598001,
    ///             // Provided by VK_KHR_video_encode_feedback2
    ///             VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_PER_PARTITION_FEEDBACK_CREATE_INFO_KHR = 1000598002,
    ///             // Provided by VK_EXT_external_memory_metal
    ///             VK_STRUCTURE_TYPE_IMPORT_MEMORY_METAL_HANDLE_INFO_EXT = 1000602000,
    ///             // Provided by VK_EXT_external_memory_metal
    ///             VK_STRUCTURE_TYPE_MEMORY_METAL_HANDLE_PROPERTIES_EXT = 1000602001,
    ///             // Provided by VK_EXT_external_memory_metal
    ///             VK_STRUCTURE_TYPE_MEMORY_GET_METAL_HANDLE_INFO_EXT = 1000602002,
    ///             // Provided by VK_KHR_depth_clamp_zero_one
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR = 1000421000,
    ///             // Provided by VK_ARM_performance_counters_by_region
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_FEATURES_ARM = 1000605000,
    ///             // Provided by VK_ARM_performance_counters_by_region
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_COUNTERS_BY_REGION_PROPERTIES_ARM = 1000605001,
    ///             // Provided by VK_ARM_performance_counters_by_region
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_ARM = 1000605002,
    ///             // Provided by VK_ARM_performance_counters_by_region
    ///             VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_ARM = 1000605003,
    ///             // Provided by VK_ARM_performance_counters_by_region
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_PERFORMANCE_COUNTERS_BY_REGION_BEGIN_INFO_ARM = 1000605004,
    ///             // Provided by VK_ARM_shader_instrumentation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INSTRUMENTATION_FEATURES_ARM = 1000607000,
    ///             // Provided by VK_ARM_shader_instrumentation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INSTRUMENTATION_PROPERTIES_ARM = 1000607001,
    ///             // Provided by VK_ARM_shader_instrumentation
    ///             VK_STRUCTURE_TYPE_SHADER_INSTRUMENTATION_CREATE_INFO_ARM = 1000607002,
    ///             // Provided by VK_ARM_shader_instrumentation
    ///             VK_STRUCTURE_TYPE_SHADER_INSTRUMENTATION_METRIC_DESCRIPTION_ARM = 1000607003,
    ///             // Provided by VK_EXT_vertex_attribute_robustness
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_ROBUSTNESS_FEATURES_EXT = 1000608000,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FORMAT_PACK_FEATURES_ARM = 1000609000,
    ///             // Provided by VK_VALVE_fragment_density_map_layered
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_FEATURES_VALVE = 1000611000,
    ///             // Provided by VK_VALVE_fragment_density_map_layered
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_LAYERED_PROPERTIES_VALVE = 1000611001,
    ///             // Provided by VK_VALVE_fragment_density_map_layered
    ///             VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_DENSITY_MAP_LAYERED_CREATE_INFO_VALVE = 1000611002,
    ///             // Provided by VK_KHR_robustness2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR = 1000286000,
    ///             // Provided by VK_KHR_robustness2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR = 1000286001,
    ///             // Provided by VK_NV_present_metering
    ///             VK_STRUCTURE_TYPE_SET_PRESENT_CONFIG_NV = 1000613000,
    ///             // Provided by VK_NV_present_metering
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_METERING_FEATURES_NV = 1000613001,
    ///             // Provided by VK_EXT_multisampled_render_to_swapchain
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SWAPCHAIN_FEATURES_EXT = 1000616000,
    ///             // Provided by VK_EXT_multisampled_render_to_swapchain
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_FLAGS_SURFACE_CAPABILITIES_EXT = 1000616001,
    ///             // Provided by VK_EXT_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT = 1000425000,
    ///             // Provided by VK_EXT_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT = 1000425001,
    ///             // Provided by VK_EXT_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT = 1000425002,
    ///             // Provided by VK_EXT_zero_initialize_device_memory
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_DEVICE_MEMORY_FEATURES_EXT = 1000620000,
    ///             // Provided by VK_KHR_present_mode_fifo_latest_ready
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR = 1000361000,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_KHR = 1000623000,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_KHR = 1000623001,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MICROMAP_DATA_KHR = 1000623002,
    ///             // Provided by VK_KHR_opacity_micromap
    ///             VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_KHR = 1000623003,
    ///             // Provided by VK_EXT_shader_64bit_indexing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_64_BIT_INDEXING_FEATURES_EXT = 1000627000,
    ///             // Provided by VK_EXT_custom_resolve
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_RESOLVE_FEATURES_EXT = 1000628000,
    ///             // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_BEGIN_CUSTOM_RESOLVE_INFO_EXT = 1000628001,
    ///             // Provided by VK_EXT_custom_resolve with VK_KHR_dynamic_rendering or VK_VERSION_1_3
    ///             VK_STRUCTURE_TYPE_CUSTOM_RESOLVE_CREATE_INFO_EXT = 1000628002,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_MODEL_FEATURES_QCOM = 1000629000,
    ///             // Provided by VK_QCOM_data_graph_model
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_BUILTIN_MODEL_CREATE_INFO_QCOM = 1000629001,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_FEATURES_KHR = 1000630000,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_10_PROPERTIES_KHR = 1000630001,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_FLAGS_INFO_KHR = 1000630002,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR = 1000619003,
    ///             // Provided by VK_KHR_maintenance10
    ///             VK_STRUCTURE_TYPE_RESOLVE_IMAGE_MODE_INFO_KHR = 1000630004,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_OPTICAL_FLOW_FEATURES_ARM = 1000631000,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_DATA_GRAPH_OPTICAL_FLOW_PROPERTIES_ARM = 1000631001,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_OPTICAL_FLOW_IMAGE_FORMAT_INFO_ARM = 1000631003,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_ARM = 1000631004,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_OPTICAL_FLOW_DISPATCH_INFO_ARM = 1000631005,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_OPTICAL_FLOW_CREATE_INFO_ARM = 1000631002,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_RESOURCE_INFO_IMAGE_LAYOUT_ARM = 1000631006,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SINGLE_NODE_CREATE_INFO_ARM = 1000631007,
    ///             // Provided by VK_ARM_data_graph_optical_flow
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SINGLE_NODE_CONNECTION_ARM = 1000631008,
    ///             // Provided by VK_EXT_shader_long_vector
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_LONG_VECTOR_FEATURES_EXT = 1000635000,
    ///             // Provided by VK_EXT_shader_long_vector
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_LONG_VECTOR_PROPERTIES_EXT = 1000635001,
    ///             // Provided by VK_SEC_pipeline_cache_incremental_mode
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CACHE_INCREMENTAL_MODE_FEATURES_SEC = 1000637000,
    ///             // Provided by VK_EXT_shader_uniform_buffer_unsized_array
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_UNIFORM_BUFFER_UNSIZED_ARRAY_FEATURES_EXT = 1000642000,
    ///             // Provided by VK_NV_compute_occupancy_priority
    ///             VK_STRUCTURE_TYPE_COMPUTE_OCCUPANCY_PRIORITY_PARAMETERS_NV = 1000645000,
    ///             // Provided by VK_NV_compute_occupancy_priority
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_OCCUPANCY_PRIORITY_FEATURES_NV = 1000645001,
    ///             // Provided by VK_KHR_maintenance11
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_11_FEATURES_KHR = 1000657000,
    ///             // Provided by VK_KHR_maintenance11
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_OPTIMAL_IMAGE_TRANSFER_GRANULARITY_PROPERTIES_KHR = 1000657001,
    ///             // Provided by VK_EXT_shader_subgroup_partitioned
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_PARTITIONED_FEATURES_EXT = 1000662000,
    ///             // Provided by VK_SEC_ubm_surface
    ///             VK_STRUCTURE_TYPE_UBM_SURFACE_CREATE_INFO_SEC = 1000664000,
    ///             // Provided by VK_KHR_extended_flags
    ///             VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_4_KHR = 1000668000,
    ///             // Provided by VK_KHR_extended_flags
    ///             VK_STRUCTURE_TYPE_IMAGE_CREATE_FLAGS_2_CREATE_INFO_KHR = 1000668001,
    ///             // Provided by VK_KHR_extended_flags
    ///             VK_STRUCTURE_TYPE_IMAGE_USAGE_FLAGS_2_CREATE_INFO_KHR = 1000668002,
    ///             // Provided by VK_KHR_extended_flags
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_2_CREATE_INFO_KHR = 1000668003,
    ///             // Provided by VK_KHR_extended_flags
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_FLAGS_FEATURES_KHR = 1000668004,
    ///             // Provided by VK_KHR_extended_flags with VK_VERSION_1_2 or VK_EXT_separate_stencil_usage
    ///             VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_2_CREATE_INFO_KHR = 1000668005,
    ///             // Provided by VK_KHR_extended_flags with VK_KHR_shared_presentable_image
    ///             VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_2_KHR = 1000668006,
    ///             // Provided by VK_EXT_shader_ocp_microscaling_types
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OCP_MICROSCALING_TYPES_FEATURES_EXT = 1000672000,
    ///             // Provided by VK_VALVE_shader_mixed_float_dot_product
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MIXED_FLOAT_DOT_PRODUCT_FEATURES_VALVE = 1000673000,
    ///             // Provided by VK_SEC_throttle_hint
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_THROTTLE_HINT_FEATURES_SEC = 1000674000,
    ///             // Provided by VK_SEC_throttle_hint
    ///             VK_STRUCTURE_TYPE_THROTTLE_HINT_SUBMIT_INFO_SEC = 1000674001,
    ///             // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_NEURAL_STATISTICS_CREATE_INFO_ARM = 1000676000,
    ///             // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///             VK_STRUCTURE_TYPE_DATA_GRAPH_PIPELINE_SESSION_NEURAL_STATISTICS_CREATE_INFO_ARM = 1000676001,
    ///             // Provided by VK_ARM_data_graph_neural_accelerator_statistics
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DATA_GRAPH_NEURAL_ACCELERATOR_STATISTICS_FEATURES_ARM = 1000676002,
    ///             // Provided by VK_EXT_primitive_restart_index
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_RESTART_INDEX_FEATURES_EXT = 1000678000,
    ///             // Provided by VK_NV_cooperative_matrix_decode_vector
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_DECODE_VECTOR_FEATURES_NV = 1000689000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES,
    ///             // Provided by VK_EXT_debug_report
    ///             // VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT is a legacy alias
    ///             VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_RENDERING_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_INFO,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES,
    ///             // Provided by VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR = VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO,
    ///             // Provided by VK_KHR_multiview
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO,
    ///             // Provided by VK_KHR_multiview
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES,
    ///             // Provided by VK_KHR_multiview
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2,
    ///             // Provided by VK_KHR_get_physical_device_properties2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2,
    ///             // Provided by VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO,
    ///             // Provided by VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO,
    ///             // Provided by VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO,
    ///             // Provided by VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO,
    ///             // Provided by VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO,
    ///             // Provided by VK_KHR_bind_memory2 with VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO,
    ///             // Provided by VK_KHR_bind_memory2 with VK_KHR_device_group
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES,
    ///             // Provided by VK_EXT_pipeline_robustness
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES,
    ///             // Provided by VK_KHR_device_group_creation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES,
    ///             // Provided by VK_KHR_device_group_creation
    ///             VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO,
    ///             // Provided by VK_KHR_external_memory_capabilities
    ///             VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES,
    ///             // Provided by VK_KHR_external_fence_capabilities, VK_KHR_external_memory_capabilities, VK_KHR_external_semaphore_capabilities
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES,
    ///             // Provided by VK_KHR_external_memory
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO,
    ///             // Provided by VK_KHR_external_memory
    ///             VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO,
    ///             // Provided by VK_KHR_external_memory
    ///             VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO,
    ///             // Provided by VK_KHR_external_semaphore_capabilities
    ///             VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES,
    ///             // Provided by VK_KHR_external_semaphore
    ///             VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO,
    ///             // Provided by VK_KHR_push_descriptor
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES,
    ///             // Provided by VK_KHR_shader_float16_int8
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,
    ///             // Provided by VK_KHR_shader_float16_int8
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,
    ///             // Provided by VK_KHR_16bit_storage
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES,
    ///             // Provided by VK_KHR_descriptor_update_template
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO,
    ///             // Provided by VK_EXT_display_surface_counter
    ///             // VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT is a legacy alias
    ///             VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT = VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT,
    ///             // Provided by VK_KHR_imageless_framebuffer
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES,
    ///             // Provided by VK_KHR_imageless_framebuffer
    ///             VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO,
    ///             // Provided by VK_KHR_imageless_framebuffer
    ///             VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR = VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO,
    ///             // Provided by VK_KHR_imageless_framebuffer
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR = VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR = VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO,
    ///             // Provided by VK_KHR_create_renderpass2
    ///             VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR = VK_STRUCTURE_TYPE_SUBPASS_END_INFO,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO,
    ///             // Provided by VK_KHR_external_fence_capabilities
    ///             VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES,
    ///             // Provided by VK_KHR_external_fence
    ///             VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO,
    ///             // Provided by VK_KHR_maintenance2
    ///             VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO,
    ///             // Provided by VK_KHR_variable_pointers
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,
    ///             // Provided by VK_KHR_variable_pointers
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR,
    ///             // Provided by VK_KHR_dedicated_allocation
    ///             VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS,
    ///             // Provided by VK_KHR_dedicated_allocation
    ///             VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO,
    ///             // Provided by VK_EXT_sampler_filter_minmax
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES,
    ///             // Provided by VK_EXT_sampler_filter_minmax
    ///             VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO,
    ///             // Provided by VK_EXT_inline_uniform_block
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES,
    ///             // Provided by VK_EXT_inline_uniform_block
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES,
    ///             // Provided by VK_EXT_inline_uniform_block
    ///             VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT = VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK,
    ///             // Provided by VK_EXT_inline_uniform_block
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO,
    ///             // Provided by VK_KHR_get_memory_requirements2
    ///             VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2,
    ///             // Provided by VK_KHR_get_memory_requirements2
    ///             VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2,
    ///             // Provided by VK_KHR_get_memory_requirements2
    ///             VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2,
    ///             // Provided by VK_KHR_get_memory_requirements2
    ///             VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2,
    ///             // Provided by VK_KHR_get_memory_requirements2
    ///             VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2,
    ///             // Provided by VK_KHR_image_format_list
    ///             VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO,
    ///             // Provided by VK_NV_framebuffer_mixed_samples with VK_VERSION_1_3 or VK_KHR_dynamic_rendering
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV = VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES,
    ///             // Provided by VK_KHR_bind_memory2
    ///             VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO,
    ///             // Provided by VK_KHR_bind_memory2
    ///             VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT,
    ///             // Provided by VK_KHR_maintenance3
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES,
    ///             // Provided by VK_KHR_maintenance3
    ///             VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT,
    ///             // Provided by VK_EXT_global_priority
    ///             VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO,
    ///             // Provided by VK_KHR_shader_subgroup_extended_types
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES,
    ///             // Provided by VK_KHR_8bit_storage
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES,
    ///             // Provided by VK_KHR_shader_atomic_int64
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES,
    ///             // Provided by VK_EXT_calibrated_timestamps
    ///             VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT = VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_KHR,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR = VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES,
    ///             // Provided by VK_EXT_vertex_attribute_divisor
    ///             VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO,
    ///             // Provided by VK_EXT_vertex_attribute_divisor
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES,
    ///             // Provided by VK_EXT_pipeline_creation_feedback
    ///             VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES,
    ///             // Provided by VK_KHR_shader_float_controls
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES,
    ///             // Provided by VK_KHR_depth_stencil_resolve
    ///             VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR = VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE,
    ///             // Provided by VK_NV_compute_shader_derivatives
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_KHR,
    ///             // Provided by VK_NV_fragment_shader_barycentric
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO,
    ///             // Provided by VK_KHR_timeline_semaphore
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO,
    ///             // Provided by VK_INTEL_performance_query
    ///             // VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL is a legacy alias
    ///             VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL = VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL,
    ///             // Provided by VK_KHR_vulkan_memory_model
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES,
    ///             // Provided by VK_KHR_shader_terminate_invocation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES,
    ///             // Provided by VK_EXT_scalar_block_layout
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES,
    ///             // Provided by VK_EXT_subgroup_size_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES,
    ///             // Provided by VK_EXT_subgroup_size_control
    ///             VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO,
    ///             // Provided by VK_EXT_subgroup_size_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES,
    ///             // Provided by VK_KHR_dynamic_rendering_local_read
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_LOCAL_READ_FEATURES,
    ///             // Provided by VK_KHR_dynamic_rendering_local_read
    ///             VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_LOCATION_INFO,
    ///             // Provided by VK_KHR_dynamic_rendering_local_read
    ///             VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_INPUT_ATTACHMENT_INDEX_INFO,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT,
    ///             // Provided by VK_KHR_separate_depth_stencil_layouts
    ///             VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,
    ///             // Provided by VK_EXT_tooling_info
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES,
    ///             // Provided by VK_EXT_separate_stencil_usage
    ///             VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO,
    ///             // Provided by VK_KHR_uniform_buffer_standard_layout
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO,
    ///             // Provided by VK_EXT_line_rasterization
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES,
    ///             // Provided by VK_EXT_host_query_reset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES,
    ///             // Provided by VK_EXT_index_type_uint8
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT = VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT = VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT = VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT = VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT = VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE,
    ///             // Provided by VK_EXT_host_image_copy
    ///             VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT = VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY,
    ///             // Provided by VK_KHR_map_memory2
    ///             VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_MAP_INFO,
    ///             // Provided by VK_KHR_map_memory2
    ///             VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO,
    ///             // Provided by VK_EXT_surface_maintenance1
    ///             VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT = VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_KHR,
    ///             // Provided by VK_EXT_surface_maintenance1
    ///             VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT = VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_KHR,
    ///             // Provided by VK_EXT_surface_maintenance1
    ///             VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT = VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_KHR,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_KHR,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT = VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_KHR,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_KHR,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT = VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_KHR,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_KHR,
    ///             // Provided by VK_EXT_swapchain_maintenance1
    ///             VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT = VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_KHR,
    ///             // Provided by VK_EXT_shader_demote_to_helper_invocation
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES,
    ///             // Provided by VK_KHR_shader_integer_dot_product
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES,
    ///             // Provided by VK_KHR_shader_integer_dot_product
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES,
    ///             // Provided by VK_EXT_texel_buffer_alignment
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES,
    ///             // Provided by VK_EXT_robustness2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_KHR,
    ///             // Provided by VK_EXT_robustness2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_KHR,
    ///             // Provided by VK_EXT_private_data
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES,
    ///             // Provided by VK_EXT_private_data
    ///             VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO,
    ///             // Provided by VK_EXT_private_data
    ///             VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO,
    ///             // Provided by VK_EXT_pipeline_creation_cache_control
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_MEMORY_BARRIER_2,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR = VK_STRUCTURE_TYPE_DEPENDENCY_INFO,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR = VK_STRUCTURE_TYPE_SUBMIT_INFO_2,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO,
    ///             // Provided by VK_KHR_synchronization2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES,
    ///             // Provided by VK_KHR_zero_initialize_workgroup_memory
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES,
    ///             // Provided by VK_EXT_image_robustness
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR = VK_STRUCTURE_TYPE_BUFFER_COPY_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR = VK_STRUCTURE_TYPE_IMAGE_COPY_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR = VK_STRUCTURE_TYPE_IMAGE_BLIT_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR = VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2,
    ///             // Provided by VK_KHR_copy_commands2
    ///             VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR = VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2,
    ///             // Provided by VK_EXT_image_compression_control
    ///             VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT = VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2,
    ///             // Provided by VK_EXT_image_compression_control
    ///             VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT = VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2,
    ///             // Provided by VK_ARM_rasterization_order_attachment_access
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT,
    ///             // Provided by VK_VALVE_mutable_descriptor_type
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT,
    ///             // Provided by VK_VALVE_mutable_descriptor_type
    ///             VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE = VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT,
    ///             // Provided by VK_KHR_format_feature_flags2
    ///             VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3,
    ///             // Provided by VK_EXT_present_mode_fifo_latest_ready
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_MODE_FIFO_LATEST_READY_FEATURES_KHR,
    ///             // Provided by VK_EXT_pipeline_properties
    ///             VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR,
    ///             // Provided by VK_EXT_global_priority_query
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES,
    ///             // Provided by VK_EXT_global_priority_query
    ///             VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT = VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES,
    ///             // Provided by VK_KHR_maintenance4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES,
    ///             // Provided by VK_KHR_maintenance4
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES,
    ///             // Provided by VK_KHR_maintenance4
    ///             VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS,
    ///             // Provided by VK_KHR_maintenance4
    ///             VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS,
    ///             // Provided by VK_KHR_shader_subgroup_rotate
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_ROTATE_FEATURES,
    ///             // Provided by VK_EXT_depth_clamp_zero_one
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_KHR,
    ///             // Provided by VK_QCOM_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_EXT,
    ///             // Provided by VK_QCOM_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_EXT,
    ///             // Provided by VK_QCOM_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM = VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_EXT,
    ///             // Provided by VK_NV_copy_memory_indirect
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_KHR,
    ///             // Provided by VK_NV_memory_decompression
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_EXT,
    ///             // Provided by VK_NV_memory_decompression
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_EXT,
    ///             // Provided by VK_EXT_pipeline_protected_access
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_AREA_INFO,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR = VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR = VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2,
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO,
    ///             // Provided by VK_KHR_extended_flags, VK_KHR_maintenance5
    ///             VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO,
    ///             // Provided by VK_EXT_shader_object
    ///             VK_STRUCTURE_TYPE_SHADER_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO,
    ///             // Provided by VK_KHR_vertex_attribute_divisor
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES,
    ///             // Provided by VK_KHR_vertex_attribute_divisor
    ///             VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO,
    ///             // Provided by VK_KHR_vertex_attribute_divisor
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES,
    ///             // Provided by VK_KHR_shader_float_controls2
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT_CONTROLS_2_FEATURES,
    ///             // Provided by VK_KHR_index_type_uint8
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO,
    ///             // Provided by VK_KHR_line_rasterization
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES,
    ///             // Provided by VK_KHR_shader_expect_assume
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EXPECT_ASSUME_FEATURES,
    ///             // Provided by VK_KHR_maintenance6
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_FEATURES,
    ///             // Provided by VK_KHR_maintenance6
    ///             VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_6_PROPERTIES,
    ///             // Provided by VK_KHR_maintenance6
    ///             VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS_KHR = VK_STRUCTURE_TYPE_BIND_MEMORY_STATUS,
    ///             // Provided by VK_KHR_maintenance6
    ///             VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO_KHR = VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_SETS_INFO,
    ///             // Provided by VK_KHR_maintenance6
    ///             VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR = VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO,
    ///             // Provided by VK_KHR_maintenance6 with VK_KHR_push_descriptor
    ///             VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO_KHR = VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_INFO,
    ///             // Provided by VK_KHR_maintenance6 with VK_KHR_push_descriptor
    ///             VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR = VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO,
    ///             // Provided by VK_EXT_fragment_density_map_offset
    ///             VK_STRUCTURE_TYPE_RENDERING_END_INFO_EXT = VK_STRUCTURE_TYPE_RENDERING_END_INFO_KHR,
    ///         } VkStructureType;
    ///     </code>
    /// </remarks>
    public enum VkStructureType : int
    {
        /// <summary>
        ///     <c>ApplicationInfo</c>
        /// </summary>
        ApplicationInfo = 0,

        /// <summary>
        ///     <c>InstanceCreateInfo</c>
        /// </summary>
        InstanceCreateInfo = 1,

        /// <summary>
        ///     <c>DeviceQueueCreateInfo</c>
        /// </summary>
        DeviceQueueCreateInfo = 2,

        /// <summary>
        ///     <c>DeviceCreateInfo</c>
        /// </summary>
        DeviceCreateInfo = 3,

        /// <summary>
        ///     <c>SubmitInfo</c>
        /// </summary>
        SubmitInfo = 4,

        /// <summary>
        ///     <c>MemoryAllocateInfo</c>
        /// </summary>
        MemoryAllocateInfo = 5,

        /// <summary>
        ///     <c>MappedMemoryRange</c>
        /// </summary>
        MappedMemoryRange = 6,

        /// <summary>
        ///     <c>BindSparseInfo</c>
        /// </summary>
        BindSparseInfo = 7,

        /// <summary>
        ///     <c>FenceCreateInfo</c>
        /// </summary>
        FenceCreateInfo = 8,

        /// <summary>
        ///     <c>SemaphoreCreateInfo</c>
        /// </summary>
        SemaphoreCreateInfo = 9,

        /// <summary>
        ///     <c>EventCreateInfo</c>
        /// </summary>
        EventCreateInfo = 10,

        /// <summary>
        ///     <c>QueryPoolCreateInfo</c>
        /// </summary>
        QueryPoolCreateInfo = 11,

        /// <summary>
        ///     <c>BufferCreateInfo</c>
        /// </summary>
        BufferCreateInfo = 12,

        /// <summary>
        ///     <c>BufferViewCreateInfo</c>
        /// </summary>
        BufferViewCreateInfo = 13,

        /// <summary>
        ///     <c>ImageCreateInfo</c>
        /// </summary>
        ImageCreateInfo = 14,

        /// <summary>
        ///     <c>ImageViewCreateInfo</c>
        /// </summary>
        ImageViewCreateInfo = 15,

        /// <summary>
        ///     <c>ShaderModuleCreateInfo</c>
        /// </summary>
        ShaderModuleCreateInfo = 16,

        /// <summary>
        ///     <c>PipelineCacheCreateInfo</c>
        /// </summary>
        PipelineCacheCreateInfo = 17,

        /// <summary>
        ///     <c>PipelineShaderStageCreateInfo</c>
        /// </summary>
        PipelineShaderStageCreateInfo = 18,

        /// <summary>
        ///     <c>PipelineVertexInputStateCreateInfo</c>
        /// </summary>
        PipelineVertexInputStateCreateInfo = 19,

        /// <summary>
        ///     <c>PipelineInputAssemblyStateCreateInfo</c>
        /// </summary>
        PipelineInputAssemblyStateCreateInfo = 20,

        /// <summary>
        ///     <c>PipelineTessellationStateCreateInfo</c>
        /// </summary>
        PipelineTessellationStateCreateInfo = 21,

        /// <summary>
        ///     <c>PipelineViewportStateCreateInfo</c>
        /// </summary>
        PipelineViewportStateCreateInfo = 22,

        /// <summary>
        ///     <c>PipelineRasterizationStateCreateInfo</c>
        /// </summary>
        PipelineRasterizationStateCreateInfo = 23,

        /// <summary>
        ///     <c>PipelineMultisampleStateCreateInfo</c>
        /// </summary>
        PipelineMultisampleStateCreateInfo = 24,

        /// <summary>
        ///     <c>PipelineDepthStencilStateCreateInfo</c>
        /// </summary>
        PipelineDepthStencilStateCreateInfo = 25,

        /// <summary>
        ///     <c>PipelineColorBlendStateCreateInfo</c>
        /// </summary>
        PipelineColorBlendStateCreateInfo = 26,

        /// <summary>
        ///     <c>PipelineDynamicStateCreateInfo</c>
        /// </summary>
        PipelineDynamicStateCreateInfo = 27,

        /// <summary>
        ///     <c>GraphicsPipelineCreateInfo</c>
        /// </summary>
        GraphicsPipelineCreateInfo = 28,

        /// <summary>
        ///     <c>ComputePipelineCreateInfo</c>
        /// </summary>
        ComputePipelineCreateInfo = 29,

        /// <summary>
        ///     <c>PipelineLayoutCreateInfo</c>
        /// </summary>
        PipelineLayoutCreateInfo = 30,

        /// <summary>
        ///     <c>SamplerCreateInfo</c>
        /// </summary>
        SamplerCreateInfo = 31,

        /// <summary>
        ///     <c>DescriptorSetLayoutCreateInfo</c>
        /// </summary>
        DescriptorSetLayoutCreateInfo = 32,

        /// <summary>
        ///     <c>DescriptorPoolCreateInfo</c>
        /// </summary>
        DescriptorPoolCreateInfo = 33,

        /// <summary>
        ///     <c>DescriptorSetAllocateInfo</c>
        /// </summary>
        DescriptorSetAllocateInfo = 34,

        /// <summary>
        ///     <c>WriteDescriptorSet</c>
        /// </summary>
        WriteDescriptorSet = 35,

        /// <summary>
        ///     <c>CopyDescriptorSet</c>
        /// </summary>
        CopyDescriptorSet = 36,

        /// <summary>
        ///     <c>FramebufferCreateInfo</c>
        /// </summary>
        FramebufferCreateInfo = 37,

        /// <summary>
        ///     <c>RenderPassCreateInfo</c>
        /// </summary>
        RenderPassCreateInfo = 38,

        /// <summary>
        ///     <c>CommandPoolCreateInfo</c>
        /// </summary>
        CommandPoolCreateInfo = 39,

        /// <summary>
        ///     <c>CommandBufferAllocateInfo</c>
        /// </summary>
        CommandBufferAllocateInfo = 40,

        /// <summary>
        ///     <c>CommandBufferInheritanceInfo</c>
        /// </summary>
        CommandBufferInheritanceInfo = 41,

        /// <summary>
        ///     <c>CommandBufferBeginInfo</c>
        /// </summary>
        CommandBufferBeginInfo = 42,

        /// <summary>
        ///     <c>RenderPassBeginInfo</c>
        /// </summary>
        RenderPassBeginInfo = 43,

        /// <summary>
        ///     <c>BufferMemoryBarrier</c>
        /// </summary>
        BufferMemoryBarrier = 44,

        /// <summary>
        ///     <c>ImageMemoryBarrier</c>
        /// </summary>
        ImageMemoryBarrier = 45,

        /// <summary>
        ///     <c>MemoryBarrier</c>
        /// </summary>
        MemoryBarrier = 46,

        /// <summary>
        ///     <c>LoaderInstanceCreateInfo</c>
        /// </summary>
        LoaderInstanceCreateInfo = 47,

        /// <summary>
        ///     <c>LoaderDeviceCreateInfo</c>
        /// </summary>
        LoaderDeviceCreateInfo = 48,

        /// <summary>
        ///     <c>BindBufferMemoryInfo</c>
        /// </summary>
        BindBufferMemoryInfo = 1000157000,

        /// <summary>
        ///     <c>BindImageMemoryInfo</c>
        /// </summary>
        BindImageMemoryInfo = 1000157001,

        /// <summary>
        ///     <c>MemoryDedicatedRequirements</c>
        /// </summary>
        MemoryDedicatedRequirements = 1000127000,

        /// <summary>
        ///     <c>MemoryDedicatedAllocateInfo</c>
        /// </summary>
        MemoryDedicatedAllocateInfo = 1000127001,

        /// <summary>
        ///     <c>MemoryAllocateFlagsInfo</c>
        /// </summary>
        MemoryAllocateFlagsInfo = 1000060000,

        /// <summary>
        ///     <c>DeviceGroupCommandBufferBeginInfo</c>
        /// </summary>
        DeviceGroupCommandBufferBeginInfo = 1000060004,

        /// <summary>
        ///     <c>DeviceGroupSubmitInfo</c>
        /// </summary>
        DeviceGroupSubmitInfo = 1000060005,

        /// <summary>
        ///     <c>DeviceGroupBindSparseInfo</c>
        /// </summary>
        DeviceGroupBindSparseInfo = 1000060006,

        /// <summary>
        ///     <c>BindBufferMemoryDeviceGroupInfo</c>
        /// </summary>
        BindBufferMemoryDeviceGroupInfo = 1000060013,

        /// <summary>
        ///     <c>BindImageMemoryDeviceGroupInfo</c>
        /// </summary>
        BindImageMemoryDeviceGroupInfo = 1000060014,

        /// <summary>
        ///     <c>PhysicalDeviceGroupProperties</c>
        /// </summary>
        PhysicalDeviceGroupProperties = 1000070000,

        /// <summary>
        ///     <c>DeviceGroupDeviceCreateInfo</c>
        /// </summary>
        DeviceGroupDeviceCreateInfo = 1000070001,

        /// <summary>
        ///     <c>BufferMemoryRequirementsInfo2</c>
        /// </summary>
        BufferMemoryRequirementsInfo2 = 1000146000,

        /// <summary>
        ///     <c>ImageMemoryRequirementsInfo2</c>
        /// </summary>
        ImageMemoryRequirementsInfo2 = 1000146001,

        /// <summary>
        ///     <c>ImageSparseMemoryRequirementsInfo2</c>
        /// </summary>
        ImageSparseMemoryRequirementsInfo2 = 1000146002,

        /// <summary>
        ///     <c>MemoryRequirements2</c>
        /// </summary>
        MemoryRequirements2 = 1000146003,

        /// <summary>
        ///     <c>SparseImageMemoryRequirements2</c>
        /// </summary>
        SparseImageMemoryRequirements2 = 1000146004,

        /// <summary>
        ///     <c>PhysicalDeviceFeatures2</c>
        /// </summary>
        PhysicalDeviceFeatures2 = 1000059000,

        /// <summary>
        ///     <c>PhysicalDeviceProperties2</c>
        /// </summary>
        PhysicalDeviceProperties2 = 1000059001,

        /// <summary>
        ///     <c>FormatProperties2</c>
        /// </summary>
        FormatProperties2 = 1000059002,

        /// <summary>
        ///     <c>ImageFormatProperties2</c>
        /// </summary>
        ImageFormatProperties2 = 1000059003,

        /// <summary>
        ///     <c>PhysicalDeviceImageFormatInfo2</c>
        /// </summary>
        PhysicalDeviceImageFormatInfo2 = 1000059004,

        /// <summary>
        ///     <c>QueueFamilyProperties2</c>
        /// </summary>
        QueueFamilyProperties2 = 1000059005,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryProperties2</c>
        /// </summary>
        PhysicalDeviceMemoryProperties2 = 1000059006,

        /// <summary>
        ///     <c>SparseImageFormatProperties2</c>
        /// </summary>
        SparseImageFormatProperties2 = 1000059007,

        /// <summary>
        ///     <c>PhysicalDeviceSparseImageFormatInfo2</c>
        /// </summary>
        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,

        /// <summary>
        ///     <c>ImageViewUsageCreateInfo</c>
        /// </summary>
        ImageViewUsageCreateInfo = 1000117002,

        /// <summary>
        ///     <c>ProtectedSubmitInfo</c>
        /// </summary>
        ProtectedSubmitInfo = 1000145000,

        /// <summary>
        ///     <c>PhysicalDeviceProtectedMemoryFeatures</c>
        /// </summary>
        PhysicalDeviceProtectedMemoryFeatures = 1000145001,

        /// <summary>
        ///     <c>PhysicalDeviceProtectedMemoryProperties</c>
        /// </summary>
        PhysicalDeviceProtectedMemoryProperties = 1000145002,

        /// <summary>
        ///     <c>DeviceQueueInfo2</c>
        /// </summary>
        DeviceQueueInfo2 = 1000145003,

        /// <summary>
        ///     <c>PhysicalDeviceExternalImageFormatInfo</c>
        /// </summary>
        PhysicalDeviceExternalImageFormatInfo = 1000071000,

        /// <summary>
        ///     <c>ExternalImageFormatProperties</c>
        /// </summary>
        ExternalImageFormatProperties = 1000071001,

        /// <summary>
        ///     <c>PhysicalDeviceExternalBufferInfo</c>
        /// </summary>
        PhysicalDeviceExternalBufferInfo = 1000071002,

        /// <summary>
        ///     <c>ExternalBufferProperties</c>
        /// </summary>
        ExternalBufferProperties = 1000071003,

        /// <summary>
        ///     <c>PhysicalDeviceIdProperties</c>
        /// </summary>
        PhysicalDeviceIdProperties = 1000071004,

        /// <summary>
        ///     <c>ExternalMemoryBufferCreateInfo</c>
        /// </summary>
        ExternalMemoryBufferCreateInfo = 1000072000,

        /// <summary>
        ///     <c>ExternalMemoryImageCreateInfo</c>
        /// </summary>
        ExternalMemoryImageCreateInfo = 1000072001,

        /// <summary>
        ///     <c>ExportMemoryAllocateInfo</c>
        /// </summary>
        ExportMemoryAllocateInfo = 1000072002,

        /// <summary>
        ///     <c>PhysicalDeviceExternalFenceInfo</c>
        /// </summary>
        PhysicalDeviceExternalFenceInfo = 1000112000,

        /// <summary>
        ///     <c>ExternalFenceProperties</c>
        /// </summary>
        ExternalFenceProperties = 1000112001,

        /// <summary>
        ///     <c>ExportFenceCreateInfo</c>
        /// </summary>
        ExportFenceCreateInfo = 1000113000,

        /// <summary>
        ///     <c>ExportSemaphoreCreateInfo</c>
        /// </summary>
        ExportSemaphoreCreateInfo = 1000077000,

        /// <summary>
        ///     <c>PhysicalDeviceExternalSemaphoreInfo</c>
        /// </summary>
        PhysicalDeviceExternalSemaphoreInfo = 1000076000,

        /// <summary>
        ///     <c>ExternalSemaphoreProperties</c>
        /// </summary>
        ExternalSemaphoreProperties = 1000076001,

        /// <summary>
        ///     <c>PhysicalDeviceSubgroupProperties</c>
        /// </summary>
        PhysicalDeviceSubgroupProperties = 1000094000,

        /// <summary>
        ///     <c>PhysicalDevice16BitStorageFeatures</c>
        /// </summary>
        PhysicalDevice16BitStorageFeatures = 1000083000,

        /// <summary>
        ///     <c>PhysicalDeviceVariablePointersFeatures</c>
        /// </summary>
        PhysicalDeviceVariablePointersFeatures = 1000120000,

        /// <summary>
        ///     <c>DescriptorUpdateTemplateCreateInfo</c>
        /// </summary>
        DescriptorUpdateTemplateCreateInfo = 1000085000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance3Properties</c>
        /// </summary>
        PhysicalDeviceMaintenance3Properties = 1000168000,

        /// <summary>
        ///     <c>DescriptorSetLayoutSupport</c>
        /// </summary>
        DescriptorSetLayoutSupport = 1000168001,

        /// <summary>
        ///     <c>SamplerYCbCrConversionCreateInfo</c>
        /// </summary>
        SamplerYCbCrConversionCreateInfo = 1000156000,

        /// <summary>
        ///     <c>SamplerYCbCrConversionInfo</c>
        /// </summary>
        SamplerYCbCrConversionInfo = 1000156001,

        /// <summary>
        ///     <c>BindImagePlaneMemoryInfo</c>
        /// </summary>
        BindImagePlaneMemoryInfo = 1000156002,

        /// <summary>
        ///     <c>ImagePlaneMemoryRequirementsInfo</c>
        /// </summary>
        ImagePlaneMemoryRequirementsInfo = 1000156003,

        /// <summary>
        ///     <c>PhysicalDeviceSamplerYCbCrConversionFeatures</c>
        /// </summary>
        PhysicalDeviceSamplerYCbCrConversionFeatures = 1000156004,

        /// <summary>
        ///     <c>SamplerYCbCrConversionImageFormatProperties</c>
        /// </summary>
        SamplerYCbCrConversionImageFormatProperties = 1000156005,

        /// <summary>
        ///     <c>DeviceGroupRenderPassBeginInfo</c>
        /// </summary>
        DeviceGroupRenderPassBeginInfo = 1000060003,

        /// <summary>
        ///     <c>PhysicalDevicePointClippingProperties</c>
        /// </summary>
        PhysicalDevicePointClippingProperties = 1000117000,

        /// <summary>
        ///     <c>RenderPassInputAttachmentAspectCreateInfo</c>
        /// </summary>
        RenderPassInputAttachmentAspectCreateInfo = 1000117001,

        /// <summary>
        ///     <c>PipelineTessellationDomainOriginStateCreateInfo</c>
        /// </summary>
        PipelineTessellationDomainOriginStateCreateInfo = 1000117003,

        /// <summary>
        ///     <c>RenderPassMultiviewCreateInfo</c>
        /// </summary>
        RenderPassMultiviewCreateInfo = 1000053000,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewFeatures</c>
        /// </summary>
        PhysicalDeviceMultiviewFeatures = 1000053001,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewProperties</c>
        /// </summary>
        PhysicalDeviceMultiviewProperties = 1000053002,

        /// <summary>
        ///     <c>PhysicalDeviceShaderDrawParametersFeatures</c>
        /// </summary>
        PhysicalDeviceShaderDrawParametersFeatures = 1000063000,

        /// <summary>
        ///     <c>PhysicalDeviceDriverProperties</c>
        /// </summary>
        PhysicalDeviceDriverProperties = 1000196000,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan11Features</c>
        /// </summary>
        PhysicalDeviceVulkan11Features = 49,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan11Properties</c>
        /// </summary>
        PhysicalDeviceVulkan11Properties = 50,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan12Features</c>
        /// </summary>
        PhysicalDeviceVulkan12Features = 51,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan12Properties</c>
        /// </summary>
        PhysicalDeviceVulkan12Properties = 52,

        /// <summary>
        ///     <c>ImageFormatListCreateInfo</c>
        /// </summary>
        ImageFormatListCreateInfo = 1000147000,

        /// <summary>
        ///     <c>PhysicalDeviceVulkanMemoryModelFeatures</c>
        /// </summary>
        PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,

        /// <summary>
        ///     <c>PhysicalDeviceHostQueryResetFeatures</c>
        /// </summary>
        PhysicalDeviceHostQueryResetFeatures = 1000261000,

        /// <summary>
        ///     <c>PhysicalDeviceTimelineSemaphoreFeatures</c>
        /// </summary>
        PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,

        /// <summary>
        ///     <c>PhysicalDeviceTimelineSemaphoreProperties</c>
        /// </summary>
        PhysicalDeviceTimelineSemaphoreProperties = 1000207001,

        /// <summary>
        ///     <c>SemaphoreTypeCreateInfo</c>
        /// </summary>
        SemaphoreTypeCreateInfo = 1000207002,

        /// <summary>
        ///     <c>TimelineSemaphoreSubmitInfo</c>
        /// </summary>
        TimelineSemaphoreSubmitInfo = 1000207003,

        /// <summary>
        ///     <c>SemaphoreWaitInfo</c>
        /// </summary>
        SemaphoreWaitInfo = 1000207004,

        /// <summary>
        ///     <c>SemaphoreSignalInfo</c>
        /// </summary>
        SemaphoreSignalInfo = 1000207005,

        /// <summary>
        ///     <c>PhysicalDeviceBufferDeviceAddressFeatures</c>
        /// </summary>
        PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,

        /// <summary>
        ///     <c>BufferDeviceAddressInfo</c>
        /// </summary>
        BufferDeviceAddressInfo = 1000244001,

        /// <summary>
        ///     <c>BufferOpaqueCaptureAddressCreateInfo</c>
        /// </summary>
        BufferOpaqueCaptureAddressCreateInfo = 1000257002,

        /// <summary>
        ///     <c>MemoryOpaqueCaptureAddressAllocateInfo</c>
        /// </summary>
        MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,

        /// <summary>
        ///     <c>DeviceMemoryOpaqueCaptureAddressInfo</c>
        /// </summary>
        DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,

        /// <summary>
        ///     <c>PhysicalDevice8BitStorageFeatures</c>
        /// </summary>
        PhysicalDevice8BitStorageFeatures = 1000177000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAtomicInt64Features</c>
        /// </summary>
        PhysicalDeviceShaderAtomicInt64Features = 1000180000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderFloat16Int8Features</c>
        /// </summary>
        PhysicalDeviceShaderFloat16Int8Features = 1000082000,

        /// <summary>
        ///     <c>PhysicalDeviceFloatControlsProperties</c>
        /// </summary>
        PhysicalDeviceFloatControlsProperties = 1000197000,

        /// <summary>
        ///     <c>DescriptorSetLayoutBindingFlagsCreateInfo</c>
        /// </summary>
        DescriptorSetLayoutBindingFlagsCreateInfo = 1000161000,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorIndexingFeatures</c>
        /// </summary>
        PhysicalDeviceDescriptorIndexingFeatures = 1000161001,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorIndexingProperties</c>
        /// </summary>
        PhysicalDeviceDescriptorIndexingProperties = 1000161002,

        /// <summary>
        ///     <c>DescriptorSetVariableDescriptorCountAllocateInfo</c>
        /// </summary>
        DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,

        /// <summary>
        ///     <c>DescriptorSetVariableDescriptorCountLayoutSupport</c>
        /// </summary>
        DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,

        /// <summary>
        ///     <c>PhysicalDeviceScalarBlockLayoutFeatures</c>
        /// </summary>
        PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,

        /// <summary>
        ///     <c>PhysicalDeviceSamplerFilterMinmaxProperties</c>
        /// </summary>
        PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,

        /// <summary>
        ///     <c>SamplerReductionModeCreateInfo</c>
        /// </summary>
        SamplerReductionModeCreateInfo = 1000130001,

        /// <summary>
        ///     <c>PhysicalDeviceUniformBufferStandardLayoutFeatures</c>
        /// </summary>
        PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSubgroupExtendedTypesFeatures</c>
        /// </summary>
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,

        /// <summary>
        ///     <c>AttachmentDescription2</c>
        /// </summary>
        AttachmentDescription2 = 1000109000,

        /// <summary>
        ///     <c>AttachmentReference2</c>
        /// </summary>
        AttachmentReference2 = 1000109001,

        /// <summary>
        ///     <c>SubpassDescription2</c>
        /// </summary>
        SubpassDescription2 = 1000109002,

        /// <summary>
        ///     <c>SubpassDependency2</c>
        /// </summary>
        SubpassDependency2 = 1000109003,

        /// <summary>
        ///     <c>RenderPassCreateInfo2</c>
        /// </summary>
        RenderPassCreateInfo2 = 1000109004,

        /// <summary>
        ///     <c>SubpassBeginInfo</c>
        /// </summary>
        SubpassBeginInfo = 1000109005,

        /// <summary>
        ///     <c>SubpassEndInfo</c>
        /// </summary>
        SubpassEndInfo = 1000109006,

        /// <summary>
        ///     <c>PhysicalDeviceDepthStencilResolveProperties</c>
        /// </summary>
        PhysicalDeviceDepthStencilResolveProperties = 1000199000,

        /// <summary>
        ///     <c>SubpassDescriptionDepthStencilResolve</c>
        /// </summary>
        SubpassDescriptionDepthStencilResolve = 1000199001,

        /// <summary>
        ///     <c>ImageStencilUsageCreateInfo</c>
        /// </summary>
        ImageStencilUsageCreateInfo = 1000246000,

        /// <summary>
        ///     <c>PhysicalDeviceImagelessFramebufferFeatures</c>
        /// </summary>
        PhysicalDeviceImagelessFramebufferFeatures = 1000108000,

        /// <summary>
        ///     <c>FramebufferAttachmentsCreateInfo</c>
        /// </summary>
        FramebufferAttachmentsCreateInfo = 1000108001,

        /// <summary>
        ///     <c>FramebufferAttachmentImageInfo</c>
        /// </summary>
        FramebufferAttachmentImageInfo = 1000108002,

        /// <summary>
        ///     <c>RenderPassAttachmentBeginInfo</c>
        /// </summary>
        RenderPassAttachmentBeginInfo = 1000108003,

        /// <summary>
        ///     <c>PhysicalDeviceSeparateDepthStencilLayoutsFeatures</c>
        /// </summary>
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,

        /// <summary>
        ///     <c>AttachmentReferenceStencilLayout</c>
        /// </summary>
        AttachmentReferenceStencilLayout = 1000241001,

        /// <summary>
        ///     <c>AttachmentDescriptionStencilLayout</c>
        /// </summary>
        AttachmentDescriptionStencilLayout = 1000241002,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan13Features</c>
        /// </summary>
        PhysicalDeviceVulkan13Features = 53,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan13Properties</c>
        /// </summary>
        PhysicalDeviceVulkan13Properties = 54,

        /// <summary>
        ///     <c>PhysicalDeviceToolProperties</c>
        /// </summary>
        PhysicalDeviceToolProperties = 1000245000,

        /// <summary>
        ///     <c>PhysicalDevicePrivateDataFeatures</c>
        /// </summary>
        PhysicalDevicePrivateDataFeatures = 1000295000,

        /// <summary>
        ///     <c>DevicePrivateDataCreateInfo</c>
        /// </summary>
        DevicePrivateDataCreateInfo = 1000295001,

        /// <summary>
        ///     <c>PrivateDataSlotCreateInfo</c>
        /// </summary>
        PrivateDataSlotCreateInfo = 1000295002,

        /// <summary>
        ///     <c>MemoryBarrier2</c>
        /// </summary>
        MemoryBarrier2 = 1000314000,

        /// <summary>
        ///     <c>BufferMemoryBarrier2</c>
        /// </summary>
        BufferMemoryBarrier2 = 1000314001,

        /// <summary>
        ///     <c>ImageMemoryBarrier2</c>
        /// </summary>
        ImageMemoryBarrier2 = 1000314002,

        /// <summary>
        ///     <c>DependencyInfo</c>
        /// </summary>
        DependencyInfo = 1000314003,

        /// <summary>
        ///     <c>SubmitInfo2</c>
        /// </summary>
        SubmitInfo2 = 1000314004,

        /// <summary>
        ///     <c>SemaphoreSubmitInfo</c>
        /// </summary>
        SemaphoreSubmitInfo = 1000314005,

        /// <summary>
        ///     <c>CommandBufferSubmitInfo</c>
        /// </summary>
        CommandBufferSubmitInfo = 1000314006,

        /// <summary>
        ///     <c>PhysicalDeviceSynchronization2Features</c>
        /// </summary>
        PhysicalDeviceSynchronization2Features = 1000314007,

        /// <summary>
        ///     <c>CopyBufferInfo2</c>
        /// </summary>
        CopyBufferInfo2 = 1000337000,

        /// <summary>
        ///     <c>CopyImageInfo2</c>
        /// </summary>
        CopyImageInfo2 = 1000337001,

        /// <summary>
        ///     <c>CopyBufferToImageInfo2</c>
        /// </summary>
        CopyBufferToImageInfo2 = 1000337002,

        /// <summary>
        ///     <c>CopyImageToBufferInfo2</c>
        /// </summary>
        CopyImageToBufferInfo2 = 1000337003,

        /// <summary>
        ///     <c>BufferCopy2</c>
        /// </summary>
        BufferCopy2 = 1000337006,

        /// <summary>
        ///     <c>ImageCopy2</c>
        /// </summary>
        ImageCopy2 = 1000337007,

        /// <summary>
        ///     <c>BufferImageCopy2</c>
        /// </summary>
        BufferImageCopy2 = 1000337009,

        /// <summary>
        ///     <c>PhysicalDeviceTextureCompressionAstcHdrFeatures</c>
        /// </summary>
        PhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,

        /// <summary>
        ///     <c>FormatProperties3</c>
        /// </summary>
        FormatProperties3 = 1000360000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance4Features</c>
        /// </summary>
        PhysicalDeviceMaintenance4Features = 1000413000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance4Properties</c>
        /// </summary>
        PhysicalDeviceMaintenance4Properties = 1000413001,

        /// <summary>
        ///     <c>DeviceBufferMemoryRequirements</c>
        /// </summary>
        DeviceBufferMemoryRequirements = 1000413002,

        /// <summary>
        ///     <c>DeviceImageMemoryRequirements</c>
        /// </summary>
        DeviceImageMemoryRequirements = 1000413003,

        /// <summary>
        ///     <c>PipelineCreationFeedbackCreateInfo</c>
        /// </summary>
        PipelineCreationFeedbackCreateInfo = 1000192000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderTerminateInvocationFeatures</c>
        /// </summary>
        PhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderDemoteToHelperInvocationFeatures</c>
        /// </summary>
        PhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,

        /// <summary>
        ///     <c>PhysicalDevicePipelineCreationCacheControlFeatures</c>
        /// </summary>
        PhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,

        /// <summary>
        ///     <c>PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures</c>
        /// </summary>
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,

        /// <summary>
        ///     <c>PhysicalDeviceImageRobustnessFeatures</c>
        /// </summary>
        PhysicalDeviceImageRobustnessFeatures = 1000335000,

        /// <summary>
        ///     <c>PhysicalDeviceSubgroupSizeControlProperties</c>
        /// </summary>
        PhysicalDeviceSubgroupSizeControlProperties = 1000225000,

        /// <summary>
        ///     <c>PipelineShaderStageRequiredSubgroupSizeCreateInfo</c>
        /// </summary>
        PipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,

        /// <summary>
        ///     <c>PhysicalDeviceSubgroupSizeControlFeatures</c>
        /// </summary>
        PhysicalDeviceSubgroupSizeControlFeatures = 1000225002,

        /// <summary>
        ///     <c>PhysicalDeviceInlineUniformBlockFeatures</c>
        /// </summary>
        PhysicalDeviceInlineUniformBlockFeatures = 1000138000,

        /// <summary>
        ///     <c>PhysicalDeviceInlineUniformBlockProperties</c>
        /// </summary>
        PhysicalDeviceInlineUniformBlockProperties = 1000138001,

        /// <summary>
        ///     <c>WriteDescriptorSetInlineUniformBlock</c>
        /// </summary>
        WriteDescriptorSetInlineUniformBlock = 1000138002,

        /// <summary>
        ///     <c>DescriptorPoolInlineUniformBlockCreateInfo</c>
        /// </summary>
        DescriptorPoolInlineUniformBlockCreateInfo = 1000138003,

        /// <summary>
        ///     <c>PhysicalDeviceShaderIntegerDotProductFeatures</c>
        /// </summary>
        PhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderIntegerDotProductProperties</c>
        /// </summary>
        PhysicalDeviceShaderIntegerDotProductProperties = 1000280001,

        /// <summary>
        ///     <c>PhysicalDeviceTexelBufferAlignmentProperties</c>
        /// </summary>
        PhysicalDeviceTexelBufferAlignmentProperties = 1000281001,

        /// <summary>
        ///     <c>BlitImageInfo2</c>
        /// </summary>
        BlitImageInfo2 = 1000337004,

        /// <summary>
        ///     <c>ResolveImageInfo2</c>
        /// </summary>
        ResolveImageInfo2 = 1000337005,

        /// <summary>
        ///     <c>ImageBlit2</c>
        /// </summary>
        ImageBlit2 = 1000337008,

        /// <summary>
        ///     <c>ImageResolve2</c>
        /// </summary>
        ImageResolve2 = 1000337010,

        /// <summary>
        ///     <c>RenderingInfo</c>
        /// </summary>
        RenderingInfo = 1000044000,

        /// <summary>
        ///     <c>RenderingAttachmentInfo</c>
        /// </summary>
        RenderingAttachmentInfo = 1000044001,

        /// <summary>
        ///     <c>PipelineRenderingCreateInfo</c>
        /// </summary>
        PipelineRenderingCreateInfo = 1000044002,

        /// <summary>
        ///     <c>PhysicalDeviceDynamicRenderingFeatures</c>
        /// </summary>
        PhysicalDeviceDynamicRenderingFeatures = 1000044003,

        /// <summary>
        ///     <c>CommandBufferInheritanceRenderingInfo</c>
        /// </summary>
        CommandBufferInheritanceRenderingInfo = 1000044004,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan14Features</c>
        /// </summary>
        PhysicalDeviceVulkan14Features = 55,

        /// <summary>
        ///     <c>PhysicalDeviceVulkan14Properties</c>
        /// </summary>
        PhysicalDeviceVulkan14Properties = 56,

        /// <summary>
        ///     <c>DeviceQueueGlobalPriorityCreateInfo</c>
        /// </summary>
        DeviceQueueGlobalPriorityCreateInfo = 1000174000,

        /// <summary>
        ///     <c>PhysicalDeviceGlobalPriorityQueryFeatures</c>
        /// </summary>
        PhysicalDeviceGlobalPriorityQueryFeatures = 1000388000,

        /// <summary>
        ///     <c>QueueFamilyGlobalPriorityProperties</c>
        /// </summary>
        QueueFamilyGlobalPriorityProperties = 1000388001,

        /// <summary>
        ///     <c>PhysicalDeviceIndexTypeUInt8Features</c>
        /// </summary>
        PhysicalDeviceIndexTypeUInt8Features = 1000265000,

        /// <summary>
        ///     <c>MemoryMapInfo</c>
        /// </summary>
        MemoryMapInfo = 1000271000,

        /// <summary>
        ///     <c>MemoryUnmapInfo</c>
        /// </summary>
        MemoryUnmapInfo = 1000271001,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance5Features</c>
        /// </summary>
        PhysicalDeviceMaintenance5Features = 1000470000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance5Properties</c>
        /// </summary>
        PhysicalDeviceMaintenance5Properties = 1000470001,

        /// <summary>
        ///     <c>DeviceImageSubresourceInfo</c>
        /// </summary>
        DeviceImageSubresourceInfo = 1000470004,

        /// <summary>
        ///     <c>SubresourceLayout2</c>
        /// </summary>
        SubresourceLayout2 = 1000338002,

        /// <summary>
        ///     <c>ImageSubresource2</c>
        /// </summary>
        ImageSubresource2 = 1000338003,

        /// <summary>
        ///     <c>BufferUsageFlags2CreateInfo</c>
        /// </summary>
        BufferUsageFlags2CreateInfo = 1000470006,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance6Features</c>
        /// </summary>
        PhysicalDeviceMaintenance6Features = 1000545000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance6Properties</c>
        /// </summary>
        PhysicalDeviceMaintenance6Properties = 1000545001,

        /// <summary>
        ///     <c>BindMemoryStatus</c>
        /// </summary>
        BindMemoryStatus = 1000545002,

        /// <summary>
        ///     <c>PhysicalDeviceHostImageCopyFeatures</c>
        /// </summary>
        PhysicalDeviceHostImageCopyFeatures = 1000270000,

        /// <summary>
        ///     <c>PhysicalDeviceHostImageCopyProperties</c>
        /// </summary>
        PhysicalDeviceHostImageCopyProperties = 1000270001,

        /// <summary>
        ///     <c>MemoryToImageCopy</c>
        /// </summary>
        MemoryToImageCopy = 1000270002,

        /// <summary>
        ///     <c>ImageToMemoryCopy</c>
        /// </summary>
        ImageToMemoryCopy = 1000270003,

        /// <summary>
        ///     <c>CopyImageToMemoryInfo</c>
        /// </summary>
        CopyImageToMemoryInfo = 1000270004,

        /// <summary>
        ///     <c>CopyMemoryToImageInfo</c>
        /// </summary>
        CopyMemoryToImageInfo = 1000270005,

        /// <summary>
        ///     <c>HostImageLayoutTransitionInfo</c>
        /// </summary>
        HostImageLayoutTransitionInfo = 1000270006,

        /// <summary>
        ///     <c>CopyImageToImageInfo</c>
        /// </summary>
        CopyImageToImageInfo = 1000270007,

        /// <summary>
        ///     <c>SubresourceHostMemcpySize</c>
        /// </summary>
        SubresourceHostMemcpySize = 1000270008,

        /// <summary>
        ///     <c>HostImageCopyDevicePerformanceQuery</c>
        /// </summary>
        HostImageCopyDevicePerformanceQuery = 1000270009,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSubgroupRotateFeatures</c>
        /// </summary>
        PhysicalDeviceShaderSubgroupRotateFeatures = 1000416000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderFloatControls2Features</c>
        /// </summary>
        PhysicalDeviceShaderFloatControls2Features = 1000528000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderExpectAssumeFeatures</c>
        /// </summary>
        PhysicalDeviceShaderExpectAssumeFeatures = 1000544000,

        /// <summary>
        ///     <c>PipelineCreateFlags2CreateInfo</c>
        /// </summary>
        PipelineCreateFlags2CreateInfo = 1000470005,

        /// <summary>
        ///     <c>PhysicalDevicePushDescriptorProperties</c>
        /// </summary>
        PhysicalDevicePushDescriptorProperties = 1000080000,

        /// <summary>
        ///     <c>BindDescriptorSetsInfo</c>
        /// </summary>
        BindDescriptorSetsInfo = 1000545003,

        /// <summary>
        ///     <c>PushConstantsInfo</c>
        /// </summary>
        PushConstantsInfo = 1000545004,

        /// <summary>
        ///     <c>PushDescriptorSetInfo</c>
        /// </summary>
        PushDescriptorSetInfo = 1000545005,

        /// <summary>
        ///     <c>PushDescriptorSetWithTemplateInfo</c>
        /// </summary>
        PushDescriptorSetWithTemplateInfo = 1000545006,

        /// <summary>
        ///     <c>PhysicalDevicePipelineProtectedAccessFeatures</c>
        /// </summary>
        PhysicalDevicePipelineProtectedAccessFeatures = 1000466000,

        /// <summary>
        ///     <c>PipelineRobustnessCreateInfo</c>
        /// </summary>
        PipelineRobustnessCreateInfo = 1000068000,

        /// <summary>
        ///     <c>PhysicalDevicePipelineRobustnessFeatures</c>
        /// </summary>
        PhysicalDevicePipelineRobustnessFeatures = 1000068001,

        /// <summary>
        ///     <c>PhysicalDevicePipelineRobustnessProperties</c>
        /// </summary>
        PhysicalDevicePipelineRobustnessProperties = 1000068002,

        /// <summary>
        ///     <c>PhysicalDeviceLineRasterizationFeatures</c>
        /// </summary>
        PhysicalDeviceLineRasterizationFeatures = 1000259000,

        /// <summary>
        ///     <c>PipelineRasterizationLineStateCreateInfo</c>
        /// </summary>
        PipelineRasterizationLineStateCreateInfo = 1000259001,

        /// <summary>
        ///     <c>PhysicalDeviceLineRasterizationProperties</c>
        /// </summary>
        PhysicalDeviceLineRasterizationProperties = 1000259002,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeDivisorProperties</c>
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorProperties = 1000525000,

        /// <summary>
        ///     <c>PipelineVertexInputDivisorStateCreateInfo</c>
        /// </summary>
        PipelineVertexInputDivisorStateCreateInfo = 1000190001,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeDivisorFeatures</c>
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorFeatures = 1000190002,

        /// <summary>
        ///     <c>RenderingAreaInfo</c>
        /// </summary>
        RenderingAreaInfo = 1000470003,

        /// <summary>
        ///     <c>PhysicalDeviceDynamicRenderingLocalReadFeatures</c>
        /// </summary>
        PhysicalDeviceDynamicRenderingLocalReadFeatures = 1000232000,

        /// <summary>
        ///     <c>RenderingAttachmentLocationInfo</c>
        /// </summary>
        RenderingAttachmentLocationInfo = 1000232001,

        /// <summary>
        ///     <c>RenderingInputAttachmentIndexInfo</c>
        /// </summary>
        RenderingInputAttachmentIndexInfo = 1000232002,

        /// <summary>
        ///     <c>SwapchainCreateInfoKHR</c>
        /// </summary>
        SwapchainCreateInfoKHR = 1000001000,

        /// <summary>
        ///     <c>PresentInfoKHR</c>
        /// </summary>
        PresentInfoKHR = 1000001001,

        /// <summary>
        ///     <c>DeviceGroupPresentCapabilitiesKHR</c>
        /// </summary>
        DeviceGroupPresentCapabilitiesKHR = 1000060007,

        /// <summary>
        ///     <c>ImageSwapchainCreateInfoKHR</c>
        /// </summary>
        ImageSwapchainCreateInfoKHR = 1000060008,

        /// <summary>
        ///     <c>BindImageMemorySwapchainInfoKHR</c>
        /// </summary>
        BindImageMemorySwapchainInfoKHR = 1000060009,

        /// <summary>
        ///     <c>AcquireNextImageInfoKHR</c>
        /// </summary>
        AcquireNextImageInfoKHR = 1000060010,

        /// <summary>
        ///     <c>DeviceGroupPresentInfoKHR</c>
        /// </summary>
        DeviceGroupPresentInfoKHR = 1000060011,

        /// <summary>
        ///     <c>DeviceGroupSwapchainCreateInfoKHR</c>
        /// </summary>
        DeviceGroupSwapchainCreateInfoKHR = 1000060012,

        /// <summary>
        ///     <c>DisplayModeCreateInfoKHR</c>
        /// </summary>
        DisplayModeCreateInfoKHR = 1000002000,

        /// <summary>
        ///     <c>DisplaySurfaceCreateInfoKHR</c>
        /// </summary>
        DisplaySurfaceCreateInfoKHR = 1000002001,

        /// <summary>
        ///     <c>DisplayPresentInfoKHR</c>
        /// </summary>
        DisplayPresentInfoKHR = 1000003000,

        /// <summary>
        ///     <c>XlibSurfaceCreateInfoKHR</c>
        /// </summary>
        XlibSurfaceCreateInfoKHR = 1000004000,

        /// <summary>
        ///     <c>XcbSurfaceCreateInfoKHR</c>
        /// </summary>
        XcbSurfaceCreateInfoKHR = 1000005000,

        /// <summary>
        ///     <c>WaylandSurfaceCreateInfoKHR</c>
        /// </summary>
        WaylandSurfaceCreateInfoKHR = 1000006000,

        /// <summary>
        ///     <c>ANDROIDSurfaceCreateInfoKHR</c>
        /// </summary>
        ANDROIDSurfaceCreateInfoKHR = 1000008000,

        /// <summary>
        ///     <c>Win32SurfaceCreateInfoKHR</c>
        /// </summary>
        Win32SurfaceCreateInfoKHR = 1000009000,

        /// <summary>
        ///     <c>DebugReportCallbackCreateInfoEXT</c>
        /// </summary>
        DebugReportCallbackCreateInfoEXT = 1000011000,

        /// <summary>
        ///     <c>PipelineRasterizationStateRasterizationOrderAMD</c>
        /// </summary>
        PipelineRasterizationStateRasterizationOrderAMD = 1000018000,

        /// <summary>
        ///     <c>DebugMarkerObjectNameInfoEXT</c>
        /// </summary>
        DebugMarkerObjectNameInfoEXT = 1000022000,

        /// <summary>
        ///     <c>DebugMarkerObjectTagInfoEXT</c>
        /// </summary>
        DebugMarkerObjectTagInfoEXT = 1000022001,

        /// <summary>
        ///     <c>DebugMarkerMarkerInfoEXT</c>
        /// </summary>
        DebugMarkerMarkerInfoEXT = 1000022002,

        /// <summary>
        ///     <c>VideoProfileInfoKHR</c>
        /// </summary>
        VideoProfileInfoKHR = 1000023000,

        /// <summary>
        ///     <c>VideoCapabilitiesKHR</c>
        /// </summary>
        VideoCapabilitiesKHR = 1000023001,

        /// <summary>
        ///     <c>VideoPictureResourceInfoKHR</c>
        /// </summary>
        VideoPictureResourceInfoKHR = 1000023002,

        /// <summary>
        ///     <c>VideoSessionMemoryRequirementsKHR</c>
        /// </summary>
        VideoSessionMemoryRequirementsKHR = 1000023003,

        /// <summary>
        ///     <c>BindVideoSessionMemoryInfoKHR</c>
        /// </summary>
        BindVideoSessionMemoryInfoKHR = 1000023004,

        /// <summary>
        ///     <c>VideoSessionCreateInfoKHR</c>
        /// </summary>
        VideoSessionCreateInfoKHR = 1000023005,

        /// <summary>
        ///     <c>VideoSessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoSessionParametersCreateInfoKHR = 1000023006,

        /// <summary>
        ///     <c>VideoSessionParametersUpdateInfoKHR</c>
        /// </summary>
        VideoSessionParametersUpdateInfoKHR = 1000023007,

        /// <summary>
        ///     <c>VideoBeginCodingInfoKHR</c>
        /// </summary>
        VideoBeginCodingInfoKHR = 1000023008,

        /// <summary>
        ///     <c>VideoEndCodingInfoKHR</c>
        /// </summary>
        VideoEndCodingInfoKHR = 1000023009,

        /// <summary>
        ///     <c>VideoCodingControlInfoKHR</c>
        /// </summary>
        VideoCodingControlInfoKHR = 1000023010,

        /// <summary>
        ///     <c>VideoReferenceSlotInfoKHR</c>
        /// </summary>
        VideoReferenceSlotInfoKHR = 1000023011,

        /// <summary>
        ///     <c>QueueFamilyVideoPropertiesKHR</c>
        /// </summary>
        QueueFamilyVideoPropertiesKHR = 1000023012,

        /// <summary>
        ///     <c>VideoProfileListInfoKHR</c>
        /// </summary>
        VideoProfileListInfoKHR = 1000023013,

        /// <summary>
        ///     <c>PhysicalDeviceVideoFormatInfoKHR</c>
        /// </summary>
        PhysicalDeviceVideoFormatInfoKHR = 1000023014,

        /// <summary>
        ///     <c>VideoFormatPropertiesKHR</c>
        /// </summary>
        VideoFormatPropertiesKHR = 1000023015,

        /// <summary>
        ///     <c>QueueFamilyQueryResultStatusPropertiesKHR</c>
        /// </summary>
        QueueFamilyQueryResultStatusPropertiesKHR = 1000023016,

        /// <summary>
        ///     <c>VideoDecodeInfoKHR</c>
        /// </summary>
        VideoDecodeInfoKHR = 1000024000,

        /// <summary>
        ///     <c>VideoDecodeCapabilitiesKHR</c>
        /// </summary>
        VideoDecodeCapabilitiesKHR = 1000024001,

        /// <summary>
        ///     <c>VideoDecodeUsageInfoKHR</c>
        /// </summary>
        VideoDecodeUsageInfoKHR = 1000024002,

        /// <summary>
        ///     <c>DedicatedAllocationImageCreateInfoNV</c>
        /// </summary>
        DedicatedAllocationImageCreateInfoNV = 1000026000,

        /// <summary>
        ///     <c>DedicatedAllocationBufferCreateInfoNV</c>
        /// </summary>
        DedicatedAllocationBufferCreateInfoNV = 1000026001,

        /// <summary>
        ///     <c>DedicatedAllocationMemoryAllocateInfoNV</c>
        /// </summary>
        DedicatedAllocationMemoryAllocateInfoNV = 1000026002,

        /// <summary>
        ///     <c>PhysicalDeviceTransformFeedbackFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,

        /// <summary>
        ///     <c>PhysicalDeviceTransformFeedbackPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,

        /// <summary>
        ///     <c>PipelineRasterizationStateStreamCreateInfoEXT</c>
        /// </summary>
        PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,

        /// <summary>
        ///     <c>CuModuleCreateInfoNVX</c>
        /// </summary>
        CuModuleCreateInfoNVX = 1000029000,

        /// <summary>
        ///     <c>CuFunctionCreateInfoNVX</c>
        /// </summary>
        CuFunctionCreateInfoNVX = 1000029001,

        /// <summary>
        ///     <c>CuLaunchInfoNVX</c>
        /// </summary>
        CuLaunchInfoNVX = 1000029002,

        /// <summary>
        ///     <c>CuModuleTexturingModeCreateInfoNVX</c>
        /// </summary>
        CuModuleTexturingModeCreateInfoNVX = 1000029004,

        /// <summary>
        ///     <c>ImageViewHandleInfoNVX</c>
        /// </summary>
        ImageViewHandleInfoNVX = 1000030000,

        /// <summary>
        ///     <c>ImageViewAddressPropertiesNVX</c>
        /// </summary>
        ImageViewAddressPropertiesNVX = 1000030001,

        /// <summary>
        ///     <c>VideoEncodeH264CapabilitiesKHR</c>
        /// </summary>
        VideoEncodeH264CapabilitiesKHR = 1000038000,

        /// <summary>
        ///     <c>VideoEncodeH264SessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoEncodeH264SessionParametersCreateInfoKHR = 1000038001,

        /// <summary>
        ///     <c>VideoEncodeH264SessionParametersAddInfoKHR</c>
        /// </summary>
        VideoEncodeH264SessionParametersAddInfoKHR = 1000038002,

        /// <summary>
        ///     <c>VideoEncodeH264PictureInfoKHR</c>
        /// </summary>
        VideoEncodeH264PictureInfoKHR = 1000038003,

        /// <summary>
        ///     <c>VideoEncodeH264DpbSlotInfoKHR</c>
        /// </summary>
        VideoEncodeH264DpbSlotInfoKHR = 1000038004,

        /// <summary>
        ///     <c>VideoEncodeH264NaluSliceInfoKHR</c>
        /// </summary>
        VideoEncodeH264NaluSliceInfoKHR = 1000038005,

        /// <summary>
        ///     <c>VideoEncodeH264GopRemainingFrameInfoKHR</c>
        /// </summary>
        VideoEncodeH264GopRemainingFrameInfoKHR = 1000038006,

        /// <summary>
        ///     <c>VideoEncodeH264ProfileInfoKHR</c>
        /// </summary>
        VideoEncodeH264ProfileInfoKHR = 1000038007,

        /// <summary>
        ///     <c>VideoEncodeH264RateControlInfoKHR</c>
        /// </summary>
        VideoEncodeH264RateControlInfoKHR = 1000038008,

        /// <summary>
        ///     <c>VideoEncodeH264RateControlLayerInfoKHR</c>
        /// </summary>
        VideoEncodeH264RateControlLayerInfoKHR = 1000038009,

        /// <summary>
        ///     <c>VideoEncodeH264SessionCreateInfoKHR</c>
        /// </summary>
        VideoEncodeH264SessionCreateInfoKHR = 1000038010,

        /// <summary>
        ///     <c>VideoEncodeH264QualityLevelPropertiesKHR</c>
        /// </summary>
        VideoEncodeH264QualityLevelPropertiesKHR = 1000038011,

        /// <summary>
        ///     <c>VideoEncodeH264SessionParametersGetInfoKHR</c>
        /// </summary>
        VideoEncodeH264SessionParametersGetInfoKHR = 1000038012,

        /// <summary>
        ///     <c>VideoEncodeH264SessionParametersFeedbackInfoKHR</c>
        /// </summary>
        VideoEncodeH264SessionParametersFeedbackInfoKHR = 1000038013,

        /// <summary>
        ///     <c>VideoEncodeH265CapabilitiesKHR</c>
        /// </summary>
        VideoEncodeH265CapabilitiesKHR = 1000039000,

        /// <summary>
        ///     <c>VideoEncodeH265SessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoEncodeH265SessionParametersCreateInfoKHR = 1000039001,

        /// <summary>
        ///     <c>VideoEncodeH265SessionParametersAddInfoKHR</c>
        /// </summary>
        VideoEncodeH265SessionParametersAddInfoKHR = 1000039002,

        /// <summary>
        ///     <c>VideoEncodeH265PictureInfoKHR</c>
        /// </summary>
        VideoEncodeH265PictureInfoKHR = 1000039003,

        /// <summary>
        ///     <c>VideoEncodeH265DpbSlotInfoKHR</c>
        /// </summary>
        VideoEncodeH265DpbSlotInfoKHR = 1000039004,

        /// <summary>
        ///     <c>VideoEncodeH265NaluSliceSegmentInfoKHR</c>
        /// </summary>
        VideoEncodeH265NaluSliceSegmentInfoKHR = 1000039005,

        /// <summary>
        ///     <c>VideoEncodeH265GopRemainingFrameInfoKHR</c>
        /// </summary>
        VideoEncodeH265GopRemainingFrameInfoKHR = 1000039006,

        /// <summary>
        ///     <c>VideoEncodeH265ProfileInfoKHR</c>
        /// </summary>
        VideoEncodeH265ProfileInfoKHR = 1000039007,

        /// <summary>
        ///     <c>VideoEncodeH265RateControlInfoKHR</c>
        /// </summary>
        VideoEncodeH265RateControlInfoKHR = 1000039009,

        /// <summary>
        ///     <c>VideoEncodeH265RateControlLayerInfoKHR</c>
        /// </summary>
        VideoEncodeH265RateControlLayerInfoKHR = 1000039010,

        /// <summary>
        ///     <c>VideoEncodeH265SessionCreateInfoKHR</c>
        /// </summary>
        VideoEncodeH265SessionCreateInfoKHR = 1000039011,

        /// <summary>
        ///     <c>VideoEncodeH265QualityLevelPropertiesKHR</c>
        /// </summary>
        VideoEncodeH265QualityLevelPropertiesKHR = 1000039012,

        /// <summary>
        ///     <c>VideoEncodeH265SessionParametersGetInfoKHR</c>
        /// </summary>
        VideoEncodeH265SessionParametersGetInfoKHR = 1000039013,

        /// <summary>
        ///     <c>VideoEncodeH265SessionParametersFeedbackInfoKHR</c>
        /// </summary>
        VideoEncodeH265SessionParametersFeedbackInfoKHR = 1000039014,

        /// <summary>
        ///     <c>VideoDecodeH264CapabilitiesKHR</c>
        /// </summary>
        VideoDecodeH264CapabilitiesKHR = 1000040000,

        /// <summary>
        ///     <c>VideoDecodeH264PictureInfoKHR</c>
        /// </summary>
        VideoDecodeH264PictureInfoKHR = 1000040001,

        /// <summary>
        ///     <c>VideoDecodeH264ProfileInfoKHR</c>
        /// </summary>
        VideoDecodeH264ProfileInfoKHR = 1000040003,

        /// <summary>
        ///     <c>VideoDecodeH264SessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoDecodeH264SessionParametersCreateInfoKHR = 1000040004,

        /// <summary>
        ///     <c>VideoDecodeH264SessionParametersAddInfoKHR</c>
        /// </summary>
        VideoDecodeH264SessionParametersAddInfoKHR = 1000040005,

        /// <summary>
        ///     <c>VideoDecodeH264DpbSlotInfoKHR</c>
        /// </summary>
        VideoDecodeH264DpbSlotInfoKHR = 1000040006,

        /// <summary>
        ///     <c>TextureLodGatherFormatPropertiesAMD</c>
        /// </summary>
        TextureLodGatherFormatPropertiesAMD = 1000041000,

        /// <summary>
        ///     <c>StreamDescriptorSurfaceCreateInfoGGP</c>
        /// </summary>
        StreamDescriptorSurfaceCreateInfoGGP = 1000049000,

        /// <summary>
        ///     <c>PhysicalDeviceCornerSampledImageFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,

        /// <summary>
        ///     <c>ExternalMemoryImageCreateInfoNV</c>
        /// </summary>
        ExternalMemoryImageCreateInfoNV = 1000056000,

        /// <summary>
        ///     <c>ExportMemoryAllocateInfoNV</c>
        /// </summary>
        ExportMemoryAllocateInfoNV = 1000056001,

        /// <summary>
        ///     <c>ImportMemoryWin32HandleInfoNV</c>
        /// </summary>
        ImportMemoryWin32HandleInfoNV = 1000057000,

        /// <summary>
        ///     <c>ExportMemoryWin32HandleInfoNV</c>
        /// </summary>
        ExportMemoryWin32HandleInfoNV = 1000057001,

        /// <summary>
        ///     <c>Win32KeyedMutexAcquireReleaseInfoNV</c>
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,

        /// <summary>
        ///     <c>ValidationFlagsEXT</c>
        /// </summary>
        ValidationFlagsEXT = 1000061000,

        /// <summary>
        ///     <c>ViSurfaceCreateInfoNN</c>
        /// </summary>
        ViSurfaceCreateInfoNN = 1000062000,

        /// <summary>
        ///     <c>ImageViewAstcDecodeModeEXT</c>
        /// </summary>
        ImageViewAstcDecodeModeEXT = 1000067000,

        /// <summary>
        ///     <c>PhysicalDeviceAstcDecodeFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,

        /// <summary>
        ///     <c>ImportMemoryWin32HandleInfoKHR</c>
        /// </summary>
        ImportMemoryWin32HandleInfoKHR = 1000073000,

        /// <summary>
        ///     <c>ExportMemoryWin32HandleInfoKHR</c>
        /// </summary>
        ExportMemoryWin32HandleInfoKHR = 1000073001,

        /// <summary>
        ///     <c>MemoryWin32HandlePropertiesKHR</c>
        /// </summary>
        MemoryWin32HandlePropertiesKHR = 1000073002,

        /// <summary>
        ///     <c>MemoryGetWin32HandleInfoKHR</c>
        /// </summary>
        MemoryGetWin32HandleInfoKHR = 1000073003,

        /// <summary>
        ///     <c>ImportMemoryFdInfoKHR</c>
        /// </summary>
        ImportMemoryFdInfoKHR = 1000074000,

        /// <summary>
        ///     <c>MemoryFdPropertiesKHR</c>
        /// </summary>
        MemoryFdPropertiesKHR = 1000074001,

        /// <summary>
        ///     <c>MemoryGetFdInfoKHR</c>
        /// </summary>
        MemoryGetFdInfoKHR = 1000074002,

        /// <summary>
        ///     <c>Win32KeyedMutexAcquireReleaseInfoKHR</c>
        /// </summary>
        Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,

        /// <summary>
        ///     <c>ImportSemaphoreWin32HandleInfoKHR</c>
        /// </summary>
        ImportSemaphoreWin32HandleInfoKHR = 1000078000,

        /// <summary>
        ///     <c>ExportSemaphoreWin32HandleInfoKHR</c>
        /// </summary>
        ExportSemaphoreWin32HandleInfoKHR = 1000078001,

        /// <summary>
        ///     <c>D3D12FenceSubmitInfoKHR</c>
        /// </summary>
        D3D12FenceSubmitInfoKHR = 1000078002,

        /// <summary>
        ///     <c>SemaphoreGetWin32HandleInfoKHR</c>
        /// </summary>
        SemaphoreGetWin32HandleInfoKHR = 1000078003,

        /// <summary>
        ///     <c>ImportSemaphoreFdInfoKHR</c>
        /// </summary>
        ImportSemaphoreFdInfoKHR = 1000079000,

        /// <summary>
        ///     <c>SemaphoreGetFdInfoKHR</c>
        /// </summary>
        SemaphoreGetFdInfoKHR = 1000079001,

        /// <summary>
        ///     <c>CommandBufferInheritanceConditionalRenderingInfoEXT</c>
        /// </summary>
        CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,

        /// <summary>
        ///     <c>PhysicalDeviceConditionalRenderingFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,

        /// <summary>
        ///     <c>ConditionalRenderingBeginInfoEXT</c>
        /// </summary>
        ConditionalRenderingBeginInfoEXT = 1000081002,

        /// <summary>
        ///     <c>PresentRegionsKHR</c>
        /// </summary>
        PresentRegionsKHR = 1000084000,

        /// <summary>
        ///     <c>PipelineViewportWScalingStateCreateInfoNV</c>
        /// </summary>
        PipelineViewportWScalingStateCreateInfoNV = 1000087000,

        /// <summary>
        ///     <c>SurfaceCapabilities2EXT</c>
        /// </summary>
        SurfaceCapabilities2EXT = 1000090000,

        /// <summary>
        ///     <c>DisplayPowerInfoEXT</c>
        /// </summary>
        DisplayPowerInfoEXT = 1000091000,

        /// <summary>
        ///     <c>DeviceEventInfoEXT</c>
        /// </summary>
        DeviceEventInfoEXT = 1000091001,

        /// <summary>
        ///     <c>DisplayEventInfoEXT</c>
        /// </summary>
        DisplayEventInfoEXT = 1000091002,

        /// <summary>
        ///     <c>SwapchainCounterCreateInfoEXT</c>
        /// </summary>
        SwapchainCounterCreateInfoEXT = 1000091003,

        /// <summary>
        ///     <c>PresentTimesInfoGOOGLE</c>
        /// </summary>
        PresentTimesInfoGOOGLE = 1000092000,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX</c>
        /// </summary>
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,

        /// <summary>
        ///     <c>MultiviewPerViewAttributesInfoNVX</c>
        /// </summary>
        MultiviewPerViewAttributesInfoNVX = 1000044009,

        /// <summary>
        ///     <c>PipelineViewportSwizzleStateCreateInfoNV</c>
        /// </summary>
        PipelineViewportSwizzleStateCreateInfoNV = 1000098000,

        /// <summary>
        ///     <c>PhysicalDeviceDiscardRectanglePropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,

        /// <summary>
        ///     <c>PipelineDiscardRectangleStateCreateInfoEXT</c>
        /// </summary>
        PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,

        /// <summary>
        ///     <c>PhysicalDeviceConservativeRasterizationPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,

        /// <summary>
        ///     <c>PipelineRasterizationConservativeStateCreateInfoEXT</c>
        /// </summary>
        PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,

        /// <summary>
        ///     <c>PhysicalDeviceDepthClipEnableFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,

        /// <summary>
        ///     <c>PipelineRasterizationDepthClipStateCreateInfoEXT</c>
        /// </summary>
        PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,

        /// <summary>
        ///     <c>HdrMetadataEXT</c>
        /// </summary>
        HdrMetadataEXT = 1000105000,

        /// <summary>
        ///     <c>PhysicalDeviceRelaxedLineRasterizationFeaturesIMG</c>
        /// </summary>
        PhysicalDeviceRelaxedLineRasterizationFeaturesIMG = 1000110000,

        /// <summary>
        ///     <c>SharedPresentSurfaceCapabilitiesKHR</c>
        /// </summary>
        SharedPresentSurfaceCapabilitiesKHR = 1000111000,

        /// <summary>
        ///     <c>ImportFenceWin32HandleInfoKHR</c>
        /// </summary>
        ImportFenceWin32HandleInfoKHR = 1000114000,

        /// <summary>
        ///     <c>ExportFenceWin32HandleInfoKHR</c>
        /// </summary>
        ExportFenceWin32HandleInfoKHR = 1000114001,

        /// <summary>
        ///     <c>FenceGetWin32HandleInfoKHR</c>
        /// </summary>
        FenceGetWin32HandleInfoKHR = 1000114002,

        /// <summary>
        ///     <c>ImportFenceFdInfoKHR</c>
        /// </summary>
        ImportFenceFdInfoKHR = 1000115000,

        /// <summary>
        ///     <c>FenceGetFdInfoKHR</c>
        /// </summary>
        FenceGetFdInfoKHR = 1000115001,

        /// <summary>
        ///     <c>PhysicalDevicePerformanceQueryFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,

        /// <summary>
        ///     <c>PhysicalDevicePerformanceQueryPropertiesKHR</c>
        /// </summary>
        PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,

        /// <summary>
        ///     <c>QueryPoolPerformanceCreateInfoKHR</c>
        /// </summary>
        QueryPoolPerformanceCreateInfoKHR = 1000116002,

        /// <summary>
        ///     <c>PerformanceQuerySubmitInfoKHR</c>
        /// </summary>
        PerformanceQuerySubmitInfoKHR = 1000116003,

        /// <summary>
        ///     <c>AcquireProfilingLockInfoKHR</c>
        /// </summary>
        AcquireProfilingLockInfoKHR = 1000116004,

        /// <summary>
        ///     <c>PerformanceCounterKHR</c>
        /// </summary>
        PerformanceCounterKHR = 1000116005,

        /// <summary>
        ///     <c>PerformanceCounterDescriptionKHR</c>
        /// </summary>
        PerformanceCounterDescriptionKHR = 1000116006,

        /// <summary>
        ///     <c>PhysicalDeviceSurfaceInfo2KHR</c>
        /// </summary>
        PhysicalDeviceSurfaceInfo2KHR = 1000119000,

        /// <summary>
        ///     <c>SurfaceCapabilities2KHR</c>
        /// </summary>
        SurfaceCapabilities2KHR = 1000119001,

        /// <summary>
        ///     <c>SurfaceFormat2KHR</c>
        /// </summary>
        SurfaceFormat2KHR = 1000119002,

        /// <summary>
        ///     <c>DisplayProperties2KHR</c>
        /// </summary>
        DisplayProperties2KHR = 1000121000,

        /// <summary>
        ///     <c>DisplayPlaneProperties2KHR</c>
        /// </summary>
        DisplayPlaneProperties2KHR = 1000121001,

        /// <summary>
        ///     <c>DisplayModeProperties2KHR</c>
        /// </summary>
        DisplayModeProperties2KHR = 1000121002,

        /// <summary>
        ///     <c>DisplayPlaneInfo2KHR</c>
        /// </summary>
        DisplayPlaneInfo2KHR = 1000121003,

        /// <summary>
        ///     <c>DisplayPlaneCapabilities2KHR</c>
        /// </summary>
        DisplayPlaneCapabilities2KHR = 1000121004,

        /// <summary>
        ///     <c>IosSurfaceCreateInfoMVK</c>
        /// </summary>
        IosSurfaceCreateInfoMVK = 1000122000,

        /// <summary>
        ///     <c>MacosSurfaceCreateInfoMVK</c>
        /// </summary>
        MacosSurfaceCreateInfoMVK = 1000123000,

        /// <summary>
        ///     <c>DebugUtilsObjectNameInfoEXT</c>
        /// </summary>
        DebugUtilsObjectNameInfoEXT = 1000128000,

        /// <summary>
        ///     <c>DebugUtilsObjectTagInfoEXT</c>
        /// </summary>
        DebugUtilsObjectTagInfoEXT = 1000128001,

        /// <summary>
        ///     <c>DebugUtilsLabelEXT</c>
        /// </summary>
        DebugUtilsLabelEXT = 1000128002,

        /// <summary>
        ///     <c>DebugUtilsMessengerCallbackDataEXT</c>
        /// </summary>
        DebugUtilsMessengerCallbackDataEXT = 1000128003,

        /// <summary>
        ///     <c>DebugUtilsMessengerCreateInfoEXT</c>
        /// </summary>
        DebugUtilsMessengerCreateInfoEXT = 1000128004,

        /// <summary>
        ///     <c>ANDROIDHardwareBufferUsageANDROID</c>
        /// </summary>
        ANDROIDHardwareBufferUsageANDROID = 1000129000,

        /// <summary>
        ///     <c>ANDROIDHardwareBufferPropertiesANDROID</c>
        /// </summary>
        ANDROIDHardwareBufferPropertiesANDROID = 1000129001,

        /// <summary>
        ///     <c>ANDROIDHardwareBufferFormatPropertiesANDROID</c>
        /// </summary>
        ANDROIDHardwareBufferFormatPropertiesANDROID = 1000129002,

        /// <summary>
        ///     <c>ImportANDROIDHardwareBufferInfoANDROID</c>
        /// </summary>
        ImportANDROIDHardwareBufferInfoANDROID = 1000129003,

        /// <summary>
        ///     <c>MemoryGetANDROIDHardwareBufferInfoANDROID</c>
        /// </summary>
        MemoryGetANDROIDHardwareBufferInfoANDROID = 1000129004,

        /// <summary>
        ///     <c>ExternalFormatANDROID</c>
        /// </summary>
        ExternalFormatANDROID = 1000129005,

        /// <summary>
        ///     <c>ANDROIDHardwareBufferFormatProperties2ANDROID</c>
        /// </summary>
        ANDROIDHardwareBufferFormatProperties2ANDROID = 1000129006,

        /// <summary>
        ///     <c>PhysicalDeviceGpaFeaturesAMD</c>
        /// </summary>
        PhysicalDeviceGpaFeaturesAMD = 1000133000,

        /// <summary>
        ///     <c>PhysicalDeviceGpaPropertiesAMD</c>
        /// </summary>
        PhysicalDeviceGpaPropertiesAMD = 1000133001,

        /// <summary>
        ///     <c>GpaSampleBeginInfoAMD</c>
        /// </summary>
        GpaSampleBeginInfoAMD = 1000133002,

        /// <summary>
        ///     <c>GpaSessionCreateInfoAMD</c>
        /// </summary>
        GpaSessionCreateInfoAMD = 1000133003,

        /// <summary>
        ///     <c>GpaDeviceClockModeInfoAMD</c>
        /// </summary>
        GpaDeviceClockModeInfoAMD = 1000133004,

        /// <summary>
        ///     <c>PhysicalDeviceGpaProperties2AMD</c>
        /// </summary>
        PhysicalDeviceGpaProperties2AMD = 1000133005,

        /// <summary>
        ///     <c>GpaDeviceGetClockInfoAMD</c>
        /// </summary>
        GpaDeviceGetClockInfoAMD = 1000133006,

        /// <summary>
        ///     <c>PhysicalDeviceShaderEnqueueFeaturesAMDX</c>
        /// </summary>
        PhysicalDeviceShaderEnqueueFeaturesAMDX = 1000134000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderEnqueuePropertiesAMDX</c>
        /// </summary>
        PhysicalDeviceShaderEnqueuePropertiesAMDX = 1000134001,

        /// <summary>
        ///     <c>ExecutionGraphPipelineScratchSizeAMDX</c>
        /// </summary>
        ExecutionGraphPipelineScratchSizeAMDX = 1000134002,

        /// <summary>
        ///     <c>ExecutionGraphPipelineCreateInfoAMDX</c>
        /// </summary>
        ExecutionGraphPipelineCreateInfoAMDX = 1000134003,

        /// <summary>
        ///     <c>PipelineShaderStageNodeCreateInfoAMDX</c>
        /// </summary>
        PipelineShaderStageNodeCreateInfoAMDX = 1000134004,

        /// <summary>
        ///     <c>TexelBufferDescriptorInfoEXT</c>
        /// </summary>
        TexelBufferDescriptorInfoEXT = 1000135000,

        /// <summary>
        ///     <c>ImageDescriptorInfoEXT</c>
        /// </summary>
        ImageDescriptorInfoEXT = 1000135001,

        /// <summary>
        ///     <c>ResourceDescriptorInfoEXT</c>
        /// </summary>
        ResourceDescriptorInfoEXT = 1000135002,

        /// <summary>
        ///     <c>BindHeapInfoEXT</c>
        /// </summary>
        BindHeapInfoEXT = 1000135003,

        /// <summary>
        ///     <c>PushDataInfoEXT</c>
        /// </summary>
        PushDataInfoEXT = 1000135004,

        /// <summary>
        ///     <c>DescriptorSetAndBindingMappingEXT</c>
        /// </summary>
        DescriptorSetAndBindingMappingEXT = 1000135005,

        /// <summary>
        ///     <c>ShaderDescriptorSetAndBindingMappingInfoEXT</c>
        /// </summary>
        ShaderDescriptorSetAndBindingMappingInfoEXT = 1000135006,

        /// <summary>
        ///     <c>OpaqueCaptureDataCreateInfoEXT</c>
        /// </summary>
        OpaqueCaptureDataCreateInfoEXT = 1000135007,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorHeapPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorHeapPropertiesEXT = 1000135008,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorHeapFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorHeapFeaturesEXT = 1000135009,

        /// <summary>
        ///     <c>CommandBufferInheritanceDescriptorHeapInfoEXT</c>
        /// </summary>
        CommandBufferInheritanceDescriptorHeapInfoEXT = 1000135010,

        /// <summary>
        ///     <c>SamplerCustomBorderColorIndexCreateInfoEXT</c>
        /// </summary>
        SamplerCustomBorderColorIndexCreateInfoEXT = 1000135011,

        /// <summary>
        ///     <c>IndirectCommandsLayoutPushDataTokenNV</c>
        /// </summary>
        IndirectCommandsLayoutPushDataTokenNV = 1000135012,

        /// <summary>
        ///     <c>SubsampledImageFormatPropertiesEXT</c>
        /// </summary>
        SubsampledImageFormatPropertiesEXT = 1000135013,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorHeapTensorPropertiesARM</c>
        /// </summary>
        PhysicalDeviceDescriptorHeapTensorPropertiesARM = 1000135014,

        /// <summary>
        ///     <c>AttachmentSampleCountInfoAMD</c>
        /// </summary>
        AttachmentSampleCountInfoAMD = 1000044008,

        /// <summary>
        ///     <c>PhysicalDeviceShaderBfloat16FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderBfloat16FeaturesKHR = 1000141000,

        /// <summary>
        ///     <c>SampleLocationsInfoEXT</c>
        /// </summary>
        SampleLocationsInfoEXT = 1000143000,

        /// <summary>
        ///     <c>RenderPassSampleLocationsBeginInfoEXT</c>
        /// </summary>
        RenderPassSampleLocationsBeginInfoEXT = 1000143001,

        /// <summary>
        ///     <c>PipelineSampleLocationsStateCreateInfoEXT</c>
        /// </summary>
        PipelineSampleLocationsStateCreateInfoEXT = 1000143002,

        /// <summary>
        ///     <c>PhysicalDeviceSampleLocationsPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,

        /// <summary>
        ///     <c>MultisamplePropertiesEXT</c>
        /// </summary>
        MultisamplePropertiesEXT = 1000143004,

        /// <summary>
        ///     <c>PhysicalDeviceBlendOperationAdvancedFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,

        /// <summary>
        ///     <c>PhysicalDeviceBlendOperationAdvancedPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,

        /// <summary>
        ///     <c>PipelineColorBlendAdvancedStateCreateInfoEXT</c>
        /// </summary>
        PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,

        /// <summary>
        ///     <c>PipelineCoverageToColorStateCreateInfoNV</c>
        /// </summary>
        PipelineCoverageToColorStateCreateInfoNV = 1000149000,

        /// <summary>
        ///     <c>WriteDescriptorSetAccelerationStructureKHR</c>
        /// </summary>
        WriteDescriptorSetAccelerationStructureKHR = 1000150007,

        /// <summary>
        ///     <c>AccelerationStructureBuildGeometryInfoKHR</c>
        /// </summary>
        AccelerationStructureBuildGeometryInfoKHR = 1000150000,

        /// <summary>
        ///     <c>AccelerationStructureDeviceAddressInfoKHR</c>
        /// </summary>
        AccelerationStructureDeviceAddressInfoKHR = 1000150002,

        /// <summary>
        ///     <c>AccelerationStructureGeometryAabbsDataKHR</c>
        /// </summary>
        AccelerationStructureGeometryAabbsDataKHR = 1000150003,

        /// <summary>
        ///     <c>AccelerationStructureGeometryInstancesDataKHR</c>
        /// </summary>
        AccelerationStructureGeometryInstancesDataKHR = 1000150004,

        /// <summary>
        ///     <c>AccelerationStructureGeometryTrianglesDataKHR</c>
        /// </summary>
        AccelerationStructureGeometryTrianglesDataKHR = 1000150005,

        /// <summary>
        ///     <c>AccelerationStructureGeometryKHR</c>
        /// </summary>
        AccelerationStructureGeometryKHR = 1000150006,

        /// <summary>
        ///     <c>AccelerationStructureVersionInfoKHR</c>
        /// </summary>
        AccelerationStructureVersionInfoKHR = 1000150009,

        /// <summary>
        ///     <c>CopyAccelerationStructureInfoKHR</c>
        /// </summary>
        CopyAccelerationStructureInfoKHR = 1000150010,

        /// <summary>
        ///     <c>CopyAccelerationStructureToMemoryInfoKHR</c>
        /// </summary>
        CopyAccelerationStructureToMemoryInfoKHR = 1000150011,

        /// <summary>
        ///     <c>CopyMemoryToAccelerationStructureInfoKHR</c>
        /// </summary>
        CopyMemoryToAccelerationStructureInfoKHR = 1000150012,

        /// <summary>
        ///     <c>PhysicalDeviceAccelerationStructureFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,

        /// <summary>
        ///     <c>PhysicalDeviceAccelerationStructurePropertiesKHR</c>
        /// </summary>
        PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,

        /// <summary>
        ///     <c>AccelerationStructureCreateInfoKHR</c>
        /// </summary>
        AccelerationStructureCreateInfoKHR = 1000150017,

        /// <summary>
        ///     <c>AccelerationStructureBuildSizesInfoKHR</c>
        /// </summary>
        AccelerationStructureBuildSizesInfoKHR = 1000150020,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingPipelineFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingPipelinePropertiesKHR</c>
        /// </summary>
        PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,

        /// <summary>
        ///     <c>RayTracingPipelineCreateInfoKHR</c>
        /// </summary>
        RayTracingPipelineCreateInfoKHR = 1000150015,

        /// <summary>
        ///     <c>RayTracingShaderGroupCreateInfoKHR</c>
        /// </summary>
        RayTracingShaderGroupCreateInfoKHR = 1000150016,

        /// <summary>
        ///     <c>RayTracingPipelineInterfaceCreateInfoKHR</c>
        /// </summary>
        RayTracingPipelineInterfaceCreateInfoKHR = 1000150018,

        /// <summary>
        ///     <c>PhysicalDeviceRayQueryFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceRayQueryFeaturesKHR = 1000348013,

        /// <summary>
        ///     <c>PipelineCoverageModulationStateCreateInfoNV</c>
        /// </summary>
        PipelineCoverageModulationStateCreateInfoNV = 1000152000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSmBuiltinsFeaturesNV</c>
        /// </summary>
        PhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSmBuiltinsPropertiesNV</c>
        /// </summary>
        PhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,

        /// <summary>
        ///     <c>DrmFormatModifierPropertiesListEXT</c>
        /// </summary>
        DrmFormatModifierPropertiesListEXT = 1000158000,

        /// <summary>
        ///     <c>PhysicalDeviceImageDrmFormatModifierInfoEXT</c>
        /// </summary>
        PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,

        /// <summary>
        ///     <c>ImageDrmFormatModifierListCreateInfoEXT</c>
        /// </summary>
        ImageDrmFormatModifierListCreateInfoEXT = 1000158003,

        /// <summary>
        ///     <c>ImageDrmFormatModifierExplicitCreateInfoEXT</c>
        /// </summary>
        ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,

        /// <summary>
        ///     <c>ImageDrmFormatModifierPropertiesEXT</c>
        /// </summary>
        ImageDrmFormatModifierPropertiesEXT = 1000158005,

        /// <summary>
        ///     <c>DrmFormatModifierPropertiesList2EXT</c>
        /// </summary>
        DrmFormatModifierPropertiesList2EXT = 1000158006,

        /// <summary>
        ///     <c>ValidationCacheCreateInfoEXT</c>
        /// </summary>
        ValidationCacheCreateInfoEXT = 1000160000,

        /// <summary>
        ///     <c>ShaderModuleValidationCacheCreateInfoEXT</c>
        /// </summary>
        ShaderModuleValidationCacheCreateInfoEXT = 1000160001,

        /// <summary>
        ///     <c>PhysicalDevicePortabilitySubsetFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePortabilitySubsetFeaturesKHR = 1000163000,

        /// <summary>
        ///     <c>PhysicalDevicePortabilitySubsetPropertiesKHR</c>
        /// </summary>
        PhysicalDevicePortabilitySubsetPropertiesKHR = 1000163001,

        /// <summary>
        ///     <c>PipelineViewportShadingRateImageStateCreateInfoNV</c>
        /// </summary>
        PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,

        /// <summary>
        ///     <c>PhysicalDeviceShadingRateImageFeaturesNV</c>
        /// </summary>
        PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,

        /// <summary>
        ///     <c>PhysicalDeviceShadingRateImagePropertiesNV</c>
        /// </summary>
        PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,

        /// <summary>
        ///     <c>PipelineViewportCoarseSampleOrderStateCreateInfoNV</c>
        /// </summary>
        PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,

        /// <summary>
        ///     <c>RayTracingPipelineCreateInfoNV</c>
        /// </summary>
        RayTracingPipelineCreateInfoNV = 1000165000,

        /// <summary>
        ///     <c>AccelerationStructureCreateInfoNV</c>
        /// </summary>
        AccelerationStructureCreateInfoNV = 1000165001,

        /// <summary>
        ///     <c>GeometryNV</c>
        /// </summary>
        GeometryNV = 1000165003,

        /// <summary>
        ///     <c>GeometryTrianglesNV</c>
        /// </summary>
        GeometryTrianglesNV = 1000165004,

        /// <summary>
        ///     <c>GeometryAabbNV</c>
        /// </summary>
        GeometryAabbNV = 1000165005,

        /// <summary>
        ///     <c>BindAccelerationStructureMemoryInfoNV</c>
        /// </summary>
        BindAccelerationStructureMemoryInfoNV = 1000165006,

        /// <summary>
        ///     <c>WriteDescriptorSetAccelerationStructureNV</c>
        /// </summary>
        WriteDescriptorSetAccelerationStructureNV = 1000165007,

        /// <summary>
        ///     <c>AccelerationStructureMemoryRequirementsInfoNV</c>
        /// </summary>
        AccelerationStructureMemoryRequirementsInfoNV = 1000165008,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingPropertiesNV</c>
        /// </summary>
        PhysicalDeviceRayTracingPropertiesNV = 1000165009,

        /// <summary>
        ///     <c>RayTracingShaderGroupCreateInfoNV</c>
        /// </summary>
        RayTracingShaderGroupCreateInfoNV = 1000165011,

        /// <summary>
        ///     <c>AccelerationStructureInfoNV</c>
        /// </summary>
        AccelerationStructureInfoNV = 1000165012,

        /// <summary>
        ///     <c>PhysicalDeviceRepresentativeFragmentTestFeaturesNV</c>
        /// </summary>
        PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,

        /// <summary>
        ///     <c>PipelineRepresentativeFragmentTestStateCreateInfoNV</c>
        /// </summary>
        PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,

        /// <summary>
        ///     <c>PhysicalDeviceImageViewImageFormatInfoEXT</c>
        /// </summary>
        PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,

        /// <summary>
        ///     <c>FilterCubicImageViewImageFormatPropertiesEXT</c>
        /// </summary>
        FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrixConversionFeaturesQCOM = 1000172000,

        /// <summary>
        ///     <c>PhysicalDeviceElapsedTimerQueryFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceElapsedTimerQueryFeaturesQCOM = 1000173000,

        /// <summary>
        ///     <c>ImportMemoryHostPointerInfoEXT</c>
        /// </summary>
        ImportMemoryHostPointerInfoEXT = 1000178000,

        /// <summary>
        ///     <c>MemoryHostPointerPropertiesEXT</c>
        /// </summary>
        MemoryHostPointerPropertiesEXT = 1000178001,

        /// <summary>
        ///     <c>PhysicalDeviceExternalMemoryHostPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,

        /// <summary>
        ///     <c>PhysicalDeviceShaderClockFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderClockFeaturesKHR = 1000181000,

        /// <summary>
        ///     <c>PipelineCompilerControlCreateInfoAMD</c>
        /// </summary>
        PipelineCompilerControlCreateInfoAMD = 1000183000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderCorePropertiesAMD</c>
        /// </summary>
        PhysicalDeviceShaderCorePropertiesAMD = 1000185000,

        /// <summary>
        ///     <c>VideoDecodeH265CapabilitiesKHR</c>
        /// </summary>
        VideoDecodeH265CapabilitiesKHR = 1000187000,

        /// <summary>
        ///     <c>VideoDecodeH265SessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoDecodeH265SessionParametersCreateInfoKHR = 1000187001,

        /// <summary>
        ///     <c>VideoDecodeH265SessionParametersAddInfoKHR</c>
        /// </summary>
        VideoDecodeH265SessionParametersAddInfoKHR = 1000187002,

        /// <summary>
        ///     <c>VideoDecodeH265ProfileInfoKHR</c>
        /// </summary>
        VideoDecodeH265ProfileInfoKHR = 1000187003,

        /// <summary>
        ///     <c>VideoDecodeH265PictureInfoKHR</c>
        /// </summary>
        VideoDecodeH265PictureInfoKHR = 1000187004,

        /// <summary>
        ///     <c>VideoDecodeH265DpbSlotInfoKHR</c>
        /// </summary>
        VideoDecodeH265DpbSlotInfoKHR = 1000187005,

        /// <summary>
        ///     <c>DeviceMemoryOverallocationCreateInfoAMD</c>
        /// </summary>
        DeviceMemoryOverallocationCreateInfoAMD = 1000189000,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeDivisorPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,

        /// <summary>
        ///     <c>PresentFrameTokenGGP</c>
        /// </summary>
        PresentFrameTokenGGP = 1000191000,

        /// <summary>
        ///     <c>PhysicalDeviceMeshShaderFeaturesNV</c>
        /// </summary>
        PhysicalDeviceMeshShaderFeaturesNV = 1000202000,

        /// <summary>
        ///     <c>PhysicalDeviceMeshShaderPropertiesNV</c>
        /// </summary>
        PhysicalDeviceMeshShaderPropertiesNV = 1000202001,

        /// <summary>
        ///     <c>PhysicalDeviceShaderImageFootprintFeaturesNV</c>
        /// </summary>
        PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,

        /// <summary>
        ///     <c>PipelineViewportExclusiveScissorStateCreateInfoNV</c>
        /// </summary>
        PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,

        /// <summary>
        ///     <c>PhysicalDeviceExclusiveScissorFeaturesNV</c>
        /// </summary>
        PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,

        /// <summary>
        ///     <c>CheckpointDataNV</c>
        /// </summary>
        CheckpointDataNV = 1000206000,

        /// <summary>
        ///     <c>QueueFamilyCheckpointPropertiesNV</c>
        /// </summary>
        QueueFamilyCheckpointPropertiesNV = 1000206001,

        /// <summary>
        ///     <c>QueueFamilyCheckpointProperties2NV</c>
        /// </summary>
        QueueFamilyCheckpointProperties2NV = 1000314008,

        /// <summary>
        ///     <c>CheckpointData2NV</c>
        /// </summary>
        CheckpointData2NV = 1000314009,

        /// <summary>
        ///     <c>PhysicalDevicePresentTimingFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePresentTimingFeaturesEXT = 1000208000,

        /// <summary>
        ///     <c>SwapchainTimingPropertiesEXT</c>
        /// </summary>
        SwapchainTimingPropertiesEXT = 1000208001,

        /// <summary>
        ///     <c>SwapchainTimeDomainPropertiesEXT</c>
        /// </summary>
        SwapchainTimeDomainPropertiesEXT = 1000208002,

        /// <summary>
        ///     <c>PresentTimingsInfoEXT</c>
        /// </summary>
        PresentTimingsInfoEXT = 1000208003,

        /// <summary>
        ///     <c>PresentTimingInfoEXT</c>
        /// </summary>
        PresentTimingInfoEXT = 1000208004,

        /// <summary>
        ///     <c>PastPresentationTimingInfoEXT</c>
        /// </summary>
        PastPresentationTimingInfoEXT = 1000208005,

        /// <summary>
        ///     <c>PastPresentationTimingPropertiesEXT</c>
        /// </summary>
        PastPresentationTimingPropertiesEXT = 1000208006,

        /// <summary>
        ///     <c>PastPresentationTimingEXT</c>
        /// </summary>
        PastPresentationTimingEXT = 1000208007,

        /// <summary>
        ///     <c>PresentTimingSurfaceCapabilitiesEXT</c>
        /// </summary>
        PresentTimingSurfaceCapabilitiesEXT = 1000208008,

        /// <summary>
        ///     <c>SwapchainCalibratedTimestampInfoEXT</c>
        /// </summary>
        SwapchainCalibratedTimestampInfoEXT = 1000208009,

        /// <summary>
        ///     <c>PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL</c>
        /// </summary>
        PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL = 1000209000,

        /// <summary>
        ///     <c>QueryPoolPerformanceQueryCreateInfoINTEL</c>
        /// </summary>
        QueryPoolPerformanceQueryCreateInfoINTEL = 1000210000,

        /// <summary>
        ///     <c>InitializePerformanceApiInfoINTEL</c>
        /// </summary>
        InitializePerformanceApiInfoINTEL = 1000210001,

        /// <summary>
        ///     <c>PerformanceMarkerInfoINTEL</c>
        /// </summary>
        PerformanceMarkerInfoINTEL = 1000210002,

        /// <summary>
        ///     <c>PerformanceStreamMarkerInfoINTEL</c>
        /// </summary>
        PerformanceStreamMarkerInfoINTEL = 1000210003,

        /// <summary>
        ///     <c>PerformanceOverrideInfoINTEL</c>
        /// </summary>
        PerformanceOverrideInfoINTEL = 1000210004,

        /// <summary>
        ///     <c>PerformanceConfigurationAcquireInfoINTEL</c>
        /// </summary>
        PerformanceConfigurationAcquireInfoINTEL = 1000210005,

        /// <summary>
        ///     <c>PhysicalDevicePciBusInfoPropertiesEXT</c>
        /// </summary>
        PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,

        /// <summary>
        ///     <c>DisplayNativeHdrSurfaceCapabilitiesAMD</c>
        /// </summary>
        DisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,

        /// <summary>
        ///     <c>SwapchainDisplayNativeHdrCreateInfoAMD</c>
        /// </summary>
        SwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,

        /// <summary>
        ///     <c>ImagepipeSurfaceCreateInfoFUCHSIA</c>
        /// </summary>
        ImagepipeSurfaceCreateInfoFUCHSIA = 1000214000,

        /// <summary>
        ///     <c>MetalSurfaceCreateInfoEXT</c>
        /// </summary>
        MetalSurfaceCreateInfoEXT = 1000217000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,

        /// <summary>
        ///     <c>RenderPassFragmentDensityMapCreateInfoEXT</c>
        /// </summary>
        RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,

        /// <summary>
        ///     <c>RenderingFragmentDensityMapAttachmentInfoEXT</c>
        /// </summary>
        RenderingFragmentDensityMapAttachmentInfoEXT = 1000044007,

        /// <summary>
        ///     <c>FragmentShadingRateAttachmentInfoKHR</c>
        /// </summary>
        FragmentShadingRateAttachmentInfoKHR = 1000226000,

        /// <summary>
        ///     <c>PipelineFragmentShadingRateStateCreateInfoKHR</c>
        /// </summary>
        PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShadingRatePropertiesKHR</c>
        /// </summary>
        PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShadingRateFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShadingRateKHR</c>
        /// </summary>
        PhysicalDeviceFragmentShadingRateKHR = 1000226004,

        /// <summary>
        ///     <c>RenderingFragmentShadingRateAttachmentInfoKHR</c>
        /// </summary>
        RenderingFragmentShadingRateAttachmentInfoKHR = 1000044006,

        /// <summary>
        ///     <c>PhysicalDeviceShaderCoreProperties2AMD</c>
        /// </summary>
        PhysicalDeviceShaderCoreProperties2AMD = 1000227000,

        /// <summary>
        ///     <c>PhysicalDeviceCoherentMemoryFeaturesAMD</c>
        /// </summary>
        PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderConstantDataFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderConstantDataFeaturesKHR = 1000231000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAbortFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderAbortFeaturesKHR = 1000233000,

        /// <summary>
        ///     <c>DeviceFaultShaderAbortMessageInfoKHR</c>
        /// </summary>
        DeviceFaultShaderAbortMessageInfoKHR = 1000233001,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAbortPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceShaderAbortPropertiesKHR = 1000233002,

        /// <summary>
        ///     <c>PhysicalDeviceShaderImageAtomicInt64FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderQuadControlFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderQuadControlFeaturesKHR = 1000235000,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryBudgetPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryPriorityFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,

        /// <summary>
        ///     <c>MemoryPriorityAllocateInfoEXT</c>
        /// </summary>
        MemoryPriorityAllocateInfoEXT = 1000238001,

        /// <summary>
        ///     <c>SurfaceProtectedCapabilitiesKHR</c>
        /// </summary>
        SurfaceProtectedCapabilitiesKHR = 1000239000,

        /// <summary>
        ///     <c>PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV</c>
        /// </summary>
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,

        /// <summary>
        ///     <c>PhysicalDeviceBufferDeviceAddressFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,

        /// <summary>
        ///     <c>BufferDeviceAddressCreateInfoEXT</c>
        /// </summary>
        BufferDeviceAddressCreateInfoEXT = 1000244002,

        /// <summary>
        ///     <c>ValidationFeaturesEXT</c>
        /// </summary>
        ValidationFeaturesEXT = 1000247000,

        /// <summary>
        ///     <c>PhysicalDevicePresentWaitFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePresentWaitFeaturesKHR = 1000248000,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrixFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,

        /// <summary>
        ///     <c>CooperativeMatrixPropertiesNV</c>
        /// </summary>
        CooperativeMatrixPropertiesNV = 1000249001,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrixPropertiesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,

        /// <summary>
        ///     <c>PhysicalDeviceCoverageReductionModeFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,

        /// <summary>
        ///     <c>PipelineCoverageReductionStateCreateInfoNV</c>
        /// </summary>
        PipelineCoverageReductionStateCreateInfoNV = 1000250001,

        /// <summary>
        ///     <c>FramebufferMixedSamplesCombinationNV</c>
        /// </summary>
        FramebufferMixedSamplesCombinationNV = 1000250002,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShaderInterlockFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,

        /// <summary>
        ///     <c>PhysicalDeviceYCbCrImageArraysFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceYCbCrImageArraysFeaturesEXT = 1000252000,

        /// <summary>
        ///     <c>PhysicalDeviceProvokingVertexFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceProvokingVertexFeaturesEXT = 1000254000,

        /// <summary>
        ///     <c>PipelineRasterizationProvokingVertexStateCreateInfoEXT</c>
        /// </summary>
        PipelineRasterizationProvokingVertexStateCreateInfoEXT = 1000254001,

        /// <summary>
        ///     <c>PhysicalDeviceProvokingVertexPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceProvokingVertexPropertiesEXT = 1000254002,

        /// <summary>
        ///     <c>SurfaceFullScreenExclusiveInfoEXT</c>
        /// </summary>
        SurfaceFullScreenExclusiveInfoEXT = 1000255000,

        /// <summary>
        ///     <c>SurfaceCapabilitiesFullScreenExclusiveEXT</c>
        /// </summary>
        SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,

        /// <summary>
        ///     <c>SurfaceFullScreenExclusiveWin32InfoEXT</c>
        /// </summary>
        SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,

        /// <summary>
        ///     <c>HeadlessSurfaceCreateInfoEXT</c>
        /// </summary>
        HeadlessSurfaceCreateInfoEXT = 1000256000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAtomicFloatFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedDynamicStateFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,

        /// <summary>
        ///     <c>PhysicalDevicePipelineExecutablePropertiesFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,

        /// <summary>
        ///     <c>PipelineInfoKHR</c>
        /// </summary>
        PipelineInfoKHR = 1000269001,

        /// <summary>
        ///     <c>PipelineExecutablePropertiesKHR</c>
        /// </summary>
        PipelineExecutablePropertiesKHR = 1000269002,

        /// <summary>
        ///     <c>PipelineExecutableInfoKHR</c>
        /// </summary>
        PipelineExecutableInfoKHR = 1000269003,

        /// <summary>
        ///     <c>PipelineExecutableStatisticKHR</c>
        /// </summary>
        PipelineExecutableStatisticKHR = 1000269004,

        /// <summary>
        ///     <c>PipelineExecutableInternalRepresentationKHR</c>
        /// </summary>
        PipelineExecutableInternalRepresentationKHR = 1000269005,

        /// <summary>
        ///     <c>PhysicalDeviceMapMemoryPlacedFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMapMemoryPlacedFeaturesEXT = 1000272000,

        /// <summary>
        ///     <c>PhysicalDeviceMapMemoryPlacedPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceMapMemoryPlacedPropertiesEXT = 1000272001,

        /// <summary>
        ///     <c>MemoryMapPlacedInfoEXT</c>
        /// </summary>
        MemoryMapPlacedInfoEXT = 1000272002,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAtomicFloat2FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderAtomicFloat2FeaturesEXT = 1000273000,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceGeneratedCommandsPropertiesNV</c>
        /// </summary>
        PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,

        /// <summary>
        ///     <c>GraphicsShaderGroupCreateInfoNV</c>
        /// </summary>
        GraphicsShaderGroupCreateInfoNV = 1000277001,

        /// <summary>
        ///     <c>GraphicsPipelineShaderGroupsCreateInfoNV</c>
        /// </summary>
        GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,

        /// <summary>
        ///     <c>IndirectCommandsLayoutTokenNV</c>
        /// </summary>
        IndirectCommandsLayoutTokenNV = 1000277003,

        /// <summary>
        ///     <c>IndirectCommandsLayoutCreateInfoNV</c>
        /// </summary>
        IndirectCommandsLayoutCreateInfoNV = 1000277004,

        /// <summary>
        ///     <c>GeneratedCommandsInfoNV</c>
        /// </summary>
        GeneratedCommandsInfoNV = 1000277005,

        /// <summary>
        ///     <c>GeneratedCommandsMemoryRequirementsInfoNV</c>
        /// </summary>
        GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceGeneratedCommandsFeaturesNV</c>
        /// </summary>
        PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,

        /// <summary>
        ///     <c>PhysicalDeviceInheritedViewportScissorFeaturesNV</c>
        /// </summary>
        PhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,

        /// <summary>
        ///     <c>CommandBufferInheritanceViewportScissorInfoNV</c>
        /// </summary>
        CommandBufferInheritanceViewportScissorInfoNV = 1000278001,

        /// <summary>
        ///     <c>PhysicalDeviceTexelBufferAlignmentFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,

        /// <summary>
        ///     <c>CommandBufferInheritanceRenderPassTransformInfoQCOM</c>
        /// </summary>
        CommandBufferInheritanceRenderPassTransformInfoQCOM = 1000282000,

        /// <summary>
        ///     <c>RenderPassTransformBeginInfoQCOM</c>
        /// </summary>
        RenderPassTransformBeginInfoQCOM = 1000282001,

        /// <summary>
        ///     <c>PhysicalDeviceDepthBiasControlFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDepthBiasControlFeaturesEXT = 1000283000,

        /// <summary>
        ///     <c>DepthBiasInfoEXT</c>
        /// </summary>
        DepthBiasInfoEXT = 1000283001,

        /// <summary>
        ///     <c>DepthBiasRepresentationInfoEXT</c>
        /// </summary>
        DepthBiasRepresentationInfoEXT = 1000283002,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceMemoryReportFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,

        /// <summary>
        ///     <c>DeviceDeviceMemoryReportCreateInfoEXT</c>
        /// </summary>
        DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,

        /// <summary>
        ///     <c>DeviceMemoryReportCallbackDataEXT</c>
        /// </summary>
        DeviceMemoryReportCallbackDataEXT = 1000284002,

        /// <summary>
        ///     <c>SamplerCustomBorderColorCreateInfoEXT</c>
        /// </summary>
        SamplerCustomBorderColorCreateInfoEXT = 1000287000,

        /// <summary>
        ///     <c>PhysicalDeviceCustomBorderColorPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,

        /// <summary>
        ///     <c>PhysicalDeviceCustomBorderColorFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,

        /// <summary>
        ///     <c>PhysicalDeviceTextureCompressionAstc3DFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceTextureCompressionAstc3DFeaturesEXT = 1000288000,

        /// <summary>
        ///     <c>PipelineLibraryCreateInfoKHR</c>
        /// </summary>
        PipelineLibraryCreateInfoKHR = 1000290000,

        /// <summary>
        ///     <c>PhysicalDevicePresentBarrierFeaturesNV</c>
        /// </summary>
        PhysicalDevicePresentBarrierFeaturesNV = 1000292000,

        /// <summary>
        ///     <c>SurfaceCapabilitiesPresentBarrierNV</c>
        /// </summary>
        SurfaceCapabilitiesPresentBarrierNV = 1000292001,

        /// <summary>
        ///     <c>SwapchainPresentBarrierCreateInfoNV</c>
        /// </summary>
        SwapchainPresentBarrierCreateInfoNV = 1000292002,

        /// <summary>
        ///     <c>PresentIdKHR</c>
        /// </summary>
        PresentIdKHR = 1000294000,

        /// <summary>
        ///     <c>PhysicalDevicePresentIdFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePresentIdFeaturesKHR = 1000294001,

        /// <summary>
        ///     <c>VideoEncodeInfoKHR</c>
        /// </summary>
        VideoEncodeInfoKHR = 1000299000,

        /// <summary>
        ///     <c>VideoEncodeRateControlInfoKHR</c>
        /// </summary>
        VideoEncodeRateControlInfoKHR = 1000299001,

        /// <summary>
        ///     <c>VideoEncodeRateControlLayerInfoKHR</c>
        /// </summary>
        VideoEncodeRateControlLayerInfoKHR = 1000299002,

        /// <summary>
        ///     <c>VideoEncodeCapabilitiesKHR</c>
        /// </summary>
        VideoEncodeCapabilitiesKHR = 1000299003,

        /// <summary>
        ///     <c>VideoEncodeUsageInfoKHR</c>
        /// </summary>
        VideoEncodeUsageInfoKHR = 1000299004,

        /// <summary>
        ///     <c>QueryPoolVideoEncodeFeedbackCreateInfoKHR</c>
        /// </summary>
        QueryPoolVideoEncodeFeedbackCreateInfoKHR = 1000299005,

        /// <summary>
        ///     <c>PhysicalDeviceVideoEncodeQualityLevelInfoKHR</c>
        /// </summary>
        PhysicalDeviceVideoEncodeQualityLevelInfoKHR = 1000299006,

        /// <summary>
        ///     <c>VideoEncodeQualityLevelPropertiesKHR</c>
        /// </summary>
        VideoEncodeQualityLevelPropertiesKHR = 1000299007,

        /// <summary>
        ///     <c>VideoEncodeQualityLevelInfoKHR</c>
        /// </summary>
        VideoEncodeQualityLevelInfoKHR = 1000299008,

        /// <summary>
        ///     <c>VideoEncodeSessionParametersGetInfoKHR</c>
        /// </summary>
        VideoEncodeSessionParametersGetInfoKHR = 1000299009,

        /// <summary>
        ///     <c>VideoEncodeSessionParametersFeedbackInfoKHR</c>
        /// </summary>
        VideoEncodeSessionParametersFeedbackInfoKHR = 1000299010,

        /// <summary>
        ///     <c>PhysicalDeviceDiagnosticsConfigFeaturesNV</c>
        /// </summary>
        PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,

        /// <summary>
        ///     <c>DeviceDiagnosticsConfigCreateInfoNV</c>
        /// </summary>
        DeviceDiagnosticsConfigCreateInfoNV = 1000300001,

        /// <summary>
        ///     <c>PerfHintInfoQCOM</c>
        /// </summary>
        PerfHintInfoQCOM = 1000302000,

        /// <summary>
        ///     <c>PhysicalDeviceQueuePerfHintFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceQueuePerfHintFeaturesQCOM = 1000302001,

        /// <summary>
        ///     <c>PhysicalDeviceQueuePerfHintPropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceQueuePerfHintPropertiesQCOM = 1000302002,

        /// <summary>
        ///     <c>PhysicalDeviceImageProcessing3FeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceImageProcessing3FeaturesQCOM = 1000303000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceShaderMultipleWaitQueuesFeaturesQCOM = 1000304000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceShaderMultipleWaitQueuesPropertiesQCOM = 1000304001,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSplitBarrierFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderSplitBarrierFeaturesEXT = 1000305000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSplitBarrierPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceShaderSplitBarrierPropertiesEXT = 1000305001,

        /// <summary>
        ///     <c>CudaModuleCreateInfoNV</c>
        /// </summary>
        CudaModuleCreateInfoNV = 1000307000,

        /// <summary>
        ///     <c>CudaFunctionCreateInfoNV</c>
        /// </summary>
        CudaFunctionCreateInfoNV = 1000307001,

        /// <summary>
        ///     <c>CudaLaunchInfoNV</c>
        /// </summary>
        CudaLaunchInfoNV = 1000307002,

        /// <summary>
        ///     <c>PhysicalDeviceCudaKernelLaunchFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCudaKernelLaunchFeaturesNV = 1000307003,

        /// <summary>
        ///     <c>PhysicalDeviceCudaKernelLaunchPropertiesNV</c>
        /// </summary>
        PhysicalDeviceCudaKernelLaunchPropertiesNV = 1000307004,

        /// <summary>
        ///     <c>PhysicalDeviceTileShadingFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceTileShadingFeaturesQCOM = 1000309000,

        /// <summary>
        ///     <c>PhysicalDeviceTileShadingPropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceTileShadingPropertiesQCOM = 1000309001,

        /// <summary>
        ///     <c>RenderPassTileShadingCreateInfoQCOM</c>
        /// </summary>
        RenderPassTileShadingCreateInfoQCOM = 1000309002,

        /// <summary>
        ///     <c>PerTileBeginInfoQCOM</c>
        /// </summary>
        PerTileBeginInfoQCOM = 1000309003,

        /// <summary>
        ///     <c>PerTileEndInfoQCOM</c>
        /// </summary>
        PerTileEndInfoQCOM = 1000309004,

        /// <summary>
        ///     <c>DispatchTileInfoQCOM</c>
        /// </summary>
        DispatchTileInfoQCOM = 1000309005,

        /// <summary>
        ///     <c>QueryLowLatencySupportNV</c>
        /// </summary>
        QueryLowLatencySupportNV = 1000310000,

        /// <summary>
        ///     <c>ExportMetalObjectCreateInfoEXT</c>
        /// </summary>
        ExportMetalObjectCreateInfoEXT = 1000311000,

        /// <summary>
        ///     <c>ExportMetalObjectsInfoEXT</c>
        /// </summary>
        ExportMetalObjectsInfoEXT = 1000311001,

        /// <summary>
        ///     <c>ExportMetalDeviceInfoEXT</c>
        /// </summary>
        ExportMetalDeviceInfoEXT = 1000311002,

        /// <summary>
        ///     <c>ExportMetalCommandQueueInfoEXT</c>
        /// </summary>
        ExportMetalCommandQueueInfoEXT = 1000311003,

        /// <summary>
        ///     <c>ExportMetalBufferInfoEXT</c>
        /// </summary>
        ExportMetalBufferInfoEXT = 1000311004,

        /// <summary>
        ///     <c>ImportMetalBufferInfoEXT</c>
        /// </summary>
        ImportMetalBufferInfoEXT = 1000311005,

        /// <summary>
        ///     <c>ExportMetalTextureInfoEXT</c>
        /// </summary>
        ExportMetalTextureInfoEXT = 1000311006,

        /// <summary>
        ///     <c>ImportMetalTextureInfoEXT</c>
        /// </summary>
        ImportMetalTextureInfoEXT = 1000311007,

        /// <summary>
        ///     <c>ExportMetalIoSurfaceInfoEXT</c>
        /// </summary>
        ExportMetalIoSurfaceInfoEXT = 1000311008,

        /// <summary>
        ///     <c>ImportMetalIoSurfaceInfoEXT</c>
        /// </summary>
        ImportMetalIoSurfaceInfoEXT = 1000311009,

        /// <summary>
        ///     <c>ExportMetalSharedEventInfoEXT</c>
        /// </summary>
        ExportMetalSharedEventInfoEXT = 1000311010,

        /// <summary>
        ///     <c>ImportMetalSharedEventInfoEXT</c>
        /// </summary>
        ImportMetalSharedEventInfoEXT = 1000311011,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorBufferPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorBufferPropertiesEXT = 1000316000,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT = 1000316001,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorBufferFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorBufferFeaturesEXT = 1000316002,

        /// <summary>
        ///     <c>DescriptorAddressInfoEXT</c>
        /// </summary>
        DescriptorAddressInfoEXT = 1000316003,

        /// <summary>
        ///     <c>DescriptorGetInfoEXT</c>
        /// </summary>
        DescriptorGetInfoEXT = 1000316004,

        /// <summary>
        ///     <c>BufferCaptureDescriptorDataInfoEXT</c>
        /// </summary>
        BufferCaptureDescriptorDataInfoEXT = 1000316005,

        /// <summary>
        ///     <c>ImageCaptureDescriptorDataInfoEXT</c>
        /// </summary>
        ImageCaptureDescriptorDataInfoEXT = 1000316006,

        /// <summary>
        ///     <c>ImageViewCaptureDescriptorDataInfoEXT</c>
        /// </summary>
        ImageViewCaptureDescriptorDataInfoEXT = 1000316007,

        /// <summary>
        ///     <c>SamplerCaptureDescriptorDataInfoEXT</c>
        /// </summary>
        SamplerCaptureDescriptorDataInfoEXT = 1000316008,

        /// <summary>
        ///     <c>OpaqueCaptureDescriptorDataCreateInfoEXT</c>
        /// </summary>
        OpaqueCaptureDescriptorDataCreateInfoEXT = 1000316010,

        /// <summary>
        ///     <c>DescriptorBufferBindingInfoEXT</c>
        /// </summary>
        DescriptorBufferBindingInfoEXT = 1000316011,

        /// <summary>
        ///     <c>DescriptorBufferBindingPushDescriptorBufferHandleEXT</c>
        /// </summary>
        DescriptorBufferBindingPushDescriptorBufferHandleEXT = 1000316012,

        /// <summary>
        ///     <c>AccelerationStructureCaptureDescriptorDataInfoEXT</c>
        /// </summary>
        AccelerationStructureCaptureDescriptorDataInfoEXT = 1000316009,

        /// <summary>
        ///     <c>DeviceMemoryCopyKHR</c>
        /// </summary>
        DeviceMemoryCopyKHR = 1000318000,

        /// <summary>
        ///     <c>CopyDeviceMemoryInfoKHR</c>
        /// </summary>
        CopyDeviceMemoryInfoKHR = 1000318001,

        /// <summary>
        ///     <c>DeviceMemoryImageCopyKHR</c>
        /// </summary>
        DeviceMemoryImageCopyKHR = 1000318002,

        /// <summary>
        ///     <c>CopyDeviceMemoryImageInfoKHR</c>
        /// </summary>
        CopyDeviceMemoryImageInfoKHR = 1000318003,

        /// <summary>
        ///     <c>MemoryRangeBarriersInfoKHR</c>
        /// </summary>
        MemoryRangeBarriersInfoKHR = 1000318004,

        /// <summary>
        ///     <c>MemoryRangeBarrierKHR</c>
        /// </summary>
        MemoryRangeBarrierKHR = 1000318005,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceAddressCommandsFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceDeviceAddressCommandsFeaturesKHR = 1000318006,

        /// <summary>
        ///     <c>BindIndexBuffer3InfoKHR</c>
        /// </summary>
        BindIndexBuffer3InfoKHR = 1000318007,

        /// <summary>
        ///     <c>BindVertexBuffer3InfoKHR</c>
        /// </summary>
        BindVertexBuffer3InfoKHR = 1000318008,

        /// <summary>
        ///     <c>DrawIndirect2InfoKHR</c>
        /// </summary>
        DrawIndirect2InfoKHR = 1000318009,

        /// <summary>
        ///     <c>DrawIndirectCount2InfoKHR</c>
        /// </summary>
        DrawIndirectCount2InfoKHR = 1000318010,

        /// <summary>
        ///     <c>DispatchIndirect2InfoKHR</c>
        /// </summary>
        DispatchIndirect2InfoKHR = 1000318011,

        /// <summary>
        ///     <c>ConditionalRenderingBeginInfo2EXT</c>
        /// </summary>
        ConditionalRenderingBeginInfo2EXT = 1000318012,

        /// <summary>
        ///     <c>BindTransformFeedbackBuffer2InfoEXT</c>
        /// </summary>
        BindTransformFeedbackBuffer2InfoEXT = 1000318013,

        /// <summary>
        ///     <c>MemoryMarkerInfoAMD</c>
        /// </summary>
        MemoryMarkerInfoAMD = 1000318014,

        /// <summary>
        ///     <c>AccelerationStructureCreateInfo2KHR</c>
        /// </summary>
        AccelerationStructureCreateInfo2KHR = 1000318015,

        /// <summary>
        ///     <c>PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT = 1000320000,

        /// <summary>
        ///     <c>PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT = 1000320001,

        /// <summary>
        ///     <c>GraphicsPipelineLibraryCreateInfoEXT</c>
        /// </summary>
        GraphicsPipelineLibraryCreateInfoEXT = 1000320002,

        /// <summary>
        ///     <c>PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD</c>
        /// </summary>
        PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD = 1000321000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShaderBarycentricFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceFragmentShaderBarycentricFeaturesKHR = 1000203000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShaderBarycentricPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceFragmentShaderBarycentricPropertiesKHR = 1000322000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShadingRateEnumsPropertiesNV</c>
        /// </summary>
        PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShadingRateEnumsFeaturesNV</c>
        /// </summary>
        PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,

        /// <summary>
        ///     <c>PipelineFragmentShadingRateEnumStateCreateInfoNV</c>
        /// </summary>
        PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,

        /// <summary>
        ///     <c>AccelerationStructureGeometryMotionTrianglesDataNV</c>
        /// </summary>
        AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingMotionBlurFeaturesNV</c>
        /// </summary>
        PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,

        /// <summary>
        ///     <c>AccelerationStructureMotionInfoNV</c>
        /// </summary>
        AccelerationStructureMotionInfoNV = 1000327002,

        /// <summary>
        ///     <c>PhysicalDeviceMeshShaderFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMeshShaderFeaturesEXT = 1000328000,

        /// <summary>
        ///     <c>PhysicalDeviceMeshShaderPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceMeshShaderPropertiesEXT = 1000328001,

        /// <summary>
        ///     <c>PhysicalDeviceYCbCr2Plane444FormatsFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceYCbCr2Plane444FormatsFeaturesEXT = 1000330000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMap2FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMap2PropertiesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,

        /// <summary>
        ///     <c>CopyCommandTransformInfoQCOM</c>
        /// </summary>
        CopyCommandTransformInfoQCOM = 1000333000,

        /// <summary>
        ///     <c>PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,

        /// <summary>
        ///     <c>PhysicalDeviceImageCompressionControlFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceImageCompressionControlFeaturesEXT = 1000338000,

        /// <summary>
        ///     <c>ImageCompressionControlEXT</c>
        /// </summary>
        ImageCompressionControlEXT = 1000338001,

        /// <summary>
        ///     <c>ImageCompressionPropertiesEXT</c>
        /// </summary>
        ImageCompressionPropertiesEXT = 1000338004,

        /// <summary>
        ///     <c>PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT = 1000339000,

        /// <summary>
        ///     <c>PhysicalDevice4444FormatsFeaturesEXT</c>
        /// </summary>
        PhysicalDevice4444FormatsFeaturesEXT = 1000340000,

        /// <summary>
        ///     <c>PhysicalDeviceFaultFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceFaultFeaturesEXT = 1000341000,

        /// <summary>
        ///     <c>DeviceFaultCountsEXT</c>
        /// </summary>
        DeviceFaultCountsEXT = 1000341001,

        /// <summary>
        ///     <c>DeviceFaultInfoEXT</c>
        /// </summary>
        DeviceFaultInfoEXT = 1000341002,

        /// <summary>
        ///     <c>PhysicalDeviceRgba10X6FormatsFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceRgba10X6FormatsFeaturesEXT = 1000344000,

        /// <summary>
        ///     <c>DirectfbSurfaceCreateInfoEXT</c>
        /// </summary>
        DirectfbSurfaceCreateInfoEXT = 1000346000,

        /// <summary>
        ///     <c>PhysicalDeviceVertexInputDynamicStateFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,

        /// <summary>
        ///     <c>VertexInputBindingDescription2EXT</c>
        /// </summary>
        VertexInputBindingDescription2EXT = 1000352001,

        /// <summary>
        ///     <c>VertexInputAttributeDescription2EXT</c>
        /// </summary>
        VertexInputAttributeDescription2EXT = 1000352002,

        /// <summary>
        ///     <c>PhysicalDeviceDrmPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDrmPropertiesEXT = 1000353000,

        /// <summary>
        ///     <c>PhysicalDeviceAddressBindingReportFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceAddressBindingReportFeaturesEXT = 1000354000,

        /// <summary>
        ///     <c>DeviceAddressBindingCallbackDataEXT</c>
        /// </summary>
        DeviceAddressBindingCallbackDataEXT = 1000354001,

        /// <summary>
        ///     <c>PhysicalDeviceDepthClipControlFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,

        /// <summary>
        ///     <c>PipelineViewportDepthClipControlCreateInfoEXT</c>
        /// </summary>
        PipelineViewportDepthClipControlCreateInfoEXT = 1000355001,

        /// <summary>
        ///     <c>PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,

        /// <summary>
        ///     <c>ImportMemoryZirconHandleInfoFUCHSIA</c>
        /// </summary>
        ImportMemoryZirconHandleInfoFUCHSIA = 1000364000,

        /// <summary>
        ///     <c>MemoryZirconHandlePropertiesFUCHSIA</c>
        /// </summary>
        MemoryZirconHandlePropertiesFUCHSIA = 1000364001,

        /// <summary>
        ///     <c>MemoryGetZirconHandleInfoFUCHSIA</c>
        /// </summary>
        MemoryGetZirconHandleInfoFUCHSIA = 1000364002,

        /// <summary>
        ///     <c>ImportSemaphoreZirconHandleInfoFUCHSIA</c>
        /// </summary>
        ImportSemaphoreZirconHandleInfoFUCHSIA = 1000365000,

        /// <summary>
        ///     <c>SemaphoreGetZirconHandleInfoFUCHSIA</c>
        /// </summary>
        SemaphoreGetZirconHandleInfoFUCHSIA = 1000365001,

        /// <summary>
        ///     <c>BufferCollectionCreateInfoFUCHSIA</c>
        /// </summary>
        BufferCollectionCreateInfoFUCHSIA = 1000366000,

        /// <summary>
        ///     <c>ImportMemoryBufferCollectionFUCHSIA</c>
        /// </summary>
        ImportMemoryBufferCollectionFUCHSIA = 1000366001,

        /// <summary>
        ///     <c>BufferCollectionImageCreateInfoFUCHSIA</c>
        /// </summary>
        BufferCollectionImageCreateInfoFUCHSIA = 1000366002,

        /// <summary>
        ///     <c>BufferCollectionPropertiesFUCHSIA</c>
        /// </summary>
        BufferCollectionPropertiesFUCHSIA = 1000366003,

        /// <summary>
        ///     <c>BufferConstraintsInfoFUCHSIA</c>
        /// </summary>
        BufferConstraintsInfoFUCHSIA = 1000366004,

        /// <summary>
        ///     <c>BufferCollectionBufferCreateInfoFUCHSIA</c>
        /// </summary>
        BufferCollectionBufferCreateInfoFUCHSIA = 1000366005,

        /// <summary>
        ///     <c>ImageConstraintsInfoFUCHSIA</c>
        /// </summary>
        ImageConstraintsInfoFUCHSIA = 1000366006,

        /// <summary>
        ///     <c>ImageFormatConstraintsInfoFUCHSIA</c>
        /// </summary>
        ImageFormatConstraintsInfoFUCHSIA = 1000366007,

        /// <summary>
        ///     <c>SysmemColorSpaceFUCHSIA</c>
        /// </summary>
        SysmemColorSpaceFUCHSIA = 1000366008,

        /// <summary>
        ///     <c>BufferCollectionConstraintsInfoFUCHSIA</c>
        /// </summary>
        BufferCollectionConstraintsInfoFUCHSIA = 1000366009,

        /// <summary>
        ///     <c>SubpassShadingPipelineCreateInfoHUAWEI</c>
        /// </summary>
        SubpassShadingPipelineCreateInfoHUAWEI = 1000369000,

        /// <summary>
        ///     <c>PhysicalDeviceSubpassShadingFeaturesHUAWEI</c>
        /// </summary>
        PhysicalDeviceSubpassShadingFeaturesHUAWEI = 1000369001,

        /// <summary>
        ///     <c>PhysicalDeviceSubpassShadingPropertiesHUAWEI</c>
        /// </summary>
        PhysicalDeviceSubpassShadingPropertiesHUAWEI = 1000369002,

        /// <summary>
        ///     <c>PhysicalDeviceInvocationMaskFeaturesHUAWEI</c>
        /// </summary>
        PhysicalDeviceInvocationMaskFeaturesHUAWEI = 1000370000,

        /// <summary>
        ///     <c>MemoryGetRemoteAddressInfoNV</c>
        /// </summary>
        MemoryGetRemoteAddressInfoNV = 1000371000,

        /// <summary>
        ///     <c>PhysicalDeviceExternalMemoryRdmaFeaturesNV</c>
        /// </summary>
        PhysicalDeviceExternalMemoryRdmaFeaturesNV = 1000371001,

        /// <summary>
        ///     <c>PipelinePropertiesIdentifierEXT</c>
        /// </summary>
        PipelinePropertiesIdentifierEXT = 1000372000,

        /// <summary>
        ///     <c>PhysicalDevicePipelinePropertiesFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePipelinePropertiesFeaturesEXT = 1000372001,

        /// <summary>
        ///     <c>PhysicalDeviceFrameBoundaryFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceFrameBoundaryFeaturesEXT = 1000375000,

        /// <summary>
        ///     <c>FrameBoundaryEXT</c>
        /// </summary>
        FrameBoundaryEXT = 1000375001,

        /// <summary>
        ///     <c>PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT = 1000376000,

        /// <summary>
        ///     <c>SubpassResolvePerformanceQueryEXT</c>
        /// </summary>
        SubpassResolvePerformanceQueryEXT = 1000376001,

        /// <summary>
        ///     <c>MultisampledRenderToSingleSampledInfoEXT</c>
        /// </summary>
        MultisampledRenderToSingleSampledInfoEXT = 1000376002,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedDynamicState2FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,

        /// <summary>
        ///     <c>ScreenSurfaceCreateInfoQNX</c>
        /// </summary>
        ScreenSurfaceCreateInfoQNX = 1000378000,

        /// <summary>
        ///     <c>PhysicalDeviceColorWriteEnableFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,

        /// <summary>
        ///     <c>PipelineColorWriteCreateInfoEXT</c>
        /// </summary>
        PipelineColorWriteCreateInfoEXT = 1000381001,

        /// <summary>
        ///     <c>PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT = 1000382000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingMaintenance1FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceRayTracingMaintenance1FeaturesKHR = 1000386000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderUntypedPointersFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderUntypedPointersFeaturesKHR = 1000387000,

        /// <summary>
        ///     <c>PhysicalDeviceVideoEncodeRGBConversionFeaturesVALVE</c>
        /// </summary>
        PhysicalDeviceVideoEncodeRGBConversionFeaturesVALVE = 1000390000,

        /// <summary>
        ///     <c>VideoEncodeRGBConversionCapabilitiesVALVE</c>
        /// </summary>
        VideoEncodeRGBConversionCapabilitiesVALVE = 1000390001,

        /// <summary>
        ///     <c>VideoEncodeProfileRGBConversionInfoVALVE</c>
        /// </summary>
        VideoEncodeProfileRGBConversionInfoVALVE = 1000390002,

        /// <summary>
        ///     <c>VideoEncodeSessionRGBConversionCreateInfoVALVE</c>
        /// </summary>
        VideoEncodeSessionRGBConversionCreateInfoVALVE = 1000390003,

        /// <summary>
        ///     <c>PhysicalDeviceImageViewMinLodFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,

        /// <summary>
        ///     <c>ImageViewMinLodCreateInfoEXT</c>
        /// </summary>
        ImageViewMinLodCreateInfoEXT = 1000391001,

        /// <summary>
        ///     <c>PhysicalDeviceMultiDrawFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMultiDrawFeaturesEXT = 1000392000,

        /// <summary>
        ///     <c>PhysicalDeviceMultiDrawPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceMultiDrawPropertiesEXT = 1000392001,

        /// <summary>
        ///     <c>PhysicalDeviceImage2DViewOf3DFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceImage2DViewOf3DFeaturesEXT = 1000393000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderTileImageFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderTileImageFeaturesEXT = 1000395000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderTileImagePropertiesEXT</c>
        /// </summary>
        PhysicalDeviceShaderTileImagePropertiesEXT = 1000395001,

        /// <summary>
        ///     <c>MicromapBuildInfoEXT</c>
        /// </summary>
        MicromapBuildInfoEXT = 1000396000,

        /// <summary>
        ///     <c>MicromapVersionInfoEXT</c>
        /// </summary>
        MicromapVersionInfoEXT = 1000396001,

        /// <summary>
        ///     <c>CopyMicromapInfoEXT</c>
        /// </summary>
        CopyMicromapInfoEXT = 1000396002,

        /// <summary>
        ///     <c>CopyMicromapToMemoryInfoEXT</c>
        /// </summary>
        CopyMicromapToMemoryInfoEXT = 1000396003,

        /// <summary>
        ///     <c>CopyMemoryToMicromapInfoEXT</c>
        /// </summary>
        CopyMemoryToMicromapInfoEXT = 1000396004,

        /// <summary>
        ///     <c>PhysicalDeviceOpacityMicromapFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceOpacityMicromapFeaturesEXT = 1000396005,

        /// <summary>
        ///     <c>PhysicalDeviceOpacityMicromapPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceOpacityMicromapPropertiesEXT = 1000396006,

        /// <summary>
        ///     <c>MicromapCreateInfoEXT</c>
        /// </summary>
        MicromapCreateInfoEXT = 1000396007,

        /// <summary>
        ///     <c>MicromapBuildSizesInfoEXT</c>
        /// </summary>
        MicromapBuildSizesInfoEXT = 1000396008,

        /// <summary>
        ///     <c>AccelerationStructureTrianglesOpacityMicromapEXT</c>
        /// </summary>
        AccelerationStructureTrianglesOpacityMicromapEXT = 1000396009,

        /// <summary>
        ///     <c>PhysicalDeviceDisplacementMicromapFeaturesNV</c>
        /// </summary>
        PhysicalDeviceDisplacementMicromapFeaturesNV = 1000397000,

        /// <summary>
        ///     <c>PhysicalDeviceDisplacementMicromapPropertiesNV</c>
        /// </summary>
        PhysicalDeviceDisplacementMicromapPropertiesNV = 1000397001,

        /// <summary>
        ///     <c>AccelerationStructureTrianglesDisplacementMicromapNV</c>
        /// </summary>
        AccelerationStructureTrianglesDisplacementMicromapNV = 1000397002,

        /// <summary>
        ///     <c>PhysicalDeviceClusterCullingShaderFeaturesHUAWEI</c>
        /// </summary>
        PhysicalDeviceClusterCullingShaderFeaturesHUAWEI = 1000404000,

        /// <summary>
        ///     <c>PhysicalDeviceClusterCullingShaderPropertiesHUAWEI</c>
        /// </summary>
        PhysicalDeviceClusterCullingShaderPropertiesHUAWEI = 1000404001,

        /// <summary>
        ///     <c>PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI</c>
        /// </summary>
        PhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI = 1000404002,

        /// <summary>
        ///     <c>PhysicalDeviceBorderColorSwizzleFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,

        /// <summary>
        ///     <c>SamplerBorderColorComponentMappingCreateInfoEXT</c>
        /// </summary>
        SamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,

        /// <summary>
        ///     <c>PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderCorePropertiesARM</c>
        /// </summary>
        PhysicalDeviceShaderCorePropertiesARM = 1000415000,

        /// <summary>
        ///     <c>DeviceQueueShaderCoreControlCreateInfoARM</c>
        /// </summary>
        DeviceQueueShaderCoreControlCreateInfoARM = 1000417000,

        /// <summary>
        ///     <c>PhysicalDeviceSchedulingControlsFeaturesARM</c>
        /// </summary>
        PhysicalDeviceSchedulingControlsFeaturesARM = 1000417001,

        /// <summary>
        ///     <c>PhysicalDeviceSchedulingControlsPropertiesARM</c>
        /// </summary>
        PhysicalDeviceSchedulingControlsPropertiesARM = 1000417002,

        /// <summary>
        ///     <c>DispatchParametersARM</c>
        /// </summary>
        DispatchParametersARM = 1000417003,

        /// <summary>
        ///     <c>PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM</c>
        /// </summary>
        PhysicalDeviceSchedulingControlsDispatchParametersPropertiesARM = 1000417004,

        /// <summary>
        ///     <c>PhysicalDeviceImageSlicedViewOf3DFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceImageSlicedViewOf3DFeaturesEXT = 1000418000,

        /// <summary>
        ///     <c>ImageViewSlicedCreateInfoEXT</c>
        /// </summary>
        ImageViewSlicedCreateInfoEXT = 1000418001,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorSetHostMappingFeaturesVALVE</c>
        /// </summary>
        PhysicalDeviceDescriptorSetHostMappingFeaturesVALVE = 1000420000,

        /// <summary>
        ///     <c>DescriptorSetBindingReferenceVALVE</c>
        /// </summary>
        DescriptorSetBindingReferenceVALVE = 1000420001,

        /// <summary>
        ///     <c>DescriptorSetLayoutHostMappingInfoVALVE</c>
        /// </summary>
        DescriptorSetLayoutHostMappingInfoVALVE = 1000420002,

        /// <summary>
        ///     <c>PhysicalDeviceNonSeamlessCubeMapFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceNonSeamlessCubeMapFeaturesEXT = 1000422000,

        /// <summary>
        ///     <c>PhysicalDeviceRenderPassStripedFeaturesARM</c>
        /// </summary>
        PhysicalDeviceRenderPassStripedFeaturesARM = 1000424000,

        /// <summary>
        ///     <c>PhysicalDeviceRenderPassStripedPropertiesARM</c>
        /// </summary>
        PhysicalDeviceRenderPassStripedPropertiesARM = 1000424001,

        /// <summary>
        ///     <c>RenderPassStripeBeginInfoARM</c>
        /// </summary>
        RenderPassStripeBeginInfoARM = 1000424002,

        /// <summary>
        ///     <c>RenderPassStripeInfoARM</c>
        /// </summary>
        RenderPassStripeInfoARM = 1000424003,

        /// <summary>
        ///     <c>RenderPassStripeSubmitInfoARM</c>
        /// </summary>
        RenderPassStripeSubmitInfoARM = 1000424004,

        /// <summary>
        ///     <c>PhysicalDeviceCopyMemoryIndirectFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCopyMemoryIndirectFeaturesNV = 1000426000,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV</c>
        /// </summary>
        PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV = 1000428000,

        /// <summary>
        ///     <c>ComputePipelineIndirectBufferInfoNV</c>
        /// </summary>
        ComputePipelineIndirectBufferInfoNV = 1000428001,

        /// <summary>
        ///     <c>PipelineIndirectDeviceAddressInfoNV</c>
        /// </summary>
        PipelineIndirectDeviceAddressInfoNV = 1000428002,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV</c>
        /// </summary>
        PhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV = 1000429008,

        /// <summary>
        ///     <c>AccelerationStructureGeometryLinearSweptSpheresDataNV</c>
        /// </summary>
        AccelerationStructureGeometryLinearSweptSpheresDataNV = 1000429009,

        /// <summary>
        ///     <c>AccelerationStructureGeometrySpheresDataNV</c>
        /// </summary>
        AccelerationStructureGeometrySpheresDataNV = 1000429010,

        /// <summary>
        ///     <c>PhysicalDeviceLinearColorAttachmentFeaturesNV</c>
        /// </summary>
        PhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR = 1000434000,

        /// <summary>
        ///     <c>PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT = 1000437000,

        /// <summary>
        ///     <c>PhysicalDeviceImageProcessingFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceImageProcessingFeaturesQCOM = 1000440000,

        /// <summary>
        ///     <c>PhysicalDeviceImageProcessingPropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceImageProcessingPropertiesQCOM = 1000440001,

        /// <summary>
        ///     <c>ImageViewSampleWeightCreateInfoQCOM</c>
        /// </summary>
        ImageViewSampleWeightCreateInfoQCOM = 1000440002,

        /// <summary>
        ///     <c>PhysicalDeviceNestedCommandBufferFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceNestedCommandBufferFeaturesEXT = 1000451000,

        /// <summary>
        ///     <c>PhysicalDeviceNestedCommandBufferPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceNestedCommandBufferPropertiesEXT = 1000451001,

        /// <summary>
        ///     <c>NativeBufferUsageOHOS</c>
        /// </summary>
        NativeBufferUsageOHOS = 1000452000,

        /// <summary>
        ///     <c>NativeBufferPropertiesOHOS</c>
        /// </summary>
        NativeBufferPropertiesOHOS = 1000452001,

        /// <summary>
        ///     <c>NativeBufferFormatPropertiesOHOS</c>
        /// </summary>
        NativeBufferFormatPropertiesOHOS = 1000452002,

        /// <summary>
        ///     <c>ImportNativeBufferInfoOHOS</c>
        /// </summary>
        ImportNativeBufferInfoOHOS = 1000452003,

        /// <summary>
        ///     <c>MemoryGetNativeBufferInfoOHOS</c>
        /// </summary>
        MemoryGetNativeBufferInfoOHOS = 1000452004,

        /// <summary>
        ///     <c>ExternalFormatOHOS</c>
        /// </summary>
        ExternalFormatOHOS = 1000452005,

        /// <summary>
        ///     <c>ExternalMemoryAcquireUnmodifiedEXT</c>
        /// </summary>
        ExternalMemoryAcquireUnmodifiedEXT = 1000453000,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedDynamicState3FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceExtendedDynamicState3FeaturesEXT = 1000455000,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedDynamicState3PropertiesEXT</c>
        /// </summary>
        PhysicalDeviceExtendedDynamicState3PropertiesEXT = 1000455001,

        /// <summary>
        ///     <c>PhysicalDeviceSubpassMergeFeedbackFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceSubpassMergeFeedbackFeaturesEXT = 1000458000,

        /// <summary>
        ///     <c>RenderPassCreationControlEXT</c>
        /// </summary>
        RenderPassCreationControlEXT = 1000458001,

        /// <summary>
        ///     <c>RenderPassCreationFeedbackCreateInfoEXT</c>
        /// </summary>
        RenderPassCreationFeedbackCreateInfoEXT = 1000458002,

        /// <summary>
        ///     <c>RenderPassSubpassFeedbackCreateInfoEXT</c>
        /// </summary>
        RenderPassSubpassFeedbackCreateInfoEXT = 1000458003,

        /// <summary>
        ///     <c>DirectDriverLoadingInfoLUNARG</c>
        /// </summary>
        DirectDriverLoadingInfoLUNARG = 1000459000,

        /// <summary>
        ///     <c>DirectDriverLoadingListLUNARG</c>
        /// </summary>
        DirectDriverLoadingListLUNARG = 1000459001,

        /// <summary>
        ///     <c>TensorCreateInfoARM</c>
        /// </summary>
        TensorCreateInfoARM = 1000460000,

        /// <summary>
        ///     <c>TensorViewCreateInfoARM</c>
        /// </summary>
        TensorViewCreateInfoARM = 1000460001,

        /// <summary>
        ///     <c>BindTensorMemoryInfoARM</c>
        /// </summary>
        BindTensorMemoryInfoARM = 1000460002,

        /// <summary>
        ///     <c>WriteDescriptorSetTensorARM</c>
        /// </summary>
        WriteDescriptorSetTensorARM = 1000460003,

        /// <summary>
        ///     <c>PhysicalDeviceTensorPropertiesARM</c>
        /// </summary>
        PhysicalDeviceTensorPropertiesARM = 1000460004,

        /// <summary>
        ///     <c>TensorFormatPropertiesARM</c>
        /// </summary>
        TensorFormatPropertiesARM = 1000460005,

        /// <summary>
        ///     <c>TensorDescriptionARM</c>
        /// </summary>
        TensorDescriptionARM = 1000460006,

        /// <summary>
        ///     <c>TensorMemoryRequirementsInfoARM</c>
        /// </summary>
        TensorMemoryRequirementsInfoARM = 1000460007,

        /// <summary>
        ///     <c>TensorMemoryBarrierARM</c>
        /// </summary>
        TensorMemoryBarrierARM = 1000460008,

        /// <summary>
        ///     <c>PhysicalDeviceTensorFeaturesARM</c>
        /// </summary>
        PhysicalDeviceTensorFeaturesARM = 1000460009,

        /// <summary>
        ///     <c>DeviceTensorMemoryRequirementsARM</c>
        /// </summary>
        DeviceTensorMemoryRequirementsARM = 1000460010,

        /// <summary>
        ///     <c>CopyTensorInfoARM</c>
        /// </summary>
        CopyTensorInfoARM = 1000460011,

        /// <summary>
        ///     <c>TensorCopyARM</c>
        /// </summary>
        TensorCopyARM = 1000460012,

        /// <summary>
        ///     <c>TensorDependencyInfoARM</c>
        /// </summary>
        TensorDependencyInfoARM = 1000460013,

        /// <summary>
        ///     <c>MemoryDedicatedAllocateInfoTensorARM</c>
        /// </summary>
        MemoryDedicatedAllocateInfoTensorARM = 1000460014,

        /// <summary>
        ///     <c>PhysicalDeviceExternalTensorInfoARM</c>
        /// </summary>
        PhysicalDeviceExternalTensorInfoARM = 1000460015,

        /// <summary>
        ///     <c>ExternalTensorPropertiesARM</c>
        /// </summary>
        ExternalTensorPropertiesARM = 1000460016,

        /// <summary>
        ///     <c>ExternalMemoryTensorCreateInfoARM</c>
        /// </summary>
        ExternalMemoryTensorCreateInfoARM = 1000460017,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorBufferTensorFeaturesARM</c>
        /// </summary>
        PhysicalDeviceDescriptorBufferTensorFeaturesARM = 1000460018,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorBufferTensorPropertiesARM</c>
        /// </summary>
        PhysicalDeviceDescriptorBufferTensorPropertiesARM = 1000460019,

        /// <summary>
        ///     <c>DescriptorGetTensorInfoARM</c>
        /// </summary>
        DescriptorGetTensorInfoARM = 1000460020,

        /// <summary>
        ///     <c>TensorCaptureDescriptorDataInfoARM</c>
        /// </summary>
        TensorCaptureDescriptorDataInfoARM = 1000460021,

        /// <summary>
        ///     <c>TensorViewCaptureDescriptorDataInfoARM</c>
        /// </summary>
        TensorViewCaptureDescriptorDataInfoARM = 1000460022,

        /// <summary>
        ///     <c>FrameBoundaryTensorsARM</c>
        /// </summary>
        FrameBoundaryTensorsARM = 1000460023,

        /// <summary>
        ///     <c>PhysicalDeviceShaderModuleIdentifierFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderModuleIdentifierFeaturesEXT = 1000462000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderModuleIdentifierPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceShaderModuleIdentifierPropertiesEXT = 1000462001,

        /// <summary>
        ///     <c>PipelineShaderStageModuleIdentifierCreateInfoEXT</c>
        /// </summary>
        PipelineShaderStageModuleIdentifierCreateInfoEXT = 1000462002,

        /// <summary>
        ///     <c>ShaderModuleIdentifierEXT</c>
        /// </summary>
        ShaderModuleIdentifierEXT = 1000462003,

        /// <summary>
        ///     <c>PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT = 1000342000,

        /// <summary>
        ///     <c>PhysicalDeviceOpticalFlowFeaturesNV</c>
        /// </summary>
        PhysicalDeviceOpticalFlowFeaturesNV = 1000464000,

        /// <summary>
        ///     <c>PhysicalDeviceOpticalFlowPropertiesNV</c>
        /// </summary>
        PhysicalDeviceOpticalFlowPropertiesNV = 1000464001,

        /// <summary>
        ///     <c>OpticalFlowImageFormatInfoNV</c>
        /// </summary>
        OpticalFlowImageFormatInfoNV = 1000464002,

        /// <summary>
        ///     <c>OpticalFlowImageFormatPropertiesNV</c>
        /// </summary>
        OpticalFlowImageFormatPropertiesNV = 1000464003,

        /// <summary>
        ///     <c>OpticalFlowSessionCreateInfoNV</c>
        /// </summary>
        OpticalFlowSessionCreateInfoNV = 1000464004,

        /// <summary>
        ///     <c>OpticalFlowExecuteInfoNV</c>
        /// </summary>
        OpticalFlowExecuteInfoNV = 1000464005,

        /// <summary>
        ///     <c>OpticalFlowSessionCreatePrivateDataInfoNV</c>
        /// </summary>
        OpticalFlowSessionCreatePrivateDataInfoNV = 1000464010,

        /// <summary>
        ///     <c>PhysicalDeviceLegacyDitheringFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceLegacyDitheringFeaturesEXT = 1000465000,

        /// <summary>
        ///     <c>PhysicalDeviceExternalFormatResolveFeaturesANDROID</c>
        /// </summary>
        PhysicalDeviceExternalFormatResolveFeaturesANDROID = 1000468000,

        /// <summary>
        ///     <c>PhysicalDeviceExternalFormatResolvePropertiesANDROID</c>
        /// </summary>
        PhysicalDeviceExternalFormatResolvePropertiesANDROID = 1000468001,

        /// <summary>
        ///     <c>ANDROIDHardwareBufferFormatResolvePropertiesANDROID</c>
        /// </summary>
        ANDROIDHardwareBufferFormatResolvePropertiesANDROID = 1000468002,

        /// <summary>
        ///     <c>PhysicalDeviceAntiLagFeaturesAMD</c>
        /// </summary>
        PhysicalDeviceAntiLagFeaturesAMD = 1000476000,

        /// <summary>
        ///     <c>AntiLagDataAMD</c>
        /// </summary>
        AntiLagDataAMD = 1000476001,

        /// <summary>
        ///     <c>AntiLagPresentationInfoAMD</c>
        /// </summary>
        AntiLagPresentationInfoAMD = 1000476002,

        /// <summary>
        ///     <c>PhysicalDeviceDenseGeometryFormatFeaturesAMDX</c>
        /// </summary>
        PhysicalDeviceDenseGeometryFormatFeaturesAMDX = 1000478000,

        /// <summary>
        ///     <c>AccelerationStructureDenseGeometryFormatTrianglesDataAMDX</c>
        /// </summary>
        AccelerationStructureDenseGeometryFormatTrianglesDataAMDX = 1000478001,

        /// <summary>
        ///     <c>SurfaceCapabilitiesPresentId2KHR</c>
        /// </summary>
        SurfaceCapabilitiesPresentId2KHR = 1000479000,

        /// <summary>
        ///     <c>PresentId2KHR</c>
        /// </summary>
        PresentId2KHR = 1000479001,

        /// <summary>
        ///     <c>PhysicalDevicePresentId2FeaturesKHR</c>
        /// </summary>
        PhysicalDevicePresentId2FeaturesKHR = 1000479002,

        /// <summary>
        ///     <c>SurfaceCapabilitiesPresentWait2KHR</c>
        /// </summary>
        SurfaceCapabilitiesPresentWait2KHR = 1000480000,

        /// <summary>
        ///     <c>PhysicalDevicePresentWait2FeaturesKHR</c>
        /// </summary>
        PhysicalDevicePresentWait2FeaturesKHR = 1000480001,

        /// <summary>
        ///     <c>PresentWait2InfoKHR</c>
        /// </summary>
        PresentWait2InfoKHR = 1000480002,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingPositionFetchFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceRayTracingPositionFetchFeaturesKHR = 1000481000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderObjectFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderObjectFeaturesEXT = 1000482000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderObjectPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceShaderObjectPropertiesEXT = 1000482001,

        /// <summary>
        ///     <c>ShaderCreateInfoEXT</c>
        /// </summary>
        ShaderCreateInfoEXT = 1000482002,

        /// <summary>
        ///     <c>PhysicalDevicePipelineBinaryFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePipelineBinaryFeaturesKHR = 1000483000,

        /// <summary>
        ///     <c>PipelineBinaryCreateInfoKHR</c>
        /// </summary>
        PipelineBinaryCreateInfoKHR = 1000483001,

        /// <summary>
        ///     <c>PipelineBinaryInfoKHR</c>
        /// </summary>
        PipelineBinaryInfoKHR = 1000483002,

        /// <summary>
        ///     <c>PipelineBinaryKeyKHR</c>
        /// </summary>
        PipelineBinaryKeyKHR = 1000483003,

        /// <summary>
        ///     <c>PhysicalDevicePipelineBinaryPropertiesKHR</c>
        /// </summary>
        PhysicalDevicePipelineBinaryPropertiesKHR = 1000483004,

        /// <summary>
        ///     <c>ReleaseCapturedPipelineDataInfoKHR</c>
        /// </summary>
        ReleaseCapturedPipelineDataInfoKHR = 1000483005,

        /// <summary>
        ///     <c>PipelineBinaryDataInfoKHR</c>
        /// </summary>
        PipelineBinaryDataInfoKHR = 1000483006,

        /// <summary>
        ///     <c>PipelineCreateInfoKHR</c>
        /// </summary>
        PipelineCreateInfoKHR = 1000483007,

        /// <summary>
        ///     <c>DevicePipelineBinaryInternalCacheControlKHR</c>
        /// </summary>
        DevicePipelineBinaryInternalCacheControlKHR = 1000483008,

        /// <summary>
        ///     <c>PipelineBinaryHandlesInfoKHR</c>
        /// </summary>
        PipelineBinaryHandlesInfoKHR = 1000483009,

        /// <summary>
        ///     <c>PhysicalDeviceTilePropertiesFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceTilePropertiesFeaturesQCOM = 1000484000,

        /// <summary>
        ///     <c>TilePropertiesQCOM</c>
        /// </summary>
        TilePropertiesQCOM = 1000484001,

        /// <summary>
        ///     <c>PhysicalDeviceAmigoProfilingFeaturesSEC</c>
        /// </summary>
        PhysicalDeviceAmigoProfilingFeaturesSEC = 1000485000,

        /// <summary>
        ///     <c>AmigoProfilingSubmitInfoSEC</c>
        /// </summary>
        AmigoProfilingSubmitInfoSEC = 1000485001,

        /// <summary>
        ///     <c>SurfacePresentModeKHR</c>
        /// </summary>
        SurfacePresentModeKHR = 1000274000,

        /// <summary>
        ///     <c>SurfacePresentScalingCapabilitiesKHR</c>
        /// </summary>
        SurfacePresentScalingCapabilitiesKHR = 1000274001,

        /// <summary>
        ///     <c>SurfacePresentModeCompatibilityKHR</c>
        /// </summary>
        SurfacePresentModeCompatibilityKHR = 1000274002,

        /// <summary>
        ///     <c>PhysicalDeviceSwapchainMaintenance1FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceSwapchainMaintenance1FeaturesKHR = 1000275000,

        /// <summary>
        ///     <c>SwapchainPresentFenceInfoKHR</c>
        /// </summary>
        SwapchainPresentFenceInfoKHR = 1000275001,

        /// <summary>
        ///     <c>SwapchainPresentModesCreateInfoKHR</c>
        /// </summary>
        SwapchainPresentModesCreateInfoKHR = 1000275002,

        /// <summary>
        ///     <c>SwapchainPresentModeInfoKHR</c>
        /// </summary>
        SwapchainPresentModeInfoKHR = 1000275003,

        /// <summary>
        ///     <c>SwapchainPresentScalingCreateInfoKHR</c>
        /// </summary>
        SwapchainPresentScalingCreateInfoKHR = 1000275004,

        /// <summary>
        ///     <c>ReleaseSwapchainImagesInfoKHR</c>
        /// </summary>
        ReleaseSwapchainImagesInfoKHR = 1000275005,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM = 1000488000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingInvocationReorderFeaturesNV</c>
        /// </summary>
        PhysicalDeviceRayTracingInvocationReorderFeaturesNV = 1000490000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingInvocationReorderPropertiesNV</c>
        /// </summary>
        PhysicalDeviceRayTracingInvocationReorderPropertiesNV = 1000490001,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeVectorFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeVectorFeaturesNV = 1000491000,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeVectorPropertiesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeVectorPropertiesNV = 1000491001,

        /// <summary>
        ///     <c>CooperativeVectorPropertiesNV</c>
        /// </summary>
        CooperativeVectorPropertiesNV = 1000491002,

        /// <summary>
        ///     <c>ConvertCooperativeVectorMatrixInfoNV</c>
        /// </summary>
        ConvertCooperativeVectorMatrixInfoNV = 1000491004,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV</c>
        /// </summary>
        PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV = 1000492000,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedSparseAddressSpacePropertiesNV</c>
        /// </summary>
        PhysicalDeviceExtendedSparseAddressSpacePropertiesNV = 1000492001,

        /// <summary>
        ///     <c>PhysicalDeviceMutableDescriptorTypeFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMutableDescriptorTypeFeaturesEXT = 1000351000,

        /// <summary>
        ///     <c>MutableDescriptorTypeCreateInfoEXT</c>
        /// </summary>
        MutableDescriptorTypeCreateInfoEXT = 1000351002,

        /// <summary>
        ///     <c>PhysicalDeviceLegacyVertexAttributesFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceLegacyVertexAttributesFeaturesEXT = 1000495000,

        /// <summary>
        ///     <c>PhysicalDeviceLegacyVertexAttributesPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceLegacyVertexAttributesPropertiesEXT = 1000495001,

        /// <summary>
        ///     <c>LayerSettingsCreateInfoEXT</c>
        /// </summary>
        LayerSettingsCreateInfoEXT = 1000496000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderCoreBuiltinsFeaturesARM</c>
        /// </summary>
        PhysicalDeviceShaderCoreBuiltinsFeaturesARM = 1000497000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderCoreBuiltinsPropertiesARM</c>
        /// </summary>
        PhysicalDeviceShaderCoreBuiltinsPropertiesARM = 1000497001,

        /// <summary>
        ///     <c>PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT = 1000498000,

        /// <summary>
        ///     <c>PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT = 1000499000,

        /// <summary>
        ///     <c>PhysicalDeviceInternallySynchronizedQueuesFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceInternallySynchronizedQueuesFeaturesKHR = 1000504000,

        /// <summary>
        ///     <c>LatencySleepModeInfoNV</c>
        /// </summary>
        LatencySleepModeInfoNV = 1000505000,

        /// <summary>
        ///     <c>LatencySleepInfoNV</c>
        /// </summary>
        LatencySleepInfoNV = 1000505001,

        /// <summary>
        ///     <c>SetLatencyMarkerInfoNV</c>
        /// </summary>
        SetLatencyMarkerInfoNV = 1000505002,

        /// <summary>
        ///     <c>GetLatencyMarkerInfoNV</c>
        /// </summary>
        GetLatencyMarkerInfoNV = 1000505003,

        /// <summary>
        ///     <c>LatencyTimingsFrameReportNV</c>
        /// </summary>
        LatencyTimingsFrameReportNV = 1000505004,

        /// <summary>
        ///     <c>LatencySubmissionPresentIdNV</c>
        /// </summary>
        LatencySubmissionPresentIdNV = 1000505005,

        /// <summary>
        ///     <c>OutOfBandQueueTypeInfoNV</c>
        /// </summary>
        OutOfBandQueueTypeInfoNV = 1000505006,

        /// <summary>
        ///     <c>SwapchainLatencyCreateInfoNV</c>
        /// </summary>
        SwapchainLatencyCreateInfoNV = 1000505007,

        /// <summary>
        ///     <c>LatencySurfaceCapabilitiesNV</c>
        /// </summary>
        LatencySurfaceCapabilitiesNV = 1000505008,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrixFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrixFeaturesKHR = 1000506000,

        /// <summary>
        ///     <c>CooperativeMatrixPropertiesKHR</c>
        /// </summary>
        CooperativeMatrixPropertiesKHR = 1000506001,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrixPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrixPropertiesKHR = 1000506002,

        /// <summary>
        ///     <c>DataGraphPipelineCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineCreateInfoARM = 1000507000,

        /// <summary>
        ///     <c>DataGraphPipelineSessionCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineSessionCreateInfoARM = 1000507001,

        /// <summary>
        ///     <c>DataGraphPipelineResourceInfoARM</c>
        /// </summary>
        DataGraphPipelineResourceInfoARM = 1000507002,

        /// <summary>
        ///     <c>DataGraphPipelineConstantARM</c>
        /// </summary>
        DataGraphPipelineConstantARM = 1000507003,

        /// <summary>
        ///     <c>DataGraphPipelineSessionMemoryRequirementsInfoARM</c>
        /// </summary>
        DataGraphPipelineSessionMemoryRequirementsInfoARM = 1000507004,

        /// <summary>
        ///     <c>BindDataGraphPipelineSessionMemoryInfoARM</c>
        /// </summary>
        BindDataGraphPipelineSessionMemoryInfoARM = 1000507005,

        /// <summary>
        ///     <c>PhysicalDeviceDataGraphFeaturesARM</c>
        /// </summary>
        PhysicalDeviceDataGraphFeaturesARM = 1000507006,

        /// <summary>
        ///     <c>DataGraphPipelineShaderModuleCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineShaderModuleCreateInfoARM = 1000507007,

        /// <summary>
        ///     <c>DataGraphPipelinePropertyQueryResultARM</c>
        /// </summary>
        DataGraphPipelinePropertyQueryResultARM = 1000507008,

        /// <summary>
        ///     <c>DataGraphPipelineInfoARM</c>
        /// </summary>
        DataGraphPipelineInfoARM = 1000507009,

        /// <summary>
        ///     <c>DataGraphPipelineCompilerControlCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineCompilerControlCreateInfoARM = 1000507010,

        /// <summary>
        ///     <c>DataGraphPipelineSessionBindPointRequirementsInfoARM</c>
        /// </summary>
        DataGraphPipelineSessionBindPointRequirementsInfoARM = 1000507011,

        /// <summary>
        ///     <c>DataGraphPipelineSessionBindPointRequirementARM</c>
        /// </summary>
        DataGraphPipelineSessionBindPointRequirementARM = 1000507012,

        /// <summary>
        ///     <c>DataGraphPipelineIdentifierCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineIdentifierCreateInfoARM = 1000507013,

        /// <summary>
        ///     <c>DataGraphPipelineDispatchInfoARM</c>
        /// </summary>
        DataGraphPipelineDispatchInfoARM = 1000507014,

        /// <summary>
        ///     <c>DataGraphProcessingEngineCreateInfoARM</c>
        /// </summary>
        DataGraphProcessingEngineCreateInfoARM = 1000507016,

        /// <summary>
        ///     <c>QueueFamilyDataGraphProcessingEnginePropertiesARM</c>
        /// </summary>
        QueueFamilyDataGraphProcessingEnginePropertiesARM = 1000507017,

        /// <summary>
        ///     <c>QueueFamilyDataGraphPropertiesARM</c>
        /// </summary>
        QueueFamilyDataGraphPropertiesARM = 1000507018,

        /// <summary>
        ///     <c>PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM</c>
        /// </summary>
        PhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM = 1000507019,

        /// <summary>
        ///     <c>DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM</c>
        /// </summary>
        DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM = 1000507015,

        /// <summary>
        ///     <c>QueueFamilyDataGraphTosaPropertiesARM</c>
        /// </summary>
        QueueFamilyDataGraphTosaPropertiesARM = 1000508000,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM = 1000510000,

        /// <summary>
        ///     <c>MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM</c>
        /// </summary>
        MultiviewPerViewRenderAreasRenderPassBeginInfoQCOM = 1000510001,

        /// <summary>
        ///     <c>PhysicalDeviceComputeShaderDerivativesFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceComputeShaderDerivativesFeaturesKHR = 1000201000,

        /// <summary>
        ///     <c>PhysicalDeviceComputeShaderDerivativesPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceComputeShaderDerivativesPropertiesKHR = 1000511000,

        /// <summary>
        ///     <c>VideoDecodeAV1CapabilitiesKHR</c>
        /// </summary>
        VideoDecodeAV1CapabilitiesKHR = 1000512000,

        /// <summary>
        ///     <c>VideoDecodeAV1PictureInfoKHR</c>
        /// </summary>
        VideoDecodeAV1PictureInfoKHR = 1000512001,

        /// <summary>
        ///     <c>VideoDecodeAV1ProfileInfoKHR</c>
        /// </summary>
        VideoDecodeAV1ProfileInfoKHR = 1000512003,

        /// <summary>
        ///     <c>VideoDecodeAV1SessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoDecodeAV1SessionParametersCreateInfoKHR = 1000512004,

        /// <summary>
        ///     <c>VideoDecodeAV1DpbSlotInfoKHR</c>
        /// </summary>
        VideoDecodeAV1DpbSlotInfoKHR = 1000512005,

        /// <summary>
        ///     <c>VideoEncodeAV1CapabilitiesKHR</c>
        /// </summary>
        VideoEncodeAV1CapabilitiesKHR = 1000513000,

        /// <summary>
        ///     <c>VideoEncodeAV1SessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoEncodeAV1SessionParametersCreateInfoKHR = 1000513001,

        /// <summary>
        ///     <c>VideoEncodeAV1PictureInfoKHR</c>
        /// </summary>
        VideoEncodeAV1PictureInfoKHR = 1000513002,

        /// <summary>
        ///     <c>VideoEncodeAV1DpbSlotInfoKHR</c>
        /// </summary>
        VideoEncodeAV1DpbSlotInfoKHR = 1000513003,

        /// <summary>
        ///     <c>PhysicalDeviceVideoEncodeAV1FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoEncodeAV1FeaturesKHR = 1000513004,

        /// <summary>
        ///     <c>VideoEncodeAV1ProfileInfoKHR</c>
        /// </summary>
        VideoEncodeAV1ProfileInfoKHR = 1000513005,

        /// <summary>
        ///     <c>VideoEncodeAV1RateControlInfoKHR</c>
        /// </summary>
        VideoEncodeAV1RateControlInfoKHR = 1000513006,

        /// <summary>
        ///     <c>VideoEncodeAV1RateControlLayerInfoKHR</c>
        /// </summary>
        VideoEncodeAV1RateControlLayerInfoKHR = 1000513007,

        /// <summary>
        ///     <c>VideoEncodeAV1QualityLevelPropertiesKHR</c>
        /// </summary>
        VideoEncodeAV1QualityLevelPropertiesKHR = 1000513008,

        /// <summary>
        ///     <c>VideoEncodeAV1SessionCreateInfoKHR</c>
        /// </summary>
        VideoEncodeAV1SessionCreateInfoKHR = 1000513009,

        /// <summary>
        ///     <c>VideoEncodeAV1GopRemainingFrameInfoKHR</c>
        /// </summary>
        VideoEncodeAV1GopRemainingFrameInfoKHR = 1000513010,

        /// <summary>
        ///     <c>PhysicalDeviceVideoDecodeVP9FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoDecodeVP9FeaturesKHR = 1000514000,

        /// <summary>
        ///     <c>VideoDecodeVP9CapabilitiesKHR</c>
        /// </summary>
        VideoDecodeVP9CapabilitiesKHR = 1000514001,

        /// <summary>
        ///     <c>VideoDecodeVP9PictureInfoKHR</c>
        /// </summary>
        VideoDecodeVP9PictureInfoKHR = 1000514002,

        /// <summary>
        ///     <c>VideoDecodeVP9ProfileInfoKHR</c>
        /// </summary>
        VideoDecodeVP9ProfileInfoKHR = 1000514003,

        /// <summary>
        ///     <c>PhysicalDeviceVideoMaintenance1FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoMaintenance1FeaturesKHR = 1000515000,

        /// <summary>
        ///     <c>VideoInlineQueryInfoKHR</c>
        /// </summary>
        VideoInlineQueryInfoKHR = 1000515001,

        /// <summary>
        ///     <c>PhysicalDevicePerStageDescriptorSetFeaturesNV</c>
        /// </summary>
        PhysicalDevicePerStageDescriptorSetFeaturesNV = 1000516000,

        /// <summary>
        ///     <c>PhysicalDeviceImageProcessing2FeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceImageProcessing2FeaturesQCOM = 1000518000,

        /// <summary>
        ///     <c>PhysicalDeviceImageProcessing2PropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceImageProcessing2PropertiesQCOM = 1000518001,

        /// <summary>
        ///     <c>SamplerBlockMatchWindowCreateInfoQCOM</c>
        /// </summary>
        SamplerBlockMatchWindowCreateInfoQCOM = 1000518002,

        /// <summary>
        ///     <c>SamplerCubicWeightsCreateInfoQCOM</c>
        /// </summary>
        SamplerCubicWeightsCreateInfoQCOM = 1000519000,

        /// <summary>
        ///     <c>PhysicalDeviceCubicWeightsFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceCubicWeightsFeaturesQCOM = 1000519001,

        /// <summary>
        ///     <c>BlitImageCubicWeightsInfoQCOM</c>
        /// </summary>
        BlitImageCubicWeightsInfoQCOM = 1000519002,

        /// <summary>
        ///     <c>PhysicalDeviceYCbCrDegammaFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceYCbCrDegammaFeaturesQCOM = 1000520000,

        /// <summary>
        ///     <c>SamplerYCbCrConversionYCbCrDegammaCreateInfoQCOM</c>
        /// </summary>
        SamplerYCbCrConversionYCbCrDegammaCreateInfoQCOM = 1000520001,

        /// <summary>
        ///     <c>PhysicalDeviceCubicClampFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceCubicClampFeaturesQCOM = 1000521000,

        /// <summary>
        ///     <c>PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT = 1000524000,

        /// <summary>
        ///     <c>PhysicalDeviceUnifiedImageLayoutsFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceUnifiedImageLayoutsFeaturesKHR = 1000527000,

        /// <summary>
        ///     <c>AttachmentFeedbackLoopInfoEXT</c>
        /// </summary>
        AttachmentFeedbackLoopInfoEXT = 1000527001,

        /// <summary>
        ///     <c>ScreenBufferPropertiesQNX</c>
        /// </summary>
        ScreenBufferPropertiesQNX = 1000529000,

        /// <summary>
        ///     <c>ScreenBufferFormatPropertiesQNX</c>
        /// </summary>
        ScreenBufferFormatPropertiesQNX = 1000529001,

        /// <summary>
        ///     <c>ImportScreenBufferInfoQNX</c>
        /// </summary>
        ImportScreenBufferInfoQNX = 1000529002,

        /// <summary>
        ///     <c>ExternalFormatQNX</c>
        /// </summary>
        ExternalFormatQNX = 1000529003,

        /// <summary>
        ///     <c>PhysicalDeviceExternalMemoryScreenBufferFeaturesQNX</c>
        /// </summary>
        PhysicalDeviceExternalMemoryScreenBufferFeaturesQNX = 1000529004,

        /// <summary>
        ///     <c>PhysicalDeviceLayeredDriverPropertiesMSFT</c>
        /// </summary>
        PhysicalDeviceLayeredDriverPropertiesMSFT = 1000530000,

        /// <summary>
        ///     <c>CalibratedTimestampInfoKHR</c>
        /// </summary>
        CalibratedTimestampInfoKHR = 1000184000,

        /// <summary>
        ///     <c>SetDescriptorBufferOffsetsInfoEXT</c>
        /// </summary>
        SetDescriptorBufferOffsetsInfoEXT = 1000545007,

        /// <summary>
        ///     <c>BindDescriptorBufferEmbeddedSamplersInfoEXT</c>
        /// </summary>
        BindDescriptorBufferEmbeddedSamplersInfoEXT = 1000545008,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorPoolOverallocationFeaturesNV</c>
        /// </summary>
        PhysicalDeviceDescriptorPoolOverallocationFeaturesNV = 1000546000,

        /// <summary>
        ///     <c>PhysicalDeviceTileMemoryHeapFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceTileMemoryHeapFeaturesQCOM = 1000547000,

        /// <summary>
        ///     <c>PhysicalDeviceTileMemoryHeapPropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceTileMemoryHeapPropertiesQCOM = 1000547001,

        /// <summary>
        ///     <c>TileMemoryRequirementsQCOM</c>
        /// </summary>
        TileMemoryRequirementsQCOM = 1000547002,

        /// <summary>
        ///     <c>TileMemoryBindInfoQCOM</c>
        /// </summary>
        TileMemoryBindInfoQCOM = 1000547003,

        /// <summary>
        ///     <c>TileMemorySizeInfoQCOM</c>
        /// </summary>
        TileMemorySizeInfoQCOM = 1000547004,

        /// <summary>
        ///     <c>PhysicalDeviceCopyMemoryIndirectFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceCopyMemoryIndirectFeaturesKHR = 1000549000,

        /// <summary>
        ///     <c>PhysicalDeviceCopyMemoryIndirectPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceCopyMemoryIndirectPropertiesKHR = 1000426001,

        /// <summary>
        ///     <c>CopyMemoryIndirectInfoKHR</c>
        /// </summary>
        CopyMemoryIndirectInfoKHR = 1000549002,

        /// <summary>
        ///     <c>CopyMemoryToImageIndirectInfoKHR</c>
        /// </summary>
        CopyMemoryToImageIndirectInfoKHR = 1000549003,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryDecompressionFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMemoryDecompressionFeaturesEXT = 1000427000,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryDecompressionPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceMemoryDecompressionPropertiesEXT = 1000427001,

        /// <summary>
        ///     <c>DecompressMemoryInfoEXT</c>
        /// </summary>
        DecompressMemoryInfoEXT = 1000550002,

        /// <summary>
        ///     <c>DisplaySurfaceStereoCreateInfoNV</c>
        /// </summary>
        DisplaySurfaceStereoCreateInfoNV = 1000551000,

        /// <summary>
        ///     <c>DisplayModeStereoPropertiesNV</c>
        /// </summary>
        DisplayModeStereoPropertiesNV = 1000551001,

        /// <summary>
        ///     <c>VideoEncodeIntraRefreshCapabilitiesKHR</c>
        /// </summary>
        VideoEncodeIntraRefreshCapabilitiesKHR = 1000552000,

        /// <summary>
        ///     <c>VideoEncodeSessionIntraRefreshCreateInfoKHR</c>
        /// </summary>
        VideoEncodeSessionIntraRefreshCreateInfoKHR = 1000552001,

        /// <summary>
        ///     <c>VideoEncodeIntraRefreshInfoKHR</c>
        /// </summary>
        VideoEncodeIntraRefreshInfoKHR = 1000552002,

        /// <summary>
        ///     <c>VideoReferenceIntraRefreshInfoKHR</c>
        /// </summary>
        VideoReferenceIntraRefreshInfoKHR = 1000552003,

        /// <summary>
        ///     <c>PhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoEncodeIntraRefreshFeaturesKHR = 1000552004,

        /// <summary>
        ///     <c>VideoEncodeQuantizationMapCapabilitiesKHR</c>
        /// </summary>
        VideoEncodeQuantizationMapCapabilitiesKHR = 1000553000,

        /// <summary>
        ///     <c>VideoFormatQuantizationMapPropertiesKHR</c>
        /// </summary>
        VideoFormatQuantizationMapPropertiesKHR = 1000553001,

        /// <summary>
        ///     <c>VideoEncodeQuantizationMapInfoKHR</c>
        /// </summary>
        VideoEncodeQuantizationMapInfoKHR = 1000553002,

        /// <summary>
        ///     <c>VideoEncodeQuantizationMapSessionParametersCreateInfoKHR</c>
        /// </summary>
        VideoEncodeQuantizationMapSessionParametersCreateInfoKHR = 1000553005,

        /// <summary>
        ///     <c>PhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR = 1000553009,

        /// <summary>
        ///     <c>VideoEncodeH264QuantizationMapCapabilitiesKHR</c>
        /// </summary>
        VideoEncodeH264QuantizationMapCapabilitiesKHR = 1000553003,

        /// <summary>
        ///     <c>VideoEncodeH265QuantizationMapCapabilitiesKHR</c>
        /// </summary>
        VideoEncodeH265QuantizationMapCapabilitiesKHR = 1000553004,

        /// <summary>
        ///     <c>VideoFormatH265QuantizationMapPropertiesKHR</c>
        /// </summary>
        VideoFormatH265QuantizationMapPropertiesKHR = 1000553006,

        /// <summary>
        ///     <c>VideoEncodeAV1QuantizationMapCapabilitiesKHR</c>
        /// </summary>
        VideoEncodeAV1QuantizationMapCapabilitiesKHR = 1000553007,

        /// <summary>
        ///     <c>VideoFormatAV1QuantizationMapPropertiesKHR</c>
        /// </summary>
        VideoFormatAV1QuantizationMapPropertiesKHR = 1000553008,

        /// <summary>
        ///     <c>PhysicalDeviceRawAccessChainsFeaturesNV</c>
        /// </summary>
        PhysicalDeviceRawAccessChainsFeaturesNV = 1000555000,

        /// <summary>
        ///     <c>ExternalComputeQueueDeviceCreateInfoNV</c>
        /// </summary>
        ExternalComputeQueueDeviceCreateInfoNV = 1000556000,

        /// <summary>
        ///     <c>ExternalComputeQueueCreateInfoNV</c>
        /// </summary>
        ExternalComputeQueueCreateInfoNV = 1000556001,

        /// <summary>
        ///     <c>ExternalComputeQueueDataParamsNV</c>
        /// </summary>
        ExternalComputeQueueDataParamsNV = 1000556002,

        /// <summary>
        ///     <c>PhysicalDeviceExternalComputeQueuePropertiesNV</c>
        /// </summary>
        PhysicalDeviceExternalComputeQueuePropertiesNV = 1000556003,

        /// <summary>
        ///     <c>PhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR = 1000558000,

        /// <summary>
        ///     <c>PhysicalDeviceCommandBufferInheritanceFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCommandBufferInheritanceFeaturesNV = 1000559000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance7FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance7FeaturesKHR = 1000562000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance7PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance7PropertiesKHR = 1000562001,

        /// <summary>
        ///     <c>PhysicalDeviceLayeredApiPropertiesListKHR</c>
        /// </summary>
        PhysicalDeviceLayeredApiPropertiesListKHR = 1000562002,

        /// <summary>
        ///     <c>PhysicalDeviceLayeredApiPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceLayeredApiPropertiesKHR = 1000562003,

        /// <summary>
        ///     <c>PhysicalDeviceLayeredApiVulkanPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceLayeredApiVulkanPropertiesKHR = 1000562004,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV</c>
        /// </summary>
        PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV = 1000563000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderReplicatedCompositesFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderReplicatedCompositesFeaturesEXT = 1000564000,

        /// <summary>
        ///     <c>TensorExplicitTilingFormatPropertiesARM</c>
        /// </summary>
        TensorExplicitTilingFormatPropertiesARM = 1000565000,

        /// <summary>
        ///     <c>TensorRollingBackingCreateInfoARM</c>
        /// </summary>
        TensorRollingBackingCreateInfoARM = 1000565001,

        /// <summary>
        ///     <c>PhysicalDeviceShaderFloat8FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderFloat8FeaturesEXT = 1000567000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingValidationFeaturesNV</c>
        /// </summary>
        PhysicalDeviceRayTracingValidationFeaturesNV = 1000568000,

        /// <summary>
        ///     <c>PhysicalDeviceClusterAccelerationStructureFeaturesNV</c>
        /// </summary>
        PhysicalDeviceClusterAccelerationStructureFeaturesNV = 1000569000,

        /// <summary>
        ///     <c>PhysicalDeviceClusterAccelerationStructurePropertiesNV</c>
        /// </summary>
        PhysicalDeviceClusterAccelerationStructurePropertiesNV = 1000569001,

        /// <summary>
        ///     <c>ClusterAccelerationStructureClustersBottomLevelInputNV</c>
        /// </summary>
        ClusterAccelerationStructureClustersBottomLevelInputNV = 1000569002,

        /// <summary>
        ///     <c>ClusterAccelerationStructureTriangleClusterInputNV</c>
        /// </summary>
        ClusterAccelerationStructureTriangleClusterInputNV = 1000569003,

        /// <summary>
        ///     <c>ClusterAccelerationStructureMoveObjectsInputNV</c>
        /// </summary>
        ClusterAccelerationStructureMoveObjectsInputNV = 1000569004,

        /// <summary>
        ///     <c>ClusterAccelerationStructureInputInfoNV</c>
        /// </summary>
        ClusterAccelerationStructureInputInfoNV = 1000569005,

        /// <summary>
        ///     <c>ClusterAccelerationStructureCommandsInfoNV</c>
        /// </summary>
        ClusterAccelerationStructureCommandsInfoNV = 1000569006,

        /// <summary>
        ///     <c>RayTracingPipelineClusterAccelerationStructureCreateInfoNV</c>
        /// </summary>
        RayTracingPipelineClusterAccelerationStructureCreateInfoNV = 1000569007,

        /// <summary>
        ///     <c>PhysicalDevicePartitionedAccelerationStructureFeaturesNV</c>
        /// </summary>
        PhysicalDevicePartitionedAccelerationStructureFeaturesNV = 1000570000,

        /// <summary>
        ///     <c>PhysicalDevicePartitionedAccelerationStructurePropertiesNV</c>
        /// </summary>
        PhysicalDevicePartitionedAccelerationStructurePropertiesNV = 1000570001,

        /// <summary>
        ///     <c>WriteDescriptorSetPartitionedAccelerationStructureNV</c>
        /// </summary>
        WriteDescriptorSetPartitionedAccelerationStructureNV = 1000570002,

        /// <summary>
        ///     <c>PartitionedAccelerationStructureInstancesInputNV</c>
        /// </summary>
        PartitionedAccelerationStructureInstancesInputNV = 1000570003,

        /// <summary>
        ///     <c>BuildPartitionedAccelerationStructureInfoNV</c>
        /// </summary>
        BuildPartitionedAccelerationStructureInfoNV = 1000570004,

        /// <summary>
        ///     <c>PartitionedAccelerationStructureFlagsNV</c>
        /// </summary>
        PartitionedAccelerationStructureFlagsNV = 1000570005,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceGeneratedCommandsFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDeviceGeneratedCommandsFeaturesEXT = 1000572000,

        /// <summary>
        ///     <c>PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT = 1000572001,

        /// <summary>
        ///     <c>GeneratedCommandsMemoryRequirementsInfoEXT</c>
        /// </summary>
        GeneratedCommandsMemoryRequirementsInfoEXT = 1000572002,

        /// <summary>
        ///     <c>IndirectExecutionSetCreateInfoEXT</c>
        /// </summary>
        IndirectExecutionSetCreateInfoEXT = 1000572003,

        /// <summary>
        ///     <c>GeneratedCommandsInfoEXT</c>
        /// </summary>
        GeneratedCommandsInfoEXT = 1000572004,

        /// <summary>
        ///     <c>IndirectCommandsLayoutCreateInfoEXT</c>
        /// </summary>
        IndirectCommandsLayoutCreateInfoEXT = 1000572006,

        /// <summary>
        ///     <c>IndirectCommandsLayoutTokenEXT</c>
        /// </summary>
        IndirectCommandsLayoutTokenEXT = 1000572007,

        /// <summary>
        ///     <c>WriteIndirectExecutionSetPipelineEXT</c>
        /// </summary>
        WriteIndirectExecutionSetPipelineEXT = 1000572008,

        /// <summary>
        ///     <c>WriteIndirectExecutionSetShaderEXT</c>
        /// </summary>
        WriteIndirectExecutionSetShaderEXT = 1000572009,

        /// <summary>
        ///     <c>IndirectExecutionSetPipelineInfoEXT</c>
        /// </summary>
        IndirectExecutionSetPipelineInfoEXT = 1000572010,

        /// <summary>
        ///     <c>IndirectExecutionSetShaderInfoEXT</c>
        /// </summary>
        IndirectExecutionSetShaderInfoEXT = 1000572011,

        /// <summary>
        ///     <c>IndirectExecutionSetShaderLayoutInfoEXT</c>
        /// </summary>
        IndirectExecutionSetShaderLayoutInfoEXT = 1000572012,

        /// <summary>
        ///     <c>GeneratedCommandsPipelineInfoEXT</c>
        /// </summary>
        GeneratedCommandsPipelineInfoEXT = 1000572013,

        /// <summary>
        ///     <c>GeneratedCommandsShaderInfoEXT</c>
        /// </summary>
        GeneratedCommandsShaderInfoEXT = 1000572014,

        /// <summary>
        ///     <c>PhysicalDeviceFaultFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceFaultFeaturesKHR = 1000573000,

        /// <summary>
        ///     <c>PhysicalDeviceFaultPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceFaultPropertiesKHR = 1000573001,

        /// <summary>
        ///     <c>DeviceFaultInfoKHR</c>
        /// </summary>
        DeviceFaultInfoKHR = 1000573002,

        /// <summary>
        ///     <c>DeviceFaultDebugInfoKHR</c>
        /// </summary>
        DeviceFaultDebugInfoKHR = 1000573003,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance8FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance8FeaturesKHR = 1000574000,

        /// <summary>
        ///     <c>MemoryBarrierAccessFlags3KHR</c>
        /// </summary>
        MemoryBarrierAccessFlags3KHR = 1000574002,

        /// <summary>
        ///     <c>PhysicalDeviceImageAlignmentControlFeaturesMESA</c>
        /// </summary>
        PhysicalDeviceImageAlignmentControlFeaturesMESA = 1000575000,

        /// <summary>
        ///     <c>PhysicalDeviceImageAlignmentControlPropertiesMESA</c>
        /// </summary>
        PhysicalDeviceImageAlignmentControlPropertiesMESA = 1000575001,

        /// <summary>
        ///     <c>ImageAlignmentControlCreateInfoMESA</c>
        /// </summary>
        ImageAlignmentControlCreateInfoMESA = 1000575002,

        /// <summary>
        ///     <c>PhysicalDeviceShaderFmaFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderFmaFeaturesKHR = 1000579000,

        /// <summary>
        ///     <c>PushConstantBankInfoNV</c>
        /// </summary>
        PushConstantBankInfoNV = 1000580000,

        /// <summary>
        ///     <c>PhysicalDevicePushConstantBankFeaturesNV</c>
        /// </summary>
        PhysicalDevicePushConstantBankFeaturesNV = 1000580001,

        /// <summary>
        ///     <c>PhysicalDevicePushConstantBankPropertiesNV</c>
        /// </summary>
        PhysicalDevicePushConstantBankPropertiesNV = 1000580002,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingInvocationReorderFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceRayTracingInvocationReorderFeaturesEXT = 1000581000,

        /// <summary>
        ///     <c>PhysicalDeviceRayTracingInvocationReorderPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceRayTracingInvocationReorderPropertiesEXT = 1000581001,

        /// <summary>
        ///     <c>PhysicalDeviceDepthClampControlFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDepthClampControlFeaturesEXT = 1000582000,

        /// <summary>
        ///     <c>PipelineViewportDepthClampControlCreateInfoEXT</c>
        /// </summary>
        PipelineViewportDepthClampControlCreateInfoEXT = 1000582001,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance9FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance9FeaturesKHR = 1000584000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance9PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance9PropertiesKHR = 1000584001,

        /// <summary>
        ///     <c>QueueFamilyOwnershipTransferPropertiesKHR</c>
        /// </summary>
        QueueFamilyOwnershipTransferPropertiesKHR = 1000584002,

        /// <summary>
        ///     <c>PhysicalDeviceVideoMaintenance2FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoMaintenance2FeaturesKHR = 1000586000,

        /// <summary>
        ///     <c>VideoDecodeH264InlineSessionParametersInfoKHR</c>
        /// </summary>
        VideoDecodeH264InlineSessionParametersInfoKHR = 1000586001,

        /// <summary>
        ///     <c>VideoDecodeH265InlineSessionParametersInfoKHR</c>
        /// </summary>
        VideoDecodeH265InlineSessionParametersInfoKHR = 1000586002,

        /// <summary>
        ///     <c>VideoDecodeAV1InlineSessionParametersInfoKHR</c>
        /// </summary>
        VideoDecodeAV1InlineSessionParametersInfoKHR = 1000586003,

        /// <summary>
        ///     <c>SurfaceCreateInfoOHOS</c>
        /// </summary>
        SurfaceCreateInfoOHOS = 1000685000,

        /// <summary>
        ///     <c>PhysicalDeviceHdrVividFeaturesHUAWEI</c>
        /// </summary>
        PhysicalDeviceHdrVividFeaturesHUAWEI = 1000590000,

        /// <summary>
        ///     <c>HdrVividDynamicMetadataHUAWEI</c>
        /// </summary>
        HdrVividDynamicMetadataHUAWEI = 1000590001,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrix2FeaturesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrix2FeaturesNV = 1000593000,

        /// <summary>
        ///     <c>CooperativeMatrixFlexibleDimensionsPropertiesNV</c>
        /// </summary>
        CooperativeMatrixFlexibleDimensionsPropertiesNV = 1000593001,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrix2PropertiesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrix2PropertiesNV = 1000593002,

        /// <summary>
        ///     <c>PhysicalDevicePipelineOpacityMicromapFeaturesARM</c>
        /// </summary>
        PhysicalDevicePipelineOpacityMicromapFeaturesARM = 1000596000,

        /// <summary>
        ///     <c>PhysicalDeviceVideoEncodeFeedback2FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVideoEncodeFeedback2FeaturesKHR = 1000598000,

        /// <summary>
        ///     <c>VideoEncodeFeedback2CapabilitiesKHR</c>
        /// </summary>
        VideoEncodeFeedback2CapabilitiesKHR = 1000598001,

        /// <summary>
        ///     <c>QueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR</c>
        /// </summary>
        QueryPoolVideoEncodePerPartitionFeedbackCreateInfoKHR = 1000598002,

        /// <summary>
        ///     <c>ImportMemoryMetalHandleInfoEXT</c>
        /// </summary>
        ImportMemoryMetalHandleInfoEXT = 1000602000,

        /// <summary>
        ///     <c>MemoryMetalHandlePropertiesEXT</c>
        /// </summary>
        MemoryMetalHandlePropertiesEXT = 1000602001,

        /// <summary>
        ///     <c>MemoryGetMetalHandleInfoEXT</c>
        /// </summary>
        MemoryGetMetalHandleInfoEXT = 1000602002,

        /// <summary>
        ///     <c>PhysicalDeviceDepthClampZeroOneFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceDepthClampZeroOneFeaturesKHR = 1000421000,

        /// <summary>
        ///     <c>PhysicalDevicePerformanceCountersByRegionFeaturesARM</c>
        /// </summary>
        PhysicalDevicePerformanceCountersByRegionFeaturesARM = 1000605000,

        /// <summary>
        ///     <c>PhysicalDevicePerformanceCountersByRegionPropertiesARM</c>
        /// </summary>
        PhysicalDevicePerformanceCountersByRegionPropertiesARM = 1000605001,

        /// <summary>
        ///     <c>PerformanceCounterARM</c>
        /// </summary>
        PerformanceCounterARM = 1000605002,

        /// <summary>
        ///     <c>PerformanceCounterDescriptionARM</c>
        /// </summary>
        PerformanceCounterDescriptionARM = 1000605003,

        /// <summary>
        ///     <c>RenderPassPerformanceCountersByRegionBeginInfoARM</c>
        /// </summary>
        RenderPassPerformanceCountersByRegionBeginInfoARM = 1000605004,

        /// <summary>
        ///     <c>PhysicalDeviceShaderInstrumentationFeaturesARM</c>
        /// </summary>
        PhysicalDeviceShaderInstrumentationFeaturesARM = 1000607000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderInstrumentationPropertiesARM</c>
        /// </summary>
        PhysicalDeviceShaderInstrumentationPropertiesARM = 1000607001,

        /// <summary>
        ///     <c>ShaderInstrumentationCreateInfoARM</c>
        /// </summary>
        ShaderInstrumentationCreateInfoARM = 1000607002,

        /// <summary>
        ///     <c>ShaderInstrumentationMetricDescriptionARM</c>
        /// </summary>
        ShaderInstrumentationMetricDescriptionARM = 1000607003,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeRobustnessFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceVertexAttributeRobustnessFeaturesEXT = 1000608000,

        /// <summary>
        ///     <c>PhysicalDeviceFormatPackFeaturesARM</c>
        /// </summary>
        PhysicalDeviceFormatPackFeaturesARM = 1000609000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE = 1000611000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE = 1000611001,

        /// <summary>
        ///     <c>PipelineFragmentDensityMapLayeredCreateInfoVALVE</c>
        /// </summary>
        PipelineFragmentDensityMapLayeredCreateInfoVALVE = 1000611002,

        /// <summary>
        ///     <c>PhysicalDeviceRobustness2FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceRobustness2FeaturesKHR = 1000286000,

        /// <summary>
        ///     <c>PhysicalDeviceRobustness2PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceRobustness2PropertiesKHR = 1000286001,

        /// <summary>
        ///     <c>SetPresentConfigNV</c>
        /// </summary>
        SetPresentConfigNV = 1000613000,

        /// <summary>
        ///     <c>PhysicalDevicePresentMeteringFeaturesNV</c>
        /// </summary>
        PhysicalDevicePresentMeteringFeaturesNV = 1000613001,

        /// <summary>
        ///     <c>PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT = 1000616000,

        /// <summary>
        ///     <c>SwapchainFlagsSurfaceCapabilitiesEXT</c>
        /// </summary>
        SwapchainFlagsSurfaceCapabilitiesEXT = 1000616001,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT = 1000425000,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT = 1000425001,

        /// <summary>
        ///     <c>RenderPassFragmentDensityMapOffsetEndInfoEXT</c>
        /// </summary>
        RenderPassFragmentDensityMapOffsetEndInfoEXT = 1000425002,

        /// <summary>
        ///     <c>PhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT = 1000620000,

        /// <summary>
        ///     <c>PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR</c>
        /// </summary>
        PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR = 1000361000,

        /// <summary>
        ///     <c>PhysicalDeviceOpacityMicromapFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceOpacityMicromapFeaturesKHR = 1000623000,

        /// <summary>
        ///     <c>PhysicalDeviceOpacityMicromapPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceOpacityMicromapPropertiesKHR = 1000623001,

        /// <summary>
        ///     <c>AccelerationStructureGeometryMicromapDataKHR</c>
        /// </summary>
        AccelerationStructureGeometryMicromapDataKHR = 1000623002,

        /// <summary>
        ///     <c>AccelerationStructureTrianglesOpacityMicromapKHR</c>
        /// </summary>
        AccelerationStructureTrianglesOpacityMicromapKHR = 1000623003,

        /// <summary>
        ///     <c>PhysicalDeviceShader64BitIndexingFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShader64BitIndexingFeaturesEXT = 1000627000,

        /// <summary>
        ///     <c>PhysicalDeviceCustomResolveFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceCustomResolveFeaturesEXT = 1000628000,

        /// <summary>
        ///     <c>BeginCustomResolveInfoEXT</c>
        /// </summary>
        BeginCustomResolveInfoEXT = 1000628001,

        /// <summary>
        ///     <c>CustomResolveCreateInfoEXT</c>
        /// </summary>
        CustomResolveCreateInfoEXT = 1000628002,

        /// <summary>
        ///     <c>PhysicalDeviceDataGraphModelFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceDataGraphModelFeaturesQCOM = 1000629000,

        /// <summary>
        ///     <c>DataGraphPipelineBuiltinModelCreateInfoQCOM</c>
        /// </summary>
        DataGraphPipelineBuiltinModelCreateInfoQCOM = 1000629001,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance10FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance10FeaturesKHR = 1000630000,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance10PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance10PropertiesKHR = 1000630001,

        /// <summary>
        ///     <c>RenderingAttachmentFlagsInfoKHR</c>
        /// </summary>
        RenderingAttachmentFlagsInfoKHR = 1000630002,

        /// <summary>
        ///     <c>RenderingEndInfoKHR</c>
        /// </summary>
        RenderingEndInfoKHR = 1000619003,

        /// <summary>
        ///     <c>ResolveImageModeInfoKHR</c>
        /// </summary>
        ResolveImageModeInfoKHR = 1000630004,

        /// <summary>
        ///     <c>PhysicalDeviceDataGraphOpticalFlowFeaturesARM</c>
        /// </summary>
        PhysicalDeviceDataGraphOpticalFlowFeaturesARM = 1000631000,

        /// <summary>
        ///     <c>QueueFamilyDataGraphOpticalFlowPropertiesARM</c>
        /// </summary>
        QueueFamilyDataGraphOpticalFlowPropertiesARM = 1000631001,

        /// <summary>
        ///     <c>DataGraphOpticalFlowImageFormatInfoARM</c>
        /// </summary>
        DataGraphOpticalFlowImageFormatInfoARM = 1000631003,

        /// <summary>
        ///     <c>DataGraphOpticalFlowImageFormatPropertiesARM</c>
        /// </summary>
        DataGraphOpticalFlowImageFormatPropertiesARM = 1000631004,

        /// <summary>
        ///     <c>DataGraphPipelineOpticalFlowDispatchInfoARM</c>
        /// </summary>
        DataGraphPipelineOpticalFlowDispatchInfoARM = 1000631005,

        /// <summary>
        ///     <c>DataGraphPipelineOpticalFlowCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineOpticalFlowCreateInfoARM = 1000631002,

        /// <summary>
        ///     <c>DataGraphPipelineResourceInfoImageLayoutARM</c>
        /// </summary>
        DataGraphPipelineResourceInfoImageLayoutARM = 1000631006,

        /// <summary>
        ///     <c>DataGraphPipelineSingleNodeCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineSingleNodeCreateInfoARM = 1000631007,

        /// <summary>
        ///     <c>DataGraphPipelineSingleNodeConnectionARM</c>
        /// </summary>
        DataGraphPipelineSingleNodeConnectionARM = 1000631008,

        /// <summary>
        ///     <c>PhysicalDeviceShaderLongVectorFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderLongVectorFeaturesEXT = 1000635000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderLongVectorPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceShaderLongVectorPropertiesEXT = 1000635001,

        /// <summary>
        ///     <c>PhysicalDevicePipelineCacheIncrementalModeFeaturesSEC</c>
        /// </summary>
        PhysicalDevicePipelineCacheIncrementalModeFeaturesSEC = 1000637000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderUniformBufferUnsizedArrayFeaturesEXT = 1000642000,

        /// <summary>
        ///     <c>ComputeOccupancyPriorityParametersNV</c>
        /// </summary>
        ComputeOccupancyPriorityParametersNV = 1000645000,

        /// <summary>
        ///     <c>PhysicalDeviceComputeOccupancyPriorityFeaturesNV</c>
        /// </summary>
        PhysicalDeviceComputeOccupancyPriorityFeaturesNV = 1000645001,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance11FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance11FeaturesKHR = 1000657000,

        /// <summary>
        ///     <c>QueueFamilyOptimalImageTransferGranularityPropertiesKHR</c>
        /// </summary>
        QueueFamilyOptimalImageTransferGranularityPropertiesKHR = 1000657001,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT = 1000662000,

        /// <summary>
        ///     <c>UbmSurfaceCreateInfoSEC</c>
        /// </summary>
        UbmSurfaceCreateInfoSEC = 1000664000,

        /// <summary>
        ///     <c>FormatProperties4KHR</c>
        /// </summary>
        FormatProperties4KHR = 1000668000,

        /// <summary>
        ///     <c>ImageCreateFlags2CreateInfoKHR</c>
        /// </summary>
        ImageCreateFlags2CreateInfoKHR = 1000668001,

        /// <summary>
        ///     <c>ImageUsageFlags2CreateInfoKHR</c>
        /// </summary>
        ImageUsageFlags2CreateInfoKHR = 1000668002,

        /// <summary>
        ///     <c>ImageViewUsage2CreateInfoKHR</c>
        /// </summary>
        ImageViewUsage2CreateInfoKHR = 1000668003,

        /// <summary>
        ///     <c>PhysicalDeviceExtendedFlagsFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceExtendedFlagsFeaturesKHR = 1000668004,

        /// <summary>
        ///     <c>ImageStencilUsage2CreateInfoKHR</c>
        /// </summary>
        ImageStencilUsage2CreateInfoKHR = 1000668005,

        /// <summary>
        ///     <c>SharedPresentSurfaceCapabilities2KHR</c>
        /// </summary>
        SharedPresentSurfaceCapabilities2KHR = 1000668006,

        /// <summary>
        ///     <c>PhysicalDeviceShaderOcpMicroscalingTypesFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderOcpMicroscalingTypesFeaturesEXT = 1000672000,

        /// <summary>
        ///     <c>PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE</c>
        /// </summary>
        PhysicalDeviceShaderMixedFloatDotProductFeaturesVALVE = 1000673000,

        /// <summary>
        ///     <c>PhysicalDeviceThrottleHintFeaturesSEC</c>
        /// </summary>
        PhysicalDeviceThrottleHintFeaturesSEC = 1000674000,

        /// <summary>
        ///     <c>ThrottleHintSubmitInfoSEC</c>
        /// </summary>
        ThrottleHintSubmitInfoSEC = 1000674001,

        /// <summary>
        ///     <c>DataGraphPipelineNeuralStatisticsCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineNeuralStatisticsCreateInfoARM = 1000676000,

        /// <summary>
        ///     <c>DataGraphPipelineSessionNeuralStatisticsCreateInfoARM</c>
        /// </summary>
        DataGraphPipelineSessionNeuralStatisticsCreateInfoARM = 1000676001,

        /// <summary>
        ///     <c>PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM</c>
        /// </summary>
        PhysicalDeviceDataGraphNeuralAcceleratorStatisticsFeaturesARM = 1000676002,

        /// <summary>
        ///     <c>PhysicalDevicePrimitiveRestartIndexFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePrimitiveRestartIndexFeaturesEXT = 1000678000,

        /// <summary>
        ///     <c>PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV</c>
        /// </summary>
        PhysicalDeviceCooperativeMatrixDecodeVectorFeaturesNV = 1000689000,

        /// <summary>
        ///     <c>PhysicalDeviceVariablePointerFeatures</c>
        /// </summary>
        PhysicalDeviceVariablePointerFeatures = PhysicalDeviceVariablePointersFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceShaderDrawParameterFeatures</c>
        /// </summary>
        PhysicalDeviceShaderDrawParameterFeatures = PhysicalDeviceShaderDrawParametersFeatures,

        /// <summary>
        ///     <c>DebugReportCreateInfoEXT</c>
        /// </summary>
        DebugReportCreateInfoEXT = DebugReportCallbackCreateInfoEXT,

        /// <summary>
        ///     <c>RenderingInfoKHR</c>
        /// </summary>
        RenderingInfoKHR = RenderingInfo,

        /// <summary>
        ///     <c>RenderingAttachmentInfoKHR</c>
        /// </summary>
        RenderingAttachmentInfoKHR = RenderingAttachmentInfo,

        /// <summary>
        ///     <c>PipelineRenderingCreateInfoKHR</c>
        /// </summary>
        PipelineRenderingCreateInfoKHR = PipelineRenderingCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceDynamicRenderingFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceDynamicRenderingFeaturesKHR = PhysicalDeviceDynamicRenderingFeatures,

        /// <summary>
        ///     <c>CommandBufferInheritanceRenderingInfoKHR</c>
        /// </summary>
        CommandBufferInheritanceRenderingInfoKHR = CommandBufferInheritanceRenderingInfo,

        /// <summary>
        ///     <c>RenderPassMultiviewCreateInfoKHR</c>
        /// </summary>
        RenderPassMultiviewCreateInfoKHR = RenderPassMultiviewCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMultiviewFeaturesKHR = PhysicalDeviceMultiviewFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceMultiviewPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMultiviewPropertiesKHR = PhysicalDeviceMultiviewProperties,

        /// <summary>
        ///     <c>PhysicalDeviceFeatures2KHR</c>
        /// </summary>
        PhysicalDeviceFeatures2KHR = PhysicalDeviceFeatures2,

        /// <summary>
        ///     <c>PhysicalDeviceProperties2KHR</c>
        /// </summary>
        PhysicalDeviceProperties2KHR = PhysicalDeviceProperties2,

        /// <summary>
        ///     <c>FormatProperties2KHR</c>
        /// </summary>
        FormatProperties2KHR = FormatProperties2,

        /// <summary>
        ///     <c>ImageFormatProperties2KHR</c>
        /// </summary>
        ImageFormatProperties2KHR = ImageFormatProperties2,

        /// <summary>
        ///     <c>PhysicalDeviceImageFormatInfo2KHR</c>
        /// </summary>
        PhysicalDeviceImageFormatInfo2KHR = PhysicalDeviceImageFormatInfo2,

        /// <summary>
        ///     <c>QueueFamilyProperties2KHR</c>
        /// </summary>
        QueueFamilyProperties2KHR = QueueFamilyProperties2,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryProperties2KHR</c>
        /// </summary>
        PhysicalDeviceMemoryProperties2KHR = PhysicalDeviceMemoryProperties2,

        /// <summary>
        ///     <c>SparseImageFormatProperties2KHR</c>
        /// </summary>
        SparseImageFormatProperties2KHR = SparseImageFormatProperties2,

        /// <summary>
        ///     <c>PhysicalDeviceSparseImageFormatInfo2KHR</c>
        /// </summary>
        PhysicalDeviceSparseImageFormatInfo2KHR = PhysicalDeviceSparseImageFormatInfo2,

        /// <summary>
        ///     <c>MemoryAllocateFlagsInfoKHR</c>
        /// </summary>
        MemoryAllocateFlagsInfoKHR = MemoryAllocateFlagsInfo,

        /// <summary>
        ///     <c>DeviceGroupRenderPassBeginInfoKHR</c>
        /// </summary>
        DeviceGroupRenderPassBeginInfoKHR = DeviceGroupRenderPassBeginInfo,

        /// <summary>
        ///     <c>DeviceGroupCommandBufferBeginInfoKHR</c>
        /// </summary>
        DeviceGroupCommandBufferBeginInfoKHR = DeviceGroupCommandBufferBeginInfo,

        /// <summary>
        ///     <c>DeviceGroupSubmitInfoKHR</c>
        /// </summary>
        DeviceGroupSubmitInfoKHR = DeviceGroupSubmitInfo,

        /// <summary>
        ///     <c>DeviceGroupBindSparseInfoKHR</c>
        /// </summary>
        DeviceGroupBindSparseInfoKHR = DeviceGroupBindSparseInfo,

        /// <summary>
        ///     <c>BindBufferMemoryDeviceGroupInfoKHR</c>
        /// </summary>
        BindBufferMemoryDeviceGroupInfoKHR = BindBufferMemoryDeviceGroupInfo,

        /// <summary>
        ///     <c>BindImageMemoryDeviceGroupInfoKHR</c>
        /// </summary>
        BindImageMemoryDeviceGroupInfoKHR = BindImageMemoryDeviceGroupInfo,

        /// <summary>
        ///     <c>PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceTextureCompressionAstcHdrFeaturesEXT = PhysicalDeviceTextureCompressionAstcHdrFeatures,

        /// <summary>
        ///     <c>PipelineRobustnessCreateInfoEXT</c>
        /// </summary>
        PipelineRobustnessCreateInfoEXT = PipelineRobustnessCreateInfo,

        /// <summary>
        ///     <c>PhysicalDevicePipelineRobustnessFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePipelineRobustnessFeaturesEXT = PhysicalDevicePipelineRobustnessFeatures,

        /// <summary>
        ///     <c>PhysicalDevicePipelineRobustnessPropertiesEXT</c>
        /// </summary>
        PhysicalDevicePipelineRobustnessPropertiesEXT = PhysicalDevicePipelineRobustnessProperties,

        /// <summary>
        ///     <c>PhysicalDeviceGroupPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceGroupPropertiesKHR = PhysicalDeviceGroupProperties,

        /// <summary>
        ///     <c>DeviceGroupDeviceCreateInfoKHR</c>
        /// </summary>
        DeviceGroupDeviceCreateInfoKHR = DeviceGroupDeviceCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceExternalImageFormatInfoKHR</c>
        /// </summary>
        PhysicalDeviceExternalImageFormatInfoKHR = PhysicalDeviceExternalImageFormatInfo,

        /// <summary>
        ///     <c>ExternalImageFormatPropertiesKHR</c>
        /// </summary>
        ExternalImageFormatPropertiesKHR = ExternalImageFormatProperties,

        /// <summary>
        ///     <c>PhysicalDeviceExternalBufferInfoKHR</c>
        /// </summary>
        PhysicalDeviceExternalBufferInfoKHR = PhysicalDeviceExternalBufferInfo,

        /// <summary>
        ///     <c>ExternalBufferPropertiesKHR</c>
        /// </summary>
        ExternalBufferPropertiesKHR = ExternalBufferProperties,

        /// <summary>
        ///     <c>PhysicalDeviceIdPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceIdPropertiesKHR = PhysicalDeviceIdProperties,

        /// <summary>
        ///     <c>ExternalMemoryBufferCreateInfoKHR</c>
        /// </summary>
        ExternalMemoryBufferCreateInfoKHR = ExternalMemoryBufferCreateInfo,

        /// <summary>
        ///     <c>ExternalMemoryImageCreateInfoKHR</c>
        /// </summary>
        ExternalMemoryImageCreateInfoKHR = ExternalMemoryImageCreateInfo,

        /// <summary>
        ///     <c>ExportMemoryAllocateInfoKHR</c>
        /// </summary>
        ExportMemoryAllocateInfoKHR = ExportMemoryAllocateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceExternalSemaphoreInfoKHR</c>
        /// </summary>
        PhysicalDeviceExternalSemaphoreInfoKHR = PhysicalDeviceExternalSemaphoreInfo,

        /// <summary>
        ///     <c>ExternalSemaphorePropertiesKHR</c>
        /// </summary>
        ExternalSemaphorePropertiesKHR = ExternalSemaphoreProperties,

        /// <summary>
        ///     <c>ExportSemaphoreCreateInfoKHR</c>
        /// </summary>
        ExportSemaphoreCreateInfoKHR = ExportSemaphoreCreateInfo,

        /// <summary>
        ///     <c>PhysicalDevicePushDescriptorPropertiesKHR</c>
        /// </summary>
        PhysicalDevicePushDescriptorPropertiesKHR = PhysicalDevicePushDescriptorProperties,

        /// <summary>
        ///     <c>PhysicalDeviceShaderFloat16Int8FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,

        /// <summary>
        ///     <c>PhysicalDeviceFloat16Int8FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceFloat16Int8FeaturesKHR = PhysicalDeviceShaderFloat16Int8Features,

        /// <summary>
        ///     <c>PhysicalDevice16BitStorageFeaturesKHR</c>
        /// </summary>
        PhysicalDevice16BitStorageFeaturesKHR = PhysicalDevice16BitStorageFeatures,

        /// <summary>
        ///     <c>DescriptorUpdateTemplateCreateInfoKHR</c>
        /// </summary>
        DescriptorUpdateTemplateCreateInfoKHR = DescriptorUpdateTemplateCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceImagelessFramebufferFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceImagelessFramebufferFeaturesKHR = PhysicalDeviceImagelessFramebufferFeatures,

        /// <summary>
        ///     <c>FramebufferAttachmentsCreateInfoKHR</c>
        /// </summary>
        FramebufferAttachmentsCreateInfoKHR = FramebufferAttachmentsCreateInfo,

        /// <summary>
        ///     <c>FramebufferAttachmentImageInfoKHR</c>
        /// </summary>
        FramebufferAttachmentImageInfoKHR = FramebufferAttachmentImageInfo,

        /// <summary>
        ///     <c>RenderPassAttachmentBeginInfoKHR</c>
        /// </summary>
        RenderPassAttachmentBeginInfoKHR = RenderPassAttachmentBeginInfo,

        /// <summary>
        ///     <c>AttachmentDescription2KHR</c>
        /// </summary>
        AttachmentDescription2KHR = AttachmentDescription2,

        /// <summary>
        ///     <c>AttachmentReference2KHR</c>
        /// </summary>
        AttachmentReference2KHR = AttachmentReference2,

        /// <summary>
        ///     <c>SubpassDescription2KHR</c>
        /// </summary>
        SubpassDescription2KHR = SubpassDescription2,

        /// <summary>
        ///     <c>SubpassDependency2KHR</c>
        /// </summary>
        SubpassDependency2KHR = SubpassDependency2,

        /// <summary>
        ///     <c>RenderPassCreateInfo2KHR</c>
        /// </summary>
        RenderPassCreateInfo2KHR = RenderPassCreateInfo2,

        /// <summary>
        ///     <c>SubpassBeginInfoKHR</c>
        /// </summary>
        SubpassBeginInfoKHR = SubpassBeginInfo,

        /// <summary>
        ///     <c>SubpassEndInfoKHR</c>
        /// </summary>
        SubpassEndInfoKHR = SubpassEndInfo,

        /// <summary>
        ///     <c>PhysicalDeviceExternalFenceInfoKHR</c>
        /// </summary>
        PhysicalDeviceExternalFenceInfoKHR = PhysicalDeviceExternalFenceInfo,

        /// <summary>
        ///     <c>ExternalFencePropertiesKHR</c>
        /// </summary>
        ExternalFencePropertiesKHR = ExternalFenceProperties,

        /// <summary>
        ///     <c>ExportFenceCreateInfoKHR</c>
        /// </summary>
        ExportFenceCreateInfoKHR = ExportFenceCreateInfo,

        /// <summary>
        ///     <c>PhysicalDevicePointClippingPropertiesKHR</c>
        /// </summary>
        PhysicalDevicePointClippingPropertiesKHR = PhysicalDevicePointClippingProperties,

        /// <summary>
        ///     <c>RenderPassInputAttachmentAspectCreateInfoKHR</c>
        /// </summary>
        RenderPassInputAttachmentAspectCreateInfoKHR = RenderPassInputAttachmentAspectCreateInfo,

        /// <summary>
        ///     <c>ImageViewUsageCreateInfoKHR</c>
        /// </summary>
        ImageViewUsageCreateInfoKHR = ImageViewUsageCreateInfo,

        /// <summary>
        ///     <c>PipelineTessellationDomainOriginStateCreateInfoKHR</c>
        /// </summary>
        PipelineTessellationDomainOriginStateCreateInfoKHR = PipelineTessellationDomainOriginStateCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceVariablePointersFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVariablePointersFeaturesKHR = PhysicalDeviceVariablePointersFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceVariablePointerFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVariablePointerFeaturesKHR = PhysicalDeviceVariablePointersFeaturesKHR,

        /// <summary>
        ///     <c>MemoryDedicatedRequirementsKHR</c>
        /// </summary>
        MemoryDedicatedRequirementsKHR = MemoryDedicatedRequirements,

        /// <summary>
        ///     <c>MemoryDedicatedAllocateInfoKHR</c>
        /// </summary>
        MemoryDedicatedAllocateInfoKHR = MemoryDedicatedAllocateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceSamplerFilterMinmaxPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceSamplerFilterMinmaxPropertiesEXT = PhysicalDeviceSamplerFilterMinmaxProperties,

        /// <summary>
        ///     <c>SamplerReductionModeCreateInfoEXT</c>
        /// </summary>
        SamplerReductionModeCreateInfoEXT = SamplerReductionModeCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceInlineUniformBlockFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceInlineUniformBlockFeaturesEXT = PhysicalDeviceInlineUniformBlockFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceInlineUniformBlockPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceInlineUniformBlockPropertiesEXT = PhysicalDeviceInlineUniformBlockProperties,

        /// <summary>
        ///     <c>WriteDescriptorSetInlineUniformBlockEXT</c>
        /// </summary>
        WriteDescriptorSetInlineUniformBlockEXT = WriteDescriptorSetInlineUniformBlock,

        /// <summary>
        ///     <c>DescriptorPoolInlineUniformBlockCreateInfoEXT</c>
        /// </summary>
        DescriptorPoolInlineUniformBlockCreateInfoEXT = DescriptorPoolInlineUniformBlockCreateInfo,

        /// <summary>
        ///     <c>BufferMemoryRequirementsInfo2KHR</c>
        /// </summary>
        BufferMemoryRequirementsInfo2KHR = BufferMemoryRequirementsInfo2,

        /// <summary>
        ///     <c>ImageMemoryRequirementsInfo2KHR</c>
        /// </summary>
        ImageMemoryRequirementsInfo2KHR = ImageMemoryRequirementsInfo2,

        /// <summary>
        ///     <c>ImageSparseMemoryRequirementsInfo2KHR</c>
        /// </summary>
        ImageSparseMemoryRequirementsInfo2KHR = ImageSparseMemoryRequirementsInfo2,

        /// <summary>
        ///     <c>MemoryRequirements2KHR</c>
        /// </summary>
        MemoryRequirements2KHR = MemoryRequirements2,

        /// <summary>
        ///     <c>SparseImageMemoryRequirements2KHR</c>
        /// </summary>
        SparseImageMemoryRequirements2KHR = SparseImageMemoryRequirements2,

        /// <summary>
        ///     <c>ImageFormatListCreateInfoKHR</c>
        /// </summary>
        ImageFormatListCreateInfoKHR = ImageFormatListCreateInfo,

        /// <summary>
        ///     <c>AttachmentSampleCountInfoNV</c>
        /// </summary>
        AttachmentSampleCountInfoNV = AttachmentSampleCountInfoAMD,

        /// <summary>
        ///     <c>SamplerYCbCrConversionCreateInfoKHR</c>
        /// </summary>
        SamplerYCbCrConversionCreateInfoKHR = SamplerYCbCrConversionCreateInfo,

        /// <summary>
        ///     <c>SamplerYCbCrConversionInfoKHR</c>
        /// </summary>
        SamplerYCbCrConversionInfoKHR = SamplerYCbCrConversionInfo,

        /// <summary>
        ///     <c>BindImagePlaneMemoryInfoKHR</c>
        /// </summary>
        BindImagePlaneMemoryInfoKHR = BindImagePlaneMemoryInfo,

        /// <summary>
        ///     <c>ImagePlaneMemoryRequirementsInfoKHR</c>
        /// </summary>
        ImagePlaneMemoryRequirementsInfoKHR = ImagePlaneMemoryRequirementsInfo,

        /// <summary>
        ///     <c>PhysicalDeviceSamplerYCbCrConversionFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceSamplerYCbCrConversionFeaturesKHR = PhysicalDeviceSamplerYCbCrConversionFeatures,

        /// <summary>
        ///     <c>SamplerYCbCrConversionImageFormatPropertiesKHR</c>
        /// </summary>
        SamplerYCbCrConversionImageFormatPropertiesKHR = SamplerYCbCrConversionImageFormatProperties,

        /// <summary>
        ///     <c>BindBufferMemoryInfoKHR</c>
        /// </summary>
        BindBufferMemoryInfoKHR = BindBufferMemoryInfo,

        /// <summary>
        ///     <c>BindImageMemoryInfoKHR</c>
        /// </summary>
        BindImageMemoryInfoKHR = BindImageMemoryInfo,

        /// <summary>
        ///     <c>DescriptorSetLayoutBindingFlagsCreateInfoEXT</c>
        /// </summary>
        DescriptorSetLayoutBindingFlagsCreateInfoEXT = DescriptorSetLayoutBindingFlagsCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorIndexingFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorIndexingFeaturesEXT = PhysicalDeviceDescriptorIndexingFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceDescriptorIndexingPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceDescriptorIndexingPropertiesEXT = PhysicalDeviceDescriptorIndexingProperties,

        /// <summary>
        ///     <c>DescriptorSetVariableDescriptorCountAllocateInfoEXT</c>
        /// </summary>
        DescriptorSetVariableDescriptorCountAllocateInfoEXT = DescriptorSetVariableDescriptorCountAllocateInfo,

        /// <summary>
        ///     <c>DescriptorSetVariableDescriptorCountLayoutSupportEXT</c>
        /// </summary>
        DescriptorSetVariableDescriptorCountLayoutSupportEXT = DescriptorSetVariableDescriptorCountLayoutSupport,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance3PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance3PropertiesKHR = PhysicalDeviceMaintenance3Properties,

        /// <summary>
        ///     <c>DescriptorSetLayoutSupportKHR</c>
        /// </summary>
        DescriptorSetLayoutSupportKHR = DescriptorSetLayoutSupport,

        /// <summary>
        ///     <c>DeviceQueueGlobalPriorityCreateInfoEXT</c>
        /// </summary>
        DeviceQueueGlobalPriorityCreateInfoEXT = DeviceQueueGlobalPriorityCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR = PhysicalDeviceShaderSubgroupExtendedTypesFeatures,

        /// <summary>
        ///     <c>PhysicalDevice8BitStorageFeaturesKHR</c>
        /// </summary>
        PhysicalDevice8BitStorageFeaturesKHR = PhysicalDevice8BitStorageFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceShaderAtomicInt64FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderAtomicInt64FeaturesKHR = PhysicalDeviceShaderAtomicInt64Features,

        /// <summary>
        ///     <c>CalibratedTimestampInfoEXT</c>
        /// </summary>
        CalibratedTimestampInfoEXT = CalibratedTimestampInfoKHR,

        /// <summary>
        ///     <c>DeviceQueueGlobalPriorityCreateInfoKHR</c>
        /// </summary>
        DeviceQueueGlobalPriorityCreateInfoKHR = DeviceQueueGlobalPriorityCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceGlobalPriorityQueryFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceGlobalPriorityQueryFeaturesKHR = PhysicalDeviceGlobalPriorityQueryFeatures,

        /// <summary>
        ///     <c>QueueFamilyGlobalPriorityPropertiesKHR</c>
        /// </summary>
        QueueFamilyGlobalPriorityPropertiesKHR = QueueFamilyGlobalPriorityProperties,

        /// <summary>
        ///     <c>PipelineVertexInputDivisorStateCreateInfoEXT</c>
        /// </summary>
        PipelineVertexInputDivisorStateCreateInfoEXT = PipelineVertexInputDivisorStateCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeDivisorFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorFeaturesEXT = PhysicalDeviceVertexAttributeDivisorFeatures,

        /// <summary>
        ///     <c>PipelineCreationFeedbackCreateInfoEXT</c>
        /// </summary>
        PipelineCreationFeedbackCreateInfoEXT = PipelineCreationFeedbackCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceDriverPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceDriverPropertiesKHR = PhysicalDeviceDriverProperties,

        /// <summary>
        ///     <c>PhysicalDeviceFloatControlsPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceFloatControlsPropertiesKHR = PhysicalDeviceFloatControlsProperties,

        /// <summary>
        ///     <c>PhysicalDeviceDepthStencilResolvePropertiesKHR</c>
        /// </summary>
        PhysicalDeviceDepthStencilResolvePropertiesKHR = PhysicalDeviceDepthStencilResolveProperties,

        /// <summary>
        ///     <c>SubpassDescriptionDepthStencilResolveKHR</c>
        /// </summary>
        SubpassDescriptionDepthStencilResolveKHR = SubpassDescriptionDepthStencilResolve,

        /// <summary>
        ///     <c>PhysicalDeviceComputeShaderDerivativesFeaturesNV</c>
        /// </summary>
        PhysicalDeviceComputeShaderDerivativesFeaturesNV = PhysicalDeviceComputeShaderDerivativesFeaturesKHR,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentShaderBarycentricFeaturesNV</c>
        /// </summary>
        PhysicalDeviceFragmentShaderBarycentricFeaturesNV = PhysicalDeviceFragmentShaderBarycentricFeaturesKHR,

        /// <summary>
        ///     <c>PhysicalDeviceTimelineSemaphoreFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceTimelineSemaphoreFeaturesKHR = PhysicalDeviceTimelineSemaphoreFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceTimelineSemaphorePropertiesKHR</c>
        /// </summary>
        PhysicalDeviceTimelineSemaphorePropertiesKHR = PhysicalDeviceTimelineSemaphoreProperties,

        /// <summary>
        ///     <c>SemaphoreTypeCreateInfoKHR</c>
        /// </summary>
        SemaphoreTypeCreateInfoKHR = SemaphoreTypeCreateInfo,

        /// <summary>
        ///     <c>TimelineSemaphoreSubmitInfoKHR</c>
        /// </summary>
        TimelineSemaphoreSubmitInfoKHR = TimelineSemaphoreSubmitInfo,

        /// <summary>
        ///     <c>SemaphoreWaitInfoKHR</c>
        /// </summary>
        SemaphoreWaitInfoKHR = SemaphoreWaitInfo,

        /// <summary>
        ///     <c>SemaphoreSignalInfoKHR</c>
        /// </summary>
        SemaphoreSignalInfoKHR = SemaphoreSignalInfo,

        /// <summary>
        ///     <c>QueryPoolCreateInfoINTEL</c>
        /// </summary>
        QueryPoolCreateInfoINTEL = QueryPoolPerformanceQueryCreateInfoINTEL,

        /// <summary>
        ///     <c>PhysicalDeviceVulkanMemoryModelFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVulkanMemoryModelFeaturesKHR = PhysicalDeviceVulkanMemoryModelFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceShaderTerminateInvocationFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderTerminateInvocationFeaturesKHR = PhysicalDeviceShaderTerminateInvocationFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceScalarBlockLayoutFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceScalarBlockLayoutFeaturesEXT = PhysicalDeviceScalarBlockLayoutFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceSubgroupSizeControlPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceSubgroupSizeControlPropertiesEXT = PhysicalDeviceSubgroupSizeControlProperties,

        /// <summary>
        ///     <c>PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT</c>
        /// </summary>
        PipelineShaderStageRequiredSubgroupSizeCreateInfoEXT = PipelineShaderStageRequiredSubgroupSizeCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceSubgroupSizeControlFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceSubgroupSizeControlFeaturesEXT = PhysicalDeviceSubgroupSizeControlFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceDynamicRenderingLocalReadFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceDynamicRenderingLocalReadFeaturesKHR = PhysicalDeviceDynamicRenderingLocalReadFeatures,

        /// <summary>
        ///     <c>RenderingAttachmentLocationInfoKHR</c>
        /// </summary>
        RenderingAttachmentLocationInfoKHR = RenderingAttachmentLocationInfo,

        /// <summary>
        ///     <c>RenderingInputAttachmentIndexInfoKHR</c>
        /// </summary>
        RenderingInputAttachmentIndexInfoKHR = RenderingInputAttachmentIndexInfo,

        /// <summary>
        ///     <c>PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR = PhysicalDeviceSeparateDepthStencilLayoutsFeatures,

        /// <summary>
        ///     <c>AttachmentReferenceStencilLayoutKHR</c>
        /// </summary>
        AttachmentReferenceStencilLayoutKHR = AttachmentReferenceStencilLayout,

        /// <summary>
        ///     <c>AttachmentDescriptionStencilLayoutKHR</c>
        /// </summary>
        AttachmentDescriptionStencilLayoutKHR = AttachmentDescriptionStencilLayout,

        /// <summary>
        ///     <c>PhysicalDeviceBufferAddressFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceBufferAddressFeaturesEXT = PhysicalDeviceBufferDeviceAddressFeaturesEXT,

        /// <summary>
        ///     <c>BufferDeviceAddressInfoEXT</c>
        /// </summary>
        BufferDeviceAddressInfoEXT = BufferDeviceAddressInfo,

        /// <summary>
        ///     <c>PhysicalDeviceToolPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceToolPropertiesEXT = PhysicalDeviceToolProperties,

        /// <summary>
        ///     <c>ImageStencilUsageCreateInfoEXT</c>
        /// </summary>
        ImageStencilUsageCreateInfoEXT = ImageStencilUsageCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceUniformBufferStandardLayoutFeaturesKHR = PhysicalDeviceUniformBufferStandardLayoutFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceBufferDeviceAddressFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceBufferDeviceAddressFeaturesKHR = PhysicalDeviceBufferDeviceAddressFeatures,

        /// <summary>
        ///     <c>BufferDeviceAddressInfoKHR</c>
        /// </summary>
        BufferDeviceAddressInfoKHR = BufferDeviceAddressInfo,

        /// <summary>
        ///     <c>BufferOpaqueCaptureAddressCreateInfoKHR</c>
        /// </summary>
        BufferOpaqueCaptureAddressCreateInfoKHR = BufferOpaqueCaptureAddressCreateInfo,

        /// <summary>
        ///     <c>MemoryOpaqueCaptureAddressAllocateInfoKHR</c>
        /// </summary>
        MemoryOpaqueCaptureAddressAllocateInfoKHR = MemoryOpaqueCaptureAddressAllocateInfo,

        /// <summary>
        ///     <c>DeviceMemoryOpaqueCaptureAddressInfoKHR</c>
        /// </summary>
        DeviceMemoryOpaqueCaptureAddressInfoKHR = DeviceMemoryOpaqueCaptureAddressInfo,

        /// <summary>
        ///     <c>PhysicalDeviceLineRasterizationFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceLineRasterizationFeaturesEXT = PhysicalDeviceLineRasterizationFeatures,

        /// <summary>
        ///     <c>PipelineRasterizationLineStateCreateInfoEXT</c>
        /// </summary>
        PipelineRasterizationLineStateCreateInfoEXT = PipelineRasterizationLineStateCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceLineRasterizationPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceLineRasterizationPropertiesEXT = PhysicalDeviceLineRasterizationProperties,

        /// <summary>
        ///     <c>PhysicalDeviceHostQueryResetFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceHostQueryResetFeaturesEXT = PhysicalDeviceHostQueryResetFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceIndexTypeUInt8FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceIndexTypeUInt8FeaturesEXT = PhysicalDeviceIndexTypeUInt8Features,

        /// <summary>
        ///     <c>PhysicalDeviceHostImageCopyFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceHostImageCopyFeaturesEXT = PhysicalDeviceHostImageCopyFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceHostImageCopyPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceHostImageCopyPropertiesEXT = PhysicalDeviceHostImageCopyProperties,

        /// <summary>
        ///     <c>MemoryToImageCopyEXT</c>
        /// </summary>
        MemoryToImageCopyEXT = MemoryToImageCopy,

        /// <summary>
        ///     <c>ImageToMemoryCopyEXT</c>
        /// </summary>
        ImageToMemoryCopyEXT = ImageToMemoryCopy,

        /// <summary>
        ///     <c>CopyImageToMemoryInfoEXT</c>
        /// </summary>
        CopyImageToMemoryInfoEXT = CopyImageToMemoryInfo,

        /// <summary>
        ///     <c>CopyMemoryToImageInfoEXT</c>
        /// </summary>
        CopyMemoryToImageInfoEXT = CopyMemoryToImageInfo,

        /// <summary>
        ///     <c>HostImageLayoutTransitionInfoEXT</c>
        /// </summary>
        HostImageLayoutTransitionInfoEXT = HostImageLayoutTransitionInfo,

        /// <summary>
        ///     <c>CopyImageToImageInfoEXT</c>
        /// </summary>
        CopyImageToImageInfoEXT = CopyImageToImageInfo,

        /// <summary>
        ///     <c>SubresourceHostMemcpySizeEXT</c>
        /// </summary>
        SubresourceHostMemcpySizeEXT = SubresourceHostMemcpySize,

        /// <summary>
        ///     <c>HostImageCopyDevicePerformanceQueryEXT</c>
        /// </summary>
        HostImageCopyDevicePerformanceQueryEXT = HostImageCopyDevicePerformanceQuery,

        /// <summary>
        ///     <c>MemoryMapInfoKHR</c>
        /// </summary>
        MemoryMapInfoKHR = MemoryMapInfo,

        /// <summary>
        ///     <c>MemoryUnmapInfoKHR</c>
        /// </summary>
        MemoryUnmapInfoKHR = MemoryUnmapInfo,

        /// <summary>
        ///     <c>SurfacePresentModeEXT</c>
        /// </summary>
        SurfacePresentModeEXT = SurfacePresentModeKHR,

        /// <summary>
        ///     <c>SurfacePresentScalingCapabilitiesEXT</c>
        /// </summary>
        SurfacePresentScalingCapabilitiesEXT = SurfacePresentScalingCapabilitiesKHR,

        /// <summary>
        ///     <c>SurfacePresentModeCompatibilityEXT</c>
        /// </summary>
        SurfacePresentModeCompatibilityEXT = SurfacePresentModeCompatibilityKHR,

        /// <summary>
        ///     <c>PhysicalDeviceSwapchainMaintenance1FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceSwapchainMaintenance1FeaturesEXT = PhysicalDeviceSwapchainMaintenance1FeaturesKHR,

        /// <summary>
        ///     <c>SwapchainPresentFenceInfoEXT</c>
        /// </summary>
        SwapchainPresentFenceInfoEXT = SwapchainPresentFenceInfoKHR,

        /// <summary>
        ///     <c>SwapchainPresentModesCreateInfoEXT</c>
        /// </summary>
        SwapchainPresentModesCreateInfoEXT = SwapchainPresentModesCreateInfoKHR,

        /// <summary>
        ///     <c>SwapchainPresentModeInfoEXT</c>
        /// </summary>
        SwapchainPresentModeInfoEXT = SwapchainPresentModeInfoKHR,

        /// <summary>
        ///     <c>SwapchainPresentScalingCreateInfoEXT</c>
        /// </summary>
        SwapchainPresentScalingCreateInfoEXT = SwapchainPresentScalingCreateInfoKHR,

        /// <summary>
        ///     <c>ReleaseSwapchainImagesInfoEXT</c>
        /// </summary>
        ReleaseSwapchainImagesInfoEXT = ReleaseSwapchainImagesInfoKHR,

        /// <summary>
        ///     <c>PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT = PhysicalDeviceShaderDemoteToHelperInvocationFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceShaderIntegerDotProductFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderIntegerDotProductFeaturesKHR = PhysicalDeviceShaderIntegerDotProductFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceShaderIntegerDotProductPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceShaderIntegerDotProductPropertiesKHR = PhysicalDeviceShaderIntegerDotProductProperties,

        /// <summary>
        ///     <c>PhysicalDeviceTexelBufferAlignmentPropertiesEXT</c>
        /// </summary>
        PhysicalDeviceTexelBufferAlignmentPropertiesEXT = PhysicalDeviceTexelBufferAlignmentProperties,

        /// <summary>
        ///     <c>PhysicalDeviceRobustness2FeaturesEXT</c>
        /// </summary>
        PhysicalDeviceRobustness2FeaturesEXT = PhysicalDeviceRobustness2FeaturesKHR,

        /// <summary>
        ///     <c>PhysicalDeviceRobustness2PropertiesEXT</c>
        /// </summary>
        PhysicalDeviceRobustness2PropertiesEXT = PhysicalDeviceRobustness2PropertiesKHR,

        /// <summary>
        ///     <c>PhysicalDevicePrivateDataFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePrivateDataFeaturesEXT = PhysicalDevicePrivateDataFeatures,

        /// <summary>
        ///     <c>DevicePrivateDataCreateInfoEXT</c>
        /// </summary>
        DevicePrivateDataCreateInfoEXT = DevicePrivateDataCreateInfo,

        /// <summary>
        ///     <c>PrivateDataSlotCreateInfoEXT</c>
        /// </summary>
        PrivateDataSlotCreateInfoEXT = PrivateDataSlotCreateInfo,

        /// <summary>
        ///     <c>PhysicalDevicePipelineCreationCacheControlFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePipelineCreationCacheControlFeaturesEXT = PhysicalDevicePipelineCreationCacheControlFeatures,

        /// <summary>
        ///     <c>MemoryBarrier2KHR</c>
        /// </summary>
        MemoryBarrier2KHR = MemoryBarrier2,

        /// <summary>
        ///     <c>BufferMemoryBarrier2KHR</c>
        /// </summary>
        BufferMemoryBarrier2KHR = BufferMemoryBarrier2,

        /// <summary>
        ///     <c>ImageMemoryBarrier2KHR</c>
        /// </summary>
        ImageMemoryBarrier2KHR = ImageMemoryBarrier2,

        /// <summary>
        ///     <c>DependencyInfoKHR</c>
        /// </summary>
        DependencyInfoKHR = DependencyInfo,

        /// <summary>
        ///     <c>SubmitInfo2KHR</c>
        /// </summary>
        SubmitInfo2KHR = SubmitInfo2,

        /// <summary>
        ///     <c>SemaphoreSubmitInfoKHR</c>
        /// </summary>
        SemaphoreSubmitInfoKHR = SemaphoreSubmitInfo,

        /// <summary>
        ///     <c>CommandBufferSubmitInfoKHR</c>
        /// </summary>
        CommandBufferSubmitInfoKHR = CommandBufferSubmitInfo,

        /// <summary>
        ///     <c>PhysicalDeviceSynchronization2FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceSynchronization2FeaturesKHR = PhysicalDeviceSynchronization2Features,

        /// <summary>
        ///     <c>PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR = PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceImageRobustnessFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceImageRobustnessFeaturesEXT = PhysicalDeviceImageRobustnessFeatures,

        /// <summary>
        ///     <c>CopyBufferInfo2KHR</c>
        /// </summary>
        CopyBufferInfo2KHR = CopyBufferInfo2,

        /// <summary>
        ///     <c>CopyImageInfo2KHR</c>
        /// </summary>
        CopyImageInfo2KHR = CopyImageInfo2,

        /// <summary>
        ///     <c>CopyBufferToImageInfo2KHR</c>
        /// </summary>
        CopyBufferToImageInfo2KHR = CopyBufferToImageInfo2,

        /// <summary>
        ///     <c>CopyImageToBufferInfo2KHR</c>
        /// </summary>
        CopyImageToBufferInfo2KHR = CopyImageToBufferInfo2,

        /// <summary>
        ///     <c>BlitImageInfo2KHR</c>
        /// </summary>
        BlitImageInfo2KHR = BlitImageInfo2,

        /// <summary>
        ///     <c>ResolveImageInfo2KHR</c>
        /// </summary>
        ResolveImageInfo2KHR = ResolveImageInfo2,

        /// <summary>
        ///     <c>BufferCopy2KHR</c>
        /// </summary>
        BufferCopy2KHR = BufferCopy2,

        /// <summary>
        ///     <c>ImageCopy2KHR</c>
        /// </summary>
        ImageCopy2KHR = ImageCopy2,

        /// <summary>
        ///     <c>ImageBlit2KHR</c>
        /// </summary>
        ImageBlit2KHR = ImageBlit2,

        /// <summary>
        ///     <c>BufferImageCopy2KHR</c>
        /// </summary>
        BufferImageCopy2KHR = BufferImageCopy2,

        /// <summary>
        ///     <c>ImageResolve2KHR</c>
        /// </summary>
        ImageResolve2KHR = ImageResolve2,

        /// <summary>
        ///     <c>SubresourceLayout2EXT</c>
        /// </summary>
        SubresourceLayout2EXT = SubresourceLayout2,

        /// <summary>
        ///     <c>ImageSubresource2EXT</c>
        /// </summary>
        ImageSubresource2EXT = ImageSubresource2,

        /// <summary>
        ///     <c>PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM</c>
        /// </summary>
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM =
            PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT,

        /// <summary>
        ///     <c>PhysicalDeviceMutableDescriptorTypeFeaturesVALVE</c>
        /// </summary>
        PhysicalDeviceMutableDescriptorTypeFeaturesVALVE = PhysicalDeviceMutableDescriptorTypeFeaturesEXT,

        /// <summary>
        ///     <c>MutableDescriptorTypeCreateInfoVALVE</c>
        /// </summary>
        MutableDescriptorTypeCreateInfoVALVE = MutableDescriptorTypeCreateInfoEXT,

        /// <summary>
        ///     <c>FormatProperties3KHR</c>
        /// </summary>
        FormatProperties3KHR = FormatProperties3,

        /// <summary>
        ///     <c>PhysicalDevicePresentModeFifoLatestReadyFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePresentModeFifoLatestReadyFeaturesEXT = PhysicalDevicePresentModeFifoLatestReadyFeaturesKHR,

        /// <summary>
        ///     <c>PipelineInfoEXT</c>
        /// </summary>
        PipelineInfoEXT = PipelineInfoKHR,

        /// <summary>
        ///     <c>PhysicalDeviceGlobalPriorityQueryFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceGlobalPriorityQueryFeaturesEXT = PhysicalDeviceGlobalPriorityQueryFeatures,

        /// <summary>
        ///     <c>QueueFamilyGlobalPriorityPropertiesEXT</c>
        /// </summary>
        QueueFamilyGlobalPriorityPropertiesEXT = QueueFamilyGlobalPriorityProperties,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance4FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance4FeaturesKHR = PhysicalDeviceMaintenance4Features,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance4PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance4PropertiesKHR = PhysicalDeviceMaintenance4Properties,

        /// <summary>
        ///     <c>DeviceBufferMemoryRequirementsKHR</c>
        /// </summary>
        DeviceBufferMemoryRequirementsKHR = DeviceBufferMemoryRequirements,

        /// <summary>
        ///     <c>DeviceImageMemoryRequirementsKHR</c>
        /// </summary>
        DeviceImageMemoryRequirementsKHR = DeviceImageMemoryRequirements,

        /// <summary>
        ///     <c>PhysicalDeviceShaderSubgroupRotateFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderSubgroupRotateFeaturesKHR = PhysicalDeviceShaderSubgroupRotateFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceDepthClampZeroOneFeaturesEXT</c>
        /// </summary>
        PhysicalDeviceDepthClampZeroOneFeaturesEXT = PhysicalDeviceDepthClampZeroOneFeaturesKHR,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM = PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT,

        /// <summary>
        ///     <c>PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM</c>
        /// </summary>
        PhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM = PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT,

        /// <summary>
        ///     <c>SubpassFragmentDensityMapOffsetEndInfoQCOM</c>
        /// </summary>
        SubpassFragmentDensityMapOffsetEndInfoQCOM = RenderPassFragmentDensityMapOffsetEndInfoEXT,

        /// <summary>
        ///     <c>PhysicalDeviceCopyMemoryIndirectPropertiesNV</c>
        /// </summary>
        PhysicalDeviceCopyMemoryIndirectPropertiesNV = PhysicalDeviceCopyMemoryIndirectPropertiesKHR,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryDecompressionFeaturesNV</c>
        /// </summary>
        PhysicalDeviceMemoryDecompressionFeaturesNV = PhysicalDeviceMemoryDecompressionFeaturesEXT,

        /// <summary>
        ///     <c>PhysicalDeviceMemoryDecompressionPropertiesNV</c>
        /// </summary>
        PhysicalDeviceMemoryDecompressionPropertiesNV = PhysicalDeviceMemoryDecompressionPropertiesEXT,

        /// <summary>
        ///     <c>PhysicalDevicePipelineProtectedAccessFeaturesEXT</c>
        /// </summary>
        PhysicalDevicePipelineProtectedAccessFeaturesEXT = PhysicalDevicePipelineProtectedAccessFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance5FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance5FeaturesKHR = PhysicalDeviceMaintenance5Features,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance5PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance5PropertiesKHR = PhysicalDeviceMaintenance5Properties,

        /// <summary>
        ///     <c>RenderingAreaInfoKHR</c>
        /// </summary>
        RenderingAreaInfoKHR = RenderingAreaInfo,

        /// <summary>
        ///     <c>DeviceImageSubresourceInfoKHR</c>
        /// </summary>
        DeviceImageSubresourceInfoKHR = DeviceImageSubresourceInfo,

        /// <summary>
        ///     <c>SubresourceLayout2KHR</c>
        /// </summary>
        SubresourceLayout2KHR = SubresourceLayout2,

        /// <summary>
        ///     <c>ImageSubresource2KHR</c>
        /// </summary>
        ImageSubresource2KHR = ImageSubresource2,

        /// <summary>
        ///     <c>PipelineCreateFlags2CreateInfoKHR</c>
        /// </summary>
        PipelineCreateFlags2CreateInfoKHR = PipelineCreateFlags2CreateInfo,

        /// <summary>
        ///     <c>BufferUsageFlags2CreateInfoKHR</c>
        /// </summary>
        BufferUsageFlags2CreateInfoKHR = BufferUsageFlags2CreateInfo,

        /// <summary>
        ///     <c>ShaderRequiredSubgroupSizeCreateInfoEXT</c>
        /// </summary>
        ShaderRequiredSubgroupSizeCreateInfoEXT = PipelineShaderStageRequiredSubgroupSizeCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeDivisorPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorPropertiesKHR = PhysicalDeviceVertexAttributeDivisorProperties,

        /// <summary>
        ///     <c>PipelineVertexInputDivisorStateCreateInfoKHR</c>
        /// </summary>
        PipelineVertexInputDivisorStateCreateInfoKHR = PipelineVertexInputDivisorStateCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceVertexAttributeDivisorFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceVertexAttributeDivisorFeaturesKHR = PhysicalDeviceVertexAttributeDivisorFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceShaderFloatControls2FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderFloatControls2FeaturesKHR = PhysicalDeviceShaderFloatControls2Features,

        /// <summary>
        ///     <c>PhysicalDeviceIndexTypeUInt8FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceIndexTypeUInt8FeaturesKHR = PhysicalDeviceIndexTypeUInt8Features,

        /// <summary>
        ///     <c>PhysicalDeviceLineRasterizationFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceLineRasterizationFeaturesKHR = PhysicalDeviceLineRasterizationFeatures,

        /// <summary>
        ///     <c>PipelineRasterizationLineStateCreateInfoKHR</c>
        /// </summary>
        PipelineRasterizationLineStateCreateInfoKHR = PipelineRasterizationLineStateCreateInfo,

        /// <summary>
        ///     <c>PhysicalDeviceLineRasterizationPropertiesKHR</c>
        /// </summary>
        PhysicalDeviceLineRasterizationPropertiesKHR = PhysicalDeviceLineRasterizationProperties,

        /// <summary>
        ///     <c>PhysicalDeviceShaderExpectAssumeFeaturesKHR</c>
        /// </summary>
        PhysicalDeviceShaderExpectAssumeFeaturesKHR = PhysicalDeviceShaderExpectAssumeFeatures,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance6FeaturesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance6FeaturesKHR = PhysicalDeviceMaintenance6Features,

        /// <summary>
        ///     <c>PhysicalDeviceMaintenance6PropertiesKHR</c>
        /// </summary>
        PhysicalDeviceMaintenance6PropertiesKHR = PhysicalDeviceMaintenance6Properties,

        /// <summary>
        ///     <c>BindMemoryStatusKHR</c>
        /// </summary>
        BindMemoryStatusKHR = BindMemoryStatus,

        /// <summary>
        ///     <c>BindDescriptorSetsInfoKHR</c>
        /// </summary>
        BindDescriptorSetsInfoKHR = BindDescriptorSetsInfo,

        /// <summary>
        ///     <c>PushConstantsInfoKHR</c>
        /// </summary>
        PushConstantsInfoKHR = PushConstantsInfo,

        /// <summary>
        ///     <c>PushDescriptorSetInfoKHR</c>
        /// </summary>
        PushDescriptorSetInfoKHR = PushDescriptorSetInfo,

        /// <summary>
        ///     <c>PushDescriptorSetWithTemplateInfoKHR</c>
        /// </summary>
        PushDescriptorSetWithTemplateInfoKHR = PushDescriptorSetWithTemplateInfo,

        /// <summary>
        ///     <c>RenderingEndInfoEXT</c>
        /// </summary>
        RenderingEndInfoEXT = RenderingEndInfoKHR,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
