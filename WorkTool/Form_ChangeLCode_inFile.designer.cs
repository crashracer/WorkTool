namespace WorkTool
{
    partial class Form_ChangeLCode_inFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChangeLCode_inFile));
            this.label1 = new System.Windows.Forms.Label();
            this.chkBox_subfolder = new System.Windows.Forms.CheckBox();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.timer_Change = new System.Windows.Forms.Timer(this.components);
            this.panel_set = new System.Windows.Forms.Panel();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Path:";
            // 
            // chkBox_subfolder
            // 
            this.chkBox_subfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_subfolder.AutoSize = true;
            this.chkBox_subfolder.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_subfolder.Location = new System.Drawing.Point(406, 7);
            this.chkBox_subfolder.Name = "chkBox_subfolder";
            this.chkBox_subfolder.Size = new System.Drawing.Size(98, 19);
            this.chkBox_subfolder.TabIndex = 1;
            this.chkBox_subfolder.Text = "Subfolder";
            this.chkBox_subfolder.UseVisualStyleBackColor = true;
            this.chkBox_subfolder.CheckedChanged += new System.EventHandler(this.chkBox_subfolder_CheckedChanged);
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(3, 32);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(510, 23);
            this.tb_path.TabIndex = 2;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_run.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.ForeColor = System.Drawing.Color.White;
            this.btn_run.Location = new System.Drawing.Point(200, 128);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(116, 56);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // timer_Change
            // 
            this.timer_Change.Interval = 1000;
            this.timer_Change.Tick += new System.EventHandler(this.timer_Change_Tick);
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Controls.Add(this.tb_path);
            this.panel_set.Controls.Add(this.chkBox_subfolder);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(516, 87);
            this.panel_set.TabIndex = 4;
            // 
            // Form_ChangeLCode_inFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 205);
            this.Controls.Add(this.panel_set);
            this.Controls.Add(this.btn_run);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ChangeLCode_inFile";
            this.Text = "Change Language/Locale Code in File";
            this.Load += new System.EventHandler(this.Form_ChangeLCode_inFile_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBox_subfolder;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Timer timer_Change;
        private System.Windows.Forms.Panel panel_set;
    }
}