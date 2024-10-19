// See https://aka.ms/new-console-template for more information

using System.Numerics;
using Raylib.NET;
using static Raylib.NET.Raylib;

const int screenWidth = 800;
const int screenHeight = 540;

InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

while (!WindowShouldClose())
{
    BeginDrawing();
    ClearBackground(Color.RAYWHITE);

    DrawText("Congrats! You created your first window!", 190, 200, 20, Color.LIGHTGRAY);

    DrawRectangleV(new Vector2 { X = 10, Y = 10 }, new Vector2 { X = 100, Y = 100 }, Color.RED);

    DrawRectangleRec(new Vector4 { X = 10, Y = 150, W = 100, Z = 100 }, Color.GREEN);

    EndDrawing();
}

CloseWindow();
