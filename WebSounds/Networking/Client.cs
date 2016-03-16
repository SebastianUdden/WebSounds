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

        public void Start(Object ipAddress)
        {
            #region Get local IP
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }

            Console.WriteLine($"IP: {localIP}");
            #endregion

            Debug.WriteLine("Connecting to IP " + (string)ipAddress);

            client = new TcpClient((string)ipAddress, 5000);
            //client = new TcpClient(localIP, 5000);

            Thread listenerThread = new Thread(Send);
            listenerThread.Start();

            Thread senderThread = new Thread(Listen);
            senderThread.Start();

            senderThread.Join();
            listenerThread.Join();
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
                    
                    Console.WriteLine("Other: " + message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Send()
        {
            string message = "";
            TextBox textBox = Application.OpenForms["Form1"].Controls["tbMessage"] as TextBox;

            try
            {
                NetworkStream n = client.GetStream();

                while (!message.Equals("quit"))
                {
                    Thread.Sleep(1000);
                    
                    message = textBox.Text;

                    if (!(message == ""))
                    {
                        Debug.WriteLine(message);
                        BinaryWriter w = new BinaryWriter(n);
                        w.Write(message);
                        w.Flush();
                    }
                }

                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        

    }
}
