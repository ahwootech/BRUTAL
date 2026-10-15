using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Xlib
{
    public static unsafe partial class XlibExtensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateXlibSurfaceKHR.html">vkCreateXlibSurfaceKHR</see> - Create a &lt;c&gt;VkSurfaceKHR&lt;/c&gt; object for an X11 window, using the Xlib client-side library
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateXlibSurfaceKHR
        ///     </para>
        ///     <para>
        ///         To create a <c>VkSurfaceKHR</c> object for an X11 window, using the Xlib
        ///         client-side library, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_xlib_surface
        ///         VkResult vkCreateXlibSurfaceKHR(
        ///         VkInstance                                  instance,
        ///         const VkXlibSurfaceCreateInfoKHR*           pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe void CreateXlibSurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkXlibSurfaceCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator,
            out VkSurfaceKHR pSurface
        )
        {
            fixed (VkXlibSurfaceCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateXlibSurfaceKHR.Invoke(
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
                            "Vulkan call to vkCreateXlibSurfaceKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateXlibSurfaceKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateXlibSurfaceKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateXlibSurfaceKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                pSurface = pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXlibPresentationSupportKHR.html">vkGetPhysicalDeviceXlibPresentationSupportKHR</see> - Query physical device for presentation to X11 server using Xlib
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To determine whether a queue family of a physical device supports
        ///         presentation to an X11 server, using the Xlib client-side library, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_xlib_surface
        ///         VkBool32 vkGetPhysicalDeviceXlibPresentationSupportKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         Display*                                    dpy,
        ///         VisualID                                    visualID);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe Brutal.Bool32 GetXlibPresentationSupportKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            void* dpy,
            nint visualID
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceXlibPresentationSupportKHR.Invoke(
                handle.Handle,
                queueFamilyIndex,
                dpy,
                visualID
            );
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAcquireXlibDisplayEXT.html">vkAcquireXlibDisplayEXT</see> - Acquire access to a VkDisplayKHR using Xlib
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To acquire permission to directly access a display in Vulkan from an X11
        ///         server, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_acquire_xlib_display
        ///         VkResult vkAcquireXlibDisplayEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         Display*                                    dpy,
        ///         VkDisplayKHR                                display);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe void AcquireXlibDisplayEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            void* dpy,
            VkDisplayKHR display
        )
        {
            VkResult result = handle.PInvoke.vkAcquireXlibDisplayEXT.Invoke(handle.Handle, dpy, display);
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkAcquireXlibDisplayEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorInitializationFailed:
                    throw new VkResultError(
                        VkResult.ErrorInitializationFailed,
                        "Vulkan call to vkAcquireXlibDisplayEXT failed with error: VK_ERROR_INITIALIZATION_FAILED"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkAcquireXlibDisplayEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkAcquireXlibDisplayEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetRandROutputDisplayEXT.html">vkGetRandROutputDisplayEXT</see> - Query the VkDisplayKHR corresponding to an X11 RandR Output
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         When acquiring displays from an X11 server, an application may also wish to
        ///         enumerate and identify them using a native handle rather than a
        ///         <c>VkDisplayKHR</c> handle.
        ///         To determine the <c>VkDisplayKHR</c> handle corresponding to an X11 RandR
        ///         Output, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_EXT_acquire_xlib_display
        ///         VkResult vkGetRandROutputDisplayEXT(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         Display*                                    dpy,
        ///         RROutput                                    rrOutput,
        ///         VkDisplayKHR*                               pDisplay);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe VkDisplayKHR GetRandROutputDisplayEXT(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            void* dpy,
            nint rrOutput
        )
        {
            VkDisplayKHR pDisplayLocal = default;
            VkResult result = handle.PInvoke.vkGetRandROutputDisplayEXT.Invoke(
                handle.Handle,
                dpy,
                rrOutput,
                &pDisplayLocal
            );
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkGetRandROutputDisplayEXT failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkGetRandROutputDisplayEXT failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkGetRandROutputDisplayEXT failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }

            return pDisplayLocal;
        }
    }
}
