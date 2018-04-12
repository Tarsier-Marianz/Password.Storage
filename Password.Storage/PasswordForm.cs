using Password.Storage.Constant;
using Password.Storage.Controllers;
using Password.Storage.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password.Storage {
    public partial class PasswordForm : Form {
        private Credentials _pwds;
        public PasswordForm() {
            InitializeComponent();
        }

        private void InitializePasswords() {
            _pwds = new Credentials(Vars.PASSWORD_DB);
            listViewPasswords.Items.Clear();
            _pwds.Initialize(listViewPasswords);
        }
        private void Action(string tag) {
            switch(tag) {
                case "ADD":
                    using(NewPasswordForm npf = new NewPasswordForm()) {
                        if(npf.ShowDialog().Equals(DialogResult.OK)) {
                            _pwds.Add(npf.Credential);
                            InitializePasswords();
                        }
                    }
                    break;
                case "REMOVE":
                    break;
                case "EDIT":
                    break;
                case "COPY":
                    break;
                case "RELOAD":
                    InitializePasswords();
                    break;
                case "SETTINGS":
                    break;
                case "HELP":
                    break;
                case "EXIT":
                    break;
                case "ABOUT":
                    break;
                default:
                    break;
            }
        }

        private void Menus_Click(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            if(menu != null) {
                if(menu.Tag != null) {
                    Action(menu.Tag.ToString());
                }
            }
        }

        private void Buttons_Click(object sender, EventArgs e) {
            ToolStripButton btn = sender as ToolStripButton;
            if(btn != null) {
                if(btn.Tag != null) {
                    Action(btn.Tag.ToString());
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e) {
            try {

            }catch {

            } finally {

            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {

        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

        }

        private void PasswordForm_Load(object sender, EventArgs e) {
            InitializePasswords();
        }

        private void tmr_Tick(object sender, EventArgs e) {
            
        }
    }
}
