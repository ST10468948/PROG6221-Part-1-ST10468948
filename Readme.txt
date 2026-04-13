Cybersecurity Digital Assistant
Welcome to the Cybersecurity Digital Assistant! This is a simple C# console application designed to help users learn about online safety through an interactive chatbot interface.
🚀 Features
•	Audio Feedback: Plays a background track (sage.wav) when the program starts.
•	Animated Welcome: A "typing" animation for the welcome message and cool ASCII art.
•	User Validation: Ensures the user enters a valid name and keyword (no empty inputs!).
•	Security Tips: Provides helpful advice on passwords, phishing, MFA, antivirus, and more.
📁 Project Structure
The project is organized into four main files to keep the code clean and easy to read:
1.	Program.cs: The "Brain." This is the entry point where the application starts. it coordinates the audio, the welcome screen, and the chat loop.
2.	User.cs: Handles the introduction. It contains the logic for the typing animation, the ASCII art, and capturing the user's name.
3.	Chatbot.cs: The core interaction. It contains a switch statement that matches user keywords (like "password" or "phishing") to specific security tips.
4.	AudioPlayer.cs: A helper class that uses the System.Media library to play the background audio file.
🛠️ Prerequisites
•	Visual Studio 2022 (or the .NET SDK installed).
•	Audio File: You must have an audio file named sage.wav located in your project's output folder (usually bin/Debug/net8.0/) for the music to work.
📖 How to Use
1.	Run the App: Press F5 in Visual Studio.
2.	Enter Name: Type your name when prompted.
3.	Ask for Tips: Type keywords like:
o	password
o	phishing
o	antivirus
o	backup
o	encryption
4.	Exit: To close the program, press the 'E' key when asked if you want to continue.

