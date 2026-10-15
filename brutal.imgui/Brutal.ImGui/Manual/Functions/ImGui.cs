using System.Buffers;
using System.Runtime.InteropServices;

namespace Brutal.ImGuiApi;

/*
 * NOTE: we want ImGui non-static to allow extensions -> make it abstract instead
 * (static == abstract sealed, so we just don't seal it).
 *
 * If we want to roll back on that decision, this is the only place we should add `static`,
 * (ie not in the dozens of auto-generated files).
 */
public abstract partial class ImGui
{
    /// <inheritdoc cref="PInvoke.LoadIniSettingsFromMemory"/>
    public static void LoadIniSettingsFromMemory(ImString iniData)
    {
        unsafe
        {
            fixed (byte* iniData_fixed = iniData)
            {
                PInvoke.LoadIniSettingsFromMemory(iniData_fixed, (nuint)iniData.Length);
            }
        }
    }

    /// <inheritdoc cref="PInvoke.SaveIniSettingsToMemory"/>
    public static ImString SaveIniSettingsToMemory()
    {
        unsafe
        {
            nuint outIniSize;
            var resultPtr = PInvoke.SaveIniSettingsToMemory(&outIniSize);
            return new ReadOnlySpan<byte>(resultPtr, (int)outIniSize);
        }
    }

    /// <inheritdoc cref="PInvoke.Combo_0"/>
    public static unsafe bool Combo(
        ImString label,
        ref int currentItem,
        ReadOnlySpan<Ptr<byte>> items,
        int popupMaxHeightInItems = -1
    )
    {
        fixed (Ptr<byte>* pointers = items)
        fixed (int* currentItem_fixed = &currentItem)
        fixed (byte* label_fixed = label)
        {
            return PInvoke.Combo_0(
                label_fixed,
                currentItem_fixed,
                (byte**)pointers,
                items.Length,
                popupMaxHeightInItems
            );
        }
    }

    /// <inheritdoc cref="PInvoke.Combo_0"/>
    public static unsafe bool Combo(
        ImString label,
        ref int currentItem,
        scoped RefString8Array items,
        int popupMaxHeightInItems = -1
    )
    {
        try
        {
            fixed (byte* bytePtr = items)
            {
                fixed (int* currentItem_fixed = &currentItem)
                fixed (byte* label_fixed = label)
                {
                    return PInvoke.Combo_0(
                        label_fixed,
                        currentItem_fixed,
                        items.CommitFixedRegion(bytePtr),
                        items.Length,
                        popupMaxHeightInItems
                    );
                }
            }
        }
        finally
        {
            items.Dispose();
        }
    }

    /// <inheritdoc cref="PInvoke.ListBox_0"/>
    public static unsafe bool ListBox(
        ImString label,
        ref int currentItem,
        ReadOnlySpan<Ptr<byte>> items,
        int heightInItems = -1
    )
    {
        fixed (Ptr<byte>* test = items)
        fixed (int* currentItem_fixed = &currentItem)
        fixed (byte* label_fixed = label)
        {
            return PInvoke.ListBox_0(label_fixed, currentItem_fixed, (byte**)test, items.Length, heightInItems);
        }
    }

    /// <inheritdoc cref="PInvoke.ListBox_0"/>
    public static unsafe bool ListBox(
        ImString label,
        ref int currentItem,
        scoped RefString8Array items,
        int heightInItems = -1
    )
    {
        try
        {
            fixed (byte* bytePtr = items)
            {
                fixed (int* currentItem_fixed = &currentItem)
                fixed (byte* label_fixed = label)
                {
                    return PInvoke.ListBox_0(
                        label_fixed,
                        currentItem_fixed,
                        items.CommitFixedRegion(bytePtr),
                        items.Length,
                        heightInItems
                    );
                }
            }
        }
        finally
        {
            items.Dispose();
        }
    }

    /// <inheritdoc cref="PInvoke.InputText"/>
    public static unsafe bool InputText(
        ImString label,
        ImInputString buffer,
        ImGuiInputTextFlags flags = default,
        ImGuiInputTextCallback? callback = null,
        nint userData = 0
    )
    {
        fixed (byte* buffer_fixed = buffer.Buffer)
        fixed (byte* label_fixed = label)
        {
            var result = PInvoke.InputText(
                label_fixed,
                buffer_fixed,
                (nuint)buffer.Capacity,
                flags,
                callback is null ? 0 : Marshal.GetFunctionPointerForDelegate(callback),
                (void*)userData
            );

            if (result)
                buffer.EvaluateLength();

            return result;
        }
    }

    /// <inheritdoc cref="PInvoke.InputTextMultiline"/>
    public static unsafe bool InputTextMultiline(
        ImString label,
        ImInputString buffer,
        in float2 size = default,
        ImGuiInputTextFlags flags = default,
        ImGuiInputTextCallback? callback = null,
        nint userData = 0
    )
    {
        fixed (byte* buffer_fixed = buffer.Buffer)
        fixed (float2* size_fixed = &size)
        fixed (byte* label_fixed = label)
        {
            var result = PInvoke.InputTextMultiline(
                label_fixed,
                buffer_fixed,
                (nuint)buffer.Capacity,
                size_fixed,
                flags,
                callback is null ? 0 : Marshal.GetFunctionPointerForDelegate(callback),
                (void*)userData
            );

            if (result)
                buffer.EvaluateLength();

            return result;
        }
    }

    /// <inheritdoc cref="PInvoke.InputTextWithHint"/>
    public static unsafe bool InputTextWithHint(
        ImString label,
        ImString hint,
        ImInputString buffer,
        ImGuiInputTextFlags flags = default,
        ImGuiInputTextCallback? callback = null,
        nint userData = 0
    )
    {
        fixed (byte* buffer_fixed = buffer.Buffer)
        fixed (byte* hint_fixed = hint)
        fixed (byte* label_fixed = label)
        {
            var result = PInvoke.InputTextWithHint(
                label_fixed,
                hint_fixed,
                buffer_fixed,
                (nuint)buffer.Capacity,
                flags,
                callback is null ? 0 : Marshal.GetFunctionPointerForDelegate(callback),
                (void*)userData
            );

            if (result)
                buffer.EvaluateLength();

            return result;
        }
    }

    /// <inheritdoc cref="PInvoke.GetAllocatorFunctions"/>
    public static unsafe void GetAllocatorFunctions(
        out ImGuiMemAllocFunc? pAllocFunc,
        out ImGuiMemFreeFunc? pFreeFunc,
        out nint pUserData
    )
    {
        nint pAllocFunc_value = 0;
        nint pFreeFunc_value = 0;

        fixed (nint* pUserData_ptr = &pUserData)
        {
            PInvoke.GetAllocatorFunctions(&pAllocFunc_value, &pFreeFunc_value, (void**)pUserData_ptr);
        }

        pAllocFunc = pAllocFunc_value is 0
            ? null
            : Marshal.GetDelegateForFunctionPointer<ImGuiMemAllocFunc>(pAllocFunc_value);

        pFreeFunc = pFreeFunc_value is 0
            ? null
            : Marshal.GetDelegateForFunctionPointer<ImGuiMemFreeFunc>(pFreeFunc_value);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* ComboGetter(nint userData, int idx);

    /// <inheritdoc cref="PInvoke.Combo_2" />
    public static bool Combo(
        ImString label,
        ref int currentItem,
        ComboGetter getter,
        nint userData,
        int itemsCount,
        int popupMaxHeightInItems = -1
    )
    {
        unsafe
        {
            fixed (int* currentItem_fixed = &currentItem)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.Combo_2(
                    label_fixed,
                    currentItem_fixed,
                    Marshal.GetFunctionPointerForDelegate(getter),
                    (void*)userData,
                    itemsCount,
                    popupMaxHeightInItems
                );
            }
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate byte* ListBoxGetter(nint userData, int idx);

    /// <inheritdoc cref="PInvoke.ListBox_1" />
    public static bool ListBox(
        ImString label,
        ref int currentItem,
        ListBoxGetter getter,
        nint userData,
        int itemsCount,
        int heightInItems = -1
    )
    {
        unsafe
        {
            fixed (int* currentItem_fixed = &currentItem)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.ListBox_1(
                    label_fixed,
                    currentItem_fixed,
                    Marshal.GetFunctionPointerForDelegate(getter),
                    (void*)userData,
                    itemsCount,
                    heightInItems
                );
            }
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float PlotLinesValuesGetter(nint data, int idx);

    /// <inheritdoc cref="PInvoke.PlotLines_1" />
    public static void PlotLines(
        ImString label,
        PlotLinesValuesGetter valuesGetter,
        nint data,
        int valuesCount,
        int valuesOffset = 0,
        ImString overlayText = default,
        float scaleMin = float.MaxValue,
        float scaleMax = float.MaxValue,
        float2? graphSize = default
    )
    {
        unsafe
        {
            var graphSize_default = graphSize ?? new float2(0f, 0f);
            fixed (byte* overlayText_fixed = overlayText)
            fixed (byte* label_fixed = label)
            {
                PInvoke.PlotLines_1(
                    label_fixed,
                    Marshal.GetFunctionPointerForDelegate(valuesGetter),
                    (void*)data,
                    valuesCount,
                    valuesOffset,
                    overlayText_fixed,
                    scaleMin,
                    scaleMax,
                    graphSize_default
                );
            }
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate float PlotHistogramValuesGetter(nint data, int idx);

    /// <inheritdoc cref="PInvoke.PlotHistogram_1" />
    public static void PlotHistogram(
        ImString label,
        PlotHistogramValuesGetter valuesGetter,
        nint data,
        int valuesCount,
        int valuesOffset = 0,
        ImString overlayText = default,
        float scaleMin = float.MaxValue,
        float scaleMax = float.MaxValue,
        float2? graphSize = default
    )
    {
        unsafe
        {
            var graphSize_default = graphSize ?? new float2(0f, 0f);
            fixed (byte* overlayText_fixed = overlayText)
            fixed (byte* label_fixed = label)
            {
                PInvoke.PlotHistogram_1(
                    label_fixed,
                    Marshal.GetFunctionPointerForDelegate(valuesGetter),
                    (void*)data,
                    valuesCount,
                    valuesOffset,
                    overlayText_fixed,
                    scaleMin,
                    scaleMax,
                    graphSize_default
                );
            }
        }
    }
}
