namespace Brutal.VulkanApi.Vma
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VmaDeviceMemoryCallbacks
    {
        [FieldOffset(0)]
        public VmaAllocateDeviceMemoryFunction PfnAllocate;

        [FieldOffset(8)]
        public VmaFreeDeviceMemoryFunction PfnFree;

        [FieldOffset(16)]
        public Ptr PUserData;
    }
}
