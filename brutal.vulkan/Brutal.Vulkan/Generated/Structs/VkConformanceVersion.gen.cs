namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkConformanceVersion.html">VkConformanceVersion</see> - Structure containing the conformance test suite version the implementation is compliant with
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The conformance test suite version an implementation is compliant with is
    ///         described with the <c>VkConformanceVersion</c> structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef struct VkConformanceVersion {
    ///             uint8_t    major;
    ///             uint8_t    minor;
    ///             uint8_t    subminor;
    ///             uint8_t    patch;
    ///         } VkConformanceVersion;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct VkConformanceVersion()
    {
        /// <summary>
        ///     <c>Major</c> is the major version number of the conformance test suite.
        /// </summary>
        [FieldOffset(0)]
        public byte Major;

        /// <summary>
        ///     <c>Minor</c> is the minor version number of the conformance test suite.
        /// </summary>
        [FieldOffset(1)]
        public byte Minor;

        /// <summary>
        ///     <c>Subminor</c> is the subminor version number of the conformance test suite.
        /// </summary>
        [FieldOffset(2)]
        public byte Subminor;

        /// <summary>
        ///     <c>Patch</c> is the patch version number of the conformance test suite.
        /// </summary>
        [FieldOffset(3)]
        public byte Patch;
    }
}
