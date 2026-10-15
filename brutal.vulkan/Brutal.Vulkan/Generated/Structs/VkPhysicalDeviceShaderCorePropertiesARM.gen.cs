namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderCorePropertiesARM.html">VkPhysicalDeviceShaderCorePropertiesARM</see> - Structure describing shader core properties that can be supported by an implementation
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderCorePropertiesARM</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_ARM_shader_core_properties
    ///         typedef struct VkPhysicalDeviceShaderCorePropertiesARM {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint32_t           pixelRate;
    ///             uint32_t           texelRate;
    ///             uint32_t           fmaRate;
    ///         } VkPhysicalDeviceShaderCorePropertiesARM;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesARM()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderCorePropertiesARM;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>PixelRate</c> is an unsigned integer value indicating the maximum number of pixels output per clock per shader core.
        /// </summary>
        [FieldOffset(16)]
        public int PixelRate;

        /// <summary>
        ///     <c>TexelRate</c> is an unsigned integer value indicating the maximum number of texels per clock per shader core.
        /// </summary>
        [FieldOffset(20)]
        public int TexelRate;

        /// <summary>
        ///     <c>FmaRate</c> is an unsigned integer value indicating the maximum number of single-precision fused multiply-add operations per clock per shader core.
        /// </summary>
        [FieldOffset(24)]
        public int FmaRate;
    }
}
