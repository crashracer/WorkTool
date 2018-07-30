namespace WorkTool
{
    partial class Form_regularFileContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_regularFileContent));
            this.grpBox_set = new System.Windows.Forms.GroupBox();
            this.tb_pathOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_OriginalSrc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBox_remNoupd = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.panel_proBar = new System.Windows.Forms.Panel();
            this.grpBox_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_set
            // 
            this.grpBox_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_set.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpBox_set.Controls.Add(this.tb_pathOut);
            this.grpBox_set.Controls.Add(this.label5);
            this.grpBox_set.Controls.Add(this.tb_OriginalSrc);
            this.grpBox_set.Controls.Add(this.label4);
            this.grpBox_set.Controls.Add(this.chkBox_remNoupd);
            this.grpBox_set.Controls.Add(this.label3);
            this.grpBox_set.Controls.Add(this.tb_type);
            this.grpBox_set.Controls.Add(this.label2);
            this.grpBox_set.Controls.Add(this.tb_path);
            this.grpBox_set.Controls.Add(this.label1);
            this.grpBox_set.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpBox_set.Location = new System.Drawing.Point(12, 12);
            this.grpBox_set.Name = "grpBox_set";
            this.grpBox_set.Size = new System.Drawing.Size(541, 295);
            this.grpBox_set.TabIndex = 0;
            this.grpBox_set.TabStop = false;
            this.grpBox_set.Text = "Settings";
            // 
            // tb_pathOut
            // 
            this.tb_pathOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathOut.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathOut.ForeColor = System.Drawing.Color.Purple;
            this.tb_pathOut.Location = new System.Drawing.Point(9, 156);
            this.tb_pathOut.Name = "tb_pathOut";
            this.tb_pathOut.Size = new System.Drawing.Size(526, 22);
            this.tb_pathOut.TabIndex = 10;
            this.tb_pathOut.TextChanged += new System.EventHandler(this.tb_pathOut_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Path Output:";
            // 
            // tb_OriginalSrc
            // 
            this.tb_OriginalSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_OriginalSrc.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_OriginalSrc.ForeColor = System.Drawing.Color.Navy;
            this.tb_OriginalSrc.Location = new System.Drawing.Point(9, 104);
            this.tb_OriginalSrc.Name = "tb_OriginalSrc";
            this.tb_OriginalSrc.Size = new System.Drawing.Size(526, 22);
            this.tb_OriginalSrc.TabIndex = 8;
            this.tb_OriginalSrc.TextChanged += new System.EventHandler(this.tb_OriginalSrc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Path Original Source:";
            // 
            // chkBox_remNoupd
            // 
            this.chkBox_remNoupd.AutoSize = true;
            this.chkBox_remNoupd.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_remNoupd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkBox_remNoupd.Location = new System.Drawing.Point(9, 248);
            this.chkBox_remNoupd.Name = "chkBox_remNoupd";
            this.chkBox_remNoupd.Size = new System.Drawing.Size(237, 21);
            this.chkBox_remNoupd.TabIndex = 6;
            this.chkBox_remNoupd.Text = "Remove no-updated segments";
            this.chkBox_remNoupd.UseVisualStyleBackColor = true;
            this.chkBox_remNoupd.CheckedChanged += new System.EventHandler(this.chkBox_remNoupd_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(129, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Separated with \';\'  like \"xlf;xml;txt\")";
            // 
            // tb_type
            // 
            this.tb_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_type.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_type.Location = new System.Drawing.Point(9, 210);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(389, 22);
            this.tb_type.TabIndex = 3;
            this.tb_type.TextChanged += new System.EventHandler(this.tb_type_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(6, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Type:";
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("楷体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_path.Location = new System.Drawing.Point(9, 52);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(526, 22);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Input:";
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.ForeColor = System.Drawing.Color.Maroon;
            this.btn_run.Location = new System.Drawing.Point(195, 366);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(157, 47);
            this.btn_run.TabIndex = 1;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // panel_proBar
            // 
            this.panel_proBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_proBar.Location = new System.Drawing.Point(12, 323);
            this.panel_proBar.Name = "panel_proBar";
            this.panel_proBar.Size = new System.Drawing.Size(541, 26);
            this.panel_proBar.TabIndex = 2;
            // 
            // Form_regularFileContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(565, 425);
            this.Controls.Add(this.panel_proBar);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.grpBox_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_regularFileContent";
            this.Text = "Regulate XLF for Sync";
            this.Load += new System.EventHandler(this.Form_regularFileContent_Load);
            this.grpBox_set.ResumeLayout(false);
            this.grpBox_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_set;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.CheckBox chkBox_remNoupd;
        private System.Windows.Forms.Panel panel_proBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_OriginalSrc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_pathOut;
    }
}