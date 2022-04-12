/*
 * Imports Synthesis from System.Speech Library
 * System.Speech may be added to project through:
 * Project > Manage NuGetPackages > Search > Browse > Search: System.Speech by Microsoft
 * Note: This package is only available for Windows.
 */
using System.Speech.Synthesis;

namespace Song;

/*
 * Class which the program plays from.
 */
class Program
{
    /*
     * Main 'method' which plays when program is ran.
     */
    static void Main()
    {
        // Object created using System.Speech library to talk.
        SpeechSynthesizer singer = new SpeechSynthesizer();
        singer.SetOutputToDefaultAudioDevice();
        // Voice speed range slow to fast: -10 to 10
        singer.Rate = 4;

        int rateChange = 4;
        int beerNum = 3;
        string word = "bottles";
        int voiceChanger = -1;

        // Dictionary to hold voices
        Dictionary<int, string> voices = new Dictionary<int, string>();
        voices.Add(-1, "Microsoft David Desktop");
        voices.Add(1, "Microsoft Zira Desktop");

        while (beerNum > 0)
        {
            singer.Speak($"{beerNum} {word} of beer on the wall");
            singer.Speak($"{beerNum} {word} of beer.");
            singer.Speak("Take one down");
            singer.Speak("Pass it around.");

            --beerNum;

            // Bottle change must be after increment change for next chorus to have correct wording
            if (beerNum == 1)
            {
                word = "bottle";
            }

            if (beerNum > 0)
            {
                singer.Speak($"{beerNum} {word} of beer on the wall.");
            }
            else
            {
                singer.Rate = -10;
                singer.Speak("No more bottles of beer on the wall.");
            }

            // Changes voice from male to female or vice-versa
            voiceChanger *= -1;
            singer.SelectVoice(voices[voiceChanger]);

            // Slowest voice rate is -10
            if (singer.Rate - rateChange <= -10)
            {
                singer.Rate = -10;
            }
            else
            {
                singer.Rate -= rateChange;
            }
        }// end while loop

    } // end Main method
} // end class
