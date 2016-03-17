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
using WebSounds.Instruments;
using WebSounds.Instruments.Drumkit;
using WebSounds.Instruments.Piano;

enum instrumentNumbers { drumkit, piano }


namespace WebSounds.Networking
{

    public class Client
    {
        private TcpClient client;
        public ListBox listBox;
        public List<string> ml;

        List<Instrument> instruments;
        List<Piano> piano;

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

            instruments = new List<Instrument>();
            instruments.Add(new Drumkit());

            piano = new List<Piano>();
            for(int i = 0; i< instruments[0].Threads; i++)
                piano.Add(new Piano());
        }

        public void Listen()
        {
            string message = "";
            int counter = 0;
            int octave = 0;
            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();

                    if (message.Substring(0, 5) == "music")
                    {
                        if (int.TryParse(message.Substring(5, 1), out octave) == false)
                            throw new Exception("Could not parse");

                        switch (message.Substring(6, 1))
                        {
                            case "a":
                                piano[counter].Notes[(int)pianoNotes.A][octave].Ctlcontrols.play();
                                break;
                            case "w":
                                piano[counter].Notes[(int)pianoNotes.Bb][octave].Ctlcontrols.play();
                                break;
                            case "s":
                                piano[counter].Notes[(int)pianoNotes.B][octave].Ctlcontrols.play();
                                break;
                            case "e":
                                piano[counter].Notes[(int)pianoNotes.C][octave].Ctlcontrols.play();
                                break;
                            case "d":
                                piano[counter].Notes[(int)pianoNotes.Db][octave].Ctlcontrols.play();
                                break;
                            case "f":
                                piano[counter].Notes[(int)pianoNotes.D][octave].Ctlcontrols.play();
                                break;
                            case "t":
                                piano[counter].Notes[(int)pianoNotes.Eb][octave].Ctlcontrols.play();
                                break;
                            case "g":
                                piano[counter].Notes[(int)pianoNotes.E][octave].Ctlcontrols.play();
                                break;
                            case "y":
                                piano[counter].Notes[(int)pianoNotes.F][octave].Ctlcontrols.play();
                                break;
                            case "h":
                                piano[counter].Notes[(int)pianoNotes.Gb][octave].Ctlcontrols.play();
                                break;
                            case "u":
                                piano[counter].Notes[(int)pianoNotes.G][octave].Ctlcontrols.play();
                                break;
                            case "j":
                                piano[counter].Notes[(int)pianoNotes.Ab][octave].Ctlcontrols.play();
                                break;

                                /*
                                case "a":
                                    instruments[(int)instrumentNumbers.drumkit].Sounds[(int)drumkitSounds.kick][counter].Ctlcontrols.play();
                                    break;
                                case "w":
                                    instruments[(int)instrumentNumbers.drumkit].Sounds[(int)drumkitSounds.Snare][counter].Ctlcontrols.play();
                                    break;
                                case "s":
                                    instruments[(int)instrumentNumbers.drumkit].Sounds[(int)drumkitSounds.hiHat][counter].Ctlcontrols.play();
                                    break;
                                case "d":
                                    piano[counter].Notes[(int)pianoNotes.A][octave].Ctlcontrols.play();
                                    break;
                                case "t":
                                    instruments[(int)instrumentNumbers.drumkit].Sounds[(int)drumkitSounds.kick][counter].Ctlcontrols.play();
                                    break;
                                case "y":
                                    instruments[(int)instrumentNumbers.drumkit].Sounds[(int)drumkitSounds.Snare][counter].Ctlcontrols.play();
                                    break;
                                case "u":
                                    instruments[(int)instrumentNumbers.drumkit].Sounds[(int)drumkitSounds.hiHat][counter].Ctlcontrols.play();
                                    break;
                                case "i":
                                    break;*/
                        }

                        counter++;

                        if (counter >= instruments[0].Threads)
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
