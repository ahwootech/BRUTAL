namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoAV1FrameType : int
    {
        /// <summary>
        ///     <c>Key</c>
        /// </summary>
        Key = 0,

        /// <summary>
        ///     <c>Inter</c>
        /// </summary>
        Inter = 1,

        /// <summary>
        ///     <c>IntraOnly</c>
        /// </summary>
        IntraOnly = 2,

        /// <summary>
        ///     <c>Switch</c>
        /// </summary>
        Switch = 3,

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
