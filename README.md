# PROGRAMMING-PART1--POE

Cybersecurity Awareness Bot (C# Console Application)

 Overview

The **Cybersecurity Awareness Bot** is a C# console-based chatbot designed to educate users about basic cybersecurity concepts. The application interacts with users, plays a voice greeting, displays ASCII art, and responds to common cybersecurity-related question
Features

Plays a voice greeting on startup
Displays ASCII art logo
 Accepts and uses user input (name)
Responds to cybersecurity questions
Handles invalid or empty input
Uses colored console output for better UI
Well-structured using multiple classes
 Technologies Used

* C#
* .NET (Console Application)
* Visual Studio

Project Structure
```
CyberAwarenessBot/
│
├── Program.cs          # Main entry point
├── Chatbot.cs          # Chatbot logic and responses
├── User.cs             # User input handling
├── AudioPlayer.cs      # Plays greeting audio
├── greeting.wav        # Voice greeting file
│
└── .github/
    └── workflows/
        └── dotnet.yml  # CI configuration
```

 How to Run the Project

1. Open the project in Visual Studio
2. Make sure the file **greeting.wav** is included
3. Set file property:
Copy to Output Directory → *Copy if newer
     
4. Build and run the project

How to Use
 Enter your name when prompted
 Ask questions like:
  - “How are you”
  - “What is phishing”
 -“Tell me about passwords”
 - Type **exit** to close the chatbot



 Notes

The audio file must be in the output directory:
  bin/Debug/net8.0/
  ```
* Only `.wav` files are supported for audio playback

Future Improvements
* Add more cybersecurity topics
* Implement GUI (Windows Forms or WPF)
* Add database support
* Improve chatbot intelligence

 Author
* Your Name Here

## 📎 GitHub Repository

()

Presentation
This project includes a demonstration video explaining:

* Code structure
* Program functionality
* Chatbot logic
  
 Conclusion
This project demonstrates the use of:

* Object-Oriented Programming in C#
* User interaction handling
* File handling (audio)
* Console UI design
* Basic cybersecurity awareness concepts

---
