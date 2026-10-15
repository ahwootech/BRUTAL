namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAmigoProfilingFeaturesSEC.html">VkPhysicalDeviceAmigoProfilingFeaturesSEC</see> - Stub description of VkPhysicalDeviceAmigoProfilingFeaturesSEC
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         [[features-amigoProfiling]]
    ///         There is currently no specification language written for this type.
    ///         This section acts only as placeholder and to avoid dead links in the
    ///         specification and reference pages.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_SEC_amigo_profiling
    ///         typedef struct VkPhysicalDeviceAmigoProfilingFeaturesSEC {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           amigoProfiling;
    ///         } VkPhysicalDeviceAmigoProfilingFeaturesSEC;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceAmigoProfilingFeaturesSEC()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceAmigoProfilingFeaturesSEC;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AmigoProfiling</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 AmigoProfiling;
    }
}
