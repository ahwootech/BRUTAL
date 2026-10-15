using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Xcb
{
    public static unsafe partial class XcbExtensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateXcbSurfaceKHR.html">vkCreateXcbSurfaceKHR</see> - Create a &lt;c&gt;VkSurfaceKHR&lt;/c&gt; object for a X11 window, using the XCB client-side library
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateXcbSurfaceKHR
        ///     </para>
        ///     <para>
        ///         To create a <c>VkSurfaceKHR</c> object for an X11 window, using the XCB
        ///         client-side library, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_xcb_surface
        ///         VkResult vkCreateXcbSurfaceKHR(
        ///         VkInstance                                  instance,
        ///         const VkXcbSurfaceCreateInfoKHR*            pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe void CreateXcbSurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkXcbSurfaceCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator,
            out VkSurfaceKHR pSurface
        )
        {
            fixed (VkXcbSurfaceCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateXcbSurfaceKHR.Invoke(
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
                            "Vulkan call to vkCreateXcbSurfaceKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateXcbSurfaceKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateXcbSurfaceKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateXcbSurfaceKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                pSurface = pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXcbPresentationSupportKHR.html">vkGetPhysicalDeviceXcbPresentationSupportKHR</see> - Query physical device for presentation to X11 server using XCB
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To determine whether a queue family of a physical device supports
        ///         presentation to an X11 server, using the XCB client-side library, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_xcb_surface
        ///         VkBool32 vkGetPhysicalDeviceXcbPresentationSupportKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         xcb_connection_t*                           connection,
        ///         xcb_visualid_t                              visual_id);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe Brutal.Bool32 GetXcbPresentationSupportKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            void* connection,
            int visual_id
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceXcbPresentationSupportKHR.Invoke(
                handle.Handle,
                queueFamilyIndex,
                connection,
                visual_id
            );
        }
    }
}
