namespace WorkTool
{
    partial class Form_copyXliffToProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_copyXliffToProject));
            this.panel_set = new System.Windows.Forms.Panel();
            this.rBtn_unlocked = new System.Windows.Forms.RadioButton();
            this.rBtn_locked = new System.Windows.Forms.RadioButton();
            this.rBtn_normal = new System.Windows.Forms.RadioButton();
            this.tb_projLoca = new System.Windows.Forms.TextBox();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_copy = new System.Windows.Forms.Button();
            this.lab_info = new System.Windows.Forms.Label();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.rBtn_unlocked);
            this.panel_set.Controls.Add(this.rBtn_locked);
            this.panel_set.Controls.Add(this.rBtn_normal);
            this.panel_set.Controls.Add(this.tb_projLoca);
            this.panel_set.Controls.Add(this.tb_filePath);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(582, 171);
            this.panel_set.TabIndex = 0;
            // 
            // rBtn_unlocked
            // 
            this.rBtn_unlocked.AutoSize = true;
            this.rBtn_unlocked.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_unlocked.ForeColor = System.Drawing.Color.Teal;
            this.rBtn_unlocked.Location = new System.Drawing.Point(383, 132);
            this.rBtn_unlocked.Name = "rBtn_unlocked";
            this.rBtn_unlocked.Size = new System.Drawing.Size(151, 19);
            this.rBtn_unlocked.TabIndex = 6;
            this.rBtn_unlocked.TabStop = true;
            this.rBtn_unlocked.Text = "After Unlocked";
            this.rBtn_unlocked.UseVisualStyleBackColor = true;
            this.rBtn_unlocked.CheckedChanged += new System.EventHandler(this.rBtn_unlocked_CheckedChanged);
            // 
            // rBtn_locked
            // 
            this.rBtn_locked.AutoSize = true;
            this.rBtn_locked.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_locked.ForeColor = System.Drawing.Color.Teal;
            this.rBtn_locked.Location = new System.Drawing.Point(191, 132);
            this.rBtn_locked.Name = "rBtn_locked";
            this.rBtn_locked.Size = new System.Drawing.Size(133, 19);
            this.rBtn_locked.TabIndex = 5;
            this.rBtn_locked.TabStop = true;
            this.rBtn_locked.Text = "After Locked";
            this.rBtn_locked.UseVisualStyleBackColor = true;
            this.rBtn_locked.CheckedChanged += new System.EventHandler(this.rBtn_locked_CheckedChanged);
            // 
            // rBtn_normal
            // 
            this.rBtn_normal.AutoSize = true;
            this.rBtn_normal.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_normal.ForeColor = System.Drawing.Color.Teal;
            this.rBtn_normal.Location = new System.Drawing.Point(47, 132);
            this.rBtn_normal.Name = "rBtn_normal";
            this.rBtn_normal.Size = new System.Drawing.Size(79, 19);
            this.rBtn_normal.TabIndex = 4;
            this.rBtn_normal.TabStop = true;
            this.rBtn_normal.Text = "Normal";
            this.rBtn_normal.UseVisualStyleBackColor = true;
            this.rBtn_normal.CheckedChanged += new System.EventHandler(this.rBtn_normal_CheckedChanged);
            // 
            // tb_projLoca
            // 
            this.tb_projLoca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_projLoca.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_projLoca.ForeColor = System.Drawing.Color.Green;
            this.tb_projLoca.Location = new System.Drawing.Point(17, 93);
            this.tb_projLoca.Name = "tb_projLoca";
            this.tb_projLoca.Size = new System.Drawing.Size(547, 22);
            this.tb_projLoca.TabIndex = 3;
            this.tb_projLoca.TextChanged += new System.EventHandler(this.tb_projLoca_TextChanged);
            // 
            // tb_filePath
            // 
            this.tb_filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filePath.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filePath.ForeColor = System.Drawing.Color.Green;
            this.tb_filePath.Location = new System.Drawing.Point(17, 32);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(547, 22);
            this.tb_filePath.TabIndex = 2;
            this.tb_filePath.TextChanged += new System.EventHandler(this.tb_filePath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path:";
            // 
            // btn_copy
            // 
            this.btn_copy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_copy.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.ForeColor = System.Drawing.Color.Maroon;
            this.btn_copy.Location = new System.Drawing.Point(215, 247);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(146, 54);
            this.btn_copy.TabIndex = 1;
            this.btn_copy.Text = "COPY";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // lab_info
            // 
            this.lab_info.AutoSize = true;
            this.lab_info.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_info.ForeColor = System.Drawing.Color.Green;
            this.lab_info.Location = new System.Drawing.Point(28, 201);
            this.lab_info.Name = "lab_info";
            this.lab_info.Size = new System.Drawing.Size(46, 16);
            this.lab_info.TabIndex = 2;
            this.lab_info.Text = "label3";
            // 
            // Form_copyXliffToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(606, 313);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_copyXliffToProject";
            this.Text = "Copy Xliff into Project";
            this.Load += new System.EventHandler(this.Form_copyXliffToProject_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.TextBox tb_projLoca;
        private System.Windows.Forms.RadioButton rBtn_normal;
        private System.Windows.Forms.RadioButton rBtn_unlocked;
        private System.Windows.Forms.RadioButton rBtn_locked;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label lab_info;
    }
}