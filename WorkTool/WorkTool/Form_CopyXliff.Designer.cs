namespace WorkTool
{
    partial class Form_CopyXliff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CopyXliff));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.ListBox();
            this.rbtn_sync = new System.Windows.Forms.RadioButton();
            this.rbtn_TM = new System.Windows.Forms.RadioButton();
            this.rbtn_xml = new System.Windows.Forms.RadioButton();
            this.comBox_sourceLang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_set = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_set.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Location:";
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(16, 34);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(484, 25);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_run.Font = new System.Drawing.Font("方正姚体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.Location = new System.Drawing.Point(531, 46);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(74, 68);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
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
            this.lb_info.Location = new System.Drawing.Point(12, 161);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(593, 157);
            this.lb_info.TabIndex = 3;
            // 
            // rbtn_sync
            // 
            this.rbtn_sync.AutoSize = true;
            this.rbtn_sync.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_sync.ForeColor = System.Drawing.Color.Green;
            this.rbtn_sync.Location = new System.Drawing.Point(16, 14);
            this.rbtn_sync.Name = "rbtn_sync";
            this.rbtn_sync.Size = new System.Drawing.Size(89, 20);
            this.rbtn_sync.TabIndex = 4;
            this.rbtn_sync.TabStop = true;
            this.rbtn_sync.Text = "Sync Xliff";
            this.rbtn_sync.UseVisualStyleBackColor = true;
            this.rbtn_sync.CheckedChanged += new System.EventHandler(this.rbtn_sync_CheckedChanged);
            // 
            // rbtn_TM
            // 
            this.rbtn_TM.AutoSize = true;
            this.rbtn_TM.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_TM.ForeColor = System.Drawing.Color.Green;
            this.rbtn_TM.Location = new System.Drawing.Point(163, 14);
            this.rbtn_TM.Name = "rbtn_TM";
            this.rbtn_TM.Size = new System.Drawing.Size(76, 20);
            this.rbtn_TM.TabIndex = 5;
            this.rbtn_TM.TabStop = true;
            this.rbtn_TM.Text = "TM Xliff";
            this.rbtn_TM.UseVisualStyleBackColor = true;
            this.rbtn_TM.CheckedChanged += new System.EventHandler(this.rbtn_TM_CheckedChanged);
            // 
            // rbtn_xml
            // 
            this.rbtn_xml.AutoSize = true;
            this.rbtn_xml.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_xml.ForeColor = System.Drawing.Color.Green;
            this.rbtn_xml.Location = new System.Drawing.Point(16, 40);
            this.rbtn_xml.Name = "rbtn_xml";
            this.rbtn_xml.Size = new System.Drawing.Size(145, 20);
            this.rbtn_xml.TabIndex = 6;
            this.rbtn_xml.TabStop = true;
            this.rbtn_xml.Text = "Translated Target";
            this.rbtn_xml.UseVisualStyleBackColor = true;
            this.rbtn_xml.CheckedChanged += new System.EventHandler(this.rbtn_xml_CheckedChanged);
            // 
            // comBox_sourceLang
            // 
            this.comBox_sourceLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox_sourceLang.DropDownHeight = 150;
            this.comBox_sourceLang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_sourceLang.ForeColor = System.Drawing.Color.Red;
            this.comBox_sourceLang.FormattingEnabled = true;
            this.comBox_sourceLang.IntegralHeight = false;
            this.comBox_sourceLang.Items.AddRange(new object[] {
            "cs-CZ",
            "da-DK",
            "de-DE",
            "en-US",
            "es-ES",
            "fr-FR",
            "id-ID",
            "it-IT",
            "ja-JP",
            "ko-KR",
            "nb-NO",
            "nl-NL",
            "pl-PL",
            "pt-BR",
            "ru-RU",
            "sv-SE",
            "th-TH",
            "tr-TR",
            "vi-VN",
            "zh-CN",
            "zh-TW"});
            this.comBox_sourceLang.Location = new System.Drawing.Point(352, 97);
            this.comBox_sourceLang.Name = "comBox_sourceLang";
            this.comBox_sourceLang.Size = new System.Drawing.Size(148, 26);
            this.comBox_sourceLang.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(349, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Source Language:";
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_set.Controls.Add(this.panel1);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Controls.Add(this.comBox_sourceLang);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.tb_path);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(513, 144);
            this.panel_set.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbtn_sync);
            this.panel1.Controls.Add(this.rbtn_TM);
            this.panel1.Controls.Add(this.rbtn_xml);
            this.panel1.Location = new System.Drawing.Point(16, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 70);
            this.panel1.TabIndex = 9;
            // 
            // Form_CopyXliff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 318);
            this.Controls.Add(this.panel_set);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.btn_run);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_CopyXliff";
            this.Text = "Copy Out Files from Project";
            this.Load += new System.EventHandler(this.Form_CopyXliff_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.ListBox lb_info;
        private System.Windows.Forms.RadioButton rbtn_sync;
        private System.Windows.Forms.RadioButton rbtn_TM;
        private System.Windows.Forms.RadioButton rbtn_xml;
        private System.Windows.Forms.ComboBox comBox_sourceLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Panel panel1;
    }
}