using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Brutal.Pointers.Extensions;
using Brutal.Strings;
using CommunityToolkit.HighPerformance.Buffers;

namespace Brutal.NativeFileDialogApi;

/// <summary>
/// Implements a native file dialog interface for opening files, picking folders, and saving files.
/// </summary>
public static partial class NativeFileDialog
{
    /// <summary>
    /// Describes the result of a native file dialog operation.
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// A programmatic error occurred, such as a memory allocation failure.
        /// </summary>
        Error,

        /// <summary>
        /// Successful operation, the user selected a file or folder.
        /// </summary>
        Okay,

        /// <summary>
        /// The user canceled the operation, such as by pressing the cancel button or closing the dialog.
        /// </summary>
        Cancel,
    }

    /// <summary>
    /// Initialize NativeFileDialog
    /// </summary>
    public static void Initialize()
    {
        Native.Init();
    }

    /// <summary>
    /// Shutdown NativeFileDialog
    /// </summary>
    public static void Shutdown()
    {
        Native.Quit();
    }

    /// <summary>
    /// Single file open dialog, with additional parameters.
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <param name="result">the result of the dialog</param>
    /// <returns>The selected string</returns>
    public static unsafe string OpenDialog(FileDialogInfo inArgs, out Result result)
    {
        using var bytes = SpanOwner<byte>.Allocate(1024, AllocationMode.Clear);
        var writtenCount = 0;

        var nfdFilterItems = stackalloc NfdFilterItem[inArgs.FilterList.Length];
        for (var i = 0; i < inArgs.FilterList.Length; i++)
        {
            var filter = inArgs.FilterList[i];

            if (filter.Name.Length == 0)
                throw new ArgumentException("Filter name is empty");
            if (filter.Spec.Length == 0)
                throw new ArgumentException("Filter spec is empty");

            var name = bytes.Span[writtenCount..];
            writtenCount += Utf8.GetBytes(filter.Name, name);
            bytes.Span[writtenCount++] = 0; // Null-terminate

            var spec = bytes.Span[writtenCount..];
            writtenCount += Utf8.GetBytes(filter.Spec, spec);
            bytes.Span[writtenCount++] = 0; // Null-terminate

            nfdFilterItems[i] = new NfdFilterItem { Name = name.AsPointer(), Spec = spec.AsPointer() };
        }

        // TODO
        NfdWindowHandle nfdHandle = new();

        var defaultPath = bytes.Span[writtenCount..];
        Utf8.GetBytes(inArgs.DefaultPath, defaultPath);

        var nfdArgs = new NfdOpenDialogArgs
        {
            FilterList = nfdFilterItems,
            FilterCount = inArgs.FilterList.Length,
            DefaultPath = defaultPath.AsPointer(),
            ParentWindow = nfdHandle,
        };

        byte* pathPtr;
        result = Native.OpenDialog(Native.INTERFACE_VERSION, &pathPtr, &nfdArgs);
        return result == Result.Okay ? Utf8.GetString(pathPtr) : string.Empty;
    }

    /// <summary>
    /// Single file open dialog, with additional parameters.
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <returns>The selected string</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string OpenDialog(FileDialogInfo inArgs = default)
    {
        return OpenDialog(inArgs, out _);
    }

    /// <summary>
    /// Multiple file open dialog
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <param name="result">the result of the dialog</param>
    /// <returns>The selected paths</returns>
    public static unsafe string[] OpenDialog(MultipleFileDialogInfo inArgs, out Result result)
    {
        using var bytes = SpanOwner<byte>.Allocate(1024, AllocationMode.Clear);
        var writtenCount = 0;

        var nfdFilterItems = stackalloc NfdFilterItem[inArgs.FilterList.Length];
        for (var i = 0; i < inArgs.FilterList.Length; i++)
        {
            var filter = inArgs.FilterList[i];

            if (filter.Name.Length == 0)
                throw new ArgumentException("Filter name is empty");
            if (filter.Spec.Length == 0)
                throw new ArgumentException("Filter spec is empty");

            var name = bytes.Span[writtenCount..];
            writtenCount += Utf8.GetBytes(filter.Name, name);
            bytes.Span[writtenCount++] = 0; // Null-terminate

            var spec = bytes.Span[writtenCount..];
            writtenCount += Utf8.GetBytes(filter.Spec, spec);
            bytes.Span[writtenCount++] = 0; // Null-terminate

            nfdFilterItems[i] = new NfdFilterItem { Name = name.AsPointer(), Spec = spec.AsPointer() };
        }

        // TODO
        NfdWindowHandle nfdHandle = new();

        var defaultPath = bytes.Span[writtenCount..];
        writtenCount += Utf8.GetBytes(inArgs.DefaultPath, defaultPath);
        bytes.Span[writtenCount] = 0; // Null-terminate

        var nfdArgs = new NfdOpenDialogArgs
        {
            FilterList = nfdFilterItems,
            FilterCount = inArgs.FilterList.Length,
            DefaultPath = defaultPath.AsPointer(),
            ParentWindow = nfdHandle,
        };

        NfdPathSet* pathSet;
        result = Native.OpenDialogMultiple(Native.INTERFACE_VERSION, &pathSet, &nfdArgs);

        if (result != Result.Okay)
            return [];

        return LoadPathSet(pathSet);
    }

    /// <summary>
    /// Multiple file open dialog
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <returns>The selected paths</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string[] OpenDialog(MultipleFileDialogInfo inArgs = default)
    {
        return OpenDialog(inArgs, out _);
    }

    /// <summary>
    /// Pick a folder
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <param name="result">the result of the dialog</param>
    /// <returns>The selected path</returns>
    public static unsafe string OpenDialog(FolderDialogInfo inArgs, out Result result)
    {
        using var bytes = SpanOwner<byte>.Allocate(256, AllocationMode.Clear);
        int writtenCount = 0;

        // TODO
        NfdWindowHandle nfdHandle = new();

        var defaultPath = bytes.Span[writtenCount..];
        writtenCount += Utf8.GetBytes(inArgs.DefaultPath, defaultPath);
        bytes.Span[writtenCount] = 0; // Null-terminate

        var nfdArgs = new NfdPickFolderArgs { DefaultPath = defaultPath.AsPointer(), ParentWindow = nfdHandle };

        byte* pathPtr;
        result = Native.PickFolder(Native.INTERFACE_VERSION, &pathPtr, &nfdArgs);

        if (result == Result.Okay)
        {
            var path = Utf8.GetString(pathPtr, Utf8.GetByteCount(pathPtr));
            Native.FreePath(pathPtr);
            return path;
        }

        return string.Empty;
    }

    /// <summary>
    /// Pick a folder
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <returns>The selected path</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string OpenDialog(FolderDialogInfo inArgs = default)
    {
        return OpenDialog(inArgs, out _);
    }

    /// <summary>
    /// Pick multiple folder(s)
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <param name="result">the result of the dialog</param>
    /// <returns>The selected path</returns>
    public static unsafe string[] OpenDialog(MultipleFolderDialogInfo inArgs, out Result result)
    {
        using var bytes = SpanOwner<byte>.Allocate(256, AllocationMode.Clear);
        int writtenCount = 0;

        // TODO
        NfdWindowHandle nfdHandle = new();

        var defaultPath = bytes.Span[writtenCount..];
        writtenCount += Utf8.GetBytes(inArgs.DefaultPath, defaultPath);
        bytes.Span[writtenCount] = 0; // Null-terminate

        var nfdArgs = new NfdPickFolderArgs { DefaultPath = defaultPath.AsPointer(), ParentWindow = nfdHandle };

        NfdPathSet* pathSet;
        result = Native.PickFolderMultiple(Native.INTERFACE_VERSION, &pathSet, &nfdArgs);

        return result != Result.Okay ? [] : LoadPathSet(pathSet);
    }

    /// <summary>
    /// Pick multiple folder(s)
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <returns>The selected path</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string[] OpenDialog(MultipleFolderDialogInfo inArgs = default)
    {
        return OpenDialog(inArgs, out _);
    }

    /// <summary>
    /// Pick a file for saving
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <param name="result">the result of the dialog</param>
    /// <returns>The selected path</returns>
    public static unsafe string OpenDialog(SaveFileDialogInfo inArgs, out Result result)
    {
        using var bytes = SpanOwner<byte>.Allocate(1024, AllocationMode.Clear);
        int writtenCount = 0;

        var nfdFilterItems = stackalloc NfdFilterItem[inArgs.FilterList.Length];
        for (var i = 0; i < inArgs.FilterList.Length; i++)
        {
            var filter = inArgs.FilterList[i];

            if (filter.Name.Length == 0)
                throw new ArgumentException("Filter name is empty");
            if (filter.Spec.Length == 0)
                throw new ArgumentException("Filter spec is empty");

            var name = bytes.Span[writtenCount..];
            writtenCount += Utf8.GetBytes(filter.Name, name);
            bytes.Span[writtenCount++] = 0; // Null-terminate

            var spec = bytes.Span[writtenCount..];
            writtenCount += Utf8.GetBytes(filter.Spec, spec);
            bytes.Span[writtenCount++] = 0; // Null-terminate

            nfdFilterItems[i] = new NfdFilterItem { Name = name.AsPointer(), Spec = spec.AsPointer() };
        }

        // TODO
        NfdWindowHandle nfdHandle = new();

        var defaultPath = bytes.Span[writtenCount..];
        writtenCount += Utf8.GetBytes(inArgs.DefaultPath, defaultPath);
        bytes.Span[writtenCount++] = 0; // Null-terminate

        var defaultName = bytes.Span[writtenCount..];
        writtenCount += Utf8.GetBytes(inArgs.DefaultName, defaultName);
        bytes.Span[writtenCount] = 0; // Null-terminate

        var nfdArgs = new NfdSaveDialogArgs
        {
            DefaultPath = defaultPath.AsPointer(),
            DefaultName = defaultName.AsPointer(),
            FilterList = nfdFilterItems,
            FilterCount = inArgs.FilterList.Length,
            ParentWindow = nfdHandle,
        };

        byte* pathPtr;
        result = Native.SaveDialog(Native.INTERFACE_VERSION, &pathPtr, &nfdArgs);

        return result == Result.Okay ? Utf8.GetString(pathPtr, Utf8.GetByteCount(pathPtr)) : string.Empty;
    }

    /// <summary>
    /// Pick a file for saving
    /// </summary>
    /// <param name="inArgs">controls the dialog behavior</param>
    /// <returns>The selected path</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string OpenDialog(SaveFileDialogInfo inArgs = default)
    {
        return OpenDialog(inArgs, out _);
    }

    internal static unsafe string[] LoadPathSet(NfdPathSet* pathSet)
    {
        uint count;
        if (Native.PathSet_GetCount(pathSet, &count) != Result.Okay)
            return [];

        var paths = new string[count];
        for (uint i = 0; i < count; i++)
        {
            byte* pathPtr;
            if (Native.PathSet_GetPath(pathSet, i, &pathPtr) != Result.Okay)
                paths[i] = string.Empty;
            else
            {
                paths[i] = Utf8.GetString(pathPtr, Utf8.GetByteCount(pathPtr));
                Native.PathSet_FreePath(pathPtr);
            }
        }

        return paths;
    }

    internal static partial class Native
    {
        public const string DLL = "nfd";
        public const int INTERFACE_VERSION = 1;

        [LibraryImport(DLL, EntryPoint = "NFD_Init")]
        public static partial Result Init();

        [LibraryImport(DLL, EntryPoint = "NFD_Quit")]
        public static partial Result Quit();

        [LibraryImport(DLL, EntryPoint = "NFD_GetError")]
        public static unsafe partial byte* GetError();

        [LibraryImport(DLL, EntryPoint = "NFD_FreePathU8")]
        public static unsafe partial void FreePath(byte* filePath);

        [LibraryImport(DLL, EntryPoint = "NFD_OpenDialogU8_With_Impl")]
        public static unsafe partial Result OpenDialog(nuint version, byte** outPath, NfdOpenDialogArgs* args);

        [LibraryImport(DLL, EntryPoint = "NFD_OpenDialogMultipleU8_With_Impl")]
        public static unsafe partial Result OpenDialogMultiple(
            nuint version,
            NfdPathSet** outPaths,
            NfdOpenDialogArgs* args
        );

        [LibraryImport(DLL, EntryPoint = "NFD_PathSet_GetCount")]
        public static unsafe partial Result PathSet_GetCount(NfdPathSet* pathSet, uint* count);

        [LibraryImport(DLL, EntryPoint = "NFD_PathSet_GetPathU8")]
        public static unsafe partial Result PathSet_GetPath(NfdPathSet* pathSet, uint index, byte** outPath);

        [LibraryImport(DLL, EntryPoint = "NFD_PathSet_FreePathU8")]
        public static unsafe partial void PathSet_FreePath(byte* filePath);

        [LibraryImport(DLL, EntryPoint = "NFD_PickFolderU8_With_Impl")]
        public static unsafe partial Result PickFolder(nuint version, byte** outPath, NfdPickFolderArgs* args);

        [LibraryImport(DLL, EntryPoint = "NFD_PickFolderMultipleU8_With_Impl")]
        public static unsafe partial Result PickFolderMultiple(
            nuint version,
            NfdPathSet** outPaths,
            NfdPickFolderArgs* args
        );

        [LibraryImport(DLL, EntryPoint = "NFD_SaveDialogU8_With_Impl")]
        public static unsafe partial Result SaveDialog(nuint version, byte** outPath, NfdSaveDialogArgs* args);
    }
}
