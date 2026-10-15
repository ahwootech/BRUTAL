namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoEncodeAV1PictureInfoFlags()
    {
        /// <summary>
        ///     <c>ErrorResilientMode</c>
        /// </summary>
        [FieldOffset(0)]
        private int _errorResilientMode;

        /// <summary>
        ///     <c>DisableCdfUpdate</c>
        /// </summary>
        [FieldOffset(0)]
        private int _disableCdfUpdate;

        /// <summary>
        ///     <c>UseSuperres</c>
        /// </summary>
        [FieldOffset(0)]
        private int _useSuperres;

        /// <summary>
        ///     <c>RenderAndFrameSizeDifferent</c>
        /// </summary>
        [FieldOffset(0)]
        private int _renderAndFrameSizeDifferent;

        /// <summary>
        ///     <c>AllowScreenContentTools</c>
        /// </summary>
        [FieldOffset(0)]
        private int _allowScreenContentTools;

        /// <summary>
        ///     <c>IsFilterSwitchable</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isFilterSwitchable;

        /// <summary>
        ///     <c>ForceIntegerMv</c>
        /// </summary>
        [FieldOffset(0)]
        private int _forceIntegerMv;

        /// <summary>
        ///     <c>FrameSizeOverrideFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameSizeOverrideFlag;

        /// <summary>
        ///     <c>BufferRemovalTimePresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _bufferRemovalTimePresentFlag;

        /// <summary>
        ///     <c>AllowIntrabc</c>
        /// </summary>
        [FieldOffset(0)]
        private int _allowIntrabc;

        /// <summary>
        ///     <c>FrameRefsShortSignaling</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameRefsShortSignaling;

        /// <summary>
        ///     <c>AllowHighPrecisionMv</c>
        /// </summary>
        [FieldOffset(0)]
        private int _allowHighPrecisionMv;

        /// <summary>
        ///     <c>IsMotionModeSwitchable</c>
        /// </summary>
        [FieldOffset(0)]
        private int _isMotionModeSwitchable;

        /// <summary>
        ///     <c>UseRefFrameMvs</c>
        /// </summary>
        [FieldOffset(0)]
        private int _useRefFrameMvs;

        /// <summary>
        ///     <c>DisableFrameEndUpdateCdf</c>
        /// </summary>
        [FieldOffset(0)]
        private int _disableFrameEndUpdateCdf;

        /// <summary>
        ///     <c>AllowWarpedMotion</c>
        /// </summary>
        [FieldOffset(0)]
        private int _allowWarpedMotion;

        /// <summary>
        ///     <c>ReducedTxSet</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reducedTxSet;

        /// <summary>
        ///     <c>SkipModePresent</c>
        /// </summary>
        [FieldOffset(0)]
        private int _skipModePresent;

        /// <summary>
        ///     <c>DeltaQPresent</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deltaQPresent;

        /// <summary>
        ///     <c>DeltaLfPresent</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deltaLfPresent;

        /// <summary>
        ///     <c>DeltaLfMulti</c>
        /// </summary>
        [FieldOffset(0)]
        private int _deltaLfMulti;

        /// <summary>
        ///     <c>SegmentationEnabled</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationEnabled;

        /// <summary>
        ///     <c>SegmentationUpdateMap</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationUpdateMap;

        /// <summary>
        ///     <c>SegmentationTemporalUpdate</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationTemporalUpdate;

        /// <summary>
        ///     <c>SegmentationUpdateData</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationUpdateData;

        /// <summary>
        ///     <c>UsesLr</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usesLr;

        /// <summary>
        ///     <c>UsesChromaLr</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usesChromaLr;

        /// <summary>
        ///     <c>ShowFrame</c>
        /// </summary>
        [FieldOffset(0)]
        private int _showFrame;

        /// <summary>
        ///     <c>ShowableFrame</c>
        /// </summary>
        [FieldOffset(0)]
        private int _showableFrame;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoEncodeAV1PictureInfoFlags
    {
        /// <inheritdoc cref="_errorResilientMode"/>
        public bool ErrorResilientMode
        {
            get => BitFields.HasFlag(_errorResilientMode, 0);
            set => BitFields.SetFlag(ref _errorResilientMode, 0, value);
        }

        /// <inheritdoc cref="_disableCdfUpdate"/>
        public bool DisableCdfUpdate
        {
            get => BitFields.HasFlag(_disableCdfUpdate, 1);
            set => BitFields.SetFlag(ref _disableCdfUpdate, 1, value);
        }

        /// <inheritdoc cref="_useSuperres"/>
        public bool UseSuperres
        {
            get => BitFields.HasFlag(_useSuperres, 2);
            set => BitFields.SetFlag(ref _useSuperres, 2, value);
        }

        /// <inheritdoc cref="_renderAndFrameSizeDifferent"/>
        public bool RenderAndFrameSizeDifferent
        {
            get => BitFields.HasFlag(_renderAndFrameSizeDifferent, 3);
            set => BitFields.SetFlag(ref _renderAndFrameSizeDifferent, 3, value);
        }

        /// <inheritdoc cref="_allowScreenContentTools"/>
        public bool AllowScreenContentTools
        {
            get => BitFields.HasFlag(_allowScreenContentTools, 4);
            set => BitFields.SetFlag(ref _allowScreenContentTools, 4, value);
        }

        /// <inheritdoc cref="_isFilterSwitchable"/>
        public bool IsFilterSwitchable
        {
            get => BitFields.HasFlag(_isFilterSwitchable, 5);
            set => BitFields.SetFlag(ref _isFilterSwitchable, 5, value);
        }

        /// <inheritdoc cref="_forceIntegerMv"/>
        public bool ForceIntegerMv
        {
            get => BitFields.HasFlag(_forceIntegerMv, 6);
            set => BitFields.SetFlag(ref _forceIntegerMv, 6, value);
        }

        /// <inheritdoc cref="_frameSizeOverrideFlag"/>
        public bool FrameSizeOverrideFlag
        {
            get => BitFields.HasFlag(_frameSizeOverrideFlag, 7);
            set => BitFields.SetFlag(ref _frameSizeOverrideFlag, 7, value);
        }

        /// <inheritdoc cref="_bufferRemovalTimePresentFlag"/>
        public bool BufferRemovalTimePresentFlag
        {
            get => BitFields.HasFlag(_bufferRemovalTimePresentFlag, 8);
            set => BitFields.SetFlag(ref _bufferRemovalTimePresentFlag, 8, value);
        }

        /// <inheritdoc cref="_allowIntrabc"/>
        public bool AllowIntrabc
        {
            get => BitFields.HasFlag(_allowIntrabc, 9);
            set => BitFields.SetFlag(ref _allowIntrabc, 9, value);
        }

        /// <inheritdoc cref="_frameRefsShortSignaling"/>
        public bool FrameRefsShortSignaling
        {
            get => BitFields.HasFlag(_frameRefsShortSignaling, 10);
            set => BitFields.SetFlag(ref _frameRefsShortSignaling, 10, value);
        }

        /// <inheritdoc cref="_allowHighPrecisionMv"/>
        public bool AllowHighPrecisionMv
        {
            get => BitFields.HasFlag(_allowHighPrecisionMv, 11);
            set => BitFields.SetFlag(ref _allowHighPrecisionMv, 11, value);
        }

        /// <inheritdoc cref="_isMotionModeSwitchable"/>
        public bool IsMotionModeSwitchable
        {
            get => BitFields.HasFlag(_isMotionModeSwitchable, 12);
            set => BitFields.SetFlag(ref _isMotionModeSwitchable, 12, value);
        }

        /// <inheritdoc cref="_useRefFrameMvs"/>
        public bool UseRefFrameMvs
        {
            get => BitFields.HasFlag(_useRefFrameMvs, 13);
            set => BitFields.SetFlag(ref _useRefFrameMvs, 13, value);
        }

        /// <inheritdoc cref="_disableFrameEndUpdateCdf"/>
        public bool DisableFrameEndUpdateCdf
        {
            get => BitFields.HasFlag(_disableFrameEndUpdateCdf, 14);
            set => BitFields.SetFlag(ref _disableFrameEndUpdateCdf, 14, value);
        }

        /// <inheritdoc cref="_allowWarpedMotion"/>
        public bool AllowWarpedMotion
        {
            get => BitFields.HasFlag(_allowWarpedMotion, 15);
            set => BitFields.SetFlag(ref _allowWarpedMotion, 15, value);
        }

        /// <inheritdoc cref="_reducedTxSet"/>
        public bool ReducedTxSet
        {
            get => BitFields.HasFlag(_reducedTxSet, 16);
            set => BitFields.SetFlag(ref _reducedTxSet, 16, value);
        }

        /// <inheritdoc cref="_skipModePresent"/>
        public bool SkipModePresent
        {
            get => BitFields.HasFlag(_skipModePresent, 17);
            set => BitFields.SetFlag(ref _skipModePresent, 17, value);
        }

        /// <inheritdoc cref="_deltaQPresent"/>
        public bool DeltaQPresent
        {
            get => BitFields.HasFlag(_deltaQPresent, 18);
            set => BitFields.SetFlag(ref _deltaQPresent, 18, value);
        }

        /// <inheritdoc cref="_deltaLfPresent"/>
        public bool DeltaLfPresent
        {
            get => BitFields.HasFlag(_deltaLfPresent, 19);
            set => BitFields.SetFlag(ref _deltaLfPresent, 19, value);
        }

        /// <inheritdoc cref="_deltaLfMulti"/>
        public bool DeltaLfMulti
        {
            get => BitFields.HasFlag(_deltaLfMulti, 20);
            set => BitFields.SetFlag(ref _deltaLfMulti, 20, value);
        }

        /// <inheritdoc cref="_segmentationEnabled"/>
        public bool SegmentationEnabled
        {
            get => BitFields.HasFlag(_segmentationEnabled, 21);
            set => BitFields.SetFlag(ref _segmentationEnabled, 21, value);
        }

        /// <inheritdoc cref="_segmentationUpdateMap"/>
        public bool SegmentationUpdateMap
        {
            get => BitFields.HasFlag(_segmentationUpdateMap, 22);
            set => BitFields.SetFlag(ref _segmentationUpdateMap, 22, value);
        }

        /// <inheritdoc cref="_segmentationTemporalUpdate"/>
        public bool SegmentationTemporalUpdate
        {
            get => BitFields.HasFlag(_segmentationTemporalUpdate, 23);
            set => BitFields.SetFlag(ref _segmentationTemporalUpdate, 23, value);
        }

        /// <inheritdoc cref="_segmentationUpdateData"/>
        public bool SegmentationUpdateData
        {
            get => BitFields.HasFlag(_segmentationUpdateData, 24);
            set => BitFields.SetFlag(ref _segmentationUpdateData, 24, value);
        }

        /// <inheritdoc cref="_usesLr"/>
        public bool UsesLr
        {
            get => BitFields.HasFlag(_usesLr, 25);
            set => BitFields.SetFlag(ref _usesLr, 25, value);
        }

        /// <inheritdoc cref="_usesChromaLr"/>
        public bool UsesChromaLr
        {
            get => BitFields.HasFlag(_usesChromaLr, 26);
            set => BitFields.SetFlag(ref _usesChromaLr, 26, value);
        }

        /// <inheritdoc cref="_showFrame"/>
        public bool ShowFrame
        {
            get => BitFields.HasFlag(_showFrame, 27);
            set => BitFields.SetFlag(ref _showFrame, 27, value);
        }

        /// <inheritdoc cref="_showableFrame"/>
        public bool ShowableFrame
        {
            get => BitFields.HasFlag(_showableFrame, 28);
            set => BitFields.SetFlag(ref _showableFrame, 28, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 29, length: 3);
            set => BitFields.SetRange(ref _reserved, start: 29, length: 3, value);
        }
    }
}
