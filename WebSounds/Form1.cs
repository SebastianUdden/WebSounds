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

        public Form1()
        {
            InitializeComponent();
            messages = new List<string>();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            stop = new Stopwatch();

            btnC.BackColor = Color.White;
            btnDb.BackColor = Color.Black;
            btnD.BackColor = Color.White;
            btnEb.BackColor = Color.Black;
            btnE.BackColor = Color.White;
            btnF.BackColor = Color.White;
            btnGb.BackColor = Color.Black;
            btnG.BackColor = Color.White;
            btnAb.BackColor = Color.Black;
            btnA.BackColor = Color.White;
            btnBb.BackColor = Color.Black;
            btnB.BackColor = Color.White;

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
                rbLowOctave.Checked = false;
                rbMiddleOctave.Checked = false;
                rbHighOctave.Checked = false;

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
                rbMiddleOctave.Checked = true;
                KeyPreview = true;
                instrument = "piano";
                cbPlayDrums.Checked = false;
            }
            else
            {
                rbLowOctave.Checked = false;
                rbMiddleOctave.Checked = false;
                rbHighOctave.Checked = false;
            }

            if (cbPlayDrums.Checked == false && cbPlayPiano.Checked == false)
                KeyPreview = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "d");
            btnColorChange(btnC);
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
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "r");
            btnColorChange(btnDb);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "f");
            btnColorChange(btnD);
        }

        private void btnEb_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "t");
            btnColorChange(btnEb);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "g");
            btnColorChange(btnE);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "h");
            btnColorChange(btnF);
        }

        private void btnGb_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "u");
            btnColorChange(btnGb);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "j");
            btnColorChange(btnG);
        }

        private void btnAb_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "i");
            btnColorChange(btnAb);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "a");
            btnColorChange(btnA);
        }

        private void btnBb_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "w");
            btnColorChange(btnBb);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            myClient.SendMusicKey(instrument + OctaveCheck().ToString() + "s");
            btnColorChange(btnB);
        }

        private void btnColorChange(Button btn)
        {
            timer1.Interval = 300;
            timer1.Start();
            btn.BackColor = Color.Gray;
        }

        private int OctaveCheck()
        {
            if (rbHighOctave.Checked)
                return 3;
            else if (rbLowOctave.Checked)
                return 1;
            else
                return 2;
        }

        private void tbMessage_MouseClick(object sender, MouseEventArgs e)
        {
            KeyPreview = false;
            cbPlayPiano.Checked = false;
            cbPlayDrums.Checked = false;
            rbLowOctave.Checked = false;
            rbMiddleOctave.Checked = false;
            rbHighOctave.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnC.BackColor = Color.White;
            btnDb.BackColor = Color.Black;
            btnD.BackColor = Color.White;
            btnEb.BackColor = Color.Black;
            btnE.BackColor = Color.White;
            btnF.BackColor = Color.White;
            btnGb.BackColor = Color.Black;
            btnG.BackColor = Color.White;
            btnAb.BackColor = Color.Black;
            btnA.BackColor = Color.White;
            btnBb.BackColor = Color.Black;
            btnB.BackColor = Color.White;
        }
    }
}
