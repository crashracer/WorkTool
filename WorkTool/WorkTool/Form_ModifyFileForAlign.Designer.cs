namespace WorkTool
{
    partial class Form_ModifyFileForAlign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModifyFileForAlign));
            this.panel_set = new System.Windows.Forms.Panel();
            this.rBtn_xliff = new System.Windows.Forms.RadioButton();
            this.rBtn_XML = new System.Windows.Forms.RadioButton();
            this.rBtn_TTX = new System.Windows.Forms.RadioButton();
            this.tb_pathOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pathIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.tabControl_proces = new System.Windows.Forms.TabControl();
            this.tabPag_align = new System.Windows.Forms.TabPage();
            this.tabPag_preENG = new System.Windows.Forms.TabPage();
            this.btn_run2 = new System.Windows.Forms.Button();
            this.panel_set2 = new System.Windows.Forms.Panel();
            this.tb_pathOut2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pathIn2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_proBar = new System.Windows.Forms.Panel();
            this.panel_set.SuspendLayout();
            this.tabControl_proces.SuspendLayout();
            this.tabPag_align.SuspendLayout();
            this.tabPag_preENG.SuspendLayout();
            this.panel_set2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_set.Controls.Add(this.rBtn_xliff);
            this.panel_set.Controls.Add(this.rBtn_XML);
            this.panel_set.Controls.Add(this.rBtn_TTX);
            this.panel_set.Controls.Add(this.tb_pathOut);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.tb_pathIn);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(6, 6);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(600, 131);
            this.panel_set.TabIndex = 0;
            // 
            // rBtn_xliff
            // 
            this.rBtn_xliff.AutoSize = true;
            this.rBtn_xliff.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_xliff.ForeColor = System.Drawing.Color.Purple;
            this.rBtn_xliff.Location = new System.Drawing.Point(365, 69);
            this.rBtn_xliff.Name = "rBtn_xliff";
            this.rBtn_xliff.Size = new System.Drawing.Size(89, 17);
            this.rBtn_xliff.TabIndex = 6;
            this.rBtn_xliff.TabStop = true;
            this.rBtn_xliff.Text = "sdlxliff";
            this.rBtn_xliff.UseVisualStyleBackColor = true;
            this.rBtn_xliff.CheckedChanged += new System.EventHandler(this.rBtn_xliff_CheckedChanged);
            // 
            // rBtn_XML
            // 
            this.rBtn_XML.AutoSize = true;
            this.rBtn_XML.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_XML.ForeColor = System.Drawing.Color.Purple;
            this.rBtn_XML.Location = new System.Drawing.Point(271, 69);
            this.rBtn_XML.Name = "rBtn_XML";
            this.rBtn_XML.Size = new System.Drawing.Size(49, 17);
            this.rBtn_XML.TabIndex = 5;
            this.rBtn_XML.TabStop = true;
            this.rBtn_XML.Text = "XML";
            this.rBtn_XML.UseVisualStyleBackColor = true;
            this.rBtn_XML.CheckedChanged += new System.EventHandler(this.rBtn_XML_CheckedChanged);
            // 
            // rBtn_TTX
            // 
            this.rBtn_TTX.AutoSize = true;
            this.rBtn_TTX.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_TTX.ForeColor = System.Drawing.Color.Purple;
            this.rBtn_TTX.Location = new System.Drawing.Point(176, 69);
            this.rBtn_TTX.Name = "rBtn_TTX";
            this.rBtn_TTX.Size = new System.Drawing.Size(49, 17);
            this.rBtn_TTX.TabIndex = 4;
            this.rBtn_TTX.TabStop = true;
            this.rBtn_TTX.Text = "TTX";
            this.rBtn_TTX.UseVisualStyleBackColor = true;
            this.rBtn_TTX.CheckedChanged += new System.EventHandler(this.rBtn_TTX_CheckedChanged);
            // 
            // tb_pathOut
            // 
            this.tb_pathOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathOut.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathOut.ForeColor = System.Drawing.Color.Teal;
            this.tb_pathOut.Location = new System.Drawing.Point(8, 93);
            this.tb_pathOut.Name = "tb_pathOut";
            this.tb_pathOut.Size = new System.Drawing.Size(584, 23);
            this.tb_pathOut.TabIndex = 3;
            this.tb_pathOut.TextChanged += new System.EventHandler(this.tb_pathOut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path Output:";
            // 
            // tb_pathIn
            // 
            this.tb_pathIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathIn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tb_pathIn.Location = new System.Drawing.Point(8, 33);
            this.tb_pathIn.Name = "tb_pathIn";
            this.tb_pathIn.Size = new System.Drawing.Size(584, 23);
            this.tb_pathIn.TabIndex = 1;
            this.tb_pathIn.TextChanged += new System.EventHandler(this.tb_pathIn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Input:";
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_run.Location = new System.Drawing.Point(226, 157);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(142, 48);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // tabControl_proces
            // 
            this.tabControl_proces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_proces.Controls.Add(this.tabPag_align);
            this.tabControl_proces.Controls.Add(this.tabPag_preENG);
            this.tabControl_proces.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_proces.Location = new System.Drawing.Point(12, 12);
            this.tabControl_proces.Name = "tabControl_proces";
            this.tabControl_proces.SelectedIndex = 0;
            this.tabControl_proces.Size = new System.Drawing.Size(624, 315);
            this.tabControl_proces.TabIndex = 3;
            // 
            // tabPag_align
            // 
            this.tabPag_align.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPag_align.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPag_align.Controls.Add(this.panel_set);
            this.tabPag_align.Controls.Add(this.btn_run);
            this.tabPag_align.Location = new System.Drawing.Point(4, 27);
            this.tabPag_align.Name = "tabPag_align";
            this.tabPag_align.Padding = new System.Windows.Forms.Padding(3);
            this.tabPag_align.Size = new System.Drawing.Size(616, 284);
            this.tabPag_align.TabIndex = 0;
            this.tabPag_align.Text = "Align Files";
            // 
            // tabPag_preENG
            // 
            this.tabPag_preENG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tabPag_preENG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPag_preENG.Controls.Add(this.btn_run2);
            this.tabPag_preENG.Controls.Add(this.panel_set2);
            this.tabPag_preENG.Location = new System.Drawing.Point(4, 27);
            this.tabPag_preENG.Name = "tabPag_preENG";
            this.tabPag_preENG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPag_preENG.Size = new System.Drawing.Size(616, 284);
            this.tabPag_preENG.TabIndex = 1;
            this.tabPag_preENG.Text = "Pre-ENG XML Files";
            // 
            // btn_run2
            // 
            this.btn_run2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run2.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run2.ForeColor = System.Drawing.Color.Teal;
            this.btn_run2.Location = new System.Drawing.Point(231, 214);
            this.btn_run2.Name = "btn_run2";
            this.btn_run2.Size = new System.Drawing.Size(125, 48);
            this.btn_run2.TabIndex = 1;
            this.btn_run2.Text = "RUN";
            this.btn_run2.UseVisualStyleBackColor = true;
            this.btn_run2.Click += new System.EventHandler(this.btn_run2_Click);
            // 
            // panel_set2
            // 
            this.panel_set2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_set2.Controls.Add(this.tb_pathOut2);
            this.panel_set2.Controls.Add(this.label4);
            this.panel_set2.Controls.Add(this.tb_pathIn2);
            this.panel_set2.Controls.Add(this.label3);
            this.panel_set2.Location = new System.Drawing.Point(6, 6);
            this.panel_set2.Name = "panel_set2";
            this.panel_set2.Size = new System.Drawing.Size(600, 141);
            this.panel_set2.TabIndex = 0;
            // 
            // tb_pathOut2
            // 
            this.tb_pathOut2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathOut2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathOut2.ForeColor = System.Drawing.Color.Purple;
            this.tb_pathOut2.Location = new System.Drawing.Point(16, 98);
            this.tb_pathOut2.Name = "tb_pathOut2";
            this.tb_pathOut2.Size = new System.Drawing.Size(570, 23);
            this.tb_pathOut2.TabIndex = 3;
            this.tb_pathOut2.TextChanged += new System.EventHandler(this.tb_pathOut2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Path Out:";
            // 
            // tb_pathIn2
            // 
            this.tb_pathIn2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathIn2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathIn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_pathIn2.Location = new System.Drawing.Point(16, 35);
            this.tb_pathIn2.Name = "tb_pathIn2";
            this.tb_pathIn2.Size = new System.Drawing.Size(570, 23);
            this.tb_pathIn2.TabIndex = 1;
            this.tb_pathIn2.TextChanged += new System.EventHandler(this.tb_pathIn2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Path In:";
            // 
            // panel_proBar
            // 
            this.panel_proBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_proBar.Location = new System.Drawing.Point(16, 343);
            this.panel_proBar.Name = "panel_proBar";
            this.panel_proBar.Size = new System.Drawing.Size(616, 29);
            this.panel_proBar.TabIndex = 4;
            // 
            // Form_ModifyFileForAlign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(648, 393);
            this.Controls.Add(this.panel_proBar);
            this.Controls.Add(this.tabControl_proces);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ModifyFileForAlign";
            this.Text = "Modify File for Align";
            this.Load += new System.EventHandler(this.Form_ModifyFileForAlign_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.tabControl_proces.ResumeLayout(false);
            this.tabPag_align.ResumeLayout(false);
            this.tabPag_preENG.ResumeLayout(false);
            this.panel_set2.ResumeLayout(false);
            this.panel_set2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pathIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pathOut;
        private System.Windows.Forms.RadioButton rBtn_xliff;
        private System.Windows.Forms.RadioButton rBtn_XML;
        private System.Windows.Forms.RadioButton rBtn_TTX;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.TabControl tabControl_proces;
        private System.Windows.Forms.TabPage tabPag_align;
        private System.Windows.Forms.TabPage tabPag_preENG;
        private System.Windows.Forms.Panel panel_set2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pathIn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pathOut2;
        private System.Windows.Forms.Button btn_run2;
        private System.Windows.Forms.Panel panel_proBar;

    }
}