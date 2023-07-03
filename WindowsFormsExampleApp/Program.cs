using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Controls.Primitives;
using WindowsFormApp;

namespace WindowsFormApp
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
