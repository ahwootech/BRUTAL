namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct StdVideoAV1ColorConfig()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1ColorConfigFlags Flags;

        /// <summary>
        ///     <c>BitDepth</c>
        /// </summary>
        [FieldOffset(4)]
        public byte BitDepth;

        /// <summary>
        ///     <c>SubsamplingX</c>
        /// </summary>
        [FieldOffset(5)]
        public byte SubsamplingX;

        /// <summary>
        ///     <c>SubsamplingY</c>
        /// </summary>
        [FieldOffset(6)]
        public byte SubsamplingY;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(7)]
        public byte Reserved1;

        /// <summary>
        ///     <c>ColorPrimaries</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoAV1ColorPrimaries ColorPrimaries;

        /// <summary>
        ///     <c>TransferCharacteristics</c>
        /// </summary>
        [FieldOffset(12)]
        public StdVideoAV1TransferCharacteristics TransferCharacteristics;

        /// <summary>
        ///     <c>MatrixCoefficients</c>
        /// </summary>
        [FieldOffset(16)]
        public StdVideoAV1MatrixCoefficients MatrixCoefficients;

        /// <summary>
        ///     <c>ChromaSamplePosition</c>
        /// </summary>
        [FieldOffset(20)]
        public StdVideoAV1ChromaSamplePosition ChromaSamplePosition;
    }
}
