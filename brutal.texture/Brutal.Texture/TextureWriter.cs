namespace Brutal.TextureApi;

public static partial class TextureWriter
{
    /// <summary>
    /// Saves an ITexture to a file.
    /// </summary>
    /// <param name="texture">The ITexture to save.</param>
    /// <param name="filePath">The path to the file.</param>
    /// <exception cref="NotSupportedException">Thrown if the extension of filePath is not supported.</exception>
    public static void SaveToFile(ITexture texture, string filePath)
    {
        var extension = Path.GetExtension(filePath);
        if (Ktx.Loader.SupportedExtensions.Contains(extension))
        {
            Ktx.Writer.SaveToFile(texture, filePath);
            return;
        }

        if (Stb.Writer.SupportedExtensions.Contains(extension))
        {
            Stb.Writer.SaveToFile(texture, filePath);
            return;
        }

        if (Gli.Loader.SupportedExtensions.Contains(extension))
        {
            Gli.Writer.SaveToFile(texture, filePath);
            return;
        }

        throw new NotSupportedException($"No loader found that supports file {extension}");
    }
}
