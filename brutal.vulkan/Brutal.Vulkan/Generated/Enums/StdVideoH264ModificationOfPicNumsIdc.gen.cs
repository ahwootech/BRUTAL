namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoH264ModificationOfPicNumsIdc : int
    {
        /// <summary>
        ///     <c>ShortTermSubtract</c>
        /// </summary>
        ShortTermSubtract = 0,

        /// <summary>
        ///     <c>ShortTermAdd</c>
        /// </summary>
        ShortTermAdd = 1,

        /// <summary>
        ///     <c>LongTerm</c>
        /// </summary>
        LongTerm = 2,

        /// <summary>
        ///     <c>End</c>
        /// </summary>
        End = 3,

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
