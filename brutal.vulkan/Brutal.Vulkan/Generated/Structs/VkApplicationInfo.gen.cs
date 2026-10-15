namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkApplicationInfo.html">VkApplicationInfo</see> - Structure specifying application information
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkApplicationInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkApplicationInfo {
    ///             VkStructureType    sType;
    ///             const void*        pNext;
    ///             const char*        pApplicationName;
    ///             uint32_t           applicationVersion;
    ///             const char*        pEngineName;
    ///             uint32_t           engineVersion;
    ///             uint32_t           apiVersion;
    ///         } VkApplicationInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public unsafe partial struct VkApplicationInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.ApplicationInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>ApplicationName</c> is `NULL` or is a pointer to a null-terminated UTF-8 string containing the name of the application.
        /// </summary>
        [FieldOffset(16)]
        public byte* ApplicationName;

        /// <summary>
        ///     <c>ApplicationVersion</c> is an unsigned integer variable containing the developer-supplied version number of the application.
        /// </summary>
        [FieldOffset(24)]
        public int ApplicationVersion;

        /// <summary>
        ///     <c>EngineName</c> is `NULL` or is a pointer to a null-terminated UTF-8 string containing the name of the engine (if any) used to create the application.
        /// </summary>
        [FieldOffset(32)]
        public byte* EngineName;

        /// <summary>
        ///     <c>EngineVersion</c> is an unsigned integer variable containing the developer-supplied version number of the engine used to create the application.
        /// </summary>
        [FieldOffset(40)]
        public int EngineVersion;

        /// <summary>
        ///     <c>ApiVersion</c> is the version of the Vulkan API against which the application expects to run, encoded as described in <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#extendingvulkan-coreversions-versionnumbers">here</see>. If <c>apiVersion</c> is 0 the implementation <i>must</i> ignore it, otherwise if the implementation does not support the requested <c>apiVersion</c>, or an effective substitute for <c>apiVersion</c>, it <i>must</i> return <c>VK_ERROR_INCOMPATIBLE_DRIVER</c>. The patch version number specified in <c>apiVersion</c> is ignored when creating an instance object. The variant version of the instance <i>must</i> match that requested in <c>apiVersion</c>.
        /// </summary>
        [FieldOffset(44)]
        public int ApiVersion;
    }
}
