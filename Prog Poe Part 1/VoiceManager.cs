using System.Speech.Synthesis;

class VoiceManager
{
    private static SpeechSynthesizer speech = new SpeechSynthesizer();

    public static void Speak(string text)
    {
        speech.Speak(text);
        speech.Volume = 100;
        speech.Rate = 0;
        speech.Speak(text);
    }
}
