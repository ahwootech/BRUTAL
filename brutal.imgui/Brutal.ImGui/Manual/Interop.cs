using System.Diagnostics;
using System.Reflection;

namespace Brutal.ImGuiApi
{
    public static class Interop
    {
        /// <summary>
        /// A function that sets up a trampoline for our functions that take an ImGuiViewportPtr and return an ImVec2 so
        /// that interop works. Without this things don't work because C++ and C# think different things about ImVec2
        /// and how it can be returned over interop. C++ expects the return type on the stack but C# puts it in a register.
        /// </summary>
        /// <remarks>The function looks for a native function pointer variable and sets it to the value of managedFunction.
        /// It then requests the function pointer for the shim function and returns it, so that can be passed to ImGui as
        /// a callback. This shim function calls the managed function that returns a POD type, and converts it to the
        /// non-pod type that C++ expects to be returned.</remarks>
        /// <param name="managedFunction">Address of the function that is your normal C# callback</param>
        /// <param name="functionName">The name of the function that you are hooking. e.g. "GetWindowPos"</param>
        /// <returns>Pointer to the c++ shim function.</returns>
        public static unsafe nint CreateTrampoline(
            delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float2> managedFunction,
            string functionName
        )
        {
            Debug.Assert(sizeof(delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float2>) == sizeof(IntPtr));

            var imguiLibrary = NativeLibrary.Load(LibraryName, Assembly.GetExecutingAssembly(), null);

            var pointerToManagedFunctionPointer = (delegate* unmanaged[Cdecl]<ImGuiViewportPtr, float2>*)
                NativeLibrary.GetExport(imguiLibrary, $"Platform_{functionName}_ManagedFunctionPointer");
            *pointerToManagedFunctionPointer = managedFunction;

            var getShimFunctionPointer = (delegate* unmanaged[Cdecl]<nint>)
                NativeLibrary.GetExport(imguiLibrary, $"Get_{functionName}_InteropPointer");
            return getShimFunctionPointer();
        }

        private const string LibraryName = "imgui";
    }
}
