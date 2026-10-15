namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkGpaPerfBlockAMD.html">VkGpaPerfBlockAMD</see> - Enum providing performance counter types
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values which <i>can</i> be set in <c>VkGpaPerfCounterAMD::blockType</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_AMD_gpa_interface
    ///         typedef enum VkGpaPerfBlockAMD {
    ///             VK_GPA_PERF_BLOCK_CPF_AMD = 0,
    ///             VK_GPA_PERF_BLOCK_IA_AMD = 1,
    ///             VK_GPA_PERF_BLOCK_VGT_AMD = 2,
    ///             VK_GPA_PERF_BLOCK_PA_AMD = 3,
    ///             VK_GPA_PERF_BLOCK_SC_AMD = 4,
    ///             VK_GPA_PERF_BLOCK_SPI_AMD = 5,
    ///             VK_GPA_PERF_BLOCK_SQ_AMD = 6,
    ///             VK_GPA_PERF_BLOCK_SX_AMD = 7,
    ///             VK_GPA_PERF_BLOCK_TA_AMD = 8,
    ///             VK_GPA_PERF_BLOCK_TD_AMD = 9,
    ///             VK_GPA_PERF_BLOCK_TCP_AMD = 10,
    ///             VK_GPA_PERF_BLOCK_TCC_AMD = 11,
    ///             VK_GPA_PERF_BLOCK_TCA_AMD = 12,
    ///             VK_GPA_PERF_BLOCK_DB_AMD = 13,
    ///             VK_GPA_PERF_BLOCK_CB_AMD = 14,
    ///             VK_GPA_PERF_BLOCK_GDS_AMD = 15,
    ///             VK_GPA_PERF_BLOCK_SRBM_AMD = 16,
    ///             VK_GPA_PERF_BLOCK_GRBM_AMD = 17,
    ///             VK_GPA_PERF_BLOCK_GRBM_SE_AMD = 18,
    ///             VK_GPA_PERF_BLOCK_RLC_AMD = 19,
    ///             VK_GPA_PERF_BLOCK_DMA_AMD = 20,
    ///             VK_GPA_PERF_BLOCK_MC_AMD = 21,
    ///             VK_GPA_PERF_BLOCK_CPG_AMD = 22,
    ///             VK_GPA_PERF_BLOCK_CPC_AMD = 23,
    ///             VK_GPA_PERF_BLOCK_WD_AMD = 24,
    ///             VK_GPA_PERF_BLOCK_TCS_AMD = 25,
    ///             VK_GPA_PERF_BLOCK_ATC_AMD = 26,
    ///             VK_GPA_PERF_BLOCK_ATC_L2_AMD = 27,
    ///             VK_GPA_PERF_BLOCK_MC_VM_L2_AMD = 28,
    ///             VK_GPA_PERF_BLOCK_EA_AMD = 29,
    ///             VK_GPA_PERF_BLOCK_RPB_AMD = 30,
    ///             VK_GPA_PERF_BLOCK_RMI_AMD = 31,
    ///             VK_GPA_PERF_BLOCK_UMCCH_AMD = 32,
    ///             VK_GPA_PERF_BLOCK_GE_AMD = 33,
    ///             VK_GPA_PERF_BLOCK_GL1A_AMD = 34,
    ///             VK_GPA_PERF_BLOCK_GL1C_AMD = 35,
    ///             VK_GPA_PERF_BLOCK_GL1CG_AMD = 36,
    ///             VK_GPA_PERF_BLOCK_GL2A_AMD = 37,
    ///             VK_GPA_PERF_BLOCK_GL2C_AMD = 38,
    ///             VK_GPA_PERF_BLOCK_CHA_AMD = 39,
    ///             VK_GPA_PERF_BLOCK_CHC_AMD = 40,
    ///             VK_GPA_PERF_BLOCK_CHCG_AMD = 41,
    ///             VK_GPA_PERF_BLOCK_GUS_AMD = 42,
    ///             VK_GPA_PERF_BLOCK_GCR_AMD = 43,
    ///             VK_GPA_PERF_BLOCK_PH_AMD = 44,
    ///             VK_GPA_PERF_BLOCK_UTCL1_AMD = 45,
    ///             VK_GPA_PERF_BLOCK_GE_DIST_AMD = 46,
    ///             VK_GPA_PERF_BLOCK_GE_SE_AMD = 47,
    ///             VK_GPA_PERF_BLOCK_DF_MALL_AMD = 48,
    ///             VK_GPA_PERF_BLOCK_SQ_WGP_AMD = 49,
    ///             VK_GPA_PERF_BLOCK_PC_AMD = 50,
    ///             VK_GPA_PERF_BLOCK_GL1XA_AMD = 51,
    ///             VK_GPA_PERF_BLOCK_GL1XC_AMD = 52,
    ///             VK_GPA_PERF_BLOCK_WGS_AMD = 53,
    ///             VK_GPA_PERF_BLOCK_EACPWD_AMD = 54,
    ///             VK_GPA_PERF_BLOCK_EASE_AMD = 55,
    ///             VK_GPA_PERF_BLOCK_RLCUSER_AMD = 56,
    ///             VK_GPA_PERF_BLOCK_GE1_AMD = VK_GPA_PERF_BLOCK_GE_AMD,
    ///             VK_GPA_PERF_BLOCK_RLCLOCAL_AMD = VK_GPA_PERF_BLOCK_RLCUSER_AMD,
    ///         } VkGpaPerfBlockAMD;
    ///     </code>
    /// </remarks>
    public enum VkGpaPerfBlockAMD : int
    {
        /// <summary>
        ///     <c>CpfAMD</c>
        /// </summary>
        CpfAMD = 0,

        /// <summary>
        ///     <c>IaAMD</c>
        /// </summary>
        IaAMD = 1,

        /// <summary>
        ///     <c>VgtAMD</c>
        /// </summary>
        VgtAMD = 2,

        /// <summary>
        ///     <c>PaAMD</c>
        /// </summary>
        PaAMD = 3,

        /// <summary>
        ///     <c>ScAMD</c>
        /// </summary>
        ScAMD = 4,

        /// <summary>
        ///     <c>SpiAMD</c>
        /// </summary>
        SpiAMD = 5,

        /// <summary>
        ///     <c>SqAMD</c>
        /// </summary>
        SqAMD = 6,

        /// <summary>
        ///     <c>SxAMD</c>
        /// </summary>
        SxAMD = 7,

        /// <summary>
        ///     <c>TaAMD</c>
        /// </summary>
        TaAMD = 8,

        /// <summary>
        ///     <c>TdAMD</c>
        /// </summary>
        TdAMD = 9,

        /// <summary>
        ///     <c>TcpAMD</c>
        /// </summary>
        TcpAMD = 10,

        /// <summary>
        ///     <c>TccAMD</c>
        /// </summary>
        TccAMD = 11,

        /// <summary>
        ///     <c>TcaAMD</c>
        /// </summary>
        TcaAMD = 12,

        /// <summary>
        ///     <c>DbAMD</c>
        /// </summary>
        DbAMD = 13,

        /// <summary>
        ///     <c>CbAMD</c>
        /// </summary>
        CbAMD = 14,

        /// <summary>
        ///     <c>GdsAMD</c>
        /// </summary>
        GdsAMD = 15,

        /// <summary>
        ///     <c>SrbmAMD</c>
        /// </summary>
        SrbmAMD = 16,

        /// <summary>
        ///     <c>GrbmAMD</c>
        /// </summary>
        GrbmAMD = 17,

        /// <summary>
        ///     <c>GrbmSeAMD</c>
        /// </summary>
        GrbmSeAMD = 18,

        /// <summary>
        ///     <c>RlcAMD</c>
        /// </summary>
        RlcAMD = 19,

        /// <summary>
        ///     <c>DmaAMD</c>
        /// </summary>
        DmaAMD = 20,

        /// <summary>
        ///     <c>McAMD</c>
        /// </summary>
        McAMD = 21,

        /// <summary>
        ///     <c>CpgAMD</c>
        /// </summary>
        CpgAMD = 22,

        /// <summary>
        ///     <c>CpcAMD</c>
        /// </summary>
        CpcAMD = 23,

        /// <summary>
        ///     <c>WdAMD</c>
        /// </summary>
        WdAMD = 24,

        /// <summary>
        ///     <c>TcsAMD</c>
        /// </summary>
        TcsAMD = 25,

        /// <summary>
        ///     <c>AtcAMD</c>
        /// </summary>
        AtcAMD = 26,

        /// <summary>
        ///     <c>AtcL2AMD</c>
        /// </summary>
        AtcL2AMD = 27,

        /// <summary>
        ///     <c>McVmL2AMD</c>
        /// </summary>
        McVmL2AMD = 28,

        /// <summary>
        ///     <c>EaAMD</c>
        /// </summary>
        EaAMD = 29,

        /// <summary>
        ///     <c>RpbAMD</c>
        /// </summary>
        RpbAMD = 30,

        /// <summary>
        ///     <c>RmiAMD</c>
        /// </summary>
        RmiAMD = 31,

        /// <summary>
        ///     <c>UmcchAMD</c>
        /// </summary>
        UmcchAMD = 32,

        /// <summary>
        ///     <c>GeAMD</c>
        /// </summary>
        GeAMD = 33,

        /// <summary>
        ///     <c>Gl1AAMD</c>
        /// </summary>
        Gl1AAMD = 34,

        /// <summary>
        ///     <c>Gl1CAMD</c>
        /// </summary>
        Gl1CAMD = 35,

        /// <summary>
        ///     <c>Gl1CgAMD</c>
        /// </summary>
        Gl1CgAMD = 36,

        /// <summary>
        ///     <c>Gl2AAMD</c>
        /// </summary>
        Gl2AAMD = 37,

        /// <summary>
        ///     <c>Gl2CAMD</c>
        /// </summary>
        Gl2CAMD = 38,

        /// <summary>
        ///     <c>ChaAMD</c>
        /// </summary>
        ChaAMD = 39,

        /// <summary>
        ///     <c>ChcAMD</c>
        /// </summary>
        ChcAMD = 40,

        /// <summary>
        ///     <c>ChcgAMD</c>
        /// </summary>
        ChcgAMD = 41,

        /// <summary>
        ///     <c>GusAMD</c>
        /// </summary>
        GusAMD = 42,

        /// <summary>
        ///     <c>GcrAMD</c>
        /// </summary>
        GcrAMD = 43,

        /// <summary>
        ///     <c>PhAMD</c>
        /// </summary>
        PhAMD = 44,

        /// <summary>
        ///     <c>Utcl1AMD</c>
        /// </summary>
        Utcl1AMD = 45,

        /// <summary>
        ///     <c>GeDistAMD</c>
        /// </summary>
        GeDistAMD = 46,

        /// <summary>
        ///     <c>GeSeAMD</c>
        /// </summary>
        GeSeAMD = 47,

        /// <summary>
        ///     <c>DfMallAMD</c>
        /// </summary>
        DfMallAMD = 48,

        /// <summary>
        ///     <c>SqWgpAMD</c>
        /// </summary>
        SqWgpAMD = 49,

        /// <summary>
        ///     <c>PcAMD</c>
        /// </summary>
        PcAMD = 50,

        /// <summary>
        ///     <c>Gl1XaAMD</c>
        /// </summary>
        Gl1XaAMD = 51,

        /// <summary>
        ///     <c>Gl1XcAMD</c>
        /// </summary>
        Gl1XcAMD = 52,

        /// <summary>
        ///     <c>WgsAMD</c>
        /// </summary>
        WgsAMD = 53,

        /// <summary>
        ///     <c>EacpwdAMD</c>
        /// </summary>
        EacpwdAMD = 54,

        /// <summary>
        ///     <c>EaseAMD</c>
        /// </summary>
        EaseAMD = 55,

        /// <summary>
        ///     <c>RlcuserAMD</c>
        /// </summary>
        RlcuserAMD = 56,

        /// <summary>
        ///     <c>Ge1AMD</c>
        /// </summary>
        Ge1AMD = GeAMD,

        /// <summary>
        ///     <c>RlclocalAMD</c>
        /// </summary>
        RlclocalAMD = RlcuserAMD,

        /// <summary>
        ///     <c>MaxEnumAMD</c>
        /// </summary>
        MaxEnumAMD = 0x7FFFFFFF,
    }
}
