namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT.html">VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT</see> - Structure describing features to disable seamless cube maps
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_non_seamless_cube_map
    ///         typedef struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           nonSeamlessCubeMap;
    ///         } VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceNonSeamlessCubeMapFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>NonSeamlessCubeMap</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 NonSeamlessCubeMap;
    }
}
