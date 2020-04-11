//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 5 - Advanced 2D Graphics(Images,Textures,Gradients,And More...)

//Libraries And Headers
#include <raylib.h> //Raylib Library

int main(void)
{
//Our Window Intended To Be 600x600
const ScreenHeight = 600;
const ScreenWidth = 600;
//Creating Our Game Window With Title,Height,Width
InitWindow(ScreenWidth,ScreenHeight,"Advanced 2D Graphics!!!");

SetTargetFPS(120); //Game FPS Is 120
//Loading Images Or Textures Must Be After Window Creation
Image steria = LoadImage("pic1.png");
Texture2D logo = LoadTextureFromImage(steria);
UnloadImage(steria); //Once Texture Used Image,We No Longer Need Image,We Can Remove It

//Game Updating
while(!WindowShouldClose())
{
    //Start Drawing
    BeginDrawing();
    
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    
    //Draw Texture With x And y Position
    DrawTexture(logo, //Texture
                200,  //x Position
                200,  //y Position
                WHITE); //White Is The Texture Tint Color
    
    //Draw Circle Gradient With x And y Position,With 2 Color
    DrawCircleGradient(400,  //x Position
                       400,  //y Position 
                       60.0, //radius
                       YELLOW, //1st Color
                       ORANGE); //2nd Color(Inside)
    
    HideCursor(); //Hide Cursor
    DrawFPS(10,10); //Drawing Game FPS On Screen,In Position: X Is 10 And Y Is 10
    EndDrawing(); //End Drawing
}
  
UnloadTexture(logo); //Unload Textures(Important!!!)
CloseWindow();
return 0;
}