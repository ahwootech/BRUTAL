namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDriverId.html">VkDriverId</see> - Khronos driver IDs
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Khronos driver IDs which may: be returned in
    ///         <c>VkPhysicalDeviceDriverProperties::driverID</c> are:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_2
    ///         typedef enum VkDriverId {
    ///             VK_DRIVER_ID_AMD_PROPRIETARY = 1,
    ///             VK_DRIVER_ID_AMD_OPEN_SOURCE = 2,
    ///             VK_DRIVER_ID_MESA_RADV = 3,
    ///             VK_DRIVER_ID_NVIDIA_PROPRIETARY = 4,
    ///             VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = 5,
    ///             VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = 6,
    ///             VK_DRIVER_ID_IMAGINATION_PROPRIETARY = 7,
    ///             VK_DRIVER_ID_QUALCOMM_PROPRIETARY = 8,
    ///             VK_DRIVER_ID_ARM_PROPRIETARY = 9,
    ///             VK_DRIVER_ID_GOOGLE_SWIFTSHADER = 10,
    ///             VK_DRIVER_ID_GGP_PROPRIETARY = 11,
    ///             VK_DRIVER_ID_BROADCOM_PROPRIETARY = 12,
    ///             VK_DRIVER_ID_MESA_LLVMPIPE = 13,
    ///             VK_DRIVER_ID_MOLTENVK = 14,
    ///             VK_DRIVER_ID_COREAVI_PROPRIETARY = 15,
    ///             VK_DRIVER_ID_JUICE_PROPRIETARY = 16,
    ///             VK_DRIVER_ID_VERISILICON_PROPRIETARY = 17,
    ///             VK_DRIVER_ID_MESA_TURNIP = 18,
    ///             VK_DRIVER_ID_MESA_V3DV = 19,
    ///             VK_DRIVER_ID_MESA_PANVK = 20,
    ///             VK_DRIVER_ID_SAMSUNG_PROPRIETARY = 21,
    ///             VK_DRIVER_ID_MESA_VENUS = 22,
    ///             VK_DRIVER_ID_MESA_DOZEN = 23,
    ///             VK_DRIVER_ID_MESA_NVK = 24,
    ///             VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA = 25,
    ///             VK_DRIVER_ID_MESA_HONEYKRISP = 26,
    ///             VK_DRIVER_ID_VULKAN_SC_EMULATION_ON_VULKAN = 27,
    ///             VK_DRIVER_ID_MESA_KOSMICKRISP = 28,
    ///             VK_DRIVER_ID_MESA_GFXSTREAM = 29,
    ///             VK_DRIVER_ID_APE_SOFT = 30,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_AMD_PROPRIETARY_KHR = VK_DRIVER_ID_AMD_PROPRIETARY,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_AMD_OPEN_SOURCE_KHR = VK_DRIVER_ID_AMD_OPEN_SOURCE,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_MESA_RADV_KHR = VK_DRIVER_ID_MESA_RADV,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_NVIDIA_PROPRIETARY_KHR = VK_DRIVER_ID_NVIDIA_PROPRIETARY,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS_KHR = VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA_KHR = VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_IMAGINATION_PROPRIETARY_KHR = VK_DRIVER_ID_IMAGINATION_PROPRIETARY,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_QUALCOMM_PROPRIETARY_KHR = VK_DRIVER_ID_QUALCOMM_PROPRIETARY,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_ARM_PROPRIETARY_KHR = VK_DRIVER_ID_ARM_PROPRIETARY,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_GOOGLE_SWIFTSHADER_KHR = VK_DRIVER_ID_GOOGLE_SWIFTSHADER,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_GGP_PROPRIETARY_KHR = VK_DRIVER_ID_GGP_PROPRIETARY,
    ///             // Provided by VK_KHR_driver_properties
    ///             VK_DRIVER_ID_BROADCOM_PROPRIETARY_KHR = VK_DRIVER_ID_BROADCOM_PROPRIETARY,
    ///         } VkDriverId;
    ///     </code>
    /// </remarks>
    public enum VkDriverId : int
    {
        /// <summary>
        ///     <c>AMDProprietary</c>
        /// </summary>
        AMDProprietary = 1,

        /// <summary>
        ///     <c>AMDOpenSource</c>
        /// </summary>
        AMDOpenSource = 2,

        /// <summary>
        ///     <c>MESARadv</c>
        /// </summary>
        MESARadv = 3,

        /// <summary>
        ///     <c>NvidiaProprietary</c>
        /// </summary>
        NvidiaProprietary = 4,

        /// <summary>
        ///     <c>INTELProprietaryWindows</c>
        /// </summary>
        INTELProprietaryWindows = 5,

        /// <summary>
        ///     <c>INTELOpenSourceMESA</c>
        /// </summary>
        INTELOpenSourceMESA = 6,

        /// <summary>
        ///     <c>ImaginationProprietary</c>
        /// </summary>
        ImaginationProprietary = 7,

        /// <summary>
        ///     <c>QualcommProprietary</c>
        /// </summary>
        QualcommProprietary = 8,

        /// <summary>
        ///     <c>ARMProprietary</c>
        /// </summary>
        ARMProprietary = 9,

        /// <summary>
        ///     <c>GOOGLESwiftshader</c>
        /// </summary>
        GOOGLESwiftshader = 10,

        /// <summary>
        ///     <c>GGPProprietary</c>
        /// </summary>
        GGPProprietary = 11,

        /// <summary>
        ///     <c>BroadcomProprietary</c>
        /// </summary>
        BroadcomProprietary = 12,

        /// <summary>
        ///     <c>MESALlvmpipe</c>
        /// </summary>
        MESALlvmpipe = 13,

        /// <summary>
        ///     <c>Moltenvk</c>
        /// </summary>
        Moltenvk = 14,

        /// <summary>
        ///     <c>CoreaviProprietary</c>
        /// </summary>
        CoreaviProprietary = 15,

        /// <summary>
        ///     <c>JUICEProprietary</c>
        /// </summary>
        JUICEProprietary = 16,

        /// <summary>
        ///     <c>VerisiliconProprietary</c>
        /// </summary>
        VerisiliconProprietary = 17,

        /// <summary>
        ///     <c>MESATurnip</c>
        /// </summary>
        MESATurnip = 18,

        /// <summary>
        ///     <c>MESAV3Dv</c>
        /// </summary>
        MESAV3Dv = 19,

        /// <summary>
        ///     <c>MESAPanvk</c>
        /// </summary>
        MESAPanvk = 20,

        /// <summary>
        ///     <c>SAMSUNGProprietary</c>
        /// </summary>
        SAMSUNGProprietary = 21,

        /// <summary>
        ///     <c>MESAVenus</c>
        /// </summary>
        MESAVenus = 22,

        /// <summary>
        ///     <c>MESADozen</c>
        /// </summary>
        MESADozen = 23,

        /// <summary>
        ///     <c>MESANvk</c>
        /// </summary>
        MESANvk = 24,

        /// <summary>
        ///     <c>ImaginationOpenSourceMESA</c>
        /// </summary>
        ImaginationOpenSourceMESA = 25,

        /// <summary>
        ///     <c>MESAHoneykrisp</c>
        /// </summary>
        MESAHoneykrisp = 26,

        /// <summary>
        ///     <c>VulkanScEmulationOnVulkan</c>
        /// </summary>
        VulkanScEmulationOnVulkan = 27,

        /// <summary>
        ///     <c>MESAKosmickrisp</c>
        /// </summary>
        MESAKosmickrisp = 28,

        /// <summary>
        ///     <c>MESAGfxstream</c>
        /// </summary>
        MESAGfxstream = 29,

        /// <summary>
        ///     <c>ApeSoft</c>
        /// </summary>
        ApeSoft = 30,

        /// <summary>
        ///     <c>AMDProprietaryKHR</c>
        /// </summary>
        AMDProprietaryKHR = AMDProprietary,

        /// <summary>
        ///     <c>AMDOpenSourceKHR</c>
        /// </summary>
        AMDOpenSourceKHR = AMDOpenSource,

        /// <summary>
        ///     <c>MESARadvKHR</c>
        /// </summary>
        MESARadvKHR = MESARadv,

        /// <summary>
        ///     <c>NvidiaProprietaryKHR</c>
        /// </summary>
        NvidiaProprietaryKHR = NvidiaProprietary,

        /// <summary>
        ///     <c>INTELProprietaryWindowsKHR</c>
        /// </summary>
        INTELProprietaryWindowsKHR = INTELProprietaryWindows,

        /// <summary>
        ///     <c>INTELOpenSourceMESAKHR</c>
        /// </summary>
        INTELOpenSourceMESAKHR = INTELOpenSourceMESA,

        /// <summary>
        ///     <c>ImaginationProprietaryKHR</c>
        /// </summary>
        ImaginationProprietaryKHR = ImaginationProprietary,

        /// <summary>
        ///     <c>QualcommProprietaryKHR</c>
        /// </summary>
        QualcommProprietaryKHR = QualcommProprietary,

        /// <summary>
        ///     <c>ARMProprietaryKHR</c>
        /// </summary>
        ARMProprietaryKHR = ARMProprietary,

        /// <summary>
        ///     <c>GOOGLESwiftshaderKHR</c>
        /// </summary>
        GOOGLESwiftshaderKHR = GOOGLESwiftshader,

        /// <summary>
        ///     <c>GGPProprietaryKHR</c>
        /// </summary>
        GGPProprietaryKHR = GGPProprietary,

        /// <summary>
        ///     <c>BroadcomProprietaryKHR</c>
        /// </summary>
        BroadcomProprietaryKHR = BroadcomProprietary,

        /// <summary>
        ///     <c>MaxEnum</c>
        /// </summary>
        MaxEnum = 0x7FFFFFFF,
    }
}
