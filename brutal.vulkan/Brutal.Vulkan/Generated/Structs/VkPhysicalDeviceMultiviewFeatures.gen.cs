namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewFeatures.html">VkPhysicalDeviceMultiviewFeatures</see> - Structure describing multiview features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceMultiviewFeatures</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef struct VkPhysicalDeviceMultiviewFeatures {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           multiview;
    ///             VkBool32           multiviewGeometryShader;
    ///             VkBool32           multiviewTessellationShader;
    ///         } VkPhysicalDeviceMultiviewFeatures;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceMultiviewFeatures()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceMultiviewFeatures;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Multiview</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Multiview;

        /// <summary>
        ///     <c>MultiviewGeometryShader</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 MultiviewGeometryShader;

        /// <summary>
        ///     <c>MultiviewTessellationShader</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 MultiviewTessellationShader;
    }
}
