namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkChromaLocation.html">VkChromaLocation</see> - Position of downsampled chroma samples
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkChromaLocation</c> enum defines the location of downsampled chroma
    ///         component samples relative to the luma samples, and is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_1
    ///         typedef enum VkChromaLocation {
    ///             VK_CHROMA_LOCATION_COSITED_EVEN = 0,
    ///             VK_CHROMA_LOCATION_MIDPOINT = 1,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_CHROMA_LOCATION_COSITED_EVEN_KHR = VK_CHROMA_LOCATION_COSITED_EVEN,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_CHROMA_LOCATION_MIDPOINT_KHR = VK_CHROMA_LOCATION_MIDPOINT,
    ///         } VkChromaLocation;
    ///     </code>
    /// </remarks>
    public enum VkChromaLocation : int
    {
        /// <summary>
        ///     <c>CositedEven</c> specifies that downsampled chroma samples are aligned with luma samples with even coordinates.
        /// </summary>
        CositedEven = 0,

        /// <summary>
        ///     <c>Midpoint</c> specifies that downsampled chroma samples are located half way between each even luma sample and the nearest higher odd luma sample.
        /// </summary>
        Midpoint = 1,

        /// <summary>
        ///     <c>CositedEvenKHR</c>
        /// </summary>
        CositedEvenKHR = CositedEven,

        /// <summary>
        ///     <c>MidpointKHR</c>
        /// </summary>
        MidpointKHR = Midpoint,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
