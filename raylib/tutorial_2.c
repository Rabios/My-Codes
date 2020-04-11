//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 2 - Text Drawing Basics
#include <raylib.h>
int main(void)
{
//Our Window Intended To Be 400x400
const ScreenHeight = 400;
const ScreenWidth = 400;
//Creating Our Game Window With Title,Height And Width
InitWindow(ScreenWidth,ScreenHeight,"Graphics Master!!!");
SetTargetFPS(120); //Game FPS Is 120

//Game Updating
while(!WindowShouldClose())
{
    BeginDrawing();
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    //We Will Start Drawing Our First Text!!!
    //DrawText(const char *text,int position_x,int position_y,int size,Color)
    DrawText("HELLO WORLD!!!",
    50, //x Position
    150, //y Position
    40, //Font Size
    BLUE); //Color
    DrawFPS(10,10); //Drawing Game FPS On Screen,In Position: X Is 10 And Y Is 10
    EndDrawing();
}
CloseWindow();
return 0;
}