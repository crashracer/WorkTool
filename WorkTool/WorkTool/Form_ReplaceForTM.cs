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

namespace WorkTool
{
    public partial class Form_ReplaceForTM : Form
    {
        public Form_ReplaceForTM()
        {
            InitializeComponent();
        }

        public bool b_XML;
        public bool b_XLIFF;
        public bool b_SignOff;

        public List<String> getXliffFiles(String pathIn, String sourceLang)
        {
            List<String> ls_files = new List<String>();
            var dirs = Directory.GetDirectories(pathIn, "*-*", SearchOption.TopDirectoryOnly);
            foreach (var dir in dirs)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                var dirName = dirInfo.Name;
                if (Regex.IsMatch(dirName, @"[a-z]{2}-[A-Z]{2}") && dirName.Length == 5 && dirName != sourceLang)
                {
                    var files = Directory.GetFiles(dir, "*.sdlxliff", SearchOption.AllDirectories);
                    if (files.Length >= 1)
                        ls_files.AddRange(files);
                }
            }

            return ls_files;
        }

        private void Form_ReplaceForTM_Load(object sender, EventArgs e)
        {          
            this.grpBox_settings.Enabled = true;
            this.tb_path.Text = "";
            this.rdbtn_xml.Checked = true;
            b_XML = true;
            this.rdbtn_xliff.Checked = false;
            b_XLIFF = false;
            this.rdbtn_SignOff.Checked = false;
            b_SignOff = false;
            this.panel_sourceLang.Visible = false;
            this.btn_replace.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text))
            {
                if (this.rdbtn_xliff.Checked || this.rdbtn_xml.Checked || this.rdbtn_SignOff.Checked)
                    this.btn_replace.Enabled = true;
                else
                    this.btn_replace.Enabled = false;
            }
            else
                this.btn_replace.Enabled = false;
        }

        private void rdbtn_xml_CheckedChanged(object sender, EventArgs e)
        {
            b_XML = this.rdbtn_xml.Checked;
            this.panel_sourceLang.Visible = false;
        }

        private void rdbtn_xliff_CheckedChanged(object sender, EventArgs e)
        {
            b_XLIFF = this.rdbtn_xliff.Checked;
            if (this.panel_sourceLang.Visible == false)
            {
                this.panel_sourceLang.Visible = true;
                this.comBox_srcLang.Text = "en-US";
            }
        }

        private void rdbtn_SignOff_CheckedChanged(object sender, EventArgs e)
        {
            b_SignOff = this.rdbtn_SignOff.Checked;
            if (this.panel_sourceLang.Visible == false)
            {
                this.panel_sourceLang.Visible = true;
                this.comBox_srcLang.Text = "en-US";
            }
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            var pathIn = this.tb_path.Text;
            if (!Directory.Exists(pathIn))
            {
                MessageBox.Show("The Path Input does not exist.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
            }
            else
            {
                this.grpBox_settings.Enabled = false;
                this.btn_replace.Enabled = false;
                
                if (b_XML)
                {
                    var files = Directory.GetFiles(pathIn, "*.xml", SearchOption.AllDirectories);
                    if (files.Length < 1)
                    {
                        MessageBox.Show("There is no any XML type file in the path.\r\n" + pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.grpBox_settings.Enabled = true;
                        this.tb_path.Text = "";
                    }
                    else
                    {
                        int repCount = 0;
                        var pathBackup = pathIn + "_Backup";
                        foreach (var file in files)
                        {
                            var fileBackup = file.Replace(pathIn, pathBackup);
                            if (File.Exists(fileBackup))
                                File.Delete(fileBackup);

                            if (!Directory.Exists(Path.GetDirectoryName(fileBackup)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileBackup));

                            File.Copy(file, fileBackup);
                            var content = File.ReadAllText(file);
                            repCount += Regex.Matches(content, @"(<source>((?:(?!</source>).)+)</source>\r\n<target><!\[CDATA\[)((?:(?!</target>).)+)(\]\]></target>)").Count;
                            var rep = Regex.Replace(content, @"(<source>((?:(?!</source>).)+)</source>\r\n<target><!\[CDATA\[)((?:(?!</target>).)+)(\]\]></target>)", "$1$2\tJZ\t$3$4");
                            File.WriteAllText(file, rep, Encoding.UTF8);
                        }

                        MessageBox.Show("Done!\r\n" + repCount.ToString() + " replaced.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.grpBox_settings.Enabled = true;
                        this.btn_replace.Enabled = true;
                    }
                }
                else
                {
                    var sourceLang = this.comBox_srcLang.Text;
                    var files = getXliffFiles(pathIn, sourceLang);
                    if (files.Count < 1)
                    {
                        MessageBox.Show("There is no any SDLXLIFF type file in the path.\r\n" + pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.grpBox_settings.Enabled = true;
                        this.tb_path.Text = "";
                    }
                    else
                    {
                        String pathBackup = "";
                        if(b_XLIFF)
                            pathBackup = pathIn + "_Backup";
                        else
                            pathBackup = pathIn + "_Backup_SignOff";


                        int repCount = 0;
                        foreach (var file in files)
                        {                  
                            var fileBackup = file.Replace(pathIn, pathBackup);
                            if (File.Exists(fileBackup))
                                File.Delete(fileBackup);

                            if (!Directory.Exists(Path.GetDirectoryName(fileBackup)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileBackup));

                            File.Copy(file, fileBackup);
                            var content = File.ReadAllText(file);
                            if (b_XLIFF)
                            {
                                repCount += Regex.Matches(content, @"(<seg-source><mrk\b([^>]+)>)((?:(?!</seg-source>).)+)\tJZ\t((?:(?!</seg-source>).)+)(</mrk></seg-source><target><mrk)\2\s*/></target>").Count;
                                var rep1 = Regex.Replace(content, @"<source>((?:(?!</source>).)+)\tJZ\t((?:(?!</source>).)+)</source>", "<source>$1</source>");
                                var rep2 = Regex.Replace(rep1, @"(<seg-source><mrk\b([^>]+)>)((?:(?!</seg-source>).)+)\tJZ\t((?:(?!</seg-source>).)+)(</mrk></seg-source><target><mrk)\2\s*/></target>", "$1$3$5$2>$4</mrk></target>");
                                File.WriteAllText(file, rep2, Encoding.UTF8);
                            }
                            else
                            {
                                repCount += Regex.Matches(content, @"(</mrk></target><sdl:seg-defs><sdl:seg id=""\d+"")(/>)").Count;
                                var rep = Regex.Replace(content, @"(</mrk></target><sdl:seg-defs><sdl:seg id=""\d+"")(/>)", "$1 conf=\"ApprovedSignOff\"$2");
                                File.WriteAllText(file, rep, Encoding.UTF8);
                            }
                        }

                        MessageBox.Show("Done!\r\n" + repCount.ToString() + " replaced.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.grpBox_settings.Enabled = true;
                        this.btn_replace.Enabled = true;
                    }
                }
            }
        }
    }
}
