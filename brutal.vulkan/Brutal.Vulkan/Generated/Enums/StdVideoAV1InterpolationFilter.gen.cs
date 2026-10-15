namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoAV1InterpolationFilter : int
    {
        /// <summary>
        ///     <c>Eighttap</c>
        /// </summary>
        Eighttap = 0,

        /// <summary>
        ///     <c>EighttapSmooth</c>
        /// </summary>
        EighttapSmooth = 1,

        /// <summary>
        ///     <c>EighttapSharp</c>
        /// </summary>
        EighttapSharp = 2,

        /// <summary>
        ///     <c>Bilinear</c>
        /// </summary>
        Bilinear = 3,

        /// <summary>
        ///     <c>Switchable</c>
        /// </summary>
        Switchable = 4,

        /// <summary>
        ///     <c>Invalid</c>
        /// </summary>
        Invalid = 0x7FFFFFFF,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
