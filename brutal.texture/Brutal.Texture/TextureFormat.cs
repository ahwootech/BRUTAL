namespace Brutal.TextureApi;

/// <summary>
///     Describes the format of a texture's image data. You can convert a TextureFormat into
///     a Vulkan format with textureFormat.ToVkFormat()
/// </summary>
/// <remarks>
///     This is ported from Vulkan's VkFormat enum, and values should match 1:1
/// </remarks>
public enum TextureFormat
{
    /// <summary>
    ///     Specifies that the format is not specified.
    /// </summary>
    Undefined = 0,

    /// <summary>
    ///     Specifies a two-component, 8-bit packed unsigned normalized format that has a 4-bit R component in bits 4..7, and a 4-bit G component in bits 0..3.
    /// </summary>
    R4G4_UNorm_Pack8 = 1,

    /// <summary>
    ///     Specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit R component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit B component in bits 4..7, and a 4-bit A component in bits 0..3.
    /// </summary>
    R4G4B4A4_UNorm_Pack16 = 2,

    /// <summary>
    ///     Specifies a four-component, 16-bit packed unsigned normalized format that has a 4-bit B component in bits 12..15, a 4-bit G component in bits 8..11, a 4-bit R component in bits 4..7, and a 4-bit A component in bits 0..3.
    /// </summary>
    B4G4R4A4_UNorm_Pack16 = 3,

    /// <summary>
    ///     Specifies a three-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit B component in bits 0..4.
    /// </summary>
    R5G6B5_UNorm_Pack16 = 4,

    /// <summary>
    ///     Specifies a three-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 6-bit G component in bits 5..10, and a 5-bit R component in bits 0..4.
    /// </summary>
    B5G6R5_UNorm_Pack16 = 5,

    /// <summary>
    ///     Specifies a four-component, 16-bit packed unsigned normalized format that has a 5-bit R component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit B component in bits 1..5, and a 1-bit A component in bit 0.
    /// </summary>
    R5G5B5A1_UNorm_Pack16 = 6,

    /// <summary>
    ///     Specifies a four-component, 16-bit packed unsigned normalized format that has a 5-bit B component in bits 11..15, a 5-bit G component in bits 6..10, a 5-bit R component in bits 1..5, and a 1-bit A component in bit 0.
    /// </summary>
    B5G5R5A1_UNorm_Pack16 = 7,

    /// <summary>
    ///     Specifies a four-component, 16-bit packed unsigned normalized format that has a 1-bit A component in bit 15, a 5-bit R component in bits 10..14, a 5-bit G component in bits 5..9, and a 5-bit B component in bits 0..4.
    /// </summary>
    A1R5G5B5_UNorm_Pack16 = 8,

    /// <summary>
    ///     Specifies a one-component, 8-bit unsigned normalized format that has a single 8-bit R component.
    /// </summary>
    R8_UNorm = 9,

    /// <summary>
    ///     Specifies a one-component, 8-bit signed normalized format that has a single 8-bit R component.
    /// </summary>
    R8_SNorm = 10,

    /// <summary>
    ///     Specifies a one-component, 8-bit unsigned scaled integer format that has a single 8-bit R component.
    /// </summary>
    R8_UScaled = 11,

    /// <summary>
    ///     Specifies a one-component, 8-bit signed scaled integer format that has a single 8-bit R component.
    /// </summary>
    R8_SScaled = 12,

    /// <summary>
    ///     Specifies a one-component, 8-bit unsigned integer format that has a single 8-bit R component.
    /// </summary>
    R8_UInt = 13,

    /// <summary>
    ///     Specifies a one-component, 8-bit signed integer format that has a single 8-bit R component.
    /// </summary>
    R8_SInt = 14,

    /// <summary>
    ///     Specifies a one-component, 8-bit unsigned normalized format that has a single 8-bit R component stored with sRGB nonlinear encoding.
    /// </summary>
    R8_SRGB = 15,

    /// <summary>
    ///     Specifies a two-component, 16-bit unsigned normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </summary>
    R8G8_UNorm = 16,

    /// <summary>
    ///     Specifies a two-component, 16-bit signed normalized format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </summary>
    R8G8_SNorm = 17,

    /// <summary>
    ///     Specifies a two-component, 16-bit unsigned scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </summary>
    R8G8_UScaled = 18,

    /// <summary>
    ///     Specifies a two-component, 16-bit signed scaled integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </summary>
    R8G8_SScaled = 19,

    /// <summary>
    ///     Specifies a two-component, 16-bit unsigned integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </summary>
    R8G8_UInt = 20,

    /// <summary>
    ///     Specifies a two-component, 16-bit signed integer format that has an 8-bit R component in byte 0, and an 8-bit G component in byte 1.
    /// </summary>
    R8G8_SInt = 21,

    /// <summary>
    ///     Specifies a two-component, 16-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, and an 8-bit G component stored with sRGB nonlinear encoding in byte 1.
    /// </summary>
    R8G8_SRGB = 22,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </summary>
    R8G8B8_UNorm = 23,

    /// <summary>
    ///     Specifies a three-component, 24-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </summary>
    R8G8B8_SNorm = 24,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </summary>
    R8G8B8_UScaled = 25,

    /// <summary>
    ///     Specifies a three-component, 24-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </summary>
    R8G8B8_SScaled = 26,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </summary>
    R8G8B8_UInt = 27,

    /// <summary>
    ///     Specifies a three-component, 24-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, and an 8-bit B component in byte 2.
    /// </summary>
    R8G8B8_SInt = 28,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit B component stored with sRGB nonlinear encoding in byte 2.
    /// </summary>
    R8G8B8_SRGB = 29,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </summary>
    B8G8R8_UNorm = 30,

    /// <summary>
    ///     Specifies a three-component, 24-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </summary>
    B8G8R8_SNorm = 31,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </summary>
    B8G8R8_UScaled = 32,

    /// <summary>
    ///     Specifies a three-component, 24-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </summary>
    B8G8R8_SScaled = 33,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </summary>
    B8G8R8_UInt = 34,

    /// <summary>
    ///     Specifies a three-component, 24-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, and an 8-bit R component in byte 2.
    /// </summary>
    B8G8R8_SInt = 35,

    /// <summary>
    ///     Specifies a three-component, 24-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, and an 8-bit R component stored with sRGB nonlinear encoding in byte 2.
    /// </summary>
    B8G8R8_SRGB = 36,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_UNorm = 37,

    /// <summary>
    ///     Specifies a four-component, 32-bit signed normalized format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_SNorm = 38,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_UScaled = 39,

    /// <summary>
    ///     Specifies a four-component, 32-bit signed scaled format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_SScaled = 40,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_UInt = 41,

    /// <summary>
    ///     Specifies a four-component, 32-bit signed integer format that has an 8-bit R component in byte 0, an 8-bit G component in byte 1, an 8-bit B component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_SInt = 42,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned normalized format that has an 8-bit R component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit B component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    R8G8B8A8_SRGB = 43,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_UNorm = 44,

    /// <summary>
    ///     Specifies a four-component, 32-bit signed normalized format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_SNorm = 45,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_UScaled = 46,

    /// <summary>
    ///     Specifies a four-component, 32-bit signed scaled format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_SScaled = 47,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_UInt = 48,

    /// <summary>
    ///     Specifies a four-component, 32-bit signed integer format that has an 8-bit B component in byte 0, an 8-bit G component in byte 1, an 8-bit R component in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_SInt = 49,

    /// <summary>
    ///     Specifies a four-component, 32-bit unsigned normalized format that has an 8-bit B component stored with sRGB nonlinear encoding in byte 0, an 8-bit G component stored with sRGB nonlinear encoding in byte 1, an 8-bit R component stored with sRGB nonlinear encoding in byte 2, and an 8-bit A component in byte 3.
    /// </summary>
    B8G8R8A8_SRGB = 50,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </summary>
    A8B8G8R8_UNorm_Pack32 = 51,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </summary>
    A8B8G8R8_SNorm_Pack32 = 52,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </summary>
    A8B8G8R8_UScaled_Pack32 = 53,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed scaled integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </summary>
    A8B8G8R8_SScaled_Pack32 = 54,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </summary>
    A8B8G8R8_UInt_Pack32 = 55,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed integer format that has an 8-bit A component in bits 24..31, an 8-bit B component in bits 16..23, an 8-bit G component in bits 8..15, and an 8-bit R component in bits 0..7.
    /// </summary>
    A8B8G8R8_SInt_Pack32 = 56,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned normalized format that has an 8-bit A component in bits 24..31, an 8-bit B component stored with sRGB nonlinear encoding in bits 16..23, an 8-bit G component stored with sRGB nonlinear encoding in bits 8..15, and an 8-bit R component stored with sRGB nonlinear encoding in bits 0..7.
    /// </summary>
    A8B8G8R8_SRGB_Pack32 = 57,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </summary>
    A2R10G10B10_UNorm_Pack32 = 58,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </summary>
    A2R10G10B10_SNorm_Pack32 = 59,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </summary>
    A2R10G10B10_UScaled_Pack32 = 60,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </summary>
    A2R10G10B10_SScaled_Pack32 = 61,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </summary>
    A2R10G10B10_UInt_Pack32 = 62,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit R component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit B component in bits 0..9.
    /// </summary>
    A2R10G10B10_SInt_Pack32 = 63,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </summary>
    A2B10G10R10_UNorm_Pack32 = 64,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed normalized format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </summary>
    A2B10G10R10_SNorm_Pack32 = 65,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </summary>
    A2B10G10R10_UScaled_Pack32 = 66,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed scaled integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </summary>
    A2B10G10R10_SScaled_Pack32 = 67,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed unsigned integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </summary>
    A2B10G10R10_UInt_Pack32 = 68,

    /// <summary>
    ///     Specifies a four-component, 32-bit packed signed integer format that has a 2-bit A component in bits 30..31, a 10-bit B component in bits 20..29, a 10-bit G component in bits 10..19, and a 10-bit R component in bits 0..9.
    /// </summary>
    A2B10G10R10_SInt_Pack32 = 69,

    /// <summary>
    ///     Specifies a one-component, 16-bit unsigned normalized format that has a single 16-bit R component.
    /// </summary>
    R16_UNorm = 70,

    /// <summary>
    ///     Specifies a one-component, 16-bit signed normalized format that has a single 16-bit R component.
    /// </summary>
    R16_SNorm = 71,

    /// <summary>
    ///     Specifies a one-component, 16-bit unsigned scaled integer format that has a single 16-bit R component.
    /// </summary>
    R16_UScaled = 72,

    /// <summary>
    ///     Specifies a one-component, 16-bit signed scaled integer format that has a single 16-bit R component.
    /// </summary>
    R16_SScaled = 73,

    /// <summary>
    ///     Specifies a one-component, 16-bit unsigned integer format that has a single 16-bit R component.
    /// </summary>
    R16_UInt = 74,

    /// <summary>
    ///     Specifies a one-component, 16-bit signed integer format that has a single 16-bit R component.
    /// </summary>
    R16_SInt = 75,

    /// <summary>
    ///     Specifies a one-component, 16-bit signed floating-point format that has a single 16-bit R component.
    /// </summary>
    R16_SFloat = 76,

    /// <summary>
    ///     Specifies a two-component, 32-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_UNorm = 77,

    /// <summary>
    ///     Specifies a two-component, 32-bit signed normalized format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_SNorm = 78,

    /// <summary>
    ///     Specifies a two-component, 32-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_UScaled = 79,

    /// <summary>
    ///     Specifies a two-component, 32-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_SScaled = 80,

    /// <summary>
    ///     Specifies a two-component, 32-bit unsigned integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_UInt = 81,

    /// <summary>
    ///     Specifies a two-component, 32-bit signed integer format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_SInt = 82,

    /// <summary>
    ///     Specifies a two-component, 32-bit signed floating-point format that has a 16-bit R component in bytes 0..1, and a 16-bit G component in bytes 2..3.
    /// </summary>
    R16G16_SFloat = 83,

    /// <summary>
    ///     Specifies a three-component, 48-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_UNorm = 84,

    /// <summary>
    ///     Specifies a three-component, 48-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_SNorm = 85,

    /// <summary>
    ///     Specifies a three-component, 48-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_UScaled = 86,

    /// <summary>
    ///     Specifies a three-component, 48-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_SScaled = 87,

    /// <summary>
    ///     Specifies a three-component, 48-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_UInt = 88,

    /// <summary>
    ///     Specifies a three-component, 48-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_SInt = 89,

    /// <summary>
    ///     Specifies a three-component, 48-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, and a 16-bit B component in bytes 4..5.
    /// </summary>
    R16G16B16_SFloat = 90,

    /// <summary>
    ///     Specifies a four-component, 64-bit unsigned normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_UNorm = 91,

    /// <summary>
    ///     Specifies a four-component, 64-bit signed normalized format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_SNorm = 92,

    /// <summary>
    ///     Specifies a four-component, 64-bit unsigned scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_UScaled = 93,

    /// <summary>
    ///     Specifies a four-component, 64-bit signed scaled integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_SScaled = 94,

    /// <summary>
    ///     Specifies a four-component, 64-bit unsigned integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_UInt = 95,

    /// <summary>
    ///     Specifies a four-component, 64-bit signed integer format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_SInt = 96,

    /// <summary>
    ///     Specifies a four-component, 64-bit signed floating-point format that has a 16-bit R component in bytes 0..1, a 16-bit G component in bytes 2..3, a 16-bit B component in bytes 4..5, and a 16-bit A component in bytes 6..7.
    /// </summary>
    R16G16B16A16_SFloat = 97,

    /// <summary>
    ///     Specifies a one-component, 32-bit unsigned integer format that has a single 32-bit R component.
    /// </summary>
    R32_UInt = 98,

    /// <summary>
    ///     Specifies a one-component, 32-bit signed integer format that has a single 32-bit R component.
    /// </summary>
    R32_SInt = 99,

    /// <summary>
    ///     Specifies a one-component, 32-bit signed floating-point format that has a single 32-bit R component.
    /// </summary>
    R32_SFloat = 100,

    /// <summary>
    ///     Specifies a two-component, 64-bit unsigned integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
    /// </summary>
    R32G32_UInt = 101,

    /// <summary>
    ///     Specifies a two-component, 64-bit signed integer format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
    /// </summary>
    R32G32_SInt = 102,

    /// <summary>
    ///     Specifies a two-component, 64-bit signed floating-point format that has a 32-bit R component in bytes 0..3, and a 32-bit G component in bytes 4..7.
    /// </summary>
    R32G32_SFloat = 103,

    /// <summary>
    ///     Specifies a three-component, 96-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
    /// </summary>
    R32G32B32_UInt = 104,

    /// <summary>
    ///     Specifies a three-component, 96-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
    /// </summary>
    R32G32B32_SInt = 105,

    /// <summary>
    ///     Specifies a three-component, 96-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, and a 32-bit B component in bytes 8..11.
    /// </summary>
    R32G32B32_SFloat = 106,

    /// <summary>
    ///     Specifies a four-component, 128-bit unsigned integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
    /// </summary>
    R32G32B32A32_UInt = 107,

    /// <summary>
    ///     Specifies a four-component, 128-bit signed integer format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
    /// </summary>
    R32G32B32A32_SInt = 108,

    /// <summary>
    ///     Specifies a four-component, 128-bit signed floating-point format that has a 32-bit R component in bytes 0..3, a 32-bit G component in bytes 4..7, a 32-bit B component in bytes 8..11, and a 32-bit A component in bytes 12..15.
    /// </summary>
    R32G32B32A32_SFloat = 109,

    /// <summary>
    ///     Specifies a one-component, 64-bit unsigned integer format that has a single 64-bit R component.
    /// </summary>
    R64_UInt = 110,

    /// <summary>
    ///     Specifies a one-component, 64-bit signed integer format that has a single 64-bit R component.
    /// </summary>
    R64_SInt = 111,

    /// <summary>
    ///     Specifies a one-component, 64-bit signed floating-point format that has a single 64-bit R component.
    /// </summary>
    R64_SFloat = 112,

    /// <summary>
    ///     Specifies a two-component, 128-bit unsigned integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
    /// </summary>
    R64G64_UInt = 113,

    /// <summary>
    ///     Specifies a two-component, 128-bit signed integer format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
    /// </summary>
    R64G64_SInt = 114,

    /// <summary>
    ///     Specifies a two-component, 128-bit signed floating-point format that has a 64-bit R component in bytes 0..7, and a 64-bit G component in bytes 8..15.
    /// </summary>
    R64G64_SFloat = 115,

    /// <summary>
    ///     Specifies a three-component, 192-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
    /// </summary>
    R64G64B64_UInt = 116,

    /// <summary>
    ///     Specifies a three-component, 192-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
    /// </summary>
    R64G64B64_SInt = 117,

    /// <summary>
    ///     Specifies a three-component, 192-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, and a 64-bit B component in bytes 16..23.
    /// </summary>
    R64G64B64_SFloat = 118,

    /// <summary>
    ///     Specifies a four-component, 256-bit unsigned integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
    /// </summary>
    R64G64B64A64_UInt = 119,

    /// <summary>
    ///     Specifies a four-component, 256-bit signed integer format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
    /// </summary>
    R64G64B64A64_SInt = 120,

    /// <summary>
    ///     Specifies a four-component, 256-bit signed floating-point format that has a 64-bit R component in bytes 0..7, a 64-bit G component in bytes 8..15, a 64-bit B component in bytes 16..23, and a 64-bit A component in bytes 24..31.
    /// </summary>
    R64G64B64A64_SFloat = 121,

    /// <summary>
    ///     Specifies a three-component, 32-bit packed unsigned floating-point format that has a 10-bit B component in bits 22..31, an 11-bit G component in bits 11..21, an 11-bit R component in bits 0..10. See <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-fp10">here</see> and <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fundamentals-fp11">here</see>.
    /// </summary>
    B10G11R11_UFloat_Pack32 = 122,

    /// <summary>
    ///     Specifies a three-component, 32-bit packed unsigned floating-point format that has a 5-bit shared exponent in bits 27..31, a 9-bit B component mantissa in bits 18..26, a 9-bit G component mantissa in bits 9..17, and a 9-bit R component mantissa in bits 0..8.
    /// </summary>
    E5B9G9R9_UFloat_Pack32 = 123,

    /// <summary>
    ///     Specifies a one-component, 16-bit unsigned normalized format that has a single 16-bit depth component.
    /// </summary>
    D16_UNorm = 124,

    /// <summary>
    ///     Specifies a two-component, 32-bit format that has 24 unsigned normalized bits in the depth component and, optionally:, 8 bits that are unused.
    /// </summary>
    X8D24_UNorm_Pack32 = 125,

    /// <summary>
    ///     Specifies a one-component, 32-bit signed floating-point format that has 32 bits in the depth component.
    /// </summary>
    D32_SFloat = 126,

    /// <summary>
    ///     Specifies a one-component, 8-bit unsigned integer format that has 8 bits in the stencil component.
    /// </summary>
    S8_UInt = 127,

    /// <summary>
    ///     Specifies a two-component, 24-bit format that has 16 unsigned normalized bits in the depth component and 8 unsigned integer bits in the stencil component.
    /// </summary>
    D16_UNormS8_UInt = 128,

    /// <summary>
    ///     Specifies a two-component, 32-bit packed format that has 8 unsigned integer bits in the stencil component, and 24 unsigned normalized bits in the depth component.
    /// </summary>
    D24_UNormS8_UInt = 129,

    /// <summary>
    ///     Specifies a two-component format that has 32 signed float bits in the depth component and 8 unsigned integer bits in the stencil component. There are optionally: 24 bits that are unused.
    /// </summary>
    D32_SFloatS8_UInt = 130,

    /// <summary>
    ///     Specifies a three-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque.
    /// </summary>
    BC1Rgb_UNorm_Block = 131,

    /// <summary>
    ///     Specifies a three-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque.
    /// </summary>
    BC1Rgb_SRGB_Block = 132,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha.
    /// </summary>
    BC1Rgba_UNorm_Block = 133,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha.
    /// </summary>
    BC1Rgba_SRGB_Block = 134,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
    /// </summary>
    BC2_UNorm_Block = 135,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding.
    /// </summary>
    BC2_SRGB_Block = 136,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
    /// </summary>
    BC3_UNorm_Block = 137,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding.
    /// </summary>
    BC3_SRGB_Block = 138,

    /// <summary>
    ///     Specifies a one-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized red texel data.
    /// </summary>
    BC4_UNorm_Block = 139,

    /// <summary>
    ///     Specifies a one-component, block-compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized red texel data.
    /// </summary>
    BC4_SNorm_Block = 140,

    /// <summary>
    ///     Specifies a two-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </summary>
    BC5_UNorm_Block = 141,

    /// <summary>
    ///     Specifies a two-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </summary>
    BC5_SNorm_Block = 142,

    /// <summary>
    ///     Specifies a three-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned floating-point RGB texel data.
    /// </summary>
    BC6HUFloat_Block = 143,

    /// <summary>
    ///     Specifies a three-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of signed floating-point RGB texel data.
    /// </summary>
    BC6H_SFloat_Block = 144,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    BC7_UNorm_Block = 145,

    /// <summary>
    ///     Specifies a four-component, block-compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    BC7_SRGB_Block = 146,

    /// <summary>
    ///     Specifies a three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data. This format has no alpha and is considered opaque.
    /// </summary>
    ETC2R8G8B8_UNorm_Block = 147,

    /// <summary>
    ///     Specifies a three-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding. This format has no alpha and is considered opaque.
    /// </summary>
    ETC2R8G8B8_SRGB_Block = 148,

    /// <summary>
    ///     Specifies a four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data, and provides 1 bit of alpha.
    /// </summary>
    ETC2R8G8B8A1_UNorm_Block = 149,

    /// <summary>
    ///     Specifies a four-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGB texel data with sRGB nonlinear encoding, and provides 1 bit of alpha.
    /// </summary>
    ETC2R8G8B8A1_SRGB_Block = 150,

    /// <summary>
    ///     Specifies a four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values.
    /// </summary>
    ETC2R8G8B8A8_UNorm_Block = 151,

    /// <summary>
    ///     Specifies a four-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with the first 64 bits encoding alpha values followed by 64 bits encoding RGB values with sRGB nonlinear encoding applied.
    /// </summary>
    ETC2R8G8B8A8_SRGB_Block = 152,

    /// <summary>
    ///     Specifies a one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized red texel data.
    /// </summary>
    EACR11_UNorm_Block = 153,

    /// <summary>
    ///     Specifies a one-component, ETC2 compressed format where each 64-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized red texel data.
    /// </summary>
    EACR11_SNorm_Block = 154,

    /// <summary>
    ///     Specifies a two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </summary>
    EACR11G11_UNorm_Block = 155,

    /// <summary>
    ///     Specifies a two-component, ETC2 compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of signed normalized RG texel data with the first 64 bits encoding red values followed by 64 bits encoding green values.
    /// </summary>
    EACR11G11_SNorm_Block = 156,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC4X4_UNorm_Block = 157,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 4{times}4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC4X4_SRGB_Block = 158,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}4 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC5X4_UNorm_Block = 159,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}4 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC5X4_SRGB_Block = 160,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}5 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC5X5_UNorm_Block = 161,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 5{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC5X5_SRGB_Block = 162,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}5 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC6X5_UNorm_Block = 163,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC6X5_SRGB_Block = 164,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}6 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC6X6_UNorm_Block = 165,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 6{times}6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC6X6_SRGB_Block = 166,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}5 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC8X5_UNorm_Block = 167,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC8X5_SRGB_Block = 168,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}6 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC8X6_UNorm_Block = 169,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC8X6_SRGB_Block = 170,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}8 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC8X8_UNorm_Block = 171,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes an 8{times}8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC8X8_SRGB_Block = 172,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}5 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC10X5_UNorm_Block = 173,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}5 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC10X5_SRGB_Block = 174,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}6 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC10X6_UNorm_Block = 175,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}6 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC10X6_SRGB_Block = 176,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}8 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC10X8_UNorm_Block = 177,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}8 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC10X8_SRGB_Block = 178,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}10 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC10X10_UNorm_Block = 179,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 10{times}10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC10X10_SRGB_Block = 180,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}10 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC12X10_UNorm_Block = 181,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}10 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC12X10_SRGB_Block = 182,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}12 rectangle of unsigned normalized RGBA texel data.
    /// </summary>
    ASTC12X12_UNorm_Block = 183,

    /// <summary>
    ///     Specifies a four-component, ASTC compressed format where each 128-bit compressed texel block encodes a 12{times}12 rectangle of unsigned normalized RGBA texel data with sRGB nonlinear encoding applied to the RGB components.
    /// </summary>
    ASTC12X12_SRGB_Block = 184,

    /// <summary>
    ///
    /// </summary>
    G8B8G8R8422_UNorm = 1000156000,

    /// <summary>
    ///
    /// </summary>
    B8G8R8G8422_UNorm = 1000156001,

    /// <summary>
    ///
    /// </summary>
    G8B8R83_Plane420_UNorm = 1000156002,

    /// <summary>
    ///
    /// </summary>
    G8B8R82_Plane420_UNorm = 1000156003,

    /// <summary>
    ///
    /// </summary>
    G8B8R83_Plane422_UNorm = 1000156004,

    /// <summary>
    ///
    /// </summary>
    G8B8R82_Plane422_UNorm = 1000156005,

    /// <summary>
    ///
    /// </summary>
    G8B8R83_Plane444_UNorm = 1000156006,

    /// <summary>
    ///
    /// </summary>
    R10X6_UNorm_Pack16 = 1000156007,

    /// <summary>
    ///
    /// </summary>
    R10X6G10X6_UNorm2_Pack16 = 1000156008,

    /// <summary>
    ///
    /// </summary>
    R10X6G10X6B10X6A10X6_UNorm4_Pack16 = 1000156009,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6G10X6R10X6422_UNorm4_Pack16 = 1000156010,

    /// <summary>
    ///
    /// </summary>
    B10X6G10X6R10X6G10X6422_UNorm4_Pack16 = 1000156011,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6R10X63_Plane420_UNorm3_Pack16 = 1000156012,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6R10X62_Plane420_UNorm3_Pack16 = 1000156013,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6R10X63_Plane422_UNorm3_Pack16 = 1000156014,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6R10X62_Plane422_UNorm3_Pack16 = 1000156015,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6R10X63_Plane444_UNorm3_Pack16 = 1000156016,

    /// <summary>
    ///
    /// </summary>
    R12X4_UNorm_Pack16 = 1000156017,

    /// <summary>
    ///
    /// </summary>
    R12X4G12X4_UNorm2_Pack16 = 1000156018,

    /// <summary>
    ///
    /// </summary>
    R12X4G12X4B12X4A12X4_UNorm4_Pack16 = 1000156019,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4G12X4R12X4422_UNorm4_Pack16 = 1000156020,

    /// <summary>
    ///
    /// </summary>
    B12X4G12X4R12X4G12X4422_UNorm4_Pack16 = 1000156021,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4R12X43_Plane420_UNorm3_Pack16 = 1000156022,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4R12X42_Plane420_UNorm3_Pack16 = 1000156023,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4R12X43_Plane422_UNorm3_Pack16 = 1000156024,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4R12X42_Plane422_UNorm3_Pack16 = 1000156025,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4R12X43_Plane444_UNorm3_Pack16 = 1000156026,

    /// <summary>
    ///
    /// </summary>
    G16B16G16R16422_UNorm = 1000156027,

    /// <summary>
    ///
    /// </summary>
    B16G16R16G16422_UNorm = 1000156028,

    /// <summary>
    ///
    /// </summary>
    G16B16R163_Plane420_UNorm = 1000156029,

    /// <summary>
    ///
    /// </summary>
    G16B16R162_Plane420_UNorm = 1000156030,

    /// <summary>
    ///
    /// </summary>
    G16B16R163_Plane422_UNorm = 1000156031,

    /// <summary>
    ///
    /// </summary>
    G16B16R162_Plane422_UNorm = 1000156032,

    /// <summary>
    ///
    /// </summary>
    G16B16R163_Plane444_UNorm = 1000156033,

    /// <summary>
    ///
    /// </summary>
    G8B8R82_Plane444_UNorm = 1000330000,

    /// <summary>
    ///
    /// </summary>
    G10X6B10X6R10X62_Plane444_UNorm3_Pack16 = 1000330001,

    /// <summary>
    ///
    /// </summary>
    G12X4B12X4R12X42_Plane444_UNorm3_Pack16 = 1000330002,

    /// <summary>
    ///
    /// </summary>
    G16B16R162_Plane444_UNorm = 1000330003,

    /// <summary>
    ///
    /// </summary>
    A4R4G4B4_UNorm_Pack16 = 1000340000,

    /// <summary>
    ///
    /// </summary>
    A4B4G4R4_UNorm_Pack16 = 1000340001,

    /// <summary>
    ///
    /// </summary>
    ASTC4X4_SFloat_Block = 1000066000,

    /// <summary>
    ///
    /// </summary>
    ASTC5X4_SFloat_Block = 1000066001,

    /// <summary>
    ///
    /// </summary>
    ASTC5X5_SFloat_Block = 1000066002,

    /// <summary>
    ///
    /// </summary>
    ASTC6X5_SFloat_Block = 1000066003,

    /// <summary>
    ///
    /// </summary>
    ASTC6X6_SFloat_Block = 1000066004,

    /// <summary>
    ///
    /// </summary>
    ASTC8X5_SFloat_Block = 1000066005,

    /// <summary>
    ///
    /// </summary>
    ASTC8X6_SFloat_Block = 1000066006,

    /// <summary>
    ///
    /// </summary>
    ASTC8X8_SFloat_Block = 1000066007,

    /// <summary>
    ///
    /// </summary>
    ASTC10X5_SFloat_Block = 1000066008,

    /// <summary>
    ///
    /// </summary>
    ASTC10X6_SFloat_Block = 1000066009,

    /// <summary>
    ///
    /// </summary>
    ASTC10X8_SFloat_Block = 1000066010,

    /// <summary>
    ///
    /// </summary>
    ASTC10X10_SFloat_Block = 1000066011,

    /// <summary>
    ///
    /// </summary>
    ASTC12X10_SFloat_Block = 1000066012,

    /// <summary>
    ///
    /// </summary>
    ASTC12X12_SFloat_Block = 1000066013,

    /// <summary>
    ///
    /// </summary>
    Pvrtc12Bpp_UNorm_BlockIMG = 1000054000,

    /// <summary>
    ///
    /// </summary>
    Pvrtc14Bpp_UNorm_BlockIMG = 1000054001,

    /// <summary>
    ///
    /// </summary>
    Pvrtc22Bpp_UNorm_BlockIMG = 1000054002,

    /// <summary>
    ///
    /// </summary>
    Pvrtc24Bpp_UNorm_BlockIMG = 1000054003,

    /// <summary>
    ///
    /// </summary>
    Pvrtc12Bpp_SRGB_BlockIMG = 1000054004,

    /// <summary>
    ///
    /// </summary>
    Pvrtc14Bpp_SRGB_BlockIMG = 1000054005,

    /// <summary>
    ///
    /// </summary>
    Pvrtc22Bpp_SRGB_BlockIMG = 1000054006,

    /// <summary>
    ///
    /// </summary>
    Pvrtc24Bpp_SRGB_BlockIMG = 1000054007,

    /// <summary>
    ///
    /// </summary>
    R16G16S105NV = 1000464000,

    /// <summary>
    ///
    /// </summary>
    A1B5G5R5_UNorm_Pack16KHR = 1000470000,

    /// <summary>
    ///
    /// </summary>
    A8_UNormKHR = 1000470001,
}
