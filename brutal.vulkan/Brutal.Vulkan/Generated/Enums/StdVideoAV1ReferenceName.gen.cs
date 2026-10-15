namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoAV1ReferenceName : int
    {
        /// <summary>
        ///     <c>IntraFrame</c>
        /// </summary>
        IntraFrame = 0,

        /// <summary>
        ///     <c>LastFrame</c>
        /// </summary>
        LastFrame = 1,

        /// <summary>
        ///     <c>Last2Frame</c>
        /// </summary>
        Last2Frame = 2,

        /// <summary>
        ///     <c>Last3Frame</c>
        /// </summary>
        Last3Frame = 3,

        /// <summary>
        ///     <c>GoldenFrame</c>
        /// </summary>
        GoldenFrame = 4,

        /// <summary>
        ///     <c>BwdrefFrame</c>
        /// </summary>
        BwdrefFrame = 5,

        /// <summary>
        ///     <c>Altref2Frame</c>
        /// </summary>
        Altref2Frame = 6,

        /// <summary>
        ///     <c>AltrefFrame</c>
        /// </summary>
        AltrefFrame = 7,

        /// <summary>
        ///     <c>Invalid</c>
        /// </summary>
        Invalid = 0x7FFFFFFF,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
