using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSounds.Networking;

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
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            StartClient(tbIP.Text.Trim());
        }

        static void StartClient(string ipAddress)
        {
            //var listBox = Application.OpenForms["Form1"].Controls["lbChat"] as ListBox;
            myClient = new Client(ipAddress, messages);
        }

        private void bSendMessage_Click(object sender, EventArgs e)
        {
            myClient.Send(tbMessage.Text);

            Thread.Sleep(50);
            foreach (var message in messages)
            {
                lbChat.Items.Add(message);
            }
        }

        //private void listGrow ()
        //{

        //}
    }
}
