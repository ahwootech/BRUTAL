namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH265ShortTermRefPicSetFlags()
    {
        /// <summary>
        ///     <c>InterRefPicSetPredictionFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _interRefPicSetPredictionFlag;

        /// <summary>
        ///     <c>DeltaRpsSign</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deltaRpsSign;
    }

    public partial struct StdVideoH265ShortTermRefPicSetFlags
    {
        /// <inheritdoc cref="_interRefPicSetPredictionFlag"/>
        public bool InterRefPicSetPredictionFlag
        {
            get => BitFields.HasFlag(_interRefPicSetPredictionFlag, 0);
            set => BitFields.SetFlag(ref _interRefPicSetPredictionFlag, 0, value);
        }

        /// <inheritdoc cref="_deltaRpsSign"/>
        public bool DeltaRpsSign
        {
            get => BitFields.HasFlag(_deltaRpsSign, 1);
            set => BitFields.SetFlag(ref _deltaRpsSign, 1, value);
        }
    }
}
