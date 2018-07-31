namespace WorkTool
{
    partial class Form_checkSpecialFormatString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_checkSpecialFormatString));
            this.panel_set = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView_strList = new System.Windows.Forms.DataGridView();
            this.col_strList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_pathInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.proBar_pro = new System.Windows.Forms.ProgressBar();
            this.panel_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_strList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.Silver;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.btn_clear);
            this.panel_set.Controls.Add(this.btn_save);
            this.panel_set.Controls.Add(this.dataGridView_strList);
            this.panel_set.Controls.Add(this.tb_pathInput);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(582, 198);
            this.panel_set.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Font = new System.Drawing.Font("方正姚体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.ForeColor = System.Drawing.Color.Purple;
            this.btn_clear.Location = new System.Drawing.Point(483, 124);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 33);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "← Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Font = new System.Drawing.Font("方正姚体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.Color.Green;
            this.btn_save.Location = new System.Drawing.Point(483, 76);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(81, 33);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "← Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView_strList
            // 
            this.dataGridView_strList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_strList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_strList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_strList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_strList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_strList});
            this.dataGridView_strList.Location = new System.Drawing.Point(16, 61);
            this.dataGridView_strList.Name = "dataGridView_strList";
            this.dataGridView_strList.RowTemplate.Height = 23;
            this.dataGridView_strList.Size = new System.Drawing.Size(449, 130);
            this.dataGridView_strList.TabIndex = 2;
            this.dataGridView_strList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_strList_CellValueChanged);
            // 
            // col_strList
            // 
            this.col_strList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.col_strList.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_strList.HeaderText = "String List";
            this.col_strList.Name = "col_strList";
            // 
            // tb_pathInput
            // 
            this.tb_pathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tb_pathInput.Location = new System.Drawing.Point(16, 32);
            this.tb_pathInput.Name = "tb_pathInput";
            this.tb_pathInput.Size = new System.Drawing.Size(548, 23);
            this.tb_pathInput.TabIndex = 1;
            this.tb_pathInput.TextChanged += new System.EventHandler(this.tb_pathInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Input:";
            // 
            // btn_check
            // 
            this.btn_check.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_check.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_check.Location = new System.Drawing.Point(242, 266);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(109, 41);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "CHECK";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // proBar_pro
            // 
            this.proBar_pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_pro.Location = new System.Drawing.Point(12, 227);
            this.proBar_pro.Name = "proBar_pro";
            this.proBar_pro.Size = new System.Drawing.Size(582, 23);
            this.proBar_pro.TabIndex = 2;
            // 
            // Form_checkSpecialFormatString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(606, 319);
            this.Controls.Add(this.proBar_pro);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_checkSpecialFormatString";
            this.Text = "Check Special Format String in XLF";
            this.Load += new System.EventHandler(this.Form_checkSpecialFormatString_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_strList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pathInput;
        private System.Windows.Forms.DataGridView dataGridView_strList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_strList;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.ProgressBar proBar_pro;
    }
}