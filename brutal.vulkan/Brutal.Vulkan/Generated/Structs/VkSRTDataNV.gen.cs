namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkSRTDataNV.html">VkSRTDataNV</see> - Structure specifying a transform in SRT decomposition
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         :refpage: VkSRTDataNV
    ///     </para>
    ///     <para>
    ///         An acceleration structure SRT transform is defined by the structure:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_NV_ray_tracing_motion_blur
    ///         typedef struct VkSRTDataNV {
    ///             float    sx;
    ///             float    a;
    ///             float    b;
    ///             float    pvx;
    ///             float    sy;
    ///             float    c;
    ///             float    pvy;
    ///             float    sz;
    ///             float    pvz;
    ///             float    qx;
    ///             float    qy;
    ///             float    qz;
    ///             float    qw;
    ///             float    tx;
    ///             float    ty;
    ///             float    tz;
    ///         } VkSRTDataNV;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct VkSRTDataNV()
    {
        /// <summary>
        ///     <c>Sx</c> is the x component of the scale of the transform
        /// </summary>
        [FieldOffset(0)]
        public float Sx;

        /// <summary>
        ///     <c>A</c> is one component of the shear for the transform
        /// </summary>
        [FieldOffset(4)]
        public float A;

        /// <summary>
        ///     <c>B</c> is one component of the shear for the transform
        /// </summary>
        [FieldOffset(8)]
        public float B;

        /// <summary>
        ///     <c>Pvx</c> is the x component of the pivot point of the transform
        /// </summary>
        [FieldOffset(12)]
        public float Pvx;

        /// <summary>
        ///     <c>Sy</c> is the y component of the scale of the transform
        /// </summary>
        [FieldOffset(16)]
        public float Sy;

        /// <summary>
        ///     <c>C</c> is one component of the shear for the transform
        /// </summary>
        [FieldOffset(20)]
        public float C;

        /// <summary>
        ///     <c>Pvy</c> is the y component of the pivot point of the transform
        /// </summary>
        [FieldOffset(24)]
        public float Pvy;

        /// <summary>
        ///     <c>Sz</c> is the z component of the scale of the transform
        /// </summary>
        [FieldOffset(28)]
        public float Sz;

        /// <summary>
        ///     <c>Pvz</c> is the z component of the pivot point of the transform
        /// </summary>
        [FieldOffset(32)]
        public float Pvz;

        /// <summary>
        ///     <c>Qx</c> is the x component of the rotation quaternion
        /// </summary>
        [FieldOffset(36)]
        public float Qx;

        /// <summary>
        ///     <c>Qy</c> is the y component of the rotation quaternion
        /// </summary>
        [FieldOffset(40)]
        public float Qy;

        /// <summary>
        ///     <c>Qz</c> is the z component of the rotation quaternion
        /// </summary>
        [FieldOffset(44)]
        public float Qz;

        /// <summary>
        ///     <c>Qw</c> is the w component of the rotation quaternion
        /// </summary>
        [FieldOffset(48)]
        public float Qw;

        /// <summary>
        ///     <c>Tx</c> is the x component of the post-rotation translation
        /// </summary>
        [FieldOffset(52)]
        public float Tx;

        /// <summary>
        ///     <c>Ty</c> is the y component of the post-rotation translation
        /// </summary>
        [FieldOffset(56)]
        public float Ty;

        /// <summary>
        ///     <c>Tz</c> is the z component of the post-rotation translation
        /// </summary>
        [FieldOffset(60)]
        public float Tz;
    }
}
