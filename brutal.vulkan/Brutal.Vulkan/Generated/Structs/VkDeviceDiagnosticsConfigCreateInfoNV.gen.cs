namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceDiagnosticsConfigCreateInfoNV.html">VkDeviceDiagnosticsConfigCreateInfoNV</see> - Specify diagnostics config for a Vulkan device
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When using the Nsight^(TM)^ Aftermath SDK, to configure how device crash
    ///         dumps are created, add a <c>VkDeviceDiagnosticsConfigCreateInfoNV</c>
    ///         structure to the <c>pNext</c> chain of the <c>VkDeviceCreateInfo</c>
    ///         structure.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_device_diagnostics_config
    ///         typedef struct VkDeviceDiagnosticsConfigCreateInfoNV {
    ///             VkStructureType                     sType;
    ///             const void*                         pNext;
    ///             VkDeviceDiagnosticsConfigFlagsNV    flags;
    ///         } VkDeviceDiagnosticsConfigCreateInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceDiagnosticsConfigCreateInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceDiagnosticsConfigCreateInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkDeviceDiagnosticsConfigFlagsNV</c> specifying additional parameters for configuring diagnostic tools.
        /// </summary>
        [FieldOffset(16)]
        public VkDeviceDiagnosticsConfigFlagsNV Flags;
    }
}
