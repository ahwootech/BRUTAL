namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct StdVideoH264SequenceParameterSetVui()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH264SpsVuiFlags Flags;

        /// <summary>
        ///     <c>AspectRatioIdc</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH264AspectRatioIdc AspectRatioIdc;

        /// <summary>
        ///     <c>SarWidth</c>
        /// </summary>
        [FieldOffset(8)]
        public ushort SarWidth;

        /// <summary>
        ///     <c>SarHeight</c>
        /// </summary>
        [FieldOffset(10)]
        public ushort SarHeight;

        /// <summary>
        ///     <c>VideoFormat</c>
        /// </summary>
        [FieldOffset(12)]
        public byte VideoFormat;

        /// <summary>
        ///     <c>ColourPrimaries</c>
        /// </summary>
        [FieldOffset(13)]
        public byte ColourPrimaries;

        /// <summary>
        ///     <c>TransferCharacteristics</c>
        /// </summary>
        [FieldOffset(14)]
        public byte TransferCharacteristics;

        /// <summary>
        ///     <c>MatrixCoefficients</c>
        /// </summary>
        [FieldOffset(15)]
        public byte MatrixCoefficients;

        /// <summary>
        ///     <c>NumUnitsInTick</c>
        /// </summary>
        [FieldOffset(16)]
        public int NumUnitsInTick;

        /// <summary>
        ///     <c>TimeScale</c>
        /// </summary>
        [FieldOffset(20)]
        public int TimeScale;

        /// <summary>
        ///     <c>MaxNumReorderFrames</c>
        /// </summary>
        [FieldOffset(24)]
        public byte MaxNumReorderFrames;

        /// <summary>
        ///     <c>MaxDecFrameBuffering</c>
        /// </summary>
        [FieldOffset(25)]
        public byte MaxDecFrameBuffering;

        /// <summary>
        ///     <c>ChromaSampleLocTypeTopField</c>
        /// </summary>
        [FieldOffset(26)]
        public byte ChromaSampleLocTypeTopField;

        /// <summary>
        ///     <c>ChromaSampleLocTypeBottomField</c>
        /// </summary>
        [FieldOffset(27)]
        public byte ChromaSampleLocTypeBottomField;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(28)]
        public int Reserved1;

        /// <summary>
        ///     <c>HrdParameters</c>
        /// </summary>
        [FieldOffset(32)]
        public StdVideoH264HrdParameters* HrdParameters;
    }
}
