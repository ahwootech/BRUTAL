namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateInfo.html">VkSamplerCreateInfo</see> - Structure specifying parameters of a newly created sampler
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The <c>VkSamplerCreateInfo</c> structure is defined as:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef struct VkSamplerCreateInfo {
    ///             VkStructureType         sType;
    ///             const void*             pNext;
    ///             VkSamplerCreateFlags    flags;
    ///             VkFilter                magFilter;
    ///             VkFilter                minFilter;
    ///             VkSamplerMipmapMode     mipmapMode;
    ///             VkSamplerAddressMode    addressModeU;
    ///             VkSamplerAddressMode    addressModeV;
    ///             VkSamplerAddressMode    addressModeW;
    ///             float                   mipLodBias;
    ///             VkBool32                anisotropyEnable;
    ///             float                   maxAnisotropy;
    ///             VkBool32                compareEnable;
    ///             VkCompareOp             compareOp;
    ///             float                   minLod;
    ///             float                   maxLod;
    ///             VkBorderColor           borderColor;
    ///             VkBool32                unnormalizedCoordinates;
    ///         } VkSamplerCreateInfo;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public unsafe partial struct VkSamplerCreateInfo()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.SamplerCreateInfo;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is a bitmask of <c>VkSamplerCreateFlags</c> describing additional parameters of the sampler.
        /// </summary>
        [FieldOffset(16)]
        public VkSamplerCreateFlags Flags;

        /// <summary>
        ///     <c>MagFilter</c> is a <c>VkFilter</c> value specifying the magnification filter to apply to lookups.
        /// </summary>
        [FieldOffset(20)]
        public VkFilter MagFilter;

        /// <summary>
        ///     <c>MinFilter</c> is a <c>VkFilter</c> value specifying the minification filter to apply to lookups.
        /// </summary>
        [FieldOffset(24)]
        public VkFilter MinFilter;

        /// <summary>
        ///     <c>MipmapMode</c> is a <c>VkSamplerMipmapMode</c> value specifying the mipmap filter to apply to lookups.
        /// </summary>
        [FieldOffset(28)]
        public VkSamplerMipmapMode MipmapMode;

        /// <summary>
        ///     <c>AddressModeU</c> is a <c>VkSamplerAddressMode</c> value specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-wrapping-operation">wrapping operation^</see> used when the <c>i</c> coordinate used to sample the image would be out of bounds.
        /// </summary>
        [FieldOffset(32)]
        public VkSamplerAddressMode AddressModeU;

        /// <summary>
        ///     <c>AddressModeV</c> is a <c>VkSamplerAddressMode</c> value specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-wrapping-operation">wrapping operation^</see> used when the <c>j</c> coordinate used to sample the image would be out of bounds.
        /// </summary>
        [FieldOffset(36)]
        public VkSamplerAddressMode AddressModeV;

        /// <summary>
        ///     <c>AddressModeW</c> is a <c>VkSamplerAddressMode</c> value specifying the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-wrapping-operation">wrapping operation^</see> used when the <c>k</c> coordinate used to sample the image would be out of bounds. If <c>unnormalizedCoordinates</c> is <c>VK_TRUE</c>, <c>addressModeW</c> is ignored.
        /// </summary>
        [FieldOffset(40)]
        public VkSamplerAddressMode AddressModeW;

        /// <summary>
        ///     <c>MipLodBias</c>
        /// </summary>
        [FieldOffset(44)]
        public float MipLodBias;

        /// <summary>
        ///     <c>AnisotropyEnable</c>
        /// </summary>
        [FieldOffset(48)]
        public Brutal.Bool32 AnisotropyEnable;

        /// <summary>
        ///     <c>MaxAnisotropy</c> is the anisotropy value clamp used by the sampler when <c>anisotropyEnable</c> is <c>VK_TRUE</c>. If <c>anisotropyEnable</c> is <c>VK_FALSE</c>, <c>maxAnisotropy</c> is ignored.
        /// </summary>
        [FieldOffset(52)]
        public float MaxAnisotropy;

        /// <summary>
        ///     <c>CompareEnable</c> is <c>VK_TRUE</c> to enable comparison against a reference value during lookups, or <c>VK_FALSE</c> otherwise.
        /// </summary>
        [FieldOffset(56)]
        public Brutal.Bool32 CompareEnable;

        /// <summary>
        ///     <c>CompareOp</c> is a <c>VkCompareOp</c> value specifying the comparison operator to apply to fetched data before filtering as described in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-depth-compare-operation">Depth Compare Operation^</see> section.
        /// </summary>
        [FieldOffset(60)]
        public VkCompareOp CompareOp;

        /// <summary>
        ///     <c>MinLod</c> is used to clamp the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-level-of-detail-operation">minimum of the computed LOD value^</see>.
        /// </summary>
        [FieldOffset(64)]
        public float MinLod;

        /// <summary>
        ///     <c>MaxLod</c> is used to clamp the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#textures-level-of-detail-operation">maximum of the computed LOD value^</see>. To avoid clamping the maximum value, set <c>maxLod</c> to the constant <c>VK_LOD_CLAMP_NONE</c>.
        /// </summary>
        [FieldOffset(68)]
        public float MaxLod;

        /// <summary>
        ///     <c>BorderColor</c> is a <c>VkBorderColor</c> value specifying the predefined border color to use.
        /// </summary>
        [FieldOffset(72)]
        public VkBorderColor BorderColor;

        /// <summary>
        ///     <c>UnnormalizedCoordinates</c>
        /// </summary>
        [FieldOffset(76)]
        public Brutal.Bool32 UnnormalizedCoordinates;
    }
}
