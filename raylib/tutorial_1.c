//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 1 - Our Beloved Game Window!!!
#include <raylib.h>
int main(void)
{
//Our Window Intended To Be 400x400
const ScreenHeight = 400;
const ScreenWidth = 400;
InitWindow(ScreenWidth,ScreenHeight,"Our Beloved Game Window!!!");
SetTargetFPS(120); //Game FPS Is 120

//Game Updating
while(!WindowShouldClose())
{
    BeginDrawing();
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    EndDrawing();
}
CloseWindow();
return 0;
}