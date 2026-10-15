namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaDefragmentationMove
    {
        [FieldOffset(0)]
        public VmaDefragmentationMoveOperation Operation;

        [FieldOffset(8)]
        public VmaAllocation SrcAllocation;

        [FieldOffset(16)]
        public VmaAllocation DstTmpAllocation;
    }
}
