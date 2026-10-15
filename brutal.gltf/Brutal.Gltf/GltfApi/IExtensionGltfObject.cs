using System.Text.Json;

namespace Brutal.GltfApi;

public interface IExtensionGltfObject
{
    public Dictionary<string, object>? Extensions { get; }
}

public static class GltfExtensions
{
    public static T? GetExtension<T>(this IExtensionGltfObject obj, string extensionName)
        where T : class
    {
        var extensionMap = obj.Extensions;
        if (extensionMap == null || !extensionMap.TryGetValue(extensionName, out var extObj))
            return null;
        JsonElement je = (JsonElement)extObj;
        return je.Deserialize<T>();
    }
}
