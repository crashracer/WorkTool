namespace WorkTool
{
    partial class Form_ReplaceForTM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReplaceForTM));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.grpBox_settings = new System.Windows.Forms.GroupBox();
            this.panel_sourceLang = new System.Windows.Forms.Panel();
            this.comBox_srcLang = new System.Windows.Forms.ComboBox();
            this.lab_srcLang = new System.Windows.Forms.Label();
            this.rdbtn_SignOff = new System.Windows.Forms.RadioButton();
            this.rdbtn_xliff = new System.Windows.Forms.RadioButton();
            this.rdbtn_xml = new System.Windows.Forms.RadioButton();
            this.btn_replace = new System.Windows.Forms.Button();
            this.grpBox_settings.SuspendLayout();
            this.panel_sourceLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Input:";
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(18, 51);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(552, 25);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // grpBox_settings
            // 
            this.grpBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_settings.BackColor = System.Drawing.Color.CadetBlue;
            this.grpBox_settings.Controls.Add(this.panel_sourceLang);
            this.grpBox_settings.Controls.Add(this.rdbtn_SignOff);
            this.grpBox_settings.Controls.Add(this.rdbtn_xliff);
            this.grpBox_settings.Controls.Add(this.rdbtn_xml);
            this.grpBox_settings.Controls.Add(this.label1);
            this.grpBox_settings.Controls.Add(this.tb_path);
            this.grpBox_settings.Location = new System.Drawing.Point(12, 12);
            this.grpBox_settings.Name = "grpBox_settings";
            this.grpBox_settings.Size = new System.Drawing.Size(587, 169);
            this.grpBox_settings.TabIndex = 2;
            this.grpBox_settings.TabStop = false;
            this.grpBox_settings.Text = "Settings";
            // 
            // panel_sourceLang
            // 
            this.panel_sourceLang.Controls.Add(this.comBox_srcLang);
            this.panel_sourceLang.Controls.Add(this.lab_srcLang);
            this.panel_sourceLang.Location = new System.Drawing.Point(419, 92);
            this.panel_sourceLang.Name = "panel_sourceLang";
            this.panel_sourceLang.Size = new System.Drawing.Size(151, 54);
            this.panel_sourceLang.TabIndex = 5;
            // 
            // comBox_srcLang
            // 
            this.comBox_srcLang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.comBox_srcLang.DropDownHeight = 150;
            this.comBox_srcLang.ForeColor = System.Drawing.Color.Red;
            this.comBox_srcLang.FormattingEnabled = true;
            this.comBox_srcLang.IntegralHeight = false;
            this.comBox_srcLang.Items.AddRange(new object[] {
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
            this.comBox_srcLang.Location = new System.Drawing.Point(0, 26);
            this.comBox_srcLang.Name = "comBox_srcLang";
            this.comBox_srcLang.Size = new System.Drawing.Size(151, 28);
            this.comBox_srcLang.TabIndex = 1;
            // 
            // lab_srcLang
            // 
            this.lab_srcLang.AutoSize = true;
            this.lab_srcLang.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_srcLang.ForeColor = System.Drawing.Color.Yellow;
            this.lab_srcLang.Location = new System.Drawing.Point(0, 0);
            this.lab_srcLang.Name = "lab_srcLang";
            this.lab_srcLang.Size = new System.Drawing.Size(135, 20);
            this.lab_srcLang.TabIndex = 0;
            this.lab_srcLang.Text = "Source Language";
            // 
            // rdbtn_SignOff
            // 
            this.rdbtn_SignOff.AutoSize = true;
            this.rdbtn_SignOff.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbtn_SignOff.ForeColor = System.Drawing.Color.Navy;
            this.rdbtn_SignOff.Location = new System.Drawing.Point(239, 92);
            this.rdbtn_SignOff.Name = "rdbtn_SignOff";
            this.rdbtn_SignOff.Size = new System.Drawing.Size(90, 23);
            this.rdbtn_SignOff.TabIndex = 4;
            this.rdbtn_SignOff.TabStop = true;
            this.rdbtn_SignOff.Text = "SignedOff";
            this.rdbtn_SignOff.UseVisualStyleBackColor = true;
            this.rdbtn_SignOff.CheckedChanged += new System.EventHandler(this.rdbtn_SignOff_CheckedChanged);
            // 
            // rdbtn_xliff
            // 
            this.rdbtn_xliff.AutoSize = true;
            this.rdbtn_xliff.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbtn_xliff.ForeColor = System.Drawing.Color.Navy;
            this.rdbtn_xliff.Location = new System.Drawing.Point(141, 92);
            this.rdbtn_xliff.Name = "rdbtn_xliff";
            this.rdbtn_xliff.Size = new System.Drawing.Size(50, 23);
            this.rdbtn_xliff.TabIndex = 3;
            this.rdbtn_xliff.TabStop = true;
            this.rdbtn_xliff.Text = "xliff";
            this.rdbtn_xliff.UseVisualStyleBackColor = true;
            this.rdbtn_xliff.CheckedChanged += new System.EventHandler(this.rdbtn_xliff_CheckedChanged);
            // 
            // rdbtn_xml
            // 
            this.rdbtn_xml.AutoSize = true;
            this.rdbtn_xml.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdbtn_xml.ForeColor = System.Drawing.Color.Navy;
            this.rdbtn_xml.Location = new System.Drawing.Point(36, 92);
            this.rdbtn_xml.Name = "rdbtn_xml";
            this.rdbtn_xml.Size = new System.Drawing.Size(49, 23);
            this.rdbtn_xml.TabIndex = 2;
            this.rdbtn_xml.TabStop = true;
            this.rdbtn_xml.Text = "xml";
            this.rdbtn_xml.UseVisualStyleBackColor = true;
            this.rdbtn_xml.CheckedChanged += new System.EventHandler(this.rdbtn_xml_CheckedChanged);
            // 
            // btn_replace
            // 
            this.btn_replace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_replace.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replace.Location = new System.Drawing.Point(239, 248);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(145, 46);
            this.btn_replace.TabIndex = 3;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // Form_ReplaceForTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 306);
            this.Controls.Add(this.btn_replace);
            this.Controls.Add(this.grpBox_settings);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ReplaceForTM";
            this.Text = "Replace For TM";
            this.Load += new System.EventHandler(this.Form_ReplaceForTM_Load);
            this.grpBox_settings.ResumeLayout(false);
            this.grpBox_settings.PerformLayout();
            this.panel_sourceLang.ResumeLayout(false);
            this.panel_sourceLang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.GroupBox grpBox_settings;
        private System.Windows.Forms.RadioButton rdbtn_xml;
        private System.Windows.Forms.RadioButton rdbtn_xliff;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.RadioButton rdbtn_SignOff;
        private System.Windows.Forms.Panel panel_sourceLang;
        private System.Windows.Forms.Label lab_srcLang;
        private System.Windows.Forms.ComboBox comBox_srcLang;
    }
}