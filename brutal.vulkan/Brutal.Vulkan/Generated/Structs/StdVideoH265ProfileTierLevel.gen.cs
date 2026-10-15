namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct StdVideoH265ProfileTierLevel()
    {
        /// <summary>
        ///     <c>Flags</c>
        /// </summary>
        [FieldOffset(0)]
        public StdVideoH265ProfileTierLevelFlags Flags;

        /// <summary>
        ///     <c>GeneralProfileIdc</c>
        /// </summary>
        [FieldOffset(4)]
        public StdVideoH265ProfileIdc GeneralProfileIdc;

        /// <summary>
        ///     <c>GeneralLevelIdc</c>
        /// </summary>
        [FieldOffset(8)]
        public StdVideoH265LevelIdc GeneralLevelIdc;
    }
}
