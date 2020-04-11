//Tutorials By Rabia Alhaffar,Created To Be Free
//Started On 9/January/2020
//GameBox Series - Part 1(With Raylib And C)
//https://www.raylib.com
//Tutorial 3 - Shapes Drawing(Filled)
#include <raylib.h>
int main(void)
{
//Our Window Intended To Be 600x600
const ScreenHeight = 600;
const ScreenWidth = 600;
//Creating Our Game Window With Title,Height,Width
InitWindow(ScreenWidth,ScreenHeight,"Filled Shapes!!!");
SetTargetFPS(120); //Game FPS Is 120

//Game Updating
while(!WindowShouldClose())
{
    BeginDrawing();
    //Clear Graphics With White Color
    ClearBackground(RAYWHITE);
    //We Will Start Drawing Shapes!!!
    //Rectangle With x,y,height,width And Color
    DrawRectangle(100, //x Position
                  100, //y Position
                  30,  //height
                  30,  //width
                  BLUE); //Color
                  
                  
    //Circle With x,y,radius And Color
    DrawCircle(200, //center x Position
               120, //center y Position
               20.0, //Radius
               RED); //Color
               
    //Triangle With 3 Positions
    //And Color
    DrawTriangle((Vector2){ 300.0,300.0 }, //First Vector Position
                 (Vector2){ 300.0,450.0 }, //Second Vector Position
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
             
    //Polygon With Position,6 Sides And Radius,No Rotation
    //And With Pink Color
    DrawPoly((Vector2){ 500,500 }, //Position
             6,                    //Number Of Sides
             80.0,                 //radius
             0.0,                  //rotation
             PINK);                //Color
             
    //Draw Pixel
    DrawPixel(400,                 //x Position
              400,                 //y Position
              BROWN);              //Color
    
    //Draw A Ring
    DrawRing((Vector2){ 100,450 }, //center Position
             60.0, //inner radius
             30.0, //outer(inside shape empty) radius
             0,    //start angle
             360,  //end angle
             100,  //segments
             DARKPURPLE); //Color     
      
    EndDrawing();
}
CloseWindow();
return 0;
}
