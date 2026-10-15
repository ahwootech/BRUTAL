namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct StdVideoEncodeH265SliceSegmentHeader()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoEncodeH265SliceSegmentHeaderFlags Flags;

        /// <summary>
        ///     <c>SliceType</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH265SliceType SliceType;

        /// <summary>
        ///     <c>SliceSegmentAddress</c>
        /// </summary>
        [FieldOffset(8)]
        public int SliceSegmentAddress;

        /// <summary>
        ///     <c>CollocatedRefIdx</c>
        /// </summary>
        [FieldOffset(12)]
        public byte CollocatedRefIdx;

        /// <summary>
        ///     <c>MaxNumMergeCand</c>
        /// </summary>
        [FieldOffset(13)]
        public byte MaxNumMergeCand;

        /// <summary>
        ///     <c>SliceCbQpOffset</c>
        /// </summary>
        [FieldOffset(14)]
        public byte SliceCbQpOffset;

        /// <summary>
        ///     <c>SliceCrQpOffset</c>
        /// </summary>
        [FieldOffset(15)]
        public byte SliceCrQpOffset;

        /// <summary>
        ///     <c>SliceBetaOffsetDiv2</c>
        /// </summary>
        [FieldOffset(16)]
        public byte SliceBetaOffsetDiv2;

        /// <summary>
        ///     <c>SliceTcOffsetDiv2</c>
        /// </summary>
        [FieldOffset(17)]
        public byte SliceTcOffsetDiv2;

        /// <summary>
        ///     <c>SliceActYQpOffset</c>
        /// </summary>
        [FieldOffset(18)]
        public byte SliceActYQpOffset;

        /// <summary>
        ///     <c>SliceActCbQpOffset</c>
        /// </summary>
        [FieldOffset(19)]
        public byte SliceActCbQpOffset;

        /// <summary>
        ///     <c>SliceActCrQpOffset</c>
        /// </summary>
        [FieldOffset(20)]
        public byte SliceActCrQpOffset;

        /// <summary>
        ///     <c>SliceQpDelta</c>
        /// </summary>
        [FieldOffset(21)]
        public byte SliceQpDelta;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(22)]
        public ushort Reserved1;

        /// <summary>
        ///     <c>WeightTable</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoEncodeH265WeightTable* WeightTable;
    }
}
