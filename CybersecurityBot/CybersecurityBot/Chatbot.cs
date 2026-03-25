using System;
using System.Threading;

namespace CybersecurityBot
{
    public class Chatbot
    {
        private ResponseEngine engine;
        private string userName;
        private const string AudioFile = "greeting.wav";

        public void Run()
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.Clear();

            ShowHeader();

            // 🔊 Play audio greeting
            AudioPlayer.PlayGreeting(AudioFile);

            Console.WriteLine("\nHello! Welcome to the Cybersecurity Awareness Bot.");
            Console.WriteLine("I'm here to help you stay safe online.\n");

            userName = GetUserName();
            engine = new ResponseEngine(userName);

            Console.WriteLine($"\nNice to meet you, {userName}!\n");

            ChatLoop();
        }

        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================================");
            Console.WriteLine("     CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("===============================================");
            Console.ResetColor();
        }

        private string GetUserName()
        {
            string name = "";

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name cannot be empty.");
                    Console.ResetColor();
                }
            }

            return name.Trim();
        }

        private void ChatLoop()
        {
            while (true)
            {
                ShowMenu();

                Console.Write("\nSelect option (0-7): ");
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(input))
                {
                    ShowError("Invalid input.");
                    continue;
                }

                if (input == "0")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nThank you for using the Cybersecurity Awareness Bot, {userName}.");
                    Console.WriteLine("Stay safe online! 👋");
                    Console.ResetColor();
                    break;
                }

                string response = engine.GetResponse(input);

                if (response != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" + response);
                    Console.ResetColor();
                }
                else
                {
                    ShowError("Invalid choice. Enter 0–7.");
                }

                Thread.Sleep(500);
            }
        }

        private void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n================ MENU ================");
            Console.WriteLine(" 1. Password Safety");
            Console.WriteLine(" 2. Phishing");
            Console.WriteLine(" 3. Safe Browsing");
            Console.WriteLine(" 4. Malware");
            Console.WriteLine(" 5. Two-Factor Authentication (2FA)");
            Console.WriteLine(" 6. How are you?");
            Console.WriteLine(" 7. What is your purpose?");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("======================================");

            Console.ResetColor();
        }

        private void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERROR] {message}");
            Console.ResetColor();
        }
    }
}