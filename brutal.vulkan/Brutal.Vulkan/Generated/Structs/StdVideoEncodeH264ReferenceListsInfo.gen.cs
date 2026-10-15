namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public unsafe partial struct StdVideoEncodeH264ReferenceListsInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH264ReferenceListsInfoFlags Flags;

        /// <summary>
        ///     <c>NumRefIdxL0ActiveMinus1</c>
        /// </summary>
        [FieldOffset(4)]
        public byte NumRefIdxL0ActiveMinus1;

        /// <summary>
        ///     <c>NumRefIdxL1ActiveMinus1</c>
        /// </summary>
        [FieldOffset(5)]
        public byte NumRefIdxL1ActiveMinus1;

        ///
        [FieldOffset(6)]
        public fixed byte RefPicList0[32];

        ///
        [FieldOffset(38)]
        public fixed byte RefPicList1[32];

        /// <summary>
        ///     <c>RefList0ModOpCount</c>
        /// </summary>
        [FieldOffset(70)]
        public byte RefList0ModOpCount;

        /// <summary>
        ///     <c>RefList1ModOpCount</c>
        /// </summary>
        [FieldOffset(71)]
        public byte RefList1ModOpCount;

        /// <summary>
        ///     <c>RefPicMarkingOpCount</c>
        /// </summary>
        [FieldOffset(72)]
        public byte RefPicMarkingOpCount;

        ///
        [FieldOffset(73)]
        public fixed byte Reserved1[7];

        /// <summary>
        ///     <c>RefList0ModOperations</c>
        /// </summary>
        [FieldOffset(80)]
        public StdVideoEncodeH264RefListModEntry* RefList0ModOperations;

        /// <summary>
        ///     <c>RefList1ModOperations</c>
        /// </summary>
        [FieldOffset(88)]
        public StdVideoEncodeH264RefListModEntry* RefList1ModOperations;

        /// <summary>
        ///     <c>RefPicMarkingOperations</c>
        /// </summary>
        [FieldOffset(96)]
        public StdVideoEncodeH264RefPicMarkingEntry* RefPicMarkingOperations;
    }
}
