using RaylibNET;
using static RaylibNET.Raylib;

InitWindow(800, 600, "Raylib.NET.ImGui - Example");
SetTargetFPS(60);

RaylibNET.RlImGui.Setup();

int counter = 0;
bool showDemo = true;

while (!WindowShouldClose())
{
    BeginDrawing();
    ClearBackground(Color.DARKGRAY);

    // Start ImGui frame
    RaylibNET.RlImGui.Begin();

    if (ImGuiNET.ImGui.Button("Increment Counter"))
    {
        counter++;
    }
    ImGuiNET.ImGui.SameLine();
    ImGuiNET.ImGui.Text($"Counter: {counter}");

    ImGuiNET.ImGui.Checkbox("Show ImGui Demo Window", ref showDemo);
    if (showDemo)
    {
        ImGuiNET.ImGui.ShowDemoWindow(ref showDemo);
    }

    // End ImGui frame and render
    RaylibNET.RlImGui.End();

    EndDrawing();
}

CloseWindow();
