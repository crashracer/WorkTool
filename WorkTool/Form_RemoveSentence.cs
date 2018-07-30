using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MyClassLib_rml;

namespace WorkTool
{
    public partial class Form_RemoveSentence : Form
    {
        public Form_RemoveSentence()
        {
            InitializeComponent();
        }

        #region 全局变量或参数
        public bool b_subfolder;
        public String str_filepath;
        public static String str_cfgfile;
        public List<FileInfo> l_listfiles;
        public static ArrayList al_addSen;
        #endregion

        private void Form_RemoveSentence_Load(object sender, EventArgs e)
        {
            this.tb_filepath.Text = "";
            this.btn_addsen.Enabled = false;
            this.btn_start.Enabled = false;
            this.chkBox_subfolder.Checked = false;
            this.lb_info.Items.Clear();
            this.timer_readCfg.Enabled = false;
            this.timer_listFile.Enabled = false;
            this.timer_remove.Enabled = false;

            l_listfiles = new List<FileInfo>();
            al_addSen = new ArrayList();
            b_subfolder = false;
            str_filepath = "";
            str_cfgfile = Path.Combine(Form_Main.str_configFolder, "Remove_Sentence.ini");
            this.timer_readCfg.Enabled = true;
        }

        private void timer_readCfg_Tick(object sender, EventArgs e)
        {
            this.timer_readCfg.Enabled = false;
            if (File.Exists(str_cfgfile))
            {
                ArrayList al_tmp = new ArrayList();
                al_tmp = Form_Main.ReadAllValues("REMOVE_SENTENCES", str_cfgfile);
                if (al_tmp.Count < 1)
                {
                    MessageBox.Show("Please add sentences you want to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form_RemSen_AddSen frsas = new Form_RemSen_AddSen();
                    frsas.ShowDialog();
                }
                else
                {
                    for (int idx = 0; idx < al_tmp.Count; idx++)
                    {
                        String str_tmp = al_tmp[idx].ToString();
                        str_tmp = str_tmp.Replace("$$Rem$$", "");
                        al_addSen.Add(str_tmp);
                    }
                }
            }
            else
            {
                File.Create(str_cfgfile);
                MessageBox.Show("Please add sentences you want to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form_RemSen_AddSen frsas = new Form_RemSen_AddSen();
                frsas.ShowDialog();
            }
            this.btn_addsen.Enabled = true;
        }

        private void tb_filepath_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_filepath.Text) && !String.IsNullOrWhiteSpace(this.tb_filepath.Text))
                this.btn_start.Enabled = true;
            else
                this.btn_start.Enabled = false;
        }

        private void chkBox_subfolder_CheckedChanged(object sender, EventArgs e)
        {
            b_subfolder = this.chkBox_subfolder.Checked;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            str_filepath = this.tb_filepath.Text;
            l_listfiles.Clear();
            this.grpBox_settings.Enabled = false;
            this.btn_start.Enabled = false;
            this.lb_info.Items.Clear();

            if (al_addSen.Count > 0)
                this.timer_listFile.Enabled = true;
            else
            {
                MessageBox.Show("No sentence to be removed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form_Main.AddTextToListbox(this.lb_info, "Please add sentences you want to remove.");
                this.grpBox_settings.Enabled = true;
                this.btn_start.Enabled = true;
            }
        }

        private void btn_addsen_Click(object sender, EventArgs e)
        {
            Form_RemSen_AddSen frsas = new Form_RemSen_AddSen();
            frsas.ShowDialog();
        }

        private void timer_listFile_Tick(object sender, EventArgs e)
        {
            this.timer_listFile.Enabled = false;
            Form_Main.AddTextToListbox(this.lb_info, "Getting files list......");
            ClassLib_RML.GetFilesListOfFolder(str_filepath, b_subfolder, l_listfiles);
            if (l_listfiles.Count > 0)
                this.timer_remove.Enabled = true;
            else
            {
                MessageBox.Show("No file found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Form_Main.AddTextToListbox(this.lb_info, "Can not find any file in the path: " + str_filepath);
                this.grpBox_settings.Enabled = true;
                this.tb_filepath.Text = "";
            }
        }

        private void timer_remove_Tick(object sender, EventArgs e)
        {
            this.timer_remove.Enabled = false;
            Form_Main.AddTextToListbox(this.lb_info, "Begin to remove sentences.");
            foreach (FileInfo finfo in l_listfiles)
            {
                Form_Main.AddTextToListbox(this.lb_info, "Current file: " + finfo.FullName);
                String str_read = "";
                StreamReader sr = new StreamReader(finfo.FullName);
                str_read = sr.ReadToEnd();
                sr.Close();

                for (int idx = 0; idx < al_addSen.Count; idx++)
                {
                    if (str_read.Contains(al_addSen[idx].ToString()))
                    {
                        Form_Main.AddTextToListbox(this.lb_info, "Remove : \"" + al_addSen[idx].ToString() + "\"");
                        str_read = str_read.Replace(al_addSen[idx].ToString() + "\r\n", "");
                    }
                }
                StreamWriter sw = new StreamWriter(finfo.FullName);
                sw.Write(str_read);
                sw.Flush();
                sw.Close();
            }
            MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form_Main.AddTextToListbox(this.lb_info, "Done!");
            this.grpBox_settings.Enabled = true;
            this.tb_filepath.Text = "";
        }
    }
}
