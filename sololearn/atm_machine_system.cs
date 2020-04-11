using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace sololearn
  {
class program
 {
public static void Main(string[] args)
{
//Created By Rabia Alhaffar In 23/3/2019
//An ATM Machine System Using C#!!!
//Code Updated In 17/March/2020
//Improved Code Using Shorthands!!!
    
//Assigning Variables To The ATM Machine!!!
var Time = DateTime.Now;    
var Balance = 1000,Change_Balance = 1000;
var Total_Balance = Balance + Change_Balance,Delete_Balance = Balance - Balance;
var Currency = " USD"; 
string Command = Console.ReadLine();

//Drawing Graphics To The ATM Machine!!!
Console.WriteLine("Welcome To The ATM Machine System!!!\nWhat Do You Want?\n\n");
Console.WriteLine("1. Check My Balance\n\n2. Change My Balance\n\n3. Delete My Balance\n\n4. System Informations\n\n5. Shutdown\n\n");
Console.WriteLine("Please Enter The Command Number In The Input!!!\n");
for(var Lines = 0;Lines < 47;Lines++) Console.Write("-");

Console.Write("\n\n");

//The ATM Machine System!!!
if(Command == "1") Console.WriteLine("Your Balance Is: " + Balance + Currency);
if(Command == "2") Console.WriteLine("Balance Changed Successfully!!!\nYour Balance Now Is: "+ Total_Balance + Currency);
if(Command == "3") Console.WriteLine("Balance Deleted Successfully!!!\nYour Balance Now Is: "+ Delete_Balance + Currency);
if(Command == "4") Console.WriteLine("System Version: 1.1\nManufacturer: Rabia Alhaffar\nCurrency:" + Currency);
    Console.Write("Current Time: " + Time);
if(Command == "5") Console.WriteLine("System Shutdowned Successfully!!!\nThanks For Using The ATM Machine System!!!");
else Console.WriteLine("Unknown Command!!!\nPlease Try Again!!!");
  }    
 }    
}    