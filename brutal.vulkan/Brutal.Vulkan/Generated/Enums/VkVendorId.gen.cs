namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkVendorId.html">VkVendorId</see> - Khronos vendor IDs
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Khronos vendor IDs which may: be returned in
    ///         <c>VkPhysicalDeviceProperties::vendorID</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkVendorId {
    ///             VK_VENDOR_ID_KHRONOS = 0x10000,
    ///             VK_VENDOR_ID_VIV = 0x10001,
    ///             VK_VENDOR_ID_VSI = 0x10002,
    ///             VK_VENDOR_ID_KAZAN = 0x10003,
    ///             VK_VENDOR_ID_CODEPLAY = 0x10004,
    ///             VK_VENDOR_ID_MESA = 0x10005,
    ///             VK_VENDOR_ID_POCL = 0x10006,
    ///             VK_VENDOR_ID_MOBILEYE = 0x10007,
    ///             VK_VENDOR_ID_APE = 0x10008,
    ///         } VkVendorId;
    ///     </code>
    /// </remarks>
    public enum VkVendorId : int
    {
        /// <summary>
        ///     <c>Khronos</c>
        /// </summary>
        Khronos = 0x10000,

        /// <summary>
        ///     <c>VIV</c>
        /// </summary>
        VIV = 0x10001,

        /// <summary>
        ///     <c>VSI</c>
        /// </summary>
        VSI = 0x10002,

        /// <summary>
        ///     <c>Kazan</c>
        /// </summary>
        Kazan = 0x10003,

        /// <summary>
        ///     <c>Codeplay</c>
        /// </summary>
        Codeplay = 0x10004,

        /// <summary>
        ///     <c>MESA</c>
        /// </summary>
        MESA = 0x10005,

        /// <summary>
        ///     <c>Pocl</c>
        /// </summary>
        Pocl = 0x10006,

        /// <summary>
        ///     <c>Mobileye</c>
        /// </summary>
        Mobileye = 0x10007,

        /// <summary>
        ///     <c>Ape</c>
        /// </summary>
        Ape = 0x10008,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
