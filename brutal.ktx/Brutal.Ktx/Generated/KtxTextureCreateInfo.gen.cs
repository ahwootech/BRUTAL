#pragma warning disable 1591
using System.Runtime.InteropServices;

namespace Brutal.KtxApi
{
    [StructLayout(LayoutKind.Explicit, Pack = 8)]
    public unsafe partial struct KtxTextureCreateInfo
    {
        /// <summary>Internal format for the texture, e.g.,GL_RGB8. Ignored when creating aktxTexture2.</summary>
        [FieldOffset(0)]
        public uint GlInternalformat;

        /// <summary>VkFormat for texture. Ignored when creating aktxTexture1.</summary>
        [FieldOffset(4)]
        public uint VkFormat;

        /// <summary>Pointer to DFD. Used only when creating aktxTexture2 and only if vkFormat isVK_FORMAT_UNDEFINED.</summary>
        [FieldOffset(8)]
        public uint* PDfd;

        /// <summary>Width of the base level of the texture.</summary>
        [FieldOffset(16)]
        public uint BaseWidth;

        /// <summary>Height of the base level of the texture.</summary>
        [FieldOffset(20)]
        public uint BaseHeight;

        /// <summary>Depth of the base level of the texture.</summary>
        [FieldOffset(24)]
        public uint BaseDepth;

        /// <summary>Number of dimensions in the texture, 1, 2or 3.</summary>
        [FieldOffset(28)]
        public uint NumDimensions;

        /// <summary>Number of mip levels in the texture. Should be1 if @c generateMipmaps is KTX_TRUE;</summary>
        [FieldOffset(32)]
        public uint NumLevels;

        /// <summary>Number of array layers in the texture.</summary>
        [FieldOffset(36)]
        public uint NumLayers;

        /// <summary>Number of faces: 6 for cube maps, 1 otherwise.</summary>
        [FieldOffset(40)]
        public uint NumFaces;

        /// <summary>Set to KTX_TRUE if the texture is to be anarray texture. Means OpenGL will use aGL_TEXTURE_*_ARRAY target.</summary>
        [FieldOffset(44)]
        public Bool8 IsArray;

        /// <summary>Set to KTX_TRUE if mipmaps should begenerated for the texture when loadinginto a 3D API.</summary>
        [FieldOffset(45)]
        public Bool8 GenerateMipmaps;
    }
}
#pragma warning restore 1591
