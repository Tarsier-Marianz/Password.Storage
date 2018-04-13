namespace Password.Storage.Forms {
    partial class OptionForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.chkEncryptContent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkHidePassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShowDetails = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkEncryptContent
            // 
            this.chkEncryptContent.Checked = true;
            this.chkEncryptContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEncryptContent.Enabled = false;
            this.chkEncryptContent.ForeColor = System.Drawing.Color.Green;
            this.chkEncryptContent.Location = new System.Drawing.Point(23, 26);
            this.chkEncryptContent.Name = "chkEncryptContent";
            this.chkEncryptContent.Size = new System.Drawing.Size(292, 17);
            this.chkEncryptContent.TabIndex = 0;
            this.chkEncryptContent.Tag = "Encrypt";
            this.chkEncryptContent.Text = "Encrypt";
            this.chkEncryptContent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encrypt all data stored into database. This will help to secure database content." +
    "";
            // 
            // chkHidePassword
            // 
            this.chkHidePassword.ForeColor = System.Drawing.Color.Green;
            this.chkHidePassword.Location = new System.Drawing.Point(23, 84);
            this.chkHidePassword.Name = "chkHidePassword";
            this.chkHidePassword.Size = new System.Drawing.Size(292, 17);
            this.chkHidePassword.TabIndex = 2;
            this.chkHidePassword.Tag = "HidePassword";
            this.chkHidePassword.Text = "Hide Password";
            this.chkHidePassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do not display password in the credential table. Instead asterisk (*) will be dis" +
    "played.";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(41, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Display panel containing details of selected credential located in right side of " +
    "the window.";
            // 
            // chkShowDetails
            // 
            this.chkShowDetails.ForeColor = System.Drawing.Color.Green;
            this.chkShowDetails.Location = new System.Drawing.Point(23, 143);
            this.chkShowDetails.Name = "chkShowDetails";
            this.chkShowDetails.Size = new System.Drawing.Size(292, 17);
            this.chkShowDetails.TabIndex = 4;
            this.chkShowDetails.Tag = "ShowPanel";
            this.chkShowDetails.Text = "Show Detail Panel";
            this.chkShowDetails.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 265);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkShowDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHidePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEncryptContent);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEncryptContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkHidePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}