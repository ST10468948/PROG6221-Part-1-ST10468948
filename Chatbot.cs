using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatBot
{
    internal class Chatbot
    {
        public static void Chat()
        {
                    
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Please enter a cyberSecurtiy key Word for tips . e.g Password");

            string key = Console.ReadLine(); ;
            bool error2 = string.IsNullOrWhiteSpace(key);
            while (error2)
            {
                Console.WriteLine("error");
                Console.WriteLine(" enter again");
                key = Console.ReadLine();
                error2 = string.IsNullOrWhiteSpace(key);
            }

            key = key.ToLower();


            switch (key)
            {
                case "how are you":
                    Console.WriteLine("I'm just code but I'm here to help you");
                    break;
                case "password":
                    Console.WriteLine("To create a strong password include upper and lower case letters, numbers, and special characters.");
                    break;
                case "phishing":
                    Console.WriteLine("An attacker tricks you into clicking a malicious link. If you receive a suspicious email avoid clicking links or down­loading attachments");
                    break;
                case "multifactor authentication":
                    Console.WriteLine("Multifactor authentication (MFA) is an authentication method that asks users to provide two or more verification methods to access an online account");
                    break;
                case "antivirus":
                    Console.WriteLine("Internet security software guards your devices and data and blocks common threats like viruses and malware");
                    break;
                case "privacy":
                    Console.WriteLine("Take charge of how much information third-parties can access. Both web browsers and mobile operating systems have settings to protect your privacy online");
                    break;
                case "backup":
                    Console.WriteLine("If you have a copy of your data and your device falls victim to ransomware or other cyber threats, you will be able to restore the data from a backup.");
                    break;
                case "cameras":
                    Console.WriteLine(" if your device has a camera and it’s connected to the internet, it’s vulnerable to attack or people spying on you. Unplug or turn off and cover cameras when not in use.");
                    break;
                case "encryption":
                    Console.WriteLine("transforms readable plaintext into unreadable ciphertext to mask sensitive information. Some devices or services will offer encryption, but not set it as the default. Make sure to turn on encryption");
                    break;
                default:
                    Console.WriteLine("I didn't quite understand that.");
                    break;
            }

            Console.ResetColor();
        }

    }
}
