namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDeviceBufferMemoryRequirements.html">VkDeviceBufferMemoryRequirements</see> - (None)
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkDeviceBufferMemoryRequirements</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_3
    ///         typedef struct VkDeviceBufferMemoryRequirements {
    ///             VkStructureType              sType;
    ///             const void*                  pNext;
    ///             const VkBufferCreateInfo*    pCreateInfo;
    ///         } VkDeviceBufferMemoryRequirements;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct VkDeviceBufferMemoryRequirements()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DeviceBufferMemoryRequirements;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>CreateInfo</c> is a pointer to a <c>VkBufferCreateInfo</c> structure containing parameters affecting creation of the buffer to query.
        /// </summary>
        [FieldOffset(16)]
        public VkBufferCreateInfo* CreateInfo;
    }
}
