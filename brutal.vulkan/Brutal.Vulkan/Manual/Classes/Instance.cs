namespace Brutal.VulkanApi;

public struct VkEmptyTable { }

/// <summary>
/// Class that wraps a Vulkan Instance handle.
/// </summary>
public class Instance : VulkanHandleWrapper<VkInstance, VkInstance.FunctionTable>, IDisposable
{
    public unsafe ref struct CreateInfo
    {
        public VkApplicationInfo AppInfo;
        public VkInstanceCreateFlags Flags;
        public HashSet<string> EnabledExtensions;
        public HashSet<string> EnabledLayers;
        public void* Next;
        public VkAllocator? Allocator;
    }

    public readonly PhysicalDevice[] PhysicalDevices;

    internal unsafe Instance(CreateInfo createInfo)
    {
        var instanceCreateInfo = new VkInstanceCreateInfo
        {
            ApplicationInfo = &createInfo.AppInfo,
            Flags = createInfo.Flags,
            EnabledExtensionCount = createInfo.EnabledExtensions.Count,
            EnabledLayerCount = createInfo.EnabledLayers.Count,
            Next = createInfo.Next,
        };

        _enabledExtensions = createInfo.EnabledExtensions;
        _enabledLayers = createInfo.EnabledLayers;

        var totalByteCount = 0;
        Span<int> lengths = stackalloc int[createInfo.EnabledExtensions.Count + createInfo.EnabledLayers.Count];
        var ptrs = stackalloc byte*[createInfo.EnabledExtensions.Count + createInfo.EnabledLayers.Count];

        instanceCreateInfo.ppEnabledExtensionNames = ptrs;
        instanceCreateInfo.ppEnabledLayerNames = ptrs + createInfo.EnabledExtensions.Count;

        // Calculate total byte count and individual lengths for each extension and layer
        var i = 0;
        foreach (var extension in createInfo.EnabledExtensions)
        {
            lengths[i] = Utf8.GetByteCount(extension) + 1; // +1 for null terminator
            totalByteCount += lengths[i];
            i++;
        }

        foreach (var layer in createInfo.EnabledLayers)
        {
            lengths[i] = Utf8.GetByteCount(layer) + 1; // +1 for null terminator
            totalByteCount += lengths[i];
            i++;
        }

        Span<byte> allBytes = stackalloc byte[totalByteCount];

        // Allocate memory for all extension strings and their pointers
        var writePtr = allBytes;

        // Fill the pointers and copy the strings into the allocated memory
        i = 0;
        foreach (var extension in createInfo.EnabledExtensions)
        {
            if (!Utf8.TryGetBytes(extension, writePtr, out var bytes))
                throw new Exception("Failed to encode extension name to UTF-8");

            ptrs[i] = writePtr.AsPointer();
            writePtr[bytes] = 0; // Null-terminate the string
            writePtr = writePtr[(bytes + 1)..];
            i++;
        }

        foreach (var layer in createInfo.EnabledLayers)
        {
            if (!Utf8.TryGetBytes(layer, writePtr, out var bytes))
                throw new Exception("Failed to encode layer name to UTF-8");

            ptrs[i] = writePtr.AsPointer();
            writePtr[bytes] = 0; // Null-terminate the string
            writePtr = writePtr[(bytes + 1)..];
            i++;
        }

        Handle = Vulkan.CreateInstanceInternal(instanceCreateInfo, createInfo.Allocator);

        _pInvoke = Mem.AllocAndCopy(new VkInstance.FunctionTable(Handle, Vulkan.GetInstanceProcAddr));

        _allocator = createInfo.Allocator;

        PhysicalDevices = new PhysicalDevice[this.EnumeratePhysicalDevicesInternal_Count()];
        fixed (VkPhysicalDevice* physicalDevices = stackalloc VkPhysicalDevice[PhysicalDevices.Length])
        {
            this.EnumeratePhysicalDevicesInternal_Write(
                new Span<VkPhysicalDevice>(physicalDevices, PhysicalDevices.Length)
            );

            for (var pdIndex = 0; pdIndex < PhysicalDevices.Length; pdIndex++)
                PhysicalDevices[pdIndex] = new PhysicalDevice(this, physicalDevices[pdIndex]);
        }
    }

    // Warn about the missed Dispose() and best-effort free the native handle, guarding both since a
    // finalizer must never throw and logging or native teardown may already be gone at process exit.
    ~Instance()
    {
        try
        {
            Vulkan.Log.Warning(
                "Instance was not disposed. Freeing native resources from the finalizer; call Dispose()."
            );
        }
        catch
        {
            // Logging may be torn down during process exit
        }

        try
        {
            Dispose(fromFinalizer: true);
        }
        catch
        {
            // Best-effort cleanup; never let it escape the finalizer
        }
    }

    public bool IsNull() => Handle.IsNull();

    /// <summary>
    /// Returns true if the given extension is enabled on this instance.
    /// </summary>
    /// <param name="inExtensionName"></param>
    /// <returns></returns>
    public bool IsExtensionEnabled(string inExtensionName)
    {
        return _enabledExtensions.Contains(inExtensionName);
    }

    // Cached lookups for extensions which were enabled on instance creation
    private readonly HashSet<string> _enabledExtensions;

    // Cached lookups for layers which were enabled on instance creation
    private readonly HashSet<string> _enabledLayers;
    private readonly VkAllocator? _allocator;

    public void Dispose() => Dispose(fromFinalizer: false);

    private void Dispose(bool fromFinalizer)
    {
        // Skip the native destroy from the finalizer with a custom allocator, its callbacks may already be freed
        if (!(fromFinalizer && _allocator != null))
            this.DestroyInstanceInternal(_allocator);
        if (_pInvoke.IsNotNull())
            Mem.Free(_pInvoke);
        GC.SuppressFinalize(this);
    }

    private readonly Ptr<VkInstance.FunctionTable> _pInvoke;
    public VkInstance Handle { get; init; }
    public ref VkInstance.FunctionTable PInvoke => ref _pInvoke.Value;
    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkInstance(Instance instance) => instance.Handle;
}
