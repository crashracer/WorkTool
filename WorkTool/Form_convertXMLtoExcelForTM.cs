using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WorkTool
{
    public partial class Form_convertXMLtoExcelForTM : Form
    {
        public Form_convertXMLtoExcelForTM()
        {
            InitializeComponent();
        }

        public void convertXMLtoExcelForTM(String fileIn, Worksheet ws_term)
        {
            var row = ws_term.UsedRange.Rows.Count;
            var filename = Path.GetFileName(fileIn);
            var content = File.ReadAllText(fileIn);
            content = Regex.Replace(content, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");
            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.CheckCharacters = false;
            xrs.IgnoreWhitespace = false;
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.PreserveWhitespace = true;
            var sr = new StringReader(content);
            using (var xr = XmlReader.Create(sr, xrs))
            {
                XmlDoc.Load(xr);
            }

            var strlistNds = XmlDoc.SelectNodes("//StringList");
            foreach (XmlNode strlistNd in strlistNds)
            {
                row++;

                ws_term.Cells[row, 1].NumberFormatLocal = "@";
                ws_term.Cells[row, 1].Value = filename;

                var sourceNd = strlistNd.SelectSingleNode("./source");
                var sourceStr = sourceNd.InnerXml;
                sourceStr = Regex.Replace(sourceStr, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
                ws_term.Cells[row, 2].NumberFormatLocal = "@";
                ws_term.Cells[row, 2].Value = sourceStr;

                var targetNd = strlistNd.SelectSingleNode("./target");
                var targetStr = targetNd.InnerXml;
                targetStr = Regex.Replace(targetStr, @"<\!\[CDATA\[([\s\S]+?)\]\]>", "$1");
                targetStr = Regex.Replace(targetStr, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
                ws_term.Cells[row, 3].NumberFormatLocal = "@";
                ws_term.Cells[row, 3].Value = targetStr;
            }
        }

        private void Form_convertXMLtoExcelForTM_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_pathIn.Text = "";
            this.comBox_srcLang.Text = "en-US";
            this.proBar_files.Visible = false;
            this.proBar_folders.Visible = false;
            this.btn_convert.Enabled = false;
        }

        private void tb_pathIn_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn.Text))
                this.btn_convert.Enabled = false;
            else
                this.btn_convert.Enabled = true;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            this.proBar_files.Minimum = 0;
            this.proBar_files.Value = 0;
            this.proBar_files.Visible = false;
            
            this.proBar_folders.Minimum = 0;
            this.proBar_folders.Value = 0;
            this.proBar_folders.Visible = false;

            var sourceLang = this.comBox_srcLang.Text;
            var pathIn = this.tb_pathIn.Text;
            if (!Directory.Exists(pathIn))
            {
                MessageBox.Show("The Path Input does not exist.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_pathIn.Text = "";
            }
            else
            {
                if (Directory.GetFiles(pathIn, "*.xml", SearchOption.AllDirectories).Length < 1)
                {
                    MessageBox.Show("There is no any XML file in the Path Input.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.tb_pathIn.Text = "";
                }
                else
                {               
                    this.panel_set.Enabled = false;
                    this.btn_convert.Enabled = false;
                    this.proBar_files.Visible = true;
                    this.proBar_folders.Visible = true;

                    var pathOut = Path.Combine(Path.GetDirectoryName(pathIn), "OutputExcel");
                    if (!Directory.Exists(pathOut))
                        Directory.CreateDirectory(pathOut);

                    var folders = Directory.GetDirectories(pathIn);
                    this.proBar_folders.Maximum = folders.Length;
                    this.proBar_folders.Value = 0;
                    foreach (var folder in folders)
                    {
                        var files = Directory.GetFiles(folder, "*.xml", SearchOption.AllDirectories);
                        if (files.Length >= 1)
                        {
                            var dirInfo = new DirectoryInfo(folder);
                            var excelName = dirInfo.Name;
                            var excelOut = Path.Combine(pathOut, excelName + ".xlsx");
                            if (File.Exists(excelOut))
                                File.Delete(excelOut);

                            Microsoft.Office.Interop.Excel.Application app_term = new Microsoft.Office.Interop.Excel.Application();
                            Workbook wb_term = app_term.Workbooks.Add(true);
                            Worksheet ws_term = new Worksheet();
                            ws_term = wb_term.Worksheets.Add(wb_term.Worksheets.get_Item(1), Missing.Value, Missing.Value, Missing.Value);
                            ws_term.Name = excelName;
                            ws_term.Cells[1, 1].Value = "FileName";
                            ws_term.Cells[1, 2].Value = sourceLang;
                            ws_term.Cells[1, 3].Value = "Localized";

                            this.proBar_files.Maximum = files.Length;
                            this.proBar_files.Value = 0;
                            foreach (var file in files)
                            {
                                convertXMLtoExcelForTM(file, ws_term);
                                this.proBar_files.Value++;
                            }

                            wb_term.SaveAs(excelOut);
                            wb_term.Close();
                            app_term.Quit();
                        }
                        this.proBar_folders.Value++;
                    }

                    MessageBox.Show("Done!!\r\nPlease view the output folder:\r\n" + pathOut, "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.proBar_files.Visible = false;
                    this.panel_set.Enabled = true;
                    this.btn_convert.Enabled = true;
                }
            }
        }
    }
}
