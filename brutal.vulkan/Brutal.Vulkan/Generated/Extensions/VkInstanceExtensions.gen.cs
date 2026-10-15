namespace Brutal.VulkanApi
{
    public static unsafe partial class VkInstanceExtensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyInstance.html">vkDestroyInstance</see> - Destroy an instance of Vulkan
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To destroy an instance, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkDestroyInstance(
        ///         VkInstance                                  instance,
        ///         const VkAllocationCallbacks*                pAllocator);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static unsafe void DestroyInstanceInternal(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            VkAllocator? pAllocator
        )
        {
            handle.PInvoke.vkDestroyInstance.Invoke(handle.Handle, pAllocator);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDevices.html">vkEnumeratePhysicalDevices</see> - Enumerates the physical devices accessible to a Vulkan instance
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To retrieve a list of physical device objects representing the physical
        ///         devices installed in the system, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkEnumeratePhysicalDevices(
        ///         VkInstance                                  instance,
        ///         uint32_t*                                   pPhysicalDeviceCount,
        ///         VkPhysicalDevice*                           pPhysicalDevices);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumeratePhysicalDevicesInternal(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            ref int pPhysicalDeviceCount,
            scoped ReadOnlySpan<VkPhysicalDevice> pPhysicalDevices
        )
        {
            fixed (VkPhysicalDevice* pPhysicalDevicesFixed = pPhysicalDevices)
            fixed (int* pPhysicalDeviceCountFixed = &pPhysicalDeviceCount)
            {
                VkResult result = handle.PInvoke.vkEnumeratePhysicalDevices.Invoke(
                    handle.Handle,
                    pPhysicalDeviceCountFixed,
                    pPhysicalDevicesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumeratePhysicalDevices failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumeratePhysicalDevices failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkEnumeratePhysicalDevices failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumeratePhysicalDevices failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumeratePhysicalDevices failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumeratePhysicalDevicesInternal_Count(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle
        )
        {
            int pPhysicalDeviceCount = default;
            EnumeratePhysicalDevicesInternal(handle, ref pPhysicalDeviceCount, null);
            return pPhysicalDeviceCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pPhysicalDevices">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumeratePhysicalDevicesInternal_Write(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkPhysicalDevice> pPhysicalDevices
        )
        {
            int pPhysicalDeviceCount = pPhysicalDevices.Length;
            return EnumeratePhysicalDevicesInternal(handle, ref pPhysicalDeviceCount, pPhysicalDevices);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures.html">vkGetPhysicalDeviceFeatures</see> - Reports capabilities of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query supported features, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkGetPhysicalDeviceFeatures(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkPhysicalDeviceFeatures*                   pFeatures);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetFeatures(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceFeatures pFeatures
        )
        {
            fixed (VkPhysicalDeviceFeatures* pFeaturesFixed = &pFeatures)
            {
                handle.PInvoke.vkGetPhysicalDeviceFeatures.Invoke(handle.Handle, pFeaturesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceFeatures.</returns>
        public static VkPhysicalDeviceFeatures GetFeatures(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceFeatures outValue = new();
            GetFeatures(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties.html">vkGetPhysicalDeviceFormatProperties</see> - Lists physical device&amp;apos;s format capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query supported format features which are properties of the physical
        ///         device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkGetPhysicalDeviceFormatProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkFormat                                    format,
        ///         VkFormatProperties*                         pFormatProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetFormatProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            ref VkFormatProperties pFormatProperties
        )
        {
            fixed (VkFormatProperties* pFormatPropertiesFixed = &pFormatProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceFormatProperties.Invoke(
                    handle.Handle,
                    format,
                    pFormatPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkFormatProperties.</returns>
        public static VkFormatProperties GetFormatProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format
        )
        {
            VkFormatProperties outValue = new();
            GetFormatProperties(handle, format, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties.html">vkGetPhysicalDeviceImageFormatProperties</see> - Lists physical device&amp;apos;s image format capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceImageFormatProperties
        ///     </para>
        ///     <para>
        ///         To query additional capabilities specific to image types, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkGetPhysicalDeviceImageFormatProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkFormat                                    format,
        ///         VkImageType                                 type,
        ///         VkImageTiling                               tiling,
        ///         VkImageUsageFlags                           usage,
        ///         VkImageCreateFlags                          flags,
        ///         VkImageFormatProperties*                    pImageFormatProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetImageFormatProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkImageTiling tiling,
            VkImageUsageFlags usage,
            VkImageCreateFlags flags,
            ref VkImageFormatProperties pImageFormatProperties
        )
        {
            fixed (VkImageFormatProperties* pImageFormatPropertiesFixed = &pImageFormatProperties)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceImageFormatProperties.Invoke(
                    handle.Handle,
                    format,
                    type,
                    tiling,
                    usage,
                    flags,
                    pImageFormatPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorFormatNotSupported:
                        throw new VkResultError(
                            VkResult.ErrorFormatNotSupported,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties failed with error: VK_ERROR_FORMAT_NOT_SUPPORTED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkImageFormatProperties.</returns>
        public static VkImageFormatProperties GetImageFormatProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkImageTiling tiling,
            VkImageUsageFlags usage,
            VkImageCreateFlags flags
        )
        {
            VkImageFormatProperties outValue = new();
            GetImageFormatProperties(handle, format, type, tiling, usage, flags, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties.html">vkGetPhysicalDeviceProperties</see> - Returns properties of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query general properties of physical devices once enumerated, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkGetPhysicalDeviceProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkPhysicalDeviceProperties*                 pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceProperties pProperties
        )
        {
            fixed (VkPhysicalDeviceProperties* pPropertiesFixed = &pProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceProperties.Invoke(handle.Handle, pPropertiesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceProperties.</returns>
        public static VkPhysicalDeviceProperties GetProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceProperties outValue = new();
            GetProperties(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties.html">vkGetPhysicalDeviceQueueFamilyProperties</see> - Reports properties of the queues of the specified physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query properties of queues available on a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkGetPhysicalDeviceQueueFamilyProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pQueueFamilyPropertyCount,
        ///         VkQueueFamilyProperties*                    pQueueFamilyProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void GetQueueFamilyProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pQueueFamilyPropertyCount,
            scoped ReadOnlySpan<VkQueueFamilyProperties> pQueueFamilyProperties
        )
        {
            fixed (VkQueueFamilyProperties* pQueueFamilyPropertiesFixed = pQueueFamilyProperties)
            fixed (int* pQueueFamilyPropertyCountFixed = &pQueueFamilyPropertyCount)
            {
                handle.PInvoke.vkGetPhysicalDeviceQueueFamilyProperties.Invoke(
                    handle.Handle,
                    pQueueFamilyPropertyCountFixed,
                    pQueueFamilyPropertiesFixed
                );
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetQueueFamilyProperties_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pQueueFamilyPropertyCount = default;
            GetQueueFamilyProperties(handle, ref pQueueFamilyPropertyCount, null);
            return pQueueFamilyPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pQueueFamilyProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static void GetQueueFamilyProperties_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkQueueFamilyProperties> pQueueFamilyProperties
        )
        {
            int pQueueFamilyPropertyCount = pQueueFamilyProperties.Length;
            GetQueueFamilyProperties(handle, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties.html">vkGetPhysicalDeviceMemoryProperties</see> - Reports memory information for the specified physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query memory properties, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkGetPhysicalDeviceMemoryProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkPhysicalDeviceMemoryProperties*           pMemoryProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetMemoryProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceMemoryProperties pMemoryProperties
        )
        {
            fixed (VkPhysicalDeviceMemoryProperties* pMemoryPropertiesFixed = &pMemoryProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceMemoryProperties.Invoke(handle.Handle, pMemoryPropertiesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceMemoryProperties.</returns>
        public static VkPhysicalDeviceMemoryProperties GetMemoryProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceMemoryProperties outValue = new();
            GetMemoryProperties(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetInstanceProcAddr.html">vkGetInstanceProcAddr</see> - Return a function pointer for a command
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Function pointers for all Vulkan commands <i>can</i> be obtained by calling:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         PFN_vkVoidFunction vkGetInstanceProcAddr(
        ///         VkInstance                                  instance,
        ///         const char*                                 pName);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe PfnVkVoidFunction GetProcAddr(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<byte> pName
        )
        {
            fixed (byte* pNameFixed = pName)
            {
                return handle.PInvoke.vkGetInstanceProcAddr.Invoke(handle.Handle, pNameFixed);
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDevice.html">vkCreateDevice</see> - Create a new device instance
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         A logical device is created as a <i>connection</i> to a physical device.
        ///         To create a logical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkCreateDevice(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkDeviceCreateInfo*                   pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkDevice*                                   pDevice);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static unsafe VkDevice CreateDeviceInternal(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkDeviceCreateInfo pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkDeviceCreateInfo* pCreateInfoFixed = &pCreateInfo)
            {
                VkDevice pDeviceLocal = default;
                VkResult result = handle.PInvoke.vkCreateDevice.Invoke(
                    handle.Handle,
                    pCreateInfoFixed,
                    pAllocator,
                    &pDeviceLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorExtensionNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorExtensionNotPresent,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_EXTENSION_NOT_PRESENT"
                        );
                    case VkResult.ErrorFeatureNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorFeatureNotPresent,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_FEATURE_NOT_PRESENT"
                        );
                    case VkResult.ErrorTooManyObjects:
                        throw new VkResultError(
                            VkResult.ErrorTooManyObjects,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                        );
                    case VkResult.ErrorDeviceLost:
                        throw new VkResultError(
                            VkResult.ErrorDeviceLost,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_DEVICE_LOST"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateDevice failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pDeviceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceExtensionProperties.html">vkEnumerateDeviceExtensionProperties</see> - Returns properties of available physical device extensions
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkEnumerateDeviceExtensionProperties
        ///     </para>
        ///     <para>
        ///         To query the extensions available to a given physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkEnumerateDeviceExtensionProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const char*                                 pLayerName,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkExtensionProperties*                      pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumerateDeviceExtensionProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<byte> pLayerName,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkExtensionProperties> pProperties
        )
        {
            fixed (VkExtensionProperties* pPropertiesFixed = pProperties)
            fixed (byte* pLayerNameFixed = pLayerName)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkEnumerateDeviceExtensionProperties.Invoke(
                    handle.Handle,
                    pLayerNameFixed,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumerateDeviceExtensionProperties failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumerateDeviceExtensionProperties failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorLayerNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorLayerNotPresent,
                            "Vulkan call to vkEnumerateDeviceExtensionProperties failed with error: VK_ERROR_LAYER_NOT_PRESENT"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumerateDeviceExtensionProperties failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumerateDeviceExtensionProperties failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumerateDeviceExtensionProperties_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<byte> pLayerName
        )
        {
            int pPropertyCount = default;
            EnumerateDeviceExtensionProperties(handle, pLayerName, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumerateDeviceExtensionProperties_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<byte> pLayerName,
            scoped ReadOnlySpan<VkExtensionProperties> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return EnumerateDeviceExtensionProperties(handle, pLayerName, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateDeviceLayerProperties.html">vkEnumerateDeviceLayerProperties</see> - Returns properties of available physical device layers
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkEnumerateDeviceLayerProperties
        ///     </para>
        ///     <para>
        ///         To enumerate device layers, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkEnumerateDeviceLayerProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkLayerProperties*                          pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumerateDeviceLayerProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkLayerProperties> pProperties
        )
        {
            fixed (VkLayerProperties* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkEnumerateDeviceLayerProperties.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumerateDeviceLayerProperties failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumerateDeviceLayerProperties failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumerateDeviceLayerProperties failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumerateDeviceLayerProperties failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumerateDeviceLayerProperties_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            EnumerateDeviceLayerProperties(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumerateDeviceLayerProperties_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkLayerProperties> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return EnumerateDeviceLayerProperties(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties.html">vkGetPhysicalDeviceSparseImageFormatProperties</see> - Retrieve properties of an image format applied to sparse images
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <c>vkGetPhysicalDeviceSparseImageFormatProperties</c> returns an array of
        ///         <c>VkSparseImageFormatProperties</c>.
        ///         Each element describes properties for one set of image aspects that are
        ///         bound simultaneously for a <c>VkImage</c> created with the provided image
        ///         creation parameters.
        ///         This is usually one element for each aspect in the image, but for
        ///         interleaved depth/stencil images there is only one element describing the
        ///         combined aspects.
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         void vkGetPhysicalDeviceSparseImageFormatProperties(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkFormat                                    format,
        ///         VkImageType                                 type,
        ///         VkSampleCountFlagBits                       samples,
        ///         VkImageUsageFlags                           usage,
        ///         VkImageTiling                               tiling,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkSparseImageFormatProperties*              pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void GetSparseImageFormatProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkSampleCountFlags samples,
            VkImageUsageFlags usage,
            VkImageTiling tiling,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkSparseImageFormatProperties> pProperties
        )
        {
            fixed (VkSparseImageFormatProperties* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                handle.PInvoke.vkGetPhysicalDeviceSparseImageFormatProperties.Invoke(
                    handle.Handle,
                    format,
                    type,
                    samples,
                    usage,
                    tiling,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetSparseImageFormatProperties_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkSampleCountFlags samples,
            VkImageUsageFlags usage,
            VkImageTiling tiling
        )
        {
            int pPropertyCount = default;
            GetSparseImageFormatProperties(handle, format, type, samples, usage, tiling, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static void GetSparseImageFormatProperties_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkSampleCountFlags samples,
            VkImageUsageFlags usage,
            VkImageTiling tiling,
            scoped ReadOnlySpan<VkSparseImageFormatProperties> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            GetSparseImageFormatProperties(
                handle,
                format,
                type,
                samples,
                usage,
                tiling,
                ref pPropertyCount,
                pProperties
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceGroups.html">vkEnumeratePhysicalDeviceGroups</see> - Enumerates groups of physical devices that can be used to create a single logical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To retrieve a list of the device groups present in the system, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumeratePhysicalDeviceGroups(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            ref int pPhysicalDeviceGroupCount,
            scoped ReadOnlySpan<VkPhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties
        )
        {
            fixed (
                VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupPropertiesFixed = pPhysicalDeviceGroupProperties
            )
            fixed (int* pPhysicalDeviceGroupCountFixed = &pPhysicalDeviceGroupCount)
            {
                VkResult result = handle.PInvoke.vkEnumeratePhysicalDeviceGroups.Invoke(
                    handle.Handle,
                    pPhysicalDeviceGroupCountFixed,
                    pPhysicalDeviceGroupPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceGroups failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceGroups failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceGroups failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumeratePhysicalDeviceGroups failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceGroups failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumeratePhysicalDeviceGroups_Count(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle
        )
        {
            int pPhysicalDeviceGroupCount = default;
            EnumeratePhysicalDeviceGroups(handle, ref pPhysicalDeviceGroupCount, null);
            return pPhysicalDeviceGroupCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pPhysicalDeviceGroupProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumeratePhysicalDeviceGroups_Write(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkPhysicalDeviceGroupProperties> pPhysicalDeviceGroupProperties
        )
        {
            int pPhysicalDeviceGroupCount = pPhysicalDeviceGroupProperties.Length;
            return EnumeratePhysicalDeviceGroups(handle, ref pPhysicalDeviceGroupCount, pPhysicalDeviceGroupProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFeatures2.html">vkGetPhysicalDeviceFeatures2</see> - Reports capabilities of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query supported features defined by the core or extensions, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetFeatures2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceFeatures2 pFeatures
        )
        {
            fixed (VkPhysicalDeviceFeatures2* pFeaturesFixed = &pFeatures)
            {
                handle.PInvoke.vkGetPhysicalDeviceFeatures2.Invoke(handle.Handle, pFeaturesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceFeatures2.</returns>
        public static VkPhysicalDeviceFeatures2 GetFeatures2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceFeatures2 outValue = new();
            GetFeatures2(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceProperties2.html">vkGetPhysicalDeviceProperties2</see> - Returns properties of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query general properties of physical devices once enumerated, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceProperties2 pProperties
        )
        {
            fixed (VkPhysicalDeviceProperties2* pPropertiesFixed = &pProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceProperties2.Invoke(handle.Handle, pPropertiesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceProperties2.</returns>
        public static VkPhysicalDeviceProperties2 GetProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceProperties2 outValue = new();
            GetProperties2(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFormatProperties2.html">vkGetPhysicalDeviceFormatProperties2</see> - Lists physical device&amp;apos;s format capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query supported format features which are properties of the physical
        ///         device, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetFormatProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            ref VkFormatProperties2 pFormatProperties
        )
        {
            fixed (VkFormatProperties2* pFormatPropertiesFixed = &pFormatProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceFormatProperties2.Invoke(
                    handle.Handle,
                    format,
                    pFormatPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkFormatProperties2.</returns>
        public static VkFormatProperties2 GetFormatProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format
        )
        {
            VkFormatProperties2 outValue = new();
            GetFormatProperties2(handle, format, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceImageFormatProperties2.html">vkGetPhysicalDeviceImageFormatProperties2</see> - Lists physical device&amp;apos;s image format capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceImageFormatProperties2
        ///     </para>
        ///     <para>
        ///         To query additional capabilities specific to image types, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetImageFormatProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo,
            ref VkImageFormatProperties2 pImageFormatProperties
        )
        {
            fixed (VkImageFormatProperties2* pImageFormatPropertiesFixed = &pImageFormatProperties)
            fixed (VkPhysicalDeviceImageFormatInfo2* pImageFormatInfoFixed = &pImageFormatInfo)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceImageFormatProperties2.Invoke(
                    handle.Handle,
                    pImageFormatInfoFixed,
                    pImageFormatPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorFormatNotSupported:
                        throw new VkResultError(
                            VkResult.ErrorFormatNotSupported,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_FORMAT_NOT_SUPPORTED"
                        );
                    case VkResult.ErrorImageUsageNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorImageUsageNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileOperationNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileOperationNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileFormatNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileFormatNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoPictureLayoutNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoPictureLayoutNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileCodecNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileCodecNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceImageFormatProperties2 failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkImageFormatProperties2.</returns>
        public static VkImageFormatProperties2 GetImageFormatProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo
        )
        {
            VkImageFormatProperties2 outValue = new();
            GetImageFormatProperties2(handle, pImageFormatInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyProperties2.html">vkGetPhysicalDeviceQueueFamilyProperties2</see> - Reports properties of the queues of the specified physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query properties of queues available on a physical device, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void GetQueueFamilyProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pQueueFamilyPropertyCount,
            scoped ReadOnlySpan<VkQueueFamilyProperties2> pQueueFamilyProperties
        )
        {
            fixed (VkQueueFamilyProperties2* pQueueFamilyPropertiesFixed = pQueueFamilyProperties)
            fixed (int* pQueueFamilyPropertyCountFixed = &pQueueFamilyPropertyCount)
            {
                handle.PInvoke.vkGetPhysicalDeviceQueueFamilyProperties2.Invoke(
                    handle.Handle,
                    pQueueFamilyPropertyCountFixed,
                    pQueueFamilyPropertiesFixed
                );
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetQueueFamilyProperties2_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pQueueFamilyPropertyCount = default;
            GetQueueFamilyProperties2(handle, ref pQueueFamilyPropertyCount, null);
            return pQueueFamilyPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pQueueFamilyProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static void GetQueueFamilyProperties2_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkQueueFamilyProperties2> pQueueFamilyProperties
        )
        {
            int pQueueFamilyPropertyCount = pQueueFamilyProperties.Length;
            GetQueueFamilyProperties2(handle, ref pQueueFamilyPropertyCount, pQueueFamilyProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMemoryProperties2.html">vkGetPhysicalDeviceMemoryProperties2</see> - Reports memory information for the specified physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query memory properties, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetMemoryProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceMemoryProperties2 pMemoryProperties
        )
        {
            fixed (VkPhysicalDeviceMemoryProperties2* pMemoryPropertiesFixed = &pMemoryProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceMemoryProperties2.Invoke(handle.Handle, pMemoryPropertiesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceMemoryProperties2.</returns>
        public static VkPhysicalDeviceMemoryProperties2 GetMemoryProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceMemoryProperties2 outValue = new();
            GetMemoryProperties2(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSparseImageFormatProperties2.html">vkGetPhysicalDeviceSparseImageFormatProperties2</see> - Retrieve properties of an image format applied to sparse images
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <c>vkGetPhysicalDeviceSparseImageFormatProperties2</c> returns an array of
        ///         <c>VkSparseImageFormatProperties2</c>.
        ///         Each element describes properties for one set of image aspects that are
        ///         bound simultaneously for a <c>VkImage</c> created with the provided image
        ///         creation parameters.
        ///         This is usually one element for each aspect in the image, but for
        ///         interleaved depth/stencil images there is only one element describing the
        ///         combined aspects.
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void GetSparseImageFormatProperties2(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkSparseImageFormatProperties2> pProperties
        )
        {
            fixed (VkSparseImageFormatProperties2* pPropertiesFixed = pProperties)
            fixed (VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfoFixed = &pFormatInfo)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                handle.PInvoke.vkGetPhysicalDeviceSparseImageFormatProperties2.Invoke(
                    handle.Handle,
                    pFormatInfoFixed,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetSparseImageFormatProperties2_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo
        )
        {
            int pPropertyCount = default;
            GetSparseImageFormatProperties2(handle, pFormatInfo, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static void GetSparseImageFormatProperties2_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo,
            scoped ReadOnlySpan<VkSparseImageFormatProperties2> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            GetSparseImageFormatProperties2(handle, pFormatInfo, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalBufferProperties.html">vkGetPhysicalDeviceExternalBufferProperties</see> - Query external handle types supported by buffers
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the external handle types supported by buffers, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalBufferProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo,
            ref VkExternalBufferProperties pExternalBufferProperties
        )
        {
            fixed (VkExternalBufferProperties* pExternalBufferPropertiesFixed = &pExternalBufferProperties)
            fixed (VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfoFixed = &pExternalBufferInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalBufferProperties.Invoke(
                    handle.Handle,
                    pExternalBufferInfoFixed,
                    pExternalBufferPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalBufferProperties.</returns>
        public static VkExternalBufferProperties GetExternalBufferProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo
        )
        {
            VkExternalBufferProperties outValue = new();
            GetExternalBufferProperties(handle, pExternalBufferInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalFenceProperties.html">vkGetPhysicalDeviceExternalFenceProperties</see> - Function for querying external fence handle capabilities.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Fences may: support import and export of their
        ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-fences-payloads">payload^</see> to external handles.
        ///         To query the external handle types supported by fences, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalFenceProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo,
            ref VkExternalFenceProperties pExternalFenceProperties
        )
        {
            fixed (VkExternalFenceProperties* pExternalFencePropertiesFixed = &pExternalFenceProperties)
            fixed (VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfoFixed = &pExternalFenceInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalFenceProperties.Invoke(
                    handle.Handle,
                    pExternalFenceInfoFixed,
                    pExternalFencePropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalFenceProperties.</returns>
        public static VkExternalFenceProperties GetExternalFenceProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo
        )
        {
            VkExternalFenceProperties outValue = new();
            GetExternalFenceProperties(handle, pExternalFenceInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalSemaphoreProperties.html">vkGetPhysicalDeviceExternalSemaphoreProperties</see> - Function for querying external semaphore handle capabilities.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Semaphores may: support import and export of their
        ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#synchronization-semaphores-payloads">payload^</see> to external handles.
        ///         To query the external handle types supported by semaphores, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalSemaphoreProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo,
            ref VkExternalSemaphoreProperties pExternalSemaphoreProperties
        )
        {
            fixed (VkExternalSemaphoreProperties* pExternalSemaphorePropertiesFixed = &pExternalSemaphoreProperties)
            fixed (VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfoFixed = &pExternalSemaphoreInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalSemaphoreProperties.Invoke(
                    handle.Handle,
                    pExternalSemaphoreInfoFixed,
                    pExternalSemaphorePropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalSemaphoreProperties.</returns>
        public static VkExternalSemaphoreProperties GetExternalSemaphoreProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo
        )
        {
            VkExternalSemaphoreProperties outValue = new();
            GetExternalSemaphoreProperties(handle, pExternalSemaphoreInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceToolProperties.html">vkGetPhysicalDeviceToolProperties</see> - Reports properties of tools active on the specified physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Information about tools providing debugging, profiling, or similar services,
        ///         active for a given physical device, can be obtained by calling:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetToolProperties(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pToolCount,
            scoped ReadOnlySpan<VkPhysicalDeviceToolProperties> pToolProperties
        )
        {
            fixed (VkPhysicalDeviceToolProperties* pToolPropertiesFixed = pToolProperties)
            fixed (int* pToolCountFixed = &pToolCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceToolProperties.Invoke(
                    handle.Handle,
                    pToolCountFixed,
                    pToolPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceToolProperties failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceToolProperties failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceToolProperties failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetToolProperties_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pToolCount = default;
            GetToolProperties(handle, ref pToolCount, null);
            return pToolCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pToolProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetToolProperties_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkPhysicalDeviceToolProperties> pToolProperties
        )
        {
            int pToolCount = pToolProperties.Length;
            return GetToolProperties(handle, ref pToolCount, pToolProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroySurfaceKHR.html">vkDestroySurfaceKHR</see> - Destroy a VkSurfaceKHR object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To destroy a <c>VkSurfaceKHR</c> object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_surface
        ///         void vkDestroySurfaceKHR(
        ///         VkInstance                                  instance,
        ///         VkSurfaceKHR                                surface,
        ///         const VkAllocationCallbacks*                pAllocator);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void DestroySurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            VkAllocator? pAllocator
        )
        {
            handle.PInvoke.vkDestroySurfaceKHR.Invoke(handle.Handle, surface, pAllocator);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceSupportKHR.html">vkGetPhysicalDeviceSurfaceSupportKHR</see> - Query if presentation is supported
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfaceSupportKHR
        ///     </para>
        ///     <para>
        ///         To determine whether a queue family of a physical device supports
        ///         presentation to a given surface, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_surface
        ///         VkResult vkGetPhysicalDeviceSurfaceSupportKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         VkSurfaceKHR                                surface,
        ///         VkBool32*                                   pSupported);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe Brutal.Bool32 GetSurfaceSupportKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            VkSurfaceKHR surface
        )
        {
            Brutal.Bool32 pSupportedLocal = default;
            VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfaceSupportKHR.Invoke(
                handle.Handle,
                queueFamilyIndex,
                surface,
                &pSupportedLocal
            );
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkGetPhysicalDeviceSurfaceSupportKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorOutOfDeviceMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfDeviceMemory,
                        "Vulkan call to vkGetPhysicalDeviceSurfaceSupportKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                    );
                case VkResult.ErrorSurfaceLostKHR:
                    throw new VkResultError(
                        VkResult.ErrorSurfaceLostKHR,
                        "Vulkan call to vkGetPhysicalDeviceSurfaceSupportKHR failed with error: VK_ERROR_SURFACE_LOST_KHR"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkGetPhysicalDeviceSurfaceSupportKHR failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkGetPhysicalDeviceSurfaceSupportKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }

            return pSupportedLocal;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilitiesKHR.html">vkGetPhysicalDeviceSurfaceCapabilitiesKHR</see> - Query surface capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfaceCapabilitiesKHR
        ///     </para>
        ///     <para>
        ///         To query the basic capabilities of a surface, needed in order to create a
        ///         swapchain, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_surface
        ///         VkResult vkGetPhysicalDeviceSurfaceCapabilitiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkSurfaceKHR                                surface,
        ///         VkSurfaceCapabilitiesKHR*                   pSurfaceCapabilities);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetSurfaceCapabilitiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            ref VkSurfaceCapabilitiesKHR pSurfaceCapabilities
        )
        {
            fixed (VkSurfaceCapabilitiesKHR* pSurfaceCapabilitiesFixed = &pSurfaceCapabilities)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfaceCapabilitiesKHR.Invoke(
                    handle.Handle,
                    surface,
                    pSurfaceCapabilitiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilitiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilitiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilitiesKHR failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilitiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilitiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkSurfaceCapabilitiesKHR.</returns>
        public static VkSurfaceCapabilitiesKHR GetSurfaceCapabilitiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface
        )
        {
            VkSurfaceCapabilitiesKHR outValue = new();
            GetSurfaceCapabilitiesKHR(handle, surface, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormatsKHR.html">vkGetPhysicalDeviceSurfaceFormatsKHR</see> - Query color formats supported by surface
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfaceFormatsKHR
        ///     </para>
        ///     <para>
        ///         To query the supported swapchain format-color space pairs for a surface,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_surface
        ///         VkResult vkGetPhysicalDeviceSurfaceFormatsKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkSurfaceKHR                                surface,
        ///         uint32_t*                                   pSurfaceFormatCount,
        ///         VkSurfaceFormatKHR*                         pSurfaceFormats);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetSurfaceFormatsKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            ref int pSurfaceFormatCount,
            scoped ReadOnlySpan<VkSurfaceFormatKHR> pSurfaceFormats
        )
        {
            fixed (VkSurfaceFormatKHR* pSurfaceFormatsFixed = pSurfaceFormats)
            fixed (int* pSurfaceFormatCountFixed = &pSurfaceFormatCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfaceFormatsKHR.Invoke(
                    handle.Handle,
                    surface,
                    pSurfaceFormatCountFixed,
                    pSurfaceFormatsFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormatsKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormatsKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormatsKHR failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormatsKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormatsKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetSurfaceFormatsKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface
        )
        {
            int pSurfaceFormatCount = default;
            GetSurfaceFormatsKHR(handle, surface, ref pSurfaceFormatCount, null);
            return pSurfaceFormatCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pSurfaceFormats">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetSurfaceFormatsKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            scoped ReadOnlySpan<VkSurfaceFormatKHR> pSurfaceFormats
        )
        {
            int pSurfaceFormatCount = pSurfaceFormats.Length;
            return GetSurfaceFormatsKHR(handle, surface, ref pSurfaceFormatCount, pSurfaceFormats);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModesKHR.html">vkGetPhysicalDeviceSurfacePresentModesKHR</see> - Query supported presentation modes
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfacePresentModesKHR
        ///     </para>
        ///     <para>
        ///         To query the supported presentation modes for a surface, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_surface
        ///         VkResult vkGetPhysicalDeviceSurfacePresentModesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkSurfaceKHR                                surface,
        ///         uint32_t*                                   pPresentModeCount,
        ///         VkPresentModeKHR*                           pPresentModes);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetSurfacePresentModesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            ref int pPresentModeCount,
            scoped ReadOnlySpan<VkPresentModeKHR> pPresentModes
        )
        {
            fixed (VkPresentModeKHR* pPresentModesFixed = pPresentModes)
            fixed (int* pPresentModeCountFixed = &pPresentModeCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfacePresentModesKHR.Invoke(
                    handle.Handle,
                    surface,
                    pPresentModeCountFixed,
                    pPresentModesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModesKHR failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetSurfacePresentModesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface
        )
        {
            int pPresentModeCount = default;
            GetSurfacePresentModesKHR(handle, surface, ref pPresentModeCount, null);
            return pPresentModeCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pPresentModes">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetSurfacePresentModesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            scoped ReadOnlySpan<VkPresentModeKHR> pPresentModes
        )
        {
            int pPresentModeCount = pPresentModes.Length;
            return GetSurfacePresentModesKHR(handle, surface, ref pPresentModeCount, pPresentModes);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html">vkGetPhysicalDevicePresentRectanglesKHR</see> - Query present rectangles for a surface on a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDevicePresentRectanglesKHR
        ///     </para>
        ///     <para>
        ///         When using <c>VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR</c>,
        ///         the application may: need to know which regions of the surface are used when
        ///         presenting locally on each physical device.
        ///         Presentation of swapchain images to this surface need only have valid
        ///         contents in the regions returned by this command.
        ///     </para>
        ///     <para>
        ///         To query a set of rectangles used in presentation on the physical device,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_1 with VK_KHR_swapchain, VK_KHR_device_group with VK_KHR_surface
        ///         VkResult vkGetPhysicalDevicePresentRectanglesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkSurfaceKHR                                surface,
        ///         uint32_t*                                   pRectCount,
        ///         VkRect2D*                                   pRects);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetPresentRectanglesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            ref int pRectCount,
            scoped ReadOnlySpan<VkRect2D> pRects
        )
        {
            fixed (VkRect2D* pRectsFixed = pRects)
            fixed (int* pRectCountFixed = &pRectCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDevicePresentRectanglesKHR.Invoke(
                    handle.Handle,
                    surface,
                    pRectCountFixed,
                    pRectsFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDevicePresentRectanglesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDevicePresentRectanglesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDevicePresentRectanglesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDevicePresentRectanglesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetPresentRectanglesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface
        )
        {
            int pRectCount = default;
            GetPresentRectanglesKHR(handle, surface, ref pRectCount, null);
            return pRectCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pRects">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetPresentRectanglesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            scoped ReadOnlySpan<VkRect2D> pRects
        )
        {
            int pRectCount = pRects.Length;
            return GetPresentRectanglesKHR(handle, surface, ref pRectCount, pRects);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPropertiesKHR.html">vkGetPhysicalDeviceDisplayPropertiesKHR</see> - Query information about the available displays
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceDisplayPropertiesKHR
        ///     </para>
        ///     <para>
        ///         Various functions are provided for enumerating the available display devices
        ///         present on a Vulkan physical device.
        ///         To query information about the available displays, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkGetPhysicalDeviceDisplayPropertiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkDisplayPropertiesKHR*                     pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkDisplayPropertiesKHR> pProperties
        )
        {
            fixed (VkDisplayPropertiesKHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceDisplayPropertiesKHR.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPropertiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayPropertiesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetDisplayPropertiesKHR(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayPropertiesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkDisplayPropertiesKHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetDisplayPropertiesKHR(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlanePropertiesKHR.html">vkGetPhysicalDeviceDisplayPlanePropertiesKHR</see> - Query the plane properties
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceDisplayPlanePropertiesKHR
        ///     </para>
        ///     <para>
        ///         Images are presented to individual planes on a display.
        ///         Devices <i>must</i> support at least one plane on each display.
        ///         Planes <i>can</i> be stacked and blended to composite multiple images on one
        ///         display.
        ///         Devices may: support only a fixed stacking order and fixed mapping between
        ///         planes and displays, or they may: allow arbitrary application-specified
        ///         stacking orders and mappings between planes and displays.
        ///         To query the properties of device display planes, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkGetPhysicalDeviceDisplayPlanePropertiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkDisplayPlanePropertiesKHR*                pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayPlanePropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkDisplayPlanePropertiesKHR> pProperties
        )
        {
            fixed (VkDisplayPlanePropertiesKHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceDisplayPlanePropertiesKHR.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlanePropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlanePropertiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlanePropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlanePropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayPlanePropertiesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetDisplayPlanePropertiesKHR(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayPlanePropertiesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkDisplayPlanePropertiesKHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetDisplayPlanePropertiesKHR(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneSupportedDisplaysKHR.html">vkGetDisplayPlaneSupportedDisplaysKHR</see> - Query the list of displays a plane supports
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetDisplayPlaneSupportedDisplaysKHR
        ///     </para>
        ///     <para>
        ///         To determine which displays a plane is usable with, call
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkGetDisplayPlaneSupportedDisplaysKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    planeIndex,
        ///         uint32_t*                                   pDisplayCount,
        ///         VkDisplayKHR*                               pDisplays);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayPlaneSupportedDisplaysKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int planeIndex,
            ref int pDisplayCount,
            scoped ReadOnlySpan<VkDisplayKHR> pDisplays
        )
        {
            fixed (VkDisplayKHR* pDisplaysFixed = pDisplays)
            fixed (int* pDisplayCountFixed = &pDisplayCount)
            {
                VkResult result = handle.PInvoke.vkGetDisplayPlaneSupportedDisplaysKHR.Invoke(
                    handle.Handle,
                    planeIndex,
                    pDisplayCountFixed,
                    pDisplaysFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetDisplayPlaneSupportedDisplaysKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetDisplayPlaneSupportedDisplaysKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetDisplayPlaneSupportedDisplaysKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetDisplayPlaneSupportedDisplaysKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayPlaneSupportedDisplaysKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int planeIndex
        )
        {
            int pDisplayCount = default;
            GetDisplayPlaneSupportedDisplaysKHR(handle, planeIndex, ref pDisplayCount, null);
            return pDisplayCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pDisplays">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayPlaneSupportedDisplaysKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int planeIndex,
            scoped ReadOnlySpan<VkDisplayKHR> pDisplays
        )
        {
            int pDisplayCount = pDisplays.Length;
            return GetDisplayPlaneSupportedDisplaysKHR(handle, planeIndex, ref pDisplayCount, pDisplays);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModePropertiesKHR.html">vkGetDisplayModePropertiesKHR</see> - Query the set of mode properties supported by the display
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetDisplayModePropertiesKHR
        ///     </para>
        ///     <para>
        ///         Each display has one or more supported modes associated with it by default.
        ///         These built-in modes are queried by calling:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkGetDisplayModePropertiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDisplayKHR                                display,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkDisplayModePropertiesKHR*                 pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayModePropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkDisplayModePropertiesKHR> pProperties
        )
        {
            fixed (VkDisplayModePropertiesKHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetDisplayModePropertiesKHR.Invoke(
                    handle.Handle,
                    display,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetDisplayModePropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetDisplayModePropertiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetDisplayModePropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetDisplayModePropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayModePropertiesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display
        )
        {
            int pPropertyCount = default;
            GetDisplayModePropertiesKHR(handle, display, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayModePropertiesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display,
            scoped ReadOnlySpan<VkDisplayModePropertiesKHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetDisplayModePropertiesKHR(handle, display, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayModeKHR.html">vkCreateDisplayModeKHR</see> - Create a display mode
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateDisplayModeKHR
        ///     </para>
        ///     <para>
        ///         Additional modes may: also be created by calling:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkCreateDisplayModeKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDisplayKHR                                display,
        ///         const VkDisplayModeCreateInfoKHR*           pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkDisplayModeKHR*                           pMode);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkDisplayModeKHR CreateDisplayModeKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display,
            in VkDisplayModeCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkDisplayModeCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkDisplayModeKHR pModeLocal = default;
                VkResult result = handle.PInvoke.vkCreateDisplayModeKHR.Invoke(
                    handle.Handle,
                    display,
                    pCreateInfoFixed,
                    pAllocator,
                    &pModeLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateDisplayModeKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateDisplayModeKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkCreateDisplayModeKHR failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateDisplayModeKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateDisplayModeKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pModeLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilitiesKHR.html">vkGetDisplayPlaneCapabilitiesKHR</see> - Query capabilities of a mode and plane combination
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetDisplayPlaneCapabilitiesKHR
        ///     </para>
        ///     <para>
        ///         Applications that wish to present directly to a display <i>must</i> select which
        ///         layer, or &quot;`plane`&quot; of the display they wish to target, and a mode to use
        ///         with the display.
        ///         Each display supports at least one plane.
        ///         The capabilities of a given mode and plane combination are determined by
        ///         calling:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkGetDisplayPlaneCapabilitiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDisplayModeKHR                            mode,
        ///         uint32_t                                    planeIndex,
        ///         VkDisplayPlaneCapabilitiesKHR*              pCapabilities);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetDisplayPlaneCapabilitiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayModeKHR mode,
            int planeIndex,
            ref VkDisplayPlaneCapabilitiesKHR pCapabilities
        )
        {
            fixed (VkDisplayPlaneCapabilitiesKHR* pCapabilitiesFixed = &pCapabilities)
            {
                VkResult result = handle.PInvoke.vkGetDisplayPlaneCapabilitiesKHR.Invoke(
                    handle.Handle,
                    mode,
                    planeIndex,
                    pCapabilitiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetDisplayPlaneCapabilitiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetDisplayPlaneCapabilitiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetDisplayPlaneCapabilitiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetDisplayPlaneCapabilitiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkDisplayPlaneCapabilitiesKHR.</returns>
        public static VkDisplayPlaneCapabilitiesKHR GetDisplayPlaneCapabilitiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayModeKHR mode,
            int planeIndex
        )
        {
            VkDisplayPlaneCapabilitiesKHR outValue = new();
            GetDisplayPlaneCapabilitiesKHR(handle, mode, planeIndex, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayPlaneSurfaceKHR.html">vkCreateDisplayPlaneSurfaceKHR</see> - Create a &lt;c&gt;VkSurfaceKHR&lt;/c&gt; structure representing a display plane and mode
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateDisplayPlaneSurfaceKHR
        ///     </para>
        ///     <para>
        ///         A complete display configuration includes a mode, one or more display planes
        ///         and any parameters describing their behavior, and parameters describing some
        ///         aspects of the images associated with those planes.
        ///         Display surfaces describe the configuration of a single plane within a
        ///         complete display configuration.
        ///         To create a <c>VkSurfaceKHR</c> object for a display plane, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_display
        ///         VkResult vkCreateDisplayPlaneSurfaceKHR(
        ///         VkInstance                                  instance,
        ///         const VkDisplaySurfaceCreateInfoKHR*        pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkSurfaceKHR CreateDisplayPlaneSurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkDisplaySurfaceCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkDisplaySurfaceCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateDisplayPlaneSurfaceKHR.Invoke(
                    handle.Handle,
                    pCreateInfoFixed,
                    pAllocator,
                    &pSurfaceLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateDisplayPlaneSurfaceKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateDisplayPlaneSurfaceKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateDisplayPlaneSurfaceKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateDisplayPlaneSurfaceKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoCapabilitiesKHR.html">vkGetPhysicalDeviceVideoCapabilitiesKHR</see> - Query video coding capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query video coding capabilities for a specific video profile, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_video_queue
        ///         VkResult vkGetPhysicalDeviceVideoCapabilitiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkVideoProfileInfoKHR*                pVideoProfile,
        ///         VkVideoCapabilitiesKHR*                     pCapabilities);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetVideoCapabilitiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkVideoProfileInfoKHR* pVideoProfile,
            ref VkVideoCapabilitiesKHR pCapabilities
        )
        {
            fixed (VkVideoCapabilitiesKHR* pCapabilitiesFixed = &pCapabilities)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceVideoCapabilitiesKHR.Invoke(
                    handle.Handle,
                    pVideoProfile,
                    pCapabilitiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorVideoProfileOperationNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileOperationNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileFormatNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileFormatNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoPictureLayoutNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoPictureLayoutNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileCodecNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileCodecNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceVideoCapabilitiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkVideoCapabilitiesKHR.</returns>
        public static unsafe VkVideoCapabilitiesKHR GetVideoCapabilitiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkVideoProfileInfoKHR* pVideoProfile
        )
        {
            VkVideoCapabilitiesKHR outValue = new();
            GetVideoCapabilitiesKHR(handle, pVideoProfile, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoFormatPropertiesKHR.html">vkGetPhysicalDeviceVideoFormatPropertiesKHR</see> - Query supported video decode and encode image formats and capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the supported video formats and corresponding capabilities for
        ///         a specific video profile, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_video_queue
        ///         VkResult vkGetPhysicalDeviceVideoFormatPropertiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceVideoFormatInfoKHR*   pVideoFormatInfo,
        ///         uint32_t*                                   pVideoFormatPropertyCount,
        ///         VkVideoFormatPropertiesKHR*                 pVideoFormatProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetVideoFormatPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo,
            ref int pVideoFormatPropertyCount,
            scoped ReadOnlySpan<VkVideoFormatPropertiesKHR> pVideoFormatProperties
        )
        {
            fixed (VkVideoFormatPropertiesKHR* pVideoFormatPropertiesFixed = pVideoFormatProperties)
            fixed (VkPhysicalDeviceVideoFormatInfoKHR* pVideoFormatInfoFixed = &pVideoFormatInfo)
            fixed (int* pVideoFormatPropertyCountFixed = &pVideoFormatPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceVideoFormatPropertiesKHR.Invoke(
                    handle.Handle,
                    pVideoFormatInfoFixed,
                    pVideoFormatPropertyCountFixed,
                    pVideoFormatPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorImageUsageNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorImageUsageNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileOperationNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileOperationNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileFormatNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileFormatNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoPictureLayoutNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoPictureLayoutNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileCodecNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileCodecNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceVideoFormatPropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetVideoFormatPropertiesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo
        )
        {
            int pVideoFormatPropertyCount = default;
            GetVideoFormatPropertiesKHR(handle, pVideoFormatInfo, ref pVideoFormatPropertyCount, null);
            return pVideoFormatPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pVideoFormatProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetVideoFormatPropertiesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceVideoFormatInfoKHR pVideoFormatInfo,
            scoped ReadOnlySpan<VkVideoFormatPropertiesKHR> pVideoFormatProperties
        )
        {
            int pVideoFormatPropertyCount = pVideoFormatProperties.Length;
            return GetVideoFormatPropertiesKHR(
                handle,
                pVideoFormatInfo,
                ref pVideoFormatPropertyCount,
                pVideoFormatProperties
            );
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetFeatures2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceFeatures2 pFeatures
        )
        {
            fixed (VkPhysicalDeviceFeatures2* pFeaturesFixed = &pFeatures)
            {
                handle.PInvoke.vkGetPhysicalDeviceFeatures2KHR.Invoke(handle.Handle, pFeaturesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceFeatures2.</returns>
        public static VkPhysicalDeviceFeatures2 GetFeatures2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceFeatures2 outValue = new();
            GetFeatures2KHR(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceProperties2 pProperties
        )
        {
            fixed (VkPhysicalDeviceProperties2* pPropertiesFixed = &pProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceProperties2KHR.Invoke(handle.Handle, pPropertiesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceProperties2.</returns>
        public static VkPhysicalDeviceProperties2 GetProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceProperties2 outValue = new();
            GetProperties2KHR(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetFormatProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            ref VkFormatProperties2 pFormatProperties
        )
        {
            fixed (VkFormatProperties2* pFormatPropertiesFixed = &pFormatProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceFormatProperties2KHR.Invoke(
                    handle.Handle,
                    format,
                    pFormatPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkFormatProperties2.</returns>
        public static VkFormatProperties2 GetFormatProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format
        )
        {
            VkFormatProperties2 outValue = new();
            GetFormatProperties2KHR(handle, format, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkResult GetImageFormatProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo,
            VkImageFormatProperties2* pImageFormatProperties
        )
        {
            fixed (VkPhysicalDeviceImageFormatInfo2* pImageFormatInfoFixed = &pImageFormatInfo)
            {
                return handle.PInvoke.vkGetPhysicalDeviceImageFormatProperties2KHR.Invoke(
                    handle.Handle,
                    pImageFormatInfoFixed,
                    pImageFormatProperties
                );
            }
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetQueueFamilyProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int* pQueueFamilyPropertyCount,
            ref VkQueueFamilyProperties2 pQueueFamilyProperties
        )
        {
            fixed (VkQueueFamilyProperties2* pQueueFamilyPropertiesFixed = &pQueueFamilyProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceQueueFamilyProperties2KHR.Invoke(
                    handle.Handle,
                    pQueueFamilyPropertyCount,
                    pQueueFamilyPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkQueueFamilyProperties2.</returns>
        public static unsafe VkQueueFamilyProperties2 GetQueueFamilyProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int* pQueueFamilyPropertyCount
        )
        {
            VkQueueFamilyProperties2 outValue = new();
            GetQueueFamilyProperties2KHR(handle, pQueueFamilyPropertyCount, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetMemoryProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref VkPhysicalDeviceMemoryProperties2 pMemoryProperties
        )
        {
            fixed (VkPhysicalDeviceMemoryProperties2* pMemoryPropertiesFixed = &pMemoryProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceMemoryProperties2KHR.Invoke(handle.Handle, pMemoryPropertiesFixed);
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkPhysicalDeviceMemoryProperties2.</returns>
        public static VkPhysicalDeviceMemoryProperties2 GetMemoryProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            VkPhysicalDeviceMemoryProperties2 outValue = new();
            GetMemoryProperties2KHR(handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetSparseImageFormatProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo,
            int* pPropertyCount,
            ref VkSparseImageFormatProperties2 pProperties
        )
        {
            fixed (VkSparseImageFormatProperties2* pPropertiesFixed = &pProperties)
            fixed (VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfoFixed = &pFormatInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceSparseImageFormatProperties2KHR.Invoke(
                    handle.Handle,
                    pFormatInfoFixed,
                    pPropertyCount,
                    pPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkSparseImageFormatProperties2.</returns>
        public static unsafe VkSparseImageFormatProperties2 GetSparseImageFormatProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo,
            int* pPropertyCount
        )
        {
            VkSparseImageFormatProperties2 outValue = new();
            GetSparseImageFormatProperties2KHR(handle, pFormatInfo, pPropertyCount, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkResult EnumeratePhysicalDeviceGroupsKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            int* pPhysicalDeviceGroupCount,
            VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties
        )
        {
            return handle.PInvoke.vkEnumeratePhysicalDeviceGroupsKHR.Invoke(
                handle.Handle,
                pPhysicalDeviceGroupCount,
                pPhysicalDeviceGroupProperties
            );
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalBufferPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo,
            ref VkExternalBufferProperties pExternalBufferProperties
        )
        {
            fixed (VkExternalBufferProperties* pExternalBufferPropertiesFixed = &pExternalBufferProperties)
            fixed (VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfoFixed = &pExternalBufferInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalBufferPropertiesKHR.Invoke(
                    handle.Handle,
                    pExternalBufferInfoFixed,
                    pExternalBufferPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalBufferProperties.</returns>
        public static VkExternalBufferProperties GetExternalBufferPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo
        )
        {
            VkExternalBufferProperties outValue = new();
            GetExternalBufferPropertiesKHR(handle, pExternalBufferInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalSemaphorePropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo,
            ref VkExternalSemaphoreProperties pExternalSemaphoreProperties
        )
        {
            fixed (VkExternalSemaphoreProperties* pExternalSemaphorePropertiesFixed = &pExternalSemaphoreProperties)
            fixed (VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfoFixed = &pExternalSemaphoreInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalSemaphorePropertiesKHR.Invoke(
                    handle.Handle,
                    pExternalSemaphoreInfoFixed,
                    pExternalSemaphorePropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalSemaphoreProperties.</returns>
        public static VkExternalSemaphoreProperties GetExternalSemaphorePropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo
        )
        {
            VkExternalSemaphoreProperties outValue = new();
            GetExternalSemaphorePropertiesKHR(handle, pExternalSemaphoreInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalFencePropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo,
            ref VkExternalFenceProperties pExternalFenceProperties
        )
        {
            fixed (VkExternalFenceProperties* pExternalFencePropertiesFixed = &pExternalFenceProperties)
            fixed (VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfoFixed = &pExternalFenceInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalFencePropertiesKHR.Invoke(
                    handle.Handle,
                    pExternalFenceInfoFixed,
                    pExternalFencePropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalFenceProperties.</returns>
        public static VkExternalFenceProperties GetExternalFencePropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo
        )
        {
            VkExternalFenceProperties outValue = new();
            GetExternalFencePropertiesKHR(handle, pExternalFenceInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR.html">vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR</see> - Reports properties of the performance query counters available on a queue family of a device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR
        ///     </para>
        ///     <para>
        ///         To enumerate the performance query counters available on a queue family of a
        ///         physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_performance_query
        ///         VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         uint32_t*                                   pCounterCount,
        ///         VkPerformanceCounterKHR*                    pCounters,
        ///         VkPerformanceCounterDescriptionKHR*         pCounterDescriptions);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            ref int pCounterCount,
            scoped ReadOnlySpan<VkPerformanceCounterKHR> pCounters,
            scoped ReadOnlySpan<VkPerformanceCounterDescriptionKHR> pCounterDescriptions
        )
        {
            fixed (VkPerformanceCounterDescriptionKHR* pCounterDescriptionsFixed = pCounterDescriptions)
            fixed (VkPerformanceCounterKHR* pCountersFixed = pCounters)
            fixed (int* pCounterCountFixed = &pCounterCount)
            {
                VkResult result = handle.PInvoke.vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR.Invoke(
                    handle.Handle,
                    queueFamilyIndex,
                    pCounterCountFixed,
                    pCountersFixed,
                    pCounterDescriptionsFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            scoped ReadOnlySpan<VkPerformanceCounterDescriptionKHR> pCounterDescriptions
        )
        {
            int pCounterCount = default;
            EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
                handle,
                queueFamilyIndex,
                ref pCounterCount,
                null,
                pCounterDescriptions
            );
            return pCounterCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pCounters">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            scoped ReadOnlySpan<VkPerformanceCounterKHR> pCounters,
            scoped ReadOnlySpan<VkPerformanceCounterDescriptionKHR> pCounterDescriptions
        )
        {
            int pCounterCount = pCounters.Length;
            return EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
                handle,
                queueFamilyIndex,
                ref pCounterCount,
                pCounters,
                pCounterDescriptions
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR.html">vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR</see> - Reports the number of passes require for a performance query pool type
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the number of passes required to query a performance query pool on
        ///         a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_performance_query
        ///         void vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkQueryPoolPerformanceCreateInfoKHR*  pPerformanceQueryCreateInfo,
        ///         uint32_t*                                   pNumPasses);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe int GetQueueFamilyPerformanceQueryPassesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo
        )
        {
            fixed (VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfoFixed = &pPerformanceQueryCreateInfo)
            {
                int pNumPassesLocal = default;
                handle.PInvoke.vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR.Invoke(
                    handle.Handle,
                    pPerformanceQueryCreateInfoFixed,
                    &pNumPassesLocal
                );
                return pNumPassesLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2KHR.html">vkGetPhysicalDeviceSurfaceCapabilities2KHR</see> - Reports capabilities of a surface on a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfaceCapabilities2KHR
        ///     </para>
        ///     <para>
        ///         To query the basic capabilities of a surface defined by the core or
        ///         extensions, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_get_surface_capabilities2
        ///         VkResult vkGetPhysicalDeviceSurfaceCapabilities2KHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceSurfaceInfo2KHR*      pSurfaceInfo,
        ///         VkSurfaceCapabilities2KHR*                  pSurfaceCapabilities);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetSurfaceCapabilities2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
            ref VkSurfaceCapabilities2KHR pSurfaceCapabilities
        )
        {
            fixed (VkSurfaceCapabilities2KHR* pSurfaceCapabilitiesFixed = &pSurfaceCapabilities)
            fixed (VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfoFixed = &pSurfaceInfo)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfaceCapabilities2KHR.Invoke(
                    handle.Handle,
                    pSurfaceInfoFixed,
                    pSurfaceCapabilitiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2KHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2KHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2KHR failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2KHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2KHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkSurfaceCapabilities2KHR.</returns>
        public static VkSurfaceCapabilities2KHR GetSurfaceCapabilities2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo
        )
        {
            VkSurfaceCapabilities2KHR outValue = new();
            GetSurfaceCapabilities2KHR(handle, pSurfaceInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormats2KHR.html">vkGetPhysicalDeviceSurfaceFormats2KHR</see> - Query color formats supported by surface
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfaceFormats2KHR
        ///     </para>
        ///     <para>
        ///         To query the supported swapchain format tuples for a surface, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_get_surface_capabilities2
        ///         VkResult vkGetPhysicalDeviceSurfaceFormats2KHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceSurfaceInfo2KHR*      pSurfaceInfo,
        ///         uint32_t*                                   pSurfaceFormatCount,
        ///         VkSurfaceFormat2KHR*                        pSurfaceFormats);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetSurfaceFormats2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
            ref int pSurfaceFormatCount,
            scoped ReadOnlySpan<VkSurfaceFormat2KHR> pSurfaceFormats
        )
        {
            fixed (VkSurfaceFormat2KHR* pSurfaceFormatsFixed = pSurfaceFormats)
            fixed (VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfoFixed = &pSurfaceInfo)
            fixed (int* pSurfaceFormatCountFixed = &pSurfaceFormatCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfaceFormats2KHR.Invoke(
                    handle.Handle,
                    pSurfaceInfoFixed,
                    pSurfaceFormatCountFixed,
                    pSurfaceFormatsFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormats2KHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormats2KHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormats2KHR failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormats2KHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceFormats2KHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetSurfaceFormats2KHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo
        )
        {
            int pSurfaceFormatCount = default;
            GetSurfaceFormats2KHR(handle, pSurfaceInfo, ref pSurfaceFormatCount, null);
            return pSurfaceFormatCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pSurfaceFormats">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetSurfaceFormats2KHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
            scoped ReadOnlySpan<VkSurfaceFormat2KHR> pSurfaceFormats
        )
        {
            int pSurfaceFormatCount = pSurfaceFormats.Length;
            return GetSurfaceFormats2KHR(handle, pSurfaceInfo, ref pSurfaceFormatCount, pSurfaceFormats);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayProperties2KHR.html">vkGetPhysicalDeviceDisplayProperties2KHR</see> - Query information about the available displays
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceDisplayProperties2KHR
        ///     </para>
        ///     <para>
        ///         To query information about the available displays, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_get_display_properties2
        ///         VkResult vkGetPhysicalDeviceDisplayProperties2KHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkDisplayProperties2KHR*                    pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkDisplayProperties2KHR> pProperties
        )
        {
            fixed (VkDisplayProperties2KHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceDisplayProperties2KHR.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayProperties2KHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayProperties2KHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceDisplayProperties2KHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceDisplayProperties2KHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayProperties2KHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetDisplayProperties2KHR(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayProperties2KHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkDisplayProperties2KHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetDisplayProperties2KHR(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlaneProperties2KHR.html">vkGetPhysicalDeviceDisplayPlaneProperties2KHR</see> - Query information about the available display planes.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceDisplayPlaneProperties2KHR
        ///     </para>
        ///     <para>
        ///         To query the properties of a device&apos;s display planes, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_get_display_properties2
        ///         VkResult vkGetPhysicalDeviceDisplayPlaneProperties2KHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkDisplayPlaneProperties2KHR*               pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayPlaneProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkDisplayPlaneProperties2KHR> pProperties
        )
        {
            fixed (VkDisplayPlaneProperties2KHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceDisplayPlaneProperties2KHR.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlaneProperties2KHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlaneProperties2KHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlaneProperties2KHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceDisplayPlaneProperties2KHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayPlaneProperties2KHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetDisplayPlaneProperties2KHR(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayPlaneProperties2KHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkDisplayPlaneProperties2KHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetDisplayPlaneProperties2KHR(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModeProperties2KHR.html">vkGetDisplayModeProperties2KHR</see> - Query information about the available display modes.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetDisplayModeProperties2KHR
        ///     </para>
        ///     <para>
        ///         To query the properties of a device&apos;s built-in display modes, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_get_display_properties2
        ///         VkResult vkGetDisplayModeProperties2KHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDisplayKHR                                display,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkDisplayModeProperties2KHR*                pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetDisplayModeProperties2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkDisplayModeProperties2KHR> pProperties
        )
        {
            fixed (VkDisplayModeProperties2KHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetDisplayModeProperties2KHR.Invoke(
                    handle.Handle,
                    display,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetDisplayModeProperties2KHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetDisplayModeProperties2KHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetDisplayModeProperties2KHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetDisplayModeProperties2KHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetDisplayModeProperties2KHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display
        )
        {
            int pPropertyCount = default;
            GetDisplayModeProperties2KHR(handle, display, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetDisplayModeProperties2KHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display,
            scoped ReadOnlySpan<VkDisplayModeProperties2KHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetDisplayModeProperties2KHR(handle, display, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilities2KHR.html">vkGetDisplayPlaneCapabilities2KHR</see> - Query capabilities of a mode and plane combination
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetDisplayPlaneCapabilities2KHR
        ///     </para>
        ///     <para>
        ///         To query the capabilities of a given mode and plane combination, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_get_display_properties2
        ///         VkResult vkGetDisplayPlaneCapabilities2KHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkDisplayPlaneInfo2KHR*               pDisplayPlaneInfo,
        ///         VkDisplayPlaneCapabilities2KHR*             pCapabilities);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetDisplayPlaneCapabilities2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkDisplayPlaneInfo2KHR pDisplayPlaneInfo,
            ref VkDisplayPlaneCapabilities2KHR pCapabilities
        )
        {
            fixed (VkDisplayPlaneCapabilities2KHR* pCapabilitiesFixed = &pCapabilities)
            fixed (VkDisplayPlaneInfo2KHR* pDisplayPlaneInfoFixed = &pDisplayPlaneInfo)
            {
                VkResult result = handle.PInvoke.vkGetDisplayPlaneCapabilities2KHR.Invoke(
                    handle.Handle,
                    pDisplayPlaneInfoFixed,
                    pCapabilitiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetDisplayPlaneCapabilities2KHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetDisplayPlaneCapabilities2KHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetDisplayPlaneCapabilities2KHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetDisplayPlaneCapabilities2KHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkDisplayPlaneCapabilities2KHR.</returns>
        public static VkDisplayPlaneCapabilities2KHR GetDisplayPlaneCapabilities2KHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkDisplayPlaneInfo2KHR pDisplayPlaneInfo
        )
        {
            VkDisplayPlaneCapabilities2KHR outValue = new();
            GetDisplayPlaneCapabilities2KHR(handle, pDisplayPlaneInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceFragmentShadingRatesKHR.html">vkGetPhysicalDeviceFragmentShadingRatesKHR</see> - Get available shading rates for a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceFragmentShadingRatesKHR
        ///     </para>
        ///     <para>
        ///         To query available shading rates, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_fragment_shading_rate
        ///         VkResult vkGetPhysicalDeviceFragmentShadingRatesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pFragmentShadingRateCount,
        ///         VkPhysicalDeviceFragmentShadingRateKHR*     pFragmentShadingRates);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetFragmentShadingRatesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pFragmentShadingRateCount,
            scoped ReadOnlySpan<VkPhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates
        )
        {
            fixed (VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRatesFixed = pFragmentShadingRates)
            fixed (int* pFragmentShadingRateCountFixed = &pFragmentShadingRateCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceFragmentShadingRatesKHR.Invoke(
                    handle.Handle,
                    pFragmentShadingRateCountFixed,
                    pFragmentShadingRatesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceFragmentShadingRatesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceFragmentShadingRatesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceFragmentShadingRatesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetFragmentShadingRatesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pFragmentShadingRateCount = default;
            GetFragmentShadingRatesKHR(handle, ref pFragmentShadingRateCount, null);
            return pFragmentShadingRateCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pFragmentShadingRates">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetFragmentShadingRatesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkPhysicalDeviceFragmentShadingRateKHR> pFragmentShadingRates
        )
        {
            int pFragmentShadingRateCount = pFragmentShadingRates.Length;
            return GetFragmentShadingRatesKHR(handle, ref pFragmentShadingRateCount, pFragmentShadingRates);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR.html">vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR</see> - Query video encode quality level properties
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query properties for a specific video encode quality level supported by a
        ///         video encode profile, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_video_encode_queue
        ///         VkResult vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfo,
        ///         VkVideoEncodeQualityLevelPropertiesKHR*     pQualityLevelProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetVideoEncodeQualityLevelPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR pQualityLevelInfo,
            ref VkVideoEncodeQualityLevelPropertiesKHR pQualityLevelProperties
        )
        {
            fixed (VkVideoEncodeQualityLevelPropertiesKHR* pQualityLevelPropertiesFixed = &pQualityLevelProperties)
            fixed (VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR* pQualityLevelInfoFixed = &pQualityLevelInfo)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR.Invoke(
                    handle.Handle,
                    pQualityLevelInfoFixed,
                    pQualityLevelPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorVideoProfileOperationNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileOperationNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileFormatNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileFormatNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoPictureLayoutNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoPictureLayoutNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorVideoProfileCodecNotSupportedKHR:
                        throw new VkResultError(
                            VkResult.ErrorVideoProfileCodecNotSupportedKHR,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkVideoEncodeQualityLevelPropertiesKHR.</returns>
        public static VkVideoEncodeQualityLevelPropertiesKHR GetVideoEncodeQualityLevelPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR pQualityLevelInfo
        )
        {
            VkVideoEncodeQualityLevelPropertiesKHR outValue = new();
            GetVideoEncodeQualityLevelPropertiesKHR(handle, pQualityLevelInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR.html">vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR</see> - Returns properties describing what cooperative matrix types are supported
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the supported cooperative matrix types and operations, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_cooperative_matrix
        ///         VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkCooperativeMatrixPropertiesKHR*           pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetCooperativeMatrixPropertiesKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkCooperativeMatrixPropertiesKHR> pProperties
        )
        {
            fixed (VkCooperativeMatrixPropertiesKHR* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetCooperativeMatrixPropertiesKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetCooperativeMatrixPropertiesKHR(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetCooperativeMatrixPropertiesKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkCooperativeMatrixPropertiesKHR> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetCooperativeMatrixPropertiesKHR(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCalibrateableTimeDomainsKHR.html">vkGetPhysicalDeviceCalibrateableTimeDomainsKHR</see> - Query calibrateable time domains
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceCalibrateableTimeDomainsKHR
        ///     </para>
        ///     <para>
        ///         To query the set of time domains for which a physical device supports
        ///         timestamp calibration, call:
        ///     </para>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetCalibrateableTimeDomainsKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pTimeDomainCount,
            scoped ReadOnlySpan<VkTimeDomainKHR> pTimeDomains
        )
        {
            fixed (VkTimeDomainKHR* pTimeDomainsFixed = pTimeDomains)
            fixed (int* pTimeDomainCountFixed = &pTimeDomainCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceCalibrateableTimeDomainsKHR.Invoke(
                    handle.Handle,
                    pTimeDomainCountFixed,
                    pTimeDomainsFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceCalibrateableTimeDomainsKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceCalibrateableTimeDomainsKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceCalibrateableTimeDomainsKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceCalibrateableTimeDomainsKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetCalibrateableTimeDomainsKHR_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pTimeDomainCount = default;
            GetCalibrateableTimeDomainsKHR(handle, ref pTimeDomainCount, null);
            return pTimeDomainCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pTimeDomains">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetCalibrateableTimeDomainsKHR_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkTimeDomainKHR> pTimeDomains
        )
        {
            int pTimeDomainCount = pTimeDomains.Length;
            return GetCalibrateableTimeDomainsKHR(handle, ref pTimeDomainCount, pTimeDomains);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDebugReportCallbackEXT.html">vkCreateDebugReportCallbackEXT</see> - Create a debug report callback object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Debug report callbacks give more detailed feedback on the application&apos;s use
        ///         of Vulkan when events of interest occur.
        ///     </para>
        ///     <para>
        ///         To register a debug report callback, an application uses
        ///         <c>vkCreateDebugReportCallbackEXT</c>.
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_debug_report
        ///         VkResult vkCreateDebugReportCallbackEXT(
        ///         VkInstance                                  instance,
        ///         const VkDebugReportCallbackCreateInfoEXT*   pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkDebugReportCallbackEXT*                   pCallback);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkDebugReportCallbackEXT CreateDebugReportCallbackEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkDebugReportCallbackCreateInfoEXT pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkDebugReportCallbackCreateInfoEXT* pCreateInfoFixed = &pCreateInfo)
            {
                VkDebugReportCallbackEXT pCallbackLocal = default;
                VkResult result = handle.PInvoke.vkCreateDebugReportCallbackEXT.Invoke(
                    handle.Handle,
                    pCreateInfoFixed,
                    pAllocator,
                    &pCallbackLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateDebugReportCallbackEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateDebugReportCallbackEXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateDebugReportCallbackEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pCallbackLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugReportCallbackEXT.html">vkDestroyDebugReportCallbackEXT</see> - Destroy a debug report callback object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To destroy a <c>VkDebugReportCallbackEXT</c> object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_debug_report
        ///         void vkDestroyDebugReportCallbackEXT(
        ///         VkInstance                                  instance,
        ///         VkDebugReportCallbackEXT                    callback,
        ///         const VkAllocationCallbacks*                pAllocator);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void DestroyDebugReportCallbackEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            VkDebugReportCallbackEXT callback,
            VkAllocator? pAllocator
        )
        {
            handle.PInvoke.vkDestroyDebugReportCallbackEXT.Invoke(handle.Handle, callback, pAllocator);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDebugReportMessageEXT.html">vkDebugReportMessageEXT</see> - Inject a message into a debug stream
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To inject its own messages into the debug stream, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_debug_report
        ///         void vkDebugReportMessageEXT(
        ///         VkInstance                                  instance,
        ///         VkDebugReportFlagsEXT                       flags,
        ///         VkDebugReportObjectTypeEXT                  objectType,
        ///         uint64_t                                    object,
        ///         size_t                                      location,
        ///         int32_t                                     messageCode,
        ///         const char*                                 pLayerPrefix,
        ///         const char*                                 pMessage);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void DebugReportMessageEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            VkDebugReportFlagsEXT flags,
            VkDebugReportObjectTypeEXT objectType,
            nint @object,
            nuint location,
            int messageCode,
            scoped ReadOnlySpan<byte> pLayerPrefix,
            scoped ReadOnlySpan<byte> pMessage
        )
        {
            fixed (byte* pMessageFixed = pMessage)
            fixed (byte* pLayerPrefixFixed = pLayerPrefix)
            {
                handle.PInvoke.vkDebugReportMessageEXT.Invoke(
                    handle.Handle,
                    flags,
                    objectType,
                    @object,
                    location,
                    messageCode,
                    pLayerPrefixFixed,
                    pMessageFixed
                );
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalImageFormatPropertiesNV.html">vkGetPhysicalDeviceExternalImageFormatPropertiesNV</see> - Determine image capabilities compatible with external memory handle types
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To determine the image capabilities compatible with an external memory
        ///         handle type, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_external_memory_capabilities
        ///         VkResult vkGetPhysicalDeviceExternalImageFormatPropertiesNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkFormat                                    format,
        ///         VkImageType                                 type,
        ///         VkImageTiling                               tiling,
        ///         VkImageUsageFlags                           usage,
        ///         VkImageCreateFlags                          flags,
        ///         VkExternalMemoryHandleTypeFlagsNV           externalHandleType,
        ///         VkExternalImageFormatPropertiesNV*          pExternalImageFormatProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalImageFormatPropertiesNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkImageTiling tiling,
            VkImageUsageFlags usage,
            VkImageCreateFlags flags,
            VkExternalMemoryHandleTypeFlagsNV externalHandleType,
            ref VkExternalImageFormatPropertiesNV pExternalImageFormatProperties
        )
        {
            fixed (
                VkExternalImageFormatPropertiesNV* pExternalImageFormatPropertiesFixed = &pExternalImageFormatProperties
            )
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceExternalImageFormatPropertiesNV.Invoke(
                    handle.Handle,
                    format,
                    type,
                    tiling,
                    usage,
                    flags,
                    externalHandleType,
                    pExternalImageFormatPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceExternalImageFormatPropertiesNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceExternalImageFormatPropertiesNV failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorFormatNotSupported:
                        throw new VkResultError(
                            VkResult.ErrorFormatNotSupported,
                            "Vulkan call to vkGetPhysicalDeviceExternalImageFormatPropertiesNV failed with error: VK_ERROR_FORMAT_NOT_SUPPORTED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceExternalImageFormatPropertiesNV failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceExternalImageFormatPropertiesNV failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalImageFormatPropertiesNV.</returns>
        public static VkExternalImageFormatPropertiesNV GetExternalImageFormatPropertiesNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkFormat format,
            VkImageType type,
            VkImageTiling tiling,
            VkImageUsageFlags usage,
            VkImageCreateFlags flags,
            VkExternalMemoryHandleTypeFlagsNV externalHandleType
        )
        {
            VkExternalImageFormatPropertiesNV outValue = new();
            GetExternalImageFormatPropertiesNV(
                handle,
                format,
                type,
                tiling,
                usage,
                flags,
                externalHandleType,
                ref outValue
            );
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseDisplayEXT.html">vkReleaseDisplayEXT</see> - Release access to an acquired VkDisplayKHR
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To release a previously acquired display, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_direct_mode_display
        ///         VkResult vkReleaseDisplayEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDisplayKHR                                display);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ReleaseDisplayEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display
        )
        {
            VkResult result = handle.PInvoke.vkReleaseDisplayEXT.Invoke(handle.Handle, display);
            switch (result)
            {
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkReleaseDisplayEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkReleaseDisplayEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2EXT.html">vkGetPhysicalDeviceSurfaceCapabilities2EXT</see> - Query surface capabilities
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfaceCapabilities2EXT
        ///     </para>
        ///     <para>
        ///         To query the basic capabilities of a surface, needed in order to create a
        ///         swapchain, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_display_surface_counter
        ///         VkResult vkGetPhysicalDeviceSurfaceCapabilities2EXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkSurfaceKHR                                surface,
        ///         VkSurfaceCapabilities2EXT*                  pSurfaceCapabilities);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetSurfaceCapabilities2EXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface,
            ref VkSurfaceCapabilities2EXT pSurfaceCapabilities
        )
        {
            fixed (VkSurfaceCapabilities2EXT* pSurfaceCapabilitiesFixed = &pSurfaceCapabilities)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfaceCapabilities2EXT.Invoke(
                    handle.Handle,
                    surface,
                    pSurfaceCapabilitiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2EXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2EXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2EXT failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2EXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfaceCapabilities2EXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkSurfaceCapabilities2EXT.</returns>
        public static VkSurfaceCapabilities2EXT GetSurfaceCapabilities2EXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSurfaceKHR surface
        )
        {
            VkSurfaceCapabilities2EXT outValue = new();
            GetSurfaceCapabilities2EXT(handle, surface, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDebugUtilsMessengerEXT.html">vkCreateDebugUtilsMessengerEXT</see> - Create a debug messenger object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         A debug messenger triggers a debug callback with a debug message when an
        ///         event of interest occurs.
        ///         To create a debug messenger which will trigger a debug callback, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_debug_utils
        ///         VkResult vkCreateDebugUtilsMessengerEXT(
        ///         VkInstance                                  instance,
        ///         const VkDebugUtilsMessengerCreateInfoEXT*   pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkDebugUtilsMessengerEXT*                   pMessenger);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkDebugUtilsMessengerEXT CreateDebugUtilsMessengerEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkDebugUtilsMessengerCreateInfoEXT pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkDebugUtilsMessengerCreateInfoEXT* pCreateInfoFixed = &pCreateInfo)
            {
                VkDebugUtilsMessengerEXT pMessengerLocal = default;
                VkResult result = handle.PInvoke.vkCreateDebugUtilsMessengerEXT.Invoke(
                    handle.Handle,
                    pCreateInfoFixed,
                    pAllocator,
                    &pMessengerLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateDebugUtilsMessengerEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateDebugUtilsMessengerEXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateDebugUtilsMessengerEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pMessengerLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugUtilsMessengerEXT.html">vkDestroyDebugUtilsMessengerEXT</see> - Destroy a debug messenger object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To destroy a <c>VkDebugUtilsMessengerEXT</c> object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_debug_utils
        ///         void vkDestroyDebugUtilsMessengerEXT(
        ///         VkInstance                                  instance,
        ///         VkDebugUtilsMessengerEXT                    messenger,
        ///         const VkAllocationCallbacks*                pAllocator);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void DestroyDebugUtilsMessengerEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            VkDebugUtilsMessengerEXT messenger,
            VkAllocator? pAllocator
        )
        {
            handle.PInvoke.vkDestroyDebugUtilsMessengerEXT.Invoke(handle.Handle, messenger, pAllocator);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkSubmitDebugUtilsMessageEXT.html">vkSubmitDebugUtilsMessageEXT</see> - Inject a message into a debug stream
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To intentionally submit a debug message, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_debug_utils
        ///         void vkSubmitDebugUtilsMessageEXT(
        ///         VkInstance                                  instance,
        ///         VkDebugUtilsMessageSeverityFlagBitsEXT      messageSeverity,
        ///         VkDebugUtilsMessageTypeFlagsEXT             messageTypes,
        ///         const VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void SubmitDebugUtilsMessageEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT messageTypes,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData
        )
        {
            handle.PInvoke.vkSubmitDebugUtilsMessageEXT.Invoke(
                handle.Handle,
                messageSeverity,
                messageTypes,
                pCallbackData
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDescriptorSizeEXT.html">vkGetPhysicalDeviceDescriptorSizeEXT</see> - Report specific descriptor sizes for each descriptor type
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the size of heap descriptor for a specific <c>VkDescriptorType</c>,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_descriptor_heap
        ///         VkDeviceSize vkGetPhysicalDeviceDescriptorSizeEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDescriptorType                            descriptorType);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ByteSize64 GetDescriptorSizeEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDescriptorType descriptorType
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceDescriptorSizeEXT.Invoke(handle.Handle, descriptorType);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceMultisamplePropertiesEXT.html">vkGetPhysicalDeviceMultisamplePropertiesEXT</see> - Report sample count specific multisampling capabilities of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query additional multisampling capabilities which may: be supported for a
        ///         specific sample count, beyond the minimum capabilities described for
        ///         <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#limits">Limits^</see> above, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_sample_locations
        ///         void vkGetPhysicalDeviceMultisamplePropertiesEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkSampleCountFlagBits                       samples,
        ///         VkMultisamplePropertiesEXT*                 pMultisampleProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetMultisamplePropertiesEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSampleCountFlags samples,
            ref VkMultisamplePropertiesEXT pMultisampleProperties
        )
        {
            fixed (VkMultisamplePropertiesEXT* pMultisamplePropertiesFixed = &pMultisampleProperties)
            {
                handle.PInvoke.vkGetPhysicalDeviceMultisamplePropertiesEXT.Invoke(
                    handle.Handle,
                    samples,
                    pMultisamplePropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkMultisamplePropertiesEXT.</returns>
        public static VkMultisamplePropertiesEXT GetMultisamplePropertiesEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkSampleCountFlags samples
        )
        {
            VkMultisamplePropertiesEXT outValue = new();
            GetMultisamplePropertiesEXT(handle, samples, ref outValue);
            return outValue;
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkResult GetCalibrateableTimeDomainsEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int* pTimeDomainCount,
            VkTimeDomainKHR* pTimeDomains
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceCalibrateableTimeDomainsEXT.Invoke(
                handle.Handle,
                pTimeDomainCount,
                pTimeDomains
            );
        }

        /// <summary>
        ///
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkResult GetToolPropertiesEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int* pToolCount,
            VkPhysicalDeviceToolProperties* pToolProperties
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceToolPropertiesEXT.Invoke(
                handle.Handle,
                pToolCount,
                pToolProperties
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixPropertiesNV.html">vkGetPhysicalDeviceCooperativeMatrixPropertiesNV</see> - Returns properties describing what cooperative matrix types are supported
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the supported cooperative matrix types and operations, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_cooperative_matrix
        ///         VkResult vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkCooperativeMatrixPropertiesNV*            pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetCooperativeMatrixPropertiesNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkCooperativeMatrixPropertiesNV> pProperties
        )
        {
            fixed (VkCooperativeMatrixPropertiesNV* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceCooperativeMatrixPropertiesNV.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesNV failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesNV failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixPropertiesNV failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetCooperativeMatrixPropertiesNV_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetCooperativeMatrixPropertiesNV(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetCooperativeMatrixPropertiesNV_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkCooperativeMatrixPropertiesNV> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetCooperativeMatrixPropertiesNV(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV.html">vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV</see> - Query supported sample count combinations
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the set of mixed sample combinations of coverage reduction mode,
        ///         rasterization samples and color, depth, stencil attachment sample counts
        ///         that are supported by a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_coverage_reduction_mode
        ///         VkResult vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pCombinationCount,
        ///         VkFramebufferMixedSamplesCombinationNV*     pCombinations);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetSupportedFramebufferMixedSamplesCombinationsNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pCombinationCount,
            scoped ReadOnlySpan<VkFramebufferMixedSamplesCombinationNV> pCombinations
        )
        {
            fixed (VkFramebufferMixedSamplesCombinationNV* pCombinationsFixed = pCombinations)
            fixed (int* pCombinationCountFixed = &pCombinationCount)
            {
                VkResult result =
                    handle.PInvoke.vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV.Invoke(
                        handle.Handle,
                        pCombinationCountFixed,
                        pCombinationsFixed
                    );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetSupportedFramebufferMixedSamplesCombinationsNV_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pCombinationCount = default;
            GetSupportedFramebufferMixedSamplesCombinationsNV(handle, ref pCombinationCount, null);
            return pCombinationCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pCombinations">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetSupportedFramebufferMixedSamplesCombinationsNV_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkFramebufferMixedSamplesCombinationNV> pCombinations
        )
        {
            int pCombinationCount = pCombinations.Length;
            return GetSupportedFramebufferMixedSamplesCombinationsNV(handle, ref pCombinationCount, pCombinations);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateHeadlessSurfaceEXT.html">vkCreateHeadlessSurfaceEXT</see> - Create a headless &lt;c&gt;VkSurfaceKHR&lt;/c&gt; object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateHeadlessSurfaceEXT
        ///     </para>
        ///     <para>
        ///         To create a headless <c>VkSurfaceKHR</c> object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_headless_surface
        ///         VkResult vkCreateHeadlessSurfaceEXT(
        ///         VkInstance                                  instance,
        ///         const VkHeadlessSurfaceCreateInfoEXT*       pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkSurfaceKHR CreateHeadlessSurfaceEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkHeadlessSurfaceCreateInfoEXT pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkHeadlessSurfaceCreateInfoEXT* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateHeadlessSurfaceEXT.Invoke(
                    handle.Handle,
                    pCreateInfoFixed,
                    pAllocator,
                    &pSurfaceLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateHeadlessSurfaceEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateHeadlessSurfaceEXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateHeadlessSurfaceEXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateHeadlessSurfaceEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireDrmDisplayEXT.html">vkAcquireDrmDisplayEXT</see> - Acquire access to a VkDisplayKHR using DRM
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To acquire permission to directly control a display in Vulkan from the
        ///         Direct Rendering Manager (DRM) interface, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_acquire_drm_display
        ///         VkResult vkAcquireDrmDisplayEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         int32_t                                     drmFd,
        ///         VkDisplayKHR                                display);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void AcquireDrmDisplayEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int drmFd,
            VkDisplayKHR display
        )
        {
            VkResult result = handle.PInvoke.vkAcquireDrmDisplayEXT.Invoke(handle.Handle, drmFd, display);
            switch (result)
            {
                case VkResult.ErrorInitializationFailed:
                    throw new VkResultError(
                        VkResult.ErrorInitializationFailed,
                        "Vulkan call to vkAcquireDrmDisplayEXT failed with error: VK_ERROR_INITIALIZATION_FAILED"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkAcquireDrmDisplayEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkAcquireDrmDisplayEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDrmDisplayEXT.html">vkGetDrmDisplayEXT</see> - Query the VkDisplayKHR corresponding to a DRM connector ID
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Before acquiring a display from the DRM interface, the caller may want to
        ///         select a specific <c>VkDisplayKHR</c> handle by identifying it using a
        ///         <c>connectorId</c>.
        ///         To do so, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_acquire_drm_display
        ///         VkResult vkGetDrmDisplayEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         int32_t                                     drmFd,
        ///         uint32_t                                    connectorId,
        ///         VkDisplayKHR*                               display);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe VkDisplayKHR GetDrmDisplayEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int drmFd,
            int connectorId
        )
        {
            VkDisplayKHR displayLocal = default;
            VkResult result = handle.PInvoke.vkGetDrmDisplayEXT.Invoke(
                handle.Handle,
                drmFd,
                connectorId,
                &displayLocal
            );
            switch (result)
            {
                case VkResult.ErrorInitializationFailed:
                    throw new VkResultError(
                        VkResult.ErrorInitializationFailed,
                        "Vulkan call to vkGetDrmDisplayEXT failed with error: VK_ERROR_INITIALIZATION_FAILED"
                    );
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkGetDrmDisplayEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkGetDrmDisplayEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkGetDrmDisplayEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }

            return displayLocal;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceExternalTensorPropertiesARM.html">vkGetPhysicalDeviceExternalTensorPropertiesARM</see> - Function for querying external tensor handle capabilities.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the external handle types supported by tensors, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_tensors
        ///         void vkGetPhysicalDeviceExternalTensorPropertiesARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceExternalTensorInfoARM* pExternalTensorInfo,
        ///         VkExternalTensorPropertiesARM*              pExternalTensorProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetExternalTensorPropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalTensorInfoARM pExternalTensorInfo,
            ref VkExternalTensorPropertiesARM pExternalTensorProperties
        )
        {
            fixed (VkExternalTensorPropertiesARM* pExternalTensorPropertiesFixed = &pExternalTensorProperties)
            fixed (VkPhysicalDeviceExternalTensorInfoARM* pExternalTensorInfoFixed = &pExternalTensorInfo)
            {
                handle.PInvoke.vkGetPhysicalDeviceExternalTensorPropertiesARM.Invoke(
                    handle.Handle,
                    pExternalTensorInfoFixed,
                    pExternalTensorPropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkExternalTensorPropertiesARM.</returns>
        public static VkExternalTensorPropertiesARM GetExternalTensorPropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceExternalTensorInfoARM pExternalTensorInfo
        )
        {
            VkExternalTensorPropertiesARM outValue = new();
            GetExternalTensorPropertiesARM(handle, pExternalTensorInfo, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceOpticalFlowImageFormatsNV.html">vkGetPhysicalDeviceOpticalFlowImageFormatsNV</see> - Query image formats for optical flow
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the supported image formats for a specific optical flow usage,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_optical_flow
        ///         VkResult vkGetPhysicalDeviceOpticalFlowImageFormatsNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkOpticalFlowImageFormatInfoNV*       pOpticalFlowImageFormatInfo,
        ///         uint32_t*                                   pFormatCount,
        ///         VkOpticalFlowImageFormatPropertiesNV*       pImageFormatProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetOpticalFlowImageFormatsNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo,
            ref int pFormatCount,
            scoped ReadOnlySpan<VkOpticalFlowImageFormatPropertiesNV> pImageFormatProperties
        )
        {
            fixed (VkOpticalFlowImageFormatPropertiesNV* pImageFormatPropertiesFixed = pImageFormatProperties)
            fixed (VkOpticalFlowImageFormatInfoNV* pOpticalFlowImageFormatInfoFixed = &pOpticalFlowImageFormatInfo)
            fixed (int* pFormatCountFixed = &pFormatCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceOpticalFlowImageFormatsNV.Invoke(
                    handle.Handle,
                    pOpticalFlowImageFormatInfoFixed,
                    pFormatCountFixed,
                    pImageFormatPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorExtensionNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorExtensionNotPresent,
                            "Vulkan call to vkGetPhysicalDeviceOpticalFlowImageFormatsNV failed with error: VK_ERROR_EXTENSION_NOT_PRESENT"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkGetPhysicalDeviceOpticalFlowImageFormatsNV failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorFormatNotSupported:
                        throw new VkResultError(
                            VkResult.ErrorFormatNotSupported,
                            "Vulkan call to vkGetPhysicalDeviceOpticalFlowImageFormatsNV failed with error: VK_ERROR_FORMAT_NOT_SUPPORTED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceOpticalFlowImageFormatsNV failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceOpticalFlowImageFormatsNV failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetOpticalFlowImageFormatsNV_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo
        )
        {
            int pFormatCount = default;
            GetOpticalFlowImageFormatsNV(handle, pOpticalFlowImageFormatInfo, ref pFormatCount, null);
            return pFormatCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pImageFormatProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetOpticalFlowImageFormatsNV_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkOpticalFlowImageFormatInfoNV pOpticalFlowImageFormatInfo,
            scoped ReadOnlySpan<VkOpticalFlowImageFormatPropertiesNV> pImageFormatProperties
        )
        {
            int pFormatCount = pImageFormatProperties.Length;
            return GetOpticalFlowImageFormatsNV(
                handle,
                pOpticalFlowImageFormatInfo,
                ref pFormatCount,
                pImageFormatProperties
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeVectorPropertiesNV.html">vkGetPhysicalDeviceCooperativeVectorPropertiesNV</see> - Returns properties describing what cooperative vector types are supported
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the supported cooperative vector type combinations, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_cooperative_vector
        ///         VkResult vkGetPhysicalDeviceCooperativeVectorPropertiesNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkCooperativeVectorPropertiesNV*            pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetCooperativeVectorPropertiesNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkCooperativeVectorPropertiesNV> pProperties
        )
        {
            fixed (VkCooperativeVectorPropertiesNV* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceCooperativeVectorPropertiesNV.Invoke(
                    handle.Handle,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeVectorPropertiesNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeVectorPropertiesNV failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeVectorPropertiesNV failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeVectorPropertiesNV failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetCooperativeVectorPropertiesNV_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetCooperativeVectorPropertiesNV(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetCooperativeVectorPropertiesNV_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkCooperativeVectorPropertiesNV> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetCooperativeVectorPropertiesNV(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM.html">vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM</see> - Query the data processing engines and the operations they support for a given queue family of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM
        ///     </para>
        ///     <para>
        ///         To query the data graph processing engines and operations they support for a
        ///         specific queue family of a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_data_graph
        ///         VkResult vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         uint32_t*                                   pQueueFamilyDataGraphPropertyCount,
        ///         VkQueueFamilyDataGraphPropertiesARM*        pQueueFamilyDataGraphProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetQueueFamilyDataGraphPropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            ref int pQueueFamilyDataGraphPropertyCount,
            scoped ReadOnlySpan<VkQueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties
        )
        {
            fixed (
                VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphPropertiesFixed =
                    pQueueFamilyDataGraphProperties
            )
            fixed (int* pQueueFamilyDataGraphPropertyCountFixed = &pQueueFamilyDataGraphPropertyCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM.Invoke(
                    handle.Handle,
                    queueFamilyIndex,
                    pQueueFamilyDataGraphPropertyCountFixed,
                    pQueueFamilyDataGraphPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetQueueFamilyDataGraphPropertiesARM_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex
        )
        {
            int pQueueFamilyDataGraphPropertyCount = default;
            GetQueueFamilyDataGraphPropertiesARM(
                handle,
                queueFamilyIndex,
                ref pQueueFamilyDataGraphPropertyCount,
                null
            );
            return pQueueFamilyDataGraphPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pQueueFamilyDataGraphProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetQueueFamilyDataGraphPropertiesARM_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            scoped ReadOnlySpan<VkQueueFamilyDataGraphPropertiesARM> pQueueFamilyDataGraphProperties
        )
        {
            int pQueueFamilyDataGraphPropertyCount = pQueueFamilyDataGraphProperties.Length;
            return GetQueueFamilyDataGraphPropertiesARM(
                handle,
                queueFamilyIndex,
                ref pQueueFamilyDataGraphPropertyCount,
                pQueueFamilyDataGraphProperties
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM.html">vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM</see> - Query the properties of a data graph processing engine for a specific queue family of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM
        ///     </para>
        ///     <para>
        ///         To query the properties of a data graph processing engine for a specific
        ///         queue family of a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_data_graph
        ///         void vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfo,
        ///         VkQueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEngineProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetQueueFamilyDataGraphProcessingEnginePropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM pQueueFamilyDataGraphProcessingEngineInfo,
            ref VkQueueFamilyDataGraphProcessingEnginePropertiesARM pQueueFamilyDataGraphProcessingEngineProperties
        )
        {
            fixed (
                VkQueueFamilyDataGraphProcessingEnginePropertiesARM* pQueueFamilyDataGraphProcessingEnginePropertiesFixed =
                    &pQueueFamilyDataGraphProcessingEngineProperties
            )
            fixed (
                VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM* pQueueFamilyDataGraphProcessingEngineInfoFixed =
                    &pQueueFamilyDataGraphProcessingEngineInfo
            )
            {
                handle.PInvoke.vkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM.Invoke(
                    handle.Handle,
                    pQueueFamilyDataGraphProcessingEngineInfoFixed,
                    pQueueFamilyDataGraphProcessingEnginePropertiesFixed
                );
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkQueueFamilyDataGraphProcessingEnginePropertiesARM.</returns>
        public static VkQueueFamilyDataGraphProcessingEnginePropertiesARM GetQueueFamilyDataGraphProcessingEnginePropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM pQueueFamilyDataGraphProcessingEngineInfo
        )
        {
            VkQueueFamilyDataGraphProcessingEnginePropertiesARM outValue = new();
            GetQueueFamilyDataGraphProcessingEnginePropertiesARM(
                handle,
                pQueueFamilyDataGraphProcessingEngineInfo,
                ref outValue
            );
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM.html">vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM</see> - Query the properties of a data graph processing engine and operation set combination for a specific queue family of a physical device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM
        ///     </para>
        ///     <para>
        ///         To query the properties of a data graph processing engine and operation set
        ///         combination for a specific queue family of a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_data_graph_instruction_set_tosa, VK_ARM_data_graph_optical_flow
        ///         VkResult vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         const VkQueueFamilyDataGraphPropertiesARM*  pQueueFamilyDataGraphProperties,
        ///         VkBaseOutStructure*                         pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void GetQueueFamilyDataGraphEngineOperationPropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
            ref VkBaseOutStructure pProperties
        )
        {
            fixed (VkBaseOutStructure* pPropertiesFixed = &pProperties)
            {
                VkResult result =
                    handle.PInvoke.vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM.Invoke(
                        handle.Handle,
                        queueFamilyIndex,
                        pQueueFamilyDataGraphProperties,
                        pPropertiesFixed
                    );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkBaseOutStructure.</returns>
        public static unsafe VkBaseOutStructure GetQueueFamilyDataGraphEngineOperationPropertiesARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties
        )
        {
            VkBaseOutStructure outValue = new();
            GetQueueFamilyDataGraphEngineOperationPropertiesARM(
                handle,
                queueFamilyIndex,
                pQueueFamilyDataGraphProperties,
                ref outValue
            );
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV.html">vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV</see> - Returns properties describing what cooperative matrix types are supported
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate additional supported cooperative matrix types and operations,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_cooperative_matrix2
        ///         VkResult vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkCooperativeMatrixFlexibleDimensionsPropertiesNV* pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetCooperativeMatrixFlexibleDimensionsPropertiesNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkCooperativeMatrixFlexibleDimensionsPropertiesNV> pProperties
        )
        {
            fixed (VkCooperativeMatrixFlexibleDimensionsPropertiesNV* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result =
                    handle.PInvoke.vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV.Invoke(
                        handle.Handle,
                        pPropertyCountFixed,
                        pPropertiesFixed
                    );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetCooperativeMatrixFlexibleDimensionsPropertiesNV_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pPropertyCount = default;
            GetCooperativeMatrixFlexibleDimensionsPropertiesNV(handle, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetCooperativeMatrixFlexibleDimensionsPropertiesNV_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkCooperativeMatrixFlexibleDimensionsPropertiesNV> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return GetCooperativeMatrixFlexibleDimensionsPropertiesNV(handle, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM.html">vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM</see> - Reports properties of the by region performance counters available on a queue family of a device
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM
        ///     </para>
        ///     <para>
        ///         To enumerate the by region performance counters available on a queue family
        ///         of a physical device, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_performance_counters_by_region
        ///         VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         uint32_t*                                   pCounterCount,
        ///         VkPerformanceCounterARM*                    pCounters,
        ///         VkPerformanceCounterDescriptionARM*         pCounterDescriptions);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            ref int pCounterCount,
            scoped ReadOnlySpan<VkPerformanceCounterARM> pCounters,
            scoped ReadOnlySpan<VkPerformanceCounterDescriptionARM> pCounterDescriptions
        )
        {
            fixed (VkPerformanceCounterDescriptionARM* pCounterDescriptionsFixed = pCounterDescriptions)
            fixed (VkPerformanceCounterARM* pCountersFixed = pCounters)
            fixed (int* pCounterCountFixed = &pCounterCount)
            {
                VkResult result =
                    handle.PInvoke.vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM.Invoke(
                        handle.Handle,
                        queueFamilyIndex,
                        pCounterCountFixed,
                        pCountersFixed,
                        pCounterDescriptionsFixed
                    );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            scoped ReadOnlySpan<VkPerformanceCounterDescriptionARM> pCounterDescriptions
        )
        {
            int pCounterCount = default;
            EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
                handle,
                queueFamilyIndex,
                ref pCounterCount,
                null,
                pCounterDescriptions
            );
            return pCounterCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pCounters">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            scoped ReadOnlySpan<VkPerformanceCounterARM> pCounters,
            scoped ReadOnlySpan<VkPerformanceCounterDescriptionARM> pCounterDescriptions
        )
        {
            int pCounterCount = pCounters.Length;
            return EnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
                handle,
                queueFamilyIndex,
                ref pCounterCount,
                pCounters,
                pCounterDescriptions
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM.html">vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM</see> - Returns properties describing what shader instrumentation metrics are supported
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the available shader instrumentation metrics, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_shader_instrumentation
        ///         VkResult vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t*                                   pDescriptionCount,
        ///         VkShaderInstrumentationMetricDescriptionARM* pDescriptions);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            ref int pDescriptionCount,
            scoped ReadOnlySpan<VkShaderInstrumentationMetricDescriptionARM> pDescriptions
        )
        {
            fixed (VkShaderInstrumentationMetricDescriptionARM* pDescriptionsFixed = pDescriptions)
            fixed (int* pDescriptionCountFixed = &pDescriptionCount)
            {
                VkResult result = handle.PInvoke.vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM.Invoke(
                    handle.Handle,
                    pDescriptionCountFixed,
                    pDescriptionsFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int EnumeratePhysicalDeviceShaderInstrumentationMetricsARM_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle
        )
        {
            int pDescriptionCount = default;
            EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(handle, ref pDescriptionCount, null);
            return pDescriptionCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pDescriptions">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumeratePhysicalDeviceShaderInstrumentationMetricsARM_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            scoped ReadOnlySpan<VkShaderInstrumentationMetricDescriptionARM> pDescriptions
        )
        {
            int pDescriptionCount = pDescriptions.Length;
            return EnumeratePhysicalDeviceShaderInstrumentationMetricsARM(handle, ref pDescriptionCount, pDescriptions);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM.html">vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM</see> - Query image formats for data graph optical flow
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To enumerate the supported image formats for a specific data graph optical
        ///         flow usage, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ARM_data_graph_optical_flow
        ///         VkResult vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         const VkQueueFamilyDataGraphPropertiesARM*  pQueueFamilyDataGraphProperties,
        ///         const VkDataGraphOpticalFlowImageFormatInfoARM* pOpticalFlowImageFormatInfo,
        ///         uint32_t*                                   pFormatCount,
        ///         VkDataGraphOpticalFlowImageFormatPropertiesARM* pImageFormatProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult GetQueueFamilyDataGraphOpticalFlowImageFormatsARM(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
            in VkDataGraphOpticalFlowImageFormatInfoARM pOpticalFlowImageFormatInfo,
            ref int pFormatCount,
            scoped ReadOnlySpan<VkDataGraphOpticalFlowImageFormatPropertiesARM> pImageFormatProperties
        )
        {
            fixed (VkDataGraphOpticalFlowImageFormatPropertiesARM* pImageFormatPropertiesFixed = pImageFormatProperties)
            fixed (
                VkDataGraphOpticalFlowImageFormatInfoARM* pOpticalFlowImageFormatInfoFixed =
                    &pOpticalFlowImageFormatInfo
            )
            fixed (int* pFormatCountFixed = &pFormatCount)
            {
                VkResult result =
                    handle.PInvoke.vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM.Invoke(
                        handle.Handle,
                        queueFamilyIndex,
                        pQueueFamilyDataGraphProperties,
                        pOpticalFlowImageFormatInfoFixed,
                        pFormatCountFixed,
                        pImageFormatPropertiesFixed
                    );
                switch (result)
                {
                    case VkResult.ErrorExtensionNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorExtensionNotPresent,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM failed with error: VK_ERROR_EXTENSION_NOT_PRESENT"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorFormatNotSupported:
                        throw new VkResultError(
                            VkResult.ErrorFormatNotSupported,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM failed with error: VK_ERROR_FORMAT_NOT_SUPPORTED"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    case VkResult.Incomplete:
                    default:
                        break;
                }

                return result;
            }
        }

        /// <summary>Queries the required length.</summary>
        /// <returns>The required length.</returns>
        public static int GetQueueFamilyDataGraphOpticalFlowImageFormatsARM_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
            in VkDataGraphOpticalFlowImageFormatInfoARM pOpticalFlowImageFormatInfo
        )
        {
            int pFormatCount = default;
            GetQueueFamilyDataGraphOpticalFlowImageFormatsARM(
                handle,
                queueFamilyIndex,
                pQueueFamilyDataGraphProperties,
                pOpticalFlowImageFormatInfo,
                ref pFormatCount,
                null
            );
            return pFormatCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pImageFormatProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult GetQueueFamilyDataGraphOpticalFlowImageFormatsARM_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            VkQueueFamilyDataGraphPropertiesARM* pQueueFamilyDataGraphProperties,
            in VkDataGraphOpticalFlowImageFormatInfoARM pOpticalFlowImageFormatInfo,
            scoped ReadOnlySpan<VkDataGraphOpticalFlowImageFormatPropertiesARM> pImageFormatProperties
        )
        {
            int pFormatCount = pImageFormatProperties.Length;
            return GetQueueFamilyDataGraphOpticalFlowImageFormatsARM(
                handle,
                queueFamilyIndex,
                pQueueFamilyDataGraphProperties,
                pOpticalFlowImageFormatInfo,
                ref pFormatCount,
                pImageFormatProperties
            );
        }
    }
}
