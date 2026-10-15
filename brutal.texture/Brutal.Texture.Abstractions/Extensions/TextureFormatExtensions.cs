namespace Brutal.TextureApi.Abstractions;

/// <summary>
/// Static class for utility functions relating to a TextureFormat.
/// </summary>
public static class TextureFormatExtensions
{
    /// <param name="format">Format to get the <see cref="FormatDescriptor"/> for</param>
    extension(TextureFormat format)
    {
        /// <summary>
        /// Returns a descriptor detailing information about a TextureFormat.
        /// </summary>
        /// <returns>The Descriptor</returns>
        /// <exception cref="NotImplementedException">If the properties of the format could not be determined</exception>
        public FormatDescriptor Descriptor()
        {
            var minBlocksX = 1u;
            var minBlocksY = 1u;
            var flags = FormatDescriptor.DescriptorFlags.None;
            var blockSizeInBits = 0u;
            var blockWidth = 0u;
            var blockHeight = 0u;
            var blockDepth = 0u;

            switch (format)
            {
                case TextureFormat.R4G4_UNorm_Pack8:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 1 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.A8_UNormKHR:
                    flags = 0;
                    blockSizeInBits = 1 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R4G4B4A4_UNorm_Pack16:
                case TextureFormat.B4G4R4A4_UNorm_Pack16:
                case TextureFormat.R5G6B5_UNorm_Pack16:
                case TextureFormat.B5G6R5_UNorm_Pack16:
                case TextureFormat.R5G5B5A1_UNorm_Pack16:
                case TextureFormat.B5G5R5A1_UNorm_Pack16:
                case TextureFormat.A1R5G5B5_UNorm_Pack16:
                case TextureFormat.A1B5G5R5_UNorm_Pack16KHR:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 2 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R8_UNorm:
                case TextureFormat.R8_SNorm:
                case TextureFormat.R8_UScaled:
                case TextureFormat.R8_SScaled:
                case TextureFormat.R8_UInt:
                case TextureFormat.R8_SInt:
                case TextureFormat.R8_SRGB:
                    flags = 0;
                    blockSizeInBits = 1 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R8G8_UNorm:
                case TextureFormat.R8G8_SNorm:
                case TextureFormat.R8G8_UScaled:
                case TextureFormat.R8G8_SScaled:
                case TextureFormat.R8G8_UInt:
                case TextureFormat.R8G8_SInt:
                case TextureFormat.R8G8_SRGB:
                    flags = 0;
                    blockSizeInBits = 2 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R8G8B8_UNorm:
                case TextureFormat.R8G8B8_SNorm:
                case TextureFormat.R8G8B8_UScaled:
                case TextureFormat.R8G8B8_SScaled:
                case TextureFormat.R8G8B8_UInt:
                case TextureFormat.R8G8B8_SInt:
                case TextureFormat.R8G8B8_SRGB:
                case TextureFormat.B8G8R8_UNorm:
                case TextureFormat.B8G8R8_SNorm:
                case TextureFormat.B8G8R8_UScaled:
                case TextureFormat.B8G8R8_SScaled:
                case TextureFormat.B8G8R8_UInt:
                case TextureFormat.B8G8R8_SInt:
                case TextureFormat.B8G8R8_SRGB:
                    flags = 0;
                    blockSizeInBits = 3 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R8G8B8A8_UNorm:
                case TextureFormat.R8G8B8A8_SNorm:
                case TextureFormat.R8G8B8A8_UScaled:
                case TextureFormat.R8G8B8A8_SScaled:
                case TextureFormat.R8G8B8A8_UInt:
                case TextureFormat.R8G8B8A8_SInt:
                case TextureFormat.R8G8B8A8_SRGB:
                case TextureFormat.B8G8R8A8_UNorm:
                case TextureFormat.B8G8R8A8_SNorm:
                case TextureFormat.B8G8R8A8_UScaled:
                case TextureFormat.B8G8R8A8_SScaled:
                case TextureFormat.B8G8R8A8_UInt:
                case TextureFormat.B8G8R8A8_SInt:
                case TextureFormat.B8G8R8A8_SRGB:
                    flags = 0;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.A8B8G8R8_UNorm_Pack32:
                case TextureFormat.A8B8G8R8_SNorm_Pack32:
                case TextureFormat.A8B8G8R8_UScaled_Pack32:
                case TextureFormat.A8B8G8R8_SScaled_Pack32:
                case TextureFormat.A8B8G8R8_UInt_Pack32:
                case TextureFormat.A8B8G8R8_SInt_Pack32:
                case TextureFormat.A8B8G8R8_SRGB_Pack32:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.A2R10G10B10_UNorm_Pack32:
                case TextureFormat.A2R10G10B10_SNorm_Pack32:
                case TextureFormat.A2R10G10B10_UScaled_Pack32:
                case TextureFormat.A2R10G10B10_SScaled_Pack32:
                case TextureFormat.A2R10G10B10_UInt_Pack32:
                case TextureFormat.A2R10G10B10_SInt_Pack32:
                case TextureFormat.A2B10G10R10_UNorm_Pack32:
                case TextureFormat.A2B10G10R10_SNorm_Pack32:
                case TextureFormat.A2B10G10R10_UScaled_Pack32:
                case TextureFormat.A2B10G10R10_SScaled_Pack32:
                case TextureFormat.A2B10G10R10_UInt_Pack32:
                case TextureFormat.A2B10G10R10_SInt_Pack32:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R16_UNorm:
                case TextureFormat.R16_SNorm:
                case TextureFormat.R16_UScaled:
                case TextureFormat.R16_SScaled:
                case TextureFormat.R16_UInt:
                case TextureFormat.R16_SInt:
                case TextureFormat.R16_SFloat:
                    flags = 0;
                    blockSizeInBits = 2 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R16G16_UNorm:
                case TextureFormat.R16G16_SNorm:
                case TextureFormat.R16G16_UScaled:
                case TextureFormat.R16G16_SScaled:
                case TextureFormat.R16G16_UInt:
                case TextureFormat.R16G16_SInt:
                case TextureFormat.R16G16_SFloat:
                case TextureFormat.R16G16S105NV: // Actualy is VK_FORMAT_R16G16_SFIXED5_NV
                    flags = 0;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R16G16B16_UNorm:
                case TextureFormat.R16G16B16_SNorm:
                case TextureFormat.R16G16B16_UScaled:
                case TextureFormat.R16G16B16_SScaled:
                case TextureFormat.R16G16B16_UInt:
                case TextureFormat.R16G16B16_SInt:
                case TextureFormat.R16G16B16_SFloat:
                    flags = 0;
                    blockSizeInBits = 6 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R16G16B16A16_UNorm:
                case TextureFormat.R16G16B16A16_SNorm:
                case TextureFormat.R16G16B16A16_UScaled:
                case TextureFormat.R16G16B16A16_SScaled:
                case TextureFormat.R16G16B16A16_UInt:
                case TextureFormat.R16G16B16A16_SInt:
                case TextureFormat.R16G16B16A16_SFloat:
                    flags = 0;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R32_UInt:
                case TextureFormat.R32_SInt:
                case TextureFormat.R32_SFloat:
                    flags = 0;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R32G32_UInt:
                case TextureFormat.R32G32_SInt:
                case TextureFormat.R32G32_SFloat:
                    flags = 0;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R32G32B32_UInt:
                case TextureFormat.R32G32B32_SInt:
                case TextureFormat.R32G32B32_SFloat:
                    flags = 0;
                    blockSizeInBits = 12 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R32G32B32A32_UInt:
                case TextureFormat.R32G32B32A32_SInt:
                case TextureFormat.R32G32B32A32_SFloat:
                    flags = 0;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R64G64_UInt:
                case TextureFormat.R64G64_SInt:
                case TextureFormat.R64G64_SFloat:
                    flags = 0;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R64_UInt:
                case TextureFormat.R64_SInt:
                case TextureFormat.R64_SFloat:
                    flags = 0;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R64G64B64_UInt:
                case TextureFormat.R64G64B64_SInt:
                case TextureFormat.R64G64B64_SFloat:
                    flags = 0;
                    blockSizeInBits = 24 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R64G64B64A64_UInt:
                case TextureFormat.R64G64B64A64_SInt:
                case TextureFormat.R64G64B64A64_SFloat:
                    flags = 0;
                    blockSizeInBits = 32 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.B10G11R11_UFloat_Pack32:
                case TextureFormat.E5B9G9R9_UFloat_Pack32:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.D16_UNorm:
                    flags = FormatDescriptor.DescriptorFlags.DepthBit;
                    blockSizeInBits = 2 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.X8D24_UNorm_Pack32:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit | FormatDescriptor.DescriptorFlags.DepthBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.D32_SFloat:
                    flags = FormatDescriptor.DescriptorFlags.DepthBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.S8_UInt:
                    flags = FormatDescriptor.DescriptorFlags.StencilBit;
                    blockSizeInBits = 1 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.D16_UNormS8_UInt:
                    flags = FormatDescriptor.DescriptorFlags.DepthBit | FormatDescriptor.DescriptorFlags.StencilBit;
                    blockSizeInBits = 3 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.D24_UNormS8_UInt:
                    flags = FormatDescriptor.DescriptorFlags.DepthBit | FormatDescriptor.DescriptorFlags.StencilBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.D32_SFloatS8_UInt:
                    flags = FormatDescriptor.DescriptorFlags.DepthBit | FormatDescriptor.DescriptorFlags.StencilBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.BC1Rgb_UNorm_Block:
                case TextureFormat.BC1Rgb_SRGB_Block:
                case TextureFormat.BC1Rgba_UNorm_Block:
                case TextureFormat.BC1Rgba_SRGB_Block:
                case TextureFormat.BC4_UNorm_Block:
                case TextureFormat.BC4_SNorm_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.BC2_UNorm_Block:
                case TextureFormat.BC2_SRGB_Block:
                case TextureFormat.BC3_UNorm_Block:
                case TextureFormat.BC3_SRGB_Block:
                case TextureFormat.BC5_UNorm_Block:
                case TextureFormat.BC5_SNorm_Block:
                case TextureFormat.BC6HUFloat_Block:
                case TextureFormat.BC6H_SFloat_Block:
                case TextureFormat.BC7_UNorm_Block:
                case TextureFormat.BC7_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.ETC2R8G8B8_UNorm_Block:
                case TextureFormat.ETC2R8G8B8_SRGB_Block:
                case TextureFormat.ETC2R8G8B8A1_UNorm_Block:
                case TextureFormat.ETC2R8G8B8A1_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.EACR11_UNorm_Block:
                case TextureFormat.EACR11_SNorm_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.ETC2R8G8B8A8_UNorm_Block:
                case TextureFormat.ETC2R8G8B8A8_SRGB_Block:
                case TextureFormat.EACR11G11_UNorm_Block:
                case TextureFormat.EACR11G11_SNorm_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.Pvrtc12Bpp_SRGB_BlockIMG:
                case TextureFormat.Pvrtc12Bpp_UNorm_BlockIMG:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 8;
                    blockHeight = 4;
                    blockDepth = 1;
                    minBlocksX = 2;
                    minBlocksY = 2;
                    break;
                case TextureFormat.Pvrtc22Bpp_SRGB_BlockIMG:
                case TextureFormat.Pvrtc22Bpp_UNorm_BlockIMG:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 8;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.Pvrtc14Bpp_SRGB_BlockIMG:
                case TextureFormat.Pvrtc14Bpp_UNorm_BlockIMG:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    minBlocksX = 2;
                    minBlocksY = 2;
                    break;
                case TextureFormat.Pvrtc24Bpp_SRGB_BlockIMG:
                case TextureFormat.Pvrtc24Bpp_UNorm_BlockIMG:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC4X4_SFloat_Block:
                case TextureFormat.ASTC4X4_UNorm_Block:
                case TextureFormat.ASTC4X4_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 4;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC5X4_SFloat_Block:
                case TextureFormat.ASTC5X4_UNorm_Block:
                case TextureFormat.ASTC5X4_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 5;
                    blockHeight = 4;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC5X5_SFloat_Block:
                case TextureFormat.ASTC5X5_UNorm_Block:
                case TextureFormat.ASTC5X5_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 5;
                    blockHeight = 5;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC6X5_SFloat_Block:
                case TextureFormat.ASTC6X5_UNorm_Block:
                case TextureFormat.ASTC6X5_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 6;
                    blockHeight = 5;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC6X6_SFloat_Block:
                case TextureFormat.ASTC6X6_UNorm_Block:
                case TextureFormat.ASTC6X6_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 6;
                    blockHeight = 6;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC8X5_SFloat_Block:
                case TextureFormat.ASTC8X5_UNorm_Block:
                case TextureFormat.ASTC8X5_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 8;
                    blockHeight = 5;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC8X6_SFloat_Block:
                case TextureFormat.ASTC8X6_UNorm_Block:
                case TextureFormat.ASTC8X6_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 8;
                    blockHeight = 6;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC8X8_SFloat_Block:
                case TextureFormat.ASTC8X8_UNorm_Block:
                case TextureFormat.ASTC8X8_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 8;
                    blockHeight = 8;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC10X5_SFloat_Block:
                case TextureFormat.ASTC10X5_UNorm_Block:
                case TextureFormat.ASTC10X5_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 10;
                    blockHeight = 5;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC10X6_SFloat_Block:
                case TextureFormat.ASTC10X6_UNorm_Block:
                case TextureFormat.ASTC10X6_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 10;
                    blockHeight = 6;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC10X8_SFloat_Block:
                case TextureFormat.ASTC10X8_UNorm_Block:
                case TextureFormat.ASTC10X8_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 10;
                    blockHeight = 8;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC10X10_SFloat_Block:
                case TextureFormat.ASTC10X10_UNorm_Block:
                case TextureFormat.ASTC10X10_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 10;
                    blockHeight = 10;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC12X10_SFloat_Block:
                case TextureFormat.ASTC12X10_UNorm_Block:
                case TextureFormat.ASTC12X10_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;
                    blockSizeInBits = 16 * 8;
                    blockWidth = 12;
                    blockHeight = 10;
                    blockDepth = 1;
                    break;
                case TextureFormat.ASTC12X12_SFloat_Block:
                case TextureFormat.ASTC12X12_UNorm_Block:
                case TextureFormat.ASTC12X12_SRGB_Block:
                    flags = FormatDescriptor.DescriptorFlags.CompressedBit;

                    blockSizeInBits = 16 * 8;
                    blockWidth = 12;
                    blockHeight = 12;
                    blockDepth = 1;
                    break;
                case TextureFormat.B8G8R8G8422_UNorm:
                case TextureFormat.G8B8G8R8422_UNorm:
                    flags = 0;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 2;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                // Plane and Scaled formats are prohibited by libktx.
                case TextureFormat.G8B8R82_Plane420_UNorm:
                case TextureFormat.G8B8R83_Plane420_UNorm:
                    flags = FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 3 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G8B8R83_Plane422_UNorm:
                case TextureFormat.G8B8R82_Plane422_UNorm:
                    flags = FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 3 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G8B8R83_Plane444_UNorm:
                case TextureFormat.G8B8R82_Plane444_UNorm:
                    flags = FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 3 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R10X6G10X6B10X6A10X6_UNorm4_Pack16:
                    //case TextureFormat.R10X6G10X6B10X6A10X6_UInt4_Pack16_Arm:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G10X6B10X6G10X6R10X6422_UNorm4_Pack16:
                case TextureFormat.B10X6G10X6R10X6G10X6422_UNorm4_Pack16:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 2;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G10X6B10X6R10X62_Plane420_UNorm3_Pack16:
                case TextureFormat.G10X6B10X6R10X62_Plane422_UNorm3_Pack16:
                case TextureFormat.G10X6B10X6R10X62_Plane444_UNorm3_Pack16:
                case TextureFormat.G10X6B10X6R10X63_Plane420_UNorm3_Pack16:
                case TextureFormat.G10X6B10X6R10X63_Plane422_UNorm3_Pack16:
                case TextureFormat.G10X6B10X6R10X63_Plane444_UNorm3_Pack16:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit | FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 6 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R12X4G12X4B12X4A12X4_UNorm4_Pack16:
                    //case TextureFormat.R12X4G12X4B12X4A12X4_UInt4_Pack16_Arm:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G12X4B12X4G12X4R12X4422_UNorm4_Pack16:
                case TextureFormat.B12X4G12X4R12X4G12X4422_UNorm4_Pack16:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 2;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G12X4B12X4R12X42_Plane420_UNorm3_Pack16:
                case TextureFormat.G12X4B12X4R12X42_Plane422_UNorm3_Pack16:
                case TextureFormat.G12X4B12X4R12X42_Plane444_UNorm3_Pack16:
                case TextureFormat.G12X4B12X4R12X43_Plane420_UNorm3_Pack16:
                case TextureFormat.G12X4B12X4R12X43_Plane422_UNorm3_Pack16:
                case TextureFormat.G12X4B12X4R12X43_Plane444_UNorm3_Pack16:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit | FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 6 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G16B16G16R16422_UNorm:
                case TextureFormat.B16G16R16G16422_UNorm:
                    flags = 0;
                    blockSizeInBits = 8 * 8;
                    blockWidth = 2;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.G16B16R163_Plane420_UNorm:
                case TextureFormat.G16B16R162_Plane420_UNorm:
                case TextureFormat.G16B16R163_Plane422_UNorm:
                case TextureFormat.G16B16R162_Plane422_UNorm:
                case TextureFormat.G16B16R162_Plane444_UNorm:
                    flags = FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 6 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R10X6_UNorm_Pack16:
                case TextureFormat.R12X4_UNorm_Pack16:
                case TextureFormat.A4R4G4B4_UNorm_Pack16:
                case TextureFormat.A4B4G4R4_UNorm_Pack16:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 2 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.R10X6G10X6_UNorm2_Pack16:
                case TextureFormat.R12X4G12X4_UNorm2_Pack16:
                    flags = FormatDescriptor.DescriptorFlags.PackedBit;
                    blockSizeInBits = 4 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;

                case TextureFormat.G16B16R163_Plane444_UNorm:
                    flags = FormatDescriptor.DescriptorFlags.PlanarBit;
                    blockSizeInBits = 6 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                case TextureFormat.Undefined:
                    flags = 0;
                    blockSizeInBits = 0 * 8;
                    blockWidth = 1;
                    blockHeight = 1;
                    blockDepth = 1;
                    break;
                default:
                    throw new NotImplementedException("FormatDescriptor undefined for TextureFormat " + format);
            }
            return new FormatDescriptor(
                flags,
                blockSizeInBits,
                blockWidth,
                blockHeight,
                blockDepth,
                minBlocksX,
                minBlocksY
            );
        }
    }
}
