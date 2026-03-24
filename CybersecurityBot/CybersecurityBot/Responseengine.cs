// ============================================================
// ResponseEngine.cs — Contains all chatbot response logic
// Uses parallel arrays for keywords and responses
// ============================================================

using System;

namespace CybersecurityBot
{
    public class Responseengine
    {
        // the user's name for personalised responses
        private string userName;

        // -------------------------------------------------------
        // Two parallel arrays:
        // keywords[i] matches with responses[i]
        // If user input contains keywords[0], return responses[0]
        // -------------------------------------------------------
        private string[] keywords;
        private string[] responses;

        // -------------------------------------------------------
        // Constructor — sets up the arrays with all keywords and responses
        // -------------------------------------------------------
        public Responseengine(string name)
        {
            userName = name;

            // Array of keywords to look for in user input
            keywords = new string[]
            {
                "how are you",
                "what is your purpose",
                "what can i ask you about",
                "hello",
                "hi",
                "password",
                "phishing",
                "safe browsing",
                "browsing",
                "two-factor",
                "2fa",
                "malware",
                "virus",
                "bye"
            };

            // Array of responses — each index matches the keyword above
            responses = new string[]
            {
                // how are you
                $"I'm running at full capacity, {userName}! Always ready to help you stay safe online.",

                // what is your purpose
                $"My purpose is to help you, {userName}, understand cybersecurity threats and best practices!",

                // what can i ask you about
                $"Great question, {userName}! You can ask me about:\n" +
                "  1. Password safety\n" +
                "  2. Phishing attacks\n" +
                "  3. Safe browsing\n" +
                "  4. Malware and viruses\n" +
                "  5. Two-factor authentication (2FA)",

                // hello
                $"Hello, {userName}! Type 'what can I ask you about' to see available topics.",

                // hi
                $"Hi there, {userName}! How can I help you stay secure today?",

                // password
                $"Great topic, {userName}! Here are key password safety tips:\n" +
                "  - Use at least 12 characters with letters, numbers and symbols\n" +
                "  - Never reuse passwords across different sites\n" +
                "  - Use a password manager like Bitwarden or LastPass\n" +
                "  - Avoid obvious passwords like 'password123'\n" +
                "  - Change passwords immediately if you suspect a breach",

                // phishing
                $"Phishing is a major threat, {userName}! Here is what to watch for:\n" +
                "  - Emails asking for urgent action or personal info\n" +
                "  - Links that do not match the sender's real domain\n" +
                "  - Poor spelling and grammar in official-looking emails\n" +
                "  - Unexpected attachments — never open them from unknown senders\n" +
                "  - Always verify by contacting the company directly",

                // safe browsing
                $"Safe browsing habits protect you, {userName}:\n" +
                "  - Always check for https:// before entering personal info\n" +
                "  - Avoid public Wi-Fi for banking or sensitive tasks\n" +
                "  - Keep your browser and plugins updated\n" +
                "  - Use a VPN on public networks\n" +
                "  - Do not click suspicious pop-ups or ads",

                // browsing
                $"Safe browsing habits protect you, {userName}:\n" +
                "  - Always check for https:// before entering personal info\n" +
                "  - Avoid public Wi-Fi for banking or sensitive tasks\n" +
                "  - Keep your browser and plugins updated",

                // two-factor
                $"Two-Factor Authentication (2FA) is essential, {userName}!\n" +
                "  - It adds a second layer of security beyond your password\n" +
                "  - Use an authenticator app like Google Authenticator or Authy\n" +
                "  - Enable 2FA on all important accounts like email and banking",

                // 2fa
                $"2FA adds a crucial extra layer of security, {userName}!\n" +
                "  - Even if someone steals your password they cannot log in without your second factor\n" +
                "  - Use authenticator apps over SMS when possible",

                // malware
                $"Malware is malicious software designed to harm your system, {userName}:\n" +
                "  - Types include viruses, trojans, ransomware and spyware\n" +
                "  - Keep your antivirus software up to date\n" +
                "  - Do not download software from unverified sources\n" +
                "  - Back up your data regularly to protect against ransomware",

                // virus
                $"Computer viruses are a type of malware, {userName}!\n" +
                "  - Install reputable antivirus software and keep it updated\n" +
                "  - Avoid clicking suspicious links or downloading unknown files\n" +
                "  - Scan USB drives before opening files on them",

                // bye
                $"Stay safe online, {userName}! Goodbye!"
            };
        }

        // -------------------------------------------------------
        // GetResponse(userInput)
        // Loops through the keywords array and checks if the user
        // input contains each keyword — returns matching response
        // -------------------------------------------------------
        public string GetResponse(string userInput)
        {
            // Convert to lowercase for case-insensitive matching
            string lowerInput = userInput.ToLower().Trim();

            // Loop through each keyword using index i
            for (int i = 0; i < keywords.Length; i++)
            {
                // Check if user input contains this keyword
                if (lowerInput.Contains(keywords[i]))
                {
                    return responses[i]; // Return the matching response at same index
                }
            }

            // No match found — return null to trigger fallback
            return null;
        }

        // -------------------------------------------------------
        // IsExitCommand(input)
        // Checks if user typed exit, quit or bye
        // -------------------------------------------------------
        public bool IsExitCommand(string input)
        {
            string lower = input.ToLower().Trim();
            return lower == "exit" || lower == "quit" || lower == "bye";
        }

        // -------------------------------------------------------
        // GetFallbackResponse()
        // Returns default message when no keyword is matched
        // -------------------------------------------------------
        public string GetFallbackResponse()
        {
            return $"I did not quite understand that, {userName}. Could you rephrase?\n" +
                   "  Type 'what can I ask you about' to see available topics.";
        }
    }
}