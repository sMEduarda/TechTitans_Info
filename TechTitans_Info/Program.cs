using System;
using System.Windows.Forms;
using TechTitans_Info.Views;

namespace TechTitans_Info
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicial());
        }
    }
}