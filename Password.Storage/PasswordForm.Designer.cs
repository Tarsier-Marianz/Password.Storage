namespace Password.Storage {
    partial class PasswordForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHidePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPwd = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.statusStripPwd = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewPasswords = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgListNos = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerPwd = new System.Windows.Forms.SplitContainer();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnCopyUsername = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStripPwd.SuspendLayout();
            this.statusStripPwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPwd)).BeginInit();
            this.splitContainerPwd.Panel1.SuspendLayout();
            this.splitContainerPwd.Panel2.SuspendLayout();
            this.splitContainerPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuClear,
            this.toolStripSeparator1,
            this.menuExit});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.passwordToolStripMenuItem.Text = "Credential";
            // 
            // menuAdd
            // 
            this.menuAdd.Image = ((System.Drawing.Image)(resources.GetObject("menuAdd.Image")));
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(152, 22);
            this.menuAdd.Tag = "ADD";
            this.menuAdd.Text = "Add";
            this.menuAdd.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuClear
            // 
            this.menuClear.Image = ((System.Drawing.Image)(resources.GetObject("menuClear.Image")));
            this.menuClear.Name = "menuClear";
            this.menuClear.Size = new System.Drawing.Size(152, 22);
            this.menuClear.Tag = "CLEAR";
            this.menuClear.Text = "Clear";
            this.menuClear.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.Image = ((System.Drawing.Image)(resources.GetObject("menuExit.Image")));
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Tag = "EXIT";
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.Menus_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHidePwd,
            this.toolStripSeparator3,
            this.menuToolbar,
            this.menuStatus});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menuHidePwd
            // 
            this.menuHidePwd.CheckOnClick = true;
            this.menuHidePwd.Name = "menuHidePwd";
            this.menuHidePwd.Size = new System.Drawing.Size(152, 22);
            this.menuHidePwd.Tag = "HIDEPWD";
            this.menuHidePwd.Text = "Hide Password";
            this.menuHidePwd.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // menuToolbar
            // 
            this.menuToolbar.CheckOnClick = true;
            this.menuToolbar.Name = "menuToolbar";
            this.menuToolbar.Size = new System.Drawing.Size(152, 22);
            this.menuToolbar.Tag = "TOOLBAR";
            this.menuToolbar.Text = "Toolbar";
            this.menuToolbar.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuStatus
            // 
            this.menuStatus.CheckOnClick = true;
            this.menuStatus.Name = "menuStatus";
            this.menuStatus.Size = new System.Drawing.Size(152, 22);
            this.menuStatus.Tag = "STATUS";
            this.menuStatus.Text = "Status";
            this.menuStatus.Click += new System.EventHandler(this.Menus_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp,
            this.menuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuHelp
            // 
            this.menuHelp.Image = ((System.Drawing.Image)(resources.GetObject("menuHelp.Image")));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(145, 22);
            this.menuHelp.Tag = "HELP";
            this.menuHelp.Text = "Help Content";
            this.menuHelp.Click += new System.EventHandler(this.Menus_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Image = ((System.Drawing.Image)(resources.GetObject("menuAbout.Image")));
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(145, 22);
            this.menuAbout.Tag = "ABOUT";
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.Menus_Click);
            // 
            // toolStripPwd
            // 
            this.toolStripPwd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnRemove,
            this.btnEdit,
            this.btnCopy,
            this.btnRefresh,
            this.btnClear,
            this.toolStripSeparator2,
            this.btnSettings,
            this.toolStripLabel1,
            this.btnHelp,
            this.btnExit});
            this.toolStripPwd.Location = new System.Drawing.Point(0, 24);
            this.toolStripPwd.Name = "toolStripPwd";
            this.toolStripPwd.Size = new System.Drawing.Size(621, 25);
            this.toolStripPwd.TabIndex = 1;
            this.toolStripPwd.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Tag = "ADD";
            this.btnAdd.Text = "Add Credential";
            this.btnAdd.Click += new System.EventHandler(this.Buttons_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 22);
            this.btnRemove.Tag = "REMOVE";
            this.btnRemove.Text = "Remove selected credential";
            this.btnRemove.Click += new System.EventHandler(this.Buttons_Click);
            this.btnRemove.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnRemove.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Tag = "EDIT";
            this.btnEdit.Text = "Edit selected credental";
            this.btnEdit.Click += new System.EventHandler(this.Buttons_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Enabled = false;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(23, 22);
            this.btnCopy.Tag = "COPY";
            this.btnCopy.Text = "Copy selected credential";
            this.btnCopy.Click += new System.EventHandler(this.Buttons_Click);
            this.btnCopy.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnCopy.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Tag = "RELOAD";
            this.btnRefresh.Text = "Reload credentials";
            this.btnRefresh.Click += new System.EventHandler(this.Buttons_Click);
            this.btnRefresh.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnRefresh.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Tag = "CLEAR";
            this.btnClear.Text = "Clear all credentials";
            this.btnClear.Click += new System.EventHandler(this.Buttons_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnClear.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Tag = "SETTINGS";
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.Buttons_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnSettings.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel1.Text = "       ";
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Tag = "HELP";
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.Buttons_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 22);
            this.btnExit.Tag = "EXIT";
            this.btnExit.Text = "Exit Application";
            this.btnExit.Click += new System.EventHandler(this.Buttons_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.Buttons_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.Buttons_MouseHover);
            // 
            // statusStripPwd
            // 
            this.statusStripPwd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStripPwd.Location = new System.Drawing.Point(0, 305);
            this.statusStripPwd.Name = "statusStripPwd";
            this.statusStripPwd.Size = new System.Drawing.Size(621, 22);
            this.statusStripPwd.TabIndex = 2;
            this.statusStripPwd.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // listViewPasswords
            // 
            this.listViewPasswords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderDescription,
            this.columnHeaderUsername,
            this.columnHeaderPassword});
            this.listViewPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPasswords.FullRowSelect = true;
            this.listViewPasswords.GridLines = true;
            this.listViewPasswords.Location = new System.Drawing.Point(0, 0);
            this.listViewPasswords.MultiSelect = false;
            this.listViewPasswords.Name = "listViewPasswords";
            this.listViewPasswords.Size = new System.Drawing.Size(441, 256);
            this.listViewPasswords.SmallImageList = this.imgListNos;
            this.listViewPasswords.TabIndex = 3;
            this.listViewPasswords.UseCompatibleStateImageBehavior = false;
            this.listViewPasswords.View = System.Windows.Forms.View.Details;
            this.listViewPasswords.SelectedIndexChanged += new System.EventHandler(this.listViewPasswords_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 40;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 162;
            // 
            // columnHeaderUsername
            // 
            this.columnHeaderUsername.DisplayIndex = 3;
            this.columnHeaderUsername.Text = "Username";
            this.columnHeaderUsername.Width = 89;
            // 
            // columnHeaderPassword
            // 
            this.columnHeaderPassword.DisplayIndex = 2;
            this.columnHeaderPassword.Text = "Password";
            this.columnHeaderPassword.Width = 123;
            // 
            // imgListNos
            // 
            this.imgListNos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListNos.ImageStream")));
            this.imgListNos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListNos.Images.SetKeyName(0, "notification-counter-01.png");
            this.imgListNos.Images.SetKeyName(1, "notification-counter-02.png");
            this.imgListNos.Images.SetKeyName(2, "notification-counter-03.png");
            this.imgListNos.Images.SetKeyName(3, "notification-counter-04.png");
            this.imgListNos.Images.SetKeyName(4, "notification-counter-05.png");
            this.imgListNos.Images.SetKeyName(5, "notification-counter-06.png");
            this.imgListNos.Images.SetKeyName(6, "notification-counter-07.png");
            this.imgListNos.Images.SetKeyName(7, "notification-counter-08.png");
            this.imgListNos.Images.SetKeyName(8, "notification-counter-09.png");
            this.imgListNos.Images.SetKeyName(9, "notification-counter-10.png");
            this.imgListNos.Images.SetKeyName(10, "notification-counter-11.png");
            this.imgListNos.Images.SetKeyName(11, "notification-counter-12.png");
            this.imgListNos.Images.SetKeyName(12, "notification-counter-13.png");
            this.imgListNos.Images.SetKeyName(13, "notification-counter-14.png");
            this.imgListNos.Images.SetKeyName(14, "notification-counter-15.png");
            this.imgListNos.Images.SetKeyName(15, "notification-counter-16.png");
            this.imgListNos.Images.SetKeyName(16, "notification-counter-17.png");
            this.imgListNos.Images.SetKeyName(17, "notification-counter-18.png");
            this.imgListNos.Images.SetKeyName(18, "notification-counter-19.png");
            this.imgListNos.Images.SetKeyName(19, "notification-counter-20.png");
            this.imgListNos.Images.SetKeyName(20, "notification-counter-20-plus.png");
            this.imgListNos.Images.SetKeyName(21, "notification-counter-42.png");
            // 
            // splitContainerPwd
            // 
            this.splitContainerPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPwd.Location = new System.Drawing.Point(0, 49);
            this.splitContainerPwd.Name = "splitContainerPwd";
            // 
            // splitContainerPwd.Panel1
            // 
            this.splitContainerPwd.Panel1.Controls.Add(this.listViewPasswords);
            // 
            // splitContainerPwd.Panel2
            // 
            this.splitContainerPwd.Panel2.Controls.Add(this.btnCopyPassword);
            this.splitContainerPwd.Panel2.Controls.Add(this.btnCopyUsername);
            this.splitContainerPwd.Panel2.Controls.Add(this.label2);
            this.splitContainerPwd.Panel2.Controls.Add(this.label5);
            this.splitContainerPwd.Panel2.Controls.Add(this.label6);
            this.splitContainerPwd.Panel2.Controls.Add(this.lblDescription);
            this.splitContainerPwd.Panel2.Controls.Add(this.lblPassword);
            this.splitContainerPwd.Panel2.Controls.Add(this.lblUsername);
            this.splitContainerPwd.Panel2MinSize = 175;
            this.splitContainerPwd.Size = new System.Drawing.Size(621, 256);
            this.splitContainerPwd.SplitterDistance = 441;
            this.splitContainerPwd.TabIndex = 4;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyPassword.FlatAppearance.BorderSize = 0;
            this.btnCopyPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyPassword.Image")));
            this.btnCopyPassword.Location = new System.Drawing.Point(144, 64);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(21, 21);
            this.btnCopyPassword.TabIndex = 11;
            this.btnCopyPassword.Tag = "COPY_PWD";
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // btnCopyUsername
            // 
            this.btnCopyUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyUsername.FlatAppearance.BorderSize = 0;
            this.btnCopyUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyUsername.Image")));
            this.btnCopyUsername.Location = new System.Drawing.Point(144, 11);
            this.btnCopyUsername.Name = "btnCopyUsername";
            this.btnCopyUsername.Size = new System.Drawing.Size(21, 21);
            this.btnCopyUsername.TabIndex = 10;
            this.btnCopyUsername.Tag = "COPY_USER";
            this.btnCopyUsername.UseVisualStyleBackColor = true;
            this.btnCopyUsername.Click += new System.EventHandler(this.Buttons_Click);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(134, 52);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "---";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoEllipsis = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(136, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "***";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoEllipsis = true;
            this.lblUsername.Location = new System.Drawing.Point(28, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(136, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "...";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 327);
            this.Controls.Add(this.splitContainerPwd);
            this.Controls.Add(this.statusStripPwd);
            this.Controls.Add(this.toolStripPwd);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Storage";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripPwd.ResumeLayout(false);
            this.toolStripPwd.PerformLayout();
            this.statusStripPwd.ResumeLayout(false);
            this.statusStripPwd.PerformLayout();
            this.splitContainerPwd.Panel1.ResumeLayout(false);
            this.splitContainerPwd.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPwd)).EndInit();
            this.splitContainerPwd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolbar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPwd;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.StatusStrip statusStripPwd;
        private System.Windows.Forms.ListView listViewPasswords;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderPassword;
        private System.Windows.Forms.SplitContainer splitContainerPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem menuStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ImageList imgListNos;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem menuHidePwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopyUsername;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

