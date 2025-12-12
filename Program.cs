using System;
using System.Windows.Forms;

namespace AddTwoNumbers  // <- must match Form1.cs namespace
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // <- Form1 must exist here
        }
    }
}
