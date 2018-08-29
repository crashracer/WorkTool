namespace WorkTool
{
    partial class Form_editTagsInXLF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_editTagsInXLF));
            this.panel_set = new System.Windows.Forms.Panel();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.chkBox_addComment = new System.Windows.Forms.CheckBox();
            this.tb_tagsInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pathOutput = new System.Windows.Forms.TextBox();
            this.tb_pathInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proBar_progress = new System.Windows.Forms.ProgressBar();
            this.btn_run = new System.Windows.Forms.Button();
            this.panel_set.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_set
            // 
            this.panel_set.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_set.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_set.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_set.Controls.Add(this.tb_comment);
            this.panel_set.Controls.Add(this.chkBox_addComment);
            this.panel_set.Controls.Add(this.tb_tagsInfo);
            this.panel_set.Controls.Add(this.label3);
            this.panel_set.Controls.Add(this.tb_pathOutput);
            this.panel_set.Controls.Add(this.tb_pathInput);
            this.panel_set.Controls.Add(this.label2);
            this.panel_set.Controls.Add(this.label1);
            this.panel_set.Location = new System.Drawing.Point(12, 12);
            this.panel_set.Name = "panel_set";
            this.panel_set.Size = new System.Drawing.Size(694, 237);
            this.panel_set.TabIndex = 0;
            // 
            // tb_comment
            // 
            this.tb_comment.AcceptsReturn = true;
            this.tb_comment.AcceptsTab = true;
            this.tb_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_comment.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_comment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_comment.ForeColor = System.Drawing.Color.Blue;
            this.tb_comment.Location = new System.Drawing.Point(11, 149);
            this.tb_comment.Multiline = true;
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_comment.Size = new System.Drawing.Size(668, 81);
            this.tb_comment.TabIndex = 8;
            this.tb_comment.WordWrap = false;
            this.tb_comment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_comment_KeyDown);
            // 
            // chkBox_addComment
            // 
            this.chkBox_addComment.AutoSize = true;
            this.chkBox_addComment.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkBox_addComment.ForeColor = System.Drawing.Color.Blue;
            this.chkBox_addComment.Location = new System.Drawing.Point(11, 120);
            this.chkBox_addComment.Name = "chkBox_addComment";
            this.chkBox_addComment.Size = new System.Drawing.Size(126, 23);
            this.chkBox_addComment.TabIndex = 6;
            this.chkBox_addComment.Text = "Add Commens";
            this.chkBox_addComment.UseVisualStyleBackColor = true;
            this.chkBox_addComment.CheckedChanged += new System.EventHandler(this.chkBox_addComment_CheckedChanged);
            // 
            // tb_tagsInfo
            // 
            this.tb_tagsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tagsInfo.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_tagsInfo.ForeColor = System.Drawing.Color.Red;
            this.tb_tagsInfo.Location = new System.Drawing.Point(120, 80);
            this.tb_tagsInfo.Name = "tb_tagsInfo";
            this.tb_tagsInfo.Size = new System.Drawing.Size(402, 25);
            this.tb_tagsInfo.TabIndex = 5;
            this.tb_tagsInfo.TextChanged += new System.EventHandler(this.tb_tagsInfo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tags Info:";
            // 
            // tb_pathOutput
            // 
            this.tb_pathOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathOutput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathOutput.ForeColor = System.Drawing.Color.Green;
            this.tb_pathOutput.Location = new System.Drawing.Point(120, 41);
            this.tb_pathOutput.Name = "tb_pathOutput";
            this.tb_pathOutput.Size = new System.Drawing.Size(559, 23);
            this.tb_pathOutput.TabIndex = 3;
            this.tb_pathOutput.TextChanged += new System.EventHandler(this.tb_pathOutput_TextChanged);
            // 
            // tb_pathInput
            // 
            this.tb_pathInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pathInput.ForeColor = System.Drawing.Color.Purple;
            this.tb_pathInput.Location = new System.Drawing.Point(120, 11);
            this.tb_pathInput.Name = "tb_pathInput";
            this.tb_pathInput.Size = new System.Drawing.Size(559, 23);
            this.tb_pathInput.TabIndex = 2;
            this.tb_pathInput.TextChanged += new System.EventHandler(this.tb_pathInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path Input:";
            // 
            // proBar_progress
            // 
            this.proBar_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.proBar_progress.Location = new System.Drawing.Point(12, 264);
            this.proBar_progress.Name = "proBar_progress";
            this.proBar_progress.Size = new System.Drawing.Size(694, 23);
            this.proBar_progress.TabIndex = 1;
            // 
            // btn_run
            // 
            this.btn_run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_run.BackColor = System.Drawing.Color.Silver;
            this.btn_run.Font = new System.Drawing.Font("方正舒体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run.ForeColor = System.Drawing.Color.Navy;
            this.btn_run.Location = new System.Drawing.Point(261, 303);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(177, 49);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "RUN";
            this.btn_run.UseVisualStyleBackColor = false;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // Form_editTagsInXLF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(718, 452);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.proBar_progress);
            this.Controls.Add(this.panel_set);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_editTagsInXLF";
            this.Text = "Edit Tags Info in XLF";
            this.Load += new System.EventHandler(this.Form_editTagsInXLF_Load);
            this.panel_set.ResumeLayout(false);
            this.panel_set.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pathOutput;
        private System.Windows.Forms.TextBox tb_pathInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tagsInfo;
        private System.Windows.Forms.ProgressBar proBar_progress;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.CheckBox chkBox_addComment;
        private System.Windows.Forms.TextBox tb_comment;
    }
}