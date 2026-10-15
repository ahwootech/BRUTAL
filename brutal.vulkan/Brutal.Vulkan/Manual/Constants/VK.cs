namespace Brutal.VulkanApi;

public static partial class VK
{
    public static readonly ByteSize WHOLE_SIZE = ByteSize.Of(unchecked((int)(~0UL)));

    // #define VK_MAKE_VIDEO_STD_VERSION(major, minor, patch) \
    //     ((((uint32_t)(major)) << 22) | (((uint32_t)(minor)) << 12) | ((uint32_t)(patch)))
    private const int STD_VULKAN_VIDEO_CODEC_H264_DECODE_API_VERSION_1_0_0 = 1 << 22;
    private const int STD_VULKAN_VIDEO_CODEC_H264_ENCODE_API_VERSION_1_0_0 = 1 << 22;
    private const int STD_VULKAN_VIDEO_CODEC_H265_DECODE_API_VERSION_1_0_0 = 1 << 22;
    private const int STD_VULKAN_VIDEO_CODEC_H265_ENCODE_API_VERSION_1_0_0 = 1 << 22;
    private const int STD_VULKAN_VIDEO_CODEC_VP9_DECODE_API_VERSION_1_0_0 = 1 << 22;
    private const int STD_VULKAN_VIDEO_CODEC_AV1_DECODE_API_VERSION_1_0_0 = 1 << 22;
    private const int STD_VULKAN_VIDEO_CODEC_AV1_ENCODE_API_VERSION_1_0_0 = 1 << 22;
}
