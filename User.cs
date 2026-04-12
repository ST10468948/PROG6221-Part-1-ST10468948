using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This is the namespace for the project
namespace chatBot
{
    // Creating a class called User
    public class User
    {
        // This is a method to welcome the user
        public static void UserWelcome()
        {
            // This loop goes through every letter in the word WELCOME
            foreach (char c in "WELCOME")
            {
                // Print the letter to the screen
                Console.WriteLine(c);
                // Wait for 50 milliseconds so it looks like it is typing
                Thread.Sleep(50);
            }

            // Printing the big cool art text
            Console.WriteLine(@" .d8888b. 88888888888     d8888 Y88b   d88P       .d8888b.        d8888 8888888888 8888888888 
d88P  Y88b    888         d88888  Y88b d88P       d88P  Y88b      d88888 888        888        
Y88b.         888        d88P888   Y88o88P        Y88b.          d88P888 888        888        
 ""Y888b.      888       d88P 888    Y888P          ""Y888b.      d88P 888 8888888    8888888    
    ""Y88b.    888      d88P  888     888              ""Y88b.   d88P  888 888        888        
      ""888    888     d88P   888     888                ""888  d88P   888 888        888        
Y88b  d88P    888   d8888888888     888          Y88b  d88P d8888888888 888        888        
 ""Y8888P""      888  d88P     888     888           ""Y8888P"" d88P     888 888        8888888888 ");


            // Change the text color to blue
            Console.ForegroundColor = ConsoleColor.Blue;
            // Printing the headers
            Console.WriteLine("====================================");
            Console.WriteLine("CyberSecurty Digital Assistant");
            Console.WriteLine("====================================");
            // Asking the user for their name
            Console.WriteLine("Please enter your name");

            // Getting what the user typed
            string input = Console.ReadLine();
            // Checking if the input is empty or just spaces
            bool error = string.IsNullOrWhiteSpace(input);

            // If there is an error, keep asking until they type something
            while (error)
            {
                Console.WriteLine("Please enter a Valid input");
                Console.WriteLine("Please enter your name");
                input = Console.ReadLine();
                error = string.IsNullOrWhiteSpace(input);
            }

            // Saving the input as the name variable
            string name = input;
            Console.WriteLine("====================================");
            // Saying hello using the name they typed
            Console.WriteLine($"Hello {name} Welcome to the Cybersecurity Digital Assistant.");
            Console.WriteLine("====================================");
            // Just an empty line for spacing
            Console.WriteLine();

        }
    }
}