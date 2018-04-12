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
        public PasswordForm() {
            InitializeComponent();
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

        private void Action(string tag) {
            switch(tag) {
                case "ADD":
                    break;
                case "REMOVE":
                    break;
                case "EDIT":
                    break;
                case "COPY":
                    break;
                case "RELOAD":
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
    }
}
