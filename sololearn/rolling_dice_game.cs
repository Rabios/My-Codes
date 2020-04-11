using System;
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
//Enter Your Name In The Input When Program Asks For That!!!
//Created By Rabia Alhaffar In 12/November/2018
//Re-Engineered In 1/November/2019
object UserName = Console.ReadLine();           
Random Dice = new Random();
int DiceRoll_1 = Dice.Next(7),DiceRoll_2 = Dice.Next(7);
Console.WriteLine("Welcome User " + UserName + " To The Game!!!\n\n" + "You First Rolled The Number " + DiceRoll_1 + "\nThen You Rolled Number " + DiceRoll_2 + "\nThe Number Of Rolls Is " + (DiceRoll_1 + DiceRoll_2) + "\n\n\nThanks For Playing The Game!!! " + ",User " + UserName + ".");
  }
 }
}