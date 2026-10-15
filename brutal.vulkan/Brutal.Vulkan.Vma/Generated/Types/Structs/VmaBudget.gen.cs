namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public unsafe partial struct VmaBudget
    {
        [FieldOffset(0)]
        public VmaStatistics Statistics;

        [FieldOffset(24)]
        public ByteSize Usage;

        [FieldOffset(32)]
        public ByteSize Budget;
    }
}
