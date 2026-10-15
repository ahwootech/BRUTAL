namespace Brutal.VulkanApi
{
    public static partial class Vulkan
    {
        public static unsafe partial class PInvoke
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
            /// <param name="pCreateInfo">is a pointer to a <c>VkInstanceCreateInfo</c> structure controlling creation of the instance.</param>
            /// <param name="pAllocator">controls host memory allocation as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#memory-allocation">Memory Allocation^</see> chapter.</param>
            /// <param name="pInstance">points a <c>VkInstance</c> handle in which the resulting instance is returned.</param>
            [LibraryImport("vulkan")]
            public static unsafe partial VkResult vkCreateInstance(
                VkInstanceCreateInfo* pCreateInfo,
                VkAllocationCallbacks* pAllocator,
                VkInstance* pInstance
            );

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
            /// <param name="pLayerName">is either `NULL` or a pointer to a null-terminated UTF-8 string naming the layer to retrieve extensions from.</param>
            /// <param name="pPropertyCount">is a pointer to an integer related to the number of extension properties available or queried, as described below.</param>
            /// <param name="pProperties">is either `NULL` or a pointer to an array of <c>VkExtensionProperties</c> structures.</param>
            [LibraryImport("vulkan")]
            public static unsafe partial VkResult vkEnumerateInstanceExtensionProperties(
                byte* pLayerName,
                int* pPropertyCount,
                VkExtensionProperties* pProperties
            );

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
            /// <param name="pPropertyCount">is a pointer to an integer related to the number of layer properties available or queried, as described below.</param>
            /// <param name="pProperties">is either `NULL` or a pointer to an array of <c>VkLayerProperties</c> structures.</param>
            [LibraryImport("vulkan")]
            public static unsafe partial VkResult vkEnumerateInstanceLayerProperties(
                int* pPropertyCount,
                VkLayerProperties* pProperties
            );

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
            /// <param name="pApiVersion">is a pointer to a <c>uint32_t</c>, which is the version of Vulkan supported by instance-level functionality, encoded as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#extendingvulkan-coreversions-versionnumbers">here</see>.</param>
            [LibraryImport("vulkan")]
            public static unsafe partial VkResult vkEnumerateInstanceVersion(int* pApiVersion);
        }
    }
}
