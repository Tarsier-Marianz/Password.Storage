using Password.Storage.Constant;
using Password.Storage.Controllers;
using Password.Storage.Forms;
using Password.Storage.Helpers;
using Password.Storage.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tarsier.Regedit;

namespace Password.Storage {
    public partial class PasswordForm : Form {
        private AppVersions _appVersion = new AppVersions();
        private AppInfo _appInfo = new AppInfo();
        private Credentials _pwds;
        private Image lockImg = Resources._lock;
        private string _selectedId = string.Empty;
        private bool _showPanel = false;
        private bool _hidePassword = true;
        private bool _encryptContent = true;
        private bool _isHover = false;
        public PasswordForm() {
            InitializeComponent();
        }

        private void InitializePasswords() {
            _pwds = new Credentials(Vars.PASSWORD_DB);
            listViewPasswords.Items.Clear();
            _pwds.Initialize(listViewPasswords, _hidePassword);
            listViewPasswords.SelectedIndices.Clear();
            _selectedId = string.Empty;
            splitContainerPwd.Panel2Collapsed = true;
        }

        private void InitializeSettings() {
            RegConfig.Set<bool>("Encrypt", _encryptContent);
            _hidePassword = RegConfig.Get<bool>("HidePassword");
            _showPanel = RegConfig.Get<bool>("ShowPanel");
            splitContainerPwd.Panel2Collapsed = true;
            menuHidePwd.Checked = _hidePassword;
            toolStripPwd.Visible = menuToolbar.Checked = RegConfig.Get<bool>("Toolbar");
            statusStripPwd.Visible = menuStatus.Checked = RegConfig.Get<bool>("Statusbar");
            menuXPLook.Checked = RegConfig.Get<bool>("XPLook");
            if(menuXPLook.Checked) {
                menuStrip1.RenderMode = ToolStripRenderMode.System;
                toolStripPwd.RenderMode = ToolStripRenderMode.System;
            }else {
                menuStrip1.RenderMode = ToolStripRenderMode.Professional;
                toolStripPwd.RenderMode = ToolStripRenderMode.Professional;
            }
        }
        private void Action(string tag) {
            switch(tag) {
                case "ADD":
                    using(NewPasswordForm npf = new NewPasswordForm(_pwds, string.Empty)) {
                        if(npf.ShowDialog().Equals(DialogResult.OK)) {
                            _pwds.Add(npf.Credential);
                            InitializePasswords();
                        }
                    }
                    break;
                case "REMOVE":
                    if(!string.IsNullOrEmpty(_selectedId)) {
                        if(MessageBox.Show(Messages.REMOVE, "Remove Credential", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                            _pwds.Delete(_selectedId);
                            InitializePasswords();
                        }
                    }
                    break;
                case "EDIT":
                    if(!string.IsNullOrEmpty(_selectedId)) {
                        using(NewPasswordForm npf = new NewPasswordForm(_pwds, _selectedId)) {
                            if(npf.ShowDialog().Equals(DialogResult.OK)) {
                                _pwds.Update(npf.Credential, _selectedId);
                                InitializePasswords();
                            }
                        }
                    }
                    break;
                case "CLEAR":
                    if(MessageBox.Show(Messages.CLEAR, "Clear Credentials", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes)) {
                        _pwds.ClearAll();
                        InitializePasswords();
                    }
                    break;
                case "COPY":
                    Clipboard.SetText(string.Format("{0}\t{1}", lblUsername.Text, lblPassword.Text));
                    break;
                case "COPY_USER":
                    Clipboard.SetText(lblUsername.Text);
                    break;
                case "COPY_PWD":
                    Clipboard.SetText(lblPassword.Text);
                    break;
                case "RELOAD":
                    InitializePasswords();
                    break;
                case "SETTINGS":
                    using(OptionForm opt = new OptionForm()) {
                        opt.ShowDialog();
                        InitializeSettings();
                        InitializePasswords();
                    }
                    break;
                case "HELP":
                    using(HelpForm h = new HelpForm()) {
                        h.ShowDialog();
                    }
                    break;
                case "EXIT":
                    Close();
                    break;
                case "ABOUT":
                    using(AboutForm a = new AboutForm()) {
                        a.ShowDialog();
                    }
                    break;
                case "HIDEPWD":
                    if(_hidePassword) {
                        if(MessageBox.Show(Messages.SHOW, "Show Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) {
                            RegConfig.Set<bool>("HidePassword", menuHidePwd.Checked);
                            _hidePassword = menuHidePwd.Checked;
                        }
                    } else {
                        RegConfig.Set<bool>("HidePassword", menuHidePwd.Checked);
                        _hidePassword = menuHidePwd.Checked;
                    }
                    InitializePasswords();
                    break;
                case "TOOLBAR":
                    RegConfig.Set<bool>("Toolbar", menuToolbar.Checked);
                    toolStripPwd.Visible = menuToolbar.Checked;
                    break;
                case "STATUS":
                    RegConfig.Set<bool>("Statusbar", menuStatus.Checked);
                    statusStripPwd.Visible = menuStatus.Checked;
                    break;
                case "XPLOOK":
                    RegConfig.Set<bool>("XPLook", menuXPLook.Checked);
                    Application.Restart();
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
            ToolStripButton tbtn = sender as ToolStripButton;
            if(tbtn != null) {
                if(tbtn.Tag != null) {
                    Action(tbtn.Tag.ToString());
                }
            } else {
                Button btn = sender as Button;
                if(btn != null) {
                    if(btn.Tag != null) {
                        Action(btn.Tag.ToString());
                    }
                }
            }
        }

        private void Buttons_MouseHover(object sender, EventArgs e) {
            ToolStripButton tbtn = sender as ToolStripButton;
            if(tbtn != null) {
                _isHover = true;
                lblStatus.Text = tbtn.Text;
            }
        }

        private void Buttons_MouseLeave(object sender, EventArgs e) {
            _isHover = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if(e.CloseReason.Equals(CloseReason.UserClosing)) {
                if(MessageBox.Show(Messages.EXIT, "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.No)) {
                    e.Cancel = true;
                } else {
                    //@---TODO---
                }
            }
            base.OnFormClosing(e);
        }

        private void PasswordForm_Load(object sender, EventArgs e) {
            _appVersion.WriteVersion("version.txt", _appInfo.AssemblyVersion);
            InitializeSettings();
            InitializePasswords();
        }

        private void tmr_Tick(object sender, EventArgs e) {
            btnRemove.Enabled = btnEdit.Enabled = listViewPasswords.SelectedItems.Count > 0;
            if(!_isHover) {
                lblStatus.Text = (listViewPasswords.SelectedItems.Count > 0) ? "Selected ID: " + _selectedId : "Ready...";
            }
        }

        private void listViewPasswords_SelectedIndexChanged(object sender, EventArgs e) {
            if(listViewPasswords.SelectedItems.Count > 0) {
                ListViewItem item = listViewPasswords.SelectedItems[0];
                _selectedId = item.Text;
                lblDescription.Text = item.SubItems[1].Text;
                lblUsername.Text = item.SubItems[2].Text;
                lblPassword.Text = item.SubItems[3].Text;

                splitContainerPwd.Panel2Collapsed = !_showPanel;
                btnCopy.Enabled = btnRemove.Enabled = btnEdit.Enabled = true;
            } else {
                _selectedId =
                lblDescription.Text = lblUsername.Text = lblPassword.Text = string.Empty;
                splitContainerPwd.Panel2Collapsed = true;
                btnCopy.Enabled = btnRemove.Enabled = btnEdit.Enabled = false;
            }
        }

        private void listViewPasswords_DrawSubItem(object sender, DrawListViewSubItemEventArgs e) {
            if(e.Header != this.columnHeaderPassword) {
                e.DrawDefault = true;
                return;
            }
            if((e.ItemState & ListViewItemStates.Selected) == 0) {
                e.DrawBackground();
            }
            e.DrawDefault = false;
            //e.DrawBackground();
            e.Graphics.DrawImage(lockImg, e.SubItem.Bounds.Location);
            e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, new SolidBrush(e.SubItem.ForeColor), (e.SubItem.Bounds.Location.X + lockImg.Width), e.SubItem.Bounds.Location.Y);
        }

        private void listViewPasswords_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            e.DrawDefault = true;
        }

      
    }
}