namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct StdVideoAV1LoopFilter()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoAV1LoopFilterFlags Flags;

        /// <summary>
        ///     <c>LoopFilterLevel</c>
        /// </summary>
        [FieldOffset(4)]
        public byte4 LoopFilterLevel;

        /// <summary>
        ///     <c>LoopFilterSharpness</c>
        /// </summary>
        [FieldOffset(8)]
        public byte LoopFilterSharpness;

        /// <summary>
        ///     <c>UpdateRefDelta</c>
        /// </summary>
        [FieldOffset(9)]
        public byte UpdateRefDelta;

        ///
        [FieldOffset(10)]
        public fixed byte LoopFilterRefDeltas[8];

        /// <summary>
        ///     <c>UpdateModeDelta</c>
        /// </summary>
        [FieldOffset(18)]
        public byte UpdateModeDelta;

        /// <summary>
        ///     <c>LoopFilterModeDeltas</c>
        /// </summary>
        [FieldOffset(19)]
        public byte2 LoopFilterModeDeltas;
    }
}
