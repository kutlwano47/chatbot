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
        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.WriteLine(@"
==============================================================================

   ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║   
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║   
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║   
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    ╚═════╝  ╚═════╝    ╚═  

                    
=============================================================================
                        SYSTEM BREACH MODE  
                   CYBERSECURITY ASSISTANT BOT
=============================================================================
");

        Console.ResetColor();
    }

    private void AskName()
    {
        Console.WriteLine("Please state your your name?");
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
6. Identity Theft
7. Online Scams
8. Fake Websites
9. Mobile Security
10. Data Breaches
11. Exit
");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            SoundManager.Beep();

            switch (choice)
            {
                case "1":
                    Speak("Phishing is a cyber attack where attackers send fake emails, messages, or websites that appear to be from trusted sources (like banks or companies). The goal is to trick users into revealing sensitive information such as passwords, credit card details, or login credentials.");
                    break;

                case "2":
                    Speak("Malware refers to malicious software designed to harm, disrupt, or gain unauthorized access to a computer system. Examples include viruses, worms, and ransomware. Malware can steal data, damage files, or spy on users.");
                    break;

                case "3":
                    Speak("Password attacks occur when hackers try to gain access to accounts by guessing or stealing passwords. This can be done using methods like brute force (trying many combinations) or using stolen password databases.");
                    break;

                case "4":
                    Speak("Social engineering is when attackers manipulate people into giving away confidential information. Instead of hacking systems, they “hack humans” by pretending to be someone trustworthy, such as a company employee or IT support.");
                    break;

                case "5":
                    Speak("Public Wi-Fi networks (like those in cafes or airports) are often unsecured. Hackers can intercept data sent over these networks, making it easy to steal passwords, emails, or banking information.");
                    break;

                case "6":
                    Speak("Identity theft happens when someone steals your personal information (such as your ID number or bank details) and uses it to commit fraud. This could include opening accounts, making purchases, or pretending to be you.");
                    break;

                case "7":
                    Speak("Online scams are fraudulent schemes carried out over the internet to trick people into sending money or sharing personal information. Examples include fake job offers, lottery scams, or phishing links.");
                    break;

                case "8":
                    Speak("Fake websites are designed to look like legitimate ones but are created to steal user information. They often mimic banking or shopping sites and trick users into entering login details or payment information.");
                    break;

                case "9":
                    Speak("Mobile security involves protecting smartphones and tablets from threats. This includes downloading apps only from trusted sources, keeping software updated, and avoiding suspicious links or downloads.");
                    break;

                case "10":
                    Speak("A data breach occurs when unauthorized individuals gain access to confidential data stored by organizations. This can expose personal information such as emails, passwords, and financial details.");
                    break;

                case "11":
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
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Bot: " + message);
        Console.ResetColor();

        
    }
}