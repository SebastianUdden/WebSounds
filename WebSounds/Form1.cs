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

namespace WebSounds
{
    public partial class Form1 : Form
    {
        public static Client myClient;
        public static List<string> messages;
        public static SoundPlayer kickHit;
        public static SoundPlayer snareHit;
        public static SoundPlayer hiHatHit;
        public Form1()
        {
            InitializeComponent();
            messages = new List<string>();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            kickHit = new SoundPlayer();
            kickHit.SoundLocation = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\WebSounds\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Kick - House.wav";
            snareHit = new SoundPlayer();
            snareHit.SoundLocation = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\WebSounds\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Snare - House.wav";
            hiHatHit = new SoundPlayer();
            hiHatHit.SoundLocation = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\WebSounds\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Hihat 2 - Echoed.wav";

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
            lbChat.Items.Add("Me: " + tbMessage.Text);

            Thread.Sleep(50);
            foreach (var message in messages)
            {
                lbChat.Items.Add(message);
            }
        }

        private void bKick_Click(object sender, EventArgs e)
        {
            kickHit.LoadAsync();
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("Key pressed: " + e.KeyChar);

            switch (e.KeyChar)
            {
                case 'a':
                    MessageBox.Show("You pressed key A");
                    break;
                case 'w':
                    MessageBox.Show("You pressed key W");
                    break;
                case 's':
                    MessageBox.Show("You pressed key W");
                    break;
                case 'd':
                    MessageBox.Show("You pressed key W");
                    break;
                case (char)55:
                    e.Handled = true;
                    break;
            }

            ////Numbers etc
            //if (e.KeyChar >= 48 && e.KeyChar <= 57)
            //{
            //    MessageBox.Show("Form.KeyPress: '" +
            //        e.KeyChar.ToString() + "' pressed.");

        private void bSnare_Click(object sender, EventArgs e)
        {
            snareHit.LoadAsync();
        }
            //    switch (e.KeyChar)
            //    {
            //        case (char)49:
            //        case (char)52:
            //        case (char)55:
            //            e.Handled = true;
            //            break;
            //    }
            //}

        }
    }
}
