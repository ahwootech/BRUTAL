namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceOpacityMicromapFeaturesEXT.html">VkPhysicalDeviceOpacityMicromapFeaturesEXT</see> - Structure describing the ray tracing opacity micromap features that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceOpacityMicromapFeaturesEXT</c> structure is defined
    ///         as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkPhysicalDeviceOpacityMicromapFeaturesEXT {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             VkBool32           micromap;
    ///             VkBool32           micromapCaptureReplay;
    ///             // micromapHostCommands is legacy, but no reason was given in the API XML
    ///             VkBool32           micromapHostCommands;
    ///         } VkPhysicalDeviceOpacityMicromapFeaturesEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceOpacityMicromapFeaturesEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceOpacityMicromapFeaturesEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Micromap</c>
        /// </summary>
        [FieldOffset(16)]
        public Brutal.Bool32 Micromap;

        /// <summary>
        ///     <c>MicromapCaptureReplay</c>
        /// </summary>
        [FieldOffset(20)]
        public Brutal.Bool32 MicromapCaptureReplay;

        /// <summary>
        ///     <c>MicromapHostCommands</c>
        /// </summary>
        [FieldOffset(24)]
        public Brutal.Bool32 MicromapHostCommands;
    }
}
