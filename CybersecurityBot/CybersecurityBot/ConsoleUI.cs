using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CybersecurityBot
{
  public static class ConsoleUI
    {
        private static bool c;

        /// Display 
        /// //print cybersecurity ASCII art logo 

        public static void DispalyAsciiArt()
        {

            //seting text colour to logo
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║   
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══██╗██║   ██║   ██║   
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║   
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝    ╚═╝   
               CYBERSECURITY AWARENESS BOT 
           Keeping you safe in the digital world 
");

            Console.ResetColor();
        }
        /// adding a divider 
        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("===========================================================================");

            Console.ResetColor();
        }
        //adding header 
        public static void PrintSectionHeader(string title)
        {
            Console.WriteLine(); //a space 
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"== {title.ToUpper()}==");
            Console.ResetColor();
        }

        //typing effect 
        public static void TypeEffect(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;

            //loop for each character 
            {
                Console.Write(c);
                Thread.Sleep(18);
            }
            Console.WriteLine();
            Console.ResetColor();
        
            }
        
        public static void BotSay(string message) {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n[BOT]");
            Console.ResetColor();
            TypeEffect(message, ConsoleColor.White);
        }

        //UserPromt
        public static string UserPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n [YOU] ->");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }
        //print a warning message 
        public static void PrintWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n WARNING {message}");
            Console.ResetColor();
        }

        //print info message 
        public static void PrintInfo(SecureString message)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"\n TIP: {message}");
            Console.ResetColor();

        }
        }
    }


