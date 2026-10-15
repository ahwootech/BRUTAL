namespace Brutal.GltfApi;

public partial class Gltf : IExtensionGltfObject
{
    /// <summary>
    /// Wraps light data for the KHR_lights_punctual extension.
    /// </summary>
    private LightsPunctualGltfDocumentExtension? m_lightData;

    /// <summary>
    /// Gets the extension data for KHR_lights_punctual if it exists.
    /// This extension contains information about punctual lights in the scene.
    /// If the extension is not present, this property returns null.
    /// </summary>
    public LightsPunctualGltfDocumentExtension? LightData
    {
        get
        {
            if (m_lightData == null)
                m_lightData = this.GetExtension<LightsPunctualGltfDocumentExtension>("KHR_lights_punctual");
            return m_lightData;
        }
    }
}
