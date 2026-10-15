// Vulkan support reference
// https://www.glfw.org/docs/latest/group__vulkan.html

// Hand-written member of the Vulkan library. CreateWindowSurface fixed-pins the out-parameter into
// a pointer and hardcodes a null allocator - not mechanically derivable - so it stays here. The
// rest of the Vulkan library is generated into Generated/Libraries/Glfw.Vulkan.gen.cs and merges
// into this same partial class.

namespace Brutal.GlfwApi;

public static unsafe partial class Glfw
{
    /// <summary>Creates a Vulkan surface for the specified window.</summary>
    /// <remarks>
    ///     This function creates a Vulkan surface for the specified window.
    ///     <para />
    ///     If the Vulkan loader or at least one minimally functional ICD were not found, this function returns
    ///     <c>VK_ERROR_INITIALIZATION_FAILED</c> and generates a <see cref="GlfwErrorCode.ApiUnavailable" /> error. Call
    ///     <see cref="VulkanSupported">Glfw.VulkanSupported</see> to check whether Vulkan is at least minimally available.
    ///     <para />
    ///     If the required window surface creation instance extensions are not available or the specified instance was not
    ///     created with these extensions enabled,
    ///     this function returns <c>VK_ERROR_EXTENSION_NOT_PRESENT</c> and generates a <see cref="GlfwErrorCode.ApiUnavailable" /> error. Call
    ///     <see cref="GetRequiredInstanceExtensions">GetRequiredInstanceExtensions</see> to check what instance extensions
    ///     are required.
    ///     <para />
    ///     The window surface cannot be shared with another API so the window must have been created with the
    ///     <see cref="GlfwWindowHint.ClientApi"/> hint set to <see cref="Constants.GLFW_NO_API" /> otherwise it
    ///     generates a <see cref="GlfwErrorCode.InvalidValue" /> error and returns <c>VK_ERROR_NATIVE_WINDOW_IN_USE_KHR</c>.
    ///     <para />
    ///     The window surface must be destroyed before the specified Vulkan instance. It is the responsibility of the
    ///     caller to destroy the window surface. GLFW does not destroy it for you.
    ///     Call <c>vkGetInstanceProcAddr</c> on the surface to destroy it.
    ///     <para />
    ///     If an error occurs before the creation call is made, GLFW returns the Vulkan error code most appropriate for
    ///     the error. Appropriate use of <see cref="VulkanSupported">Glfw.VulkanSupported</see> and
    ///     <see cref="GetRequiredInstanceExtensions">GetRequiredInstanceExtensions</see> should eliminate
    ///     almost all occurrences of this error.
    ///     <para />
    ///     macOS: GLFW prefers the <c>VK_EXT_metal_surface</c> extension, with the <c>VK_MVK_macos_surface</c> extension
    ///     as a fallback. The <c>VK_EXT_metal_surface</c> extension is the preferred extension for macOS and is the only
    ///     one that supports Metal.
    ///     <para />
    ///     macOS: This function creates and sets a <c>CAMetalLayer</c> instance for the window content view, which is
    ///     required for MoltenVK to function.
    /// </remarks>
    /// <possibleErrors>
    ///     <see cref="GlfwErrorCode.NotInitialized" />,
    ///     <see cref="GlfwErrorCode.ApiUnavailable" />,
    ///     <see cref="GlfwErrorCode.PlatformError" />,
    ///     <see cref="GlfwErrorCode.InvalidValue" />
    /// </possibleErrors>
    /// <threadSafety>This function may be called from any thread.</threadSafety>
    /// <seealso href="https://www.glfw.org/docs/latest/vulkan_guide.html#vulkan_surface">Creating a Vulkan window surface</seealso>
    public static int CreateWindowSurface(nint instance, GlfwWindow window, out ulong surface)
    {
        fixed (ulong* surfacePtr = &surface)
        {
            // Call the internal function to create the window surface
            return PInvoke.CreateWindowSurface(instance, window, null, surfacePtr);
        }
    }
}
