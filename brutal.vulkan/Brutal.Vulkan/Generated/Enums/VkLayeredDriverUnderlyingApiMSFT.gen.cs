namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkLayeredDriverUnderlyingApiMSFT.html">VkLayeredDriverUnderlyingApiMSFT</see> - Layered driver underlying APIs
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Underlying APIs which may: be returned in
    ///         <c>VkPhysicalDeviceLayeredDriverPropertiesMSFT::underlyingAPI</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_MSFT_layered_driver
    ///         typedef enum VkLayeredDriverUnderlyingApiMSFT {
    ///             VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT = 0,
    ///             VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT = 1,
    ///         } VkLayeredDriverUnderlyingApiMSFT;
    ///     </code>
    /// </remarks>
    public enum VkLayeredDriverUnderlyingApiMSFT : int
    {
        /// <summary>
        ///     <c>NoneMSFT</c>
        /// </summary>
        NoneMSFT = 0,

        /// <summary>
        ///     <c>D3D12MSFT</c>
        /// </summary>
        D3D12MSFT = 1,

        /// <summary>
        ///     <c>MaxEnumMSFT</c>
        /// </summary>
        MaxEnumMSFT = 0x7FFFFFFF,
    }
}
