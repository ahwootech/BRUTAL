using System.Text;
using System.Text.Json;

namespace Brutal.GltfApi;

/// <summary>
/// Helper functions for loading and parsing glTF models
/// </summary>
public static class GltfUtility
{
    const uint GLTFHEADER = 0x46546C67;
    const uint GLTFVERSION2 = 2;
    const uint CHUNKJSON = 0x4E4F534A;
    const uint CHUNKBIN = 0x004E4942;

    static string EmbeddedBase64 => ";base64,";
    static readonly string EmbeddedImagePrefix = "data:image/";
    static readonly string EmbeddedOctetStream = "data:application/octet-stream;base64,";
    static readonly string EmbeddedGltfBuffer = "data:application/gltf-buffer;base64,";

    static readonly string[] EmbeddedImageExtensions = ["png", "jpg", "jpeg", "ktx", "dds", "gif", "bmp"];

    private static readonly string[] EmbeddedImageExtensionPrefixes = Array.ConvertAll(
        EmbeddedImageExtensions,
        ext => $"{EmbeddedImagePrefix}{ext}{EmbeddedBase64}"
    );

    private static readonly Encoding DefaultStreamWriterEncoding = new UTF8Encoding(
        encoderShouldEmitUTF8Identifier: false,
        throwOnInvalidBytes: true
    );
    private const int DefaultStreamWriterBufferSize = 1024;

    /// <summary>
    /// Loads a <code>Schema.Gltf</code> model from a file
    /// </summary>
    /// <param name="filePath">Source file path to a gltf/glb model</param>
    /// <returns><code>Schema.Gltf</code> model</returns>
    public static Gltf LoadModel(string filePath)
    {
        var path = Path.GetFullPath(filePath);

        using (Stream stream = File.OpenRead(filePath))
        {
            return LoadModel(stream);
        }
    }

    /// <summary>
    /// Reads a <code>Schema.Gltf</code> model from a stream
    /// </summary>
    /// <param name="stream">Readable stream to a gltf/glb model</param>
    /// <returns><code>Schema.Gltf</code> model</returns>
    public static Gltf LoadModel(Stream stream)
    {
        var binaryFile = false;

        uint magic = 0;
        magic |= (uint)stream.ReadByte();
        magic |= (uint)stream.ReadByte() << 8;
        magic |= (uint)stream.ReadByte() << 16;
        magic |= (uint)stream.ReadByte() << 24;

        if (magic == GLTFHEADER)
            binaryFile = true;

        stream.Position = 0; // restart read position

        string fileData;
        if (binaryFile)
        {
            fileData = ParseBinary(stream);
        }
        else
        {
            fileData = ParseText(stream);
        }

        return DeserializeModelJson(fileData);
    }

    private static string ParseText(Stream stream)
    {
        using (var streamReader = new StreamReader(stream))
        {
            return streamReader.ReadToEnd();
        }
    }

    private static string ParseBinary(Stream stream)
    {
        using (var binaryReader = new BinaryReader(stream))
        {
            ReadBinaryHeader(binaryReader);

            var data = ReadBinaryChunk(binaryReader, CHUNKJSON);

            return Encoding.UTF8.GetString(data);
        }
    }

    private static byte[] ReadBinaryChunk(BinaryReader binaryReader, uint format)
    {
        while (true) // keep reading until EndOfFile exception
        {
            var chunkLength = binaryReader.ReadUInt32();
            if ((chunkLength & 3) != 0)
            {
                throw new InvalidDataException($"The chunk must be padded to 4 bytes: {chunkLength}");
            }

            var chunkFormat = binaryReader.ReadUInt32();

            var data = binaryReader.ReadBytes((int)chunkLength);

            if (chunkFormat == format)
                return data;
        }
    }

    private static void ReadBinaryHeader(BinaryReader binaryReader)
    {
        var magic = binaryReader.ReadUInt32();
        if (magic != GLTFHEADER)
        {
            throw new InvalidDataException($"Unexpected magic number: {magic}");
        }

        var version = binaryReader.ReadUInt32();
        if (version != GLTFVERSION2)
        {
            throw new InvalidDataException($"Unknown version number: {version}");
        }

        var length = binaryReader.ReadUInt32();
        var fileLength = binaryReader.BaseStream.Length;
        if (length != fileLength)
        {
            throw new InvalidDataException(
                $"The specified length of the file ({length}) is not equal to the actual length of the file ({fileLength})."
            );
        }
    }

    private static JsonSerializerOptions CreateSerializerOptions()
    {
        var options = new JsonSerializerOptions();
        options.Converters.Add(new JsonHelpers.Float3JsonConverter());
        options.Converters.Add(new JsonHelpers.Float4JsonConverter());
        options.Converters.Add(new JsonHelpers.FloatQuatJsonConverter());
        options.Converters.Add(new JsonHelpers.Float4X4JsonConverter());
        return options;
    }

    private static readonly JsonSerializerOptions JsonOptions = CreateSerializerOptions();

    /// <summary>
    /// Parses a JSON formatted text content
    /// </summary>
    /// <param name="fileData">JSON text content</param>
    /// <returns><code>Schema.Gltf</code> model</returns>
    public static Gltf DeserializeModelJson(string fileData)
    {
        return JsonSerializer.Deserialize<Gltf>(fileData, JsonOptions) ?? throw new NullReferenceException();
    }

    /// <summary>
    /// Serializes a <code>Schema.Gltf</code> model to text
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <returns>JSON formatted text</returns>
    public static string SerializeModelJson(this Gltf model)
    {
        return JsonSerializer.Serialize(model, JsonOptions);
    }

    private static byte[]? TryLoadBase64BinaryBufferUnchecked(Buffer buffer, string prefix)
    {
        return buffer.Uri == null || !buffer.Uri.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)
            ? null
            : Convert.FromBase64String(buffer.Uri.Substring(prefix.Length));
    }

    private static byte[] LoadBinaryBufferUnchecked(Buffer buffer, Func<string, byte[]> externalReferenceSolver)
    {
        return TryLoadBase64BinaryBufferUnchecked(buffer, EmbeddedGltfBuffer)
            ?? TryLoadBase64BinaryBufferUnchecked(buffer, EmbeddedOctetStream)
            ?? externalReferenceSolver(buffer.Uri);
    }

    private static byte[] LoadExternalFileReference(string baseFilePath, string uri)
    {
        // Load embedded glb
        if (string.IsNullOrEmpty(uri))
        {
            using (Stream stream = File.OpenRead(baseFilePath))
            using (BinaryReader binaryReader = new BinaryReader(stream))
            {
                ReadBinaryHeader(binaryReader);
                return ReadBinaryChunk(binaryReader, CHUNKBIN);
            }
        }
        // Load external reference
        return File.ReadAllBytes(Path.Combine(Path.GetDirectoryName(baseFilePath) ?? "", uri));
    }

    private static byte[] LoadBinaryBufferUnchecked(Buffer buffer, string baseFilePath)
    {
        return TryLoadBase64BinaryBufferUnchecked(buffer, EmbeddedGltfBuffer)
            ?? TryLoadBase64BinaryBufferUnchecked(buffer, EmbeddedOctetStream)
            ?? LoadExternalFileReference(baseFilePath, buffer.Uri);
    }

    /// <summary>
    /// Attempts to parse and load an embedded image from a glTF model.
    /// </summary>
    /// <param name="image">Image with embedded data</param>
    /// <param name="extension">Extension format of embedded image file</param>
    /// <returns>Byte array of image data</returns>
    /// <exception cref="ArgumentException">Invalid image format</exception>
    public static byte[] OpenEmbeddedImage(this Image image, out string? extension)
    {
        string? s = null;
        extension = null;
        for (var i = 0; i < EmbeddedImageExtensionPrefixes.Length; ++i)
        {
            if (image.Uri.StartsWith(EmbeddedImageExtensionPrefixes[i], StringComparison.OrdinalIgnoreCase))
            {
                s = image.Uri.Substring(EmbeddedImageExtensionPrefixes[i].Length);
                extension = EmbeddedImageExtensions[i];
                break;
            }
        }
        if (s is null)
            throw new ArgumentException($"Image URI '{image.Uri}' is not a valid embedded image format.");
        return Convert.FromBase64String(s);
    }

    /// <summary>
    /// Load a buffer from a glTF model by its index.
    /// This method will read the buffer data from the model's binary data or through an external reference solver.
    /// </summary>
    /// <param name="model">glTF model</param>
    /// <param name="bufferIndex">Index of buffer in glTF</param>
    /// <param name="externalReferenceSolver">Function to handle a reference for an external buffer</param>
    /// <returns>Buffer loaded as byte array</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidDataException"></exception>
    public static byte[] LoadBinaryBuffer(
        this Gltf model,
        int bufferIndex,
        Func<string, byte[]> externalReferenceSolver
    )
    {
        var buffer = model.Buffers[bufferIndex];
        if (buffer == null)
            throw new ArgumentException($"Buffer with index {bufferIndex} does not exist in the model.");
        var numArray = LoadBinaryBufferUnchecked(buffer, externalReferenceSolver);
        if (numArray.Length < buffer.ByteLength || numArray.Length - buffer.ByteLength > 3)
            throw new InvalidDataException($"The buffer length is {numArray.Length}, expected {buffer.ByteLength}");
        return numArray;
    }

    /// <summary>
    /// Load a buffer from a glTF model by its index.
    /// This method reads the buffer data from the model's binary data or external file reference.
    /// </summary>
    /// <param name="model">glTF Model</param>
    /// <param name="bufferIndex">Index of buffer</param>
    /// <param name="baseFilePath">Path of source gltf file itself, or directory URIs are assumed to be relative to</param>
    /// <returns>Buffer loaded as byte array</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="InvalidDataException"></exception>
    public static byte[] LoadBinaryBuffer(this Gltf model, int bufferIndex, string baseFilePath)
    {
        var buffer = model.Buffers[bufferIndex];
        if (buffer == null)
            throw new ArgumentException($"Buffer with index {bufferIndex} does not exist in the model.");
        var numArray = LoadBinaryBufferUnchecked(buffer, baseFilePath);
        if (numArray.Length < buffer.ByteLength || numArray.Length - buffer.ByteLength > 3)
            throw new InvalidDataException($"The buffer length is {numArray.Length}, expected {buffer.ByteLength}");
        return numArray;
    }

    /// <summary>
    /// Open an image file from a glTF model.
    /// </summary>
    /// <param name="model">glTF model</param>
    /// <param name="imageIndex">Index of image to load</param>
    /// <param name="externalReferenceSolver">Function to handle an external reference</param>
    /// <returns>Stream for image file</returns>
    public static Stream OpenImageFile(this Gltf model, int imageIndex, Func<string, byte[]> externalReferenceSolver)
    {
        var image = model.Images[imageIndex];
        if (image.BufferView.HasValue)
        {
            var bufferView = model.BufferViews[image.BufferView.Value];
            return new MemoryStream(
                model.LoadBinaryBuffer(bufferView.Buffer, externalReferenceSolver),
                bufferView.ByteOffset,
                bufferView.ByteLength
            );
        }
        return image.IsEmbedded()
            ? new MemoryStream(image.OpenEmbeddedImage(out _))
            : new MemoryStream(externalReferenceSolver(image.Uri));
    }

    /// <summary>
    /// Open an image file from a glTF model.
    /// </summary>
    /// <param name="model">glTF model</param>
    /// <param name="imageIndex">Index of image to load</param>
    /// <param name="baseFilePath">Function to handle an external reference</param>
    /// <returns>Stream for image file</returns>
    public static Stream OpenImageFile(this Gltf model, int imageIndex, string baseFilePath)
    {
        var image = model.Images[imageIndex];
        if (image.BufferView.HasValue)
        {
            var bufferView = model.BufferViews[image.BufferView.Value];
            return new MemoryStream(
                model.LoadBinaryBuffer(bufferView.Buffer, baseFilePath),
                bufferView.ByteOffset,
                bufferView.ByteLength
            );
        }
        return image.IsEmbedded()
            ? new MemoryStream(image.OpenEmbeddedImage(out _))
            : new MemoryStream(LoadExternalFileReference(baseFilePath, image.Uri));
    }

    /// <summary>
    /// Checks if an image contains embedded data in it's URI
    /// </summary>
    /// <param name="image">Image to check for embedded data</param>
    /// <returns>True if embedded data present</returns>
    public static bool IsEmbedded(this Image image)
    {
        return image.Uri.StartsWith(EmbeddedImagePrefix);
    }

    #region saving

    /// <summary>
    /// Saves a <code>Schema.Gltf</code> model to a gltf file
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="path">Destination file path</param>
    public static void SaveModel(this Gltf model, string path)
    {
        using (Stream stream = File.Create(path))
        {
            SaveModel(model, stream);
        }
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable stream
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="stream">Writable stream</param>
    public static void SaveModel(this Gltf model, Stream stream)
    {
        string fileData = SerializeModelJson(model);

        using (
            var ts = new StreamWriter(
                stream,
                DefaultStreamWriterEncoding,
                DefaultStreamWriterBufferSize,
                leaveOpen: true
            )
        )
        {
            ts.Write(fileData);
        }
    }

    /// <summary>
    /// Saves a <code>Schema.Gltf</code> model to a glb file
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="buffer">Binary buffer to embed in the file, or null</param>
    /// <param name="filePath">Destination file path</param>
    public static void SaveBinaryModel(this Gltf model, byte[] buffer, string filePath)
    {
        using (Stream stream = File.Create(filePath))
        {
            SaveBinaryModel(model, buffer, stream);
        }
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable stream
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="buffer">Binary buffer to embed in the file, or null</param>
    /// <param name="stream">Writable stream</param>
    public static void SaveBinaryModel(this Gltf model, byte[] buffer, Stream stream)
    {
        using (var wb = new BinaryWriter(stream))
        {
            SaveBinaryModel(model, buffer, wb);
        }
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable binary writer
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="buffer">Binary buffer to embed in the file, or null</param>
    /// <param name="binaryWriter">Binary Writer</param>
    public static void SaveBinaryModel(this Gltf model, byte[]? buffer, BinaryWriter binaryWriter)
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));

        var brefcount = model.Buffers?.Count(item => item.Uri == null) ?? 0;

        if (brefcount > 1)
            throw new ArgumentNullException($"{nameof(model)} multiple binary buffer references found");

        if (brefcount == 1)
        {
            if (buffer == null)
                throw new ArgumentNullException($"{nameof(buffer)} must not be null");

            var b = model.Buffers?[0] ?? throw new ArgumentNullException($"{nameof(buffer)} must not be null");

            if (b.ByteLength > buffer.Length)
                throw new ArgumentException($"{nameof(buffer)} byte size is smaller than declared");
            if ((buffer.Length - b.ByteLength) > 3)
                throw new ArgumentException($"{nameof(buffer)} byte size is larger than declared");
        }

        if (brefcount == 0 && buffer != null)
            throw new ArgumentNullException($"{nameof(buffer)} must be null");

        var jsonText = SerializeModelJson(model);
        var jsonChunk = Encoding.UTF8.GetBytes(jsonText);
        var jsonPadding = jsonChunk.Length & 3;
        if (jsonPadding != 0)
            jsonPadding = 4 - jsonPadding;

        if (buffer != null && buffer.Length == 0)
            buffer = null;
        var binPadding = buffer == null ? 0 : buffer.Length & 3;
        if (binPadding != 0)
            binPadding = 4 - binPadding;

        int fullLength = 4 + 4 + 4;

        fullLength += 8 + jsonChunk.Length + jsonPadding;
        if (buffer != null)
            fullLength += 8 + buffer.Length + binPadding;

        binaryWriter.Write(GLTFHEADER);
        binaryWriter.Write(GLTFVERSION2);
        binaryWriter.Write(fullLength);

        binaryWriter.Write(jsonChunk.Length + jsonPadding);
        binaryWriter.Write(CHUNKJSON);
        binaryWriter.Write(jsonChunk);
        for (int i = 0; i < jsonPadding; ++i)
            binaryWriter.Write((Byte)0x20);

        if (buffer != null)
        {
            binaryWriter.Write(buffer.Length + binPadding);
            binaryWriter.Write(CHUNKBIN);
            binaryWriter.Write(buffer);
            for (int i = 0; i < binPadding; ++i)
                binaryWriter.Write((Byte)0);
        }
    }

    /// <summary>
    /// Combines multiple buffers into a single buffer, remapping all BufferView byte offsets in the model.
    /// </summary>
    /// <param name="model">glTF model whose BufferViews will be remapped to the merged buffer</param>
    /// <param name="buffers">Buffer data arrays, one entry per element in model.Buffers</param>
    /// <returns>Combined buffer data with all BufferViews remapped to buffer index 0</returns>
    public static byte[] MergeBuffers(this Gltf model, byte[][] buffers)
    {
        if (buffers == null)
            throw new ArgumentNullException(nameof(buffers));
        if (model.Buffers == null || model.Buffers.Length == 0)
            return Array.Empty<byte>();
        if (buffers.Length != model.Buffers.Length)
            throw new ArgumentException(
                $"Expected {model.Buffers.Length} buffer(s), got {buffers.Length}.",
                nameof(buffers)
            );

        if (buffers.Length == 1)
        {
            model.Buffers = new[] { new Buffer { ByteLength = buffers[0].Length } };
            return buffers[0];
        }

        using var ms = new MemoryStream();
        var startOffsets = new int[buffers.Length];

        for (int i = 0; i < buffers.Length; i++)
        {
            ms.Align(4);
            startOffsets[i] = (int)ms.Position;
            ms.Write(buffers[i], 0, buffers[i].Length);
        }

        if (model.BufferViews != null)
        {
            foreach (var bv in model.BufferViews)
            {
                bv.ByteOffset += startOffsets[bv.Buffer];
                bv.Buffer = 0;
            }
        }

        var combined = ms.ToArray();
        model.Buffers = new[] { new Buffer { ByteLength = combined.Length } };
        return combined;
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable binary writer and pack all data into the model
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="outputFile">GLB output file path</param>
    /// <param name="gltfFilePath">Source file path used to load the model</param>
    /// <param name="glbBinChunk">optional GLB-stored Buffer (BIN data file). If null, then the first buffer Uri must point to a BIN file.</param>
    public static void SaveBinaryModelPacked(
        this Gltf model,
        string outputFile,
        string gltfFilePath,
        byte[]? glbBinChunk = null
    )
    {
        using (Stream stream = File.Create(outputFile))
        using (var wb = new BinaryWriter(stream))
        {
            SaveBinaryModelPacked(model, wb, gltfFilePath, glbBinChunk);
        }
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a file as a self-contained GLB, packing all resources
    /// from the provided pre-loaded buffer data. External image URIs are resolved relative to
    /// <paramref name="gltfFilePath"/> when supplied; otherwise only buffer-view and embedded images are supported.
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="outputFile">GLB output file path</param>
    /// <param name="buffers">Pre-loaded buffer data, one entry per element in model.Buffers</param>
    /// <param name="gltfFilePath">Optional source file path used to resolve external image URIs</param>
    public static void SaveBinaryModelPacked(
        this Gltf model,
        string outputFile,
        byte[][] buffers,
        string? gltfFilePath = null
    )
    {
        using (Stream stream = File.Create(outputFile))
        using (var wb = new BinaryWriter(stream))
        {
            SaveBinaryModelPacked(model, wb, buffers, gltfFilePath);
        }
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable binary writer and pack all data into the model
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="binaryWriter">Binary Writer</param>
    /// <param name="gltfFilePath">Source file path used to load the model</param>
    /// <param name="glbBinChunk">optional GLB-stored Buffer (BIN data file). If null, then the first buffer Uri must point to a BIN file.</param>
    public static void SaveBinaryModelPacked(
        this Gltf model,
        BinaryWriter binaryWriter,
        string gltfFilePath,
        byte[]? glbBinChunk = null
    )
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));

        // https://github.com/KhronosGroup/glTF/tree/master/specification/2.0#glb-stored-buffer
        // "glTF Buffer referring to GLB-stored BIN chunk, must have buffer.uri property undefined,
        // and it must be the first element of buffers array"
        var binData = PackBufferData(
            model,
            bufferIndex =>
                bufferIndex == 0 && glbBinChunk != null
                    ? glbBinChunk
                    : model.LoadBinaryBuffer(bufferIndex, gltfFilePath),
            imageIndex => model.OpenImageFile(imageIndex, gltfFilePath)
        );

        SaveBinaryModel(model, binData, binaryWriter);
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable binary writer as a self-contained GLB, packing
    /// all resources from the provided pre-loaded buffer data. External image URIs are resolved relative to
    /// <paramref name="gltfFilePath"/> when supplied; otherwise only buffer-view and embedded images are supported.
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="binaryWriter">Binary Writer</param>
    /// <param name="buffers">Pre-loaded buffer data, one entry per element in model.Buffers</param>
    /// <param name="gltfFilePath">Optional source file path used to resolve external image URIs</param>
    public static void SaveBinaryModelPacked(
        this Gltf model,
        BinaryWriter binaryWriter,
        byte[][] buffers,
        string? gltfFilePath = null
    )
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));
        if (buffers == null)
            throw new ArgumentNullException(nameof(buffers));
        if (model.Buffers != null && buffers.Length != model.Buffers.Length)
            throw new ArgumentException(
                $"Expected {model.Buffers.Length} buffer(s), got {buffers.Length}.",
                nameof(buffers)
            );

        var binData = PackBufferData(
            model,
            bufferIndex => buffers[bufferIndex],
            imageIndex =>
            {
                var image = model.Images[imageIndex];
                if (image.IsEmbedded())
                    return new MemoryStream(image.OpenEmbeddedImage(out _));
                if (gltfFilePath != null)
                    return model.OpenImageFile(imageIndex, gltfFilePath);
                throw new InvalidOperationException(
                    $"Cannot load external image '{image.Uri}' without a gltfFilePath."
                );
            }
        );

        SaveBinaryModel(model, binData, binaryWriter);
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a file as a self-contained GLB, packing all resources
    /// from the provided pre-loaded buffer data, using a custom function to resolve external image URIs.
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="outputFile">GLB output file path</param>
    /// <param name="buffers">Pre-loaded buffer data, one entry per element in model.Buffers</param>
    /// <param name="externalResolveImage">Function to load raw image bytes by URI for non-embedded images</param>
    public static void SaveBinaryModelPacked(
        this Gltf model,
        string outputFile,
        byte[][] buffers,
        Func<string, byte[]> externalResolveImage
    )
    {
        using (Stream stream = File.Create(outputFile))
        using (var wb = new BinaryWriter(stream))
        {
            SaveBinaryModelPacked(model, wb, buffers, externalResolveImage);
        }
    }

    /// <summary>
    /// Writes a <code>Schema.Gltf</code> model to a writable binary writer as a self-contained GLB, packing
    /// all resources from the provided pre-loaded buffer data, using a custom function to resolve external image URIs.
    /// </summary>
    /// <param name="model"><code>Schema.Gltf</code> model</param>
    /// <param name="binaryWriter">Binary Writer</param>
    /// <param name="buffers">Pre-loaded buffer data, one entry per element in model.Buffers</param>
    /// <param name="externalResolveImage">Function to load raw image bytes by URI for non-embedded images</param>
    public static void SaveBinaryModelPacked(
        this Gltf model,
        BinaryWriter binaryWriter,
        byte[][] buffers,
        Func<string, byte[]> externalResolveImage
    )
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));
        if (buffers == null)
            throw new ArgumentNullException(nameof(buffers));
        if (externalResolveImage == null)
            throw new ArgumentNullException(nameof(externalResolveImage));
        if (model.Buffers != null && buffers.Length != model.Buffers.Length)
            throw new ArgumentException(
                $"Expected {model.Buffers.Length} buffer(s), got {buffers.Length}.",
                nameof(buffers)
            );

        var binData = PackBufferData(
            model,
            bufferIndex => buffers[bufferIndex],
            imageIndex =>
            {
                var image = model.Images[imageIndex];
                if (image.IsEmbedded())
                    return new MemoryStream(image.OpenEmbeddedImage(out _));
                return new MemoryStream(externalResolveImage(image.Uri));
            }
        );

        SaveBinaryModel(model, binData, binaryWriter);
    }

    private static byte[]? PackBufferData(Gltf model, Func<int, byte[]> bufferLoader, Func<int, Stream> imageLoader)
    {
        using var ms = new MemoryStream();
        var bufferViews = new List<BufferView>();
        var loadedBuffers = new Dictionary<int, byte[]>();

        if (model.BufferViews != null)
        {
            foreach (var bv in model.BufferViews)
            {
                ms.Align(4);
                var byteOffset = ms.Position;

                if (!loadedBuffers.TryGetValue(bv.Buffer, out var data))
                {
                    data = bufferLoader(bv.Buffer);
                    loadedBuffers[bv.Buffer] = data;
                }

                ms.Write(data, bv.ByteOffset, bv.ByteLength);
                bv.Buffer = 0;
                bv.ByteOffset = (int)byteOffset;
                bufferViews.Add(bv);
            }
        }

        if (model.Images != null)
        {
            for (int i = 0; i < model.Images.Length; i++)
            {
                var image = model.Images[i];

                // Images already in a BufferView were packed above; skip them.
                if (image.BufferView.HasValue)
                    continue;

                ms.Align(4);
                var byteOffset = ms.Position;

                using (var imageStream = imageLoader(i))
                    imageStream.CopyTo(ms);

                // Preserve existing MimeType for images that have one (e.g. previously buffer-view images);
                // otherwise derive it from the URI.
                image.MimeType = GetMimeType(image.Uri) ?? image.MimeType;
                image.BufferView = bufferViews.Count;
                image.Uri = null;

                bufferViews.Add(
                    new BufferView
                    {
                        Buffer = 0,
                        ByteOffset = (int)byteOffset,
                        ByteLength = (int)(ms.Position - byteOffset),
                    }
                );
            }
        }

        if (!bufferViews.Any())
            return null;

        model.BufferViews = bufferViews.ToArray();
        model.Buffers = new[] { new Buffer { ByteLength = (int)ms.Length } };
        return ms.ToArray();
    }

    /// <summary>
    /// Converts self contained GLB to glTF file and associated textures and data
    /// </summary>
    /// <param name="inputFilePath">glTF binary file (.glb) to unpack</param>
    /// <param name="outputDirectoryPath">Directory where the files will be extracted</param>
    public static void Unpack(string inputFilePath, string outputDirectoryPath)
    {
        ArgumentNullException.ThrowIfNull(outputDirectoryPath);
        ArgumentNullException.ThrowIfNull(inputFilePath);

        if (!File.Exists(inputFilePath))
            throw new ArgumentException("Input file does not exists");
        if (!Directory.Exists(outputDirectoryPath))
            throw new ArgumentException("Output directory does not exists");

        string inputFileName = Path.GetFileNameWithoutExtension(inputFilePath);
        string inputDirectoryPath = Path.GetDirectoryName(inputFilePath) ?? throw new InvalidOperationException();

        var model = LoadModel(inputFilePath);
        Buffer? binBuffer = null;
        byte[]? binBufferData = null;
        if (model.Buffers != null && string.IsNullOrEmpty(model.Buffers[0].Uri))
        {
            binBuffer = model.Buffers[0];
            binBufferData = model.LoadBinaryBuffer(0, inputFilePath);
        }

        var imageBufferViewIndices = new List<int>();

        if (model.Images != null)
        {
            for (var index = 0; index < model.Images.Length; index++)
            {
                var image = model.Images[index];

                if (!string.IsNullOrEmpty(image.Uri))
                {
                    if (!image.Uri.StartsWith("data:"))
                    {
                        var sourceFilePath = Path.Combine(inputDirectoryPath, image.Uri);
                        var fileName = $"{inputFilePath}_image{index}.bin";

                        if (File.Exists(sourceFilePath))
                        {
                            var destinationFilePath = Path.Combine(outputDirectoryPath, fileName);
                            File.Copy(sourceFilePath, destinationFilePath, true);
                        }

                        image.Uri = fileName;
                    }
                }
                else if (image.BufferView.HasValue)
                {
                    var bufferView = model.BufferViews[image.BufferView.Value];
                    if (bufferView.Buffer == 0)
                    {
                        imageBufferViewIndices.Add(image.BufferView.Value);

                        var fileExtension = image.MimeType == Image.MimeTypeEnum.ImageJpeg ? "jpg" : "png";
                        var fileName = $"{inputFileName}_image{index}.{fileExtension}";

                        using (var fileStream = File.Create(Path.Combine(outputDirectoryPath, fileName)))
                        {
                            fileStream.Write(binBufferData!, bufferView.ByteOffset, bufferView.ByteLength);
                        }

                        image.BufferView = null;
                        image.MimeType = null;
                        image.Uri = fileName;
                    }
                }
            }
        }

        if (model.BufferViews != null)
        {
            var binFileName = $"{inputFileName}.bin";
            var binFilePath = Path.Combine(outputDirectoryPath, binFileName);
            var binByteLength = 0;

            var indexMap = new Dictionary<int, int>();
            var bufferViews = new List<BufferView>();
            using (var fileStream = File.Create(binFilePath))
            {
                for (var index = 0; index < model.BufferViews.Length; index++)
                {
                    if (!imageBufferViewIndices.Any(imageIndex => imageIndex == index))
                    {
                        var bufferView = model.BufferViews[index];
                        if (bufferView.Buffer == 0)
                        {
                            fileStream.Align(4);
                            var fileStreamPosition = fileStream.Position;
                            fileStream.Write(binBufferData!, bufferView.ByteOffset, bufferView.ByteLength);
                            bufferView.ByteOffset = (int)fileStreamPosition;
                        }

                        var newIndex = bufferViews.Count;
                        if (index != newIndex)
                        {
                            indexMap.Add(index, newIndex);
                        }

                        bufferViews.Add(bufferView);
                    }
                }

                binByteLength = (int)fileStream.Length;
            }

            model.BufferViews = bufferViews.ToArray();

            if (binByteLength == 0)
            {
                File.Delete(binFilePath);
                if (binBuffer != null)
                {
                    model.Buffers = model.Buffers!.Skip(1).ToArray();
                    foreach (var bufferView in model.BufferViews)
                    {
                        bufferView.Buffer--;
                    }
                }
            }
            else
            {
                binBuffer?.Uri = binFileName;
                binBuffer?.ByteLength = binByteLength;
            }

            if (model.Accessors != null)
            {
                foreach (var accessor in model.Accessors)
                {
                    if (accessor.BufferView.HasValue)
                    {
                        if (indexMap.TryGetValue(accessor.BufferView.Value, out int newIndex))
                        {
                            accessor.BufferView = newIndex;
                        }
                    }
                }
            }
        }

        if (model.Buffers != null)
        {
            for (var index = 1; index < model.Buffers.Length; index++)
            {
                var buffer = model.Buffers[index];
                if (!buffer.Uri.StartsWith("data:"))
                {
                    var sourceFilePath = Path.Combine(inputDirectoryPath, buffer.Uri);
                    var fileName = $"{inputFileName}{index}.bin";

                    if (File.Exists(sourceFilePath))
                    {
                        var destinationFilePath = Path.Combine(outputDirectoryPath, fileName);
                        File.Copy(sourceFilePath, destinationFilePath, true);
                    }

                    buffer.Uri = fileName;
                }
            }
        }

        SaveModel(model, Path.Combine(outputDirectoryPath, $"{inputFileName}.gltf"));
    }

    /// <summary>
    /// Converts a glTF file and its associated resources to a packed GLB binary file
    /// </summary>
    /// <param name="inputGltfFilePath">glTF file (.gltf) to pack</param>
    /// <param name="outputGlbFile">Path where the GLB file should be generated</param>
    public static void Pack(string inputGltfFilePath, string outputGlbFile)
    {
        if (!File.Exists(inputGltfFilePath))
            throw new ArgumentException("glTF file does not exists.", nameof(inputGltfFilePath));

        Gltf model = LoadModel(inputGltfFilePath);

        SaveBinaryModelPacked(model, outputGlbFile, inputGltfFilePath);
    }

    private static void Align(this Stream stream, int size, byte fillByte = 0)
    {
        var mod = stream.Position % size;
        if (mod == 0)
        {
            return;
        }

        for (var i = 0; i < size - mod; i++)
        {
            stream.WriteByte(fillByte);
        }
    }

    private static Image.MimeTypeEnum? GetMimeType(string uri)
    {
        if (String.IsNullOrEmpty(uri))
        {
            return null;
        }
        if (uri.StartsWith("data:image/png;base64,") || uri.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
        {
            return Image.MimeTypeEnum.ImagePng;
        }
        if (
            uri.StartsWith("data:image/jpeg;base64,")
            || uri.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
            || uri.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
        )
        {
            return Image.MimeTypeEnum.ImageJpeg;
        }
        throw new InvalidOperationException("Unable to determine mime type from uri");
    }

    #endregion
}
