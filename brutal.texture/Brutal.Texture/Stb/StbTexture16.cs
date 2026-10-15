using Brutal.Numerics;
using Brutal.StbApi;
using Brutal.TextureApi;

namespace Brutal.TextureApi.Stb;

public class StbTexture16 : StbTexture
{
    internal StbTexture16(StbImage16 image)
        : base(
            new CreateInfo
            {
                Extent = new int2(image.Width, image.Height),
                Channels = image.Channels,
                BytesPerChannel = 2,
            }
        )
    {
        _image = image;
    }

    public override TextureFormat Format
    {
        get
        {
            return _image.Channels switch
            {
                1 => TextureFormat.R16_UNorm,
                2 => TextureFormat.R16G16_UNorm,
                3 => TextureFormat.R16G16B16_UNorm,
                4 => TextureFormat.R16G16B16A16_UNorm,
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }

    protected override unsafe byte* GetDataPointer()
    {
        return (byte*)_image.Data;
    }

    protected override void FreeNativeResources()
    {
        if (_image.IsNotNull())
        {
            _image.Dispose();
            _image = default;
        }
    }

    private StbImage16 _image;
}
