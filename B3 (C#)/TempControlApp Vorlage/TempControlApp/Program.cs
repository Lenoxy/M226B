using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempControlApp {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TempControlWindow tcv1 = new TempControlWindow();
            tcv1.Show();
            TempControlWindow tcv2 = new TempControlWindow();
            tcv2.Show();
            TempView tv = new TempView();
            Application.Run(tv);
        }
    }
}
