using Brutal.TextureApi;

namespace Brutal.GltfApi;

/// <summary>
/// Interface for a glTF loader
/// </summary>
public interface IGltfLoader
{
    /// <summary>
    /// Gltf Json object
    /// </summary>
    public Gltf GltfJson { get; }

    /// <summary>
    /// Gets a span of bytes for a specific buffer view
    /// </summary>
    /// <param name="bufferViewIndex">Index of buffer view</param>
    /// <returns>Buffer view as byte span</returns>
    public ReadOnlySpan<byte> GetBufferView(int bufferViewIndex);
}

/// <summary>
/// Interface for a glTF loader that caches loaded data
/// </summary>
public interface IGltfCachedLoader : IGltfLoader
{
    /// <summary>
    /// Gets a cached buffer or loads it from the glTF file if not already loaded.
    /// </summary>
    /// <param name="bufferIndex">Index of buffer</param>
    /// <returns>Buffer's contents as byte span</returns>
    public ReadOnlySpan<byte> GetOrLoadBuffer(int bufferIndex);

    /// <summary>
    /// Gets a cached image or loads it from the glTF file if not already loaded.
    /// </summary>
    /// <param name="imageIndex">Index of image</param>
    /// <param name="loadInfo">Optional texture load info</param>
    /// <returns>Image loaded as ITexture</returns>
    public ITexture GetOrLoadImage(int imageIndex, TextureLoadSettings? loadInfo = null);
}

/// <summary>
/// Helper class for loading glTF files
/// This class caches loaded glTF json and binary buffers
/// </summary>
public class GltfLoader : IGltfCachedLoader, IDisposable
{
    /// <summary>
    /// Source path of the glTF file, if loaded from a file
    /// </summary>
    public string FilePath = string.Empty;

    /// <summary>
    /// Optional function to resolve image data externally
    /// This can be used to load images from a custom source, such as a network or
    /// a custom image format.
    /// If empty, the loader will attempt to load images as files relative to the glTF file path
    /// </summary>
    public Func<string, ReadOnlySpan<byte>>? ExternalResolveImage;

    /// <summary>
    /// Optional function to resolve binary buffer data externally
    /// This can be used to load binary buffers from a custom source
    /// If empty, the loader will attempt to load buffers as files relative to the glTF file path
    /// This is useful for cases where the glTF file references external binary buffers.
    /// </summary>
    public Func<string, byte[]>? ExternalResolveBuffer;

    /// <summary>
    /// Parsed Gltf Json object
    /// This contains all the metadata about the glTF file, such as meshes, materials,
    /// textures, and animations.
    /// </summary>
    public readonly Gltf GltfJson;

    /// <summary>
    /// Array of loaded binary buffers, cached as byte arrays when needed
    /// Each buffer corresponds to a buffer in the glTF file.
    /// If a buffer is not loaded, it will be null in the array.
    /// This is used to avoid reloading buffers multiple times during a load operation.
    /// </summary>
    public readonly byte[]?[] LoadedBuffers;

    /// <summary>
    /// Array of loaded images, cached as ITexture objects
    /// Each image corresponds to a texture in the glTF file.
    /// This is used to avoid reloading images multiple times during a load operation.
    /// If an image is not loaded, it will be null in the array.
    /// </summary>
    public readonly ITexture?[] LoadedImages;

    /// <summary>
    /// Constructor for GltfLoader
    /// Initializes the GltfJson object by loading the glTF file from the specified file path
    /// and initializes the LoadedBuffers and LoadedImages arrays.
    /// </summary>
    /// <param name="filePath">Path to glTF file</param>
    public GltfLoader(string filePath)
    {
        GltfJson = GltfUtility.LoadModel(filePath);
        LoadedBuffers = new byte[GltfJson.Buffers?.Length ?? 0][];
        LoadedImages = new ITexture[GltfJson.Images?.Length ?? 0];
        FilePath = filePath;
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        for (var index = 0; index < LoadedImages.Length; index++)
        {
            var image = LoadedImages[index];
            if (image is not null)
                TextureApi.TextureLoader.Unload(image);
            LoadedImages[index] = null;
        }
    }

    /// <summary>
    /// Accesses cached loaded buffer or loads it from the glTF file if not already loaded.
    /// </summary>
    /// <param name="bufferIndex">Buffer index</param>
    /// <returns>Span of bytes encompassing entire buffer</returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public ReadOnlySpan<byte> GetOrLoadBuffer(int bufferIndex)
    {
        if (bufferIndex < 0 || bufferIndex >= LoadedBuffers.Length)
            throw new IndexOutOfRangeException($"Buffer index {bufferIndex} is out of range.");

        var buffer = LoadedBuffers[bufferIndex];
        if (buffer == null)
        {
            // Load the buffer from the glTF file
            if (ExternalResolveBuffer is null)
                buffer = GltfJson.LoadBinaryBuffer(bufferIndex, FilePath);
            else
                buffer = GltfJson.LoadBinaryBuffer(bufferIndex, ExternalResolveBuffer);
            // Cache the loaded buffer
            LoadedBuffers[bufferIndex] =
                buffer ?? throw new InvalidOperationException($"Failed to load buffer at index {bufferIndex}.");
        }

        return new ReadOnlySpan<byte>(buffer);
    }

    /// <summary>
    /// Accesses a span of buffer memory for a specific buffer view.
    /// This method retrieves the buffer view from the glTF JSON and returns a span of bytes
    /// Buffers are loaded on demand and cached for future access.
    /// </summary>
    /// <param name="bufferViewIndex">Index of buffer view</param>
    /// <returns>Span of bytes matching buffer view</returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public ReadOnlySpan<byte> GetBufferView(int bufferViewIndex)
    {
        if (bufferViewIndex < 0 || bufferViewIndex >= GltfJson.BufferViews.Length)
            throw new IndexOutOfRangeException($"Buffer view index {bufferViewIndex} is out of range.");

        // Get the buffer view from the glTF JSON
        var bufferIndex = GltfJson.BufferViews[bufferViewIndex].Buffer;
        var bufferSpan = GetOrLoadBuffer(bufferIndex);
        return bufferSpan.Slice(
            GltfJson.BufferViews[bufferViewIndex].ByteOffset,
            GltfJson.BufferViews[bufferViewIndex].ByteLength
        );
    }

    /// <summary>
    /// Load image with different strategies based on how it is embedded in the glTF file.
    /// </summary>
    /// <param name="imageIndex"></param>
    /// <param name="loadInfo"></param>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    protected ITexture LoadImage(int imageIndex, TextureLoadSettings? loadInfo)
    {
        var image = GltfJson.Images[imageIndex];
        // If texture embedded in buffer, extract it here
        if (image.BufferView.HasValue)
        {
            var bufferViewSpan = GetBufferView(image.BufferView.Value);
            if (image.MimeType is null)
                throw new InvalidOperationException(
                    $"Image at index {imageIndex} is embedded in a buffer view but has no mime type."
                );
            return TextureLoader.LoadFromMemory(
                bufferViewSpan,
                image.MimeType == Image.MimeTypeEnum.ImageJpeg
                    ? TextureLoader.FormatType.Jpg
                    : TextureLoader.FormatType.Png,
                loadInfo
            );
        }
        // If texture embedded in URI, load it from the embedded data
        if (image.IsEmbedded())
        {
            var embedded = image.OpenEmbeddedImage(out var extension);
            if (string.IsNullOrEmpty(extension))
                throw new InvalidOperationException($"Image at index {imageIndex} is embedded but has no extension.");
            if (extension[0] != '.')
                extension = "." + extension;
            return TextureLoader.LoadFromMemory(embedded, TextureLoader.GetFormatType(extension), loadInfo);
        }
        if (string.IsNullOrEmpty(image.Uri))
            throw new InvalidOperationException($"Image at index {imageIndex} has no URI or buffer view.");
        // If image is not embedded, load it from file or external source
        if (ExternalResolveImage is not null)
        {
            // Use external resolver if provided
            var imageData = ExternalResolveImage(image.Uri);
            if (imageData.IsEmpty)
                throw new InvalidOperationException(
                    $"Failed to resolve image at index {imageIndex} using external resolver."
                );
            return TextureLoader.LoadFromMemory(imageData, TextureLoader.GetFormatType(image.Uri), loadInfo);
        }
        return TextureLoader.LoadFromFile(
            Path.Combine(Path.GetDirectoryName(FilePath) ?? string.Empty, image.Uri),
            loadInfo
        );
    }

    /// <summary>
    /// Gets an image by index: loads it if not already loaded.
    /// This method retrieves an image from the cache or loads it from the glTF file if it has not been loaded yet.
    /// The image is cached in the LoadedImages array to avoid reloading it multiple times.
    /// </summary>
    /// <param name="imageIndex">Index of image</param>
    /// <param name="loadInfo"></param>
    /// <returns>Image loaded as ITexture</returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public ITexture GetOrLoadImage(int imageIndex, TextureLoadSettings? loadInfo = null)
    {
        if (imageIndex < 0 || imageIndex >= LoadedImages.Length)
            throw new IndexOutOfRangeException($"Image index {imageIndex} is out of range.");

        var image = LoadedImages[imageIndex];
        if (image is null)
        {
            image = LoadImage(imageIndex, loadInfo);
            LoadedImages[imageIndex] = image;
        }
        return image;
    }

    /// <summary>
    /// Save GLTF data to a packed .GLB file
    /// </summary>
    /// <param name="outputFilePath">File path to save .glb</param>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="NullReferenceException"></exception>
    public void SaveAsGlb(string outputFilePath)
    {
        using var stream = File.Create(outputFilePath);
        SaveAsGlb(stream);
    }

    /// <summary>
    /// Save as GLB file to an output stream
    /// </summary>
    /// <param name="outputStream">Stream to write .glb</param>
    public void SaveAsGlb(Stream outputStream)
    {
        // Deep copy so that PackBufferData's in-place remapping of BufferViews/Buffers/Images
        // does not corrupt the cached GltfJson state for subsequent use of this loader.
        var workingCopy = GltfUtility.DeserializeModelJson(GltfJson.SerializeModelJson());

        // Ensure all buffers are loaded, then coerce byte[]?[] → byte[][] (all non-null after load)
        for (int i = 0; i < LoadedBuffers.Length; i++)
            GetOrLoadBuffer(i);
        var buffers = Array.ConvertAll(LoadedBuffers, b => b!);

        using var wb = new BinaryWriter(outputStream);
        if (ExternalResolveImage is not null)
            workingCopy.SaveBinaryModelPacked(wb, buffers, uri => ExternalResolveImage(uri).ToArray());
        else
            workingCopy.SaveBinaryModelPacked(wb, buffers, FilePath);
    }

    /// <inheritdoc/>
    Gltf IGltfLoader.GltfJson => GltfJson;
}

/// <summary>
/// Extension methods for IGltfLoader
/// </summary>
public static partial class GltfLoaderExtensions
{
    /// <summary>
    /// Gets a span of bytes for a specific glTF accessor.
    /// This method retrieves the buffer view associated with the accessor and returns a span of bytes
    /// corresponding to the accessor's data.
    /// Note: Sparse accessors are not supported in this implementation.
    /// </summary>
    /// <param name="loader">Gltf loader</param>
    /// <param name="accessorIndex">Accessor index</param>
    /// <returns>Span of bytes accessor want to access</returns>
    /// <exception cref="Exception"></exception>
    public static ReadOnlySpan<byte> GetAccessorBufferSpan(this IGltfLoader loader, int accessorIndex)
    {
        var accessor = loader.GltfJson.Accessors[accessorIndex];
        if (accessor.BufferView is null)
            throw new Exception("No bufferview assigned to accessor! Sparse accessors not supported");
        var bufferView = loader.GltfJson.BufferViews[accessor.BufferView.Value];
        var bufferViewSpan = loader.GetBufferView(accessor.BufferView.Value);

        var stride = bufferView.ByteStride ?? (int)accessor.ElementSize();
        return bufferViewSpan.Slice(accessor.ByteOffset, accessor.Count * stride);
    }

    /// <summary>
    /// Saves gltf data as a .gltf file
    /// </summary>
    /// <param name="loader">Gltf loader</param>
    /// <param name="filePath">Target file</param>
    public static void SaveAsGltf(this IGltfLoader loader, string filePath) => loader.GltfJson.SaveModel(filePath);

    /// <summary>
    /// Saves gltf data to stream
    /// </summary>
    /// <param name="loader">Gltf loader</param>
    /// <param name="stream">Output stream</param>
    public static void SaveAsGltf(this IGltfLoader loader, Stream stream) => loader.GltfJson.SaveModel(stream);
}
