#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    public partial struct KtxTexture1Handle : INullable, IDisposable
    {
        public KtxTexture1Handle(nint impl)
        {
            _impl = impl;
        }

        /// <summary>Returns whether the handle has been initialised or not.</summary>
        public bool IsNull() => _impl is 0;

        internal nint Impl => _impl;

        public void Dispose() => Release();

        public static implicit operator KtxTextureHandle(KtxTexture1Handle handle) => new KtxTextureHandle(handle.Impl);

        public unsafe ref KtxTexture1Native Ptr => ref *(KtxTexture1Native*)_impl;
        public ClassId ClassId => Ptr.ClassId;
        public unsafe KtxTextureProtected* Protected => Ptr.Protected;
        public Bool8 IsArray => Ptr.IsArray;
        public Bool8 IsCubemap => Ptr.IsCubemap;
        public Bool8 IsCompressed => Ptr.IsCompressed;
        public Bool8 GenerateMipmaps => Ptr.GenerateMipmaps;
        public uint BaseWidth => Ptr.BaseWidth;
        public uint BaseHeight => Ptr.BaseHeight;
        public uint BaseDepth => Ptr.BaseDepth;
        public uint NumDimensions => Ptr.NumDimensions;
        public uint NumLevels => Ptr.NumLevels;
        public uint NumLayers => Ptr.NumLayers;
        public uint NumFaces => Ptr.NumFaces;
        public Orientation Orientation => Ptr.Orientation;
        public ulong DataSize => Ptr.DataSize;
        public unsafe byte* PData => Ptr.PData;
        public uint GlFormat => Ptr.GlFormat;
        public uint GlInternalformat => Ptr.GlInternalformat;
        public uint GlBaseInternalformat => Ptr.GlBaseInternalformat;
        public uint GlType => Ptr.GlType;

        private void Release()
        {
            var impl = Interlocked.Exchange(ref _impl, 0);
            if (impl == 0)
                return;
            KtxTexture1.Destroy(new(impl));
        }

        private nint _impl;
    }
}
#pragma warning restore 1591
