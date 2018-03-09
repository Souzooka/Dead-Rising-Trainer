using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Ascension.Settings;
using System.Diagnostics;
using Ascension.Forms.Dialog;
using Ascension.Forms.Dialog.Extras;

namespace QuickPoke
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
