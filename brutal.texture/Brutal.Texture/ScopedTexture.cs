namespace Brutal.TextureApi
{
    public static partial class ITextureExtensions
    {
        /// <summary>
        /// A wrapper class for an ITexture that can be used where IDisposables can; e.g. in
        /// a using statement.
        /// When Dispose() is called on an instance of ScopedTexture the ITexture
        /// is unloaded through the <see cref="TextureLoader" /> static class.
        /// </summary>
        public ref struct ScopedTexture : IDisposable
        {
            public ScopedTexture(ITexture texture)
            {
                Texture = texture;
            }

            public ITexture? Texture { get; private set; }

            public void Dispose()
            {
                if (Texture is null)
                    return;

                TextureLoader.Unload(Texture);
                Texture = null;
            }
        }

        /// <summary>
        /// Wraps an ITexture in an IDisposable
        /// </summary>
        /// <param name="texture">The ITexture to wrap</param>
        /// <returns>The ScopedTexture wrapper</returns>
        public static ScopedTexture Using(this ITexture texture)
        {
            return new ScopedTexture(texture);
        }
    }
}
