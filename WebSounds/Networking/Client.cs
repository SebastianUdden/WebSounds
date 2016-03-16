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
        public static List<AxWindowsMediaPlayer> Drumkit1;
        public static SoundPlayer kickHit;
        public static SoundPlayer snareHit;
        public static SoundPlayer hiHatHit;

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

            kickHit.SoundLocation = @"C:\Users\Administrator\Source\Repos\WebSounds3\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Kick - House.wav";
            snareHit = new SoundPlayer();
            snareHit.SoundLocation = @"C:\Users\Administrator\Source\Repos\WebSounds3\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Snare - House.wav";
            hiHatHit = new SoundPlayer();
            hiHatHit.SoundLocation = @"C:\Users\Administrator\Source\Repos\WebSounds3\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Hihat 2 - Echoed.wav";

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
                    

                    if (message.Substring(0, 5) == "music")
                    {
                        Debug.WriteLine("hello " + message.Substring(5, 1));

                        switch (message.Substring(5, 1))
                        {
                            case "a":
                                Drumkit1[0].URL = kickHit.SoundLocation;
                                Drumkit1[0].Ctlcontrols.play();
                                break;
                            case "w":
                                Drumkit1[1].URL = snareHit.SoundLocation;
                                Drumkit1[1].Ctlcontrols.play();
                                break;
                            case "s":
                                Drumkit1[2].URL = hiHatHit.SoundLocation;
                                Drumkit1[2].Ctlcontrols.play();
                                break;
                            case "d":
                                break;
                        }

                    }
                    else
                        listBox.Items.Add("Anonymous: " + message);

                    //var chat = Application.OpenForms["Form1"].Controls["lbChat"] as ListBox;
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
