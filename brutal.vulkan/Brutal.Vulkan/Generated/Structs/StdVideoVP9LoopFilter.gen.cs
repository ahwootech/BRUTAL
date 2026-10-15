namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct StdVideoVP9LoopFilter()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoVP9LoopFilterFlags Flags;

        /// <summary>
        ///     <c>LoopFilterLevel</c>
        /// </summary>
        [FieldOffset(4)]
        public byte LoopFilterLevel;

        /// <summary>
        ///     <c>LoopFilterSharpness</c>
        /// </summary>
        [FieldOffset(5)]
        public byte LoopFilterSharpness;

        /// <summary>
        ///     <c>UpdateRefDelta</c>
        /// </summary>
        [FieldOffset(6)]
        public byte UpdateRefDelta;

        /// <summary>
        ///     <c>LoopFilterRefDeltas</c>
        /// </summary>
        [FieldOffset(7)]
        public byte4 LoopFilterRefDeltas;

        /// <summary>
        ///     <c>UpdateModeDelta</c>
        /// </summary>
        [FieldOffset(11)]
        public byte UpdateModeDelta;

        /// <summary>
        ///     <c>LoopFilterModeDeltas</c>
        /// </summary>
        [FieldOffset(12)]
        public byte2 LoopFilterModeDeltas;
    }
}
