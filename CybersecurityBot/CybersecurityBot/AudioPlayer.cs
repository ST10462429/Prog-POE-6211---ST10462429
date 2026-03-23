using System;
using System.Media;
using System.IO;

namespace CybersecurityBot
{
    public static class AudioPlayer
    {

        // play greeting 
        public static void PlayGreeting(string filePath)
        {
            //looking for wav file
            string path = "file_example_WAV_1MG.wav";
            if (File.Exists(filePath))
            {
                try
                {
                    //new sound player insatnce 
                    SoundPlayer player = new SoundPlayer(filePath);

                    //play sync before contuing 
                    player.PlaySync();
                }
                catch (Exception ex)
                {
                    //error handling 
                    ConsoleUI.PrintWarning($"Could not play audio: {ex.Message}");
                    ConsoleUI.TypeEffect("(Skipping audio - continue with text resetting...)", ConsoleColor.DarkGray);

                }
            }
        }
    }
}
