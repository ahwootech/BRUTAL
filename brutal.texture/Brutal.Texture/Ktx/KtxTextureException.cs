using Brutal.KtxApi;
using Brutal.TextureApi;

namespace Brutal.TextureApi.Ktx;

public class KtxTextureException : TextureException
{
    public KtxTextureException(string message, KtxErrorCode? errorCode = null)
        : base(message)
    {
        ErrorCode = errorCode;
    }

    public KtxErrorCode? ErrorCode { get; }
}
