namespace Brutal.TextureApi.Stb;

/// <summary>
/// Thrown when the StbTextureLoaded encounters a fatal error.
/// </summary>
public class StbTextureReadException : StbTextureException
{
    public StbTextureReadException(string message)
        : base(message) { }
}
