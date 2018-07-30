namespace WorkTool
{
    partial class Form_chkFileNameAfterVerId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chkFileNameAfterVerId));
            this.panel_set = new System.Windows.Forms.Panel();
            this.chkBox_subfolder = new System.Windows.Forms.CheckBox();
            this.tb_filepath = new System.Windows.Forms.TextBox();
            this.label_path = new System.Windows.Forms.Label();
            this.btn_chk = new System.Windows.Forms.Button();
            this.timer_listFiles = new System.Windows.Forms.Timer(this.components);
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.panel_progress = new System.Windows.Forms.Panel();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.chkBox_subfolder);
            this.panel_set.Controls.Add(this.tb_filepath);
            this.panel_set.Controls.Add(this.label_path);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(517, 94);
            this.panel_set.TabIndex = 0;
            // 
            // chkBox_subfolder
            // 
            this.chkBox_subfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_subfolder.AutoSize = true;
            this.chkBox_subfolder.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_subfolder.ForeColor = System.Drawing.Color.MediumBlue;
            this.chkBox_subfolder.Location = new System.Drawing.Point(369, 61);
            this.chkBox_subfolder.Name = "chkBox_subfolder";
            this.chkBox_subfolder.Size = new System.Drawing.Size(130, 21);
            this.chkBox_subfolder.TabIndex = 2;
            this.chkBox_subfolder.Text = "Include Subfolder";
            this.chkBox_subfolder.UseVisualStyleBackColor = true;
            this.chkBox_subfolder.CheckedChanged += new System.EventHandler(this.chkBox_subfolder_CheckedChanged);
            // 
            // tb_filepath
            // 
            this.tb_filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filepath.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_filepath.Location = new System.Drawing.Point(7, 33);
            this.tb_filepath.Name = "tb_filepath";
            this.tb_filepath.Size = new System.Drawing.Size(503, 22);
            this.tb_filepath.TabIndex = 1;
            this.tb_filepath.TextChanged += new System.EventHandler(this.tb_filepath_TextChanged);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_path.Location = new System.Drawing.Point(3, 10);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(74, 20);
            this.label_path.TabIndex = 0;
            this.label_path.Text = "File Path:";
            // 
            // btn_chk
            // 
            this.btn_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_chk.Font = new System.Drawing.Font("方正姚体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chk.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_chk.Location = new System.Drawing.Point(201, 193);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(118, 41);
            this.btn_chk.TabIndex = 1;
            this.btn_chk.Text = "CHECK";
            this.btn_chk.UseVisualStyleBackColor = false;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // timer_listFiles
            // 
            this.timer_listFiles.Interval = 1000;
            this.timer_listFiles.Tick += new System.EventHandler(this.timer_listFiles_Tick);
            // 
            // timer_check
            // 
            this.timer_check.Interval = 1000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // panel_progress
            // 
            this.panel_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_progress.Location = new System.Drawing.Point(12, 138);
            this.panel_progress.Name = "panel_progress";
            this.panel_progress.Size = new System.Drawing.Size(517, 30);
            this.panel_progress.TabIndex = 2;
            // 
            // Form_chkFileNameAfterVerId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(541, 278);
            this.Controls.Add(this.panel_progress);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_chkFileNameAfterVerId";
            this.Text = "Check Filename after \"- @version $Id:\"";
            this.Load += new System.EventHandler(this.Form_chkFileNameAfterVerId_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.CheckBox chkBox_subfolder;
        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Timer timer_listFiles;
        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Panel panel_progress;
    }
}