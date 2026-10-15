namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkViewport.html">VkViewport</see> - Structure specifying a viewport
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkViewport</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkViewport {
    ///             float    x;
    ///             float    y;
    ///             float    width;
    ///             float    height;
    ///             float    minDepth;
    ///             float    maxDepth;
    ///         } VkViewport;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct VkViewport()
    {
        /// <summary>
        ///     <c>X</c> and <c>y</c> are the viewport&apos;s upper left corner <c>(x,y)</c>.
        /// </summary>
        [FieldOffset(0)]
        public float X;

        /// <summary>
        ///     <c>Y</c>
        /// </summary>
        [FieldOffset(4)]
        public float Y;

        /// <summary>
        ///     <c>Width</c> and <c>height</c> are the viewport&apos;s width and height, respectively.
        /// </summary>
        [FieldOffset(8)]
        public float Width;

        /// <summary>
        ///     <c>Height</c>
        /// </summary>
        [FieldOffset(12)]
        public float Height;

        /// <summary>
        ///     <c>MinDepth</c> and <c>maxDepth</c> are the depth range for the viewport.
        /// </summary>
        [FieldOffset(16)]
        public float MinDepth;

        /// <summary>
        ///     <c>MaxDepth</c>
        /// </summary>
        [FieldOffset(20)]
        public float MaxDepth;
    }
}
