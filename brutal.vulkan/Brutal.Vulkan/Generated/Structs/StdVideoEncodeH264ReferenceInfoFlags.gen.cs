namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH264ReferenceInfoFlags()
    {
        /// <summary>
        ///     <c>UsedForLongTermReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usedForLongTermReference;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH264ReferenceInfoFlags
    {
        /// <inheritdoc cref="_usedForLongTermReference"/>
        public bool UsedForLongTermReference
        {
            get => BitFields.HasFlag(_usedForLongTermReference, 0);
            set => BitFields.SetFlag(ref _usedForLongTermReference, 0, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 1, length: 31);
            set => BitFields.SetRange(ref _reserved, start: 1, length: 31, value);
        }
    }
}
