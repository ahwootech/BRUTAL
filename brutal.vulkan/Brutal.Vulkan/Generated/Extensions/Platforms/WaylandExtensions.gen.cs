using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Wayland
{
    public static unsafe partial class WaylandExtensions
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateWaylandSurfaceKHR.html">vkCreateWaylandSurfaceKHR</see> - Create a &lt;c&gt;VkSurfaceKHR&lt;/c&gt; object for a Wayland window
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         :refpage: vkCreateWaylandSurfaceKHR
        ///     </para>
        ///     <para>
        ///         To create a <c>VkSurfaceKHR</c> object for a Wayland surface, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_wayland_surface
        ///         VkResult vkCreateWaylandSurfaceKHR(
        ///         VkInstance                                  instance,
        ///         const VkWaylandSurfaceCreateInfoKHR*        pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkSurfaceKHR*                               pSurface);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe void CreateWaylandSurfaceKHR(
            this VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable> handle,
            in VkWaylandSurfaceCreateInfoKHR pCreateInfo,
            VkAllocator? pAllocator,
            out VkSurfaceKHR pSurface
        )
        {
            fixed (VkWaylandSurfaceCreateInfoKHR* pCreateInfoFixed = &pCreateInfo)
            {
                VkSurfaceKHR pSurfaceLocal = default;
                VkResult result = handle.PInvoke.vkCreateWaylandSurfaceKHR.Invoke(
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
                            "Vulkan call to vkCreateWaylandSurfaceKHR failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateWaylandSurfaceKHR failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateWaylandSurfaceKHR failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateWaylandSurfaceKHR failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                pSurface = pSurfaceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceWaylandPresentationSupportKHR.html">vkGetPhysicalDeviceWaylandPresentationSupportKHR</see> - Query physical device for presentation to Wayland
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To determine whether a queue family of a physical device supports
        ///         presentation to a Wayland compositor, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_KHR_wayland_surface
        ///         VkBool32 vkGetPhysicalDeviceWaylandPresentationSupportKHR(
        ///         VkPhysicalDevice                            physicalDevice,
        ///         uint32_t                                    queueFamilyIndex,
        ///         struct wl_display*                          display);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [SupportedOSPlatform("linux")]
        public static unsafe Brutal.Bool32 GetWaylandPresentationSupportKHR(
            this VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable> handle,
            int queueFamilyIndex,
            void* display
        )
        {
            return handle.PInvoke.vkGetPhysicalDeviceWaylandPresentationSupportKHR.Invoke(
                handle.Handle,
                queueFamilyIndex,
                display
            );
        }
    }
}
