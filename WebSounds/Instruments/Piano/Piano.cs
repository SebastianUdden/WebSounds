using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum pianoNotes { A, Bb, B, C, Db, D, Eb, E, F, Gb, G, Ab}

namespace WebSounds.Instruments.Piano
{
    class Piano : Instrument
    {
        public List<AxWindowsMediaPlayer>[] Notes { get; set; }
        public int notePerOctave { get; set; }
        public int octaves { get; set; }

        public Dictionary<int, string> pianoNotes; 

        public Piano() : base()
        {
            Sounds = new List<List<AxWindowsMediaPlayer>>();

            pianoNotes = new Dictionary<int, string>()
            {
                { 0, "A" }, { 1, "Bb" }, {2, "B" }, {3, "C" }, {4, "Db" }, {5, "D" }, {6, "Eb" }, {7, "E" }, {8, "F" }, {9, "Gb" }, {10, "G" }, {11, "Ab" }
            };

            octaves = 4;
            notePerOctave = 12;

            GenerateSounds();
        }

        public override void GenerateSounds()
        {
            Notes = new List<AxWindowsMediaPlayer>[4]
            {
                new List<AxWindowsMediaPlayer>(),
                new List<AxWindowsMediaPlayer>(),
                new List<AxWindowsMediaPlayer>(),
                new List<AxWindowsMediaPlayer>()
            };

            Debug.WriteLine("generating piano sounds");

            for (int i = 0; i< octaves; i++)
            {
                for(int j = 0; j< notePerOctave; j++)
                {
                    Notes[i].Add(new AxWindowsMediaPlayer());
                    Notes[i].Last().CreateControl();
                    Notes[i].Last().URL = Directory.GetCurrentDirectory() + @"\Sounds\Instruments\Piano\" + pianoNotes[j] + i.ToString() + ".wav";
                }
            }
        }
    }
}
