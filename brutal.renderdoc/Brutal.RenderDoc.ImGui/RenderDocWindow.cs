namespace Brutal.RenderDocApi;

/// Helper to control RenderDoc, view captures etc., through an ImGui window.
public class RenderDocWindow
{
    public static readonly RenderDocWindow Instance = new();

    bool LoadApi()
    {
        var success = RenderDoc.LoadApi();
        Log.Info($"RenderDoc API {(success ? "loaded successfully" : "loading failed")}");
        return success;
    }

    void UnloadApi()
    {
        RenderDoc.RemoveHooks();
        Log.Info("RenderDoc API unloaded");
    }

    void OpenUI()
    {
        var connected = RenderDoc.IsTargetControlConnected;
        var res = connected ? RenderDoc.ShowReplayUI() : RenderDoc.LaunchReplayUI(true, null);
        Log.Info(connected ? $"ShowReplayUI {res}" : $"LaunchReplayUI {res}");
    }

    int frameCount;
    uint? triggerCaptureIndex;
    public bool Visible;

    public void OnImGui()
    {
        OnUpdate();
        DrawMenuBar();
        DrawWindow();
    }

    void OnUpdate()
    {
        frameCount++;

        if (!RenderDoc.IsAvailable)
        {
            return;
        }

        if (triggerCaptureIndex.HasValue && RenderDoc.NumCaptures > triggerCaptureIndex)
        {
            triggerCaptureIndex = null;
            Log.Info($"TriggerCapture finished (frame {frameCount}, {RenderDoc.NumCaptures} captures)");
        }
    }

    void DrawMenuBar()
    {
        if (ImGui.BeginMainMenuBar())
        {
            if (ImGui.BeginMenu("View"u8))
            {
                if (ImGui.MenuItem("RenderDoc"u8, selected: Visible))
                    Visible = !Visible;
                ImGui.EndMenu();
            }

            ImGui.EndMainMenuBar();
        }
    }

    void DrawWindow()
    {
        if (!Visible)
            return;

        var status = RenderDoc.State switch
        {
            RenderDoc.ControllerState.NotLoaded => "(not loaded)",
            RenderDoc.ControllerState.LoadFail => "(loading failed)",
            RenderDoc.ControllerState.LoadSuccess =>
                $"{RenderDoc.Version}{(RenderDoc.IsTargetControlConnected ? " (connected)" : "")}",
            _ => throw new ArgumentOutOfRangeException(),
        };

        if (ImGui.Begin($"RenderDoc {status}###RenderDoc", ref Visible))
        {
            DrawWindowContent();
        }
        ImGui.End();
    }

    void DrawWindowContent()
    {
        // insert a help URL in the top-right corner
        ImGui.SameLine(ImGui.GetContentRegionAvail().X - 25); // right-align
        ImGui.TextLinkOpenURL("Help"u8, "https://renderdoc.org/docs/in_application_api.html"u8);
        ImGui.SetCursorPos(ImGui.GetCursorStartPos()); // reset

        if (RenderDoc.IsAvailable)
        {
            DrawWindowContentWhenAvailable();
            ImGui.Separator();
        }

        // the load/unload button is somewhat misleading -> draw it last:
        // - loading late appears to work but capturing might fail
        // - unloading/detaching is not guaranteed to work: https://renderdoc.org/docs/in_application_api.html#_CPPv411RemoveHooksv)
        if (ImGui.Button(RenderDoc.ApiLoaded ? "Unload RenderDoc"u8 : "Load RenderDoc"u8))
        {
            if (RenderDoc.ApiLoaded)
                UnloadApi();
            else
                LoadApi();
        }
    }

    static readonly ImInputString CaptureFilePathTemplate = new(256);

    void DrawWindowContentWhenAvailable()
    {
        var overlayBits = RenderDoc.OverlayBits;
        if (
            ImGui.CheckboxFlags(
                "##enabled"u8,
                ref Unsafe.As<OverlayBits, int>(ref overlayBits),
                (int)OverlayBits.Enabled
            )
        )
        {
            RenderDoc.OverlayBits = overlayBits;
        }
        ImGui.SameLine();
        if (EnumFlagField("Overlay"u8, ref overlayBits))
        {
            RenderDoc.OverlayBits = overlayBits;
        }

        if (ImGui.Button(RenderDoc.IsTargetControlConnected ? "Focus RenderDoc app"u8 : "Open RenderDoc app"u8))
        {
            OpenUI();
        }

        if (ImGui.TreeNode("More"u8))
        {
            Field("IsTargetControlConnected"u8, RenderDoc.IsTargetControlConnected);

            if (ImGui.Button("LaunchReplayUI"u8))
            {
                var res = RenderDoc.LaunchReplayUI(true, null);
                Log.Info($"LaunchReplayUI {res}");
            }

            if (ImGui.Button("ShowReplayUI"u8))
            {
                var res = RenderDoc.ShowReplayUI();
                Log.Info($"ShowReplayUI {res}");
            }

            if (ImGui.Button("SetActiveWindow"u8))
            {
                RenderDoc.SetActiveWindow(0, 0);
            }

            if (ImGui.Button("UnloadCrashHandler"u8))
            {
                RenderDoc.UnloadCrashHandler();
            }

            if (ImGui.Button("RemoveHooks"u8))
            {
                RenderDoc.RemoveHooks();
            }

            ImGui.TreePop();
        }

        if (ImGui.TreeNode("Capture options"u8))
        {
            foreach (var option in typeof(RenderDoc.CaptureOptions).GetProperties())
            {
                if (option.PropertyType == typeof(bool))
                {
                    var value = (bool)option.GetValue(null)!;
                    if (ImGui.Checkbox(option.Name, ref value))
                        option.SetValue(null, value);
                }
                else if (option.PropertyType == typeof(float))
                {
                    var value = (float)option.GetValue(null)!;
                    if (ImGui.InputFloat(option.Name, ref value))
                        option.SetValue(null, value);
                }
                else if (option.PropertyType == typeof(uint))
                {
                    var value = (int)(uint)option.GetValue(null)!; // TODO actually uint...
                    if (ImGui.InputInt(option.Name, ref value))
                        option.SetValue(null, value);
                }
            }

            CaptureFilePathTemplate.SetValue(RenderDoc.CaptureFilePathTemplate);
            ImGui.Text("CaptureFilePathTemplate"u8);
            ImGui.SameLine();
            if (ImGui.InputText("##CaptureFilePathTemplate"u8, CaptureFilePathTemplate))
                RenderDoc.CaptureFilePathTemplate = CaptureFilePathTemplate.ValueSpan;

            ImGui.TreePop();
        }

        var foldoutCaptures = FoldoutField("Captures"u8, RenderDoc.NumCaptures, RenderDoc.NumCaptures > 0);
        ImGui.SameLine();
        if (ImGui.Button("TriggerCapture"u8))
        {
            RenderDoc.TriggerCapture();
            triggerCaptureIndex = RenderDoc.NumCaptures;
            Log.Info($"TriggerCapture requested (frame {frameCount}, {RenderDoc.NumCaptures} captures)");
        }
        if (foldoutCaptures)
        {
            if (ImGui.BeginTable("captures"u8, 4, ImGuiTableFlags.Borders))
            {
                ImGui.TableSetupColumn("#"u8, ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("time"u8, ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableSetupColumn("file"u8);
                ImGui.TableSetupColumn(""u8, ImGuiTableColumnFlags.WidthFixed);
                ImGui.TableHeadersRow();

                for (var i = 0; i < RenderDoc.NumCaptures; i++)
                {
                    ImGui.PushID(i);
                    ImGui.TableNextRow();
                    ImGui.TableNextColumn();

                    ImGui.Text($"#{i}");
                    ImGui.TableNextColumn();

                    if (RenderDoc.TryGetCapture(i, out var path, out var time))
                    {
                        ImGui.Text($"{time:g}");
                        ImGui.TableNextColumn();
                        var name = Utf8.Path.GetFileName(path);
                        ImGui.Text($"<{name}>");
                        ImGui.TableNextColumn();
                        if (ImGui.Button("open"u8))
                        {
                            OpenUI();
                        }
                    }
                    else
                    {
                        ImGui.Text("N/A"u8);
                        ImGui.TableNextColumn();
                        ImGui.Text("N/A"u8);
                    }

                    ImGui.PopID();
                }

                ImGui.EndTable();
            }

            ImGui.TreePop();
        }
    }

    static bool EnumFlagField(ImString label, ref OverlayBits value)
    {
        var changed = false;

        if (FoldoutField(label, value.ToString()))
        {
            foreach (var flag in Enum.GetValues<OverlayBits>())
            {
                if (flag == 0 || flag == OverlayBits.All)
                    continue;
                changed |= EnumFlagFieldRow(flag.ToString(), ref value, flag);
            }
            ImGui.TreePop();
        }

        return changed;
    }

    static bool EnumFlagFieldRow(ImString label, ref OverlayBits mask, OverlayBits flag)
    {
        var flagSet = mask.HasFlag(flag);
        var changed = ImGui.Checkbox(label, ref flagSet);
        if (changed)
        {
            if (flagSet)
                mask |= flag;
            else
                mask &= ~flag;
        }
        return changed;
    }

    static void Field(ImString label, object? value)
    {
        ImGui.Text($"{label}: {value}");
    }

    static void Field(ImString label, ImString value)
    {
        ImGui.Text($"{label}: {value}");
    }

    static bool FoldoutField(ImString label, object? value, bool foldable = true)
    {
        if (foldable)
            return ImGui.TreeNode(label, $"{label}: {value}");
        Field(label, value);
        return false;
    }
}
