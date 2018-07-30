using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyClassLib_rml;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;

namespace WorkTool
{
    public partial class Form_AddBundleSource : Form
    {
        public Form_AddBundleSource()
        {
            InitializeComponent();
        }

        #region Win API 函数及常量
        const int SB_VERT = 0x0001;
        const int WM_VSCROLL = 0x0115;
        const int SB_THUMBPOSITION = 0x0004;

        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hwnd, int nbar);

        [DllImport("user32.dll")]
        public static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool Rush);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        #endregion

        int int_bPos;
        int int_fPos;
        String str_cfgPath;

        private void Form_AddBundleSource_Load(object sender, EventArgs e)
        {   
            this.timer_Init.Enabled = false;
            this.timer_scrSb.Enabled = false;
            this.btn_clear.Enabled = false;
            this.btn_save.Enabled = false;
            this.tb_bundles.Text = "";
            this.tb_folders.Text = "";
            this.lab_bundCount.Text = "";
            this.lab_foldCount.Text = "";
            this.timer_Init.Enabled = true;
        }

        private void timer_Init_Tick(object sender, EventArgs e)
        {
            this.timer_Init.Enabled = false;
            if (Form_moveBundle.al_Bundles.Count > 0)
            {
                String str_BundleTxt = "";
                String str_FolderTxt = "";
                for (int idx = 0; idx < Form_moveBundle.al_Bundles.Count; idx++)
                {
                    str_BundleTxt += Form_moveBundle.al_Bundles[idx] + "\r\n";
                    str_FolderTxt += Form_moveBundle.al_Folders[idx] + "\r\n";
                }
                this.tb_bundles.Text = str_BundleTxt;
                this.tb_folders.Text = str_FolderTxt;
                this.btn_clear.Enabled = true;
                this.btn_save.Enabled = true;
                this.timer_scrSb.Enabled = true;
                int_bPos = GetScrollPos(this.tb_bundles.Handle, SB_VERT);
                int_fPos = GetScrollPos(this.tb_folders.Handle, SB_VERT);
                str_cfgPath = Form_moveBundle.str_cfgIniPath;
            }
        }

        private void tb_bundles_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_bundles.Text) && !String.IsNullOrWhiteSpace(this.tb_bundles.Text))
            {
                if (!String.IsNullOrEmpty(this.tb_folders.Text) && !String.IsNullOrWhiteSpace(this.tb_folders.Text))
                    this.btn_save.Enabled = true;
                else
                    this.btn_save.Enabled = false;
            }
            else
                this.btn_save.Enabled = false;

            ArrayList al_tmp = ClassLib_RML.SplitString(this.tb_bundles.Text, "\r\n");
            int int_cot = 0;
            for (int idx = 0; idx < al_tmp.Count; idx++)
            {
                if (!String.IsNullOrEmpty(al_tmp[idx].ToString()) && !String.IsNullOrWhiteSpace(al_tmp[idx].ToString()))
                    int_cot++;
            }
            this.lab_bundCount.Text = int_cot.ToString() + " item(s)";
        }

        private void tb_folders_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_bundles.Text) && !String.IsNullOrWhiteSpace(this.tb_bundles.Text))
            {
                if (!String.IsNullOrEmpty(this.tb_folders.Text) && !String.IsNullOrWhiteSpace(this.tb_folders.Text))
                    this.btn_save.Enabled = true;
                else
                    this.btn_save.Enabled = false;
            }
            else
                this.btn_save.Enabled = false;

            ArrayList al_tmp = ClassLib_RML.SplitString(this.tb_folders.Text, "\r\n");
            int int_cot = 0;
            for (int idx = 0; idx < al_tmp.Count; idx++)
            {
                if (!String.IsNullOrEmpty(al_tmp[idx].ToString()) && !String.IsNullOrWhiteSpace(al_tmp[idx].ToString()))
                    int_cot++;
            }
            this.lab_foldCount.Text = int_cot.ToString() + " item(s)";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.tb_bundles.Text = "";
            this.tb_folders.Text = "";
        }

        private void timer_scrSb_Tick(object sender, EventArgs e)
        {
            int int_pos = 0;
            int_pos = GetScrollPos(this.tb_bundles.Handle, SB_VERT);
            if (int_pos != int_bPos)
            {
                int_bPos = int_pos;
                int_fPos = int_pos;
                int tmp = SetScrollPos(this.tb_folders.Handle, SB_VERT, int_pos, true);
                int tmp2 = SendMessage(this.tb_folders.Handle, WM_VSCROLL, SB_THUMBPOSITION + 0x10000 * int_pos, 0);
            }
            else
            {
                int_pos = GetScrollPos(this.tb_folders.Handle, SB_VERT);
                if (int_pos != int_fPos)
                {
                    int_bPos = int_pos;
                    int_fPos = int_pos;
                    int tmp = SetScrollPos(this.tb_bundles.Handle, SB_VERT, int_pos, true);
                    int tmp2 = SendMessage(this.tb_bundles.Handle, WM_VSCROLL, SB_THUMBPOSITION + 0x10000 * int_pos, 0);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ArrayList al_budTmp = ClassLib_RML.SplitString(this.tb_bundles.Text, "\r\n");
            ArrayList al_fodTmp = ClassLib_RML.SplitString(this.tb_folders.Text, "\r\n");
            if (al_budTmp.Count == al_fodTmp.Count)
            {
                Form_moveBundle.al_Bundles.Clear();
                Form_moveBundle.al_Folders.Clear();
                File.Delete(str_cfgPath);

                for (int idx = 0; idx < al_budTmp.Count; idx++)
                {
                    String str_bTmp = al_budTmp[idx].ToString();
                    String str_fTmp = al_fodTmp[idx].ToString();

                    if (String.IsNullOrEmpty(str_bTmp) || String.IsNullOrWhiteSpace(str_bTmp))
                        str_bTmp = "N/A";

                    if (String.IsNullOrEmpty(str_fTmp) || String.IsNullOrWhiteSpace(str_fTmp))
                        str_fTmp = "N/A";

                    Form_moveBundle.al_Bundles.Add(str_bTmp);
                    Form_moveBundle.al_Folders.Add(str_fTmp);

                    ClassLib_RML.WriteValueToINI("BUNDLE" + idx.ToString(), "Bundle", str_bTmp, str_cfgPath);
                    ClassLib_RML.WriteValueToINI("BUNDLE" + idx.ToString(), "Folder", str_fTmp, str_cfgPath);
                }
                this.Close();
            }
            else
                MessageBox.Show("The number of bundle is not same with folder's.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
