using System.Text.Json;

namespace Brutal.GltfApi;

public partial class Node : IExtensionGltfObject
{
    /// <summary>
    /// Gets a light index if the node is associated with a light source.
    /// This is used when the "KHR_lights_punctual" extension is present.
    /// If the extension is not present or the light index is not defined, returns null.
    /// </summary>
    public int? LightIndex
    {
        get
        {
            if (Extensions == null || !Extensions.TryGetValue("KHR_lights_punctual", out var ext))
                return null;
            if (ext is JsonElement extElement && extElement.TryGetProperty("light"u8, out var lightIndex))
            {
                return lightIndex.GetInt32();
            }
            return null;
        }
    }
}
