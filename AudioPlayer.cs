using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace chatBot
{
    // Creating another class called AudioPlayer to handle sound
    public class AudioPlayer
    {
        // A method that takes a file path string to play music
        public static void PlayMusic(string filepath)
        {
            // Making a new SoundPlayer object so we can use its functions
            SoundPlayer musicPlayer = new SoundPlayer();
            // Telling the player where the music file is located on the computer
            musicPlayer.SoundLocation = filepath;
            // This actually starts playing the sound
            musicPlayer.Play();

        }
    }
}
