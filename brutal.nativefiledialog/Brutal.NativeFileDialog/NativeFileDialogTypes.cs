using System;

namespace Brutal.NativeFileDialogApi
{
    internal unsafe struct NfdFilterItem
    {
        public byte* Name;
        public byte* Spec;
    }

    internal unsafe struct NfdWindowHandle
    {
        public ulong Type;
        public void* Handle;
    }

    internal unsafe struct NfdOpenDialogArgs
    {
        public NfdFilterItem* FilterList;
        public int FilterCount;
        public byte* DefaultPath;
        public NfdWindowHandle ParentWindow;
    }

    internal unsafe struct NfdSaveDialogArgs
    {
        public NfdFilterItem* FilterList;
        public int FilterCount;
        public byte* DefaultPath;
        public byte* DefaultName;
        public NfdWindowHandle ParentWindow;
    }

    internal unsafe struct NfdPickFolderArgs
    {
        public byte* DefaultPath;
        public NfdWindowHandle ParentWindow;
    }

    internal struct NfdPathSet;

    /// <summary>
    /// Filter for a dialog
    /// </summary>
    public struct FilterItem()
    {
        /// <summary>
        /// The user-readable name of the filter
        /// </summary>
        public string Name = "";

        /// <summary>
        /// The specification for the filter
        /// </summary>
        public string Spec = "";
    }

    /// <summary>
    /// Arguments for a dialog opening file(s)
    /// </summary>
    public ref struct FileDialogInfo()
    {
        /// <summary>
        /// A pointer to a list of filters
        /// </summary>
        public ReadOnlySpan<FilterItem> FilterList = [];

        /// <summary>
        /// The default path to open
        /// </summary>
        public string DefaultPath = "";

        /// <summary>
        /// A handle to the parent window
        /// </summary>
        public nint ParentWindow = 0;
    }

    /// <summary>
    /// Arguments for a dialog opening file(s)
    /// </summary>
    public ref struct MultipleFileDialogInfo()
    {
        /// <summary>
        /// A pointer to a list of filters
        /// </summary>
        public ReadOnlySpan<FilterItem> FilterList = [];

        /// <summary>
        /// The default path to open
        /// </summary>
        public string DefaultPath = "";

        /// <summary>
        /// A handle to the parent window
        /// </summary>
        public nint ParentWindow = 0;
    }

    /// <summary>
    /// Arguments for a dialog saving a file
    /// </summary>
    public ref struct SaveFileDialogInfo()
    {
        /// <summary>
        /// A pointer to a list of filters
        /// </summary>
        public ReadOnlySpan<FilterItem> FilterList = [];

        /// <summary>
        /// The default path to save to
        /// </summary>
        public string DefaultPath = "";

        /// <summary>
        /// The default name of the file
        /// </summary>
        public string DefaultName = "";

        /// <summary>
        /// A handle to the parent window
        /// </summary>
        public nint ParentWindow = 0;
    }

    /// <summary>
    /// Arguments for a dialog picking folder(s)
    /// </summary>
    public struct FolderDialogInfo()
    {
        /// <summary>
        /// The default path to open from
        /// </summary>
        public string DefaultPath = "";

        /// <summary>
        /// A handle to the parent window
        /// </summary>
        public nint ParentWindow = 0;
    }

    /// <summary>
    /// Arguments for a dialog picking folder(s)
    /// </summary>
    public struct MultipleFolderDialogInfo()
    {
        /// <summary>
        /// The default path to open from
        /// </summary>
        public string DefaultPath = "";

        /// <summary>
        /// A handle to the parent window
        /// </summary>
        public nint ParentWindow = 0;
    }
}
