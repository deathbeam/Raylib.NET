using RaylibNET;
using static RaylibNET.Raylib;
using static RaylibNET.Raygui;

InitWindow(800, 600, "Raylib.NET - Example");
InitAudioDevice();

var texture = LoadTexture("assets/cat.png");
var music = LoadMusicStream("assets/country.mp3");
var showMessageBox = false;

SetTargetFPS(60);
PlayMusicStream(music);

while (!WindowShouldClose())
{
    UpdateMusicStream(music);

    BeginDrawing();

    ClearBackground(GetColor((uint)GuiGetStyle((int)GuiControl.DEFAULT, (int)GuiDefaultProperty.BACKGROUND_COLOR)));

    DrawTexture(texture, 10, 40, Color.WHITE);

    DrawText("Congrats! You created your first window!", 100, 10, 20, Color.LIGHTGRAY);

    if (GuiButton(new(40, 50, 120, 30), "#191#Show Message") == 1)
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

    var mousePosition = GetMousePosition();

    DrawRectangle((int)mousePosition.X - 5 , (int)mousePosition.Y - 5, 10, 10, Color.RED);

    DrawFPS(10, 10);

    EndDrawing();
}

UnloadMusicStream(music);
UnloadTexture(texture);

CloseAudioDevice();
CloseWindow();
