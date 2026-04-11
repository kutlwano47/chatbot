using System;
using System.Media;

class SoundManager
{
    public static void PlayWelcomeSound()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("welcome.W" +
                "av");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine("Sound error.");
        }
    }

    public static void Beep()
    {
        Console.Beep(700, 150);
    }
}
