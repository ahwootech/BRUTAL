namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VmaDefragmentationInfo
    {
        [FieldOffset(0)]
        public VmaDefragmentationFlags Flags;

        [FieldOffset(8)]
        public VmaPool Pool;

        [FieldOffset(16)]
        public ByteSize MaxBytesPerPass;

        [FieldOffset(24)]
        public uint MaxAllocationsPerPass;

        [FieldOffset(32)]
        public VmaCheckDefragmentationBreakFunction PfnBreakCallback;

        [FieldOffset(40)]
        public Ptr PBreakCallbackUserData;
    }
}
