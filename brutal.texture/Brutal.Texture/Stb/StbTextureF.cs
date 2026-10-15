using Brutal.Numerics;
using Brutal.StbApi;
using Brutal.TextureApi;

namespace Brutal.TextureApi.Stb;

public class StbTextureF : StbTexture
{
    internal StbTextureF(StbImageF image)
        : base(
            new CreateInfo
            {
                Extent = new int2(image.Width, image.Height),
                Channels = image.Channels,
                BytesPerChannel = 4,
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
                1 => TextureFormat.R32_SFloat,
                2 => TextureFormat.R32G32_SFloat,
                3 => TextureFormat.R32G32B32_SFloat,
                4 => TextureFormat.R32G32B32A32_SFloat,
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

    private StbImageF _image;
}
