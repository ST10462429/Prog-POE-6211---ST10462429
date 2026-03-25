using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityBot
{
    public class Chatbot
    {
        // Private fields 
        //Wav greeting file = output folder 
        private const string WavFilePath = "greeting.wav";
        private ResponseEngine responseEngine;
        private string userName; // 
        //response engine instance 
        //main method for chatbot 
        // im calling it from program.cs

        public void Run()
        {
            //console window 
            Console.Title = "Cybersecurity Awareness Bot"; // window title 
            Console.OutputEncoding = System.Text.Encoding.UTF8; // emoji

            //display ASCII art logo 
            Console.Clear(); // to clear console first 
            ConsoleUI.DispalyAsciiArt(); // DISPLAYS LOGO 

            //play voice greeting 
            ConsoleUI.PrintSectionHeader("Voice Greeting");
            ConsoleUI.TypeEffect("Playing voice greeting...", ConsoleColor.DarkCyan);

            AudioPlayer.PlayGreeting(WavFilePath); // attempt to play wav file 

            //user input 
            ConsoleUI.PrintDivider();
            ConsoleUI.BotSay("Hello ! Welcome to the Cybersecurity Awareness Bot");
            ConsoleUI.BotSay("I'm here to help ypu stay safe online.");
            ConsoleUI.PrintDivider();


            userName = GetUserName(); // collect user input 

            //initialise the response engine with users name 
            responseEngine = new ResponseEngine(userName);

            //display personalised welcome message 
            DisplayWelcomeMessage(userName);

            //enter main chat loop 
            ChatLoop();
        }

        //validate user input 
        private string GetUserName()
        {
            string name = "";

            // loop will keep runing until system gets a valid non empty name 
            while (string.IsNullOrEmpty(name))
            {
                ConsoleUI.BotSay("Before we begin, whats your name?");
                name = ConsoleUI.UserPrompt();

                //validate 
                if (string.IsNullOrEmpty(name))
                {
                    ConsoleUI.PrintWarning("Name cannot be empty. please enter your name");

                }
            }
            return name.Trim();
        }
        private void DisplayWelcomeMessage(string userName)
        {
            ConsoleUI.PrintDivider();
            Thread.Sleep(300);

            ConsoleUI.TypeEffect($"\n ======================================================", ConsoleColor.Cyan);
            ConsoleUI.TypeEffect($" Welcome, {userName,-28}", ConsoleColor.Cyan);
            ConsoleUI.TypeEffect($" ==Your cybersecurity guide is ready. ==", ConsoleColor.Cyan);
            ConsoleUI.TypeEffect($" =========================================================", ConsoleColor.Cyan);
            Thread.Sleep(200);
            ConsoleUI.BotSay($"Great to meet you, {userName}! Ican help you with topics like:");
            ConsoleUI.TypeEffect("1.Passwords      2.Phising     3.Safe Browsing    4.Malware    5.2FA", ConsoleColor.DarkCyan);
            
            ///readline
        }

        //chat loop 
        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n Please select an option:");
                Console.WriteLine(" 1. Passwords safety ");
                Console.WriteLine("  2. Phishing");
                Console.WriteLine("  3. Safe Browsing");
                Console.WriteLine("  4. Malware");
                Console.WriteLine("  5. Two-Factor Authentication (2FA)");
                Console.WriteLine("  6. How are you?");
                Console.WriteLine("  7. What is your purpose?");
                Console.ResetColor();
                // get user input 

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n  Enter your choice (0-7): ");
                Console.ResetColor();
                string input = Console.ReadLine();

                if (input == null)
                    continue;

                if (input == null)
                    continue;

                // Trim whitespace
                input = input.Trim();

                // Check for empty
                if (input == "")
                {
                    ConsoleUI.PrintWarning("You did not enter anything. Please enter a number between 0 and 7.");
                    continue;
                }

                // Check for exit
                if (input == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\n  Stay safe online, {userName}! Goodbye!");
                    Console.ResetColor();
                    ConsoleUI.PrintDivider();
                    System.Threading.Thread.Sleep(1000);
                    break;
                }

                // Get response based on number selected
                string response = responseEngine.GetResponse(input);

                if (response != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n  [BOT] ");
                    Console.ResetColor();
                    Console.WriteLine(response);
                }
                else
                {
                    ConsoleUI.PrintWarning("Invalid choice. Please enter a number between 0 and 7.");
                }

                ConsoleUI.PrintDivider();
            }
        }
    }
            }
        
    

        
    


