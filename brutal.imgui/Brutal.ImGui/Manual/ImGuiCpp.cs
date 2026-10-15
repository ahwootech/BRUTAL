namespace Brutal.ImGuiApi;

/*
 * These types are only forward declared in headers, defined in imgui.cpp but used in imgui_internal.h structs
 */

public enum ImGuiDockRequestType
{
    None = 0,
    Dock,
    Undock,
    Split, // Split is the same as Dock but without a DockPayload
}

[StructLayout(LayoutKind.Explicit, Size = 64)]
public struct ImGuiDockRequest()
{
    [FieldOffset(0)]
    public ImGuiDockRequestType Type;

    [FieldOffset(8)]
    public Ptr<ImGuiWindow> DockTargetWindow; // Destination/Target Window to dock into (may be a loose window or a DockNode, might be NULL in which case DockTargetNode cannot be NULL)

    [FieldOffset(16)]
    public Ptr<ImGuiDockNode> DockTargetNode; // Destination/Target Node to dock into

    [FieldOffset(24)]
    public Ptr<ImGuiWindow> DockPayload; // Source/Payload window to dock (may be a loose window or a DockNode), [Optional]

    [FieldOffset(32)]
    public ImGuiDir DockSplitDir;

    [FieldOffset(36)]
    public float DockSplitRatio = 0.5f;

    [FieldOffset(40)]
    public Bool8 DockSplitOuter;

    [FieldOffset(48)]
    public Ptr<ImGuiWindow> UndockTargetWindow;

    [FieldOffset(56)]
    public Ptr<ImGuiDockNode> UndockTargetNode;
}

[InlineArray((int)ImGuiDir.COUNT + 1)]
public struct ImGuiDockPreviewData_DockRectsDraw
{
    public floatRect Value;
}

[StructLayout(LayoutKind.Explicit, Size = 312)]
public struct ImGuiDockPreviewData
{
    [FieldOffset(0)]
    public ImGuiDockNode FutureNode;

    [FieldOffset(208)]
    public Bool8 IsDropAllowed;

    [FieldOffset(209)]
    public Bool8 IsCenterAvailable;

    [FieldOffset(210)]
    public Bool8 IsSidesAvailable; // Hold your breath, grammar freaks..

    [FieldOffset(211)]
    public Bool8 IsSplitDirExplicit; // Set when hovered the drop rect (vs. implicit SplitDir==None when hovered the window)

    [FieldOffset(216)]
    public Ptr<ImGuiDockNode> SplitNode;

    [FieldOffset(224)]
    public ImGuiDir SplitDir;

    [FieldOffset(228)]
    public float SplitRatio;

    [FieldOffset(232)]
    public ImGuiDockPreviewData_DockRectsDraw DropRectsDraw; // May be slightly different from hit-testing drop rects used in DockNodeCalcDropRects()

    // TODO: Init DropRectsDraw as per constructor defaults
}

// Persistent Settings data, stored contiguously in SettingsNodes (sizeof() ~32 bytes)
[StructLayout(LayoutKind.Explicit, Size = 36)]
public struct ImGuiDockNodeSettings
{
    [FieldOffset(0)]
    public ImGuiID ID;

    [FieldOffset(4)]
    public ImGuiID ParentNodeId;

    [FieldOffset(8)]
    public ImGuiID ParentWindowId;

    [FieldOffset(12)]
    public ImGuiID SelectedTabId;

    [FieldOffset(16)]
    public sbyte SplitAxis;

    [FieldOffset(17)]
    public byte Depth;

    [FieldOffset(20)]
    public ImGuiDockNodeFlags Flags; // NB: We save individual flags one by one in ascii format (ImGuiDockNodeFlags_SavedFlagsMask_)

    [FieldOffset(24)]
    public short2 Pos;

    [FieldOffset(28)]
    public short2 Size;

    [FieldOffset(32)]
    public short2 SizeRef;
}
