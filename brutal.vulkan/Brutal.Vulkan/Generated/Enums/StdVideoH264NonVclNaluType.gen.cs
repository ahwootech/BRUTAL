namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoH264NonVclNaluType : int
    {
        /// <summary>
        ///     <c>Sps</c>
        /// </summary>
        Sps = 0,

        /// <summary>
        ///     <c>Pps</c>
        /// </summary>
        Pps = 1,

        /// <summary>
        ///     <c>Aud</c>
        /// </summary>
        Aud = 2,

        /// <summary>
        ///     <c>Prefix</c>
        /// </summary>
        Prefix = 3,

        /// <summary>
        ///     <c>EndOfSequence</c>
        /// </summary>
        EndOfSequence = 4,

        /// <summary>
        ///     <c>EndOfStream</c>
        /// </summary>
        EndOfStream = 5,

        /// <summary>
        ///     <c>Precoded</c>
        /// </summary>
        Precoded = 6,

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
