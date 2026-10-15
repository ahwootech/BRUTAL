namespace Brutal.JoltApi;

// Hand-written imports over Manual/Shim/JoltInteropManual.cpp, kept on the same Jolt.PInvoke class as
// the generated ones (Generated/PInvoke/) so every raw entry point is found in one place.
public static partial class Jolt
{
    public static unsafe partial class PInvoke
    {
        [LibraryImport("jolt", EntryPoint = "Factory_GetInstance")]
        public static partial Factory Factory_GetInstance();

        [LibraryImport("jolt", EntryPoint = "Factory_SetInstance")]
        public static partial void Factory_SetInstance(Factory inFactory);

        [LibraryImport("jolt", EntryPoint = "Factory_DestroyInstance")]
        public static partial void Factory_DestroyInstance();
    }
}
