namespace Brutal.VulkanApi.Abstractions;

public class DescriptorSetLayoutEx : VulkanHandleWrapper<VkDescriptorSetLayout, VkEmptyTable>, IDisposable
{
    public Device Device { get; }
    public Dictionary<VkDescriptorType, int> Descriptors { get; } = new();
    private readonly VkAllocator? _allocator;

    public unsafe ref struct CreateInfo
    {
        /// <summary>
        ///     <c>pNext</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        public void* Next;

        /// <summary>
        ///     <c>flags</c> is a bitmask specifying options for descriptor set layout creation.
        /// </summary>
        public VkDescriptorSetLayoutCreateFlags Flags;

        /// <summary>
        ///     <c>pBindings</c> is a pointer to an array of <c>VkDescriptorSetLayoutBinding</c> structures.
        /// </summary>
        public Span<VkDescriptorSetLayoutBinding> Bindings;

        /// <summary>
        /// Extract or populate this struct with a VkDescriptorSetLayoutCreateInfo
        /// </summary>
        public VkDescriptorSetLayoutCreateInfo DescriptorSetLayoutCreateInfo
        {
            get =>
                new()
                {
                    Next = Next,
                    Flags = Flags,
                    BindingCount = Bindings.Length,
                    Bindings = Bindings.AsPointer(),
                };
            set
            {
                Next = value.Next;
                Flags = value.Flags;
                Bindings = new(value.Bindings, value.BindingCount);
            }
        }
    }

    internal DescriptorSetLayoutEx(Device device, CreateInfo createInfo, VkAllocator? allocator)
    {
        Device = device;
        Handle = device.CreateDescriptorSetLayout(createInfo.DescriptorSetLayoutCreateInfo, allocator);
        _allocator = allocator;

        foreach (var binding in createInfo.Bindings)
        {
            if (Descriptors.ContainsKey(binding.DescriptorType))
                Descriptors[binding.DescriptorType] += binding.DescriptorCount;
            else
                Descriptors[binding.DescriptorType] = binding.DescriptorCount;
        }
    }

    public void Dispose()
    {
        Device.DestroyDescriptorSetLayout(Handle, _allocator);
    }

    public VkDescriptorSetLayout Handle { get; init; }
    public ref VkEmptyTable PInvoke => throw new NotImplementedException();

    public bool IsNull() => Handle.IsNull();

    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkDescriptorSetLayout(DescriptorSetLayoutEx descriptorSetLayout) =>
        descriptorSetLayout.Handle;
}

public static class DescriptorSetLayoutExExtensions
{
    public static DescriptorSetLayoutEx CreateDescriptorSetLayout(
        this Device device,
        DescriptorSetLayoutEx.CreateInfo createInfo,
        VkAllocator? allocator
    )
    {
        return new DescriptorSetLayoutEx(device, createInfo, allocator);
    }
}
