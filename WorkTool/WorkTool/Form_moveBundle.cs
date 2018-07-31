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
using System.IO;

namespace WorkTool
{
    public partial class Form_moveBundle : Form
    {
        public Form_moveBundle()
        {
            InitializeComponent();
        }

        public static String str_cfgIniPath;
        public static ArrayList al_Bundles;
        public static ArrayList al_Folders;

        private void Form_moveBundle_Load(object sender, EventArgs e)
        {
            this.timer_Init.Enabled = false;
            this.grpBox_settings.Enabled = true;
            this.tb_basePath.Text = "";
            this.btn_addSrc.Enabled = false;
            this.btn_run.Enabled = false;
            this.panel_Progress.Controls.Clear();

            str_cfgIniPath = Path.Combine(Form_Main.str_configFolder, "Move_Bundle.ini");
            al_Bundles = new ArrayList();
            al_Folders = new ArrayList();
            this.timer_Init.Enabled = true;
        }

        private void tb_basePath_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_basePath.Text) && !String.IsNullOrWhiteSpace(this.tb_basePath.Text))
                this.btn_run.Enabled = true;
            else
                this.btn_run.Enabled = false;
        }

        private void btn_addSrc_Click(object sender, EventArgs e)
        {
            Form_AddBundleSource fabs = new Form_AddBundleSource();
            fabs.ShowDialog();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            int int_moveCount = 0;
            int int_stillCount = 0;
            String str_basePath = this.tb_basePath.Text;
            if (Directory.Exists(str_basePath))
            {
                List<FileInfo> l_fi = new List<FileInfo>();
                ClassLib_RML.GetFilesListOfFolder(str_basePath, true, l_fi);
                if (l_fi.Count > 0)
                {
                    ProgressBar pb_move = new ProgressBar();
                    this.panel_Progress.Controls.Add(pb_move);
                    pb_move.Dock = DockStyle.Fill;
                    pb_move.Value = 0;
                    pb_move.Minimum = 0;
                    pb_move.Maximum = l_fi.Count;
                    
                    this.grpBox_settings.Enabled = false;
                    this.btn_run.Enabled = false;
                    foreach (FileInfo fInfo in l_fi)
                    {
                        for (int idx = 0; idx < al_Bundles.Count; idx++)
                        {
                            String str_bundleName = al_Bundles[idx].ToString();
                            String str_folderName = al_Folders[idx].ToString();
                            if (fInfo.Name == str_bundleName)
                            {
                                if (str_folderName != "N/A")
                                {
                                    String str_newPath = Path.Combine(fInfo.DirectoryName, str_folderName);
                                    str_newPath = Path.Combine(str_newPath, "ForTrans");
                                    if (!Directory.Exists(str_newPath))
                                        Directory.CreateDirectory(str_newPath);

                                    str_newPath = Path.Combine(str_newPath, fInfo.Name);
                                    if (File.Exists(str_newPath))
                                        File.Delete(str_newPath);

                                    fInfo.MoveTo(str_newPath);
                                    int_moveCount++;
                                    break;
                                }
                            }
                        }
                        pb_move.Value += 1;
                    }
                    int_stillCount = l_fi.Count - int_moveCount;
                    MessageBox.Show("Total Count: " + l_fi.Count.ToString() + "\r\nMoved Count: " + int_moveCount.ToString() + "\r\nNot Moved Count: " + int_stillCount.ToString(), "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grpBox_settings.Enabled = true;
                    this.panel_Progress.Controls.Clear();
                }
                else
                    MessageBox.Show("Can not find files in the Base Path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Can not find the path:\r\n" + str_basePath, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer_Init_Tick(object sender, EventArgs e)
        {
            this.timer_Init.Enabled = false;

            if (File.Exists(str_cfgIniPath))
            {
                ArrayList al_sections = ClassLib_RML.ReadSectionsFromINI(str_cfgIniPath);
                if (al_sections.Count > 0)
                {
                    for (int idx = 0; idx < al_sections.Count; idx++)
                    {
                        String str_bundle = ClassLib_RML.ReadeValueFromINI(al_sections[idx].ToString(), "Bundle", str_cfgIniPath);
                        String str_Folder = ClassLib_RML.ReadeValueFromINI(al_sections[idx].ToString(), "Folder", str_cfgIniPath);

                        if (String.IsNullOrEmpty(str_bundle) || String.IsNullOrWhiteSpace(str_bundle))
                            str_bundle = "N/A";

                        if (String.IsNullOrEmpty(str_Folder) || String.IsNullOrWhiteSpace(str_Folder))
                            str_Folder = "N/A";

                        al_Bundles.Add(str_bundle);
                        al_Folders.Add(str_Folder);
                    }
                }
            }
            else
            {
                File.Create(str_cfgIniPath);
            }
            this.btn_addSrc.Enabled = true;
        }
    }
}
