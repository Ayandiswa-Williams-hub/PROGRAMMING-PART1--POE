using System;

public class User
{
    public string Name { get; private set; } = string.Empty;

    public void GetUserDetails()
    {
        Console.WriteLine("Enter your name: ");
        Name = Console.ReadLine() ?? string.Empty;

        while (string.IsNullOrEmpty(Name))
        {
            Console.WriteLine("Name cannot be empty. Enter your name: ");
            Name = Console.ReadLine() ?? string.Empty;
        }
    }
}
