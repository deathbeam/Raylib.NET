using RaylibNET;
using static RaylibNET.Raylib;
using Hexa.NET.ImGui;
using System.Numerics;


SetConfigFlags(
    (int)(ConfigFlags.FLAG_WINDOW_HIGHDPI)
);
InitWindow(800, 600, "Raylib.NET.ImGui - Example");
SetTargetFPS(60);

RlImGui.Setup();

int counter = 0;
bool showDemo = true;

while (!WindowShouldClose())
{
    BeginDrawing();
    ClearBackground(Color.DARKGRAY);

    // Start ImGui frame
    RlImGui.Begin();

    // Demonstrate FontAwesome icons
    // Test icon-only display (matching C++ rlImGui example)
    ImGui.TextUnformatted(FontAwesome.Jedi);
    ImGui.SameLine();
    ImGui.Text($"{FontAwesome.Rocket} Welcome to Raylib.NET.ImGui!");
    ImGui.Separator();

    // Button with icon
    if (ImGui.Button($"{FontAwesome.Plus} Increment Counter"))
    {
        counter++;
    }
    ImGui.SameLine();
    ImGui.Text($"{FontAwesome.Hashtag} Counter: {counter}");

    ImGui.Spacing();

    // More icon examples
    ImGui.Text($"{FontAwesome.House} Home");
    ImGui.SameLine();
    ImGui.Text($"{FontAwesome.Gear} Settings");
    ImGui.SameLine();
    ImGui.Text($"{FontAwesome.Heart} Favorite");
    ImGui.SameLine();
    ImGui.Text($"{FontAwesome.Star} Rating");

    ImGui.Spacing();

    // Demonstrate color extensions
    var raylibColor = Color.RAYWHITE;
    var imguiColor = raylibColor.ToImGui();
    ImGui.TextColored(imguiColor, "This text uses Raylib.RAYWHITE converted to ImGui color!");

    var customImGuiColor = new Vector4(0.2f, 0.8f, 0.4f, 1.0f);
    var convertedBack = customImGuiColor.ToRaylib();
    ImGui.Text($"Custom color RGB: {convertedBack.R}, {convertedBack.G}, {convertedBack.B}");

    ImGui.Spacing();
    ImGui.Separator();

    ImGui.Checkbox($"{FontAwesome.WindowMaximize} Show ImGui Demo Window", ref showDemo);
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
