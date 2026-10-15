using System.Runtime.CompilerServices;
using Brutal.Strings;

namespace Brutal.ImGuiApi.Extensions;

using static ImGui;

public static partial class ImGuiEx
{
    public static bool CheckboxFlags<T>(ImString label, ref T flags, T flagsValue)
        where T : Enum
    {
        CheckEnumIsIntSized<T>();
        return ImGui.CheckboxFlags(label, ref Unsafe.As<T, int>(ref flags), Unsafe.As<T, int>(ref flagsValue));
    }

    public static bool Combo<T>(
        ImString label,
        ref T currentItem,
        ReadOnlySpan<Ptr<byte>> items,
        int popupMaxHeightInItems = -1
    )
        where T : Enum
    {
        CheckEnumIsIntSized<T>();
        return ImGui.Combo(label, ref Unsafe.As<T, int>(ref currentItem), items, popupMaxHeightInItems);
    }

    public static bool Combo<T>(
        ImString label,
        ref T currentItem,
        scoped RefString8Array items,
        int popupMaxHeightInItems = -1
    )
        where T : Enum
    {
        CheckEnumIsIntSized<T>();
        return ImGui.Combo(label, ref Unsafe.As<T, int>(ref currentItem), items, popupMaxHeightInItems);
    }

    public static bool Combo<T>(
        ImString label,
        ref T currentItem,
        ImString itemsSeparatedByZeros,
        int popupMaxHeightInItems = -1
    )
        where T : Enum
    {
        CheckEnumIsIntSized<T>();
        return ImGui.Combo(label, ref Unsafe.As<T, int>(ref currentItem), itemsSeparatedByZeros, popupMaxHeightInItems);
    }

    public static bool Combo<T>(
        ImString label,
        ref T currentItem,
        ComboGetter getter,
        nint userData,
        int itemsCount,
        int popupMaxHeightInItems = -1
    )
        where T : Enum
    {
        CheckEnumIsIntSized<T>();
        return ImGui.Combo(
            label,
            ref Unsafe.As<T, int>(ref currentItem),
            getter,
            userData,
            itemsCount,
            popupMaxHeightInItems
        );
    }

    public static bool RadioButton<T>(ImString label, ref T v, T vButton)
        where T : Enum
    {
        CheckEnumIsIntSized<T>();
        return ImGui.RadioButton(label, ref Unsafe.As<T, int>(ref v), Unsafe.As<T, int>(ref vButton));
    }

    private static void CheckEnumIsIntSized<T>()
        where T : Enum
    {
        if (Unsafe.SizeOf<T>() != sizeof(int))
            throw new ArgumentException("Enum must be int sized to be used in this function");
    }

    /// <remarks>
    /// Implementation automatically applies the NoAlpha flag, so col.A is ignored
    /// </remarks>
    public static bool ColorPicker3(ImString label, ref float4 col, ImGuiColorEditFlags flags = default)
    {
        unsafe
        {
            fixed (float4* col_fixed = &col)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.ColorPicker3(label_fixed, (float3*)col_fixed, flags);
            }
        }
    }

    /// <remarks>
    /// Implementation automatically applies the NoAlpha flag, so col.A is ignored
    /// </remarks>
    public static bool ColorEdit3(ImString label, ref float4 col, ImGuiColorEditFlags flags = default)
    {
        unsafe
        {
            fixed (float4* col_fixed = &col)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.ColorEdit3(label_fixed, (float3*)col_fixed, flags);
            }
        }
    }

    public static bool DragScalar<T>(
        ImString label,
        ImGuiDataType dataType,
        ref T pData,
        float vSpeed = 1f,
        T? pMin = null,
        T? pMax = null,
        ImString format = default,
        ImGuiSliderFlags flags = default
    )
        where T : unmanaged
    {
        unsafe
        {
            var pMin_ptr = pMin is { } min_value ? &min_value : null;
            var pMax_ptr = pMax is { } max_value ? &max_value : null;

            fixed (T* pData_fixed = &pData)
            fixed (byte* format_fixed = format)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.DragScalar(
                    label_fixed,
                    dataType,
                    pData_fixed,
                    vSpeed,
                    pMin_ptr,
                    pMax_ptr,
                    format_fixed,
                    flags
                );
            }
        }
    }

    public static bool SliderScalar<T>(
        ImString label,
        ImGuiDataType dataType,
        ref T pData,
        T pMin,
        T pMax,
        ImString format = default,
        ImGuiSliderFlags flags = default
    )
        where T : unmanaged
    {
        unsafe
        {
            fixed (byte* format_fixed = format)
            fixed (T* pData_fixed = &pData)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.SliderScalar(label_fixed, dataType, pData_fixed, &pMin, &pMax, format_fixed, flags);
            }
        }
    }

    public static bool InputScalar<T>(
        ImString label,
        ImGuiDataType dataType,
        ref T pData,
        T? pStep = null,
        T? pStepFast = null,
        ImString format = default,
        ImGuiInputTextFlags flags = default
    )
        where T : unmanaged
    {
        unsafe
        {
            var pStep_ptr = pStep is { } step_value ? &step_value : null;
            var pStepFast_ptr = pStepFast is { } stepFast_value ? &stepFast_value : null;

            fixed (byte* format_fixed = format)
            fixed (T* pData_fixed = &pData)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.InputScalar(
                    label_fixed,
                    dataType,
                    pData_fixed,
                    pStep_ptr,
                    pStepFast_ptr,
                    format_fixed,
                    flags
                );
            }
        }
    }

    public static bool DragScalarN<T>(
        ImString label,
        ImGuiDataType dataType,
        Span<T> pData,
        float vSpeed = 1f,
        T? pMin = null,
        T? pMax = null,
        ImString format = default,
        ImGuiSliderFlags flags = default
    )
        where T : unmanaged
    {
        unsafe
        {
            var pMin_ptr = pMin is { } min_value ? &min_value : null;
            var pMax_ptr = pMax is { } max_value ? &max_value : null;

            fixed (T* pData_fixed = pData)
            fixed (byte* format_fixed = format)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.DragScalarN(
                    label_fixed,
                    dataType,
                    pData_fixed,
                    pData.Length,
                    vSpeed,
                    pMin_ptr,
                    pMax_ptr,
                    format_fixed,
                    flags
                );
            }
        }
    }

    public static bool SliderScalar<T>(
        ImString label,
        ImGuiDataType dataType,
        Span<T> pData,
        T pMin,
        T pMax,
        ImString format = default,
        ImGuiSliderFlags flags = default
    )
        where T : unmanaged
    {
        unsafe
        {
            fixed (byte* format_fixed = format)
            fixed (T* pData_fixed = pData)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.SliderScalarN(
                    label_fixed,
                    dataType,
                    pData_fixed,
                    pData.Length,
                    &pMin,
                    &pMax,
                    format_fixed,
                    flags
                );
            }
        }
    }

    public static bool InputScalar<T>(
        ImString label,
        ImGuiDataType dataType,
        Span<T> pData,
        T? pStep = null,
        T? pStepFast = null,
        ImString format = default,
        ImGuiInputTextFlags flags = default
    )
        where T : unmanaged
    {
        unsafe
        {
            var pStep_ptr = pStep is { } step_value ? &step_value : null;
            var pStepFast_ptr = pStepFast is { } stepFast_value ? &stepFast_value : null;

            fixed (byte* format_fixed = format)
            fixed (T* pData_fixed = pData)
            fixed (byte* label_fixed = label)
            {
                return PInvoke.InputScalarN(
                    label_fixed,
                    dataType,
                    pData_fixed,
                    pData.Length,
                    pStep_ptr,
                    pStepFast_ptr,
                    format_fixed,
                    flags
                );
            }
        }
    }

    public static float4 ColorConvertHSVtoRGB(float4 hsv)
    {
        var rgba = new float4 { A = hsv.A };
        ImGui.ColorConvertHSVtoRGB(hsv.X, hsv.Y, hsv.Z, out rgba.X, out rgba.Y, out rgba.Z);
        return rgba;
    }
}
