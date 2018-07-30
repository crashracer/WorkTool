using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MyClassLib_rml;
using System.Text.RegularExpressions;

namespace WorkTool
{
    public partial class Form_chkFileNameAfterVerId : Form
    {
        public Form_chkFileNameAfterVerId()
        {
            InitializeComponent();
        }

        public bool b_subfolder;
        public List<FileInfo> l_fileList;
        public String str_filePath;
        ProgressBar proBar_step;

        private void Form_chkFileNameAfterVerId_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_filepath.Text = "";
            this.chkBox_subfolder.Checked = false;
            this.panel_progress.Controls.Clear();
            this.btn_chk.Enabled = false;

            this.timer_listFiles.Enabled = false;
            this.timer_check.Enabled = false;

            b_subfolder = false;
            l_fileList = new List<FileInfo>();
            str_filePath = "";
        }

        private void tb_filepath_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_filepath.Text) || String.IsNullOrWhiteSpace(this.tb_filepath.Text))
            {
                this.btn_chk.Enabled = false;
            }
            else
            {
                this.btn_chk.Enabled = true;
            }
        }

        private void chkBox_subfolder_CheckedChanged(object sender, EventArgs e)
        {
            b_subfolder = this.chkBox_subfolder.Checked;
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            this.panel_progress.Controls.Clear();
            proBar_step = new ProgressBar();
            this.panel_progress.Controls.Add(proBar_step);
            proBar_step.Dock = DockStyle.Fill;
            proBar_step.Maximum = 5;
            proBar_step.Minimum = 0;

            l_fileList.Clear();
            str_filePath = this.tb_filepath.Text;
            proBar_step.Value++;
            if (!Directory.Exists(str_filePath))
            {
                MessageBox.Show("The file path does not exist.\r\n" + str_filePath, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_filepath.Text = "";
                this.panel_progress.Controls.Clear();
            }
            else
            {
                this.panel_set.Enabled = false;
                this.btn_chk.Enabled = false;
                this.timer_listFiles.Enabled = true;
                proBar_step.Value++;
            }
        }

        private void timer_listFiles_Tick(object sender, EventArgs e)
        {
            this.timer_listFiles.Enabled = false;
            List<FileInfo> l_tmp = new List<FileInfo>();
            ClassLib_RML.GetFilesListOfFolder(str_filePath, b_subfolder, l_tmp);
            foreach (FileInfo fInfo in l_tmp)
            {
                if (Regex.IsMatch(fInfo.Extension, @"(?i)^\.xml$"))
                {
                    l_fileList.Add(fInfo);
                }
            }
            proBar_step.Value++;
            if (l_fileList.Count < 1)
            {
                MessageBox.Show("No XML type files found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panel_set.Enabled = true;
                this.tb_filepath.Text = "";
                this.panel_progress.Controls.Clear();
            }
            else
            {
                this.timer_check.Enabled = true;
                proBar_step.Value++;
            }
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            this.timer_check.Enabled = false;
            foreach (FileInfo fInfo in l_fileList)
            {
                StreamReader sr = new StreamReader(fInfo.FullName);
                String str_read = sr.ReadToEnd();
                String str_fName = fInfo.Name.Replace(fInfo.Extension, "");
                String str_write = Regex.Replace(str_read, @"(?<=- @version \$Id: )[a-zA-Z_\-\d]+?(?=\.xml)", str_fName);
                sr.Close();

                StreamWriter sw = new StreamWriter(fInfo.FullName);
                sw.Write(str_write);
                sw.Flush();
                sw.Close();
            }
            proBar_step.Value++;
            MessageBox.Show("Check finished!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.panel_set.Enabled = true;
            this.panel_progress.Controls.Clear();
        }
    }
}
