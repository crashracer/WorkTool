using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using MyClassLib_rml;
using System.Xml;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace WorkTool
{
    public partial class Form_regularFileContent : Form
    {
        public Form_regularFileContent()
        {
            InitializeComponent();
        }

        public bool b_remnoupd;

        public List<String> getFilesByTypes(String str_pathIn, ArrayList al_types, bool b_subF)
        {
            List<String> lstr_files = new List<String>();

            foreach (var type in al_types)
            {
                if (b_subF == true)
                {
                    var files = Directory.GetFiles(str_pathIn, "*." + type, SearchOption.AllDirectories);
                    lstr_files.AddRange(files);
                }
                else
                {
                    var files = Directory.GetFiles(str_pathIn, "*." + type, SearchOption.TopDirectoryOnly);
                    lstr_files.AddRange(files);
                }
            }

            return lstr_files;
        }

        public void regularFile(String str_fileIn, String str_fileOrigSrc, String str_fileOut, bool b_removeNd)
        {
            var contentIn = File.ReadAllText(str_fileIn);
            var contentOrig = File.ReadAllText(str_fileOrigSrc);
            var defxml = Regex.Match(contentOrig, @"<\?xml\b[^<>]*\?>").Value;
            var spaceTU = Regex.Match(contentOrig, @"(?<=[\r\n]+)[ \t]*(?=<trans-unit\b)").Value;
            var spaceTUChild = Regex.Match(contentOrig, @"(?<=[\r\n]+)[ \t]*(?=<source\b)").Value;
            var nsdef = Regex.Match(contentOrig, @"(?<=xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            contentIn = Regex.Replace(contentIn, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");
            contentOrig = Regex.Replace(contentOrig, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");

            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.CheckCharacters = false;
            xrs.IgnoreWhitespace = false;
            xrs.NameTable = new NameTable();
            XmlNamespaceManager xnm = new XmlNamespaceManager(xrs.NameTable);
            xnm.AddNamespace("xlfns", nsdef);

            XmlDocument xmlDocIn = new XmlDocument();
            xmlDocIn.PreserveWhitespace = true;
            var sr = new StringReader(contentIn);
            using (var xr = XmlReader.Create(sr, xrs))
            {
                xmlDocIn.Load(xr);
            }

            XmlDocument xmlDocOrig = new XmlDocument();
            xmlDocOrig.PreserveWhitespace = true;
            var srOrig = new StringReader(contentOrig);
            using (var xrOrig = XmlReader.Create(srOrig, xrs))
            {
                xmlDocOrig.Load(xrOrig);
            }

            var TuNds = xmlDocIn.SelectNodes("//xlfns:trans-unit", xnm);
            foreach (XmlNode TuNd in TuNds)
            {
                var targetNd = TuNd.SelectSingleNode("./xlfns:target", xnm);
                XmlElement targetXe = (XmlElement)targetNd;
                var stateAttr = targetXe.GetAttribute("state");
                if (stateAttr == "final" && b_removeNd == true)
                {
                    var parent = TuNd.ParentNode;
                    parent.RemoveChild(TuNd);
                }
                else
                {
                    var noteNds = TuNd.SelectNodes("./xlfns:note", xnm);
                    XmlElement TuXe = (XmlElement)TuNd;
                    var idAttr = TuXe.GetAttribute("id");
                    var TuNdOrig = xmlDocOrig.SelectSingleNode("//xlfns:trans-unit[@id='" + idAttr + "']", xnm);
                    var noteNdsOrig = TuNdOrig.SelectNodes("./xlfns:note", xnm);

                    foreach (XmlNode noteNd in noteNds)
                    {
                        TuNd.RemoveChild(noteNd);
                    }

                    foreach (XmlNode noteNdOrig in noteNdsOrig)
                    {
                        var addNd = xmlDocIn.ImportNode(noteNdOrig, true);
                        TuNd.AppendChild(addNd);
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
            using (var xw = XmlWriter.Create(str_fileOut, xws))
            {
                xmlDocIn.Save(xw);
            }

            var textWrite = File.ReadAllText(str_fileOut);
            var repand = Regex.Replace(textWrite, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
            var repXmldef = Regex.Replace(repand, @"<\?xml\b[^<>]*\?>", defxml);
            var addSpace1 = Regex.Replace(repXmldef, @">\s*<(target|source|note)\b", ">\r\n" + spaceTUChild + "<$1");
            var addSpace2 = Regex.Replace(addSpace1, @">\s*<trans-unit\b", ">\r\n" + spaceTU + "<trans-unit");
            var addSpace3 = Regex.Replace(addSpace2, @">\s*</trans-unit>", ">\r\n" + spaceTU + "</trans-unit>");
            File.WriteAllText(str_fileOut, addSpace3, Encoding.UTF8);
        }

        private void Form_regularFileContent_Load(object sender, EventArgs e)
        {
            this.grpBox_set.Enabled = true;
            this.tb_path.Text = "";
            this.tb_OriginalSrc.Text = "";
            this.tb_type.Text = "xlf";
            this.panel_proBar.Controls.Clear();
            this.chkBox_remNoupd.Checked = true;
            b_remnoupd = true;
            this.btn_run.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_path.Text) || String.IsNullOrWhiteSpace(this.tb_path.Text) || String.IsNullOrEmpty(this.tb_type.Text) || String.IsNullOrWhiteSpace(this.tb_type.Text) || String.IsNullOrEmpty(this.tb_OriginalSrc.Text) || String.IsNullOrWhiteSpace(this.tb_OriginalSrc.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void tb_OriginalSrc_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_path.Text) || String.IsNullOrWhiteSpace(this.tb_path.Text) || String.IsNullOrEmpty(this.tb_type.Text) || String.IsNullOrWhiteSpace(this.tb_type.Text) || String.IsNullOrEmpty(this.tb_OriginalSrc.Text) || String.IsNullOrWhiteSpace(this.tb_OriginalSrc.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void tb_pathOut_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_path.Text) || String.IsNullOrWhiteSpace(this.tb_path.Text) || String.IsNullOrEmpty(this.tb_type.Text) || String.IsNullOrWhiteSpace(this.tb_type.Text) || String.IsNullOrEmpty(this.tb_OriginalSrc.Text) || String.IsNullOrWhiteSpace(this.tb_OriginalSrc.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void tb_type_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_path.Text) || String.IsNullOrWhiteSpace(this.tb_path.Text) || String.IsNullOrEmpty(this.tb_type.Text) || String.IsNullOrWhiteSpace(this.tb_type.Text) || String.IsNullOrEmpty(this.tb_OriginalSrc.Text) || String.IsNullOrWhiteSpace(this.tb_OriginalSrc.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void chkBox_remNoupd_CheckedChanged(object sender, EventArgs e)
        {
            b_remnoupd = this.chkBox_remNoupd.Checked;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.panel_proBar.Controls.Clear();
            ProgressBar proBar_steps = new ProgressBar();
            this.panel_proBar.Controls.Add(proBar_steps);
            proBar_steps.Dock = DockStyle.Fill;

            var str_pathIn = this.tb_path.Text;
            var str_OrigSrcPath = this.tb_OriginalSrc.Text;
            var pathOut = this.tb_pathOut.Text;

            if (Directory.Exists(str_pathIn) && Directory.Exists(str_OrigSrcPath))
            {
                var str_type = this.tb_type.Text;
                var al_fileType = ClassLib_RML.SplitString(str_type, ";");
                var filesIn = getFilesByTypes(str_pathIn, al_fileType, true);
                var origSrcFiles = getFilesByTypes(str_OrigSrcPath, al_fileType, true);

                if (filesIn.Count < 1 || origSrcFiles.Count < 1)
                {
                    MessageBox.Show("Please enter the directory paths containing the operable files.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_path.Text = "";
                    this.tb_OriginalSrc.Text = "";
                    this.panel_proBar.Controls.Clear();
                }
                else
                {
                    this.grpBox_set.Enabled = false;
                    this.btn_run.Enabled = false;

                    proBar_steps.Maximum = filesIn.Count;
                    proBar_steps.Minimum = 0;
                    foreach (var fileIn in filesIn)
                    {
                        var nameFileIn = Path.GetFileName(fileIn);
                        var textFileIn = File.ReadAllText(fileIn);
                        var langFileIn = Regex.Match(textFileIn, @"(?<=target-language[ \t]*=[ \t]*"")[^""]+?(?="")").Value;
                        var fileOut = fileIn.Replace(str_pathIn, pathOut);
                        if (File.Exists(fileOut))
                            File.Delete(fileOut);

                        if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                            Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                        foreach(var origSrcFile in origSrcFiles)
                        {
                            var nameOrigSrc = Path.GetFileName(origSrcFile);
                            var textOrigSrc = File.ReadAllText(origSrcFile);
                            var langOrigSrc = Regex.Match(textOrigSrc, @"(?<=target-language[ \t]*=[ \t]*"")[^""]+?(?="")").Value;
                            if (nameOrigSrc.ToLower() == nameFileIn.ToLower() && langOrigSrc.ToLower() == langFileIn.ToLower())
                            {
                                regularFile(fileIn, origSrcFile, fileOut, b_remnoupd);
                                origSrcFiles.Remove(origSrcFile);
                                proBar_steps.Value++;
                                break;
                            }
                        }
                    }

                    if (proBar_steps.Value == filesIn.Count)
                    {
                        MessageBox.Show("Done!!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.grpBox_set.Enabled = true;
                        this.btn_run.Enabled = true;
                    }
                    else
                    {
                        var undo = filesIn.Count - proBar_steps.Value;
                        MessageBox.Show(undo.ToString() + " file(s) did not be processed. \r\nPlease check if they have Original Source for reference.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.grpBox_set.Enabled = true;
                        this.tb_OriginalSrc.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the valid directory paths.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_path.Text = "";
                this.tb_OriginalSrc.Text = "";
                this.panel_proBar.Controls.Clear();
            }
        }
    }
}
