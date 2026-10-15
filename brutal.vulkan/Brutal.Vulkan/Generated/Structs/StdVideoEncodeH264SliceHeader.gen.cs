namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct StdVideoEncodeH264SliceHeader()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH264SliceHeaderFlags Flags;

        /// <summary>
        ///     <c>FirstMbInSlice</c>
        /// </summary>
        [FieldOffset(4)]
        public int FirstMbInSlice;

        /// <summary>
        ///     <c>SliceType</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoH264SliceType SliceType;

        /// <summary>
        ///     <c>SliceAlphaC0OffsetDiv2</c>
        /// </summary>
        [FieldOffset(12)]
        public byte SliceAlphaC0OffsetDiv2;

        /// <summary>
        ///     <c>SliceBetaOffsetDiv2</c>
        /// </summary>
        [FieldOffset(13)]
        public byte SliceBetaOffsetDiv2;

        /// <summary>
        ///     <c>SliceQpDelta</c>
        /// </summary>
        [FieldOffset(14)]
        public byte SliceQpDelta;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(15)]
        public byte Reserved1;

        /// <summary>
        ///     <c>CabacInitIdc</c>
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH264CabacInitIdc CabacInitIdc;

        /// <summary>
        ///     <c>DisableDeblockingFilterIdc</c>
        /// </summary>
        [FieldOffset(20)]
        public StdVideoH264DisableDeblockingFilterIdc DisableDeblockingFilterIdc;

        /// <summary>
        ///     <c>WeightTable</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeH264WeightTable* WeightTable;
    }
}
