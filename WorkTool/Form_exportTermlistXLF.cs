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
using System.Xml;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WorkTool
{
    public partial class Form_exportTermlistXLF : Form
    {
        public Form_exportTermlistXLF()
        {
            InitializeComponent();
        }

        public void exportTermlistFromXLF(String fileIn, Workbook wb_term)
        {
            var content = File.ReadAllText(fileIn);
            var filename = Regex.Match(content, @"(?<=<file\b.*original[ \t]*=[ \t]*"")[^""]+?(?="")").Value;
            var nsdef = Regex.Match(content, @"(?<=xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            var lang = Regex.Match(content, @"(?<=target-language[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            content = Regex.Replace(content, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");
            Worksheet ws_term = new Worksheet();
            try
            {
                ws_term = wb_term.Worksheets["SP_" + lang];
            }
            catch
            {
                ws_term = wb_term.Worksheets.Add(wb_term.Worksheets.get_Item(1), Missing.Value, Missing.Value, Missing.Value);
                ws_term.Name = "SP_" + lang;
                ws_term.Cells[1, 1].Value = "filename";
                ws_term.Cells[1, 2].Value = "context";
                ws_term.Cells[1, 3].Value = "text";
                ws_term.Cells[1, 4].Value = "translation";
                ws_term.Cells[1, 5].Value = "comment";
                ws_term.Cells[1, 6].Value = "tags";
                ws_term.Cells[1, 7].Value = "DB ID";

                Range wsRang = ws_term.get_Range((Range)ws_term.Cells[1, 1], (Range)ws_term.Cells[1, 7]);
                wsRang.Font.Bold = true;
                wsRang.Borders.LineStyle = XlLineStyle.xlContinuous;
            }

            int rows = ws_term.UsedRange.Rows.Count;
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

            XmlNodeList TuNds = xmlDoc.SelectNodes("//xlfns:trans-unit", xnm);
            foreach (XmlNode TuNd in TuNds)
            {
                rows++;
                XmlElement TuXe = (XmlElement)TuNd;
                var TuId = TuXe.GetAttribute("id");

                var sourceNd = TuNd.SelectSingleNode("./xlfns:source", xnm);
                var source = sourceNd.InnerXml;
                source = source.Replace(" xmlns=\"" + nsdef + "\"", "");
                source = Regex.Replace(source, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");

                var targetNd = TuNd.SelectSingleNode("./xlfns:target", xnm);
                var localized = targetNd.InnerXml;
                localized = localized.Replace(" xmlns=\"" + nsdef + "\"", "");
                localized = Regex.Replace(localized, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");

                var noteNd = TuNd.SelectSingleNode("./xlfns:note[@from='Context']", xnm);
                var context = noteNd.InnerXml;
                context = context.Replace(" xmlns=\"" + nsdef + "\"", "");

                var tagsNd = TuNd.SelectSingleNode("./xlfns:note[@from='tags']", xnm);
                var tags = tagsNd.InnerXml;
                tags = tags.Replace(" xmlns=\"" + nsdef + "\"", "");

                var commentNd = TuNd.SelectSingleNode("./xlfns:note[@from='L10N comment']", xnm);
                String comment = "";
                if (commentNd != null)
                {
                    comment = commentNd.InnerXml;
                    comment = comment.Replace(" xmlns=\"" + nsdef + "\"", "");
                }

                ws_term.Cells[rows, 1].NumberFormatLocal = "@";
                ws_term.Cells[rows, 1].Value = filename;

                ws_term.Cells[rows, 2].NumberFormatLocal = "@";
                ws_term.Cells[rows, 2].Value = context;

                ws_term.Cells[rows, 3].NumberFormatLocal = "@";
                ws_term.Cells[rows, 3].Value = source;

                ws_term.Cells[rows, 4].NumberFormatLocal = "@";
                ws_term.Cells[rows, 4].Value = localized;

                ws_term.Cells[rows, 5].NumberFormatLocal = "@";
                ws_term.Cells[rows, 5].Value = comment;

                ws_term.Cells[rows, 6].NumberFormatLocal = "@";
                ws_term.Cells[rows, 6].Value = tags;

                ws_term.Cells[rows, 7].NumberFormatLocal = "@";
                ws_term.Cells[rows, 7].Value = TuId;
            }
        }

        private void Form_exportTermlistXLF_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_path.Text = "";
            this.panel_proBar.Controls.Clear();
            this.btn_export.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text))
                this.btn_export.Enabled = true;
            else
                this.btn_export.Enabled = false;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            this.panel_proBar.Controls.Clear();
            ProgressBar proBar_steps = new ProgressBar();
            this.panel_proBar.Controls.Add(proBar_steps);
            proBar_steps.Dock = DockStyle.Fill;
            proBar_steps.Minimum = 0;

            var pathIn = this.tb_path.Text;
            if (!Directory.Exists(pathIn))
            {
                MessageBox.Show("The path does not exist.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
                this.panel_proBar.Controls.Clear();
            }
            else
            {
                var files = Directory.GetFiles(pathIn, "*.xlf", SearchOption.AllDirectories);
                if (files.Length < 1)
                {
                    MessageBox.Show("There is no any XLF type file in the path.\r\n" + pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_path.Text = "";
                    this.panel_proBar.Controls.Clear();
                }
                else
                {
                    proBar_steps.Maximum = files.Length;
                    this.panel_set.Enabled = false;
                    this.btn_export.Enabled = false;
                    var TermlistOut = Path.Combine(pathIn, "String_List.xlsx");
                    if (File.Exists(TermlistOut))
                        File.Delete(TermlistOut);

                    Microsoft.Office.Interop.Excel.Application app_term = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb_term = app_term.Workbooks.Add(true);
                    foreach (var file in files)
                    {
                        exportTermlistFromXLF(file, wb_term);
                        proBar_steps.Value++;
                    }

                    wb_term.SaveAs(TermlistOut);
                    wb_term.Close();
                    app_term.Quit();
                    MessageBox.Show("Done!\r\n\r\nPlease view the exported termlist:\r\n" + TermlistOut, "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.panel_set.Enabled = true;
                    this.btn_export.Enabled = true;
                }
            }
        }
    }
}
