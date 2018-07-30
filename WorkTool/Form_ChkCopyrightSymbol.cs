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
    public partial class Form_ChkCopyrightSymbol : Form
    {
        public Form_ChkCopyrightSymbol()
        {
            InitializeComponent();
        }

        public void ChkCopyrightSymbol(String fileIn, String fileOut)
        {
            var content = File.ReadAllText(fileIn);
            var defxml = Regex.Match(content, @"<\?xml\b[^<>]*\?>").Value;
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
                var inxml = sourceNd.InnerXml;
                if (Regex.IsMatch(inxml, @"(©|&(amp;)+copy;|&amp;#38;copy;) \d{4}"))
                {
                    var parent = sourceNd.ParentNode;
                    var targetNd = parent.SelectSingleNode("./xlfns:target", xnm);
                    var inxmlTar = targetNd.InnerXml;
                    var rep1 = Regex.Replace(inxmlTar, @"(?<!&|amp;|#38;)\b(amp;)*copy; \d{4}", "&amp;#38;$0", RegexOptions.IgnoreCase);
                    var rep2 = Regex.Replace(rep1, @"(?<=&(amp;#38;)?(amp;)*)Copy(?=; \d{4})", "copy", RegexOptions.IgnoreCase);
                    targetNd.InnerXml = rep2;
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
            File.WriteAllText(fileOut, repXmldef, Encoding.UTF8);
        }

        private void Form_ChkCopyrightSymbol_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_pathIn.Text = "";
            this.tb_pathOut.Text = "";
            this.panel_proBar.Controls.Clear();
            this.btn_chk.Enabled = false;
        }

        private void tb_pathIn_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_chk.Enabled = false;
            else
                this.btn_chk.Enabled = true;
        }

        private void tb_pathOut_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_chk.Enabled = false;
            else
                this.btn_chk.Enabled = true;
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            this.panel_proBar.Controls.Clear();
            ProgressBar proBar_steps = new ProgressBar();
            this.panel_proBar.Controls.Add(proBar_steps);
            proBar_steps.Dock = DockStyle.Fill;
            proBar_steps.Minimum = 0;

            var pathIn = this.tb_pathIn.Text;
            var pathOut = this.tb_pathOut.Text;
            if (!Directory.Exists(pathIn))
            {
                MessageBox.Show("The Path In does not exist.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_pathIn.Text = "";
                this.panel_proBar.Controls.Clear();
            }
            else
            {
                var files = Directory.GetFiles(pathIn, "*.xlf", SearchOption.AllDirectories);
                if (files.Length < 1)
                {
                    MessageBox.Show("There is no any operable file in the Path In.\r\n" + pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_pathIn.Text = "";
                    this.panel_proBar.Controls.Clear();
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.btn_chk.Enabled = false;
                    proBar_steps.Maximum = files.Length;
                    foreach (var file in files)
                    {
                        var fileOut = file.Replace(pathIn, pathOut);
                        if (File.Exists(fileOut))
                            File.Delete(fileOut);

                        if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                            Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                        ChkCopyrightSymbol(file, fileOut);
                        proBar_steps.Value++;
                    }

                    MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.panel_set.Enabled = true;
                    this.btn_chk.Enabled = true;
                }
            }
        }
    }
}
