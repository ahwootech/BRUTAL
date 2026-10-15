namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkResult.html">VkResult</see> - Vulkan command return codes
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         While the core Vulkan API is not designed to capture incorrect usage, some
    ///         circumstances still require return codes.
    ///         Commands in Vulkan return their status via return codes that are in one of
    ///         two categories:
    ///     </para>
    ///     <para>
    ///         * Successful completion codes are returned when a command needs to
    ///         communicate success or status information.
    ///         All successful completion codes are non-negative values.
    ///         * Runtime error codes are returned when a command needs to communicate a
    ///         failure that could only be detected at runtime.
    ///         All runtime error codes are negative values.
    ///     </para>
    ///     <para>
    ///         All return codes in Vulkan are reported via <c>VkResult</c> return values.
    ///         The possible codes are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkResult {
    ///             VK_SUCCESS = 0,
    ///             VK_NOT_READY = 1,
    ///             VK_TIMEOUT = 2,
    ///             VK_EVENT_SET = 3,
    ///             VK_EVENT_RESET = 4,
    ///             VK_INCOMPLETE = 5,
    ///             VK_ERROR_OUT_OF_HOST_MEMORY = -1,
    ///             VK_ERROR_OUT_OF_DEVICE_MEMORY = -2,
    ///             VK_ERROR_INITIALIZATION_FAILED = -3,
    ///             VK_ERROR_DEVICE_LOST = -4,
    ///             VK_ERROR_MEMORY_MAP_FAILED = -5,
    ///             VK_ERROR_LAYER_NOT_PRESENT = -6,
    ///             VK_ERROR_EXTENSION_NOT_PRESENT = -7,
    ///             VK_ERROR_FEATURE_NOT_PRESENT = -8,
    ///             VK_ERROR_INCOMPATIBLE_DRIVER = -9,
    ///             VK_ERROR_TOO_MANY_OBJECTS = -10,
    ///             VK_ERROR_FORMAT_NOT_SUPPORTED = -11,
    ///             VK_ERROR_FRAGMENTED_POOL = -12,
    ///             VK_ERROR_UNKNOWN = -13,
    ///             // Provided by VK_VERSION_1_0
    ///             VK_ERROR_VALIDATION_FAILED = -1000011001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_ERROR_OUT_OF_POOL_MEMORY = -1000069000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_ERROR_INVALID_EXTERNAL_HANDLE = -1000072003,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS = -1000257000,
    ///             // Provided by VK_VERSION_1_2
    ///             VK_ERROR_FRAGMENTATION = -1000161000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_PIPELINE_COMPILE_REQUIRED = 1000297000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_ERROR_NOT_PERMITTED = -1000174001,
    ///             // Provided by VK_KHR_surface
    ///             VK_ERROR_SURFACE_LOST_KHR = -1000000000,
    ///             // Provided by VK_KHR_surface
    ///             VK_ERROR_NATIVE_WINDOW_IN_USE_KHR = -1000000001,
    ///             // Provided by VK_KHR_swapchain
    ///             VK_SUBOPTIMAL_KHR = 1000001003,
    ///             // Provided by VK_KHR_swapchain
    ///             VK_ERROR_OUT_OF_DATE_KHR = -1000001004,
    ///             // Provided by VK_KHR_display_swapchain
    ///             VK_ERROR_INCOMPATIBLE_DISPLAY_KHR = -1000003001,
    ///             // Provided by VK_NV_glsl_shader
    ///             VK_ERROR_INVALID_SHADER_NV = -1000012000,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR = -1000023000,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR = -1000023001,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR = -1000023002,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR = -1000023003,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR = -1000023004,
    ///             // Provided by VK_KHR_video_queue
    ///             VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR = -1000023005,
    ///             // Provided by VK_EXT_image_drm_format_modifier
    ///             VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT = -1000158000,
    ///             // Provided by VK_EXT_present_timing
    ///             VK_ERROR_PRESENT_TIMING_QUEUE_FULL_EXT = -1000208000,
    ///             // Provided by VK_EXT_full_screen_exclusive
    ///             VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT = -1000255000,
    ///             // Provided by VK_KHR_deferred_host_operations
    ///             VK_THREAD_IDLE_KHR = 1000268000,
    ///             // Provided by VK_KHR_deferred_host_operations
    ///             VK_THREAD_DONE_KHR = 1000268001,
    ///             // Provided by VK_KHR_deferred_host_operations
    ///             VK_OPERATION_DEFERRED_KHR = 1000268002,
    ///             // Provided by VK_KHR_deferred_host_operations
    ///             VK_OPERATION_NOT_DEFERRED_KHR = 1000268003,
    ///             // Provided by VK_KHR_video_encode_queue
    ///             VK_ERROR_INVALID_VIDEO_STD_PARAMETERS_KHR = -1000299000,
    ///             // Provided by VK_EXT_image_compression_control
    ///             VK_ERROR_COMPRESSION_EXHAUSTED_EXT = -1000338000,
    ///             // Provided by VK_EXT_shader_object
    ///             VK_INCOMPATIBLE_SHADER_BINARY_EXT = 1000482000,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_PIPELINE_BINARY_MISSING_KHR = 1000483000,
    ///             // Provided by VK_KHR_pipeline_binary
    ///             VK_ERROR_NOT_ENOUGH_SPACE_KHR = -1000483000,
    ///             // Provided by VK_EXT_debug_report
    ///             VK_ERROR_VALIDATION_FAILED_EXT = VK_ERROR_VALIDATION_FAILED,
    ///             // Provided by VK_KHR_maintenance1
    ///             VK_ERROR_OUT_OF_POOL_MEMORY_KHR = VK_ERROR_OUT_OF_POOL_MEMORY,
    ///             // Provided by VK_KHR_external_memory
    ///             VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR = VK_ERROR_INVALID_EXTERNAL_HANDLE,
    ///             // Provided by VK_EXT_descriptor_indexing
    ///             VK_ERROR_FRAGMENTATION_EXT = VK_ERROR_FRAGMENTATION,
    ///             // Provided by VK_EXT_global_priority
    ///             VK_ERROR_NOT_PERMITTED_EXT = VK_ERROR_NOT_PERMITTED,
    ///             // Provided by VK_KHR_global_priority
    ///             VK_ERROR_NOT_PERMITTED_KHR = VK_ERROR_NOT_PERMITTED,
    ///             // Provided by VK_EXT_buffer_device_address
    ///             VK_ERROR_INVALID_DEVICE_ADDRESS_EXT = VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS,
    ///             // Provided by VK_KHR_buffer_device_address
    ///             VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR = VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS,
    ///             // Provided by VK_EXT_pipeline_creation_cache_control
    ///             VK_PIPELINE_COMPILE_REQUIRED_EXT = VK_PIPELINE_COMPILE_REQUIRED,
    ///             // Provided by VK_EXT_pipeline_creation_cache_control
    ///             VK_ERROR_PIPELINE_COMPILE_REQUIRED_EXT = VK_PIPELINE_COMPILE_REQUIRED,
    ///             // Provided by VK_EXT_shader_object
    ///             // VK_ERROR_INCOMPATIBLE_SHADER_BINARY_EXT is a legacy alias
    ///             VK_ERROR_INCOMPATIBLE_SHADER_BINARY_EXT = VK_INCOMPATIBLE_SHADER_BINARY_EXT,
    ///         } VkResult;
    ///     </code>
    /// </remarks>
    public enum VkResult : int
    {
        /// <summary>
        ///     <c>Success</c>
        /// </summary>
        Success = 0,

        /// <summary>
        ///     <c>NotReady</c>
        /// </summary>
        NotReady = 1,

        /// <summary>
        ///     <c>Timeout</c>
        /// </summary>
        Timeout = 2,

        /// <summary>
        ///     <c>EventSet</c>
        /// </summary>
        EventSet = 3,

        /// <summary>
        ///     <c>EventReset</c>
        /// </summary>
        EventReset = 4,

        /// <summary>
        ///     <c>Incomplete</c>
        /// </summary>
        Incomplete = 5,

        /// <summary>
        ///     <c>ErrorOutOfHostMemory</c>
        /// </summary>
        ErrorOutOfHostMemory = -1,

        /// <summary>
        ///     <c>ErrorOutOfDeviceMemory</c>
        /// </summary>
        ErrorOutOfDeviceMemory = -2,

        /// <summary>
        ///     <c>ErrorInitializationFailed</c>
        /// </summary>
        ErrorInitializationFailed = -3,

        /// <summary>
        ///     <c>ErrorDeviceLost</c>
        /// </summary>
        ErrorDeviceLost = -4,

        /// <summary>
        ///     <c>ErrorMemoryMapFailed</c>
        /// </summary>
        ErrorMemoryMapFailed = -5,

        /// <summary>
        ///     <c>ErrorLayerNotPresent</c>
        /// </summary>
        ErrorLayerNotPresent = -6,

        /// <summary>
        ///     <c>ErrorExtensionNotPresent</c>
        /// </summary>
        ErrorExtensionNotPresent = -7,

        /// <summary>
        ///     <c>ErrorFeatureNotPresent</c>
        /// </summary>
        ErrorFeatureNotPresent = -8,

        /// <summary>
        ///     <c>ErrorIncompatibleDriver</c>
        /// </summary>
        ErrorIncompatibleDriver = -9,

        /// <summary>
        ///     <c>ErrorTooManyObjects</c>
        /// </summary>
        ErrorTooManyObjects = -10,

        /// <summary>
        ///     <c>ErrorFormatNotSupported</c>
        /// </summary>
        ErrorFormatNotSupported = -11,

        /// <summary>
        ///     <c>ErrorFragmentedPool</c>
        /// </summary>
        ErrorFragmentedPool = -12,

        /// <summary>
        ///     <c>ErrorUnknown</c>
        /// </summary>
        ErrorUnknown = -13,

        /// <summary>
        ///     <c>ErrorValidationFailed</c>
        /// </summary>
        ErrorValidationFailed = -1000011001,

        /// <summary>
        ///     <c>ErrorOutOfPoolMemory</c>
        /// </summary>
        ErrorOutOfPoolMemory = -1000069000,

        /// <summary>
        ///     <c>ErrorInvalidExternalHandle</c>
        /// </summary>
        ErrorInvalidExternalHandle = -1000072003,

        /// <summary>
        ///     <c>ErrorInvalidOpaqueCaptureAddress</c>
        /// </summary>
        ErrorInvalidOpaqueCaptureAddress = -1000257000,

        /// <summary>
        ///     <c>ErrorFragmentation</c>
        /// </summary>
        ErrorFragmentation = -1000161000,

        /// <summary>
        ///     <c>PipelineCompileRequired</c>
        /// </summary>
        PipelineCompileRequired = 1000297000,

        /// <summary>
        ///     <c>ErrorNotPermitted</c>
        /// </summary>
        ErrorNotPermitted = -1000174001,

        /// <summary>
        ///     <c>ErrorSurfaceLostKHR</c>
        /// </summary>
        ErrorSurfaceLostKHR = -1000000000,

        /// <summary>
        ///     <c>ErrorNativeWindowInUseKHR</c>
        /// </summary>
        ErrorNativeWindowInUseKHR = -1000000001,

        /// <summary>
        ///     <c>SuboptimalKHR</c>
        /// </summary>
        SuboptimalKHR = 1000001003,

        /// <summary>
        ///     <c>ErrorOutOfDateKHR</c>
        /// </summary>
        ErrorOutOfDateKHR = -1000001004,

        /// <summary>
        ///     <c>ErrorIncompatibleDisplayKHR</c>
        /// </summary>
        ErrorIncompatibleDisplayKHR = -1000003001,

        /// <summary>
        ///     <c>ErrorInvalidShaderNV</c>
        /// </summary>
        ErrorInvalidShaderNV = -1000012000,

        /// <summary>
        ///     <c>ErrorImageUsageNotSupportedKHR</c>
        /// </summary>
        ErrorImageUsageNotSupportedKHR = -1000023000,

        /// <summary>
        ///     <c>ErrorVideoPictureLayoutNotSupportedKHR</c>
        /// </summary>
        ErrorVideoPictureLayoutNotSupportedKHR = -1000023001,

        /// <summary>
        ///     <c>ErrorVideoProfileOperationNotSupportedKHR</c>
        /// </summary>
        ErrorVideoProfileOperationNotSupportedKHR = -1000023002,

        /// <summary>
        ///     <c>ErrorVideoProfileFormatNotSupportedKHR</c>
        /// </summary>
        ErrorVideoProfileFormatNotSupportedKHR = -1000023003,

        /// <summary>
        ///     <c>ErrorVideoProfileCodecNotSupportedKHR</c>
        /// </summary>
        ErrorVideoProfileCodecNotSupportedKHR = -1000023004,

        /// <summary>
        ///     <c>ErrorVideoStdVersionNotSupportedKHR</c>
        /// </summary>
        ErrorVideoStdVersionNotSupportedKHR = -1000023005,

        /// <summary>
        ///     <c>ErrorInvalidDrmFormatModifierPlaneLayoutEXT</c>
        /// </summary>
        ErrorInvalidDrmFormatModifierPlaneLayoutEXT = -1000158000,

        /// <summary>
        ///     <c>ErrorPresentTimingQueueFullEXT</c>
        /// </summary>
        ErrorPresentTimingQueueFullEXT = -1000208000,

        /// <summary>
        ///     <c>ErrorFullScreenExclusiveModeLostEXT</c>
        /// </summary>
        ErrorFullScreenExclusiveModeLostEXT = -1000255000,

        /// <summary>
        ///     <c>ThreadIdleKHR</c>
        /// </summary>
        ThreadIdleKHR = 1000268000,

        /// <summary>
        ///     <c>ThreadDoneKHR</c>
        /// </summary>
        ThreadDoneKHR = 1000268001,

        /// <summary>
        ///     <c>OperationDeferredKHR</c>
        /// </summary>
        OperationDeferredKHR = 1000268002,

        /// <summary>
        ///     <c>OperationNotDeferredKHR</c>
        /// </summary>
        OperationNotDeferredKHR = 1000268003,

        /// <summary>
        ///     <c>ErrorInvalidVideoStdParametersKHR</c>
        /// </summary>
        ErrorInvalidVideoStdParametersKHR = -1000299000,

        /// <summary>
        ///     <c>ErrorCompressionExhaustedEXT</c>
        /// </summary>
        ErrorCompressionExhaustedEXT = -1000338000,

        /// <summary>
        ///     <c>IncompatibleShaderBinaryEXT</c>
        /// </summary>
        IncompatibleShaderBinaryEXT = 1000482000,

        /// <summary>
        ///     <c>PipelineBinaryMissingKHR</c>
        /// </summary>
        PipelineBinaryMissingKHR = 1000483000,

        /// <summary>
        ///     <c>ErrorNotEnoughSpaceKHR</c>
        /// </summary>
        ErrorNotEnoughSpaceKHR = -1000483000,

        /// <summary>
        ///     <c>ErrorValidationFailedEXT</c>
        /// </summary>
        ErrorValidationFailedEXT = ErrorValidationFailed,

        /// <summary>
        ///     <c>ErrorOutOfPoolMemoryKHR</c>
        /// </summary>
        ErrorOutOfPoolMemoryKHR = ErrorOutOfPoolMemory,

        /// <summary>
        ///     <c>ErrorInvalidExternalHandleKHR</c>
        /// </summary>
        ErrorInvalidExternalHandleKHR = ErrorInvalidExternalHandle,

        /// <summary>
        ///     <c>ErrorFragmentationEXT</c>
        /// </summary>
        ErrorFragmentationEXT = ErrorFragmentation,

        /// <summary>
        ///     <c>ErrorNotPermittedEXT</c>
        /// </summary>
        ErrorNotPermittedEXT = ErrorNotPermitted,

        /// <summary>
        ///     <c>ErrorNotPermittedKHR</c>
        /// </summary>
        ErrorNotPermittedKHR = ErrorNotPermitted,

        /// <summary>
        ///     <c>ErrorInvalidDeviceAddressEXT</c>
        /// </summary>
        ErrorInvalidDeviceAddressEXT = ErrorInvalidOpaqueCaptureAddress,

        /// <summary>
        ///     <c>ErrorInvalidOpaqueCaptureAddressKHR</c>
        /// </summary>
        ErrorInvalidOpaqueCaptureAddressKHR = ErrorInvalidOpaqueCaptureAddress,

        /// <summary>
        ///     <c>PipelineCompileRequiredEXT</c>
        /// </summary>
        PipelineCompileRequiredEXT = PipelineCompileRequired,

        /// <summary>
        ///     <c>ErrorPipelineCompileRequiredEXT</c>
        /// </summary>
        ErrorPipelineCompileRequiredEXT = PipelineCompileRequired,

        /// <summary>
        ///     <c>ErrorIncompatibleShaderBinaryEXT</c>
        /// </summary>
        ErrorIncompatibleShaderBinaryEXT = IncompatibleShaderBinaryEXT,

        /// <summary>
        ///     <c>ResultMaxEnum</c>
        /// </summary>
        ResultMaxEnum = 0x7FFFFFFF,
    }
}
