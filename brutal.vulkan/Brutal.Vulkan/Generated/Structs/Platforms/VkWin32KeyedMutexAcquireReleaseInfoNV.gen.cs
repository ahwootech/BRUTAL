using System.Runtime.Versioning;

namespace Brutal.VulkanApi.Win32
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkWin32KeyedMutexAcquireReleaseInfoNV.html">VkWin32KeyedMutexAcquireReleaseInfoNV</see> - Use Windows keyex mutex mechanism to synchronize work
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         When submitting work that operates on memory imported from a Direct3D 11
    ///         resource to a queue, the keyed mutex mechanism may: be used in addition to
    ///         Vulkan semaphores to synchronize the work.
    ///         Keyed mutexes are a property of a properly created shareable Direct3D 11
    ///         resource.
    ///         They <i>can</i> only be used if the imported resource was created with the
    ///         etext:D3D11_RESOURCE_MISC_SHARED_KEYEDMUTEX flag.
    ///     </para>
    ///     <para>
    ///         To acquire keyed mutexes before submitted work and/or release them after,
    ///         add a <c>VkWin32KeyedMutexAcquireReleaseInfoNV</c> structure to the
    ///         <c>pNext</c> chain of the <c>VkSubmitInfo</c> structure.
    ///     </para>
    ///     <para>
    ///         The <c>VkWin32KeyedMutexAcquireReleaseInfoNV</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_win32_keyed_mutex
    ///         typedef struct VkWin32KeyedMutexAcquireReleaseInfoNV {
    ///             VkStructureType          sType;
    ///             const void*              pNext;
    ///             uint32_t                 acquireCount;
    ///             const VkDeviceMemory*    pAcquireSyncs;
    ///             const uint64_t*          pAcquireKeys;
    ///             const uint32_t*          pAcquireTimeoutMilliseconds;
    ///             uint32_t                 releaseCount;
    ///             const VkDeviceMemory*    pReleaseSyncs;
    ///             const uint64_t*          pReleaseKeys;
    ///         } VkWin32KeyedMutexAcquireReleaseInfoNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    [SupportedOSPlatform("windows")]
    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNV;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>AcquireCount</c> is the number of entries in the <c>pAcquireSyncs</c>, <c>pAcquireKeys</c>, and <c>pAcquireTimeoutMilliseconds</c> arrays.
        /// </summary>
        [FieldOffset(16)]
        public int AcquireCount;

        /// <summary>
        ///     <c>AcquireSyncs</c> is a pointer to an array of <c>VkDeviceMemory</c> objects which were imported from Direct3D 11 resources.
        /// </summary>
        [FieldOffset(24)]
        public VkDeviceMemory* AcquireSyncs;

        /// <summary>
        ///     <c>AcquireKeys</c> is a pointer to an array of mutex key values to wait for prior to beginning the submitted work. Entries refer to the keyed mutex associated with the corresponding entries in <c>pAcquireSyncs</c>.
        /// </summary>
        [FieldOffset(32)]
        public nint* AcquireKeys;

        /// <summary>
        ///     <c>AcquireTimeoutMilliseconds</c> is a pointer to an array of timeout values, in millisecond units, for each acquire specified in <c>pAcquireKeys</c>.
        /// </summary>
        [FieldOffset(40)]
        public int* AcquireTimeoutMilliseconds;

        /// <summary>
        ///     <c>ReleaseCount</c> is the number of entries in the <c>pReleaseSyncs</c> and <c>pReleaseKeys</c> arrays.
        /// </summary>
        [FieldOffset(48)]
        public int ReleaseCount;

        /// <summary>
        ///     <c>ReleaseSyncs</c> is a pointer to an array of <c>VkDeviceMemory</c> objects which were imported from Direct3D 11 resources.
        /// </summary>
        [FieldOffset(56)]
        public VkDeviceMemory* ReleaseSyncs;

        /// <summary>
        ///     <c>ReleaseKeys</c> is a pointer to an array of mutex key values to set when the submitted work has completed. Entries refer to the keyed mutex associated with the corresponding entries in <c>pReleaseSyncs</c>.
        /// </summary>
        [FieldOffset(64)]
        public nint* ReleaseKeys;
    }
}
