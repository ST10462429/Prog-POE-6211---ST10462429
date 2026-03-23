using System;
using System.Collections.Generic;
using System.Text;

namespace CybersecurityBot
{
    public class Responseengine
    {
        //username , stores the users name for personalised responses
        private string userName;

        //responses 
        private Dictionary<string, string> responses;

        //constructor 
        public Responseengine(string name)
        {
            userName = name; //store name 

            //populateresponses 
            responses = new Dictionary<string, string>()
            {
                {
                    "how are you", $" I'm running at full capacity, {userName}! Always ready to help you stay safe online." },
                {"what is your purpose", $"My purpose is to help you {userName}, understand cybersecurity threats and best practices. I can answer questions about passwords, phishing, safe browsing, and more!" },

                {"what can i ask you about",$"Great question, {userName}! You can ask me about:\n" + "Password saftey\n" + "Phishing attacks\n" + "Safe browsing\n" + "General cybersecurity tips\n" + "two-factor authentication\n" + "Malware and viruses"},
                {
                    "hello", $"Hello, {userName}! Great to see you. Type 'what can i ask you about' to see available topics." },
                {
                    "hi", $"Hi there, {userName}! how can i help you stay secure today?" },
                { "password",
                  $"Great topic, {userName}! Here are key password safety tips:\n" +
                  "   Use at least 12 characters with a mix of letters, numbers & symbols\n" +
                  "   Never reuse passwords across different sites\n" +
                  "   Use a password manager (e.g. Bitwarden, LastPass)\n" +
                  "   Avoid obvious passwords like 'password123' or your name\n" +
                  "   Change passwords immediately if you suspect a breach" },

                { "phishing",
                  $"Phishing is a major threat, {userName}! Here's what to watch for:\n" +
                  "   Emails asking for urgent action or personal info\n" +
                  "   Links that don't match the sender's real domain\n" +
                  "   Poor spelling and grammar in official-looking emails\n" +
                  "   Unexpected attachments — never open them from unknown senders\n" +
                  "   Always verify by contacting the company directly" },

                { "browsing",
                  $"Safe browsing habits protect you, {userName}:\n" +
                  "   Always check for 'https://' before entering personal info\n" +
                  "   Avoid using public Wi-Fi for banking or sensitive tasks\n" +
                  "   Keep your browser and plugins updated\n" +
                  "   Use a VPN on public networks\n" +
                  "   Don't click suspicious pop-ups or ads" },

                { "safe browsing",
                  $"Safe browsing habits protect you, {userName}:\n" +
                  "   Always check for 'https://' before entering personal info\n" +
                  "   Avoid using public Wi-Fi for banking or sensitive tasks\n" +
                  "   Keep your browser and plugins updated\n" +
                  "   Use a VPN on public networks\n" +
                  "   Don't click suspicious pop-ups or ads" },

                { "two-factor",
                  $"Two-Factor Authentication (2FA) is essential, {userName}!\n" +
                  "   It adds a second layer of security beyond your password\n" +
                  "   Use an authenticator app (Google Authenticator, Authy)\n" +
                  "   SMS codes are better than nothing, but apps are more secure\n" +
                  "   Enable 2FA on all important accounts (email, banking, social media)" },

                { "2fa",
                  $"2FA (Two-Factor Authentication) adds a crucial extra layer, {userName}!\n" +
                  "   Even if someone steals your password, they can't log in without your second factor\n" +
                  "   Use authenticator apps over SMS when possible" },

                { "malware",
                  $"Malware is malicious software designed to harm your system, {userName}:\n" +
                  "   Types include: viruses, trojans, ransomware, spyware\n" +
                  "   Keep your antivirus software up to date\n" +
                  "   Don't download software from unverified sources\n" +
                  "   Regularly scan your computer for threats\n" +
                  "   Back up your data regularly to protect against ransomware" },

                { "virus",
                  $"Computer viruses are a type of malware, {userName}!\n" +
                  "   Install reputable antivirus software and keep it updated\n" +
                  "   Avoid clicking suspicious links or downloading unknown files\n" +
                  "   Scan USB drives before opening files on them" },


                //exit 
                {"exit",   "" }, 
                {"quit",   "" }, {"bye",  $"Stay safe online, {userName}! Goodbye!"},
            };
            }

        //get response 
        public string GetResponse(string userInput)
        {
            //CONVERT input to lower case for insensitive matching 
            string lowerInput = userInput.ToLower().Trim();

            //loop through each dictionary 
            foreach (var entry in responses)
            {

                // check if the user input contains the keyword 
                if (lowerInput.Contains(entry.Key))

                {
                    return entry.Value;
                }
            }

            return null;
        }

        //exit command 
        public  bool IsExitCommand(string input)
        {
            string lower = input.ToLower().Trim();
            //return true if user typed any variation of exit 
            return lower == "exit" || lower == "quit" || lower == "bye";
        }

        //get get fall back response 
        public string GetFallbackResponse()

        {
            return $"I did not quite understand that , {userName}. Could you rephrase \n " + "Type 'what can i ask you about to see available topics.";

        }
        }
    }

