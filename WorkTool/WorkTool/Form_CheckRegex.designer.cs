namespace WorkTool
{
    partial class Form_CheckRegex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CheckRegex));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_regExpr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.btn_chk = new System.Windows.Forms.Button();
            this.lab_info = new System.Windows.Forms.Label();
            this.tb_matchText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regular Expressions :";
            // 
            // tb_regExpr
            // 
            this.tb_regExpr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_regExpr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_regExpr.Location = new System.Drawing.Point(12, 32);
            this.tb_regExpr.Name = "tb_regExpr";
            this.tb_regExpr.Size = new System.Drawing.Size(611, 23);
            this.tb_regExpr.TabIndex = 1;
            this.tb_regExpr.TextChanged += new System.EventHandler(this.tb_regExpr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text :";
            // 
            // tb_text
            // 
            this.tb_text.AcceptsReturn = true;
            this.tb_text.AcceptsTab = true;
            this.tb_text.AllowDrop = true;
            this.tb_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_text.Location = new System.Drawing.Point(4, 34);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_text.Size = new System.Drawing.Size(306, 253);
            this.tb_text.TabIndex = 3;
            this.tb_text.TextChanged += new System.EventHandler(this.tb_text_TextChanged);
            this.tb_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_text_KeyDown);
            // 
            // btn_chk
            // 
            this.btn_chk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_chk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chk.Location = new System.Drawing.Point(116, 61);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(97, 44);
            this.btn_chk.TabIndex = 4;
            this.btn_chk.Text = "Check";
            this.btn_chk.UseVisualStyleBackColor = false;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // lab_info
            // 
            this.lab_info.AutoSize = true;
            this.lab_info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_info.Location = new System.Drawing.Point(104, 7);
            this.lab_info.Name = "lab_info";
            this.lab_info.Size = new System.Drawing.Size(55, 21);
            this.lab_info.TabIndex = 5;
            this.lab_info.Text = "label3";
            // 
            // tb_matchText
            // 
            this.tb_matchText.AcceptsReturn = true;
            this.tb_matchText.AcceptsTab = true;
            this.tb_matchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_matchText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_matchText.Location = new System.Drawing.Point(3, 34);
            this.tb_matchText.Multiline = true;
            this.tb_matchText.Name = "tb_matchText";
            this.tb_matchText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_matchText.Size = new System.Drawing.Size(288, 253);
            this.tb_matchText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match Text:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 111);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.tb_text);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.tb_matchText);
            this.splitContainer1.Panel2.Controls.Add(this.lab_info);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(611, 290);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 8;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(410, 61);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 44);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form_CheckRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(635, 413);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.tb_regExpr);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_CheckRegex";
            this.Text = "Check Regex";
            this.Load += new System.EventHandler(this.Form_CheckRegex_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_regExpr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Button btn_chk;
        private System.Windows.Forms.Label lab_info;
        private System.Windows.Forms.TextBox tb_matchText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_clear;
    }
}