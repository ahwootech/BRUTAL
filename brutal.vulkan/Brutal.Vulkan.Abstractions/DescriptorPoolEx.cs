using System.Text;

namespace Brutal.VulkanApi.Abstractions;

public class DescriptorPoolEx : VulkanHandleWrapper<VkDescriptorPool, VkEmptyTable>, IDisposable
{
    public ref struct CreateInfo
    {
        /// <inheritdoc cref="VkDescriptorPoolCreateInfo.Next"/>
        public unsafe void* Next;

        /// <inheritdoc cref="VkDescriptorPoolCreateInfo.MaxSets"/>
        public int MaxSets;

        /// <inheritdoc cref="VkDescriptorPoolCreateInfo.Flags"/>
        public VkDescriptorPoolCreateFlags Flags;

        /// <inheritdoc cref="VkDescriptorPoolCreateInfo.PoolSizes"/>
        public Span<VkDescriptorPoolSize> PoolSizes;

        /// <summary>
        /// Extract or populate this struct with a VkDescriptorPoolCreateInfo
        /// </summary>
        public unsafe VkDescriptorPoolCreateInfo DescriptorPoolCreateInfo
        {
            get =>
                new()
                {
                    Flags = Flags,
                    MaxSets = MaxSets,
                    Next = Next,
                    PoolSizes = PoolSizes.AsPointer(),
                    PoolSizeCount = PoolSizes.Length,
                };
            set
            {
                Next = value.Next;
                Flags = value.Flags;
                MaxSets = value.MaxSets;
                PoolSizes = new(value.PoolSizes, value.PoolSizeCount);
            }
        }
    }

    public Device Device { get; }

    public int MaxSets { get; }

    public int RemainingSets { get; private set; }

    public VkDescriptorPoolCreateFlags Flags { get; }

    public record struct PoolSize(VkDescriptorType Type, int InitialCount, int RemainingCount);

    public readonly PoolSize[] PoolSizes;

    public readonly Dictionary<VkDescriptorSet, DescriptorSetLayoutEx> MappedDescriptorSets;
    private readonly VkAllocator? _allocator;

    internal DescriptorPoolEx(Device device, CreateInfo createInfo, VkAllocator? allocator)
    {
        Device = device;
        MaxSets = createInfo.MaxSets;
        RemainingSets = MaxSets;
        Flags = createInfo.Flags;
        _allocator = allocator;

        PoolSizes = new PoolSize[createInfo.PoolSizes.Length];
        for (var i = 0; i < createInfo.PoolSizes.Length; i++)
            PoolSizes[i] = new PoolSize(
                createInfo.PoolSizes[i].Type,
                createInfo.PoolSizes[i].DescriptorCount,
                createInfo.PoolSizes[i].DescriptorCount
            );

        Handle = device.CreateDescriptorPool(createInfo.DescriptorPoolCreateInfo, allocator);

        MappedDescriptorSets = new Dictionary<VkDescriptorSet, DescriptorSetLayoutEx>(MaxSets);
    }

    internal unsafe VkDescriptorSet AllocateDescriptorSet(DescriptorSetLayoutEx layout)
    {
        TryAllocateFromLayouts([layout]);

        var layoutHandle = layout.Handle;

        VkDescriptorSet descriptorSet;

        Device.AllocateDescriptorSets(
            new VkDescriptorSetAllocateInfo
            {
                DescriptorPool = Handle,
                DescriptorSetCount = 1,
                SetLayouts = &layoutHandle,
            },
            new ReadOnlySpan<VkDescriptorSet>(&descriptorSet, 1)
        );

        MappedDescriptorSets.Add(descriptorSet, layout);

        return descriptorSet;
    }

    internal unsafe void AllocateDescriptorSets(DescriptorSetLayoutEx layout, Span<VkDescriptorSet> descriptorSets)
    {
        TryAllocateFromLayouts([layout], descriptorSets.Length);

        Span<VkDescriptorSetLayout> layouts = stackalloc VkDescriptorSetLayout[descriptorSets.Length];
        for (var i = 0; i < descriptorSets.Length; i++)
            layouts[i] = layout.Handle;

        Device.AllocateDescriptorSets(
            new VkDescriptorSetAllocateInfo
            {
                DescriptorPool = Handle,
                DescriptorSetCount = descriptorSets.Length,
                SetLayouts = layouts.AsPointer(),
            },
            descriptorSets
        );

        for (var i = 0; i < descriptorSets.Length; i++)
            MappedDescriptorSets.Add(descriptorSets[i], layout);
    }

    internal unsafe void AllocateDescriptorSets(
        Span<DescriptorSetLayoutEx> layouts,
        Span<VkDescriptorSet> descriptorSets
    )
    {
        if (layouts.Length != descriptorSets.Length)
            throw new ArgumentException("layouts and descriptorSets must be the same length");

        TryAllocateFromLayouts(layouts);

        Span<VkDescriptorSetLayout> layoutHandles = stackalloc VkDescriptorSetLayout[layouts.Length];

        for (var i = 0; i < layouts.Length; i++)
            layoutHandles[i] = layouts[i].Handle;

        Device.AllocateDescriptorSets(
            new VkDescriptorSetAllocateInfo
            {
                DescriptorPool = Handle,
                DescriptorSetCount = layouts.Length,
                SetLayouts = layoutHandles.AsPointer(),
            },
            descriptorSets
        );

        for (var i = 0; i < layouts.Length; i++)
            MappedDescriptorSets.Add(descriptorSets[i], layouts[i]);
    }

    protected void TryAllocateFromLayouts(Span<DescriptorSetLayoutEx> layouts, int multiplier = 1)
    {
        var requiredSets = layouts.Length * multiplier;

        if (RemainingSets < requiredSets)
            throw DescriptorPoolOutOfMemoryException.OutOfSets(this, requiredSets);

        // Create a copy of the pool sizes to avoid modifying the original in case of failure
        Span<PoolSize> poolSizes = stackalloc PoolSize[PoolSizes.Length];
        PoolSizes.CopyTo(poolSizes);

        foreach (var layout in layouts)
            TryAllocateFromLayout(poolSizes, layout, multiplier);

        // Commit the changes if allocation was successful
        poolSizes.CopyTo(PoolSizes);
        RemainingSets -= requiredSets;
    }

    private void TryAllocateFromLayout(Span<PoolSize> poolSizes, DescriptorSetLayoutEx layout, int multiplier)
    {
        foreach (var (type, required) in layout.Descriptors)
            TryAllocateDescriptors(poolSizes, type, required * multiplier);
    }

    private void TryAllocateDescriptors(Span<PoolSize> poolSizes, VkDescriptorType type, int required)
    {
        // Try to find a pool size that matches the type and has enough remaining descriptors
        for (var i = 0; i < poolSizes.Length; i++)
        {
            if (poolSizes[i].Type != type)
                continue;

            if (poolSizes[i].RemainingCount < required)
                throw DescriptorPoolOutOfMemoryException.OutOfDescriptors(this, type, required);

            poolSizes[i].RemainingCount -= required;
            return;
        }

        // If no matching pool size was found, allocation failed
        throw DescriptorPoolInvalidOperationException.DescriptorTypeNotFound(this, type);
    }

    internal void FreeDescriptorSets(Span<VkDescriptorSet> descriptorSets)
    {
        if ((Flags & VkDescriptorPoolCreateFlags.FreeDescriptorSetBit) == 0)
            throw DescriptorPoolInvalidOperationException.BadFreeOperation(this);

        foreach (var descriptorSet in descriptorSets)
        {
            if (!MappedDescriptorSets.TryGetValue(descriptorSet, out var layout))
                throw DescriptorPoolInvalidOperationException.FreeInvalidDescriptorSet(this, descriptorSet);

            // Returns the descriptors and credits RemainingSets by one (multiplier -1)
            TryAllocateFromLayouts([layout], -1);
            MappedDescriptorSets.Remove(descriptorSet);
        }

        Device.FreeDescriptorSetsInternal(Handle, descriptorSets);
    }

    public void Dispose()
    {
        MappedDescriptorSets.Clear();
        Device.DestroyDescriptorPool(Handle, _allocator);
    }

    public VkDescriptorPool Handle { get; init; }
    public ref VkEmptyTable PInvoke => throw new NotImplementedException();

    public bool IsNull() => Handle.IsNull();

    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkDescriptorPool(DescriptorPoolEx descriptorPool) => descriptorPool.Handle;
}

public static class DescriptorPoolExExtensions
{
    public static DescriptorPoolEx CreateDescriptorPool(
        this Device device,
        DescriptorPoolEx.CreateInfo createInfo,
        VkAllocator? allocator
    )
    {
        return new DescriptorPoolEx(device, createInfo, allocator);
    }

    /// <summary>
    /// Allocates a single descriptor set from the specified descriptor pool using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html">vkAllocateDescriptorSets</see>.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the descriptor pool.</param>
    /// <param name="inDescriptorPool">The descriptor pool from which to allocate the descriptor set.</param>
    /// <param name="inDescriptorSetLayout">
    /// A <see cref="VkDescriptorSetLayout"/> handle that describes the layout of the descriptor set to be allocated.
    /// </param>
    /// <returns>A <c>VkDescriptorSet</c> object representing the allocated descriptor set.</returns>
    public static VkDescriptorSet AllocateDescriptorSet(
        this Device inDevice,
        DescriptorPoolEx inDescriptorPool,
        DescriptorSetLayoutEx inDescriptorSetLayout
    )
    {
        return inDescriptorPool.AllocateDescriptorSet(inDescriptorSetLayout);
    }

    /// <summary>
    /// Allocates one or more descriptor sets from the specified descriptor pool using
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkAllocateDescriptorSets.html">vkAllocateDescriptorSets</see>.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the descriptor pool.</param>
    /// <param name="inDescriptorPool">The descriptor pool from which the descriptor sets will be allocated.</param>
    /// <param name="inDescriptorSetLayouts">
    /// A span of <see cref="VkDescriptorSetLayout"/> handles, each describing the layout of a descriptor set to be allocated.
    /// </param>
    /// <param name="outDescriptorSets">An array of <c>VkDescriptorSet</c> objects representing the allocated descriptor sets.</param>
    public static void AllocateDescriptorSets(
        this Device inDevice,
        DescriptorPoolEx inDescriptorPool,
        Span<DescriptorSetLayoutEx> inDescriptorSetLayouts,
        Span<VkDescriptorSet> outDescriptorSets
    )
    {
        inDescriptorPool.AllocateDescriptorSets(inDescriptorSetLayouts, outDescriptorSets);
    }

    /// <summary>
    /// Allocates an array of descriptor sets from the specified descriptor pool using a single descriptor set layout repeated for each set.
    /// This method constructs a span containing the same <see cref="VkDescriptorSetLayout"/> for every descriptor set to be allocated.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the descriptor pool.</param>
    /// <param name="inDescriptorPool">The descriptor pool from which the descriptor sets will be allocated.</param>
    /// <param name="inDescriptorSetLayout">
    /// A <see cref="VkDescriptorSetLayout"/> handle that describes the layout of each descriptor set.
    /// </param>
    /// <param name="outDescriptorSets">A span to be filled with the allocated descriptor sets.</param>
    /// <returns>An array of <c>VkDescriptorSet</c> objects representing the allocated descriptor sets.</returns>
    public static void AllocateDescriptorSets(
        this Device inDevice,
        DescriptorPoolEx inDescriptorPool,
        DescriptorSetLayoutEx inDescriptorSetLayout,
        Span<VkDescriptorSet> outDescriptorSets
    )
    {
        inDescriptorPool.AllocateDescriptorSets(inDescriptorSetLayout, outDescriptorSets);
    }

    /// <summary>
    /// Frees descriptor sets that were previously allocated from the specified descriptor pool
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html">vkFreeDescriptorSets</see>.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the descriptor pool.</param>
    /// <param name="inDescriptorPool">The descriptor pool from which the descriptor sets were allocated.</param>
    /// <param name="inDescriptorSet">The descriptor set to free</param>
    public static void FreeDescriptorSet(
        this Device inDevice,
        DescriptorPoolEx inDescriptorPool,
        VkDescriptorSet inDescriptorSet
    )
    {
        inDescriptorPool.FreeDescriptorSets([inDescriptorSet]);
    }

    /// <summary>
    /// Frees an array of descriptor sets that were previously allocated from the specified descriptor pool.
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkFreeDescriptorSets.html">vkFreeDescriptorSets</see>.
    /// </summary>
    /// <param name="inDevice">The logical device that owns the descriptor pool.</param>
    /// <param name="inDescriptorPool">The descriptor pool from which the descriptor sets were allocated.</param>
    /// <param name="inDescriptorSets">Span of descriptor sets to free</param>
    public static void FreeDescriptorSets(
        this Device inDevice,
        DescriptorPoolEx inDescriptorPool,
        Span<VkDescriptorSet> inDescriptorSets
    )
    {
        inDescriptorPool.FreeDescriptorSets(inDescriptorSets);
    }
}

public class DescriptorPoolInvalidOperationException(DescriptorPoolEx pool, string message)
    : InvalidOperationException(message)
{
    public DescriptorPoolEx Pool = pool;

    public static DescriptorPoolInvalidOperationException BadFreeOperation(DescriptorPoolEx pool) =>
        new(pool, "Tried to free sets from a pool that was not created with the 'FreeDescriptorSet' flag");

    public static DescriptorPoolInvalidOperationException FreeInvalidDescriptorSet(
        DescriptorPoolEx pool,
        VkDescriptorSet descriptorSet
    ) => new(pool, "Tried to free a descriptor set that was not allocated from this pool");

    public static DescriptorPoolInvalidOperationException DescriptorTypeNotFound(
        DescriptorPoolEx pool,
        VkDescriptorType type
    ) => new(pool, $"Tried to allocate descriptor of type '{type}' that was never allocated for this pool");
}

public class DescriptorPoolOutOfMemoryException(DescriptorPoolEx pool, string message) : OutOfMemoryException(message)
{
    public DescriptorPoolEx Pool = pool;

    public static DescriptorPoolOutOfMemoryException OutOfSets(DescriptorPoolEx pool, int required)
    {
        var remaining = pool.RemainingSets;

        return new DescriptorPoolOutOfMemoryException(
            pool,
            new StringBuilder("Tried to allocate ")
                .Append(required == 1 ? "a new set" : $"{required} new sets")
                .Append(", but there ")
                .Append(
                    remaining switch
                    {
                        0 => "are no sets remaining",
                        1 => "is only 1 set remaining",
                        _ => $"are only {remaining} sets remaining",
                    }
                )
                .ToString()
        );
    }

    public static DescriptorPoolOutOfMemoryException OutOfDescriptors(
        DescriptorPoolEx pool,
        VkDescriptorType type,
        int required
    )
    {
        // Find the matching pool size without a LINQ enumerator/closure on this error path
        var remaining = 0;
        foreach (var poolSize in pool.PoolSizes)
        {
            if (poolSize.Type != type)
                continue;
            remaining = poolSize.RemainingCount;
            break;
        }

        return new DescriptorPoolOutOfMemoryException(
            pool,
            new StringBuilder("Tried to allocate ")
                .Append(required == 1 ? "a new descriptor" : $"{required} new descriptors")
                .Append(" of type '")
                .Append(type)
                .Append("', but there ")
                .Append(
                    remaining switch
                    {
                        0 => "are no descriptors of this type remaining",
                        1 => "is only 1 descriptor of this type remaining",
                        _ => $"are only {remaining} descriptors of this type remaining",
                    }
                )
                .ToString()
        );
    }
}
