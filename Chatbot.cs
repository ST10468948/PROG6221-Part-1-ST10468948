using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatBot
{
    // This is the Chatbot class that only other things in this project can see
    internal class Chatbot
    {
        // This is the Chat method that we call to start the loop
        public static void Chat()
        {
            // Start a loop that will keep running at least once
            do
            {
                // Change the text color to dark green
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                // Ask the user to type in a word to get a tip
                Console.WriteLine("Please enter a cyberSecurtiy key Word for tips . e.g Password ");

                // Read what the user types and save it in a variable called key
                string key = Console.ReadLine(); ;

                // Check if the user left it blank
                bool error2 = string.IsNullOrWhiteSpace(key);

                // This loop runs if the user didn't type anything
                while (error2)
                {
                    // Tell them to enter something valid and read it again
                    Console.WriteLine("Please enter a Valid input");
                    key = Console.ReadLine();

                    // Check again if it's still blank to see if we can stop looping
                    error2 = string.IsNullOrWhiteSpace(key);
                }

                // Change the word to lowercase so it matches our list even if they use caps
                key = key.ToLower();

                // Use a switch to check the word against different cases
                switch (key)
                {
                    // If they typed "how are you"
                    case "how are you":
                        Console.WriteLine("I'm just code but I'm here to help you");
                        break;
                    // If they typed "password"
                    case "password":
                        Console.WriteLine("To create a strong password include upper and lower case letters, numbers, and special characters.");
                        break;
                    // If they typed "phishing"
                    case "phishing":
                        Console.WriteLine("An attacker tricks you into clicking a malicious link. If you receive a suspicious email avoid clicking links or down­loading attachments");
                        break;
                    // If they typed "multifactor authentication"
                    case "multifactor authentication":
                        Console.WriteLine("Multifactor authentication (MFA) is an authentication method that asks users to provide two or more verification methods to access an online account");
                        break;
                    // If they typed "antivirus"
                    case "antivirus":
                        Console.WriteLine("Internet security software guards your devices and data and blocks common threats like viruses and malware");
                        break;
                    // If they typed "privacy"
                    case "privacy":
                        Console.WriteLine("Take charge of how much information third-parties can access. Both web browsers and mobile operating systems have settings to protect your privacy online");
                        break;
                    // If they typed "backup"
                    case "backup":
                        Console.WriteLine("If you have a copy of your data and your device falls victim to ransomware or other cyber threats, you will be able to restore the data from a backup.");
                        break;
                    // If they typed "cameras"
                    case "cameras":
                        Console.WriteLine(" if your device has a camera and it’s connected to the internet, it’s vulnerable to attack or people spying on you. Unplug or turn off and cover cameras when not in use.");
                        break;
                    // If they typed "encryption"
                    case "encryption":
                        Console.WriteLine("transforms readable plaintext into unreadable ciphertext to mask sensitive information. Some devices or services will offer encryption, but not set it as the default. Make sure to turn on encryption");
                        break;
                    // If they typed something that ia not on the list.
                    default:
                        Console.WriteLine("I didn't quite understand that.");
                        break;
                }

                // Ask the user if they want to stop or keep going
                Console.WriteLine();

                Console.WriteLine("Enter E to Exit or any other key to continue");

                // Keep looping as long as the user does NOT press the E key
            } while (Console.ReadKey(true).Key != ConsoleKey.E);

            // Change the console color back to normal
            Console.ResetColor();
        }
    }
}
