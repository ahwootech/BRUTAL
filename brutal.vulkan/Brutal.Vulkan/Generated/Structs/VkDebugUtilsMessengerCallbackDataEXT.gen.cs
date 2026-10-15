namespace Brutal.VulkanApi
{
    /// <summary>
    ///     <see href="https://registry.khronos.org/vulkan/specs/1.3-extensions/man/html/VkDebugUtilsMessengerCallbackDataEXT.html">VkDebugUtilsMessengerCallbackDataEXT</see> - Structure specifying parameters returned to the callback
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         The definition of <c>VkDebugUtilsMessengerCallbackDataEXT</c> is:
    ///     </para>
    ///     <code>
    ///         // Provided by VK_EXT_debug_utils
    ///         typedef struct VkDebugUtilsMessengerCallbackDataEXT {
    ///             VkStructureType                              sType;
    ///             const void*                                  pNext;
    ///             VkDebugUtilsMessengerCallbackDataFlagsEXT    flags;
    ///             const char*                                  pMessageIdName;
    ///             int32_t                                      messageIdNumber;
    ///             const char*                                  pMessage;
    ///             uint32_t                                     queueLabelCount;
    ///             const VkDebugUtilsLabelEXT*                  pQueueLabels;
    ///             uint32_t                                     cmdBufLabelCount;
    ///             const VkDebugUtilsLabelEXT*                  pCmdBufLabels;
    ///             uint32_t                                     objectCount;
    ///             const VkDebugUtilsObjectNameInfoEXT*         pObjects;
    ///         } VkDebugUtilsMessengerCallbackDataEXT;
    ///     </code>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT()
    {
        /// <summary>
        ///     <c>sType</c> is a <c>VkStructureType</c> value identifying this structure.
        /// </summary>
        [FieldOffset(0)]
        internal readonly VkStructureType sType = VkStructureType.DebugUtilsMessengerCallbackDataEXT;

        /// <summary>
        ///     <c>Next</c> is `NULL` or a pointer to a structure extending this structure.
        /// </summary>
        [FieldOffset(8)]
        public void* Next;

        /// <summary>
        ///     <c>Flags</c> is `0` and is reserved for future use.
        /// </summary>
        [FieldOffset(16)]
        public VkDebugUtilsMessengerCallbackDataFlagsEXT Flags;

        /// <summary>
        ///     <c>MessageIdName</c> is `NULL` or a null-terminated UTF-8 string that identifies the particular message ID that is associated with the provided message. If the message corresponds to a validation layer message, then this string will be the VUID.
        /// </summary>
        [FieldOffset(24)]
        public byte* MessageIdName;

        /// <summary>
        ///     <c>MessageIdNumber</c> is the ID number of the triggering message. If the message corresponds to a validation layer message, then this number is an internal hash of the VUID.
        /// </summary>
        [FieldOffset(32)]
        public int MessageIdNumber;

        /// <summary>
        ///     <c>Message</c> is a null-terminated UTF-8 string detailing the trigger conditions. If the message corresponds to a validation layer message, then this will contain the main message with the specification text and link.
        /// </summary>
        [FieldOffset(40)]
        public byte* Message;

        /// <summary>
        ///     <c>QueueLabelCount</c> is a count of items contained in the <c>pQueueLabels</c> array.
        /// </summary>
        [FieldOffset(48)]
        public int QueueLabelCount;

        /// <summary>
        ///     <c>QueueLabels</c> is `NULL` or a pointer to an array of <c>VkDebugUtilsLabelEXT</c> active in the current <c>VkQueue</c> at the time the callback was triggered. Refer to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#debugging-queue-labels">Queue Labels^</see> for more information.
        /// </summary>
        [FieldOffset(56)]
        public VkDebugUtilsLabelEXT* QueueLabels;

        /// <summary>
        ///     <c>CmdBufLabelCount</c> is a count of items contained in the <c>pCmdBufLabels</c> array.
        /// </summary>
        [FieldOffset(64)]
        public int CmdBufLabelCount;

        /// <summary>
        ///     <c>CmdBufLabels</c> is `NULL` or a pointer to an array of <c>VkDebugUtilsLabelEXT</c> active in the current <c>VkCommandBuffer</c> at the time the callback was triggered. Refer to <see href="https://registry.khronos.org/vulkan/specs/latest/html/vkspec.html#debugging-command-buffer-labels">Command Buffer Labels^</see> for more information.
        /// </summary>
        [FieldOffset(72)]
        public VkDebugUtilsLabelEXT* CmdBufLabels;

        /// <summary>
        ///     <c>ObjectCount</c> is a count of items contained in the <c>pObjects</c> array.
        /// </summary>
        [FieldOffset(80)]
        public int ObjectCount;

        /// <summary>
        ///     <c>Objects</c> is a pointer to an array of <c>VkDebugUtilsObjectNameInfoEXT</c> objects related to the detected issue. The array is roughly in order of importance, but the 0th element is always guaranteed to be the most important object for this message.
        /// </summary>
        [FieldOffset(88)]
        public VkDebugUtilsObjectNameInfoEXT* Objects;
    }
}
