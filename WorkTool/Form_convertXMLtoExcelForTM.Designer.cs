namespace WorkTool
{
    partial class Form_convertXMLtoExcelForTM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_convertXMLtoExcelForTM));
            this.panel_set = new System.Windows.Forms.Panel();
            this.comBox_srcLang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pathIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.proBar_files = new System.Windows.Forms.ProgressBar();
            this.proBar_folders = new System.Windows.Forms.ProgressBar();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.Thistle;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.comBox_srcLang);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.tb_pathIn);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(496, 118);
            this.panel_set.TabIndex = 0;
            // 
            // comBox_srcLang
            // 
            this.comBox_srcLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox_srcLang.DropDownHeight = 150;
            this.comBox_srcLang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox_srcLang.ForeColor = System.Drawing.Color.Teal;
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
            this.comBox_srcLang.Location = new System.Drawing.Point(325, 79);
            this.comBox_srcLang.Name = "comBox_srcLang";
            this.comBox_srcLang.Size = new System.Drawing.Size(121, 26);
            this.comBox_srcLang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(321, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Source Language:";
            // 
            // tb_pathIn
            // 
            this.tb_pathIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathIn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathIn.ForeColor = System.Drawing.Color.Navy;
            this.tb_pathIn.Location = new System.Drawing.Point(6, 30);
            this.tb_pathIn.Name = "tb_pathIn";
            this.tb_pathIn.Size = new System.Drawing.Size(483, 23);
            this.tb_pathIn.TabIndex = 1;
            this.tb_pathIn.TextChanged += new System.EventHandler(this.tb_pathIn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Input:";
            // 
            // btn_convert
            // 
            this.btn_convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_convert.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_convert.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_convert.Location = new System.Drawing.Point(198, 232);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(114, 44);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // proBar_files
            // 
            this.proBar_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_files.Location = new System.Drawing.Point(12, 136);
            this.proBar_files.Name = "proBar_files";
            this.proBar_files.Size = new System.Drawing.Size(496, 23);
            this.proBar_files.TabIndex = 3;
            // 
            // proBar_folders
            // 
            this.proBar_folders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_folders.Location = new System.Drawing.Point(12, 165);
            this.proBar_folders.Name = "proBar_folders";
            this.proBar_folders.Size = new System.Drawing.Size(496, 23);
            this.proBar_folders.TabIndex = 4;
            // 
            // Form_convertXMLtoExcelForTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(520, 301);
            this.Controls.Add(this.proBar_folders);
            this.Controls.Add(this.proBar_files);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_convertXMLtoExcelForTM";
            this.Text = "Convert Passolo exported XML to XLF for TM";
            this.Load += new System.EventHandler(this.Form_convertXMLtoExcelForTM_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pathIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBox_srcLang;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.ProgressBar proBar_files;
        private System.Windows.Forms.ProgressBar proBar_folders;
    }
}