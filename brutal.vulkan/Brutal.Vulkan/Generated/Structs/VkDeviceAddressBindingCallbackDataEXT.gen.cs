namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceAddressBindingCallbackDataEXT.html">VkDeviceAddressBindingCallbackDataEXT</see> - Structure specifying parameters returned to the callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The definition of <c>VkDeviceAddressBindingCallbackDataEXT</c> is:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_device_address_binding_report
    ///         typedef struct VkDeviceAddressBindingCallbackDataEXT {
    ///             VkStructureType                   sType;
    ///             void*                             pNext;
    ///             VkDeviceAddressBindingFlagsEXT    flags;
    ///             VkDeviceAddress                   baseAddress;
    ///             VkDeviceSize                      size;
    ///             VkDeviceAddressBindingTypeEXT     bindingType;
    ///         } VkDeviceAddressBindingCallbackDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkDeviceAddressBindingCallbackDataEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceAddressBindingCallbackDataEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkDeviceAddressBindingFlagsEXT</c> specifying additional information about the binding event that caused the callback to be called.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceAddressBindingFlagsEXT Flags;

        /// <summary>
        ///     <c>BaseAddress</c> is a GPU-accessible virtual address identifying the start of a region of the virtual address space associated with a Vulkan object, as identified by the <c>pObjects</c> member of <c>VkDebugUtilsMessengerCallbackDataEXT</c>.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceAddress BaseAddress;

        /// <summary>
        ///     <c>Size</c> is the size in bytes of a region of GPU-accessible virtual address space.
        /// </summary>
        [FieldOffset(32)]
        public ByteSize64 Size;

        /// <summary>
        ///     <c>BindingType</c> is a <c>VkDeviceAddressBindingTypeEXT</c> specifying the type of binding event that caused the callback to be called.
        /// </summary>
        [FieldOffset(40)]
        public VkDeviceAddressBindingTypeEXT BindingType;
    }
}
