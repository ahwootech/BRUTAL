namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoH265SliceType : int
    {
        /// <summary>
        ///     <c>B</c>
        /// </summary>
        B = 0,

        /// <summary>
        ///     <c>P</c>
        /// </summary>
        P = 1,

        /// <summary>
        ///     <c>I</c>
        /// </summary>
        I = 2,

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
