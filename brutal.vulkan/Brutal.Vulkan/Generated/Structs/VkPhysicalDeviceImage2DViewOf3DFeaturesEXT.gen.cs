namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceImage2DViewOf3DFeaturesEXT.html">VkPhysicalDeviceImage2DViewOf3DFeaturesEXT</see> - Structure describing whether single-slice 2D views of 3D images can be used in image descriptors
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceImage2DViewOf3DFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_image_2d_view_of_3d
    ///         typedef struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           image2DViewOf3D;
    ///             VkBool32           sampler2DViewOf3D;
    ///         } VkPhysicalDeviceImage2DViewOf3DFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceImage2DViewOf3DFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Image2DViewOf3D</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Image2DViewOf3D;

        /// <summary>
        ///     <c>Sampler2DViewOf3D</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 Sampler2DViewOf3D;
    }
}
