using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Android
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAndroidSurfaceCreateInfoKHR.html">VkAndroidSurfaceCreateInfoKHR</see> - Structure specifying parameters of a newly created Android surface object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkAndroidSurfaceCreateInfoKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_android_surface
    ///         typedef struct VkAndroidSurfaceCreateInfoKHR {
    ///             VkStructureType                   sType;
    ///             const void*                       pNext;
    ///             VkAndroidSurfaceCreateFlagsKHR    flags;
    ///             struct ANativeWindow*             window;
    ///         } VkAndroidSurfaceCreateInfoKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    [SupportedOSPlatform("android")]
    public unsafe partial struct VkAndroidSurfaceCreateInfoKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ANDROIDSurfaceCreateInfoKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkAndroidSurfaceCreateFlagsKHR Flags;

        /// <summary>
        ///     <c>Window</c> is a pointer to the basetype:ANativeWindow to associate the surface with.
        /// </summary>
        [FieldOffset(24)]
        public void* Window;
    }
}
