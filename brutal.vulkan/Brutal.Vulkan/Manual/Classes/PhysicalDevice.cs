using System.Numerics;

namespace Brutal.VulkanApi;

/// <summary>
/// Class that wraps a Vulkan PhysicalDevice handle.
/// </summary>
public class PhysicalDevice : VulkanHandleWrapper<VkPhysicalDevice, VkInstance.FunctionTable>
{
    /// <summary>
    /// The Instance that this physical device was created from.
    /// </summary>
    public Instance Instance { get; }

    /// <summary>
    /// Cached PhysicalDevice ExtensionNames.
    /// </summary>
    /// <remarks>
    /// Prefer <see cref="SupportsExtension(ReadOnlySpan{byte})"/> for lookups: this property
    /// materializes a managed string per supported extension (200+ on modern drivers), whereas
    /// the byte-span lookup avoids all string allocation.
    /// </remarks>
    public HashSet<string> ExtensionNames
    {
        get
        {
            if (_extensionNames == null)
            {
                var utf8 = ExtensionNamesUtf8;
                _extensionNames = new HashSet<string>(utf8.Length);
                foreach (var name in utf8)
                    _extensionNames.Add(Utf8.GetString(name));
            }
            return _extensionNames;
        }
    }
    private HashSet<string>? _extensionNames;

    /// <summary>
    /// Supported extension names as raw UTF-8 bytes (trimmed to the null terminator), enumerated
    /// once on first access. Backs the allocation-free extension lookups.
    /// </summary>
    private byte[][] ExtensionNamesUtf8
    {
        get
        {
            if (_extensionNamesUtf8 == null)
            {
                ReadOnlySpan<VkExtensionProperties> extensionProperties =
                    stackalloc VkExtensionProperties[this.EnumerateDeviceExtensionProperties_Count([])];
                var result = this.EnumerateDeviceExtensionProperties_Write([], extensionProperties);
                if (result != VkResult.Success)
                    throw new InvalidOperationException("Failed to enumerate device extension properties: " + result);

                var names = new byte[extensionProperties.Length][];
                for (var i = 0; i < extensionProperties.Length; i++)
                {
                    unsafe
                    {
                        fixed (byte* name = extensionProperties[i].ExtensionName)
                            names[i] = Utf8.GetNullTerminatedSpan(name).ToArray();
                    }
                }
                _extensionNamesUtf8 = names;
            }
            return _extensionNamesUtf8;
        }
    }
    private byte[][]? _extensionNamesUtf8;

    internal PhysicalDevice(Instance inInstance, VkPhysicalDevice inHandle)
    {
        Handle = inHandle;
        Instance = inInstance;
    }

    /// <summary>
    /// Naively returns the index of the first queue family which has the given VkQueueFlag, or -1 if no family is found
    /// </summary>
    public int GetFirstQueueFamilyWithFlag(VkQueueFlags flag)
    {
        using var properties = SpanOwner<VkQueueFamilyProperties>.Allocate(this.GetQueueFamilyProperties_Count());
        this.GetQueueFamilyProperties_Write(properties.Span);

        for (var i = 0; i < properties.Length; ++i)
            if (properties.Span[i].QueueFlags.HasFlag(flag))
                return i;

        return -1;
    }

    /// <summary>
    /// Searches for the first memory type index that satisfies both the specified memory type filter and required property flags.
    /// </summary>
    /// <param name="memoryTypeFilter">A bitmask representing the candidate memory types.</param>
    /// <param name="requiredProperties">The memory property flags that must be present.</param>
    /// <returns>The index of the first suitable memory type.</returns>
    /// <exception cref="Exception">Thrown if no memory type meets the required criteria.</exception>
    public int FindMemoryType(int memoryTypeFilter, VkMemoryPropertyFlags requiredProperties)
    {
        var memoryProperties = this.GetMemoryProperties();
        var memoryTypeCount = memoryProperties.MemoryTypeCount;

        for (var i = 0; i < memoryTypeCount; i++)
        {
            var memoryTypeBits = 1 << i;
            var isRequiredMemoryType = (memoryTypeFilter & memoryTypeBits) != 0;

            if (!isRequiredMemoryType)
                continue;

            var properties = memoryProperties.MemoryTypes[i].PropertyFlags;
            var hasRequiredProperties = (properties & requiredProperties) == requiredProperties;

            if (hasRequiredProperties)
                return i;
        }

        throw new Exception("failed to find suitable memory type!");
    }

    /// <summary>
    /// Searches for the first memory type index that satisfies both the specified memory type filter and required property flags.
    /// </summary>
    /// <param name="memoryTypeFilter">A bitmask representing the candidate memory types.</param>
    /// <param name="requiredProperties">The memory property flags that must be present.</param>
    /// <param name="preferredProperties">Memory property flags that are preferred, and will be prioritized</param>
    /// <returns>The index of the first suitable memory type.</returns>
    /// <exception cref="Exception">Thrown if no memory type meets the required criteria.</exception>
    public int FindMemoryType(
        int memoryTypeFilter,
        VkMemoryPropertyFlags requiredProperties,
        VkMemoryPropertyFlags preferredProperties
    )
    {
        var memoryProperties = this.GetMemoryProperties();
        var memoryTypeCount = memoryProperties.MemoryTypeCount;

        int bestHits = 0;
        int bestCandidate = -1;
        for (var i = 0; i < memoryTypeCount; i++)
        {
            var memoryTypeBits = 1 << i;
            var isRequiredMemoryType = (memoryTypeFilter & memoryTypeBits) != 0;

            if (!isRequiredMemoryType)
                continue;

            var properties = memoryProperties.MemoryTypes[i].PropertyFlags;
            var hasRequiredProperties = (properties & requiredProperties) == requiredProperties;
            if (!hasRequiredProperties)
                continue;
            var prefMatch = (properties & preferredProperties);
            // perfect candidate
            if (prefMatch == preferredProperties)
                return i;
            // sort imperfect candidate by most preferredProperties flag hits
            int hits = BitOperations.PopCount((ulong)prefMatch);
            if (hits > bestHits)
            {
                bestCandidate = i;
                bestHits = hits;
            }
        }

        if (bestCandidate == -1)
            throw new Exception("failed to find suitable memory type!");
        return bestCandidate;
    }

    /// <summary>
    /// Determines if the physical device supports a given extension, without allocating a string.
    /// </summary>
    /// <param name="utf8Name">The extension name as UTF-8 bytes, e.g. a <c>"VK_KHR_swapchain"u8</c> literal.</param>
    public bool SupportsExtension(ReadOnlySpan<byte> utf8Name)
    {
        foreach (var name in ExtensionNamesUtf8)
            if (utf8Name.SequenceEqual(name))
                return true;
        return false;
    }

    /// <summary>
    /// Determines if the physical device supports a given extension.
    /// </summary>
    /// <remarks>
    /// Answers from <see cref="ExtensionNames"/> so it stays consistent with that mutable set and
    /// with the pre-existing behaviour. This materializes the managed string set on first use;
    /// prefer <see cref="SupportsExtension(ReadOnlySpan{byte})"/> on hot paths to avoid the allocation.
    /// </remarks>
    public bool SupportsExtension(string extension)
    {
        return ExtensionNames.Contains(extension);
    }

    /// <summary>
    /// <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/vkCreateDevice.html">vkCreateDevice</see> - Create a new device instance
    /// </summary>
    /// <returns>Device object wrapping a DeviceHandle</returns>
    public Device CreateDevice(Device.CreateInfo createInfo)
    {
        return new Device(this, createInfo);
    }

    public VkPhysicalDevice Handle { get; init; }
    public ref VkInstance.FunctionTable PInvoke => ref Instance.PInvoke;

    public bool IsNull() => Handle.IsNull();

    public VkObjectType VkObjectType => Handle.VkObjectType;
    public IntPtr VkHandle => Handle.VkHandle;

    public static implicit operator VkPhysicalDevice(PhysicalDevice physicalDevice) => physicalDevice.Handle;
}
