using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MyClassLib_rml;
using System.IO;
using System.Diagnostics;

namespace WorkTool
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        #region 全局变量或参数
        public static String str_configFolder;
        #endregion

        #region 自定义方法
        public void keepOneChildFormOpen(Form form_parent, Form form_child)
        {
            if (form_parent.MdiChildren.Length > 0)
            {
                foreach (Form fChild in form_parent.MdiChildren)
                    fChild.Close();
            }

            form_child.MdiParent = form_parent;
            form_child.ShowIcon = true;
            form_child.Show();
            form_child.WindowState = FormWindowState.Maximized;
            this.picBox_main.Visible = false;
        }

        public static void AddTextToListbox(ListBox lb_ui, String str_text)
        {
            String str_time = "[" + DateTime.Now.ToString("HH:mm:ss") + "] ";
            lb_ui.Items.Insert(0, str_time + str_text);
            lb_ui.SelectedIndex = 0;
        }

        /*获取指定节点下的所有Key的Value*/
        public static ArrayList ReadAllValues(String sectionName, String fPath)
        {
            String rd_tmp = "";
            ArrayList al_keys = new ArrayList();
            ArrayList al_value = new ArrayList();

            al_keys = ClassLib_RML.ReadKeysFromINI(sectionName, fPath);

            for (int idx = 0; idx < al_keys.Count; idx++)
            {
                rd_tmp = ClassLib_RML.ReadeValueFromINI(sectionName, al_keys[idx].ToString(), fPath);
                al_value.Add(rd_tmp);
            }
            return al_value;
        }
        #endregion

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.menuStrip_main.Enabled = false;

            if (this.MdiChildren.Length > 0)
            {
                foreach (Form fChild in this.MdiChildren)
                    fChild.Close();
            }

            str_configFolder = Path.Combine(Application.StartupPath, "ConfigSettings");
            if (!Directory.Exists(str_configFolder))
                Directory.CreateDirectory(str_configFolder);

            this.picBox_main.Visible = true;
            this.menuStrip_main.Enabled = true;
        }

        private void tsmi_addTagLine_Click(object sender, EventArgs e)
        {
            Form_addTagLine fatl = new Form_addTagLine();
            keepOneChildFormOpen(this, fatl);
        }

        private void tsmi_ReplaceForTM_Click(object sender, EventArgs e)
        {
            Form_ReplaceForTM frfTM = new Form_ReplaceForTM();
            keepOneChildFormOpen(this, frfTM);
        }

        private void tsmi_copyxliff_Click(object sender, EventArgs e)
        {
            Form_CopyXliff fcx = new Form_CopyXliff();
            keepOneChildFormOpen(this, fcx);
        }

        private void tsmi_downloadP4files_Click(object sender, EventArgs e)
        {
            Form_downloadP4files fdp4f = new Form_downloadP4files();
            keepOneChildFormOpen(this, fdp4f);
        }

        private void tsmi_regularFileContent_Click(object sender, EventArgs e)
        {
            Form_regularFileContent frfc = new Form_regularFileContent();
            keepOneChildFormOpen(this, frfc);
        }

        private void tsmi_renameFNameAsLangCode_Click(object sender, EventArgs e)
        {
            String str_runExe = Path.Combine(Application.StartupPath, "RenameFileFolderNameAsLangCode.exe");
            Process pro = new Process();
            pro.StartInfo.FileName = str_runExe;
            pro.Start();
            this.WindowState = FormWindowState.Minimized;
            pro.WaitForExit();
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmi_exportTermlistXLF_Click(object sender, EventArgs e)
        {
            Form_exportTermlistXLF fetxlf = new Form_exportTermlistXLF();
            keepOneChildFormOpen(this, fetxlf);
        }

        private void tsmi_copyXliffToProject_Click(object sender, EventArgs e)
        {
            Form_copyXliffToProject fcxtp = new Form_copyXliffToProject();
            keepOneChildFormOpen(this, fcxtp);
        }

        private void tsmi_ChkEscapedXLF_Click(object sender, EventArgs e)
        {
            Form_ChkEscapedXLF fcexlf = new Form_ChkEscapedXLF();
            keepOneChildFormOpen(this, fcexlf);
        }

        private void tsmi_chkLocaleCode_Click(object sender, EventArgs e)
        {
            Form_chkLocaleCode fclc = new Form_chkLocaleCode();
            keepOneChildFormOpen(this, fclc);
        }

        private void tsmi_chkTabInTag_Click(object sender, EventArgs e)
        {
            Form_chkTabInTag fctit = new Form_chkTabInTag();
            keepOneChildFormOpen(this, fctit);
        }

        private void tsmi_chkFileNameAfterVerId_Click(object sender, EventArgs e)
        {
            Form_chkFileNameAfterVerId fcfnavi = new Form_chkFileNameAfterVerId();
            keepOneChildFormOpen(this, fcfnavi);
        }

        private void tsmi_chkSpaceXML_Click(object sender, EventArgs e)
        {
            Form_chkSpaceXML fcsXML = new Form_chkSpaceXML();
            keepOneChildFormOpen(this, fcsXML);
        }

        private void tsmi_chkRegex_Click(object sender, EventArgs e)
        {
            Form_CheckRegex fcr = new Form_CheckRegex();
            keepOneChildFormOpen(this, fcr);
        }

        private void tsmi_RemSentence_Click(object sender, EventArgs e)
        {
            Form_RemoveSentence frs = new Form_RemoveSentence();
            keepOneChildFormOpen(this, frs);
        }

        private void tsmi_moveBundle_Click(object sender, EventArgs e)
        {
            Form_moveBundle fmb = new Form_moveBundle();
            keepOneChildFormOpen(this, fmb);
        }

        private void tsmi_moveFile_Click(object sender, EventArgs e)
        {
            Form_moveFile fmf = new Form_moveFile();
            keepOneChildFormOpen(this, fmf);
        }

        private void tsmi_ChangeLCode_inFile_Click(object sender, EventArgs e)
        {
            Form_ChangeLCode_inFile fclcif = new Form_ChangeLCode_inFile();
            keepOneChildFormOpen(this, fclcif);
        }

        private void tsmi_ModifyFileForAlign_Click(object sender, EventArgs e)
        {
            Form_ModifyFileForAlign fmffa = new Form_ModifyFileForAlign();
            keepOneChildFormOpen(this, fmffa);
        }

        private void tsmi_ChkCopyrightSymbol_Click(object sender, EventArgs e)
        {
            Form_ChkCopyrightSymbol fccs = new Form_ChkCopyrightSymbol();
            keepOneChildFormOpen(this, fccs);
        }

        private void tsmi_convertXMLtoExcelForTM_Click(object sender, EventArgs e)
        {
            Form_convertXMLtoExcelForTM fcxteftm = new Form_convertXMLtoExcelForTM();
            keepOneChildFormOpen(this, fcxteftm);
        }

        private void tsmi_renameFilePath_Click(object sender, EventArgs e)
        {
            Form_renameFilePath frfp = new Form_renameFilePath();
            keepOneChildFormOpen(this, frfp);
        }

        private void tsmi_pickUpURLsFromXLF_Click(object sender, EventArgs e)
        {
            Form_pickUpURLsFromXLF fpurlfxlf = new Form_pickUpURLsFromXLF();
            keepOneChildFormOpen(this, fpurlfxlf);
        }

        private void tsmi_checkSpecialFormatString_Click(object sender, EventArgs e)
        {
            Form_checkSpecialFormatString fcsfs = new Form_checkSpecialFormatString();
            keepOneChildFormOpen(this, fcsfs);
        }

        private void tsmi_editTagsInXLF_Click(object sender, EventArgs e)
        {
            Form_editTagsInXLF fetixlf = new Form_editTagsInXLF();
            keepOneChildFormOpen(this, fetixlf);
        }

        private void tsmi_regulateXLFForFixingBug_Click(object sender, EventArgs e)
        {
            Form_regulateXLFForFixingBug frxlfffb = new Form_regulateXLFForFixingBug();
            keepOneChildFormOpen(this, frxlfffb);
        }

        private void tsmi_setRegExpOfQAVerification_Click(object sender, EventArgs e)
        {
            Form_setRegExpOfQAVerification fsreoqav = new Form_setRegExpOfQAVerification();
            keepOneChildFormOpen(this, fsreoqav);
        }
    }
}
