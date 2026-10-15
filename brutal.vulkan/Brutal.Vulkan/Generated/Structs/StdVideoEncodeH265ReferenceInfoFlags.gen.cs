namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeH265ReferenceInfoFlags()
    {
        /// <summary>
        ///     <c>UsedForLongTermReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usedForLongTermReference;

        /// <summary>
        ///     <c>UnusedForReference</c>
        /// </summary>
        [FieldOffset(0)]
        private int _unusedForReference;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeH265ReferenceInfoFlags
    {
        /// <inheritdoc cref="_usedForLongTermReference"/>
        public bool UsedForLongTermReference
        {
            get => BitFields.HasFlag(_usedForLongTermReference, 0);
            set => BitFields.SetFlag(ref _usedForLongTermReference, 0, value);
        }

        /// <inheritdoc cref="_unusedForReference"/>
        public bool UnusedForReference
        {
            get => BitFields.HasFlag(_unusedForReference, 1);
            set => BitFields.SetFlag(ref _unusedForReference, 1, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 2, length: 30);
            set => BitFields.SetRange(ref _reserved, start: 2, length: 30, value);
        }
    }
}
