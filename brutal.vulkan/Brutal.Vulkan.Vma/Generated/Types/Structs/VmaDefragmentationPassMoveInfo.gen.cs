namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe partial struct VmaDefragmentationPassMoveInfo
    {
        [FieldOffset(0)]
        public uint MoveCount;

        [FieldOffset(8)]
        public Ptr<VmaDefragmentationMove> PMoves;
    }
}
