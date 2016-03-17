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


        List<AxWindowsMediaPlayer> hiHats;
        List<AxWindowsMediaPlayer> snares;
        List<AxWindowsMediaPlayer> kicks;



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

            hiHats = new List<AxWindowsMediaPlayer>();
            for(int i = 0; i < 20; i++)
            {
                hiHats.Add(new AxWindowsMediaPlayer());
                hiHats[i].CreateControl();
                hiHats[i].URL = @"C:\Users\Administrator\Source\Repos\WebSounds3\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Hihat 2 - Echoed.wav";
            }

            snares = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < 20; i++)
            {
                snares.Add(new AxWindowsMediaPlayer());
                snares[i].CreateControl();
                snares[i].URL = @"C:\Users\Administrator\Source\Repos\WebSounds3\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Snare - House.wav";
            }

            kicks = new List<AxWindowsMediaPlayer>();
            for (int i = 0; i < 20; i++)
            {
                kicks.Add(new AxWindowsMediaPlayer());
                kicks[i].CreateControl();
                kicks[i].URL = @"C:\Users\Administrator\Source\Repos\WebSounds3\WebSounds\Sounds\Instruments\Drums\Drumkit 1\Kick - House.wav";
            }

        }

        public void Listen()
        {
            string message = "";
            int counter = 0;

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
                                hiHats[counter].Ctlcontrols.play();
                                break;
                            case "w":
                                snares[counter].Ctlcontrols.play();
                                break;
                            case "s":
                                kicks[counter].Ctlcontrols.play();
                                break;
                            case "d":
                                break;
                        }

                        counter++;

                        if (counter > 19)
                            counter = 0; 

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
