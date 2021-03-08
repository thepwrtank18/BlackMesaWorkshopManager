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

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var userDocFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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
                else if (File.Exists(userDocFolder + @"/bmm_globalsettings.txt"))
                {
                    string bmsDir = File.ReadAllText(userDocFolder + @"/bmm_globalsettings.txt");
                    Directory.SetCurrentDirectory(bmsDir);
                    if (!File.Exists("./bms.exe"))
                    {
                        Console.WriteLine("Black Mesa not there, showing error");
                        Application.Run(new Form2());
                    }
                    else
                    {
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
