using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created By Rabia Alhaffar In 25/2/2019
            //An Load Game Using Passwords Example!!!
            //Beautiful Information:In Old Devices,They Uses This Technique,Because There Are Not Any Way To Save The Game!!!
            
            //Defining Game Passwords!!! 
            var Level_1 = "FaUxDeLKvGbekf",Level_2 = "GaVdTfLoKwDXsZ",Level_3 = "DsFgWeGmOpQvAs";
            
            //Load Game Level By Checking & Asking For Password!!!
            var Load_Game = Console.ReadLine();
            
            //Startup System!!!
            Console.WriteLine("Loading Game......");
            if (Load_Game == Level_1) Console.Write("LEVEL 1");    
            if (Load_Game == Level_2) Console.Write("LEVEL 2");
            if (Load_Game == Level_3) Console.Write("LEVEL 3");
            else Console.Write("NOT FOUND!!!");
        }
    }
}
