//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 6 - 3D Basics

//Libraries And Headers
#include <raylib.h> //Raylib Library

int main(void)
{
//Our Window Intended To Be 600x800
const ScreenHeight = 600;
const ScreenWidth = 800;

//Creating Our Game Window With Title,Height,Width
InitWindow(ScreenWidth,ScreenHeight,"Welcome To 3D Graphics!!!");

//Creating A Camera,With Position And FOV
//And With Type Perspective With Mode First Person
Camera c = { 0 };
c.position = (Vector3){ 20,100,80 };
c.fovy = 90;
c.target = (Vector3){ 0.0f, 0.5f, 0.0f };
c.up = (Vector3){ 0.0f, 0.5f, 0.0f };
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
    
    //Cube With x,y,z Position,Height,Width,Length
    //And With Color!!!
    DrawCube((Vector3){ 60,60,60 }, //Position x,y,z
             30.0, //height
             30.0, //width
             30.0, //length
             BLUE); //Color
    
    //Sphere With Position Of x,y,z And Radius
    //And Color!!!
    DrawSphere((Vector3){ 60,80,80 }, //Position x,y,z
               5.0,     //Size
               ORANGE); //Color
               
    //Cylinder           
    DrawCylinder((Vector3){ 70,90,70 }, //Position x,y,z
                10.0,    //radius top
                10.0,    //radius bottom
                10.0,    //height
                10,      //Slices
                PURPLE); //Color
    
    //Plane    
    DrawPlane((Vector3){ 10,10,10 }, //Position x,y,z 
              (Vector2){ 200,200 },  //Size(height,width)
               RED); //Color
    
    //Line With Start And End Position(Each One Has It's x,y,z Position)
    //And A Color!!!
    DrawLine3D((Vector3){ 60,60,60 },   //Start Position x,y,z
               (Vector3){ 60,100,100 }, //End Position x,y,z
                BLACK); //Color       
                
    //End 3D Mode 
    EndMode3D();
    
    HideCursor(); //Hide Cursor
    DrawFPS(10,10); //Drawing Game FPS On Screen,In Position: X Is 10 And Y Is 10
    EndDrawing(); //End Drawing
}
  
CloseWindow();
return 0;
}