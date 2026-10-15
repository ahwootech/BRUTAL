namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoVP9ColorConfigFlags()
    {
        /// <summary>
        ///     <c>ColorRange</c>
        /// </summary>
        [FieldOffset(0)]
        private int _colorRange;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoVP9ColorConfigFlags
    {
        /// <inheritdoc cref="_colorRange"/>
        public bool ColorRange
        {
            get => BitFields.HasFlag(_colorRange, 0);
            set => BitFields.SetFlag(ref _colorRange, 0, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 1, length: 31);
            set => BitFields.SetRange(ref _reserved, start: 1, length: 31, value);
        }
    }
}
