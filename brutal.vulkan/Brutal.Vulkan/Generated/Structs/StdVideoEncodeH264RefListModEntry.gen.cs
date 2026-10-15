namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct StdVideoEncodeH264RefListModEntry()
    {
        /// <summary>
        ///     <c>ModificationOfPicNumsIdc</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH264ModificationOfPicNumsIdc ModificationOfPicNumsIdc;

        /// <summary>
        ///     <c>AbsDiffPicNumMinus1</c>
        /// </summary>
        [FieldOffset(4)]
        public ushort AbsDiffPicNumMinus1;

        /// <summary>
        ///     <c>LongTermPicNum</c>
        /// </summary>
        [FieldOffset(6)]
        public ushort LongTermPicNum;
    }
}
