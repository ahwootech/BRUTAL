namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkMicromapCreateInfoEXT.html">VkMicromapCreateInfoEXT</see> - Structure specifying the parameters of a newly created micromap object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkMicromapCreateInfoEXT
    ///     </para>
    ///     <para>
    ///         The <c>VkMicromapCreateInfoEXT</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_opacity_micromap
    ///         typedef struct VkMicromapCreateInfoEXT {
    ///             VkStructureType             sType;
    ///             const void*                 pNext;
    ///             VkMicromapCreateFlagsEXT    createFlags;
    ///             VkBuffer                    buffer;
    ///             VkDeviceSize                offset;
    ///             VkDeviceSize                size;
    ///             VkMicromapTypeEXT           type;
    ///             VkDeviceAddress             deviceAddress;
    ///         } VkMicromapCreateInfoEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public unsafe partial struct VkMicromapCreateInfoEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.MicromapCreateInfoEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CreateFlags</c> is a bitmask of <c>VkMicromapCreateFlagsEXT</c> specifying additional creation parameters of the micromap.
        /// </summary>
        [FieldOffset(16)]
        public VkMicromapCreateFlagsEXT CreateFlags;

        /// <summary>
        ///     <c>Buffer</c> is the buffer on which the micromap will be stored.
        /// </summary>
        [FieldOffset(24)]
        public VkBuffer Buffer;

        /// <summary>
        ///     <c>Offset</c> is an offset in bytes from the base address of the buffer at which the micromap will be stored, and <i>must</i> be a multiple of `256`.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Offset;

        /// <summary>
        ///     <c>Size</c> is the size required for the micromap.
        /// </summary>
        [FieldOffset(40)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>Type</c> is a <c>VkMicromapTypeEXT</c> value specifying the type of micromap that will be created.
        /// </summary>
        [FieldOffset(48)]
        public VkMicromapTypeEXT Type;

        /// <summary>
        ///     <c>DeviceAddress</c> is the device address requested for the micromap if the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#features-micromapCaptureReplayEXT"><c>VkPhysicalDeviceOpacityMicromapFeaturesEXT::micromapCaptureReplay</c>^</see> feature is being used.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceAddress DeviceAddress;
    }
}
