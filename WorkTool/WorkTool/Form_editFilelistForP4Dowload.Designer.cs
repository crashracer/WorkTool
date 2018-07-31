namespace WorkTool
{
    partial class Form_editFilelistForP4Dowload
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_editFilelistForP4Dowload));
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel_filelist = new System.Windows.Forms.Panel();
            this.dataGridView_filelist = new System.Windows.Forms.DataGridView();
            this.col_filelist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_tip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_filelist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_filelist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Clear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Clear.Location = new System.Drawing.Point(588, 88);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(87, 53);
            this.btn_Clear.TabIndex = 0;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(588, 29);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(87, 53);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "OK";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel_filelist
            // 
            this.panel_filelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_filelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_filelist.Controls.Add(this.dataGridView_filelist);
            this.panel_filelist.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_filelist.Location = new System.Drawing.Point(12, 160);
            this.panel_filelist.Name = "panel_filelist";
            this.panel_filelist.Size = new System.Drawing.Size(668, 198);
            this.panel_filelist.TabIndex = 3;
            // 
            // dataGridView_filelist
            // 
            this.dataGridView_filelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_filelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_filelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_filelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_filelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_filelist});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_filelist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_filelist.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_filelist.Name = "dataGridView_filelist";
            this.dataGridView_filelist.RowTemplate.Height = 23;
            this.dataGridView_filelist.Size = new System.Drawing.Size(658, 188);
            this.dataGridView_filelist.TabIndex = 0;
            // 
            // col_filelist
            // 
            this.col_filelist.HeaderText = "File List";
            this.col_filelist.Name = "col_filelist";
            // 
            // tb_tip
            // 
            this.tb_tip.AcceptsReturn = true;
            this.tb_tip.AcceptsTab = true;
            this.tb_tip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tb_tip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tip.ForeColor = System.Drawing.Color.Black;
            this.tb_tip.Location = new System.Drawing.Point(76, 12);
            this.tb_tip.Multiline = true;
            this.tb_tip.Name = "tb_tip";
            this.tb_tip.ReadOnly = true;
            this.tb_tip.Size = new System.Drawing.Size(452, 142);
            this.tb_tip.TabIndex = 4;
            this.tb_tip.Text = resources.GetString("tb_tip.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tip: ";
            // 
            // Form_editFilelistForP4Dowload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(692, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tip);
            this.Controls.Add(this.panel_filelist);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Clear);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_editFilelistForP4Dowload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Filelist of Download";
            this.Load += new System.EventHandler(this.Form_editFilelistForP4Dowload_Load);
            this.panel_filelist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_filelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel_filelist;
        private System.Windows.Forms.DataGridView dataGridView_filelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_filelist;
        private System.Windows.Forms.TextBox tb_tip;
        private System.Windows.Forms.Label label1;
    }
}