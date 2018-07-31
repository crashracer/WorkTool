namespace WorkTool
{
    partial class Form_moveBundle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_moveBundle));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_basePath = new System.Windows.Forms.TextBox();
            this.grpBox_settings = new System.Windows.Forms.GroupBox();
            this.btn_addSrc = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.timer_Init = new System.Windows.Forms.Timer(this.components);
            this.panel_Progress = new System.Windows.Forms.Panel();
            this.grpBox_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Path:";
            // 
            // tb_basePath
            // 
            this.tb_basePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_basePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_basePath.Location = new System.Drawing.Point(6, 46);
            this.tb_basePath.Name = "tb_basePath";
            this.tb_basePath.Size = new System.Drawing.Size(599, 23);
            this.tb_basePath.TabIndex = 1;
            this.tb_basePath.TextChanged += new System.EventHandler(this.tb_basePath_TextChanged);
            // 
            // grpBox_settings
            // 
            this.grpBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grpBox_settings.Controls.Add(this.btn_addSrc);
            this.grpBox_settings.Controls.Add(this.label1);
            this.grpBox_settings.Controls.Add(this.tb_basePath);
            this.grpBox_settings.Location = new System.Drawing.Point(12, 12);
            this.grpBox_settings.Name = "grpBox_settings";
            this.grpBox_settings.Size = new System.Drawing.Size(611, 113);
            this.grpBox_settings.TabIndex = 2;
            this.grpBox_settings.TabStop = false;
            this.grpBox_settings.Text = "Settings";
            // 
            // btn_addSrc
            // 
            this.btn_addSrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_addSrc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSrc.Location = new System.Drawing.Point(10, 75);
            this.btn_addSrc.Name = "btn_addSrc";
            this.btn_addSrc.Size = new System.Drawing.Size(116, 32);
            this.btn_addSrc.TabIndex = 2;
            this.btn_addSrc.Text = "Add Source";
            this.btn_addSrc.UseVisualStyleBackColor = false;
            this.btn_addSrc.Click += new System.EventHandler(this.btn_addSrc_Click);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_run.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.Location = new System.Drawing.Point(229, 173);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(137, 45);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // timer_Init
            // 
            this.timer_Init.Interval = 1000;
            this.timer_Init.Tick += new System.EventHandler(this.timer_Init_Tick);
            // 
            // panel_Progress
            // 
            this.panel_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Progress.Location = new System.Drawing.Point(12, 131);
            this.panel_Progress.Name = "panel_Progress";
            this.panel_Progress.Size = new System.Drawing.Size(611, 27);
            this.panel_Progress.TabIndex = 4;
            // 
            // Form_moveBundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(635, 240);
            this.Controls.Add(this.panel_Progress);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.grpBox_settings);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_moveBundle";
            this.Text = "Move Bundle";
            this.Load += new System.EventHandler(this.Form_moveBundle_Load);
            this.grpBox_settings.ResumeLayout(false);
            this.grpBox_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_basePath;
        private System.Windows.Forms.GroupBox grpBox_settings;
        private System.Windows.Forms.Button btn_addSrc;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Timer timer_Init;
        private System.Windows.Forms.Panel panel_Progress;
    }
}