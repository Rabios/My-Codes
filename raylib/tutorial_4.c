//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 4 - Shapes Drawing(Stroked)
#include <raylib.h>
int main(void)
{
//Our Window Intended To Be 600x600
const ScreenHeight = 600;
const ScreenWidth = 600;
//Creating Our Game Window With Title,Height,Width
InitWindow(ScreenWidth,ScreenHeight,"Stroked Shapes!!!");
SetTargetFPS(120); //Game FPS Is 120

//Game Updating
while(!WindowShouldClose())
{
    BeginDrawing();
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    //We Will Start Drawing Shapes!!!
    //Rectangle Stroked With x,y,height,width And Color
    DrawRectangleLines(100, //x Position
                       100, //y Position
                       30,  //height
                       30,  //width
                       BLUE); //Color
                       
    //Circle With x,y,radius And Color
    DrawCircleLines(200,  //center x Position
                    120,  //center y Position
                    20.0, //radius
                    RED); //Color
                    
    //Triangle With 3 Positions
    //And Color
    DrawTriangleLines((Vector2){ 300.0,300.0 }, //First Vector Position
                      (Vector2){ 300.0,450.0 }, //Second Vector Positon
                      (Vector2){ 450.0,400.0 }, //Third Vector Position
                      ORANGE); //Color
                                            
    HideCursor(); //Hide Cursor
    //Draw Line With Start x And y Position
    //And End x And y Position
    //And Color
    DrawLine(150, //start x Position
             150, //start y Position
             200, //end x Position
             200, //end y Position
             VIOLET); //Color
             
    DrawPixel(400, //x Position
              400, //y Position
              BROWN); //Color
              
    DrawFPS(10,10); //Drawing Game FPS On Screen,In Position: X Is 10 And Y Is 10
    EndDrawing();
}
CloseWindow();
return 0;
}