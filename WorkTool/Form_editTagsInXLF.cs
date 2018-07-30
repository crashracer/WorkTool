using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace WorkTool
{
    public partial class Form_editTagsInXLF : Form
    {
        public Form_editTagsInXLF()
        {
            InitializeComponent();
        }

        public void editTagsInfoInXLF(String fileIn, String fileOut, String tagsInfo)
        {
            var content = File.ReadAllText(fileIn);
            var defxml = Regex.Match(content, @"<\?xml\b[^<>]*\?>").Value;
            var nsdef = Regex.Match(content, @"(?<=<xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            var spaceTU = Regex.Match(content, @"(?<=[\r\n]+)[ \t]*(?=<trans-unit\b)").Value;
            var spaceTUChild = Regex.Match(content, @"(?<=[\r\n]+)[ \t]*(?=<source\b)").Value;
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

            var TuNds = xmlDoc.SelectNodes("//xlfns:trans-unit", xnm);
            foreach (XmlNode TuNd in TuNds)
            {
                var noteNd = TuNd.SelectSingleNode("./xlfns:note[@from='tags']", xnm);
                if (noteNd != null)
                    noteNd.InnerXml = tagsInfo;
                else
                {
                    XmlNode addNd = xmlDoc.CreateNode(XmlNodeType.Element, "note", nsdef);
                    XmlElement addXe = (XmlElement)addNd;
                    addXe.SetAttribute("from", "tags");
                    addXe.InnerXml = tagsInfo;
                    TuNd.AppendChild(addXe);
                }
            }

            XmlWriterSettings xws = new XmlWriterSettings();
            xws.CheckCharacters = false;
            xws.Encoding = Encoding.UTF8;
            xws.Indent = true;
            xws.NamespaceHandling = NamespaceHandling.OmitDuplicates;
            xws.NewLineChars = "\r\n";
            xws.NewLineHandling = NewLineHandling.None;
            xws.NewLineOnAttributes = false;
            xws.OmitXmlDeclaration = false;
            using (var xw = XmlWriter.Create(fileOut, xws))
            {
                xmlDoc.Save(xw);
            }

            var textWrite = File.ReadAllText(fileOut);
            var repand = Regex.Replace(textWrite, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
            var repXmldef = Regex.Replace(repand, @"<\?xml\b[^<>]*\?>", defxml);
            var addSpace1 = Regex.Replace(repXmldef, @">\s*<(target|source|note)\b", ">\r\n" + spaceTUChild + "<$1");
            var addSpace2 = Regex.Replace(addSpace1, @">\s*<trans-unit\b", ">\r\n" + spaceTU + "<trans-unit");
            var addSpace3 = Regex.Replace(addSpace2, @">\s*</trans-unit>", ">\r\n" + spaceTU + "</trans-unit>");
            File.WriteAllText(fileOut, addSpace3, Encoding.UTF8);
        }

        private void Form_editTagsInXLF_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_pathInput.Text = "";
            this.tb_tagsInfo.Text = "";
            this.tb_pathOutput.Text = "";
            this.proBar_progress.Visible = false;
            this.btn_run.Enabled = false;
        }

        private void tb_pathInput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathInput.Text) || String.IsNullOrWhiteSpace(this.tb_pathInput.Text) || String.IsNullOrEmpty(this.tb_tagsInfo.Text) || String.IsNullOrWhiteSpace(this.tb_tagsInfo.Text) || String.IsNullOrEmpty(this.tb_pathOutput.Text) || String.IsNullOrWhiteSpace(this.tb_pathOutput.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void tb_tagsInfo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathInput.Text) || String.IsNullOrWhiteSpace(this.tb_pathInput.Text) || String.IsNullOrEmpty(this.tb_tagsInfo.Text) || String.IsNullOrWhiteSpace(this.tb_tagsInfo.Text) || String.IsNullOrEmpty(this.tb_pathOutput.Text) || String.IsNullOrWhiteSpace(this.tb_pathOutput.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void tb_pathOutput_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathInput.Text) || String.IsNullOrWhiteSpace(this.tb_pathInput.Text) || String.IsNullOrEmpty(this.tb_tagsInfo.Text) || String.IsNullOrWhiteSpace(this.tb_tagsInfo.Text) || String.IsNullOrEmpty(this.tb_pathOutput.Text) || String.IsNullOrWhiteSpace(this.tb_pathOutput.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.proBar_progress.Visible = true;
            this.proBar_progress.Minimum = 0;
            this.proBar_progress.Value = 0;

            var inputPath = this.tb_pathInput.Text;
            var tagsInfo = this.tb_tagsInfo.Text;
            var outputPath = this.tb_pathOutput.Text;

            if (!Directory.Exists(inputPath))
            {
                MessageBox.Show("The Path Input does not exist.\r\n" + inputPath, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_pathInput.Text = "";
            }
            else
            {
                var files = Directory.GetFiles(inputPath, "*.xlf", SearchOption.AllDirectories);
                if (files.Length < 1)
                {
                    MessageBox.Show("There is no any applicable file in the Path Input.\r\n" + inputPath, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_pathInput.Text = "";
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.btn_run.Enabled = false;
                    this.proBar_progress.Maximum = files.Length;

                    foreach (var file in files)
                    {
                        var fileout = file.Replace(inputPath, outputPath);
                        if (File.Exists(fileout))
                            File.Delete(fileout);

                        if (!Directory.Exists(Path.GetDirectoryName(fileout)))
                            Directory.CreateDirectory(Path.GetDirectoryName(fileout));

                        editTagsInfoInXLF(file, fileout, tagsInfo);
                        this.proBar_progress.Value++;
                    }

                    MessageBox.Show("Done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.panel_set.Enabled = true;
                    this.btn_run.Enabled = true;
                }
            }
        }
    }
}
