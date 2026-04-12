using System;
using System.Media;

class SoundManager
{
    public static void PlayWelcomeSound()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("welcome.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("Sound sucessful.");
        }
    }

    public static void Beep()
    {
        Console.Beep(700, 150);
    }
}
