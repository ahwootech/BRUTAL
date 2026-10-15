namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe partial struct StdVideoEncodeH265ReferenceListsInfo()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH265ReferenceListsInfoFlags Flags;

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
        public fixed byte RefPicList0[15];

        ///
        [FieldOffset(21)]
        public fixed byte RefPicList1[15];

        ///
        [FieldOffset(36)]
        public fixed byte ListEntryL0[15];

        ///
        [FieldOffset(51)]
        public fixed byte ListEntryL1[15];
    }
}
