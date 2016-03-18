using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSounds.Networking;
using System.Media;
using WMPLib;
using AxWMPLib;

namespace WebSounds
{
    public partial class Form1 : Form
    {
        public static Client myClient;
        public static List<string> messages;
        public static SoundPlayer kickHit;
        public static SoundPlayer snareHit;
        public static SoundPlayer hiHatHit;
        public static List<AxWindowsMediaPlayer> Drumkit1;
        public string instrument;
        Stopwatch stop;
        Thread newThread;

        public Form1()
        {
            InitializeComponent();
            messages = new List<string>();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            stop = new Stopwatch();

            kickHit = new SoundPlayer();

            kickHit.SoundLocation = @"C:\Users\Administrator\Source\Repos\WebSounds\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Kick - House.wav";
            snareHit = new SoundPlayer();
            snareHit.SoundLocation = @"C:\Users\Administrator\Source\Repos\WebSounds\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Snare - House.wav";
            hiHatHit = new SoundPlayer();
            hiHatHit.SoundLocation = @"C:\Users\Administrator\Source\Repos\WebSounds\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Hihat 2 - Echoed.wav";

            Drumkit1 = new List<AxWindowsMediaPlayer>();

            for (int i = 0; i < 10; i++)
            {
                Drumkit1.Add(new AxWindowsMediaPlayer());
                Drumkit1[i].CreateControl();
            }

            this.KeyPress +=
                new KeyPressEventHandler(Form1_KeyPress);
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            StartClient(tbIP.Text.Trim());
        }

        static void StartClient(string ipAddress)
        {
            var listBox = Application.OpenForms["Form1"].Controls["lbChat"] as ListBox;

            myClient = new Client(ipAddress, listBox);
        }

        private void bSendMessage_Click(object sender, EventArgs e)
        {

            myClient.Send(tbMessage.Text);
            //lbChat.Items.Add("Me: " + tbMessage.Text);

            Thread.Sleep(50);
            foreach (var message in messages)
            {
                lbChat.Items.Add(message);
            }
        }

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            Debug.WriteLine("Key pressed: " + e.KeyChar);

            if (instrument == "drums")
                myClient.SendMusicKey(instrument + e.KeyChar.ToString());
            else if (instrument == "piano")
                myClient.SendMusicKey(instrument + octave.ToString() + e.KeyChar.ToString());
            else
                throw new Exception("No instrument");
        }


        private void bSnare_Click(object sender, EventArgs e)
        {
            snareHit.LoadAsync();
        }

        private void cbPlayDrums_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayDrums.Checked == true)
            {
                KeyPreview = true;
                instrument = "drums";
                cbPlayPiano.Checked = false;
            }

            if (cbPlayDrums.Checked == false && cbPlayPiano.Checked == false)
                KeyPreview = false;
        }


        private void cbPlayPiano_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayPiano.Checked == true)
            {
                KeyPreview = true;
                instrument = "piano";
                cbPlayDrums.Checked = false;
            }

            if (cbPlayDrums.Checked == false && cbPlayPiano.Checked == false)
                KeyPreview = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "d");

            //stop.Start();
            //System.Threading.Timer timer = new System.Threading.Timer(ChangeColor(), null, 200, 500);//
        }

        public void SetKeyColor ()
        {
            //while (true)
            //{
            //    if (stop.ElapsedMilliseconds > 100 && stop.ElapsedMilliseconds < 2000)
            //    {
            //        btnC.BackColor = Color.Red;
            //    }
            //    else if (stop.ElapsedMilliseconds < 4000)
            //    {
            //        btnC.BackColor = Color.Turquoise;
            //        stop.Stop();
            //        break;
            //    }
            //}
        }

        private TimerCallback ChangeColor()
        {
            btnC.BackColor = Color.White;
            return null;
        }

        private void btnDb_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "r");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "f");
        }

        private void btnEb_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "t");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "g");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "h");
        }

        private void btnGb_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "u");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "j");
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "i");
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "a");
        }

        private void btnBb_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "w");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            int octave = 0;

            if (rbHighOctave.Checked)
                octave = 3;
            else if (rbMiddleOctave.Checked)
                octave = 2;
            else
                octave = 1;

            myClient.SendMusicKey(instrument + octave.ToString() + "s");
        }
    }
}
