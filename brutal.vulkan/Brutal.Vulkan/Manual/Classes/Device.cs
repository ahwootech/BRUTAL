namespace Brutal.VulkanApi;

/// <summary>
/// Class that wraps a Vulkan Device handle.
/// </summary>
public class Device : VulkanHandleWrapper<VkDevice, VkDevice.FunctionTable>, IDisposable
{
    public ref struct CreateInfo()
    {
        public HashSet<string> Extensions = [];
        public Ptr<VkPhysicalDeviceFeatures> Features = null;
        public ReadOnlySpan<VkDeviceQueueCreateInfo> QueueCreateInfos = [];
        public Ptr Next = null;
        public VkAllocator? Allocator = null;
    }

    /// <summary>
    /// The physical device that this device was created from.
    /// </summary>
    public PhysicalDevice PhysicalDevice { get; }

    // Caches a unique queue object for each queue family/index combination.
    private readonly Dictionary<(int, int), Queue> _queues = new();

    /// <summary>
    /// The set of enabled extensions for this device
    /// </summary>
    public readonly HashSet<string> EnabledExtensions;

    protected VkAllocator? _vkAllocator;

    internal unsafe Device(PhysicalDevice physicalDevice, CreateInfo createInfo)
    {
        _vkAllocator = createInfo.Allocator;
        EnabledExtensions = createInfo.Extensions;

        // Calculate total byte count and individual lengths for each extension
        Span<int> lengths = stackalloc int[createInfo.Extensions.Count];
        var totalByteCount = 0;

        var i = 0;
        foreach (var extension in createInfo.Extensions)
        {
            lengths[i] = Utf8.GetByteCount(extension) + 1; // +1 for null terminator
            totalByteCount += lengths[i];
            i++;
        }

        // Allocate memory for all extension strings and their pointers
        Span<byte> allExtensionBytes = stackalloc byte[totalByteCount];
        var extensionPtrs = stackalloc byte*[createInfo.Extensions.Count];
        var writePtr = allExtensionBytes;

        // Fill the pointers and copy the strings into the allocated memory
        i = 0;
        foreach (var ext in createInfo.Extensions)
        {
            if (!Utf8.TryGetBytes(ext, writePtr, out var bytes))
                throw new Exception("Failed to encode extension name to UTF-8");

            extensionPtrs[i] = writePtr.AsPointer();
            writePtr[bytes] = 0; // Null-terminate the string
            writePtr = writePtr[(bytes + 1)..];
            i++;
        }

        var vkCreateInfo = new VkDeviceCreateInfo
        {
            EnabledExtensionCount = createInfo.Extensions.Count,
            QueueCreateInfoCount = createInfo.QueueCreateInfos.Length,
            EnabledFeatures = createInfo.Features,
            Next = createInfo.Next,
            ppEnabledExtensionNames = extensionPtrs,
        };

        fixed (VkDeviceQueueCreateInfo* queueCreateInfosPtr = createInfo.QueueCreateInfos)
        {
            vkCreateInfo.QueueCreateInfos = queueCreateInfosPtr;
            Handle = physicalDevice.CreateDeviceInternal(vkCreateInfo, _vkAllocator);
        }

        PhysicalDevice = physicalDevice;

        var getDeviceProcAddr = physicalDevice.Instance.GetProcAddr("vkGetDeviceProcAddr"u8);
        _pInvoke = Mem.AllocAndCopy(new VkDevice.FunctionTable(Handle, (VkGetDeviceProcAddr)getDeviceProcAddr));
    }

    /// <summary>
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkGetDeviceQueue.html">vkGetDeviceQueue</see> - Get a queue from a device
    /// </summary>
    /// <param name="queueFamilyIndex">is the index of the queue family to which the queue belongs.</param>
    /// <param name="queueIndex">is the index within this queue family of the queue to retrieve.</param>
    /// <returns>Queue object wrapping a QueueHandle</returns>
    public Queue GetQueue(int queueFamilyIndex, int queueIndex)
    {
        var tuple = (queueFamilyIndex, queueIndex);

        if (!_queues.TryGetValue(tuple, out var queue))
        {
            queue = new Queue(this, queueFamilyIndex, queueIndex);
            _queues.Add(tuple, queue);
        }

        return queue;
    }

    // Detection only, never touch native handles from the finalizer. Mirrors the Instance warning.
    ~Device()
    {
        try
        {
            Vulkan.Log.Warning("Device was not disposed. Native resources leaked; call Dispose().");
        }
        catch
        {
            // Logging may be torn down during process exit
        }
    }

    public virtual void Dispose()
    {
        this.DestroyDeviceInternal(_vkAllocator);
        if (_pInvoke.IsNotNull())
            Mem.Free(_pInvoke);
        GC.SuppressFinalize(this);
    }

    internal readonly Ptr<VkDevice.FunctionTable> _pInvoke;
    public VkDevice Handle { get; init; }
    public ref VkDevice.FunctionTable PInvoke => ref _pInvoke.Value;

    public bool IsNull() => Handle.IsNull();

    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkDevice(Device device) => device.Handle;
}
