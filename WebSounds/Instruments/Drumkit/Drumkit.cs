using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSounds.Instruments;
using AxWMPLib;
using System.IO;

enum drumkitSounds { kick, Snare, hiHat }

namespace WebSounds.Instruments.Drumkit
{
    class Drumkit : Instrument
    {
        public List<AxWindowsMediaPlayer> hiHats { get; set; }
        public List<AxWindowsMediaPlayer> snares { get; set; }
        public List<AxWindowsMediaPlayer> kicks { get; set; }

        public Drumkit(int threads = 10) : base()
        {
            Sounds = new List<List<AxWindowsMediaPlayer>>();
            GenerateSounds();
        }

        public override void GenerateSounds()
        {
            kicks = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                kicks.Add(new AxWindowsMediaPlayer());
                kicks[i].CreateControl();
                kicks[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Kick - House.wav";
            }

            snares = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                snares.Add(new AxWindowsMediaPlayer());
                snares[i].CreateControl();
                snares[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Snare - House.wav";
            }

            hiHats = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                hiHats.Add(new AxWindowsMediaPlayer());
                hiHats[i].CreateControl();
                hiHats[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Hihat 2 - Echoed.wav";
            }

            Sounds.Add(kicks);
            Sounds.Add(snares);
            Sounds.Add(hiHats);
        }
    }
}
