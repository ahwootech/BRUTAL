namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct StdVideoH264PictureParameterSet()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH264PpsFlags Flags;

        /// <summary>
        ///     <c>SeqParameterSetId</c>
        /// </summary>
        [FieldOffset(4)]
        public byte SeqParameterSetId;

        /// <summary>
        ///     <c>PicParameterSetId</c>
        /// </summary>
        [FieldOffset(5)]
        public byte PicParameterSetId;

        /// <summary>
        ///     <c>NumRefIdxL0DefaultActiveMinus1</c>
        /// </summary>
        [FieldOffset(6)]
        public byte NumRefIdxL0DefaultActiveMinus1;

        /// <summary>
        ///     <c>NumRefIdxL1DefaultActiveMinus1</c>
        /// </summary>
        [FieldOffset(7)]
        public byte NumRefIdxL1DefaultActiveMinus1;

        /// <summary>
        ///     <c>WeightedBipredIdc</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoH264WeightedBipredIdc WeightedBipredIdc;

        /// <summary>
        ///     <c>PicInitQpMinus26</c>
        /// </summary>
        [FieldOffset(12)]
        public byte PicInitQpMinus26;

        /// <summary>
        ///     <c>PicInitQsMinus26</c>
        /// </summary>
        [FieldOffset(13)]
        public byte PicInitQsMinus26;

        /// <summary>
        ///     <c>ChromaQpIndexOffset</c>
        /// </summary>
        [FieldOffset(14)]
        public byte ChromaQpIndexOffset;

        /// <summary>
        ///     <c>SecondChromaQpIndexOffset</c>
        /// </summary>
        [FieldOffset(15)]
        public byte SecondChromaQpIndexOffset;

        /// <summary>
        ///     <c>ScalingLists</c>
        /// </summary>
        [FieldOffset(16)]
        public StdVideoH264ScalingLists* ScalingLists;
    }
}
