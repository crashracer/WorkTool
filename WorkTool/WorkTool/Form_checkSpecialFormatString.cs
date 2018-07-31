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
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;

namespace WorkTool
{
    public partial class Form_checkSpecialFormatString : Form
    {
        public Form_checkSpecialFormatString()
        {
            InitializeComponent();
        }

        private String str_cfgfile = Path.Combine(Form_Main.str_configFolder, "CheckSpecialFormatString.ini");
        private List<String> specStrs = new List<String>();

        private void initApp()
        {
            if (!File.Exists(str_cfgfile))
            {
                ClassLib_RML.WriteValueToINI("StringList", "Str1", "en_US", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str2", "en-US", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str3", "MM/dd/yyyy", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str4", "MM-dd-yyyy", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str5", "yyyy/MM/dd", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str6", "yyyy-MM-dd", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str7", "%M/%D/%Y", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str8", "%M-%D-%Y", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str9", "%Y/%M/%D", str_cfgfile);
                ClassLib_RML.WriteValueToINI("StringList", "Str10", "%Y-%M-%D", str_cfgfile);
            }

            specStrs.Clear();
            var strKeys = ClassLib_RML.ReadKeysFromINI("StringList", str_cfgfile);
            this.dataGridView_strList.Rows.Add(strKeys.Count);
            int rowcount = 0;
            foreach (String strKey in strKeys)
            {
                var str = ClassLib_RML.ReadeValueFromINI("StringList", strKey, str_cfgfile);
                this.dataGridView_strList.Rows[rowcount].Cells[0].Value = str;
                specStrs.Add(str);
                rowcount++;
            }
        }

        private String checkSpecialFormatString(String fileIn)
        {
            var content = File.ReadAllText(fileIn);
            var nsdef = Regex.Match(content, @"(?<=<xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            content = Regex.Replace(content, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");

            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.CheckCharacters = false;
            xrs.IgnoreWhitespace = false;
            xrs.NameTable = new NameTable();
            XmlNamespaceManager xnm = new XmlNamespaceManager(xrs.NameTable);
            xnm.AddNamespace("xlfns", nsdef);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            var sr = new StringReader(content);
            using (var xr = XmlReader.Create(sr, xrs))
            {
                xmlDoc.Load(xr);
            }

            String str_log = "";
            var sourceNds = xmlDoc.SelectNodes("//xlfns:source", xnm);
            foreach (XmlNode sourceNd in sourceNds)
            {
                var sourceStr = sourceNd.InnerXml;
                sourceStr = Regex.Replace(sourceStr, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
                sourceStr = sourceStr.Replace(" xmlns=\"" + nsdef + "\"", "");
                foreach (var specStr in specStrs)
                {
                    if (sourceStr.Contains(specStr))
                    {
                        XmlElement xe_TuNd = (XmlElement)sourceNd.ParentNode;
                        var TuId = xe_TuNd.GetAttribute("id");
                        str_log += "trans-unit: id=" + TuId + "\r\nSource String:\t" + sourceStr + "\r\n\r\n";
                        break;
                    }
                }
            }

            if (!String.IsNullOrWhiteSpace(str_log) && !String.IsNullOrEmpty(str_log))
                str_log = fileIn + "\r\n" + str_log;

            return str_log;
        }

        private void Form_checkSpecialFormatString_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_pathInput.Text = "";
            initApp();
            this.btn_save.Enabled = false;
            this.proBar_pro.Visible = false;
            this.btn_check.Enabled = false;
        }

        private void tb_pathInput_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_pathInput.Text) && !String.IsNullOrWhiteSpace(this.tb_pathInput.Text))
                this.btn_check.Enabled = true;
            else
                this.btn_check.Enabled = false;
        }

        private void dataGridView_strList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.btn_save.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            specStrs.Clear();
            foreach (DataGridViewRow row in this.dataGridView_strList.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    var str = row.Cells[0].Value.ToString();
                    if (!String.IsNullOrEmpty(str) && !String.IsNullOrWhiteSpace(str))
                        specStrs.Add(str);
                }
            }

            if (specStrs.Count < 1)
            {
                MessageBox.Show("The String List can not be empty.\r\nThe default list will be used.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                initApp();
            }
            else
            {
                File.Delete(str_cfgfile);
                int strCount = 0;
                foreach (var specStr in specStrs)
                {
                    strCount++;
                    ClassLib_RML.WriteValueToINI("StringList", "Str" + strCount.ToString(), specStr, str_cfgfile);
                }
            }

            this.btn_save.Enabled = false;

            if (!String.IsNullOrEmpty(this.tb_pathInput.Text) && !String.IsNullOrWhiteSpace(this.tb_pathInput.Text))
                this.btn_check.Enabled = true;
            else
                this.btn_check.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_strList.Rows.Count > 1)
            {
                for (int idxrow = this.dataGridView_strList.Rows.Count - 2; idxrow >= 0; idxrow--)
                {
                    this.dataGridView_strList.Rows.RemoveAt(idxrow);
                }
            }

            this.btn_save.Enabled = false;
            this.btn_check.Enabled = false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            this.proBar_pro.Visible = false;
            var pathInput = this.tb_pathInput.Text;
            if (!Directory.Exists(pathInput))
            {
                MessageBox.Show("The Path Input does not exist.\r\n" + pathInput, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_pathInput.Text = "";
            }
            else
            {
                var files = Directory.GetFiles(pathInput, "*.xlf", SearchOption.AllDirectories);
                if (files.Length < 1)
                {
                    MessageBox.Show("There is no any XLF type file in the Path Input.\r\n" + pathInput, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_pathInput.Text = "";
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.proBar_pro.Visible = true;
                    this.proBar_pro.Minimum = 0;
                    this.proBar_pro.Maximum = files.Length;
                    String logFile = Path.Combine(pathInput, "ChkSpecFormatStr_Log.txt");
                    String logText = "";

                    foreach (var file in files)
                    {
                        logText += checkSpecialFormatString(file);
                        this.proBar_pro.Value++;
                    }

                    if (String.IsNullOrEmpty(logText) || String.IsNullOrWhiteSpace(logText))
                        logText = "No special format string need to check customization!";

                    File.WriteAllText(logFile, logText);
                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.panel_set.Enabled = true;
                    this.btn_check.Enabled = true;
                    Process.Start(logFile);
                }
            }
        }
    }
}
