namespace WorkTool
{
    partial class Form_chkSpaceXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chkSpaceXML));
            this.panel_set = new System.Windows.Forms.Panel();
            this.chkBox_subfolder = new System.Windows.Forms.CheckBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.btn_chk = new System.Windows.Forms.Button();
            this.panel_progBar = new System.Windows.Forms.Panel();
            this.timer_listFile = new System.Windows.Forms.Timer(this.components);
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.chkBox_subfolder);
            this.panel_set.Controls.Add(this.tb_path);
            this.panel_set.Controls.Add(this.label_path);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(501, 88);
            this.panel_set.TabIndex = 0;
            // 
            // chkBox_subfolder
            // 
            this.chkBox_subfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_subfolder.AutoSize = true;
            this.chkBox_subfolder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_subfolder.ForeColor = System.Drawing.Color.Lime;
            this.chkBox_subfolder.Location = new System.Drawing.Point(352, 62);
            this.chkBox_subfolder.Name = "chkBox_subfolder";
            this.chkBox_subfolder.Size = new System.Drawing.Size(142, 20);
            this.chkBox_subfolder.TabIndex = 2;
            this.chkBox_subfolder.Text = "Include Subfolder";
            this.chkBox_subfolder.UseVisualStyleBackColor = true;
            this.chkBox_subfolder.CheckedChanged += new System.EventHandler(this.chkBox_subfolder_CheckedChanged);
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(3, 34);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(491, 22);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_path.Location = new System.Drawing.Point(3, 12);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(48, 19);
            this.label_path.TabIndex = 0;
            this.label_path.Text = "Path:";
            // 
            // btn_chk
            // 
            this.btn_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_chk.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chk.ForeColor = System.Drawing.Color.Blue;
            this.btn_chk.Location = new System.Drawing.Point(199, 184);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(114, 43);
            this.btn_chk.TabIndex = 1;
            this.btn_chk.Text = "CHECK";
            this.btn_chk.UseVisualStyleBackColor = false;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // panel_progBar
            // 
            this.panel_progBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_progBar.Location = new System.Drawing.Point(12, 126);
            this.panel_progBar.Name = "panel_progBar";
            this.panel_progBar.Size = new System.Drawing.Size(501, 27);
            this.panel_progBar.TabIndex = 2;
            // 
            // timer_listFile
            // 
            this.timer_listFile.Interval = 1000;
            this.timer_listFile.Tick += new System.EventHandler(this.timer_listFile_Tick);
            // 
            // timer_check
            // 
            this.timer_check.Interval = 1000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // Form_chkSpaceXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(525, 275);
            this.Controls.Add(this.panel_progBar);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_chkSpaceXML";
            this.Text = "Check Space( &nbsp; )";
            this.Load += new System.EventHandler(this.Form_chkSpaceXML_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.CheckBox chkBox_subfolder;
        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Panel panel_progBar;
        private System.Windows.Forms.Timer timer_listFile;
        private System.Windows.Forms.Timer timer_check;
    }
}