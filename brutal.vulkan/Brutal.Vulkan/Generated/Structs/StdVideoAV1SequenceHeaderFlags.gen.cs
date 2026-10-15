namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct StdVideoAV1SequenceHeaderFlags()
    {
        /// <summary>
        ///     <c>StillPicture</c>
        /// </summary>
        [FieldOffset(0)]
        private int _stillPicture;

        /// <summary>
        ///     <c>ReducedStillPictureHeader</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reducedStillPictureHeader;

        /// <summary>
        ///     <c>Use_128x128Superblock</c>
        /// </summary>
        [FieldOffset(0)]
        private int _use_128x128Superblock;

        /// <summary>
        ///     <c>EnableFilterIntra</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableFilterIntra;

        /// <summary>
        ///     <c>EnableIntraEdgeFilter</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableIntraEdgeFilter;

        /// <summary>
        ///     <c>EnableInterintraCompound</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableInterintraCompound;

        /// <summary>
        ///     <c>EnableMaskedCompound</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableMaskedCompound;

        /// <summary>
        ///     <c>EnableWarpedMotion</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableWarpedMotion;

        /// <summary>
        ///     <c>EnableDualFilter</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableDualFilter;

        /// <summary>
        ///     <c>EnableOrderHint</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableOrderHint;

        /// <summary>
        ///     <c>EnableJntComp</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableJntComp;

        /// <summary>
        ///     <c>EnableRefFrameMvs</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableRefFrameMvs;

        /// <summary>
        ///     <c>FrameIdNumbersPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _frameIdNumbersPresentFlag;

        /// <summary>
        ///     <c>EnableSuperres</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableSuperres;

        /// <summary>
        ///     <c>EnableCdef</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableCdef;

        /// <summary>
        ///     <c>EnableRestoration</c>
        /// </summary>
        [FieldOffset(0)]
        private int _enableRestoration;

        /// <summary>
        ///     <c>FilmGrainParamsPresent</c>
        /// </summary>
        [FieldOffset(0)]
        private int _filmGrainParamsPresent;

        /// <summary>
        ///     <c>TimingInfoPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _timingInfoPresentFlag;

        /// <summary>
        ///     <c>InitialDisplayDelayPresentFlag</c>
        /// </summary>
        [FieldOffset(0)]
        private int _initialDisplayDelayPresentFlag;

        /// <summary>
        ///     <c>Reserved</c>
        /// </summary>
        [FieldOffset(0)]
        private int _reserved;
    }

    public partial struct StdVideoAV1SequenceHeaderFlags
    {
        /// <inheritdoc cref="_stillPicture"/>
        public bool StillPicture
        {
            get => BitFields.HasFlag(_stillPicture, 0);
            set => BitFields.SetFlag(ref _stillPicture, 0, value);
        }

        /// <inheritdoc cref="_reducedStillPictureHeader"/>
        public bool ReducedStillPictureHeader
        {
            get => BitFields.HasFlag(_reducedStillPictureHeader, 1);
            set => BitFields.SetFlag(ref _reducedStillPictureHeader, 1, value);
        }

        /// <inheritdoc cref="_use_128x128Superblock"/>
        public bool Use_128x128Superblock
        {
            get => BitFields.HasFlag(_use_128x128Superblock, 2);
            set => BitFields.SetFlag(ref _use_128x128Superblock, 2, value);
        }

        /// <inheritdoc cref="_enableFilterIntra"/>
        public bool EnableFilterIntra
        {
            get => BitFields.HasFlag(_enableFilterIntra, 3);
            set => BitFields.SetFlag(ref _enableFilterIntra, 3, value);
        }

        /// <inheritdoc cref="_enableIntraEdgeFilter"/>
        public bool EnableIntraEdgeFilter
        {
            get => BitFields.HasFlag(_enableIntraEdgeFilter, 4);
            set => BitFields.SetFlag(ref _enableIntraEdgeFilter, 4, value);
        }

        /// <inheritdoc cref="_enableInterintraCompound"/>
        public bool EnableInterintraCompound
        {
            get => BitFields.HasFlag(_enableInterintraCompound, 5);
            set => BitFields.SetFlag(ref _enableInterintraCompound, 5, value);
        }

        /// <inheritdoc cref="_enableMaskedCompound"/>
        public bool EnableMaskedCompound
        {
            get => BitFields.HasFlag(_enableMaskedCompound, 6);
            set => BitFields.SetFlag(ref _enableMaskedCompound, 6, value);
        }

        /// <inheritdoc cref="_enableWarpedMotion"/>
        public bool EnableWarpedMotion
        {
            get => BitFields.HasFlag(_enableWarpedMotion, 7);
            set => BitFields.SetFlag(ref _enableWarpedMotion, 7, value);
        }

        /// <inheritdoc cref="_enableDualFilter"/>
        public bool EnableDualFilter
        {
            get => BitFields.HasFlag(_enableDualFilter, 8);
            set => BitFields.SetFlag(ref _enableDualFilter, 8, value);
        }

        /// <inheritdoc cref="_enableOrderHint"/>
        public bool EnableOrderHint
        {
            get => BitFields.HasFlag(_enableOrderHint, 9);
            set => BitFields.SetFlag(ref _enableOrderHint, 9, value);
        }

        /// <inheritdoc cref="_enableJntComp"/>
        public bool EnableJntComp
        {
            get => BitFields.HasFlag(_enableJntComp, 10);
            set => BitFields.SetFlag(ref _enableJntComp, 10, value);
        }

        /// <inheritdoc cref="_enableRefFrameMvs"/>
        public bool EnableRefFrameMvs
        {
            get => BitFields.HasFlag(_enableRefFrameMvs, 11);
            set => BitFields.SetFlag(ref _enableRefFrameMvs, 11, value);
        }

        /// <inheritdoc cref="_frameIdNumbersPresentFlag"/>
        public bool FrameIdNumbersPresentFlag
        {
            get => BitFields.HasFlag(_frameIdNumbersPresentFlag, 12);
            set => BitFields.SetFlag(ref _frameIdNumbersPresentFlag, 12, value);
        }

        /// <inheritdoc cref="_enableSuperres"/>
        public bool EnableSuperres
        {
            get => BitFields.HasFlag(_enableSuperres, 13);
            set => BitFields.SetFlag(ref _enableSuperres, 13, value);
        }

        /// <inheritdoc cref="_enableCdef"/>
        public bool EnableCdef
        {
            get => BitFields.HasFlag(_enableCdef, 14);
            set => BitFields.SetFlag(ref _enableCdef, 14, value);
        }

        /// <inheritdoc cref="_enableRestoration"/>
        public bool EnableRestoration
        {
            get => BitFields.HasFlag(_enableRestoration, 15);
            set => BitFields.SetFlag(ref _enableRestoration, 15, value);
        }

        /// <inheritdoc cref="_filmGrainParamsPresent"/>
        public bool FilmGrainParamsPresent
        {
            get => BitFields.HasFlag(_filmGrainParamsPresent, 16);
            set => BitFields.SetFlag(ref _filmGrainParamsPresent, 16, value);
        }

        /// <inheritdoc cref="_timingInfoPresentFlag"/>
        public bool TimingInfoPresentFlag
        {
            get => BitFields.HasFlag(_timingInfoPresentFlag, 17);
            set => BitFields.SetFlag(ref _timingInfoPresentFlag, 17, value);
        }

        /// <inheritdoc cref="_initialDisplayDelayPresentFlag"/>
        public bool InitialDisplayDelayPresentFlag
        {
            get => BitFields.HasFlag(_initialDisplayDelayPresentFlag, 18);
            set => BitFields.SetFlag(ref _initialDisplayDelayPresentFlag, 18, value);
        }

        /// <inheritdoc cref="_reserved"/>
        public int Reserved
        {
            get => BitFields.ExtractRange(_reserved, start: 19, length: 13);
            set => BitFields.SetRange(ref _reserved, start: 19, length: 13, value);
        }
    }
}
