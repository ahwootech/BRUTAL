using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    public static unsafe partial class Win32Extensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateWin32SurfaceKHR.html">vkCreateWin32SurfaceKHR</see> - Create a VkSurfaceKHR object for a Win32 native window
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateWin32SurfaceKHR
        ///     </para>
        ///     <para>
        ///         To create a <c>VkSurfaceKHR</c> object for a Win32 window, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_win32_surface
        ///         VkResult vkCreateWin32SurfaceKHR(
        ///         VkInstance                                  instance,
        ///         const VkWin32SurfaceCreateInfoKHR*          pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe void CreateWin32SurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkWin32SurfaceCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator,
            out VkSurfaceKHR pSurface
        )
        {
            fixed (VkWin32SurfaceCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateWin32SurfaceKHR.Invoke(
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
                            "Vulkan call to vkCreateWin32SurfaceKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateWin32SurfaceKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateWin32SurfaceKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateWin32SurfaceKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                pSurface = pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWin32PresentationSupportKHR.html">vkGetPhysicalDeviceWin32PresentationSupportKHR</see> - Query queue family support for presentation on a Win32 display
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To determine whether a queue family of a physical device supports
        ///         presentation to the Microsoft Windows desktop, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_win32_surface
        ///         VkBool32 vkGetPhysicalDeviceWin32PresentationSupportKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static Brutal.Bool32 GetWin32PresentationSupportKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceWin32PresentationSupportKHR.Invoke(
                handle.Handle,
                queueFamilyIndex
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleKHR.html">vkGetMemoryWin32HandleKHR</see> - Get a Windows HANDLE for a memory object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To export a Windows handle representing the payload of a Vulkan device
        ///         memory object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_external_memory_win32
        ///         VkResult vkGetMemoryWin32HandleKHR(
        ///         VkDevice                                    device,
        ///         const VkMemoryGetWin32HandleInfoKHR*        pGetWin32HandleInfo,
        ///         HANDLE*                                     pHandle);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe nint GetMemoryWin32HandleKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkMemoryGetWin32HandleInfoKHR pGetWin32HandleInfo
        )
        {
            fixed (VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfoFixed = &pGetWin32HandleInfo)
            {
                nint pHandleLocal = default;
                VkResult result = handle.PInvoke.vkGetMemoryWin32HandleKHR.Invoke(
                    handle.Handle,
                    pGetWin32HandleInfoFixed,
                    &pHandleLocal
                );
                switch (result)
                {
                    case VkResult.ErrorTooManyObjects:
                        throw new VkResultError(
                            VkResult.ErrorTooManyObjects,
                            "Vulkan call to vkGetMemoryWin32HandleKHR failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                        );
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetMemoryWin32HandleKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetMemoryWin32HandleKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetMemoryWin32HandleKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pHandleLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandlePropertiesKHR.html">vkGetMemoryWin32HandlePropertiesKHR</see> - Get Properties of External Memory Win32 Handles
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Windows memory handles compatible with Vulkan may: also be created by
        ///         non-Vulkan APIs using methods beyond the scope of this specification.
        ///         To determine the correct parameters to use when importing such handles,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_external_memory_win32
        ///         VkResult vkGetMemoryWin32HandlePropertiesKHR(
        ///         VkDevice                                    device,
        ///         VkExternalMemoryHandleTypeFlagBits          handleType,
        ///         HANDLE                                      handle,
        ///         VkMemoryWin32HandlePropertiesKHR*           pMemoryWin32HandleProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe void GetMemoryWin32HandlePropertiesKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkExternalMemoryHandleTypeFlags handleType,
            nint win32Handle,
            ref VkMemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties
        )
        {
            fixed (VkMemoryWin32HandlePropertiesKHR* pMemoryWin32HandlePropertiesFixed = &pMemoryWin32HandleProperties)
            {
                VkResult result = handle.PInvoke.vkGetMemoryWin32HandlePropertiesKHR.Invoke(
                    handle.Handle,
                    handleType,
                    win32Handle,
                    pMemoryWin32HandlePropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetMemoryWin32HandlePropertiesKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorInvalidExternalHandle:
                        throw new VkResultError(
                            VkResult.ErrorInvalidExternalHandle,
                            "Vulkan call to vkGetMemoryWin32HandlePropertiesKHR failed with error: VK_ERROR_INVALID_EXTERNAL_HANDLE"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetMemoryWin32HandlePropertiesKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetMemoryWin32HandlePropertiesKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkMemoryWin32HandlePropertiesKHR.</returns>
        [SupportedOSPlatform("windows")]
        public static VkMemoryWin32HandlePropertiesKHR GetMemoryWin32HandlePropertiesKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkExternalMemoryHandleTypeFlags handleType,
            nint win32Handle
        )
        {
            VkMemoryWin32HandlePropertiesKHR outValue = new();
            GetMemoryWin32HandlePropertiesKHR(handle, handleType, win32Handle, ref outValue);
            return outValue;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportSemaphoreWin32HandleKHR.html">vkImportSemaphoreWin32HandleKHR</see> - Import a semaphore from a Windows HANDLE
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To import a semaphore payload from a Windows handle, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_external_semaphore_win32
        ///         VkResult vkImportSemaphoreWin32HandleKHR(
        ///         VkDevice                                    device,
        ///         const VkImportSemaphoreWin32HandleInfoKHR*  pImportSemaphoreWin32HandleInfo);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe void ImportSemaphoreWin32HandleKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo
        )
        {
            fixed (
                VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfoFixed =
                    &pImportSemaphoreWin32HandleInfo
            )
            {
                VkResult result = handle.PInvoke.vkImportSemaphoreWin32HandleKHR.Invoke(
                    handle.Handle,
                    pImportSemaphoreWin32HandleInfoFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkImportSemaphoreWin32HandleKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorInvalidExternalHandle:
                        throw new VkResultError(
                            VkResult.ErrorInvalidExternalHandle,
                            "Vulkan call to vkImportSemaphoreWin32HandleKHR failed with error: VK_ERROR_INVALID_EXTERNAL_HANDLE"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkImportSemaphoreWin32HandleKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkImportSemaphoreWin32HandleKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetSemaphoreWin32HandleKHR.html">vkGetSemaphoreWin32HandleKHR</see> - Get a Windows HANDLE for a semaphore
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To export a Windows handle representing the payload of a semaphore, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_external_semaphore_win32
        ///         VkResult vkGetSemaphoreWin32HandleKHR(
        ///         VkDevice                                    device,
        ///         const VkSemaphoreGetWin32HandleInfoKHR*     pGetWin32HandleInfo,
        ///         HANDLE*                                     pHandle);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe nint GetSemaphoreWin32HandleKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkSemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo
        )
        {
            fixed (VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfoFixed = &pGetWin32HandleInfo)
            {
                nint pHandleLocal = default;
                VkResult result = handle.PInvoke.vkGetSemaphoreWin32HandleKHR.Invoke(
                    handle.Handle,
                    pGetWin32HandleInfoFixed,
                    &pHandleLocal
                );
                switch (result)
                {
                    case VkResult.ErrorTooManyObjects:
                        throw new VkResultError(
                            VkResult.ErrorTooManyObjects,
                            "Vulkan call to vkGetSemaphoreWin32HandleKHR failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                        );
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetSemaphoreWin32HandleKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetSemaphoreWin32HandleKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetSemaphoreWin32HandleKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pHandleLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkImportFenceWin32HandleKHR.html">vkImportFenceWin32HandleKHR</see> - Import a fence from a Windows HANDLE
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To import a fence payload from a Windows handle, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_external_fence_win32
        ///         VkResult vkImportFenceWin32HandleKHR(
        ///         VkDevice                                    device,
        ///         const VkImportFenceWin32HandleInfoKHR*      pImportFenceWin32HandleInfo);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe void ImportFenceWin32HandleKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo
        )
        {
            fixed (VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfoFixed = &pImportFenceWin32HandleInfo)
            {
                VkResult result = handle.PInvoke.vkImportFenceWin32HandleKHR.Invoke(
                    handle.Handle,
                    pImportFenceWin32HandleInfoFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkImportFenceWin32HandleKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorInvalidExternalHandle:
                        throw new VkResultError(
                            VkResult.ErrorInvalidExternalHandle,
                            "Vulkan call to vkImportFenceWin32HandleKHR failed with error: VK_ERROR_INVALID_EXTERNAL_HANDLE"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkImportFenceWin32HandleKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkImportFenceWin32HandleKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetFenceWin32HandleKHR.html">vkGetFenceWin32HandleKHR</see> - Get a Windows HANDLE for a fence
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To export a Windows handle representing the state of a fence, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_external_fence_win32
        ///         VkResult vkGetFenceWin32HandleKHR(
        ///         VkDevice                                    device,
        ///         const VkFenceGetWin32HandleInfoKHR*         pGetWin32HandleInfo,
        ///         HANDLE*                                     pHandle);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe nint GetFenceWin32HandleKHR(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkFenceGetWin32HandleInfoKHR pGetWin32HandleInfo
        )
        {
            fixed (VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfoFixed = &pGetWin32HandleInfo)
            {
                nint pHandleLocal = default;
                VkResult result = handle.PInvoke.vkGetFenceWin32HandleKHR.Invoke(
                    handle.Handle,
                    pGetWin32HandleInfoFixed,
                    &pHandleLocal
                );
                switch (result)
                {
                    case VkResult.ErrorTooManyObjects:
                        throw new VkResultError(
                            VkResult.ErrorTooManyObjects,
                            "Vulkan call to vkGetFenceWin32HandleKHR failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                        );
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetFenceWin32HandleKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetFenceWin32HandleKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetFenceWin32HandleKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pHandleLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html">vkGetMemoryWin32HandleNV</see> - Retrieve Win32 handle to a device memory object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To retrieve the handle corresponding to a device memory object created with
        ///         <c>VkExportMemoryAllocateInfoNV::handleTypes</c> set to include
        ///         <c>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV</c> or
        ///         <c>VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV</c>, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_external_memory_win32
        ///         VkResult vkGetMemoryWin32HandleNV(
        ///         VkDevice                                    device,
        ///         VkDeviceMemory                              memory,
        ///         VkExternalMemoryHandleTypeFlagsNV           handleType,
        ///         HANDLE*                                     pHandle);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe nint GetMemoryWin32HandleNV(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkDeviceMemory memory,
            VkExternalMemoryHandleTypeFlagsNV handleType
        )
        {
            nint pHandleLocal = default;
            VkResult result = handle.PInvoke.vkGetMemoryWin32HandleNV.Invoke(
                handle.Handle,
                memory,
                handleType,
                &pHandleLocal
            );
            switch (result)
            {
                case VkResult.ErrorTooManyObjects:
                    throw new VkResultError(
                        VkResult.ErrorTooManyObjects,
                        "Vulkan call to vkGetMemoryWin32HandleNV failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                    );
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkGetMemoryWin32HandleNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkGetMemoryWin32HandleNV failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkGetMemoryWin32HandleNV failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }

            return pHandleLocal;
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModes2EXT.html">vkGetPhysicalDeviceSurfacePresentModes2EXT</see> - Query supported presentation modes
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetPhysicalDeviceSurfacePresentModes2EXT
        ///     </para>
        ///     <para>
        ///         To query the supported presentation modes for a surface combined with select
        ///         other fixed swapchain creation parameters, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_full_screen_exclusive
        ///         VkResult vkGetPhysicalDeviceSurfacePresentModes2EXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         const VkPhysicalDeviceSurfaceInfo2KHR*      pSurfaceInfo,
        ///         uint32_t*                                   pPresentModeCount,
        ///         VkPresentModeKHR*                           pPresentModes);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        private static unsafe VkResult GetSurfacePresentModes2EXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
            ref int pPresentModeCount,
            scoped ReadOnlySpan<VkPresentModeKHR> pPresentModes
        )
        {
            fixed (VkPresentModeKHR* pPresentModesFixed = pPresentModes)
            fixed (VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfoFixed = &pSurfaceInfo)
            fixed (int* pPresentModeCountFixed = &pPresentModeCount)
            {
                VkResult result = handle.PInvoke.vkGetPhysicalDeviceSurfacePresentModes2EXT.Invoke(
                    handle.Handle,
                    pSurfaceInfoFixed,
                    pPresentModeCountFixed,
                    pPresentModesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModes2EXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModes2EXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModes2EXT failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModes2EXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetPhysicalDeviceSurfacePresentModes2EXT failed with error: VK_ERROR_VALIDATION_FAILED"
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
        [SupportedOSPlatform("windows")]
        public static int GetSurfacePresentModes2EXT_Count(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo
        )
        {
            int pPresentModeCount = default;
            GetSurfacePresentModes2EXT(handle, pSurfaceInfo, ref pPresentModeCount, null);
            return pPresentModeCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pPresentModes">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        [SupportedOSPlatform("windows")]
        public static VkResult GetSurfacePresentModes2EXT_Write(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo,
            scoped ReadOnlySpan<VkPresentModeKHR> pPresentModes
        )
        {
            int pPresentModeCount = pPresentModes.Length;
            return GetSurfacePresentModes2EXT(handle, pSurfaceInfo, ref pPresentModeCount, pPresentModes);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireFullScreenExclusiveModeEXT.html">vkAcquireFullScreenExclusiveModeEXT</see> - Acquire full-screen exclusive mode for a swapchain
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To acquire exclusive full-screen access for a swapchain, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_full_screen_exclusive
        ///         VkResult vkAcquireFullScreenExclusiveModeEXT(
        ///         VkDevice                                    device,
        ///         VkSwapchainKHR                              swapchain);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static void AcquireFullScreenExclusiveModeEXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkSwapchainKHR swapchain
        )
        {
            VkResult result = handle.PInvoke.vkAcquireFullScreenExclusiveModeEXT.Invoke(handle.Handle, swapchain);
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkAcquireFullScreenExclusiveModeEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorOutOfDeviceMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfDeviceMemory,
                        "Vulkan call to vkAcquireFullScreenExclusiveModeEXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                    );
                case VkResult.ErrorInitializationFailed:
                    throw new VkResultError(
                        VkResult.ErrorInitializationFailed,
                        "Vulkan call to vkAcquireFullScreenExclusiveModeEXT failed with error: VK_ERROR_INITIALIZATION_FAILED"
                    );
                case VkResult.ErrorSurfaceLostKHR:
                    throw new VkResultError(
                        VkResult.ErrorSurfaceLostKHR,
                        "Vulkan call to vkAcquireFullScreenExclusiveModeEXT failed with error: VK_ERROR_SURFACE_LOST_KHR"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkAcquireFullScreenExclusiveModeEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkAcquireFullScreenExclusiveModeEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkReleaseFullScreenExclusiveModeEXT.html">vkReleaseFullScreenExclusiveModeEXT</see> - Release full-screen exclusive mode from a swapchain
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To release exclusive full-screen access from a swapchain, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_full_screen_exclusive
        ///         VkResult vkReleaseFullScreenExclusiveModeEXT(
        ///         VkDevice                                    device,
        ///         VkSwapchainKHR                              swapchain);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static void ReleaseFullScreenExclusiveModeEXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkSwapchainKHR swapchain
        )
        {
            VkResult result = handle.PInvoke.vkReleaseFullScreenExclusiveModeEXT.Invoke(handle.Handle, swapchain);
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkReleaseFullScreenExclusiveModeEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorOutOfDeviceMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfDeviceMemory,
                        "Vulkan call to vkReleaseFullScreenExclusiveModeEXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                    );
                case VkResult.ErrorSurfaceLostKHR:
                    throw new VkResultError(
                        VkResult.ErrorSurfaceLostKHR,
                        "Vulkan call to vkReleaseFullScreenExclusiveModeEXT failed with error: VK_ERROR_SURFACE_LOST_KHR"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkReleaseFullScreenExclusiveModeEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkReleaseFullScreenExclusiveModeEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModes2EXT.html">vkGetDeviceGroupSurfacePresentModes2EXT</see> - Query device group present capabilities for a surface
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the supported device group presentation modes for a surface
        ///         combined with select other fixed swapchain creation parameters, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_full_screen_exclusive with VK_KHR_device_group or VK_VERSION_1_1
        ///         VkResult vkGetDeviceGroupSurfacePresentModes2EXT(
        ///         VkDevice                                    device,
        ///         const VkPhysicalDeviceSurfaceInfo2KHR*      pSurfaceInfo,
        ///         VkDeviceGroupPresentModeFlagsKHR*           pModes);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe VkDeviceGroupPresentModeFlagsKHR GetGroupSurfacePresentModes2EXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo
        )
        {
            fixed (VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfoFixed = &pSurfaceInfo)
            {
                VkDeviceGroupPresentModeFlagsKHR pModesLocal = default;
                VkResult result = handle.PInvoke.vkGetDeviceGroupSurfacePresentModes2EXT.Invoke(
                    handle.Handle,
                    pSurfaceInfoFixed,
                    &pModesLocal
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetDeviceGroupSurfacePresentModes2EXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkGetDeviceGroupSurfacePresentModes2EXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorSurfaceLostKHR:
                        throw new VkResultError(
                            VkResult.ErrorSurfaceLostKHR,
                            "Vulkan call to vkGetDeviceGroupSurfacePresentModes2EXT failed with error: VK_ERROR_SURFACE_LOST_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetDeviceGroupSurfacePresentModes2EXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetDeviceGroupSurfacePresentModes2EXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pModesLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireWinrtDisplayNV.html">vkAcquireWinrtDisplayNV</see> - Acquire access to a VkDisplayKHR
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkAcquireWinrtDisplayNV
        ///     </para>
        ///     <para>
        ///         To acquire permission to directly access a display in Vulkan on Windows 10,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_acquire_winrt_display
        ///         VkResult vkAcquireWinrtDisplayNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         VkDisplayKHR                                display);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static void AcquireWinrtDisplayNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            VkDisplayKHR display
        )
        {
            VkResult result = handle.PInvoke.vkAcquireWinrtDisplayNV.Invoke(handle.Handle, display);
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkAcquireWinrtDisplayNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorDeviceLost:
                    throw new VkResultError(
                        VkResult.ErrorDeviceLost,
                        "Vulkan call to vkAcquireWinrtDisplayNV failed with error: VK_ERROR_DEVICE_LOST"
                    );
                case VkResult.ErrorInitializationFailed:
                    throw new VkResultError(
                        VkResult.ErrorInitializationFailed,
                        "Vulkan call to vkAcquireWinrtDisplayNV failed with error: VK_ERROR_INITIALIZATION_FAILED"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkAcquireWinrtDisplayNV failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkAcquireWinrtDisplayNV failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetWinrtDisplayNV.html">vkGetWinrtDisplayNV</see> - Query the VkDisplayKHR corresponding to a WinRT DisplayTarget
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkGetWinrtDisplayNV
        ///     </para>
        ///     <para>
        ///         When acquiring displays on Windows 10, an application may also wish to
        ///         enumerate and identify them using a native handle rather than a
        ///         <c>VkDisplayKHR</c> handle.
        ///     </para>
        ///     <para>
        ///         To determine the <c>VkDisplayKHR</c> handle corresponding to a
        ///         https://docs.microsoft.com/en-us/uwp/api/windows.devices.display.core.displaytarget[&quot;`winrt::Windows::Devices::Display::Core::DisplayTarget`&quot;],
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_NV_acquire_winrt_display
        ///         VkResult vkGetWinrtDisplayNV(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    deviceRelativeId,
        ///         VkDisplayKHR*                               pDisplay);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("windows")]
        public static unsafe VkDisplayKHR GetWinrtDisplayNV(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int deviceRelativeId
        )
        {
            VkDisplayKHR pDisplayLocal = default;
            VkResult result = handle.PInvoke.vkGetWinrtDisplayNV.Invoke(
                handle.Handle,
                deviceRelativeId,
                &pDisplayLocal
            );
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkGetWinrtDisplayNV failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorDeviceLost:
                    throw new VkResultError(
                        VkResult.ErrorDeviceLost,
                        "Vulkan call to vkGetWinrtDisplayNV failed with error: VK_ERROR_DEVICE_LOST"
                    );
                case VkResult.ErrorInitializationFailed:
                    throw new VkResultError(
                        VkResult.ErrorInitializationFailed,
                        "Vulkan call to vkGetWinrtDisplayNV failed with error: VK_ERROR_INITIALIZATION_FAILED"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkGetWinrtDisplayNV failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkGetWinrtDisplayNV failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }

            return pDisplayLocal;
        }
    }
}
