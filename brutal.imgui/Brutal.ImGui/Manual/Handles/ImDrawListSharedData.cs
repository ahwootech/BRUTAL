namespace Brutal.ImGuiApi;

public record struct ImDrawListSharedData;

public readonly unsafe struct ImDrawListSharedDataPtr(ImDrawListSharedData* value) : INullable
{
    private readonly ImDrawListSharedData* _value = value;

    public bool IsNull()
    {
        return _value == null;
    }

    public static implicit operator ImDrawListSharedDataPtr(ImDrawListSharedData* value) => new(value);

    public static implicit operator ImDrawListSharedData*(ImDrawListSharedDataPtr wrapper) => wrapper._value;
}
