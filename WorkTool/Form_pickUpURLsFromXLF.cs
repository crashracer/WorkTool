using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml;

namespace WorkTool
{
    public partial class Form_pickUpURLsFromXLF : Form
    {
        public Form_pickUpURLsFromXLF()
        {
            InitializeComponent();
        }

        public void pickUpUrlFromXLF(String fileInput, Worksheet ws_UrlList)
        {
            var rows = ws_UrlList.UsedRange.Rows.Count;
            var fileName = Path.GetFileName(fileInput);
            var content = File.ReadAllText(fileInput);
            var nsdef = Regex.Match(content, @"(?<=xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
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

            var sourceNds = xmlDoc.SelectNodes("//xlfns:source", xnm);
            foreach (XmlNode sourceNd in sourceNds)
            {
                var sourceString = sourceNd.InnerXml;
                sourceString = sourceString.Replace(" xmlns=\"" + nsdef + "\"", "");
                sourceString = Regex.Replace(sourceString, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");

                var matchUrls = Regex.Matches(sourceString, @"(http|ftp|https)://[^\r\n\s<>""']+");
                if (matchUrls.Count >= 1)
                {
                    foreach (Match matchUrl in matchUrls)
                    {
                        rows++;
                        ws_UrlList.Cells[rows, 1].NumberFormatLocal = "@";
                        ws_UrlList.Cells[rows, 1].Value = fileName;

                        ws_UrlList.Cells[rows, 2].NumberFormatLocal = "@";
                        ws_UrlList.Cells[rows, 2].Value = matchUrl.Value;

                        ws_UrlList.Cells[rows, 3].NumberFormatLocal = "@";
                        ws_UrlList.Cells[rows, 3].Value = sourceString;
                    }
                }

                var matchUrls2 = Regex.Matches(sourceString, @"(?<!/)www\.[^\r\n\s<>""']+");
                if (matchUrls2.Count >= 1)
                {
                    foreach (Match matchUrl2 in matchUrls2)
                    {
                        rows++;
                        ws_UrlList.Cells[rows, 1].NumberFormatLocal = "@";
                        ws_UrlList.Cells[rows, 1].Value = fileName;

                        ws_UrlList.Cells[rows, 2].NumberFormatLocal = "@";
                        ws_UrlList.Cells[rows, 2].Value = matchUrl2.Value;

                        ws_UrlList.Cells[rows, 3].NumberFormatLocal = "@";
                        ws_UrlList.Cells[rows, 3].Value = sourceString;
                    }
                }

                var matchUrls3 = Regex.Matches(sourceString, @"[^\r\n\s""<>]+\.(com|cn)");
                if (matchUrls3.Count >= 1)
                {
                    foreach (Match matchUrl3 in matchUrls3)
                    {
                        if (!Regex.IsMatch(matchUrl3.Value, @"(http|ftp|https)://|www\."))
                        {
                            rows++;
                            ws_UrlList.Cells[rows, 1].NumberFormatLocal = "@";
                            ws_UrlList.Cells[rows, 1].Value = fileName;

                            ws_UrlList.Cells[rows, 2].NumberFormatLocal = "@";
                            ws_UrlList.Cells[rows, 2].Value = matchUrl3.Value;

                            ws_UrlList.Cells[rows, 3].NumberFormatLocal = "@";
                            ws_UrlList.Cells[rows, 3].Value = sourceString;
                        }
                    }
                }
            }
        }

        public void pickUpTerminologyFromXLF(String fileInput, Worksheet ws_TermList)
        {
            var rows = ws_TermList.UsedRange.Rows.Count;
            var fileName = Path.GetFileName(fileInput);
            var content = File.ReadAllText(fileInput);
            var nsdef = Regex.Match(content, @"(?<=xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
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

            var sourceNds = xmlDoc.SelectNodes("//xlfns:source", xnm);
            foreach (XmlNode sourceNd in sourceNds)
            {
                var sourceString = sourceNd.InnerXml;
                sourceString = sourceString.Replace(" xmlns=\"" + nsdef + "\"", "");
                sourceString = Regex.Replace(sourceString, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");

                var matchUrls = Regex.Matches(sourceString, @"(\b[A-Z][a-zA-Z0-9.\-]+\b)([\s|\-|\/](\b[A-Z][a-zA-Z0-9.\-]+\b)){1,6}");
                if (matchUrls.Count >= 1)
                {
                    foreach (Match matchUrl in matchUrls)
                    {
                        rows++;
                        ws_TermList.Cells[rows, 1].NumberFormatLocal = "@";
                        ws_TermList.Cells[rows, 1].Value = fileName;

                        ws_TermList.Cells[rows, 2].NumberFormatLocal = "@";
                        ws_TermList.Cells[rows, 2].Value = matchUrl.Value;

                        ws_TermList.Cells[rows, 3].NumberFormatLocal = "@";
                        ws_TermList.Cells[rows, 3].Value = sourceString;
                    }
                }
            }
        }

        private void Form_pickUpURLsFromXLF_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_inputpath.Text = "";
            this.rBtn_url.Checked = true;
            this.rBtn_term.Checked = false;
            this.proBar_steps.Visible = false;
            this.btn_pickup.Enabled = false;
        }

        private void tb_inputpath_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_inputpath.Text) || String.IsNullOrWhiteSpace(this.tb_inputpath.Text))
                this.btn_pickup.Enabled = false;
            else
                this.btn_pickup.Enabled = true;
        }

        private void btn_pickup_Click(object sender, EventArgs e)
        {
            this.proBar_steps.Visible = true;
            this.proBar_steps.Minimum = 0;
            this.proBar_steps.Value = 0;

            var inputpath = this.tb_inputpath.Text;
            if (!Directory.Exists(inputpath))
            {
                MessageBox.Show("The Input Path does not exist.\r\n" + inputpath, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_inputpath.Text = "";
            }
            else
            {
                var files = Directory.EnumerateFiles(inputpath, "*.xlf", SearchOption.AllDirectories);
                if (files.Count() < 1)
                {
                    MessageBox.Show("There is no any applicable file in the Input Path.\r\n" + inputpath, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_inputpath.Text = "";
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.btn_pickup.Enabled = false;
                    this.proBar_steps.Maximum = files.Count();

                    Microsoft.Office.Interop.Excel.Application app_list = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb_list = app_list.Workbooks.Add(true);
                    Worksheet ws_list = new Worksheet();
                    ws_list = wb_list.Worksheets.Add(wb_list.Worksheets.get_Item(1), Missing.Value, Missing.Value, Missing.Value);       
                    ws_list.Cells[1, 1].Value = "File Name";                  
                    ws_list.Cells[1, 3].Value = "Source String";
                    Range wsRang = ws_list.get_Range((Range)ws_list.Cells[1, 1], (Range)ws_list.Cells[1, 3]);
                    wsRang.Font.Bold = true;

                    var listoutfile = String.Empty;
                    if (this.rBtn_url.Checked)
                    {
                        listoutfile = Path.Combine(inputpath, "URL_List.xlsx");
                        if (File.Exists(listoutfile))
                            File.Delete(listoutfile);

                        ws_list.Name = "URL_List";
                        ws_list.Cells[1, 2].Value = "URL";

                        foreach (var file in files)
                        {
                            pickUpUrlFromXLF(file, ws_list);
                            this.proBar_steps.Value++;
                        }
                    }
                    else
                    {
                        listoutfile = Path.Combine(inputpath, "Term_List.xlsx");
                        if (File.Exists(listoutfile))
                            File.Delete(listoutfile);

                        ws_list.Name = "Term_List";
                        ws_list.Cells[1, 2].Value = "Terminology";

                        foreach (var file in files)
                        {
                            pickUpTerminologyFromXLF(file, ws_list);
                            this.proBar_steps.Value++;
                        }
                    }

                    bool b_save = true;
                    if (ws_list.UsedRange.Rows.Count < 2)
                        b_save = false;

                    wb_list.SaveAs(listoutfile);
                    wb_list.Close();
                    app_list.Quit();

                    if (!b_save)
                        File.Delete(listoutfile);

                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.panel_set.Enabled = true;
                    this.btn_pickup.Enabled = true;
                }
            }
        }
    }
}
