//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 7 - Stroked 3D Graphics

//Libraries And Headers
#include <raylib.h> //Raylib Library

int main(void)
{
//Our Window Intended To Be 600x800
const ScreenHeight = 600;
const ScreenWidth = 800;

//Creating Our Game Window With Title,Height,Width
InitWindow(ScreenWidth,ScreenHeight,"Stroked 3D Graphics!!!");

//Creating A Camera,With Position And FOV
//And With Type Perspective With Mode First Person
Camera c = { 0 };
c.position = (Vector3){ 20,150,80 };
c.fovy = 90;
c.target = (Vector3){ 0.0f, 0.5f, 0.0f };
c.up = (Vector3){ 0.0f, 2.0f, 0.0f };
c.type = CAMERA_PERSPECTIVE;

//Setting Camera Mode,Important Before FPS Target Setting
SetCameraMode(c,CAMERA_FIRST_PERSON);

SetTargetFPS(120); //Game FPS Is 120


//Game Updating
while(!WindowShouldClose())
{
    //Start 3D Camera
    UpdateCamera(&c);
    
    //Start Drawing
    BeginDrawing();
    
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    
    //NOTES: We Could Use 2D Before Or After 3D Mode
    DrawText("Move Mouse To Rotate Camera,Move With WASD!!!",120,10,20,BLACK);
    
    //Begin 3D Mode,With Camera c(See Line 22)
    BeginMode3D(c);
    
    DrawCubeWires((Vector3){ 90,90,90 }, //Position x,y,z
                  10.0, //height
                  10.0, //width
                  10.0, //length
                  RED); //Color
                  
    DrawSphereWires((Vector3){ 70,70,70 }, //Position x,y,z
                    20.0, //Size
                    10,   //Rings
                    10,   //Slices
                    ORANGE); //Color
    
    //Draw A Grid,For 3D With Space And Slicing          
    DrawGrid(600,10);
    
    //End 3D Mode 
    EndMode3D();
    
    HideCursor(); //Hide Cursor
    DrawFPS(10,10); //Drawing Game FPS On Screen,In Position: X Is 10 And Y Is 10
    EndDrawing(); //End Drawing
}
CloseWindow();
return 0;
}