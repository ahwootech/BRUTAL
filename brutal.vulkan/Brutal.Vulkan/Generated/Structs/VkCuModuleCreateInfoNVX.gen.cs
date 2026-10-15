namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCuModuleCreateInfoNVX.html">VkCuModuleCreateInfoNVX</see> - Stub description of VkCuModuleCreateInfoNVX
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_binary_import
    ///         typedef struct VkCuModuleCreateInfoNVX {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             size_t             dataSize;
    ///             const void*        pData;
    ///         } VkCuModuleCreateInfoNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCuModuleCreateInfoNVX()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CuModuleCreateInfoNVX;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>DataSize</c>
        /// </summary>
        [FieldOffset(16)]
        public nuint DataSize;

        /// <summary>
        ///     <c>Data</c>
        /// </summary>
        [FieldOffset(24)]
        public void* Data;
    }
}
