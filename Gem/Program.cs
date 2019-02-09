using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;
using System.IO;

namespace Gem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string ss = "";
            try
            {
               // StreamReader sr = new StreamReader("\\data.txt");
                ss = "Data Source=.;Initial Catalog=GamDatabase;Integrated Security=True";//sr.ReadLine().ToString();
              // ss = " Data Source=.;Initial Catalog=GamDatabase;Integrated Security=False;User ID=sa;Password=amir1360;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
               
                // ss = sr.ReadLine().ToString();
              //  MessageBox.Show(ss);
               // sr.Close();
                
            }
            catch
            {
                MessageBox.Show("اتصال پایگاه داده وصل نیست");

            }
            Classmain.x = ss;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Basis.login() );
        }
    }
}
