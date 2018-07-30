namespace WorkTool
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_operFile = new System.Windows.Forms.ToolStripMenuItem();
            this.stringPortalFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_checkSpecialFormatString = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_addTagLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_regularFileContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exportTermlistXLF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChkEscapedXLF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChkCopyrightSymbol = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_pickUpURLsFromXLF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_editTagsInXLF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_regulateXLFForFixingBug = new System.Windows.Forms.ToolStripMenuItem();
            this.sDLTradosProjectFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copyxliff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_copyXliffToProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ReplaceForTM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_convertXMLtoExcelForTM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ModifyFileForAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_setRegExpOfQAVerification = new System.Windows.Forms.ToolStripMenuItem();
            this.otherExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_downloadP4files = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_renameFNameAsLangCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_renameFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_satmetrix = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chkLocaleCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chkTabInTag = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chkFileNameAfterVerId = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chkSpaceXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_operText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_chkRegex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_RemSentence = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_moveBundle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_moveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ChangeLCode_inFile = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_operFile,
            this.tsmi_satmetrix,
            this.tsmi_operText});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(683, 25);
            this.menuStrip_main.TabIndex = 2;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // tsmi_operFile
            // 
            this.tsmi_operFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringPortalFilesToolStripMenuItem,
            this.sDLTradosProjectFilesToolStripMenuItem,
            this.otherExtensionsToolStripMenuItem});
            this.tsmi_operFile.ForeColor = System.Drawing.Color.Black;
            this.tsmi_operFile.Name = "tsmi_operFile";
            this.tsmi_operFile.Size = new System.Drawing.Size(98, 21);
            this.tsmi_operFile.Text = "Trend Project";
            // 
            // stringPortalFilesToolStripMenuItem
            // 
            this.stringPortalFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_checkSpecialFormatString,
            this.tsmi_addTagLine,
            this.tsmi_regularFileContent,
            this.tsmi_exportTermlistXLF,
            this.tsmi_ChkEscapedXLF,
            this.tsmi_ChkCopyrightSymbol,
            this.tsmi_pickUpURLsFromXLF,
            this.tsmi_editTagsInXLF,
            this.tsmi_regulateXLFForFixingBug});
            this.stringPortalFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stringPortalFilesToolStripMenuItem.Image")));
            this.stringPortalFilesToolStripMenuItem.Name = "stringPortalFilesToolStripMenuItem";
            this.stringPortalFilesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.stringPortalFilesToolStripMenuItem.Text = "String Portal Files";
            // 
            // tsmi_checkSpecialFormatString
            // 
            this.tsmi_checkSpecialFormatString.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_checkSpecialFormatString.Image")));
            this.tsmi_checkSpecialFormatString.Name = "tsmi_checkSpecialFormatString";
            this.tsmi_checkSpecialFormatString.Size = new System.Drawing.Size(289, 22);
            this.tsmi_checkSpecialFormatString.Text = "Check Special Format String in XLF";
            this.tsmi_checkSpecialFormatString.Click += new System.EventHandler(this.tsmi_checkSpecialFormatString_Click);
            // 
            // tsmi_addTagLine
            // 
            this.tsmi_addTagLine.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_addTagLine.Image")));
            this.tsmi_addTagLine.Name = "tsmi_addTagLine";
            this.tsmi_addTagLine.Size = new System.Drawing.Size(289, 22);
            this.tsmi_addTagLine.Text = "Add Target Line";
            this.tsmi_addTagLine.Click += new System.EventHandler(this.tsmi_addTagLine_Click);
            // 
            // tsmi_regularFileContent
            // 
            this.tsmi_regularFileContent.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_regularFileContent.Image")));
            this.tsmi_regularFileContent.Name = "tsmi_regularFileContent";
            this.tsmi_regularFileContent.Size = new System.Drawing.Size(289, 22);
            this.tsmi_regularFileContent.Text = "Regulate XLF for Sync";
            this.tsmi_regularFileContent.Click += new System.EventHandler(this.tsmi_regularFileContent_Click);
            // 
            // tsmi_exportTermlistXLF
            // 
            this.tsmi_exportTermlistXLF.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_exportTermlistXLF.Image")));
            this.tsmi_exportTermlistXLF.Name = "tsmi_exportTermlistXLF";
            this.tsmi_exportTermlistXLF.Size = new System.Drawing.Size(289, 22);
            this.tsmi_exportTermlistXLF.Text = "Export Translated Stringlist from XLF";
            this.tsmi_exportTermlistXLF.Click += new System.EventHandler(this.tsmi_exportTermlistXLF_Click);
            // 
            // tsmi_ChkEscapedXLF
            // 
            this.tsmi_ChkEscapedXLF.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_ChkEscapedXLF.Image")));
            this.tsmi_ChkEscapedXLF.Name = "tsmi_ChkEscapedXLF";
            this.tsmi_ChkEscapedXLF.Size = new System.Drawing.Size(289, 22);
            this.tsmi_ChkEscapedXLF.Text = "Check Escaped in XLF";
            this.tsmi_ChkEscapedXLF.Click += new System.EventHandler(this.tsmi_ChkEscapedXLF_Click);
            // 
            // tsmi_ChkCopyrightSymbol
            // 
            this.tsmi_ChkCopyrightSymbol.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_ChkCopyrightSymbol.Image")));
            this.tsmi_ChkCopyrightSymbol.Name = "tsmi_ChkCopyrightSymbol";
            this.tsmi_ChkCopyrightSymbol.Size = new System.Drawing.Size(289, 22);
            this.tsmi_ChkCopyrightSymbol.Text = "Check Copyright Symbol";
            this.tsmi_ChkCopyrightSymbol.Click += new System.EventHandler(this.tsmi_ChkCopyrightSymbol_Click);
            // 
            // tsmi_pickUpURLsFromXLF
            // 
            this.tsmi_pickUpURLsFromXLF.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_pickUpURLsFromXLF.Image")));
            this.tsmi_pickUpURLsFromXLF.Name = "tsmi_pickUpURLsFromXLF";
            this.tsmi_pickUpURLsFromXLF.Size = new System.Drawing.Size(289, 22);
            this.tsmi_pickUpURLsFromXLF.Text = "Pick Up URL/Terminology from XLF";
            this.tsmi_pickUpURLsFromXLF.Click += new System.EventHandler(this.tsmi_pickUpURLsFromXLF_Click);
            // 
            // tsmi_editTagsInXLF
            // 
            this.tsmi_editTagsInXLF.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_editTagsInXLF.Image")));
            this.tsmi_editTagsInXLF.Name = "tsmi_editTagsInXLF";
            this.tsmi_editTagsInXLF.Size = new System.Drawing.Size(289, 22);
            this.tsmi_editTagsInXLF.Text = "Edit Tags Info in XLF";
            this.tsmi_editTagsInXLF.Click += new System.EventHandler(this.tsmi_editTagsInXLF_Click);
            // 
            // tsmi_regulateXLFForFixingBug
            // 
            this.tsmi_regulateXLFForFixingBug.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_regulateXLFForFixingBug.Image")));
            this.tsmi_regulateXLFForFixingBug.Name = "tsmi_regulateXLFForFixingBug";
            this.tsmi_regulateXLFForFixingBug.Size = new System.Drawing.Size(289, 22);
            this.tsmi_regulateXLFForFixingBug.Text = "Regulate XLF for Fixing Bug";
            this.tsmi_regulateXLFForFixingBug.Click += new System.EventHandler(this.tsmi_regulateXLFForFixingBug_Click);
            // 
            // sDLTradosProjectFilesToolStripMenuItem
            // 
            this.sDLTradosProjectFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_copyxliff,
            this.tsmi_copyXliffToProject,
            this.tsmi_ReplaceForTM,
            this.tsmi_convertXMLtoExcelForTM,
            this.tsmi_ModifyFileForAlign,
            this.tsmi_setRegExpOfQAVerification});
            this.sDLTradosProjectFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sDLTradosProjectFilesToolStripMenuItem.Image")));
            this.sDLTradosProjectFilesToolStripMenuItem.Name = "sDLTradosProjectFilesToolStripMenuItem";
            this.sDLTradosProjectFilesToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.sDLTradosProjectFilesToolStripMenuItem.Text = "SDL Trados Project Files";
            // 
            // tsmi_copyxliff
            // 
            this.tsmi_copyxliff.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_copyxliff.Image")));
            this.tsmi_copyxliff.Name = "tsmi_copyxliff";
            this.tsmi_copyxliff.Size = new System.Drawing.Size(341, 22);
            this.tsmi_copyxliff.Text = "Copy Out Files from Project";
            this.tsmi_copyxliff.Click += new System.EventHandler(this.tsmi_copyxliff_Click);
            // 
            // tsmi_copyXliffToProject
            // 
            this.tsmi_copyXliffToProject.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_copyXliffToProject.Image")));
            this.tsmi_copyXliffToProject.Name = "tsmi_copyXliffToProject";
            this.tsmi_copyXliffToProject.Size = new System.Drawing.Size(341, 22);
            this.tsmi_copyXliffToProject.Text = "Copy Xliff into Project";
            this.tsmi_copyXliffToProject.Click += new System.EventHandler(this.tsmi_copyXliffToProject_Click);
            // 
            // tsmi_ReplaceForTM
            // 
            this.tsmi_ReplaceForTM.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_ReplaceForTM.Image")));
            this.tsmi_ReplaceForTM.Name = "tsmi_ReplaceForTM";
            this.tsmi_ReplaceForTM.Size = new System.Drawing.Size(341, 22);
            this.tsmi_ReplaceForTM.Text = "Replace For TM";
            this.tsmi_ReplaceForTM.Click += new System.EventHandler(this.tsmi_ReplaceForTM_Click);
            // 
            // tsmi_convertXMLtoExcelForTM
            // 
            this.tsmi_convertXMLtoExcelForTM.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_convertXMLtoExcelForTM.Image")));
            this.tsmi_convertXMLtoExcelForTM.Name = "tsmi_convertXMLtoExcelForTM";
            this.tsmi_convertXMLtoExcelForTM.Size = new System.Drawing.Size(341, 22);
            this.tsmi_convertXMLtoExcelForTM.Text = "Convert Passolo exported XML to XLF for TM";
            this.tsmi_convertXMLtoExcelForTM.Click += new System.EventHandler(this.tsmi_convertXMLtoExcelForTM_Click);
            // 
            // tsmi_ModifyFileForAlign
            // 
            this.tsmi_ModifyFileForAlign.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_ModifyFileForAlign.Image")));
            this.tsmi_ModifyFileForAlign.Name = "tsmi_ModifyFileForAlign";
            this.tsmi_ModifyFileForAlign.Size = new System.Drawing.Size(341, 22);
            this.tsmi_ModifyFileForAlign.Text = "Modify File for Align";
            this.tsmi_ModifyFileForAlign.Click += new System.EventHandler(this.tsmi_ModifyFileForAlign_Click);
            // 
            // tsmi_setRegExpOfQAVerification
            // 
            this.tsmi_setRegExpOfQAVerification.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_setRegExpOfQAVerification.Image")));
            this.tsmi_setRegExpOfQAVerification.Name = "tsmi_setRegExpOfQAVerification";
            this.tsmi_setRegExpOfQAVerification.Size = new System.Drawing.Size(341, 22);
            this.tsmi_setRegExpOfQAVerification.Text = "Set Regular Expressions of QA Verification";
            this.tsmi_setRegExpOfQAVerification.Click += new System.EventHandler(this.tsmi_setRegExpOfQAVerification_Click);
            // 
            // otherExtensionsToolStripMenuItem
            // 
            this.otherExtensionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_downloadP4files,
            this.tsmi_renameFNameAsLangCode,
            this.tsmi_renameFilePath});
            this.otherExtensionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("otherExtensionsToolStripMenuItem.Image")));
            this.otherExtensionsToolStripMenuItem.Name = "otherExtensionsToolStripMenuItem";
            this.otherExtensionsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.otherExtensionsToolStripMenuItem.Text = "Other Extensions";
            // 
            // tsmi_downloadP4files
            // 
            this.tsmi_downloadP4files.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_downloadP4files.Image")));
            this.tsmi_downloadP4files.Name = "tsmi_downloadP4files";
            this.tsmi_downloadP4files.Size = new System.Drawing.Size(315, 22);
            this.tsmi_downloadP4files.Text = "Download Files from P4";
            this.tsmi_downloadP4files.Click += new System.EventHandler(this.tsmi_downloadP4files_Click);
            // 
            // tsmi_renameFNameAsLangCode
            // 
            this.tsmi_renameFNameAsLangCode.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_renameFNameAsLangCode.Image")));
            this.tsmi_renameFNameAsLangCode.Name = "tsmi_renameFNameAsLangCode";
            this.tsmi_renameFNameAsLangCode.Size = new System.Drawing.Size(315, 22);
            this.tsmi_renameFNameAsLangCode.Text = "Rename Folder / File Name as LangCode";
            this.tsmi_renameFNameAsLangCode.Click += new System.EventHandler(this.tsmi_renameFNameAsLangCode_Click);
            // 
            // tsmi_renameFilePath
            // 
            this.tsmi_renameFilePath.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_renameFilePath.Image")));
            this.tsmi_renameFilePath.Name = "tsmi_renameFilePath";
            this.tsmi_renameFilePath.Size = new System.Drawing.Size(315, 22);
            this.tsmi_renameFilePath.Text = "Rename File Path";
            this.tsmi_renameFilePath.Click += new System.EventHandler(this.tsmi_renameFilePath_Click);
            // 
            // tsmi_satmetrix
            // 
            this.tsmi_satmetrix.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_chkLocaleCode,
            this.tsmi_chkTabInTag,
            this.tsmi_chkFileNameAfterVerId,
            this.tsmi_chkSpaceXML});
            this.tsmi_satmetrix.ForeColor = System.Drawing.Color.Black;
            this.tsmi_satmetrix.Name = "tsmi_satmetrix";
            this.tsmi_satmetrix.Size = new System.Drawing.Size(118, 21);
            this.tsmi_satmetrix.Text = "Satmetrix Project";
            // 
            // tsmi_chkLocaleCode
            // 
            this.tsmi_chkLocaleCode.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_chkLocaleCode.Image")));
            this.tsmi_chkLocaleCode.Name = "tsmi_chkLocaleCode";
            this.tsmi_chkLocaleCode.Size = new System.Drawing.Size(346, 22);
            this.tsmi_chkLocaleCode.Text = "Check LocaleCode";
            this.tsmi_chkLocaleCode.Click += new System.EventHandler(this.tsmi_chkLocaleCode_Click);
            // 
            // tsmi_chkTabInTag
            // 
            this.tsmi_chkTabInTag.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_chkTabInTag.Image")));
            this.tsmi_chkTabInTag.Name = "tsmi_chkTabInTag";
            this.tsmi_chkTabInTag.Size = new System.Drawing.Size(346, 22);
            this.tsmi_chkTabInTag.Text = "Check Tab( \\t ) in Tag of XML";
            this.tsmi_chkTabInTag.Click += new System.EventHandler(this.tsmi_chkTabInTag_Click);
            // 
            // tsmi_chkFileNameAfterVerId
            // 
            this.tsmi_chkFileNameAfterVerId.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_chkFileNameAfterVerId.Image")));
            this.tsmi_chkFileNameAfterVerId.Name = "tsmi_chkFileNameAfterVerId";
            this.tsmi_chkFileNameAfterVerId.Size = new System.Drawing.Size(346, 22);
            this.tsmi_chkFileNameAfterVerId.Text = "Check Filename after \"- @version $Id:\" of XML";
            this.tsmi_chkFileNameAfterVerId.Click += new System.EventHandler(this.tsmi_chkFileNameAfterVerId_Click);
            // 
            // tsmi_chkSpaceXML
            // 
            this.tsmi_chkSpaceXML.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_chkSpaceXML.Image")));
            this.tsmi_chkSpaceXML.Name = "tsmi_chkSpaceXML";
            this.tsmi_chkSpaceXML.Size = new System.Drawing.Size(346, 22);
            this.tsmi_chkSpaceXML.Text = "Check Space( &&nbsp; ) of XML";
            this.tsmi_chkSpaceXML.Click += new System.EventHandler(this.tsmi_chkSpaceXML_Click);
            // 
            // tsmi_operText
            // 
            this.tsmi_operText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_chkRegex,
            this.tsmi_RemSentence,
            this.tsmi_moveBundle,
            this.tsmi_moveFile,
            this.tsmi_ChangeLCode_inFile});
            this.tsmi_operText.ForeColor = System.Drawing.Color.Black;
            this.tsmi_operText.Name = "tsmi_operText";
            this.tsmi_operText.Size = new System.Drawing.Size(59, 21);
            this.tsmi_operText.Text = "Others";
            // 
            // tsmi_chkRegex
            // 
            this.tsmi_chkRegex.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_chkRegex.Image")));
            this.tsmi_chkRegex.Name = "tsmi_chkRegex";
            this.tsmi_chkRegex.Size = new System.Drawing.Size(295, 22);
            this.tsmi_chkRegex.Text = "Check Regex";
            this.tsmi_chkRegex.Click += new System.EventHandler(this.tsmi_chkRegex_Click);
            // 
            // tsmi_RemSentence
            // 
            this.tsmi_RemSentence.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_RemSentence.Image")));
            this.tsmi_RemSentence.Name = "tsmi_RemSentence";
            this.tsmi_RemSentence.Size = new System.Drawing.Size(295, 22);
            this.tsmi_RemSentence.Text = "Remove Sentence";
            this.tsmi_RemSentence.Click += new System.EventHandler(this.tsmi_RemSentence_Click);
            // 
            // tsmi_moveBundle
            // 
            this.tsmi_moveBundle.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_moveBundle.Image")));
            this.tsmi_moveBundle.Name = "tsmi_moveBundle";
            this.tsmi_moveBundle.Size = new System.Drawing.Size(295, 22);
            this.tsmi_moveBundle.Text = "Move Bundle";
            this.tsmi_moveBundle.Click += new System.EventHandler(this.tsmi_moveBundle_Click);
            // 
            // tsmi_moveFile
            // 
            this.tsmi_moveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_moveFile.Image")));
            this.tsmi_moveFile.Name = "tsmi_moveFile";
            this.tsmi_moveFile.Size = new System.Drawing.Size(295, 22);
            this.tsmi_moveFile.Text = "Move File";
            this.tsmi_moveFile.Click += new System.EventHandler(this.tsmi_moveFile_Click);
            // 
            // tsmi_ChangeLCode_inFile
            // 
            this.tsmi_ChangeLCode_inFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmi_ChangeLCode_inFile.Image")));
            this.tsmi_ChangeLCode_inFile.Name = "tsmi_ChangeLCode_inFile";
            this.tsmi_ChangeLCode_inFile.Size = new System.Drawing.Size(295, 22);
            this.tsmi_ChangeLCode_inFile.Text = "Change Language/Locale Code in File";
            this.tsmi_ChangeLCode_inFile.Click += new System.EventHandler(this.tsmi_ChangeLCode_inFile_Click);
            // 
            // picBox_main
            // 
            this.picBox_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picBox_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_main.Image = ((System.Drawing.Image)(resources.GetObject("picBox_main.Image")));
            this.picBox_main.Location = new System.Drawing.Point(0, 25);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(683, 472);
            this.picBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_main.TabIndex = 4;
            this.picBox_main.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 497);
            this.Controls.Add(this.picBox_main);
            this.Controls.Add(this.menuStrip_main);
            this.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_main;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkTool";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_operFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_satmetrix;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chkLocaleCode;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chkTabInTag;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chkFileNameAfterVerId;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chkSpaceXML;
        private System.Windows.Forms.ToolStripMenuItem tsmi_operText;
        private System.Windows.Forms.ToolStripMenuItem tsmi_chkRegex;
        private System.Windows.Forms.ToolStripMenuItem tsmi_RemSentence;
        private System.Windows.Forms.ToolStripMenuItem tsmi_moveBundle;
        private System.Windows.Forms.ToolStripMenuItem tsmi_moveFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChangeLCode_inFile;
        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.ToolStripMenuItem stringPortalFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_checkSpecialFormatString;
        private System.Windows.Forms.ToolStripMenuItem tsmi_addTagLine;
        private System.Windows.Forms.ToolStripMenuItem tsmi_regularFileContent;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exportTermlistXLF;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChkEscapedXLF;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChkCopyrightSymbol;
        private System.Windows.Forms.ToolStripMenuItem tsmi_pickUpURLsFromXLF;
        private System.Windows.Forms.ToolStripMenuItem sDLTradosProjectFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copyxliff;
        private System.Windows.Forms.ToolStripMenuItem tsmi_copyXliffToProject;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ReplaceForTM;
        private System.Windows.Forms.ToolStripMenuItem tsmi_convertXMLtoExcelForTM;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ModifyFileForAlign;
        private System.Windows.Forms.ToolStripMenuItem otherExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_downloadP4files;
        private System.Windows.Forms.ToolStripMenuItem tsmi_renameFNameAsLangCode;
        private System.Windows.Forms.ToolStripMenuItem tsmi_renameFilePath;
        private System.Windows.Forms.ToolStripMenuItem tsmi_editTagsInXLF;
        private System.Windows.Forms.ToolStripMenuItem tsmi_regulateXLFForFixingBug;
        private System.Windows.Forms.ToolStripMenuItem tsmi_setRegExpOfQAVerification;
    }
}

