using RaylibNET;
using static RaylibNET.Raylib;


InitWindow(640, 480, "Raylib.NET - Test");

while (!WindowShouldClose())
{
    BeginDrawing();

    ClearBackground(Color.RAYWHITE);

    DrawText("Congrats! You created your first window!", 10, 10, 20, Color.LIGHTGRAY);

    EndDrawing();
}

CloseWindow();
