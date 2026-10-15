namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugReportObjectTypeEXT.html">VkDebugReportObjectTypeEXT</see> - Specify the type of an object handle
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Possible values passed to the <c>objectType</c> parameter of the callback
    ///         function specified by
    ///         <c>VkDebugReportCallbackCreateInfoEXT::pfnCallback</c>, specifying the
    ///         type of object handle being reported, are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_marker, VK_EXT_debug_report
    ///         typedef enum VkDebugReportObjectTypeEXT {
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = 0,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = 1,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = 2,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = 3,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = 4,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = 5,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = 6,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = 7,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = 8,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = 9,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = 10,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = 11,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = 12,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = 13,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = 14,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = 15,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = 16,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = 17,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = 18,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = 19,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = 20,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = 21,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = 22,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = 23,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = 24,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = 25,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = 26,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = 27,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = 28,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = 29,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = 30,
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = 33,
    ///             // Provided by VK_VERSION_1_1 with VK_EXT_debug_report, VK_KHR_sampler_ycbcr_conversion with VK_EXT_debug_report
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = 1000156000,
    ///             // Provided by VK_VERSION_1_1 with VK_EXT_debug_report
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = 1000085000,
    ///             // Provided by VK_EXT_debug_report with VK_NVX_binary_import
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT = 1000029000,
    ///             // Provided by VK_EXT_debug_report with VK_NVX_binary_import
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT = 1000029001,
    ///             // Provided by VK_KHR_acceleration_structure with VK_EXT_debug_report
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT = 1000150000,
    ///             // Provided by VK_EXT_debug_report with VK_NV_ray_tracing
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = 1000165000,
    ///             // Provided by VK_EXT_debug_report with VK_NV_cuda_kernel_launch
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV_EXT = 1000307000,
    ///             // Provided by VK_EXT_debug_report with VK_NV_cuda_kernel_launch
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV_EXT = 1000307001,
    ///             // Provided by VK_EXT_debug_report with VK_FUCHSIA_buffer_collection
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT = 1000366000,
    ///             // VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT is a legacy alias
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT,
    ///             // VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT is a legacy alias
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT,
    ///             // Provided by VK_KHR_descriptor_update_template with VK_EXT_debug_report
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion with VK_EXT_debug_report
    ///             VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT,
    ///         } VkDebugReportObjectTypeEXT;
    ///     </code>
    /// </remarks>
    public enum VkDebugReportObjectTypeEXT : int
    {
        /// <summary>
        ///     <c>UnknownEXT</c>
        /// </summary>
        UnknownEXT = 0,

        /// <summary>
        ///     <c>InstanceEXT</c>
        /// </summary>
        InstanceEXT = 1,

        /// <summary>
        ///     <c>PhysicalDeviceEXT</c>
        /// </summary>
        PhysicalDeviceEXT = 2,

        /// <summary>
        ///     <c>DeviceEXT</c>
        /// </summary>
        DeviceEXT = 3,

        /// <summary>
        ///     <c>QueueEXT</c>
        /// </summary>
        QueueEXT = 4,

        /// <summary>
        ///     <c>SemaphoreEXT</c>
        /// </summary>
        SemaphoreEXT = 5,

        /// <summary>
        ///     <c>CommandBufferEXT</c>
        /// </summary>
        CommandBufferEXT = 6,

        /// <summary>
        ///     <c>FenceEXT</c>
        /// </summary>
        FenceEXT = 7,

        /// <summary>
        ///     <c>DeviceMemoryEXT</c>
        /// </summary>
        DeviceMemoryEXT = 8,

        /// <summary>
        ///     <c>BufferEXT</c>
        /// </summary>
        BufferEXT = 9,

        /// <summary>
        ///     <c>ImageEXT</c>
        /// </summary>
        ImageEXT = 10,

        /// <summary>
        ///     <c>EventEXT</c>
        /// </summary>
        EventEXT = 11,

        /// <summary>
        ///     <c>QueryPoolEXT</c>
        /// </summary>
        QueryPoolEXT = 12,

        /// <summary>
        ///     <c>BufferViewEXT</c>
        /// </summary>
        BufferViewEXT = 13,

        /// <summary>
        ///     <c>ImageViewEXT</c>
        /// </summary>
        ImageViewEXT = 14,

        /// <summary>
        ///     <c>ShaderModuleEXT</c>
        /// </summary>
        ShaderModuleEXT = 15,

        /// <summary>
        ///     <c>PipelineCacheEXT</c>
        /// </summary>
        PipelineCacheEXT = 16,

        /// <summary>
        ///     <c>PipelineLayoutEXT</c>
        /// </summary>
        PipelineLayoutEXT = 17,

        /// <summary>
        ///     <c>RenderPassEXT</c>
        /// </summary>
        RenderPassEXT = 18,

        /// <summary>
        ///     <c>PipelineEXT</c>
        /// </summary>
        PipelineEXT = 19,

        /// <summary>
        ///     <c>DescriptorSetLayoutEXT</c>
        /// </summary>
        DescriptorSetLayoutEXT = 20,

        /// <summary>
        ///     <c>SamplerEXT</c>
        /// </summary>
        SamplerEXT = 21,

        /// <summary>
        ///     <c>DescriptorPoolEXT</c>
        /// </summary>
        DescriptorPoolEXT = 22,

        /// <summary>
        ///     <c>DescriptorSetEXT</c>
        /// </summary>
        DescriptorSetEXT = 23,

        /// <summary>
        ///     <c>FramebufferEXT</c>
        /// </summary>
        FramebufferEXT = 24,

        /// <summary>
        ///     <c>CommandPoolEXT</c>
        /// </summary>
        CommandPoolEXT = 25,

        /// <summary>
        ///     <c>SurfaceKHREXT</c>
        /// </summary>
        SurfaceKHREXT = 26,

        /// <summary>
        ///     <c>SwapchainKHREXT</c>
        /// </summary>
        SwapchainKHREXT = 27,

        /// <summary>
        ///     <c>DebugReportCallbackEXTEXT</c>
        /// </summary>
        DebugReportCallbackEXTEXT = 28,

        /// <summary>
        ///     <c>DisplayKHREXT</c>
        /// </summary>
        DisplayKHREXT = 29,

        /// <summary>
        ///     <c>DisplayModeKHREXT</c>
        /// </summary>
        DisplayModeKHREXT = 30,

        /// <summary>
        ///     <c>ValidationCacheEXTEXT</c>
        /// </summary>
        ValidationCacheEXTEXT = 33,

        /// <summary>
        ///     <c>SamplerYCbCrConversionEXT</c>
        /// </summary>
        SamplerYCbCrConversionEXT = 1000156000,

        /// <summary>
        ///     <c>DescriptorUpdateTemplateEXT</c>
        /// </summary>
        DescriptorUpdateTemplateEXT = 1000085000,

        /// <summary>
        ///     <c>CuModuleNVXEXT</c>
        /// </summary>
        CuModuleNVXEXT = 1000029000,

        /// <summary>
        ///     <c>CuFunctionNVXEXT</c>
        /// </summary>
        CuFunctionNVXEXT = 1000029001,

        /// <summary>
        ///     <c>AccelerationStructureKHREXT</c>
        /// </summary>
        AccelerationStructureKHREXT = 1000150000,

        /// <summary>
        ///     <c>AccelerationStructureNVEXT</c>
        /// </summary>
        AccelerationStructureNVEXT = 1000165000,

        /// <summary>
        ///     <c>CudaModuleNVEXT</c>
        /// </summary>
        CudaModuleNVEXT = 1000307000,

        /// <summary>
        ///     <c>CudaFunctionNVEXT</c>
        /// </summary>
        CudaFunctionNVEXT = 1000307001,

        /// <summary>
        ///     <c>BufferCollectionFUCHSIAEXT</c>
        /// </summary>
        BufferCollectionFUCHSIAEXT = 1000366000,

        /// <summary>
        ///     <c>DebugReportEXT</c>
        /// </summary>
        DebugReportEXT = DebugReportCallbackEXTEXT,

        /// <summary>
        ///     <c>ValidationCacheEXT</c>
        /// </summary>
        ValidationCacheEXT = ValidationCacheEXTEXT,

        /// <summary>
        ///     <c>DescriptorUpdateTemplateKHREXT</c>
        /// </summary>
        DescriptorUpdateTemplateKHREXT = DescriptorUpdateTemplateEXT,

        /// <summary>
        ///     <c>SamplerYCbCrConversionKHREXT</c>
        /// </summary>
        SamplerYCbCrConversionKHREXT = SamplerYCbCrConversionEXT,

        /// <summary>
        ///     <c>MaxEnumEXT</c>
        /// </summary>
        MaxEnumEXT = 0x7FFFFFFF,
    }
}
