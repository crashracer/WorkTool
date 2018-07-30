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
    public partial class Form_regulateXLFForFixingBug : Form
    {
        public Form_regulateXLFForFixingBug()
        {
            InitializeComponent();
        }

        public void regulateXLFForFixingBug(String fileIn, String fileBase, String fileOut)
        {
            var contentIn = File.ReadAllText(fileIn);
            var contentBase = File.ReadAllText(fileBase);

            if (contentIn != contentBase)
            {
                var defxml = Regex.Match(contentBase, @"<\?xml\b[^<>]*\?>").Value;
                var nsdef = Regex.Match(contentBase, @"(?<=<xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
                var spaceTU = Regex.Match(contentBase, @"(?<=[\r\n]+)[ \t]*(?=<trans-unit\b)").Value;
                var spaceTUChild = Regex.Match(contentBase, @"(?<=[\r\n]+)[ \t]*(?=<source\b)").Value;

                contentIn = Regex.Replace(contentIn, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");
                contentBase = Regex.Replace(contentBase, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");

                XmlReaderSettings xrs = new XmlReaderSettings();
                xrs.CheckCharacters = false;
                xrs.IgnoreWhitespace = false;
                xrs.NameTable = new NameTable();
                XmlNamespaceManager xnm = new XmlNamespaceManager(xrs.NameTable);
                xnm.AddNamespace("xlfns", nsdef);

                XmlDocument xmlDocIn = new XmlDocument();
                xmlDocIn.PreserveWhitespace = true;
                var srIn = new StringReader(contentIn);
                using (var xrIn = XmlReader.Create(srIn, xrs))
                {
                    xmlDocIn.Load(xrIn);
                }

                XmlDocument xmlDocBase = new XmlDocument();
                xmlDocBase.PreserveWhitespace = true;
                var srBase = new StringReader(contentBase);
                using (var xrBase = XmlReader.Create(srBase, xrs))
                {
                    xmlDocBase.Load(xrBase);
                }

                var TuNdsIn = xmlDocIn.SelectNodes("//xlfns:trans-unit", xnm);
                foreach (XmlNode TuNdIn in TuNdsIn)
                {
                    var parentNd = TuNdIn.ParentNode;
                    var targetIn = TuNdIn.SelectSingleNode("./xlfns:target", xnm);
                    if (targetIn == null)
                        parentNd.RemoveChild(TuNdIn);
                    else
                    {
                        XmlElement targetInXe = (XmlElement)targetIn;
                        if (targetInXe.GetAttribute("state") == "in translation")
                            parentNd.RemoveChild(TuNdIn);
                        else
                        {
                            var inxmlIn = targetIn.InnerXml;
                            XmlElement TuNdInXe = (XmlElement)TuNdIn;
                            var TuIdIn = TuNdInXe.GetAttribute("id");
                            var TuNdBase = xmlDocBase.SelectSingleNode("//xlfns:trans-unit[@id='" + TuIdIn + "']", xnm);
                            var targetBase = TuNdBase.SelectSingleNode("./xlfns:target", xnm);
                            if (targetBase.InnerXml == inxmlIn)
                                parentNd.RemoveChild(TuNdIn);
                        }
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

                if (File.Exists(fileOut))
                    File.Delete(fileOut);

                if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                    Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                using (var xw = XmlWriter.Create(fileOut, xws))
                {
                    xmlDocIn.Save(xw);
                }

                var textWrite = File.ReadAllText(fileOut);
                var repand = Regex.Replace(textWrite, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
                var repXmldef = Regex.Replace(repand, @"<\?xml\b[^<>]*\?>", defxml);
                var addSpace1 = Regex.Replace(repXmldef, @">\s*<(target|source|note)\b", ">\r\n" + spaceTUChild + "<$1");
                var addSpace2 = Regex.Replace(addSpace1, @">\s*<trans-unit\b", ">\r\n" + spaceTU + "<trans-unit");
                var addSpace3 = Regex.Replace(addSpace2, @">\s*</trans-unit>", ">\r\n" + spaceTU + "</trans-unit>");
                File.WriteAllText(fileOut, addSpace3, Encoding.UTF8);
            }
        }

        private void Form_regulateXLFForFixingBug_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_input.Text = "";
            this.tb_base.Text = "";
            this.tb_output.Text = "";
            this.proBar_progress.Visible = false;
            this.btn_start.Enabled = false;
        }

        private void tb_input_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_input.Text) || String.IsNullOrWhiteSpace(this.tb_input.Text) || String.IsNullOrEmpty(this.tb_base.Text) || String.IsNullOrWhiteSpace(this.tb_base.Text) || String.IsNullOrEmpty(this.tb_output.Text) || String.IsNullOrWhiteSpace(this.tb_output.Text))
                this.btn_start.Enabled = false;
            else
                this.btn_start.Enabled = true;
        }

        private void tb_base_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_input.Text) || String.IsNullOrWhiteSpace(this.tb_input.Text) || String.IsNullOrEmpty(this.tb_base.Text) || String.IsNullOrWhiteSpace(this.tb_base.Text) || String.IsNullOrEmpty(this.tb_output.Text) || String.IsNullOrWhiteSpace(this.tb_output.Text))
                this.btn_start.Enabled = false;
            else
                this.btn_start.Enabled = true;
        }

        private void tb_output_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_input.Text) || String.IsNullOrWhiteSpace(this.tb_input.Text) || String.IsNullOrEmpty(this.tb_base.Text) || String.IsNullOrWhiteSpace(this.tb_base.Text) || String.IsNullOrEmpty(this.tb_output.Text) || String.IsNullOrWhiteSpace(this.tb_output.Text))
                this.btn_start.Enabled = false;
            else
                this.btn_start.Enabled = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            this.proBar_progress.Visible = true;
            this.proBar_progress.Minimum = 0;
            this.proBar_progress.Value = 0;

            var inputPath = this.tb_input.Text;
            var basePath = this.tb_base.Text;
            var outputPath = this.tb_output.Text;

            if (!Directory.Exists(inputPath) || !Directory.Exists(basePath))
            {
                MessageBox.Show("Please check whether you have entered the right Input path and Base path!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var inputFiles = Directory.GetFiles(inputPath, "*.xlf", SearchOption.AllDirectories);
                var baseFilesTmp = Directory.GetFiles(basePath, "*.xlf", SearchOption.AllDirectories);
                if (inputFiles.Length < 1 || baseFilesTmp.Length < 1)
                {
                    MessageBox.Show("Please check whether exist XLF type files in the Input path and the Base path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.btn_start.Enabled = false;
                    this.proBar_progress.Maximum = inputFiles.Length;

                    List<String> baseFiles = new List<String>();
                    foreach (var baseFileTmp in baseFilesTmp)
                    {
                        baseFiles.Add(baseFileTmp);
                    }

                    foreach (var inputFile in inputFiles)
                    {
                        var inputFileName = Path.GetFileName(inputFile);
                        var inputFileLang = Regex.Match(File.ReadAllText(inputFile), @"(?<=<file\b[^<>]*target-language[ \t]*=[ \t]*"")[^""]+(?=""[^<>]*>)").ToString();

                        foreach (var baseFile in baseFiles)
                        {
                            var baseFileName = Path.GetFileName(baseFile);
                            var baseFileLang = Regex.Match(File.ReadAllText(baseFile), @"(?<=<file\b[^<>]*target-language[ \t]*=[ \t]*"")[^""]+(?=""[^<>]*>)").ToString();
                            if (baseFileName.ToLower() == inputFileName.ToLower() && baseFileLang.ToLower() == inputFileLang.ToLower())
                            {
                                var outputFile = inputFile.Replace(inputPath, outputPath);
                                regulateXLFForFixingBug(inputFile, baseFile, outputFile);

                                baseFiles.Remove(baseFile);
                                break;
                            }
                        }
                        this.proBar_progress.Value++;
                    }

                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.panel_set.Enabled = true;
                    this.btn_start.Enabled = true;
                }
            }
        }
    }
}
