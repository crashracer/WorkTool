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
using System.Diagnostics;

namespace WorkTool
{
    public partial class Form_ChkEscapedXLF : Form
    {
        public Form_ChkEscapedXLF()
        {
            InitializeComponent();
        }

        public String checkEscaped(String fileIn, String fileOut)
        {
            var content = File.ReadAllText(fileIn);
            var defxml = Regex.Match(content, @"<\?xml\b[^<>]*\?>").Value;
            var nsdef = Regex.Match(content, @"(?<=<xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            var origFile = Regex.Match(content, @"(?<=<file\b[^<>]*original[ \t]*=[ \t]*"")[^""]+(?="")").Value.ToLower();
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
            var targetNds = xmlDoc.SelectNodes("//xlfns:target", xnm);
            if (Regex.IsMatch(origFile, @"(.*(/|\\))?values(/|\\)strings\.xml$"))
            {
                foreach (XmlNode targetNd in targetNds)
                {
                    var targStr = targetNd.InnerXml;
                    targStr = targStr.Replace(" xmlns=\"" + nsdef + "\"", "");
                    targStr = targStr.Replace(@"\’", "’");
                    targStr = Regex.Replace(targStr, @"(?<!\\)('|"")", "\\$1");
                    targetNd.InnerXml = targStr;
                }
            }
            else if (Regex.IsMatch(origFile, @".+\.(json|jsonjs|strings|xstrings|po)$"))
            {
                foreach (XmlNode targetNd in targetNds)
                {
                    var targStr = targetNd.InnerXml;
                    targStr = targStr.Replace(" xmlns=\"" + nsdef + "\"", "");
                    targStr = targStr.Replace(@"\’", "’");
                    targStr = Regex.Replace(targStr, @"(?<!\\)("")", "\\$1");
                    targetNd.InnerXml = targStr;
                }
            }
            else if (Regex.IsMatch(origFile, @".+\.(h|js|php|sql)$"))
            {
                foreach (XmlNode targetNd in targetNds)
                {
                    var targStr = targetNd.InnerXml;
                    targStr = Regex.Replace(targStr, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
                    targStr = targStr.Replace(" xmlns=\"" + nsdef + "\"", "");
                    if (Regex.IsMatch(targStr, @"(?<!\\)('|"")"))
                    {
                        XmlElement xe_TuNd = (XmlElement)targetNd.ParentNode;
                        var TuId = xe_TuNd.GetAttribute("id");
                        str_log += "trans-unit: id=" + TuId + "\r\nLocalized String:\r\n" + targStr + "\r\n\r\n";
                    }
                }
            }
            else
            {
                Console.Write("No need escaped: {0}", fileIn);
            }

            if (!String.IsNullOrWhiteSpace(str_log) && !String.IsNullOrEmpty(str_log))
                str_log = fileIn + "\r\n" + str_log;

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

            return str_log;
        }

        private void Form_ChkEscapedXLF_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_path.Text = "";
            this.proBar_pro.Visible = false;
            this.lab_proBar.Text = "";
            this.btn_chk.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text))
                this.btn_chk.Enabled = true;
            else
                this.btn_chk.Enabled = false;
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            this.proBar_pro.Minimum = 0;
            this.proBar_pro.Value = 0;
            this.proBar_pro.Visible = false;

            var pathInput = this.tb_path.Text;
            if (!Directory.Exists(pathInput))
            {
                MessageBox.Show("The Enter Path does not exist.\r\n" + pathInput, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
            }
            else
            {
                var files = Directory.GetFiles(pathInput, "*.xlf", SearchOption.AllDirectories);
                if (files.Length < 1)
                {
                    MessageBox.Show("There is no any XLF type file in the Enter Path.\r\n" + pathInput, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.panel_set.Enabled = true;
                    this.tb_path.Text = "";
                }
                else
                {
                    this.panel_set.Enabled = false;
                    this.btn_chk.Enabled = false;
                    this.proBar_pro.Visible = true;
                    this.proBar_pro.Maximum = files.Length;
                    this.proBar_pro.Value = 0;
                    this.lab_proBar.Text = "0/" + files.Length.ToString();

                    var pathOutput = Path.Combine(Path.GetDirectoryName(pathInput), "CheckEscaped");
                    var logFile = Path.Combine(Path.GetDirectoryName(pathInput), "CheckEscaped_Log.txt");
                    if (File.Exists(logFile))
                        File.Delete(logFile);

                    String logText = "";

                    foreach (var file in files)
                    {
                        var fileout = file.Replace(pathInput, pathOutput);
                        if (File.Exists(fileout))
                            File.Delete(fileout);

                        if (!Directory.Exists(Path.GetDirectoryName(fileout)))
                            Directory.CreateDirectory(Path.GetDirectoryName(fileout));

                        var log = checkEscaped(file, fileout);
                        logText += log;

                        this.proBar_pro.Value++;
                        this.lab_proBar.Text = this.proBar_pro.Value.ToString() + "/" + files.Length.ToString();
                    }

                    if (String.IsNullOrEmpty(logText) || String.IsNullOrWhiteSpace(logText))
                        logText = "No escaped issue need confirmation!";

                    File.WriteAllText(logFile, logText);

                    MessageBox.Show("Done!\r\n\r\nOutput Path:\r\n" + pathOutput + "\r\n\r\nPlease view the log file for more information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(logFile);
                    this.panel_set.Enabled = true;
                    this.btn_chk.Enabled = true;
                }
            }
        }
    }
}
