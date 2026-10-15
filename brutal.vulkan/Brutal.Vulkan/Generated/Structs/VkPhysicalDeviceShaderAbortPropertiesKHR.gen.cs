namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceShaderAbortPropertiesKHR.html">VkPhysicalDeviceShaderAbortPropertiesKHR</see> - Structure describing the maximum size of a shader abort message
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkPhysicalDeviceShaderAbortPropertiesKHR</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_KHR_shader_abort
    ///         typedef struct VkPhysicalDeviceShaderAbortPropertiesKHR {
    ///             VkStructureType    sType;
    ///             void*              pNext;
    ///             uint64_t           maxShaderAbortMessageSize;
    ///         } VkPhysicalDeviceShaderAbortPropertiesKHR;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkPhysicalDeviceShaderAbortPropertiesKHR()
    {
        /// <summary>
        ///     <c>sType</c>
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.PhysicalDeviceShaderAbortPropertiesKHR;

        /// <summary>
        ///     <c>Next</c>
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>MaxShaderAbortMessageSize</c>
        /// </summary>
        [FieldOffset(16)]
        public nint MaxShaderAbortMessageSize;
    }
}
