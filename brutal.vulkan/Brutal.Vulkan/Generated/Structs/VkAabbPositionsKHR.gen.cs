namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkAabbPositionsKHR.html">VkAabbPositionsKHR</see> - Structure specifying two opposing corners of an axis-aligned bounding box
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkAabbPositionsKHR
    ///     </para>
    ///     <para>
    ///         The <c>VkAabbPositionsKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_acceleration_structure
    ///         typedef struct VkAabbPositionsKHR {
    ///             float    minX;
    ///             float    minY;
    ///             float    minZ;
    ///             float    maxX;
    ///             float    maxY;
    ///             float    maxZ;
    ///         } VkAabbPositionsKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkAabbPositionsKHR()
    {
        /// <summary>
        ///     <c>MinX</c> is the x position of one opposing corner of a bounding box.
        /// </summary>
        [FieldOffset(0)]
        public float MinX;

        /// <summary>
        ///     <c>MinY</c> is the y position of one opposing corner of a bounding box.
        /// </summary>
        [FieldOffset(4)]
        public float MinY;

        /// <summary>
        ///     <c>MinZ</c> is the z position of one opposing corner of a bounding box.
        /// </summary>
        [FieldOffset(8)]
        public float MinZ;

        /// <summary>
        ///     <c>MaxX</c> is the x position of the other opposing corner of a bounding box.
        /// </summary>
        [FieldOffset(12)]
        public float MaxX;

        /// <summary>
        ///     <c>MaxY</c> is the y position of the other opposing corner of a bounding box.
        /// </summary>
        [FieldOffset(16)]
        public float MaxY;

        /// <summary>
        ///     <c>MaxZ</c> is the z position of the other opposing corner of a bounding box.
        /// </summary>
        [FieldOffset(20)]
        public float MaxZ;
    }
}
