using Brutal.Numerics;
using Brutal.StbApi;
using Brutal.TextureApi;

namespace Brutal.TextureApi.Stb;

public class StbTexture8 : StbTexture
{
    internal StbTexture8(StbImage8 image)
        : base(
            new CreateInfo
            {
                Extent = new int2(image.Width, image.Height),
                Channels = image.Channels,
                BytesPerChannel = 1,
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
                1 => TextureFormat.R8_UNorm,
                2 => TextureFormat.R8G8_UNorm,
                3 => TextureFormat.R8G8B8_UNorm,
                4 => TextureFormat.R8G8B8A8_UNorm,
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
    }

    protected override unsafe byte* GetDataPointer()
    {
        return _image.Data;
    }

    protected override void FreeNativeResources()
    {
        if (_image.IsNotNull())
        {
            _image.Dispose();
            _image = default;
        }
    }

    private StbImage8 _image;
}
