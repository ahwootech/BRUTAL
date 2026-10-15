namespace Brutal.VulkanApi
{
    ///
    [StructLayout(LayoutKind.Explicit, Size = 484)]
    public partial struct StdVideoH264ScalingLists()
    {
        /// <summary>
        ///     <c>ScalingListPresentMask</c>
        /// </summary>
        [FieldOffset(0)]
        public ushort ScalingListPresentMask;

        /// <summary>
        ///     <c>UseDefaultScalingMatrixMask</c>
        /// </summary>
        [FieldOffset(2)]
        public ushort UseDefaultScalingMatrixMask;

        /// <summary>
        ///     <c>ScalingList4x4</c>
        /// </summary>
        [FieldOffset(4)]
        public byte_16_6 ScalingList4x4;

        /// <summary>
        ///     <c>ScalingList8x8</c>
        /// </summary>
        [FieldOffset(100)]
        public byte_64_6 ScalingList8x8;
    }
}
