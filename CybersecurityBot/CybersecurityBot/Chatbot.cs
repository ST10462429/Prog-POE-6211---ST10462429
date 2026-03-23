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
        private Responseengine responseEngine;
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


            string userName = GetUserName(); // collect user input 

            //initialise the response engine with users name 
            responseEngine = new Responseengine(userName);

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
            ConsoleUI.BotSay("Type 'what can i ask you about' to see all topics or 'exit' to quit.");
            ConsoleUI.PrintDivider();
        }

        //chat loop 
         private void ChatLoop()
        {
            while(true) {
                // get user input 
                string userInput = ConsoleUI.UserPrompt();

                //VALIDATE 
                if (string.IsNullOrEmpty(userInput))
                {

                    //handling 
                    ConsoleUI.PrintWarning("You did not type anything. Please enter a question or command.");
                    continue; // skips to next loop 
                }

                //check for exit command 
                if (responseEngine.IsExitCommand(userInput))
                {
                    //display goodbye message 
                    ConsoleUI.PrintDivider();
                    Thread.Sleep(1000);
                    break;
                }

                //get and display bot response 
                string response = responseEngine.GetResponse(userInput);
                if (response ! == null)
                {

                    ConsoleUI.BotSay(response);
                }
                else
                {
                    //if no match 

                    ConsoleUI.BotSay(responseEngine.GetFallbackResponse());
                }
                ConsoleUI.PrintDivider();
        }
        }
    }

}
