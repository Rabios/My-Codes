using System;
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
//Re-Engineered The Examples Itself In 1/November/2019
//How To Play:In Input Enter A Number From 100000 To 999999 As Password(6-Digit Number)
object PasswordCheck = Console.ReadLine();
Random PasswordCreator = new Random();
object L1 = PasswordCreator.Next(100000,1000000);
Console.WriteLine("Password You Entered: " + PasswordCheck + "\nComputer Password Is: " + L1 + "\n\n");
if (PasswordCheck == L1) Console.WriteLine("Computer Hacked!!!\nYou Win!!!\n\n\nThanks For Playing The Game!!!");
else Console.WriteLine("Hack Failed!!!\nYou Lose!!!\n\n\nThanks For Playing The Game!!!");
        }
    }
}
