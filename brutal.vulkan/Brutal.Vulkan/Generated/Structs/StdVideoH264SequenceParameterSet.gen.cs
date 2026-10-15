namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public unsafe partial struct StdVideoH264SequenceParameterSet()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH264SpsFlags Flags;

        /// <summary>
        ///     <c>ProfileIdc</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH264ProfileIdc ProfileIdc;

        /// <summary>
        ///     <c>LevelIdc</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoH264LevelIdc LevelIdc;

        /// <summary>
        ///     <c>ChromaFormatIdc</c>
        /// </summary>
        [FieldOffset(12)]
        public StdVideoH264ChromaFormatIdc ChromaFormatIdc;

        /// <summary>
        ///     <c>SeqParameterSetId</c>
        /// </summary>
        [FieldOffset(16)]
        public byte SeqParameterSetId;

        /// <summary>
        ///     <c>BitDepthLumaMinus8</c>
        /// </summary>
        [FieldOffset(17)]
        public byte BitDepthLumaMinus8;

        /// <summary>
        ///     <c>BitDepthChromaMinus8</c>
        /// </summary>
        [FieldOffset(18)]
        public byte BitDepthChromaMinus8;

        /// <summary>
        ///     <c>Log2MaxFrameNumMinus4</c>
        /// </summary>
        [FieldOffset(19)]
        public byte Log2MaxFrameNumMinus4;

        /// <summary>
        ///     <c>PicOrderCntType</c>
        /// </summary>
        [FieldOffset(20)]
        public StdVideoH264PocType PicOrderCntType;

        /// <summary>
        ///     <c>OffsetForNonRefPic</c>
        /// </summary>
        [FieldOffset(24)]
        public int OffsetForNonRefPic;

        /// <summary>
        ///     <c>OffsetForTopToBottomField</c>
        /// </summary>
        [FieldOffset(28)]
        public int OffsetForTopToBottomField;

        /// <summary>
        ///     <c>Log2MaxPicOrderCntLsbMinus4</c>
        /// </summary>
        [FieldOffset(32)]
        public byte Log2MaxPicOrderCntLsbMinus4;

        /// <summary>
        ///     <c>NumRefFramesInPicOrderCntCycle</c>
        /// </summary>
        [FieldOffset(33)]
        public byte NumRefFramesInPicOrderCntCycle;

        /// <summary>
        ///     <c>MaxNumRefFrames</c>
        /// </summary>
        [FieldOffset(34)]
        public byte MaxNumRefFrames;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(35)]
        public byte Reserved1;

        /// <summary>
        ///     <c>PicWidthInMbsMinus1</c>
        /// </summary>
        [FieldOffset(36)]
        public int PicWidthInMbsMinus1;

        /// <summary>
        ///     <c>PicHeightInMapUnitsMinus1</c>
        /// </summary>
        [FieldOffset(40)]
        public int PicHeightInMapUnitsMinus1;

        /// <summary>
        ///     <c>FrameCropLeftOffset</c>
        /// </summary>
        [FieldOffset(44)]
        public int FrameCropLeftOffset;

        /// <summary>
        ///     <c>FrameCropRightOffset</c>
        /// </summary>
        [FieldOffset(48)]
        public int FrameCropRightOffset;

        /// <summary>
        ///     <c>FrameCropTopOffset</c>
        /// </summary>
        [FieldOffset(52)]
        public int FrameCropTopOffset;

        /// <summary>
        ///     <c>FrameCropBottomOffset</c>
        /// </summary>
        [FieldOffset(56)]
        public int FrameCropBottomOffset;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(60)]
        public int Reserved2;

        /// <summary>
        ///     <c>OffsetForRefFrame</c>
        /// </summary>
        [FieldOffset(64)]
        public int* OffsetForRefFrame;

        /// <summary>
        ///     <c>ScalingLists</c>
        /// </summary>
        [FieldOffset(72)]
        public StdVideoH264ScalingLists* ScalingLists;

        /// <summary>
        ///     <c>SequenceParameterSetVui</c>
        /// </summary>
        [FieldOffset(80)]
        public StdVideoH264SequenceParameterSetVui* SequenceParameterSetVui;
    }
}
