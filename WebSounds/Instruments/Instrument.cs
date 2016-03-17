using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments.WebSounds
{
    class Instrument
    {
        public int Threads { get; set; }

        public Instrument(int threads = 10)
        {
            Threads = threads;
        }
    }
}
