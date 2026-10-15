namespace Brutal.VulkanApi.Abstractions;

public static class Presets
{
    public struct VertexInput
    {
        /// <summary>
        /// An empty vertex input
        /// </summary>
        public static readonly NativeList<VkPipelineVertexInputStateCreateInfo> None = [new()];
    }

    public struct BlendState
    {
        /// <summary>
        /// Color blend using alpha
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendStateCreateInfo> BlendColorAlpha = new(
            new VkPipelineColorBlendStateCreateInfo
            {
                AttachmentCount = 1,
                Attachments = BlendAttachment.BlendColorAlpha,
            }
        );

        /// <summary>
        /// Source color replaces destination color directly with no blending
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendStateCreateInfo> BlendNone = new(
            new VkPipelineColorBlendStateCreateInfo { AttachmentCount = 1, Attachments = BlendAttachment.BlendNone }
        );

        /// <summary>
        /// Additive blend
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendStateCreateInfo> BlendAdditive = new(
            new VkPipelineColorBlendStateCreateInfo
            {
                AttachmentCount = 1,
                Attachments = BlendAttachment.BlendColorAdditive,
            }
        );

        /// <summary>
        /// Source color is softer the brighter the destination color is, resulting components don't exceed 1
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendStateCreateInfo> BlendSoftAdditive = new(
            new VkPipelineColorBlendStateCreateInfo
            {
                AttachmentCount = 1,
                Attachments = BlendAttachment.BlendColorSoftAdditive,
            }
        );

        /// <summary>
        /// Multiplicative blend
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendStateCreateInfo> BlendMultiplicative = new(
            new VkPipelineColorBlendStateCreateInfo
            {
                AttachmentCount = 1,
                Attachments = BlendAttachment.BlendColorMultiplicative,
            }
        );
    }

    public struct BlendAttachment
    {
        /// <summary>
        /// Source color replaces destination color directly with no blending
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendAttachmentState> BlendNone = new(
            new VkPipelineColorBlendAttachmentState
            {
                BlendEnable = false,
                ColorWriteMask =
                    VkColorComponentFlags.RBit
                    | VkColorComponentFlags.GBit
                    | VkColorComponentFlags.BBit
                    | VkColorComponentFlags.ABit,
            }
        );

        /// <summary>
        /// Color blend using alpha
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendAttachmentState> BlendColorAlpha = new(
            new VkPipelineColorBlendAttachmentState
            {
                BlendEnable = true,
                SrcColorBlendFactor = VkBlendFactor.SrcAlpha,
                DstColorBlendFactor = VkBlendFactor.OneMinusSrcAlpha,
                ColorBlendOp = VkBlendOp.Add,
                SrcAlphaBlendFactor = VkBlendFactor.One,
                DstAlphaBlendFactor = VkBlendFactor.Zero,
                AlphaBlendOp = VkBlendOp.Add,
                ColorWriteMask =
                    VkColorComponentFlags.RBit
                    | VkColorComponentFlags.GBit
                    | VkColorComponentFlags.BBit
                    | VkColorComponentFlags.ABit,
            }
        );

        /// <summary>
        /// Additive blend
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendAttachmentState> BlendColorAdditive = new(
            new VkPipelineColorBlendAttachmentState
            {
                BlendEnable = true,
                SrcColorBlendFactor = VkBlendFactor.One,
                DstColorBlendFactor = VkBlendFactor.DstAlpha,
                ColorBlendOp = VkBlendOp.Add,
                SrcAlphaBlendFactor = VkBlendFactor.One,
                DstAlphaBlendFactor = VkBlendFactor.Zero,
                AlphaBlendOp = VkBlendOp.Add,
                ColorWriteMask =
                    VkColorComponentFlags.RBit
                    | VkColorComponentFlags.GBit
                    | VkColorComponentFlags.BBit
                    | VkColorComponentFlags.ABit,
            }
        );

        /// <summary>
        /// Source color is softer the brighter the destination color is, resulting components don't exceed 1
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendAttachmentState> BlendColorSoftAdditive = new(
            new VkPipelineColorBlendAttachmentState
            {
                BlendEnable = true,
                SrcColorBlendFactor = VkBlendFactor.OneMinusDstColor,
                DstColorBlendFactor = VkBlendFactor.DstAlpha,
                ColorBlendOp = VkBlendOp.Add,
                SrcAlphaBlendFactor = VkBlendFactor.One,
                DstAlphaBlendFactor = VkBlendFactor.Zero,
                AlphaBlendOp = VkBlendOp.Add,
                ColorWriteMask =
                    VkColorComponentFlags.RBit
                    | VkColorComponentFlags.GBit
                    | VkColorComponentFlags.BBit
                    | VkColorComponentFlags.ABit,
            }
        );

        /// <summary>
        /// Multiplicative blend
        /// </summary>
        public static readonly PtrOwner<VkPipelineColorBlendAttachmentState> BlendColorMultiplicative = new(
            new VkPipelineColorBlendAttachmentState
            {
                BlendEnable = true,
                SrcColorBlendFactor = VkBlendFactor.DstColor,
                DstColorBlendFactor = VkBlendFactor.Zero,
                ColorBlendOp = VkBlendOp.Add,
                SrcAlphaBlendFactor = VkBlendFactor.One,
                DstAlphaBlendFactor = VkBlendFactor.Zero,
                AlphaBlendOp = VkBlendOp.Add,
                ColorWriteMask =
                    VkColorComponentFlags.RBit
                    | VkColorComponentFlags.GBit
                    | VkColorComponentFlags.BBit
                    | VkColorComponentFlags.ABit,
            }
        );
    }

    /// <summary>
    /// Depth stencil presets
    /// </summary>
    public struct DepthStencil
    {
        /// <summary>
        /// Depth stencil with depth test and write enabled
        /// </summary>
        public static readonly PtrOwner<VkPipelineDepthStencilStateCreateInfo> DepthTestWrite = new(
            new VkPipelineDepthStencilStateCreateInfo
            {
                DepthTestEnable = true,
                DepthWriteEnable = true,
                DepthCompareOp = VkCompareOp.LessOrEqual,
                DepthBoundsTestEnable = false,
                StencilTestEnable = false,
            }
        );

        /// <summary>
        /// Depth stencil with depth test enabled but not write. Good for a transparent particle
        /// </summary>
        public static readonly PtrOwner<VkPipelineDepthStencilStateCreateInfo> DepthTestNoWrite = new(
            new VkPipelineDepthStencilStateCreateInfo
            {
                DepthTestEnable = true,
                DepthWriteEnable = false,
                DepthCompareOp = VkCompareOp.LessOrEqual,
                DepthBoundsTestEnable = false,
                StencilTestEnable = false,
            }
        );

        /// <summary>
        /// Depth stencil with depth test enabled and write enabled. Stencil test enabled and using front and back StencilOpState values.
        /// </summary>
        public static readonly PtrOwner<VkPipelineDepthStencilStateCreateInfo> DepthTestWriteStencil = new(
            new VkPipelineDepthStencilStateCreateInfo
            {
                DepthTestEnable = true,
                DepthWriteEnable = true,
                DepthCompareOp = VkCompareOp.LessOrEqual,
                DepthBoundsTestEnable = false,
                StencilTestEnable = true,
                Front = new VkStencilOpState(),
                Back = new VkStencilOpState(),
            }
        );

        /// <summary>
        /// Depth stencil with depth test and write disabled. Stencil test enabled and using front and back StencilOpState values.
        /// </summary>
        public static readonly PtrOwner<VkPipelineDepthStencilStateCreateInfo> DepthNoTestNoWriteStencil = new(
            new VkPipelineDepthStencilStateCreateInfo
            {
                DepthTestEnable = false,
                DepthWriteEnable = false,
                DepthCompareOp = VkCompareOp.LessOrEqual,
                DepthBoundsTestEnable = false,
                StencilTestEnable = true,
                Front = new VkStencilOpState(),
                Back = new VkStencilOpState(),
            }
        );

        /// <summary>
        /// Depth stencil with depth test enabled but not write. Good for a transparent particle
        /// </summary>
        public static readonly PtrOwner<VkPipelineDepthStencilStateCreateInfo> NoDepthTest = new(
            new VkPipelineDepthStencilStateCreateInfo()
        );
    }

    public struct InputAssembly
    {
        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkPipelineInputAssemblyStateCreateInfo> PointList = new(
            new VkPipelineInputAssemblyStateCreateInfo { Topology = VkPrimitiveTopology.PointList }
        );

        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkPipelineInputAssemblyStateCreateInfo> TriangleList = new(
            new VkPipelineInputAssemblyStateCreateInfo { Topology = VkPrimitiveTopology.TriangleList }
        );

        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkPipelineInputAssemblyStateCreateInfo> TriangleStrip = new(
            new VkPipelineInputAssemblyStateCreateInfo { Topology = VkPrimitiveTopology.TriangleStrip }
        );

        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkPipelineInputAssemblyStateCreateInfo> LineList = new(
            new VkPipelineInputAssemblyStateCreateInfo { Topology = VkPrimitiveTopology.LineList }
        );

        /// <summary>
        ///
        /// </summary>
        public static PtrOwner<VkPipelineInputAssemblyStateCreateInfo> LineStrip = new(
            new VkPipelineInputAssemblyStateCreateInfo { Topology = VkPrimitiveTopology.LineStrip }
        );

        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkPipelineInputAssemblyStateCreateInfo> PatchList = new(
            new VkPipelineInputAssemblyStateCreateInfo { Topology = VkPrimitiveTopology.PatchList }
        );
    }

    public struct Multisample
    {
        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkPipelineMultisampleStateCreateInfo> None = new(
            new VkPipelineMultisampleStateCreateInfo { RasterizationSamples = VkSampleCountFlags._1Bit }
        );
    }

    public struct Rasterization
    {
        /// <summary>
        ///
        /// </summary>
        public static class Fill
        {
            /// <summary>
            ///
            /// </summary>
            public static readonly PtrOwner<VkPipelineRasterizationStateCreateInfo> CullBack = new(
                new VkPipelineRasterizationStateCreateInfo { CullMode = VkCullModeFlags.BackBit, LineWidth = 1 }
            );

            /// <summary>
            ///
            /// </summary>
            public static readonly PtrOwner<VkPipelineRasterizationStateCreateInfo> CullFront = new(
                new VkPipelineRasterizationStateCreateInfo { CullMode = VkCullModeFlags.FrontBit, LineWidth = 1 }
            );

            /// <summary>
            ///
            /// </summary>
            public static readonly PtrOwner<VkPipelineRasterizationStateCreateInfo> CullNone = new(
                new VkPipelineRasterizationStateCreateInfo { CullMode = VkCullModeFlags.None, LineWidth = 1 }
            );
        }

        /// <summary>
        ///
        /// </summary>
        public static class Line
        {
            /// <summary>
            ///
            /// </summary>
            public static readonly PtrOwner<VkPipelineRasterizationStateCreateInfo> CullBack = new(
                new VkPipelineRasterizationStateCreateInfo
                {
                    CullMode = VkCullModeFlags.BackBit,
                    PolygonMode = VkPolygonMode.Line,
                    LineWidth = 1.0f,
                }
            );

            /// <summary>
            ///
            /// </summary>
            public static PtrOwner<VkPipelineRasterizationStateCreateInfo> CullFront = new(
                new VkPipelineRasterizationStateCreateInfo
                {
                    CullMode = VkCullModeFlags.FrontBit,
                    PolygonMode = VkPolygonMode.Line,
                    LineWidth = 1.0f,
                }
            );

            /// <summary>
            ///
            /// </summary>
            public static readonly PtrOwner<VkPipelineRasterizationStateCreateInfo> CullNone = new(
                new VkPipelineRasterizationStateCreateInfo
                {
                    CullMode = VkCullModeFlags.None,
                    PolygonMode = VkPolygonMode.Line,
                    LineWidth = 1.0f,
                }
            );
        }
    }

    public struct Components
    {
        /// <summary>
        ///
        /// </summary>
        public static readonly PtrOwner<VkComponentMapping> Default = new(
            new VkComponentMapping
            {
                R = VkComponentSwizzle.R,
                G = VkComponentSwizzle.G,
                B = VkComponentSwizzle.B,
                A = VkComponentSwizzle.A,
            }
        );
    }

    public struct Entrypoint
    {
        Ptr<byte> Name;

        internal unsafe Entrypoint(ReadOnlySpan<byte> name)
        {
            Name = name.AsPointer();
        }

        public static Entrypoint Main => new("main"u8);

        public static unsafe implicit operator byte*(Entrypoint entrypoint) => entrypoint.Name;
    }

    public struct ShaderStage
    {
        /// <summary>
        /// Create a shader stage with a pre-built module
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="shaderModule"></param>
        /// <returns></returns>
        public static VkPipelineShaderStageCreateInfo Make(VkShaderStageFlags stage, VkShaderModule shaderModule) =>
            new()
            {
                Name = Entrypoint.Main,
                Stage = stage,
                Module = shaderModule,
            };

        /// <summary>
        /// Make a vertex shader stage
        /// </summary>
        public static VkPipelineShaderStageCreateInfo Vertex(VkShaderModule shaderModule) =>
            Make(VkShaderStageFlags.VertexBit, shaderModule);

        /// <summary>
        /// Make a fragment shader stage
        /// </summary>
        public static VkPipelineShaderStageCreateInfo Fragment(VkShaderModule shaderModule) =>
            Make(VkShaderStageFlags.FragmentBit, shaderModule);

        /// <summary>
        /// Make a geometry shader stage
        /// </summary>
        public static VkPipelineShaderStageCreateInfo Geometry(VkShaderModule shaderModule) =>
            Make(VkShaderStageFlags.GeometryBit, shaderModule);

        /// <summary>
        /// Make a evaluation shader stage
        /// </summary>
        public static VkPipelineShaderStageCreateInfo Evaluation(VkShaderModule shaderModule) =>
            Make(VkShaderStageFlags.TessellationEvaluationBit, shaderModule);

        /// <summary>
        /// Make a control shader stage
        /// </summary>
        public static VkPipelineShaderStageCreateInfo Control(VkShaderModule shaderModule) =>
            Make(VkShaderStageFlags.TessellationControlBit, shaderModule);

        /// <summary>
        /// Make a compute shader stage
        /// </summary>
        public static VkPipelineShaderStageCreateInfo Compute(VkShaderModule shaderModule) =>
            Make(VkShaderStageFlags.ComputeBit, shaderModule);
    }

    public struct Sampler
    {
        /// <summary>
        /// Basic sampler config for a standard trilinear sampler that is clamped, with no anisotrophy
        /// </summary>
        public static VkSamplerCreateInfo SamplerLinearClamped =>
            new()
            {
                MagFilter = VkFilter.Linear,
                MinFilter = VkFilter.Linear,
                MipmapMode = VkSamplerMipmapMode.Linear,
                AddressModeU = VkSamplerAddressMode.ClampToEdge,
                AddressModeV = VkSamplerAddressMode.ClampToEdge,
                AddressModeW = VkSamplerAddressMode.ClampToEdge,
                MipLodBias = 0,
                AnisotropyEnable = false,
                MaxAnisotropy = 0,
                CompareEnable = false,
                CompareOp = VkCompareOp.Never,
                MinLod = 0,
                MaxLod = VK.LOD_CLAMP_NONE,
                BorderColor = VkBorderColor.FloatOpaqueBlack,
                UnnormalizedCoordinates = false,
            };

        /// <summary>
        /// Basic sampler config for a standard trilinear sampler that repeats, with no anisotrophy
        /// </summary>
        public static VkSamplerCreateInfo SamplerLinearRepeat =>
            new()
            {
                MagFilter = VkFilter.Linear,
                MinFilter = VkFilter.Linear,
                MipmapMode = VkSamplerMipmapMode.Linear,
                AddressModeU = VkSamplerAddressMode.Repeat,
                AddressModeV = VkSamplerAddressMode.Repeat,
                AddressModeW = VkSamplerAddressMode.Repeat,
                MipLodBias = 0,
                AnisotropyEnable = false,
                MaxAnisotropy = 0,
                CompareEnable = false,
                CompareOp = VkCompareOp.Never,
                MinLod = 0,
                MaxLod = VK.LOD_CLAMP_NONE,
                BorderColor = VkBorderColor.FloatOpaqueBlack,
                UnnormalizedCoordinates = false,
            };

        /// <summary>
        /// Basic sampler config for a standard point sampler that is clamped, with no anisotrophy
        /// </summary>
        public static VkSamplerCreateInfo SamplerPointClamped =>
            new()
            {
                MagFilter = VkFilter.Nearest,
                MinFilter = VkFilter.Nearest,
                MipmapMode = VkSamplerMipmapMode.Nearest,
                AddressModeU = VkSamplerAddressMode.ClampToEdge,
                AddressModeV = VkSamplerAddressMode.ClampToEdge,
                AddressModeW = VkSamplerAddressMode.ClampToEdge,
                MipLodBias = 0,
                AnisotropyEnable = false,
                MaxAnisotropy = 0,
                CompareEnable = false,
                CompareOp = VkCompareOp.Never,
                MinLod = 0,
                MaxLod = VK.LOD_CLAMP_NONE,
                BorderColor = VkBorderColor.FloatOpaqueBlack,
                UnnormalizedCoordinates = false,
            };
    }
}
