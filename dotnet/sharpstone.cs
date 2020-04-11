//Copyright (c)2018 - 2019 , Rabia Alhaffar,All Rights Reserved!!!
//Sharpstone Version 1.8.0.0,A C# .NET Command Line Created For C# Developers!!!
using System;
using System.CodeDom;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using Microsoft.CSharp;
using Microsoft.Win32;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml;
using System.Web;
using Microsoft.SqlServer;
using Microsoft.VisualBasic;
using System.Data;
using System.Deployment;
using System.Dynamic;
using System.Globalization;
using System.Reflection;
using System.Management;
using System.Resources;
using System.Security;
namespace Sharpstone
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Adding Theme For Fonts & Backgrounds!!!
			Console.ForegroundColor = ConsoleColor.Magenta;
			//Adding Titles!!!
			Console.Title = "Sharpstone Interactive .NET C# Command Line";
			System.Console.WriteLine("Sharpstone .NET C# Command Line (R) Version 1.8.0.0\nMicrosoft (R) Visual C# Compiler Version " + typeof(string).Assembly.ImageRuntimeVersion + "\n\nRabia Alhaffar (c)2018 - 2019,All Rights Reserved!!!\nThe Ultimate Real Time .NET Interactive Command Line For Microsoft Windows .NET C# Developers!!!\n");
			//Asking For The Commsnd!!!
			var command = Console.ReadLine();
			    //Full Command Line Source Code Included Here!!!
			    while (command.Contains("") == true)
			    {
			    	while(command.Contains("") == true)
			    	{
	            //Command: System.Console.Write(); 
				if(command.Contains("System.Console.Write(") == true)
				{
					command = command.Replace("System.Console.Write(","").Replace("\"","").Replace(");","");
					System.Console.Write(">>> " + command);
					command = Console.ReadLine();
				if(command.Contains("System.Console.Write(") == true)
				{
		            command = command.Replace("System.Console.Write(","").Replace("\"","").Replace(");","");
					System.Console.Write(">>> " + command);
					command = Console.ReadLine();
		         }
		         }
				//Command: System.Console.WriteLine();
				else if(command.Contains("System.Console.WriteLine(") == true)
				{
					command = command.Replace("System.Console.WriteLine(","").Replace("\"","").Replace(");","");
					System.Console.WriteLine(">>> " + command);
					command = Console.ReadLine();
				if(command.Contains("System.Console.WriteLine(") == true)
				{
                    command = command.Replace("System.Console.WriteLine(","").Replace("\"","").Replace(");","");
					System.Console.WriteLine(">>> " + command);
					command = Console.ReadLine();
		         }
		         }
		        //Command: DateTime.Now();
				else if(command.Contains("DateTime.Now();") == true)
				{
					command = command.Replace("DateTime.Now();","");
					System.Console.WriteLine(">>> " + DateTime.Now.ToString());
					command = Console.ReadLine();
				if(command.Contains("DateTime.Now();") == true)
				{
	                command = command.Replace("DateTime.Now();","");
	                System.Console.WriteLine(">>> " + DateTime.Now.ToString());
					command = Console.ReadLine();
		         }
		         }
				//Command: Console.Clear();
				else if(command.Contains("Console.Clear();") == true)
				{
					command = command.Replace("Console.Clear();","");
					Console.Clear();
					command = Console.ReadLine();
				if(command.Contains("Console.Clear();") == true)
				{
	                command = command.Replace("Console.Clear();","");
	                Console.Clear();
					command = Console.ReadLine();
		         }
		         }
				//Command: System.Diagnostics.Process.Start();
				else if(command.Contains("System.Diagnostics.Process.Start(") == true)
				{
					command = command.Replace("System.Diagnostics.Process.Start(","").Replace(");","").Replace("@","").Replace("\"","").Replace(");","");
					System.Console.WriteLine(">>> Starting: " + command);
				    System.Diagnostics.Process.Start(command);
				    command = Console.ReadLine();
			    if(command.Contains("System.Diagnostics.Process.Start(") == true)
				{
	                command = command.Replace("System.Diagnostics.Process.Start(","").Replace(");","").Replace("@","").Replace("\"","").Replace(");","");
					System.Console.WriteLine(">>> Starting: " + command);
				    System.Diagnostics.Process.Start(command);
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Black;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Black;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Black;","");
					Console.BackgroundColor = ConsoleColor.Black;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Black;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Black;","");
					Console.BackgroundColor = ConsoleColor.Black;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Blue;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Blue;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Blue;","");
					Console.BackgroundColor = ConsoleColor.Blue;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Blue;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Blue;","");
					Console.BackgroundColor = ConsoleColor.Blue;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Cyan;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Cyan;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Cyan;","");
					Console.BackgroundColor = ConsoleColor.Cyan;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Cyan;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Cyan;","");
					Console.BackgroundColor = ConsoleColor.Cyan;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.DarkBlue;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkBlue;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkBlue;","");
					Console.BackgroundColor = ConsoleColor.DarkBlue;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkBlue;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkBlue;","");
					Console.BackgroundColor = ConsoleColor.DarkBlue;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.DarkCyan;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkCyan;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkCyan;","");
					Console.BackgroundColor = ConsoleColor.DarkCyan;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkCyan;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkCyan;","");
					Console.BackgroundColor = ConsoleColor.DarkCyan;
				    command = Console.ReadLine();
			    }
				}
			    //Command: Console.BackgroundColor = ConsoleColor.DarkGray;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkGray;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkGray;","");
					Console.BackgroundColor = ConsoleColor.DarkGray;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkGray;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkGray;","");
					Console.BackgroundColor = ConsoleColor.DarkGray;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.DarkGreen;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkGreen;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkGreen;","");
					Console.BackgroundColor = ConsoleColor.DarkGreen;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkGreen;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkGreen;","");
					Console.BackgroundColor = ConsoleColor.DarkGreen;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.DarkMagenta;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkMagenta;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkMagenta;","");
					Console.BackgroundColor = ConsoleColor.DarkMagenta;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkMagenta;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkMagenta;","");
					Console.BackgroundColor = ConsoleColor.DarkMagenta;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.DarkRed;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkRed;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkRed;","");
					Console.BackgroundColor = ConsoleColor.DarkRed;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkRed;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkRed;","");
					Console.BackgroundColor = ConsoleColor.DarkRed;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.DarkYellow;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkYellow;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkYellow;","");
					Console.BackgroundColor = ConsoleColor.DarkYellow;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.DarkYellow;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.DarkYellow;","");
					Console.BackgroundColor = ConsoleColor.DarkYellow;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Gray;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Gray;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Gray;","");
					Console.BackgroundColor = ConsoleColor.Gray;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Gray;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Gray;","");
					Console.BackgroundColor = ConsoleColor.Gray;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Green;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Green;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Green;","");
					Console.BackgroundColor = ConsoleColor.Green;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Green;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Green;","");
					Console.BackgroundColor = ConsoleColor.Green;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Magenta;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Magenta;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Magenta;","");
					Console.BackgroundColor = ConsoleColor.Magenta;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Magenta;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Magenta;","");
					Console.BackgroundColor = ConsoleColor.Magenta;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Red;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Red;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Red;","");
					Console.BackgroundColor = ConsoleColor.Red;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Red;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Red;","");
					Console.BackgroundColor = ConsoleColor.Red;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.White;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.White;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.White;","");
					Console.BackgroundColor = ConsoleColor.White;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.White;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.White;","");
					Console.BackgroundColor = ConsoleColor.White;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.BackgroundColor = ConsoleColor.Yellow;
				else if(command.Contains("Console.BackgroundColor = ConsoleColor.Yellow;") == true)
				{
					command = command.Replace("Console.BackgroundColor = ConsoleColor.Yellow;","");
					Console.BackgroundColor = ConsoleColor.Yellow;
				    command = Console.ReadLine();
			    if(command.Contains("Console.BackgroundColor = ConsoleColor.Yellow;") == true)
				{
				    command = command.Replace("Console.BackgroundColor = ConsoleColor.Yellow;","");
					Console.BackgroundColor = ConsoleColor.Yellow;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Black;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Black;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Black;","");
					Console.ForegroundColor = ConsoleColor.Black;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Black;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Black;","");
					Console.ForegroundColor = ConsoleColor.Black;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Blue;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Blue;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Blue;","");
					Console.ForegroundColor = ConsoleColor.Blue;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Blue;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Blue;","");
					Console.ForegroundColor = ConsoleColor.Blue;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Cyan;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Cyan;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Cyan;","");
					Console.ForegroundColor = ConsoleColor.Cyan;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Cyan;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Cyan;","");
					Console.ForegroundColor = ConsoleColor.Cyan;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkBlue;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkBlue;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkBlue;","");
					Console.ForegroundColor = ConsoleColor.DarkBlue;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkBlue;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkBlue;","");
					Console.ForegroundColor = ConsoleColor.DarkBlue;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkCyan;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkCyan;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkCyan;","");
					Console.ForegroundColor = ConsoleColor.DarkCyan;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkCyan;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkCyan;","");
					Console.ForegroundColor = ConsoleColor.DarkCyan;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkGray;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkGray;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkGray;","");
					Console.ForegroundColor = ConsoleColor.DarkGray;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkGray;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkGray;","");
					Console.ForegroundColor = ConsoleColor.DarkGray;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkGreen;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkGreen;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkGreen;","");
					Console.ForegroundColor = ConsoleColor.DarkGreen;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkGreen;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkGreen;","");
					Console.ForegroundColor = ConsoleColor.DarkGreen;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkMagenta;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkMagenta;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkMagenta;","");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkMagenta;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkMagenta;","");
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkRed;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkRed;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkRed;","");
					Console.ForegroundColor = ConsoleColor.DarkRed;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkRed;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkRed;","");
					Console.ForegroundColor = ConsoleColor.DarkRed;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.DarkYellow;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkYellow;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkYellow;","");
					Console.ForegroundColor = ConsoleColor.DarkYellow;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.DarkYellow;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.DarkYellow;","");
					Console.ForegroundColor = ConsoleColor.DarkYellow;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Gray;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Gray;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Gray;","");
					Console.ForegroundColor = ConsoleColor.Gray;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Gray;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Gray;","");
					Console.ForegroundColor = ConsoleColor.Gray;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Green;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Green;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Green;","");
					Console.ForegroundColor = ConsoleColor.Green;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Green;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Green;","");
					Console.ForegroundColor = ConsoleColor.Green;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Magenta;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Magenta;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Magenta;","");
					Console.ForegroundColor = ConsoleColor.Magenta;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Magenta;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Magenta;","");
					Console.ForegroundColor = ConsoleColor.Magenta;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Red;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Red;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Red;","");
					Console.ForegroundColor = ConsoleColor.Red;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Red;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Red;","");
					Console.ForegroundColor = ConsoleColor.Red;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.White;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.White;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.White;","");
					Console.ForegroundColor = ConsoleColor.White;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.White;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.White;","");
					Console.ForegroundColor = ConsoleColor.White;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.ForegroundColor = ConsoleColor.Yellow;
				else if(command.Contains("Console.ForegroundColor = ConsoleColor.Yellow;") == true)
				{
					command = command.Replace("Console.ForegroundColor = ConsoleColor.Yellow;","");
					Console.ForegroundColor = ConsoleColor.Yellow;
				    command = Console.ReadLine();
			    if(command.Contains("Console.ForegroundColor = ConsoleColor.Yellow;") == true)
				{
				    command = command.Replace("Console.ForegroundColor = ConsoleColor.Yellow;","");
					Console.ForegroundColor = ConsoleColor.Yellow;
				    command = Console.ReadLine();
			    }
				}
				//Command: Console.Beep();
				else if(command.Contains("Console.Beep();") == true)
				{
					command = command.Replace("Console.Beep();","");
					Console.Beep();
					command = Console.ReadLine();
			    if(command.Contains("Console.Beep();") == true)
				{
				    command = command.Replace("Console.Beep();","");
					Console.Beep();
					command = Console.ReadLine();
			    }
				}
		        //Command: System.Media.SystemSounds.Asterisk.Play();
				else if(command.Contains("System.Media.SystemSounds.Asterisk.Play();") == true)
				{
					command = command.Replace("System.Media.SystemSounds.Asterisk.Play();","");
					System.Media.SystemSounds.Asterisk.Play();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SystemSounds.Asterisk.Play();") == true)
				{
				    command = command.Replace("System.Media.SystemSounds.Asterisk.Play();","");
					System.Media.SystemSounds.Asterisk.Play();
					command = Console.ReadLine();
			    }
				}
				//Command: System.Media.SystemSounds.Hand.Play();
				else if(command.Contains("System.Media.SystemSounds.Hand.Play();") == true)
				{
					command = command.Replace("System.Media.SystemSounds.Hand.Play();","");
					System.Media.SystemSounds.Hand.Play();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SystemSounds.Hand.Play();") == true)
				{
				    command = command.Replace("System.Media.SystemSounds.Hand.Play();","");
					System.Media.SystemSounds.Hand.Play();
					command = Console.ReadLine();
			    }
				}
				//Command: System.Media.SystemSounds.Beep.Play();
				else if(command.Contains("System.Media.SystemSounds.Beep.Play();") == true)
				{
					command = command.Replace("System.Media.SystemSounds.Beep.Play();","");
					System.Media.SystemSounds.Beep.Play();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SystemSounds.Beep.Play();") == true)
				{
				    command = command.Replace("System.Media.SystemSounds.Beep.Play();","");
					System.Media.SystemSounds.Beep.Play();
					command = Console.ReadLine();
			    }
				}
				//Command: System.Media.SystemSounds.Exclamation.Play();
				else if(command.Contains("System.Media.SystemSounds.Exclamation.Play();") == true)
				{
					command = command.Replace("System.Media.SystemSounds.Exclamation.Play();","");
					System.Media.SystemSounds.Exclamation.Play();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SystemSounds.Exclamation.Play();") == true)
				{
				    command = command.Replace("System.Media.SystemSounds.Exclamation.Play();","");
					System.Media.SystemSounds.Exclamation.Play();
					command = Console.ReadLine();
			    }
				}
				//Command: System.Media.SystemSounds.Question.Play();
				else if(command.Contains("System.Media.SystemSounds.Question.Play();") == true)
				{
					command = command.Replace("System.Media.SystemSounds.Question.Play();","");
					System.Media.SystemSounds.Question.Play();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SystemSounds.Question.Play();") == true)
				{
				    command = command.Replace("System.Media.SystemSounds.Question.Play();","");
					System.Media.SystemSounds.Question.Play();
					command = Console.ReadLine();
			    }
				}
				//Command: System.Media.SoundPlayer.Play(File Directory In WAV Type);
				else if(command.Contains("System.Media.SoundPlayer.Play(") == true)
				{
					command = command.Replace("System.Media.SoundPlayer.Play(","");
					command = command.Replace(");","");
					command = command.Replace("@","");
					command = command.Replace("\"","");
					System.Media.SoundPlayer player = new System.Media.SoundPlayer(command.ToString());
                    player.Play();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SoundPlayer.Play(") == true)
				{
				    command = command.Replace("System.Media.SoundPlayer.Play(","");
				    command = command.Replace(");","");
				    command = command.Replace("@","");
					command = command.Replace("\"","");
					System.Media.SoundPlayer player_0 = new System.Media.SoundPlayer(command.ToString());
                    player_0.Play();
					command = Console.ReadLine();
			    }
				}
				//Command: System.Media.SoundPlayer.Stop();
				else if(command.Contains("System.Media.SoundPlayer.Stop();") == true)
				{
					command = command.Replace("System.Media.SoundPlayer.Stop();","");
					System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.Stop();
					command = Console.ReadLine();
			    if(command.Contains("System.Media.SoundPlayer.Stop();") == true)
				{
				    command = command.Replace("System.Media.SoundPlayer.Stop();","");
					System.Media.SoundPlayer player_0 = new System.Media.SoundPlayer();
                    player_0.Stop();
					command = Console.ReadLine();
			    }
				}
					command = Console.ReadLine();
			    }
			    //Command: System.IO.File.Create();
				if(command.Contains("System.IO.File.Create(") == true)
				{
					command = command.Replace("System.IO.File.Create(","").Replace(");","").Replace("@","").Replace("\"","");
					System.IO.File.Create(command.ToString());
					command = Console.ReadLine();
			    if(command.Contains("System.IO.File.Create(") == true)
				{
	                command = command.Replace("System.IO.File.Create(","").Replace(");","").Replace("@","").Replace("\"","");
					System.IO.File.Create(command.ToString());
					command = Console.ReadLine();
			    }
				}
				//Command: System.IO.File.Delete();
				else if(command.Contains("System.IO.File.Delete(") == true)
				{
			        command = command.Replace("System.IO.File.Delete(","").Replace(");","").Replace("@","").Replace("\"","");
					System.IO.File.Delete(command.ToString());
					command = Console.ReadLine();
			    if(command.Contains("System.IO.File.Delete(") == true)
				{
	                command = command.Replace("System.IO.File.Delete(","").Replace(");","").Replace("@","").Replace("\"","");
					System.IO.File.Delete(command.ToString());
					command = Console.ReadLine();
			    }
				}		
				//Command: Thread.Sleep();
				//Note: The Sleeping Of The Thread Is 1 Second,If You Are A .NET Developer/Programmer,Change It If You Want!!!
				else if(command.Contains("Thread.Sleep();") == true)
				{
					command = command.Replace("Thread.Sleep();","");
					Thread.Sleep(1000);
					command = Console.ReadLine();
				if(command.Contains("Thread.Sleep();") == true)
				{
					command = command.Replace("Thread.Sleep();","");
					Thread.Sleep(1000);
					command = Console.ReadLine();
				}
				}
					command = Console.ReadLine();
			    }
		Console.ReadKey(true);
		}
	  }
	}	