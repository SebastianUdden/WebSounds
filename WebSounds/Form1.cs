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
        

        public Form1()
        {
            InitializeComponent();
            messages = new List<string>();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            

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

        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine("Key pressed: " + e.KeyChar);

            myClient.SendMusicKey(e.KeyChar.ToString());

            switch (e.KeyChar)
            {
                case 'a':
                    Drumkit1[0].URL = kickHit.SoundLocation;
                    Drumkit1[0].Ctlcontrols.play();
                    break;
                case 'w':
                    Drumkit1[1].URL = snareHit.SoundLocation;
                    Drumkit1[1].Ctlcontrols.play();
                    break;
                case 's':
                    Drumkit1[2].URL = hiHatHit.SoundLocation;
                    Drumkit1[2].Ctlcontrols.play();
                    break;
                case 'd':
                    break;
                case (char)55:
                    e.Handled = true;
                    break;
            }
        }


        private void bSnare_Click(object sender, EventArgs e)
        {
            snareHit.LoadAsync();
        }

        private void cbPlayMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayMusic.Checked == true)
                KeyPreview = true;
            else
                KeyPreview = false;
        }
    }
}
