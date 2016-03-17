using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSounds;



namespace WebSounds.Instruments
{
    abstract class Instrument
    {
        public int Threads { get; set; }
        public List<List<AxWindowsMediaPlayer>> Sounds { get; set; }

        public Instrument(int threads = 10)
        {
            Threads = threads;
        }

        public abstract void GenerateSounds();

    }
}
