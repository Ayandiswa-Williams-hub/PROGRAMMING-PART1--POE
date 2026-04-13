using System;

class Program
{
    static void Main(string[] args)
    {
     
        // Play greeting audio
        AudioPlayer audioPlayer = new AudioPlayer();
        audioPlayer.PlayGreeting();

        Console.WriteLine(@"
   _____      _                 ____        _   
  / ____|    | |               |  _ \      | |  
 | |    _   _| |__   ___ _ __  | |_) | ___ | |_ 
 | |   | | | | '_ \ / _ \ '__| |  _ < / _ \| __|
 | |___| |_| | |_) |  __/ |    | |_) | (_) | |_ 
  \_____\__, |_.__/ \___|_|    |____/ \___/ \__|
         __/ |                                  
        |___/                                    ");

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine("                    CYBERSECURITY AWARENESS BOT                   ");
        Console.WriteLine("-----------------------------------------------------------------------------------");


        // Get user info
        User user = new User();
        user.GetUserDetails();

        // Start chatbot
        Chatbot bot = new Chatbot(user);
        bot.Startchat();

        Console.ReadLine(); // keeps app open
    }
}