namespace WorkTool
{
    partial class Form_ChkCopyrightSymbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChkCopyrightSymbol));
            this.panel_set = new System.Windows.Forms.Panel();
            this.tb_pathOut = new System.Windows.Forms.TextBox();
            this.tb_pathIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_proBar = new System.Windows.Forms.Panel();
            this.btn_chk = new System.Windows.Forms.Button();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.Silver;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.tb_pathOut);
            this.panel_set.Controls.Add(this.tb_pathIn);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(544, 132);
            this.panel_set.TabIndex = 0;
            // 
            // tb_pathOut
            // 
            this.tb_pathOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathOut.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pathOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tb_pathOut.Location = new System.Drawing.Point(12, 94);
            this.tb_pathOut.Name = "tb_pathOut";
            this.tb_pathOut.Size = new System.Drawing.Size(514, 22);
            this.tb_pathOut.TabIndex = 3;
            this.tb_pathOut.TextChanged += new System.EventHandler(this.tb_pathOut_TextChanged);
            // 
            // tb_pathIn
            // 
            this.tb_pathIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathIn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pathIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_pathIn.Location = new System.Drawing.Point(12, 34);
            this.tb_pathIn.Name = "tb_pathIn";
            this.tb_pathIn.Size = new System.Drawing.Size(514, 22);
            this.tb_pathIn.TabIndex = 2;
            this.tb_pathIn.TextChanged += new System.EventHandler(this.tb_pathIn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path Out:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path In:";
            // 
            // panel_proBar
            // 
            this.panel_proBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_proBar.Location = new System.Drawing.Point(12, 164);
            this.panel_proBar.Name = "panel_proBar";
            this.panel_proBar.Size = new System.Drawing.Size(544, 25);
            this.panel_proBar.TabIndex = 1;
            // 
            // btn_chk
            // 
            this.btn_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chk.BackColor = System.Drawing.Color.Teal;
            this.btn_chk.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_chk.Location = new System.Drawing.Point(218, 226);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(109, 44);
            this.btn_chk.TabIndex = 2;
            this.btn_chk.Text = "CHECK";
            this.btn_chk.UseVisualStyleBackColor = false;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // Form_ChkCopyrightSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(568, 312);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.panel_proBar);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ChkCopyrightSymbol";
            this.Text = "Check Copyright Symbol";
            this.Load += new System.EventHandler(this.Form_ChkCopyrightSymbol_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pathIn;
        private System.Windows.Forms.TextBox tb_pathOut;
        private System.Windows.Forms.Panel panel_proBar;
        private System.Windows.Forms.Button btn_chk;
    }
}