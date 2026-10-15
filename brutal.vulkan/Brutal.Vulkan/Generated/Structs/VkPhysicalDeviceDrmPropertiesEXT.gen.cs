namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDrmPropertiesEXT.html">VkPhysicalDeviceDrmPropertiesEXT</see> - Structure containing DRM information of a physical device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceDrmPropertiesEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_physical_device_drm
    ///         typedef struct VkPhysicalDeviceDrmPropertiesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           hasPrimary;
    ///             VkBool32           hasRender;
    ///             int64_t            primaryMajor;
    ///             int64_t            primaryMinor;
    ///             int64_t            renderMajor;
    ///             int64_t            renderMinor;
    ///         } VkPhysicalDeviceDrmPropertiesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public unsafe partial struct VkPhysicalDeviceDrmPropertiesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceDrmPropertiesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>HasPrimary</c> is a boolean indicating whether the physical device has a DRM primary node.
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 HasPrimary;

        /// <summary>
        ///     <c>HasRender</c> is a boolean indicating whether the physical device has a DRM render node.
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 HasRender;

        /// <summary>
        ///     <c>PrimaryMajor</c> is the DRM primary node major number, if any.
        /// </summary>
        [FieldOffset(24)]
        public long PrimaryMajor;

        /// <summary>
        ///     <c>PrimaryMinor</c> is the DRM primary node minor number, if any.
        /// </summary>
        [FieldOffset(32)]
        public long PrimaryMinor;

        /// <summary>
        ///     <c>RenderMajor</c> is the DRM render node major number, if any.
        /// </summary>
        [FieldOffset(40)]
        public long RenderMajor;

        /// <summary>
        ///     <c>RenderMinor</c> is the DRM render node minor number, if any.
        /// </summary>
        [FieldOffset(48)]
        public long RenderMinor;
    }
}
