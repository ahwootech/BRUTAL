using Brutal.VulkanApi.Android;
using Brutal.VulkanApi.Metal;
using Brutal.VulkanApi.Wayland;
using Brutal.VulkanApi.Win32;
using Brutal.VulkanApi.Xcb;
using Brutal.VulkanApi.Xlib;

namespace Brutal.VulkanApi
{
    public readonly unsafe struct VkDestroyInstance(
        delegate* unmanaged[Cdecl]<VkInstance, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkInstance, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyInstance(PfnVkVoidFunction func)
        {
            return new VkDestroyInstance(
                (delegate* unmanaged[Cdecl]<VkInstance, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDevices(
        delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDevice*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDevice*, VkResult> Invoke = handle;

        public static explicit operator VkEnumeratePhysicalDevices(PfnVkVoidFunction func)
        {
            return new VkEnumeratePhysicalDevices(
                (delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDevice*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFeatures(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceFeatures(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFeatures(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFormatProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceFormatProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFormatProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceImageFormatProperties(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkFormat,
            VkImageType,
            VkImageTiling,
            VkImageUsageFlags,
            VkImageCreateFlags,
            VkImageFormatProperties*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkFormat,
            VkImageType,
            VkImageTiling,
            VkImageUsageFlags,
            VkImageCreateFlags,
            VkImageFormatProperties*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceImageFormatProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceImageFormatProperties(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkFormat,
                    VkImageType,
                    VkImageTiling,
                    VkImageUsageFlags,
                    VkImageCreateFlags,
                    VkImageFormatProperties*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties*, void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceQueueFamilyProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMemoryProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceMemoryProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceMemoryProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetInstanceProcAddr(
        delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction> Invoke = handle;

        public static explicit operator VkGetInstanceProcAddr(PfnVkVoidFunction func)
        {
            return new VkGetInstanceProcAddr(
                (delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceProcAddr(
        delegate* unmanaged[Cdecl]<VkDevice, byte*, PfnVkVoidFunction> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, byte*, PfnVkVoidFunction> Invoke = handle;

        public static explicit operator VkGetDeviceProcAddr(PfnVkVoidFunction func)
        {
            return new VkGetDeviceProcAddr((delegate* unmanaged[Cdecl]<VkDevice, byte*, PfnVkVoidFunction>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCreateDevice(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDeviceCreateInfo*,
            VkAllocationCallbacks*,
            VkDevice*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDeviceCreateInfo*,
            VkAllocationCallbacks*,
            VkDevice*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDevice(PfnVkVoidFunction func)
        {
            return new VkCreateDevice(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkDeviceCreateInfo*,
                    VkAllocationCallbacks*,
                    VkDevice*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDevice(
        delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyDevice(PfnVkVoidFunction func)
        {
            return new VkDestroyDevice((delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkEnumerateDeviceExtensionProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, byte*, int*, VkExtensionProperties*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            byte*,
            int*,
            VkExtensionProperties*,
            VkResult> Invoke = handle;

        public static explicit operator VkEnumerateDeviceExtensionProperties(PfnVkVoidFunction func)
        {
            return new VkEnumerateDeviceExtensionProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, byte*, int*, VkExtensionProperties*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEnumerateDeviceLayerProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkLayerProperties*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkLayerProperties*, VkResult> Invoke =
            handle;

        public static explicit operator VkEnumerateDeviceLayerProperties(PfnVkVoidFunction func)
        {
            return new VkEnumerateDeviceLayerProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkLayerProperties*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceQueue(
        delegate* unmanaged[Cdecl]<VkDevice, int, int, VkQueue*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, int, VkQueue*, void> Invoke = handle;

        public static explicit operator VkGetDeviceQueue(PfnVkVoidFunction func)
        {
            return new VkGetDeviceQueue((delegate* unmanaged[Cdecl]<VkDevice, int, int, VkQueue*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkQueueSubmit(
        delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo*, VkFence, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo*, VkFence, VkResult> Invoke = handle;

        public static explicit operator VkQueueSubmit(PfnVkVoidFunction func)
        {
            return new VkQueueSubmit(
                (delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo*, VkFence, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueWaitIdle(delegate* unmanaged[Cdecl]<VkQueue, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkResult> Invoke = handle;

        public static explicit operator VkQueueWaitIdle(PfnVkVoidFunction func)
        {
            return new VkQueueWaitIdle((delegate* unmanaged[Cdecl]<VkQueue, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkDeviceWaitIdle(delegate* unmanaged[Cdecl]<VkDevice, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkResult> Invoke = handle;

        public static explicit operator VkDeviceWaitIdle(PfnVkVoidFunction func)
        {
            return new VkDeviceWaitIdle((delegate* unmanaged[Cdecl]<VkDevice, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkAllocateMemory(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMemoryAllocateInfo*,
            VkAllocationCallbacks*,
            VkDeviceMemory*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMemoryAllocateInfo*,
            VkAllocationCallbacks*,
            VkDeviceMemory*,
            VkResult> Invoke = handle;

        public static explicit operator VkAllocateMemory(PfnVkVoidFunction func)
        {
            return new VkAllocateMemory(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkMemoryAllocateInfo*,
                    VkAllocationCallbacks*,
                    VkDeviceMemory*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkFreeMemory(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkFreeMemory(PfnVkVoidFunction func)
        {
            return new VkFreeMemory(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkMapMemory(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceMemory,
            ByteSize64,
            ByteSize64,
            VkMemoryMapFlags,
            void**,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceMemory,
            ByteSize64,
            ByteSize64,
            VkMemoryMapFlags,
            void**,
            VkResult> Invoke = handle;

        public static explicit operator VkMapMemory(PfnVkVoidFunction func)
        {
            return new VkMapMemory(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeviceMemory,
                    ByteSize64,
                    ByteSize64,
                    VkMemoryMapFlags,
                    void**,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUnmapMemory(delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, void> Invoke = handle;

        public static explicit operator VkUnmapMemory(PfnVkVoidFunction func)
        {
            return new VkUnmapMemory((delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkFlushMappedMemoryRanges(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkMappedMemoryRange*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkMappedMemoryRange*, VkResult> Invoke = handle;

        public static explicit operator VkFlushMappedMemoryRanges(PfnVkVoidFunction func)
        {
            return new VkFlushMappedMemoryRanges(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkMappedMemoryRange*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkInvalidateMappedMemoryRanges(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkMappedMemoryRange*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkMappedMemoryRange*, VkResult> Invoke = handle;

        public static explicit operator VkInvalidateMappedMemoryRanges(PfnVkVoidFunction func)
        {
            return new VkInvalidateMappedMemoryRanges(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkMappedMemoryRange*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceMemoryCommitment(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ByteSize64*, void> Invoke = handle;

        public static explicit operator VkGetDeviceMemoryCommitment(PfnVkVoidFunction func)
        {
            return new VkGetDeviceMemoryCommitment(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ByteSize64*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindBufferMemory(
        delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkDeviceMemory, ByteSize64, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkDeviceMemory, ByteSize64, VkResult> Invoke =
            handle;

        public static explicit operator VkBindBufferMemory(PfnVkVoidFunction func)
        {
            return new VkBindBufferMemory(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkDeviceMemory, ByteSize64, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindImageMemory(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkDeviceMemory, ByteSize64, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkDeviceMemory, ByteSize64, VkResult> Invoke =
            handle;

        public static explicit operator VkBindImageMemory(PfnVkVoidFunction func)
        {
            return new VkBindImageMemory(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkDeviceMemory, ByteSize64, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferMemoryRequirements(
        delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkMemoryRequirements*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkMemoryRequirements*, void> Invoke = handle;

        public static explicit operator VkGetBufferMemoryRequirements(PfnVkVoidFunction func)
        {
            return new VkGetBufferMemoryRequirements(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkMemoryRequirements*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageMemoryRequirements(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkMemoryRequirements*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkMemoryRequirements*, void> Invoke = handle;

        public static explicit operator VkGetImageMemoryRequirements(PfnVkVoidFunction func)
        {
            return new VkGetImageMemoryRequirements(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkMemoryRequirements*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSparseMemoryRequirements(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, int*, VkSparseImageMemoryRequirements*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImage,
            int*,
            VkSparseImageMemoryRequirements*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSparseMemoryRequirements(PfnVkVoidFunction func)
        {
            return new VkGetImageSparseMemoryRequirements(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, int*, VkSparseImageMemoryRequirements*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSparseImageFormatProperties(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkFormat,
            VkImageType,
            VkSampleCountFlags,
            VkImageUsageFlags,
            VkImageTiling,
            int*,
            VkSparseImageFormatProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkFormat,
            VkImageType,
            VkSampleCountFlags,
            VkImageUsageFlags,
            VkImageTiling,
            int*,
            VkSparseImageFormatProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSparseImageFormatProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSparseImageFormatProperties(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkFormat,
                    VkImageType,
                    VkSampleCountFlags,
                    VkImageUsageFlags,
                    VkImageTiling,
                    int*,
                    VkSparseImageFormatProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueBindSparse(
        delegate* unmanaged[Cdecl]<VkQueue, int, VkBindSparseInfo*, VkFence, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int, VkBindSparseInfo*, VkFence, VkResult> Invoke = handle;

        public static explicit operator VkQueueBindSparse(PfnVkVoidFunction func)
        {
            return new VkQueueBindSparse(
                (delegate* unmanaged[Cdecl]<VkQueue, int, VkBindSparseInfo*, VkFence, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateFence(
        delegate* unmanaged[Cdecl]<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkFenceCreateInfo*,
            VkAllocationCallbacks*,
            VkFence*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateFence(PfnVkVoidFunction func)
        {
            return new VkCreateFence(
                (delegate* unmanaged[Cdecl]<VkDevice, VkFenceCreateInfo*, VkAllocationCallbacks*, VkFence*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyFence(
        delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyFence(PfnVkVoidFunction func)
        {
            return new VkDestroyFence(
                (delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkResetFences(delegate* unmanaged[Cdecl]<VkDevice, int, VkFence*, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkFence*, VkResult> Invoke = handle;

        public static explicit operator VkResetFences(PfnVkVoidFunction func)
        {
            return new VkResetFences((delegate* unmanaged[Cdecl]<VkDevice, int, VkFence*, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetFenceStatus(delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkResult> Invoke = handle;

        public static explicit operator VkGetFenceStatus(PfnVkVoidFunction func)
        {
            return new VkGetFenceStatus((delegate* unmanaged[Cdecl]<VkDevice, VkFence, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkWaitForFences(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkFence*, Brutal.Bool32, nint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkFence*, Brutal.Bool32, nint, VkResult> Invoke =
            handle;

        public static explicit operator VkWaitForFences(PfnVkVoidFunction func)
        {
            return new VkWaitForFences(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkFence*, Brutal.Bool32, nint, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateSemaphore(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSemaphoreCreateInfo*,
            VkAllocationCallbacks*,
            VkSemaphore*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSemaphoreCreateInfo*,
            VkAllocationCallbacks*,
            VkSemaphore*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateSemaphore(PfnVkVoidFunction func)
        {
            return new VkCreateSemaphore(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSemaphoreCreateInfo*,
                    VkAllocationCallbacks*,
                    VkSemaphore*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroySemaphore(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroySemaphore(PfnVkVoidFunction func)
        {
            return new VkDestroySemaphore(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateQueryPool(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkQueryPoolCreateInfo*,
            VkAllocationCallbacks*,
            VkQueryPool*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkQueryPoolCreateInfo*,
            VkAllocationCallbacks*,
            VkQueryPool*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateQueryPool(PfnVkVoidFunction func)
        {
            return new VkCreateQueryPool(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkQueryPoolCreateInfo*,
                    VkAllocationCallbacks*,
                    VkQueryPool*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyQueryPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyQueryPool(PfnVkVoidFunction func)
        {
            return new VkDestroyQueryPool(
                (delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetQueryPoolResults(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkQueryPool,
            int,
            int,
            nuint,
            void*,
            ByteSize64,
            VkQueryResultFlags,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkQueryPool,
            int,
            int,
            nuint,
            void*,
            ByteSize64,
            VkQueryResultFlags,
            VkResult> Invoke = handle;

        public static explicit operator VkGetQueryPoolResults(PfnVkVoidFunction func)
        {
            return new VkGetQueryPoolResults(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkQueryPool,
                    int,
                    int,
                    nuint,
                    void*,
                    ByteSize64,
                    VkQueryResultFlags,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateBuffer(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkBufferCreateInfo*,
            VkAllocationCallbacks*,
            VkBuffer*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateBuffer(PfnVkVoidFunction func)
        {
            return new VkCreateBuffer(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCreateInfo*, VkAllocationCallbacks*, VkBuffer*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyBuffer(
        delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyBuffer(PfnVkVoidFunction func)
        {
            return new VkDestroyBuffer(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBuffer, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateImage(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageCreateInfo*,
            VkAllocationCallbacks*,
            VkImage*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateImage(PfnVkVoidFunction func)
        {
            return new VkCreateImage(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyImage(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyImage(PfnVkVoidFunction func)
        {
            return new VkDestroyImage(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSubresourceLayout(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImage,
            VkImageSubresource*,
            VkSubresourceLayout*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSubresourceLayout(PfnVkVoidFunction func)
        {
            return new VkGetImageSubresourceLayout(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource*, VkSubresourceLayout*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateImageView(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageViewCreateInfo*,
            VkAllocationCallbacks*,
            VkImageView*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageViewCreateInfo*,
            VkAllocationCallbacks*,
            VkImageView*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateImageView(PfnVkVoidFunction func)
        {
            return new VkCreateImageView(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkImageViewCreateInfo*,
                    VkAllocationCallbacks*,
                    VkImageView*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyImageView(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyImageView(PfnVkVoidFunction func)
        {
            return new VkDestroyImageView(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateCommandPool(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCommandPoolCreateInfo*,
            VkAllocationCallbacks*,
            VkCommandPool*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCommandPoolCreateInfo*,
            VkAllocationCallbacks*,
            VkCommandPool*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateCommandPool(PfnVkVoidFunction func)
        {
            return new VkCreateCommandPool(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkCommandPoolCreateInfo*,
                    VkAllocationCallbacks*,
                    VkCommandPool*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyCommandPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyCommandPool(PfnVkVoidFunction func)
        {
            return new VkDestroyCommandPool(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkResetCommandPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolResetFlags, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolResetFlags, VkResult> Invoke =
            handle;

        public static explicit operator VkResetCommandPool(PfnVkVoidFunction func)
        {
            return new VkResetCommandPool(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolResetFlags, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAllocateCommandBuffers(
        delegate* unmanaged[Cdecl]<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCommandBufferAllocateInfo*,
            VkCommandBuffer*,
            VkResult> Invoke = handle;

        public static explicit operator VkAllocateCommandBuffers(PfnVkVoidFunction func)
        {
            return new VkAllocateCommandBuffers(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCommandBufferAllocateInfo*, VkCommandBuffer*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkFreeCommandBuffers(
        delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, int, VkCommandBuffer*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, int, VkCommandBuffer*, void> Invoke =
            handle;

        public static explicit operator VkFreeCommandBuffers(PfnVkVoidFunction func)
        {
            return new VkFreeCommandBuffers(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, int, VkCommandBuffer*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBeginCommandBuffer(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult> Invoke =
            handle;

        public static explicit operator VkBeginCommandBuffer(PfnVkVoidFunction func)
        {
            return new VkBeginCommandBuffer(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferBeginInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEndCommandBuffer(delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResult> Invoke = handle;

        public static explicit operator VkEndCommandBuffer(PfnVkVoidFunction func)
        {
            return new VkEndCommandBuffer((delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkResetCommandBuffer(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferResetFlags, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferResetFlags, VkResult> Invoke =
            handle;

        public static explicit operator VkResetCommandBuffer(PfnVkVoidFunction func)
        {
            return new VkResetCommandBuffer(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCommandBufferResetFlags, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyBuffer(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkBuffer, int, VkBufferCopy*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            VkBuffer,
            int,
            VkBufferCopy*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyBuffer(PfnVkVoidFunction func)
        {
            return new VkCmdCopyBuffer(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkBuffer, int, VkBufferCopy*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImage(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkImage,
            VkImageLayout,
            int,
            VkImageCopy*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkImage,
            VkImageLayout,
            int,
            VkImageCopy*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyImage(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImage(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkImage,
                    VkImageLayout,
                    VkImage,
                    VkImageLayout,
                    int,
                    VkImageCopy*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyBufferToImage(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            VkImage,
            VkImageLayout,
            int,
            VkBufferImageCopy*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            VkImage,
            VkImageLayout,
            int,
            VkBufferImageCopy*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyBufferToImage(PfnVkVoidFunction func)
        {
            return new VkCmdCopyBufferToImage(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    VkImage,
                    VkImageLayout,
                    int,
                    VkBufferImageCopy*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImageToBuffer(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkBuffer,
            int,
            VkBufferImageCopy*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkBuffer,
            int,
            VkBufferImageCopy*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyImageToBuffer(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImageToBuffer(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkImage,
                    VkImageLayout,
                    VkBuffer,
                    int,
                    VkBufferImageCopy*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdUpdateBuffer(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            void*,
            void> Invoke = handle;

        public static explicit operator VkCmdUpdateBuffer(PfnVkVoidFunction func)
        {
            return new VkCmdUpdateBuffer(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, void*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdFillBuffer(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdFillBuffer(PfnVkVoidFunction func)
        {
            return new VkCmdFillBuffer(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPipelineBarrier(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags,
            VkPipelineStageFlags,
            VkDependencyFlags,
            int,
            VkMemoryBarrier*,
            int,
            VkBufferMemoryBarrier*,
            int,
            VkImageMemoryBarrier*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags,
            VkPipelineStageFlags,
            VkDependencyFlags,
            int,
            VkMemoryBarrier*,
            int,
            VkBufferMemoryBarrier*,
            int,
            VkImageMemoryBarrier*,
            void> Invoke = handle;

        public static explicit operator VkCmdPipelineBarrier(PfnVkVoidFunction func)
        {
            return new VkCmdPipelineBarrier(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkPipelineStageFlags,
                    VkPipelineStageFlags,
                    VkDependencyFlags,
                    int,
                    VkMemoryBarrier*,
                    int,
                    VkBufferMemoryBarrier*,
                    int,
                    VkImageMemoryBarrier*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginQuery(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, VkQueryControlFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkQueryPool,
            int,
            VkQueryControlFlags,
            void> Invoke = handle;

        public static explicit operator VkCmdBeginQuery(PfnVkVoidFunction func)
        {
            return new VkCmdBeginQuery(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, VkQueryControlFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndQuery(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, void> Invoke = handle;

        public static explicit operator VkCmdEndQuery(PfnVkVoidFunction func)
        {
            return new VkCmdEndQuery((delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdResetQueryPool(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, int, void> Invoke = handle;

        public static explicit operator VkCmdResetQueryPool(PfnVkVoidFunction func)
        {
            return new VkCmdResetQueryPool(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteTimestamp(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags,
            VkQueryPool,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteTimestamp(PfnVkVoidFunction func)
        {
            return new VkCmdWriteTimestamp(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkQueryPool, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyQueryPoolResults(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkQueryPool,
            int,
            int,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkQueryResultFlags,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkQueryPool,
            int,
            int,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkQueryResultFlags,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyQueryPoolResults(PfnVkVoidFunction func)
        {
            return new VkCmdCopyQueryPoolResults(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkQueryPool,
                    int,
                    int,
                    VkBuffer,
                    ByteSize64,
                    ByteSize64,
                    VkQueryResultFlags,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdExecuteCommands(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkCommandBuffer*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkCommandBuffer*, void> Invoke = handle;

        public static explicit operator VkCmdExecuteCommands(PfnVkVoidFunction func)
        {
            return new VkCmdExecuteCommands(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkCommandBuffer*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateEvent(
        delegate* unmanaged[Cdecl]<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkEventCreateInfo*,
            VkAllocationCallbacks*,
            VkEvent*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateEvent(PfnVkVoidFunction func)
        {
            return new VkCreateEvent(
                (delegate* unmanaged[Cdecl]<VkDevice, VkEventCreateInfo*, VkAllocationCallbacks*, VkEvent*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyEvent(
        delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyEvent(PfnVkVoidFunction func)
        {
            return new VkDestroyEvent(
                (delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetEventStatus(delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> Invoke = handle;

        public static explicit operator VkGetEventStatus(PfnVkVoidFunction func)
        {
            return new VkGetEventStatus((delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkSetEvent(delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> Invoke = handle;

        public static explicit operator VkSetEvent(PfnVkVoidFunction func)
        {
            return new VkSetEvent((delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkResetEvent(delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult> Invoke = handle;

        public static explicit operator VkResetEvent(PfnVkVoidFunction func)
        {
            return new VkResetEvent((delegate* unmanaged[Cdecl]<VkDevice, VkEvent, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCreateBufferView(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkBufferViewCreateInfo*,
            VkAllocationCallbacks*,
            VkBufferView*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkBufferViewCreateInfo*,
            VkAllocationCallbacks*,
            VkBufferView*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateBufferView(PfnVkVoidFunction func)
        {
            return new VkCreateBufferView(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkBufferViewCreateInfo*,
                    VkAllocationCallbacks*,
                    VkBufferView*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyBufferView(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferView, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferView, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyBufferView(PfnVkVoidFunction func)
        {
            return new VkDestroyBufferView(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferView, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateShaderModule(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderModuleCreateInfo*,
            VkAllocationCallbacks*,
            VkShaderModule*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderModuleCreateInfo*,
            VkAllocationCallbacks*,
            VkShaderModule*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateShaderModule(PfnVkVoidFunction func)
        {
            return new VkCreateShaderModule(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkShaderModuleCreateInfo*,
                    VkAllocationCallbacks*,
                    VkShaderModule*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyShaderModule(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyShaderModule(PfnVkVoidFunction func)
        {
            return new VkDestroyShaderModule(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreatePipelineCache(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCacheCreateInfo*,
            VkAllocationCallbacks*,
            VkPipelineCache*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCacheCreateInfo*,
            VkAllocationCallbacks*,
            VkPipelineCache*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreatePipelineCache(PfnVkVoidFunction func)
        {
            return new VkCreatePipelineCache(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineCacheCreateInfo*,
                    VkAllocationCallbacks*,
                    VkPipelineCache*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyPipelineCache(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyPipelineCache(PfnVkVoidFunction func)
        {
            return new VkDestroyPipelineCache(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineCacheData(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, nuint*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, nuint*, void*, VkResult> Invoke = handle;

        public static explicit operator VkGetPipelineCacheData(PfnVkVoidFunction func)
        {
            return new VkGetPipelineCacheData(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, nuint*, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkMergePipelineCaches(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, int, VkPipelineCache*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, int, VkPipelineCache*, VkResult> Invoke =
            handle;

        public static explicit operator VkMergePipelineCaches(PfnVkVoidFunction func)
        {
            return new VkMergePipelineCaches(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCache, int, VkPipelineCache*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateComputePipelines(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCache,
            int,
            VkComputePipelineCreateInfo*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCache,
            int,
            VkComputePipelineCreateInfo*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateComputePipelines(PfnVkVoidFunction func)
        {
            return new VkCreateComputePipelines(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineCache,
                    int,
                    VkComputePipelineCreateInfo*,
                    VkAllocationCallbacks*,
                    VkPipeline*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyPipeline(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyPipeline(PfnVkVoidFunction func)
        {
            return new VkDestroyPipeline(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreatePipelineLayout(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineLayoutCreateInfo*,
            VkAllocationCallbacks*,
            VkPipelineLayout*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineLayoutCreateInfo*,
            VkAllocationCallbacks*,
            VkPipelineLayout*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreatePipelineLayout(PfnVkVoidFunction func)
        {
            return new VkCreatePipelineLayout(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineLayoutCreateInfo*,
                    VkAllocationCallbacks*,
                    VkPipelineLayout*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyPipelineLayout(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyPipelineLayout(PfnVkVoidFunction func)
        {
            return new VkDestroyPipelineLayout(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateSampler(
        delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCreateInfo*, VkAllocationCallbacks*, VkSampler*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerCreateInfo*,
            VkAllocationCallbacks*,
            VkSampler*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateSampler(PfnVkVoidFunction func)
        {
            return new VkCreateSampler(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSamplerCreateInfo*,
                    VkAllocationCallbacks*,
                    VkSampler*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroySampler(
        delegate* unmanaged[Cdecl]<VkDevice, VkSampler, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSampler, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroySampler(PfnVkVoidFunction func)
        {
            return new VkDestroySampler(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSampler, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDescriptorSetLayout(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayoutCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorSetLayout*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayoutCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorSetLayout*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDescriptorSetLayout(PfnVkVoidFunction func)
        {
            return new VkCreateDescriptorSetLayout(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorSetLayoutCreateInfo*,
                    VkAllocationCallbacks*,
                    VkDescriptorSetLayout*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDescriptorSetLayout(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayout,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDescriptorSetLayout(PfnVkVoidFunction func)
        {
            return new VkDestroyDescriptorSetLayout(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDescriptorPool(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorPoolCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorPool*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorPoolCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorPool*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDescriptorPool(PfnVkVoidFunction func)
        {
            return new VkCreateDescriptorPool(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorPoolCreateInfo*,
                    VkAllocationCallbacks*,
                    VkDescriptorPool*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDescriptorPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyDescriptorPool(PfnVkVoidFunction func)
        {
            return new VkDestroyDescriptorPool(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkResetDescriptorPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorPool,
            VkDescriptorPoolResetFlags,
            VkResult> Invoke = handle;

        public static explicit operator VkResetDescriptorPool(PfnVkVoidFunction func)
        {
            return new VkResetDescriptorPool(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, VkDescriptorPoolResetFlags, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAllocateDescriptorSets(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetAllocateInfo*,
            VkDescriptorSet*,
            VkResult> Invoke = handle;

        public static explicit operator VkAllocateDescriptorSets(PfnVkVoidFunction func)
        {
            return new VkAllocateDescriptorSets(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetAllocateInfo*, VkDescriptorSet*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkFreeDescriptorSets(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, int, VkDescriptorSet*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, int, VkDescriptorSet*, VkResult> Invoke =
            handle;

        public static explicit operator VkFreeDescriptorSets(PfnVkVoidFunction func)
        {
            return new VkFreeDescriptorSets(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorPool, int, VkDescriptorSet*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUpdateDescriptorSets(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkWriteDescriptorSet*, int, VkCopyDescriptorSet*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkWriteDescriptorSet*,
            int,
            VkCopyDescriptorSet*,
            void> Invoke = handle;

        public static explicit operator VkUpdateDescriptorSets(PfnVkVoidFunction func)
        {
            return new VkUpdateDescriptorSets(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkWriteDescriptorSet*, int, VkCopyDescriptorSet*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindPipeline(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> Invoke =
            handle;

        public static explicit operator VkCmdBindPipeline(PfnVkVoidFunction func)
        {
            return new VkCmdBindPipeline(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindDescriptorSets(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            VkDescriptorSet*,
            int,
            int*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            VkDescriptorSet*,
            int,
            int*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindDescriptorSets(PfnVkVoidFunction func)
        {
            return new VkCmdBindDescriptorSets(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkPipelineBindPoint,
                    VkPipelineLayout,
                    int,
                    int,
                    VkDescriptorSet*,
                    int,
                    int*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdClearColorImage(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkClearColorValue*,
            int,
            VkImageSubresourceRange*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkClearColorValue*,
            int,
            VkImageSubresourceRange*,
            void> Invoke = handle;

        public static explicit operator VkCmdClearColorImage(PfnVkVoidFunction func)
        {
            return new VkCmdClearColorImage(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkImage,
                    VkImageLayout,
                    VkClearColorValue*,
                    int,
                    VkImageSubresourceRange*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDispatch(delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDispatch(PfnVkVoidFunction func)
        {
            return new VkCmdDispatch((delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdDispatchIndirect(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, void> Invoke = handle;

        public static explicit operator VkCmdDispatchIndirect(PfnVkVoidFunction func)
        {
            return new VkCmdDispatchIndirect(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetEvent(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> Invoke =
            handle;

        public static explicit operator VkCmdSetEvent(PfnVkVoidFunction func)
        {
            return new VkCmdSetEvent(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdResetEvent(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void> Invoke =
            handle;

        public static explicit operator VkCmdResetEvent(PfnVkVoidFunction func)
        {
            return new VkCmdResetEvent(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWaitEvents(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkEvent*,
            VkPipelineStageFlags,
            VkPipelineStageFlags,
            int,
            VkMemoryBarrier*,
            int,
            VkBufferMemoryBarrier*,
            int,
            VkImageMemoryBarrier*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkEvent*,
            VkPipelineStageFlags,
            VkPipelineStageFlags,
            int,
            VkMemoryBarrier*,
            int,
            VkBufferMemoryBarrier*,
            int,
            VkImageMemoryBarrier*,
            void> Invoke = handle;

        public static explicit operator VkCmdWaitEvents(PfnVkVoidFunction func)
        {
            return new VkCmdWaitEvents(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkEvent*,
                    VkPipelineStageFlags,
                    VkPipelineStageFlags,
                    int,
                    VkMemoryBarrier*,
                    int,
                    VkBufferMemoryBarrier*,
                    int,
                    VkImageMemoryBarrier*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushConstants(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlags, int, int, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineLayout,
            VkShaderStageFlags,
            int,
            int,
            void*,
            void> Invoke = handle;

        public static explicit operator VkCmdPushConstants(PfnVkVoidFunction func)
        {
            return new VkCmdPushConstants(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkPipelineLayout,
                    VkShaderStageFlags,
                    int,
                    int,
                    void*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateGraphicsPipelines(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCache,
            int,
            VkGraphicsPipelineCreateInfo*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCache,
            int,
            VkGraphicsPipelineCreateInfo*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateGraphicsPipelines(PfnVkVoidFunction func)
        {
            return new VkCreateGraphicsPipelines(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineCache,
                    int,
                    VkGraphicsPipelineCreateInfo*,
                    VkAllocationCallbacks*,
                    VkPipeline*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateFramebuffer(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkFramebufferCreateInfo*,
            VkAllocationCallbacks*,
            VkFramebuffer*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkFramebufferCreateInfo*,
            VkAllocationCallbacks*,
            VkFramebuffer*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateFramebuffer(PfnVkVoidFunction func)
        {
            return new VkCreateFramebuffer(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkFramebufferCreateInfo*,
                    VkAllocationCallbacks*,
                    VkFramebuffer*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyFramebuffer(
        delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyFramebuffer(PfnVkVoidFunction func)
        {
            return new VkDestroyFramebuffer(
                (delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateRenderPass(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkRenderPassCreateInfo*,
            VkAllocationCallbacks*,
            VkRenderPass*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkRenderPassCreateInfo*,
            VkAllocationCallbacks*,
            VkRenderPass*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateRenderPass(PfnVkVoidFunction func)
        {
            return new VkCreateRenderPass(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkRenderPassCreateInfo*,
                    VkAllocationCallbacks*,
                    VkRenderPass*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyRenderPass(
        delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyRenderPass(PfnVkVoidFunction func)
        {
            return new VkDestroyRenderPass(
                (delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRenderAreaGranularity(
        delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, void> Invoke = handle;

        public static explicit operator VkGetRenderAreaGranularity(PfnVkVoidFunction func)
        {
            return new VkGetRenderAreaGranularity(
                (delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetViewport(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewport*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewport*, void> Invoke = handle;

        public static explicit operator VkCmdSetViewport(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewport(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewport*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetScissor(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void> Invoke = handle;

        public static explicit operator VkCmdSetScissor(PfnVkVoidFunction func)
        {
            return new VkCmdSetScissor(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLineWidth(delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> Invoke = handle;

        public static explicit operator VkCmdSetLineWidth(PfnVkVoidFunction func)
        {
            return new VkCmdSetLineWidth((delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetDepthBias(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, float, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, float, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBias(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBias(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, float, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetBlendConstants(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, float*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, float*, void> Invoke = handle;

        public static explicit operator VkCmdSetBlendConstants(PfnVkVoidFunction func)
        {
            return new VkCmdSetBlendConstants((delegate* unmanaged[Cdecl]<VkCommandBuffer, float*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetDepthBounds(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBounds(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBounds(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, float, float, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilCompareMask(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void> Invoke = handle;

        public static explicit operator VkCmdSetStencilCompareMask(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilCompareMask(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilWriteMask(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void> Invoke = handle;

        public static explicit operator VkCmdSetStencilWriteMask(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilWriteMask(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilReference(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void> Invoke = handle;

        public static explicit operator VkCmdSetStencilReference(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilReference(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkStencilFaceFlags, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindIndexBuffer(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkIndexType, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkIndexType, void> Invoke =
            handle;

        public static explicit operator VkCmdBindIndexBuffer(PfnVkVoidFunction func)
        {
            return new VkCmdBindIndexBuffer(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkIndexType, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindVertexBuffers(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void> Invoke =
            handle;

        public static explicit operator VkCmdBindVertexBuffers(PfnVkVoidFunction func)
        {
            return new VkCmdBindVertexBuffers(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDraw(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDraw(PfnVkVoidFunction func)
        {
            return new VkCmdDraw((delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdDrawIndexed(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDrawIndexed(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexed(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirect(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> Invoke =
            handle;

        public static explicit operator VkCmdDrawIndirect(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirect(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirect(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> Invoke =
            handle;

        public static explicit operator VkCmdDrawIndexedIndirect(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexedIndirect(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBlitImage(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkImage,
            VkImageLayout,
            int,
            VkImageBlit*,
            VkFilter,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkImage,
            VkImageLayout,
            int,
            VkImageBlit*,
            VkFilter,
            void> Invoke = handle;

        public static explicit operator VkCmdBlitImage(PfnVkVoidFunction func)
        {
            return new VkCmdBlitImage(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkImage,
                    VkImageLayout,
                    VkImage,
                    VkImageLayout,
                    int,
                    VkImageBlit*,
                    VkFilter,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdClearDepthStencilImage(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkClearDepthStencilValue*,
            int,
            VkImageSubresourceRange*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkClearDepthStencilValue*,
            int,
            VkImageSubresourceRange*,
            void> Invoke = handle;

        public static explicit operator VkCmdClearDepthStencilImage(PfnVkVoidFunction func)
        {
            return new VkCmdClearDepthStencilImage(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkImage,
                    VkImageLayout,
                    VkClearDepthStencilValue*,
                    int,
                    VkImageSubresourceRange*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdClearAttachments(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkClearAttachment*, int, VkClearRect*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkClearAttachment*,
            int,
            VkClearRect*,
            void> Invoke = handle;

        public static explicit operator VkCmdClearAttachments(PfnVkVoidFunction func)
        {
            return new VkCmdClearAttachments(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkClearAttachment*, int, VkClearRect*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdResolveImage(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkImage,
            VkImageLayout,
            int,
            VkImageResolve*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkImage,
            VkImageLayout,
            VkImage,
            VkImageLayout,
            int,
            VkImageResolve*,
            void> Invoke = handle;

        public static explicit operator VkCmdResolveImage(PfnVkVoidFunction func)
        {
            return new VkCmdResolveImage(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkImage,
                    VkImageLayout,
                    VkImage,
                    VkImageLayout,
                    int,
                    VkImageResolve*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginRenderPass(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkRenderPassBeginInfo*,
            VkSubpassContents,
            void> Invoke = handle;

        public static explicit operator VkCmdBeginRenderPass(PfnVkVoidFunction func)
        {
            return new VkCmdBeginRenderPass(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassContents, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdNextSubpass(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassContents, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassContents, void> Invoke = handle;

        public static explicit operator VkCmdNextSubpass(PfnVkVoidFunction func)
        {
            return new VkCmdNextSubpass(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassContents, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRenderPass(delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdEndRenderPass(PfnVkVoidFunction func)
        {
            return new VkCmdEndRenderPass((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkBindBufferMemory2(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindBufferMemoryInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkBindBufferMemoryInfo*, VkResult> Invoke = handle;

        public static explicit operator VkBindBufferMemory2(PfnVkVoidFunction func)
        {
            return new VkBindBufferMemory2(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindBufferMemoryInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindImageMemory2(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindImageMemoryInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkBindImageMemoryInfo*, VkResult> Invoke = handle;

        public static explicit operator VkBindImageMemory2(PfnVkVoidFunction func)
        {
            return new VkBindImageMemory2(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindImageMemoryInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceGroupPeerMemoryFeatures(
        delegate* unmanaged[Cdecl]<VkDevice, int, int, int, VkPeerMemoryFeatureFlags*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, int, int, VkPeerMemoryFeatureFlags*, void> Invoke =
            handle;

        public static explicit operator VkGetDeviceGroupPeerMemoryFeatures(PfnVkVoidFunction func)
        {
            return new VkGetDeviceGroupPeerMemoryFeatures(
                (delegate* unmanaged[Cdecl]<VkDevice, int, int, int, VkPeerMemoryFeatureFlags*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDeviceMask(delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetDeviceMask(PfnVkVoidFunction func)
        {
            return new VkCmdSetDeviceMask((delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceGroups(
        delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDeviceGroupProperties*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            int*,
            VkPhysicalDeviceGroupProperties*,
            VkResult> Invoke = handle;

        public static explicit operator VkEnumeratePhysicalDeviceGroups(PfnVkVoidFunction func)
        {
            return new VkEnumeratePhysicalDeviceGroups(
                (delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDeviceGroupProperties*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageMemoryRequirements2(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageMemoryRequirementsInfo2*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageMemoryRequirements2(PfnVkVoidFunction func)
        {
            return new VkGetImageMemoryRequirements2(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferMemoryRequirements2(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkBufferMemoryRequirementsInfo2*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetBufferMemoryRequirements2(PfnVkVoidFunction func)
        {
            return new VkGetBufferMemoryRequirements2(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSparseMemoryRequirements2(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageSparseMemoryRequirementsInfo2*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageSparseMemoryRequirementsInfo2*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSparseMemoryRequirements2(PfnVkVoidFunction func)
        {
            return new VkGetImageSparseMemoryRequirements2(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkImageSparseMemoryRequirementsInfo2*,
                    int*,
                    VkSparseImageMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFeatures2(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceFeatures2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFeatures2(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceProperties2(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceProperties2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceProperties2(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFormatProperties2(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceFormatProperties2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFormatProperties2(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceImageFormatProperties2(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceImageFormatInfo2*,
            VkImageFormatProperties2*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceImageFormatInfo2*,
            VkImageFormatProperties2*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceImageFormatProperties2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceImageFormatProperties2(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceImageFormatInfo2*,
                    VkImageFormatProperties2*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyProperties2(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyProperties2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceQueueFamilyProperties2(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMemoryProperties2(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceMemoryProperties2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceMemoryProperties2(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSparseImageFormatProperties2(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2*,
            int*,
            VkSparseImageFormatProperties2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2*,
            int*,
            VkSparseImageFormatProperties2*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSparseImageFormatProperties2(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSparseImageFormatProperties2(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceSparseImageFormatInfo2*,
                    int*,
                    VkSparseImageFormatProperties2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkTrimCommandPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> Invoke =
            handle;

        public static explicit operator VkTrimCommandPool(PfnVkVoidFunction func)
        {
            return new VkTrimCommandPool(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceQueue2(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void> Invoke = handle;

        public static explicit operator VkGetDeviceQueue2(PfnVkVoidFunction func)
        {
            return new VkGetDeviceQueue2(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceQueueInfo2*, VkQueue*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalBufferProperties(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalBufferInfo*,
            VkExternalBufferProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalBufferInfo*,
            VkExternalBufferProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalBufferProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalBufferProperties(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalBufferInfo*,
                    VkExternalBufferProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalFenceProperties(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalFenceInfo*,
            VkExternalFenceProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalFenceInfo*,
            VkExternalFenceProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalFenceProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalFenceProperties(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalFenceInfo*,
                    VkExternalFenceProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalSemaphoreProperties(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo*,
            VkExternalSemaphoreProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo*,
            VkExternalSemaphoreProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalSemaphoreProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalSemaphoreProperties(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalSemaphoreInfo*,
                    VkExternalSemaphoreProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDispatchBase(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDispatchBase(PfnVkVoidFunction func)
        {
            return new VkCmdDispatchBase(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDescriptorUpdateTemplate(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorUpdateTemplateCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorUpdateTemplate*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorUpdateTemplateCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorUpdateTemplate*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDescriptorUpdateTemplate(PfnVkVoidFunction func)
        {
            return new VkCreateDescriptorUpdateTemplate(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorUpdateTemplateCreateInfo*,
                    VkAllocationCallbacks*,
                    VkDescriptorUpdateTemplate*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDescriptorUpdateTemplate(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorUpdateTemplate,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDescriptorUpdateTemplate(PfnVkVoidFunction func)
        {
            return new VkDestroyDescriptorUpdateTemplate(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUpdateDescriptorSetWithTemplate(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSet,
            VkDescriptorUpdateTemplate,
            void*,
            void> Invoke = handle;

        public static explicit operator VkUpdateDescriptorSetWithTemplate(PfnVkVoidFunction func)
        {
            return new VkUpdateDescriptorSetWithTemplate(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDescriptorSetLayoutSupport(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayoutCreateInfo*,
            VkDescriptorSetLayoutSupport*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayoutCreateInfo*,
            VkDescriptorSetLayoutSupport*,
            void> Invoke = handle;

        public static explicit operator VkGetDescriptorSetLayoutSupport(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorSetLayoutSupport(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorSetLayoutCreateInfo*,
                    VkDescriptorSetLayoutSupport*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateSamplerYcbcrConversion(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerYCbCrConversionCreateInfo*,
            VkAllocationCallbacks*,
            VkSamplerYCbCrConversion*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerYCbCrConversionCreateInfo*,
            VkAllocationCallbacks*,
            VkSamplerYCbCrConversion*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateSamplerYcbcrConversion(PfnVkVoidFunction func)
        {
            return new VkCreateSamplerYcbcrConversion(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSamplerYCbCrConversionCreateInfo*,
                    VkAllocationCallbacks*,
                    VkSamplerYCbCrConversion*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroySamplerYcbcrConversion(
        delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYCbCrConversion, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerYCbCrConversion,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroySamplerYcbcrConversion(PfnVkVoidFunction func)
        {
            return new VkDestroySamplerYcbcrConversion(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYCbCrConversion, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkResetQueryPool(
        delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, int, int, void> Invoke = handle;

        public static explicit operator VkResetQueryPool(PfnVkVoidFunction func)
        {
            return new VkResetQueryPool((delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, int, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetSemaphoreCounterValue(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint*, VkResult> Invoke = handle;

        public static explicit operator VkGetSemaphoreCounterValue(PfnVkVoidFunction func)
        {
            return new VkGetSemaphoreCounterValue(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWaitSemaphores(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, nint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, nint, VkResult> Invoke = handle;

        public static explicit operator VkWaitSemaphores(PfnVkVoidFunction func)
        {
            return new VkWaitSemaphores(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, nint, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSignalSemaphore(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> Invoke = handle;

        public static explicit operator VkSignalSemaphore(PfnVkVoidFunction func)
        {
            return new VkSignalSemaphore(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferDeviceAddress(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> Invoke =
            handle;

        public static explicit operator VkGetBufferDeviceAddress(PfnVkVoidFunction func)
        {
            return new VkGetBufferDeviceAddress(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferOpaqueCaptureAddress(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, nint> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, nint> Invoke = handle;

        public static explicit operator VkGetBufferOpaqueCaptureAddress(PfnVkVoidFunction func)
        {
            return new VkGetBufferOpaqueCaptureAddress(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, nint>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceMemoryOpaqueCaptureAddress(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, nint> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, nint> Invoke =
            handle;

        public static explicit operator VkGetDeviceMemoryOpaqueCaptureAddress(PfnVkVoidFunction func)
        {
            return new VkGetDeviceMemoryOpaqueCaptureAddress(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, nint>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectCount(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirectCount(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirectCount(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirectCount(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndexedIndirectCount(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexedIndirectCount(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateRenderPass2(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkRenderPassCreateInfo2*,
            VkAllocationCallbacks*,
            VkRenderPass*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkRenderPassCreateInfo2*,
            VkAllocationCallbacks*,
            VkRenderPass*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateRenderPass2(PfnVkVoidFunction func)
        {
            return new VkCreateRenderPass2(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkRenderPassCreateInfo2*,
                    VkAllocationCallbacks*,
                    VkRenderPass*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginRenderPass2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkRenderPassBeginInfo*,
            VkSubpassBeginInfo*,
            void> Invoke = handle;

        public static explicit operator VkCmdBeginRenderPass2(PfnVkVoidFunction func)
        {
            return new VkCmdBeginRenderPass2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdNextSubpass2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkSubpassBeginInfo*,
            VkSubpassEndInfo*,
            void> Invoke = handle;

        public static explicit operator VkCmdNextSubpass2(PfnVkVoidFunction func)
        {
            return new VkCmdNextSubpass2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRenderPass2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> Invoke = handle;

        public static explicit operator VkCmdEndRenderPass2(PfnVkVoidFunction func)
        {
            return new VkCmdEndRenderPass2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceToolProperties(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkPhysicalDeviceToolProperties*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkPhysicalDeviceToolProperties*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceToolProperties(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceToolProperties(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkPhysicalDeviceToolProperties*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreatePrivateDataSlot(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPrivateDataSlotCreateInfo*,
            VkAllocationCallbacks*,
            VkPrivateDataSlot*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPrivateDataSlotCreateInfo*,
            VkAllocationCallbacks*,
            VkPrivateDataSlot*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreatePrivateDataSlot(PfnVkVoidFunction func)
        {
            return new VkCreatePrivateDataSlot(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPrivateDataSlotCreateInfo*,
                    VkAllocationCallbacks*,
                    VkPrivateDataSlot*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyPrivateDataSlot(
        delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyPrivateDataSlot(PfnVkVoidFunction func)
        {
            return new VkDestroyPrivateDataSlot(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetPrivateData(
        delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkObjectType,
            nint,
            VkPrivateDataSlot,
            nint,
            VkResult> Invoke = handle;

        public static explicit operator VkSetPrivateData(PfnVkVoidFunction func)
        {
            return new VkSetPrivateData(
                (delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPrivateData(
        delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkObjectType,
            nint,
            VkPrivateDataSlot,
            nint*,
            void> Invoke = handle;

        public static explicit operator VkGetPrivateData(PfnVkVoidFunction func)
        {
            return new VkGetPrivateData(
                (delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPipelineBarrier2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> Invoke = handle;

        public static explicit operator VkCmdPipelineBarrier2(PfnVkVoidFunction func)
        {
            return new VkCmdPipelineBarrier2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteTimestamp2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags2,
            VkQueryPool,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteTimestamp2(PfnVkVoidFunction func)
        {
            return new VkCmdWriteTimestamp2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueSubmit2(
        delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo2*, VkFence, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo2*, VkFence, VkResult> Invoke = handle;

        public static explicit operator VkQueueSubmit2(PfnVkVoidFunction func)
        {
            return new VkQueueSubmit2(
                (delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo2*, VkFence, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyBuffer2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyBuffer2(PfnVkVoidFunction func)
        {
            return new VkCmdCopyBuffer2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImage2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyImage2(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImage2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyBufferToImage2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyBufferToImage2(PfnVkVoidFunction func)
        {
            return new VkCmdCopyBufferToImage2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImageToBuffer2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyImageToBuffer2(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImageToBuffer2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceBufferMemoryRequirements(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceBufferMemoryRequirements*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceBufferMemoryRequirements(PfnVkVoidFunction func)
        {
            return new VkGetDeviceBufferMemoryRequirements(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceImageMemoryRequirements(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageMemoryRequirements*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceImageMemoryRequirements(PfnVkVoidFunction func)
        {
            return new VkGetDeviceImageMemoryRequirements(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceImageSparseMemoryRequirements(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageMemoryRequirements*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageMemoryRequirements*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceImageSparseMemoryRequirements(PfnVkVoidFunction func)
        {
            return new VkGetDeviceImageSparseMemoryRequirements(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeviceImageMemoryRequirements*,
                    int*,
                    VkSparseImageMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetEvent2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> Invoke = handle;

        public static explicit operator VkCmdSetEvent2(PfnVkVoidFunction func)
        {
            return new VkCmdSetEvent2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdResetEvent2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> Invoke =
            handle;

        public static explicit operator VkCmdResetEvent2(PfnVkVoidFunction func)
        {
            return new VkCmdResetEvent2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWaitEvents2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkEvent*, VkDependencyInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkEvent*, VkDependencyInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdWaitEvents2(PfnVkVoidFunction func)
        {
            return new VkCmdWaitEvents2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkEvent*, VkDependencyInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBlitImage2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdBlitImage2(PfnVkVoidFunction func)
        {
            return new VkCmdBlitImage2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdResolveImage2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdResolveImage2(PfnVkVoidFunction func)
        {
            return new VkCmdResolveImage2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginRendering(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> Invoke = handle;

        public static explicit operator VkCmdBeginRendering(PfnVkVoidFunction func)
        {
            return new VkCmdBeginRendering(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRendering(delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdEndRendering(PfnVkVoidFunction func)
        {
            return new VkCmdEndRendering((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetCullMode(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> Invoke = handle;

        public static explicit operator VkCmdSetCullMode(PfnVkVoidFunction func)
        {
            return new VkCmdSetCullMode(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetFrontFace(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> Invoke = handle;

        public static explicit operator VkCmdSetFrontFace(PfnVkVoidFunction func)
        {
            return new VkCmdSetFrontFace((delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetPrimitiveTopology(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> Invoke = handle;

        public static explicit operator VkCmdSetPrimitiveTopology(PfnVkVoidFunction func)
        {
            return new VkCmdSetPrimitiveTopology(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetViewportWithCount(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkViewport*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkViewport*, void> Invoke = handle;

        public static explicit operator VkCmdSetViewportWithCount(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewportWithCount(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkViewport*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetScissorWithCount(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkRect2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkRect2D*, void> Invoke = handle;

        public static explicit operator VkCmdSetScissorWithCount(PfnVkVoidFunction func)
        {
            return new VkCmdSetScissorWithCount(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkRect2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindVertexBuffers2(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBuffer*,
            ByteSize64*,
            ByteSize64*,
            ByteSize64*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBuffer*,
            ByteSize64*,
            ByteSize64*,
            ByteSize64*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindVertexBuffers2(PfnVkVoidFunction func)
        {
            return new VkCmdBindVertexBuffers2(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    int,
                    VkBuffer*,
                    ByteSize64*,
                    ByteSize64*,
                    ByteSize64*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthTestEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthTestEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthTestEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthWriteEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthWriteEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthWriteEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthCompareOp(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthCompareOp(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthCompareOp(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthBoundsTestEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBoundsTestEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBoundsTestEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilTestEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetStencilTestEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilTestEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilOp(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStencilFaceFlags,
            VkStencilOp,
            VkStencilOp,
            VkStencilOp,
            VkCompareOp,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStencilFaceFlags,
            VkStencilOp,
            VkStencilOp,
            VkStencilOp,
            VkCompareOp,
            void> Invoke = handle;

        public static explicit operator VkCmdSetStencilOp(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilOp(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkStencilFaceFlags,
                    VkStencilOp,
                    VkStencilOp,
                    VkStencilOp,
                    VkCompareOp,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRasterizerDiscardEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetRasterizerDiscardEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetRasterizerDiscardEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthBiasEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBiasEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBiasEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPrimitiveRestartEnable(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetPrimitiveRestartEnable(PfnVkVoidFunction func)
        {
            return new VkCmdSetPrimitiveRestartEnable(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkMapMemory2(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfo*, void**, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfo*, void**, VkResult> Invoke = handle;

        public static explicit operator VkMapMemory2(PfnVkVoidFunction func)
        {
            return new VkMapMemory2(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfo*, void**, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUnmapMemory2(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfo*, VkResult> Invoke = handle;

        public static explicit operator VkUnmapMemory2(PfnVkVoidFunction func)
        {
            return new VkUnmapMemory2((delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfo*, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetDeviceImageSubresourceLayout(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageSubresourceInfo*,
            VkSubresourceLayout2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceImageSubresourceLayout(PfnVkVoidFunction func)
        {
            return new VkGetDeviceImageSubresourceLayout(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSubresourceLayout2(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImage,
            VkImageSubresource2*,
            VkSubresourceLayout2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSubresourceLayout2(PfnVkVoidFunction func)
        {
            return new VkGetImageSubresourceLayout2(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyMemoryToImage(
        delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfo*, VkResult> Invoke = handle;

        public static explicit operator VkCopyMemoryToImage(PfnVkVoidFunction func)
        {
            return new VkCopyMemoryToImage(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyImageToMemory(
        delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfo*, VkResult> Invoke = handle;

        public static explicit operator VkCopyImageToMemory(PfnVkVoidFunction func)
        {
            return new VkCopyImageToMemory(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyImageToImage(
        delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfo*, VkResult> Invoke = handle;

        public static explicit operator VkCopyImageToImage(PfnVkVoidFunction func)
        {
            return new VkCopyImageToImage(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkTransitionImageLayout(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkHostImageLayoutTransitionInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkHostImageLayoutTransitionInfo*, VkResult> Invoke =
            handle;

        public static explicit operator VkTransitionImageLayout(PfnVkVoidFunction func)
        {
            return new VkTransitionImageLayout(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkHostImageLayoutTransitionInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSet(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            VkWriteDescriptorSet*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            VkWriteDescriptorSet*,
            void> Invoke = handle;

        public static explicit operator VkCmdPushDescriptorSet(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSet(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkPipelineBindPoint,
                    VkPipelineLayout,
                    int,
                    int,
                    VkWriteDescriptorSet*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetWithTemplate(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDescriptorUpdateTemplate,
            VkPipelineLayout,
            int,
            void*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDescriptorUpdateTemplate,
            VkPipelineLayout,
            int,
            void*,
            void> Invoke = handle;

        public static explicit operator VkCmdPushDescriptorSetWithTemplate(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSetWithTemplate(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkDescriptorUpdateTemplate,
                    VkPipelineLayout,
                    int,
                    void*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindDescriptorSets2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> Invoke = handle;

        public static explicit operator VkCmdBindDescriptorSets2(PfnVkVoidFunction func)
        {
            return new VkCmdBindDescriptorSets2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorSetsInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushConstants2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushConstantsInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushConstantsInfo*, void> Invoke = handle;

        public static explicit operator VkCmdPushConstants2(PfnVkVoidFunction func)
        {
            return new VkCmdPushConstants2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushConstantsInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSet2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetInfo*, void> Invoke = handle;

        public static explicit operator VkCmdPushDescriptorSet2(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSet2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetWithTemplate2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdPushDescriptorSetWithTemplate2(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSetWithTemplate2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLineStipple(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void> Invoke = handle;

        public static explicit operator VkCmdSetLineStipple(PfnVkVoidFunction func)
        {
            return new VkCmdSetLineStipple((delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdBindIndexBuffer2(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, VkIndexType, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkIndexType,
            void> Invoke = handle;

        public static explicit operator VkCmdBindIndexBuffer2(PfnVkVoidFunction func)
        {
            return new VkCmdBindIndexBuffer2(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, VkIndexType, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRenderingAreaGranularity(
        delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> Invoke = handle;

        public static explicit operator VkGetRenderingAreaGranularity(PfnVkVoidFunction func)
        {
            return new VkGetRenderingAreaGranularity(
                (delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRenderingAttachmentLocations(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetRenderingAttachmentLocations(PfnVkVoidFunction func)
        {
            return new VkCmdSetRenderingAttachmentLocations(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRenderingInputAttachmentIndices(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetRenderingInputAttachmentIndices(PfnVkVoidFunction func)
        {
            return new VkCmdSetRenderingInputAttachmentIndices(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroySurfaceKHR(
        delegate* unmanaged[Cdecl]<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroySurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkDestroySurfaceKHR(
                (delegate* unmanaged[Cdecl]<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceSupportKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkSurfaceKHR, Brutal.Bool32*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            VkSurfaceKHR,
            Brutal.Bool32*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfaceSupportKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfaceSupportKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkSurfaceKHR, Brutal.Bool32*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceCapabilitiesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkSurfaceKHR,
            VkSurfaceCapabilitiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfaceCapabilitiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfaceCapabilitiesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceFormatsKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkSurfaceFormatKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkSurfaceKHR,
            int*,
            VkSurfaceFormatKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfaceFormatsKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfaceFormatsKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkSurfaceFormatKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfacePresentModesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkPresentModeKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkSurfaceKHR,
            int*,
            VkPresentModeKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfacePresentModesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfacePresentModesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkPresentModeKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateSwapchainKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSwapchainKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSwapchainKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateSwapchainKHR(PfnVkVoidFunction func)
        {
            return new VkCreateSwapchainKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSwapchainCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSwapchainKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroySwapchainKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroySwapchainKHR(PfnVkVoidFunction func)
        {
            return new VkDestroySwapchainKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSwapchainImagesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int*, VkImage*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int*, VkImage*, VkResult> Invoke = handle;

        public static explicit operator VkGetSwapchainImagesKHR(PfnVkVoidFunction func)
        {
            return new VkGetSwapchainImagesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int*, VkImage*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireNextImageKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, nint, VkSemaphore, VkFence, int*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            nint,
            VkSemaphore,
            VkFence,
            int*,
            VkResult> Invoke = handle;

        public static explicit operator VkAcquireNextImageKHR(PfnVkVoidFunction func)
        {
            return new VkAcquireNextImageKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, nint, VkSemaphore, VkFence, int*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueuePresentKHR(
        delegate* unmanaged[Cdecl]<VkQueue, VkPresentInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkPresentInfoKHR*, VkResult> Invoke = handle;

        public static explicit operator VkQueuePresentKHR(PfnVkVoidFunction func)
        {
            return new VkQueuePresentKHR((delegate* unmanaged[Cdecl]<VkQueue, VkPresentInfoKHR*, VkResult>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetDeviceGroupPresentCapabilitiesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetDeviceGroupPresentCapabilitiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceGroupPresentCapabilitiesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceGroupSurfacePresentModesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSurfaceKHR,
            VkDeviceGroupPresentModeFlagsKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDeviceGroupSurfacePresentModesKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceGroupSurfacePresentModesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDevicePresentRectanglesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkRect2D*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkRect2D*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDevicePresentRectanglesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDevicePresentRectanglesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, int*, VkRect2D*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireNextImage2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, int*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, int*, VkResult> Invoke =
            handle;

        public static explicit operator VkAcquireNextImage2KHR(PfnVkVoidFunction func)
        {
            return new VkAcquireNextImage2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAcquireNextImageInfoKHR*, int*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceDisplayPropertiesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPropertiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPropertiesKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceDisplayPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceDisplayPropertiesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPropertiesKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceDisplayPlanePropertiesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPlanePropertiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkDisplayPlanePropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceDisplayPlanePropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceDisplayPlanePropertiesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPlanePropertiesKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDisplayPlaneSupportedDisplaysKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int*, VkDisplayKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int*, VkDisplayKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetDisplayPlaneSupportedDisplaysKHR(PfnVkVoidFunction func)
        {
            return new VkGetDisplayPlaneSupportedDisplaysKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int*, VkDisplayKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDisplayModePropertiesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, int*, VkDisplayModePropertiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayKHR,
            int*,
            VkDisplayModePropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDisplayModePropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetDisplayModePropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkDisplayKHR,
                    int*,
                    VkDisplayModePropertiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDisplayModeKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayKHR,
            VkDisplayModeCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkDisplayModeKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayKHR,
            VkDisplayModeCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkDisplayModeKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDisplayModeKHR(PfnVkVoidFunction func)
        {
            return new VkCreateDisplayModeKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkDisplayKHR,
                    VkDisplayModeCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkDisplayModeKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDisplayPlaneCapabilitiesKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayModeKHR,
            int,
            VkDisplayPlaneCapabilitiesKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayModeKHR,
            int,
            VkDisplayPlaneCapabilitiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDisplayPlaneCapabilitiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetDisplayPlaneCapabilitiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkDisplayModeKHR,
                    int,
                    VkDisplayPlaneCapabilitiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDisplayPlaneSurfaceKHR(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDisplaySurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDisplaySurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDisplayPlaneSurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkCreateDisplayPlaneSurfaceKHR(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkDisplaySurfaceCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateSharedSwapchainsKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkSwapchainCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSwapchainKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkSwapchainCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSwapchainKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateSharedSwapchainsKHR(PfnVkVoidFunction func)
        {
            return new VkCreateSharedSwapchainsKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    int,
                    VkSwapchainCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSwapchainKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceVideoCapabilitiesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkVideoProfileInfoKHR*,
            VkVideoCapabilitiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceVideoCapabilitiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceVideoCapabilitiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkVideoProfileInfoKHR*,
                    VkVideoCapabilitiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceVideoFormatPropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceVideoFormatInfoKHR*,
            int*,
            VkVideoFormatPropertiesKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceVideoFormatInfoKHR*,
            int*,
            VkVideoFormatPropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceVideoFormatPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceVideoFormatPropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceVideoFormatInfoKHR*,
                    int*,
                    VkVideoFormatPropertiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateVideoSessionKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkVideoSessionKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkVideoSessionKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateVideoSessionKHR(PfnVkVoidFunction func)
        {
            return new VkCreateVideoSessionKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkVideoSessionCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkVideoSessionKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyVideoSessionKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyVideoSessionKHR(PfnVkVoidFunction func)
        {
            return new VkDestroyVideoSessionKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetVideoSessionMemoryRequirementsKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionKHR,
            int*,
            VkVideoSessionMemoryRequirementsKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionKHR,
            int*,
            VkVideoSessionMemoryRequirementsKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetVideoSessionMemoryRequirementsKHR(PfnVkVoidFunction func)
        {
            return new VkGetVideoSessionMemoryRequirementsKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkVideoSessionKHR,
                    int*,
                    VkVideoSessionMemoryRequirementsKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindVideoSessionMemoryKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionKHR, int, VkBindVideoSessionMemoryInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionKHR,
            int,
            VkBindVideoSessionMemoryInfoKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkBindVideoSessionMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkBindVideoSessionMemoryKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkVideoSessionKHR,
                    int,
                    VkBindVideoSessionMemoryInfoKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateVideoSessionParametersKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionParametersCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkVideoSessionParametersKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionParametersCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkVideoSessionParametersKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateVideoSessionParametersKHR(PfnVkVoidFunction func)
        {
            return new VkCreateVideoSessionParametersKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkVideoSessionParametersCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkVideoSessionParametersKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUpdateVideoSessionParametersKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionParametersKHR,
            VkVideoSessionParametersUpdateInfoKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionParametersKHR,
            VkVideoSessionParametersUpdateInfoKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkUpdateVideoSessionParametersKHR(PfnVkVoidFunction func)
        {
            return new VkUpdateVideoSessionParametersKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkVideoSessionParametersKHR,
                    VkVideoSessionParametersUpdateInfoKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyVideoSessionParametersKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoSessionParametersKHR,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyVideoSessionParametersKHR(PfnVkVoidFunction func)
        {
            return new VkDestroyVideoSessionParametersKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginVideoCodingKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdBeginVideoCodingKHR(PfnVkVoidFunction func)
        {
            return new VkCmdBeginVideoCodingKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndVideoCodingKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdEndVideoCodingKHR(PfnVkVoidFunction func)
        {
            return new VkCmdEndVideoCodingKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdControlVideoCodingKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdControlVideoCodingKHR(PfnVkVoidFunction func)
        {
            return new VkCmdControlVideoCodingKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDecodeVideoKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDecodeVideoKHR(PfnVkVoidFunction func)
        {
            return new VkCmdDecodeVideoKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginRenderingKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void> Invoke = handle;

        public static explicit operator VkCmdBeginRenderingKHR(PfnVkVoidFunction func)
        {
            return new VkCmdBeginRenderingKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRenderingKHR(delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdEndRenderingKHR(PfnVkVoidFunction func)
        {
            return new VkCmdEndRenderingKHR((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFeatures2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceFeatures2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFeatures2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceProperties2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFormatProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceFormatProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFormatProperties2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceImageFormatProperties2KHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceImageFormatInfo2*,
            VkImageFormatProperties2*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceImageFormatInfo2*,
            VkImageFormatProperties2*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceImageFormatProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceImageFormatProperties2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceImageFormatInfo2*,
                    VkImageFormatProperties2*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceQueueFamilyProperties2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkQueueFamilyProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMemoryProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceMemoryProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceMemoryProperties2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSparseImageFormatProperties2KHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2*,
            int*,
            VkSparseImageFormatProperties2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2*,
            int*,
            VkSparseImageFormatProperties2*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSparseImageFormatProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSparseImageFormatProperties2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceSparseImageFormatInfo2*,
                    int*,
                    VkSparseImageFormatProperties2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceGroupPeerMemoryFeaturesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, int, int, int, VkPeerMemoryFeatureFlags*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, int, int, VkPeerMemoryFeatureFlags*, void> Invoke =
            handle;

        public static explicit operator VkGetDeviceGroupPeerMemoryFeaturesKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceGroupPeerMemoryFeaturesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, int, int, int, VkPeerMemoryFeatureFlags*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDeviceMaskKHR(delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetDeviceMaskKHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetDeviceMaskKHR((delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdDispatchBaseKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDispatchBaseKHR(PfnVkVoidFunction func)
        {
            return new VkCmdDispatchBaseKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, int, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkTrimCommandPoolKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> Invoke =
            handle;

        public static explicit operator VkTrimCommandPoolKHR(PfnVkVoidFunction func)
        {
            return new VkTrimCommandPoolKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceGroupsKHR(
        delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDeviceGroupProperties*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            int*,
            VkPhysicalDeviceGroupProperties*,
            VkResult> Invoke = handle;

        public static explicit operator VkEnumeratePhysicalDeviceGroupsKHR(PfnVkVoidFunction func)
        {
            return new VkEnumeratePhysicalDeviceGroupsKHR(
                (delegate* unmanaged[Cdecl]<VkInstance, int*, VkPhysicalDeviceGroupProperties*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalBufferPropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalBufferInfo*,
            VkExternalBufferProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalBufferInfo*,
            VkExternalBufferProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalBufferPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalBufferPropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalBufferInfo*,
                    VkExternalBufferProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryFdKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryFdKHR(PfnVkVoidFunction func)
        {
            return new VkGetMemoryFdKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryFdPropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            int,
            VkMemoryFdPropertiesKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            int,
            VkMemoryFdPropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryFdPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetMemoryFdPropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkExternalMemoryHandleTypeFlags,
                    int,
                    VkMemoryFdPropertiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalSemaphorePropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo*,
            VkExternalSemaphoreProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo*,
            VkExternalSemaphoreProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalSemaphorePropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalSemaphorePropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalSemaphoreInfo*,
                    VkExternalSemaphoreProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkImportSemaphoreFdKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> Invoke = handle;

        public static explicit operator VkImportSemaphoreFdKHR(PfnVkVoidFunction func)
        {
            return new VkImportSemaphoreFdKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSemaphoreFdKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> Invoke = handle;

        public static explicit operator VkGetSemaphoreFdKHR(PfnVkVoidFunction func)
        {
            return new VkGetSemaphoreFdKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            VkWriteDescriptorSet*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            VkWriteDescriptorSet*,
            void> Invoke = handle;

        public static explicit operator VkCmdPushDescriptorSetKHR(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSetKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkPipelineBindPoint,
                    VkPipelineLayout,
                    int,
                    int,
                    VkWriteDescriptorSet*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetWithTemplateKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDescriptorUpdateTemplate,
            VkPipelineLayout,
            int,
            void*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDescriptorUpdateTemplate,
            VkPipelineLayout,
            int,
            void*,
            void> Invoke = handle;

        public static explicit operator VkCmdPushDescriptorSetWithTemplateKHR(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSetWithTemplateKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkDescriptorUpdateTemplate,
                    VkPipelineLayout,
                    int,
                    void*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDescriptorUpdateTemplateKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorUpdateTemplateCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorUpdateTemplate*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorUpdateTemplateCreateInfo*,
            VkAllocationCallbacks*,
            VkDescriptorUpdateTemplate*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDescriptorUpdateTemplateKHR(PfnVkVoidFunction func)
        {
            return new VkCreateDescriptorUpdateTemplateKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorUpdateTemplateCreateInfo*,
                    VkAllocationCallbacks*,
                    VkDescriptorUpdateTemplate*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDescriptorUpdateTemplateKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorUpdateTemplate,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDescriptorUpdateTemplateKHR(PfnVkVoidFunction func)
        {
            return new VkDestroyDescriptorUpdateTemplateKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUpdateDescriptorSetWithTemplateKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSet,
            VkDescriptorUpdateTemplate,
            void*,
            void> Invoke = handle;

        public static explicit operator VkUpdateDescriptorSetWithTemplateKHR(PfnVkVoidFunction func)
        {
            return new VkUpdateDescriptorSetWithTemplateKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateRenderPass2KHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkRenderPassCreateInfo2*,
            VkAllocationCallbacks*,
            VkRenderPass*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkRenderPassCreateInfo2*,
            VkAllocationCallbacks*,
            VkRenderPass*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateRenderPass2KHR(PfnVkVoidFunction func)
        {
            return new VkCreateRenderPass2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkRenderPassCreateInfo2*,
                    VkAllocationCallbacks*,
                    VkRenderPass*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginRenderPass2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkRenderPassBeginInfo*,
            VkSubpassBeginInfo*,
            void> Invoke = handle;

        public static explicit operator VkCmdBeginRenderPass2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdBeginRenderPass2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdNextSubpass2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkSubpassBeginInfo*,
            VkSubpassEndInfo*,
            void> Invoke = handle;

        public static explicit operator VkCmdNextSubpass2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdNextSubpass2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRenderPass2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void> Invoke = handle;

        public static explicit operator VkCmdEndRenderPass2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdEndRenderPass2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSubpassEndInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSwapchainStatusKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> Invoke = handle;

        public static explicit operator VkGetSwapchainStatusKHR(PfnVkVoidFunction func)
        {
            return new VkGetSwapchainStatusKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalFencePropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalFenceInfo*,
            VkExternalFenceProperties*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalFenceInfo*,
            VkExternalFenceProperties*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalFencePropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalFencePropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalFenceInfo*,
                    VkExternalFenceProperties*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkImportFenceFdKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceFdInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceFdInfoKHR*, VkResult> Invoke = handle;

        public static explicit operator VkImportFenceFdKHR(PfnVkVoidFunction func)
        {
            return new VkImportFenceFdKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceFdInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetFenceFdKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> Invoke = handle;

        public static explicit operator VkGetFenceFdKHR(PfnVkVoidFunction func)
        {
            return new VkGetFenceFdKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            int*,
            VkPerformanceCounterKHR*,
            VkPerformanceCounterDescriptionKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            int*,
            VkPerformanceCounterKHR*,
            VkPerformanceCounterDescriptionKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
            PfnVkVoidFunction func
        )
        {
            return new VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int,
                    int*,
                    VkPerformanceCounterKHR*,
                    VkPerformanceCounterDescriptionKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, int*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkQueryPoolPerformanceCreateInfoKHR*,
            int*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, int*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireProfilingLockKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> Invoke = handle;

        public static explicit operator VkAcquireProfilingLockKHR(PfnVkVoidFunction func)
        {
            return new VkAcquireProfilingLockKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleaseProfilingLockKHR(delegate* unmanaged[Cdecl]<VkDevice, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, void> Invoke = handle;

        public static explicit operator VkReleaseProfilingLockKHR(PfnVkVoidFunction func)
        {
            return new VkReleaseProfilingLockKHR((delegate* unmanaged[Cdecl]<VkDevice, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceCapabilities2KHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            VkSurfaceCapabilities2KHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            VkSurfaceCapabilities2KHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfaceCapabilities2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfaceCapabilities2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceSurfaceInfo2KHR*,
                    VkSurfaceCapabilities2KHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceFormats2KHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            int*,
            VkSurfaceFormat2KHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            int*,
            VkSurfaceFormat2KHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfaceFormats2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfaceFormats2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceSurfaceInfo2KHR*,
                    int*,
                    VkSurfaceFormat2KHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceDisplayProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayProperties2KHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayProperties2KHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetPhysicalDeviceDisplayProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceDisplayProperties2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayProperties2KHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceDisplayPlaneProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPlaneProperties2KHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkDisplayPlaneProperties2KHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceDisplayPlaneProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceDisplayPlaneProperties2KHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkDisplayPlaneProperties2KHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDisplayModeProperties2KHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, int*, VkDisplayModeProperties2KHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayKHR,
            int*,
            VkDisplayModeProperties2KHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDisplayModeProperties2KHR(PfnVkVoidFunction func)
        {
            return new VkGetDisplayModeProperties2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkDisplayKHR,
                    int*,
                    VkDisplayModeProperties2KHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDisplayPlaneCapabilities2KHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayPlaneInfo2KHR*,
            VkDisplayPlaneCapabilities2KHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkDisplayPlaneInfo2KHR*,
            VkDisplayPlaneCapabilities2KHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDisplayPlaneCapabilities2KHR(PfnVkVoidFunction func)
        {
            return new VkGetDisplayPlaneCapabilities2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkDisplayPlaneInfo2KHR*,
                    VkDisplayPlaneCapabilities2KHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageMemoryRequirements2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageMemoryRequirementsInfo2*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageMemoryRequirements2KHR(PfnVkVoidFunction func)
        {
            return new VkGetImageMemoryRequirements2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferMemoryRequirements2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkBufferMemoryRequirementsInfo2*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetBufferMemoryRequirements2KHR(PfnVkVoidFunction func)
        {
            return new VkGetBufferMemoryRequirements2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSparseMemoryRequirements2KHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageSparseMemoryRequirementsInfo2*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageSparseMemoryRequirementsInfo2*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSparseMemoryRequirements2KHR(PfnVkVoidFunction func)
        {
            return new VkGetImageSparseMemoryRequirements2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkImageSparseMemoryRequirementsInfo2*,
                    int*,
                    VkSparseImageMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateSamplerYcbcrConversionKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerYCbCrConversionCreateInfo*,
            VkAllocationCallbacks*,
            VkSamplerYCbCrConversion*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerYCbCrConversionCreateInfo*,
            VkAllocationCallbacks*,
            VkSamplerYCbCrConversion*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateSamplerYcbcrConversionKHR(PfnVkVoidFunction func)
        {
            return new VkCreateSamplerYcbcrConversionKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSamplerYCbCrConversionCreateInfo*,
                    VkAllocationCallbacks*,
                    VkSamplerYCbCrConversion*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroySamplerYcbcrConversionKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYCbCrConversion, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerYCbCrConversion,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroySamplerYcbcrConversionKHR(PfnVkVoidFunction func)
        {
            return new VkDestroySamplerYcbcrConversionKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSamplerYCbCrConversion, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindBufferMemory2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindBufferMemoryInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkBindBufferMemoryInfo*, VkResult> Invoke = handle;

        public static explicit operator VkBindBufferMemory2KHR(PfnVkVoidFunction func)
        {
            return new VkBindBufferMemory2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindBufferMemoryInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindImageMemory2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindImageMemoryInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkBindImageMemoryInfo*, VkResult> Invoke = handle;

        public static explicit operator VkBindImageMemory2KHR(PfnVkVoidFunction func)
        {
            return new VkBindImageMemory2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindImageMemoryInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDescriptorSetLayoutSupportKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayoutCreateInfo*,
            VkDescriptorSetLayoutSupport*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetLayoutCreateInfo*,
            VkDescriptorSetLayoutSupport*,
            void> Invoke = handle;

        public static explicit operator VkGetDescriptorSetLayoutSupportKHR(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorSetLayoutSupportKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorSetLayoutCreateInfo*,
                    VkDescriptorSetLayoutSupport*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectCountKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirectCountKHR(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirectCountKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirectCountKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndexedIndirectCountKHR(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexedIndirectCountKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSemaphoreCounterValueKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint*, VkResult> Invoke = handle;

        public static explicit operator VkGetSemaphoreCounterValueKHR(PfnVkVoidFunction func)
        {
            return new VkGetSemaphoreCounterValueKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWaitSemaphoresKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, nint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, nint, VkResult> Invoke = handle;

        public static explicit operator VkWaitSemaphoresKHR(PfnVkVoidFunction func)
        {
            return new VkWaitSemaphoresKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, nint, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSignalSemaphoreKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> Invoke = handle;

        public static explicit operator VkSignalSemaphoreKHR(PfnVkVoidFunction func)
        {
            return new VkSignalSemaphoreKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFragmentShadingRatesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkPhysicalDeviceFragmentShadingRateKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceFragmentShadingRatesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceFragmentShadingRatesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetFragmentShadingRateKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkExtent2D*,
            VkFragmentShadingRateCombinerOpKHR*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetFragmentShadingRateKHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetFragmentShadingRateKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRenderingAttachmentLocationsKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetRenderingAttachmentLocationsKHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetRenderingAttachmentLocationsKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingAttachmentLocationInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRenderingInputAttachmentIndicesKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetRenderingInputAttachmentIndicesKHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetRenderingInputAttachmentIndicesKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingInputAttachmentIndexInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWaitForPresentKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, nint, nint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, nint, nint, VkResult> Invoke = handle;

        public static explicit operator VkWaitForPresentKHR(PfnVkVoidFunction func)
        {
            return new VkWaitForPresentKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, nint, nint, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferDeviceAddressKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> Invoke =
            handle;

        public static explicit operator VkGetBufferDeviceAddressKHR(PfnVkVoidFunction func)
        {
            return new VkGetBufferDeviceAddressKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferOpaqueCaptureAddressKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, nint> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, nint> Invoke = handle;

        public static explicit operator VkGetBufferOpaqueCaptureAddressKHR(PfnVkVoidFunction func)
        {
            return new VkGetBufferOpaqueCaptureAddressKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, nint>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceMemoryOpaqueCaptureAddressKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, nint> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, nint> Invoke =
            handle;

        public static explicit operator VkGetDeviceMemoryOpaqueCaptureAddressKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceMemoryOpaqueCaptureAddressKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, nint>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDeferredOperationKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAllocationCallbacks*,
            VkDeferredOperationKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDeferredOperationKHR(PfnVkVoidFunction func)
        {
            return new VkCreateDeferredOperationKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDeferredOperationKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDeferredOperationKHR(PfnVkVoidFunction func)
        {
            return new VkDestroyDeferredOperationKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeferredOperationMaxConcurrencyKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, int> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, int> Invoke = handle;

        public static explicit operator VkGetDeferredOperationMaxConcurrencyKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeferredOperationMaxConcurrencyKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, int>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeferredOperationResultKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> Invoke = handle;

        public static explicit operator VkGetDeferredOperationResultKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeferredOperationResultKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDeferredOperationJoinKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> Invoke = handle;

        public static explicit operator VkDeferredOperationJoinKHR(PfnVkVoidFunction func)
        {
            return new VkDeferredOperationJoinKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineExecutablePropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineInfoKHR*,
            int*,
            VkPipelineExecutablePropertiesKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineInfoKHR*,
            int*,
            VkPipelineExecutablePropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPipelineExecutablePropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPipelineExecutablePropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineInfoKHR*,
                    int*,
                    VkPipelineExecutablePropertiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineExecutableStatisticsKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineExecutableInfoKHR*,
            int*,
            VkPipelineExecutableStatisticKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineExecutableInfoKHR*,
            int*,
            VkPipelineExecutableStatisticKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPipelineExecutableStatisticsKHR(PfnVkVoidFunction func)
        {
            return new VkGetPipelineExecutableStatisticsKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineExecutableInfoKHR*,
                    int*,
                    VkPipelineExecutableStatisticKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineExecutableInternalRepresentationsKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineExecutableInfoKHR*,
            int*,
            VkPipelineExecutableInternalRepresentationKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineExecutableInfoKHR*,
            int*,
            VkPipelineExecutableInternalRepresentationKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPipelineExecutableInternalRepresentationsKHR(PfnVkVoidFunction func)
        {
            return new VkGetPipelineExecutableInternalRepresentationsKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineExecutableInfoKHR*,
                    int*,
                    VkPipelineExecutableInternalRepresentationKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkMapMemory2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfo*, void**, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfo*, void**, VkResult> Invoke = handle;

        public static explicit operator VkMapMemory2KHR(PfnVkVoidFunction func)
        {
            return new VkMapMemory2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryMapInfo*, void**, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUnmapMemory2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfo*, VkResult> Invoke = handle;

        public static explicit operator VkUnmapMemory2KHR(PfnVkVoidFunction func)
        {
            return new VkUnmapMemory2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryUnmapInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*,
            VkVideoEncodeQualityLevelPropertiesKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*,
            VkVideoEncodeQualityLevelPropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceVideoEncodeQualityLevelPropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR*,
                    VkVideoEncodeQualityLevelPropertiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetEncodedVideoSessionParametersKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoEncodeSessionParametersGetInfoKHR*,
            VkVideoEncodeSessionParametersFeedbackInfoKHR*,
            nuint*,
            void*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkVideoEncodeSessionParametersGetInfoKHR*,
            VkVideoEncodeSessionParametersFeedbackInfoKHR*,
            nuint*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetEncodedVideoSessionParametersKHR(PfnVkVoidFunction func)
        {
            return new VkGetEncodedVideoSessionParametersKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkVideoEncodeSessionParametersGetInfoKHR*,
                    VkVideoEncodeSessionParametersFeedbackInfoKHR*,
                    nuint*,
                    void*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEncodeVideoKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEncodeInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEncodeInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdEncodeVideoKHR(PfnVkVoidFunction func)
        {
            return new VkCmdEncodeVideoKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoEncodeInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetEvent2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> Invoke = handle;

        public static explicit operator VkCmdSetEvent2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetEvent2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdResetEvent2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> Invoke =
            handle;

        public static explicit operator VkCmdResetEvent2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdResetEvent2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWaitEvents2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkEvent*, VkDependencyInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkEvent*, VkDependencyInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdWaitEvents2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdWaitEvents2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkEvent*, VkDependencyInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPipelineBarrier2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void> Invoke = handle;

        public static explicit operator VkCmdPipelineBarrier2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdPipelineBarrier2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDependencyInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteTimestamp2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags2,
            VkQueryPool,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteTimestamp2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdWriteTimestamp2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueSubmit2KHR(
        delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo2*, VkFence, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo2*, VkFence, VkResult> Invoke = handle;

        public static explicit operator VkQueueSubmit2KHR(PfnVkVoidFunction func)
        {
            return new VkQueueSubmit2KHR(
                (delegate* unmanaged[Cdecl]<VkQueue, int, VkSubmitInfo2*, VkFence, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindIndexBuffer3KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindIndexBuffer3InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindIndexBuffer3InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdBindIndexBuffer3KHR(PfnVkVoidFunction func)
        {
            return new VkCmdBindIndexBuffer3KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindIndexBuffer3InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindVertexBuffers3KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindVertexBuffer3InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBindVertexBuffer3InfoKHR*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindVertexBuffers3KHR(PfnVkVoidFunction func)
        {
            return new VkCmdBindVertexBuffers3KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindVertexBuffer3InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirect2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirect2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirect2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirect2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDrawIndexedIndirect2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexedIndirect2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDispatchIndirect2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchIndirect2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchIndirect2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDispatchIndirect2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdDispatchIndirect2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchIndirect2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdCopyMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryToImageKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryImageInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryImageInfoKHR*, void> Invoke =
            handle;

        public static explicit operator VkCmdCopyMemoryToImageKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryToImageKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryImageInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImageToMemoryKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryImageInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryImageInfoKHR*, void> Invoke =
            handle;

        public static explicit operator VkCmdCopyImageToMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImageToMemoryKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyDeviceMemoryImageInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdUpdateMemoryKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddressRangeKHR*,
            VkAddressCommandFlagsKHR,
            ByteSize64,
            void*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddressRangeKHR*,
            VkAddressCommandFlagsKHR,
            ByteSize64,
            void*,
            void> Invoke = handle;

        public static explicit operator VkCmdUpdateMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCmdUpdateMemoryKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkDeviceAddressRangeKHR*,
                    VkAddressCommandFlagsKHR,
                    ByteSize64,
                    void*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdFillMemoryKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddressRangeKHR*,
            VkAddressCommandFlagsKHR,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddressRangeKHR*,
            VkAddressCommandFlagsKHR,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdFillMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCmdFillMemoryKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkDeviceAddressRangeKHR*,
                    VkAddressCommandFlagsKHR,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyQueryPoolResultsToMemoryKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkQueryPool,
            int,
            int,
            VkStridedDeviceAddressRangeKHR*,
            VkAddressCommandFlagsKHR,
            VkQueryResultFlags,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkQueryPool,
            int,
            int,
            VkStridedDeviceAddressRangeKHR*,
            VkAddressCommandFlagsKHR,
            VkQueryResultFlags,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyQueryPoolResultsToMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyQueryPoolResultsToMemoryKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkQueryPool,
                    int,
                    int,
                    VkStridedDeviceAddressRangeKHR*,
                    VkAddressCommandFlagsKHR,
                    VkQueryResultFlags,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectCount2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirectCount2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirectCount2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirectCount2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDrawIndexedIndirectCount2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexedIndirectCount2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginConditionalRendering2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfo2EXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfo2EXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdBeginConditionalRendering2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginConditionalRendering2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfo2EXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindTransformFeedbackBuffers2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindTransformFeedbackBuffer2InfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBindTransformFeedbackBuffer2InfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindTransformFeedbackBuffers2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindTransformFeedbackBuffers2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindTransformFeedbackBuffer2InfoEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginTransformFeedback2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindTransformFeedbackBuffer2InfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBindTransformFeedbackBuffer2InfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdBeginTransformFeedback2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginTransformFeedback2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindTransformFeedbackBuffer2InfoEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndTransformFeedback2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindTransformFeedbackBuffer2InfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBindTransformFeedbackBuffer2InfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdEndTransformFeedback2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdEndTransformFeedback2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBindTransformFeedbackBuffer2InfoEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectByteCount2EXT(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBindTransformFeedbackBuffer2InfoEXT*,
            int,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBindTransformFeedbackBuffer2InfoEXT*,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirectByteCount2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirectByteCount2EXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    int,
                    VkBindTransformFeedbackBuffer2InfoEXT*,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirect2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDrawMeshTasksIndirect2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksIndirect2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirect2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectCount2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdDrawMeshTasksIndirectCount2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksIndirectCount2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDrawIndirectCount2InfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteMarkerToMemoryAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkMemoryMarkerInfoAMD*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkMemoryMarkerInfoAMD*, void> Invoke = handle;

        public static explicit operator VkCmdWriteMarkerToMemoryAMD(PfnVkVoidFunction func)
        {
            return new VkCmdWriteMarkerToMemoryAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkMemoryMarkerInfoAMD*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateAccelerationStructure2KHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCreateInfo2KHR*,
            VkAllocationCallbacks*,
            VkAccelerationStructureKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCreateInfo2KHR*,
            VkAllocationCallbacks*,
            VkAccelerationStructureKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateAccelerationStructure2KHR(PfnVkVoidFunction func)
        {
            return new VkCreateAccelerationStructure2KHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureCreateInfo2KHR*,
                    VkAllocationCallbacks*,
                    VkAccelerationStructureKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyBuffer2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyBuffer2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyBuffer2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImage2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyImage2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImage2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyBufferToImage2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyBufferToImage2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyBufferToImage2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyImageToBuffer2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdCopyImageToBuffer2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyImageToBuffer2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBlitImage2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdBlitImage2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdBlitImage2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBlitImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdResolveImage2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void> Invoke = handle;

        public static explicit operator VkCmdResolveImage2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdResolveImage2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkResolveImageInfo2*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdTraceRaysIndirect2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void> Invoke = handle;

        public static explicit operator VkCmdTraceRaysIndirect2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdTraceRaysIndirect2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceBufferMemoryRequirementsKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceBufferMemoryRequirements*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceBufferMemoryRequirementsKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceBufferMemoryRequirementsKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceImageMemoryRequirementsKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageMemoryRequirements*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceImageMemoryRequirementsKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceImageMemoryRequirementsKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceImageSparseMemoryRequirementsKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageMemoryRequirements*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageMemoryRequirements*,
            int*,
            VkSparseImageMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceImageSparseMemoryRequirementsKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceImageSparseMemoryRequirementsKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeviceImageMemoryRequirements*,
                    int*,
                    VkSparseImageMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindIndexBuffer2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, VkIndexType, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkIndexType,
            void> Invoke = handle;

        public static explicit operator VkCmdBindIndexBuffer2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdBindIndexBuffer2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, ByteSize64, VkIndexType, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRenderingAreaGranularityKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void> Invoke = handle;

        public static explicit operator VkGetRenderingAreaGranularityKHR(PfnVkVoidFunction func)
        {
            return new VkGetRenderingAreaGranularityKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfo*, VkExtent2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceImageSubresourceLayoutKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceImageSubresourceInfo*,
            VkSubresourceLayout2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceImageSubresourceLayoutKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceImageSubresourceLayoutKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfo*, VkSubresourceLayout2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSubresourceLayout2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImage,
            VkImageSubresource2*,
            VkSubresourceLayout2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSubresourceLayout2KHR(PfnVkVoidFunction func)
        {
            return new VkGetImageSubresourceLayout2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWaitForPresent2KHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkPresentWait2InfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkPresentWait2InfoKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkWaitForPresent2KHR(PfnVkVoidFunction func)
        {
            return new VkWaitForPresent2KHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkPresentWait2InfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreatePipelineBinariesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineBinaryCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkPipelineBinaryHandlesInfoKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineBinaryCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkPipelineBinaryHandlesInfoKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreatePipelineBinariesKHR(PfnVkVoidFunction func)
        {
            return new VkCreatePipelineBinariesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineBinaryCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkPipelineBinaryHandlesInfoKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyPipelineBinaryKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyPipelineBinaryKHR(PfnVkVoidFunction func)
        {
            return new VkDestroyPipelineBinaryKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineBinaryKHR, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineKeyKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCreateInfoKHR*,
            VkPipelineBinaryKeyKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPipelineKeyKHR(PfnVkVoidFunction func)
        {
            return new VkGetPipelineKeyKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineCreateInfoKHR*, VkPipelineBinaryKeyKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineBinaryDataKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineBinaryDataInfoKHR*,
            VkPipelineBinaryKeyKHR*,
            nuint*,
            void*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineBinaryDataInfoKHR*,
            VkPipelineBinaryKeyKHR*,
            nuint*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPipelineBinaryDataKHR(PfnVkVoidFunction func)
        {
            return new VkGetPipelineBinaryDataKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineBinaryDataInfoKHR*,
                    VkPipelineBinaryKeyKHR*,
                    nuint*,
                    void*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleaseCapturedPipelineDataKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkReleaseCapturedPipelineDataInfoKHR*,
            VkAllocationCallbacks*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkReleaseCapturedPipelineDataInfoKHR*,
            VkAllocationCallbacks*,
            VkResult> Invoke = handle;

        public static explicit operator VkReleaseCapturedPipelineDataKHR(PfnVkVoidFunction func)
        {
            return new VkReleaseCapturedPipelineDataKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkReleaseCapturedPipelineDataInfoKHR*,
                    VkAllocationCallbacks*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleaseSwapchainImagesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkReleaseSwapchainImagesKHR(PfnVkVoidFunction func)
        {
            return new VkReleaseSwapchainImagesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkCooperativeMatrixPropertiesKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkCooperativeMatrixPropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceCooperativeMatrixPropertiesKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkCooperativeMatrixPropertiesKHR*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLineStippleKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void> Invoke = handle;

        public static explicit operator VkCmdSetLineStippleKHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetLineStippleKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCalibrateableTimeDomainsKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkTimeDomainKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkTimeDomainKHR*, VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceCalibrateableTimeDomainsKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceCalibrateableTimeDomainsKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkTimeDomainKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetCalibratedTimestampsKHR(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkCalibratedTimestampInfoKHR*, nint*, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkCalibratedTimestampInfoKHR*,
            nint*,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetCalibratedTimestampsKHR(PfnVkVoidFunction func)
        {
            return new VkGetCalibratedTimestampsKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkCalibratedTimestampInfoKHR*, nint*, nint*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindDescriptorSets2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorSetsInfo*, void> Invoke = handle;

        public static explicit operator VkCmdBindDescriptorSets2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdBindDescriptorSets2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorSetsInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushConstants2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushConstantsInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushConstantsInfo*, void> Invoke = handle;

        public static explicit operator VkCmdPushConstants2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdPushConstants2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushConstantsInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSet2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetInfo*, void> Invoke = handle;

        public static explicit operator VkCmdPushDescriptorSet2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSet2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetWithTemplate2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void> Invoke =
            handle;

        public static explicit operator VkCmdPushDescriptorSetWithTemplate2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdPushDescriptorSetWithTemplate2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfo*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDescriptorBufferOffsets2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetDescriptorBufferOffsets2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDescriptorBufferOffsets2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindDescriptorBufferEmbeddedSamplers2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBindDescriptorBufferEmbeddedSamplersInfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindDescriptorBufferEmbeddedSamplers2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindDescriptorBufferEmbeddedSamplers2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryIndirectKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryIndirectInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryIndirectInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdCopyMemoryIndirectKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryIndirectKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryIndirectInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryToImageIndirectKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToImageIndirectInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToImageIndirectInfoKHR*, void> Invoke =
            handle;

        public static explicit operator VkCmdCopyMemoryToImageIndirectKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryToImageIndirectKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToImageIndirectInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceFaultReportsKHR(
        delegate* unmanaged[Cdecl]<VkDevice, nint, int*, VkDeviceFaultInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, nint, int*, VkDeviceFaultInfoKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetDeviceFaultReportsKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceFaultReportsKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, nint, int*, VkDeviceFaultInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceFaultDebugInfoKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultDebugInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultDebugInfoKHR*, VkResult> Invoke = handle;

        public static explicit operator VkGetDeviceFaultDebugInfoKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceFaultDebugInfoKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultDebugInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRendering2KHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingEndInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingEndInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdEndRendering2KHR(PfnVkVoidFunction func)
        {
            return new VkCmdEndRendering2KHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingEndInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDebugReportCallbackEXT(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugReportCallbackCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkDebugReportCallbackEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugReportCallbackCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkDebugReportCallbackEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDebugReportCallbackEXT(PfnVkVoidFunction func)
        {
            return new VkCreateDebugReportCallbackEXT(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkDebugReportCallbackCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkDebugReportCallbackEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDebugReportCallbackEXT(
        delegate* unmanaged[Cdecl]<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugReportCallbackEXT,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDebugReportCallbackEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyDebugReportCallbackEXT(
                (delegate* unmanaged[Cdecl]<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDebugReportMessageEXT(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            nint,
            nuint,
            int,
            byte*,
            byte*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            nint,
            nuint,
            int,
            byte*,
            byte*,
            void> Invoke = handle;

        public static explicit operator VkDebugReportMessageEXT(PfnVkVoidFunction func)
        {
            return new VkDebugReportMessageEXT(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkDebugReportFlagsEXT,
                    VkDebugReportObjectTypeEXT,
                    nint,
                    nuint,
                    int,
                    byte*,
                    byte*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDebugMarkerSetObjectTagEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> Invoke = handle;

        public static explicit operator VkDebugMarkerSetObjectTagEXT(PfnVkVoidFunction func)
        {
            return new VkDebugMarkerSetObjectTagEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDebugMarkerSetObjectNameEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> Invoke = handle;

        public static explicit operator VkDebugMarkerSetObjectNameEXT(PfnVkVoidFunction func)
        {
            return new VkDebugMarkerSetObjectNameEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDebugMarkerBeginEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdDebugMarkerBeginEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDebugMarkerBeginEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDebugMarkerEndEXT(delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdDebugMarkerEndEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDebugMarkerEndEXT((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdDebugMarkerInsertEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdDebugMarkerInsertEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDebugMarkerInsertEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindTransformFeedbackBuffersEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBuffer*,
            ByteSize64*,
            ByteSize64*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindTransformFeedbackBuffersEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindTransformFeedbackBuffersEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, ByteSize64*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginTransformFeedbackEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void> Invoke =
            handle;

        public static explicit operator VkCmdBeginTransformFeedbackEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginTransformFeedbackEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndTransformFeedbackEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void> Invoke =
            handle;

        public static explicit operator VkCmdEndTransformFeedbackEXT(PfnVkVoidFunction func)
        {
            return new VkCmdEndTransformFeedbackEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer*, ByteSize64*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginQueryIndexedEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, VkQueryControlFlags, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkQueryPool,
            int,
            VkQueryControlFlags,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdBeginQueryIndexedEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginQueryIndexedEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, VkQueryControlFlags, int, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndQueryIndexedEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, int, void> Invoke = handle;

        public static explicit operator VkCmdEndQueryIndexedEXT(PfnVkVoidFunction func)
        {
            return new VkCmdEndQueryIndexedEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkQueryPool, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectByteCountEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirectByteCountEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirectByteCountEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkBuffer, ByteSize64, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateCuModuleNVX(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCuModuleCreateInfoNVX*,
            VkAllocationCallbacks*,
            VkCuModuleNVX*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCuModuleCreateInfoNVX*,
            VkAllocationCallbacks*,
            VkCuModuleNVX*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateCuModuleNVX(PfnVkVoidFunction func)
        {
            return new VkCreateCuModuleNVX(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkCuModuleCreateInfoNVX*,
                    VkAllocationCallbacks*,
                    VkCuModuleNVX*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateCuFunctionNVX(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCuFunctionCreateInfoNVX*,
            VkAllocationCallbacks*,
            VkCuFunctionNVX*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkCuFunctionCreateInfoNVX*,
            VkAllocationCallbacks*,
            VkCuFunctionNVX*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateCuFunctionNVX(PfnVkVoidFunction func)
        {
            return new VkCreateCuFunctionNVX(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkCuFunctionCreateInfoNVX*,
                    VkAllocationCallbacks*,
                    VkCuFunctionNVX*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyCuModuleNVX(
        delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyCuModuleNVX(PfnVkVoidFunction func)
        {
            return new VkDestroyCuModuleNVX(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyCuFunctionNVX(
        delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyCuFunctionNVX(PfnVkVoidFunction func)
        {
            return new VkDestroyCuFunctionNVX(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCuLaunchKernelNVX(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCuLaunchInfoNVX*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCuLaunchInfoNVX*, void> Invoke = handle;

        public static explicit operator VkCmdCuLaunchKernelNVX(PfnVkVoidFunction func)
        {
            return new VkCmdCuLaunchKernelNVX(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCuLaunchInfoNVX*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageViewHandleNVX(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, int> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, int> Invoke = handle;

        public static explicit operator VkGetImageViewHandleNVX(PfnVkVoidFunction func)
        {
            return new VkGetImageViewHandleNVX(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, int>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageViewHandle64NVX(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, nint> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, nint> Invoke = handle;

        public static explicit operator VkGetImageViewHandle64NVX(PfnVkVoidFunction func)
        {
            return new VkGetImageViewHandle64NVX(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, nint>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageViewAddressNVX(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageView,
            VkImageViewAddressPropertiesNVX*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetImageViewAddressNVX(PfnVkVoidFunction func)
        {
            return new VkGetImageViewAddressNVX(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceCombinedImageSamplerIndexNVX(
        delegate* unmanaged[Cdecl]<VkDevice, nint, nint, nint> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, nint, nint, nint> Invoke = handle;

        public static explicit operator VkGetDeviceCombinedImageSamplerIndexNVX(PfnVkVoidFunction func)
        {
            return new VkGetDeviceCombinedImageSamplerIndexNVX(
                (delegate* unmanaged[Cdecl]<VkDevice, nint, nint, nint>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectCountAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndirectCountAMD(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndirectCountAMD(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirectCountAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawIndexedIndirectCountAMD(PfnVkVoidFunction func)
        {
            return new VkCmdDrawIndexedIndirectCountAMD(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetShaderInfoAMD(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipeline,
            VkShaderStageFlags,
            VkShaderInfoTypeAMD,
            nuint*,
            void*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipeline,
            VkShaderStageFlags,
            VkShaderInfoTypeAMD,
            nuint*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetShaderInfoAMD(PfnVkVoidFunction func)
        {
            return new VkGetShaderInfoAMD(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipeline,
                    VkShaderStageFlags,
                    VkShaderInfoTypeAMD,
                    nuint*,
                    void*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalImageFormatPropertiesNV(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkFormat,
            VkImageType,
            VkImageTiling,
            VkImageUsageFlags,
            VkImageCreateFlags,
            VkExternalMemoryHandleTypeFlagsNV,
            VkExternalImageFormatPropertiesNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkFormat,
            VkImageType,
            VkImageTiling,
            VkImageUsageFlags,
            VkImageCreateFlags,
            VkExternalMemoryHandleTypeFlagsNV,
            VkExternalImageFormatPropertiesNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalImageFormatPropertiesNV(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalImageFormatPropertiesNV(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkFormat,
                    VkImageType,
                    VkImageTiling,
                    VkImageUsageFlags,
                    VkImageCreateFlags,
                    VkExternalMemoryHandleTypeFlagsNV,
                    VkExternalImageFormatPropertiesNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginConditionalRenderingEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdBeginConditionalRenderingEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginConditionalRenderingEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndConditionalRenderingEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdEndConditionalRenderingEXT(PfnVkVoidFunction func)
        {
            return new VkCmdEndConditionalRenderingEXT((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetViewportWScalingNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewportWScalingNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewportWScalingNV*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetViewportWScalingNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewportWScalingNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewportWScalingNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleaseDisplayEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> Invoke = handle;

        public static explicit operator VkReleaseDisplayEXT(PfnVkVoidFunction func)
        {
            return new VkReleaseDisplayEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceCapabilities2EXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkSurfaceKHR,
            VkSurfaceCapabilities2EXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfaceCapabilities2EXT(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfaceCapabilities2EXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDisplayPowerControlEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> Invoke =
            handle;

        public static explicit operator VkDisplayPowerControlEXT(PfnVkVoidFunction func)
        {
            return new VkDisplayPowerControlEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkRegisterDeviceEventEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceEventInfoEXT*,
            VkAllocationCallbacks*,
            VkFence*,
            VkResult> Invoke = handle;

        public static explicit operator VkRegisterDeviceEventEXT(PfnVkVoidFunction func)
        {
            return new VkRegisterDeviceEventEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeviceEventInfoEXT*,
                    VkAllocationCallbacks*,
                    VkFence*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkRegisterDisplayEventEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDisplayKHR,
            VkDisplayEventInfoEXT*,
            VkAllocationCallbacks*,
            VkFence*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDisplayKHR,
            VkDisplayEventInfoEXT*,
            VkAllocationCallbacks*,
            VkFence*,
            VkResult> Invoke = handle;

        public static explicit operator VkRegisterDisplayEventEXT(PfnVkVoidFunction func)
        {
            return new VkRegisterDisplayEventEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDisplayKHR,
                    VkDisplayEventInfoEXT*,
                    VkAllocationCallbacks*,
                    VkFence*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSwapchainCounterEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            VkSurfaceCounterFlagsEXT,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetSwapchainCounterEXT(PfnVkVoidFunction func)
        {
            return new VkGetSwapchainCounterEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, nint*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRefreshCycleDurationGOOGLE(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            VkRefreshCycleDurationGOOGLE*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetRefreshCycleDurationGOOGLE(PfnVkVoidFunction func)
        {
            return new VkGetRefreshCycleDurationGOOGLE(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPastPresentationTimingGOOGLE(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int*, VkPastPresentationTimingGOOGLE*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            int*,
            VkPastPresentationTimingGOOGLE*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPastPresentationTimingGOOGLE(PfnVkVoidFunction func)
        {
            return new VkGetPastPresentationTimingGOOGLE(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int*, VkPastPresentationTimingGOOGLE*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDiscardRectangleEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void> Invoke = handle;

        public static explicit operator VkCmdSetDiscardRectangleEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDiscardRectangleEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDiscardRectangleEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDiscardRectangleEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDiscardRectangleEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDiscardRectangleModeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDiscardRectangleModeEXT, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDiscardRectangleModeEXT, void> Invoke = handle;

        public static explicit operator VkCmdSetDiscardRectangleModeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDiscardRectangleModeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDiscardRectangleModeEXT, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetHdrMetadataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkSwapchainKHR*, VkHdrMetadataEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkSwapchainKHR*, VkHdrMetadataEXT*, void> Invoke =
            handle;

        public static explicit operator VkSetHdrMetadataEXT(PfnVkVoidFunction func)
        {
            return new VkSetHdrMetadataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkSwapchainKHR*, VkHdrMetadataEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetDebugUtilsObjectNameEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> Invoke = handle;

        public static explicit operator VkSetDebugUtilsObjectNameEXT(PfnVkVoidFunction func)
        {
            return new VkSetDebugUtilsObjectNameEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetDebugUtilsObjectTagEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> Invoke = handle;

        public static explicit operator VkSetDebugUtilsObjectTagEXT(PfnVkVoidFunction func)
        {
            return new VkSetDebugUtilsObjectTagEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueBeginDebugUtilsLabelEXT(
        delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> Invoke = handle;

        public static explicit operator VkQueueBeginDebugUtilsLabelEXT(PfnVkVoidFunction func)
        {
            return new VkQueueBeginDebugUtilsLabelEXT(
                (delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueEndDebugUtilsLabelEXT(delegate* unmanaged[Cdecl]<VkQueue, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, void> Invoke = handle;

        public static explicit operator VkQueueEndDebugUtilsLabelEXT(PfnVkVoidFunction func)
        {
            return new VkQueueEndDebugUtilsLabelEXT((delegate* unmanaged[Cdecl]<VkQueue, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkQueueInsertDebugUtilsLabelEXT(
        delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void> Invoke = handle;

        public static explicit operator VkQueueInsertDebugUtilsLabelEXT(PfnVkVoidFunction func)
        {
            return new VkQueueInsertDebugUtilsLabelEXT(
                (delegate* unmanaged[Cdecl]<VkQueue, VkDebugUtilsLabelEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginDebugUtilsLabelEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> Invoke = handle;

        public static explicit operator VkCmdBeginDebugUtilsLabelEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginDebugUtilsLabelEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndDebugUtilsLabelEXT(delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdEndDebugUtilsLabelEXT(PfnVkVoidFunction func)
        {
            return new VkCmdEndDebugUtilsLabelEXT((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdInsertDebugUtilsLabelEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> Invoke = handle;

        public static explicit operator VkCmdInsertDebugUtilsLabelEXT(PfnVkVoidFunction func)
        {
            return new VkCmdInsertDebugUtilsLabelEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDebugUtilsMessengerEXT(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugUtilsMessengerCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkDebugUtilsMessengerEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugUtilsMessengerCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkDebugUtilsMessengerEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDebugUtilsMessengerEXT(PfnVkVoidFunction func)
        {
            return new VkCreateDebugUtilsMessengerEXT(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkDebugUtilsMessengerCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkDebugUtilsMessengerEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDebugUtilsMessengerEXT(
        delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugUtilsMessengerEXT,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDebugUtilsMessengerEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyDebugUtilsMessengerEXT(
                (delegate* unmanaged[Cdecl]<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSubmitDebugUtilsMessageEXT(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugUtilsMessageSeverityFlagsEXT,
            VkDebugUtilsMessageTypeFlagsEXT,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkDebugUtilsMessageSeverityFlagsEXT,
            VkDebugUtilsMessageTypeFlagsEXT,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void> Invoke = handle;

        public static explicit operator VkSubmitDebugUtilsMessageEXT(PfnVkVoidFunction func)
        {
            return new VkSubmitDebugUtilsMessageEXT(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkDebugUtilsMessageSeverityFlagsEXT,
                    VkDebugUtilsMessageTypeFlagsEXT,
                    VkDebugUtilsMessengerCallbackDataEXT*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateGpaSessionAMD(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkGpaSessionCreateInfoAMD*,
            VkAllocationCallbacks*,
            VkGpaSessionAMD*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkGpaSessionCreateInfoAMD*,
            VkAllocationCallbacks*,
            VkGpaSessionAMD*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateGpaSessionAMD(PfnVkVoidFunction func)
        {
            return new VkCreateGpaSessionAMD(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkGpaSessionCreateInfoAMD*,
                    VkAllocationCallbacks*,
                    VkGpaSessionAMD*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyGpaSessionAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyGpaSessionAMD(PfnVkVoidFunction func)
        {
            return new VkDestroyGpaSessionAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetGpaDeviceClockModeAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkGpaDeviceClockModeInfoAMD*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkGpaDeviceClockModeInfoAMD*, VkResult> Invoke = handle;

        public static explicit operator VkSetGpaDeviceClockModeAMD(PfnVkVoidFunction func)
        {
            return new VkSetGpaDeviceClockModeAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkGpaDeviceClockModeInfoAMD*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetGpaDeviceClockInfoAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkGpaDeviceGetClockInfoAMD*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkGpaDeviceGetClockInfoAMD*, VkResult> Invoke = handle;

        public static explicit operator VkGetGpaDeviceClockInfoAMD(PfnVkVoidFunction func)
        {
            return new VkGetGpaDeviceClockInfoAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkGpaDeviceGetClockInfoAMD*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginGpaSessionAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkResult> Invoke = handle;

        public static explicit operator VkCmdBeginGpaSessionAMD(PfnVkVoidFunction func)
        {
            return new VkCmdBeginGpaSessionAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndGpaSessionAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkResult> Invoke = handle;

        public static explicit operator VkCmdEndGpaSessionAMD(PfnVkVoidFunction func)
        {
            return new VkCmdEndGpaSessionAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginGpaSampleAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkGpaSampleBeginInfoAMD*, int*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkGpaSessionAMD,
            VkGpaSampleBeginInfoAMD*,
            int*,
            VkResult> Invoke = handle;

        public static explicit operator VkCmdBeginGpaSampleAMD(PfnVkVoidFunction func)
        {
            return new VkCmdBeginGpaSampleAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, VkGpaSampleBeginInfoAMD*, int*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndGpaSampleAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, int, void> Invoke = handle;

        public static explicit operator VkCmdEndGpaSampleAMD(PfnVkVoidFunction func)
        {
            return new VkCmdEndGpaSampleAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetGpaSessionStatusAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkResult> Invoke = handle;

        public static explicit operator VkGetGpaSessionStatusAMD(PfnVkVoidFunction func)
        {
            return new VkGetGpaSessionStatusAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetGpaSessionResultsAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, int, nuint*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, int, nuint*, void*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetGpaSessionResultsAMD(PfnVkVoidFunction func)
        {
            return new VkGetGpaSessionResultsAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, int, nuint*, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkResetGpaSessionAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkResult> Invoke = handle;

        public static explicit operator VkResetGpaSessionAMD(PfnVkVoidFunction func)
        {
            return new VkResetGpaSessionAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkGpaSessionAMD, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyGpaSessionResultsAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, void> Invoke = handle;

        public static explicit operator VkCmdCopyGpaSessionResultsAMD(PfnVkVoidFunction func)
        {
            return new VkCmdCopyGpaSessionResultsAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGpaSessionAMD, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWriteSamplerDescriptorsEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkSamplerCreateInfo*, VkHostAddressRangeEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkSamplerCreateInfo*,
            VkHostAddressRangeEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkWriteSamplerDescriptorsEXT(PfnVkVoidFunction func)
        {
            return new VkWriteSamplerDescriptorsEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkSamplerCreateInfo*, VkHostAddressRangeEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWriteResourceDescriptorsEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkResourceDescriptorInfoEXT*, VkHostAddressRangeEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkResourceDescriptorInfoEXT*,
            VkHostAddressRangeEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkWriteResourceDescriptorsEXT(PfnVkVoidFunction func)
        {
            return new VkWriteResourceDescriptorsEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    int,
                    VkResourceDescriptorInfoEXT*,
                    VkHostAddressRangeEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindSamplerHeapEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindHeapInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindHeapInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdBindSamplerHeapEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindSamplerHeapEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindHeapInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindResourceHeapEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindHeapInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindHeapInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdBindResourceHeapEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindResourceHeapEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBindHeapInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPushDataEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDataInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDataInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdPushDataEXT(PfnVkVoidFunction func)
        {
            return new VkCmdPushDataEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPushDataInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageOpaqueCaptureDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkImage*, VkHostAddressRangeEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkImage*, VkHostAddressRangeEXT*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetImageOpaqueCaptureDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetImageOpaqueCaptureDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkImage*, VkHostAddressRangeEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceDescriptorSizeEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDescriptorType, ByteSize64> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDescriptorType, ByteSize64> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceDescriptorSizeEXT(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceDescriptorSizeEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDescriptorType, ByteSize64>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkRegisterCustomBorderColorEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerCustomBorderColorCreateInfoEXT*,
            Brutal.Bool32,
            int*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerCustomBorderColorCreateInfoEXT*,
            Brutal.Bool32,
            int*,
            VkResult> Invoke = handle;

        public static explicit operator VkRegisterCustomBorderColorEXT(PfnVkVoidFunction func)
        {
            return new VkRegisterCustomBorderColorEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSamplerCustomBorderColorCreateInfoEXT*,
                    Brutal.Bool32,
                    int*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUnregisterCustomBorderColorEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, void> Invoke = handle;

        public static explicit operator VkUnregisterCustomBorderColorEXT(PfnVkVoidFunction func)
        {
            return new VkUnregisterCustomBorderColorEXT((delegate* unmanaged[Cdecl]<VkDevice, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetTensorOpaqueCaptureDataARM(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkTensorARM*, VkHostAddressRangeEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkTensorARM*,
            VkHostAddressRangeEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetTensorOpaqueCaptureDataARM(PfnVkVoidFunction func)
        {
            return new VkGetTensorOpaqueCaptureDataARM(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkTensorARM*, VkHostAddressRangeEXT*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetSampleLocationsEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdSetSampleLocationsEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetSampleLocationsEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMultisamplePropertiesEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkSampleCountFlags,
            VkMultisamplePropertiesEXT*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceMultisamplePropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceMultisamplePropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageDrmFormatModifierPropertiesEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImage,
            VkImageDrmFormatModifierPropertiesEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetImageDrmFormatModifierPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetImageDrmFormatModifierPropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateValidationCacheEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkValidationCacheCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkValidationCacheEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkValidationCacheCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkValidationCacheEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateValidationCacheEXT(PfnVkVoidFunction func)
        {
            return new VkCreateValidationCacheEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkValidationCacheCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkValidationCacheEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyValidationCacheEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkValidationCacheEXT,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyValidationCacheEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyValidationCacheEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkMergeValidationCachesEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, int, VkValidationCacheEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkValidationCacheEXT,
            int,
            VkValidationCacheEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkMergeValidationCachesEXT(PfnVkVoidFunction func)
        {
            return new VkMergeValidationCachesEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, int, VkValidationCacheEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetValidationCacheDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetValidationCacheDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetValidationCacheDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindShadingRateImageNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> Invoke = handle;

        public static explicit operator VkCmdBindShadingRateImageNV(PfnVkVoidFunction func)
        {
            return new VkCmdBindShadingRateImageNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetViewportShadingRatePaletteNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkShadingRatePaletteNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkShadingRatePaletteNV*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetViewportShadingRatePaletteNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewportShadingRatePaletteNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkShadingRatePaletteNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoarseSampleOrderNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkCoarseSampleOrderTypeNV,
            int,
            VkCoarseSampleOrderCustomNV*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkCoarseSampleOrderTypeNV,
            int,
            VkCoarseSampleOrderCustomNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetCoarseSampleOrderNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoarseSampleOrderNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkCoarseSampleOrderTypeNV,
                    int,
                    VkCoarseSampleOrderCustomNV*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateAccelerationStructureNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCreateInfoNV*,
            VkAllocationCallbacks*,
            VkAccelerationStructureNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCreateInfoNV*,
            VkAllocationCallbacks*,
            VkAccelerationStructureNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateAccelerationStructureNV(PfnVkVoidFunction func)
        {
            return new VkCreateAccelerationStructureNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureCreateInfoNV*,
                    VkAllocationCallbacks*,
                    VkAccelerationStructureNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyAccelerationStructureNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureNV,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyAccelerationStructureNV(PfnVkVoidFunction func)
        {
            return new VkDestroyAccelerationStructureNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureMemoryRequirementsNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureMemoryRequirementsInfoNV*,
            VkMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureMemoryRequirementsInfoNV*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetAccelerationStructureMemoryRequirementsNV(PfnVkVoidFunction func)
        {
            return new VkGetAccelerationStructureMemoryRequirementsNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureMemoryRequirementsInfoNV*,
                    VkMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindAccelerationStructureMemoryNV(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindAccelerationStructureMemoryInfoNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkBindAccelerationStructureMemoryInfoNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkBindAccelerationStructureMemoryNV(PfnVkVoidFunction func)
        {
            return new VkBindAccelerationStructureMemoryNV(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindAccelerationStructureMemoryInfoNV*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBuildAccelerationStructureNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkAccelerationStructureInfoNV*,
            VkBuffer,
            ByteSize64,
            Brutal.Bool32,
            VkAccelerationStructureNV,
            VkAccelerationStructureNV,
            VkBuffer,
            ByteSize64,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkAccelerationStructureInfoNV*,
            VkBuffer,
            ByteSize64,
            Brutal.Bool32,
            VkAccelerationStructureNV,
            VkAccelerationStructureNV,
            VkBuffer,
            ByteSize64,
            void> Invoke = handle;

        public static explicit operator VkCmdBuildAccelerationStructureNV(PfnVkVoidFunction func)
        {
            return new VkCmdBuildAccelerationStructureNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkAccelerationStructureInfoNV*,
                    VkBuffer,
                    ByteSize64,
                    Brutal.Bool32,
                    VkAccelerationStructureNV,
                    VkAccelerationStructureNV,
                    VkBuffer,
                    ByteSize64,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyAccelerationStructureNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkAccelerationStructureNV,
            VkAccelerationStructureNV,
            VkCopyAccelerationStructureModeKHR,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkAccelerationStructureNV,
            VkAccelerationStructureNV,
            VkCopyAccelerationStructureModeKHR,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyAccelerationStructureNV(PfnVkVoidFunction func)
        {
            return new VkCmdCopyAccelerationStructureNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkAccelerationStructureNV,
                    VkAccelerationStructureNV,
                    VkCopyAccelerationStructureModeKHR,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdTraceRaysNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            int,
            int,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            ByteSize64,
            int,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdTraceRaysNV(PfnVkVoidFunction func)
        {
            return new VkCmdTraceRaysNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    ByteSize64,
                    int,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateRayTracingPipelinesNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCache,
            int,
            VkRayTracingPipelineCreateInfoNV*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineCache,
            int,
            VkRayTracingPipelineCreateInfoNV*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateRayTracingPipelinesNV(PfnVkVoidFunction func)
        {
            return new VkCreateRayTracingPipelinesNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPipelineCache,
                    int,
                    VkRayTracingPipelineCreateInfoNV*,
                    VkAllocationCallbacks*,
                    VkPipeline*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRayTracingShaderGroupHandlesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetRayTracingShaderGroupHandlesKHR(PfnVkVoidFunction func)
        {
            return new VkGetRayTracingShaderGroupHandlesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRayTracingShaderGroupHandlesNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetRayTracingShaderGroupHandlesNV(PfnVkVoidFunction func)
        {
            return new VkGetRayTracingShaderGroupHandlesNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureHandleNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetAccelerationStructureHandleNV(PfnVkVoidFunction func)
        {
            return new VkGetAccelerationStructureHandleNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteAccelerationStructuresPropertiesNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureNV*,
            VkQueryType,
            VkQueryPool,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureNV*,
            VkQueryType,
            VkQueryPool,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteAccelerationStructuresPropertiesNV(PfnVkVoidFunction func)
        {
            return new VkCmdWriteAccelerationStructuresPropertiesNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkAccelerationStructureNV*,
                    VkQueryType,
                    VkQueryPool,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCompileDeferredNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, VkResult> Invoke = handle;

        public static explicit operator VkCompileDeferredNV(PfnVkVoidFunction func)
        {
            return new VkCompileDeferredNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryHostPointerPropertiesEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            void*,
            VkMemoryHostPointerPropertiesEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            void*,
            VkMemoryHostPointerPropertiesEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryHostPointerPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetMemoryHostPointerPropertiesEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkExternalMemoryHandleTypeFlags,
                    void*,
                    VkMemoryHostPointerPropertiesEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteBufferMarkerAMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, ByteSize64, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags,
            VkBuffer,
            ByteSize64,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteBufferMarkerAMD(PfnVkVoidFunction func)
        {
            return new VkCmdWriteBufferMarkerAMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, ByteSize64, int, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteBufferMarker2AMD(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, ByteSize64, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineStageFlags2,
            VkBuffer,
            ByteSize64,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteBufferMarker2AMD(PfnVkVoidFunction func)
        {
            return new VkCmdWriteBufferMarker2AMD(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, ByteSize64, int, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCalibrateableTimeDomainsEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkTimeDomainKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkTimeDomainKHR*, VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceCalibrateableTimeDomainsEXT(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceCalibrateableTimeDomainsEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkTimeDomainKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetCalibratedTimestampsEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkCalibratedTimestampInfoKHR*, nint*, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkCalibratedTimestampInfoKHR*,
            nint*,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetCalibratedTimestampsEXT(PfnVkVoidFunction func)
        {
            return new VkGetCalibratedTimestampsEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkCalibratedTimestampInfoKHR*, nint*, nint*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDrawMeshTasksNV(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksNV((delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> Invoke =
            handle;

        public static explicit operator VkCmdDrawMeshTasksIndirectNV(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksIndirectNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectCountNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawMeshTasksIndirectCountNV(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksIndirectCountNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetExclusiveScissorEnableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, Brutal.Bool32*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, Brutal.Bool32*, void> Invoke = handle;

        public static explicit operator VkCmdSetExclusiveScissorEnableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetExclusiveScissorEnableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, Brutal.Bool32*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetExclusiveScissorNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void> Invoke = handle;

        public static explicit operator VkCmdSetExclusiveScissorNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetExclusiveScissorNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkRect2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCheckpointNV(delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void> Invoke = handle;

        public static explicit operator VkCmdSetCheckpointNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCheckpointNV((delegate* unmanaged[Cdecl]<VkCommandBuffer, void*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetQueueCheckpointDataNV(
        delegate* unmanaged[Cdecl]<VkQueue, int*, VkCheckpointDataNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int*, VkCheckpointDataNV*, void> Invoke = handle;

        public static explicit operator VkGetQueueCheckpointDataNV(PfnVkVoidFunction func)
        {
            return new VkGetQueueCheckpointDataNV(
                (delegate* unmanaged[Cdecl]<VkQueue, int*, VkCheckpointDataNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetQueueCheckpointData2NV(
        delegate* unmanaged[Cdecl]<VkQueue, int*, VkCheckpointData2NV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int*, VkCheckpointData2NV*, void> Invoke = handle;

        public static explicit operator VkGetQueueCheckpointData2NV(PfnVkVoidFunction func)
        {
            return new VkGetQueueCheckpointData2NV(
                (delegate* unmanaged[Cdecl]<VkQueue, int*, VkCheckpointData2NV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetSwapchainPresentTimingQueueSizeEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int, VkResult> Invoke = handle;

        public static explicit operator VkSetSwapchainPresentTimingQueueSizeEXT(PfnVkVoidFunction func)
        {
            return new VkSetSwapchainPresentTimingQueueSizeEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, int, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSwapchainTimingPropertiesEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSwapchainTimingPropertiesEXT*, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            VkSwapchainTimingPropertiesEXT*,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetSwapchainTimingPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetSwapchainTimingPropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSwapchainTimingPropertiesEXT*, nint*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSwapchainTimeDomainPropertiesEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            VkSwapchainTimeDomainPropertiesEXT*,
            nint*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            VkSwapchainTimeDomainPropertiesEXT*,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetSwapchainTimeDomainPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetSwapchainTimeDomainPropertiesEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkSwapchainKHR,
                    VkSwapchainTimeDomainPropertiesEXT*,
                    nint*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPastPresentationTimingEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPastPresentationTimingInfoEXT*,
            VkPastPresentationTimingPropertiesEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPastPresentationTimingInfoEXT*,
            VkPastPresentationTimingPropertiesEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPastPresentationTimingEXT(PfnVkVoidFunction func)
        {
            return new VkGetPastPresentationTimingEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPastPresentationTimingInfoEXT*,
                    VkPastPresentationTimingPropertiesEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkInitializePerformanceApiINTEL(
        delegate* unmanaged[Cdecl]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> Invoke =
            handle;

        public static explicit operator VkInitializePerformanceApiINTEL(PfnVkVoidFunction func)
        {
            return new VkInitializePerformanceApiINTEL(
                (delegate* unmanaged[Cdecl]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUninitializePerformanceApiINTEL(delegate* unmanaged[Cdecl]<VkDevice, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, void> Invoke = handle;

        public static explicit operator VkUninitializePerformanceApiINTEL(PfnVkVoidFunction func)
        {
            return new VkUninitializePerformanceApiINTEL((delegate* unmanaged[Cdecl]<VkDevice, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetPerformanceMarkerINTEL(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> Invoke =
            handle;

        public static explicit operator VkCmdSetPerformanceMarkerINTEL(PfnVkVoidFunction func)
        {
            return new VkCmdSetPerformanceMarkerINTEL(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPerformanceStreamMarkerINTEL(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPerformanceStreamMarkerInfoINTEL*,
            VkResult> Invoke = handle;

        public static explicit operator VkCmdSetPerformanceStreamMarkerINTEL(PfnVkVoidFunction func)
        {
            return new VkCmdSetPerformanceStreamMarkerINTEL(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPerformanceOverrideINTEL(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> Invoke =
            handle;

        public static explicit operator VkCmdSetPerformanceOverrideINTEL(PfnVkVoidFunction func)
        {
            return new VkCmdSetPerformanceOverrideINTEL(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquirePerformanceConfigurationINTEL(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPerformanceConfigurationAcquireInfoINTEL*,
            VkPerformanceConfigurationINTEL*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPerformanceConfigurationAcquireInfoINTEL*,
            VkPerformanceConfigurationINTEL*,
            VkResult> Invoke = handle;

        public static explicit operator VkAcquirePerformanceConfigurationINTEL(PfnVkVoidFunction func)
        {
            return new VkAcquirePerformanceConfigurationINTEL(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPerformanceConfigurationAcquireInfoINTEL*,
                    VkPerformanceConfigurationINTEL*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleasePerformanceConfigurationINTEL(
        delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationINTEL, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationINTEL, VkResult> Invoke = handle;

        public static explicit operator VkReleasePerformanceConfigurationINTEL(PfnVkVoidFunction func)
        {
            return new VkReleasePerformanceConfigurationINTEL(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceConfigurationINTEL, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueSetPerformanceConfigurationINTEL(
        delegate* unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult> Invoke = handle;

        public static explicit operator VkQueueSetPerformanceConfigurationINTEL(PfnVkVoidFunction func)
        {
            return new VkQueueSetPerformanceConfigurationINTEL(
                (delegate* unmanaged[Cdecl]<VkQueue, VkPerformanceConfigurationINTEL, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPerformanceParameterINTEL(
        delegate* unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPerformanceParameterTypeINTEL,
            VkPerformanceValueINTEL*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPerformanceParameterINTEL(PfnVkVoidFunction func)
        {
            return new VkGetPerformanceParameterINTEL(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPerformanceParameterTypeINTEL,
                    VkPerformanceValueINTEL*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetLocalDimmingAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkSetLocalDimmingAMD(PfnVkVoidFunction func)
        {
            return new VkSetLocalDimmingAMD(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferDeviceAddressEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> Invoke =
            handle;

        public static explicit operator VkGetBufferDeviceAddressEXT(PfnVkVoidFunction func)
        {
            return new VkGetBufferDeviceAddressEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceToolPropertiesEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkPhysicalDeviceToolProperties*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkPhysicalDeviceToolProperties*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceToolPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceToolPropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkPhysicalDeviceToolProperties*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCooperativeMatrixPropertiesNV(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkCooperativeMatrixPropertiesNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkCooperativeMatrixPropertiesNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceCooperativeMatrixPropertiesNV(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceCooperativeMatrixPropertiesNV(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkCooperativeMatrixPropertiesNV*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkFramebufferMixedSamplesCombinationNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkFramebufferMixedSamplesCombinationNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
            PfnVkVoidFunction func
        )
        {
            return new VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkFramebufferMixedSamplesCombinationNV*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateHeadlessSurfaceEXT(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkHeadlessSurfaceCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkHeadlessSurfaceCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateHeadlessSurfaceEXT(PfnVkVoidFunction func)
        {
            return new VkCreateHeadlessSurfaceEXT(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkHeadlessSurfaceCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLineStippleEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void> Invoke = handle;

        public static explicit operator VkCmdSetLineStippleEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetLineStippleEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, ushort, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkResetQueryPoolEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, int, int, void> Invoke = handle;

        public static explicit operator VkResetQueryPoolEXT(PfnVkVoidFunction func)
        {
            return new VkResetQueryPoolEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCullModeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void> Invoke = handle;

        public static explicit operator VkCmdSetCullModeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetCullModeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCullModeFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetFrontFaceEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void> Invoke = handle;

        public static explicit operator VkCmdSetFrontFaceEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetFrontFaceEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFrontFace, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPrimitiveTopologyEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void> Invoke = handle;

        public static explicit operator VkCmdSetPrimitiveTopologyEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetPrimitiveTopologyEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPrimitiveTopology, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetViewportWithCountEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkViewport*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkViewport*, void> Invoke = handle;

        public static explicit operator VkCmdSetViewportWithCountEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewportWithCountEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkViewport*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetScissorWithCountEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkRect2D*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkRect2D*, void> Invoke = handle;

        public static explicit operator VkCmdSetScissorWithCountEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetScissorWithCountEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkRect2D*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindVertexBuffers2EXT(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBuffer*,
            ByteSize64*,
            ByteSize64*,
            ByteSize64*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            int,
            VkBuffer*,
            ByteSize64*,
            ByteSize64*,
            ByteSize64*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindVertexBuffers2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindVertexBuffers2EXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    int,
                    VkBuffer*,
                    ByteSize64*,
                    ByteSize64*,
                    ByteSize64*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthTestEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthTestEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthTestEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthWriteEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthWriteEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthWriteEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthCompareOpEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthCompareOpEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthCompareOpEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCompareOp, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthBoundsTestEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBoundsTestEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBoundsTestEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilTestEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetStencilTestEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilTestEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetStencilOpEXT(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStencilFaceFlags,
            VkStencilOp,
            VkStencilOp,
            VkStencilOp,
            VkCompareOp,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStencilFaceFlags,
            VkStencilOp,
            VkStencilOp,
            VkStencilOp,
            VkCompareOp,
            void> Invoke = handle;

        public static explicit operator VkCmdSetStencilOpEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetStencilOpEXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkStencilFaceFlags,
                    VkStencilOp,
                    VkStencilOp,
                    VkStencilOp,
                    VkCompareOp,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyMemoryToImageEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfo*, VkResult> Invoke = handle;

        public static explicit operator VkCopyMemoryToImageEXT(PfnVkVoidFunction func)
        {
            return new VkCopyMemoryToImageEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCopyMemoryToImageInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyImageToMemoryEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfo*, VkResult> Invoke = handle;

        public static explicit operator VkCopyImageToMemoryEXT(PfnVkVoidFunction func)
        {
            return new VkCopyImageToMemoryEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToMemoryInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyImageToImageEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfo*, VkResult> Invoke = handle;

        public static explicit operator VkCopyImageToImageEXT(PfnVkVoidFunction func)
        {
            return new VkCopyImageToImageEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkCopyImageToImageInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkTransitionImageLayoutEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkHostImageLayoutTransitionInfo*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkHostImageLayoutTransitionInfo*, VkResult> Invoke =
            handle;

        public static explicit operator VkTransitionImageLayoutEXT(PfnVkVoidFunction func)
        {
            return new VkTransitionImageLayoutEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkHostImageLayoutTransitionInfo*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageSubresourceLayout2EXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImage,
            VkImageSubresource2*,
            VkSubresourceLayout2*,
            void> Invoke = handle;

        public static explicit operator VkGetImageSubresourceLayout2EXT(PfnVkVoidFunction func)
        {
            return new VkGetImageSubresourceLayout2EXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2*, VkSubresourceLayout2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleaseSwapchainImagesEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkReleaseSwapchainImagesEXT(PfnVkVoidFunction func)
        {
            return new VkReleaseSwapchainImagesEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetGeneratedCommandsMemoryRequirementsNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkGeneratedCommandsMemoryRequirementsInfoNV*,
            VkMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkGeneratedCommandsMemoryRequirementsInfoNV*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetGeneratedCommandsMemoryRequirementsNV(PfnVkVoidFunction func)
        {
            return new VkGetGeneratedCommandsMemoryRequirementsNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkGeneratedCommandsMemoryRequirementsInfoNV*,
                    VkMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPreprocessGeneratedCommandsNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> Invoke = handle;

        public static explicit operator VkCmdPreprocessGeneratedCommandsNV(PfnVkVoidFunction func)
        {
            return new VkCmdPreprocessGeneratedCommandsNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdExecuteGeneratedCommandsNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, VkGeneratedCommandsInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            Brutal.Bool32,
            VkGeneratedCommandsInfoNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdExecuteGeneratedCommandsNV(PfnVkVoidFunction func)
        {
            return new VkCmdExecuteGeneratedCommandsNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, VkGeneratedCommandsInfoNV*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindPipelineShaderGroupNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, int, void> Invoke =
            handle;

        public static explicit operator VkCmdBindPipelineShaderGroupNV(PfnVkVoidFunction func)
        {
            return new VkCmdBindPipelineShaderGroupNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateIndirectCommandsLayoutNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectCommandsLayoutCreateInfoNV*,
            VkAllocationCallbacks*,
            VkIndirectCommandsLayoutNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectCommandsLayoutCreateInfoNV*,
            VkAllocationCallbacks*,
            VkIndirectCommandsLayoutNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateIndirectCommandsLayoutNV(PfnVkVoidFunction func)
        {
            return new VkCreateIndirectCommandsLayoutNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkIndirectCommandsLayoutCreateInfoNV*,
                    VkAllocationCallbacks*,
                    VkIndirectCommandsLayoutNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyIndirectCommandsLayoutNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectCommandsLayoutNV,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyIndirectCommandsLayoutNV(PfnVkVoidFunction func)
        {
            return new VkDestroyIndirectCommandsLayoutNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthBias2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthBiasInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthBiasInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBias2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBias2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthBiasInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireDrmDisplayEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR, VkResult> Invoke = handle;

        public static explicit operator VkAcquireDrmDisplayEXT(PfnVkVoidFunction func)
        {
            return new VkAcquireDrmDisplayEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDrmDisplayEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int, VkDisplayKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int, VkDisplayKHR*, VkResult> Invoke = handle;

        public static explicit operator VkGetDrmDisplayEXT(PfnVkVoidFunction func)
        {
            return new VkGetDrmDisplayEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int, VkDisplayKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreatePrivateDataSlotEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPrivateDataSlotCreateInfo*,
            VkAllocationCallbacks*,
            VkPrivateDataSlot*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPrivateDataSlotCreateInfo*,
            VkAllocationCallbacks*,
            VkPrivateDataSlot*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreatePrivateDataSlotEXT(PfnVkVoidFunction func)
        {
            return new VkCreatePrivateDataSlotEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPrivateDataSlotCreateInfo*,
                    VkAllocationCallbacks*,
                    VkPrivateDataSlot*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyPrivateDataSlotEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyPrivateDataSlotEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyPrivateDataSlotEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetPrivateDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkObjectType,
            nint,
            VkPrivateDataSlot,
            nint,
            VkResult> Invoke = handle;

        public static explicit operator VkSetPrivateDataEXT(PfnVkVoidFunction func)
        {
            return new VkSetPrivateDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPrivateDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkObjectType,
            nint,
            VkPrivateDataSlot,
            nint*,
            void> Invoke = handle;

        public static explicit operator VkGetPrivateDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetPrivateDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, nint, VkPrivateDataSlot, nint*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueSetPerfHintQCOM(
        delegate* unmanaged[Cdecl]<VkQueue, VkPerfHintInfoQCOM*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkPerfHintInfoQCOM*, VkResult> Invoke = handle;

        public static explicit operator VkQueueSetPerfHintQCOM(PfnVkVoidFunction func)
        {
            return new VkQueueSetPerfHintQCOM(
                (delegate* unmanaged[Cdecl]<VkQueue, VkPerfHintInfoQCOM*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDispatchTileQCOM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchTileInfoQCOM*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchTileInfoQCOM*, void> Invoke = handle;

        public static explicit operator VkCmdDispatchTileQCOM(PfnVkVoidFunction func)
        {
            return new VkCmdDispatchTileQCOM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchTileInfoQCOM*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginPerTileExecutionQCOM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerTileBeginInfoQCOM*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerTileBeginInfoQCOM*, void> Invoke = handle;

        public static explicit operator VkCmdBeginPerTileExecutionQCOM(PfnVkVoidFunction func)
        {
            return new VkCmdBeginPerTileExecutionQCOM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerTileBeginInfoQCOM*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndPerTileExecutionQCOM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerTileEndInfoQCOM*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerTileEndInfoQCOM*, void> Invoke = handle;

        public static explicit operator VkCmdEndPerTileExecutionQCOM(PfnVkVoidFunction func)
        {
            return new VkCmdEndPerTileExecutionQCOM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPerTileEndInfoQCOM*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetLatencySleepModeLegacyNV(
        delegate* unmanaged[Cdecl]<VkDevice, Brutal.Bool32, Brutal.Bool32, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, Brutal.Bool32, Brutal.Bool32, int, void> Invoke = handle;

        public static explicit operator VkSetLatencySleepModeLegacyNV(PfnVkVoidFunction func)
        {
            return new VkSetLatencySleepModeLegacyNV(
                (delegate* unmanaged[Cdecl]<VkDevice, Brutal.Bool32, Brutal.Bool32, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkLatencySleepLegacyNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint, void> Invoke = handle;

        public static explicit operator VkLatencySleepLegacyNV(PfnVkVoidFunction func)
        {
            return new VkLatencySleepLegacyNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, nint, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetLatencyMarkerLegacyNV(
        delegate* unmanaged[Cdecl]<VkDevice, nint, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, nint, int, void> Invoke = handle;

        public static explicit operator VkSetLatencyMarkerLegacyNV(PfnVkVoidFunction func)
        {
            return new VkSetLatencyMarkerLegacyNV((delegate* unmanaged[Cdecl]<VkDevice, nint, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetLatencyTimingsLegacyNV(delegate* unmanaged[Cdecl]<VkDevice, void*, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, void*, void> Invoke = handle;

        public static explicit operator VkGetLatencyTimingsLegacyNV(PfnVkVoidFunction func)
        {
            return new VkGetLatencyTimingsLegacyNV((delegate* unmanaged[Cdecl]<VkDevice, void*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkQueueNotifyOutOfBandLegacyNV(delegate* unmanaged[Cdecl]<VkQueue, int, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, int, void> Invoke = handle;

        public static explicit operator VkQueueNotifyOutOfBandLegacyNV(PfnVkVoidFunction func)
        {
            return new VkQueueNotifyOutOfBandLegacyNV((delegate* unmanaged[Cdecl]<VkQueue, int, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetSleepStatusLegacyNV(
        delegate* unmanaged[Cdecl]<VkDevice, Brutal.Bool32*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, Brutal.Bool32*, void> Invoke = handle;

        public static explicit operator VkGetSleepStatusLegacyNV(PfnVkVoidFunction func)
        {
            return new VkGetSleepStatusLegacyNV(
                (delegate* unmanaged[Cdecl]<VkDevice, Brutal.Bool32*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkShutdownLatencyDeviceLegacyNV(delegate* unmanaged[Cdecl]<VkDevice, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, void> Invoke = handle;

        public static explicit operator VkShutdownLatencyDeviceLegacyNV(PfnVkVoidFunction func)
        {
            return new VkShutdownLatencyDeviceLegacyNV((delegate* unmanaged[Cdecl]<VkDevice, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetDescriptorSetLayoutSizeEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, ByteSize64*, void> Invoke = handle;

        public static explicit operator VkGetDescriptorSetLayoutSizeEXT(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorSetLayoutSizeEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, ByteSize64*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDescriptorSetLayoutBindingOffsetEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, int, ByteSize64*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, int, ByteSize64*, void> Invoke =
            handle;

        public static explicit operator VkGetDescriptorSetLayoutBindingOffsetEXT(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorSetLayoutBindingOffsetEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, int, ByteSize64*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDescriptorEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void> Invoke =
            handle;

        public static explicit operator VkGetDescriptorEXT(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorGetInfoEXT*, nuint, void*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindDescriptorBuffersEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkDescriptorBufferBindingInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkDescriptorBufferBindingInfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindDescriptorBuffersEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindDescriptorBuffersEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkDescriptorBufferBindingInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDescriptorBufferOffsetsEXT(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            int*,
            ByteSize64*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            int,
            int*,
            ByteSize64*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetDescriptorBufferOffsetsEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDescriptorBufferOffsetsEXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkPipelineBindPoint,
                    VkPipelineLayout,
                    int,
                    int,
                    int*,
                    ByteSize64*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindDescriptorBufferEmbeddedSamplersEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkPipelineBindPoint,
            VkPipelineLayout,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdBindDescriptorBufferEmbeddedSamplersEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindDescriptorBufferEmbeddedSamplersEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, int, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetBufferOpaqueCaptureDescriptorDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkBufferCaptureDescriptorDataInfoEXT*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetBufferOpaqueCaptureDescriptorDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetBufferOpaqueCaptureDescriptorDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageOpaqueCaptureDescriptorDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageCaptureDescriptorDataInfoEXT*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetImageOpaqueCaptureDescriptorDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetImageOpaqueCaptureDescriptorDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetImageViewOpaqueCaptureDescriptorDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkImageViewCaptureDescriptorDataInfoEXT*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetImageViewOpaqueCaptureDescriptorDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetImageViewOpaqueCaptureDescriptorDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSamplerOpaqueCaptureDescriptorDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSamplerCaptureDescriptorDataInfoEXT*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetSamplerOpaqueCaptureDescriptorDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetSamplerOpaqueCaptureDescriptorDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCaptureDescriptorDataInfoEXT*,
            void*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCaptureDescriptorDataInfoEXT*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureCaptureDescriptorDataInfoEXT*,
                    void*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetFragmentShadingRateEnumNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkFragmentShadingRateNV,
            VkFragmentShadingRateCombinerOpKHR*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkFragmentShadingRateNV,
            VkFragmentShadingRateCombinerOpKHR*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetFragmentShadingRateEnumNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetFragmentShadingRateEnumNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkFragmentShadingRateNV,
                    VkFragmentShadingRateCombinerOpKHR*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceFaultInfoEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceFaultCountsEXT*,
            VkDeviceFaultInfoEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDeviceFaultInfoEXT(PfnVkVoidFunction func)
        {
            return new VkGetDeviceFaultInfoEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceFaultCountsEXT*, VkDeviceFaultInfoEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetVertexInputEXT(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkVertexInputBindingDescription2EXT*,
            int,
            VkVertexInputAttributeDescription2EXT*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkVertexInputBindingDescription2EXT*,
            int,
            VkVertexInputAttributeDescription2EXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetVertexInputEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetVertexInputEXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkVertexInputBindingDescription2EXT*,
                    int,
                    VkVertexInputAttributeDescription2EXT*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(
        delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult> Invoke = handle;

        public static explicit operator VkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(PfnVkVoidFunction func)
        {
            return new VkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(
                (delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSubpassShadingHUAWEI(delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdSubpassShadingHUAWEI(PfnVkVoidFunction func)
        {
            return new VkCmdSubpassShadingHUAWEI((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdBindInvocationMaskHUAWEI(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> Invoke = handle;

        public static explicit operator VkCmdBindInvocationMaskHUAWEI(PfnVkVoidFunction func)
        {
            return new VkCmdBindInvocationMaskHUAWEI(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryRemoteAddressNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMemoryGetRemoteAddressInfoNV*,
            VkRemoteAddressNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryRemoteAddressNV(PfnVkVoidFunction func)
        {
            return new VkGetMemoryRemoteAddressNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetRemoteAddressInfoNV*, VkRemoteAddressNV*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelinePropertiesEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetPipelinePropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetPipelinePropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPatchControlPointsEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetPatchControlPointsEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetPatchControlPointsEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRasterizerDiscardEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetRasterizerDiscardEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetRasterizerDiscardEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthBiasEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthBiasEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthBiasEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLogicOpEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void> Invoke = handle;

        public static explicit operator VkCmdSetLogicOpEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetLogicOpEXT((delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLogicOp, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCmdSetPrimitiveRestartEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetPrimitiveRestartEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetPrimitiveRestartEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetColorWriteEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, Brutal.Bool32*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, Brutal.Bool32*, void> Invoke = handle;

        public static explicit operator VkCmdSetColorWriteEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetColorWriteEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, Brutal.Bool32*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMultiEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMultiDrawInfoEXT*, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkMultiDrawInfoEXT*,
            int,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawMultiEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMultiEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMultiDrawInfoEXT*, int, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMultiIndexedEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMultiDrawIndexedInfoEXT*, int, int, int, int*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkMultiDrawIndexedInfoEXT*,
            int,
            int,
            int,
            int*,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawMultiIndexedEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMultiIndexedEXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkMultiDrawIndexedInfoEXT*,
                    int,
                    int,
                    int,
                    int*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateMicromapEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMicromapCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkMicromapEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMicromapCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkMicromapEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateMicromapEXT(PfnVkVoidFunction func)
        {
            return new VkCreateMicromapEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkMicromapCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkMicromapEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyMicromapEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyMicromapEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyMicromapEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMicromapEXT, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBuildMicromapsEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMicromapBuildInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMicromapBuildInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdBuildMicromapsEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBuildMicromapsEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMicromapBuildInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBuildMicromapsEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, int, VkMicromapBuildInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            int,
            VkMicromapBuildInfoEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkBuildMicromapsEXT(PfnVkVoidFunction func)
        {
            return new VkBuildMicromapsEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, int, VkMicromapBuildInfoEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyMicromapEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyMicromapInfoEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCopyMicromapEXT(PfnVkVoidFunction func)
        {
            return new VkCopyMicromapEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapInfoEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyMicromapToMemoryEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyMicromapToMemoryInfoEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCopyMicromapToMemoryEXT(PfnVkVoidFunction func)
        {
            return new VkCopyMicromapToMemoryEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMicromapToMemoryInfoEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyMemoryToMicromapEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyMemoryToMicromapInfoEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCopyMemoryToMicromapEXT(PfnVkVoidFunction func)
        {
            return new VkCopyMemoryToMicromapEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToMicromapInfoEXT*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWriteMicromapsPropertiesEXT(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkMicromapEXT*,
            VkQueryType,
            nuint,
            void*,
            nuint,
            VkResult> Invoke = handle;

        public static explicit operator VkWriteMicromapsPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkWriteMicromapsPropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkMicromapEXT*, VkQueryType, nuint, void*, nuint, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMicromapEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdCopyMicromapEXT(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMicromapEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMicromapToMemoryEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdCopyMicromapToMemoryEXT(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMicromapToMemoryEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMicromapToMemoryInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryToMicromapEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdCopyMemoryToMicromapEXT(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryToMicromapEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToMicromapInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteMicromapsPropertiesEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMicromapEXT*, VkQueryType, VkQueryPool, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkMicromapEXT*,
            VkQueryType,
            VkQueryPool,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteMicromapsPropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkCmdWriteMicromapsPropertiesEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkMicromapEXT*, VkQueryType, VkQueryPool, int, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceMicromapCompatibilityEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMicromapVersionInfoEXT*,
            VkAccelerationStructureCompatibilityKHR*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMicromapVersionInfoEXT*,
            VkAccelerationStructureCompatibilityKHR*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceMicromapCompatibilityEXT(PfnVkVoidFunction func)
        {
            return new VkGetDeviceMicromapCompatibilityEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkMicromapVersionInfoEXT*,
                    VkAccelerationStructureCompatibilityKHR*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMicromapBuildSizesEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureBuildTypeKHR,
            VkMicromapBuildInfoEXT*,
            VkMicromapBuildSizesInfoEXT*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureBuildTypeKHR,
            VkMicromapBuildInfoEXT*,
            VkMicromapBuildSizesInfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkGetMicromapBuildSizesEXT(PfnVkVoidFunction func)
        {
            return new VkGetMicromapBuildSizesEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureBuildTypeKHR,
                    VkMicromapBuildInfoEXT*,
                    VkMicromapBuildSizesInfoEXT*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawClusterHUAWEI(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDrawClusterHUAWEI(PfnVkVoidFunction func)
        {
            return new VkCmdDrawClusterHUAWEI(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawClusterIndirectHUAWEI(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, void> Invoke = handle;

        public static explicit operator VkCmdDrawClusterIndirectHUAWEI(PfnVkVoidFunction func)
        {
            return new VkCmdDrawClusterIndirectHUAWEI(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetDeviceMemoryPriorityEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void> Invoke = handle;

        public static explicit operator VkSetDeviceMemoryPriorityEXT(PfnVkVoidFunction func)
        {
            return new VkSetDeviceMemoryPriorityEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDispatchParametersARM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchParametersARM*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchParametersARM*, void> Invoke = handle;

        public static explicit operator VkCmdSetDispatchParametersARM(PfnVkVoidFunction func)
        {
            return new VkCmdSetDispatchParametersARM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDispatchParametersARM*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDescriptorSetLayoutHostMappingInfoVALVE(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetBindingReferenceVALVE*,
            VkDescriptorSetLayoutHostMappingInfoVALVE*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDescriptorSetBindingReferenceVALVE*,
            VkDescriptorSetLayoutHostMappingInfoVALVE*,
            void> Invoke = handle;

        public static explicit operator VkGetDescriptorSetLayoutHostMappingInfoVALVE(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorSetLayoutHostMappingInfoVALVE(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDescriptorSetBindingReferenceVALVE*,
                    VkDescriptorSetLayoutHostMappingInfoVALVE*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDescriptorSetHostMappingVALVE(
        delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, void**, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, void**, void> Invoke = handle;

        public static explicit operator VkGetDescriptorSetHostMappingVALVE(PfnVkVoidFunction func)
        {
            return new VkGetDescriptorSetHostMappingVALVE(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, void**, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryIndirectNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, int, int, void> Invoke = handle;

        public static explicit operator VkCmdCopyMemoryIndirectNV(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryIndirectNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryToImageIndirectNV(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddress,
            int,
            int,
            VkImage,
            VkImageLayout,
            VkImageSubresourceLayers*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddress,
            int,
            int,
            VkImage,
            VkImageLayout,
            VkImageSubresourceLayers*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyMemoryToImageIndirectNV(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryToImageIndirectNV(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkDeviceAddress,
                    int,
                    int,
                    VkImage,
                    VkImageLayout,
                    VkImageSubresourceLayers*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDecompressMemoryNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkDecompressMemoryRegionNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkDecompressMemoryRegionNV*, void> Invoke =
            handle;

        public static explicit operator VkCmdDecompressMemoryNV(PfnVkVoidFunction func)
        {
            return new VkCmdDecompressMemoryNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkDecompressMemoryRegionNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDecompressMemoryIndirectCountNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDeviceAddress,
            VkDeviceAddress,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDecompressMemoryIndirectCountNV(PfnVkVoidFunction func)
        {
            return new VkCmdDecompressMemoryIndirectCountNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineIndirectMemoryRequirementsNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkComputePipelineCreateInfo*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetPipelineIndirectMemoryRequirementsNV(PfnVkVoidFunction func)
        {
            return new VkGetPipelineIndirectMemoryRequirementsNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdUpdatePipelineIndirectBufferNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> Invoke =
            handle;

        public static explicit operator VkCmdUpdatePipelineIndirectBufferNV(PfnVkVoidFunction func)
        {
            return new VkCmdUpdatePipelineIndirectBufferNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPipelineIndirectDeviceAddressNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipelineIndirectDeviceAddressInfoNV*,
            VkDeviceAddress> Invoke = handle;

        public static explicit operator VkGetPipelineIndirectDeviceAddressNV(PfnVkVoidFunction func)
        {
            return new VkGetPipelineIndirectDeviceAddressNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthClampEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthClampEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthClampEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPolygonModeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPolygonMode, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPolygonMode, void> Invoke = handle;

        public static explicit operator VkCmdSetPolygonModeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetPolygonModeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPolygonMode, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRasterizationSamplesEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, void> Invoke = handle;

        public static explicit operator VkCmdSetRasterizationSamplesEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetRasterizationSamplesEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetSampleMaskEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, VkSampleMask*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, VkSampleMask*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetSampleMaskEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetSampleMaskEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkSampleCountFlags, VkSampleMask*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetAlphaToCoverageEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetAlphaToCoverageEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetAlphaToCoverageEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetAlphaToOneEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetAlphaToOneEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetAlphaToOneEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLogicOpEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetLogicOpEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetLogicOpEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetColorBlendEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, Brutal.Bool32*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, Brutal.Bool32*, void> Invoke = handle;

        public static explicit operator VkCmdSetColorBlendEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetColorBlendEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, Brutal.Bool32*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetColorBlendEquationEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorBlendEquationEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorBlendEquationEXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetColorBlendEquationEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetColorBlendEquationEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorBlendEquationEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetColorWriteMaskEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorComponentFlags*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorComponentFlags*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetColorWriteMaskEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetColorWriteMaskEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorComponentFlags*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetTessellationDomainOriginEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTessellationDomainOrigin, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTessellationDomainOrigin, void> Invoke = handle;

        public static explicit operator VkCmdSetTessellationDomainOriginEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetTessellationDomainOriginEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTessellationDomainOrigin, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRasterizationStreamEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetRasterizationStreamEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetRasterizationStreamEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetConservativeRasterizationModeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConservativeRasterizationModeEXT, void> Invoke =
            handle;

        public static explicit operator VkCmdSetConservativeRasterizationModeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetConservativeRasterizationModeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkConservativeRasterizationModeEXT, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetExtraPrimitiveOverestimationSizeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void> Invoke = handle;

        public static explicit operator VkCmdSetExtraPrimitiveOverestimationSizeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetExtraPrimitiveOverestimationSizeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, float, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthClipEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthClipEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthClipEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetSampleLocationsEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetSampleLocationsEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetSampleLocationsEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetColorBlendAdvancedEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorBlendAdvancedEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorBlendAdvancedEXT*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetColorBlendAdvancedEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetColorBlendAdvancedEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkColorBlendAdvancedEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetProvokingVertexModeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkProvokingVertexModeEXT, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkProvokingVertexModeEXT, void> Invoke = handle;

        public static explicit operator VkCmdSetProvokingVertexModeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetProvokingVertexModeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkProvokingVertexModeEXT, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLineRasterizationModeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLineRasterizationModeEXT, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLineRasterizationModeEXT, void> Invoke = handle;

        public static explicit operator VkCmdSetLineRasterizationModeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetLineRasterizationModeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkLineRasterizationModeEXT, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetLineStippleEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetLineStippleEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetLineStippleEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthClipNegativeOneToOneEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetDepthClipNegativeOneToOneEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthClipNegativeOneToOneEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetViewportWScalingEnableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetViewportWScalingEnableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewportWScalingEnableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetViewportSwizzleNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewportSwizzleNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewportSwizzleNV*, void> Invoke =
            handle;

        public static explicit operator VkCmdSetViewportSwizzleNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetViewportSwizzleNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, VkViewportSwizzleNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoverageToColorEnableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetCoverageToColorEnableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoverageToColorEnableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoverageToColorLocationNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetCoverageToColorLocationNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoverageToColorLocationNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoverageModulationModeNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageModulationModeNV, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageModulationModeNV, void> Invoke = handle;

        public static explicit operator VkCmdSetCoverageModulationModeNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoverageModulationModeNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageModulationModeNV, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoverageModulationTableEnableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetCoverageModulationTableEnableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoverageModulationTableEnableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoverageModulationTableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, float*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, float*, void> Invoke = handle;

        public static explicit operator VkCmdSetCoverageModulationTableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoverageModulationTableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, float*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetShadingRateImageEnableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetShadingRateImageEnableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetShadingRateImageEnableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRepresentativeFragmentTestEnableNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void> Invoke = handle;

        public static explicit operator VkCmdSetRepresentativeFragmentTestEnableNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetRepresentativeFragmentTestEnableNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetCoverageReductionModeNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageReductionModeNV, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageReductionModeNV, void> Invoke = handle;

        public static explicit operator VkCmdSetCoverageReductionModeNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetCoverageReductionModeNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoverageReductionModeNV, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateTensorARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorCreateInfoARM*,
            VkAllocationCallbacks*,
            VkTensorARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorCreateInfoARM*,
            VkAllocationCallbacks*,
            VkTensorARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateTensorARM(PfnVkVoidFunction func)
        {
            return new VkCreateTensorARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkTensorCreateInfoARM*,
                    VkAllocationCallbacks*,
                    VkTensorARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyTensorARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkTensorARM, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkTensorARM, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyTensorARM(PfnVkVoidFunction func)
        {
            return new VkDestroyTensorARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkTensorARM, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateTensorViewARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorViewCreateInfoARM*,
            VkAllocationCallbacks*,
            VkTensorViewARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorViewCreateInfoARM*,
            VkAllocationCallbacks*,
            VkTensorViewARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateTensorViewARM(PfnVkVoidFunction func)
        {
            return new VkCreateTensorViewARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkTensorViewCreateInfoARM*,
                    VkAllocationCallbacks*,
                    VkTensorViewARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyTensorViewARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkTensorViewARM, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkTensorViewARM, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VkDestroyTensorViewARM(PfnVkVoidFunction func)
        {
            return new VkDestroyTensorViewARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkTensorViewARM, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetTensorMemoryRequirementsARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkTensorMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorMemoryRequirementsInfoARM*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetTensorMemoryRequirementsARM(PfnVkVoidFunction func)
        {
            return new VkGetTensorMemoryRequirementsARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkTensorMemoryRequirementsInfoARM*, VkMemoryRequirements2*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindTensorMemoryARM(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindTensorMemoryInfoARM*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, int, VkBindTensorMemoryInfoARM*, VkResult> Invoke = handle;

        public static explicit operator VkBindTensorMemoryARM(PfnVkVoidFunction func)
        {
            return new VkBindTensorMemoryARM(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindTensorMemoryInfoARM*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceTensorMemoryRequirementsARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceTensorMemoryRequirementsARM*, VkMemoryRequirements2*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceTensorMemoryRequirementsARM*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceTensorMemoryRequirementsARM(PfnVkVoidFunction func)
        {
            return new VkGetDeviceTensorMemoryRequirementsARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeviceTensorMemoryRequirementsARM*,
                    VkMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyTensorARM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyTensorInfoARM*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyTensorInfoARM*, void> Invoke = handle;

        public static explicit operator VkCmdCopyTensorARM(PfnVkVoidFunction func)
        {
            return new VkCmdCopyTensorARM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyTensorInfoARM*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalTensorPropertiesARM(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalTensorInfoARM*,
            VkExternalTensorPropertiesARM*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceExternalTensorInfoARM*,
            VkExternalTensorPropertiesARM*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceExternalTensorPropertiesARM(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceExternalTensorPropertiesARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceExternalTensorInfoARM*,
                    VkExternalTensorPropertiesARM*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetTensorOpaqueCaptureDescriptorDataARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkTensorCaptureDescriptorDataInfoARM*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorCaptureDescriptorDataInfoARM*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetTensorOpaqueCaptureDescriptorDataARM(PfnVkVoidFunction func)
        {
            return new VkGetTensorOpaqueCaptureDescriptorDataARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkTensorCaptureDescriptorDataInfoARM*, void*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetTensorViewOpaqueCaptureDescriptorDataARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkTensorViewCaptureDescriptorDataInfoARM*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkTensorViewCaptureDescriptorDataInfoARM*,
            void*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetTensorViewOpaqueCaptureDescriptorDataARM(PfnVkVoidFunction func)
        {
            return new VkGetTensorViewOpaqueCaptureDescriptorDataARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkTensorViewCaptureDescriptorDataInfoARM*, void*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetShaderModuleIdentifierEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderModule,
            VkShaderModuleIdentifierEXT*,
            void> Invoke = handle;

        public static explicit operator VkGetShaderModuleIdentifierEXT(PfnVkVoidFunction func)
        {
            return new VkGetShaderModuleIdentifierEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetShaderModuleCreateInfoIdentifierEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderModuleCreateInfo*,
            VkShaderModuleIdentifierEXT*,
            void> Invoke = handle;

        public static explicit operator VkGetShaderModuleCreateInfoIdentifierEXT(PfnVkVoidFunction func)
        {
            return new VkGetShaderModuleCreateInfoIdentifierEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceOpticalFlowImageFormatsNV(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkOpticalFlowImageFormatInfoNV*,
            int*,
            VkOpticalFlowImageFormatPropertiesNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkOpticalFlowImageFormatInfoNV*,
            int*,
            VkOpticalFlowImageFormatPropertiesNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceOpticalFlowImageFormatsNV(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceOpticalFlowImageFormatsNV(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkOpticalFlowImageFormatInfoNV*,
                    int*,
                    VkOpticalFlowImageFormatPropertiesNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateOpticalFlowSessionNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkOpticalFlowSessionCreateInfoNV*,
            VkAllocationCallbacks*,
            VkOpticalFlowSessionNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkOpticalFlowSessionCreateInfoNV*,
            VkAllocationCallbacks*,
            VkOpticalFlowSessionNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateOpticalFlowSessionNV(PfnVkVoidFunction func)
        {
            return new VkCreateOpticalFlowSessionNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkOpticalFlowSessionCreateInfoNV*,
                    VkAllocationCallbacks*,
                    VkOpticalFlowSessionNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyOpticalFlowSessionNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkOpticalFlowSessionNV,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyOpticalFlowSessionNV(PfnVkVoidFunction func)
        {
            return new VkDestroyOpticalFlowSessionNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkOpticalFlowSessionNV, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindOpticalFlowSessionImageNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkOpticalFlowSessionNV,
            VkOpticalFlowSessionBindingPointNV,
            VkImageView,
            VkImageLayout,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkOpticalFlowSessionNV,
            VkOpticalFlowSessionBindingPointNV,
            VkImageView,
            VkImageLayout,
            VkResult> Invoke = handle;

        public static explicit operator VkBindOpticalFlowSessionImageNV(PfnVkVoidFunction func)
        {
            return new VkBindOpticalFlowSessionImageNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkOpticalFlowSessionNV,
                    VkOpticalFlowSessionBindingPointNV,
                    VkImageView,
                    VkImageLayout,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdOpticalFlowExecuteNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkOpticalFlowSessionNV,
            VkOpticalFlowExecuteInfoNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdOpticalFlowExecuteNV(PfnVkVoidFunction func)
        {
            return new VkCmdOpticalFlowExecuteNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkOpticalFlowSessionNV, VkOpticalFlowExecuteInfoNV*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAntiLagUpdateAMD(
        delegate* unmanaged[Cdecl]<VkDevice, VkAntiLagDataAMD*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkAntiLagDataAMD*, void> Invoke = handle;

        public static explicit operator VkAntiLagUpdateAMD(PfnVkVoidFunction func)
        {
            return new VkAntiLagUpdateAMD((delegate* unmanaged[Cdecl]<VkDevice, VkAntiLagDataAMD*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkCreateShadersEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkShaderCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkShaderEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkShaderCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkShaderEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateShadersEXT(PfnVkVoidFunction func)
        {
            return new VkCreateShadersEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    int,
                    VkShaderCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkShaderEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyShaderEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void> Invoke = handle;

        public static explicit operator VkDestroyShaderEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyShaderEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetShaderBinaryDataEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, nuint*, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, nuint*, void*, VkResult> Invoke = handle;

        public static explicit operator VkGetShaderBinaryDataEXT(PfnVkVoidFunction func)
        {
            return new VkGetShaderBinaryDataEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderEXT, nuint*, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindShadersEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkShaderStageFlags*, VkShaderEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkShaderStageFlags*,
            VkShaderEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdBindShadersEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBindShadersEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkShaderStageFlags*, VkShaderEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetDepthClampRangeEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDepthClampModeEXT,
            VkDepthClampRangeEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetDepthClampRangeEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetDepthClampRangeEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetFramebufferTilePropertiesQCOM(
        delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, int*, VkTilePropertiesQCOM*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkFramebuffer,
            int*,
            VkTilePropertiesQCOM*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetFramebufferTilePropertiesQCOM(PfnVkVoidFunction func)
        {
            return new VkGetFramebufferTilePropertiesQCOM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, int*, VkTilePropertiesQCOM*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDynamicRenderingTilePropertiesQCOM(
        delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetDynamicRenderingTilePropertiesQCOM(PfnVkVoidFunction func)
        {
            return new VkGetDynamicRenderingTilePropertiesQCOM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCooperativeVectorPropertiesNV(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkCooperativeVectorPropertiesNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkCooperativeVectorPropertiesNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceCooperativeVectorPropertiesNV(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceCooperativeVectorPropertiesNV(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int*, VkCooperativeVectorPropertiesNV*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkConvertCooperativeVectorMatrixNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkConvertCooperativeVectorMatrixInfoNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkConvertCooperativeVectorMatrixInfoNV*, VkResult> Invoke =
            handle;

        public static explicit operator VkConvertCooperativeVectorMatrixNV(PfnVkVoidFunction func)
        {
            return new VkConvertCooperativeVectorMatrixNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkConvertCooperativeVectorMatrixInfoNV*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdConvertCooperativeVectorMatrixNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkConvertCooperativeVectorMatrixInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkConvertCooperativeVectorMatrixInfoNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdConvertCooperativeVectorMatrixNV(PfnVkVoidFunction func)
        {
            return new VkCmdConvertCooperativeVectorMatrixNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, VkConvertCooperativeVectorMatrixInfoNV*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetLatencySleepModeNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSwapchainKHR,
            VkLatencySleepModeInfoNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkSetLatencySleepModeNV(PfnVkVoidFunction func)
        {
            return new VkSetLatencySleepModeNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkLatencySleepNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult> Invoke =
            handle;

        public static explicit operator VkLatencySleepNV(PfnVkVoidFunction func)
        {
            return new VkLatencySleepNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkSetLatencyMarkerNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void> Invoke =
            handle;

        public static explicit operator VkSetLatencyMarkerNV(PfnVkVoidFunction func)
        {
            return new VkSetLatencyMarkerNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetLatencyTimingsNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void> Invoke =
            handle;

        public static explicit operator VkGetLatencyTimingsNV(PfnVkVoidFunction func)
        {
            return new VkGetLatencyTimingsNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkGetLatencyMarkerInfoNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkQueueNotifyOutOfBandNV(
        delegate* unmanaged[Cdecl]<VkQueue, VkOutOfBandQueueTypeInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkQueue, VkOutOfBandQueueTypeInfoNV*, void> Invoke = handle;

        public static explicit operator VkQueueNotifyOutOfBandNV(PfnVkVoidFunction func)
        {
            return new VkQueueNotifyOutOfBandNV(
                (delegate* unmanaged[Cdecl]<VkQueue, VkOutOfBandQueueTypeInfoNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDataGraphPipelinesARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkPipelineCache,
            int,
            VkDataGraphPipelineCreateInfoARM*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkPipelineCache,
            int,
            VkDataGraphPipelineCreateInfoARM*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDataGraphPipelinesARM(PfnVkVoidFunction func)
        {
            return new VkCreateDataGraphPipelinesARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeferredOperationKHR,
                    VkPipelineCache,
                    int,
                    VkDataGraphPipelineCreateInfoARM*,
                    VkAllocationCallbacks*,
                    VkPipeline*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateDataGraphPipelineSessionARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionCreateInfoARM*,
            VkAllocationCallbacks*,
            VkDataGraphPipelineSessionARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionCreateInfoARM*,
            VkAllocationCallbacks*,
            VkDataGraphPipelineSessionARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateDataGraphPipelineSessionARM(PfnVkVoidFunction func)
        {
            return new VkCreateDataGraphPipelineSessionARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDataGraphPipelineSessionCreateInfoARM*,
                    VkAllocationCallbacks*,
                    VkDataGraphPipelineSessionARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDataGraphPipelineSessionBindPointRequirementsARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionBindPointRequirementsInfoARM*,
            int*,
            VkDataGraphPipelineSessionBindPointRequirementARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionBindPointRequirementsInfoARM*,
            int*,
            VkDataGraphPipelineSessionBindPointRequirementARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDataGraphPipelineSessionBindPointRequirementsARM(PfnVkVoidFunction func)
        {
            return new VkGetDataGraphPipelineSessionBindPointRequirementsARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDataGraphPipelineSessionBindPointRequirementsInfoARM*,
                    int*,
                    VkDataGraphPipelineSessionBindPointRequirementARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDataGraphPipelineSessionMemoryRequirementsARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionMemoryRequirementsInfoARM*,
            VkMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionMemoryRequirementsInfoARM*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetDataGraphPipelineSessionMemoryRequirementsARM(PfnVkVoidFunction func)
        {
            return new VkGetDataGraphPipelineSessionMemoryRequirementsARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDataGraphPipelineSessionMemoryRequirementsInfoARM*,
                    VkMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBindDataGraphPipelineSessionMemoryARM(
        delegate* unmanaged[Cdecl]<VkDevice, int, VkBindDataGraphPipelineSessionMemoryInfoARM*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkBindDataGraphPipelineSessionMemoryInfoARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkBindDataGraphPipelineSessionMemoryARM(PfnVkVoidFunction func)
        {
            return new VkBindDataGraphPipelineSessionMemoryARM(
                (delegate* unmanaged[Cdecl]<VkDevice, int, VkBindDataGraphPipelineSessionMemoryInfoARM*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyDataGraphPipelineSessionARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkDataGraphPipelineSessionARM, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineSessionARM,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyDataGraphPipelineSessionARM(PfnVkVoidFunction func)
        {
            return new VkDestroyDataGraphPipelineSessionARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkDataGraphPipelineSessionARM, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDispatchDataGraphARM(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDataGraphPipelineSessionARM,
            VkDataGraphPipelineDispatchInfoARM*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkDataGraphPipelineSessionARM,
            VkDataGraphPipelineDispatchInfoARM*,
            void> Invoke = handle;

        public static explicit operator VkCmdDispatchDataGraphARM(PfnVkVoidFunction func)
        {
            return new VkCmdDispatchDataGraphARM(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkDataGraphPipelineSessionARM,
                    VkDataGraphPipelineDispatchInfoARM*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDataGraphPipelineAvailablePropertiesARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineInfoARM*,
            int*,
            VkDataGraphPipelinePropertyARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineInfoARM*,
            int*,
            VkDataGraphPipelinePropertyARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDataGraphPipelineAvailablePropertiesARM(PfnVkVoidFunction func)
        {
            return new VkGetDataGraphPipelineAvailablePropertiesARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDataGraphPipelineInfoARM*,
                    int*,
                    VkDataGraphPipelinePropertyARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDataGraphPipelinePropertiesARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineInfoARM*,
            int,
            VkDataGraphPipelinePropertyQueryResultARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDataGraphPipelineInfoARM*,
            int,
            VkDataGraphPipelinePropertyQueryResultARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDataGraphPipelinePropertiesARM(PfnVkVoidFunction func)
        {
            return new VkGetDataGraphPipelinePropertiesARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDataGraphPipelineInfoARM*,
                    int,
                    VkDataGraphPipelinePropertyQueryResultARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, int*, VkQueueFamilyDataGraphPropertiesARM*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            int*,
            VkQueueFamilyDataGraphPropertiesARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceQueueFamilyDataGraphPropertiesARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int,
                    int*,
                    VkQueueFamilyDataGraphPropertiesARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM*,
            VkQueueFamilyDataGraphProcessingEnginePropertiesARM*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM*,
            VkQueueFamilyDataGraphProcessingEnginePropertiesARM*,
            void> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
            PfnVkVoidFunction func
        )
        {
            return new VkGetPhysicalDeviceQueueFamilyDataGraphProcessingEnginePropertiesARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceQueueFamilyDataGraphProcessingEngineInfoARM*,
                    VkQueueFamilyDataGraphProcessingEnginePropertiesARM*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            VkQueueFamilyDataGraphPropertiesARM*,
            VkBaseOutStructure*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            VkQueueFamilyDataGraphPropertiesARM*,
            VkBaseOutStructure*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
            PfnVkVoidFunction func
        )
        {
            return new VkGetPhysicalDeviceQueueFamilyDataGraphEngineOperationPropertiesARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int,
                    VkQueueFamilyDataGraphPropertiesARM*,
                    VkBaseOutStructure*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetAttachmentFeedbackLoopEnableEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void> Invoke = handle;

        public static explicit operator VkCmdSetAttachmentFeedbackLoopEnableEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetAttachmentFeedbackLoopEnableEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageAspectFlags, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBindTileMemoryQCOM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTileMemoryBindInfoQCOM*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTileMemoryBindInfoQCOM*, void> Invoke = handle;

        public static explicit operator VkCmdBindTileMemoryQCOM(PfnVkVoidFunction func)
        {
            return new VkCmdBindTileMemoryQCOM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkTileMemoryBindInfoQCOM*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDecompressMemoryEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDecompressMemoryInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDecompressMemoryInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdDecompressMemoryEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDecompressMemoryEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDecompressMemoryInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDecompressMemoryIndirectCountEXT(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkMemoryDecompressionMethodFlagsEXT,
            VkDeviceAddress,
            VkDeviceAddress,
            int,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkMemoryDecompressionMethodFlagsEXT,
            VkDeviceAddress,
            VkDeviceAddress,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDecompressMemoryIndirectCountEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDecompressMemoryIndirectCountEXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkMemoryDecompressionMethodFlagsEXT,
                    VkDeviceAddress,
                    VkDeviceAddress,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateExternalComputeQueueNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalComputeQueueCreateInfoNV*,
            VkAllocationCallbacks*,
            VkExternalComputeQueueNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalComputeQueueCreateInfoNV*,
            VkAllocationCallbacks*,
            VkExternalComputeQueueNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateExternalComputeQueueNV(PfnVkVoidFunction func)
        {
            return new VkCreateExternalComputeQueueNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkExternalComputeQueueCreateInfoNV*,
                    VkAllocationCallbacks*,
                    VkExternalComputeQueueNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyExternalComputeQueueNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkExternalComputeQueueNV, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalComputeQueueNV,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyExternalComputeQueueNV(PfnVkVoidFunction func)
        {
            return new VkDestroyExternalComputeQueueNV(
                (delegate* unmanaged[Cdecl]<VkDevice, VkExternalComputeQueueNV, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetExternalComputeQueueDataNV(
        delegate* unmanaged[Cdecl]<VkExternalComputeQueueNV, VkExternalComputeQueueDataParamsNV*, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkExternalComputeQueueNV,
            VkExternalComputeQueueDataParamsNV*,
            void*,
            void> Invoke = handle;

        public static explicit operator VkGetExternalComputeQueueDataNV(PfnVkVoidFunction func)
        {
            return new VkGetExternalComputeQueueDataNV(
                (delegate* unmanaged[Cdecl]<VkExternalComputeQueueNV, VkExternalComputeQueueDataParamsNV*, void*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetClusterAccelerationStructureBuildSizesNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkClusterAccelerationStructureInputInfoNV*,
            VkAccelerationStructureBuildSizesInfoKHR*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkClusterAccelerationStructureInputInfoNV*,
            VkAccelerationStructureBuildSizesInfoKHR*,
            void> Invoke = handle;

        public static explicit operator VkGetClusterAccelerationStructureBuildSizesNV(PfnVkVoidFunction func)
        {
            return new VkGetClusterAccelerationStructureBuildSizesNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkClusterAccelerationStructureInputInfoNV*,
                    VkAccelerationStructureBuildSizesInfoKHR*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBuildClusterAccelerationStructureIndirectNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkClusterAccelerationStructureCommandsInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkClusterAccelerationStructureCommandsInfoNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdBuildClusterAccelerationStructureIndirectNV(PfnVkVoidFunction func)
        {
            return new VkCmdBuildClusterAccelerationStructureIndirectNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkClusterAccelerationStructureCommandsInfoNV*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPartitionedAccelerationStructuresBuildSizesNV(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPartitionedAccelerationStructureInstancesInputNV*,
            VkAccelerationStructureBuildSizesInfoKHR*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPartitionedAccelerationStructureInstancesInputNV*,
            VkAccelerationStructureBuildSizesInfoKHR*,
            void> Invoke = handle;

        public static explicit operator VkGetPartitionedAccelerationStructuresBuildSizesNV(PfnVkVoidFunction func)
        {
            return new VkGetPartitionedAccelerationStructuresBuildSizesNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPartitionedAccelerationStructureInstancesInputNV*,
                    VkAccelerationStructureBuildSizesInfoKHR*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBuildPartitionedAccelerationStructuresNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuildPartitionedAccelerationStructureInfoNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuildPartitionedAccelerationStructureInfoNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdBuildPartitionedAccelerationStructuresNV(PfnVkVoidFunction func)
        {
            return new VkCmdBuildPartitionedAccelerationStructuresNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuildPartitionedAccelerationStructureInfoNV*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetGeneratedCommandsMemoryRequirementsEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkGeneratedCommandsMemoryRequirementsInfoEXT*,
            VkMemoryRequirements2*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkGeneratedCommandsMemoryRequirementsInfoEXT*,
            VkMemoryRequirements2*,
            void> Invoke = handle;

        public static explicit operator VkGetGeneratedCommandsMemoryRequirementsEXT(PfnVkVoidFunction func)
        {
            return new VkGetGeneratedCommandsMemoryRequirementsEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkGeneratedCommandsMemoryRequirementsInfoEXT*,
                    VkMemoryRequirements2*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdPreprocessGeneratedCommandsEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkGeneratedCommandsInfoEXT*,
            VkCommandBuffer,
            void> Invoke = handle;

        public static explicit operator VkCmdPreprocessGeneratedCommandsEXT(PfnVkVoidFunction func)
        {
            return new VkCmdPreprocessGeneratedCommandsEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkGeneratedCommandsInfoEXT*, VkCommandBuffer, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdExecuteGeneratedCommandsEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, VkGeneratedCommandsInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            Brutal.Bool32,
            VkGeneratedCommandsInfoEXT*,
            void> Invoke = handle;

        public static explicit operator VkCmdExecuteGeneratedCommandsEXT(PfnVkVoidFunction func)
        {
            return new VkCmdExecuteGeneratedCommandsEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, Brutal.Bool32, VkGeneratedCommandsInfoEXT*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateIndirectCommandsLayoutEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectCommandsLayoutCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkIndirectCommandsLayoutEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectCommandsLayoutCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkIndirectCommandsLayoutEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateIndirectCommandsLayoutEXT(PfnVkVoidFunction func)
        {
            return new VkCreateIndirectCommandsLayoutEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkIndirectCommandsLayoutCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkIndirectCommandsLayoutEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyIndirectCommandsLayoutEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectCommandsLayoutEXT,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyIndirectCommandsLayoutEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyIndirectCommandsLayoutEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkIndirectCommandsLayoutEXT, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateIndirectExecutionSetEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkIndirectExecutionSetEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkIndirectExecutionSetEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateIndirectExecutionSetEXT(PfnVkVoidFunction func)
        {
            return new VkCreateIndirectExecutionSetEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkIndirectExecutionSetCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkIndirectExecutionSetEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyIndirectExecutionSetEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetEXT,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyIndirectExecutionSetEXT(PfnVkVoidFunction func)
        {
            return new VkDestroyIndirectExecutionSetEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkIndirectExecutionSetEXT, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUpdateIndirectExecutionSetPipelineEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetEXT,
            int,
            VkWriteIndirectExecutionSetPipelineEXT*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetEXT,
            int,
            VkWriteIndirectExecutionSetPipelineEXT*,
            void> Invoke = handle;

        public static explicit operator VkUpdateIndirectExecutionSetPipelineEXT(PfnVkVoidFunction func)
        {
            return new VkUpdateIndirectExecutionSetPipelineEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkIndirectExecutionSetEXT,
                    int,
                    VkWriteIndirectExecutionSetPipelineEXT*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkUpdateIndirectExecutionSetShaderEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetEXT,
            int,
            VkWriteIndirectExecutionSetShaderEXT*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkIndirectExecutionSetEXT,
            int,
            VkWriteIndirectExecutionSetShaderEXT*,
            void> Invoke = handle;

        public static explicit operator VkUpdateIndirectExecutionSetShaderEXT(PfnVkVoidFunction func)
        {
            return new VkUpdateIndirectExecutionSetShaderEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkIndirectExecutionSetEXT,
                    int,
                    VkWriteIndirectExecutionSetShaderEXT*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkCooperativeMatrixFlexibleDimensionsPropertiesNV*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkCooperativeMatrixFlexibleDimensionsPropertiesNV*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
            PfnVkVoidFunction func
        )
        {
            return new VkGetPhysicalDeviceCooperativeMatrixFlexibleDimensionsPropertiesNV(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int*,
                    VkCooperativeMatrixFlexibleDimensionsPropertiesNV*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            int*,
            VkPerformanceCounterARM*,
            VkPerformanceCounterDescriptionARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            int*,
            VkPerformanceCounterARM*,
            VkPerformanceCounterDescriptionARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
            PfnVkVoidFunction func
        )
        {
            return new VkEnumeratePhysicalDeviceQueueFamilyPerformanceCountersByRegionARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int,
                    int*,
                    VkPerformanceCounterARM*,
                    VkPerformanceCounterDescriptionARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkShaderInstrumentationMetricDescriptionARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int*,
            VkShaderInstrumentationMetricDescriptionARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM(PfnVkVoidFunction func)
        {
            return new VkEnumeratePhysicalDeviceShaderInstrumentationMetricsARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int*,
                    VkShaderInstrumentationMetricDescriptionARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateShaderInstrumentationARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderInstrumentationCreateInfoARM*,
            VkAllocationCallbacks*,
            VkShaderInstrumentationARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderInstrumentationCreateInfoARM*,
            VkAllocationCallbacks*,
            VkShaderInstrumentationARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateShaderInstrumentationARM(PfnVkVoidFunction func)
        {
            return new VkCreateShaderInstrumentationARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkShaderInstrumentationCreateInfoARM*,
                    VkAllocationCallbacks*,
                    VkShaderInstrumentationARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyShaderInstrumentationARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderInstrumentationARM, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderInstrumentationARM,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyShaderInstrumentationARM(PfnVkVoidFunction func)
        {
            return new VkDestroyShaderInstrumentationARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderInstrumentationARM, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginShaderInstrumentationARM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkShaderInstrumentationARM, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkShaderInstrumentationARM, void> Invoke = handle;

        public static explicit operator VkCmdBeginShaderInstrumentationARM(PfnVkVoidFunction func)
        {
            return new VkCmdBeginShaderInstrumentationARM(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkShaderInstrumentationARM, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndShaderInstrumentationARM(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, void> Invoke = handle;

        public static explicit operator VkCmdEndShaderInstrumentationARM(PfnVkVoidFunction func)
        {
            return new VkCmdEndShaderInstrumentationARM((delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)func.Invoke);
        }
    }

    public readonly unsafe struct VkGetShaderInstrumentationValuesARM(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderInstrumentationARM,
            int*,
            void*,
            VkShaderInstrumentationValuesFlagsARM,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkShaderInstrumentationARM,
            int*,
            void*,
            VkShaderInstrumentationValuesFlagsARM,
            VkResult> Invoke = handle;

        public static explicit operator VkGetShaderInstrumentationValuesARM(PfnVkVoidFunction func)
        {
            return new VkGetShaderInstrumentationValuesARM(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkShaderInstrumentationARM,
                    int*,
                    void*,
                    VkShaderInstrumentationValuesFlagsARM,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkClearShaderInstrumentationMetricsARM(
        delegate* unmanaged[Cdecl]<VkDevice, VkShaderInstrumentationARM, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkShaderInstrumentationARM, void> Invoke = handle;

        public static explicit operator VkClearShaderInstrumentationMetricsARM(PfnVkVoidFunction func)
        {
            return new VkClearShaderInstrumentationMetricsARM(
                (delegate* unmanaged[Cdecl]<VkDevice, VkShaderInstrumentationARM, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdEndRendering2EXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingEndInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingEndInfoKHR*, void> Invoke = handle;

        public static explicit operator VkCmdEndRendering2EXT(PfnVkVoidFunction func)
        {
            return new VkCmdEndRendering2EXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkRenderingEndInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBeginCustomResolveEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBeginCustomResolveInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBeginCustomResolveInfoEXT*, void> Invoke = handle;

        public static explicit operator VkCmdBeginCustomResolveEXT(PfnVkVoidFunction func)
        {
            return new VkCmdBeginCustomResolveEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBeginCustomResolveInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            VkQueueFamilyDataGraphPropertiesARM*,
            VkDataGraphOpticalFlowImageFormatInfoARM*,
            int*,
            VkDataGraphOpticalFlowImageFormatPropertiesARM*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            int,
            VkQueueFamilyDataGraphPropertiesARM*,
            VkDataGraphOpticalFlowImageFormatInfoARM*,
            int*,
            VkDataGraphOpticalFlowImageFormatPropertiesARM*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
            PfnVkVoidFunction func
        )
        {
            return new VkGetPhysicalDeviceQueueFamilyDataGraphOpticalFlowImageFormatsARM(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    int,
                    VkQueueFamilyDataGraphPropertiesARM*,
                    VkDataGraphOpticalFlowImageFormatInfoARM*,
                    int*,
                    VkDataGraphOpticalFlowImageFormatPropertiesARM*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetComputeOccupancyPriorityNV(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkComputeOccupancyPriorityParametersNV*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkComputeOccupancyPriorityParametersNV*,
            void> Invoke = handle;

        public static explicit operator VkCmdSetComputeOccupancyPriorityNV(PfnVkVoidFunction func)
        {
            return new VkCmdSetComputeOccupancyPriorityNV(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkComputeOccupancyPriorityParametersNV*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetPrimitiveRestartIndexEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetPrimitiveRestartIndexEXT(PfnVkVoidFunction func)
        {
            return new VkCmdSetPrimitiveRestartIndexEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateAccelerationStructureKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkAccelerationStructureKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkAccelerationStructureKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateAccelerationStructureKHR(PfnVkVoidFunction func)
        {
            return new VkCreateAccelerationStructureKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkAccelerationStructureKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkDestroyAccelerationStructureKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureKHR,
            VkAllocationCallbacks*,
            void> Invoke = handle;

        public static explicit operator VkDestroyAccelerationStructureKHR(PfnVkVoidFunction func)
        {
            return new VkDestroyAccelerationStructureKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBuildAccelerationStructuresKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            VkAccelerationStructureBuildRangeInfoKHR**,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            VkAccelerationStructureBuildRangeInfoKHR**,
            void> Invoke = handle;

        public static explicit operator VkCmdBuildAccelerationStructuresKHR(PfnVkVoidFunction func)
        {
            return new VkCmdBuildAccelerationStructuresKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkAccelerationStructureBuildGeometryInfoKHR*,
                    VkAccelerationStructureBuildRangeInfoKHR**,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdBuildAccelerationStructuresIndirectKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            VkDeviceAddress*,
            int*,
            int**,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            VkDeviceAddress*,
            int*,
            int**,
            void> Invoke = handle;

        public static explicit operator VkCmdBuildAccelerationStructuresIndirectKHR(PfnVkVoidFunction func)
        {
            return new VkCmdBuildAccelerationStructuresIndirectKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkAccelerationStructureBuildGeometryInfoKHR*,
                    VkDeviceAddress*,
                    int*,
                    int**,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkBuildAccelerationStructuresKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            int,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            VkAccelerationStructureBuildRangeInfoKHR**,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            int,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            VkAccelerationStructureBuildRangeInfoKHR**,
            VkResult> Invoke = handle;

        public static explicit operator VkBuildAccelerationStructuresKHR(PfnVkVoidFunction func)
        {
            return new VkBuildAccelerationStructuresKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeferredOperationKHR,
                    int,
                    VkAccelerationStructureBuildGeometryInfoKHR*,
                    VkAccelerationStructureBuildRangeInfoKHR**,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyAccelerationStructureKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyAccelerationStructureInfoKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyAccelerationStructureInfoKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCopyAccelerationStructureKHR(PfnVkVoidFunction func)
        {
            return new VkCopyAccelerationStructureKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeferredOperationKHR,
                    VkCopyAccelerationStructureInfoKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyAccelerationStructureToMemoryKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyAccelerationStructureToMemoryInfoKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyAccelerationStructureToMemoryInfoKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCopyAccelerationStructureToMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCopyAccelerationStructureToMemoryKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeferredOperationKHR,
                    VkCopyAccelerationStructureToMemoryInfoKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCopyMemoryToAccelerationStructureKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyMemoryToAccelerationStructureInfoKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkCopyMemoryToAccelerationStructureInfoKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCopyMemoryToAccelerationStructureKHR(PfnVkVoidFunction func)
        {
            return new VkCopyMemoryToAccelerationStructureKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeferredOperationKHR,
                    VkCopyMemoryToAccelerationStructureInfoKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkWriteAccelerationStructuresPropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkAccelerationStructureKHR*,
            VkQueryType,
            nuint,
            void*,
            nuint,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            int,
            VkAccelerationStructureKHR*,
            VkQueryType,
            nuint,
            void*,
            nuint,
            VkResult> Invoke = handle;

        public static explicit operator VkWriteAccelerationStructuresPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkWriteAccelerationStructuresPropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    int,
                    VkAccelerationStructureKHR*,
                    VkQueryType,
                    nuint,
                    void*,
                    nuint,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyAccelerationStructureKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> Invoke =
            handle;

        public static explicit operator VkCmdCopyAccelerationStructureKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyAccelerationStructureKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyAccelerationStructureToMemoryKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkCopyAccelerationStructureToMemoryInfoKHR*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyAccelerationStructureToMemoryKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyAccelerationStructureToMemoryKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryToAccelerationStructureKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkCopyMemoryToAccelerationStructureInfoKHR*,
            void> Invoke = handle;

        public static explicit operator VkCmdCopyMemoryToAccelerationStructureKHR(PfnVkVoidFunction func)
        {
            return new VkCmdCopyMemoryToAccelerationStructureKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureDeviceAddressKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, VkDeviceAddress> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureDeviceAddressInfoKHR*,
            VkDeviceAddress> Invoke = handle;

        public static explicit operator VkGetAccelerationStructureDeviceAddressKHR(PfnVkVoidFunction func)
        {
            return new VkGetAccelerationStructureDeviceAddressKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, VkDeviceAddress>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdWriteAccelerationStructuresPropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureKHR*,
            VkQueryType,
            VkQueryPool,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            int,
            VkAccelerationStructureKHR*,
            VkQueryType,
            VkQueryPool,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdWriteAccelerationStructuresPropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkCmdWriteAccelerationStructuresPropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    int,
                    VkAccelerationStructureKHR*,
                    VkQueryType,
                    VkQueryPool,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceAccelerationStructureCompatibilityKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureVersionInfoKHR*,
            VkAccelerationStructureCompatibilityKHR*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureVersionInfoKHR*,
            VkAccelerationStructureCompatibilityKHR*,
            void> Invoke = handle;

        public static explicit operator VkGetDeviceAccelerationStructureCompatibilityKHR(PfnVkVoidFunction func)
        {
            return new VkGetDeviceAccelerationStructureCompatibilityKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureVersionInfoKHR*,
                    VkAccelerationStructureCompatibilityKHR*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureBuildSizesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureBuildTypeKHR,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            int*,
            VkAccelerationStructureBuildSizesInfoKHR*,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkAccelerationStructureBuildTypeKHR,
            VkAccelerationStructureBuildGeometryInfoKHR*,
            int*,
            VkAccelerationStructureBuildSizesInfoKHR*,
            void> Invoke = handle;

        public static explicit operator VkGetAccelerationStructureBuildSizesKHR(PfnVkVoidFunction func)
        {
            return new VkGetAccelerationStructureBuildSizesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkAccelerationStructureBuildTypeKHR,
                    VkAccelerationStructureBuildGeometryInfoKHR*,
                    int*,
                    VkAccelerationStructureBuildSizesInfoKHR*,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdTraceRaysKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            int,
            int,
            int,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            int,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdTraceRaysKHR(PfnVkVoidFunction func)
        {
            return new VkCmdTraceRaysKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkStridedDeviceAddressRegionKHR*,
                    VkStridedDeviceAddressRegionKHR*,
                    VkStridedDeviceAddressRegionKHR*,
                    VkStridedDeviceAddressRegionKHR*,
                    int,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateRayTracingPipelinesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkPipelineCache,
            int,
            VkRayTracingPipelineCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeferredOperationKHR,
            VkPipelineCache,
            int,
            VkRayTracingPipelineCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkPipeline*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateRayTracingPipelinesKHR(PfnVkVoidFunction func)
        {
            return new VkCreateRayTracingPipelinesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeferredOperationKHR,
                    VkPipelineCache,
                    int,
                    VkRayTracingPipelineCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkPipeline*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRayTracingCaptureReplayShaderGroupHandlesKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetRayTracingCaptureReplayShaderGroupHandlesKHR(PfnVkVoidFunction func)
        {
            return new VkGetRayTracingCaptureReplayShaderGroupHandlesKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, int, nuint, void*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdTraceRaysIndirectKHR(
        delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkDeviceAddress,
            void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkStridedDeviceAddressRegionKHR*,
            VkDeviceAddress,
            void> Invoke = handle;

        public static explicit operator VkCmdTraceRaysIndirectKHR(PfnVkVoidFunction func)
        {
            return new VkCmdTraceRaysIndirectKHR(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkStridedDeviceAddressRegionKHR*,
                    VkStridedDeviceAddressRegionKHR*,
                    VkStridedDeviceAddressRegionKHR*,
                    VkStridedDeviceAddressRegionKHR*,
                    VkDeviceAddress,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRayTracingShaderGroupStackSizeKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, VkShaderGroupShaderKHR, ByteSize64> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPipeline,
            int,
            VkShaderGroupShaderKHR,
            ByteSize64> Invoke = handle;

        public static explicit operator VkGetRayTracingShaderGroupStackSizeKHR(PfnVkVoidFunction func)
        {
            return new VkGetRayTracingShaderGroupStackSizeKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkPipeline, int, VkShaderGroupShaderKHR, ByteSize64>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdSetRayTracingPipelineStackSizeKHR(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void> Invoke = handle;

        public static explicit operator VkCmdSetRayTracingPipelineStackSizeKHR(PfnVkVoidFunction func)
        {
            return new VkCmdSetRayTracingPipelineStackSizeKHR(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void> Invoke = handle;

        public static explicit operator VkCmdDrawMeshTasksEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, int, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void> Invoke =
            handle;

        public static explicit operator VkCmdDrawMeshTasksIndirectEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksIndirectEXT(
                (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, int, int, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectCountEXT(
        delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, ByteSize64, VkBuffer, ByteSize64, int, int, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkCommandBuffer,
            VkBuffer,
            ByteSize64,
            VkBuffer,
            ByteSize64,
            int,
            int,
            void> Invoke = handle;

        public static explicit operator VkCmdDrawMeshTasksIndirectCountEXT(PfnVkVoidFunction func)
        {
            return new VkCmdDrawMeshTasksIndirectCountEXT(
                (delegate* unmanaged[Cdecl]<
                    VkCommandBuffer,
                    VkBuffer,
                    ByteSize64,
                    VkBuffer,
                    ByteSize64,
                    int,
                    int,
                    void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateWin32SurfaceKHR(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkWin32SurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkWin32SurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateWin32SurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkCreateWin32SurfaceKHR(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkWin32SurfaceCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceWin32PresentationSupportKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, Brutal.Bool32> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, Brutal.Bool32> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceWin32PresentationSupportKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceWin32PresentationSupportKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, Brutal.Bool32>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryWin32HandleKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetWin32HandleInfoKHR*, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetWin32HandleInfoKHR*, nint*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetMemoryWin32HandleKHR(PfnVkVoidFunction func)
        {
            return new VkGetMemoryWin32HandleKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetWin32HandleInfoKHR*, nint*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryWin32HandlePropertiesKHR(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            nint,
            VkMemoryWin32HandlePropertiesKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            nint,
            VkMemoryWin32HandlePropertiesKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryWin32HandlePropertiesKHR(PfnVkVoidFunction func)
        {
            return new VkGetMemoryWin32HandlePropertiesKHR(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkExternalMemoryHandleTypeFlags,
                    nint,
                    VkMemoryWin32HandlePropertiesKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkImportSemaphoreWin32HandleKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkImportSemaphoreWin32HandleKHR(PfnVkVoidFunction func)
        {
            return new VkImportSemaphoreWin32HandleKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetSemaphoreWin32HandleKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkSemaphoreGetWin32HandleInfoKHR*,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetSemaphoreWin32HandleKHR(PfnVkVoidFunction func)
        {
            return new VkGetSemaphoreWin32HandleKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, nint*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkImportFenceWin32HandleKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkImportFenceWin32HandleKHR(PfnVkVoidFunction func)
        {
            return new VkImportFenceWin32HandleKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetFenceWin32HandleKHR(
        delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetWin32HandleInfoKHR*, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetWin32HandleInfoKHR*, nint*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetFenceWin32HandleKHR(PfnVkVoidFunction func)
        {
            return new VkGetFenceWin32HandleKHR(
                (delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetWin32HandleInfoKHR*, nint*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryWin32HandleNV(
        delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagsNV, nint*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkDeviceMemory,
            VkExternalMemoryHandleTypeFlagsNV,
            nint*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryWin32HandleNV(PfnVkVoidFunction func)
        {
            return new VkGetMemoryWin32HandleNV(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkDeviceMemory,
                    VkExternalMemoryHandleTypeFlagsNV,
                    nint*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfacePresentModes2EXT(
        delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            int*,
            VkPresentModeKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkPhysicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            int*,
            VkPresentModeKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceSurfacePresentModes2EXT(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceSurfacePresentModes2EXT(
                (delegate* unmanaged[Cdecl]<
                    VkPhysicalDevice,
                    VkPhysicalDeviceSurfaceInfo2KHR*,
                    int*,
                    VkPresentModeKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireFullScreenExclusiveModeEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> Invoke = handle;

        public static explicit operator VkAcquireFullScreenExclusiveModeEXT(PfnVkVoidFunction func)
        {
            return new VkAcquireFullScreenExclusiveModeEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkReleaseFullScreenExclusiveModeEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult> Invoke = handle;

        public static explicit operator VkReleaseFullScreenExclusiveModeEXT(PfnVkVoidFunction func)
        {
            return new VkReleaseFullScreenExclusiveModeEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetDeviceGroupSurfacePresentModes2EXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            VkDeviceGroupPresentModeFlagsKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkPhysicalDeviceSurfaceInfo2KHR*,
            VkDeviceGroupPresentModeFlagsKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetDeviceGroupSurfacePresentModes2EXT(PfnVkVoidFunction func)
        {
            return new VkGetDeviceGroupSurfacePresentModes2EXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkPhysicalDeviceSurfaceInfo2KHR*,
                    VkDeviceGroupPresentModeFlagsKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireWinrtDisplayNV(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult> Invoke = handle;

        public static explicit operator VkAcquireWinrtDisplayNV(PfnVkVoidFunction func)
        {
            return new VkAcquireWinrtDisplayNV(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetWinrtDisplayNV(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR*, VkResult> Invoke = handle;

        public static explicit operator VkGetWinrtDisplayNV(PfnVkVoidFunction func)
        {
            return new VkGetWinrtDisplayNV(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, VkDisplayKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateXlibSurfaceKHR(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkXlibSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkXlibSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateXlibSurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkCreateXlibSurfaceKHR(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkXlibSurfaceCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceXlibPresentationSupportKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, nint, Brutal.Bool32> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, nint, Brutal.Bool32> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceXlibPresentationSupportKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceXlibPresentationSupportKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, nint, Brutal.Bool32>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkAcquireXlibDisplayEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, void*, VkDisplayKHR, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, void*, VkDisplayKHR, VkResult> Invoke = handle;

        public static explicit operator VkAcquireXlibDisplayEXT(PfnVkVoidFunction func)
        {
            return new VkAcquireXlibDisplayEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, void*, VkDisplayKHR, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetRandROutputDisplayEXT(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, void*, nint, VkDisplayKHR*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, void*, nint, VkDisplayKHR*, VkResult> Invoke =
            handle;

        public static explicit operator VkGetRandROutputDisplayEXT(PfnVkVoidFunction func)
        {
            return new VkGetRandROutputDisplayEXT(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, void*, nint, VkDisplayKHR*, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateXcbSurfaceKHR(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkXcbSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkXcbSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateXcbSurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkCreateXcbSurfaceKHR(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkXcbSurfaceCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceXcbPresentationSupportKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, int, Brutal.Bool32> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, int, Brutal.Bool32> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceXcbPresentationSupportKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceXcbPresentationSupportKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, int, Brutal.Bool32>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateWaylandSurfaceKHR(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkWaylandSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkWaylandSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateWaylandSurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkCreateWaylandSurfaceKHR(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkWaylandSurfaceCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceWaylandPresentationSupportKHR(
        delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, Brutal.Bool32> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, Brutal.Bool32> Invoke = handle;

        public static explicit operator VkGetPhysicalDeviceWaylandPresentationSupportKHR(PfnVkVoidFunction func)
        {
            return new VkGetPhysicalDeviceWaylandPresentationSupportKHR(
                (delegate* unmanaged[Cdecl]<VkPhysicalDevice, int, void*, Brutal.Bool32>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateMetalSurfaceEXT(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkMetalSurfaceCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkMetalSurfaceCreateInfoEXT*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateMetalSurfaceEXT(PfnVkVoidFunction func)
        {
            return new VkCreateMetalSurfaceEXT(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkMetalSurfaceCreateInfoEXT*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkExportMetalObjectsEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void> Invoke = handle;

        public static explicit operator VkExportMetalObjectsEXT(PfnVkVoidFunction func)
        {
            return new VkExportMetalObjectsEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkExportMetalObjectsInfoEXT*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryMetalHandleEXT(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetMetalHandleInfoEXT*, void**, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetMetalHandleInfoEXT*, void**, VkResult> Invoke =
            handle;

        public static explicit operator VkGetMemoryMetalHandleEXT(PfnVkVoidFunction func)
        {
            return new VkGetMemoryMetalHandleEXT(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetMetalHandleInfoEXT*, void**, VkResult>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryMetalHandlePropertiesEXT(
        delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            void*,
            VkMemoryMetalHandlePropertiesEXT*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkExternalMemoryHandleTypeFlags,
            void*,
            VkMemoryMetalHandlePropertiesEXT*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryMetalHandlePropertiesEXT(PfnVkVoidFunction func)
        {
            return new VkGetMemoryMetalHandlePropertiesEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDevice,
                    VkExternalMemoryHandleTypeFlags,
                    void*,
                    VkMemoryMetalHandlePropertiesEXT*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkCreateAndroidSurfaceKHR(
        delegate* unmanaged[Cdecl]<
            VkInstance,
            VkAndroidSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkInstance,
            VkAndroidSurfaceCreateInfoKHR*,
            VkAllocationCallbacks*,
            VkSurfaceKHR*,
            VkResult> Invoke = handle;

        public static explicit operator VkCreateAndroidSurfaceKHR(PfnVkVoidFunction func)
        {
            return new VkCreateAndroidSurfaceKHR(
                (delegate* unmanaged[Cdecl]<
                    VkInstance,
                    VkAndroidSurfaceCreateInfoKHR*,
                    VkAllocationCallbacks*,
                    VkSurfaceKHR*,
                    VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetAndroidHardwareBufferPropertiesANDROID(
        delegate* unmanaged[Cdecl]<VkDevice, void*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            void*,
            VkAndroidHardwareBufferPropertiesANDROID*,
            VkResult> Invoke = handle;

        public static explicit operator VkGetAndroidHardwareBufferPropertiesANDROID(PfnVkVoidFunction func)
        {
            return new VkGetAndroidHardwareBufferPropertiesANDROID(
                (delegate* unmanaged[Cdecl]<VkDevice, void*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VkGetMemoryAndroidHardwareBufferANDROID(
        delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, void**, VkResult> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDevice,
            VkMemoryGetAndroidHardwareBufferInfoANDROID*,
            void**,
            VkResult> Invoke = handle;

        public static explicit operator VkGetMemoryAndroidHardwareBufferANDROID(PfnVkVoidFunction func)
        {
            return new VkGetMemoryAndroidHardwareBufferANDROID(
                (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, void**, VkResult>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct VxDestroyImages(
        delegate* unmanaged[Cdecl]<VkDevice, VkImage*, int, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImage*, int, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VxDestroyImages(PfnVkVoidFunction func)
        {
            return new VxDestroyImages(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImage*, int, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VxDestroyImageViews(
        delegate* unmanaged[Cdecl]<VkDevice, VkImageView*, int, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkImageView*, int, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VxDestroyImageViews(PfnVkVoidFunction func)
        {
            return new VxDestroyImageViews(
                (delegate* unmanaged[Cdecl]<VkDevice, VkImageView*, int, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VxDestroyBuffers(
        delegate* unmanaged[Cdecl]<VkDevice, VkBuffer*, int, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBuffer*, int, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VxDestroyBuffers(PfnVkVoidFunction func)
        {
            return new VxDestroyBuffers(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBuffer*, int, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct VxDestroyBufferViews(
        delegate* unmanaged[Cdecl]<VkDevice, VkBufferView*, int, VkAllocationCallbacks*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDevice, VkBufferView*, int, VkAllocationCallbacks*, void> Invoke =
            handle;

        public static explicit operator VxDestroyBufferViews(PfnVkVoidFunction func)
        {
            return new VxDestroyBufferViews(
                (delegate* unmanaged[Cdecl]<VkDevice, VkBufferView*, int, VkAllocationCallbacks*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkAllocationFunction(
        delegate* unmanaged[Cdecl]<void*, nuint, nuint, VkSystemAllocationScope, void*> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<void*, nuint, nuint, VkSystemAllocationScope, void*> Invoke = handle;

        public static explicit operator PfnVkAllocationFunction(PfnVkVoidFunction func)
        {
            return new PfnVkAllocationFunction(
                (delegate* unmanaged[Cdecl]<void*, nuint, nuint, VkSystemAllocationScope, void*>)func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkFreeFunction(delegate* unmanaged[Cdecl]<void*, void*, void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<void*, void*, void> Invoke = handle;

        public static explicit operator PfnVkFreeFunction(PfnVkVoidFunction func)
        {
            return new PfnVkFreeFunction((delegate* unmanaged[Cdecl]<void*, void*, void>)func.Invoke);
        }
    }

    public readonly unsafe struct PfnVkInternalAllocationNotification(
        delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            void*,
            nuint,
            VkInternalAllocationType,
            VkSystemAllocationScope,
            void> Invoke = handle;

        public static explicit operator PfnVkInternalAllocationNotification(PfnVkVoidFunction func)
        {
            return new PfnVkInternalAllocationNotification(
                (delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkInternalFreeNotification(
        delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            void*,
            nuint,
            VkInternalAllocationType,
            VkSystemAllocationScope,
            void> Invoke = handle;

        public static explicit operator PfnVkInternalFreeNotification(PfnVkVoidFunction func)
        {
            return new PfnVkInternalFreeNotification(
                (delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkReallocationFunction(
        delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, VkSystemAllocationScope, void*> Invoke =
            handle;

        public static explicit operator PfnVkReallocationFunction(PfnVkVoidFunction func)
        {
            return new PfnVkReallocationFunction(
                (delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, VkSystemAllocationScope, void*>)func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkVoidFunction(delegate* unmanaged[Cdecl]<void> handle)
    {
        public readonly delegate* unmanaged[Cdecl]<void> Invoke = handle;
    }

    public readonly unsafe struct PfnVkDebugReportCallbackEXT(
        delegate* unmanaged[Cdecl]<
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            nint,
            nuint,
            int,
            byte*,
            byte*,
            void*,
            Brutal.Bool32> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDebugReportFlagsEXT,
            VkDebugReportObjectTypeEXT,
            nint,
            nuint,
            int,
            byte*,
            byte*,
            void*,
            Brutal.Bool32> Invoke = handle;

        public static explicit operator PfnVkDebugReportCallbackEXT(PfnVkVoidFunction func)
        {
            return new PfnVkDebugReportCallbackEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDebugReportFlagsEXT,
                    VkDebugReportObjectTypeEXT,
                    nint,
                    nuint,
                    int,
                    byte*,
                    byte*,
                    void*,
                    Brutal.Bool32>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkDebugUtilsMessengerCallbackEXT(
        delegate* unmanaged[Cdecl]<
            VkDebugUtilsMessageSeverityFlagsEXT,
            VkDebugUtilsMessageTypeFlagsEXT,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void*,
            Brutal.Bool32> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<
            VkDebugUtilsMessageSeverityFlagsEXT,
            VkDebugUtilsMessageTypeFlagsEXT,
            VkDebugUtilsMessengerCallbackDataEXT*,
            void*,
            Brutal.Bool32> Invoke = handle;

        public static explicit operator PfnVkDebugUtilsMessengerCallbackEXT(PfnVkVoidFunction func)
        {
            return new PfnVkDebugUtilsMessengerCallbackEXT(
                (delegate* unmanaged[Cdecl]<
                    VkDebugUtilsMessageSeverityFlagsEXT,
                    VkDebugUtilsMessageTypeFlagsEXT,
                    VkDebugUtilsMessengerCallbackDataEXT*,
                    void*,
                    Brutal.Bool32>)
                    func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkDeviceMemoryReportCallbackEXT(
        delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void> Invoke = handle;

        public static explicit operator PfnVkDeviceMemoryReportCallbackEXT(PfnVkVoidFunction func)
        {
            return new PfnVkDeviceMemoryReportCallbackEXT(
                (delegate* unmanaged[Cdecl]<VkDeviceMemoryReportCallbackDataEXT*, void*, void>)func.Invoke
            );
        }
    }

    public readonly unsafe struct PfnVkGetInstanceProcAddrLUNARG(
        delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction> handle
    )
    {
        public readonly delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction> Invoke = handle;

        public static explicit operator PfnVkGetInstanceProcAddrLUNARG(PfnVkVoidFunction func)
        {
            return new PfnVkGetInstanceProcAddrLUNARG(
                (delegate* unmanaged[Cdecl]<VkInstance, byte*, PfnVkVoidFunction>)func.Invoke
            );
        }
    }
}
