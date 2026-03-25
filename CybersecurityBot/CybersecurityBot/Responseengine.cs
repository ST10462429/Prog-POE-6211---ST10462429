using System;

namespace CybersecurityBot
{
    public class ResponseEngine
    {
        private string userName;

        public ResponseEngine(string name)
        {
            userName = name;
        }

        // -------------------------------------------------------
        // GetResponse(input)
        // Matches the number the user typed to a response
        // -------------------------------------------------------
        public string GetResponse(string input)
        {
            switch (input)
            {
                case "1":
                    return $"PASSWORD SAFETY — {userName}:\n\n" +
                           "  - Use at least 12 characters with letters, numbers and symbols\n" +
                           "  - Never reuse passwords across different sites\n" +
                           "  - Use a password manager like Bitwarden or LastPass\n" +
                           "  - Avoid obvious passwords like password123\n" +
                           "  - Change passwords immediately if you suspect a breach";

                case "2":
                    return $"PHISHING — {userName}:\n\n" +
                           "  - Watch for emails asking for urgent action or personal info\n" +
                           "  - Check that links match the sender's real domain\n" +
                           "  - Look for poor spelling and grammar in official-looking emails\n" +
                           "  - Never open unexpected attachments from unknown senders\n" +
                           "  - Always verify by contacting the company directly";

                case "3":
                    return $"SAFE BROWSING — {userName}:\n\n" +
                           "  - Always check for https:// before entering personal info\n" +
                           "  - Avoid public Wi-Fi for banking or sensitive tasks\n" +
                           "  - Keep your browser and plugins updated\n" +
                           "  - Use a VPN on public networks\n" +
                           "  - Do not click suspicious pop-ups or ads";

                case "4":
                    return $"MALWARE — {userName}:\n\n" +
                           "  - Types include viruses, trojans, ransomware and spyware\n" +
                           "  - Keep your antivirus software up to date\n" +
                           "  - Do not download software from unverified sources\n" +
                           "  - Back up your data regularly to protect against ransomware\n" +
                           "  - Scan USB drives before opening files on them";

                case "5":
                    return $"TWO-FACTOR AUTHENTICATION — {userName}:\n\n" +
                           "  - 2FA adds a second layer of security beyond your password\n" +
                           "  - Use an authenticator app like Google Authenticator or Authy\n" +
                           "  - Enable 2FA on all important accounts like email and banking\n" +
                           "  - SMS codes are better than nothing but apps are more secure\n" +
                           "  - Even if your password is stolen 2FA keeps you protected";

                case "6":
                    return $"I am running at full capacity, {userName}! Always ready to help you stay safe online.";

                case "7":
                    return $"My purpose is to help you, {userName}, understand cybersecurity threats and best practices!\n" +
                           "  Select any option from the menu to learn more.";

                default:
                    // Return null to trigger invalid choice warning
                    return null;
            }
        }

        // -------------------------------------------------------
        // IsExitCommand — kept for compatibility but 0 handles exit now
        // -------------------------------------------------------
        public bool IsExitCommand(string input)
        {
            return input.Trim() == "0";
        }

        public string GetFallbackResponse()
        {
            return $"Invalid choice, {userName}. Please enter a number between 0 and 7.";
        }
    }
}