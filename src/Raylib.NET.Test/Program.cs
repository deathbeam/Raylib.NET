using Raylib.NET;
using static Raylib.NET.Raylib;
using static Raylib.NET.Raygui;

bool showMessageBox = false;

InitWindow(640, 480, "Raylib.NET - Test");
SetConfigFlags((int)ConfigFlags.FLAG_WINDOW_RESIZABLE | (int)ConfigFlags.FLAG_WINDOW_HIGHDPI);
SetTargetFPS(60);

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(GetColor((uint)GuiGetStyle((int)GuiControl.DEFAULT, (int)GuiDefaultProperty.BACKGROUND_COLOR)));

    DrawText("Congrats! You created your first window!", 10, 10, 20, Color.LIGHTGRAY);

    if (GuiButton(new(40, 40, 120, 30), "#191#Show Message") == 1) {
        showMessageBox = true;
    }

    if (showMessageBox)
    {
        int result = GuiMessageBox(new(85, 70, 250, 100), "#191#Message Box", "Hi! This is a message!", "Nice;Cool");
        if (result >= 0) {
            showMessageBox = false;
        }
    }

    EndDrawing();
}

CloseWindow();
