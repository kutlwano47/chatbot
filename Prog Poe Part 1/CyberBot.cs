using System;

class CyberBot
{
    private string userName;

    public void Start()
    {
        SoundManager.PlayWelcomeSound();
       

        ShowHeader();
        AskName();
        ChatMenu();
    }

    private void ShowHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
==========================================================

   ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║   
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║   
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║   
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═╝   

                   FRIENDLY CYBER BOT  

==========================================================

                      ⛓️  SYSTEM BREACH MODE  ⛓️

                           .-""""""-.
                          /  X    X  \
                         |     <>     |
                         |   .----.   |
                         |  /  ██  \  |
                         | |  ████  | |
                         |  \  ██  /  |
                          \   ----   /
                           '-.___.-'

                    ☠️ CYBERSECURITY ASSISTANT ☠️

============================================================
");

        Console.ResetColor();
    }

    private void AskName()
    {
        Console.WriteLine("What's your name?");
        userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.WriteLine("Please enter a valid name.");
            userName = Console.ReadLine();
        }

        Console.WriteLine($"\nWelcome {userName}, how can I assist you today?\n");
    }

    private void ChatMenu()
    {
        while (true)
        {
            Console.WriteLine(@"
Choose an option:

1. Phishing
2. Malware
3. Password Attacks
4. Social Engineering
5. Public Wi-Fi Risks
6. Exit
");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            SoundManager.Beep();

            switch (choice)
            {
                case "1":
                    Speak("Fake emails/messages that trick you into revealing sensitive info.");
                    break;

                case "2":
                    Speak("Malicious software that steals or damages data.");
                    break;

                case "3":
                    Speak("Hackers try to guess or steal your passwords.");
                    break;

                case "4":
                    Speak("Manipulating people into giving away confidential information.");
                    break;

                case "5":
                    Speak("Unsecured networks can expose your data to attackers.");
                    break;

                case "6":
                    Speak("Goodbye. Stay safe online.");
                    return;

                default:
                    Speak("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void Speak(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Bot: " + message);
        Console.ResetColor();

        
    }
}