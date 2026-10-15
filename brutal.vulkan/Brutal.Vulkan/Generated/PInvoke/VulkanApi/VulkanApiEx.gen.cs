namespace Brutal.VulkanApi
{
    public static partial class Vulkan
    {
        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateInstance.html">vkCreateInstance</see> - Create a new Vulkan instance
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To create an instance object, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkCreateInstance(
        ///         const VkInstanceCreateInfo*                 pCreateInfo,
        ///         const VkAllocationCallbacks*                pAllocator,
        ///         VkInstance*                                 pInstance);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static unsafe VkInstance CreateInstanceInternal(
            in VkInstanceCreateInfo pCreateInfo,
            VkAllocator? pAllocator
        )
        {
            fixed (VkInstanceCreateInfo* pCreateInfoFixed = &pCreateInfo)
            {
                VkInstance pInstanceLocal = default;
                VkResult result = Vulkan.PInvoke.vkCreateInstance(pCreateInfoFixed, pAllocator, &pInstanceLocal);
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorInitializationFailed:
                        throw new VkResultError(
                            VkResult.ErrorInitializationFailed,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_INITIALIZATION_FAILED"
                        );
                    case VkResult.ErrorLayerNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorLayerNotPresent,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_LAYER_NOT_PRESENT"
                        );
                    case VkResult.ErrorExtensionNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorExtensionNotPresent,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_EXTENSION_NOT_PRESENT"
                        );
                    case VkResult.ErrorIncompatibleDriver:
                        throw new VkResultError(
                            VkResult.ErrorIncompatibleDriver,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_INCOMPATIBLE_DRIVER"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkCreateInstance failed with error: VK_ERROR_VALIDATION_FAILED"
                        );
                    case VkResult.Success:
                    default:
                        break;
                }

                return pInstanceLocal;
            }
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceExtensionProperties.html">vkEnumerateInstanceExtensionProperties</see> - Returns up to requested number of global extension properties
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the available instance extensions, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkEnumerateInstanceExtensionProperties(
        ///         const char*                                 pLayerName,
        ///         uint32_t*                                   pPropertyCount,
        ///         VkExtensionProperties*                      pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumerateInstanceExtensionProperties(
            scoped ReadOnlySpan<byte> pLayerName,
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkExtensionProperties> pProperties
        )
        {
            fixed (VkExtensionProperties* pPropertiesFixed = pProperties)
            fixed (byte* pLayerNameFixed = pLayerName)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = Vulkan.PInvoke.vkEnumerateInstanceExtensionProperties(
                    pLayerNameFixed,
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumerateInstanceExtensionProperties failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumerateInstanceExtensionProperties failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorLayerNotPresent:
                        throw new VkResultError(
                            VkResult.ErrorLayerNotPresent,
                            "Vulkan call to vkEnumerateInstanceExtensionProperties failed with error: VK_ERROR_LAYER_NOT_PRESENT"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumerateInstanceExtensionProperties failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumerateInstanceExtensionProperties failed with error: VK_ERROR_VALIDATION_FAILED"
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
        public static int EnumerateInstanceExtensionProperties_Count(scoped ReadOnlySpan<byte> pLayerName)
        {
            int pPropertyCount = default;
            EnumerateInstanceExtensionProperties(pLayerName, ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumerateInstanceExtensionProperties_Write(
            scoped ReadOnlySpan<byte> pLayerName,
            scoped ReadOnlySpan<VkExtensionProperties> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return EnumerateInstanceExtensionProperties(pLayerName, ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceLayerProperties.html">vkEnumerateInstanceLayerProperties</see> - Returns up to requested number of global layer properties
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the available layers, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_0
        ///         VkResult vkEnumerateInstanceLayerProperties(
        ///         uint32_t*                                   pPropertyCount,
        ///         VkLayerProperties*                          pProperties);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe VkResult EnumerateInstanceLayerProperties(
            ref int pPropertyCount,
            scoped ReadOnlySpan<VkLayerProperties> pProperties
        )
        {
            fixed (VkLayerProperties* pPropertiesFixed = pProperties)
            fixed (int* pPropertyCountFixed = &pPropertyCount)
            {
                VkResult result = Vulkan.PInvoke.vkEnumerateInstanceLayerProperties(
                    pPropertyCountFixed,
                    pPropertiesFixed
                );
                switch (result)
                {
                    case VkResult.ErrorOutOfHostMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfHostMemory,
                            "Vulkan call to vkEnumerateInstanceLayerProperties failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                        );
                    case VkResult.ErrorOutOfDeviceMemory:
                        throw new VkResultError(
                            VkResult.ErrorOutOfDeviceMemory,
                            "Vulkan call to vkEnumerateInstanceLayerProperties failed with error: VK_ERROR_OUT_OF_DEVICE_MEMORY"
                        );
                    case VkResult.ErrorUnknown:
                        throw new VkResultError(
                            VkResult.ErrorUnknown,
                            "Vulkan call to vkEnumerateInstanceLayerProperties failed with error: VK_ERROR_UNKNOWN"
                        );
                    case VkResult.ErrorValidationFailed:
                        throw new VkResultError(
                            VkResult.ErrorValidationFailed,
                            "Vulkan call to vkEnumerateInstanceLayerProperties failed with error: VK_ERROR_VALIDATION_FAILED"
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
        public static int EnumerateInstanceLayerProperties_Count()
        {
            int pPropertyCount = default;
            EnumerateInstanceLayerProperties(ref pPropertyCount, null);
            return pPropertyCount;
        }

        /// <summary>Writes to a provided span.</summary>
        /// <param name="pProperties">The span to write to.</param>
        /// <returns>Return value of the underlying function.</returns>
        public static VkResult EnumerateInstanceLayerProperties_Write(
            scoped ReadOnlySpan<VkLayerProperties> pProperties
        )
        {
            int pPropertyCount = pProperties.Length;
            return EnumerateInstanceLayerProperties(ref pPropertyCount, pProperties);
        }

        /// <summary>
        ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkEnumerateInstanceVersion.html">vkEnumerateInstanceVersion</see> - Query instance-level version before instance creation
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         To query the version of instance-level functionality supported by the
        ///         implementation, call:
        ///     </para>
        ///     <code>
        ///         // Provided by VK_VERSION_1_1
        ///         VkResult vkEnumerateInstanceVersion(
        ///         uint32_t*                                   pApiVersion);
        ///     </code>
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void EnumerateInstanceVersion(int* pApiVersion)
        {
            VkResult result = Vulkan.PInvoke.vkEnumerateInstanceVersion(pApiVersion);
            switch (result)
            {
                case VkResult.ErrorOutOfHostMemory:
                    throw new VkResultError(
                        VkResult.ErrorOutOfHostMemory,
                        "Vulkan call to vkEnumerateInstanceVersion failed with error: VK_ERROR_OUT_OF_HOST_MEMORY"
                    );
                case VkResult.ErrorUnknown:
                    throw new VkResultError(
                        VkResult.ErrorUnknown,
                        "Vulkan call to vkEnumerateInstanceVersion failed with error: VK_ERROR_UNKNOWN"
                    );
                case VkResult.ErrorValidationFailed:
                    throw new VkResultError(
                        VkResult.ErrorValidationFailed,
                        "Vulkan call to vkEnumerateInstanceVersion failed with error: VK_ERROR_VALIDATION_FAILED"
                    );
                case VkResult.Success:
                default:
                    break;
            }
        }
    }
}
