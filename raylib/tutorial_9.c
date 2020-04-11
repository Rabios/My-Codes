//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 9 - Miscs
#include <raylib.h>
#include <stdlib.h>
//Variables To Store In System!!!
//C Is Number Of Rects To Draw!!!
typedef enum { C = 0 } StorageData;

int main(void)
{
//Our Window Intended To Be 400x600
const ScreenHeight = 400;
const ScreenWidth = 600;
InitWindow(ScreenWidth,ScreenHeight,"Awesome Miscs!!!");
SetTargetFPS(120); //Game FPS Is 120

//Clipboard
SetClipboardText("rAyLiB"); //Copy Text rAyLiB To Clipboard

//Window
SetWindowMinSize(100,100); //Setting Minimium Window Size
SetWindowTitle("Title Changed!!!"); //Changing Window Title

//Storage,Save Random Value (From 0 To 20) To C 
StorageSaveValue(C,rand() % 20); //Save Value To Storage

//Game Updating
while(!WindowShouldClose())
{
    BeginDrawing();
    
    //Logs Something To C99 Compiler(GCC,MinGW) Console!!!
    TraceLog(LOG_INFO,"STARTING GAME...");
    
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    
    //Load C For Loop,Then Draw Rects For C Times,With Random X,Y Position But Height And Width Of 20
    for(int i = 0;i < StorageLoadValue(C);i++) DrawRectangle(rand() % 600,rand() % 400,20,20,DARKPURPLE);
    
    //If F Key Pressed,Untoggle Fullscreen Mode
    if(IsKeyPressed(KEY_F)) ToggleFullscreen();
    
    //Show Cursor
    ShowCursor();
    
    EndDrawing();
}

//When Player Closes The Game!!!
//Game Takes Screenshoot For Last Frame In The Game,Saves It Under Name end.png
TakeScreenshot("end.png");

//Opens Raylib Website
OpenURL("https://www.raylib.com");

//Wait 1 Second
_sleep(1000);

//Close Game Window
CloseWindow();
return 0;
}