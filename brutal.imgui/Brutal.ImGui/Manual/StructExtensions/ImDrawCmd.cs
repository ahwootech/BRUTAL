namespace Brutal.ImGuiApi;

public partial struct ImDrawCmd
{
    /// <inheritdoc cref="ImDrawCmdExtensions.GetTexID(ImDrawCmdPtr)"/>
    /// <remarks>
    ///     Port of definition in imgui.h for backend use on underlying struct
    /// </remarks>
    public unsafe ImTextureID GetTexID()
    {
        if (TexRef._TexData.IsNotNull())
        {
            var texId = TexRef._TexData.TexID;
            ImGui.Assert(
                texId != ImTextureID.Invalid,
                "ImDrawCmd is referring to ImTextureData that wasn't uploaded to graphics system. Backend must call ImTextureData::SetTexID() after handling ImTextureStatus_WantCreate request!"
            );
            return texId;
        }

        return TexRef._TexID;
    }
}
