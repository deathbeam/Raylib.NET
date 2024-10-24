using RaylibNET;
using static RaylibNET.Raylib;
using static RaylibNET.Raygui;

bool showMessageBox = false;

InitWindow(640, 480, "Raylib.NET - Example");

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(Color.RAYWHITE);

    DrawText("Congrats! You created your first window!", 10, 10, 20, Color.LIGHTGRAY);

    if (GuiButton(new(40, 40, 120, 30), "#191#Show Message") == 1)
    {
        showMessageBox = true;
    }
    if (showMessageBox)
    {
        int result = GuiMessageBox(new(85, 70, 250, 100), "#191#Message Box", "Hi! This is a message!", "Nice;Cool");
        if (result >= 0)
        {
            showMessageBox = false;
        }
    }

    EndDrawing();
}

CloseWindow();
