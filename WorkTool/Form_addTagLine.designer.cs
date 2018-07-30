namespace WorkTool
{
    partial class Form_addTagLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_addTagLine));
            this.grpBox_settings = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtn_chkPostEng = new System.Windows.Forms.RadioButton();
            this.rBtn_preENG = new System.Windows.Forms.RadioButton();
            this.chkBox_onlyFilter = new System.Windows.Forms.CheckBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_info = new System.Windows.Forms.ListBox();
            this.grpBox_settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_settings
            // 
            this.grpBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_settings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpBox_settings.Controls.Add(this.panel1);
            this.grpBox_settings.Controls.Add(this.chkBox_onlyFilter);
            this.grpBox_settings.Controls.Add(this.tb_path);
            this.grpBox_settings.Controls.Add(this.label1);
            this.grpBox_settings.Location = new System.Drawing.Point(12, 2);
            this.grpBox_settings.Name = "grpBox_settings";
            this.grpBox_settings.Size = new System.Drawing.Size(504, 144);
            this.grpBox_settings.TabIndex = 0;
            this.grpBox_settings.TabStop = false;
            this.grpBox_settings.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.rBtn_chkPostEng);
            this.panel1.Controls.Add(this.rBtn_preENG);
            this.panel1.Location = new System.Drawing.Point(6, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 28);
            this.panel1.TabIndex = 7;
            // 
            // rBtn_chkPostEng
            // 
            this.rBtn_chkPostEng.AutoSize = true;
            this.rBtn_chkPostEng.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_chkPostEng.ForeColor = System.Drawing.Color.Cyan;
            this.rBtn_chkPostEng.Location = new System.Drawing.Point(265, 3);
            this.rBtn_chkPostEng.Name = "rBtn_chkPostEng";
            this.rBtn_chkPostEng.Size = new System.Drawing.Size(224, 20);
            this.rBtn_chkPostEng.TabIndex = 1;
            this.rBtn_chkPostEng.TabStop = true;
            this.rBtn_chkPostEng.Text = "For checking post-ENG files";
            this.rBtn_chkPostEng.UseVisualStyleBackColor = true;
            this.rBtn_chkPostEng.CheckedChanged += new System.EventHandler(this.rBtn_chkPostEng_CheckedChanged);
            // 
            // rBtn_preENG
            // 
            this.rBtn_preENG.AutoSize = true;
            this.rBtn_preENG.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_preENG.ForeColor = System.Drawing.Color.Cyan;
            this.rBtn_preENG.Location = new System.Drawing.Point(14, 3);
            this.rBtn_preENG.Name = "rBtn_preENG";
            this.rBtn_preENG.Size = new System.Drawing.Size(199, 20);
            this.rBtn_preENG.TabIndex = 0;
            this.rBtn_preENG.TabStop = true;
            this.rBtn_preENG.Text = "For pre-Eng source files";
            this.rBtn_preENG.UseVisualStyleBackColor = true;
            this.rBtn_preENG.CheckedChanged += new System.EventHandler(this.rBtn_preENG_CheckedChanged);
            // 
            // chkBox_onlyFilter
            // 
            this.chkBox_onlyFilter.AutoSize = true;
            this.chkBox_onlyFilter.Font = new System.Drawing.Font("幼圆", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_onlyFilter.ForeColor = System.Drawing.Color.Blue;
            this.chkBox_onlyFilter.Location = new System.Drawing.Point(9, 81);
            this.chkBox_onlyFilter.Name = "chkBox_onlyFilter";
            this.chkBox_onlyFilter.Size = new System.Drawing.Size(314, 17);
            this.chkBox_onlyFilter.TabIndex = 6;
            this.chkBox_onlyFilter.Text = "Only filter out need processed files";
            this.chkBox_onlyFilter.UseVisualStyleBackColor = true;
            this.chkBox_onlyFilter.CheckedChanged += new System.EventHandler(this.chkBox_onlyFilter_CheckedChanged);
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(9, 48);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(489, 22);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_run.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.Location = new System.Drawing.Point(522, 50);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(92, 56);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lb_info);
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lb_info
            // 
            this.lb_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_info.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_info.FormattingEnabled = true;
            this.lb_info.HorizontalScrollbar = true;
            this.lb_info.ItemHeight = 17;
            this.lb_info.Location = new System.Drawing.Point(6, 26);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(590, 208);
            this.lb_info.TabIndex = 0;
            // 
            // Form_addTagLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(626, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.grpBox_settings);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_addTagLine";
            this.Text = "Add Target Line";
            this.Load += new System.EventHandler(this.Form_addTagLine_Load);
            this.grpBox_settings.ResumeLayout(false);
            this.grpBox_settings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_info;
        private System.Windows.Forms.CheckBox chkBox_onlyFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtn_preENG;
        private System.Windows.Forms.RadioButton rBtn_chkPostEng;
    }
}