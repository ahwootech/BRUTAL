namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct StdVideoH265VideoParameterSet()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265VpsFlags Flags;

        /// <summary>
        ///     <c>VpsVideoParameterSetId</c>
        /// </summary>
        [FieldOffset(4)]
        public byte VpsVideoParameterSetId;

        /// <summary>
        ///     <c>VpsMaxSubLayersMinus1</c>
        /// </summary>
        [FieldOffset(5)]
        public byte VpsMaxSubLayersMinus1;

        /// <summary>
        ///     <c>Reserved1</c>
        /// </summary>
        [FieldOffset(6)]
        public byte Reserved1;

        /// <summary>
        ///     <c>Reserved2</c>
        /// </summary>
        [FieldOffset(7)]
        public byte Reserved2;

        /// <summary>
        ///     <c>VpsNumUnitsInTick</c>
        /// </summary>
        [FieldOffset(8)]
        public int VpsNumUnitsInTick;

        /// <summary>
        ///     <c>VpsTimeScale</c>
        /// </summary>
        [FieldOffset(12)]
        public int VpsTimeScale;

        /// <summary>
        ///     <c>VpsNumTicksPocDiffOneMinus1</c>
        /// </summary>
        [FieldOffset(16)]
        public int VpsNumTicksPocDiffOneMinus1;

        /// <summary>
        ///     <c>Reserved3</c>
        /// </summary>
        [FieldOffset(20)]
        public int Reserved3;

        /// <summary>
        ///     <c>DecPicBufMgr</c>
        /// </summary>
        [FieldOffset(24)]
        public StdVideoH265DecPicBufMgr* DecPicBufMgr;

        /// <summary>
        ///     <c>HrdParameters</c>
        /// </summary>
        [FieldOffset(32)]
        public StdVideoH265HrdParameters* HrdParameters;

        /// <summary>
        ///     <c>ProfileTierLevel</c>
        /// </summary>
        [FieldOffset(40)]
        public StdVideoH265ProfileTierLevel* ProfileTierLevel;
    }
}
