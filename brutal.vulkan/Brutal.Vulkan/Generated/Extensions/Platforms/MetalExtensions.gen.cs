using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Metal
{
    public static unsafe partial class MetalExtensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateMetalSurfaceEXT.html">vkCreateMetalSurfaceEXT</see> - Create a VkSurfaceKHR object for CAMetalLayer
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateMetalSurfaceEXT
        ///     </para>
        ///     <para>
        ///         To create a <c>VkSurfaceKHR</c> object for a basetype:CAMetalLayer, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_metal_surface
        ///         VkResult vkCreateMetalSurfaceEXT(
        ///         VkInstance                                  instance,
        ///         const VkMetalSurfaceCreateInfoEXT*          pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
        public static unsafe void CreateMetalSurfaceEXT(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkMetalSurfaceCreateInfoEXT pCreateInfo,
            VkAllocator? pAllocator,
            out VkSurfaceKHR pSurface
        )
        {
            fixed (VkMetalSurfaceCreateInfoEXT* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateMetalSurfaceEXT.Invoke(
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
                            "Vulkan call to vkCreateMetalSurfaceEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateMetalSurfaceEXT failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorNativeWindowInUseKHR:
                        throw new VkResultError(
                            VkResult.ErrorNativeWindowInUseKHR,
                            "Vulkan call to vkCreateMetalSurfaceEXT failed with error: VK_ERROR_NATIVE_WINDOW_IN_USE_KHR"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateMetalSurfaceEXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateMetalSurfaceEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                pSurface = pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkExportMetalObjectsEXT.html">vkExportMetalObjectsEXT</see> - Export Metal objects from the corresponding Vulkan objects
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To export Metal objects that underlie Vulkan objects, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_metal_objects
        ///         void vkExportMetalObjectsEXT(
        ///         VkDevice                                    device,
        ///         VkExportMetalObjectsInfoEXT*                pMetalObjectsInfo);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
        public static unsafe void ExportMetalObjectsEXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            ref VkExportMetalObjectsInfoEXT pMetalObjectsInfo
        )
        {
            fixed (VkExportMetalObjectsInfoEXT* pMetalObjectsInfoFixed = &pMetalObjectsInfo)
            {
                handle.PInvoke.vkExportMetalObjectsEXT.Invoke(handle.Handle, pMetalObjectsInfoFixed);
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryMetalHandleEXT.html">vkGetMemoryMetalHandleEXT</see> - Get a Metal handle for a memory object
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To export a Metal handle representing the payload of a Vulkan device memory
        ///         object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_external_memory_metal
        ///         VkResult vkGetMemoryMetalHandleEXT(
        ///         VkDevice                                    device,
        ///         const VkMemoryGetMetalHandleInfoEXT*        pGetMetalHandleInfo,
        ///         void**                                      pHandle);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
        public static unsafe void* GetMemoryMetalHandleEXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            in VkMemoryGetMetalHandleInfoEXT pGetMetalHandleInfo
        )
        {
            fixed (VkMemoryGetMetalHandleInfoEXT* pGetMetalHandleInfoFixed = &pGetMetalHandleInfo)
            {
                void* pHandleLocal = default;
                VkResult result = handle.PInvoke.vkGetMemoryMetalHandleEXT.Invoke(
                    handle.Handle,
                    pGetMetalHandleInfoFixed,
                    &pHandleLocal
                );
                switch (result)
                {
                    case VkResult.ErrorTooManyObjects:
                        throw new VkResultError(
                            VkResult.ErrorTooManyObjects,
                            "Vulkan call to vkGetMemoryMetalHandleEXT failed with error: VK_ERROR_TOO_MANY_OBJECTS"
                        );
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetMemoryMetalHandleEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetMemoryMetalHandleEXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetMemoryMetalHandleEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pHandleLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetMemoryMetalHandlePropertiesEXT.html">vkGetMemoryMetalHandlePropertiesEXT</see> - Get Properties of External Memory Metal Handles
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Metal memory handles compatible with Vulkan may: also be created by
        ///         non-Vulkan APIs using methods beyond the scope of this specification.
        ///         To determine the correct parameters to use when importing such handles,
        ///         call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_external_memory_metal
        ///         VkResult vkGetMemoryMetalHandlePropertiesEXT(
        ///         VkDevice                                    device,
        ///         VkExternalMemoryHandleTypeFlagBits          handleType,
        ///         const void*                                 pHandle,
        ///         VkMemoryMetalHandlePropertiesEXT*           pMemoryMetalHandleProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
        public static unsafe void GetMemoryMetalHandlePropertiesEXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkExternalMemoryHandleTypeFlags handleType,
            void* pHandle,
            ref VkMemoryMetalHandlePropertiesEXT pMemoryMetalHandleProperties
        )
        {
            fixed (VkMemoryMetalHandlePropertiesEXT* pMemoryMetalHandlePropertiesFixed = &pMemoryMetalHandleProperties)
            {
                VkResult result = handle.PInvoke.vkGetMemoryMetalHandlePropertiesEXT.Invoke(
                    handle.Handle,
                    handleType,
                    pHandle,
                    pMemoryMetalHandlePropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkGetMemoryMetalHandlePropertiesEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorInvalidExternalHandle:
                        throw new VkResultError(
                            VkResult.ErrorInvalidExternalHandle,
                            "Vulkan call to vkGetMemoryMetalHandlePropertiesEXT failed with error: VK_ERROR_INVALID_EXTERNAL_HANDLE"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkGetMemoryMetalHandlePropertiesEXT failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkGetMemoryMetalHandlePropertiesEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }
            }
        }

        /// <summary>Wrapper that returns the struct instead of taking it as a ref parameter.</summary>
        /// <returns>The VkMemoryMetalHandlePropertiesEXT.</returns>
        [SupportedOSPlatform("macos"), SupportedOSPlatform("ios")]
        public static unsafe VkMemoryMetalHandlePropertiesEXT GetMemoryMetalHandlePropertiesEXT(
            this VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable> handle,
            VkExternalMemoryHandleTypeFlags handleType,
            void* pHandle
        )
        {
            VkMemoryMetalHandlePropertiesEXT outValue = new();
            GetMemoryMetalHandlePropertiesEXT(handle, handleType, pHandle, ref outValue);
            return outValue;
        }
    }
}
