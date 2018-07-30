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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections;

namespace WorkTool
{
    public partial class Form_CopyXliff : Form
    {
        public Form_CopyXliff()
        {
            InitializeComponent();
        }

        public bool b_sync;
        public bool b_tm;
        public bool b_xml;

        public int copyXliffFiles(String pathIn, String sourceLang, String pathOut)
        {
            int copyCount = 0;
            var dirs = Directory.GetDirectories(pathIn, "*-*", SearchOption.TopDirectoryOnly);
            foreach (var dir in dirs)
            { 
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                var dirName = dirInfo.Name;
                if (Regex.IsMatch(dirName, @"[a-z]{2}-[A-Z]{2}") && dirName.Length == 5 && dirName != sourceLang)
                {
                    var files = Directory.GetFiles(dir, "*.sdlxliff", SearchOption.AllDirectories);
                    if (files.Length >= 1)
                    {
                        var pathOutLang = Path.Combine(pathOut, dirName);
                        if (!Directory.Exists(pathOutLang))
                            Directory.CreateDirectory(pathOutLang);

                        foreach (var file in files)
                        {

                            var fileOut = Path.Combine(pathOutLang, Path.GetFileName(file));
                            if (File.Exists(fileOut))
                                File.Delete(fileOut);

                            Form_Main.AddTextToListbox(this.lb_info, "Copy: \"" + file + "\" To \"" + fileOut + "\".");
                            File.Copy(file, fileOut);
                            copyCount++;
                        }
                    }
                }
            }

            return copyCount;
        }

        public int copyTargetFiles(String pathIn, String sourceLang, String pathOut)
        {
            int copyCount = 0;
            var dirs = Directory.GetDirectories(pathIn, "*-*", SearchOption.TopDirectoryOnly);
            foreach (var dir in dirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                var dirName = dirInfo.Name;
                if (Regex.IsMatch(dirName, @"[a-z]{2}-[A-Z]{2}") && dirName.Length == 5 && dirName != sourceLang)
                {
                    var files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);
                    if (files.Length >= 1)
                    {
                        var pathOutLang = Path.Combine(pathOut, dirName);
                        foreach (var file in files)
                        {
                            var type = Path.GetExtension(file).ToLower();
                            if (type != ".sdlxliff")
                            {
                                if (!Directory.Exists(pathOutLang))
                                    Directory.CreateDirectory(pathOutLang);

                                var fileOut = Path.Combine(pathOutLang, Path.GetFileName(file));
                                if (File.Exists(fileOut))
                                    File.Delete(fileOut);

                                Form_Main.AddTextToListbox(this.lb_info, "Copy: \"" + file + "\" To \"" + fileOut + "\".");
                                File.Copy(file, fileOut);
                                copyCount++;
                            }
                        }
                    }
                }
            }

            return copyCount;
        }

        private void Form_CopyXliff_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_path.Text = "";
            this.comBox_sourceLang.Text = "en-US";
            this.rbtn_sync.Checked = true;
            b_sync = true;
            this.rbtn_TM.Checked = false;
            b_tm = false;
            this.rbtn_xml.Checked = false;
            b_xml = false;
            this.lb_info.Items.Clear();
            this.btn_run.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text))
                this.btn_run.Enabled = true;
            else
                this.btn_run.Enabled = false;
        }

        private void rbtn_sync_CheckedChanged(object sender, EventArgs e)
        {
            b_sync = this.rbtn_sync.Checked;
        }

        private void rbtn_TM_CheckedChanged(object sender, EventArgs e)
        {
            b_tm = this.rbtn_TM.Checked;
        }

        private void rbtn_xml_CheckedChanged(object sender, EventArgs e)
        {
            b_xml = this.rbtn_xml.Checked;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.lb_info.Items.Clear();
            var sourceLang = this.comBox_sourceLang.Text;
            var pathIn = this.tb_path.Text;
            if (!Directory.Exists(pathIn))
            {
                MessageBox.Show("The Project Location does not exist.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
                Form_Main.AddTextToListbox(this.lb_info, "Please enter a valid Project Location.");
            }
            else
            {
                this.panel_set.Enabled = false;
                this.btn_run.Enabled = false;
                int copyCount = 0;
                var pathOut = Directory.GetParent(pathIn).FullName;
                if (b_sync)
                {
                    pathOut = Path.Combine(pathOut, "3_ForTrans_Xliff");
                    copyCount = copyXliffFiles(pathIn, sourceLang, pathOut);
                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Main.AddTextToListbox(this.lb_info, copyCount.ToString() + " file(s) copied.");
                }
                else if (b_tm)
                {
                    pathOut = Path.Combine(pathOut, "3_ForTM_Xliff");
                    copyCount = copyXliffFiles(pathIn, sourceLang, pathOut);
                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Main.AddTextToListbox(this.lb_info, copyCount.ToString() + " file(s) copied.");
                }
                else if (b_xml)
                {
                    pathOut = Path.Combine(pathOut, "4_TargetTranslated");
                    copyCount = copyTargetFiles(pathIn, sourceLang, pathOut);
                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Main.AddTextToListbox(this.lb_info, copyCount.ToString() + " file(s) copied.");
                }
                else
                {
                    MessageBox.Show("Please select what files need to copy.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form_Main.AddTextToListbox(this.lb_info, "Need to select an option.");
                }

                this.panel_set.Enabled = true;
                this.btn_run.Enabled = true;
                if(copyCount >= 1)
                    Process.Start("explorer.exe", pathOut);
            }
        }
    }
}
