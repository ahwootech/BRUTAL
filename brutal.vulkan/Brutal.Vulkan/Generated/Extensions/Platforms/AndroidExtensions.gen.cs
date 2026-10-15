using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    public static unsafe partial class AndroidExtensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateAndroidSurfaceKHR.html">vkCreateAndroidSurfaceKHR</see> - Create a &lt;c&gt;VkSurfaceKHR&lt;/c&gt; object for an Android native window
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateAndroidSurfaceKHR
        ///     </para>
        ///     <para>
        ///         To create a <c>VkSurfaceKHR</c> object for an Android native window, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_android_surface
        ///         VkResult vkCreateAndroidSurfaceKHR(
        ///         VkInstance                                  instance,
        ///         const VkAndroidSurfaceCreateInfoKHR*        pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("android")]
        public static unsafe void CreateAndroidSurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkAndroidSurfaceCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator,
            out VkSurfaceKHR pSurface
        )
        {
            fixed (VkAndroidSurfaceCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateAndroidSurfaceKHR.Invoke(
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
                            "Vulkan call to vkCreateAndroidSurfaceKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateAndroidSurfaceKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorNativeWindowInUseKHR:
                        throw new VkResultError(
                            VkResult.ErrorNativeWindowInUseKHR,
                            "Vulkan call to vkCreateAndroidSurfaceKHR failed with error: VK_ERROR_NATIVE_WINDOW_IN_USE_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateAndroidSurfaceKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateAndroidSurfaceKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                pSurface = pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetAndroidHardwareBufferPropertiesANDROID.html">vkGetAndroidHardwareBufferPropertiesANDROID</see> - Get Properties of External Memory Android Hardware Buffers
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To determine the memory parameters to use when importing an Android hardware
        ///         buffer, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
        ///         VkResult vkGetAndroidHardwareBufferPropertiesANDROID(
        ///         VkDevice                                    device,
        ///         const struct AHardwareBuffer*               buffer,
        ///         VkAndroidHardwareBufferPropertiesANDROID*   pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("android")]
        public static unsafe void GetAndroidHardwareBufferPropertiesANDROID(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            void* buffer,
            ref VkAndroidHardwareBufferPropertiesANDROID pProperties
        )
        {
            fixed (VkAndroidHardwareBufferPropertiesANDROID* pPropertiesFixed = &pProperties)
            {
                VkResult result = handle.PInvoke.vkGetAndroidHardwareBufferPropertiesANDROID.Invoke(
                    handle.Handle,
                    buffer,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetAndroidHardwareBufferPropertiesANDROID failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorInvalidExternalHandleKHR:
                        throw new VkResultError(
                            VkResult.ErrorInvalidExternalHandleKHR,
                            "Vulkan call to vkGetAndroidHardwareBufferPropertiesANDROID failed with error: VK_ERROR_INVALID_EXTERNAL_HANDLE_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetAndroidHardwareBufferPropertiesANDROID failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetAndroidHardwareBufferPropertiesANDROID failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkAndroidHardwareBufferPropertiesANDROID.</returns>
        [SupportedOSPlatform("android")]
        public static unsafe VkAndroidHardwareBufferPropertiesANDROID GetAndroidHardwareBufferPropertiesANDROID(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            void* buffer
        )
        {
            VkAndroidHardwareBufferPropertiesANDROID outValue = new();
            GetAndroidHardwareBufferPropertiesANDROID(handle, buffer, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryAndroidHardwareBufferANDROID.html">vkGetMemoryAndroidHardwareBufferANDROID</see> - Get an Android hardware buffer for a memory object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To export an Android hardware buffer referencing the payload of a Vulkan
        ///         device memory object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_ANDROID_external_memory_android_hardware_buffer
        ///         VkResult vkGetMemoryAndroidHardwareBufferANDROID(
        ///         VkDevice                                    device,
        ///         const VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo,
        ///         struct AHardwareBuffer**                    pBuffer);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("android")]
        public static unsafe void* GetMemoryAndroidHardwareBufferANDROID(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkMemoryGetAndroidHardwareBufferInfoANDROID pInfo
        )
        {
            fixed (VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfoFixed = &pInfo)
            {
                void* pBufferLocal = default;
                VkResult result = handle.PInvoke.vkGetMemoryAndroidHardwareBufferANDROID.Invoke(
                    handle.Handle,
                    pInfoFixed,
                    &pBufferLocal
                );
                switch (result)
                {
                    case VkResult.ErrorTooManyObjects:
                        throw new VkResultError(
                            VkResult.ErrorTooManyObjects,
                            "Vulkan call to vkGetMemoryAndroidHardwareBufferANDROID failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                        );
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetMemoryAndroidHardwareBufferANDROID failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetMemoryAndroidHardwareBufferANDROID failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetMemoryAndroidHardwareBufferANDROID failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pBufferLocal;
            }
        }
    }
}
