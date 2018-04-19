using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tarsier.Regedit;

namespace Password.Storage {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            bool xpLook = RegConfig.Get<bool>("XPLook");
            if(!xpLook) {
                Application.EnableVisualStyles();
            }
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PasswordForm());
        }
    }
}
