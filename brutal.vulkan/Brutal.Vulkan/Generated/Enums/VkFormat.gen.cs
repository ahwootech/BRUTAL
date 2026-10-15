namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkFormat.html">VkFormat</see> - Available image formats
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The following image formats <i>can</i> be passed to, and may: be returned from
    ///         Vulkan commands.
    ///         The memory required to store each format is discussed with that format, and
    ///         also summarized in the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#texel-block-size">Representation and Texel Block
    ///         Size^</see> section and the <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#formats-compatibility">Compatible formats^</see> table.
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         typedef enum VkFormat {
    ///             VK_FORMAT_UNDEFINED = 0,
    ///             VK_FORMAT_R4G4_UNORM_PACK8 = 1,
    ///             VK_FORMAT_R4G4B4A4_UNORM_PACK16 = 2,
    ///             VK_FORMAT_B4G4R4A4_UNORM_PACK16 = 3,
    ///             VK_FORMAT_R5G6B5_UNORM_PACK16 = 4,
    ///             VK_FORMAT_B5G6R5_UNORM_PACK16 = 5,
    ///             VK_FORMAT_R5G5B5A1_UNORM_PACK16 = 6,
    ///             VK_FORMAT_B5G5R5A1_UNORM_PACK16 = 7,
    ///             VK_FORMAT_A1R5G5B5_UNORM_PACK16 = 8,
    ///             VK_FORMAT_R8_UNORM = 9,
    ///             VK_FORMAT_R8_SNORM = 10,
    ///             VK_FORMAT_R8_USCALED = 11,
    ///             VK_FORMAT_R8_SSCALED = 12,
    ///             VK_FORMAT_R8_UINT = 13,
    ///             VK_FORMAT_R8_SINT = 14,
    ///             VK_FORMAT_R8_SRGB = 15,
    ///             VK_FORMAT_R8G8_UNORM = 16,
    ///             VK_FORMAT_R8G8_SNORM = 17,
    ///             VK_FORMAT_R8G8_USCALED = 18,
    ///             VK_FORMAT_R8G8_SSCALED = 19,
    ///             VK_FORMAT_R8G8_UINT = 20,
    ///             VK_FORMAT_R8G8_SINT = 21,
    ///             VK_FORMAT_R8G8_SRGB = 22,
    ///             VK_FORMAT_R8G8B8_UNORM = 23,
    ///             VK_FORMAT_R8G8B8_SNORM = 24,
    ///             VK_FORMAT_R8G8B8_USCALED = 25,
    ///             VK_FORMAT_R8G8B8_SSCALED = 26,
    ///             VK_FORMAT_R8G8B8_UINT = 27,
    ///             VK_FORMAT_R8G8B8_SINT = 28,
    ///             VK_FORMAT_R8G8B8_SRGB = 29,
    ///             VK_FORMAT_B8G8R8_UNORM = 30,
    ///             VK_FORMAT_B8G8R8_SNORM = 31,
    ///             VK_FORMAT_B8G8R8_USCALED = 32,
    ///             VK_FORMAT_B8G8R8_SSCALED = 33,
    ///             VK_FORMAT_B8G8R8_UINT = 34,
    ///             VK_FORMAT_B8G8R8_SINT = 35,
    ///             VK_FORMAT_B8G8R8_SRGB = 36,
    ///             VK_FORMAT_R8G8B8A8_UNORM = 37,
    ///             VK_FORMAT_R8G8B8A8_SNORM = 38,
    ///             VK_FORMAT_R8G8B8A8_USCALED = 39,
    ///             VK_FORMAT_R8G8B8A8_SSCALED = 40,
    ///             VK_FORMAT_R8G8B8A8_UINT = 41,
    ///             VK_FORMAT_R8G8B8A8_SINT = 42,
    ///             VK_FORMAT_R8G8B8A8_SRGB = 43,
    ///             VK_FORMAT_B8G8R8A8_UNORM = 44,
    ///             VK_FORMAT_B8G8R8A8_SNORM = 45,
    ///             VK_FORMAT_B8G8R8A8_USCALED = 46,
    ///             VK_FORMAT_B8G8R8A8_SSCALED = 47,
    ///             VK_FORMAT_B8G8R8A8_UINT = 48,
    ///             VK_FORMAT_B8G8R8A8_SINT = 49,
    ///             VK_FORMAT_B8G8R8A8_SRGB = 50,
    ///             VK_FORMAT_A8B8G8R8_UNORM_PACK32 = 51,
    ///             VK_FORMAT_A8B8G8R8_SNORM_PACK32 = 52,
    ///             VK_FORMAT_A8B8G8R8_USCALED_PACK32 = 53,
    ///             VK_FORMAT_A8B8G8R8_SSCALED_PACK32 = 54,
    ///             VK_FORMAT_A8B8G8R8_UINT_PACK32 = 55,
    ///             VK_FORMAT_A8B8G8R8_SINT_PACK32 = 56,
    ///             VK_FORMAT_A8B8G8R8_SRGB_PACK32 = 57,
    ///             VK_FORMAT_A2R10G10B10_UNORM_PACK32 = 58,
    ///             VK_FORMAT_A2R10G10B10_SNORM_PACK32 = 59,
    ///             VK_FORMAT_A2R10G10B10_USCALED_PACK32 = 60,
    ///             VK_FORMAT_A2R10G10B10_SSCALED_PACK32 = 61,
    ///             VK_FORMAT_A2R10G10B10_UINT_PACK32 = 62,
    ///             VK_FORMAT_A2R10G10B10_SINT_PACK32 = 63,
    ///             VK_FORMAT_A2B10G10R10_UNORM_PACK32 = 64,
    ///             VK_FORMAT_A2B10G10R10_SNORM_PACK32 = 65,
    ///             VK_FORMAT_A2B10G10R10_USCALED_PACK32 = 66,
    ///             VK_FORMAT_A2B10G10R10_SSCALED_PACK32 = 67,
    ///             VK_FORMAT_A2B10G10R10_UINT_PACK32 = 68,
    ///             VK_FORMAT_A2B10G10R10_SINT_PACK32 = 69,
    ///             VK_FORMAT_R16_UNORM = 70,
    ///             VK_FORMAT_R16_SNORM = 71,
    ///             VK_FORMAT_R16_USCALED = 72,
    ///             VK_FORMAT_R16_SSCALED = 73,
    ///             VK_FORMAT_R16_UINT = 74,
    ///             VK_FORMAT_R16_SINT = 75,
    ///             VK_FORMAT_R16_SFLOAT = 76,
    ///             VK_FORMAT_R16G16_UNORM = 77,
    ///             VK_FORMAT_R16G16_SNORM = 78,
    ///             VK_FORMAT_R16G16_USCALED = 79,
    ///             VK_FORMAT_R16G16_SSCALED = 80,
    ///             VK_FORMAT_R16G16_UINT = 81,
    ///             VK_FORMAT_R16G16_SINT = 82,
    ///             VK_FORMAT_R16G16_SFLOAT = 83,
    ///             VK_FORMAT_R16G16B16_UNORM = 84,
    ///             VK_FORMAT_R16G16B16_SNORM = 85,
    ///             VK_FORMAT_R16G16B16_USCALED = 86,
    ///             VK_FORMAT_R16G16B16_SSCALED = 87,
    ///             VK_FORMAT_R16G16B16_UINT = 88,
    ///             VK_FORMAT_R16G16B16_SINT = 89,
    ///             VK_FORMAT_R16G16B16_SFLOAT = 90,
    ///             VK_FORMAT_R16G16B16A16_UNORM = 91,
    ///             VK_FORMAT_R16G16B16A16_SNORM = 92,
    ///             VK_FORMAT_R16G16B16A16_USCALED = 93,
    ///             VK_FORMAT_R16G16B16A16_SSCALED = 94,
    ///             VK_FORMAT_R16G16B16A16_UINT = 95,
    ///             VK_FORMAT_R16G16B16A16_SINT = 96,
    ///             VK_FORMAT_R16G16B16A16_SFLOAT = 97,
    ///             VK_FORMAT_R32_UINT = 98,
    ///             VK_FORMAT_R32_SINT = 99,
    ///             VK_FORMAT_R32_SFLOAT = 100,
    ///             VK_FORMAT_R32G32_UINT = 101,
    ///             VK_FORMAT_R32G32_SINT = 102,
    ///             VK_FORMAT_R32G32_SFLOAT = 103,
    ///             VK_FORMAT_R32G32B32_UINT = 104,
    ///             VK_FORMAT_R32G32B32_SINT = 105,
    ///             VK_FORMAT_R32G32B32_SFLOAT = 106,
    ///             VK_FORMAT_R32G32B32A32_UINT = 107,
    ///             VK_FORMAT_R32G32B32A32_SINT = 108,
    ///             VK_FORMAT_R32G32B32A32_SFLOAT = 109,
    ///             VK_FORMAT_R64_UINT = 110,
    ///             VK_FORMAT_R64_SINT = 111,
    ///             VK_FORMAT_R64_SFLOAT = 112,
    ///             VK_FORMAT_R64G64_UINT = 113,
    ///             VK_FORMAT_R64G64_SINT = 114,
    ///             VK_FORMAT_R64G64_SFLOAT = 115,
    ///             VK_FORMAT_R64G64B64_UINT = 116,
    ///             VK_FORMAT_R64G64B64_SINT = 117,
    ///             VK_FORMAT_R64G64B64_SFLOAT = 118,
    ///             VK_FORMAT_R64G64B64A64_UINT = 119,
    ///             VK_FORMAT_R64G64B64A64_SINT = 120,
    ///             VK_FORMAT_R64G64B64A64_SFLOAT = 121,
    ///             VK_FORMAT_B10G11R11_UFLOAT_PACK32 = 122,
    ///             VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 = 123,
    ///             VK_FORMAT_D16_UNORM = 124,
    ///             VK_FORMAT_X8_D24_UNORM_PACK32 = 125,
    ///             VK_FORMAT_D32_SFLOAT = 126,
    ///             VK_FORMAT_S8_UINT = 127,
    ///             VK_FORMAT_D16_UNORM_S8_UINT = 128,
    ///             VK_FORMAT_D24_UNORM_S8_UINT = 129,
    ///             VK_FORMAT_D32_SFLOAT_S8_UINT = 130,
    ///             VK_FORMAT_BC1_RGB_UNORM_BLOCK = 131,
    ///             VK_FORMAT_BC1_RGB_SRGB_BLOCK = 132,
    ///             VK_FORMAT_BC1_RGBA_UNORM_BLOCK = 133,
    ///             VK_FORMAT_BC1_RGBA_SRGB_BLOCK = 134,
    ///             VK_FORMAT_BC2_UNORM_BLOCK = 135,
    ///             VK_FORMAT_BC2_SRGB_BLOCK = 136,
    ///             VK_FORMAT_BC3_UNORM_BLOCK = 137,
    ///             VK_FORMAT_BC3_SRGB_BLOCK = 138,
    ///             VK_FORMAT_BC4_UNORM_BLOCK = 139,
    ///             VK_FORMAT_BC4_SNORM_BLOCK = 140,
    ///             VK_FORMAT_BC5_UNORM_BLOCK = 141,
    ///             VK_FORMAT_BC5_SNORM_BLOCK = 142,
    ///             VK_FORMAT_BC6H_UFLOAT_BLOCK = 143,
    ///             VK_FORMAT_BC6H_SFLOAT_BLOCK = 144,
    ///             VK_FORMAT_BC7_UNORM_BLOCK = 145,
    ///             VK_FORMAT_BC7_SRGB_BLOCK = 146,
    ///             VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK = 147,
    ///             VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK = 148,
    ///             VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK = 149,
    ///             VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK = 150,
    ///             VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK = 151,
    ///             VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK = 152,
    ///             VK_FORMAT_EAC_R11_UNORM_BLOCK = 153,
    ///             VK_FORMAT_EAC_R11_SNORM_BLOCK = 154,
    ///             VK_FORMAT_EAC_R11G11_UNORM_BLOCK = 155,
    ///             VK_FORMAT_EAC_R11G11_SNORM_BLOCK = 156,
    ///             VK_FORMAT_ASTC_4x4_UNORM_BLOCK = 157,
    ///             VK_FORMAT_ASTC_4x4_SRGB_BLOCK = 158,
    ///             VK_FORMAT_ASTC_5x4_UNORM_BLOCK = 159,
    ///             VK_FORMAT_ASTC_5x4_SRGB_BLOCK = 160,
    ///             VK_FORMAT_ASTC_5x5_UNORM_BLOCK = 161,
    ///             VK_FORMAT_ASTC_5x5_SRGB_BLOCK = 162,
    ///             VK_FORMAT_ASTC_6x5_UNORM_BLOCK = 163,
    ///             VK_FORMAT_ASTC_6x5_SRGB_BLOCK = 164,
    ///             VK_FORMAT_ASTC_6x6_UNORM_BLOCK = 165,
    ///             VK_FORMAT_ASTC_6x6_SRGB_BLOCK = 166,
    ///             VK_FORMAT_ASTC_8x5_UNORM_BLOCK = 167,
    ///             VK_FORMAT_ASTC_8x5_SRGB_BLOCK = 168,
    ///             VK_FORMAT_ASTC_8x6_UNORM_BLOCK = 169,
    ///             VK_FORMAT_ASTC_8x6_SRGB_BLOCK = 170,
    ///             VK_FORMAT_ASTC_8x8_UNORM_BLOCK = 171,
    ///             VK_FORMAT_ASTC_8x8_SRGB_BLOCK = 172,
    ///             VK_FORMAT_ASTC_10x5_UNORM_BLOCK = 173,
    ///             VK_FORMAT_ASTC_10x5_SRGB_BLOCK = 174,
    ///             VK_FORMAT_ASTC_10x6_UNORM_BLOCK = 175,
    ///             VK_FORMAT_ASTC_10x6_SRGB_BLOCK = 176,
    ///             VK_FORMAT_ASTC_10x8_UNORM_BLOCK = 177,
    ///             VK_FORMAT_ASTC_10x8_SRGB_BLOCK = 178,
    ///             VK_FORMAT_ASTC_10x10_UNORM_BLOCK = 179,
    ///             VK_FORMAT_ASTC_10x10_SRGB_BLOCK = 180,
    ///             VK_FORMAT_ASTC_12x10_UNORM_BLOCK = 181,
    ///             VK_FORMAT_ASTC_12x10_SRGB_BLOCK = 182,
    ///             VK_FORMAT_ASTC_12x12_UNORM_BLOCK = 183,
    ///             VK_FORMAT_ASTC_12x12_SRGB_BLOCK = 184,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G8B8G8R8_422_UNORM = 1000156000,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_B8G8R8G8_422_UNORM = 1000156001,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM = 1000156002,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G8_B8R8_2PLANE_420_UNORM = 1000156003,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM = 1000156004,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G8_B8R8_2PLANE_422_UNORM = 1000156005,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM = 1000156006,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_R10X6_UNORM_PACK16 = 1000156007,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_R10X6G10X6_UNORM_2PACK16 = 1000156008,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 = 1000156009,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 = 1000156010,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 = 1000156011,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 = 1000156012,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 = 1000156013,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 = 1000156014,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 = 1000156015,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 = 1000156016,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_R12X4_UNORM_PACK16 = 1000156017,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_R12X4G12X4_UNORM_2PACK16 = 1000156018,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 = 1000156019,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 = 1000156020,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 = 1000156021,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 = 1000156022,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 = 1000156023,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 = 1000156024,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 = 1000156025,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 = 1000156026,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G16B16G16R16_422_UNORM = 1000156027,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_B16G16R16G16_422_UNORM = 1000156028,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM = 1000156029,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G16_B16R16_2PLANE_420_UNORM = 1000156030,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM = 1000156031,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G16_B16R16_2PLANE_422_UNORM = 1000156032,
    ///             // Provided by VK_VERSION_1_1
    ///             VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM = 1000156033,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_G8_B8R8_2PLANE_444_UNORM = 1000330000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16 = 1000330001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16 = 1000330002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_G16_B16R16_2PLANE_444_UNORM = 1000330003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_A4R4G4B4_UNORM_PACK16 = 1000340000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_A4B4G4R4_UNORM_PACK16 = 1000340001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK = 1000066000,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK = 1000066001,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK = 1000066002,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK = 1000066003,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK = 1000066004,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK = 1000066005,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK = 1000066006,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK = 1000066007,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK = 1000066008,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK = 1000066009,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK = 1000066010,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK = 1000066011,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK = 1000066012,
    ///             // Provided by VK_VERSION_1_3
    ///             VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK = 1000066013,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_FORMAT_A1B5G5R5_UNORM_PACK16 = 1000470000,
    ///             // Provided by VK_VERSION_1_4
    ///             VK_FORMAT_A8_UNORM = 1000470001,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG = 1000054000,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG = 1000054001,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG = 1000054002,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG = 1000054003,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG = 1000054004,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG = 1000054005,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG = 1000054006,
    ///             // Provided by VK_IMG_format_pvrtc
    ///             VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG = 1000054007,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_3x3x3_UNORM_BLOCK_EXT = 1000288000,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_3x3x3_SRGB_BLOCK_EXT = 1000288001,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_3x3x3_SFLOAT_BLOCK_EXT = 1000288002,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x3x3_UNORM_BLOCK_EXT = 1000288003,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x3x3_SRGB_BLOCK_EXT = 1000288004,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x3x3_SFLOAT_BLOCK_EXT = 1000288005,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x4x3_UNORM_BLOCK_EXT = 1000288006,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x4x3_SRGB_BLOCK_EXT = 1000288007,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x4x3_SFLOAT_BLOCK_EXT = 1000288008,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x4x4_UNORM_BLOCK_EXT = 1000288009,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x4x4_SRGB_BLOCK_EXT = 1000288010,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_4x4x4_SFLOAT_BLOCK_EXT = 1000288011,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x4x4_UNORM_BLOCK_EXT = 1000288012,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x4x4_SRGB_BLOCK_EXT = 1000288013,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x4x4_SFLOAT_BLOCK_EXT = 1000288014,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x5x4_UNORM_BLOCK_EXT = 1000288015,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x5x4_SRGB_BLOCK_EXT = 1000288016,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x5x4_SFLOAT_BLOCK_EXT = 1000288017,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x5x5_UNORM_BLOCK_EXT = 1000288018,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x5x5_SRGB_BLOCK_EXT = 1000288019,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_5x5x5_SFLOAT_BLOCK_EXT = 1000288020,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x5x5_UNORM_BLOCK_EXT = 1000288021,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x5x5_SRGB_BLOCK_EXT = 1000288022,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x5x5_SFLOAT_BLOCK_EXT = 1000288023,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x6x5_UNORM_BLOCK_EXT = 1000288024,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x6x5_SRGB_BLOCK_EXT = 1000288025,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x6x5_SFLOAT_BLOCK_EXT = 1000288026,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x6x6_UNORM_BLOCK_EXT = 1000288027,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x6x6_SRGB_BLOCK_EXT = 1000288028,
    ///             // Provided by VK_EXT_texture_compression_astc_3d
    ///             VK_FORMAT_ASTC_6x6x6_SFLOAT_BLOCK_EXT = 1000288029,
    ///             // Provided by VK_ARM_tensors
    ///             VK_FORMAT_R8_BOOL_ARM = 1000460000,
    ///             // Provided by VK_KHR_shader_bfloat16 with VK_ARM_tensors
    ///             VK_FORMAT_R16_SFLOAT_FPENCODING_BFLOAT16_ARM = 1000460001,
    ///             // Provided by VK_EXT_shader_float8 with VK_ARM_tensors
    ///             VK_FORMAT_R8_SFLOAT_FPENCODING_FLOAT8E4M3_ARM = 1000460002,
    ///             // Provided by VK_EXT_shader_float8 with VK_ARM_tensors
    ///             VK_FORMAT_R8_SFLOAT_FPENCODING_FLOAT8E5M2_ARM = 1000460003,
    ///             // Provided by VK_NV_optical_flow
    ///             VK_FORMAT_R16G16_SFIXED5_NV = 1000464000,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R10X6_UINT_PACK16_ARM = 1000609000,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R10X6G10X6_UINT_2PACK16_ARM = 1000609001,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R10X6G10X6B10X6A10X6_UINT_4PACK16_ARM = 1000609002,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R12X4_UINT_PACK16_ARM = 1000609003,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R12X4G12X4_UINT_2PACK16_ARM = 1000609004,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R12X4G12X4B12X4A12X4_UINT_4PACK16_ARM = 1000609005,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R14X2_UINT_PACK16_ARM = 1000609006,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R14X2G14X2_UINT_2PACK16_ARM = 1000609007,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R14X2G14X2B14X2A14X2_UINT_4PACK16_ARM = 1000609008,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R14X2_UNORM_PACK16_ARM = 1000609009,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R14X2G14X2_UNORM_2PACK16_ARM = 1000609010,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_R14X2G14X2B14X2A14X2_UNORM_4PACK16_ARM = 1000609011,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_G14X2_B14X2R14X2_2PLANE_420_UNORM_3PACK16_ARM = 1000609012,
    ///             // Provided by VK_ARM_format_pack
    ///             VK_FORMAT_G14X2_B14X2R14X2_2PLANE_422_UNORM_3PACK16_ARM = 1000609013,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK,
    ///             // Provided by VK_EXT_texture_compression_astc_hdr
    ///             VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK_EXT = VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G8B8G8R8_422_UNORM_KHR = VK_FORMAT_G8B8G8R8_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_B8G8R8G8_422_UNORM_KHR = VK_FORMAT_B8G8R8G8_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G8_B8R8_2PLANE_420_UNORM_KHR = VK_FORMAT_G8_B8R8_2PLANE_420_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G8_B8R8_2PLANE_422_UNORM_KHR = VK_FORMAT_G8_B8R8_2PLANE_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM_KHR = VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_R10X6_UNORM_PACK16_KHR = VK_FORMAT_R10X6_UNORM_PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_R10X6G10X6_UNORM_2PACK16_KHR = VK_FORMAT_R10X6G10X6_UNORM_2PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR = VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR = VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR = VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR = VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_R12X4_UNORM_PACK16_KHR = VK_FORMAT_R12X4_UNORM_PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_R12X4G12X4_UNORM_2PACK16_KHR = VK_FORMAT_R12X4G12X4_UNORM_2PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR = VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR = VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR = VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR = VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G16B16G16R16_422_UNORM_KHR = VK_FORMAT_G16B16G16R16_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_B16G16R16G16_422_UNORM_KHR = VK_FORMAT_B16G16R16G16_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G16_B16R16_2PLANE_420_UNORM_KHR = VK_FORMAT_G16_B16R16_2PLANE_420_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G16_B16R16_2PLANE_422_UNORM_KHR = VK_FORMAT_G16_B16R16_2PLANE_422_UNORM,
    ///             // Provided by VK_KHR_sampler_ycbcr_conversion
    ///             VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM_KHR = VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM,
    ///             // Provided by VK_EXT_ycbcr_2plane_444_formats
    ///             VK_FORMAT_G8_B8R8_2PLANE_444_UNORM_EXT = VK_FORMAT_G8_B8R8_2PLANE_444_UNORM,
    ///             // Provided by VK_EXT_ycbcr_2plane_444_formats
    ///             VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16_EXT = VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16,
    ///             // Provided by VK_EXT_ycbcr_2plane_444_formats
    ///             VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16_EXT = VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16,
    ///             // Provided by VK_EXT_ycbcr_2plane_444_formats
    ///             VK_FORMAT_G16_B16R16_2PLANE_444_UNORM_EXT = VK_FORMAT_G16_B16R16_2PLANE_444_UNORM,
    ///             // Provided by VK_EXT_4444_formats
    ///             VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT = VK_FORMAT_A4R4G4B4_UNORM_PACK16,
    ///             // Provided by VK_EXT_4444_formats
    ///             VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT = VK_FORMAT_A4B4G4R4_UNORM_PACK16,
    ///             // Provided by VK_NV_optical_flow
    ///             // VK_FORMAT_R16G16_S10_5_NV is a legacy alias
    ///             VK_FORMAT_R16G16_S10_5_NV = VK_FORMAT_R16G16_SFIXED5_NV,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_FORMAT_A1B5G5R5_UNORM_PACK16_KHR = VK_FORMAT_A1B5G5R5_UNORM_PACK16,
    ///             // Provided by VK_KHR_maintenance5
    ///             VK_FORMAT_A8_UNORM_KHR = VK_FORMAT_A8_UNORM,
    ///         } VkFormat;
    ///     </code>
    /// </remarks>
    public enum VkFormat : int
    {
        /// <summary>
        ///     <c>Undefined</c> specifies that the format is not specified.
        /// </summary>
        Undefined = 0,

        /// <summary>
        ///     <c>R4G4UNormPack8</c> specifies a two-component, 8-bit packed unsigned normalized format that has a 4-bit R component in bits 4..7, and a 4-bit G component in bits 0..3.
        /// </summary>
        R4G4UNormPack8 = 1,

        /// <summary>
        ///     <c>R4G4B4A4UNormPack16</c> specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit R component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in bits 4..7, and a 4-bit A component in bits 0..3.
        /// </summary>
        R4G4B4A4UNormPack16 = 2,

        /// <summary>
        ///     <c>B4G4R4A4UNormPack16</c> specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit B component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in bits 4..7, and a 4-bit A component in bits 0..3.
        /// </summary>
        B4G4R4A4UNormPack16 = 3,

        /// <summary>
        ///     <c>R5G6B5UNormPack16</c> specifies a three-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component in bits 0..4.
        /// </summary>
        R5G6B5UNormPack16 = 4,

        /// <summary>
        ///     <c>B5G6R5UNormPack16</c> specifies a three-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component in bits 0..4.
        /// </summary>
        B5G6R5UNormPack16 = 5,

        /// <summary>
        ///     <c>R5G5B5A1UNormPack16</c> specifies a four-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in bits 1..5, and a 1-bit A component in bit 0.
        /// </summary>
        R5G5B5A1UNormPack16 = 6,

        /// <summary>
        ///     <c>B5G5R5A1UNormPack16</c> specifies a four-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in bits 1..5, and a 1-bit A component in bit 0.
        /// </summary>
        B5G5R5A1UNormPack16 = 7,

        /// <summary>
        ///     <c>A1R5G5B5UNormPack16</c> specifies a four-component, 16-bit packed unsigned normalized format that has a 1-bit A component in bit 15, a 5-bit R component in bits 10..14, a 5-bit G component in bits 5..9, and a 5-bit B component in bits 0..4.
        /// </summary>
        A1R5G5B5UNormPack16 = 8,

        /// <summary>
        ///     <c>R8UNorm</c> specifies a one-component, 8-bit unsigned normalized format that has a single 8-bit R component.
        /// </summary>
        R8UNorm = 9,

        /// <summary>
        ///     <c>R8SNorm</c> specifies a one-component, 8-bit signed normalized format that has a single 8-bit R component.
        /// </summary>
        R8SNorm = 10,

        /// <summary>
        ///     <c>R8UScaled</c> specifies a one-component, 8-bit unsigned scaled integer format that has a single 8-bit R component.
        /// </summary>
        R8UScaled = 11,

        /// <summary>
        ///     <c>R8SScaled</c> specifies a one-component, 8-bit signed scaled integer format that has a single 8-bit R component.
        /// </summary>
        R8SScaled = 12,

        /// <summary>
        ///     <c>R8UInt</c> specifies a one-component, 8-bit unsigned integer format that has a single 8-bit R component.
        /// </summary>
        R8UInt = 13,

        /// <summary>
        ///     <c>R8SInt</c> specifies a one-component, 8-bit signed integer format that has a single 8-bit R component.
        /// </summary>
        R8SInt = 14,

        /// <summary>
        ///     <c>R8SRGB</c> specifies a one-component, 8-bit unsigned normalized format that has a single 8-bit R component stored with sRGB nonlinear encoding.
        /// </summary>
        R8SRGB = 15,

        /// <summary>
        ///     <c>R8G8UNorm</c> specifies a two-component, 16-bit unsigned normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8UNorm = 16,

        /// <summary>
        ///     <c>R8G8SNorm</c> specifies a two-component, 16-bit signed normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8SNorm = 17,

        /// <summary>
        ///     <c>R8G8UScaled</c> specifies a two-component, 16-bit unsigned scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8UScaled = 18,

        /// <summary>
        ///     <c>R8G8SScaled</c> specifies a two-component, 16-bit signed scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8SScaled = 19,

        /// <summary>
        ///     <c>R8G8UInt</c> specifies a two-component, 16-bit unsigned integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8UInt = 20,

        /// <summary>
        ///     <c>R8G8SInt</c> specifies a two-component, 16-bit signed integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
        /// </summary>
        R8G8SInt = 21,

        /// <summary>
        ///     <c>R8G8SRGB</c> specifies a two-component, 16-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, and an 8-bit G component stored with sRGB nonlinear encoding in byte 1.
        /// </summary>
        R8G8SRGB = 22,

        /// <summary>
        ///     <c>R8G8B8UNorm</c> specifies a three-component, 24-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8UNorm = 23,

        /// <summary>
        ///     <c>R8G8B8SNorm</c> specifies a three-component, 24-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8SNorm = 24,

        /// <summary>
        ///     <c>R8G8B8UScaled</c> specifies a three-component, 24-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8UScaled = 25,

        /// <summary>
        ///     <c>R8G8B8SScaled</c> specifies a three-component, 24-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8SScaled = 26,

        /// <summary>
        ///     <c>R8G8B8UInt</c> specifies a three-component, 24-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8UInt = 27,

        /// <summary>
        ///     <c>R8G8B8SInt</c> specifies a three-component, 24-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
        /// </summary>
        R8G8B8SInt = 28,

        /// <summary>
        ///     <c>R8G8B8SRGB</c> specifies a three-component, 24-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit B component stored with sRGB nonlinear encoding in byte 2.
        /// </summary>
        R8G8B8SRGB = 29,

        /// <summary>
        ///     <c>B8G8R8UNorm</c> specifies a three-component, 24-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8UNorm = 30,

        /// <summary>
        ///     <c>B8G8R8SNorm</c> specifies a three-component, 24-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8SNorm = 31,

        /// <summary>
        ///     <c>B8G8R8UScaled</c> specifies a three-component, 24-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8UScaled = 32,

        /// <summary>
        ///     <c>B8G8R8SScaled</c> specifies a three-component, 24-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8SScaled = 33,

        /// <summary>
        ///     <c>B8G8R8UInt</c> specifies a three-component, 24-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8UInt = 34,

        /// <summary>
        ///     <c>B8G8R8SInt</c> specifies a three-component, 24-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
        /// </summary>
        B8G8R8SInt = 35,

        /// <summary>
        ///     <c>B8G8R8SRGB</c> specifies a three-component, 24-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit R component stored with sRGB nonlinear encoding in byte 2.
        /// </summary>
        B8G8R8SRGB = 36,

        /// <summary>
        ///     <c>R8G8B8A8UNorm</c> specifies a four-component, 32-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UNorm = 37,

        /// <summary>
        ///     <c>R8G8B8A8SNorm</c> specifies a four-component, 32-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SNorm = 38,

        /// <summary>
        ///     <c>R8G8B8A8UScaled</c> specifies a four-component, 32-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UScaled = 39,

        /// <summary>
        ///     <c>R8G8B8A8SScaled</c> specifies a four-component, 32-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SScaled = 40,

        /// <summary>
        ///     <c>R8G8B8A8UInt</c> specifies a four-component, 32-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8UInt = 41,

        /// <summary>
        ///     <c>R8G8B8A8SInt</c> specifies a four-component, 32-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SInt = 42,

        /// <summary>
        ///     <c>R8G8B8A8SRGB</c> specifies a four-component, 32-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit B component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        R8G8B8A8SRGB = 43,

        /// <summary>
        ///     <c>B8G8R8A8UNorm</c> specifies a four-component, 32-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UNorm = 44,

        /// <summary>
        ///     <c>B8G8R8A8SNorm</c> specifies a four-component, 32-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SNorm = 45,

        /// <summary>
        ///     <c>B8G8R8A8UScaled</c> specifies a four-component, 32-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UScaled = 46,

        /// <summary>
        ///     <c>B8G8R8A8SScaled</c> specifies a four-component, 32-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SScaled = 47,

        /// <summary>
        ///     <c>B8G8R8A8UInt</c> specifies a four-component, 32-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8UInt = 48,

        /// <summary>
        ///     <c>B8G8R8A8SInt</c> specifies a four-component, 32-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SInt = 49,

        /// <summary>
        ///     <c>B8G8R8A8SRGB</c> specifies a four-component, 32-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit R component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
        /// </summary>
        B8G8R8A8SRGB = 50,

        /// <summary>
        ///     <c>A8B8G8R8UNormPack32</c> specifies a four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8UNormPack32 = 51,

        /// <summary>
        ///     <c>A8B8G8R8SNormPack32</c> specifies a four-component, 32-bit packed signed normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8SNormPack32 = 52,

        /// <summary>
        ///     <c>A8B8G8R8UScaledPack32</c> specifies a four-component, 32-bit packed unsigned scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8UScaledPack32 = 53,

        /// <summary>
        ///     <c>A8B8G8R8SScaledPack32</c> specifies a four-component, 32-bit packed signed scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8SScaledPack32 = 54,

        /// <summary>
        ///     <c>A8B8G8R8UIntPack32</c> specifies a four-component, 32-bit packed unsigned integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8UIntPack32 = 55,

        /// <summary>
        ///     <c>A8B8G8R8SIntPack32</c> specifies a four-component, 32-bit packed signed integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
        /// </summary>
        A8B8G8R8SIntPack32 = 56,

        /// <summary>
        ///     <c>A8B8G8R8SRGBPack32</c> specifies a four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component stored with sRGB nonlinear encoding in bits 16..23, an 8-bit G component stored with sRGB nonlinear encoding in bits 8..15, and an 8-bit R component stored with sRGB nonlinear encoding in bits 0..7.
        /// </summary>
        A8B8G8R8SRGBPack32 = 57,

        /// <summary>
        ///     <c>A2R10G10B10UNormPack32</c> specifies a four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10UNormPack32 = 58,

        /// <summary>
        ///     <c>A2R10G10B10SNormPack32</c> specifies a four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10SNormPack32 = 59,

        /// <summary>
        ///     <c>A2R10G10B10UScaledPack32</c> specifies a four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10UScaledPack32 = 60,

        /// <summary>
        ///     <c>A2R10G10B10SScaledPack32</c> specifies a four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10SScaledPack32 = 61,

        /// <summary>
        ///     <c>A2R10G10B10UIntPack32</c> specifies a four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10UIntPack32 = 62,

        /// <summary>
        ///     <c>A2R10G10B10SIntPack32</c> specifies a four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
        /// </summary>
        A2R10G10B10SIntPack32 = 63,

        /// <summary>
        ///     <c>A2B10G10R10UNormPack32</c> specifies a four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10UNormPack32 = 64,

        /// <summary>
        ///     <c>A2B10G10R10SNormPack32</c> specifies a four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10SNormPack32 = 65,

        /// <summary>
        ///     <c>A2B10G10R10UScaledPack32</c> specifies a four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10UScaledPack32 = 66,

        /// <summary>
        ///     <c>A2B10G10R10SScaledPack32</c> specifies a four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10SScaledPack32 = 67,

        /// <summary>
        ///     <c>A2B10G10R10UIntPack32</c> specifies a four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10UIntPack32 = 68,

        /// <summary>
        ///     <c>A2B10G10R10SIntPack32</c> specifies a four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
        /// </summary>
        A2B10G10R10SIntPack32 = 69,

        /// <summary>
        ///     <c>R16UNorm</c> specifies a one-component, 16-bit unsigned normalized format that has a single 16-bit R component.
        /// </summary>
        R16UNorm = 70,

        /// <summary>
        ///     <c>R16SNorm</c> specifies a one-component, 16-bit signed normalized format that has a single 16-bit R component.
        /// </summary>
        R16SNorm = 71,

        /// <summary>
        ///     <c>R16UScaled</c> specifies a one-component, 16-bit unsigned scaled integer format that has a single 16-bit R component.
        /// </summary>
        R16UScaled = 72,

        /// <summary>
        ///     <c>R16SScaled</c> specifies a one-component, 16-bit signed scaled integer format that has a single 16-bit R component.
        /// </summary>
        R16SScaled = 73,

        /// <summary>
        ///     <c>R16UInt</c> specifies a one-component, 16-bit unsigned integer format that has a single 16-bit R component.
        /// </summary>
        R16UInt = 74,

        /// <summary>
        ///     <c>R16SInt</c> specifies a one-component, 16-bit signed integer format that has a single 16-bit R component.
        /// </summary>
        R16SInt = 75,

        /// <summary>
        ///     <c>R16SFloat</c> specifies a one-component, 16-bit signed floating-point format that has a single 16-bit R component.
        /// </summary>
        R16SFloat = 76,

        /// <summary>
        ///     <c>R16G16UNorm</c> specifies a two-component, 32-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UNorm = 77,

        /// <summary>
        ///     <c>R16G16SNorm</c> specifies a two-component, 32-bit signed normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SNorm = 78,

        /// <summary>
        ///     <c>R16G16UScaled</c> specifies a two-component, 32-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UScaled = 79,

        /// <summary>
        ///     <c>R16G16SScaled</c> specifies a two-component, 32-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SScaled = 80,

        /// <summary>
        ///     <c>R16G16UInt</c> specifies a two-component, 32-bit unsigned integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16UInt = 81,

        /// <summary>
        ///     <c>R16G16SInt</c> specifies a two-component, 32-bit signed integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SInt = 82,

        /// <summary>
        ///     <c>R16G16SFloat</c> specifies a two-component, 32-bit signed floating-point format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
        /// </summary>
        R16G16SFloat = 83,

        /// <summary>
        ///     <c>R16G16B16UNorm</c> specifies a three-component, 48-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16UNorm = 84,

        /// <summary>
        ///     <c>R16G16B16SNorm</c> specifies a three-component, 48-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SNorm = 85,

        /// <summary>
        ///     <c>R16G16B16UScaled</c> specifies a three-component, 48-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16UScaled = 86,

        /// <summary>
        ///     <c>R16G16B16SScaled</c> specifies a three-component, 48-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SScaled = 87,

        /// <summary>
        ///     <c>R16G16B16UInt</c> specifies a three-component, 48-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16UInt = 88,

        /// <summary>
        ///     <c>R16G16B16SInt</c> specifies a three-component, 48-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SInt = 89,

        /// <summary>
        ///     <c>R16G16B16SFloat</c> specifies a three-component, 48-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
        /// </summary>
        R16G16B16SFloat = 90,

        /// <summary>
        ///     <c>R16G16B16A16UNorm</c> specifies a four-component, 64-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16UNorm = 91,

        /// <summary>
        ///     <c>R16G16B16A16SNorm</c> specifies a four-component, 64-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SNorm = 92,

        /// <summary>
        ///     <c>R16G16B16A16UScaled</c> specifies a four-component, 64-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16UScaled = 93,

        /// <summary>
        ///     <c>R16G16B16A16SScaled</c> specifies a four-component, 64-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SScaled = 94,

        /// <summary>
        ///     <c>R16G16B16A16UInt</c> specifies a four-component, 64-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16UInt = 95,

        /// <summary>
        ///     <c>R16G16B16A16SInt</c> specifies a four-component, 64-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SInt = 96,

        /// <summary>
        ///     <c>R16G16B16A16SFloat</c> specifies a four-component, 64-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
        /// </summary>
        R16G16B16A16SFloat = 97,

        /// <summary>
        ///     <c>R32UInt</c> specifies a one-component, 32-bit unsigned integer format that has a single 32-bit R component.
        /// </summary>
        R32UInt = 98,

        /// <summary>
        ///     <c>R32SInt</c> specifies a one-component, 32-bit signed integer format that has a single 32-bit R component.
        /// </summary>
        R32SInt = 99,

        /// <summary>
        ///     <c>R32SFloat</c> specifies a one-component, 32-bit signed floating-point format that has a single 32-bit R component.
        /// </summary>
        R32SFloat = 100,

        /// <summary>
        ///     <c>R32G32UInt</c> specifies a two-component, 64-bit unsigned integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32UInt = 101,

        /// <summary>
        ///     <c>R32G32SInt</c> specifies a two-component, 64-bit signed integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32SInt = 102,

        /// <summary>
        ///     <c>R32G32SFloat</c> specifies a two-component, 64-bit signed floating-point format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
        /// </summary>
        R32G32SFloat = 103,

        /// <summary>
        ///     <c>R32G32B32UInt</c> specifies a three-component, 96-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
        /// </summary>
        R32G32B32UInt = 104,

        /// <summary>
        ///     <c>R32G32B32SInt</c> specifies a three-component, 96-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
        /// </summary>
        R32G32B32SInt = 105,

        /// <summary>
        ///     <c>R32G32B32SFloat</c> specifies a three-component, 96-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
        /// </summary>
        R32G32B32SFloat = 106,

        /// <summary>
        ///     <c>R32G32B32A32UInt</c> specifies a four-component, 128-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32G32B32A32UInt = 107,

        /// <summary>
        ///     <c>R32G32B32A32SInt</c> specifies a four-component, 128-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32G32B32A32SInt = 108,

        /// <summary>
        ///     <c>R32G32B32A32SFloat</c> specifies a four-component, 128-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
        /// </summary>
        R32G32B32A32SFloat = 109,

        /// <summary>
        ///     <c>R64UInt</c> specifies a one-component, 64-bit unsigned integer format that has a single 64-bit R component.
        /// </summary>
        R64UInt = 110,

        /// <summary>
        ///     <c>R64SInt</c> specifies a one-component, 64-bit signed integer format that has a single 64-bit R component.
        /// </summary>
        R64SInt = 111,

        /// <summary>
        ///     <c>R64SFloat</c> specifies a one-component, 64-bit signed floating-point format that has a single 64-bit R component.
        /// </summary>
        R64SFloat = 112,

        /// <summary>
        ///     <c>R64G64UInt</c> specifies a two-component, 128-bit unsigned integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64UInt = 113,

        /// <summary>
        ///     <c>R64G64SInt</c> specifies a two-component, 128-bit signed integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64SInt = 114,

        /// <summary>
        ///     <c>R64G64SFloat</c> specifies a two-component, 128-bit signed floating-point format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
        /// </summary>
        R64G64SFloat = 115,

        /// <summary>
        ///     <c>R64G64B64UInt</c> specifies a three-component, 192-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
        /// </summary>
        R64G64B64UInt = 116,

        /// <summary>
        ///     <c>R64G64B64SInt</c> specifies a three-component, 192-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
        /// </summary>
        R64G64B64SInt = 117,

        /// <summary>
        ///     <c>R64G64B64SFloat</c> specifies a three-component, 192-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
        /// </summary>
        R64G64B64SFloat = 118,

        /// <summary>
        ///     <c>R64G64B64A64UInt</c> specifies a four-component, 256-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64G64B64A64UInt = 119,

        /// <summary>
        ///     <c>R64G64B64A64SInt</c> specifies a four-component, 256-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64G64B64A64SInt = 120,

        /// <summary>
        ///     <c>R64G64B64A64SFloat</c> specifies a four-component, 256-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
        /// </summary>
        R64G64B64A64SFloat = 121,

        /// <summary>
        ///     <c>B10G11R11UfloatPack32</c> specifies a three-component, 32-bit packed unsigned floating-point format that has a 10-bit B component in bits 22..31, an 11-bit G component in bits 11..21, an 11-bit R component in bits 0..10. See <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fundamentals-fp10">here</see> and <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#fundamentals-fp11">here</see>.
        /// </summary>
        B10G11R11UfloatPack32 = 122,

        /// <summary>
        ///     <c>E5B9G9R9UfloatPack32</c> specifies a three-component, 32-bit packed unsigned floating-point format that has a 5-bit shared exponent in bits 27..31, a 9-bit B component mantissa in bits 18..26, a 9-bit G component mantissa in bits 9..17, and a 9-bit R component mantissa in bits 0..8.
        /// </summary>
        E5B9G9R9UfloatPack32 = 123,

        /// <summary>
        ///     <c>D16UNorm</c> specifies a one-component, 16-bit unsigned normalized format that has a single 16-bit depth component.
        /// </summary>
        D16UNorm = 124,

        /// <summary>
        ///     <c>X8D24UNormPack32</c> specifies a two-component, 32-bit format that has 24 unsigned normalized bits in the depth component and, optionally:, 8 bits that are unused.
        /// </summary>
        X8D24UNormPack32 = 125,

        /// <summary>
        ///     <c>D32SFloat</c> specifies a one-component, 32-bit signed floating-point format that has 32 bits in the depth component.
        /// </summary>
        D32SFloat = 126,

        /// <summary>
        ///     <c>S8UInt</c> specifies a one-component, 8-bit unsigned integer format that has 8 bits in the stencil component.
        /// </summary>
        S8UInt = 127,

        /// <summary>
        ///     <c>D16UNormS8UInt</c> specifies a two-component, 24-bit format that has 16 unsigned normalized bits in the depth component and 8 unsigned integer bits in the stencil component.
        /// </summary>
        D16UNormS8UInt = 128,

        /// <summary>
        ///     <c>D24UNormS8UInt</c> specifies a two-component, 32-bit packed format that has 8 unsigned integer bits in the stencil component, and 24 unsigned normalized bits in the depth component.
        /// </summary>
        D24UNormS8UInt = 129,

        /// <summary>
        ///     <c>D32SFloatS8UInt</c> specifies a two-component format that has 32 signed float bits in the depth component and 8 unsigned integer bits in the stencil component. There are optionally: 24 bits that are unused.
        /// </summary>
        D32SFloatS8UInt = 130,

        /// <summary>
        ///     <c>Bc1RGBUNormBlock</c> specifies a three-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque.
        /// </summary>
        Bc1RGBUNormBlock = 131,

        /// <summary>
        ///     <c>Bc1RGBSRGBBlock</c> specifies a three-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque.
        /// </summary>
        Bc1RGBSRGBBlock = 132,

        /// <summary>
        ///     <c>Bc1RGBAUNormBlock</c> specifies a four-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha.
        /// </summary>
        Bc1RGBAUNormBlock = 133,

        /// <summary>
        ///     <c>Bc1RGBASRGBBlock</c> specifies a four-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha.
        /// </summary>
        Bc1RGBASRGBBlock = 134,

        /// <summary>
        ///     <c>Bc2UNormBlock</c> specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
        /// </summary>
        Bc2UNormBlock = 135,

        /// <summary>
        ///     <c>Bc2SRGBBlock</c> specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding.
        /// </summary>
        Bc2SRGBBlock = 136,

        /// <summary>
        ///     <c>Bc3UNormBlock</c> specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
        /// </summary>
        Bc3UNormBlock = 137,

        /// <summary>
        ///     <c>Bc3SRGBBlock</c> specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding.
        /// </summary>
        Bc3SRGBBlock = 138,

        /// <summary>
        ///     <c>Bc4UNormBlock</c> specifies a one-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized red texel data.
        /// </summary>
        Bc4UNormBlock = 139,

        /// <summary>
        ///     <c>Bc4SNormBlock</c> specifies a one-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized red texel data.
        /// </summary>
        Bc4SNormBlock = 140,

        /// <summary>
        ///     <c>Bc5UNormBlock</c> specifies a two-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        Bc5UNormBlock = 141,

        /// <summary>
        ///     <c>Bc5SNormBlock</c> specifies a two-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        Bc5SNormBlock = 142,

        /// <summary>
        ///     <c>Bc6HUfloatBlock</c> specifies a three-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned floating-point RGB texel data.
        /// </summary>
        Bc6HUfloatBlock = 143,

        /// <summary>
        ///     <c>Bc6HSFloatBlock</c> specifies a three-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of signed floating-point RGB texel data.
        /// </summary>
        Bc6HSFloatBlock = 144,

        /// <summary>
        ///     <c>Bc7UNormBlock</c> specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Bc7UNormBlock = 145,

        /// <summary>
        ///     <c>Bc7SRGBBlock</c> specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Bc7SRGBBlock = 146,

        /// <summary>
        ///     <c>Etc2R8G8B8UNormBlock</c> specifies a three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque.
        /// </summary>
        Etc2R8G8B8UNormBlock = 147,

        /// <summary>
        ///     <c>Etc2R8G8B8SRGBBlock</c> specifies a three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque.
        /// </summary>
        Etc2R8G8B8SRGBBlock = 148,

        /// <summary>
        ///     <c>Etc2R8G8B8A1UNormBlock</c> specifies a four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha.
        /// </summary>
        Etc2R8G8B8A1UNormBlock = 149,

        /// <summary>
        ///     <c>Etc2R8G8B8A1SRGBBlock</c> specifies a four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha.
        /// </summary>
        Etc2R8G8B8A1SRGBBlock = 150,

        /// <summary>
        ///     <c>Etc2R8G8B8A8UNormBlock</c> specifies a four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
        /// </summary>
        Etc2R8G8B8A8UNormBlock = 151,

        /// <summary>
        ///     <c>Etc2R8G8B8A8SRGBBlock</c> specifies a four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding applied.
        /// </summary>
        Etc2R8G8B8A8SRGBBlock = 152,

        /// <summary>
        ///     <c>EacR11UNormBlock</c> specifies a one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized red texel data.
        /// </summary>
        EacR11UNormBlock = 153,

        /// <summary>
        ///     <c>EacR11SNormBlock</c> specifies a one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized red texel data.
        /// </summary>
        EacR11SNormBlock = 154,

        /// <summary>
        ///     <c>EacR11G11UNormBlock</c> specifies a two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        EacR11G11UNormBlock = 155,

        /// <summary>
        ///     <c>EacR11G11SNormBlock</c> specifies a two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
        /// </summary>
        EacR11G11SNormBlock = 156,

        /// <summary>
        ///     <c>Astc4X4UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc4X4UNormBlock = 157,

        /// <summary>
        ///     <c>Astc4X4SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc4X4SRGBBlock = 158,

        /// <summary>
        ///     <c>Astc5X4UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}4 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc5X4UNormBlock = 159,

        /// <summary>
        ///     <c>Astc5X4SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc5X4SRGBBlock = 160,

        /// <summary>
        ///     <c>Astc5X5UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc5X5UNormBlock = 161,

        /// <summary>
        ///     <c>Astc5X5SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc5X5SRGBBlock = 162,

        /// <summary>
        ///     <c>Astc6X5UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc6X5UNormBlock = 163,

        /// <summary>
        ///     <c>Astc6X5SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc6X5SRGBBlock = 164,

        /// <summary>
        ///     <c>Astc6X6UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}6 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc6X6UNormBlock = 165,

        /// <summary>
        ///     <c>Astc6X6SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc6X6SRGBBlock = 166,

        /// <summary>
        ///     <c>Astc8X5UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8X5UNormBlock = 167,

        /// <summary>
        ///     <c>Astc8X5SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8X5SRGBBlock = 168,

        /// <summary>
        ///     <c>Astc8X6UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}6 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8X6UNormBlock = 169,

        /// <summary>
        ///     <c>Astc8X6SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8X6SRGBBlock = 170,

        /// <summary>
        ///     <c>Astc8X8UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}8 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc8X8UNormBlock = 171,

        /// <summary>
        ///     <c>Astc8X8SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc8X8SRGBBlock = 172,

        /// <summary>
        ///     <c>Astc10X5UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}5 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10X5UNormBlock = 173,

        /// <summary>
        ///     <c>Astc10X5SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10X5SRGBBlock = 174,

        /// <summary>
        ///     <c>Astc10X6UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}6 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10X6UNormBlock = 175,

        /// <summary>
        ///     <c>Astc10X6SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10X6SRGBBlock = 176,

        /// <summary>
        ///     <c>Astc10X8UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}8 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10X8UNormBlock = 177,

        /// <summary>
        ///     <c>Astc10X8SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10X8SRGBBlock = 178,

        /// <summary>
        ///     <c>Astc10X10UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}10 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc10X10UNormBlock = 179,

        /// <summary>
        ///     <c>Astc10X10SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc10X10SRGBBlock = 180,

        /// <summary>
        ///     <c>Astc12X10UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}10 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc12X10UNormBlock = 181,

        /// <summary>
        ///     <c>Astc12X10SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc12X10SRGBBlock = 182,

        /// <summary>
        ///     <c>Astc12X12UNormBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}12 rectangle of unsigned normalized RGBA texel data.
        /// </summary>
        Astc12X12UNormBlock = 183,

        /// <summary>
        ///     <c>Astc12X12SRGBBlock</c> specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}12 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
        /// </summary>
        Astc12X12SRGBBlock = 184,

        /// <summary>
        ///     <c>G8B8G8R8422UNorm</c>
        /// </summary>
        G8B8G8R8422UNorm = 1000156000,

        /// <summary>
        ///     <c>B8G8R8G8422UNorm</c>
        /// </summary>
        B8G8R8G8422UNorm = 1000156001,

        /// <summary>
        ///     <c>G8B8R83Plane420UNorm</c>
        /// </summary>
        G8B8R83Plane420UNorm = 1000156002,

        /// <summary>
        ///     <c>G8B8R82Plane420UNorm</c>
        /// </summary>
        G8B8R82Plane420UNorm = 1000156003,

        /// <summary>
        ///     <c>G8B8R83Plane422UNorm</c>
        /// </summary>
        G8B8R83Plane422UNorm = 1000156004,

        /// <summary>
        ///     <c>G8B8R82Plane422UNorm</c>
        /// </summary>
        G8B8R82Plane422UNorm = 1000156005,

        /// <summary>
        ///     <c>G8B8R83Plane444UNorm</c>
        /// </summary>
        G8B8R83Plane444UNorm = 1000156006,

        /// <summary>
        ///     <c>R10X6UNormPack16</c>
        /// </summary>
        R10X6UNormPack16 = 1000156007,

        /// <summary>
        ///     <c>R10X6G10X6UNorm2Pack16</c>
        /// </summary>
        R10X6G10X6UNorm2Pack16 = 1000156008,

        /// <summary>
        ///     <c>R10X6G10X6B10X6A10X6UNorm4Pack16</c>
        /// </summary>
        R10X6G10X6B10X6A10X6UNorm4Pack16 = 1000156009,

        /// <summary>
        ///     <c>G10X6B10X6G10X6R10X6422UNorm4Pack16</c>
        /// </summary>
        G10X6B10X6G10X6R10X6422UNorm4Pack16 = 1000156010,

        /// <summary>
        ///     <c>B10X6G10X6R10X6G10X6422UNorm4Pack16</c>
        /// </summary>
        B10X6G10X6R10X6G10X6422UNorm4Pack16 = 1000156011,

        /// <summary>
        ///     <c>G10X6B10X6R10X63Plane420UNorm3Pack16</c>
        /// </summary>
        G10X6B10X6R10X63Plane420UNorm3Pack16 = 1000156012,

        /// <summary>
        ///     <c>G10X6B10X6R10X62Plane420UNorm3Pack16</c>
        /// </summary>
        G10X6B10X6R10X62Plane420UNorm3Pack16 = 1000156013,

        /// <summary>
        ///     <c>G10X6B10X6R10X63Plane422UNorm3Pack16</c>
        /// </summary>
        G10X6B10X6R10X63Plane422UNorm3Pack16 = 1000156014,

        /// <summary>
        ///     <c>G10X6B10X6R10X62Plane422UNorm3Pack16</c>
        /// </summary>
        G10X6B10X6R10X62Plane422UNorm3Pack16 = 1000156015,

        /// <summary>
        ///     <c>G10X6B10X6R10X63Plane444UNorm3Pack16</c>
        /// </summary>
        G10X6B10X6R10X63Plane444UNorm3Pack16 = 1000156016,

        /// <summary>
        ///     <c>R12X4UNormPack16</c>
        /// </summary>
        R12X4UNormPack16 = 1000156017,

        /// <summary>
        ///     <c>R12X4G12X4UNorm2Pack16</c>
        /// </summary>
        R12X4G12X4UNorm2Pack16 = 1000156018,

        /// <summary>
        ///     <c>R12X4G12X4B12X4A12X4UNorm4Pack16</c>
        /// </summary>
        R12X4G12X4B12X4A12X4UNorm4Pack16 = 1000156019,

        /// <summary>
        ///     <c>G12X4B12X4G12X4R12X4422UNorm4Pack16</c>
        /// </summary>
        G12X4B12X4G12X4R12X4422UNorm4Pack16 = 1000156020,

        /// <summary>
        ///     <c>B12X4G12X4R12X4G12X4422UNorm4Pack16</c>
        /// </summary>
        B12X4G12X4R12X4G12X4422UNorm4Pack16 = 1000156021,

        /// <summary>
        ///     <c>G12X4B12X4R12X43Plane420UNorm3Pack16</c>
        /// </summary>
        G12X4B12X4R12X43Plane420UNorm3Pack16 = 1000156022,

        /// <summary>
        ///     <c>G12X4B12X4R12X42Plane420UNorm3Pack16</c>
        /// </summary>
        G12X4B12X4R12X42Plane420UNorm3Pack16 = 1000156023,

        /// <summary>
        ///     <c>G12X4B12X4R12X43Plane422UNorm3Pack16</c>
        /// </summary>
        G12X4B12X4R12X43Plane422UNorm3Pack16 = 1000156024,

        /// <summary>
        ///     <c>G12X4B12X4R12X42Plane422UNorm3Pack16</c>
        /// </summary>
        G12X4B12X4R12X42Plane422UNorm3Pack16 = 1000156025,

        /// <summary>
        ///     <c>G12X4B12X4R12X43Plane444UNorm3Pack16</c>
        /// </summary>
        G12X4B12X4R12X43Plane444UNorm3Pack16 = 1000156026,

        /// <summary>
        ///     <c>G16B16G16R16422UNorm</c>
        /// </summary>
        G16B16G16R16422UNorm = 1000156027,

        /// <summary>
        ///     <c>B16G16R16G16422UNorm</c>
        /// </summary>
        B16G16R16G16422UNorm = 1000156028,

        /// <summary>
        ///     <c>G16B16R163Plane420UNorm</c>
        /// </summary>
        G16B16R163Plane420UNorm = 1000156029,

        /// <summary>
        ///     <c>G16B16R162Plane420UNorm</c>
        /// </summary>
        G16B16R162Plane420UNorm = 1000156030,

        /// <summary>
        ///     <c>G16B16R163Plane422UNorm</c>
        /// </summary>
        G16B16R163Plane422UNorm = 1000156031,

        /// <summary>
        ///     <c>G16B16R162Plane422UNorm</c>
        /// </summary>
        G16B16R162Plane422UNorm = 1000156032,

        /// <summary>
        ///     <c>G16B16R163Plane444UNorm</c>
        /// </summary>
        G16B16R163Plane444UNorm = 1000156033,

        /// <summary>
        ///     <c>G8B8R82Plane444UNorm</c>
        /// </summary>
        G8B8R82Plane444UNorm = 1000330000,

        /// <summary>
        ///     <c>G10X6B10X6R10X62Plane444UNorm3Pack16</c>
        /// </summary>
        G10X6B10X6R10X62Plane444UNorm3Pack16 = 1000330001,

        /// <summary>
        ///     <c>G12X4B12X4R12X42Plane444UNorm3Pack16</c>
        /// </summary>
        G12X4B12X4R12X42Plane444UNorm3Pack16 = 1000330002,

        /// <summary>
        ///     <c>G16B16R162Plane444UNorm</c>
        /// </summary>
        G16B16R162Plane444UNorm = 1000330003,

        /// <summary>
        ///     <c>A4R4G4B4UNormPack16</c>
        /// </summary>
        A4R4G4B4UNormPack16 = 1000340000,

        /// <summary>
        ///     <c>A4B4G4R4UNormPack16</c>
        /// </summary>
        A4B4G4R4UNormPack16 = 1000340001,

        /// <summary>
        ///     <c>Astc4X4SFloatBlock</c>
        /// </summary>
        Astc4X4SFloatBlock = 1000066000,

        /// <summary>
        ///     <c>Astc5X4SFloatBlock</c>
        /// </summary>
        Astc5X4SFloatBlock = 1000066001,

        /// <summary>
        ///     <c>Astc5X5SFloatBlock</c>
        /// </summary>
        Astc5X5SFloatBlock = 1000066002,

        /// <summary>
        ///     <c>Astc6X5SFloatBlock</c>
        /// </summary>
        Astc6X5SFloatBlock = 1000066003,

        /// <summary>
        ///     <c>Astc6X6SFloatBlock</c>
        /// </summary>
        Astc6X6SFloatBlock = 1000066004,

        /// <summary>
        ///     <c>Astc8X5SFloatBlock</c>
        /// </summary>
        Astc8X5SFloatBlock = 1000066005,

        /// <summary>
        ///     <c>Astc8X6SFloatBlock</c>
        /// </summary>
        Astc8X6SFloatBlock = 1000066006,

        /// <summary>
        ///     <c>Astc8X8SFloatBlock</c>
        /// </summary>
        Astc8X8SFloatBlock = 1000066007,

        /// <summary>
        ///     <c>Astc10X5SFloatBlock</c>
        /// </summary>
        Astc10X5SFloatBlock = 1000066008,

        /// <summary>
        ///     <c>Astc10X6SFloatBlock</c>
        /// </summary>
        Astc10X6SFloatBlock = 1000066009,

        /// <summary>
        ///     <c>Astc10X8SFloatBlock</c>
        /// </summary>
        Astc10X8SFloatBlock = 1000066010,

        /// <summary>
        ///     <c>Astc10X10SFloatBlock</c>
        /// </summary>
        Astc10X10SFloatBlock = 1000066011,

        /// <summary>
        ///     <c>Astc12X10SFloatBlock</c>
        /// </summary>
        Astc12X10SFloatBlock = 1000066012,

        /// <summary>
        ///     <c>Astc12X12SFloatBlock</c>
        /// </summary>
        Astc12X12SFloatBlock = 1000066013,

        /// <summary>
        ///     <c>A1B5G5R5UNormPack16</c>
        /// </summary>
        A1B5G5R5UNormPack16 = 1000470000,

        /// <summary>
        ///     <c>A8UNorm</c>
        /// </summary>
        A8UNorm = 1000470001,

        /// <summary>
        ///     <c>Pvrtc12BppUNormBlockIMG</c>
        /// </summary>
        Pvrtc12BppUNormBlockIMG = 1000054000,

        /// <summary>
        ///     <c>Pvrtc14BppUNormBlockIMG</c>
        /// </summary>
        Pvrtc14BppUNormBlockIMG = 1000054001,

        /// <summary>
        ///     <c>Pvrtc22BppUNormBlockIMG</c>
        /// </summary>
        Pvrtc22BppUNormBlockIMG = 1000054002,

        /// <summary>
        ///     <c>Pvrtc24BppUNormBlockIMG</c>
        /// </summary>
        Pvrtc24BppUNormBlockIMG = 1000054003,

        /// <summary>
        ///     <c>Pvrtc12BppSRGBBlockIMG</c>
        /// </summary>
        Pvrtc12BppSRGBBlockIMG = 1000054004,

        /// <summary>
        ///     <c>Pvrtc14BppSRGBBlockIMG</c>
        /// </summary>
        Pvrtc14BppSRGBBlockIMG = 1000054005,

        /// <summary>
        ///     <c>Pvrtc22BppSRGBBlockIMG</c>
        /// </summary>
        Pvrtc22BppSRGBBlockIMG = 1000054006,

        /// <summary>
        ///     <c>Pvrtc24BppSRGBBlockIMG</c>
        /// </summary>
        Pvrtc24BppSRGBBlockIMG = 1000054007,

        /// <summary>
        ///     <c>Astc3X3X3UNormBlockEXT</c>
        /// </summary>
        Astc3X3X3UNormBlockEXT = 1000288000,

        /// <summary>
        ///     <c>Astc3X3X3SRGBBlockEXT</c>
        /// </summary>
        Astc3X3X3SRGBBlockEXT = 1000288001,

        /// <summary>
        ///     <c>Astc3X3X3SFloatBlockEXT</c>
        /// </summary>
        Astc3X3X3SFloatBlockEXT = 1000288002,

        /// <summary>
        ///     <c>Astc4X3X3UNormBlockEXT</c>
        /// </summary>
        Astc4X3X3UNormBlockEXT = 1000288003,

        /// <summary>
        ///     <c>Astc4X3X3SRGBBlockEXT</c>
        /// </summary>
        Astc4X3X3SRGBBlockEXT = 1000288004,

        /// <summary>
        ///     <c>Astc4X3X3SFloatBlockEXT</c>
        /// </summary>
        Astc4X3X3SFloatBlockEXT = 1000288005,

        /// <summary>
        ///     <c>Astc4X4X3UNormBlockEXT</c>
        /// </summary>
        Astc4X4X3UNormBlockEXT = 1000288006,

        /// <summary>
        ///     <c>Astc4X4X3SRGBBlockEXT</c>
        /// </summary>
        Astc4X4X3SRGBBlockEXT = 1000288007,

        /// <summary>
        ///     <c>Astc4X4X3SFloatBlockEXT</c>
        /// </summary>
        Astc4X4X3SFloatBlockEXT = 1000288008,

        /// <summary>
        ///     <c>Astc4X4X4UNormBlockEXT</c>
        /// </summary>
        Astc4X4X4UNormBlockEXT = 1000288009,

        /// <summary>
        ///     <c>Astc4X4X4SRGBBlockEXT</c>
        /// </summary>
        Astc4X4X4SRGBBlockEXT = 1000288010,

        /// <summary>
        ///     <c>Astc4X4X4SFloatBlockEXT</c>
        /// </summary>
        Astc4X4X4SFloatBlockEXT = 1000288011,

        /// <summary>
        ///     <c>Astc5X4X4UNormBlockEXT</c>
        /// </summary>
        Astc5X4X4UNormBlockEXT = 1000288012,

        /// <summary>
        ///     <c>Astc5X4X4SRGBBlockEXT</c>
        /// </summary>
        Astc5X4X4SRGBBlockEXT = 1000288013,

        /// <summary>
        ///     <c>Astc5X4X4SFloatBlockEXT</c>
        /// </summary>
        Astc5X4X4SFloatBlockEXT = 1000288014,

        /// <summary>
        ///     <c>Astc5X5X4UNormBlockEXT</c>
        /// </summary>
        Astc5X5X4UNormBlockEXT = 1000288015,

        /// <summary>
        ///     <c>Astc5X5X4SRGBBlockEXT</c>
        /// </summary>
        Astc5X5X4SRGBBlockEXT = 1000288016,

        /// <summary>
        ///     <c>Astc5X5X4SFloatBlockEXT</c>
        /// </summary>
        Astc5X5X4SFloatBlockEXT = 1000288017,

        /// <summary>
        ///     <c>Astc5X5X5UNormBlockEXT</c>
        /// </summary>
        Astc5X5X5UNormBlockEXT = 1000288018,

        /// <summary>
        ///     <c>Astc5X5X5SRGBBlockEXT</c>
        /// </summary>
        Astc5X5X5SRGBBlockEXT = 1000288019,

        /// <summary>
        ///     <c>Astc5X5X5SFloatBlockEXT</c>
        /// </summary>
        Astc5X5X5SFloatBlockEXT = 1000288020,

        /// <summary>
        ///     <c>Astc6X5X5UNormBlockEXT</c>
        /// </summary>
        Astc6X5X5UNormBlockEXT = 1000288021,

        /// <summary>
        ///     <c>Astc6X5X5SRGBBlockEXT</c>
        /// </summary>
        Astc6X5X5SRGBBlockEXT = 1000288022,

        /// <summary>
        ///     <c>Astc6X5X5SFloatBlockEXT</c>
        /// </summary>
        Astc6X5X5SFloatBlockEXT = 1000288023,

        /// <summary>
        ///     <c>Astc6X6X5UNormBlockEXT</c>
        /// </summary>
        Astc6X6X5UNormBlockEXT = 1000288024,

        /// <summary>
        ///     <c>Astc6X6X5SRGBBlockEXT</c>
        /// </summary>
        Astc6X6X5SRGBBlockEXT = 1000288025,

        /// <summary>
        ///     <c>Astc6X6X5SFloatBlockEXT</c>
        /// </summary>
        Astc6X6X5SFloatBlockEXT = 1000288026,

        /// <summary>
        ///     <c>Astc6X6X6UNormBlockEXT</c>
        /// </summary>
        Astc6X6X6UNormBlockEXT = 1000288027,

        /// <summary>
        ///     <c>Astc6X6X6SRGBBlockEXT</c>
        /// </summary>
        Astc6X6X6SRGBBlockEXT = 1000288028,

        /// <summary>
        ///     <c>Astc6X6X6SFloatBlockEXT</c>
        /// </summary>
        Astc6X6X6SFloatBlockEXT = 1000288029,

        /// <summary>
        ///     <c>R8BoolARM</c>
        /// </summary>
        R8BoolARM = 1000460000,

        /// <summary>
        ///     <c>R16SFloatFpencodingBfloat16ARM</c>
        /// </summary>
        R16SFloatFpencodingBfloat16ARM = 1000460001,

        /// <summary>
        ///     <c>R8SFloatFpencodingFloat8E4M3ARM</c>
        /// </summary>
        R8SFloatFpencodingFloat8E4M3ARM = 1000460002,

        /// <summary>
        ///     <c>R8SFloatFpencodingFloat8E5M2ARM</c>
        /// </summary>
        R8SFloatFpencodingFloat8E5M2ARM = 1000460003,

        /// <summary>
        ///     <c>R16G16Sfixed5NV</c>
        /// </summary>
        R16G16Sfixed5NV = 1000464000,

        /// <summary>
        ///     <c>R10X6UIntPack16ARM</c>
        /// </summary>
        R10X6UIntPack16ARM = 1000609000,

        /// <summary>
        ///     <c>R10X6G10X6UInt2Pack16ARM</c>
        /// </summary>
        R10X6G10X6UInt2Pack16ARM = 1000609001,

        /// <summary>
        ///     <c>R10X6G10X6B10X6A10X6UInt4Pack16ARM</c>
        /// </summary>
        R10X6G10X6B10X6A10X6UInt4Pack16ARM = 1000609002,

        /// <summary>
        ///     <c>R12X4UIntPack16ARM</c>
        /// </summary>
        R12X4UIntPack16ARM = 1000609003,

        /// <summary>
        ///     <c>R12X4G12X4UInt2Pack16ARM</c>
        /// </summary>
        R12X4G12X4UInt2Pack16ARM = 1000609004,

        /// <summary>
        ///     <c>R12X4G12X4B12X4A12X4UInt4Pack16ARM</c>
        /// </summary>
        R12X4G12X4B12X4A12X4UInt4Pack16ARM = 1000609005,

        /// <summary>
        ///     <c>R14X2UIntPack16ARM</c>
        /// </summary>
        R14X2UIntPack16ARM = 1000609006,

        /// <summary>
        ///     <c>R14X2G14X2UInt2Pack16ARM</c>
        /// </summary>
        R14X2G14X2UInt2Pack16ARM = 1000609007,

        /// <summary>
        ///     <c>R14X2G14X2B14X2A14X2UInt4Pack16ARM</c>
        /// </summary>
        R14X2G14X2B14X2A14X2UInt4Pack16ARM = 1000609008,

        /// <summary>
        ///     <c>R14X2UNormPack16ARM</c>
        /// </summary>
        R14X2UNormPack16ARM = 1000609009,

        /// <summary>
        ///     <c>R14X2G14X2UNorm2Pack16ARM</c>
        /// </summary>
        R14X2G14X2UNorm2Pack16ARM = 1000609010,

        /// <summary>
        ///     <c>R14X2G14X2B14X2A14X2UNorm4Pack16ARM</c>
        /// </summary>
        R14X2G14X2B14X2A14X2UNorm4Pack16ARM = 1000609011,

        /// <summary>
        ///     <c>G14X2B14X2R14X22Plane420UNorm3Pack16ARM</c>
        /// </summary>
        G14X2B14X2R14X22Plane420UNorm3Pack16ARM = 1000609012,

        /// <summary>
        ///     <c>G14X2B14X2R14X22Plane422UNorm3Pack16ARM</c>
        /// </summary>
        G14X2B14X2R14X22Plane422UNorm3Pack16ARM = 1000609013,

        /// <summary>
        ///     <c>Astc4X4SFloatBlockEXT</c>
        /// </summary>
        Astc4X4SFloatBlockEXT = Astc4X4SFloatBlock,

        /// <summary>
        ///     <c>Astc5X4SFloatBlockEXT</c>
        /// </summary>
        Astc5X4SFloatBlockEXT = Astc5X4SFloatBlock,

        /// <summary>
        ///     <c>Astc5X5SFloatBlockEXT</c>
        /// </summary>
        Astc5X5SFloatBlockEXT = Astc5X5SFloatBlock,

        /// <summary>
        ///     <c>Astc6X5SFloatBlockEXT</c>
        /// </summary>
        Astc6X5SFloatBlockEXT = Astc6X5SFloatBlock,

        /// <summary>
        ///     <c>Astc6X6SFloatBlockEXT</c>
        /// </summary>
        Astc6X6SFloatBlockEXT = Astc6X6SFloatBlock,

        /// <summary>
        ///     <c>Astc8X5SFloatBlockEXT</c>
        /// </summary>
        Astc8X5SFloatBlockEXT = Astc8X5SFloatBlock,

        /// <summary>
        ///     <c>Astc8X6SFloatBlockEXT</c>
        /// </summary>
        Astc8X6SFloatBlockEXT = Astc8X6SFloatBlock,

        /// <summary>
        ///     <c>Astc8X8SFloatBlockEXT</c>
        /// </summary>
        Astc8X8SFloatBlockEXT = Astc8X8SFloatBlock,

        /// <summary>
        ///     <c>Astc10X5SFloatBlockEXT</c>
        /// </summary>
        Astc10X5SFloatBlockEXT = Astc10X5SFloatBlock,

        /// <summary>
        ///     <c>Astc10X6SFloatBlockEXT</c>
        /// </summary>
        Astc10X6SFloatBlockEXT = Astc10X6SFloatBlock,

        /// <summary>
        ///     <c>Astc10X8SFloatBlockEXT</c>
        /// </summary>
        Astc10X8SFloatBlockEXT = Astc10X8SFloatBlock,

        /// <summary>
        ///     <c>Astc10X10SFloatBlockEXT</c>
        /// </summary>
        Astc10X10SFloatBlockEXT = Astc10X10SFloatBlock,

        /// <summary>
        ///     <c>Astc12X10SFloatBlockEXT</c>
        /// </summary>
        Astc12X10SFloatBlockEXT = Astc12X10SFloatBlock,

        /// <summary>
        ///     <c>Astc12X12SFloatBlockEXT</c>
        /// </summary>
        Astc12X12SFloatBlockEXT = Astc12X12SFloatBlock,

        /// <summary>
        ///     <c>G8B8G8R8422UNormKHR</c>
        /// </summary>
        G8B8G8R8422UNormKHR = G8B8G8R8422UNorm,

        /// <summary>
        ///     <c>B8G8R8G8422UNormKHR</c>
        /// </summary>
        B8G8R8G8422UNormKHR = B8G8R8G8422UNorm,

        /// <summary>
        ///     <c>G8B8R83Plane420UNormKHR</c>
        /// </summary>
        G8B8R83Plane420UNormKHR = G8B8R83Plane420UNorm,

        /// <summary>
        ///     <c>G8B8R82Plane420UNormKHR</c>
        /// </summary>
        G8B8R82Plane420UNormKHR = G8B8R82Plane420UNorm,

        /// <summary>
        ///     <c>G8B8R83Plane422UNormKHR</c>
        /// </summary>
        G8B8R83Plane422UNormKHR = G8B8R83Plane422UNorm,

        /// <summary>
        ///     <c>G8B8R82Plane422UNormKHR</c>
        /// </summary>
        G8B8R82Plane422UNormKHR = G8B8R82Plane422UNorm,

        /// <summary>
        ///     <c>G8B8R83Plane444UNormKHR</c>
        /// </summary>
        G8B8R83Plane444UNormKHR = G8B8R83Plane444UNorm,

        /// <summary>
        ///     <c>R10X6UNormPack16KHR</c>
        /// </summary>
        R10X6UNormPack16KHR = R10X6UNormPack16,

        /// <summary>
        ///     <c>R10X6G10X6UNorm2Pack16KHR</c>
        /// </summary>
        R10X6G10X6UNorm2Pack16KHR = R10X6G10X6UNorm2Pack16,

        /// <summary>
        ///     <c>R10X6G10X6B10X6A10X6UNorm4Pack16KHR</c>
        /// </summary>
        R10X6G10X6B10X6A10X6UNorm4Pack16KHR = R10X6G10X6B10X6A10X6UNorm4Pack16,

        /// <summary>
        ///     <c>G10X6B10X6G10X6R10X6422UNorm4Pack16KHR</c>
        /// </summary>
        G10X6B10X6G10X6R10X6422UNorm4Pack16KHR = G10X6B10X6G10X6R10X6422UNorm4Pack16,

        /// <summary>
        ///     <c>B10X6G10X6R10X6G10X6422UNorm4Pack16KHR</c>
        /// </summary>
        B10X6G10X6R10X6G10X6422UNorm4Pack16KHR = B10X6G10X6R10X6G10X6422UNorm4Pack16,

        /// <summary>
        ///     <c>G10X6B10X6R10X63Plane420UNorm3Pack16KHR</c>
        /// </summary>
        G10X6B10X6R10X63Plane420UNorm3Pack16KHR = G10X6B10X6R10X63Plane420UNorm3Pack16,

        /// <summary>
        ///     <c>G10X6B10X6R10X62Plane420UNorm3Pack16KHR</c>
        /// </summary>
        G10X6B10X6R10X62Plane420UNorm3Pack16KHR = G10X6B10X6R10X62Plane420UNorm3Pack16,

        /// <summary>
        ///     <c>G10X6B10X6R10X63Plane422UNorm3Pack16KHR</c>
        /// </summary>
        G10X6B10X6R10X63Plane422UNorm3Pack16KHR = G10X6B10X6R10X63Plane422UNorm3Pack16,

        /// <summary>
        ///     <c>G10X6B10X6R10X62Plane422UNorm3Pack16KHR</c>
        /// </summary>
        G10X6B10X6R10X62Plane422UNorm3Pack16KHR = G10X6B10X6R10X62Plane422UNorm3Pack16,

        /// <summary>
        ///     <c>G10X6B10X6R10X63Plane444UNorm3Pack16KHR</c>
        /// </summary>
        G10X6B10X6R10X63Plane444UNorm3Pack16KHR = G10X6B10X6R10X63Plane444UNorm3Pack16,

        /// <summary>
        ///     <c>R12X4UNormPack16KHR</c>
        /// </summary>
        R12X4UNormPack16KHR = R12X4UNormPack16,

        /// <summary>
        ///     <c>R12X4G12X4UNorm2Pack16KHR</c>
        /// </summary>
        R12X4G12X4UNorm2Pack16KHR = R12X4G12X4UNorm2Pack16,

        /// <summary>
        ///     <c>R12X4G12X4B12X4A12X4UNorm4Pack16KHR</c>
        /// </summary>
        R12X4G12X4B12X4A12X4UNorm4Pack16KHR = R12X4G12X4B12X4A12X4UNorm4Pack16,

        /// <summary>
        ///     <c>G12X4B12X4G12X4R12X4422UNorm4Pack16KHR</c>
        /// </summary>
        G12X4B12X4G12X4R12X4422UNorm4Pack16KHR = G12X4B12X4G12X4R12X4422UNorm4Pack16,

        /// <summary>
        ///     <c>B12X4G12X4R12X4G12X4422UNorm4Pack16KHR</c>
        /// </summary>
        B12X4G12X4R12X4G12X4422UNorm4Pack16KHR = B12X4G12X4R12X4G12X4422UNorm4Pack16,

        /// <summary>
        ///     <c>G12X4B12X4R12X43Plane420UNorm3Pack16KHR</c>
        /// </summary>
        G12X4B12X4R12X43Plane420UNorm3Pack16KHR = G12X4B12X4R12X43Plane420UNorm3Pack16,

        /// <summary>
        ///     <c>G12X4B12X4R12X42Plane420UNorm3Pack16KHR</c>
        /// </summary>
        G12X4B12X4R12X42Plane420UNorm3Pack16KHR = G12X4B12X4R12X42Plane420UNorm3Pack16,

        /// <summary>
        ///     <c>G12X4B12X4R12X43Plane422UNorm3Pack16KHR</c>
        /// </summary>
        G12X4B12X4R12X43Plane422UNorm3Pack16KHR = G12X4B12X4R12X43Plane422UNorm3Pack16,

        /// <summary>
        ///     <c>G12X4B12X4R12X42Plane422UNorm3Pack16KHR</c>
        /// </summary>
        G12X4B12X4R12X42Plane422UNorm3Pack16KHR = G12X4B12X4R12X42Plane422UNorm3Pack16,

        /// <summary>
        ///     <c>G12X4B12X4R12X43Plane444UNorm3Pack16KHR</c>
        /// </summary>
        G12X4B12X4R12X43Plane444UNorm3Pack16KHR = G12X4B12X4R12X43Plane444UNorm3Pack16,

        /// <summary>
        ///     <c>G16B16G16R16422UNormKHR</c>
        /// </summary>
        G16B16G16R16422UNormKHR = G16B16G16R16422UNorm,

        /// <summary>
        ///     <c>B16G16R16G16422UNormKHR</c>
        /// </summary>
        B16G16R16G16422UNormKHR = B16G16R16G16422UNorm,

        /// <summary>
        ///     <c>G16B16R163Plane420UNormKHR</c>
        /// </summary>
        G16B16R163Plane420UNormKHR = G16B16R163Plane420UNorm,

        /// <summary>
        ///     <c>G16B16R162Plane420UNormKHR</c>
        /// </summary>
        G16B16R162Plane420UNormKHR = G16B16R162Plane420UNorm,

        /// <summary>
        ///     <c>G16B16R163Plane422UNormKHR</c>
        /// </summary>
        G16B16R163Plane422UNormKHR = G16B16R163Plane422UNorm,

        /// <summary>
        ///     <c>G16B16R162Plane422UNormKHR</c>
        /// </summary>
        G16B16R162Plane422UNormKHR = G16B16R162Plane422UNorm,

        /// <summary>
        ///     <c>G16B16R163Plane444UNormKHR</c>
        /// </summary>
        G16B16R163Plane444UNormKHR = G16B16R163Plane444UNorm,

        /// <summary>
        ///     <c>G8B8R82Plane444UNormEXT</c>
        /// </summary>
        G8B8R82Plane444UNormEXT = G8B8R82Plane444UNorm,

        /// <summary>
        ///     <c>G10X6B10X6R10X62Plane444UNorm3Pack16EXT</c>
        /// </summary>
        G10X6B10X6R10X62Plane444UNorm3Pack16EXT = G10X6B10X6R10X62Plane444UNorm3Pack16,

        /// <summary>
        ///     <c>G12X4B12X4R12X42Plane444UNorm3Pack16EXT</c>
        /// </summary>
        G12X4B12X4R12X42Plane444UNorm3Pack16EXT = G12X4B12X4R12X42Plane444UNorm3Pack16,

        /// <summary>
        ///     <c>G16B16R162Plane444UNormEXT</c>
        /// </summary>
        G16B16R162Plane444UNormEXT = G16B16R162Plane444UNorm,

        /// <summary>
        ///     <c>A4R4G4B4UNormPack16EXT</c>
        /// </summary>
        A4R4G4B4UNormPack16EXT = A4R4G4B4UNormPack16,

        /// <summary>
        ///     <c>A4B4G4R4UNormPack16EXT</c>
        /// </summary>
        A4B4G4R4UNormPack16EXT = A4B4G4R4UNormPack16,

        /// <summary>
        ///     <c>R16G16S105NV</c>
        /// </summary>
        R16G16S105NV = R16G16Sfixed5NV,

        /// <summary>
        ///     <c>A1B5G5R5UNormPack16KHR</c>
        /// </summary>
        A1B5G5R5UNormPack16KHR = A1B5G5R5UNormPack16,

        /// <summary>
        ///     <c>A8UNormKHR</c>
        /// </summary>
        A8UNormKHR = A8UNorm,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
