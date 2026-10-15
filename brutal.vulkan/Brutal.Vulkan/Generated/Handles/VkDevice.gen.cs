namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDevice.html">VkDevice</see> - Opaque handle to a device object
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Logical devices are represented by <c>VkDevice</c> handles:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_VERSION_1_0
    ///         VK_DEFINE_HANDLE(VkDevice)
    ///     </code>
    /// </remarks>
    public readonly unsafe struct VkDevice : IVulkanHandle
    {
        /// <inheritdoc />
        public VkObjectType VkObjectType => VkObjectType.Device;

        /// <inheritdoc />
        public nint VkHandle { get; }

        /// <summary>Construct from an existing pointer</summary>
        public VkDevice(nint handle)
        {
            VkHandle = handle;
        }

        /// <inheritdoc />
        public bool IsNull()
        {
            return VkHandle == 0;
        }

        public static VkDevice NullHandle = new();

        public struct FunctionTable
        {
            public VkGetDeviceProcAddr vkGetDeviceProcAddr;
            public VkDestroyDevice vkDestroyDevice;
            public VkGetDeviceQueue vkGetDeviceQueue;
            public VkQueueSubmit vkQueueSubmit;
            public VkQueueWaitIdle vkQueueWaitIdle;
            public VkDeviceWaitIdle vkDeviceWaitIdle;
            public VkAllocateMemory vkAllocateMemory;
            public VkFreeMemory vkFreeMemory;
            public VkMapMemory vkMapMemory;
            public VkUnmapMemory vkUnmapMemory;
            public VkFlushMappedMemoryRanges vkFlushMappedMemoryRanges;
            public VkInvalidateMappedMemoryRanges vkInvalidateMappedMemoryRanges;
            public VkGetDeviceMemoryCommitment vkGetDeviceMemoryCommitment;
            public VkBindBufferMemory vkBindBufferMemory;
            public VkBindImageMemory vkBindImageMemory;
            public VkGetBufferMemoryRequirements vkGetBufferMemoryRequirements;
            public VkGetImageMemoryRequirements vkGetImageMemoryRequirements;
            public VkGetImageSparseMemoryRequirements vkGetImageSparseMemoryRequirements;
            public VkQueueBindSparse vkQueueBindSparse;
            public VkCreateFence vkCreateFence;
            public VkDestroyFence vkDestroyFence;
            public VkResetFences vkResetFences;
            public VkGetFenceStatus vkGetFenceStatus;
            public VkWaitForFences vkWaitForFences;
            public VkCreateSemaphore vkCreateSemaphore;
            public VkDestroySemaphore vkDestroySemaphore;
            public VkCreateQueryPool vkCreateQueryPool;
            public VkDestroyQueryPool vkDestroyQueryPool;
            public VkGetQueryPoolResults vkGetQueryPoolResults;
            public VkCreateBuffer vkCreateBuffer;
            public VkDestroyBuffer vkDestroyBuffer;
            public VkCreateImage vkCreateImage;
            public VkDestroyImage vkDestroyImage;
            public VkGetImageSubresourceLayout vkGetImageSubresourceLayout;
            public VkCreateImageView vkCreateImageView;
            public VkDestroyImageView vkDestroyImageView;
            public VkCreateCommandPool vkCreateCommandPool;
            public VkDestroyCommandPool vkDestroyCommandPool;
            public VkResetCommandPool vkResetCommandPool;
            public VkAllocateCommandBuffers vkAllocateCommandBuffers;
            public VkFreeCommandBuffers vkFreeCommandBuffers;
            public VkBeginCommandBuffer vkBeginCommandBuffer;
            public VkEndCommandBuffer vkEndCommandBuffer;
            public VkResetCommandBuffer vkResetCommandBuffer;
            public VkCmdCopyBuffer vkCmdCopyBuffer;
            public VkCmdCopyImage vkCmdCopyImage;
            public VkCmdCopyBufferToImage vkCmdCopyBufferToImage;
            public VkCmdCopyImageToBuffer vkCmdCopyImageToBuffer;
            public VkCmdUpdateBuffer vkCmdUpdateBuffer;
            public VkCmdFillBuffer vkCmdFillBuffer;
            public VkCmdPipelineBarrier vkCmdPipelineBarrier;
            public VkCmdBeginQuery vkCmdBeginQuery;
            public VkCmdEndQuery vkCmdEndQuery;
            public VkCmdResetQueryPool vkCmdResetQueryPool;
            public VkCmdWriteTimestamp vkCmdWriteTimestamp;
            public VkCmdCopyQueryPoolResults vkCmdCopyQueryPoolResults;
            public VkCmdExecuteCommands vkCmdExecuteCommands;
            public VkCreateEvent vkCreateEvent;
            public VkDestroyEvent vkDestroyEvent;
            public VkGetEventStatus vkGetEventStatus;
            public VkSetEvent vkSetEvent;
            public VkResetEvent vkResetEvent;
            public VkCreateBufferView vkCreateBufferView;
            public VkDestroyBufferView vkDestroyBufferView;
            public VkCreateShaderModule vkCreateShaderModule;
            public VkDestroyShaderModule vkDestroyShaderModule;
            public VkCreatePipelineCache vkCreatePipelineCache;
            public VkDestroyPipelineCache vkDestroyPipelineCache;
            public VkGetPipelineCacheData vkGetPipelineCacheData;
            public VkMergePipelineCaches vkMergePipelineCaches;
            public VkCreateComputePipelines vkCreateComputePipelines;
            public VkDestroyPipeline vkDestroyPipeline;
            public VkCreatePipelineLayout vkCreatePipelineLayout;
            public VkDestroyPipelineLayout vkDestroyPipelineLayout;
            public VkCreateSampler vkCreateSampler;
            public VkDestroySampler vkDestroySampler;
            public VkCreateDescriptorSetLayout vkCreateDescriptorSetLayout;
            public VkDestroyDescriptorSetLayout vkDestroyDescriptorSetLayout;
            public VkCreateDescriptorPool vkCreateDescriptorPool;
            public VkDestroyDescriptorPool vkDestroyDescriptorPool;
            public VkResetDescriptorPool vkResetDescriptorPool;
            public VkAllocateDescriptorSets vkAllocateDescriptorSets;
            public VkFreeDescriptorSets vkFreeDescriptorSets;
            public VkUpdateDescriptorSets vkUpdateDescriptorSets;
            public VkCmdBindPipeline vkCmdBindPipeline;
            public VkCmdBindDescriptorSets vkCmdBindDescriptorSets;
            public VkCmdClearColorImage vkCmdClearColorImage;
            public VkCmdDispatch vkCmdDispatch;
            public VkCmdDispatchIndirect vkCmdDispatchIndirect;
            public VkCmdSetEvent vkCmdSetEvent;
            public VkCmdResetEvent vkCmdResetEvent;
            public VkCmdWaitEvents vkCmdWaitEvents;
            public VkCmdPushConstants vkCmdPushConstants;
            public VkCreateGraphicsPipelines vkCreateGraphicsPipelines;
            public VkCreateFramebuffer vkCreateFramebuffer;
            public VkDestroyFramebuffer vkDestroyFramebuffer;
            public VkCreateRenderPass vkCreateRenderPass;
            public VkDestroyRenderPass vkDestroyRenderPass;
            public VkGetRenderAreaGranularity vkGetRenderAreaGranularity;
            public VkCmdSetViewport vkCmdSetViewport;
            public VkCmdSetScissor vkCmdSetScissor;
            public VkCmdSetLineWidth vkCmdSetLineWidth;
            public VkCmdSetDepthBias vkCmdSetDepthBias;
            public VkCmdSetBlendConstants vkCmdSetBlendConstants;
            public VkCmdSetDepthBounds vkCmdSetDepthBounds;
            public VkCmdSetStencilCompareMask vkCmdSetStencilCompareMask;
            public VkCmdSetStencilWriteMask vkCmdSetStencilWriteMask;
            public VkCmdSetStencilReference vkCmdSetStencilReference;
            public VkCmdBindIndexBuffer vkCmdBindIndexBuffer;
            public VkCmdBindVertexBuffers vkCmdBindVertexBuffers;
            public VkCmdDraw vkCmdDraw;
            public VkCmdDrawIndexed vkCmdDrawIndexed;
            public VkCmdDrawIndirect vkCmdDrawIndirect;
            public VkCmdDrawIndexedIndirect vkCmdDrawIndexedIndirect;
            public VkCmdBlitImage vkCmdBlitImage;
            public VkCmdClearDepthStencilImage vkCmdClearDepthStencilImage;
            public VkCmdClearAttachments vkCmdClearAttachments;
            public VkCmdResolveImage vkCmdResolveImage;
            public VkCmdBeginRenderPass vkCmdBeginRenderPass;
            public VkCmdNextSubpass vkCmdNextSubpass;
            public VkCmdEndRenderPass vkCmdEndRenderPass;
            public VkBindBufferMemory2 vkBindBufferMemory2;
            public VkBindImageMemory2 vkBindImageMemory2;
            public VkGetDeviceGroupPeerMemoryFeatures vkGetDeviceGroupPeerMemoryFeatures;
            public VkCmdSetDeviceMask vkCmdSetDeviceMask;
            public VkGetImageMemoryRequirements2 vkGetImageMemoryRequirements2;
            public VkGetBufferMemoryRequirements2 vkGetBufferMemoryRequirements2;
            public VkGetImageSparseMemoryRequirements2 vkGetImageSparseMemoryRequirements2;
            public VkTrimCommandPool vkTrimCommandPool;
            public VkGetDeviceQueue2 vkGetDeviceQueue2;
            public VkCmdDispatchBase vkCmdDispatchBase;
            public VkCreateDescriptorUpdateTemplate vkCreateDescriptorUpdateTemplate;
            public VkDestroyDescriptorUpdateTemplate vkDestroyDescriptorUpdateTemplate;
            public VkUpdateDescriptorSetWithTemplate vkUpdateDescriptorSetWithTemplate;
            public VkGetDescriptorSetLayoutSupport vkGetDescriptorSetLayoutSupport;
            public VkCreateSamplerYcbcrConversion vkCreateSamplerYcbcrConversion;
            public VkDestroySamplerYcbcrConversion vkDestroySamplerYcbcrConversion;
            public VkResetQueryPool vkResetQueryPool;
            public VkGetSemaphoreCounterValue vkGetSemaphoreCounterValue;
            public VkWaitSemaphores vkWaitSemaphores;
            public VkSignalSemaphore vkSignalSemaphore;
            public VkGetBufferDeviceAddress vkGetBufferDeviceAddress;
            public VkGetBufferOpaqueCaptureAddress vkGetBufferOpaqueCaptureAddress;
            public VkGetDeviceMemoryOpaqueCaptureAddress vkGetDeviceMemoryOpaqueCaptureAddress;
            public VkCmdDrawIndirectCount vkCmdDrawIndirectCount;
            public VkCmdDrawIndexedIndirectCount vkCmdDrawIndexedIndirectCount;
            public VkCreateRenderPass2 vkCreateRenderPass2;
            public VkCmdBeginRenderPass2 vkCmdBeginRenderPass2;
            public VkCmdNextSubpass2 vkCmdNextSubpass2;
            public VkCmdEndRenderPass2 vkCmdEndRenderPass2;
            public VkCreatePrivateDataSlot vkCreatePrivateDataSlot;
            public VkDestroyPrivateDataSlot vkDestroyPrivateDataSlot;
            public VkSetPrivateData vkSetPrivateData;
            public VkGetPrivateData vkGetPrivateData;
            public VkCmdPipelineBarrier2 vkCmdPipelineBarrier2;
            public VkCmdWriteTimestamp2 vkCmdWriteTimestamp2;
            public VkQueueSubmit2 vkQueueSubmit2;
            public VkCmdCopyBuffer2 vkCmdCopyBuffer2;
            public VkCmdCopyImage2 vkCmdCopyImage2;
            public VkCmdCopyBufferToImage2 vkCmdCopyBufferToImage2;
            public VkCmdCopyImageToBuffer2 vkCmdCopyImageToBuffer2;
            public VkGetDeviceBufferMemoryRequirements vkGetDeviceBufferMemoryRequirements;
            public VkGetDeviceImageMemoryRequirements vkGetDeviceImageMemoryRequirements;
            public VkGetDeviceImageSparseMemoryRequirements vkGetDeviceImageSparseMemoryRequirements;
            public VkCmdSetEvent2 vkCmdSetEvent2;
            public VkCmdResetEvent2 vkCmdResetEvent2;
            public VkCmdWaitEvents2 vkCmdWaitEvents2;
            public VkCmdBlitImage2 vkCmdBlitImage2;
            public VkCmdResolveImage2 vkCmdResolveImage2;
            public VkCmdBeginRendering vkCmdBeginRendering;
            public VkCmdEndRendering vkCmdEndRendering;
            public VkCmdSetCullMode vkCmdSetCullMode;
            public VkCmdSetFrontFace vkCmdSetFrontFace;
            public VkCmdSetPrimitiveTopology vkCmdSetPrimitiveTopology;
            public VkCmdSetViewportWithCount vkCmdSetViewportWithCount;
            public VkCmdSetScissorWithCount vkCmdSetScissorWithCount;
            public VkCmdBindVertexBuffers2 vkCmdBindVertexBuffers2;
            public VkCmdSetDepthTestEnable vkCmdSetDepthTestEnable;
            public VkCmdSetDepthWriteEnable vkCmdSetDepthWriteEnable;
            public VkCmdSetDepthCompareOp vkCmdSetDepthCompareOp;
            public VkCmdSetDepthBoundsTestEnable vkCmdSetDepthBoundsTestEnable;
            public VkCmdSetStencilTestEnable vkCmdSetStencilTestEnable;
            public VkCmdSetStencilOp vkCmdSetStencilOp;
            public VkCmdSetRasterizerDiscardEnable vkCmdSetRasterizerDiscardEnable;
            public VkCmdSetDepthBiasEnable vkCmdSetDepthBiasEnable;
            public VkCmdSetPrimitiveRestartEnable vkCmdSetPrimitiveRestartEnable;
            public VkMapMemory2 vkMapMemory2;
            public VkUnmapMemory2 vkUnmapMemory2;
            public VkGetDeviceImageSubresourceLayout vkGetDeviceImageSubresourceLayout;
            public VkGetImageSubresourceLayout2 vkGetImageSubresourceLayout2;
            public VkCopyMemoryToImage vkCopyMemoryToImage;
            public VkCopyImageToMemory vkCopyImageToMemory;
            public VkCopyImageToImage vkCopyImageToImage;
            public VkTransitionImageLayout vkTransitionImageLayout;
            public VkCmdPushDescriptorSet vkCmdPushDescriptorSet;
            public VkCmdPushDescriptorSetWithTemplate vkCmdPushDescriptorSetWithTemplate;
            public VkCmdBindDescriptorSets2 vkCmdBindDescriptorSets2;
            public VkCmdPushConstants2 vkCmdPushConstants2;
            public VkCmdPushDescriptorSet2 vkCmdPushDescriptorSet2;
            public VkCmdPushDescriptorSetWithTemplate2 vkCmdPushDescriptorSetWithTemplate2;
            public VkCmdSetLineStipple vkCmdSetLineStipple;
            public VkCmdBindIndexBuffer2 vkCmdBindIndexBuffer2;
            public VkGetRenderingAreaGranularity vkGetRenderingAreaGranularity;
            public VkCmdSetRenderingAttachmentLocations vkCmdSetRenderingAttachmentLocations;
            public VkCmdSetRenderingInputAttachmentIndices vkCmdSetRenderingInputAttachmentIndices;
            public VkCreateSwapchainKHR vkCreateSwapchainKHR;
            public VkDestroySwapchainKHR vkDestroySwapchainKHR;
            public VkGetSwapchainImagesKHR vkGetSwapchainImagesKHR;
            public VkAcquireNextImageKHR vkAcquireNextImageKHR;
            public VkQueuePresentKHR vkQueuePresentKHR;
            public VkGetDeviceGroupPresentCapabilitiesKHR vkGetDeviceGroupPresentCapabilitiesKHR;
            public VkGetDeviceGroupSurfacePresentModesKHR vkGetDeviceGroupSurfacePresentModesKHR;
            public VkAcquireNextImage2KHR vkAcquireNextImage2KHR;
            public VkCreateSharedSwapchainsKHR vkCreateSharedSwapchainsKHR;
            public VkCreateVideoSessionKHR vkCreateVideoSessionKHR;
            public VkDestroyVideoSessionKHR vkDestroyVideoSessionKHR;
            public VkGetVideoSessionMemoryRequirementsKHR vkGetVideoSessionMemoryRequirementsKHR;
            public VkBindVideoSessionMemoryKHR vkBindVideoSessionMemoryKHR;
            public VkCreateVideoSessionParametersKHR vkCreateVideoSessionParametersKHR;
            public VkUpdateVideoSessionParametersKHR vkUpdateVideoSessionParametersKHR;
            public VkDestroyVideoSessionParametersKHR vkDestroyVideoSessionParametersKHR;
            public VkCmdBeginVideoCodingKHR vkCmdBeginVideoCodingKHR;
            public VkCmdEndVideoCodingKHR vkCmdEndVideoCodingKHR;
            public VkCmdControlVideoCodingKHR vkCmdControlVideoCodingKHR;
            public VkCmdDecodeVideoKHR vkCmdDecodeVideoKHR;
            public VkCmdBeginRenderingKHR vkCmdBeginRenderingKHR;
            public VkCmdEndRenderingKHR vkCmdEndRenderingKHR;
            public VkGetDeviceGroupPeerMemoryFeaturesKHR vkGetDeviceGroupPeerMemoryFeaturesKHR;
            public VkCmdSetDeviceMaskKHR vkCmdSetDeviceMaskKHR;
            public VkCmdDispatchBaseKHR vkCmdDispatchBaseKHR;
            public VkTrimCommandPoolKHR vkTrimCommandPoolKHR;
            public VkGetMemoryFdKHR vkGetMemoryFdKHR;
            public VkGetMemoryFdPropertiesKHR vkGetMemoryFdPropertiesKHR;
            public VkImportSemaphoreFdKHR vkImportSemaphoreFdKHR;
            public VkGetSemaphoreFdKHR vkGetSemaphoreFdKHR;
            public VkCmdPushDescriptorSetKHR vkCmdPushDescriptorSetKHR;
            public VkCmdPushDescriptorSetWithTemplateKHR vkCmdPushDescriptorSetWithTemplateKHR;
            public VkCreateDescriptorUpdateTemplateKHR vkCreateDescriptorUpdateTemplateKHR;
            public VkDestroyDescriptorUpdateTemplateKHR vkDestroyDescriptorUpdateTemplateKHR;
            public VkUpdateDescriptorSetWithTemplateKHR vkUpdateDescriptorSetWithTemplateKHR;
            public VkCreateRenderPass2KHR vkCreateRenderPass2KHR;
            public VkCmdBeginRenderPass2KHR vkCmdBeginRenderPass2KHR;
            public VkCmdNextSubpass2KHR vkCmdNextSubpass2KHR;
            public VkCmdEndRenderPass2KHR vkCmdEndRenderPass2KHR;
            public VkGetSwapchainStatusKHR vkGetSwapchainStatusKHR;
            public VkImportFenceFdKHR vkImportFenceFdKHR;
            public VkGetFenceFdKHR vkGetFenceFdKHR;
            public VkAcquireProfilingLockKHR vkAcquireProfilingLockKHR;
            public VkReleaseProfilingLockKHR vkReleaseProfilingLockKHR;
            public VkGetImageMemoryRequirements2KHR vkGetImageMemoryRequirements2KHR;
            public VkGetBufferMemoryRequirements2KHR vkGetBufferMemoryRequirements2KHR;
            public VkGetImageSparseMemoryRequirements2KHR vkGetImageSparseMemoryRequirements2KHR;
            public VkCreateSamplerYcbcrConversionKHR vkCreateSamplerYcbcrConversionKHR;
            public VkDestroySamplerYcbcrConversionKHR vkDestroySamplerYcbcrConversionKHR;
            public VkBindBufferMemory2KHR vkBindBufferMemory2KHR;
            public VkBindImageMemory2KHR vkBindImageMemory2KHR;
            public VkGetDescriptorSetLayoutSupportKHR vkGetDescriptorSetLayoutSupportKHR;
            public VkCmdDrawIndirectCountKHR vkCmdDrawIndirectCountKHR;
            public VkCmdDrawIndexedIndirectCountKHR vkCmdDrawIndexedIndirectCountKHR;
            public VkGetSemaphoreCounterValueKHR vkGetSemaphoreCounterValueKHR;
            public VkWaitSemaphoresKHR vkWaitSemaphoresKHR;
            public VkSignalSemaphoreKHR vkSignalSemaphoreKHR;
            public VkCmdSetFragmentShadingRateKHR vkCmdSetFragmentShadingRateKHR;
            public VkCmdSetRenderingAttachmentLocationsKHR vkCmdSetRenderingAttachmentLocationsKHR;
            public VkCmdSetRenderingInputAttachmentIndicesKHR vkCmdSetRenderingInputAttachmentIndicesKHR;
            public VkWaitForPresentKHR vkWaitForPresentKHR;
            public VkGetBufferDeviceAddressKHR vkGetBufferDeviceAddressKHR;
            public VkGetBufferOpaqueCaptureAddressKHR vkGetBufferOpaqueCaptureAddressKHR;
            public VkGetDeviceMemoryOpaqueCaptureAddressKHR vkGetDeviceMemoryOpaqueCaptureAddressKHR;
            public VkCreateDeferredOperationKHR vkCreateDeferredOperationKHR;
            public VkDestroyDeferredOperationKHR vkDestroyDeferredOperationKHR;
            public VkGetDeferredOperationMaxConcurrencyKHR vkGetDeferredOperationMaxConcurrencyKHR;
            public VkGetDeferredOperationResultKHR vkGetDeferredOperationResultKHR;
            public VkDeferredOperationJoinKHR vkDeferredOperationJoinKHR;
            public VkGetPipelineExecutablePropertiesKHR vkGetPipelineExecutablePropertiesKHR;
            public VkGetPipelineExecutableStatisticsKHR vkGetPipelineExecutableStatisticsKHR;
            public VkGetPipelineExecutableInternalRepresentationsKHR vkGetPipelineExecutableInternalRepresentationsKHR;
            public VkMapMemory2KHR vkMapMemory2KHR;
            public VkUnmapMemory2KHR vkUnmapMemory2KHR;
            public VkGetEncodedVideoSessionParametersKHR vkGetEncodedVideoSessionParametersKHR;
            public VkCmdEncodeVideoKHR vkCmdEncodeVideoKHR;
            public VkCmdSetEvent2KHR vkCmdSetEvent2KHR;
            public VkCmdResetEvent2KHR vkCmdResetEvent2KHR;
            public VkCmdWaitEvents2KHR vkCmdWaitEvents2KHR;
            public VkCmdPipelineBarrier2KHR vkCmdPipelineBarrier2KHR;
            public VkCmdWriteTimestamp2KHR vkCmdWriteTimestamp2KHR;
            public VkQueueSubmit2KHR vkQueueSubmit2KHR;
            public VkCmdBindIndexBuffer3KHR vkCmdBindIndexBuffer3KHR;
            public VkCmdBindVertexBuffers3KHR vkCmdBindVertexBuffers3KHR;
            public VkCmdDrawIndirect2KHR vkCmdDrawIndirect2KHR;
            public VkCmdDrawIndexedIndirect2KHR vkCmdDrawIndexedIndirect2KHR;
            public VkCmdDispatchIndirect2KHR vkCmdDispatchIndirect2KHR;
            public VkCmdCopyMemoryKHR vkCmdCopyMemoryKHR;
            public VkCmdCopyMemoryToImageKHR vkCmdCopyMemoryToImageKHR;
            public VkCmdCopyImageToMemoryKHR vkCmdCopyImageToMemoryKHR;
            public VkCmdUpdateMemoryKHR vkCmdUpdateMemoryKHR;
            public VkCmdFillMemoryKHR vkCmdFillMemoryKHR;
            public VkCmdCopyQueryPoolResultsToMemoryKHR vkCmdCopyQueryPoolResultsToMemoryKHR;
            public VkCmdDrawIndirectCount2KHR vkCmdDrawIndirectCount2KHR;
            public VkCmdDrawIndexedIndirectCount2KHR vkCmdDrawIndexedIndirectCount2KHR;
            public VkCmdBeginConditionalRendering2EXT vkCmdBeginConditionalRendering2EXT;
            public VkCmdBindTransformFeedbackBuffers2EXT vkCmdBindTransformFeedbackBuffers2EXT;
            public VkCmdBeginTransformFeedback2EXT vkCmdBeginTransformFeedback2EXT;
            public VkCmdEndTransformFeedback2EXT vkCmdEndTransformFeedback2EXT;
            public VkCmdDrawIndirectByteCount2EXT vkCmdDrawIndirectByteCount2EXT;
            public VkCmdDrawMeshTasksIndirect2EXT vkCmdDrawMeshTasksIndirect2EXT;
            public VkCmdDrawMeshTasksIndirectCount2EXT vkCmdDrawMeshTasksIndirectCount2EXT;
            public VkCmdWriteMarkerToMemoryAMD vkCmdWriteMarkerToMemoryAMD;
            public VkCreateAccelerationStructure2KHR vkCreateAccelerationStructure2KHR;
            public VkCmdCopyBuffer2KHR vkCmdCopyBuffer2KHR;
            public VkCmdCopyImage2KHR vkCmdCopyImage2KHR;
            public VkCmdCopyBufferToImage2KHR vkCmdCopyBufferToImage2KHR;
            public VkCmdCopyImageToBuffer2KHR vkCmdCopyImageToBuffer2KHR;
            public VkCmdBlitImage2KHR vkCmdBlitImage2KHR;
            public VkCmdResolveImage2KHR vkCmdResolveImage2KHR;
            public VkCmdTraceRaysIndirect2KHR vkCmdTraceRaysIndirect2KHR;
            public VkGetDeviceBufferMemoryRequirementsKHR vkGetDeviceBufferMemoryRequirementsKHR;
            public VkGetDeviceImageMemoryRequirementsKHR vkGetDeviceImageMemoryRequirementsKHR;
            public VkGetDeviceImageSparseMemoryRequirementsKHR vkGetDeviceImageSparseMemoryRequirementsKHR;
            public VkCmdBindIndexBuffer2KHR vkCmdBindIndexBuffer2KHR;
            public VkGetRenderingAreaGranularityKHR vkGetRenderingAreaGranularityKHR;
            public VkGetDeviceImageSubresourceLayoutKHR vkGetDeviceImageSubresourceLayoutKHR;
            public VkGetImageSubresourceLayout2KHR vkGetImageSubresourceLayout2KHR;
            public VkWaitForPresent2KHR vkWaitForPresent2KHR;
            public VkCreatePipelineBinariesKHR vkCreatePipelineBinariesKHR;
            public VkDestroyPipelineBinaryKHR vkDestroyPipelineBinaryKHR;
            public VkGetPipelineKeyKHR vkGetPipelineKeyKHR;
            public VkGetPipelineBinaryDataKHR vkGetPipelineBinaryDataKHR;
            public VkReleaseCapturedPipelineDataKHR vkReleaseCapturedPipelineDataKHR;
            public VkReleaseSwapchainImagesKHR vkReleaseSwapchainImagesKHR;
            public VkCmdSetLineStippleKHR vkCmdSetLineStippleKHR;
            public VkGetCalibratedTimestampsKHR vkGetCalibratedTimestampsKHR;
            public VkCmdBindDescriptorSets2KHR vkCmdBindDescriptorSets2KHR;
            public VkCmdPushConstants2KHR vkCmdPushConstants2KHR;
            public VkCmdPushDescriptorSet2KHR vkCmdPushDescriptorSet2KHR;
            public VkCmdPushDescriptorSetWithTemplate2KHR vkCmdPushDescriptorSetWithTemplate2KHR;
            public VkCmdSetDescriptorBufferOffsets2EXT vkCmdSetDescriptorBufferOffsets2EXT;
            public VkCmdBindDescriptorBufferEmbeddedSamplers2EXT vkCmdBindDescriptorBufferEmbeddedSamplers2EXT;
            public VkCmdCopyMemoryIndirectKHR vkCmdCopyMemoryIndirectKHR;
            public VkCmdCopyMemoryToImageIndirectKHR vkCmdCopyMemoryToImageIndirectKHR;
            public VkGetDeviceFaultReportsKHR vkGetDeviceFaultReportsKHR;
            public VkGetDeviceFaultDebugInfoKHR vkGetDeviceFaultDebugInfoKHR;
            public VkCmdEndRendering2KHR vkCmdEndRendering2KHR;
            public VkDebugMarkerSetObjectTagEXT vkDebugMarkerSetObjectTagEXT;
            public VkDebugMarkerSetObjectNameEXT vkDebugMarkerSetObjectNameEXT;
            public VkCmdDebugMarkerBeginEXT vkCmdDebugMarkerBeginEXT;
            public VkCmdDebugMarkerEndEXT vkCmdDebugMarkerEndEXT;
            public VkCmdDebugMarkerInsertEXT vkCmdDebugMarkerInsertEXT;
            public VkCmdBindTransformFeedbackBuffersEXT vkCmdBindTransformFeedbackBuffersEXT;
            public VkCmdBeginTransformFeedbackEXT vkCmdBeginTransformFeedbackEXT;
            public VkCmdEndTransformFeedbackEXT vkCmdEndTransformFeedbackEXT;
            public VkCmdBeginQueryIndexedEXT vkCmdBeginQueryIndexedEXT;
            public VkCmdEndQueryIndexedEXT vkCmdEndQueryIndexedEXT;
            public VkCmdDrawIndirectByteCountEXT vkCmdDrawIndirectByteCountEXT;
            public VkCreateCuModuleNVX vkCreateCuModuleNVX;
            public VkCreateCuFunctionNVX vkCreateCuFunctionNVX;
            public VkDestroyCuModuleNVX vkDestroyCuModuleNVX;
            public VkDestroyCuFunctionNVX vkDestroyCuFunctionNVX;
            public VkCmdCuLaunchKernelNVX vkCmdCuLaunchKernelNVX;
            public VkGetImageViewHandleNVX vkGetImageViewHandleNVX;
            public VkGetImageViewHandle64NVX vkGetImageViewHandle64NVX;
            public VkGetImageViewAddressNVX vkGetImageViewAddressNVX;
            public VkGetDeviceCombinedImageSamplerIndexNVX vkGetDeviceCombinedImageSamplerIndexNVX;
            public VkCmdDrawIndirectCountAMD vkCmdDrawIndirectCountAMD;
            public VkCmdDrawIndexedIndirectCountAMD vkCmdDrawIndexedIndirectCountAMD;
            public VkGetShaderInfoAMD vkGetShaderInfoAMD;
            public VkCmdBeginConditionalRenderingEXT vkCmdBeginConditionalRenderingEXT;
            public VkCmdEndConditionalRenderingEXT vkCmdEndConditionalRenderingEXT;
            public VkCmdSetViewportWScalingNV vkCmdSetViewportWScalingNV;
            public VkDisplayPowerControlEXT vkDisplayPowerControlEXT;
            public VkRegisterDeviceEventEXT vkRegisterDeviceEventEXT;
            public VkRegisterDisplayEventEXT vkRegisterDisplayEventEXT;
            public VkGetSwapchainCounterEXT vkGetSwapchainCounterEXT;
            public VkGetRefreshCycleDurationGOOGLE vkGetRefreshCycleDurationGOOGLE;
            public VkGetPastPresentationTimingGOOGLE vkGetPastPresentationTimingGOOGLE;
            public VkCmdSetDiscardRectangleEXT vkCmdSetDiscardRectangleEXT;
            public VkCmdSetDiscardRectangleEnableEXT vkCmdSetDiscardRectangleEnableEXT;
            public VkCmdSetDiscardRectangleModeEXT vkCmdSetDiscardRectangleModeEXT;
            public VkSetHdrMetadataEXT vkSetHdrMetadataEXT;
            public VkSetDebugUtilsObjectNameEXT vkSetDebugUtilsObjectNameEXT;
            public VkSetDebugUtilsObjectTagEXT vkSetDebugUtilsObjectTagEXT;
            public VkQueueBeginDebugUtilsLabelEXT vkQueueBeginDebugUtilsLabelEXT;
            public VkQueueEndDebugUtilsLabelEXT vkQueueEndDebugUtilsLabelEXT;
            public VkQueueInsertDebugUtilsLabelEXT vkQueueInsertDebugUtilsLabelEXT;
            public VkCmdBeginDebugUtilsLabelEXT vkCmdBeginDebugUtilsLabelEXT;
            public VkCmdEndDebugUtilsLabelEXT vkCmdEndDebugUtilsLabelEXT;
            public VkCmdInsertDebugUtilsLabelEXT vkCmdInsertDebugUtilsLabelEXT;
            public VkCreateGpaSessionAMD vkCreateGpaSessionAMD;
            public VkDestroyGpaSessionAMD vkDestroyGpaSessionAMD;
            public VkSetGpaDeviceClockModeAMD vkSetGpaDeviceClockModeAMD;
            public VkGetGpaDeviceClockInfoAMD vkGetGpaDeviceClockInfoAMD;
            public VkCmdBeginGpaSessionAMD vkCmdBeginGpaSessionAMD;
            public VkCmdEndGpaSessionAMD vkCmdEndGpaSessionAMD;
            public VkCmdBeginGpaSampleAMD vkCmdBeginGpaSampleAMD;
            public VkCmdEndGpaSampleAMD vkCmdEndGpaSampleAMD;
            public VkGetGpaSessionStatusAMD vkGetGpaSessionStatusAMD;
            public VkGetGpaSessionResultsAMD vkGetGpaSessionResultsAMD;
            public VkResetGpaSessionAMD vkResetGpaSessionAMD;
            public VkCmdCopyGpaSessionResultsAMD vkCmdCopyGpaSessionResultsAMD;
            public VkWriteSamplerDescriptorsEXT vkWriteSamplerDescriptorsEXT;
            public VkWriteResourceDescriptorsEXT vkWriteResourceDescriptorsEXT;
            public VkCmdBindSamplerHeapEXT vkCmdBindSamplerHeapEXT;
            public VkCmdBindResourceHeapEXT vkCmdBindResourceHeapEXT;
            public VkCmdPushDataEXT vkCmdPushDataEXT;
            public VkGetImageOpaqueCaptureDataEXT vkGetImageOpaqueCaptureDataEXT;
            public VkRegisterCustomBorderColorEXT vkRegisterCustomBorderColorEXT;
            public VkUnregisterCustomBorderColorEXT vkUnregisterCustomBorderColorEXT;
            public VkGetTensorOpaqueCaptureDataARM vkGetTensorOpaqueCaptureDataARM;
            public VkCmdSetSampleLocationsEXT vkCmdSetSampleLocationsEXT;
            public VkGetImageDrmFormatModifierPropertiesEXT vkGetImageDrmFormatModifierPropertiesEXT;
            public VkCreateValidationCacheEXT vkCreateValidationCacheEXT;
            public VkDestroyValidationCacheEXT vkDestroyValidationCacheEXT;
            public VkMergeValidationCachesEXT vkMergeValidationCachesEXT;
            public VkGetValidationCacheDataEXT vkGetValidationCacheDataEXT;
            public VkCmdBindShadingRateImageNV vkCmdBindShadingRateImageNV;
            public VkCmdSetViewportShadingRatePaletteNV vkCmdSetViewportShadingRatePaletteNV;
            public VkCmdSetCoarseSampleOrderNV vkCmdSetCoarseSampleOrderNV;
            public VkCreateAccelerationStructureNV vkCreateAccelerationStructureNV;
            public VkDestroyAccelerationStructureNV vkDestroyAccelerationStructureNV;
            public VkGetAccelerationStructureMemoryRequirementsNV vkGetAccelerationStructureMemoryRequirementsNV;
            public VkBindAccelerationStructureMemoryNV vkBindAccelerationStructureMemoryNV;
            public VkCmdBuildAccelerationStructureNV vkCmdBuildAccelerationStructureNV;
            public VkCmdCopyAccelerationStructureNV vkCmdCopyAccelerationStructureNV;
            public VkCmdTraceRaysNV vkCmdTraceRaysNV;
            public VkCreateRayTracingPipelinesNV vkCreateRayTracingPipelinesNV;
            public VkGetRayTracingShaderGroupHandlesKHR vkGetRayTracingShaderGroupHandlesKHR;
            public VkGetRayTracingShaderGroupHandlesNV vkGetRayTracingShaderGroupHandlesNV;
            public VkGetAccelerationStructureHandleNV vkGetAccelerationStructureHandleNV;
            public VkCmdWriteAccelerationStructuresPropertiesNV vkCmdWriteAccelerationStructuresPropertiesNV;
            public VkCompileDeferredNV vkCompileDeferredNV;
            public VkGetMemoryHostPointerPropertiesEXT vkGetMemoryHostPointerPropertiesEXT;
            public VkCmdWriteBufferMarkerAMD vkCmdWriteBufferMarkerAMD;
            public VkCmdWriteBufferMarker2AMD vkCmdWriteBufferMarker2AMD;
            public VkGetCalibratedTimestampsEXT vkGetCalibratedTimestampsEXT;
            public VkCmdDrawMeshTasksNV vkCmdDrawMeshTasksNV;
            public VkCmdDrawMeshTasksIndirectNV vkCmdDrawMeshTasksIndirectNV;
            public VkCmdDrawMeshTasksIndirectCountNV vkCmdDrawMeshTasksIndirectCountNV;
            public VkCmdSetExclusiveScissorEnableNV vkCmdSetExclusiveScissorEnableNV;
            public VkCmdSetExclusiveScissorNV vkCmdSetExclusiveScissorNV;
            public VkCmdSetCheckpointNV vkCmdSetCheckpointNV;
            public VkGetQueueCheckpointDataNV vkGetQueueCheckpointDataNV;
            public VkGetQueueCheckpointData2NV vkGetQueueCheckpointData2NV;
            public VkSetSwapchainPresentTimingQueueSizeEXT vkSetSwapchainPresentTimingQueueSizeEXT;
            public VkGetSwapchainTimingPropertiesEXT vkGetSwapchainTimingPropertiesEXT;
            public VkGetSwapchainTimeDomainPropertiesEXT vkGetSwapchainTimeDomainPropertiesEXT;
            public VkGetPastPresentationTimingEXT vkGetPastPresentationTimingEXT;
            public VkInitializePerformanceApiINTEL vkInitializePerformanceApiINTEL;
            public VkUninitializePerformanceApiINTEL vkUninitializePerformanceApiINTEL;
            public VkCmdSetPerformanceMarkerINTEL vkCmdSetPerformanceMarkerINTEL;
            public VkCmdSetPerformanceStreamMarkerINTEL vkCmdSetPerformanceStreamMarkerINTEL;
            public VkCmdSetPerformanceOverrideINTEL vkCmdSetPerformanceOverrideINTEL;
            public VkAcquirePerformanceConfigurationINTEL vkAcquirePerformanceConfigurationINTEL;
            public VkReleasePerformanceConfigurationINTEL vkReleasePerformanceConfigurationINTEL;
            public VkQueueSetPerformanceConfigurationINTEL vkQueueSetPerformanceConfigurationINTEL;
            public VkGetPerformanceParameterINTEL vkGetPerformanceParameterINTEL;
            public VkSetLocalDimmingAMD vkSetLocalDimmingAMD;
            public VkGetBufferDeviceAddressEXT vkGetBufferDeviceAddressEXT;
            public VkCmdSetLineStippleEXT vkCmdSetLineStippleEXT;
            public VkResetQueryPoolEXT vkResetQueryPoolEXT;
            public VkCmdSetCullModeEXT vkCmdSetCullModeEXT;
            public VkCmdSetFrontFaceEXT vkCmdSetFrontFaceEXT;
            public VkCmdSetPrimitiveTopologyEXT vkCmdSetPrimitiveTopologyEXT;
            public VkCmdSetViewportWithCountEXT vkCmdSetViewportWithCountEXT;
            public VkCmdSetScissorWithCountEXT vkCmdSetScissorWithCountEXT;
            public VkCmdBindVertexBuffers2EXT vkCmdBindVertexBuffers2EXT;
            public VkCmdSetDepthTestEnableEXT vkCmdSetDepthTestEnableEXT;
            public VkCmdSetDepthWriteEnableEXT vkCmdSetDepthWriteEnableEXT;
            public VkCmdSetDepthCompareOpEXT vkCmdSetDepthCompareOpEXT;
            public VkCmdSetDepthBoundsTestEnableEXT vkCmdSetDepthBoundsTestEnableEXT;
            public VkCmdSetStencilTestEnableEXT vkCmdSetStencilTestEnableEXT;
            public VkCmdSetStencilOpEXT vkCmdSetStencilOpEXT;
            public VkCopyMemoryToImageEXT vkCopyMemoryToImageEXT;
            public VkCopyImageToMemoryEXT vkCopyImageToMemoryEXT;
            public VkCopyImageToImageEXT vkCopyImageToImageEXT;
            public VkTransitionImageLayoutEXT vkTransitionImageLayoutEXT;
            public VkGetImageSubresourceLayout2EXT vkGetImageSubresourceLayout2EXT;
            public VkReleaseSwapchainImagesEXT vkReleaseSwapchainImagesEXT;
            public VkGetGeneratedCommandsMemoryRequirementsNV vkGetGeneratedCommandsMemoryRequirementsNV;
            public VkCmdPreprocessGeneratedCommandsNV vkCmdPreprocessGeneratedCommandsNV;
            public VkCmdExecuteGeneratedCommandsNV vkCmdExecuteGeneratedCommandsNV;
            public VkCmdBindPipelineShaderGroupNV vkCmdBindPipelineShaderGroupNV;
            public VkCreateIndirectCommandsLayoutNV vkCreateIndirectCommandsLayoutNV;
            public VkDestroyIndirectCommandsLayoutNV vkDestroyIndirectCommandsLayoutNV;
            public VkCmdSetDepthBias2EXT vkCmdSetDepthBias2EXT;
            public VkCreatePrivateDataSlotEXT vkCreatePrivateDataSlotEXT;
            public VkDestroyPrivateDataSlotEXT vkDestroyPrivateDataSlotEXT;
            public VkSetPrivateDataEXT vkSetPrivateDataEXT;
            public VkGetPrivateDataEXT vkGetPrivateDataEXT;
            public VkQueueSetPerfHintQCOM vkQueueSetPerfHintQCOM;
            public VkCmdDispatchTileQCOM vkCmdDispatchTileQCOM;
            public VkCmdBeginPerTileExecutionQCOM vkCmdBeginPerTileExecutionQCOM;
            public VkCmdEndPerTileExecutionQCOM vkCmdEndPerTileExecutionQCOM;
            public VkSetLatencySleepModeLegacyNV vkSetLatencySleepModeLegacyNV;
            public VkLatencySleepLegacyNV vkLatencySleepLegacyNV;
            public VkSetLatencyMarkerLegacyNV vkSetLatencyMarkerLegacyNV;
            public VkGetLatencyTimingsLegacyNV vkGetLatencyTimingsLegacyNV;
            public VkQueueNotifyOutOfBandLegacyNV vkQueueNotifyOutOfBandLegacyNV;
            public VkGetSleepStatusLegacyNV vkGetSleepStatusLegacyNV;
            public VkShutdownLatencyDeviceLegacyNV vkShutdownLatencyDeviceLegacyNV;
            public VkGetDescriptorSetLayoutSizeEXT vkGetDescriptorSetLayoutSizeEXT;
            public VkGetDescriptorSetLayoutBindingOffsetEXT vkGetDescriptorSetLayoutBindingOffsetEXT;
            public VkGetDescriptorEXT vkGetDescriptorEXT;
            public VkCmdBindDescriptorBuffersEXT vkCmdBindDescriptorBuffersEXT;
            public VkCmdSetDescriptorBufferOffsetsEXT vkCmdSetDescriptorBufferOffsetsEXT;
            public VkCmdBindDescriptorBufferEmbeddedSamplersEXT vkCmdBindDescriptorBufferEmbeddedSamplersEXT;
            public VkGetBufferOpaqueCaptureDescriptorDataEXT vkGetBufferOpaqueCaptureDescriptorDataEXT;
            public VkGetImageOpaqueCaptureDescriptorDataEXT vkGetImageOpaqueCaptureDescriptorDataEXT;
            public VkGetImageViewOpaqueCaptureDescriptorDataEXT vkGetImageViewOpaqueCaptureDescriptorDataEXT;
            public VkGetSamplerOpaqueCaptureDescriptorDataEXT vkGetSamplerOpaqueCaptureDescriptorDataEXT;
            public VkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT;
            public VkCmdSetFragmentShadingRateEnumNV vkCmdSetFragmentShadingRateEnumNV;
            public VkGetDeviceFaultInfoEXT vkGetDeviceFaultInfoEXT;
            public VkCmdSetVertexInputEXT vkCmdSetVertexInputEXT;
            public VkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;
            public VkCmdSubpassShadingHUAWEI vkCmdSubpassShadingHUAWEI;
            public VkCmdBindInvocationMaskHUAWEI vkCmdBindInvocationMaskHUAWEI;
            public VkGetMemoryRemoteAddressNV vkGetMemoryRemoteAddressNV;
            public VkGetPipelinePropertiesEXT vkGetPipelinePropertiesEXT;
            public VkCmdSetPatchControlPointsEXT vkCmdSetPatchControlPointsEXT;
            public VkCmdSetRasterizerDiscardEnableEXT vkCmdSetRasterizerDiscardEnableEXT;
            public VkCmdSetDepthBiasEnableEXT vkCmdSetDepthBiasEnableEXT;
            public VkCmdSetLogicOpEXT vkCmdSetLogicOpEXT;
            public VkCmdSetPrimitiveRestartEnableEXT vkCmdSetPrimitiveRestartEnableEXT;
            public VkCmdSetColorWriteEnableEXT vkCmdSetColorWriteEnableEXT;
            public VkCmdDrawMultiEXT vkCmdDrawMultiEXT;
            public VkCmdDrawMultiIndexedEXT vkCmdDrawMultiIndexedEXT;
            public VkCreateMicromapEXT vkCreateMicromapEXT;
            public VkDestroyMicromapEXT vkDestroyMicromapEXT;
            public VkCmdBuildMicromapsEXT vkCmdBuildMicromapsEXT;
            public VkBuildMicromapsEXT vkBuildMicromapsEXT;
            public VkCopyMicromapEXT vkCopyMicromapEXT;
            public VkCopyMicromapToMemoryEXT vkCopyMicromapToMemoryEXT;
            public VkCopyMemoryToMicromapEXT vkCopyMemoryToMicromapEXT;
            public VkWriteMicromapsPropertiesEXT vkWriteMicromapsPropertiesEXT;
            public VkCmdCopyMicromapEXT vkCmdCopyMicromapEXT;
            public VkCmdCopyMicromapToMemoryEXT vkCmdCopyMicromapToMemoryEXT;
            public VkCmdCopyMemoryToMicromapEXT vkCmdCopyMemoryToMicromapEXT;
            public VkCmdWriteMicromapsPropertiesEXT vkCmdWriteMicromapsPropertiesEXT;
            public VkGetDeviceMicromapCompatibilityEXT vkGetDeviceMicromapCompatibilityEXT;
            public VkGetMicromapBuildSizesEXT vkGetMicromapBuildSizesEXT;
            public VkCmdDrawClusterHUAWEI vkCmdDrawClusterHUAWEI;
            public VkCmdDrawClusterIndirectHUAWEI vkCmdDrawClusterIndirectHUAWEI;
            public VkSetDeviceMemoryPriorityEXT vkSetDeviceMemoryPriorityEXT;
            public VkCmdSetDispatchParametersARM vkCmdSetDispatchParametersARM;
            public VkGetDescriptorSetLayoutHostMappingInfoVALVE vkGetDescriptorSetLayoutHostMappingInfoVALVE;
            public VkGetDescriptorSetHostMappingVALVE vkGetDescriptorSetHostMappingVALVE;
            public VkCmdCopyMemoryIndirectNV vkCmdCopyMemoryIndirectNV;
            public VkCmdCopyMemoryToImageIndirectNV vkCmdCopyMemoryToImageIndirectNV;
            public VkCmdDecompressMemoryNV vkCmdDecompressMemoryNV;
            public VkCmdDecompressMemoryIndirectCountNV vkCmdDecompressMemoryIndirectCountNV;
            public VkGetPipelineIndirectMemoryRequirementsNV vkGetPipelineIndirectMemoryRequirementsNV;
            public VkCmdUpdatePipelineIndirectBufferNV vkCmdUpdatePipelineIndirectBufferNV;
            public VkGetPipelineIndirectDeviceAddressNV vkGetPipelineIndirectDeviceAddressNV;
            public VkCmdSetDepthClampEnableEXT vkCmdSetDepthClampEnableEXT;
            public VkCmdSetPolygonModeEXT vkCmdSetPolygonModeEXT;
            public VkCmdSetRasterizationSamplesEXT vkCmdSetRasterizationSamplesEXT;
            public VkCmdSetSampleMaskEXT vkCmdSetSampleMaskEXT;
            public VkCmdSetAlphaToCoverageEnableEXT vkCmdSetAlphaToCoverageEnableEXT;
            public VkCmdSetAlphaToOneEnableEXT vkCmdSetAlphaToOneEnableEXT;
            public VkCmdSetLogicOpEnableEXT vkCmdSetLogicOpEnableEXT;
            public VkCmdSetColorBlendEnableEXT vkCmdSetColorBlendEnableEXT;
            public VkCmdSetColorBlendEquationEXT vkCmdSetColorBlendEquationEXT;
            public VkCmdSetColorWriteMaskEXT vkCmdSetColorWriteMaskEXT;
            public VkCmdSetTessellationDomainOriginEXT vkCmdSetTessellationDomainOriginEXT;
            public VkCmdSetRasterizationStreamEXT vkCmdSetRasterizationStreamEXT;
            public VkCmdSetConservativeRasterizationModeEXT vkCmdSetConservativeRasterizationModeEXT;
            public VkCmdSetExtraPrimitiveOverestimationSizeEXT vkCmdSetExtraPrimitiveOverestimationSizeEXT;
            public VkCmdSetDepthClipEnableEXT vkCmdSetDepthClipEnableEXT;
            public VkCmdSetSampleLocationsEnableEXT vkCmdSetSampleLocationsEnableEXT;
            public VkCmdSetColorBlendAdvancedEXT vkCmdSetColorBlendAdvancedEXT;
            public VkCmdSetProvokingVertexModeEXT vkCmdSetProvokingVertexModeEXT;
            public VkCmdSetLineRasterizationModeEXT vkCmdSetLineRasterizationModeEXT;
            public VkCmdSetLineStippleEnableEXT vkCmdSetLineStippleEnableEXT;
            public VkCmdSetDepthClipNegativeOneToOneEXT vkCmdSetDepthClipNegativeOneToOneEXT;
            public VkCmdSetViewportWScalingEnableNV vkCmdSetViewportWScalingEnableNV;
            public VkCmdSetViewportSwizzleNV vkCmdSetViewportSwizzleNV;
            public VkCmdSetCoverageToColorEnableNV vkCmdSetCoverageToColorEnableNV;
            public VkCmdSetCoverageToColorLocationNV vkCmdSetCoverageToColorLocationNV;
            public VkCmdSetCoverageModulationModeNV vkCmdSetCoverageModulationModeNV;
            public VkCmdSetCoverageModulationTableEnableNV vkCmdSetCoverageModulationTableEnableNV;
            public VkCmdSetCoverageModulationTableNV vkCmdSetCoverageModulationTableNV;
            public VkCmdSetShadingRateImageEnableNV vkCmdSetShadingRateImageEnableNV;
            public VkCmdSetRepresentativeFragmentTestEnableNV vkCmdSetRepresentativeFragmentTestEnableNV;
            public VkCmdSetCoverageReductionModeNV vkCmdSetCoverageReductionModeNV;
            public VkCreateTensorARM vkCreateTensorARM;
            public VkDestroyTensorARM vkDestroyTensorARM;
            public VkCreateTensorViewARM vkCreateTensorViewARM;
            public VkDestroyTensorViewARM vkDestroyTensorViewARM;
            public VkGetTensorMemoryRequirementsARM vkGetTensorMemoryRequirementsARM;
            public VkBindTensorMemoryARM vkBindTensorMemoryARM;
            public VkGetDeviceTensorMemoryRequirementsARM vkGetDeviceTensorMemoryRequirementsARM;
            public VkCmdCopyTensorARM vkCmdCopyTensorARM;
            public VkGetTensorOpaqueCaptureDescriptorDataARM vkGetTensorOpaqueCaptureDescriptorDataARM;
            public VkGetTensorViewOpaqueCaptureDescriptorDataARM vkGetTensorViewOpaqueCaptureDescriptorDataARM;
            public VkGetShaderModuleIdentifierEXT vkGetShaderModuleIdentifierEXT;
            public VkGetShaderModuleCreateInfoIdentifierEXT vkGetShaderModuleCreateInfoIdentifierEXT;
            public VkCreateOpticalFlowSessionNV vkCreateOpticalFlowSessionNV;
            public VkDestroyOpticalFlowSessionNV vkDestroyOpticalFlowSessionNV;
            public VkBindOpticalFlowSessionImageNV vkBindOpticalFlowSessionImageNV;
            public VkCmdOpticalFlowExecuteNV vkCmdOpticalFlowExecuteNV;
            public VkAntiLagUpdateAMD vkAntiLagUpdateAMD;
            public VkCreateShadersEXT vkCreateShadersEXT;
            public VkDestroyShaderEXT vkDestroyShaderEXT;
            public VkGetShaderBinaryDataEXT vkGetShaderBinaryDataEXT;
            public VkCmdBindShadersEXT vkCmdBindShadersEXT;
            public VkCmdSetDepthClampRangeEXT vkCmdSetDepthClampRangeEXT;
            public VkGetFramebufferTilePropertiesQCOM vkGetFramebufferTilePropertiesQCOM;
            public VkGetDynamicRenderingTilePropertiesQCOM vkGetDynamicRenderingTilePropertiesQCOM;
            public VkConvertCooperativeVectorMatrixNV vkConvertCooperativeVectorMatrixNV;
            public VkCmdConvertCooperativeVectorMatrixNV vkCmdConvertCooperativeVectorMatrixNV;
            public VkSetLatencySleepModeNV vkSetLatencySleepModeNV;
            public VkLatencySleepNV vkLatencySleepNV;
            public VkSetLatencyMarkerNV vkSetLatencyMarkerNV;
            public VkGetLatencyTimingsNV vkGetLatencyTimingsNV;
            public VkQueueNotifyOutOfBandNV vkQueueNotifyOutOfBandNV;
            public VkCreateDataGraphPipelinesARM vkCreateDataGraphPipelinesARM;
            public VkCreateDataGraphPipelineSessionARM vkCreateDataGraphPipelineSessionARM;
            public VkGetDataGraphPipelineSessionBindPointRequirementsARM vkGetDataGraphPipelineSessionBindPointRequirementsARM;
            public VkGetDataGraphPipelineSessionMemoryRequirementsARM vkGetDataGraphPipelineSessionMemoryRequirementsARM;
            public VkBindDataGraphPipelineSessionMemoryARM vkBindDataGraphPipelineSessionMemoryARM;
            public VkDestroyDataGraphPipelineSessionARM vkDestroyDataGraphPipelineSessionARM;
            public VkCmdDispatchDataGraphARM vkCmdDispatchDataGraphARM;
            public VkGetDataGraphPipelineAvailablePropertiesARM vkGetDataGraphPipelineAvailablePropertiesARM;
            public VkGetDataGraphPipelinePropertiesARM vkGetDataGraphPipelinePropertiesARM;
            public VkCmdSetAttachmentFeedbackLoopEnableEXT vkCmdSetAttachmentFeedbackLoopEnableEXT;
            public VkCmdBindTileMemoryQCOM vkCmdBindTileMemoryQCOM;
            public VkCmdDecompressMemoryEXT vkCmdDecompressMemoryEXT;
            public VkCmdDecompressMemoryIndirectCountEXT vkCmdDecompressMemoryIndirectCountEXT;
            public VkCreateExternalComputeQueueNV vkCreateExternalComputeQueueNV;
            public VkDestroyExternalComputeQueueNV vkDestroyExternalComputeQueueNV;
            public VkGetExternalComputeQueueDataNV vkGetExternalComputeQueueDataNV;
            public VkGetClusterAccelerationStructureBuildSizesNV vkGetClusterAccelerationStructureBuildSizesNV;
            public VkCmdBuildClusterAccelerationStructureIndirectNV vkCmdBuildClusterAccelerationStructureIndirectNV;
            public VkGetPartitionedAccelerationStructuresBuildSizesNV vkGetPartitionedAccelerationStructuresBuildSizesNV;
            public VkCmdBuildPartitionedAccelerationStructuresNV vkCmdBuildPartitionedAccelerationStructuresNV;
            public VkGetGeneratedCommandsMemoryRequirementsEXT vkGetGeneratedCommandsMemoryRequirementsEXT;
            public VkCmdPreprocessGeneratedCommandsEXT vkCmdPreprocessGeneratedCommandsEXT;
            public VkCmdExecuteGeneratedCommandsEXT vkCmdExecuteGeneratedCommandsEXT;
            public VkCreateIndirectCommandsLayoutEXT vkCreateIndirectCommandsLayoutEXT;
            public VkDestroyIndirectCommandsLayoutEXT vkDestroyIndirectCommandsLayoutEXT;
            public VkCreateIndirectExecutionSetEXT vkCreateIndirectExecutionSetEXT;
            public VkDestroyIndirectExecutionSetEXT vkDestroyIndirectExecutionSetEXT;
            public VkUpdateIndirectExecutionSetPipelineEXT vkUpdateIndirectExecutionSetPipelineEXT;
            public VkUpdateIndirectExecutionSetShaderEXT vkUpdateIndirectExecutionSetShaderEXT;
            public VkCreateShaderInstrumentationARM vkCreateShaderInstrumentationARM;
            public VkDestroyShaderInstrumentationARM vkDestroyShaderInstrumentationARM;
            public VkCmdBeginShaderInstrumentationARM vkCmdBeginShaderInstrumentationARM;
            public VkCmdEndShaderInstrumentationARM vkCmdEndShaderInstrumentationARM;
            public VkGetShaderInstrumentationValuesARM vkGetShaderInstrumentationValuesARM;
            public VkClearShaderInstrumentationMetricsARM vkClearShaderInstrumentationMetricsARM;
            public VkCmdEndRendering2EXT vkCmdEndRendering2EXT;
            public VkCmdBeginCustomResolveEXT vkCmdBeginCustomResolveEXT;
            public VkCmdSetComputeOccupancyPriorityNV vkCmdSetComputeOccupancyPriorityNV;
            public VkCmdSetPrimitiveRestartIndexEXT vkCmdSetPrimitiveRestartIndexEXT;
            public VkCreateAccelerationStructureKHR vkCreateAccelerationStructureKHR;
            public VkDestroyAccelerationStructureKHR vkDestroyAccelerationStructureKHR;
            public VkCmdBuildAccelerationStructuresKHR vkCmdBuildAccelerationStructuresKHR;
            public VkCmdBuildAccelerationStructuresIndirectKHR vkCmdBuildAccelerationStructuresIndirectKHR;
            public VkBuildAccelerationStructuresKHR vkBuildAccelerationStructuresKHR;
            public VkCopyAccelerationStructureKHR vkCopyAccelerationStructureKHR;
            public VkCopyAccelerationStructureToMemoryKHR vkCopyAccelerationStructureToMemoryKHR;
            public VkCopyMemoryToAccelerationStructureKHR vkCopyMemoryToAccelerationStructureKHR;
            public VkWriteAccelerationStructuresPropertiesKHR vkWriteAccelerationStructuresPropertiesKHR;
            public VkCmdCopyAccelerationStructureKHR vkCmdCopyAccelerationStructureKHR;
            public VkCmdCopyAccelerationStructureToMemoryKHR vkCmdCopyAccelerationStructureToMemoryKHR;
            public VkCmdCopyMemoryToAccelerationStructureKHR vkCmdCopyMemoryToAccelerationStructureKHR;
            public VkGetAccelerationStructureDeviceAddressKHR vkGetAccelerationStructureDeviceAddressKHR;
            public VkCmdWriteAccelerationStructuresPropertiesKHR vkCmdWriteAccelerationStructuresPropertiesKHR;
            public VkGetDeviceAccelerationStructureCompatibilityKHR vkGetDeviceAccelerationStructureCompatibilityKHR;
            public VkGetAccelerationStructureBuildSizesKHR vkGetAccelerationStructureBuildSizesKHR;
            public VkCmdTraceRaysKHR vkCmdTraceRaysKHR;
            public VkCreateRayTracingPipelinesKHR vkCreateRayTracingPipelinesKHR;
            public VkGetRayTracingCaptureReplayShaderGroupHandlesKHR vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;
            public VkCmdTraceRaysIndirectKHR vkCmdTraceRaysIndirectKHR;
            public VkGetRayTracingShaderGroupStackSizeKHR vkGetRayTracingShaderGroupStackSizeKHR;
            public VkCmdSetRayTracingPipelineStackSizeKHR vkCmdSetRayTracingPipelineStackSizeKHR;
            public VkCmdDrawMeshTasksEXT vkCmdDrawMeshTasksEXT;
            public VkCmdDrawMeshTasksIndirectEXT vkCmdDrawMeshTasksIndirectEXT;
            public VkCmdDrawMeshTasksIndirectCountEXT vkCmdDrawMeshTasksIndirectCountEXT;
            public VkGetMemoryWin32HandleKHR vkGetMemoryWin32HandleKHR;
            public VkGetMemoryWin32HandlePropertiesKHR vkGetMemoryWin32HandlePropertiesKHR;
            public VkImportSemaphoreWin32HandleKHR vkImportSemaphoreWin32HandleKHR;
            public VkGetSemaphoreWin32HandleKHR vkGetSemaphoreWin32HandleKHR;
            public VkImportFenceWin32HandleKHR vkImportFenceWin32HandleKHR;
            public VkGetFenceWin32HandleKHR vkGetFenceWin32HandleKHR;
            public VkGetMemoryWin32HandleNV vkGetMemoryWin32HandleNV;
            public VkAcquireFullScreenExclusiveModeEXT vkAcquireFullScreenExclusiveModeEXT;
            public VkReleaseFullScreenExclusiveModeEXT vkReleaseFullScreenExclusiveModeEXT;
            public VkGetDeviceGroupSurfacePresentModes2EXT vkGetDeviceGroupSurfacePresentModes2EXT;
            public VkExportMetalObjectsEXT vkExportMetalObjectsEXT;
            public VkGetMemoryMetalHandleEXT vkGetMemoryMetalHandleEXT;
            public VkGetMemoryMetalHandlePropertiesEXT vkGetMemoryMetalHandlePropertiesEXT;
            public VkGetAndroidHardwareBufferPropertiesANDROID vkGetAndroidHardwareBufferPropertiesANDROID;
            public VkGetMemoryAndroidHardwareBufferANDROID vkGetMemoryAndroidHardwareBufferANDROID;
            public VxDestroyImages vxDestroyImages;
            public VxDestroyImageViews vxDestroyImageViews;
            public VxDestroyBuffers vxDestroyBuffers;
            public VxDestroyBufferViews vxDestroyBufferViews;

            public FunctionTable(VkDevice device, VkGetDeviceProcAddr getProc)
            {
                vkGetDeviceProcAddr = getProc;
                vkDestroyDevice = (VkDestroyDevice)getProc.Invoke(device, "vkDestroyDevice"u8.AsPointer());
                vkGetDeviceQueue = (VkGetDeviceQueue)getProc.Invoke(device, "vkGetDeviceQueue"u8.AsPointer());
                vkQueueSubmit = (VkQueueSubmit)getProc.Invoke(device, "vkQueueSubmit"u8.AsPointer());
                vkQueueWaitIdle = (VkQueueWaitIdle)getProc.Invoke(device, "vkQueueWaitIdle"u8.AsPointer());
                vkDeviceWaitIdle = (VkDeviceWaitIdle)getProc.Invoke(device, "vkDeviceWaitIdle"u8.AsPointer());
                vkAllocateMemory = (VkAllocateMemory)getProc.Invoke(device, "vkAllocateMemory"u8.AsPointer());
                vkFreeMemory = (VkFreeMemory)getProc.Invoke(device, "vkFreeMemory"u8.AsPointer());
                vkMapMemory = (VkMapMemory)getProc.Invoke(device, "vkMapMemory"u8.AsPointer());
                vkUnmapMemory = (VkUnmapMemory)getProc.Invoke(device, "vkUnmapMemory"u8.AsPointer());
                vkFlushMappedMemoryRanges = (VkFlushMappedMemoryRanges)
                    getProc.Invoke(device, "vkFlushMappedMemoryRanges"u8.AsPointer());
                vkInvalidateMappedMemoryRanges = (VkInvalidateMappedMemoryRanges)
                    getProc.Invoke(device, "vkInvalidateMappedMemoryRanges"u8.AsPointer());
                vkGetDeviceMemoryCommitment = (VkGetDeviceMemoryCommitment)
                    getProc.Invoke(device, "vkGetDeviceMemoryCommitment"u8.AsPointer());
                vkBindBufferMemory = (VkBindBufferMemory)getProc.Invoke(device, "vkBindBufferMemory"u8.AsPointer());
                vkBindImageMemory = (VkBindImageMemory)getProc.Invoke(device, "vkBindImageMemory"u8.AsPointer());
                vkGetBufferMemoryRequirements = (VkGetBufferMemoryRequirements)
                    getProc.Invoke(device, "vkGetBufferMemoryRequirements"u8.AsPointer());
                vkGetImageMemoryRequirements = (VkGetImageMemoryRequirements)
                    getProc.Invoke(device, "vkGetImageMemoryRequirements"u8.AsPointer());
                vkGetImageSparseMemoryRequirements = (VkGetImageSparseMemoryRequirements)
                    getProc.Invoke(device, "vkGetImageSparseMemoryRequirements"u8.AsPointer());
                vkQueueBindSparse = (VkQueueBindSparse)getProc.Invoke(device, "vkQueueBindSparse"u8.AsPointer());
                vkCreateFence = (VkCreateFence)getProc.Invoke(device, "vkCreateFence"u8.AsPointer());
                vkDestroyFence = (VkDestroyFence)getProc.Invoke(device, "vkDestroyFence"u8.AsPointer());
                vkResetFences = (VkResetFences)getProc.Invoke(device, "vkResetFences"u8.AsPointer());
                vkGetFenceStatus = (VkGetFenceStatus)getProc.Invoke(device, "vkGetFenceStatus"u8.AsPointer());
                vkWaitForFences = (VkWaitForFences)getProc.Invoke(device, "vkWaitForFences"u8.AsPointer());
                vkCreateSemaphore = (VkCreateSemaphore)getProc.Invoke(device, "vkCreateSemaphore"u8.AsPointer());
                vkDestroySemaphore = (VkDestroySemaphore)getProc.Invoke(device, "vkDestroySemaphore"u8.AsPointer());
                vkCreateQueryPool = (VkCreateQueryPool)getProc.Invoke(device, "vkCreateQueryPool"u8.AsPointer());
                vkDestroyQueryPool = (VkDestroyQueryPool)getProc.Invoke(device, "vkDestroyQueryPool"u8.AsPointer());
                vkGetQueryPoolResults = (VkGetQueryPoolResults)
                    getProc.Invoke(device, "vkGetQueryPoolResults"u8.AsPointer());
                vkCreateBuffer = (VkCreateBuffer)getProc.Invoke(device, "vkCreateBuffer"u8.AsPointer());
                vkDestroyBuffer = (VkDestroyBuffer)getProc.Invoke(device, "vkDestroyBuffer"u8.AsPointer());
                vkCreateImage = (VkCreateImage)getProc.Invoke(device, "vkCreateImage"u8.AsPointer());
                vkDestroyImage = (VkDestroyImage)getProc.Invoke(device, "vkDestroyImage"u8.AsPointer());
                vkGetImageSubresourceLayout = (VkGetImageSubresourceLayout)
                    getProc.Invoke(device, "vkGetImageSubresourceLayout"u8.AsPointer());
                vkCreateImageView = (VkCreateImageView)getProc.Invoke(device, "vkCreateImageView"u8.AsPointer());
                vkDestroyImageView = (VkDestroyImageView)getProc.Invoke(device, "vkDestroyImageView"u8.AsPointer());
                vkCreateCommandPool = (VkCreateCommandPool)getProc.Invoke(device, "vkCreateCommandPool"u8.AsPointer());
                vkDestroyCommandPool = (VkDestroyCommandPool)
                    getProc.Invoke(device, "vkDestroyCommandPool"u8.AsPointer());
                vkResetCommandPool = (VkResetCommandPool)getProc.Invoke(device, "vkResetCommandPool"u8.AsPointer());
                vkAllocateCommandBuffers = (VkAllocateCommandBuffers)
                    getProc.Invoke(device, "vkAllocateCommandBuffers"u8.AsPointer());
                vkFreeCommandBuffers = (VkFreeCommandBuffers)
                    getProc.Invoke(device, "vkFreeCommandBuffers"u8.AsPointer());
                vkBeginCommandBuffer = (VkBeginCommandBuffer)
                    getProc.Invoke(device, "vkBeginCommandBuffer"u8.AsPointer());
                vkEndCommandBuffer = (VkEndCommandBuffer)getProc.Invoke(device, "vkEndCommandBuffer"u8.AsPointer());
                vkResetCommandBuffer = (VkResetCommandBuffer)
                    getProc.Invoke(device, "vkResetCommandBuffer"u8.AsPointer());
                vkCmdCopyBuffer = (VkCmdCopyBuffer)getProc.Invoke(device, "vkCmdCopyBuffer"u8.AsPointer());
                vkCmdCopyImage = (VkCmdCopyImage)getProc.Invoke(device, "vkCmdCopyImage"u8.AsPointer());
                vkCmdCopyBufferToImage = (VkCmdCopyBufferToImage)
                    getProc.Invoke(device, "vkCmdCopyBufferToImage"u8.AsPointer());
                vkCmdCopyImageToBuffer = (VkCmdCopyImageToBuffer)
                    getProc.Invoke(device, "vkCmdCopyImageToBuffer"u8.AsPointer());
                vkCmdUpdateBuffer = (VkCmdUpdateBuffer)getProc.Invoke(device, "vkCmdUpdateBuffer"u8.AsPointer());
                vkCmdFillBuffer = (VkCmdFillBuffer)getProc.Invoke(device, "vkCmdFillBuffer"u8.AsPointer());
                vkCmdPipelineBarrier = (VkCmdPipelineBarrier)
                    getProc.Invoke(device, "vkCmdPipelineBarrier"u8.AsPointer());
                vkCmdBeginQuery = (VkCmdBeginQuery)getProc.Invoke(device, "vkCmdBeginQuery"u8.AsPointer());
                vkCmdEndQuery = (VkCmdEndQuery)getProc.Invoke(device, "vkCmdEndQuery"u8.AsPointer());
                vkCmdResetQueryPool = (VkCmdResetQueryPool)getProc.Invoke(device, "vkCmdResetQueryPool"u8.AsPointer());
                vkCmdWriteTimestamp = (VkCmdWriteTimestamp)getProc.Invoke(device, "vkCmdWriteTimestamp"u8.AsPointer());
                vkCmdCopyQueryPoolResults = (VkCmdCopyQueryPoolResults)
                    getProc.Invoke(device, "vkCmdCopyQueryPoolResults"u8.AsPointer());
                vkCmdExecuteCommands = (VkCmdExecuteCommands)
                    getProc.Invoke(device, "vkCmdExecuteCommands"u8.AsPointer());
                vkCreateEvent = (VkCreateEvent)getProc.Invoke(device, "vkCreateEvent"u8.AsPointer());
                vkDestroyEvent = (VkDestroyEvent)getProc.Invoke(device, "vkDestroyEvent"u8.AsPointer());
                vkGetEventStatus = (VkGetEventStatus)getProc.Invoke(device, "vkGetEventStatus"u8.AsPointer());
                vkSetEvent = (VkSetEvent)getProc.Invoke(device, "vkSetEvent"u8.AsPointer());
                vkResetEvent = (VkResetEvent)getProc.Invoke(device, "vkResetEvent"u8.AsPointer());
                vkCreateBufferView = (VkCreateBufferView)getProc.Invoke(device, "vkCreateBufferView"u8.AsPointer());
                vkDestroyBufferView = (VkDestroyBufferView)getProc.Invoke(device, "vkDestroyBufferView"u8.AsPointer());
                vkCreateShaderModule = (VkCreateShaderModule)
                    getProc.Invoke(device, "vkCreateShaderModule"u8.AsPointer());
                vkDestroyShaderModule = (VkDestroyShaderModule)
                    getProc.Invoke(device, "vkDestroyShaderModule"u8.AsPointer());
                vkCreatePipelineCache = (VkCreatePipelineCache)
                    getProc.Invoke(device, "vkCreatePipelineCache"u8.AsPointer());
                vkDestroyPipelineCache = (VkDestroyPipelineCache)
                    getProc.Invoke(device, "vkDestroyPipelineCache"u8.AsPointer());
                vkGetPipelineCacheData = (VkGetPipelineCacheData)
                    getProc.Invoke(device, "vkGetPipelineCacheData"u8.AsPointer());
                vkMergePipelineCaches = (VkMergePipelineCaches)
                    getProc.Invoke(device, "vkMergePipelineCaches"u8.AsPointer());
                vkCreateComputePipelines = (VkCreateComputePipelines)
                    getProc.Invoke(device, "vkCreateComputePipelines"u8.AsPointer());
                vkDestroyPipeline = (VkDestroyPipeline)getProc.Invoke(device, "vkDestroyPipeline"u8.AsPointer());
                vkCreatePipelineLayout = (VkCreatePipelineLayout)
                    getProc.Invoke(device, "vkCreatePipelineLayout"u8.AsPointer());
                vkDestroyPipelineLayout = (VkDestroyPipelineLayout)
                    getProc.Invoke(device, "vkDestroyPipelineLayout"u8.AsPointer());
                vkCreateSampler = (VkCreateSampler)getProc.Invoke(device, "vkCreateSampler"u8.AsPointer());
                vkDestroySampler = (VkDestroySampler)getProc.Invoke(device, "vkDestroySampler"u8.AsPointer());
                vkCreateDescriptorSetLayout = (VkCreateDescriptorSetLayout)
                    getProc.Invoke(device, "vkCreateDescriptorSetLayout"u8.AsPointer());
                vkDestroyDescriptorSetLayout = (VkDestroyDescriptorSetLayout)
                    getProc.Invoke(device, "vkDestroyDescriptorSetLayout"u8.AsPointer());
                vkCreateDescriptorPool = (VkCreateDescriptorPool)
                    getProc.Invoke(device, "vkCreateDescriptorPool"u8.AsPointer());
                vkDestroyDescriptorPool = (VkDestroyDescriptorPool)
                    getProc.Invoke(device, "vkDestroyDescriptorPool"u8.AsPointer());
                vkResetDescriptorPool = (VkResetDescriptorPool)
                    getProc.Invoke(device, "vkResetDescriptorPool"u8.AsPointer());
                vkAllocateDescriptorSets = (VkAllocateDescriptorSets)
                    getProc.Invoke(device, "vkAllocateDescriptorSets"u8.AsPointer());
                vkFreeDescriptorSets = (VkFreeDescriptorSets)
                    getProc.Invoke(device, "vkFreeDescriptorSets"u8.AsPointer());
                vkUpdateDescriptorSets = (VkUpdateDescriptorSets)
                    getProc.Invoke(device, "vkUpdateDescriptorSets"u8.AsPointer());
                vkCmdBindPipeline = (VkCmdBindPipeline)getProc.Invoke(device, "vkCmdBindPipeline"u8.AsPointer());
                vkCmdBindDescriptorSets = (VkCmdBindDescriptorSets)
                    getProc.Invoke(device, "vkCmdBindDescriptorSets"u8.AsPointer());
                vkCmdClearColorImage = (VkCmdClearColorImage)
                    getProc.Invoke(device, "vkCmdClearColorImage"u8.AsPointer());
                vkCmdDispatch = (VkCmdDispatch)getProc.Invoke(device, "vkCmdDispatch"u8.AsPointer());
                vkCmdDispatchIndirect = (VkCmdDispatchIndirect)
                    getProc.Invoke(device, "vkCmdDispatchIndirect"u8.AsPointer());
                vkCmdSetEvent = (VkCmdSetEvent)getProc.Invoke(device, "vkCmdSetEvent"u8.AsPointer());
                vkCmdResetEvent = (VkCmdResetEvent)getProc.Invoke(device, "vkCmdResetEvent"u8.AsPointer());
                vkCmdWaitEvents = (VkCmdWaitEvents)getProc.Invoke(device, "vkCmdWaitEvents"u8.AsPointer());
                vkCmdPushConstants = (VkCmdPushConstants)getProc.Invoke(device, "vkCmdPushConstants"u8.AsPointer());
                vkCreateGraphicsPipelines = (VkCreateGraphicsPipelines)
                    getProc.Invoke(device, "vkCreateGraphicsPipelines"u8.AsPointer());
                vkCreateFramebuffer = (VkCreateFramebuffer)getProc.Invoke(device, "vkCreateFramebuffer"u8.AsPointer());
                vkDestroyFramebuffer = (VkDestroyFramebuffer)
                    getProc.Invoke(device, "vkDestroyFramebuffer"u8.AsPointer());
                vkCreateRenderPass = (VkCreateRenderPass)getProc.Invoke(device, "vkCreateRenderPass"u8.AsPointer());
                vkDestroyRenderPass = (VkDestroyRenderPass)getProc.Invoke(device, "vkDestroyRenderPass"u8.AsPointer());
                vkGetRenderAreaGranularity = (VkGetRenderAreaGranularity)
                    getProc.Invoke(device, "vkGetRenderAreaGranularity"u8.AsPointer());
                vkCmdSetViewport = (VkCmdSetViewport)getProc.Invoke(device, "vkCmdSetViewport"u8.AsPointer());
                vkCmdSetScissor = (VkCmdSetScissor)getProc.Invoke(device, "vkCmdSetScissor"u8.AsPointer());
                vkCmdSetLineWidth = (VkCmdSetLineWidth)getProc.Invoke(device, "vkCmdSetLineWidth"u8.AsPointer());
                vkCmdSetDepthBias = (VkCmdSetDepthBias)getProc.Invoke(device, "vkCmdSetDepthBias"u8.AsPointer());
                vkCmdSetBlendConstants = (VkCmdSetBlendConstants)
                    getProc.Invoke(device, "vkCmdSetBlendConstants"u8.AsPointer());
                vkCmdSetDepthBounds = (VkCmdSetDepthBounds)getProc.Invoke(device, "vkCmdSetDepthBounds"u8.AsPointer());
                vkCmdSetStencilCompareMask = (VkCmdSetStencilCompareMask)
                    getProc.Invoke(device, "vkCmdSetStencilCompareMask"u8.AsPointer());
                vkCmdSetStencilWriteMask = (VkCmdSetStencilWriteMask)
                    getProc.Invoke(device, "vkCmdSetStencilWriteMask"u8.AsPointer());
                vkCmdSetStencilReference = (VkCmdSetStencilReference)
                    getProc.Invoke(device, "vkCmdSetStencilReference"u8.AsPointer());
                vkCmdBindIndexBuffer = (VkCmdBindIndexBuffer)
                    getProc.Invoke(device, "vkCmdBindIndexBuffer"u8.AsPointer());
                vkCmdBindVertexBuffers = (VkCmdBindVertexBuffers)
                    getProc.Invoke(device, "vkCmdBindVertexBuffers"u8.AsPointer());
                vkCmdDraw = (VkCmdDraw)getProc.Invoke(device, "vkCmdDraw"u8.AsPointer());
                vkCmdDrawIndexed = (VkCmdDrawIndexed)getProc.Invoke(device, "vkCmdDrawIndexed"u8.AsPointer());
                vkCmdDrawIndirect = (VkCmdDrawIndirect)getProc.Invoke(device, "vkCmdDrawIndirect"u8.AsPointer());
                vkCmdDrawIndexedIndirect = (VkCmdDrawIndexedIndirect)
                    getProc.Invoke(device, "vkCmdDrawIndexedIndirect"u8.AsPointer());
                vkCmdBlitImage = (VkCmdBlitImage)getProc.Invoke(device, "vkCmdBlitImage"u8.AsPointer());
                vkCmdClearDepthStencilImage = (VkCmdClearDepthStencilImage)
                    getProc.Invoke(device, "vkCmdClearDepthStencilImage"u8.AsPointer());
                vkCmdClearAttachments = (VkCmdClearAttachments)
                    getProc.Invoke(device, "vkCmdClearAttachments"u8.AsPointer());
                vkCmdResolveImage = (VkCmdResolveImage)getProc.Invoke(device, "vkCmdResolveImage"u8.AsPointer());
                vkCmdBeginRenderPass = (VkCmdBeginRenderPass)
                    getProc.Invoke(device, "vkCmdBeginRenderPass"u8.AsPointer());
                vkCmdNextSubpass = (VkCmdNextSubpass)getProc.Invoke(device, "vkCmdNextSubpass"u8.AsPointer());
                vkCmdEndRenderPass = (VkCmdEndRenderPass)getProc.Invoke(device, "vkCmdEndRenderPass"u8.AsPointer());
                vkBindBufferMemory2 = (VkBindBufferMemory2)getProc.Invoke(device, "vkBindBufferMemory2"u8.AsPointer());
                vkBindImageMemory2 = (VkBindImageMemory2)getProc.Invoke(device, "vkBindImageMemory2"u8.AsPointer());
                vkGetDeviceGroupPeerMemoryFeatures = (VkGetDeviceGroupPeerMemoryFeatures)
                    getProc.Invoke(device, "vkGetDeviceGroupPeerMemoryFeatures"u8.AsPointer());
                vkCmdSetDeviceMask = (VkCmdSetDeviceMask)getProc.Invoke(device, "vkCmdSetDeviceMask"u8.AsPointer());
                vkGetImageMemoryRequirements2 = (VkGetImageMemoryRequirements2)
                    getProc.Invoke(device, "vkGetImageMemoryRequirements2"u8.AsPointer());
                vkGetBufferMemoryRequirements2 = (VkGetBufferMemoryRequirements2)
                    getProc.Invoke(device, "vkGetBufferMemoryRequirements2"u8.AsPointer());
                vkGetImageSparseMemoryRequirements2 = (VkGetImageSparseMemoryRequirements2)
                    getProc.Invoke(device, "vkGetImageSparseMemoryRequirements2"u8.AsPointer());
                vkTrimCommandPool = (VkTrimCommandPool)getProc.Invoke(device, "vkTrimCommandPool"u8.AsPointer());
                vkGetDeviceQueue2 = (VkGetDeviceQueue2)getProc.Invoke(device, "vkGetDeviceQueue2"u8.AsPointer());
                vkCmdDispatchBase = (VkCmdDispatchBase)getProc.Invoke(device, "vkCmdDispatchBase"u8.AsPointer());
                vkCreateDescriptorUpdateTemplate = (VkCreateDescriptorUpdateTemplate)
                    getProc.Invoke(device, "vkCreateDescriptorUpdateTemplate"u8.AsPointer());
                vkDestroyDescriptorUpdateTemplate = (VkDestroyDescriptorUpdateTemplate)
                    getProc.Invoke(device, "vkDestroyDescriptorUpdateTemplate"u8.AsPointer());
                vkUpdateDescriptorSetWithTemplate = (VkUpdateDescriptorSetWithTemplate)
                    getProc.Invoke(device, "vkUpdateDescriptorSetWithTemplate"u8.AsPointer());
                vkGetDescriptorSetLayoutSupport = (VkGetDescriptorSetLayoutSupport)
                    getProc.Invoke(device, "vkGetDescriptorSetLayoutSupport"u8.AsPointer());
                vkCreateSamplerYcbcrConversion = (VkCreateSamplerYcbcrConversion)
                    getProc.Invoke(device, "vkCreateSamplerYcbcrConversion"u8.AsPointer());
                vkDestroySamplerYcbcrConversion = (VkDestroySamplerYcbcrConversion)
                    getProc.Invoke(device, "vkDestroySamplerYcbcrConversion"u8.AsPointer());
                vkResetQueryPool = (VkResetQueryPool)getProc.Invoke(device, "vkResetQueryPool"u8.AsPointer());
                vkGetSemaphoreCounterValue = (VkGetSemaphoreCounterValue)
                    getProc.Invoke(device, "vkGetSemaphoreCounterValue"u8.AsPointer());
                vkWaitSemaphores = (VkWaitSemaphores)getProc.Invoke(device, "vkWaitSemaphores"u8.AsPointer());
                vkSignalSemaphore = (VkSignalSemaphore)getProc.Invoke(device, "vkSignalSemaphore"u8.AsPointer());
                vkGetBufferDeviceAddress = (VkGetBufferDeviceAddress)
                    getProc.Invoke(device, "vkGetBufferDeviceAddress"u8.AsPointer());
                vkGetBufferOpaqueCaptureAddress = (VkGetBufferOpaqueCaptureAddress)
                    getProc.Invoke(device, "vkGetBufferOpaqueCaptureAddress"u8.AsPointer());
                vkGetDeviceMemoryOpaqueCaptureAddress = (VkGetDeviceMemoryOpaqueCaptureAddress)
                    getProc.Invoke(device, "vkGetDeviceMemoryOpaqueCaptureAddress"u8.AsPointer());
                vkCmdDrawIndirectCount = (VkCmdDrawIndirectCount)
                    getProc.Invoke(device, "vkCmdDrawIndirectCount"u8.AsPointer());
                vkCmdDrawIndexedIndirectCount = (VkCmdDrawIndexedIndirectCount)
                    getProc.Invoke(device, "vkCmdDrawIndexedIndirectCount"u8.AsPointer());
                vkCreateRenderPass2 = (VkCreateRenderPass2)getProc.Invoke(device, "vkCreateRenderPass2"u8.AsPointer());
                vkCmdBeginRenderPass2 = (VkCmdBeginRenderPass2)
                    getProc.Invoke(device, "vkCmdBeginRenderPass2"u8.AsPointer());
                vkCmdNextSubpass2 = (VkCmdNextSubpass2)getProc.Invoke(device, "vkCmdNextSubpass2"u8.AsPointer());
                vkCmdEndRenderPass2 = (VkCmdEndRenderPass2)getProc.Invoke(device, "vkCmdEndRenderPass2"u8.AsPointer());
                vkCreatePrivateDataSlot = (VkCreatePrivateDataSlot)
                    getProc.Invoke(device, "vkCreatePrivateDataSlot"u8.AsPointer());
                vkDestroyPrivateDataSlot = (VkDestroyPrivateDataSlot)
                    getProc.Invoke(device, "vkDestroyPrivateDataSlot"u8.AsPointer());
                vkSetPrivateData = (VkSetPrivateData)getProc.Invoke(device, "vkSetPrivateData"u8.AsPointer());
                vkGetPrivateData = (VkGetPrivateData)getProc.Invoke(device, "vkGetPrivateData"u8.AsPointer());
                vkCmdPipelineBarrier2 = (VkCmdPipelineBarrier2)
                    getProc.Invoke(device, "vkCmdPipelineBarrier2"u8.AsPointer());
                vkCmdWriteTimestamp2 = (VkCmdWriteTimestamp2)
                    getProc.Invoke(device, "vkCmdWriteTimestamp2"u8.AsPointer());
                vkQueueSubmit2 = (VkQueueSubmit2)getProc.Invoke(device, "vkQueueSubmit2"u8.AsPointer());
                vkCmdCopyBuffer2 = (VkCmdCopyBuffer2)getProc.Invoke(device, "vkCmdCopyBuffer2"u8.AsPointer());
                vkCmdCopyImage2 = (VkCmdCopyImage2)getProc.Invoke(device, "vkCmdCopyImage2"u8.AsPointer());
                vkCmdCopyBufferToImage2 = (VkCmdCopyBufferToImage2)
                    getProc.Invoke(device, "vkCmdCopyBufferToImage2"u8.AsPointer());
                vkCmdCopyImageToBuffer2 = (VkCmdCopyImageToBuffer2)
                    getProc.Invoke(device, "vkCmdCopyImageToBuffer2"u8.AsPointer());
                vkGetDeviceBufferMemoryRequirements = (VkGetDeviceBufferMemoryRequirements)
                    getProc.Invoke(device, "vkGetDeviceBufferMemoryRequirements"u8.AsPointer());
                vkGetDeviceImageMemoryRequirements = (VkGetDeviceImageMemoryRequirements)
                    getProc.Invoke(device, "vkGetDeviceImageMemoryRequirements"u8.AsPointer());
                vkGetDeviceImageSparseMemoryRequirements = (VkGetDeviceImageSparseMemoryRequirements)
                    getProc.Invoke(device, "vkGetDeviceImageSparseMemoryRequirements"u8.AsPointer());
                vkCmdSetEvent2 = (VkCmdSetEvent2)getProc.Invoke(device, "vkCmdSetEvent2"u8.AsPointer());
                vkCmdResetEvent2 = (VkCmdResetEvent2)getProc.Invoke(device, "vkCmdResetEvent2"u8.AsPointer());
                vkCmdWaitEvents2 = (VkCmdWaitEvents2)getProc.Invoke(device, "vkCmdWaitEvents2"u8.AsPointer());
                vkCmdBlitImage2 = (VkCmdBlitImage2)getProc.Invoke(device, "vkCmdBlitImage2"u8.AsPointer());
                vkCmdResolveImage2 = (VkCmdResolveImage2)getProc.Invoke(device, "vkCmdResolveImage2"u8.AsPointer());
                vkCmdBeginRendering = (VkCmdBeginRendering)getProc.Invoke(device, "vkCmdBeginRendering"u8.AsPointer());
                vkCmdEndRendering = (VkCmdEndRendering)getProc.Invoke(device, "vkCmdEndRendering"u8.AsPointer());
                vkCmdSetCullMode = (VkCmdSetCullMode)getProc.Invoke(device, "vkCmdSetCullMode"u8.AsPointer());
                vkCmdSetFrontFace = (VkCmdSetFrontFace)getProc.Invoke(device, "vkCmdSetFrontFace"u8.AsPointer());
                vkCmdSetPrimitiveTopology = (VkCmdSetPrimitiveTopology)
                    getProc.Invoke(device, "vkCmdSetPrimitiveTopology"u8.AsPointer());
                vkCmdSetViewportWithCount = (VkCmdSetViewportWithCount)
                    getProc.Invoke(device, "vkCmdSetViewportWithCount"u8.AsPointer());
                vkCmdSetScissorWithCount = (VkCmdSetScissorWithCount)
                    getProc.Invoke(device, "vkCmdSetScissorWithCount"u8.AsPointer());
                vkCmdBindVertexBuffers2 = (VkCmdBindVertexBuffers2)
                    getProc.Invoke(device, "vkCmdBindVertexBuffers2"u8.AsPointer());
                vkCmdSetDepthTestEnable = (VkCmdSetDepthTestEnable)
                    getProc.Invoke(device, "vkCmdSetDepthTestEnable"u8.AsPointer());
                vkCmdSetDepthWriteEnable = (VkCmdSetDepthWriteEnable)
                    getProc.Invoke(device, "vkCmdSetDepthWriteEnable"u8.AsPointer());
                vkCmdSetDepthCompareOp = (VkCmdSetDepthCompareOp)
                    getProc.Invoke(device, "vkCmdSetDepthCompareOp"u8.AsPointer());
                vkCmdSetDepthBoundsTestEnable = (VkCmdSetDepthBoundsTestEnable)
                    getProc.Invoke(device, "vkCmdSetDepthBoundsTestEnable"u8.AsPointer());
                vkCmdSetStencilTestEnable = (VkCmdSetStencilTestEnable)
                    getProc.Invoke(device, "vkCmdSetStencilTestEnable"u8.AsPointer());
                vkCmdSetStencilOp = (VkCmdSetStencilOp)getProc.Invoke(device, "vkCmdSetStencilOp"u8.AsPointer());
                vkCmdSetRasterizerDiscardEnable = (VkCmdSetRasterizerDiscardEnable)
                    getProc.Invoke(device, "vkCmdSetRasterizerDiscardEnable"u8.AsPointer());
                vkCmdSetDepthBiasEnable = (VkCmdSetDepthBiasEnable)
                    getProc.Invoke(device, "vkCmdSetDepthBiasEnable"u8.AsPointer());
                vkCmdSetPrimitiveRestartEnable = (VkCmdSetPrimitiveRestartEnable)
                    getProc.Invoke(device, "vkCmdSetPrimitiveRestartEnable"u8.AsPointer());
                vkMapMemory2 = (VkMapMemory2)getProc.Invoke(device, "vkMapMemory2"u8.AsPointer());
                vkUnmapMemory2 = (VkUnmapMemory2)getProc.Invoke(device, "vkUnmapMemory2"u8.AsPointer());
                vkGetDeviceImageSubresourceLayout = (VkGetDeviceImageSubresourceLayout)
                    getProc.Invoke(device, "vkGetDeviceImageSubresourceLayout"u8.AsPointer());
                vkGetImageSubresourceLayout2 = (VkGetImageSubresourceLayout2)
                    getProc.Invoke(device, "vkGetImageSubresourceLayout2"u8.AsPointer());
                vkCopyMemoryToImage = (VkCopyMemoryToImage)getProc.Invoke(device, "vkCopyMemoryToImage"u8.AsPointer());
                vkCopyImageToMemory = (VkCopyImageToMemory)getProc.Invoke(device, "vkCopyImageToMemory"u8.AsPointer());
                vkCopyImageToImage = (VkCopyImageToImage)getProc.Invoke(device, "vkCopyImageToImage"u8.AsPointer());
                vkTransitionImageLayout = (VkTransitionImageLayout)
                    getProc.Invoke(device, "vkTransitionImageLayout"u8.AsPointer());
                vkCmdPushDescriptorSet = (VkCmdPushDescriptorSet)
                    getProc.Invoke(device, "vkCmdPushDescriptorSet"u8.AsPointer());
                vkCmdPushDescriptorSetWithTemplate = (VkCmdPushDescriptorSetWithTemplate)
                    getProc.Invoke(device, "vkCmdPushDescriptorSetWithTemplate"u8.AsPointer());
                vkCmdBindDescriptorSets2 = (VkCmdBindDescriptorSets2)
                    getProc.Invoke(device, "vkCmdBindDescriptorSets2"u8.AsPointer());
                vkCmdPushConstants2 = (VkCmdPushConstants2)getProc.Invoke(device, "vkCmdPushConstants2"u8.AsPointer());
                vkCmdPushDescriptorSet2 = (VkCmdPushDescriptorSet2)
                    getProc.Invoke(device, "vkCmdPushDescriptorSet2"u8.AsPointer());
                vkCmdPushDescriptorSetWithTemplate2 = (VkCmdPushDescriptorSetWithTemplate2)
                    getProc.Invoke(device, "vkCmdPushDescriptorSetWithTemplate2"u8.AsPointer());
                vkCmdSetLineStipple = (VkCmdSetLineStipple)getProc.Invoke(device, "vkCmdSetLineStipple"u8.AsPointer());
                vkCmdBindIndexBuffer2 = (VkCmdBindIndexBuffer2)
                    getProc.Invoke(device, "vkCmdBindIndexBuffer2"u8.AsPointer());
                vkGetRenderingAreaGranularity = (VkGetRenderingAreaGranularity)
                    getProc.Invoke(device, "vkGetRenderingAreaGranularity"u8.AsPointer());
                vkCmdSetRenderingAttachmentLocations = (VkCmdSetRenderingAttachmentLocations)
                    getProc.Invoke(device, "vkCmdSetRenderingAttachmentLocations"u8.AsPointer());
                vkCmdSetRenderingInputAttachmentIndices = (VkCmdSetRenderingInputAttachmentIndices)
                    getProc.Invoke(device, "vkCmdSetRenderingInputAttachmentIndices"u8.AsPointer());
                vkCreateSwapchainKHR = (VkCreateSwapchainKHR)
                    getProc.Invoke(device, "vkCreateSwapchainKHR"u8.AsPointer());
                vkDestroySwapchainKHR = (VkDestroySwapchainKHR)
                    getProc.Invoke(device, "vkDestroySwapchainKHR"u8.AsPointer());
                vkGetSwapchainImagesKHR = (VkGetSwapchainImagesKHR)
                    getProc.Invoke(device, "vkGetSwapchainImagesKHR"u8.AsPointer());
                vkAcquireNextImageKHR = (VkAcquireNextImageKHR)
                    getProc.Invoke(device, "vkAcquireNextImageKHR"u8.AsPointer());
                vkQueuePresentKHR = (VkQueuePresentKHR)getProc.Invoke(device, "vkQueuePresentKHR"u8.AsPointer());
                vkGetDeviceGroupPresentCapabilitiesKHR = (VkGetDeviceGroupPresentCapabilitiesKHR)
                    getProc.Invoke(device, "vkGetDeviceGroupPresentCapabilitiesKHR"u8.AsPointer());
                vkGetDeviceGroupSurfacePresentModesKHR = (VkGetDeviceGroupSurfacePresentModesKHR)
                    getProc.Invoke(device, "vkGetDeviceGroupSurfacePresentModesKHR"u8.AsPointer());
                vkAcquireNextImage2KHR = (VkAcquireNextImage2KHR)
                    getProc.Invoke(device, "vkAcquireNextImage2KHR"u8.AsPointer());
                vkCreateSharedSwapchainsKHR = (VkCreateSharedSwapchainsKHR)
                    getProc.Invoke(device, "vkCreateSharedSwapchainsKHR"u8.AsPointer());
                vkCreateVideoSessionKHR = (VkCreateVideoSessionKHR)
                    getProc.Invoke(device, "vkCreateVideoSessionKHR"u8.AsPointer());
                vkDestroyVideoSessionKHR = (VkDestroyVideoSessionKHR)
                    getProc.Invoke(device, "vkDestroyVideoSessionKHR"u8.AsPointer());
                vkGetVideoSessionMemoryRequirementsKHR = (VkGetVideoSessionMemoryRequirementsKHR)
                    getProc.Invoke(device, "vkGetVideoSessionMemoryRequirementsKHR"u8.AsPointer());
                vkBindVideoSessionMemoryKHR = (VkBindVideoSessionMemoryKHR)
                    getProc.Invoke(device, "vkBindVideoSessionMemoryKHR"u8.AsPointer());
                vkCreateVideoSessionParametersKHR = (VkCreateVideoSessionParametersKHR)
                    getProc.Invoke(device, "vkCreateVideoSessionParametersKHR"u8.AsPointer());
                vkUpdateVideoSessionParametersKHR = (VkUpdateVideoSessionParametersKHR)
                    getProc.Invoke(device, "vkUpdateVideoSessionParametersKHR"u8.AsPointer());
                vkDestroyVideoSessionParametersKHR = (VkDestroyVideoSessionParametersKHR)
                    getProc.Invoke(device, "vkDestroyVideoSessionParametersKHR"u8.AsPointer());
                vkCmdBeginVideoCodingKHR = (VkCmdBeginVideoCodingKHR)
                    getProc.Invoke(device, "vkCmdBeginVideoCodingKHR"u8.AsPointer());
                vkCmdEndVideoCodingKHR = (VkCmdEndVideoCodingKHR)
                    getProc.Invoke(device, "vkCmdEndVideoCodingKHR"u8.AsPointer());
                vkCmdControlVideoCodingKHR = (VkCmdControlVideoCodingKHR)
                    getProc.Invoke(device, "vkCmdControlVideoCodingKHR"u8.AsPointer());
                vkCmdDecodeVideoKHR = (VkCmdDecodeVideoKHR)getProc.Invoke(device, "vkCmdDecodeVideoKHR"u8.AsPointer());
                vkCmdBeginRenderingKHR = (VkCmdBeginRenderingKHR)
                    getProc.Invoke(device, "vkCmdBeginRenderingKHR"u8.AsPointer());
                vkCmdEndRenderingKHR = (VkCmdEndRenderingKHR)
                    getProc.Invoke(device, "vkCmdEndRenderingKHR"u8.AsPointer());
                vkGetDeviceGroupPeerMemoryFeaturesKHR = (VkGetDeviceGroupPeerMemoryFeaturesKHR)
                    getProc.Invoke(device, "vkGetDeviceGroupPeerMemoryFeaturesKHR"u8.AsPointer());
                vkCmdSetDeviceMaskKHR = (VkCmdSetDeviceMaskKHR)
                    getProc.Invoke(device, "vkCmdSetDeviceMaskKHR"u8.AsPointer());
                vkCmdDispatchBaseKHR = (VkCmdDispatchBaseKHR)
                    getProc.Invoke(device, "vkCmdDispatchBaseKHR"u8.AsPointer());
                vkTrimCommandPoolKHR = (VkTrimCommandPoolKHR)
                    getProc.Invoke(device, "vkTrimCommandPoolKHR"u8.AsPointer());
                vkGetMemoryFdKHR = (VkGetMemoryFdKHR)getProc.Invoke(device, "vkGetMemoryFdKHR"u8.AsPointer());
                vkGetMemoryFdPropertiesKHR = (VkGetMemoryFdPropertiesKHR)
                    getProc.Invoke(device, "vkGetMemoryFdPropertiesKHR"u8.AsPointer());
                vkImportSemaphoreFdKHR = (VkImportSemaphoreFdKHR)
                    getProc.Invoke(device, "vkImportSemaphoreFdKHR"u8.AsPointer());
                vkGetSemaphoreFdKHR = (VkGetSemaphoreFdKHR)getProc.Invoke(device, "vkGetSemaphoreFdKHR"u8.AsPointer());
                vkCmdPushDescriptorSetKHR = (VkCmdPushDescriptorSetKHR)
                    getProc.Invoke(device, "vkCmdPushDescriptorSetKHR"u8.AsPointer());
                vkCmdPushDescriptorSetWithTemplateKHR = (VkCmdPushDescriptorSetWithTemplateKHR)
                    getProc.Invoke(device, "vkCmdPushDescriptorSetWithTemplateKHR"u8.AsPointer());
                vkCreateDescriptorUpdateTemplateKHR = (VkCreateDescriptorUpdateTemplateKHR)
                    getProc.Invoke(device, "vkCreateDescriptorUpdateTemplateKHR"u8.AsPointer());
                vkDestroyDescriptorUpdateTemplateKHR = (VkDestroyDescriptorUpdateTemplateKHR)
                    getProc.Invoke(device, "vkDestroyDescriptorUpdateTemplateKHR"u8.AsPointer());
                vkUpdateDescriptorSetWithTemplateKHR = (VkUpdateDescriptorSetWithTemplateKHR)
                    getProc.Invoke(device, "vkUpdateDescriptorSetWithTemplateKHR"u8.AsPointer());
                vkCreateRenderPass2KHR = (VkCreateRenderPass2KHR)
                    getProc.Invoke(device, "vkCreateRenderPass2KHR"u8.AsPointer());
                vkCmdBeginRenderPass2KHR = (VkCmdBeginRenderPass2KHR)
                    getProc.Invoke(device, "vkCmdBeginRenderPass2KHR"u8.AsPointer());
                vkCmdNextSubpass2KHR = (VkCmdNextSubpass2KHR)
                    getProc.Invoke(device, "vkCmdNextSubpass2KHR"u8.AsPointer());
                vkCmdEndRenderPass2KHR = (VkCmdEndRenderPass2KHR)
                    getProc.Invoke(device, "vkCmdEndRenderPass2KHR"u8.AsPointer());
                vkGetSwapchainStatusKHR = (VkGetSwapchainStatusKHR)
                    getProc.Invoke(device, "vkGetSwapchainStatusKHR"u8.AsPointer());
                vkImportFenceFdKHR = (VkImportFenceFdKHR)getProc.Invoke(device, "vkImportFenceFdKHR"u8.AsPointer());
                vkGetFenceFdKHR = (VkGetFenceFdKHR)getProc.Invoke(device, "vkGetFenceFdKHR"u8.AsPointer());
                vkAcquireProfilingLockKHR = (VkAcquireProfilingLockKHR)
                    getProc.Invoke(device, "vkAcquireProfilingLockKHR"u8.AsPointer());
                vkReleaseProfilingLockKHR = (VkReleaseProfilingLockKHR)
                    getProc.Invoke(device, "vkReleaseProfilingLockKHR"u8.AsPointer());
                vkGetImageMemoryRequirements2KHR = (VkGetImageMemoryRequirements2KHR)
                    getProc.Invoke(device, "vkGetImageMemoryRequirements2KHR"u8.AsPointer());
                vkGetBufferMemoryRequirements2KHR = (VkGetBufferMemoryRequirements2KHR)
                    getProc.Invoke(device, "vkGetBufferMemoryRequirements2KHR"u8.AsPointer());
                vkGetImageSparseMemoryRequirements2KHR = (VkGetImageSparseMemoryRequirements2KHR)
                    getProc.Invoke(device, "vkGetImageSparseMemoryRequirements2KHR"u8.AsPointer());
                vkCreateSamplerYcbcrConversionKHR = (VkCreateSamplerYcbcrConversionKHR)
                    getProc.Invoke(device, "vkCreateSamplerYcbcrConversionKHR"u8.AsPointer());
                vkDestroySamplerYcbcrConversionKHR = (VkDestroySamplerYcbcrConversionKHR)
                    getProc.Invoke(device, "vkDestroySamplerYcbcrConversionKHR"u8.AsPointer());
                vkBindBufferMemory2KHR = (VkBindBufferMemory2KHR)
                    getProc.Invoke(device, "vkBindBufferMemory2KHR"u8.AsPointer());
                vkBindImageMemory2KHR = (VkBindImageMemory2KHR)
                    getProc.Invoke(device, "vkBindImageMemory2KHR"u8.AsPointer());
                vkGetDescriptorSetLayoutSupportKHR = (VkGetDescriptorSetLayoutSupportKHR)
                    getProc.Invoke(device, "vkGetDescriptorSetLayoutSupportKHR"u8.AsPointer());
                vkCmdDrawIndirectCountKHR = (VkCmdDrawIndirectCountKHR)
                    getProc.Invoke(device, "vkCmdDrawIndirectCountKHR"u8.AsPointer());
                vkCmdDrawIndexedIndirectCountKHR = (VkCmdDrawIndexedIndirectCountKHR)
                    getProc.Invoke(device, "vkCmdDrawIndexedIndirectCountKHR"u8.AsPointer());
                vkGetSemaphoreCounterValueKHR = (VkGetSemaphoreCounterValueKHR)
                    getProc.Invoke(device, "vkGetSemaphoreCounterValueKHR"u8.AsPointer());
                vkWaitSemaphoresKHR = (VkWaitSemaphoresKHR)getProc.Invoke(device, "vkWaitSemaphoresKHR"u8.AsPointer());
                vkSignalSemaphoreKHR = (VkSignalSemaphoreKHR)
                    getProc.Invoke(device, "vkSignalSemaphoreKHR"u8.AsPointer());
                vkCmdSetFragmentShadingRateKHR = (VkCmdSetFragmentShadingRateKHR)
                    getProc.Invoke(device, "vkCmdSetFragmentShadingRateKHR"u8.AsPointer());
                vkCmdSetRenderingAttachmentLocationsKHR = (VkCmdSetRenderingAttachmentLocationsKHR)
                    getProc.Invoke(device, "vkCmdSetRenderingAttachmentLocationsKHR"u8.AsPointer());
                vkCmdSetRenderingInputAttachmentIndicesKHR = (VkCmdSetRenderingInputAttachmentIndicesKHR)
                    getProc.Invoke(device, "vkCmdSetRenderingInputAttachmentIndicesKHR"u8.AsPointer());
                vkWaitForPresentKHR = (VkWaitForPresentKHR)getProc.Invoke(device, "vkWaitForPresentKHR"u8.AsPointer());
                vkGetBufferDeviceAddressKHR = (VkGetBufferDeviceAddressKHR)
                    getProc.Invoke(device, "vkGetBufferDeviceAddressKHR"u8.AsPointer());
                vkGetBufferOpaqueCaptureAddressKHR = (VkGetBufferOpaqueCaptureAddressKHR)
                    getProc.Invoke(device, "vkGetBufferOpaqueCaptureAddressKHR"u8.AsPointer());
                vkGetDeviceMemoryOpaqueCaptureAddressKHR = (VkGetDeviceMemoryOpaqueCaptureAddressKHR)
                    getProc.Invoke(device, "vkGetDeviceMemoryOpaqueCaptureAddressKHR"u8.AsPointer());
                vkCreateDeferredOperationKHR = (VkCreateDeferredOperationKHR)
                    getProc.Invoke(device, "vkCreateDeferredOperationKHR"u8.AsPointer());
                vkDestroyDeferredOperationKHR = (VkDestroyDeferredOperationKHR)
                    getProc.Invoke(device, "vkDestroyDeferredOperationKHR"u8.AsPointer());
                vkGetDeferredOperationMaxConcurrencyKHR = (VkGetDeferredOperationMaxConcurrencyKHR)
                    getProc.Invoke(device, "vkGetDeferredOperationMaxConcurrencyKHR"u8.AsPointer());
                vkGetDeferredOperationResultKHR = (VkGetDeferredOperationResultKHR)
                    getProc.Invoke(device, "vkGetDeferredOperationResultKHR"u8.AsPointer());
                vkDeferredOperationJoinKHR = (VkDeferredOperationJoinKHR)
                    getProc.Invoke(device, "vkDeferredOperationJoinKHR"u8.AsPointer());
                vkGetPipelineExecutablePropertiesKHR = (VkGetPipelineExecutablePropertiesKHR)
                    getProc.Invoke(device, "vkGetPipelineExecutablePropertiesKHR"u8.AsPointer());
                vkGetPipelineExecutableStatisticsKHR = (VkGetPipelineExecutableStatisticsKHR)
                    getProc.Invoke(device, "vkGetPipelineExecutableStatisticsKHR"u8.AsPointer());
                vkGetPipelineExecutableInternalRepresentationsKHR = (VkGetPipelineExecutableInternalRepresentationsKHR)
                    getProc.Invoke(device, "vkGetPipelineExecutableInternalRepresentationsKHR"u8.AsPointer());
                vkMapMemory2KHR = (VkMapMemory2KHR)getProc.Invoke(device, "vkMapMemory2KHR"u8.AsPointer());
                vkUnmapMemory2KHR = (VkUnmapMemory2KHR)getProc.Invoke(device, "vkUnmapMemory2KHR"u8.AsPointer());
                vkGetEncodedVideoSessionParametersKHR = (VkGetEncodedVideoSessionParametersKHR)
                    getProc.Invoke(device, "vkGetEncodedVideoSessionParametersKHR"u8.AsPointer());
                vkCmdEncodeVideoKHR = (VkCmdEncodeVideoKHR)getProc.Invoke(device, "vkCmdEncodeVideoKHR"u8.AsPointer());
                vkCmdSetEvent2KHR = (VkCmdSetEvent2KHR)getProc.Invoke(device, "vkCmdSetEvent2KHR"u8.AsPointer());
                vkCmdResetEvent2KHR = (VkCmdResetEvent2KHR)getProc.Invoke(device, "vkCmdResetEvent2KHR"u8.AsPointer());
                vkCmdWaitEvents2KHR = (VkCmdWaitEvents2KHR)getProc.Invoke(device, "vkCmdWaitEvents2KHR"u8.AsPointer());
                vkCmdPipelineBarrier2KHR = (VkCmdPipelineBarrier2KHR)
                    getProc.Invoke(device, "vkCmdPipelineBarrier2KHR"u8.AsPointer());
                vkCmdWriteTimestamp2KHR = (VkCmdWriteTimestamp2KHR)
                    getProc.Invoke(device, "vkCmdWriteTimestamp2KHR"u8.AsPointer());
                vkQueueSubmit2KHR = (VkQueueSubmit2KHR)getProc.Invoke(device, "vkQueueSubmit2KHR"u8.AsPointer());
                vkCmdBindIndexBuffer3KHR = (VkCmdBindIndexBuffer3KHR)
                    getProc.Invoke(device, "vkCmdBindIndexBuffer3KHR"u8.AsPointer());
                vkCmdBindVertexBuffers3KHR = (VkCmdBindVertexBuffers3KHR)
                    getProc.Invoke(device, "vkCmdBindVertexBuffers3KHR"u8.AsPointer());
                vkCmdDrawIndirect2KHR = (VkCmdDrawIndirect2KHR)
                    getProc.Invoke(device, "vkCmdDrawIndirect2KHR"u8.AsPointer());
                vkCmdDrawIndexedIndirect2KHR = (VkCmdDrawIndexedIndirect2KHR)
                    getProc.Invoke(device, "vkCmdDrawIndexedIndirect2KHR"u8.AsPointer());
                vkCmdDispatchIndirect2KHR = (VkCmdDispatchIndirect2KHR)
                    getProc.Invoke(device, "vkCmdDispatchIndirect2KHR"u8.AsPointer());
                vkCmdCopyMemoryKHR = (VkCmdCopyMemoryKHR)getProc.Invoke(device, "vkCmdCopyMemoryKHR"u8.AsPointer());
                vkCmdCopyMemoryToImageKHR = (VkCmdCopyMemoryToImageKHR)
                    getProc.Invoke(device, "vkCmdCopyMemoryToImageKHR"u8.AsPointer());
                vkCmdCopyImageToMemoryKHR = (VkCmdCopyImageToMemoryKHR)
                    getProc.Invoke(device, "vkCmdCopyImageToMemoryKHR"u8.AsPointer());
                vkCmdUpdateMemoryKHR = (VkCmdUpdateMemoryKHR)
                    getProc.Invoke(device, "vkCmdUpdateMemoryKHR"u8.AsPointer());
                vkCmdFillMemoryKHR = (VkCmdFillMemoryKHR)getProc.Invoke(device, "vkCmdFillMemoryKHR"u8.AsPointer());
                vkCmdCopyQueryPoolResultsToMemoryKHR = (VkCmdCopyQueryPoolResultsToMemoryKHR)
                    getProc.Invoke(device, "vkCmdCopyQueryPoolResultsToMemoryKHR"u8.AsPointer());
                vkCmdDrawIndirectCount2KHR = (VkCmdDrawIndirectCount2KHR)
                    getProc.Invoke(device, "vkCmdDrawIndirectCount2KHR"u8.AsPointer());
                vkCmdDrawIndexedIndirectCount2KHR = (VkCmdDrawIndexedIndirectCount2KHR)
                    getProc.Invoke(device, "vkCmdDrawIndexedIndirectCount2KHR"u8.AsPointer());
                vkCmdBeginConditionalRendering2EXT = (VkCmdBeginConditionalRendering2EXT)
                    getProc.Invoke(device, "vkCmdBeginConditionalRendering2EXT"u8.AsPointer());
                vkCmdBindTransformFeedbackBuffers2EXT = (VkCmdBindTransformFeedbackBuffers2EXT)
                    getProc.Invoke(device, "vkCmdBindTransformFeedbackBuffers2EXT"u8.AsPointer());
                vkCmdBeginTransformFeedback2EXT = (VkCmdBeginTransformFeedback2EXT)
                    getProc.Invoke(device, "vkCmdBeginTransformFeedback2EXT"u8.AsPointer());
                vkCmdEndTransformFeedback2EXT = (VkCmdEndTransformFeedback2EXT)
                    getProc.Invoke(device, "vkCmdEndTransformFeedback2EXT"u8.AsPointer());
                vkCmdDrawIndirectByteCount2EXT = (VkCmdDrawIndirectByteCount2EXT)
                    getProc.Invoke(device, "vkCmdDrawIndirectByteCount2EXT"u8.AsPointer());
                vkCmdDrawMeshTasksIndirect2EXT = (VkCmdDrawMeshTasksIndirect2EXT)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksIndirect2EXT"u8.AsPointer());
                vkCmdDrawMeshTasksIndirectCount2EXT = (VkCmdDrawMeshTasksIndirectCount2EXT)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksIndirectCount2EXT"u8.AsPointer());
                vkCmdWriteMarkerToMemoryAMD = (VkCmdWriteMarkerToMemoryAMD)
                    getProc.Invoke(device, "vkCmdWriteMarkerToMemoryAMD"u8.AsPointer());
                vkCreateAccelerationStructure2KHR = (VkCreateAccelerationStructure2KHR)
                    getProc.Invoke(device, "vkCreateAccelerationStructure2KHR"u8.AsPointer());
                vkCmdCopyBuffer2KHR = (VkCmdCopyBuffer2KHR)getProc.Invoke(device, "vkCmdCopyBuffer2KHR"u8.AsPointer());
                vkCmdCopyImage2KHR = (VkCmdCopyImage2KHR)getProc.Invoke(device, "vkCmdCopyImage2KHR"u8.AsPointer());
                vkCmdCopyBufferToImage2KHR = (VkCmdCopyBufferToImage2KHR)
                    getProc.Invoke(device, "vkCmdCopyBufferToImage2KHR"u8.AsPointer());
                vkCmdCopyImageToBuffer2KHR = (VkCmdCopyImageToBuffer2KHR)
                    getProc.Invoke(device, "vkCmdCopyImageToBuffer2KHR"u8.AsPointer());
                vkCmdBlitImage2KHR = (VkCmdBlitImage2KHR)getProc.Invoke(device, "vkCmdBlitImage2KHR"u8.AsPointer());
                vkCmdResolveImage2KHR = (VkCmdResolveImage2KHR)
                    getProc.Invoke(device, "vkCmdResolveImage2KHR"u8.AsPointer());
                vkCmdTraceRaysIndirect2KHR = (VkCmdTraceRaysIndirect2KHR)
                    getProc.Invoke(device, "vkCmdTraceRaysIndirect2KHR"u8.AsPointer());
                vkGetDeviceBufferMemoryRequirementsKHR = (VkGetDeviceBufferMemoryRequirementsKHR)
                    getProc.Invoke(device, "vkGetDeviceBufferMemoryRequirementsKHR"u8.AsPointer());
                vkGetDeviceImageMemoryRequirementsKHR = (VkGetDeviceImageMemoryRequirementsKHR)
                    getProc.Invoke(device, "vkGetDeviceImageMemoryRequirementsKHR"u8.AsPointer());
                vkGetDeviceImageSparseMemoryRequirementsKHR = (VkGetDeviceImageSparseMemoryRequirementsKHR)
                    getProc.Invoke(device, "vkGetDeviceImageSparseMemoryRequirementsKHR"u8.AsPointer());
                vkCmdBindIndexBuffer2KHR = (VkCmdBindIndexBuffer2KHR)
                    getProc.Invoke(device, "vkCmdBindIndexBuffer2KHR"u8.AsPointer());
                vkGetRenderingAreaGranularityKHR = (VkGetRenderingAreaGranularityKHR)
                    getProc.Invoke(device, "vkGetRenderingAreaGranularityKHR"u8.AsPointer());
                vkGetDeviceImageSubresourceLayoutKHR = (VkGetDeviceImageSubresourceLayoutKHR)
                    getProc.Invoke(device, "vkGetDeviceImageSubresourceLayoutKHR"u8.AsPointer());
                vkGetImageSubresourceLayout2KHR = (VkGetImageSubresourceLayout2KHR)
                    getProc.Invoke(device, "vkGetImageSubresourceLayout2KHR"u8.AsPointer());
                vkWaitForPresent2KHR = (VkWaitForPresent2KHR)
                    getProc.Invoke(device, "vkWaitForPresent2KHR"u8.AsPointer());
                vkCreatePipelineBinariesKHR = (VkCreatePipelineBinariesKHR)
                    getProc.Invoke(device, "vkCreatePipelineBinariesKHR"u8.AsPointer());
                vkDestroyPipelineBinaryKHR = (VkDestroyPipelineBinaryKHR)
                    getProc.Invoke(device, "vkDestroyPipelineBinaryKHR"u8.AsPointer());
                vkGetPipelineKeyKHR = (VkGetPipelineKeyKHR)getProc.Invoke(device, "vkGetPipelineKeyKHR"u8.AsPointer());
                vkGetPipelineBinaryDataKHR = (VkGetPipelineBinaryDataKHR)
                    getProc.Invoke(device, "vkGetPipelineBinaryDataKHR"u8.AsPointer());
                vkReleaseCapturedPipelineDataKHR = (VkReleaseCapturedPipelineDataKHR)
                    getProc.Invoke(device, "vkReleaseCapturedPipelineDataKHR"u8.AsPointer());
                vkReleaseSwapchainImagesKHR = (VkReleaseSwapchainImagesKHR)
                    getProc.Invoke(device, "vkReleaseSwapchainImagesKHR"u8.AsPointer());
                vkCmdSetLineStippleKHR = (VkCmdSetLineStippleKHR)
                    getProc.Invoke(device, "vkCmdSetLineStippleKHR"u8.AsPointer());
                vkGetCalibratedTimestampsKHR = (VkGetCalibratedTimestampsKHR)
                    getProc.Invoke(device, "vkGetCalibratedTimestampsKHR"u8.AsPointer());
                vkCmdBindDescriptorSets2KHR = (VkCmdBindDescriptorSets2KHR)
                    getProc.Invoke(device, "vkCmdBindDescriptorSets2KHR"u8.AsPointer());
                vkCmdPushConstants2KHR = (VkCmdPushConstants2KHR)
                    getProc.Invoke(device, "vkCmdPushConstants2KHR"u8.AsPointer());
                vkCmdPushDescriptorSet2KHR = (VkCmdPushDescriptorSet2KHR)
                    getProc.Invoke(device, "vkCmdPushDescriptorSet2KHR"u8.AsPointer());
                vkCmdPushDescriptorSetWithTemplate2KHR = (VkCmdPushDescriptorSetWithTemplate2KHR)
                    getProc.Invoke(device, "vkCmdPushDescriptorSetWithTemplate2KHR"u8.AsPointer());
                vkCmdSetDescriptorBufferOffsets2EXT = (VkCmdSetDescriptorBufferOffsets2EXT)
                    getProc.Invoke(device, "vkCmdSetDescriptorBufferOffsets2EXT"u8.AsPointer());
                vkCmdBindDescriptorBufferEmbeddedSamplers2EXT = (VkCmdBindDescriptorBufferEmbeddedSamplers2EXT)
                    getProc.Invoke(device, "vkCmdBindDescriptorBufferEmbeddedSamplers2EXT"u8.AsPointer());
                vkCmdCopyMemoryIndirectKHR = (VkCmdCopyMemoryIndirectKHR)
                    getProc.Invoke(device, "vkCmdCopyMemoryIndirectKHR"u8.AsPointer());
                vkCmdCopyMemoryToImageIndirectKHR = (VkCmdCopyMemoryToImageIndirectKHR)
                    getProc.Invoke(device, "vkCmdCopyMemoryToImageIndirectKHR"u8.AsPointer());
                vkGetDeviceFaultReportsKHR = (VkGetDeviceFaultReportsKHR)
                    getProc.Invoke(device, "vkGetDeviceFaultReportsKHR"u8.AsPointer());
                vkGetDeviceFaultDebugInfoKHR = (VkGetDeviceFaultDebugInfoKHR)
                    getProc.Invoke(device, "vkGetDeviceFaultDebugInfoKHR"u8.AsPointer());
                vkCmdEndRendering2KHR = (VkCmdEndRendering2KHR)
                    getProc.Invoke(device, "vkCmdEndRendering2KHR"u8.AsPointer());
                vkDebugMarkerSetObjectTagEXT = (VkDebugMarkerSetObjectTagEXT)
                    getProc.Invoke(device, "vkDebugMarkerSetObjectTagEXT"u8.AsPointer());
                vkDebugMarkerSetObjectNameEXT = (VkDebugMarkerSetObjectNameEXT)
                    getProc.Invoke(device, "vkDebugMarkerSetObjectNameEXT"u8.AsPointer());
                vkCmdDebugMarkerBeginEXT = (VkCmdDebugMarkerBeginEXT)
                    getProc.Invoke(device, "vkCmdDebugMarkerBeginEXT"u8.AsPointer());
                vkCmdDebugMarkerEndEXT = (VkCmdDebugMarkerEndEXT)
                    getProc.Invoke(device, "vkCmdDebugMarkerEndEXT"u8.AsPointer());
                vkCmdDebugMarkerInsertEXT = (VkCmdDebugMarkerInsertEXT)
                    getProc.Invoke(device, "vkCmdDebugMarkerInsertEXT"u8.AsPointer());
                vkCmdBindTransformFeedbackBuffersEXT = (VkCmdBindTransformFeedbackBuffersEXT)
                    getProc.Invoke(device, "vkCmdBindTransformFeedbackBuffersEXT"u8.AsPointer());
                vkCmdBeginTransformFeedbackEXT = (VkCmdBeginTransformFeedbackEXT)
                    getProc.Invoke(device, "vkCmdBeginTransformFeedbackEXT"u8.AsPointer());
                vkCmdEndTransformFeedbackEXT = (VkCmdEndTransformFeedbackEXT)
                    getProc.Invoke(device, "vkCmdEndTransformFeedbackEXT"u8.AsPointer());
                vkCmdBeginQueryIndexedEXT = (VkCmdBeginQueryIndexedEXT)
                    getProc.Invoke(device, "vkCmdBeginQueryIndexedEXT"u8.AsPointer());
                vkCmdEndQueryIndexedEXT = (VkCmdEndQueryIndexedEXT)
                    getProc.Invoke(device, "vkCmdEndQueryIndexedEXT"u8.AsPointer());
                vkCmdDrawIndirectByteCountEXT = (VkCmdDrawIndirectByteCountEXT)
                    getProc.Invoke(device, "vkCmdDrawIndirectByteCountEXT"u8.AsPointer());
                vkCreateCuModuleNVX = (VkCreateCuModuleNVX)getProc.Invoke(device, "vkCreateCuModuleNVX"u8.AsPointer());
                vkCreateCuFunctionNVX = (VkCreateCuFunctionNVX)
                    getProc.Invoke(device, "vkCreateCuFunctionNVX"u8.AsPointer());
                vkDestroyCuModuleNVX = (VkDestroyCuModuleNVX)
                    getProc.Invoke(device, "vkDestroyCuModuleNVX"u8.AsPointer());
                vkDestroyCuFunctionNVX = (VkDestroyCuFunctionNVX)
                    getProc.Invoke(device, "vkDestroyCuFunctionNVX"u8.AsPointer());
                vkCmdCuLaunchKernelNVX = (VkCmdCuLaunchKernelNVX)
                    getProc.Invoke(device, "vkCmdCuLaunchKernelNVX"u8.AsPointer());
                vkGetImageViewHandleNVX = (VkGetImageViewHandleNVX)
                    getProc.Invoke(device, "vkGetImageViewHandleNVX"u8.AsPointer());
                vkGetImageViewHandle64NVX = (VkGetImageViewHandle64NVX)
                    getProc.Invoke(device, "vkGetImageViewHandle64NVX"u8.AsPointer());
                vkGetImageViewAddressNVX = (VkGetImageViewAddressNVX)
                    getProc.Invoke(device, "vkGetImageViewAddressNVX"u8.AsPointer());
                vkGetDeviceCombinedImageSamplerIndexNVX = (VkGetDeviceCombinedImageSamplerIndexNVX)
                    getProc.Invoke(device, "vkGetDeviceCombinedImageSamplerIndexNVX"u8.AsPointer());
                vkCmdDrawIndirectCountAMD = (VkCmdDrawIndirectCountAMD)
                    getProc.Invoke(device, "vkCmdDrawIndirectCountAMD"u8.AsPointer());
                vkCmdDrawIndexedIndirectCountAMD = (VkCmdDrawIndexedIndirectCountAMD)
                    getProc.Invoke(device, "vkCmdDrawIndexedIndirectCountAMD"u8.AsPointer());
                vkGetShaderInfoAMD = (VkGetShaderInfoAMD)getProc.Invoke(device, "vkGetShaderInfoAMD"u8.AsPointer());
                vkCmdBeginConditionalRenderingEXT = (VkCmdBeginConditionalRenderingEXT)
                    getProc.Invoke(device, "vkCmdBeginConditionalRenderingEXT"u8.AsPointer());
                vkCmdEndConditionalRenderingEXT = (VkCmdEndConditionalRenderingEXT)
                    getProc.Invoke(device, "vkCmdEndConditionalRenderingEXT"u8.AsPointer());
                vkCmdSetViewportWScalingNV = (VkCmdSetViewportWScalingNV)
                    getProc.Invoke(device, "vkCmdSetViewportWScalingNV"u8.AsPointer());
                vkDisplayPowerControlEXT = (VkDisplayPowerControlEXT)
                    getProc.Invoke(device, "vkDisplayPowerControlEXT"u8.AsPointer());
                vkRegisterDeviceEventEXT = (VkRegisterDeviceEventEXT)
                    getProc.Invoke(device, "vkRegisterDeviceEventEXT"u8.AsPointer());
                vkRegisterDisplayEventEXT = (VkRegisterDisplayEventEXT)
                    getProc.Invoke(device, "vkRegisterDisplayEventEXT"u8.AsPointer());
                vkGetSwapchainCounterEXT = (VkGetSwapchainCounterEXT)
                    getProc.Invoke(device, "vkGetSwapchainCounterEXT"u8.AsPointer());
                vkGetRefreshCycleDurationGOOGLE = (VkGetRefreshCycleDurationGOOGLE)
                    getProc.Invoke(device, "vkGetRefreshCycleDurationGOOGLE"u8.AsPointer());
                vkGetPastPresentationTimingGOOGLE = (VkGetPastPresentationTimingGOOGLE)
                    getProc.Invoke(device, "vkGetPastPresentationTimingGOOGLE"u8.AsPointer());
                vkCmdSetDiscardRectangleEXT = (VkCmdSetDiscardRectangleEXT)
                    getProc.Invoke(device, "vkCmdSetDiscardRectangleEXT"u8.AsPointer());
                vkCmdSetDiscardRectangleEnableEXT = (VkCmdSetDiscardRectangleEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDiscardRectangleEnableEXT"u8.AsPointer());
                vkCmdSetDiscardRectangleModeEXT = (VkCmdSetDiscardRectangleModeEXT)
                    getProc.Invoke(device, "vkCmdSetDiscardRectangleModeEXT"u8.AsPointer());
                vkSetHdrMetadataEXT = (VkSetHdrMetadataEXT)getProc.Invoke(device, "vkSetHdrMetadataEXT"u8.AsPointer());
                vkSetDebugUtilsObjectNameEXT = (VkSetDebugUtilsObjectNameEXT)
                    getProc.Invoke(device, "vkSetDebugUtilsObjectNameEXT"u8.AsPointer());
                vkSetDebugUtilsObjectTagEXT = (VkSetDebugUtilsObjectTagEXT)
                    getProc.Invoke(device, "vkSetDebugUtilsObjectTagEXT"u8.AsPointer());
                vkQueueBeginDebugUtilsLabelEXT = (VkQueueBeginDebugUtilsLabelEXT)
                    getProc.Invoke(device, "vkQueueBeginDebugUtilsLabelEXT"u8.AsPointer());
                vkQueueEndDebugUtilsLabelEXT = (VkQueueEndDebugUtilsLabelEXT)
                    getProc.Invoke(device, "vkQueueEndDebugUtilsLabelEXT"u8.AsPointer());
                vkQueueInsertDebugUtilsLabelEXT = (VkQueueInsertDebugUtilsLabelEXT)
                    getProc.Invoke(device, "vkQueueInsertDebugUtilsLabelEXT"u8.AsPointer());
                vkCmdBeginDebugUtilsLabelEXT = (VkCmdBeginDebugUtilsLabelEXT)
                    getProc.Invoke(device, "vkCmdBeginDebugUtilsLabelEXT"u8.AsPointer());
                vkCmdEndDebugUtilsLabelEXT = (VkCmdEndDebugUtilsLabelEXT)
                    getProc.Invoke(device, "vkCmdEndDebugUtilsLabelEXT"u8.AsPointer());
                vkCmdInsertDebugUtilsLabelEXT = (VkCmdInsertDebugUtilsLabelEXT)
                    getProc.Invoke(device, "vkCmdInsertDebugUtilsLabelEXT"u8.AsPointer());
                vkCreateGpaSessionAMD = (VkCreateGpaSessionAMD)
                    getProc.Invoke(device, "vkCreateGpaSessionAMD"u8.AsPointer());
                vkDestroyGpaSessionAMD = (VkDestroyGpaSessionAMD)
                    getProc.Invoke(device, "vkDestroyGpaSessionAMD"u8.AsPointer());
                vkSetGpaDeviceClockModeAMD = (VkSetGpaDeviceClockModeAMD)
                    getProc.Invoke(device, "vkSetGpaDeviceClockModeAMD"u8.AsPointer());
                vkGetGpaDeviceClockInfoAMD = (VkGetGpaDeviceClockInfoAMD)
                    getProc.Invoke(device, "vkGetGpaDeviceClockInfoAMD"u8.AsPointer());
                vkCmdBeginGpaSessionAMD = (VkCmdBeginGpaSessionAMD)
                    getProc.Invoke(device, "vkCmdBeginGpaSessionAMD"u8.AsPointer());
                vkCmdEndGpaSessionAMD = (VkCmdEndGpaSessionAMD)
                    getProc.Invoke(device, "vkCmdEndGpaSessionAMD"u8.AsPointer());
                vkCmdBeginGpaSampleAMD = (VkCmdBeginGpaSampleAMD)
                    getProc.Invoke(device, "vkCmdBeginGpaSampleAMD"u8.AsPointer());
                vkCmdEndGpaSampleAMD = (VkCmdEndGpaSampleAMD)
                    getProc.Invoke(device, "vkCmdEndGpaSampleAMD"u8.AsPointer());
                vkGetGpaSessionStatusAMD = (VkGetGpaSessionStatusAMD)
                    getProc.Invoke(device, "vkGetGpaSessionStatusAMD"u8.AsPointer());
                vkGetGpaSessionResultsAMD = (VkGetGpaSessionResultsAMD)
                    getProc.Invoke(device, "vkGetGpaSessionResultsAMD"u8.AsPointer());
                vkResetGpaSessionAMD = (VkResetGpaSessionAMD)
                    getProc.Invoke(device, "vkResetGpaSessionAMD"u8.AsPointer());
                vkCmdCopyGpaSessionResultsAMD = (VkCmdCopyGpaSessionResultsAMD)
                    getProc.Invoke(device, "vkCmdCopyGpaSessionResultsAMD"u8.AsPointer());
                vkWriteSamplerDescriptorsEXT = (VkWriteSamplerDescriptorsEXT)
                    getProc.Invoke(device, "vkWriteSamplerDescriptorsEXT"u8.AsPointer());
                vkWriteResourceDescriptorsEXT = (VkWriteResourceDescriptorsEXT)
                    getProc.Invoke(device, "vkWriteResourceDescriptorsEXT"u8.AsPointer());
                vkCmdBindSamplerHeapEXT = (VkCmdBindSamplerHeapEXT)
                    getProc.Invoke(device, "vkCmdBindSamplerHeapEXT"u8.AsPointer());
                vkCmdBindResourceHeapEXT = (VkCmdBindResourceHeapEXT)
                    getProc.Invoke(device, "vkCmdBindResourceHeapEXT"u8.AsPointer());
                vkCmdPushDataEXT = (VkCmdPushDataEXT)getProc.Invoke(device, "vkCmdPushDataEXT"u8.AsPointer());
                vkGetImageOpaqueCaptureDataEXT = (VkGetImageOpaqueCaptureDataEXT)
                    getProc.Invoke(device, "vkGetImageOpaqueCaptureDataEXT"u8.AsPointer());
                vkRegisterCustomBorderColorEXT = (VkRegisterCustomBorderColorEXT)
                    getProc.Invoke(device, "vkRegisterCustomBorderColorEXT"u8.AsPointer());
                vkUnregisterCustomBorderColorEXT = (VkUnregisterCustomBorderColorEXT)
                    getProc.Invoke(device, "vkUnregisterCustomBorderColorEXT"u8.AsPointer());
                vkGetTensorOpaqueCaptureDataARM = (VkGetTensorOpaqueCaptureDataARM)
                    getProc.Invoke(device, "vkGetTensorOpaqueCaptureDataARM"u8.AsPointer());
                vkCmdSetSampleLocationsEXT = (VkCmdSetSampleLocationsEXT)
                    getProc.Invoke(device, "vkCmdSetSampleLocationsEXT"u8.AsPointer());
                vkGetImageDrmFormatModifierPropertiesEXT = (VkGetImageDrmFormatModifierPropertiesEXT)
                    getProc.Invoke(device, "vkGetImageDrmFormatModifierPropertiesEXT"u8.AsPointer());
                vkCreateValidationCacheEXT = (VkCreateValidationCacheEXT)
                    getProc.Invoke(device, "vkCreateValidationCacheEXT"u8.AsPointer());
                vkDestroyValidationCacheEXT = (VkDestroyValidationCacheEXT)
                    getProc.Invoke(device, "vkDestroyValidationCacheEXT"u8.AsPointer());
                vkMergeValidationCachesEXT = (VkMergeValidationCachesEXT)
                    getProc.Invoke(device, "vkMergeValidationCachesEXT"u8.AsPointer());
                vkGetValidationCacheDataEXT = (VkGetValidationCacheDataEXT)
                    getProc.Invoke(device, "vkGetValidationCacheDataEXT"u8.AsPointer());
                vkCmdBindShadingRateImageNV = (VkCmdBindShadingRateImageNV)
                    getProc.Invoke(device, "vkCmdBindShadingRateImageNV"u8.AsPointer());
                vkCmdSetViewportShadingRatePaletteNV = (VkCmdSetViewportShadingRatePaletteNV)
                    getProc.Invoke(device, "vkCmdSetViewportShadingRatePaletteNV"u8.AsPointer());
                vkCmdSetCoarseSampleOrderNV = (VkCmdSetCoarseSampleOrderNV)
                    getProc.Invoke(device, "vkCmdSetCoarseSampleOrderNV"u8.AsPointer());
                vkCreateAccelerationStructureNV = (VkCreateAccelerationStructureNV)
                    getProc.Invoke(device, "vkCreateAccelerationStructureNV"u8.AsPointer());
                vkDestroyAccelerationStructureNV = (VkDestroyAccelerationStructureNV)
                    getProc.Invoke(device, "vkDestroyAccelerationStructureNV"u8.AsPointer());
                vkGetAccelerationStructureMemoryRequirementsNV = (VkGetAccelerationStructureMemoryRequirementsNV)
                    getProc.Invoke(device, "vkGetAccelerationStructureMemoryRequirementsNV"u8.AsPointer());
                vkBindAccelerationStructureMemoryNV = (VkBindAccelerationStructureMemoryNV)
                    getProc.Invoke(device, "vkBindAccelerationStructureMemoryNV"u8.AsPointer());
                vkCmdBuildAccelerationStructureNV = (VkCmdBuildAccelerationStructureNV)
                    getProc.Invoke(device, "vkCmdBuildAccelerationStructureNV"u8.AsPointer());
                vkCmdCopyAccelerationStructureNV = (VkCmdCopyAccelerationStructureNV)
                    getProc.Invoke(device, "vkCmdCopyAccelerationStructureNV"u8.AsPointer());
                vkCmdTraceRaysNV = (VkCmdTraceRaysNV)getProc.Invoke(device, "vkCmdTraceRaysNV"u8.AsPointer());
                vkCreateRayTracingPipelinesNV = (VkCreateRayTracingPipelinesNV)
                    getProc.Invoke(device, "vkCreateRayTracingPipelinesNV"u8.AsPointer());
                vkGetRayTracingShaderGroupHandlesKHR = (VkGetRayTracingShaderGroupHandlesKHR)
                    getProc.Invoke(device, "vkGetRayTracingShaderGroupHandlesKHR"u8.AsPointer());
                vkGetRayTracingShaderGroupHandlesNV = (VkGetRayTracingShaderGroupHandlesNV)
                    getProc.Invoke(device, "vkGetRayTracingShaderGroupHandlesNV"u8.AsPointer());
                vkGetAccelerationStructureHandleNV = (VkGetAccelerationStructureHandleNV)
                    getProc.Invoke(device, "vkGetAccelerationStructureHandleNV"u8.AsPointer());
                vkCmdWriteAccelerationStructuresPropertiesNV = (VkCmdWriteAccelerationStructuresPropertiesNV)
                    getProc.Invoke(device, "vkCmdWriteAccelerationStructuresPropertiesNV"u8.AsPointer());
                vkCompileDeferredNV = (VkCompileDeferredNV)getProc.Invoke(device, "vkCompileDeferredNV"u8.AsPointer());
                vkGetMemoryHostPointerPropertiesEXT = (VkGetMemoryHostPointerPropertiesEXT)
                    getProc.Invoke(device, "vkGetMemoryHostPointerPropertiesEXT"u8.AsPointer());
                vkCmdWriteBufferMarkerAMD = (VkCmdWriteBufferMarkerAMD)
                    getProc.Invoke(device, "vkCmdWriteBufferMarkerAMD"u8.AsPointer());
                vkCmdWriteBufferMarker2AMD = (VkCmdWriteBufferMarker2AMD)
                    getProc.Invoke(device, "vkCmdWriteBufferMarker2AMD"u8.AsPointer());
                vkGetCalibratedTimestampsEXT = (VkGetCalibratedTimestampsEXT)
                    getProc.Invoke(device, "vkGetCalibratedTimestampsEXT"u8.AsPointer());
                vkCmdDrawMeshTasksNV = (VkCmdDrawMeshTasksNV)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksNV"u8.AsPointer());
                vkCmdDrawMeshTasksIndirectNV = (VkCmdDrawMeshTasksIndirectNV)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksIndirectNV"u8.AsPointer());
                vkCmdDrawMeshTasksIndirectCountNV = (VkCmdDrawMeshTasksIndirectCountNV)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksIndirectCountNV"u8.AsPointer());
                vkCmdSetExclusiveScissorEnableNV = (VkCmdSetExclusiveScissorEnableNV)
                    getProc.Invoke(device, "vkCmdSetExclusiveScissorEnableNV"u8.AsPointer());
                vkCmdSetExclusiveScissorNV = (VkCmdSetExclusiveScissorNV)
                    getProc.Invoke(device, "vkCmdSetExclusiveScissorNV"u8.AsPointer());
                vkCmdSetCheckpointNV = (VkCmdSetCheckpointNV)
                    getProc.Invoke(device, "vkCmdSetCheckpointNV"u8.AsPointer());
                vkGetQueueCheckpointDataNV = (VkGetQueueCheckpointDataNV)
                    getProc.Invoke(device, "vkGetQueueCheckpointDataNV"u8.AsPointer());
                vkGetQueueCheckpointData2NV = (VkGetQueueCheckpointData2NV)
                    getProc.Invoke(device, "vkGetQueueCheckpointData2NV"u8.AsPointer());
                vkSetSwapchainPresentTimingQueueSizeEXT = (VkSetSwapchainPresentTimingQueueSizeEXT)
                    getProc.Invoke(device, "vkSetSwapchainPresentTimingQueueSizeEXT"u8.AsPointer());
                vkGetSwapchainTimingPropertiesEXT = (VkGetSwapchainTimingPropertiesEXT)
                    getProc.Invoke(device, "vkGetSwapchainTimingPropertiesEXT"u8.AsPointer());
                vkGetSwapchainTimeDomainPropertiesEXT = (VkGetSwapchainTimeDomainPropertiesEXT)
                    getProc.Invoke(device, "vkGetSwapchainTimeDomainPropertiesEXT"u8.AsPointer());
                vkGetPastPresentationTimingEXT = (VkGetPastPresentationTimingEXT)
                    getProc.Invoke(device, "vkGetPastPresentationTimingEXT"u8.AsPointer());
                vkInitializePerformanceApiINTEL = (VkInitializePerformanceApiINTEL)
                    getProc.Invoke(device, "vkInitializePerformanceApiINTEL"u8.AsPointer());
                vkUninitializePerformanceApiINTEL = (VkUninitializePerformanceApiINTEL)
                    getProc.Invoke(device, "vkUninitializePerformanceApiINTEL"u8.AsPointer());
                vkCmdSetPerformanceMarkerINTEL = (VkCmdSetPerformanceMarkerINTEL)
                    getProc.Invoke(device, "vkCmdSetPerformanceMarkerINTEL"u8.AsPointer());
                vkCmdSetPerformanceStreamMarkerINTEL = (VkCmdSetPerformanceStreamMarkerINTEL)
                    getProc.Invoke(device, "vkCmdSetPerformanceStreamMarkerINTEL"u8.AsPointer());
                vkCmdSetPerformanceOverrideINTEL = (VkCmdSetPerformanceOverrideINTEL)
                    getProc.Invoke(device, "vkCmdSetPerformanceOverrideINTEL"u8.AsPointer());
                vkAcquirePerformanceConfigurationINTEL = (VkAcquirePerformanceConfigurationINTEL)
                    getProc.Invoke(device, "vkAcquirePerformanceConfigurationINTEL"u8.AsPointer());
                vkReleasePerformanceConfigurationINTEL = (VkReleasePerformanceConfigurationINTEL)
                    getProc.Invoke(device, "vkReleasePerformanceConfigurationINTEL"u8.AsPointer());
                vkQueueSetPerformanceConfigurationINTEL = (VkQueueSetPerformanceConfigurationINTEL)
                    getProc.Invoke(device, "vkQueueSetPerformanceConfigurationINTEL"u8.AsPointer());
                vkGetPerformanceParameterINTEL = (VkGetPerformanceParameterINTEL)
                    getProc.Invoke(device, "vkGetPerformanceParameterINTEL"u8.AsPointer());
                vkSetLocalDimmingAMD = (VkSetLocalDimmingAMD)
                    getProc.Invoke(device, "vkSetLocalDimmingAMD"u8.AsPointer());
                vkGetBufferDeviceAddressEXT = (VkGetBufferDeviceAddressEXT)
                    getProc.Invoke(device, "vkGetBufferDeviceAddressEXT"u8.AsPointer());
                vkCmdSetLineStippleEXT = (VkCmdSetLineStippleEXT)
                    getProc.Invoke(device, "vkCmdSetLineStippleEXT"u8.AsPointer());
                vkResetQueryPoolEXT = (VkResetQueryPoolEXT)getProc.Invoke(device, "vkResetQueryPoolEXT"u8.AsPointer());
                vkCmdSetCullModeEXT = (VkCmdSetCullModeEXT)getProc.Invoke(device, "vkCmdSetCullModeEXT"u8.AsPointer());
                vkCmdSetFrontFaceEXT = (VkCmdSetFrontFaceEXT)
                    getProc.Invoke(device, "vkCmdSetFrontFaceEXT"u8.AsPointer());
                vkCmdSetPrimitiveTopologyEXT = (VkCmdSetPrimitiveTopologyEXT)
                    getProc.Invoke(device, "vkCmdSetPrimitiveTopologyEXT"u8.AsPointer());
                vkCmdSetViewportWithCountEXT = (VkCmdSetViewportWithCountEXT)
                    getProc.Invoke(device, "vkCmdSetViewportWithCountEXT"u8.AsPointer());
                vkCmdSetScissorWithCountEXT = (VkCmdSetScissorWithCountEXT)
                    getProc.Invoke(device, "vkCmdSetScissorWithCountEXT"u8.AsPointer());
                vkCmdBindVertexBuffers2EXT = (VkCmdBindVertexBuffers2EXT)
                    getProc.Invoke(device, "vkCmdBindVertexBuffers2EXT"u8.AsPointer());
                vkCmdSetDepthTestEnableEXT = (VkCmdSetDepthTestEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDepthTestEnableEXT"u8.AsPointer());
                vkCmdSetDepthWriteEnableEXT = (VkCmdSetDepthWriteEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDepthWriteEnableEXT"u8.AsPointer());
                vkCmdSetDepthCompareOpEXT = (VkCmdSetDepthCompareOpEXT)
                    getProc.Invoke(device, "vkCmdSetDepthCompareOpEXT"u8.AsPointer());
                vkCmdSetDepthBoundsTestEnableEXT = (VkCmdSetDepthBoundsTestEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDepthBoundsTestEnableEXT"u8.AsPointer());
                vkCmdSetStencilTestEnableEXT = (VkCmdSetStencilTestEnableEXT)
                    getProc.Invoke(device, "vkCmdSetStencilTestEnableEXT"u8.AsPointer());
                vkCmdSetStencilOpEXT = (VkCmdSetStencilOpEXT)
                    getProc.Invoke(device, "vkCmdSetStencilOpEXT"u8.AsPointer());
                vkCopyMemoryToImageEXT = (VkCopyMemoryToImageEXT)
                    getProc.Invoke(device, "vkCopyMemoryToImageEXT"u8.AsPointer());
                vkCopyImageToMemoryEXT = (VkCopyImageToMemoryEXT)
                    getProc.Invoke(device, "vkCopyImageToMemoryEXT"u8.AsPointer());
                vkCopyImageToImageEXT = (VkCopyImageToImageEXT)
                    getProc.Invoke(device, "vkCopyImageToImageEXT"u8.AsPointer());
                vkTransitionImageLayoutEXT = (VkTransitionImageLayoutEXT)
                    getProc.Invoke(device, "vkTransitionImageLayoutEXT"u8.AsPointer());
                vkGetImageSubresourceLayout2EXT = (VkGetImageSubresourceLayout2EXT)
                    getProc.Invoke(device, "vkGetImageSubresourceLayout2EXT"u8.AsPointer());
                vkReleaseSwapchainImagesEXT = (VkReleaseSwapchainImagesEXT)
                    getProc.Invoke(device, "vkReleaseSwapchainImagesEXT"u8.AsPointer());
                vkGetGeneratedCommandsMemoryRequirementsNV = (VkGetGeneratedCommandsMemoryRequirementsNV)
                    getProc.Invoke(device, "vkGetGeneratedCommandsMemoryRequirementsNV"u8.AsPointer());
                vkCmdPreprocessGeneratedCommandsNV = (VkCmdPreprocessGeneratedCommandsNV)
                    getProc.Invoke(device, "vkCmdPreprocessGeneratedCommandsNV"u8.AsPointer());
                vkCmdExecuteGeneratedCommandsNV = (VkCmdExecuteGeneratedCommandsNV)
                    getProc.Invoke(device, "vkCmdExecuteGeneratedCommandsNV"u8.AsPointer());
                vkCmdBindPipelineShaderGroupNV = (VkCmdBindPipelineShaderGroupNV)
                    getProc.Invoke(device, "vkCmdBindPipelineShaderGroupNV"u8.AsPointer());
                vkCreateIndirectCommandsLayoutNV = (VkCreateIndirectCommandsLayoutNV)
                    getProc.Invoke(device, "vkCreateIndirectCommandsLayoutNV"u8.AsPointer());
                vkDestroyIndirectCommandsLayoutNV = (VkDestroyIndirectCommandsLayoutNV)
                    getProc.Invoke(device, "vkDestroyIndirectCommandsLayoutNV"u8.AsPointer());
                vkCmdSetDepthBias2EXT = (VkCmdSetDepthBias2EXT)
                    getProc.Invoke(device, "vkCmdSetDepthBias2EXT"u8.AsPointer());
                vkCreatePrivateDataSlotEXT = (VkCreatePrivateDataSlotEXT)
                    getProc.Invoke(device, "vkCreatePrivateDataSlotEXT"u8.AsPointer());
                vkDestroyPrivateDataSlotEXT = (VkDestroyPrivateDataSlotEXT)
                    getProc.Invoke(device, "vkDestroyPrivateDataSlotEXT"u8.AsPointer());
                vkSetPrivateDataEXT = (VkSetPrivateDataEXT)getProc.Invoke(device, "vkSetPrivateDataEXT"u8.AsPointer());
                vkGetPrivateDataEXT = (VkGetPrivateDataEXT)getProc.Invoke(device, "vkGetPrivateDataEXT"u8.AsPointer());
                vkQueueSetPerfHintQCOM = (VkQueueSetPerfHintQCOM)
                    getProc.Invoke(device, "vkQueueSetPerfHintQCOM"u8.AsPointer());
                vkCmdDispatchTileQCOM = (VkCmdDispatchTileQCOM)
                    getProc.Invoke(device, "vkCmdDispatchTileQCOM"u8.AsPointer());
                vkCmdBeginPerTileExecutionQCOM = (VkCmdBeginPerTileExecutionQCOM)
                    getProc.Invoke(device, "vkCmdBeginPerTileExecutionQCOM"u8.AsPointer());
                vkCmdEndPerTileExecutionQCOM = (VkCmdEndPerTileExecutionQCOM)
                    getProc.Invoke(device, "vkCmdEndPerTileExecutionQCOM"u8.AsPointer());
                vkSetLatencySleepModeLegacyNV = (VkSetLatencySleepModeLegacyNV)
                    getProc.Invoke(device, "vkSetLatencySleepModeLegacyNV"u8.AsPointer());
                vkLatencySleepLegacyNV = (VkLatencySleepLegacyNV)
                    getProc.Invoke(device, "vkLatencySleepLegacyNV"u8.AsPointer());
                vkSetLatencyMarkerLegacyNV = (VkSetLatencyMarkerLegacyNV)
                    getProc.Invoke(device, "vkSetLatencyMarkerLegacyNV"u8.AsPointer());
                vkGetLatencyTimingsLegacyNV = (VkGetLatencyTimingsLegacyNV)
                    getProc.Invoke(device, "vkGetLatencyTimingsLegacyNV"u8.AsPointer());
                vkQueueNotifyOutOfBandLegacyNV = (VkQueueNotifyOutOfBandLegacyNV)
                    getProc.Invoke(device, "vkQueueNotifyOutOfBandLegacyNV"u8.AsPointer());
                vkGetSleepStatusLegacyNV = (VkGetSleepStatusLegacyNV)
                    getProc.Invoke(device, "vkGetSleepStatusLegacyNV"u8.AsPointer());
                vkShutdownLatencyDeviceLegacyNV = (VkShutdownLatencyDeviceLegacyNV)
                    getProc.Invoke(device, "vkShutdownLatencyDeviceLegacyNV"u8.AsPointer());
                vkGetDescriptorSetLayoutSizeEXT = (VkGetDescriptorSetLayoutSizeEXT)
                    getProc.Invoke(device, "vkGetDescriptorSetLayoutSizeEXT"u8.AsPointer());
                vkGetDescriptorSetLayoutBindingOffsetEXT = (VkGetDescriptorSetLayoutBindingOffsetEXT)
                    getProc.Invoke(device, "vkGetDescriptorSetLayoutBindingOffsetEXT"u8.AsPointer());
                vkGetDescriptorEXT = (VkGetDescriptorEXT)getProc.Invoke(device, "vkGetDescriptorEXT"u8.AsPointer());
                vkCmdBindDescriptorBuffersEXT = (VkCmdBindDescriptorBuffersEXT)
                    getProc.Invoke(device, "vkCmdBindDescriptorBuffersEXT"u8.AsPointer());
                vkCmdSetDescriptorBufferOffsetsEXT = (VkCmdSetDescriptorBufferOffsetsEXT)
                    getProc.Invoke(device, "vkCmdSetDescriptorBufferOffsetsEXT"u8.AsPointer());
                vkCmdBindDescriptorBufferEmbeddedSamplersEXT = (VkCmdBindDescriptorBufferEmbeddedSamplersEXT)
                    getProc.Invoke(device, "vkCmdBindDescriptorBufferEmbeddedSamplersEXT"u8.AsPointer());
                vkGetBufferOpaqueCaptureDescriptorDataEXT = (VkGetBufferOpaqueCaptureDescriptorDataEXT)
                    getProc.Invoke(device, "vkGetBufferOpaqueCaptureDescriptorDataEXT"u8.AsPointer());
                vkGetImageOpaqueCaptureDescriptorDataEXT = (VkGetImageOpaqueCaptureDescriptorDataEXT)
                    getProc.Invoke(device, "vkGetImageOpaqueCaptureDescriptorDataEXT"u8.AsPointer());
                vkGetImageViewOpaqueCaptureDescriptorDataEXT = (VkGetImageViewOpaqueCaptureDescriptorDataEXT)
                    getProc.Invoke(device, "vkGetImageViewOpaqueCaptureDescriptorDataEXT"u8.AsPointer());
                vkGetSamplerOpaqueCaptureDescriptorDataEXT = (VkGetSamplerOpaqueCaptureDescriptorDataEXT)
                    getProc.Invoke(device, "vkGetSamplerOpaqueCaptureDescriptorDataEXT"u8.AsPointer());
                vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT =
                    (VkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT)
                        getProc.Invoke(
                            device,
                            "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT"u8.AsPointer()
                        );
                vkCmdSetFragmentShadingRateEnumNV = (VkCmdSetFragmentShadingRateEnumNV)
                    getProc.Invoke(device, "vkCmdSetFragmentShadingRateEnumNV"u8.AsPointer());
                vkGetDeviceFaultInfoEXT = (VkGetDeviceFaultInfoEXT)
                    getProc.Invoke(device, "vkGetDeviceFaultInfoEXT"u8.AsPointer());
                vkCmdSetVertexInputEXT = (VkCmdSetVertexInputEXT)
                    getProc.Invoke(device, "vkCmdSetVertexInputEXT"u8.AsPointer());
                vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI = (VkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI)
                    getProc.Invoke(device, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI"u8.AsPointer());
                vkCmdSubpassShadingHUAWEI = (VkCmdSubpassShadingHUAWEI)
                    getProc.Invoke(device, "vkCmdSubpassShadingHUAWEI"u8.AsPointer());
                vkCmdBindInvocationMaskHUAWEI = (VkCmdBindInvocationMaskHUAWEI)
                    getProc.Invoke(device, "vkCmdBindInvocationMaskHUAWEI"u8.AsPointer());
                vkGetMemoryRemoteAddressNV = (VkGetMemoryRemoteAddressNV)
                    getProc.Invoke(device, "vkGetMemoryRemoteAddressNV"u8.AsPointer());
                vkGetPipelinePropertiesEXT = (VkGetPipelinePropertiesEXT)
                    getProc.Invoke(device, "vkGetPipelinePropertiesEXT"u8.AsPointer());
                vkCmdSetPatchControlPointsEXT = (VkCmdSetPatchControlPointsEXT)
                    getProc.Invoke(device, "vkCmdSetPatchControlPointsEXT"u8.AsPointer());
                vkCmdSetRasterizerDiscardEnableEXT = (VkCmdSetRasterizerDiscardEnableEXT)
                    getProc.Invoke(device, "vkCmdSetRasterizerDiscardEnableEXT"u8.AsPointer());
                vkCmdSetDepthBiasEnableEXT = (VkCmdSetDepthBiasEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDepthBiasEnableEXT"u8.AsPointer());
                vkCmdSetLogicOpEXT = (VkCmdSetLogicOpEXT)getProc.Invoke(device, "vkCmdSetLogicOpEXT"u8.AsPointer());
                vkCmdSetPrimitiveRestartEnableEXT = (VkCmdSetPrimitiveRestartEnableEXT)
                    getProc.Invoke(device, "vkCmdSetPrimitiveRestartEnableEXT"u8.AsPointer());
                vkCmdSetColorWriteEnableEXT = (VkCmdSetColorWriteEnableEXT)
                    getProc.Invoke(device, "vkCmdSetColorWriteEnableEXT"u8.AsPointer());
                vkCmdDrawMultiEXT = (VkCmdDrawMultiEXT)getProc.Invoke(device, "vkCmdDrawMultiEXT"u8.AsPointer());
                vkCmdDrawMultiIndexedEXT = (VkCmdDrawMultiIndexedEXT)
                    getProc.Invoke(device, "vkCmdDrawMultiIndexedEXT"u8.AsPointer());
                vkCreateMicromapEXT = (VkCreateMicromapEXT)getProc.Invoke(device, "vkCreateMicromapEXT"u8.AsPointer());
                vkDestroyMicromapEXT = (VkDestroyMicromapEXT)
                    getProc.Invoke(device, "vkDestroyMicromapEXT"u8.AsPointer());
                vkCmdBuildMicromapsEXT = (VkCmdBuildMicromapsEXT)
                    getProc.Invoke(device, "vkCmdBuildMicromapsEXT"u8.AsPointer());
                vkBuildMicromapsEXT = (VkBuildMicromapsEXT)getProc.Invoke(device, "vkBuildMicromapsEXT"u8.AsPointer());
                vkCopyMicromapEXT = (VkCopyMicromapEXT)getProc.Invoke(device, "vkCopyMicromapEXT"u8.AsPointer());
                vkCopyMicromapToMemoryEXT = (VkCopyMicromapToMemoryEXT)
                    getProc.Invoke(device, "vkCopyMicromapToMemoryEXT"u8.AsPointer());
                vkCopyMemoryToMicromapEXT = (VkCopyMemoryToMicromapEXT)
                    getProc.Invoke(device, "vkCopyMemoryToMicromapEXT"u8.AsPointer());
                vkWriteMicromapsPropertiesEXT = (VkWriteMicromapsPropertiesEXT)
                    getProc.Invoke(device, "vkWriteMicromapsPropertiesEXT"u8.AsPointer());
                vkCmdCopyMicromapEXT = (VkCmdCopyMicromapEXT)
                    getProc.Invoke(device, "vkCmdCopyMicromapEXT"u8.AsPointer());
                vkCmdCopyMicromapToMemoryEXT = (VkCmdCopyMicromapToMemoryEXT)
                    getProc.Invoke(device, "vkCmdCopyMicromapToMemoryEXT"u8.AsPointer());
                vkCmdCopyMemoryToMicromapEXT = (VkCmdCopyMemoryToMicromapEXT)
                    getProc.Invoke(device, "vkCmdCopyMemoryToMicromapEXT"u8.AsPointer());
                vkCmdWriteMicromapsPropertiesEXT = (VkCmdWriteMicromapsPropertiesEXT)
                    getProc.Invoke(device, "vkCmdWriteMicromapsPropertiesEXT"u8.AsPointer());
                vkGetDeviceMicromapCompatibilityEXT = (VkGetDeviceMicromapCompatibilityEXT)
                    getProc.Invoke(device, "vkGetDeviceMicromapCompatibilityEXT"u8.AsPointer());
                vkGetMicromapBuildSizesEXT = (VkGetMicromapBuildSizesEXT)
                    getProc.Invoke(device, "vkGetMicromapBuildSizesEXT"u8.AsPointer());
                vkCmdDrawClusterHUAWEI = (VkCmdDrawClusterHUAWEI)
                    getProc.Invoke(device, "vkCmdDrawClusterHUAWEI"u8.AsPointer());
                vkCmdDrawClusterIndirectHUAWEI = (VkCmdDrawClusterIndirectHUAWEI)
                    getProc.Invoke(device, "vkCmdDrawClusterIndirectHUAWEI"u8.AsPointer());
                vkSetDeviceMemoryPriorityEXT = (VkSetDeviceMemoryPriorityEXT)
                    getProc.Invoke(device, "vkSetDeviceMemoryPriorityEXT"u8.AsPointer());
                vkCmdSetDispatchParametersARM = (VkCmdSetDispatchParametersARM)
                    getProc.Invoke(device, "vkCmdSetDispatchParametersARM"u8.AsPointer());
                vkGetDescriptorSetLayoutHostMappingInfoVALVE = (VkGetDescriptorSetLayoutHostMappingInfoVALVE)
                    getProc.Invoke(device, "vkGetDescriptorSetLayoutHostMappingInfoVALVE"u8.AsPointer());
                vkGetDescriptorSetHostMappingVALVE = (VkGetDescriptorSetHostMappingVALVE)
                    getProc.Invoke(device, "vkGetDescriptorSetHostMappingVALVE"u8.AsPointer());
                vkCmdCopyMemoryIndirectNV = (VkCmdCopyMemoryIndirectNV)
                    getProc.Invoke(device, "vkCmdCopyMemoryIndirectNV"u8.AsPointer());
                vkCmdCopyMemoryToImageIndirectNV = (VkCmdCopyMemoryToImageIndirectNV)
                    getProc.Invoke(device, "vkCmdCopyMemoryToImageIndirectNV"u8.AsPointer());
                vkCmdDecompressMemoryNV = (VkCmdDecompressMemoryNV)
                    getProc.Invoke(device, "vkCmdDecompressMemoryNV"u8.AsPointer());
                vkCmdDecompressMemoryIndirectCountNV = (VkCmdDecompressMemoryIndirectCountNV)
                    getProc.Invoke(device, "vkCmdDecompressMemoryIndirectCountNV"u8.AsPointer());
                vkGetPipelineIndirectMemoryRequirementsNV = (VkGetPipelineIndirectMemoryRequirementsNV)
                    getProc.Invoke(device, "vkGetPipelineIndirectMemoryRequirementsNV"u8.AsPointer());
                vkCmdUpdatePipelineIndirectBufferNV = (VkCmdUpdatePipelineIndirectBufferNV)
                    getProc.Invoke(device, "vkCmdUpdatePipelineIndirectBufferNV"u8.AsPointer());
                vkGetPipelineIndirectDeviceAddressNV = (VkGetPipelineIndirectDeviceAddressNV)
                    getProc.Invoke(device, "vkGetPipelineIndirectDeviceAddressNV"u8.AsPointer());
                vkCmdSetDepthClampEnableEXT = (VkCmdSetDepthClampEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDepthClampEnableEXT"u8.AsPointer());
                vkCmdSetPolygonModeEXT = (VkCmdSetPolygonModeEXT)
                    getProc.Invoke(device, "vkCmdSetPolygonModeEXT"u8.AsPointer());
                vkCmdSetRasterizationSamplesEXT = (VkCmdSetRasterizationSamplesEXT)
                    getProc.Invoke(device, "vkCmdSetRasterizationSamplesEXT"u8.AsPointer());
                vkCmdSetSampleMaskEXT = (VkCmdSetSampleMaskEXT)
                    getProc.Invoke(device, "vkCmdSetSampleMaskEXT"u8.AsPointer());
                vkCmdSetAlphaToCoverageEnableEXT = (VkCmdSetAlphaToCoverageEnableEXT)
                    getProc.Invoke(device, "vkCmdSetAlphaToCoverageEnableEXT"u8.AsPointer());
                vkCmdSetAlphaToOneEnableEXT = (VkCmdSetAlphaToOneEnableEXT)
                    getProc.Invoke(device, "vkCmdSetAlphaToOneEnableEXT"u8.AsPointer());
                vkCmdSetLogicOpEnableEXT = (VkCmdSetLogicOpEnableEXT)
                    getProc.Invoke(device, "vkCmdSetLogicOpEnableEXT"u8.AsPointer());
                vkCmdSetColorBlendEnableEXT = (VkCmdSetColorBlendEnableEXT)
                    getProc.Invoke(device, "vkCmdSetColorBlendEnableEXT"u8.AsPointer());
                vkCmdSetColorBlendEquationEXT = (VkCmdSetColorBlendEquationEXT)
                    getProc.Invoke(device, "vkCmdSetColorBlendEquationEXT"u8.AsPointer());
                vkCmdSetColorWriteMaskEXT = (VkCmdSetColorWriteMaskEXT)
                    getProc.Invoke(device, "vkCmdSetColorWriteMaskEXT"u8.AsPointer());
                vkCmdSetTessellationDomainOriginEXT = (VkCmdSetTessellationDomainOriginEXT)
                    getProc.Invoke(device, "vkCmdSetTessellationDomainOriginEXT"u8.AsPointer());
                vkCmdSetRasterizationStreamEXT = (VkCmdSetRasterizationStreamEXT)
                    getProc.Invoke(device, "vkCmdSetRasterizationStreamEXT"u8.AsPointer());
                vkCmdSetConservativeRasterizationModeEXT = (VkCmdSetConservativeRasterizationModeEXT)
                    getProc.Invoke(device, "vkCmdSetConservativeRasterizationModeEXT"u8.AsPointer());
                vkCmdSetExtraPrimitiveOverestimationSizeEXT = (VkCmdSetExtraPrimitiveOverestimationSizeEXT)
                    getProc.Invoke(device, "vkCmdSetExtraPrimitiveOverestimationSizeEXT"u8.AsPointer());
                vkCmdSetDepthClipEnableEXT = (VkCmdSetDepthClipEnableEXT)
                    getProc.Invoke(device, "vkCmdSetDepthClipEnableEXT"u8.AsPointer());
                vkCmdSetSampleLocationsEnableEXT = (VkCmdSetSampleLocationsEnableEXT)
                    getProc.Invoke(device, "vkCmdSetSampleLocationsEnableEXT"u8.AsPointer());
                vkCmdSetColorBlendAdvancedEXT = (VkCmdSetColorBlendAdvancedEXT)
                    getProc.Invoke(device, "vkCmdSetColorBlendAdvancedEXT"u8.AsPointer());
                vkCmdSetProvokingVertexModeEXT = (VkCmdSetProvokingVertexModeEXT)
                    getProc.Invoke(device, "vkCmdSetProvokingVertexModeEXT"u8.AsPointer());
                vkCmdSetLineRasterizationModeEXT = (VkCmdSetLineRasterizationModeEXT)
                    getProc.Invoke(device, "vkCmdSetLineRasterizationModeEXT"u8.AsPointer());
                vkCmdSetLineStippleEnableEXT = (VkCmdSetLineStippleEnableEXT)
                    getProc.Invoke(device, "vkCmdSetLineStippleEnableEXT"u8.AsPointer());
                vkCmdSetDepthClipNegativeOneToOneEXT = (VkCmdSetDepthClipNegativeOneToOneEXT)
                    getProc.Invoke(device, "vkCmdSetDepthClipNegativeOneToOneEXT"u8.AsPointer());
                vkCmdSetViewportWScalingEnableNV = (VkCmdSetViewportWScalingEnableNV)
                    getProc.Invoke(device, "vkCmdSetViewportWScalingEnableNV"u8.AsPointer());
                vkCmdSetViewportSwizzleNV = (VkCmdSetViewportSwizzleNV)
                    getProc.Invoke(device, "vkCmdSetViewportSwizzleNV"u8.AsPointer());
                vkCmdSetCoverageToColorEnableNV = (VkCmdSetCoverageToColorEnableNV)
                    getProc.Invoke(device, "vkCmdSetCoverageToColorEnableNV"u8.AsPointer());
                vkCmdSetCoverageToColorLocationNV = (VkCmdSetCoverageToColorLocationNV)
                    getProc.Invoke(device, "vkCmdSetCoverageToColorLocationNV"u8.AsPointer());
                vkCmdSetCoverageModulationModeNV = (VkCmdSetCoverageModulationModeNV)
                    getProc.Invoke(device, "vkCmdSetCoverageModulationModeNV"u8.AsPointer());
                vkCmdSetCoverageModulationTableEnableNV = (VkCmdSetCoverageModulationTableEnableNV)
                    getProc.Invoke(device, "vkCmdSetCoverageModulationTableEnableNV"u8.AsPointer());
                vkCmdSetCoverageModulationTableNV = (VkCmdSetCoverageModulationTableNV)
                    getProc.Invoke(device, "vkCmdSetCoverageModulationTableNV"u8.AsPointer());
                vkCmdSetShadingRateImageEnableNV = (VkCmdSetShadingRateImageEnableNV)
                    getProc.Invoke(device, "vkCmdSetShadingRateImageEnableNV"u8.AsPointer());
                vkCmdSetRepresentativeFragmentTestEnableNV = (VkCmdSetRepresentativeFragmentTestEnableNV)
                    getProc.Invoke(device, "vkCmdSetRepresentativeFragmentTestEnableNV"u8.AsPointer());
                vkCmdSetCoverageReductionModeNV = (VkCmdSetCoverageReductionModeNV)
                    getProc.Invoke(device, "vkCmdSetCoverageReductionModeNV"u8.AsPointer());
                vkCreateTensorARM = (VkCreateTensorARM)getProc.Invoke(device, "vkCreateTensorARM"u8.AsPointer());
                vkDestroyTensorARM = (VkDestroyTensorARM)getProc.Invoke(device, "vkDestroyTensorARM"u8.AsPointer());
                vkCreateTensorViewARM = (VkCreateTensorViewARM)
                    getProc.Invoke(device, "vkCreateTensorViewARM"u8.AsPointer());
                vkDestroyTensorViewARM = (VkDestroyTensorViewARM)
                    getProc.Invoke(device, "vkDestroyTensorViewARM"u8.AsPointer());
                vkGetTensorMemoryRequirementsARM = (VkGetTensorMemoryRequirementsARM)
                    getProc.Invoke(device, "vkGetTensorMemoryRequirementsARM"u8.AsPointer());
                vkBindTensorMemoryARM = (VkBindTensorMemoryARM)
                    getProc.Invoke(device, "vkBindTensorMemoryARM"u8.AsPointer());
                vkGetDeviceTensorMemoryRequirementsARM = (VkGetDeviceTensorMemoryRequirementsARM)
                    getProc.Invoke(device, "vkGetDeviceTensorMemoryRequirementsARM"u8.AsPointer());
                vkCmdCopyTensorARM = (VkCmdCopyTensorARM)getProc.Invoke(device, "vkCmdCopyTensorARM"u8.AsPointer());
                vkGetTensorOpaqueCaptureDescriptorDataARM = (VkGetTensorOpaqueCaptureDescriptorDataARM)
                    getProc.Invoke(device, "vkGetTensorOpaqueCaptureDescriptorDataARM"u8.AsPointer());
                vkGetTensorViewOpaqueCaptureDescriptorDataARM = (VkGetTensorViewOpaqueCaptureDescriptorDataARM)
                    getProc.Invoke(device, "vkGetTensorViewOpaqueCaptureDescriptorDataARM"u8.AsPointer());
                vkGetShaderModuleIdentifierEXT = (VkGetShaderModuleIdentifierEXT)
                    getProc.Invoke(device, "vkGetShaderModuleIdentifierEXT"u8.AsPointer());
                vkGetShaderModuleCreateInfoIdentifierEXT = (VkGetShaderModuleCreateInfoIdentifierEXT)
                    getProc.Invoke(device, "vkGetShaderModuleCreateInfoIdentifierEXT"u8.AsPointer());
                vkCreateOpticalFlowSessionNV = (VkCreateOpticalFlowSessionNV)
                    getProc.Invoke(device, "vkCreateOpticalFlowSessionNV"u8.AsPointer());
                vkDestroyOpticalFlowSessionNV = (VkDestroyOpticalFlowSessionNV)
                    getProc.Invoke(device, "vkDestroyOpticalFlowSessionNV"u8.AsPointer());
                vkBindOpticalFlowSessionImageNV = (VkBindOpticalFlowSessionImageNV)
                    getProc.Invoke(device, "vkBindOpticalFlowSessionImageNV"u8.AsPointer());
                vkCmdOpticalFlowExecuteNV = (VkCmdOpticalFlowExecuteNV)
                    getProc.Invoke(device, "vkCmdOpticalFlowExecuteNV"u8.AsPointer());
                vkAntiLagUpdateAMD = (VkAntiLagUpdateAMD)getProc.Invoke(device, "vkAntiLagUpdateAMD"u8.AsPointer());
                vkCreateShadersEXT = (VkCreateShadersEXT)getProc.Invoke(device, "vkCreateShadersEXT"u8.AsPointer());
                vkDestroyShaderEXT = (VkDestroyShaderEXT)getProc.Invoke(device, "vkDestroyShaderEXT"u8.AsPointer());
                vkGetShaderBinaryDataEXT = (VkGetShaderBinaryDataEXT)
                    getProc.Invoke(device, "vkGetShaderBinaryDataEXT"u8.AsPointer());
                vkCmdBindShadersEXT = (VkCmdBindShadersEXT)getProc.Invoke(device, "vkCmdBindShadersEXT"u8.AsPointer());
                vkCmdSetDepthClampRangeEXT = (VkCmdSetDepthClampRangeEXT)
                    getProc.Invoke(device, "vkCmdSetDepthClampRangeEXT"u8.AsPointer());
                vkGetFramebufferTilePropertiesQCOM = (VkGetFramebufferTilePropertiesQCOM)
                    getProc.Invoke(device, "vkGetFramebufferTilePropertiesQCOM"u8.AsPointer());
                vkGetDynamicRenderingTilePropertiesQCOM = (VkGetDynamicRenderingTilePropertiesQCOM)
                    getProc.Invoke(device, "vkGetDynamicRenderingTilePropertiesQCOM"u8.AsPointer());
                vkConvertCooperativeVectorMatrixNV = (VkConvertCooperativeVectorMatrixNV)
                    getProc.Invoke(device, "vkConvertCooperativeVectorMatrixNV"u8.AsPointer());
                vkCmdConvertCooperativeVectorMatrixNV = (VkCmdConvertCooperativeVectorMatrixNV)
                    getProc.Invoke(device, "vkCmdConvertCooperativeVectorMatrixNV"u8.AsPointer());
                vkSetLatencySleepModeNV = (VkSetLatencySleepModeNV)
                    getProc.Invoke(device, "vkSetLatencySleepModeNV"u8.AsPointer());
                vkLatencySleepNV = (VkLatencySleepNV)getProc.Invoke(device, "vkLatencySleepNV"u8.AsPointer());
                vkSetLatencyMarkerNV = (VkSetLatencyMarkerNV)
                    getProc.Invoke(device, "vkSetLatencyMarkerNV"u8.AsPointer());
                vkGetLatencyTimingsNV = (VkGetLatencyTimingsNV)
                    getProc.Invoke(device, "vkGetLatencyTimingsNV"u8.AsPointer());
                vkQueueNotifyOutOfBandNV = (VkQueueNotifyOutOfBandNV)
                    getProc.Invoke(device, "vkQueueNotifyOutOfBandNV"u8.AsPointer());
                vkCreateDataGraphPipelinesARM = (VkCreateDataGraphPipelinesARM)
                    getProc.Invoke(device, "vkCreateDataGraphPipelinesARM"u8.AsPointer());
                vkCreateDataGraphPipelineSessionARM = (VkCreateDataGraphPipelineSessionARM)
                    getProc.Invoke(device, "vkCreateDataGraphPipelineSessionARM"u8.AsPointer());
                vkGetDataGraphPipelineSessionBindPointRequirementsARM =
                    (VkGetDataGraphPipelineSessionBindPointRequirementsARM)
                        getProc.Invoke(device, "vkGetDataGraphPipelineSessionBindPointRequirementsARM"u8.AsPointer());
                vkGetDataGraphPipelineSessionMemoryRequirementsARM =
                    (VkGetDataGraphPipelineSessionMemoryRequirementsARM)
                        getProc.Invoke(device, "vkGetDataGraphPipelineSessionMemoryRequirementsARM"u8.AsPointer());
                vkBindDataGraphPipelineSessionMemoryARM = (VkBindDataGraphPipelineSessionMemoryARM)
                    getProc.Invoke(device, "vkBindDataGraphPipelineSessionMemoryARM"u8.AsPointer());
                vkDestroyDataGraphPipelineSessionARM = (VkDestroyDataGraphPipelineSessionARM)
                    getProc.Invoke(device, "vkDestroyDataGraphPipelineSessionARM"u8.AsPointer());
                vkCmdDispatchDataGraphARM = (VkCmdDispatchDataGraphARM)
                    getProc.Invoke(device, "vkCmdDispatchDataGraphARM"u8.AsPointer());
                vkGetDataGraphPipelineAvailablePropertiesARM = (VkGetDataGraphPipelineAvailablePropertiesARM)
                    getProc.Invoke(device, "vkGetDataGraphPipelineAvailablePropertiesARM"u8.AsPointer());
                vkGetDataGraphPipelinePropertiesARM = (VkGetDataGraphPipelinePropertiesARM)
                    getProc.Invoke(device, "vkGetDataGraphPipelinePropertiesARM"u8.AsPointer());
                vkCmdSetAttachmentFeedbackLoopEnableEXT = (VkCmdSetAttachmentFeedbackLoopEnableEXT)
                    getProc.Invoke(device, "vkCmdSetAttachmentFeedbackLoopEnableEXT"u8.AsPointer());
                vkCmdBindTileMemoryQCOM = (VkCmdBindTileMemoryQCOM)
                    getProc.Invoke(device, "vkCmdBindTileMemoryQCOM"u8.AsPointer());
                vkCmdDecompressMemoryEXT = (VkCmdDecompressMemoryEXT)
                    getProc.Invoke(device, "vkCmdDecompressMemoryEXT"u8.AsPointer());
                vkCmdDecompressMemoryIndirectCountEXT = (VkCmdDecompressMemoryIndirectCountEXT)
                    getProc.Invoke(device, "vkCmdDecompressMemoryIndirectCountEXT"u8.AsPointer());
                vkCreateExternalComputeQueueNV = (VkCreateExternalComputeQueueNV)
                    getProc.Invoke(device, "vkCreateExternalComputeQueueNV"u8.AsPointer());
                vkDestroyExternalComputeQueueNV = (VkDestroyExternalComputeQueueNV)
                    getProc.Invoke(device, "vkDestroyExternalComputeQueueNV"u8.AsPointer());
                vkGetExternalComputeQueueDataNV = (VkGetExternalComputeQueueDataNV)
                    getProc.Invoke(device, "vkGetExternalComputeQueueDataNV"u8.AsPointer());
                vkGetClusterAccelerationStructureBuildSizesNV = (VkGetClusterAccelerationStructureBuildSizesNV)
                    getProc.Invoke(device, "vkGetClusterAccelerationStructureBuildSizesNV"u8.AsPointer());
                vkCmdBuildClusterAccelerationStructureIndirectNV = (VkCmdBuildClusterAccelerationStructureIndirectNV)
                    getProc.Invoke(device, "vkCmdBuildClusterAccelerationStructureIndirectNV"u8.AsPointer());
                vkGetPartitionedAccelerationStructuresBuildSizesNV =
                    (VkGetPartitionedAccelerationStructuresBuildSizesNV)
                        getProc.Invoke(device, "vkGetPartitionedAccelerationStructuresBuildSizesNV"u8.AsPointer());
                vkCmdBuildPartitionedAccelerationStructuresNV = (VkCmdBuildPartitionedAccelerationStructuresNV)
                    getProc.Invoke(device, "vkCmdBuildPartitionedAccelerationStructuresNV"u8.AsPointer());
                vkGetGeneratedCommandsMemoryRequirementsEXT = (VkGetGeneratedCommandsMemoryRequirementsEXT)
                    getProc.Invoke(device, "vkGetGeneratedCommandsMemoryRequirementsEXT"u8.AsPointer());
                vkCmdPreprocessGeneratedCommandsEXT = (VkCmdPreprocessGeneratedCommandsEXT)
                    getProc.Invoke(device, "vkCmdPreprocessGeneratedCommandsEXT"u8.AsPointer());
                vkCmdExecuteGeneratedCommandsEXT = (VkCmdExecuteGeneratedCommandsEXT)
                    getProc.Invoke(device, "vkCmdExecuteGeneratedCommandsEXT"u8.AsPointer());
                vkCreateIndirectCommandsLayoutEXT = (VkCreateIndirectCommandsLayoutEXT)
                    getProc.Invoke(device, "vkCreateIndirectCommandsLayoutEXT"u8.AsPointer());
                vkDestroyIndirectCommandsLayoutEXT = (VkDestroyIndirectCommandsLayoutEXT)
                    getProc.Invoke(device, "vkDestroyIndirectCommandsLayoutEXT"u8.AsPointer());
                vkCreateIndirectExecutionSetEXT = (VkCreateIndirectExecutionSetEXT)
                    getProc.Invoke(device, "vkCreateIndirectExecutionSetEXT"u8.AsPointer());
                vkDestroyIndirectExecutionSetEXT = (VkDestroyIndirectExecutionSetEXT)
                    getProc.Invoke(device, "vkDestroyIndirectExecutionSetEXT"u8.AsPointer());
                vkUpdateIndirectExecutionSetPipelineEXT = (VkUpdateIndirectExecutionSetPipelineEXT)
                    getProc.Invoke(device, "vkUpdateIndirectExecutionSetPipelineEXT"u8.AsPointer());
                vkUpdateIndirectExecutionSetShaderEXT = (VkUpdateIndirectExecutionSetShaderEXT)
                    getProc.Invoke(device, "vkUpdateIndirectExecutionSetShaderEXT"u8.AsPointer());
                vkCreateShaderInstrumentationARM = (VkCreateShaderInstrumentationARM)
                    getProc.Invoke(device, "vkCreateShaderInstrumentationARM"u8.AsPointer());
                vkDestroyShaderInstrumentationARM = (VkDestroyShaderInstrumentationARM)
                    getProc.Invoke(device, "vkDestroyShaderInstrumentationARM"u8.AsPointer());
                vkCmdBeginShaderInstrumentationARM = (VkCmdBeginShaderInstrumentationARM)
                    getProc.Invoke(device, "vkCmdBeginShaderInstrumentationARM"u8.AsPointer());
                vkCmdEndShaderInstrumentationARM = (VkCmdEndShaderInstrumentationARM)
                    getProc.Invoke(device, "vkCmdEndShaderInstrumentationARM"u8.AsPointer());
                vkGetShaderInstrumentationValuesARM = (VkGetShaderInstrumentationValuesARM)
                    getProc.Invoke(device, "vkGetShaderInstrumentationValuesARM"u8.AsPointer());
                vkClearShaderInstrumentationMetricsARM = (VkClearShaderInstrumentationMetricsARM)
                    getProc.Invoke(device, "vkClearShaderInstrumentationMetricsARM"u8.AsPointer());
                vkCmdEndRendering2EXT = (VkCmdEndRendering2EXT)
                    getProc.Invoke(device, "vkCmdEndRendering2EXT"u8.AsPointer());
                vkCmdBeginCustomResolveEXT = (VkCmdBeginCustomResolveEXT)
                    getProc.Invoke(device, "vkCmdBeginCustomResolveEXT"u8.AsPointer());
                vkCmdSetComputeOccupancyPriorityNV = (VkCmdSetComputeOccupancyPriorityNV)
                    getProc.Invoke(device, "vkCmdSetComputeOccupancyPriorityNV"u8.AsPointer());
                vkCmdSetPrimitiveRestartIndexEXT = (VkCmdSetPrimitiveRestartIndexEXT)
                    getProc.Invoke(device, "vkCmdSetPrimitiveRestartIndexEXT"u8.AsPointer());
                vkCreateAccelerationStructureKHR = (VkCreateAccelerationStructureKHR)
                    getProc.Invoke(device, "vkCreateAccelerationStructureKHR"u8.AsPointer());
                vkDestroyAccelerationStructureKHR = (VkDestroyAccelerationStructureKHR)
                    getProc.Invoke(device, "vkDestroyAccelerationStructureKHR"u8.AsPointer());
                vkCmdBuildAccelerationStructuresKHR = (VkCmdBuildAccelerationStructuresKHR)
                    getProc.Invoke(device, "vkCmdBuildAccelerationStructuresKHR"u8.AsPointer());
                vkCmdBuildAccelerationStructuresIndirectKHR = (VkCmdBuildAccelerationStructuresIndirectKHR)
                    getProc.Invoke(device, "vkCmdBuildAccelerationStructuresIndirectKHR"u8.AsPointer());
                vkBuildAccelerationStructuresKHR = (VkBuildAccelerationStructuresKHR)
                    getProc.Invoke(device, "vkBuildAccelerationStructuresKHR"u8.AsPointer());
                vkCopyAccelerationStructureKHR = (VkCopyAccelerationStructureKHR)
                    getProc.Invoke(device, "vkCopyAccelerationStructureKHR"u8.AsPointer());
                vkCopyAccelerationStructureToMemoryKHR = (VkCopyAccelerationStructureToMemoryKHR)
                    getProc.Invoke(device, "vkCopyAccelerationStructureToMemoryKHR"u8.AsPointer());
                vkCopyMemoryToAccelerationStructureKHR = (VkCopyMemoryToAccelerationStructureKHR)
                    getProc.Invoke(device, "vkCopyMemoryToAccelerationStructureKHR"u8.AsPointer());
                vkWriteAccelerationStructuresPropertiesKHR = (VkWriteAccelerationStructuresPropertiesKHR)
                    getProc.Invoke(device, "vkWriteAccelerationStructuresPropertiesKHR"u8.AsPointer());
                vkCmdCopyAccelerationStructureKHR = (VkCmdCopyAccelerationStructureKHR)
                    getProc.Invoke(device, "vkCmdCopyAccelerationStructureKHR"u8.AsPointer());
                vkCmdCopyAccelerationStructureToMemoryKHR = (VkCmdCopyAccelerationStructureToMemoryKHR)
                    getProc.Invoke(device, "vkCmdCopyAccelerationStructureToMemoryKHR"u8.AsPointer());
                vkCmdCopyMemoryToAccelerationStructureKHR = (VkCmdCopyMemoryToAccelerationStructureKHR)
                    getProc.Invoke(device, "vkCmdCopyMemoryToAccelerationStructureKHR"u8.AsPointer());
                vkGetAccelerationStructureDeviceAddressKHR = (VkGetAccelerationStructureDeviceAddressKHR)
                    getProc.Invoke(device, "vkGetAccelerationStructureDeviceAddressKHR"u8.AsPointer());
                vkCmdWriteAccelerationStructuresPropertiesKHR = (VkCmdWriteAccelerationStructuresPropertiesKHR)
                    getProc.Invoke(device, "vkCmdWriteAccelerationStructuresPropertiesKHR"u8.AsPointer());
                vkGetDeviceAccelerationStructureCompatibilityKHR = (VkGetDeviceAccelerationStructureCompatibilityKHR)
                    getProc.Invoke(device, "vkGetDeviceAccelerationStructureCompatibilityKHR"u8.AsPointer());
                vkGetAccelerationStructureBuildSizesKHR = (VkGetAccelerationStructureBuildSizesKHR)
                    getProc.Invoke(device, "vkGetAccelerationStructureBuildSizesKHR"u8.AsPointer());
                vkCmdTraceRaysKHR = (VkCmdTraceRaysKHR)getProc.Invoke(device, "vkCmdTraceRaysKHR"u8.AsPointer());
                vkCreateRayTracingPipelinesKHR = (VkCreateRayTracingPipelinesKHR)
                    getProc.Invoke(device, "vkCreateRayTracingPipelinesKHR"u8.AsPointer());
                vkGetRayTracingCaptureReplayShaderGroupHandlesKHR = (VkGetRayTracingCaptureReplayShaderGroupHandlesKHR)
                    getProc.Invoke(device, "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR"u8.AsPointer());
                vkCmdTraceRaysIndirectKHR = (VkCmdTraceRaysIndirectKHR)
                    getProc.Invoke(device, "vkCmdTraceRaysIndirectKHR"u8.AsPointer());
                vkGetRayTracingShaderGroupStackSizeKHR = (VkGetRayTracingShaderGroupStackSizeKHR)
                    getProc.Invoke(device, "vkGetRayTracingShaderGroupStackSizeKHR"u8.AsPointer());
                vkCmdSetRayTracingPipelineStackSizeKHR = (VkCmdSetRayTracingPipelineStackSizeKHR)
                    getProc.Invoke(device, "vkCmdSetRayTracingPipelineStackSizeKHR"u8.AsPointer());
                vkCmdDrawMeshTasksEXT = (VkCmdDrawMeshTasksEXT)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksEXT"u8.AsPointer());
                vkCmdDrawMeshTasksIndirectEXT = (VkCmdDrawMeshTasksIndirectEXT)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksIndirectEXT"u8.AsPointer());
                vkCmdDrawMeshTasksIndirectCountEXT = (VkCmdDrawMeshTasksIndirectCountEXT)
                    getProc.Invoke(device, "vkCmdDrawMeshTasksIndirectCountEXT"u8.AsPointer());
                vkGetMemoryWin32HandleKHR = (VkGetMemoryWin32HandleKHR)
                    getProc.Invoke(device, "vkGetMemoryWin32HandleKHR"u8.AsPointer());
                vkGetMemoryWin32HandlePropertiesKHR = (VkGetMemoryWin32HandlePropertiesKHR)
                    getProc.Invoke(device, "vkGetMemoryWin32HandlePropertiesKHR"u8.AsPointer());
                vkImportSemaphoreWin32HandleKHR = (VkImportSemaphoreWin32HandleKHR)
                    getProc.Invoke(device, "vkImportSemaphoreWin32HandleKHR"u8.AsPointer());
                vkGetSemaphoreWin32HandleKHR = (VkGetSemaphoreWin32HandleKHR)
                    getProc.Invoke(device, "vkGetSemaphoreWin32HandleKHR"u8.AsPointer());
                vkImportFenceWin32HandleKHR = (VkImportFenceWin32HandleKHR)
                    getProc.Invoke(device, "vkImportFenceWin32HandleKHR"u8.AsPointer());
                vkGetFenceWin32HandleKHR = (VkGetFenceWin32HandleKHR)
                    getProc.Invoke(device, "vkGetFenceWin32HandleKHR"u8.AsPointer());
                vkGetMemoryWin32HandleNV = (VkGetMemoryWin32HandleNV)
                    getProc.Invoke(device, "vkGetMemoryWin32HandleNV"u8.AsPointer());
                vkAcquireFullScreenExclusiveModeEXT = (VkAcquireFullScreenExclusiveModeEXT)
                    getProc.Invoke(device, "vkAcquireFullScreenExclusiveModeEXT"u8.AsPointer());
                vkReleaseFullScreenExclusiveModeEXT = (VkReleaseFullScreenExclusiveModeEXT)
                    getProc.Invoke(device, "vkReleaseFullScreenExclusiveModeEXT"u8.AsPointer());
                vkGetDeviceGroupSurfacePresentModes2EXT = (VkGetDeviceGroupSurfacePresentModes2EXT)
                    getProc.Invoke(device, "vkGetDeviceGroupSurfacePresentModes2EXT"u8.AsPointer());
                vkExportMetalObjectsEXT = (VkExportMetalObjectsEXT)
                    getProc.Invoke(device, "vkExportMetalObjectsEXT"u8.AsPointer());
                vkGetMemoryMetalHandleEXT = (VkGetMemoryMetalHandleEXT)
                    getProc.Invoke(device, "vkGetMemoryMetalHandleEXT"u8.AsPointer());
                vkGetMemoryMetalHandlePropertiesEXT = (VkGetMemoryMetalHandlePropertiesEXT)
                    getProc.Invoke(device, "vkGetMemoryMetalHandlePropertiesEXT"u8.AsPointer());
                vkGetAndroidHardwareBufferPropertiesANDROID = (VkGetAndroidHardwareBufferPropertiesANDROID)
                    getProc.Invoke(device, "vkGetAndroidHardwareBufferPropertiesANDROID"u8.AsPointer());
                vkGetMemoryAndroidHardwareBufferANDROID = (VkGetMemoryAndroidHardwareBufferANDROID)
                    getProc.Invoke(device, "vkGetMemoryAndroidHardwareBufferANDROID"u8.AsPointer());
                vxDestroyImages = (VxDestroyImages)getProc.Invoke(device, "vxDestroyImages"u8.AsPointer());
                vxDestroyImageViews = (VxDestroyImageViews)getProc.Invoke(device, "vxDestroyImageViews"u8.AsPointer());
                vxDestroyBuffers = (VxDestroyBuffers)getProc.Invoke(device, "vxDestroyBuffers"u8.AsPointer());
                vxDestroyBufferViews = (VxDestroyBufferViews)
                    getProc.Invoke(device, "vxDestroyBufferViews"u8.AsPointer());
            }
        }
    }
}
