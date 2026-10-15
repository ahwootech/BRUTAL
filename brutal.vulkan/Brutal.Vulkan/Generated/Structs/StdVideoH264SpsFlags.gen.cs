namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoH264SpsFlags()
    {
        /// <summary>
        ///     <c>ConstraintSet0Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constraintSet0Flag;

        /// <summary>
        ///     <c>ConstraintSet1Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constraintSet1Flag;

        /// <summary>
        ///     <c>ConstraintSet2Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constraintSet2Flag;

        /// <summary>
        ///     <c>ConstraintSet3Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constraintSet3Flag;

        /// <summary>
        ///     <c>ConstraintSet4Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constraintSet4Flag;

        /// <summary>
        ///     <c>ConstraintSet5Flag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _constraintSet5Flag;

        /// <summary>
        ///     <c>Direct_8x8InferenceFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _direct_8x8InferenceFlag;

        /// <summary>
        ///     <c>MbAdaptiveFrameFieldFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _mbAdaptiveFrameFieldFlag;

        /// <summary>
        ///     <c>FrameMbsOnlyFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameMbsOnlyFlag;

        /// <summary>
        ///     <c>DeltaPicOrderAlwaysZeroFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deltaPicOrderAlwaysZeroFlag;

        /// <summary>
        ///     <c>SeparateColourPlaneFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _separateColourPlaneFlag;

        /// <summary>
        ///     <c>GapsInFrameNumValueAllowedFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _gapsInFrameNumValueAllowedFlag;

        /// <summary>
        ///     <c>QpprimeYZeroTransformBypassFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _qpprimeYZeroTransformBypassFlag;

        /// <summary>
        ///     <c>FrameCroppingFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameCroppingFlag;

        /// <summary>
        ///     <c>SeqScalingMatrixPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _seqScalingMatrixPresentFlag;

        /// <summary>
        ///     <c>VuiParametersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _vuiParametersPresentFlag;
    }

    public partial struct StdVideoH264SpsFlags
    {
        /// <inheritdoc cref="_constraintSet0Flag"/>
        public bool ConstraintSet0Flag
        {
            get => BitFields.HasFlag(_constraintSet0Flag, 0);
            set => BitFields.SetFlag(ref _constraintSet0Flag, 0, value);
        }

        /// <inheritdoc cref="_constraintSet1Flag"/>
        public bool ConstraintSet1Flag
        {
            get => BitFields.HasFlag(_constraintSet1Flag, 1);
            set => BitFields.SetFlag(ref _constraintSet1Flag, 1, value);
        }

        /// <inheritdoc cref="_constraintSet2Flag"/>
        public bool ConstraintSet2Flag
        {
            get => BitFields.HasFlag(_constraintSet2Flag, 2);
            set => BitFields.SetFlag(ref _constraintSet2Flag, 2, value);
        }

        /// <inheritdoc cref="_constraintSet3Flag"/>
        public bool ConstraintSet3Flag
        {
            get => BitFields.HasFlag(_constraintSet3Flag, 3);
            set => BitFields.SetFlag(ref _constraintSet3Flag, 3, value);
        }

        /// <inheritdoc cref="_constraintSet4Flag"/>
        public bool ConstraintSet4Flag
        {
            get => BitFields.HasFlag(_constraintSet4Flag, 4);
            set => BitFields.SetFlag(ref _constraintSet4Flag, 4, value);
        }

        /// <inheritdoc cref="_constraintSet5Flag"/>
        public bool ConstraintSet5Flag
        {
            get => BitFields.HasFlag(_constraintSet5Flag, 5);
            set => BitFields.SetFlag(ref _constraintSet5Flag, 5, value);
        }

        /// <inheritdoc cref="_direct_8x8InferenceFlag"/>
        public bool Direct_8x8InferenceFlag
        {
            get => BitFields.HasFlag(_direct_8x8InferenceFlag, 6);
            set => BitFields.SetFlag(ref _direct_8x8InferenceFlag, 6, value);
        }

        /// <inheritdoc cref="_mbAdaptiveFrameFieldFlag"/>
        public bool MbAdaptiveFrameFieldFlag
        {
            get => BitFields.HasFlag(_mbAdaptiveFrameFieldFlag, 7);
            set => BitFields.SetFlag(ref _mbAdaptiveFrameFieldFlag, 7, value);
        }

        /// <inheritdoc cref="_frameMbsOnlyFlag"/>
        public bool FrameMbsOnlyFlag
        {
            get => BitFields.HasFlag(_frameMbsOnlyFlag, 8);
            set => BitFields.SetFlag(ref _frameMbsOnlyFlag, 8, value);
        }

        /// <inheritdoc cref="_deltaPicOrderAlwaysZeroFlag"/>
        public bool DeltaPicOrderAlwaysZeroFlag
        {
            get => BitFields.HasFlag(_deltaPicOrderAlwaysZeroFlag, 9);
            set => BitFields.SetFlag(ref _deltaPicOrderAlwaysZeroFlag, 9, value);
        }

        /// <inheritdoc cref="_separateColourPlaneFlag"/>
        public bool SeparateColourPlaneFlag
        {
            get => BitFields.HasFlag(_separateColourPlaneFlag, 10);
            set => BitFields.SetFlag(ref _separateColourPlaneFlag, 10, value);
        }

        /// <inheritdoc cref="_gapsInFrameNumValueAllowedFlag"/>
        public bool GapsInFrameNumValueAllowedFlag
        {
            get => BitFields.HasFlag(_gapsInFrameNumValueAllowedFlag, 11);
            set => BitFields.SetFlag(ref _gapsInFrameNumValueAllowedFlag, 11, value);
        }

        /// <inheritdoc cref="_qpprimeYZeroTransformBypassFlag"/>
        public bool QpprimeYZeroTransformBypassFlag
        {
            get => BitFields.HasFlag(_qpprimeYZeroTransformBypassFlag, 12);
            set => BitFields.SetFlag(ref _qpprimeYZeroTransformBypassFlag, 12, value);
        }

        /// <inheritdoc cref="_frameCroppingFlag"/>
        public bool FrameCroppingFlag
        {
            get => BitFields.HasFlag(_frameCroppingFlag, 13);
            set => BitFields.SetFlag(ref _frameCroppingFlag, 13, value);
        }

        /// <inheritdoc cref="_seqScalingMatrixPresentFlag"/>
        public bool SeqScalingMatrixPresentFlag
        {
            get => BitFields.HasFlag(_seqScalingMatrixPresentFlag, 14);
            set => BitFields.SetFlag(ref _seqScalingMatrixPresentFlag, 14, value);
        }

        /// <inheritdoc cref="_vuiParametersPresentFlag"/>
        public bool VuiParametersPresentFlag
        {
            get => BitFields.HasFlag(_vuiParametersPresentFlag, 15);
            set => BitFields.SetFlag(ref _vuiParametersPresentFlag, 15, value);
        }
    }
}
