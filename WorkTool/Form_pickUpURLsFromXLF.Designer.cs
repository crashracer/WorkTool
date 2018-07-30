namespace WorkTool
{
    partial class Form_pickUpURLsFromXLF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pickUpURLsFromXLF));
            this.panel_set = new System.Windows.Forms.Panel();
            this.rBtn_term = new System.Windows.Forms.RadioButton();
            this.rBtn_url = new System.Windows.Forms.RadioButton();
            this.tb_inputpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pickup = new System.Windows.Forms.Button();
            this.proBar_steps = new System.Windows.Forms.ProgressBar();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.rBtn_term);
            this.panel_set.Controls.Add(this.rBtn_url);
            this.panel_set.Controls.Add(this.tb_inputpath);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(521, 105);
            this.panel_set.TabIndex = 0;
            // 
            // rBtn_term
            // 
            this.rBtn_term.AutoSize = true;
            this.rBtn_term.Font = new System.Drawing.Font("方正姚体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_term.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rBtn_term.Location = new System.Drawing.Point(258, 68);
            this.rBtn_term.Name = "rBtn_term";
            this.rBtn_term.Size = new System.Drawing.Size(154, 19);
            this.rBtn_term.TabIndex = 3;
            this.rBtn_term.TabStop = true;
            this.rBtn_term.Text = "Pick Up Terminology";
            this.rBtn_term.UseVisualStyleBackColor = true;
            // 
            // rBtn_url
            // 
            this.rBtn_url.AutoSize = true;
            this.rBtn_url.Font = new System.Drawing.Font("方正姚体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_url.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rBtn_url.Location = new System.Drawing.Point(68, 68);
            this.rBtn_url.Name = "rBtn_url";
            this.rBtn_url.Size = new System.Drawing.Size(102, 19);
            this.rBtn_url.TabIndex = 2;
            this.rBtn_url.TabStop = true;
            this.rBtn_url.Text = "Pick Up URL";
            this.rBtn_url.UseVisualStyleBackColor = true;
            // 
            // tb_inputpath
            // 
            this.tb_inputpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_inputpath.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_inputpath.Location = new System.Drawing.Point(16, 31);
            this.tb_inputpath.Name = "tb_inputpath";
            this.tb_inputpath.Size = new System.Drawing.Size(488, 22);
            this.tb_inputpath.TabIndex = 1;
            this.tb_inputpath.TextChanged += new System.EventHandler(this.tb_inputpath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Path:";
            // 
            // btn_pickup
            // 
            this.btn_pickup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_pickup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pickup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_pickup.Location = new System.Drawing.Point(203, 189);
            this.btn_pickup.Name = "btn_pickup";
            this.btn_pickup.Size = new System.Drawing.Size(117, 39);
            this.btn_pickup.TabIndex = 1;
            this.btn_pickup.Text = "Pick Up";
            this.btn_pickup.UseVisualStyleBackColor = false;
            this.btn_pickup.Click += new System.EventHandler(this.btn_pickup_Click);
            // 
            // proBar_steps
            // 
            this.proBar_steps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_steps.Location = new System.Drawing.Point(12, 134);
            this.proBar_steps.Name = "proBar_steps";
            this.proBar_steps.Size = new System.Drawing.Size(521, 25);
            this.proBar_steps.TabIndex = 0;
            // 
            // Form_pickUpURLsFromXLF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(545, 267);
            this.Controls.Add(this.proBar_steps);
            this.Controls.Add(this.btn_pickup);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_pickUpURLsFromXLF";
            this.Text = "Pick Up URL/Terminology from XLF";
            this.Load += new System.EventHandler(this.Form_pickUpURLsFromXLF_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_inputpath;
        private System.Windows.Forms.Button btn_pickup;
        private System.Windows.Forms.ProgressBar proBar_steps;
        private System.Windows.Forms.RadioButton rBtn_url;
        private System.Windows.Forms.RadioButton rBtn_term;
    }
}