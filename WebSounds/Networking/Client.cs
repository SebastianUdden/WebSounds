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

namespace WebSounds.Networking
{
    public class Client
    {
        private TcpClient client;
        //public ListBox lb;
        public List<string> ml;

        public Client(string ipAddress, List<string> messageList)
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
            ml = messageList;
            
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
                    ml.Add(message);
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


    }
}
