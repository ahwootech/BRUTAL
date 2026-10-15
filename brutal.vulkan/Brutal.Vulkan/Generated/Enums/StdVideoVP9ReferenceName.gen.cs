namespace Brutal.VulkanApi
{
    ///
    public enum StdVideoVP9ReferenceName : int
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
        ///     <c>GoldenFrame</c>
        /// </summary>
        GoldenFrame = 2,

        /// <summary>
        ///     <c>AltrefFrame</c>
        /// </summary>
        AltrefFrame = 3,

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
