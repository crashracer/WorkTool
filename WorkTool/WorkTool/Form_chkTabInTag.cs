using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyClassLib_rml;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WorkTool
{
    public partial class Form_chkTabInTag : Form
    {
        public Form_chkTabInTag()
        {
            InitializeComponent();
        }

        public bool b_subFolder;
        public String str_FilePath;
        public List<FileInfo> l_fileList;

        public void addMsgToLab(Label lab, String str_msg, Color co_msg)
        {
            lab.Text = str_msg;
            lab.ForeColor = co_msg;
        }

        private void Form_chkTabInTag_Load(object sender, EventArgs e)
        {
            this.panel_setting.Enabled = true;
            this.tb_filePath.Text = "";
            this.chkBox_subfolder.Checked = false;
            this.lab_msg.Text = "";
            this.btn_check.Enabled = false;

            this.timer_listFiles.Enabled = false;
            this.timer_check.Enabled = false;

            b_subFolder = false;
            str_FilePath = "";
            l_fileList = new List<FileInfo>();
        }

        private void tb_filePath_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_filePath.Text) || String.IsNullOrWhiteSpace(this.tb_filePath.Text))
            {
                this.btn_check.Enabled = false;
            }
            else
            {
                this.btn_check.Enabled = true;
            }
        }

        private void chkBox_subfolder_CheckedChanged(object sender, EventArgs e)
        {
            b_subFolder = this.chkBox_subfolder.Checked;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            l_fileList.Clear();
            str_FilePath = this.tb_filePath.Text;
            if (Directory.Exists(str_FilePath))
            {
                this.panel_setting.Enabled = false;
                this.btn_check.Enabled = false;
                this.timer_listFiles.Enabled = true;
            }
            else
            {
                MessageBox.Show("The file path does not exist.\r\n" + str_FilePath, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addMsgToLab(this.lab_msg, "Wrong file path.", Color.Red);
                this.tb_filePath.Text = "";
            }
            
        }

        private void timer_listFiles_Tick(object sender, EventArgs e)
        {
            this.timer_listFiles.Enabled = false;
            addMsgToLab(this.lab_msg, "Filtering files......", Color.Blue);
            List<FileInfo> l_tmp = new List<FileInfo>();
            ClassLib_RML.GetFilesListOfFolder(str_FilePath, b_subFolder, l_tmp);
            foreach (FileInfo fInfo in l_tmp)
            {
                if (Regex.IsMatch(fInfo.Extension, @"(?i)^\.xml$"))
                {
                    l_fileList.Add(fInfo);
                }
            }

            if (l_fileList.Count < 1)
            {
                MessageBox.Show("No file need to check!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addMsgToLab(this.lab_msg, "No XML type files found.", Color.Black);
                this.panel_setting.Enabled = true;
                this.tb_filePath.Text = "";
            }
            else
            {
                addMsgToLab(this.lab_msg, "Please wait! Checking files......", Color.Blue);
                this.timer_check.Enabled = true;
            }
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            this.timer_check.Enabled = false;
            String str_logotext = "";
            DirectoryInfo dirInfo = new DirectoryInfo(str_FilePath);
            String str_logofile = Path.Combine(dirInfo.Parent.FullName, "check_info.txt");
            if (File.Exists(str_logofile))
                File.Delete(str_logofile);

            foreach (FileInfo fInfo in l_fileList)
            {
                StreamReader sr1 = new StreamReader(fInfo.FullName);
                String str_readToEnd = sr1.ReadToEnd();
                sr1.Close();
                String str_write = Regex.Replace(str_readToEnd, @"\t(?=[\t\r\n ]*[a-zA-Z\d_]+="")", "    ");

                StreamWriter sw = new StreamWriter(fInfo.FullName);
                sw.Write(str_write);
                sw.Flush();
                sw.Close();

                StreamReader sr2 = new StreamReader(fInfo.FullName);
                String str_readLine = sr2.ReadLine();
                int int_lineNum = 0;
                String str_logTmp = "";
                while (str_readLine != null)
                {
                    int_lineNum++;
                    int int_mTmp = Regex.Matches(str_readLine, @"\t").Count;
                    if (int_mTmp >= 1)
                    {
                        str_logTmp = str_logTmp + "Line: " + int_lineNum.ToString() + "\r\n" + str_readLine + "\r\nTotal: " + int_mTmp.ToString() + "\r\n\r\n";
                    }
                    str_readLine = sr2.ReadLine();
                }
                sr2.Close();

                if (!String.IsNullOrEmpty(str_logTmp) && !String.IsNullOrWhiteSpace(str_logTmp))
                {
                    str_logotext = str_logotext + "\r\n" + fInfo.FullName + "\r\n" + str_logTmp;
                }
            }

            addMsgToLab(this.lab_msg, "Completed.", Color.Green);
            this.panel_setting.Enabled = true;
            this.btn_check.Enabled = false;
            if (String.IsNullOrEmpty(str_logotext) || String.IsNullOrWhiteSpace(str_logotext))
            { 
                MessageBox.Show("Done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FileStream fs = new FileStream(str_logofile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw_log = new StreamWriter(fs);
                sw_log.Write(str_logotext);
                sw_log.Flush();
                sw_log.Close();
                fs.Close();

                MessageBox.Show("Some Tabs did not be converted.\r\nPlease read the logo file to get information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(str_logofile);
            }
        }
    }
}
