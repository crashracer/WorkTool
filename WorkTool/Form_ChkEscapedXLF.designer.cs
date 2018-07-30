namespace WorkTool
{
    partial class Form_ChkEscapedXLF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChkEscapedXLF));
            this.panel_set = new System.Windows.Forms.Panel();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chk = new System.Windows.Forms.Button();
            this.lab_proBar = new System.Windows.Forms.Label();
            this.proBar_pro = new System.Windows.Forms.ProgressBar();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_set.Controls.Add(this.tb_path);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(6, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(561, 74);
            this.panel_set.TabIndex = 0;
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(10, 33);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(544, 22);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Path:";
            // 
            // btn_chk
            // 
            this.btn_chk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_chk.Font = new System.Drawing.Font("华文新魏", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_chk.ForeColor = System.Drawing.Color.Teal;
            this.btn_chk.Location = new System.Drawing.Point(170, 168);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(216, 54);
            this.btn_chk.TabIndex = 1;
            this.btn_chk.Text = "CHECK";
            this.btn_chk.UseVisualStyleBackColor = true;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // lab_proBar
            // 
            this.lab_proBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_proBar.AutoSize = true;
            this.lab_proBar.ForeColor = System.Drawing.Color.Lime;
            this.lab_proBar.Location = new System.Drawing.Point(507, 103);
            this.lab_proBar.Name = "lab_proBar";
            this.lab_proBar.Size = new System.Drawing.Size(53, 20);
            this.lab_proBar.TabIndex = 3;
            this.lab_proBar.Text = "label2";
            // 
            // proBar_pro
            // 
            this.proBar_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_pro.Location = new System.Drawing.Point(16, 103);
            this.proBar_pro.Name = "proBar_pro";
            this.proBar_pro.Size = new System.Drawing.Size(473, 23);
            this.proBar_pro.TabIndex = 4;
            // 
            // Form_ChkEscapedXLF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(572, 275);
            this.Controls.Add(this.proBar_pro);
            this.Controls.Add(this.lab_proBar);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ChkEscapedXLF";
            this.Text = "Check Escaped in XLF";
            this.Load += new System.EventHandler(this.Form_ChkEscapedXLF_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Label lab_proBar;
        private System.Windows.Forms.ProgressBar proBar_pro;
    }
}