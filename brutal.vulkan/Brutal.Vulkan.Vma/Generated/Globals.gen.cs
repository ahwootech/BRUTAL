namespace Brutal.VulkanApi.Vma
{
    public readonly unsafe struct VmaAllocateDeviceMemoryFunction(
        delegate* unmanaged[Cdecl]<VmaAllocatorHandle, uint, VkDeviceMemory, ByteSize, Ptr, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VmaAllocatorHandle,
            uint,
            VkDeviceMemory,
            ByteSize,
            Ptr,
            void> Invoke = handle;

        public static explicit operator VmaAllocateDeviceMemoryFunction(PfnVkVoidFunction func)
        {
            return new VmaAllocateDeviceMemoryFunction(
                (delegate* unmanaged[Cdecl]<VmaAllocatorHandle, uint, VkDeviceMemory, ByteSize, Ptr, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VmaFreeDeviceMemoryFunction(
        delegate* unmanaged[Cdecl]<VmaAllocatorHandle, uint, VkDeviceMemory, ByteSize, Ptr, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VmaAllocatorHandle,
            uint,
            VkDeviceMemory,
            ByteSize,
            Ptr,
            void> Invoke = handle;

        public static explicit operator VmaFreeDeviceMemoryFunction(PfnVkVoidFunction func)
        {
            return new VmaFreeDeviceMemoryFunction(
                (delegate* unmanaged[Cdecl]<VmaAllocatorHandle, uint, VkDeviceMemory, ByteSize, Ptr, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VmaCheckDefragmentationBreakFunction(delegate* unmanaged[Cdecl]<Ptr, Bool32> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<Ptr, Bool32> Invoke = handle;

        public static explicit operator VmaCheckDefragmentationBreakFunction(PfnVkVoidFunction func)
        {
            return new VmaCheckDefragmentationBreakFunction((delegate* unmanaged[Cdecl]<Ptr, Bool32>)func.Invoke);
        }
    }
}
