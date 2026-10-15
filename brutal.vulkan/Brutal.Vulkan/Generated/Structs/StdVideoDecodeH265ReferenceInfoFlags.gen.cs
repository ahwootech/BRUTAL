namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoDecodeH265ReferenceInfoFlags()
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
    }

    public partial struct StdVideoDecodeH265ReferenceInfoFlags
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
    }
}
