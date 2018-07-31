namespace WorkTool
{
    partial class Form_moveFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_moveFile));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.lab_tip = new System.Windows.Forms.Label();
            this.timer_listFiles = new System.Windows.Forms.Timer(this.components);
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_path.Location = new System.Drawing.Point(63, 9);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(393, 23);
            this.tb_path.TabIndex = 1;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_run.Font = new System.Drawing.Font("方正姚体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.Location = new System.Drawing.Point(462, 9);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 52);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FileType:";
            // 
            // tb_type
            // 
            this.tb_type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_type.Location = new System.Drawing.Point(124, 38);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(289, 23);
            this.tb_type.TabIndex = 4;
            this.tb_type.TextChanged += new System.EventHandler(this.tb_type_TextChanged);
            // 
            // lab_tip
            // 
            this.lab_tip.AutoSize = true;
            this.lab_tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tip.ForeColor = System.Drawing.Color.Red;
            this.lab_tip.Location = new System.Drawing.Point(92, 41);
            this.lab_tip.Name = "lab_tip";
            this.lab_tip.Size = new System.Drawing.Size(26, 17);
            this.lab_tip.TabIndex = 5;
            this.lab_tip.Text = "Tip";
            // 
            // timer_listFiles
            // 
            this.timer_listFiles.Interval = 1000;
            this.timer_listFiles.Tick += new System.EventHandler(this.timer_listFiles_Tick);
            // 
            // timer_move
            // 
            this.timer_move.Interval = 1000;
            this.timer_move.Tick += new System.EventHandler(this.timer_move_Tick);
            // 
            // Form_moveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(549, 74);
            this.Controls.Add(this.lab_tip);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_moveFile";
            this.Text = "Move File";
            this.Load += new System.EventHandler(this.Form_moveFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label lab_tip;
        private System.Windows.Forms.Timer timer_listFiles;
        private System.Windows.Forms.Timer timer_move;
    }
}