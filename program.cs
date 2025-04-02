using System;
using System.Windows.Forms;

namespace labexamipt
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StudentPage()); // Ensure this is the correct Form name
        }
    }
}
