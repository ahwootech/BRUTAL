namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkHostImageCopyDevicePerformanceQuery.html">VkHostImageCopyDevicePerformanceQuery</see> - Struct containing information about optimality of device access
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To query if using <c>VK_IMAGE_USAGE_HOST_TRANSFER_BIT</c> has a negative
    ///         impact on device performance when accessing an image, add
    ///         <c>VK_IMAGE_USAGE_HOST_TRANSFER_BIT</c> to
    ///         <c>VkPhysicalDeviceImageFormatInfo2::usage</c>, and add a
    ///         <c>VkHostImageCopyDevicePerformanceQuery</c> structure to the <c>pNext</c>
    ///         chain of a <c>VkImageFormatProperties2</c> structure passed to
    ///         <c>vkGetPhysicalDeviceImageFormatProperties2</c>.
    ///         This structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_4
    ///         typedef struct VkHostImageCopyDevicePerformanceQuery {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           optimalDeviceAccess;
    ///             VkBool32           identicalMemoryLayout;
    ///         } VkHostImageCopyDevicePerformanceQuery;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkHostImageCopyDevicePerformanceQuery()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.HostImageCopyDevicePerformanceQuery;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>OptimalDeviceAccess</c> returns <c>VK_TRUE</c> if use of host image copy has no adverse effect on device access performance, compared to an image that is created with exact same creation parameters, and bound to the same <c>VkDeviceMemory</c>, except that the <c>VK_IMAGE_USAGE_HOST_TRANSFER_BIT</c> usage flag is replaced with <c>VK_IMAGE_USAGE_TRANSFER_SRC_BIT</c> and <c>VK_IMAGE_USAGE_TRANSFER_DST_BIT</c>.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 OptimalDeviceAccess;

        /// <summary>
        ///     <c>IdenticalMemoryLayout</c> returns <c>VK_TRUE</c> if use of host image copy has no impact on memory layout compared to an image that is created with exact same creation parameters, and bound to the same <c>VkDeviceMemory</c>, except that the <c>VK_IMAGE_USAGE_HOST_TRANSFER_BIT</c> usage flag is replaced with <c>VK_IMAGE_USAGE_TRANSFER_SRC_BIT</c> and <c>VK_IMAGE_USAGE_TRANSFER_DST_BIT</c>.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 IdenticalMemoryLayout;
    }
}
