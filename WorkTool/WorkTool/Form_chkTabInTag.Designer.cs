namespace WorkTool
{
    partial class Form_chkTabInTag
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chkTabInTag));
            this.panel_setting = new System.Windows.Forms.Panel();
            this.chkBox_subfolder = new System.Windows.Forms.CheckBox();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.lab_filepath = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.timer_listFiles = new System.Windows.Forms.Timer(this.components);
            this.lab_msg = new System.Windows.Forms.Label();
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.panel_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_setting
            // 
            this.panel_setting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_setting.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_setting.Controls.Add(this.chkBox_subfolder);
            this.panel_setting.Controls.Add(this.tb_filePath);
            this.panel_setting.Controls.Add(this.lab_filepath);
            this.panel_setting.Location = new System.Drawing.Point(12, 12);
            this.panel_setting.Name = "panel_setting";
            this.panel_setting.Size = new System.Drawing.Size(521, 100);
            this.panel_setting.TabIndex = 0;
            // 
            // chkBox_subfolder
            // 
            this.chkBox_subfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_subfolder.AutoSize = true;
            this.chkBox_subfolder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_subfolder.ForeColor = System.Drawing.Color.Cyan;
            this.chkBox_subfolder.Location = new System.Drawing.Point(348, 27);
            this.chkBox_subfolder.Name = "chkBox_subfolder";
            this.chkBox_subfolder.Size = new System.Drawing.Size(142, 20);
            this.chkBox_subfolder.TabIndex = 2;
            this.chkBox_subfolder.Text = "Include Subfolder";
            this.chkBox_subfolder.UseVisualStyleBackColor = true;
            this.chkBox_subfolder.CheckedChanged += new System.EventHandler(this.chkBox_subfolder_CheckedChanged);
            // 
            // tb_filePath
            // 
            this.tb_filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filePath.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_filePath.Location = new System.Drawing.Point(6, 49);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(508, 22);
            this.tb_filePath.TabIndex = 1;
            this.tb_filePath.TextChanged += new System.EventHandler(this.tb_filePath_TextChanged);
            // 
            // lab_filepath
            // 
            this.lab_filepath.AutoSize = true;
            this.lab_filepath.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_filepath.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lab_filepath.Location = new System.Drawing.Point(3, 26);
            this.lab_filepath.Name = "lab_filepath";
            this.lab_filepath.Size = new System.Drawing.Size(77, 19);
            this.lab_filepath.TabIndex = 0;
            this.lab_filepath.Text = "File Path:";
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.BackColor = System.Drawing.Color.LightBlue;
            this.btn_check.Font = new System.Drawing.Font("方正姚体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_check.Location = new System.Drawing.Point(201, 191);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(133, 46);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "CHECK";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // timer_listFiles
            // 
            this.timer_listFiles.Interval = 1000;
            this.timer_listFiles.Tick += new System.EventHandler(this.timer_listFiles_Tick);
            // 
            // lab_msg
            // 
            this.lab_msg.AutoSize = true;
            this.lab_msg.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_msg.ForeColor = System.Drawing.Color.Black;
            this.lab_msg.Location = new System.Drawing.Point(17, 129);
            this.lab_msg.Name = "lab_msg";
            this.lab_msg.Size = new System.Drawing.Size(319, 19);
            this.lab_msg.TabIndex = 2;
            this.lab_msg.Text = "label1tt34f34t4t4rtr4rwer23wr34";
            // 
            // timer_check
            // 
            this.timer_check.Interval = 1000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // Form_chkTabInTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 268);
            this.Controls.Add(this.lab_msg);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.panel_setting);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_chkTabInTag";
            this.Text = "Check Tab in Tag";
            this.Load += new System.EventHandler(this.Form_chkTabInTag_Load);
            this.panel_setting.ResumeLayout(false);
            this.panel_setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_setting;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Label lab_filepath;
        private System.Windows.Forms.CheckBox chkBox_subfolder;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Timer timer_listFiles;
        private System.Windows.Forms.Label lab_msg;
        private System.Windows.Forms.Timer timer_check;
    }
}