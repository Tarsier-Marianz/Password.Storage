using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tarsier.Regedit;

namespace Password.Storage.Forms {
    public partial class OptionForm : Form {
        public OptionForm() {
            InitializeComponent();
            InitOptions();
        }

        private void InitOptions() {
            chkEncryptContent.Checked = RegConfig.Get<bool>("Encrypt");
            chkHidePassword.Checked = RegConfig.Get<bool>("HidePassword");
            chkShowDetails.Checked = RegConfig.Get<bool>("ShowPanel");
        }
        private void AppyOptions() {
            RegConfig.Set<bool>("Encrypt", chkEncryptContent.Checked);
            RegConfig.Set<bool>("HidePassword", chkHidePassword.Checked);
            RegConfig.Set<bool>("ShowPanel", chkShowDetails.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            AppyOptions();
            Close();
        }
    }
}