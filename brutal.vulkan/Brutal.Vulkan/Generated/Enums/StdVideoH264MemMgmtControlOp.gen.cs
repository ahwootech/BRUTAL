namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoH264MemMgmtControlOp : int
    {
        /// <summary>
        ///     <c>End</c>
        /// </summary>
        End = 0,

        /// <summary>
        ///     <c>UnmarkShortTerm</c>
        /// </summary>
        UnmarkShortTerm = 1,

        /// <summary>
        ///     <c>UnmarkLongTerm</c>
        /// </summary>
        UnmarkLongTerm = 2,

        /// <summary>
        ///     <c>MarkLongTerm</c>
        /// </summary>
        MarkLongTerm = 3,

        /// <summary>
        ///     <c>SetMaxLongTermIndex</c>
        /// </summary>
        SetMaxLongTermIndex = 4,

        /// <summary>
        ///     <c>UnmarkAll</c>
        /// </summary>
        UnmarkAll = 5,

        /// <summary>
        ///     <c>MarkCurrentAsLongTerm</c>
        /// </summary>
        MarkCurrentAsLongTerm = 6,

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
