using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using Brutal.Numerics;

#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value

namespace Brutal.GliApi;

/// <summary>
///     A library providing interop for basic functionality of the Gli texture library
/// </summary>
public static partial class Gli
{
    /// <summary>
    ///     Representation of a native gli::texture*
    /// </summary>
    [NativeMarshalling(typeof(NativeTextureMarshaller))]
    public sealed unsafe class Texture : INullable, IDisposable
    {
        internal Texture(nint impl)
        {
            Impl = impl;
            // A null handle means the native load/create failed. Accessing Levels here would
            // dereference the null native pointer, so leave the row-pitch cache empty and let
            // callers detect the failure via IsNull().
            _rowPitch = impl != 0 ? new long[Levels] : [];
        }

        ~Texture()
        {
            Release();
        }

        /// <summary>
        ///     Create an empty texture
        /// </summary>
        /// <returns>The created native texture</returns>
        public Texture()
            : this(PInvoke.createEmpty()) { }

        /// <summary>
        ///     Load a texture from a file. Returns an empty handle in case of failure.
        /// </summary>
        public Texture(string filePath)
            : this(PInvoke.load(filePath)) { }

        /// <summary>
        ///     Load a texture from memory. Returns an empty handle in case of failure.
        /// </summary>
        public Texture(ReadOnlySpan<byte> data)
            : this(PInvoke.loadFromMemory(data, data.Length)) { }

        /// <summary>
        ///     Create a texture object and allocate a texture storage for it
        /// </summary>
        /// <param name="target">Type/Shape of the texture storage_linear</param>
        /// <param name="format">Texel format</param>
        /// <param name="extent">Size of the texture: width, height and depth.</param>
        /// <param name="layers">Number of one-dimensional or two-dimensional images of identical size and format</param>
        /// <param name="faces">6 for cube map textures otherwise 1.</param>
        /// <param name="levels">Number of images in the texture mipmap chain.</param>
        /// <param name="swizzles">A mechanism to swizzle the components of a texture before they are applied according to the texture environment.</param>
        /// <returns>The created native texture</returns>
        public Texture(
            Target target,
            Format format,
            int3 extent,
            long layers,
            long faces,
            long levels,
            Swizzles swizzles
        )
            : this(PInvoke.create(target, format, extent, layers, faces, levels, swizzles)) { }

        /// <summary>
        ///     Create a texture object by sharing an existing texture storage_type from another texture instance.
        /// </summary>
        /// <remarks>
        /// This texture object is effectively a texture view where the layer, the face and the level allows identifying
        /// a specific subset of the texture storage_linear source, and where the target and format can be reinterpreted
        /// with a different compatible texture target and texture format.
        /// </remarks>
        /// <param name="texture">The texture to share the storage_type from</param>
        /// <param name="target">Type/Shape of the texture storage_linear</param>
        /// <param name="format">Texel format</param>
        /// <param name="baseLayer">The base layer of the texture instance</param>
        /// <param name="maxLayer">The max layer of the texture instance</param>
        /// <param name="baseFace">The base face of the texture instance</param>
        /// <param name="maxFace">The max face of the texture instance</param>
        /// <param name="baseLevel">The base level of the texture instance</param>
        /// <param name="maxLevel">The max level of the texture instance</param>
        /// <param name="swizzles">A mechanism to swizzle the components of a texture before they are applied according to the texture environment.</param>
        /// <returns>The created native texture</returns>
        public Texture(
            Texture texture,
            Target target,
            Format format,
            long baseLayer,
            long maxLayer,
            long baseFace,
            long maxFace,
            long baseLevel,
            long maxLevel,
            Swizzles swizzles
        )
            : this(
                PInvoke.createFromExistingSubset(
                    texture,
                    target,
                    format,
                    baseLayer,
                    maxLayer,
                    baseFace,
                    maxFace,
                    baseLevel,
                    maxLevel,
                    swizzles
                )
            ) { }

        /// <summary>
        ///     Create a texture object by sharing an existing texture storage_type from another texture instance.
        /// </summary>
        /// <remarks>
        /// This texture object is effectively a texture view where the target and format can be reinterpreted
        /// with a different compatible texture target and texture format.
        /// </remarks>
        /// <param name="texture">The texture to share the storage from</param>
        /// <param name="target">Type/Shape of the texture storage</param>
        /// <param name="format">Texel format</param>
        /// <param name="swizzles">A mechanism to swizzle the components of a texture before they are applied according to the texture environment.</param>
        /// <returns>The created native texture</returns>
        public Texture(Texture texture, Target target, Format format, Swizzles swizzles)
            : this(PInvoke.createFromExisting(texture, target, format, swizzles)) { }

        public bool IsNull() => Impl == 0;

        public void Dispose()
        {
            Release();
            GC.SuppressFinalize(this);
        }

        private void Release()
        {
            // Atomically claim the handle so that only one caller (a racing Dispose or the
            // finalizer) can ever hand it to native release, preventing a double-free.
            var impl = Interlocked.Exchange(ref Impl, 0);
            if (impl != 0)
                PInvoke.release(impl);
        }

        internal nint Impl;
        private byte* _data;
        private long _size;
        private int3 _extent;
        private Format _format;
        private long _layers;
        private long _levels;
        private long _faces;
        private Target _target;
        private int3 _blockExtent;
        private bool? _isCompressed;
        private long _blockSize;
        private readonly long[] _rowPitch;

        /// <summary>
        ///     Returns a pointer to the beginning of the texture instance data.
        /// </summary>
        public byte* Data => _data = _data != null ? _data : PInvoke.data(this);

        /// <summary>
        ///     Returns the memory size of the instance data in bytes.
        /// </summary>
        public long Size => _size = _size != 0 ? _size : PInvoke.size(this);

        /// <summary>
        /// Returns pointer to the image data for a single level, layer and face.
        /// </summary>
        /// <param name="level">Level to retrieve data for</param>
        /// <param name="layer">Layer to retrieve data for</param>
        /// <param name="face">Face to retrieve data for</param>
        /// <returns></returns>
        public byte* ImageData(int level, int layer = 0, int face = 0) => PInvoke.imagedata(this, level, layer, face);

        /// <summary>
        /// Returns the size in bytes of a specified mip level of the texture
        /// </summary>
        /// <param name="level">The level whose size you require</param>
        /// <returns>The size in bytes of the level</returns>
        public long ImageSize(int level) => PInvoke.levelsize(this, level);

        /// <summary>
        ///     Return the size of a texture instance: width, height and depth.
        /// </summary>
        public int3 Extent => _extent = _extent != default ? _extent : PInvoke.extent(this);

        /// <summary>
        /// Return the extent of a specified mip level. The value is in texels.
        /// </summary>
        /// <param name="level">mip level of extent to return</param>
        /// <returns>The extent</returns>
        public int3 ImageExtent(int level) => PInvoke.extent(this, level);

        /// <summary>
        /// Gets the row pitch for a mip level
        /// </summary>
        /// <param name="level">Level to get</param>
        /// <returns>Row pitch in bytes</returns>
        public long ImageRowPitch(int level) =>
            _rowPitch[level] = _rowPitch[level] != 0 ? _rowPitch[level] : PInvoke.rowpitch(this, level);

        /// <summary>
        /// Returns the size of a "block" in bytes. Block can be a compressed block or texel.
        /// </summary>
        public long BlockSize => _blockSize = _blockSize != 0 ? _blockSize : PInvoke.blocksize(this);

        /// <summary>
        /// Returns whether this texture is in a compressed format.
        /// </summary>
        public bool IsCompressed => _isCompressed ??= PInvoke.iscompressed(this);

        /// <summary>
        /// Returns the size of a block in texels.
        /// </summary>
        public int3 BlockExtent => _blockExtent = _blockExtent != default ? _blockExtent : PInvoke.blockextent(this);

        /// <summary>
        ///     Returns the texture instance format.
        /// </summary>
        public Format Format => _format = _format != 0 ? _format : PInvoke.format(this);

        /// <summary>
        ///     Returns the number of layers in a texture instance
        /// </summary>
        public long Layers => _layers = _layers != 0 ? _layers : PInvoke.layers(this);

        /// <summary>
        ///     Returns the number of levels in a texture instance
        /// </summary>
        public long Levels => _levels = _levels != 0 ? _levels : PInvoke.levels(this);

        /// <summary>
        ///     Returns the number of faces in a texture instance
        /// </summary>
        public long Faces => _faces = _faces != 0 ? _faces : PInvoke.faces(this);

        /// <summary>
        ///     Returns the target of a texture instance.
        /// </summary>
        public Target Target => _target = _target != 0 ? _target : PInvoke.target(this);

        /// <summary>
        ///     Save a texture storage_linear to a file.
        /// </summary>
        /// <param name="filePath"> Path for where to save the file. It must include the filename and filename extension.</param>
        /// <remarks>
        ///     The function uses the filename extension included in the path to figure out the file container to use.
        /// </remarks>
        /// <returns>False if the function fails to save the file.</returns>
        public bool Save(string filePath)
        {
            return PInvoke.save(this, filePath);
        }
    }

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    internal static partial class PInvoke
    {
        [LibraryImport("gli")]
        public static unsafe partial nint createEmpty();

        [LibraryImport("gli")]
        public static unsafe partial nint create(
            Target target,
            Format format,
            int3 extent,
            long layers,
            long faces,
            long levels,
            Swizzles swizzles
        );

        [LibraryImport("gli")]
        public static unsafe partial nint createFromExistingSubset(
            Texture texture,
            Target target,
            Format format,
            long baseLayer,
            long maxLayer,
            long baseFace,
            long maxFace,
            long baseLevel,
            long maxLevel,
            Swizzles swizzles
        );

        [LibraryImport("gli")]
        public static unsafe partial nint createFromExisting(
            Texture texture,
            Target target,
            Format format,
            Swizzles swizzles
        );

        [LibraryImport("gli", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial Bool8 save(Texture texture, string filePath);

        [LibraryImport("gli")]
        public static unsafe partial void release(nint texture);

        [LibraryImport("gli", StringMarshalling = StringMarshalling.Utf8)]
        public static unsafe partial nint load(string fileName);

        [LibraryImport("gli")]
        public static unsafe partial nint loadFromMemory(ReadOnlySpan<byte> data, long size);

        [LibraryImport("gli")]
        public static unsafe partial byte* data(Texture texture);

        [LibraryImport("gli")]
        public static unsafe partial byte* imagedata(Texture texture, long level, long layer = 0, long face = 0);

        [LibraryImport("gli")]
        public static partial long size(Texture texture);

        [LibraryImport("gli")]
        public static partial long levelsize(Texture texture, long level = 0);

        [LibraryImport("gli")]
        public static partial int3 extent(Texture texture, long level = 0);

        [LibraryImport("gli")]
        public static partial Format format(Texture texture);

        [LibraryImport("gli")]
        public static partial long layers(Texture texture);

        [LibraryImport("gli")]
        public static partial long levels(Texture texture);

        [LibraryImport("gli")]
        public static partial long faces(Texture texture);

        [LibraryImport("gli")]
        public static partial Target target(Texture texture);

        [LibraryImport("gli")]
        public static partial long rowpitch(Texture texture, long level = 0);

        [LibraryImport("gli")]
        public static partial long blocksize(Texture texture);

        [LibraryImport("gli")]
        public static partial int3 blockextent(Texture texture);

        [LibraryImport("gli")]
        public static partial Bool8 iscompressed(Texture texture);
    }

    [CustomMarshaller(
        managedType: typeof(Texture),
        marshalMode: MarshalMode.Default,
        marshallerType: typeof(NativeTextureMarshaller)
    )]
    internal static class NativeTextureMarshaller
    {
        internal static nint ConvertToUnmanaged(Texture? managed)
        {
            return managed?.Impl ?? 0;
        }

        internal static Texture ConvertToManaged(nint unmanaged)
        {
            return new Texture(unmanaged);
        }
    }
}
