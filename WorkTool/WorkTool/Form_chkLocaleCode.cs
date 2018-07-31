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
    public partial class Form_chkLocaleCode : Form
    {
        public Form_chkLocaleCode()
        {
            InitializeComponent();
        }

        public String str_filepath;
        public String str_filetype;
        public List<FileInfo> l_filelist;
        public ArrayList al_filetype;

        public void addLabInfo(Label label_info, String str_addText, Color text_color)
        {
            label_info.Text = str_addText;
            label_info.ForeColor = text_color;
        }

        private void Form_chkLocaleCode_Load(object sender, EventArgs e)
        {
            str_filepath = "";
            str_filetype = "";
            l_filelist = new List<FileInfo>();
            al_filetype = new ArrayList();
            this.grpBox_settings.Enabled = true;
            this.tb_filePath.Text = "";
            this.tb_fileType.Text = "xml";
            this.lab_info.Text = "";
            this.btn_check.Enabled = false;
            this.timer_listfiles.Enabled = false;
            this.timer_check.Enabled = false;
        }

        private void tb_filePath_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_filePath.Text) && !String.IsNullOrWhiteSpace(this.tb_filePath.Text))
                this.btn_check.Enabled = true;
            else
                this.btn_check.Enabled = false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            str_filepath = this.tb_filePath.Text;
            str_filetype = this.tb_fileType.Text;
            l_filelist.Clear();
            al_filetype.Clear();
            addLabInfo(this.lab_info, "Reading file type......", Color.White);
            al_filetype = ClassLib_RML.SplitString(str_filetype, ";");
            this.grpBox_settings.Enabled = false;
            this.btn_check.Enabled = false;
            this.timer_listfiles.Enabled = true;
        }

        private void timer_listfiles_Tick(object sender, EventArgs e)
        {
            this.timer_listfiles.Enabled = false;
            addLabInfo(this.lab_info, "Getting files list......", Color.White);
            String str_tmppath = "";
            List<FileInfo> l_tmplist = new List<FileInfo>();

            str_tmppath = Path.Combine(str_filepath, "programassets");
            if (Directory.Exists(str_tmppath))
                ClassLib_RML.GetFilesListOfFolder(str_tmppath, true, l_tmplist);

            str_tmppath = "";
            str_tmppath = Path.Combine(str_filepath, "seed");
            if (Directory.Exists(str_tmppath))
                ClassLib_RML.GetFilesListOfFolder(str_tmppath, true, l_tmplist);

            addLabInfo(this.lab_info, "Filtering files......", Color.White);
            foreach (FileInfo finfo in l_tmplist)
            {
                for (int idx = 0; idx < al_filetype.Count; idx++)
                {
                    if (finfo.Extension == "." + al_filetype[idx])
                        l_filelist.Add(finfo);
                }
            }

            if (l_filelist.Count > 0)
                this.timer_check.Enabled = true;
            else
            {
                MessageBox.Show("Can not find the file need to check.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.grpBox_settings.Enabled = true;
                this.tb_filePath.Text = "";
                addLabInfo(this.lab_info, "Failed operation.", Color.Red);
            }
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            this.timer_check.Enabled = false;
            addLabInfo(this.lab_info, "Begin to check files......", Color.White);
            String str_lang = "";
            String str_logotext = "";
            DirectoryInfo dirInfo = new DirectoryInfo(str_filepath);
            String str_logofile = Path.Combine(dirInfo.Parent.FullName, "check_logo.txt");
            if (File.Exists(str_logofile))
                File.Delete(str_logofile);

            //File.Create(str_logofile);
      
            foreach (FileInfo fInfo in l_filelist)
            {
                addLabInfo(this.lab_info, "Current file: " + fInfo.FullName, Color.White);
                String str_tmp = fInfo.Extension.Replace(".", "");
                Regex regx = new Regex(@"(?<=-|_)[a-z]{2}(-|_)[A-Z]{2}(?=\." + str_tmp + ")");
                str_lang = regx.Match(fInfo.Name, 0).ToString();
                if (!Regex.IsMatch(str_lang, @"[a-z]{2}(-|_)[A-Z]{2}"))
                {
                    str_lang = "";
                    str_lang = fInfo.Directory.Name;
                    if (!Regex.IsMatch(str_lang, @"[a-z]{2}(-|_)[A-Z]{2}"))
                    {
                        str_lang = "";
                        str_logotext += fInfo.FullName + "\r\nCan not identify the language.\r\n\r\n";
                    }
                }

                if (Regex.IsMatch(str_lang, @"[a-z]{2}(-|_)[A-Z]{2}"))
                {
                    Regex rx1 = new Regex(@"(?<=(localeCode=""))[a-z]{2}(-|_)[A-Z]{2}(?="")");
                    Regex rx2 = new Regex(@"(?<=(sourceLocaleCode=""))[a-z]{2}(-|_)[A-Z]{2}(?="")");
                    Regex rx3 = new Regex(@"(?<=(primaryLocaleCode=""))[a-z]{2}(-|_)[A-Z]{2}(?="")");
                    String str_langtmp = "";
                    String str_FileLineTmp = "";
                    int int_linecount = 0;
                    String str_readLine = "";
                    String str_readToEnd = "";
                    StreamReader sr = new StreamReader(fInfo.FullName);

                    str_readLine = sr.ReadLine();
                    while (str_readLine != null)
                    {
                        int_linecount++;
                        str_FileLineTmp = "\r\n" + fInfo.FullName + "\r\nLine: " + int_linecount.ToString() + "\r\n";
                        str_langtmp = rx1.Match(str_readLine, 0).ToString();
                        if (Regex.IsMatch(str_langtmp, @"[a-z]{2}(-|_)[A-Z]{2}"))
                        {
                            if (str_langtmp != str_lang)
                            {
                                str_logotext += str_FileLineTmp + "localeCode=\"" + str_langtmp + "\"\r\n";
                                str_FileLineTmp = "";
                                str_langtmp = "";
                            }
                        }

                        str_langtmp = rx2.Match(str_readLine, 0).ToString();
                        if (Regex.IsMatch(str_langtmp, @"[a-z]{2}(-|_)[A-Z]{2}"))
                        {
                            if (str_langtmp != str_lang)
                            {
                                str_logotext += str_FileLineTmp + "sourceLocaleCode=\"" + str_langtmp + "\"\r\n";
                                str_FileLineTmp = "";
                                str_langtmp = "";
                            }
                        }

                        str_langtmp = rx3.Match(str_readLine, 0).ToString();
                        if (Regex.IsMatch(str_langtmp, @"[a-z]{2}(-|_)[A-Z]{2}"))
                        {
                            if (str_langtmp != str_lang)
                            {
                                str_logotext += str_FileLineTmp + "primaryLocaleCode=\"" + str_langtmp + "\"\r\n";
                                str_FileLineTmp = "";
                                str_langtmp = "";
                            }
                        }

                        str_readLine = sr.ReadLine();
                    }
                    sr.Close();

                    if (!String.IsNullOrEmpty(str_lang) && !String.IsNullOrWhiteSpace(str_lang))
                    {
                        StreamReader sr2 = new StreamReader(fInfo.FullName);
                        str_readToEnd = sr2.ReadToEnd();
                        String str_repTmp1 = Regex.Replace(str_readToEnd, @"(?<=(localeCode=""))[a-z]{2}(-|_)[A-Z]{2}(?="")", str_lang);
                        String str_repTmp2 = Regex.Replace(str_repTmp1, @"(?<=(sourceLocaleCode=""))[a-z]{2}(-|_)[A-Z]{2}(?="")", str_lang);
                        String str_write = Regex.Replace(str_repTmp2, @"(?<=(primaryLocaleCode=""))[a-z]{2}(-|_)[A-Z]{2}(?="")", str_lang);
                        sr2.Close();

                        StreamWriter sw = new StreamWriter(fInfo.FullName);
                        sw.Write(str_write);
                        sw.Flush();
                        sw.Close();
                    }  
                }
            }

            this.grpBox_settings.Enabled = true;
            this.btn_check.Enabled = false;
            if (String.IsNullOrEmpty(str_logotext) || String.IsNullOrWhiteSpace(str_logotext))
            {
                addLabInfo(this.lab_info, "All the LocaleCode are correct!", Color.Lime);
            }
            else
            {
                FileStream fs = new FileStream(str_logofile, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sw_log = new StreamWriter(fs);
                sw_log.Write(str_logotext);
                sw_log.Flush();
                sw_log.Close();
                fs.Close();

                addLabInfo(this.lab_info, "Completed!", Color.Lime);
                Process.Start(str_logofile);
            }
        }
    }
}
