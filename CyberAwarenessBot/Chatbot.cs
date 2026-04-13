using System;
using System.Threading;

public class Chatbot
{
    private readonly User user;

    public Chatbot(User user)
    {
        this.user = user;
    }

    public void Startchat()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Hello {user.Name}! Welcome to the Cybersecurity Bot.");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nYou: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Bot: Please enter something.");
                continue;
            }

            if (input == "exit")
            {
                Console.WriteLine("Bot: Goodbye! Stay safe online");
                break;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Bot: ");

        if (input == "how are you")
        {
            Console.WriteLine("I'm just a bot, but I'm here to help you.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Please use a strong password with symbols and numbers.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is a deceptive cyberattack where attackers impersonate trusted entities via email, SMS, or websites to steal sensitive data like passwords, credit card numbers, or login credentials.");
        }
        else
        {
            Console.WriteLine("I didn't quite understand that. TRY ASKING ABOUT CYBERSECURITY");
        }

        Console.ResetColor();
    }

    private void TypeText(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }
}
