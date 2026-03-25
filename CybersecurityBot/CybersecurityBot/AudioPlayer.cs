using System;
using System.IO;
using System.Media;

namespace CybersecurityBot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("(Audio file 'greeting.wav' not found)");
                return;
            }

            try
            {
                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.PlaySync(); // plays before continuing
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Audio error: {ex.Message}");
            }
        }
    }
}