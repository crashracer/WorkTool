namespace WorkTool
{
    partial class Form_regulateXLFForFixingBug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_regulateXLFForFixingBug));
            this.panel_set = new System.Windows.Forms.Panel();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.tb_base = new System.Windows.Forms.TextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proBar_progress = new System.Windows.Forms.ProgressBar();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_set.Controls.Add(this.tb_output);
            this.panel_set.Controls.Add(this.tb_base);
            this.panel_set.Controls.Add(this.tb_input);
            this.panel_set.Controls.Add(this.label3);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(634, 121);
            this.panel_set.TabIndex = 0;
            // 
            // tb_output
            // 
            this.tb_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_output.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_output.ForeColor = System.Drawing.Color.Green;
            this.tb_output.Location = new System.Drawing.Point(108, 87);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(511, 23);
            this.tb_output.TabIndex = 5;
            this.tb_output.TextChanged += new System.EventHandler(this.tb_output_TextChanged);
            // 
            // tb_base
            // 
            this.tb_base.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_base.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_base.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_base.Location = new System.Drawing.Point(108, 47);
            this.tb_base.Name = "tb_base";
            this.tb_base.Size = new System.Drawing.Size(511, 23);
            this.tb_base.TabIndex = 4;
            this.tb_base.TextChanged += new System.EventHandler(this.tb_base_TextChanged);
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.BackColor = System.Drawing.Color.White;
            this.tb_input.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_input.Location = new System.Drawing.Point(108, 8);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(511, 23);
            this.tb_input.TabIndex = 3;
            this.tb_input.TextChanged += new System.EventHandler(this.tb_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // proBar_progress
            // 
            this.proBar_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_progress.Location = new System.Drawing.Point(12, 148);
            this.proBar_progress.Name = "proBar_progress";
            this.proBar_progress.Size = new System.Drawing.Size(634, 23);
            this.proBar_progress.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_start.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_start.Location = new System.Drawing.Point(232, 226);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(159, 46);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form_regulateXLFForFixingBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(658, 321);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.proBar_progress);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_regulateXLFForFixingBug";
            this.Text = "Regulate XLF for Fixing Bug";
            this.Load += new System.EventHandler(this.Form_regulateXLFForFixingBug_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.TextBox tb_base;
        private System.Windows.Forms.ProgressBar proBar_progress;
        private System.Windows.Forms.Button btn_start;
    }
}