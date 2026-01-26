using RaylibNET;
using static RaylibNET.Raylib;
using Hexa.NET.ImGui;

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
    RlImGui.Begin();

    if (ImGui.Button("Increment Counter"))
    {
        counter++;
    }
    ImGui.SameLine();
    ImGui.Text($"Counter: {counter}");

    ImGui.Checkbox("Show ImGui Demo Window", ref showDemo);
    if (showDemo)
    {
        ImGui.ShowDemoWindow(ref showDemo);
    }

    // End ImGui frame and render
    RlImGui.End();

    EndDrawing();
}

RlImGui.Shutdown();
CloseWindow();
