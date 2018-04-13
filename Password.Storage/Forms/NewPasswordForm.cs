using Password.Storage.Controllers;
using Password.Storage.Models;
using Password.Storage.Properties;
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
        private Credentials _cred;
        public NewPasswordForm(Credentials credential,string id) {
            InitializeComponent();
            InitializeCredential(credential, id);
        }

        private void InitializeCredential(Credentials credential, string id) {
            if(string.IsNullOrEmpty(id)) {
                Text = "Add Credential";
                btnSave.Text = "Save";
                btnSave.Image = Resources.save;
            } else {
                Text = "Edit Credential";
                btnSave.Text = "Update";
                btnSave.Image = Resources.update;
                _cred = credential;
                Credential c = _cred.GetCredential(id);
                txtUsername.Text = c.Username;
                txtPassword.Text = c.PassKey;
                txtDescription.Text = c.Description;
            }
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
