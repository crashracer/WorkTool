using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyClassLib_rml;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Xml;

namespace WorkTool
{
    public partial class Form_addTagLine : Form
    {
        public Form_addTagLine()
        {
            InitializeComponent();
        }

        public bool b_onlyFilter;
        public bool b_preENG;
        public bool b_postENG;

        public void fileProcessedForPreENG(String fileIn, String fileOut, bool b_onlyFilt)
        {
            var content = File.ReadAllText(fileIn);
            var defxml = Regex.Match(content, @"<\?xml\b[^<>]*\?>").Value;
            var nsdef = Regex.Match(content, @"(?<=xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
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

            var sourceNds = xmlDoc.SelectNodes("//xlfns:source", xnm);
            var targetNds = xmlDoc.SelectNodes("//xlfns:target[@state='translated'] | //xlfns:target[@state='final']", xnm);
            if (targetNds.Count < sourceNds.Count)
            {
                if (b_onlyFilt == false)
                {
                    foreach (XmlNode sourceNd in sourceNds)
                    {
                        var inxml = sourceNd.InnerXml;
                        var TuNd = sourceNd.ParentNode;
                        var targetNd = TuNd.SelectSingleNode("./xlfns:target", xnm);
                        if (targetNd == null)
                        {
                            XmlNode addNd = xmlDoc.CreateNode(XmlNodeType.Element, "target", nsdef);
                            XmlElement addXe = (XmlElement)addNd;
                            if (inxml == "※BLANK※")
                            {
                                addXe.InnerXml = inxml;
                                addXe.SetAttribute("state", "translated");
                            }
                            else
                            {
                                addXe.SetAttribute("state", "in translation");
                            }

                            TuNd.InsertAfter(addXe, sourceNd);
                        }
                        else
                        {
                            XmlElement targetXe = (XmlElement)targetNd;
                            var stateAttr = targetXe.GetAttribute("state");
                            if (stateAttr == "in translation")
                            {
                                if (inxml == "※BLANK※")
                                {
                                    targetXe.InnerXml = inxml;
                                    targetXe.SetAttribute("state", "translated");
                                }
                            }
                            else
                            {
                                targetXe.SetAttribute("state", "final");
                            }
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
        }

        public void fileProcessedForCheckFiles(String fileIn, String fileOut)
        {
            var content = File.ReadAllText(fileIn);
            var defxml = Regex.Match(content, @"<\?xml\b[^<>]*\?>").Value;
            var nsdef = Regex.Match(content, @"(?<=xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
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
                var targetNd = TuNd.SelectSingleNode("./xlfns:target", xnm);
                XmlElement targetXe = (XmlElement)targetNd;
                var stateAttr = targetXe.GetAttribute("state");
                if (stateAttr == "final")
                {
                    var parent = TuNd.ParentNode;
                    parent.RemoveChild(TuNd);
                }
                else
                {
                    var sourceNd = TuNd.SelectSingleNode("./xlfns:source", xnm);
                    var inxml = sourceNd.InnerXml;
                    targetXe.InnerXml = inxml;
                    targetXe.SetAttribute("state", "translated");
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

        private void Form_addTagLine_Load(object sender, EventArgs e)
        {
            this.tb_path.Text = "";
            this.lb_info.Items.Clear();

            this.grpBox_settings.Enabled = true;
            this.chkBox_onlyFilter.Checked = false;
            b_onlyFilter = false;
            this.rBtn_preENG.Checked = true;
            b_preENG = true;
            this.rBtn_chkPostEng.Checked = false;
            b_postENG = false;
            this.btn_run.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text))
                this.btn_run.Enabled = true;
            else
                this.btn_run.Enabled = false;
        }

        private void chkBox_onlyFilter_CheckedChanged(object sender, EventArgs e)
        {
            b_onlyFilter = this.chkBox_onlyFilter.Checked;
        } 

        private void rBtn_preENG_CheckedChanged(object sender, EventArgs e)
        {
            b_preENG = this.rBtn_preENG.Checked;
        }

        private void rBtn_chkPostEng_CheckedChanged(object sender, EventArgs e)
        {
            b_postENG = this.rBtn_chkPostEng.Checked;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.lb_info.Items.Clear();
            Form_Main.AddTextToListbox(this.lb_info, "----------START----------");

            var str_pathInp = this.tb_path.Text;
            if (!Directory.Exists(str_pathInp))
            {
                MessageBox.Show("The path does not exist.\r\n" + str_pathInp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
                Form_Main.AddTextToListbox(this.lb_info, "Please check the path!");
            }
            else
            {
                var filesIn = Directory.GetFiles(str_pathInp, "*.xlf", SearchOption.AllDirectories);
                if (filesIn.Length < 1)
                {
                    MessageBox.Show("Did not find the type of files to be processed in the path.\r\n" + str_pathInp, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_path.Text = "";
                    Form_Main.AddTextToListbox(this.lb_info, "Please check files in the path!");
                }
                else
                {
                    this.grpBox_settings.Enabled = false;
                    this.btn_run.Enabled = false;
                    String pathOut = "";
                    if (b_preENG)
                    {
                        pathOut = Path.Combine(Directory.GetParent(str_pathInp).FullName, "Source_forPreENG");
                        foreach (var fileIn in filesIn)
                        {
                            Form_Main.AddTextToListbox(this.lb_info, fileIn);
                            var fileOut = fileIn.Replace(str_pathInp, pathOut);
                            if (File.Exists(fileOut))
                                File.Delete(fileOut);

                            if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                            fileProcessedForPreENG(fileIn, fileOut, b_onlyFilter);
                        }
                    }
                    else
                    {
                        pathOut = Path.Combine(Directory.GetParent(str_pathInp).FullName, "Source_forCheckFiles");
                        foreach (var fileIn in filesIn)
                        {
                            Form_Main.AddTextToListbox(this.lb_info, fileIn);
                            var fileOut = fileIn.Replace(str_pathInp, pathOut);
                            if (File.Exists(fileOut))
                                File.Delete(fileOut);

                            if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                            fileProcessedForCheckFiles(fileIn, fileOut);
                        }
                    }

                    MessageBox.Show("Done!", "TIP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_Main.AddTextToListbox(this.lb_info, "----------END----------");
                    this.grpBox_settings.Enabled = true;
                    this.btn_run.Enabled = true;
                    Process.Start("explorer.exe", pathOut);
                }
            }
        }
    }
}
