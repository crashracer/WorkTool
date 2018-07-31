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
using System.Diagnostics;

namespace WorkTool
{
    public partial class Form_chkSpaceXML : Form
    {
        public Form_chkSpaceXML()
        {
            InitializeComponent();
        }

        public String str_path;
        public bool b_sub;
        public List<FileInfo> l_fileList;
        ProgressBar progBar_step;

        private void Form_chkSpaceXML_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_path.Text = "";
            this.chkBox_subfolder.Checked = false;
            this.panel_progBar.Controls.Clear();
            this.btn_chk.Enabled = false;

            this.timer_listFile.Enabled = false;
            this.timer_check.Enabled = false;

            str_path = "";
            b_sub = false;
            l_fileList = new List<FileInfo>();
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_path.Text) || String.IsNullOrWhiteSpace(this.tb_path.Text))
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
            b_sub = this.chkBox_subfolder.Checked;
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            this.panel_progBar.Controls.Clear();
            progBar_step = new ProgressBar();
            this.panel_progBar.Controls.Add(progBar_step);
            progBar_step.Dock = DockStyle.Fill;
            progBar_step.Minimum = 0;
            progBar_step.Maximum = 7;

            l_fileList.Clear();
            str_path = this.tb_path.Text;
            progBar_step.Value++;
            if (!Directory.Exists(str_path))
            {
                MessageBox.Show("The path does not exist.\r\n" + str_path, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
                this.panel_progBar.Controls.Clear();
            }
            else
            {
                this.panel_set.Enabled = false;
                this.btn_chk.Enabled = false;
                this.timer_listFile.Enabled = true;
                progBar_step.Value++;
            }
        }

        private void timer_listFile_Tick(object sender, EventArgs e)
        {
            this.timer_listFile.Enabled = false;
            List<FileInfo> l_tmp = new List<FileInfo>();
            ClassLib_RML.GetFilesListOfFolder(str_path, b_sub, l_tmp);
            foreach (FileInfo fInfo in l_tmp)
            {
                if (Regex.IsMatch(fInfo.Extension, @"(?i)^\.xml$"))
                {
                    l_fileList.Add(fInfo);
                }
            }
            progBar_step.Value++;
            if (l_fileList.Count < 1)
            {
                MessageBox.Show("No XML type files found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.panel_set.Enabled = true;
                this.tb_path.Text = "";
                this.panel_progBar.Controls.Clear();
            }
            else
            {
                this.timer_check.Enabled = true;
                progBar_step.Value++;
            }
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            this.timer_check.Enabled = false;
            String str_chkLogText = "";
            DirectoryInfo dirInfo = new DirectoryInfo(str_path);
            String str_chkLogFile = Path.Combine(dirInfo.Parent.FullName, "check_log.txt");
            if (File.Exists(str_chkLogFile))
                File.Delete(str_chkLogFile);

            progBar_step.Value++;
            foreach (FileInfo fInfo in l_fileList)
            {
                String str_logTmp = "";
                int int_lineNum = 0;
                StreamReader sr = new StreamReader(fInfo.FullName);
                String str_readLine = sr.ReadLine();
                while (str_readLine != null)
                {
                    int_lineNum++;
                    if (str_readLine.Contains("&nbsp;"))
                    {
                        str_logTmp = str_logTmp + "Line: " + int_lineNum.ToString() + "\r\n" + str_readLine + "\r\n\r\n";
                    }
                    str_readLine = sr.ReadLine();
                }
                sr.Close();
                if (!String.IsNullOrEmpty(str_logTmp) && !String.IsNullOrWhiteSpace(str_logTmp))
                {
                    str_chkLogText = str_chkLogText + "\r\n" + fInfo.FullName + "\r\n" + str_logTmp;
                }
            }
            progBar_step.Value++;
            if (!String.IsNullOrEmpty(str_chkLogText) && !String.IsNullOrWhiteSpace(str_chkLogText))
            {
                FileStream fs = new FileStream(str_chkLogFile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(str_chkLogText);
                sw.Flush();
                sw.Close();
                fs.Close();

                progBar_step.Value++;
                MessageBox.Show("Check finished!\r\nPlease read log file to get information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(str_chkLogFile);
            }
            else
            {
                progBar_step.Value++;
                MessageBox.Show("Check finished!\r\nDo not find Space( &nbsp; ) in all files.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            panel_progBar.Controls.Clear();
            this.panel_set.Enabled = true;
        }
    }
}
