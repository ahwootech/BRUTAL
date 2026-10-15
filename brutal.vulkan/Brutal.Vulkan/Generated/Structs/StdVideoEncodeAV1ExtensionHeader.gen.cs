namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct StdVideoEncodeAV1ExtensionHeader()
    {
        /// <summary>
        ///     <c>TemporalId</c>
        /// </summary>
        [FieldOffset(0)]
        public byte TemporalId;

        /// <summary>
        ///     <c>SpatialId</c>
        /// </summary>
        [FieldOffset(1)]
        public byte SpatialId;
    }
}
