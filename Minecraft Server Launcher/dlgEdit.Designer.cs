namespace Minecraft_Server_Launcher
{
    partial class dlgEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPermission = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPermissionXUID = new System.Windows.Forms.TextBox();
            this.cboPermission = new System.Windows.Forms.ComboBox();
            this.panelPack = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackFileVersion = new System.Windows.Forms.TextBox();
            this.txtPackFileSystem = new System.Windows.Forms.TextBox();
            this.txtPackPath = new System.Windows.Forms.TextBox();
            this.txtPackUUID = new System.Windows.Forms.TextBox();
            this.txtPackVersion = new System.Windows.Forms.TextBox();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPlayerXUID = new System.Windows.Forms.TextBox();
            this.chkPlayerIgnorePlayerLimit = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelPermission.SuspendLayout();
            this.panelPack.SuspendLayout();
            this.panelPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPermission
            // 
            this.panelPermission.Controls.Add(this.cboPermission);
            this.panelPermission.Controls.Add(this.txtPermissionXUID);
            this.panelPermission.Controls.Add(this.label2);
            this.panelPermission.Controls.Add(this.label1);
            this.panelPermission.Location = new System.Drawing.Point(12, 12);
            this.panelPermission.Name = "panelPermission";
            this.panelPermission.Size = new System.Drawing.Size(333, 145);
            this.panelPermission.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Permission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "XUID:";
            // 
            // txtPermissionXUID
            // 
            this.txtPermissionXUID.Location = new System.Drawing.Point(69, 39);
            this.txtPermissionXUID.Name = "txtPermissionXUID";
            this.txtPermissionXUID.Size = new System.Drawing.Size(261, 20);
            this.txtPermissionXUID.TabIndex = 3;
            // 
            // cboPermission
            // 
            this.cboPermission.FormattingEnabled = true;
            this.cboPermission.Items.AddRange(new object[] {
            "visitor",
            "member",
            "operator"});
            this.cboPermission.Location = new System.Drawing.Point(69, 12);
            this.cboPermission.Name = "cboPermission";
            this.cboPermission.Size = new System.Drawing.Size(121, 21);
            this.cboPermission.TabIndex = 4;
            // 
            // panelPack
            // 
            this.panelPack.Controls.Add(this.txtPackVersion);
            this.panelPack.Controls.Add(this.txtPackUUID);
            this.panelPack.Controls.Add(this.txtPackPath);
            this.panelPack.Controls.Add(this.txtPackFileSystem);
            this.panelPack.Controls.Add(this.txtPackFileVersion);
            this.panelPack.Controls.Add(this.label7);
            this.panelPack.Controls.Add(this.label6);
            this.panelPack.Controls.Add(this.label5);
            this.panelPack.Controls.Add(this.label4);
            this.panelPack.Controls.Add(this.label3);
            this.panelPack.Location = new System.Drawing.Point(351, 12);
            this.panelPack.Name = "panelPack";
            this.panelPack.Size = new System.Drawing.Size(333, 145);
            this.panelPack.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "File System:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "UUID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Version:";
            // 
            // txtPackFileVersion
            // 
            this.txtPackFileVersion.Location = new System.Drawing.Point(72, 12);
            this.txtPackFileVersion.Name = "txtPackFileVersion";
            this.txtPackFileVersion.Size = new System.Drawing.Size(101, 20);
            this.txtPackFileVersion.TabIndex = 5;
            // 
            // txtPackFileSystem
            // 
            this.txtPackFileSystem.Location = new System.Drawing.Point(72, 35);
            this.txtPackFileSystem.Name = "txtPackFileSystem";
            this.txtPackFileSystem.Size = new System.Drawing.Size(258, 20);
            this.txtPackFileSystem.TabIndex = 6;
            // 
            // txtPackPath
            // 
            this.txtPackPath.Location = new System.Drawing.Point(73, 61);
            this.txtPackPath.Name = "txtPackPath";
            this.txtPackPath.Size = new System.Drawing.Size(257, 20);
            this.txtPackPath.TabIndex = 7;
            // 
            // txtPackUUID
            // 
            this.txtPackUUID.Location = new System.Drawing.Point(73, 87);
            this.txtPackUUID.Name = "txtPackUUID";
            this.txtPackUUID.Size = new System.Drawing.Size(257, 20);
            this.txtPackUUID.TabIndex = 8;
            // 
            // txtPackVersion
            // 
            this.txtPackVersion.Location = new System.Drawing.Point(73, 113);
            this.txtPackVersion.Name = "txtPackVersion";
            this.txtPackVersion.Size = new System.Drawing.Size(100, 20);
            this.txtPackVersion.TabIndex = 9;
            // 
            // panelPlayer
            // 
            this.panelPlayer.Controls.Add(this.chkPlayerIgnorePlayerLimit);
            this.panelPlayer.Controls.Add(this.txtPlayerXUID);
            this.panelPlayer.Controls.Add(this.txtPlayerName);
            this.panelPlayer.Controls.Add(this.label9);
            this.panelPlayer.Controls.Add(this.label8);
            this.panelPlayer.Location = new System.Drawing.Point(690, 12);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(333, 145);
            this.panelPlayer.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "XUID:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(56, 3);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(274, 20);
            this.txtPlayerName.TabIndex = 3;
            // 
            // txtPlayerXUID
            // 
            this.txtPlayerXUID.Location = new System.Drawing.Point(56, 29);
            this.txtPlayerXUID.Name = "txtPlayerXUID";
            this.txtPlayerXUID.Size = new System.Drawing.Size(274, 20);
            this.txtPlayerXUID.TabIndex = 4;
            // 
            // chkPlayerIgnorePlayerLimit
            // 
            this.chkPlayerIgnorePlayerLimit.AutoSize = true;
            this.chkPlayerIgnorePlayerLimit.Location = new System.Drawing.Point(56, 55);
            this.chkPlayerIgnorePlayerLimit.Name = "chkPlayerIgnorePlayerLimit";
            this.chkPlayerIgnorePlayerLimit.Size = new System.Drawing.Size(117, 17);
            this.chkPlayerIgnorePlayerLimit.TabIndex = 5;
            this.chkPlayerIgnorePlayerLimit.Text = "Ignores Player Limit";
            this.chkPlayerIgnorePlayerLimit.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(865, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(946, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dlgEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.panelPack);
            this.Controls.Add(this.panelPermission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dlgEdit";
            this.Text = "dlgEdit";
            this.panelPermission.ResumeLayout(false);
            this.panelPermission.PerformLayout();
            this.panelPack.ResumeLayout(false);
            this.panelPack.PerformLayout();
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPermission;
        private System.Windows.Forms.ComboBox cboPermission;
        private System.Windows.Forms.TextBox txtPermissionXUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPack;
        private System.Windows.Forms.TextBox txtPackVersion;
        private System.Windows.Forms.TextBox txtPackUUID;
        private System.Windows.Forms.TextBox txtPackPath;
        private System.Windows.Forms.TextBox txtPackFileSystem;
        private System.Windows.Forms.TextBox txtPackFileVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.CheckBox chkPlayerIgnorePlayerLimit;
        private System.Windows.Forms.TextBox txtPlayerXUID;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}