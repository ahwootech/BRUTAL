namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct StdVideoEncodeH264RefPicMarkingEntry()
    {
        /// <summary>
        ///     <c>MemoryManagementControlOperation</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH264MemMgmtControlOp MemoryManagementControlOperation;

        /// <summary>
        ///     <c>DifferenceOfPicNumsMinus1</c>
        /// </summary>
        [FieldOffset(4)]
        public ushort DifferenceOfPicNumsMinus1;

        /// <summary>
        ///     <c>LongTermPicNum</c>
        /// </summary>
        [FieldOffset(6)]
        public ushort LongTermPicNum;

        /// <summary>
        ///     <c>LongTermFrameIdx</c>
        /// </summary>
        [FieldOffset(8)]
        public ushort LongTermFrameIdx;

        /// <summary>
        ///     <c>MaxLongTermFrameIdxPlus1</c>
        /// </summary>
        [FieldOffset(10)]
        public ushort MaxLongTermFrameIdxPlus1;
    }
}
