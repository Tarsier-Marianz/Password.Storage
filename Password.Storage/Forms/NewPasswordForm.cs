using Password.Storage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password.Storage.Forms {
    public partial class NewPasswordForm : Form {
        public NewPasswordForm() {
            InitializeComponent();
        }

        public Credential Credential {
            get {
                return new Credential() {
                    Username = txtUsername.Text.Trim(),
                    PassKey = txtPassword.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };
            }
        }
         
        private void tmr_Tick(object sender, EventArgs e) {
            btnSave.Enabled = txtDescription.Text.Trim().Length > 5 && txtPassword.Text.Trim().Length > 2 && txtUsername.Text.Trim().Length > 1;
        }

        private void Field_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode.Equals(Keys.Enter)) {
                if(btnSave.Enabled) {
                    btnSave.PerformClick();
                }else {
                    SendKeys.Send("{TAB}");
                }
            }
        }
    }
}
