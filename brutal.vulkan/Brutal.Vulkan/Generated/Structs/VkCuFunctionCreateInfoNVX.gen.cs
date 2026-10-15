namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCuFunctionCreateInfoNVX.html">VkCuFunctionCreateInfoNVX</see> - Stub description of VkCuFunctionCreateInfoNVX
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_binary_import
    ///         typedef struct VkCuFunctionCreateInfoNVX {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkCuModuleNVX      module;
    ///             const char*        pName;
    ///         } VkCuFunctionCreateInfoNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkCuFunctionCreateInfoNVX()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CuFunctionCreateInfoNVX;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Module</c>
        /// </summary>
        [FieldOffset(16)]
        public VkCuModuleNVX Module;

        /// <summary>
        ///     <c>Name</c>
        /// </summary>
        [FieldOffset(24)]
        public byte* Name;
    }
}
