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
        public Form1()
        {
            InitializeComponent();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            StartClient(tbIP.Text.Trim());
        }

        static void StartClient(string ipAddress)
        {
            var myClient = new Client();

            Thread clientThread = new Thread(myClient.Start);
            clientThread.Start(ipAddress);
            //clientThread.Join();
        }

        private void bSendMessage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
