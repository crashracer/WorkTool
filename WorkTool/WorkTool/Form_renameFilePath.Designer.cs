namespace WorkTool
{
    partial class Form_renameFilePath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_renameFilePath));
            this.panel_set = new System.Windows.Forms.Panel();
            this.tb_Separator = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_fileType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.btn_restore = new System.Windows.Forms.Button();
            this.lab_info = new System.Windows.Forms.Label();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.tb_Separator);
            this.panel_set.Controls.Add(this.label4);
            this.panel_set.Controls.Add(this.tb_fileType);
            this.panel_set.Controls.Add(this.label3);
            this.panel_set.Controls.Add(this.tb_output);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.tb_input);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(495, 164);
            this.panel_set.TabIndex = 0;
            // 
            // tb_Separator
            // 
            this.tb_Separator.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Separator.Location = new System.Drawing.Point(379, 123);
            this.tb_Separator.MaxLength = 1;
            this.tb_Separator.Name = "tb_Separator";
            this.tb_Separator.Size = new System.Drawing.Size(76, 22);
            this.tb_Separator.TabIndex = 7;
            this.tb_Separator.TextChanged += new System.EventHandler(this.tb_Separator_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(284, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Separator:";
            // 
            // tb_fileType
            // 
            this.tb_fileType.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_fileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tb_fileType.Location = new System.Drawing.Point(130, 123);
            this.tb_fileType.Name = "tb_fileType";
            this.tb_fileType.Size = new System.Drawing.Size(107, 22);
            this.tb_fileType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "File Type:";
            // 
            // tb_output
            // 
            this.tb_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_output.Location = new System.Drawing.Point(16, 86);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(461, 23);
            this.tb_output.TabIndex = 3;
            this.tb_output.TextChanged += new System.EventHandler(this.tb_output_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output:";
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_input.ForeColor = System.Drawing.Color.Blue;
            this.tb_input.Location = new System.Drawing.Point(16, 30);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(461, 23);
            this.tb_input.TabIndex = 1;
            this.tb_input.TextChanged += new System.EventHandler(this.tb_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // btn_rename
            // 
            this.btn_rename.BackColor = System.Drawing.Color.Moccasin;
            this.btn_rename.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rename.Location = new System.Drawing.Point(144, 241);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(97, 40);
            this.btn_rename.TabIndex = 2;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = false;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restore.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_restore.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_restore.ForeColor = System.Drawing.Color.Purple;
            this.btn_restore.Location = new System.Drawing.Point(269, 241);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(97, 40);
            this.btn_restore.TabIndex = 3;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // lab_info
            // 
            this.lab_info.AutoSize = true;
            this.lab_info.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_info.ForeColor = System.Drawing.Color.Green;
            this.lab_info.Location = new System.Drawing.Point(27, 195);
            this.lab_info.Name = "lab_info";
            this.lab_info.Size = new System.Drawing.Size(52, 18);
            this.lab_info.TabIndex = 4;
            this.lab_info.Text = "label5";
            // 
            // Form_renameFilePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 309);
            this.Controls.Add(this.lab_info);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_renameFilePath";
            this.Text = "Rename File Path";
            this.Load += new System.EventHandler(this.Form_renameFilePath_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.TextBox tb_fileType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Separator;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Label lab_info;
    }
}