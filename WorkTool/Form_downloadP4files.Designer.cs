namespace WorkTool
{
    partial class Form_downloadP4files
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_downloadP4files));
            this.grpBox_settings = new System.Windows.Forms.GroupBox();
            this.btn_updPassword = new System.Windows.Forms.Button();
            this.btn_addWorkspace = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_addServer = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comBox_Workspace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comBox_User = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comBox_Server = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editFilelist = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.tb_runinfo = new System.Windows.Forms.TextBox();
            this.panel_set = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpBox_settings.SuspendLayout();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_settings
            // 
            this.grpBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_settings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpBox_settings.Controls.Add(this.btn_updPassword);
            this.grpBox_settings.Controls.Add(this.btn_addWorkspace);
            this.grpBox_settings.Controls.Add(this.btn_addUser);
            this.grpBox_settings.Controls.Add(this.btn_addServer);
            this.grpBox_settings.Controls.Add(this.tb_Password);
            this.grpBox_settings.Controls.Add(this.label6);
            this.grpBox_settings.Controls.Add(this.comBox_Workspace);
            this.grpBox_settings.Controls.Add(this.label5);
            this.grpBox_settings.Controls.Add(this.comBox_User);
            this.grpBox_settings.Controls.Add(this.label2);
            this.grpBox_settings.Controls.Add(this.comBox_Server);
            this.grpBox_settings.Controls.Add(this.label1);
            this.grpBox_settings.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBox_settings.Location = new System.Drawing.Point(3, 3);
            this.grpBox_settings.Name = "grpBox_settings";
            this.grpBox_settings.Size = new System.Drawing.Size(517, 141);
            this.grpBox_settings.TabIndex = 0;
            this.grpBox_settings.TabStop = false;
            this.grpBox_settings.Text = "Connect P4 Settings";
            // 
            // btn_updPassword
            // 
            this.btn_updPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_updPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_updPassword.Location = new System.Drawing.Point(411, 107);
            this.btn_updPassword.Name = "btn_updPassword";
            this.btn_updPassword.Size = new System.Drawing.Size(75, 22);
            this.btn_updPassword.TabIndex = 16;
            this.btn_updPassword.Text = "Update";
            this.btn_updPassword.UseVisualStyleBackColor = true;
            this.btn_updPassword.Click += new System.EventHandler(this.btn_updPassword_Click);
            // 
            // btn_addWorkspace
            // 
            this.btn_addWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addWorkspace.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addWorkspace.ForeColor = System.Drawing.Color.Teal;
            this.btn_addWorkspace.Location = new System.Drawing.Point(411, 79);
            this.btn_addWorkspace.Name = "btn_addWorkspace";
            this.btn_addWorkspace.Size = new System.Drawing.Size(75, 22);
            this.btn_addWorkspace.TabIndex = 15;
            this.btn_addWorkspace.Text = "Add";
            this.btn_addWorkspace.UseVisualStyleBackColor = true;
            this.btn_addWorkspace.Click += new System.EventHandler(this.btn_addWorkspace_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addUser.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_addUser.Location = new System.Drawing.Point(411, 51);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(75, 22);
            this.btn_addUser.TabIndex = 14;
            this.btn_addUser.Text = "Add";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_addServer
            // 
            this.btn_addServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addServer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addServer.ForeColor = System.Drawing.Color.Purple;
            this.btn_addServer.Location = new System.Drawing.Point(411, 23);
            this.btn_addServer.Name = "btn_addServer";
            this.btn_addServer.Size = new System.Drawing.Size(75, 22);
            this.btn_addServer.TabIndex = 13;
            this.btn_addServer.Text = "Add";
            this.btn_addServer.UseVisualStyleBackColor = true;
            this.btn_addServer.Click += new System.EventHandler(this.btn_addServer_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Password.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_Password.Location = new System.Drawing.Point(145, 107);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(237, 22);
            this.tb_Password.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(18, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // comBox_Workspace
            // 
            this.comBox_Workspace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox_Workspace.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Workspace.ForeColor = System.Drawing.Color.Teal;
            this.comBox_Workspace.FormattingEnabled = true;
            this.comBox_Workspace.Location = new System.Drawing.Point(145, 79);
            this.comBox_Workspace.Name = "comBox_Workspace";
            this.comBox_Workspace.Size = new System.Drawing.Size(237, 22);
            this.comBox_Workspace.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(18, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Workspace:";
            // 
            // comBox_User
            // 
            this.comBox_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox_User.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.comBox_User.FormattingEnabled = true;
            this.comBox_User.Location = new System.Drawing.Point(145, 51);
            this.comBox_User.Name = "comBox_User";
            this.comBox_User.Size = new System.Drawing.Size(237, 22);
            this.comBox_User.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "User:";
            // 
            // comBox_Server
            // 
            this.comBox_Server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox_Server.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_Server.ForeColor = System.Drawing.Color.Purple;
            this.comBox_Server.FormattingEnabled = true;
            this.comBox_Server.Location = new System.Drawing.Point(145, 23);
            this.comBox_Server.Name = "comBox_Server";
            this.comBox_Server.Size = new System.Drawing.Size(237, 22);
            this.comBox_Server.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // btn_editFilelist
            // 
            this.btn_editFilelist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editFilelist.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_editFilelist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_editFilelist.Location = new System.Drawing.Point(24, 150);
            this.btn_editFilelist.Name = "btn_editFilelist";
            this.btn_editFilelist.Size = new System.Drawing.Size(465, 32);
            this.btn_editFilelist.TabIndex = 17;
            this.btn_editFilelist.Text = "Edit the Filelist of Download";
            this.btn_editFilelist.UseVisualStyleBackColor = true;
            this.btn_editFilelist.Click += new System.EventHandler(this.btn_editFilelist_Click);
            // 
            // btn_download
            // 
            this.btn_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_download.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Location = new System.Drawing.Point(551, 112);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(128, 57);
            this.btn_download.TabIndex = 1;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // tb_runinfo
            // 
            this.tb_runinfo.AcceptsReturn = true;
            this.tb_runinfo.AcceptsTab = true;
            this.tb_runinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_runinfo.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_runinfo.ForeColor = System.Drawing.Color.Black;
            this.tb_runinfo.Location = new System.Drawing.Point(13, 210);
            this.tb_runinfo.Multiline = true;
            this.tb_runinfo.Name = "tb_runinfo";
            this.tb_runinfo.ReadOnly = true;
            this.tb_runinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_runinfo.Size = new System.Drawing.Size(666, 344);
            this.tb_runinfo.TabIndex = 2;
            this.tb_runinfo.WordWrap = false;
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.Controls.Add(this.btn_editFilelist);
            this.panel_set.Controls.Add(this.grpBox_settings);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(523, 192);
            this.panel_set.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(551, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(128, 91);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Make sure your VPN has been connected before starting download.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_downloadP4files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(691, 566);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel_set);
            this.Controls.Add(this.tb_runinfo);
            this.Controls.Add(this.btn_download);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_downloadP4files";
            this.Text = "Download Files from P4";
            this.Load += new System.EventHandler(this.Form_downloadP4files_Load);
            this.grpBox_settings.ResumeLayout(false);
            this.grpBox_settings.PerformLayout();
            this.panel_set.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_settings;
        private System.Windows.Forms.ComboBox comBox_Server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBox_User;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.ComboBox comBox_Workspace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_updPassword;
        private System.Windows.Forms.Button btn_addWorkspace;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_addServer;
        private System.Windows.Forms.Button btn_editFilelist;
        private System.Windows.Forms.TextBox tb_runinfo;
        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.TextBox textBox1;
    }
}