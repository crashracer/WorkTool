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
    public partial class Form_copyXliffToProject : Form
    {
        public Form_copyXliffToProject()
        {
            InitializeComponent();
        }

        public bool b_normal;
        public bool b_locked;
        public bool b_unlocked;

        public bool getProjectXliff(String str_projectLocation, List<String> l_px)
        {
            bool b_get = false;
            var files = Directory.GetFiles(str_projectLocation, "*.sdlxliff", SearchOption.AllDirectories);
            l_px.AddRange(files);

            if (l_px.Count >= 1)
                b_get = true;
            else
                b_get = false;
            
            return b_get;
        }

        public bool getNormalXliff(String str_path, List<String> l_nx)
        {
            bool b_get = false;
            var files = Directory.GetFiles(str_path, "*.sdlxliff", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Path.GetDirectoryName(file));
                if (dirInfo.Name != "ContentLocked" && dirInfo.Name != "UnlockedContents")
                    l_nx.Add(file);
            }

            if (l_nx.Count >= 1)
                b_get = true;
            else
                b_get = false;

            return b_get;
        }

        public bool getLockedXliff(String str_path, List<String> l_lx)
        {
            bool b_get = false;
            var files = Directory.GetFiles(str_path, "*.sdlxliff", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Path.GetDirectoryName(file));
                if (dirInfo.Name == "ContentLocked")
                    l_lx.Add(file);
            }

            if (l_lx.Count >= 1)
                b_get = true;
            else
                b_get = false;

            return b_get;
        }

        public bool getUnlockedXliff(String str_path, List<String> l_ux)
        {
            bool b_get = false;
            var files = Directory.GetFiles(str_path, "*.sdlxliff", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Path.GetDirectoryName(file));
                if (dirInfo.Name == "UnlockedContents")
                    l_ux.Add(file);

            }

            if (l_ux.Count >= 1)
                b_get = true;
            else
                b_get = false;

            return b_get;
        }

        public String getTargetLangXliff(String str_fileXliff)
        {
            var str_read = File.ReadAllText(str_fileXliff);
            String str_lang = "";
            if (Regex.IsMatch(str_read, @"(?<=target-language[ \t]*=[ \t]*"")[^""]+(?="")"))
                str_lang = Regex.Match(str_read, @"(?<=target-language[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            else
                str_lang = "NULL";

            return str_lang;
        }

        private void Form_copyXliffToProject_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_filePath.Text = "";
            this.tb_projLoca.Text = "";
            this.rBtn_normal.Checked = true;
            this.lab_info.Text = "";
            this.btn_copy.Enabled = false;

            b_normal = true;
            b_locked = false;
            b_unlocked = false;
        }

        private void tb_filePath_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_filePath.Text) && !String.IsNullOrWhiteSpace(this.tb_filePath.Text) && !String.IsNullOrEmpty(this.tb_projLoca.Text) && !String.IsNullOrWhiteSpace(this.tb_projLoca.Text))
                this.btn_copy.Enabled = true;
            else
                this.btn_copy.Enabled = false;
        }

        private void tb_projLoca_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_filePath.Text) && !String.IsNullOrWhiteSpace(this.tb_filePath.Text) && !String.IsNullOrEmpty(this.tb_projLoca.Text) && !String.IsNullOrWhiteSpace(this.tb_projLoca.Text))
                this.btn_copy.Enabled = true;
            else
                this.btn_copy.Enabled = false;
        }

        private void rBtn_normal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rBtn_normal.Checked == true)
                b_normal = true;
            else
                b_normal = false;
        }

        private void rBtn_locked_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rBtn_locked.Checked == true)
                b_locked = true;
            else
                b_locked = false;
        }

        private void rBtn_unlocked_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rBtn_unlocked.Checked == true)
                b_unlocked = true;
            else
                b_unlocked = false;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            var str_filePath = this.tb_filePath.Text;
            var str_projLoca = this.tb_projLoca.Text;
            if (!Directory.Exists(str_filePath))
            {
                MessageBox.Show("The File Path does not exist.\r\n" + str_filePath, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.tb_filePath.Text = "";
                this.lab_info.Text = "Please re-enter the File Path.";
            }
            else
            {
                if (!Directory.Exists(str_projLoca))
                {
                    MessageBox.Show("The Project Location does not exist.\r\n" + str_projLoca, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_projLoca.Text = "";
                    this.lab_info.Text = "Please re-enter the Project Location.";
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.btn_copy.Enabled = false;
                    List<String> files_proj = new List<String>();
                    List<String> files_copy = new List<String>();
                    int int_noCopyCount = 0;
                    
                    bool b_getProjXliff = getProjectXliff(str_projLoca, files_proj);
                    bool b_getCopyXliff = false;
                    if (b_normal == true)
                        b_getCopyXliff = getNormalXliff(str_filePath, files_copy);

                    if (b_locked == true)
                        b_getCopyXliff = getLockedXliff(str_filePath, files_copy);

                    if (b_unlocked == true)
                        b_getCopyXliff = getUnlockedXliff(str_filePath, files_copy);

                    if (b_getCopyXliff == true && b_getProjXliff == true)
                    {
                        String str_msgLog = "The following files did not be copied. Please check if they are valid.\r\n\r\n";
                        foreach (var file_copy in files_copy)
                        {
                            String str_lang = getTargetLangXliff(file_copy);
                            if (str_lang != "NULL")
                            {
                                bool b_match = false;
                                foreach (var file_proj in files_proj)
                                {
                                    if (file_proj.ToLower().Contains(Path.Combine(str_projLoca, str_lang).ToLower()) && Path.GetFileName(file_proj).ToLower() == Path.GetFileName(file_copy).ToLower() && getTargetLangXliff(file_proj).ToLower() == str_lang.ToLower())
                                    {
                                        this.lab_info.Text = file_copy;
                                        b_match = true;
                                        File.Delete(file_proj);
                                        File.Copy(file_copy, file_proj);
                                        files_proj.Remove(file_proj);
                                        break;
                                    }
                                }

                                if (b_match == false)
                                {
                                    int_noCopyCount++;
                                    str_msgLog = str_msgLog + "\r\n" + file_copy;
                                }
                            }
                            else
                            {
                                int_noCopyCount++;
                                str_msgLog = str_msgLog + "\r\n" + file_copy;
                            }
                        }

                        if (int_noCopyCount < 1)
                        {
                            MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lab_info.Text = "Completed!";
                            this.panel_set.Enabled = true;
                            this.tb_filePath.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(str_msgLog, "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.lab_info.Text = "Please check.";
                            this.panel_set.Enabled = true;
                            this.tb_filePath.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check if there are available files in the File Path and the Project Location.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.lab_info.Text = "Please check the files!";
                        this.panel_set.Enabled = true;
                        this.btn_copy.Enabled = true;
                    }
                }
            }
        }
    }
}
