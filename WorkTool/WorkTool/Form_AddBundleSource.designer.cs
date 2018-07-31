namespace WorkTool
{
    partial class Form_AddBundleSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddBundleSource));
            this.btn_save = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lab_bundCount = new System.Windows.Forms.Label();
            this.tb_bundles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_foldCount = new System.Windows.Forms.Label();
            this.tb_folders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.timer_Init = new System.Windows.Forms.Timer(this.components);
            this.timer_scrSb = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(351, 280);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(93, 39);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.lab_bundCount);
            this.splitContainer1.Panel1.Controls.Add(this.tb_bundles);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.lab_foldCount);
            this.splitContainer1.Panel2.Controls.Add(this.tb_folders);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(607, 262);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 1;
            // 
            // lab_bundCount
            // 
            this.lab_bundCount.AutoSize = true;
            this.lab_bundCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_bundCount.ForeColor = System.Drawing.Color.Blue;
            this.lab_bundCount.Location = new System.Drawing.Point(75, 12);
            this.lab_bundCount.Name = "lab_bundCount";
            this.lab_bundCount.Size = new System.Drawing.Size(43, 17);
            this.lab_bundCount.TabIndex = 2;
            this.lab_bundCount.Text = "label3";
            // 
            // tb_bundles
            // 
            this.tb_bundles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_bundles.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_bundles.Location = new System.Drawing.Point(3, 32);
            this.tb_bundles.Multiline = true;
            this.tb_bundles.Name = "tb_bundles";
            this.tb_bundles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_bundles.Size = new System.Drawing.Size(407, 227);
            this.tb_bundles.TabIndex = 1;
            this.tb_bundles.TextChanged += new System.EventHandler(this.tb_bundles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bundles";
            // 
            // lab_foldCount
            // 
            this.lab_foldCount.AutoSize = true;
            this.lab_foldCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_foldCount.ForeColor = System.Drawing.Color.Blue;
            this.lab_foldCount.Location = new System.Drawing.Point(72, 12);
            this.lab_foldCount.Name = "lab_foldCount";
            this.lab_foldCount.Size = new System.Drawing.Size(43, 17);
            this.lab_foldCount.TabIndex = 2;
            this.lab_foldCount.Text = "label3";
            // 
            // tb_folders
            // 
            this.tb_folders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_folders.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_folders.Location = new System.Drawing.Point(3, 32);
            this.tb_folders.Multiline = true;
            this.tb_folders.Name = "tb_folders";
            this.tb_folders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_folders.Size = new System.Drawing.Size(184, 227);
            this.tb_folders.TabIndex = 1;
            this.tb_folders.TextChanged += new System.EventHandler(this.tb_folders_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folders";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(162, 280);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 39);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // timer_Init
            // 
            this.timer_Init.Interval = 1000;
            this.timer_Init.Tick += new System.EventHandler(this.timer_Init_Tick);
            // 
            // timer_scrSb
            // 
            this.timer_scrSb.Tick += new System.EventHandler(this.timer_scrSb_Tick);
            // 
            // Form_AddBundleSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 331);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_AddBundleSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bundle Source";
            this.Load += new System.EventHandler(this.Form_AddBundleSource_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_bundles;
        private System.Windows.Forms.TextBox tb_folders;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Timer timer_Init;
        private System.Windows.Forms.Label lab_bundCount;
        private System.Windows.Forms.Label lab_foldCount;
        private System.Windows.Forms.Timer timer_scrSb;
    }
}