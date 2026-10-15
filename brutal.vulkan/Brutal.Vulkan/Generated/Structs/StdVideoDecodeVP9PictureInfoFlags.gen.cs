namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoDecodeVP9PictureInfoFlags()
    {
        /// <summary>
        ///     <c>ErrorResilientMode</c>
        /// </summary>
        [FieldOffset(0)]
        private int _errorResilientMode;

        /// <summary>
        ///     <c>IntraOnly</c>
        /// </summary>
        [FieldOffset(0)]
        private int _intraOnly;

        /// <summary>
        ///     <c>AllowHighPrecisionMv</c>
        /// </summary>
        [FieldOffset(0)]
        private int _allowHighPrecisionMv;

        /// <summary>
        ///     <c>RefreshFrameContext</c>
        /// </summary>
        [FieldOffset(0)]
        private int _refreshFrameContext;

        /// <summary>
        ///     <c>FrameParallelDecodingMode</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameParallelDecodingMode;

        /// <summary>
        ///     <c>SegmentationEnabled</c>
        /// </summary>
        [FieldOffset(0)]
        private int _segmentationEnabled;

        /// <summary>
        ///     <c>ShowFrame</c>
        /// </summary>
        [FieldOffset(0)]
        private int _showFrame;

        /// <summary>
        ///     <c>UsePrevFrameMvs</c>
        /// </summary>
        [FieldOffset(0)]
        private int _usePrevFrameMvs;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoDecodeVP9PictureInfoFlags
    {
        /// <inheritdoc cref="_errorResilientMode"/>
        public bool ErrorResilientMode
        {
            get => BitFields.HasFlag(_errorResilientMode, 0);
            set => BitFields.SetFlag(ref _errorResilientMode, 0, value);
        }

        /// <inheritdoc cref="_intraOnly"/>
        public bool IntraOnly
        {
            get => BitFields.HasFlag(_intraOnly, 1);
            set => BitFields.SetFlag(ref _intraOnly, 1, value);
        }

        /// <inheritdoc cref="_allowHighPrecisionMv"/>
        public bool AllowHighPrecisionMv
        {
            get => BitFields.HasFlag(_allowHighPrecisionMv, 2);
            set => BitFields.SetFlag(ref _allowHighPrecisionMv, 2, value);
        }

        /// <inheritdoc cref="_refreshFrameContext"/>
        public bool RefreshFrameContext
        {
            get => BitFields.HasFlag(_refreshFrameContext, 3);
            set => BitFields.SetFlag(ref _refreshFrameContext, 3, value);
        }

        /// <inheritdoc cref="_frameParallelDecodingMode"/>
        public bool FrameParallelDecodingMode
        {
            get => BitFields.HasFlag(_frameParallelDecodingMode, 4);
            set => BitFields.SetFlag(ref _frameParallelDecodingMode, 4, value);
        }

        /// <inheritdoc cref="_segmentationEnabled"/>
        public bool SegmentationEnabled
        {
            get => BitFields.HasFlag(_segmentationEnabled, 5);
            set => BitFields.SetFlag(ref _segmentationEnabled, 5, value);
        }

        /// <inheritdoc cref="_showFrame"/>
        public bool ShowFrame
        {
            get => BitFields.HasFlag(_showFrame, 6);
            set => BitFields.SetFlag(ref _showFrame, 6, value);
        }

        /// <inheritdoc cref="_usePrevFrameMvs"/>
        public bool UsePrevFrameMvs
        {
            get => BitFields.HasFlag(_usePrevFrameMvs, 7);
            set => BitFields.SetFlag(ref _usePrevFrameMvs, 7, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 8, length: 24);
            set => BitFields.SetRange(ref _reserved, start: 8, length: 24, value);
        }
    }
}
