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

namespace WorkTool
{
    public partial class Form_ChangeLCode_inFile : Form
    {
        public Form_ChangeLCode_inFile()
        {
            InitializeComponent();
        }

        public String str_path;
        public bool b_subF;
        public List<FileInfo> l_fileList;

        private void Form_ChangeLCode_inFile_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_path.Text = "";
            this.chkBox_subfolder.Checked = false;
            this.btn_run.Enabled = false;
            this.timer_Change.Enabled = false;

            str_path = "";
            b_subF = false;
            l_fileList = new List<FileInfo>();
        }

        private void chkBox_subfolder_CheckedChanged(object sender, EventArgs e)
        {
            b_subF = this.chkBox_subfolder.Checked;
            //MessageBox.Show(b_subF.ToString());
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_path.Text) || String.IsNullOrWhiteSpace(this.tb_path.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            str_path = this.tb_path.Text;
            l_fileList.Clear();

            if (Directory.Exists(str_path))
            {
                ClassLib_RML.GetFilesListOfFolder(str_path, b_subF, l_fileList);
                if (l_fileList.Count > 0)
                {
                    this.panel_set.Enabled = false;
                    this.btn_run.Enabled = false;
                    this.timer_Change.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No file exists in the path:\r\n" + str_path, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_path.Text = "";
                }
            }
            else
            {
                MessageBox.Show("The path does not exist.\r\n" + str_path, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
            }
        }

        private void timer_Change_Tick(object sender, EventArgs e)
        {
            this.timer_Change.Enabled = false;

            foreach (FileInfo fInfo in l_fileList)
            {
                String str_2LCode = "";
                String str_read = "";
                String str_write = "";
                String str_fNane = fInfo.Name;

                String str_4LCode = str_fNane.Replace(fInfo.Extension, "");
                if (Regex.IsMatch(str_4LCode, @"([a-z]{2})(-|_)([A-Z]{2}|\d+)"))
                {
                    if (str_4LCode == "pt-PT" || str_4LCode == "pt_PT")
                        str_2LCode = "pt_pt";
                    else
                    {
                        Regex rex0 = new Regex(@"(-|_)([A-Z]{2}|\d+)");
                        str_2LCode = rex0.Replace(str_4LCode, "");
                    }

                    StreamReader sr = new StreamReader(fInfo.FullName);
                    str_read = sr.ReadToEnd();
                    sr.Close();

                    String str_Tmp = "";
                    Regex rex1 = new Regex(@"(?<=(window\.cpdfLanguage\['))(en-US|en_US)");
                    String str_Match = rex1.Match(str_read, 0).ToString();
                    if (str_Match == "en-US")
                    {
                        str_4LCode = str_4LCode.Replace("_", "-");
                        str_Tmp = rex1.Replace(str_read, str_4LCode);
                    }
                    else if (str_Match == "en_US")
                    {
                        str_4LCode = str_4LCode.Replace("-", "_");
                        str_Tmp = rex1.Replace(str_read, str_4LCode);
                    }
                    else
                        str_Tmp = str_read;

                    Regex rex2 = new Regex(@"(en)(?=(\.[a-zA-Z\d_]+( |\t)*=))");
                    str_write = rex2.Replace(str_Tmp, str_2LCode);

                    StreamWriter sw = new StreamWriter(fInfo.FullName);
                    sw.Write(str_write);
                    sw.Flush();
                    sw.Close();
                }
            }
            MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.panel_set.Enabled = true;
        }
    }
}
