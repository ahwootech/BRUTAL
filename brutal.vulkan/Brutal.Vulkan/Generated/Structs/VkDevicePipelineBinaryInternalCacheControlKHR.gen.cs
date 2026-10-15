namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDevicePipelineBinaryInternalCacheControlKHR.html">VkDevicePipelineBinaryInternalCacheControlKHR</see> - Structure specifying parameter to disable the internal pipeline cache
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         To disable the implementation&apos;s internal pipeline cache, add a
    ///         <c>VkDevicePipelineBinaryInternalCacheControlKHR</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkDeviceCreateInfo</c> structure.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_pipeline_binary
    ///         typedef struct VkDevicePipelineBinaryInternalCacheControlKHR {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           disableInternalCache;
    ///         } VkDevicePipelineBinaryInternalCacheControlKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDevicePipelineBinaryInternalCacheControlKHR()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DevicePipelineBinaryInternalCacheControlKHR;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DisableInternalCache</c> specifies whether or not to disable the implementation&apos;s internal pipeline cache.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 DisableInternalCache;
    }
}
