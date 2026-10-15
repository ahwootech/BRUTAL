namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 164)]
    public unsafe partial struct StdVideoAV1FilmGrain()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1FilmGrainFlags Flags;

        /// <summary>
        ///     <c>GrainScalingMinus_8</c>
        /// </summary>
        [FieldOffset(4)]
        public byte GrainScalingMinus_8;

        /// <summary>
        ///     <c>ArCoeffLag</c>
        /// </summary>
        [FieldOffset(5)]
        public byte ArCoeffLag;

        /// <summary>
        ///     <c>ArCoeffShiftMinus_6</c>
        /// </summary>
        [FieldOffset(6)]
        public byte ArCoeffShiftMinus_6;

        /// <summary>
        ///     <c>GrainScaleShift</c>
        /// </summary>
        [FieldOffset(7)]
        public byte GrainScaleShift;

        /// <summary>
        ///     <c>GrainSeed</c>
        /// </summary>
        [FieldOffset(8)]
        public ushort GrainSeed;

        /// <summary>
        ///     <c>FilmGrainParamsRefIdx</c>
        /// </summary>
        [FieldOffset(10)]
        public byte FilmGrainParamsRefIdx;

        /// <summary>
        ///     <c>NumYPoints</c>
        /// </summary>
        [FieldOffset(11)]
        public byte NumYPoints;

        ///
        [FieldOffset(12)]
        public fixed byte PointYValue[14];

        ///
        [FieldOffset(26)]
        public fixed byte PointYScaling[14];

        /// <summary>
        ///     <c>NumCbPoints</c>
        /// </summary>
        [FieldOffset(40)]
        public byte NumCbPoints;

        ///
        [FieldOffset(41)]
        public fixed byte PointCbValue[10];

        ///
        [FieldOffset(51)]
        public fixed byte PointCbScaling[10];

        /// <summary>
        ///     <c>NumCrPoints</c>
        /// </summary>
        [FieldOffset(61)]
        public byte NumCrPoints;

        ///
        [FieldOffset(62)]
        public fixed byte PointCrValue[10];

        ///
        [FieldOffset(72)]
        public fixed byte PointCrScaling[10];

        ///
        [FieldOffset(82)]
        public fixed byte ArCoeffsYPlus_128[24];

        ///
        [FieldOffset(106)]
        public fixed byte ArCoeffsCbPlus_128[25];

        ///
        [FieldOffset(131)]
        public fixed byte ArCoeffsCrPlus_128[25];

        /// <summary>
        ///     <c>CbMult</c>
        /// </summary>
        [FieldOffset(156)]
        public byte CbMult;

        /// <summary>
        ///     <c>CbLumaMult</c>
        /// </summary>
        [FieldOffset(157)]
        public byte CbLumaMult;

        /// <summary>
        ///     <c>CbOffset</c>
        /// </summary>
        [FieldOffset(158)]
        public ushort CbOffset;

        /// <summary>
        ///     <c>CrMult</c>
        /// </summary>
        [FieldOffset(160)]
        public byte CrMult;

        /// <summary>
        ///     <c>CrLumaMult</c>
        /// </summary>
        [FieldOffset(161)]
        public byte CrLumaMult;

        /// <summary>
        ///     <c>CrOffset</c>
        /// </summary>
        [FieldOffset(162)]
        public ushort CrOffset;
    }
}
