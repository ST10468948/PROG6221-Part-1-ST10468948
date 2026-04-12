using chatBot;
using System;
using System.IO;
using System.Media;


namespace PlayMusicC
{
    // This is the main class where the program starts
    class Program
    {

        // This is the Main method which is the entry point of the application
        static void Main(string[] args)
        {
            // Call the PlayMusic method from the AudioPlayer class and give it the file name
            AudioPlayer.PlayMusic("sage.wav");

            // Call the UserWelcome method from the User class to show the welcome screen
            User.UserWelcome();

            // Call the Chat method from the Chatbot class to start the conversation
            Chatbot.Chat();

        }
    }
}