//typedef ImU32* ImBitArrayPtr
global using ImBitArrayPtr = Brutal.Pointers.Ptr<uint>;

namespace Brutal.ImGuiApi;

public struct ImSpan<T> { }

public struct ImStableVector<T> { }

public struct ImPool<T> { }

public struct ImStbTexteditState { }

public struct stbrp_node
{
#pragma warning disable CS0169 // Field is never used
    int x,
        y;
    nint next;
#pragma warning restore CS0169 // Field is never used
}

#region used by ImGuiContext

public struct ImBitArrayForNamedKeys { }

public struct ImChunkStream<T> { }

public struct ImFileHandle { }

#endregion
