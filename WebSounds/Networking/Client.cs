using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSounds.Networking;
using System.Media;
using WMPLib;
using AxWMPLib;

namespace WebSounds.Networking
{
    public class Client
    {    
        private TcpClient client;
        public ListBox listBox;
        public List<string> ml;

        public static SoundPlayer kickHit;
        public static SoundPlayer snareHit;
        public static SoundPlayer hiHatHit;
        public static List<AxWindowsMediaPlayer> Drumkit1;

        public Client(string ipAddress, ListBox lb)
        {
            #region Get local IP
            //IPHostEntry host;
            //string localIP = "?";
            //host = Dns.GetHostEntry(Dns.GetHostName());
            //foreach (IPAddress ip in host.AddressList)
            //{
            //    if (ip.AddressFamily == AddressFamily.InterNetwork)
            //    {
            //        localIP = ip.ToString();
            //    }
            //}

            //Console.WriteLine($"IP: {localIP}");
            #endregion

            Debug.WriteLine("Connecting to IP " + ipAddress);

            client = new TcpClient((string)ipAddress, 5000);
            //client = new TcpClient(localIP, 5000);

            Thread listenerThread = new Thread(Listen);
            listenerThread.Start();
            listBox = lb;

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
        }

        public void Listen()
        {
            string message = "";

            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();

                    //var chat = Application.OpenForms["Form1"].Controls["lbChat"] as ListBox;
                    listBox.Items.Add("Anonymous: " + message);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void Send(string message)
        {
            try
            {
                NetworkStream n = client.GetStream();

                if (!(message == ""))
                {
                    Debug.WriteLine(message);
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(message);
                    w.Flush();
                }

                if (message.Equals("quit"))
                {
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void SendMusicKey(string keyChar)
        {
            try
            {
                NetworkStream n = client.GetStream();

                if (!(string.IsNullOrEmpty(keyChar)))
                {
                    Debug.WriteLine(keyChar);
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(keyChar);
                    w.Flush();
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
