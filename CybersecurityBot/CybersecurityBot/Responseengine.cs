namespace CybersecurityBot
{
    public class ResponseEngine
    {
        private string name;

        public ResponseEngine(string userName)
        {
            name = userName;
        }

        public string GetResponse(string input)
        {
            switch (input)
            {
                case "1":
                    return $"PASSWORD SAFETY — {name}\n\n" +
                           "• Use strong passwords (at least 12 characters)\n" +
                           "• Include letters, numbers, and symbols\n" +
                           "• Do not reuse passwords across sites\n" +
                           "• Use a password manager\n" +
                           "• Avoid obvious passwords like 'password123'";

                case "2":
                    return $"PHISHING — {name}\n\n" +
                           "• Be cautious of urgent or suspicious emails\n" +
                           "• Do not click unknown links\n" +
                           "• Check the sender’s email address carefully\n" +
                           "• Avoid downloading unexpected attachments\n" +
                           "• Verify messages with the company directly";

                case "3":
                    return $"SAFE BROWSING — {name}\n\n" +
                           "• Only enter information on HTTPS websites\n" +
                           "• Avoid public Wi-Fi for sensitive activities\n" +
                           "• Keep your browser updated\n" +
                           "• Do not click suspicious ads or pop-ups\n" +
                           "• Use trusted websites only";

                case "4":
                    return $"MALWARE — {name}\n\n" +
                           "• Malware includes viruses, spyware, and ransomware\n" +
                           "• Install and update antivirus software\n" +
                           "• Do not download files from unknown sources\n" +
                           "• Scan USB devices before use\n" +
                           "• Back up your data regularly";

                case "5":
                    return $"TWO-FACTOR AUTHENTICATION (2FA) — {name}\n\n" +
                           "• Adds an extra layer of security\n" +
                           "• Use authenticator apps instead of SMS when possible\n" +
                           "• Enable 2FA on email, banking, and social media\n" +
                           "• Protects your account even if your password is stolen";

                case "6":
                    return $"I'm doing great, {name}! I'm always ready to help you stay safe online 😄";

                case "7":
                    return $"My purpose is to help you understand cybersecurity risks and stay safe online, {name}!";

                default:
                    return null;
            }
        }
    }
}