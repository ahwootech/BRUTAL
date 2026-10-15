namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkInstance.html">VkInstance</see> - Opaque handle to an instance object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is no global state in Vulkan and all per-application state is stored
    ///         in a <c>VkInstance</c> object.
    ///         Creating a <c>VkInstance</c> object initializes the Vulkan library and allows
    ///         the application to pass information about itself to the implementation.
    ///     </para>
    ///     <para>
    ///         Instances are represented by <c>VkInstance</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_HANDLE(VkInstance)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkInstance : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Instance;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkInstance(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkInstance NullHandle = new();

        public struct FunctionTable
        {
            public VkDestroyInstance vkDestroyInstance;
            public VkEnumeratePhysicalDevices vkEnumeratePhysicalDevices;
            public VkGetPhysicalDeviceFeatures vkGetPhysicalDeviceFeatures;
            public VkGetPhysicalDeviceFormatProperties vkGetPhysicalDeviceFormatProperties;
            public VkGetPhysicalDeviceImageFormatProperties vkGetPhysicalDeviceImageFormatProperties;
            public VkGetPhysicalDeviceProperties vkGetPhysicalDeviceProperties;
            public VkGetPhysicalDeviceQueueFamilyProperties vkGetPhysicalDeviceQueueFamilyProperties;
            public VkGetPhysicalDeviceMemoryProperties vkGetPhysicalDeviceMemoryProperties;
            public VkGetInstanceProcAddr vkGetInstanceProcAddr;
            public VkCreateDevice vkCreateDevice;
            public VkEnumerateDeviceExtensionProperties vkEnumerateDeviceExtensionProperties;
            public VkEnumerateDeviceLayerProperties vkEnumerateDeviceLayerProperties;
            public VkGetPhysicalDeviceSparseImageFormatProperties vkGetPhysicalDeviceSparseImageFormatProperties;
            public VkEnumeratePhysicalDeviceGroups vkEnumeratePhysicalDeviceGroups;
            public VkGetPhysicalDeviceFeatures2 vkGetPhysicalDeviceFeatures2;
            public VkGetPhysicalDeviceProperties2 vkGetPhysicalDeviceProperties2;
            public VkGetPhysicalDeviceFormatProperties2 vkGetPhysicalDeviceFormatProperties2;
            public VkGetPhysicalDeviceImageFormatProperties2 vkGetPhysicalDeviceImageFormatProperties2;
            public VkGetPhysicalDeviceQueueFamilyProperties2 vkGetPhysicalDeviceQueueFamilyProperties2;
            public VkGetPhysicalDeviceMemoryProperties2 vkGetPhysicalDeviceMemoryProperties2;
            public VkGetPhysicalDeviceSparseImageFormatProperties2 vkGetPhysicalDeviceSparseImageFormatProperties2;
            public VkGetPhysicalDeviceExternalBufferProperties vkGetPhysicalDeviceExternalBufferProperties;
            public VkGetPhysicalDeviceExternalFenceProperties vkGetPhysicalDeviceExternalFenceProperties;
            public VkGetPhysicalDeviceExternalSemaphoreProperties vkGetPhysicalDeviceExternalSemaphoreProperties;
            public VkGetPhysicalDeviceToolProperties vkGetPhysicalDeviceToolProperties;
            public VkDestroySurfaceKHR vkDestroySurfaceKHR;
            public VkGetPhysicalDeviceSurfaceSupportKHR vkGetPhysicalDeviceSurfaceSupportKHR;
            public VkGetPhysicalDeviceSurfaceCapabilitiesKHR vkGetPhysicalDeviceSurfaceCapabilitiesKHR;
            public VkGetPhysicalDeviceSurfaceFormatsKHR vkGetPhysicalDeviceSurfaceFormatsKHR;
            public VkGetPhysicalDeviceSurfacePresentModesKHR vkGetPhysicalDeviceSurfacePresentModesKHR;
            public VkGetPhysicalDevicePresentRectanglesKHR vkGetPhysicalDevicePresentRectanglesKHR;
            public VkGetPhysicalDeviceDisplayPropertiesKHR vkGetPhysicalDeviceDisplayPropertiesKHR;
            public VkGetPhysicalDeviceDisplayPlanePropertiesKHR vkGetPhysicalDeviceDisplayPlanePropertiesKHR;
            public VkGetDisplayPlaneSupportedDisplaysKHR vkGetDisplayPlaneSupportedDisplaysKHR;
            public VkGetDisplayModePropertiesKHR vkGetDisplayModePropertiesKHR;
            public VkCreateDisplayModeKHR vkCreateDisplayModeKHR;
            public VkGetDisplayPlaneCapabilitiesKHR vkGetDisplayPlaneCapabilitiesKHR;
            public VkCreateDisplayPlaneSurfaceKHR vkCreateDisplayPlaneSurfaceKHR;
            public VkGetPhysicalDeviceVideoCapabilitiesKHR vkGetPhysicalDeviceVideoCapabilitiesKHR;
            public VkGetPhysicalDeviceVideoFormatPropertiesKHR vkGetPhysicalDeviceVideoFormatPropertiesKHR;
            public VkGetPhysicalDeviceFeatures2KHR vkGetPhysicalDeviceFeatures2KHR;
            public VkGetPhysicalDeviceProperties2KHR vkGetPhysicalDeviceProperties2KHR;
            public VkGetPhysicalDeviceFormatProperties2KHR vkGetPhysicalDeviceFormatProperties2KHR;
            public VkGetPhysicalDeviceImageFormatProperties2KHR vkGetPhysicalDeviceImageFormatProperties2KHR;
            public VkGetPhysicalDeviceQueueFamilyProperties2KHR vkGetPhysicalDeviceQueueFamilyProperties2KHR;
            public VkGetPhysicalDeviceMemoryProperties2KHR vkGetPhysicalDeviceMemoryProperties2KHR;
            public VkGetPhysicalDeviceSparseImageFormatProperties2KHR vkGetPhysicalDeviceSparseImageFormatProperties2KHR;
            public VkEnumeratePhysicalDeviceGroupsKHR vkEnumeratePhysicalDeviceGroupsKHR;
            public VkGetPhysicalDeviceExternalBufferPropertiesKHR vkGetPhysicalDeviceExternalBufferPropertiesKHR;
            public VkGetPhysicalDeviceExternalSemaphorePropertiesKHR vkGetPhysicalDeviceExternalSemaphorePropertiesKHR;
            public VkGetPhysicalDeviceExternalFencePropertiesKHR vkGetPhysicalDeviceExternalFencePropertiesKHR;
            public VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;
            public VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;
            public VkGetPhysicalDeviceSurfaceCapabilities2KHR vkGetPhysicalDeviceSurfaceCapabilities2KHR;
            public VkGetPhysicalDeviceSurfaceFormats2KHR vkGetPhysicalDeviceSurfaceFormats2KHR;
            public VkGetPhysicalDeviceDisplayProperties2KHR vkGetPhysicalDeviceDisplayProperties2KHR;
            public VkGetPhysicalDeviceDisplayPlaneProperties2KHR vkGetPhysicalDeviceDisplayPlaneProperties2KHR;
            public VkGetDisplayModeProperties2KHR vkGetDisplayModeProperties2KHR;
            public VkGetDisplayPlaneCapabilities2KHR vkGetDisplayPlaneCapabilities2KHR;
            public VkGetPhysicalDeviceFragmentShadingRatesKHR vkGetPhysicalDeviceFragmentShadingRatesKHR;
            public VkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR;
            public VkGetPhysicalDeviceCooperativeMatrixPropertiesKHR vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR;
            public VkGetPhysicalDeviceCalibrateableTimeDomainsKHR vkGetPhysicalDeviceCalibrateableTimeDomainsKHR;
            public VkCreateDebugReportCallbackEXT vkCreateDebugReportCallbackEXT;
            public VkDestroyDebugReportCallbackEXT vkDestroyDebugReportCallbackEXT;
            public VkDebugReportMessageEXT vkDebugReportMessageEXT;
            public VkGetPhysicalDeviceExternalImageFormatPropertiesNV vkGetPhysicalDeviceExternalImageFormatPropertiesNV;
            public VkReleaseDisplayEXT vkReleaseDisplayEXT;
            public VkGetPhysicalDeviceSurfaceCapabilities2EXT vkGetPhysicalDeviceSurfaceCapabilities2EXT;
            public VkCreateDebugUtilsMessengerEXT vkCreateDebugUtilsMessengerEXT;
            public VkDestroyDebugUtilsMessengerEXT vkDestroyDebugUtilsMessengerEXT;
            public VkSubmitDebugUtilsMessageEXT vkSubmitDebugUtilsMessageEXT;
            public VkGetPhysicalDeviceDescriptorSizeEXT vkGetPhysicalDeviceDescriptorSizeEXT;
            public VkGetPhysicalDeviceMultisamplePropertiesEXT vkGetPhysicalDeviceMultisamplePropertiesEXT;
            public VkGetPhysicalDeviceCalibrateableTimeDomainsEXT vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;
            public VkGetPhysicalDeviceToolPropertiesEXT vkGetPhysicalDeviceToolPropertiesEXT;
            public VkGetPhysicalDeviceCooperativeMatrixPropertiesNV vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;
            public VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;
            public VkCreateHeadlessSurfaceEXT vkCreateHeadlessSurfaceEXT;
            public VkAcquireDrmDisplayEXT vkAcquireDrmDisplayEXT;
            public VkGetDrmDisplayEXT vkGetDrmDisplayEXT;
            public VkGetPhysicalDeviceExternalTensorPropertiesARM vkGetPhysicalDeviceExternalTensorPropertiesARM;
            public VkGetPhysicalDeviceOpticalFlowImageFormatsNV vkGetPhysicalDeviceOpticalFlowImageFormatsNV;
            public VkGetPhysicalDeviceCooperativeVectorPropertiesNV vkGetPhysicalDeviceCooperativeVectorPropertiesNV;
            public VkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM;
            public VkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM;
            public VkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM;
            public VkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV;
            public VkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM;
            public VkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM;
            public VkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM;
            public VkCreateWin32SurfaceKHR vkCreateWin32SurfaceKHR;
            public VkGetPhysicalDeviceWin32PresentationSupportKHR vkGetPhysicalDeviceWin32PresentationSupportKHR;
            public VkGetPhysicalDeviceSurfacePresentModes2EXT vkGetPhysicalDeviceSurfacePresentModes2EXT;
            public VkAcquireWinrtDisplayNV vkAcquireWinrtDisplayNV;
            public VkGetWinrtDisplayNV vkGetWinrtDisplayNV;
            public VkCreateXlibSurfaceKHR vkCreateXlibSurfaceKHR;
            public VkGetPhysicalDeviceXlibPresentationSupportKHR vkGetPhysicalDeviceXlibPresentationSupportKHR;
            public VkAcquireXlibDisplayEXT vkAcquireXlibDisplayEXT;
            public VkGetRandROutputDisplayEXT vkGetRandROutputDisplayEXT;
            public VkCreateXcbSurfaceKHR vkCreateXcbSurfaceKHR;
            public VkGetPhysicalDeviceXcbPresentationSupportKHR vkGetPhysicalDeviceXcbPresentationSupportKHR;
            public VkCreateWaylandSurfaceKHR vkCreateWaylandSurfaceKHR;
            public VkGetPhysicalDeviceWaylandPresentationSupportKHR vkGetPhysicalDeviceWaylandPresentationSupportKHR;
            public VkCreateMetalSurfaceEXT vkCreateMetalSurfaceEXT;
            public VkCreateAndroidSurfaceKHR vkCreateAndroidSurfaceKHR;

            public FunctionTable(VkInstance instance, VkGetInstanceProcAddr getProc)
            {
                vkGetInstanceProcAddr = getProc;
                vkDestroyInstance = (VkDestroyInstance)getProc.Invoke(instance, "vkDestroyInstance"u8.AsPointer());
                vkEnumeratePhysicalDevices = (VkEnumeratePhysicalDevices)
                    getProc.Invoke(instance, "vkEnumeratePhysicalDevices"u8.AsPointer());
                vkGetPhysicalDeviceFeatures = (VkGetPhysicalDeviceFeatures)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFeatures"u8.AsPointer());
                vkGetPhysicalDeviceFormatProperties = (VkGetPhysicalDeviceFormatProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFormatProperties"u8.AsPointer());
                vkGetPhysicalDeviceImageFormatProperties = (VkGetPhysicalDeviceImageFormatProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceImageFormatProperties"u8.AsPointer());
                vkGetPhysicalDeviceProperties = (VkGetPhysicalDeviceProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceProperties"u8.AsPointer());
                vkGetPhysicalDeviceQueueFamilyProperties = (VkGetPhysicalDeviceQueueFamilyProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceQueueFamilyProperties"u8.AsPointer());
                vkGetPhysicalDeviceMemoryProperties = (VkGetPhysicalDeviceMemoryProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceMemoryProperties"u8.AsPointer());
                vkCreateDevice = (VkCreateDevice)getProc.Invoke(instance, "vkCreateDevice"u8.AsPointer());
                vkEnumerateDeviceExtensionProperties = (VkEnumerateDeviceExtensionProperties)
                    getProc.Invoke(instance, "vkEnumerateDeviceExtensionProperties"u8.AsPointer());
                vkEnumerateDeviceLayerProperties = (VkEnumerateDeviceLayerProperties)
                    getProc.Invoke(instance, "vkEnumerateDeviceLayerProperties"u8.AsPointer());
                vkGetPhysicalDeviceSparseImageFormatProperties = (VkGetPhysicalDeviceSparseImageFormatProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSparseImageFormatProperties"u8.AsPointer());
                vkEnumeratePhysicalDeviceGroups = (VkEnumeratePhysicalDeviceGroups)
                    getProc.Invoke(instance, "vkEnumeratePhysicalDeviceGroups"u8.AsPointer());
                vkGetPhysicalDeviceFeatures2 = (VkGetPhysicalDeviceFeatures2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFeatures2"u8.AsPointer());
                vkGetPhysicalDeviceProperties2 = (VkGetPhysicalDeviceProperties2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceProperties2"u8.AsPointer());
                vkGetPhysicalDeviceFormatProperties2 = (VkGetPhysicalDeviceFormatProperties2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFormatProperties2"u8.AsPointer());
                vkGetPhysicalDeviceImageFormatProperties2 = (VkGetPhysicalDeviceImageFormatProperties2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceImageFormatProperties2"u8.AsPointer());
                vkGetPhysicalDeviceQueueFamilyProperties2 = (VkGetPhysicalDeviceQueueFamilyProperties2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceQueueFamilyProperties2"u8.AsPointer());
                vkGetPhysicalDeviceMemoryProperties2 = (VkGetPhysicalDeviceMemoryProperties2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceMemoryProperties2"u8.AsPointer());
                vkGetPhysicalDeviceSparseImageFormatProperties2 = (VkGetPhysicalDeviceSparseImageFormatProperties2)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2"u8.AsPointer());
                vkGetPhysicalDeviceExternalBufferProperties = (VkGetPhysicalDeviceExternalBufferProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalBufferProperties"u8.AsPointer());
                vkGetPhysicalDeviceExternalFenceProperties = (VkGetPhysicalDeviceExternalFenceProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalFenceProperties"u8.AsPointer());
                vkGetPhysicalDeviceExternalSemaphoreProperties = (VkGetPhysicalDeviceExternalSemaphoreProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalSemaphoreProperties"u8.AsPointer());
                vkGetPhysicalDeviceToolProperties = (VkGetPhysicalDeviceToolProperties)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceToolProperties"u8.AsPointer());
                vkDestroySurfaceKHR = (VkDestroySurfaceKHR)
                    getProc.Invoke(instance, "vkDestroySurfaceKHR"u8.AsPointer());
                vkGetPhysicalDeviceSurfaceSupportKHR = (VkGetPhysicalDeviceSurfaceSupportKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfaceSupportKHR"u8.AsPointer());
                vkGetPhysicalDeviceSurfaceCapabilitiesKHR = (VkGetPhysicalDeviceSurfaceCapabilitiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceSurfaceFormatsKHR = (VkGetPhysicalDeviceSurfaceFormatsKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfaceFormatsKHR"u8.AsPointer());
                vkGetPhysicalDeviceSurfacePresentModesKHR = (VkGetPhysicalDeviceSurfacePresentModesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfacePresentModesKHR"u8.AsPointer());
                vkGetPhysicalDevicePresentRectanglesKHR = (VkGetPhysicalDevicePresentRectanglesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDevicePresentRectanglesKHR"u8.AsPointer());
                vkGetPhysicalDeviceDisplayPropertiesKHR = (VkGetPhysicalDeviceDisplayPropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceDisplayPropertiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceDisplayPlanePropertiesKHR = (VkGetPhysicalDeviceDisplayPlanePropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR"u8.AsPointer());
                vkGetDisplayPlaneSupportedDisplaysKHR = (VkGetDisplayPlaneSupportedDisplaysKHR)
                    getProc.Invoke(instance, "vkGetDisplayPlaneSupportedDisplaysKHR"u8.AsPointer());
                vkGetDisplayModePropertiesKHR = (VkGetDisplayModePropertiesKHR)
                    getProc.Invoke(instance, "vkGetDisplayModePropertiesKHR"u8.AsPointer());
                vkCreateDisplayModeKHR = (VkCreateDisplayModeKHR)
                    getProc.Invoke(instance, "vkCreateDisplayModeKHR"u8.AsPointer());
                vkGetDisplayPlaneCapabilitiesKHR = (VkGetDisplayPlaneCapabilitiesKHR)
                    getProc.Invoke(instance, "vkGetDisplayPlaneCapabilitiesKHR"u8.AsPointer());
                vkCreateDisplayPlaneSurfaceKHR = (VkCreateDisplayPlaneSurfaceKHR)
                    getProc.Invoke(instance, "vkCreateDisplayPlaneSurfaceKHR"u8.AsPointer());
                vkGetPhysicalDeviceVideoCapabilitiesKHR = (VkGetPhysicalDeviceVideoCapabilitiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceVideoCapabilitiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceVideoFormatPropertiesKHR = (VkGetPhysicalDeviceVideoFormatPropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceVideoFormatPropertiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceFeatures2KHR = (VkGetPhysicalDeviceFeatures2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFeatures2KHR"u8.AsPointer());
                vkGetPhysicalDeviceProperties2KHR = (VkGetPhysicalDeviceProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceProperties2KHR"u8.AsPointer());
                vkGetPhysicalDeviceFormatProperties2KHR = (VkGetPhysicalDeviceFormatProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFormatProperties2KHR"u8.AsPointer());
                vkGetPhysicalDeviceImageFormatProperties2KHR = (VkGetPhysicalDeviceImageFormatProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceImageFormatProperties2KHR"u8.AsPointer());
                vkGetPhysicalDeviceQueueFamilyProperties2KHR = (VkGetPhysicalDeviceQueueFamilyProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceQueueFamilyProperties2KHR"u8.AsPointer());
                vkGetPhysicalDeviceMemoryProperties2KHR = (VkGetPhysicalDeviceMemoryProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceMemoryProperties2KHR"u8.AsPointer());
                vkGetPhysicalDeviceSparseImageFormatProperties2KHR =
                    (VkGetPhysicalDeviceSparseImageFormatProperties2KHR)
                        getProc.Invoke(instance, "vkGetPhysicalDeviceSparseImageFormatProperties2KHR"u8.AsPointer());
                vkEnumeratePhysicalDeviceGroupsKHR = (VkEnumeratePhysicalDeviceGroupsKHR)
                    getProc.Invoke(instance, "vkEnumeratePhysicalDeviceGroupsKHR"u8.AsPointer());
                vkGetPhysicalDeviceExternalBufferPropertiesKHR = (VkGetPhysicalDeviceExternalBufferPropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalBufferPropertiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceExternalSemaphorePropertiesKHR = (VkGetPhysicalDeviceExternalSemaphorePropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceExternalFencePropertiesKHR = (VkGetPhysicalDeviceExternalFencePropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalFencePropertiesKHR"u8.AsPointer());
                vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR =
                    (VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR)
                        getProc.Invoke(
                            instance,
                            "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR"u8.AsPointer()
                        );
                vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR =
                    (VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR"u8.AsPointer()
                        );
                vkGetPhysicalDeviceSurfaceCapabilities2KHR = (VkGetPhysicalDeviceSurfaceCapabilities2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfaceCapabilities2KHR"u8.AsPointer());
                vkGetPhysicalDeviceSurfaceFormats2KHR = (VkGetPhysicalDeviceSurfaceFormats2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfaceFormats2KHR"u8.AsPointer());
                vkGetPhysicalDeviceDisplayProperties2KHR = (VkGetPhysicalDeviceDisplayProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceDisplayProperties2KHR"u8.AsPointer());
                vkGetPhysicalDeviceDisplayPlaneProperties2KHR = (VkGetPhysicalDeviceDisplayPlaneProperties2KHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR"u8.AsPointer());
                vkGetDisplayModeProperties2KHR = (VkGetDisplayModeProperties2KHR)
                    getProc.Invoke(instance, "vkGetDisplayModeProperties2KHR"u8.AsPointer());
                vkGetDisplayPlaneCapabilities2KHR = (VkGetDisplayPlaneCapabilities2KHR)
                    getProc.Invoke(instance, "vkGetDisplayPlaneCapabilities2KHR"u8.AsPointer());
                vkGetPhysicalDeviceFragmentShadingRatesKHR = (VkGetPhysicalDeviceFragmentShadingRatesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceFragmentShadingRatesKHR"u8.AsPointer());
                vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR =
                    (VkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR"u8.AsPointer()
                        );
                vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR = (VkGetPhysicalDeviceCooperativeMatrixPropertiesKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR"u8.AsPointer());
                vkGetPhysicalDeviceCalibrateableTimeDomainsKHR = (VkGetPhysicalDeviceCalibrateableTimeDomainsKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsKHR"u8.AsPointer());
                vkCreateDebugReportCallbackEXT = (VkCreateDebugReportCallbackEXT)
                    getProc.Invoke(instance, "vkCreateDebugReportCallbackEXT"u8.AsPointer());
                vkDestroyDebugReportCallbackEXT = (VkDestroyDebugReportCallbackEXT)
                    getProc.Invoke(instance, "vkDestroyDebugReportCallbackEXT"u8.AsPointer());
                vkDebugReportMessageEXT = (VkDebugReportMessageEXT)
                    getProc.Invoke(instance, "vkDebugReportMessageEXT"u8.AsPointer());
                vkGetPhysicalDeviceExternalImageFormatPropertiesNV =
                    (VkGetPhysicalDeviceExternalImageFormatPropertiesNV)
                        getProc.Invoke(instance, "vkGetPhysicalDeviceExternalImageFormatPropertiesNV"u8.AsPointer());
                vkReleaseDisplayEXT = (VkReleaseDisplayEXT)
                    getProc.Invoke(instance, "vkReleaseDisplayEXT"u8.AsPointer());
                vkGetPhysicalDeviceSurfaceCapabilities2EXT = (VkGetPhysicalDeviceSurfaceCapabilities2EXT)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfaceCapabilities2EXT"u8.AsPointer());
                vkCreateDebugUtilsMessengerEXT = (VkCreateDebugUtilsMessengerEXT)
                    getProc.Invoke(instance, "vkCreateDebugUtilsMessengerEXT"u8.AsPointer());
                vkDestroyDebugUtilsMessengerEXT = (VkDestroyDebugUtilsMessengerEXT)
                    getProc.Invoke(instance, "vkDestroyDebugUtilsMessengerEXT"u8.AsPointer());
                vkSubmitDebugUtilsMessageEXT = (VkSubmitDebugUtilsMessageEXT)
                    getProc.Invoke(instance, "vkSubmitDebugUtilsMessageEXT"u8.AsPointer());
                vkGetPhysicalDeviceDescriptorSizeEXT = (VkGetPhysicalDeviceDescriptorSizeEXT)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceDescriptorSizeEXT"u8.AsPointer());
                vkGetPhysicalDeviceMultisamplePropertiesEXT = (VkGetPhysicalDeviceMultisamplePropertiesEXT)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceMultisamplePropertiesEXT"u8.AsPointer());
                vkGetPhysicalDeviceCalibrateableTimeDomainsEXT = (VkGetPhysicalDeviceCalibrateableTimeDomainsEXT)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT"u8.AsPointer());
                vkGetPhysicalDeviceToolPropertiesEXT = (VkGetPhysicalDeviceToolPropertiesEXT)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceToolPropertiesEXT"u8.AsPointer());
                vkGetPhysicalDeviceCooperativeMatrixPropertiesNV = (VkGetPhysicalDeviceCooperativeMatrixPropertiesNV)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV"u8.AsPointer());
                vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV =
                    (VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV"u8.AsPointer()
                        );
                vkCreateHeadlessSurfaceEXT = (VkCreateHeadlessSurfaceEXT)
                    getProc.Invoke(instance, "vkCreateHeadlessSurfaceEXT"u8.AsPointer());
                vkAcquireDrmDisplayEXT = (VkAcquireDrmDisplayEXT)
                    getProc.Invoke(instance, "vkAcquireDrmDisplayEXT"u8.AsPointer());
                vkGetDrmDisplayEXT = (VkGetDrmDisplayEXT)getProc.Invoke(instance, "vkGetDrmDisplayEXT"u8.AsPointer());
                vkGetPhysicalDeviceExternalTensorPropertiesARM = (VkGetPhysicalDeviceExternalTensorPropertiesARM)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceExternalTensorPropertiesARM"u8.AsPointer());
                vkGetPhysicalDeviceOpticalFlowImageFormatsNV = (VkGetPhysicalDeviceOpticalFlowImageFormatsNV)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceOpticalFlowImageFormatsNV"u8.AsPointer());
                vkGetPhysicalDeviceCooperativeVectorPropertiesNV = (VkGetPhysicalDeviceCooperativeVectorPropertiesNV)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceCooperativeVectorPropertiesNV"u8.AsPointer());
                vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM =
                    (VkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM)
                        getProc.Invoke(instance, "vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM"u8.AsPointer());
                vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM =
                    (VkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM"u8.AsPointer()
                        );
                vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM =
                    (VkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM"u8.AsPointer()
                        );
                vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV =
                    (VkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV"u8.AsPointer()
                        );
                vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM =
                    (VkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM)
                        getProc.Invoke(
                            instance,
                            "vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM"u8.AsPointer()
                        );
                vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM =
                    (VkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM)
                        getProc.Invoke(
                            instance,
                            "vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM"u8.AsPointer()
                        );
                vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM =
                    (VkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM)
                        getProc.Invoke(
                            instance,
                            "vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM"u8.AsPointer()
                        );
                vkCreateWin32SurfaceKHR = (VkCreateWin32SurfaceKHR)
                    getProc.Invoke(instance, "vkCreateWin32SurfaceKHR"u8.AsPointer());
                vkGetPhysicalDeviceWin32PresentationSupportKHR = (VkGetPhysicalDeviceWin32PresentationSupportKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceWin32PresentationSupportKHR"u8.AsPointer());
                vkGetPhysicalDeviceSurfacePresentModes2EXT = (VkGetPhysicalDeviceSurfacePresentModes2EXT)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceSurfacePresentModes2EXT"u8.AsPointer());
                vkAcquireWinrtDisplayNV = (VkAcquireWinrtDisplayNV)
                    getProc.Invoke(instance, "vkAcquireWinrtDisplayNV"u8.AsPointer());
                vkGetWinrtDisplayNV = (VkGetWinrtDisplayNV)
                    getProc.Invoke(instance, "vkGetWinrtDisplayNV"u8.AsPointer());
                vkCreateXlibSurfaceKHR = (VkCreateXlibSurfaceKHR)
                    getProc.Invoke(instance, "vkCreateXlibSurfaceKHR"u8.AsPointer());
                vkGetPhysicalDeviceXlibPresentationSupportKHR = (VkGetPhysicalDeviceXlibPresentationSupportKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceXlibPresentationSupportKHR"u8.AsPointer());
                vkAcquireXlibDisplayEXT = (VkAcquireXlibDisplayEXT)
                    getProc.Invoke(instance, "vkAcquireXlibDisplayEXT"u8.AsPointer());
                vkGetRandROutputDisplayEXT = (VkGetRandROutputDisplayEXT)
                    getProc.Invoke(instance, "vkGetRandROutputDisplayEXT"u8.AsPointer());
                vkCreateXcbSurfaceKHR = (VkCreateXcbSurfaceKHR)
                    getProc.Invoke(instance, "vkCreateXcbSurfaceKHR"u8.AsPointer());
                vkGetPhysicalDeviceXcbPresentationSupportKHR = (VkGetPhysicalDeviceXcbPresentationSupportKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceXcbPresentationSupportKHR"u8.AsPointer());
                vkCreateWaylandSurfaceKHR = (VkCreateWaylandSurfaceKHR)
                    getProc.Invoke(instance, "vkCreateWaylandSurfaceKHR"u8.AsPointer());
                vkGetPhysicalDeviceWaylandPresentationSupportKHR = (VkGetPhysicalDeviceWaylandPresentationSupportKHR)
                    getProc.Invoke(instance, "vkGetPhysicalDeviceWaylandPresentationSupportKHR"u8.AsPointer());
                vkCreateMetalSurfaceEXT = (VkCreateMetalSurfaceEXT)
                    getProc.Invoke(instance, "vkCreateMetalSurfaceEXT"u8.AsPointer());
                vkCreateAndroidSurfaceKHR = (VkCreateAndroidSurfaceKHR)
                    getProc.Invoke(instance, "vkCreateAndroidSurfaceKHR"u8.AsPointer());
            }
        }
    }
}
