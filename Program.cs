using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace BlackMesaWorkshopManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Form NextMainWindow { get; set; }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            {
                if (File.Exists("./bms.exe"))
                {
                    NextMainWindow = new Form1();

                    while (NextMainWindow != null)
                    {
                        var nextMainWindow = NextMainWindow;
                        NextMainWindow = null;
                        Console.WriteLine("Black Mesa detected, continuing");
                        Application.Run(new Form1());
                    }
                }
                else
                {
                    Console.WriteLine("Black Mesa not there, showing error");
                    Application.Run(new Form2());
                }
            }
        }
    }
}
