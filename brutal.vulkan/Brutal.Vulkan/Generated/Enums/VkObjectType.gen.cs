namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkObjectType.html">VkObjectType</see> - Specify an enumeration to track object handle types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkObjectType</c> enumeration defines values, each of which corresponds
    ///         to a specific Vulkan handle type.
    ///         These values <i>can</i> be used to associate debug information with a particular
    ///         type of object through one or more extensions.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkObjectType {
    ///             VK_OBJECT_TYPE_UNKNOWN = 0,
    ///             VK_OBJECT_TYPE_INSTANCE = 1,
    ///             VK_OBJECT_TYPE_PHYSICAL_DEVICE = 2,
    ///             VK_OBJECT_TYPE_DEVICE = 3,
    ///             VK_OBJECT_TYPE_QUEUE = 4,
    ///             VK_OBJECT_TYPE_SEMAPHORE = 5,
    ///             VK_OBJECT_TYPE_COMMAND_BUFFER = 6,
    ///             VK_OBJECT_TYPE_FENCE = 7,
    ///             VK_OBJECT_TYPE_DEVICE_MEMORY = 8,
    ///             VK_OBJECT_TYPE_BUFFER = 9,
    ///             VK_OBJECT_TYPE_IMAGE = 10,
    ///             VK_OBJECT_TYPE_EVENT = 11,
    ///             VK_OBJECT_TYPE_QUERY_POOL = 12,
    ///             VK_OBJECT_TYPE_BUFFER_VIEW = 13,
    ///             VK_OBJECT_TYPE_IMAGE_VIEW = 14,
    ///             VK_OBJECT_TYPE_SHADER_MODULE = 15,
    ///             VK_OBJECT_TYPE_PIPELINE_CACHE = 16,
    ///             VK_OBJECT_TYPE_PIPELINE_LAYOUT = 17,
    ///             VK_OBJECT_TYPE_RENDER_PASS = 18,
    ///             VK_OBJECT_TYPE_PIPELINE = 19,
    ///             VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = 20,
    ///             VK_OBJECT_TYPE_SAMPLER = 21,
    ///             VK_OBJECT_TYPE_DESCRIPTOR_POOL = 22,
    ///             VK_OBJECT_TYPE_DESCRIPTOR_SET = 23,
    ///             VK_OBJECT_TYPE_FRAMEBUFFER = 24,
    ///             VK_OBJECT_TYPE_COMMAND_POOL = 25,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE = 1000085000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION = 1000156000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_OBJECT_TYPE_PRIVATE_DATA_SLOT = 1000295000,
    ///             // Provided by VK_KHR_surface
    ///             VK_OBJECT_TYPE_SURFACE_KHR = 1000000000,
    ///             // Provided by VK_KHR_swapchain
    ///             VK_OBJECT_TYPE_SWAPCHAIN_KHR = 1000001000,
    ///             // Provided by VK_KHR_display
    ///             VK_OBJECT_TYPE_DISPLAY_KHR = 1000002000,
    ///             // Provided by VK_KHR_display
    ///             VK_OBJECT_TYPE_DISPLAY_MODE_KHR = 1000002001,
    ///             // Provided by VK_EXT_debug_report
    ///             VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = 1000011000,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_OBJECT_TYPE_VIDEO_SESSION_KHR = 1000023000,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_OBJECT_TYPE_VIDEO_SESSION_PARAMETERS_KHR = 1000023001,
    ///             // Provided by VK_NVX_binary_import
    ///             VK_OBJECT_TYPE_CU_MODULE_NVX = 1000029000,
    ///             // Provided by VK_NVX_binary_import
    ///             VK_OBJECT_TYPE_CU_FUNCTION_NVX = 1000029001,
    ///             // Provided by VK_EXT_debug_utils
    ///             VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = 1000128000,
    ///             // Provided by VK_AMD_gpa_interface
    ///             VK_OBJECT_TYPE_GPA_SESSION_AMD = 1000133000,
    ///             // Provided by VK_KHR_acceleration_structure
    ///             VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR = 1000150000,
    ///             // Provided by VK_EXT_validation_cache
    ///             VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = 1000160000,
    ///             // Provided by VK_NV_ray_tracing
    ///             VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,
    ///             // Provided by VK_INTEL_performance_query
    ///             VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL = 1000210000,
    ///             // Provided by VK_KHR_deferred_host_operations
    ///             VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR = 1000268000,
    ///             // Provided by VK_NV_device_generated_commands
    ///             VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV = 1000277000,
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_OBJECT_TYPE_CUDA_MODULE_NV = 1000307000,
    ///             #endif
    ///             #ifdef VK_ENABLE_BETA_EXTENSIONS
    ///             // Provided by VK_NV_cuda_kernel_launch
    ///             VK_OBJECT_TYPE_CUDA_FUNCTION_NV = 1000307001,
    ///             #endif
    ///             // Provided by VK_FUCHSIA_buffer_collection
    ///             VK_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA = 1000366000,
    ///             // Provided by VK_EXT_opacity_micromap
    ///             VK_OBJECT_TYPE_MICROMAP_EXT = 1000396000,
    ///             // Provided by VK_ARM_tensors
    ///             VK_OBJECT_TYPE_TENSOR_ARM = 1000460000,
    ///             // Provided by VK_ARM_tensors
    ///             VK_OBJECT_TYPE_TENSOR_VIEW_ARM = 1000460001,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_OBJECT_TYPE_OPTICAL_FLOW_SESSION_NV = 1000464000,
    ///             // Provided by VK_EXT_shader_object
    ///             VK_OBJECT_TYPE_SHADER_EXT = 1000482000,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_OBJECT_TYPE_PIPELINE_BINARY_KHR = 1000483000,
    ///             // Provided by VK_ARM_data_graph
    ///             VK_OBJECT_TYPE_DATA_GRAPH_PIPELINE_SESSION_ARM = 1000507000,
    ///             // Provided by VK_NV_external_compute_queue
    ///             VK_OBJECT_TYPE_EXTERNAL_COMPUTE_QUEUE_NV = 1000556000,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_EXT = 1000572000,
    ///             // Provided by VK_EXT_device_generated_commands
    ///             VK_OBJECT_TYPE_INDIRECT_EXECUTION_SET_EXT = 1000572001,
    ///             // Provided by VK_ARM_shader_instrumentation
    ///             VK_OBJECT_TYPE_SHADER_INSTRUMENTATION_ARM = 1000607000,
    ///             // Provided by VK_KHR_descriptor_update_template
    ///             VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR = VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR = VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION,
    ///             // Provided by VK_EXT_private_data
    ///             VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT = VK_OBJECT_TYPE_PRIVATE_DATA_SLOT,
    ///         } VkObjectType;
    ///     </code>
    /// </remarks>
    public enum VkObjectType : int
    {
        /// <summary>
        ///     <c>Unknown</c>
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     <c>Instance</c>
        /// </summary>
        Instance = 1,

        /// <summary>
        ///     <c>PhysicalDevice</c>
        /// </summary>
        PhysicalDevice = 2,

        /// <summary>
        ///     <c>Device</c>
        /// </summary>
        Device = 3,

        /// <summary>
        ///     <c>Queue</c>
        /// </summary>
        Queue = 4,

        /// <summary>
        ///     <c>Semaphore</c>
        /// </summary>
        Semaphore = 5,

        /// <summary>
        ///     <c>CommandBuffer</c>
        /// </summary>
        CommandBuffer = 6,

        /// <summary>
        ///     <c>Fence</c>
        /// </summary>
        Fence = 7,

        /// <summary>
        ///     <c>DeviceMemory</c>
        /// </summary>
        DeviceMemory = 8,

        /// <summary>
        ///     <c>Buffer</c>
        /// </summary>
        Buffer = 9,

        /// <summary>
        ///     <c>Image</c>
        /// </summary>
        Image = 10,

        /// <summary>
        ///     <c>Event</c>
        /// </summary>
        Event = 11,

        /// <summary>
        ///     <c>QueryPool</c>
        /// </summary>
        QueryPool = 12,

        /// <summary>
        ///     <c>BufferView</c>
        /// </summary>
        BufferView = 13,

        /// <summary>
        ///     <c>ImageView</c>
        /// </summary>
        ImageView = 14,

        /// <summary>
        ///     <c>ShaderModule</c>
        /// </summary>
        ShaderModule = 15,

        /// <summary>
        ///     <c>PipelineCache</c>
        /// </summary>
        PipelineCache = 16,

        /// <summary>
        ///     <c>PipelineLayout</c>
        /// </summary>
        PipelineLayout = 17,

        /// <summary>
        ///     <c>RenderPass</c>
        /// </summary>
        RenderPass = 18,

        /// <summary>
        ///     <c>Pipeline</c>
        /// </summary>
        Pipeline = 19,

        /// <summary>
        ///     <c>DescriptorSetLayout</c>
        /// </summary>
        DescriptorSetLayout = 20,

        /// <summary>
        ///     <c>Sampler</c>
        /// </summary>
        Sampler = 21,

        /// <summary>
        ///     <c>DescriptorPool</c>
        /// </summary>
        DescriptorPool = 22,

        /// <summary>
        ///     <c>DescriptorSet</c>
        /// </summary>
        DescriptorSet = 23,

        /// <summary>
        ///     <c>Framebuffer</c>
        /// </summary>
        Framebuffer = 24,

        /// <summary>
        ///     <c>CommandPool</c>
        /// </summary>
        CommandPool = 25,

        /// <summary>
        ///     <c>DescriptorUpdateTemplate</c>
        /// </summary>
        DescriptorUpdateTemplate = 1000085000,

        /// <summary>
        ///     <c>SamplerYCbCrConversion</c>
        /// </summary>
        SamplerYCbCrConversion = 1000156000,

        /// <summary>
        ///     <c>PrivateDataSlot</c>
        /// </summary>
        PrivateDataSlot = 1000295000,

        /// <summary>
        ///     <c>SurfaceKHR</c>
        /// </summary>
        SurfaceKHR = 1000000000,

        /// <summary>
        ///     <c>SwapchainKHR</c>
        /// </summary>
        SwapchainKHR = 1000001000,

        /// <summary>
        ///     <c>DisplayKHR</c>
        /// </summary>
        DisplayKHR = 1000002000,

        /// <summary>
        ///     <c>DisplayModeKHR</c>
        /// </summary>
        DisplayModeKHR = 1000002001,

        /// <summary>
        ///     <c>DebugReportCallbackEXT</c>
        /// </summary>
        DebugReportCallbackEXT = 1000011000,

        /// <summary>
        ///     <c>VideoSessionKHR</c>
        /// </summary>
        VideoSessionKHR = 1000023000,

        /// <summary>
        ///     <c>VideoSessionParametersKHR</c>
        /// </summary>
        VideoSessionParametersKHR = 1000023001,

        /// <summary>
        ///     <c>CuModuleNVX</c>
        /// </summary>
        CuModuleNVX = 1000029000,

        /// <summary>
        ///     <c>CuFunctionNVX</c>
        /// </summary>
        CuFunctionNVX = 1000029001,

        /// <summary>
        ///     <c>DebugUtilsMessengerEXT</c>
        /// </summary>
        DebugUtilsMessengerEXT = 1000128000,

        /// <summary>
        ///     <c>GpaSessionAMD</c>
        /// </summary>
        GpaSessionAMD = 1000133000,

        /// <summary>
        ///     <c>AccelerationStructureKHR</c>
        /// </summary>
        AccelerationStructureKHR = 1000150000,

        /// <summary>
        ///     <c>ValidationCacheEXT</c>
        /// </summary>
        ValidationCacheEXT = 1000160000,

        /// <summary>
        ///     <c>AccelerationStructureNV</c>
        /// </summary>
        AccelerationStructureNV = 1000165000,

        /// <summary>
        ///     <c>PerformanceConfigurationINTEL</c>
        /// </summary>
        PerformanceConfigurationINTEL = 1000210000,

        /// <summary>
        ///     <c>DeferredOperationKHR</c>
        /// </summary>
        DeferredOperationKHR = 1000268000,

        /// <summary>
        ///     <c>IndirectCommandsLayoutNV</c>
        /// </summary>
        IndirectCommandsLayoutNV = 1000277000,

        /// <summary>
        ///     <c>CudaModuleNV</c>
        /// </summary>
        CudaModuleNV = 1000307000,

        /// <summary>
        ///     <c>CudaFunctionNV</c>
        /// </summary>
        CudaFunctionNV = 1000307001,

        /// <summary>
        ///     <c>BufferCollectionFUCHSIA</c>
        /// </summary>
        BufferCollectionFUCHSIA = 1000366000,

        /// <summary>
        ///     <c>MicromapEXT</c>
        /// </summary>
        MicromapEXT = 1000396000,

        /// <summary>
        ///     <c>TensorARM</c>
        /// </summary>
        TensorARM = 1000460000,

        /// <summary>
        ///     <c>TensorViewARM</c>
        /// </summary>
        TensorViewARM = 1000460001,

        /// <summary>
        ///     <c>OpticalFlowSessionNV</c>
        /// </summary>
        OpticalFlowSessionNV = 1000464000,

        /// <summary>
        ///     <c>ShaderEXT</c>
        /// </summary>
        ShaderEXT = 1000482000,

        /// <summary>
        ///     <c>PipelineBinaryKHR</c>
        /// </summary>
        PipelineBinaryKHR = 1000483000,

        /// <summary>
        ///     <c>DataGraphPipelineSessionARM</c>
        /// </summary>
        DataGraphPipelineSessionARM = 1000507000,

        /// <summary>
        ///     <c>ExternalComputeQueueNV</c>
        /// </summary>
        ExternalComputeQueueNV = 1000556000,

        /// <summary>
        ///     <c>IndirectCommandsLayoutEXT</c>
        /// </summary>
        IndirectCommandsLayoutEXT = 1000572000,

        /// <summary>
        ///     <c>IndirectExecutionSetEXT</c>
        /// </summary>
        IndirectExecutionSetEXT = 1000572001,

        /// <summary>
        ///     <c>ShaderInstrumentationARM</c>
        /// </summary>
        ShaderInstrumentationARM = 1000607000,

        /// <summary>
        ///     <c>DescriptorUpdateTemplateKHR</c>
        /// </summary>
        DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,

        /// <summary>
        ///     <c>SamplerYCbCrConversionKHR</c>
        /// </summary>
        SamplerYCbCrConversionKHR = SamplerYCbCrConversion,

        /// <summary>
        ///     <c>PrivateDataSlotEXT</c>
        /// </summary>
        PrivateDataSlotEXT = PrivateDataSlot,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
