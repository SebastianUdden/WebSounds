using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSounds.Instruments;
using AxWMPLib;
using System.IO;

enum drumkitSounds { kick, Snare, hiHat, hiHat2, tom, tom2, tom3 }

namespace WebSounds.Instruments.Drumkit
{
    class Drumkit : Instrument
    {
        public List<AxWindowsMediaPlayer> kicks { get; set; }
        public List<AxWindowsMediaPlayer> snares { get; set; }
        public List<AxWindowsMediaPlayer> hiHats { get; set; }
        public List<AxWindowsMediaPlayer> hiHats2 { get; set; }
        public List<AxWindowsMediaPlayer> toms { get; set; }
        public List<AxWindowsMediaPlayer> toms2 { get; set; }
        public List<AxWindowsMediaPlayer> toms3 { get; set; }

        public Drumkit() : base()
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
                hiHats[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Hihat - open.wav";
            }

            hiHats2 = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                hiHats2.Add(new AxWindowsMediaPlayer());
                hiHats2[i].CreateControl();
                hiHats2[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Hihat 2 - Echoed.wav";
            }

            toms = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                toms.Add(new AxWindowsMediaPlayer());
                toms[i].CreateControl();
                toms[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Tom 1 - Tec-studios Dr Tom - g.wav";
            
            }

            toms2 = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                toms2.Add(new AxWindowsMediaPlayer());
                toms2[i].CreateControl();
                toms2[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Tom 2 - Zgump.wav";
            }

            toms3 = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < Threads; i++)
            {
                toms3.Add(new AxWindowsMediaPlayer());
                toms3[i].CreateControl();
                toms3[i].URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Drums\Drumkit 1\Tom 3 - Phat 909 room-tom.wav";
            }

            Sounds.Add(kicks);
            Sounds.Add(snares);
            Sounds.Add(hiHats);
            Sounds.Add(hiHats2);
            Sounds.Add(toms);
            Sounds.Add(toms2);
            Sounds.Add(toms3);
        }
    }
}
