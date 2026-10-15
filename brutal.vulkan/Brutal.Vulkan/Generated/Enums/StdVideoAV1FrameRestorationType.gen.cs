namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoAV1FrameRestorationType : int
    {
        /// <summary>
        ///     <c>None</c>
        /// </summary>
        None = 0,

        /// <summary>
        ///     <c>Wiener</c>
        /// </summary>
        Wiener = 1,

        /// <summary>
        ///     <c>Sgrproj</c>
        /// </summary>
        Sgrproj = 2,

        /// <summary>
        ///     <c>Switchable</c>
        /// </summary>
        Switchable = 3,

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
