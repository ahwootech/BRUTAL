namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkCuModuleTexturingModeCreateInfoNVX.html">VkCuModuleTexturingModeCreateInfoNVX</see> - Stub description of VkCuModuleTexturingModeCreateInfoNVX
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NVX_binary_import
    ///         typedef struct VkCuModuleTexturingModeCreateInfoNVX {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             VkBool32           use64bitTexturing;
    ///         } VkCuModuleTexturingModeCreateInfoNVX;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkCuModuleTexturingModeCreateInfoNVX()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.CuModuleTexturingModeCreateInfoNVX;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Use64bitTexturing</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Use64bitTexturing;
    }
}
