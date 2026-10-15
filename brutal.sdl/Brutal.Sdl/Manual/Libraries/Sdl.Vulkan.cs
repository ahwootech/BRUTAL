namespace Brutal.SdlApi;

public static unsafe partial class Sdl
{
    public static unsafe partial class PInvoke
    {
        // SDL_vulkan.h is not part of the umbrella header the generator's shim consumes
        // (Brutal.Sdl.Generate/sdl3_all.h only `#include <SDL3/SDL.h>`, which does not itself pull
        // in SDL_vulkan.h - unlike SDL_render.h, which is why SDL_AddVulkanRenderSemaphores exists in
        // the generated surface but nothing else Vulkan-related does). Rather than widen the
        // generator's input header - which would also mint brand-new generated VkInstance/
        // VkPhysicalDevice/VkSurfaceKHR handle types with no relationship to
        // RocketWerkz.Brutal.Vulkan's own types of the same name, the whole point of the cross-package
        // sample - the handful of entry points VulkanSurfaceSample actually needs are bound by hand
        // here, following the same manual-gap pattern as SDL_LogMessage in Sdl.PInvoke.cs.
        //
        // Vulkan's opaque handles (VkInstance, VkSurfaceKHR) are spelled as `nint` rather than
        // referencing Brutal.Vulkan's own VkInstance/VkSurfaceKHR types: this package takes no
        // dependency on Vulkan, and both handles are pointer-sized opaque values on every platform
        // this project targets (Windows x64, Linux x64, macOS arm64 - all 64-bit), so `nint`
        // round-trips losslessly through Brutal.Vulkan's own `Instance.VkHandle` (an `IntPtr`).

        [LibraryImport(Dll, EntryPoint = "SDL_Vulkan_GetInstanceExtensions")]
        private static partial byte** _Vulkan_GetInstanceExtensions(uint* count);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte** Vulkan_GetInstanceExtensions(uint* count)
        {
            Sdl.TraceLog.Trace();
            return _Vulkan_GetInstanceExtensions(count);
        }

        [LibraryImport(Dll, EntryPoint = "SDL_Vulkan_CreateSurface")]
        private static partial byte _Vulkan_CreateSurface(
            SdlWindow window,
            nint instance,
            nint allocator,
            nint* surface
        );

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Vulkan_CreateSurface(SdlWindow window, nint instance, nint allocator, nint* surface)
        {
            Sdl.TraceLog.Trace();
            return _Vulkan_CreateSurface(window, instance, allocator, surface);
        }

        [LibraryImport(Dll, EntryPoint = "SDL_Vulkan_DestroySurface")]
        private static partial void _Vulkan_DestroySurface(nint instance, nint surface, nint allocator);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Vulkan_DestroySurface(nint instance, nint surface, nint allocator)
        {
            Sdl.TraceLog.Trace();
            _Vulkan_DestroySurface(instance, surface, allocator);
        }
    }

    /// <summary>
    /// Ergonomic wrappers over SDL's Vulkan support functions (<c>SDL_Vulkan_GetInstanceExtensions</c>,
    /// <c>SDL_Vulkan_CreateSurface</c>, <c>SDL_Vulkan_DestroySurface</c>). See
    /// <c>VulkanSurfaceSample</c> (in the samples project) for a full cross-package usage example
    /// pairing this with <c>RocketWerkz.Brutal.Vulkan</c>.
    /// </summary>
    /// <remarks>
    /// Only the three entry points needed to create and tear down a <c>VkSurfaceKHR</c> for an
    /// <see cref="SdlWindow"/> are bound (see <see cref="PInvoke"/> for why the rest of
    /// <c>SDL_vulkan.h</c> is not). <c>SDL_Vulkan_LoadLibrary</c> is not called explicitly: creating a
    /// window with <see cref="SdlWindowFlags.Vulkan"/> loads the Vulkan library as a side effect.
    /// </remarks>
    public static unsafe class Vulkan
    {
        /// <summary>
        /// Ergonomic wrapper over <c>SDL_Vulkan_GetInstanceExtensions</c>. Returns the instance
        /// extension names SDL requires for <c>vkCreateInstance</c> to later succeed in creating a
        /// surface for a Vulkan-flagged window.
        /// </summary>
        /// <exception cref="SdlException">The SDL call failed; the message carries the
        /// <c>SDL_GetError</c> text.</exception>
        public static string[] GetInstanceExtensions()
        {
            uint count;
            var ptr = PInvoke.Vulkan_GetInstanceExtensions(&count);
            if (ptr is null)
                throw SdlException.FromError("SDL_Vulkan_GetInstanceExtensions failed");

            // Owned by SDL - must not be freed here (see SDL_vulkan.h's doc comment).
            var result = new string[count];
            for (var i = 0; i < count; i++)
                result[i] = Marshal.PtrToStringUTF8((nint)ptr[i])!;
            return result;
        }

        /// <summary>
        /// Ergonomic wrapper over <c>SDL_Vulkan_CreateSurface</c>. <paramref name="instance"/> must
        /// have been created with the extensions <see cref="GetInstanceExtensions"/> returned enabled,
        /// and <paramref name="window"/> must have been created with
        /// <see cref="SdlWindowFlags.Vulkan"/>.
        /// </summary>
        /// <param name="window">The Vulkan-flagged window to attach the surface to.</param>
        /// <param name="instance">The <c>VkInstance</c> handle, as a raw pointer-sized value
        /// (e.g. <c>Instance.VkHandle</c> from RocketWerkz.Brutal.Vulkan).</param>
        /// <returns>The newly created <c>VkSurfaceKHR</c>, as a raw pointer-sized value.</returns>
        /// <exception cref="SdlException">The SDL call failed; the message carries the
        /// <c>SDL_GetError</c> text.</exception>
        public static nint CreateSurface(SdlWindow window, nint instance)
        {
            nint surface;
            if (PInvoke.Vulkan_CreateSurface(window, instance, 0, &surface) == 0)
                throw SdlException.FromError("SDL_Vulkan_CreateSurface failed");
            return surface;
        }

        /// <summary>
        /// Ergonomic wrapper over <c>SDL_Vulkan_DestroySurface</c>. Must be called before the
        /// <paramref name="instance"/> is destroyed, and before the window is destroyed if the
        /// surface was created after the window.
        /// </summary>
        /// <param name="instance">The <c>VkInstance</c> the surface was created against.</param>
        /// <param name="surface">The <c>VkSurfaceKHR</c> to destroy.</param>
        public static void DestroySurface(nint instance, nint surface) =>
            PInvoke.Vulkan_DestroySurface(instance, surface, 0);
    }
}
