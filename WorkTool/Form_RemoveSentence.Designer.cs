namespace WorkTool
{
    partial class Form_RemoveSentence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RemoveSentence));
            this.grpBox_settings = new System.Windows.Forms.GroupBox();
            this.chkBox_subfolder = new System.Windows.Forms.CheckBox();
            this.btn_addsen = new System.Windows.Forms.Button();
            this.tb_filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_info = new System.Windows.Forms.GroupBox();
            this.lb_info = new System.Windows.Forms.ListBox();
            this.timer_readCfg = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.timer_listFile = new System.Windows.Forms.Timer(this.components);
            this.timer_remove = new System.Windows.Forms.Timer(this.components);
            this.grpBox_settings.SuspendLayout();
            this.grpBox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_settings
            // 
            this.grpBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_settings.BackColor = System.Drawing.Color.SteelBlue;
            this.grpBox_settings.Controls.Add(this.chkBox_subfolder);
            this.grpBox_settings.Controls.Add(this.btn_addsen);
            this.grpBox_settings.Controls.Add(this.tb_filepath);
            this.grpBox_settings.Controls.Add(this.label1);
            this.grpBox_settings.Location = new System.Drawing.Point(12, 12);
            this.grpBox_settings.Name = "grpBox_settings";
            this.grpBox_settings.Size = new System.Drawing.Size(549, 101);
            this.grpBox_settings.TabIndex = 0;
            this.grpBox_settings.TabStop = false;
            this.grpBox_settings.Text = "Settings";
            // 
            // chkBox_subfolder
            // 
            this.chkBox_subfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_subfolder.AutoSize = true;
            this.chkBox_subfolder.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_subfolder.Location = new System.Drawing.Point(426, 65);
            this.chkBox_subfolder.Name = "chkBox_subfolder";
            this.chkBox_subfolder.Size = new System.Drawing.Size(98, 19);
            this.chkBox_subfolder.TabIndex = 3;
            this.chkBox_subfolder.Text = "Subfolder";
            this.chkBox_subfolder.UseVisualStyleBackColor = true;
            this.chkBox_subfolder.CheckedChanged += new System.EventHandler(this.chkBox_subfolder_CheckedChanged);
            // 
            // btn_addsen
            // 
            this.btn_addsen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_addsen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addsen.Location = new System.Drawing.Point(6, 55);
            this.btn_addsen.Name = "btn_addsen";
            this.btn_addsen.Size = new System.Drawing.Size(129, 37);
            this.btn_addsen.TabIndex = 2;
            this.btn_addsen.Text = "Add Sentence";
            this.btn_addsen.UseVisualStyleBackColor = false;
            this.btn_addsen.Click += new System.EventHandler(this.btn_addsen_Click);
            // 
            // tb_filepath
            // 
            this.tb_filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filepath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_filepath.Location = new System.Drawing.Point(91, 26);
            this.tb_filepath.Name = "tb_filepath";
            this.tb_filepath.Size = new System.Drawing.Size(452, 23);
            this.tb_filepath.TabIndex = 1;
            this.tb_filepath.TextChanged += new System.EventHandler(this.tb_filepath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FilePath:";
            // 
            // grpBox_info
            // 
            this.grpBox_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_info.BackColor = System.Drawing.Color.Teal;
            this.grpBox_info.Controls.Add(this.lb_info);
            this.grpBox_info.Location = new System.Drawing.Point(12, 165);
            this.grpBox_info.Name = "grpBox_info";
            this.grpBox_info.Size = new System.Drawing.Size(549, 203);
            this.grpBox_info.TabIndex = 1;
            this.grpBox_info.TabStop = false;
            this.grpBox_info.Text = "Information";
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
            this.lb_info.Size = new System.Drawing.Size(537, 157);
            this.lb_info.TabIndex = 0;
            // 
            // timer_readCfg
            // 
            this.timer_readCfg.Interval = 1000;
            this.timer_readCfg.Tick += new System.EventHandler(this.timer_readCfg_Tick);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_start.Font = new System.Drawing.Font("方正姚体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(186, 119);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(138, 40);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer_listFile
            // 
            this.timer_listFile.Interval = 1000;
            this.timer_listFile.Tick += new System.EventHandler(this.timer_listFile_Tick);
            // 
            // timer_remove
            // 
            this.timer_remove.Interval = 1000;
            this.timer_remove.Tick += new System.EventHandler(this.timer_remove_Tick);
            // 
            // Form_RemoveSentence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 380);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.grpBox_info);
            this.Controls.Add(this.grpBox_settings);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_RemoveSentence";
            this.Text = "Remove Sentence";
            this.Load += new System.EventHandler(this.Form_RemoveSentence_Load);
            this.grpBox_settings.ResumeLayout(false);
            this.grpBox_settings.PerformLayout();
            this.grpBox_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_settings;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addsen;
        private System.Windows.Forms.CheckBox chkBox_subfolder;
        private System.Windows.Forms.GroupBox grpBox_info;
        private System.Windows.Forms.ListBox lb_info;
        private System.Windows.Forms.Timer timer_readCfg;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer_listFile;
        private System.Windows.Forms.Timer timer_remove;
    }
}