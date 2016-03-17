using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSounds.Networking;
using System.Threading;
using System.Diagnostics;
using System.IO;
using WebSounds.Instruments.Piano;

namespace WebSounds
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var x = new Piano();

            Application.Run(new Form1());

        }
    }
}
