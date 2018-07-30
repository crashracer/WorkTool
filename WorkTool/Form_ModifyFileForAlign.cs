using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace WorkTool
{
    public partial class Form_ModifyFileForAlign : Form
    {
        public Form_ModifyFileForAlign()
        {
            InitializeComponent();
        }

        public bool b_TTX;
        public bool b_XML;
        public bool b_xliff;

        public void modifyTTX(String str_fileIn, String str_fileOut)
        {
            var fileName = Path.GetFileNameWithoutExtension(str_fileIn);
            fileName = Regex.Replace(fileName, @"&(?!amp;)", "&amp;");
            var content = File.ReadAllText(str_fileIn);
            var repC1 = Regex.Replace(content, @"(?<=SourceDocumentPath[ \t]*=[ \t]*""[^""]+?\\)[^""\\]+?(?="")", fileName);
            var repC2 = repC1.Replace("</Tuv>", "<ut>&lt;PactBr/&gt;</ut></Tuv>");
            File.WriteAllText(str_fileOut, repC2, Encoding.Unicode);
        }

        public void modifyXML(String str_fileIn, String str_fileOut)
        {
            var content = File.ReadAllText(str_fileIn);
            var dtdText = Regex.Match(content, @"<\!DOCTYPE\b[\s\S]+?\]>").Value;
            if (String.IsNullOrEmpty(dtdText) || String.IsNullOrWhiteSpace(dtdText))
            {
                dtdText = Regex.Match(content, @"<\!DOCTYPE\b[\s\S]+?(?<!\-\-)>").Value;
            }
            var repC1 = Regex.Replace(content, @"</?pacteraseg>", "");
            var repC2 = Regex.Replace(repC1, @"(:\s*|：\s*)<PactBr/>", "$1");
            String repC3 = "";
            if (!String.IsNullOrEmpty(dtdText) && !String.IsNullOrWhiteSpace(dtdText))
            {
                repC3 = repC2.Replace(dtdText, "<!-- RMLiang set here as DTD Part -->");
            }
            repC3 = Regex.Replace(repC3, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");
            
            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.CheckCharacters = false;
            xrs.IgnoreWhitespace = false;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;

            StringReader sr = new StringReader(repC3);
            using (var xr = XmlReader.Create(sr, xrs))
            {
                xmlDoc.Load(xr);
            }

            var pactBrs = xmlDoc.SelectNodes("//PactBr");
            foreach (XmlNode pactBr in pactBrs)
            {
                var parent = pactBr.ParentNode;
                var nameParent = parent.Name;
                if (nameParent == "uicontrol" || nameParent == "title" || nameParent == "wintitle" || nameParent == "menucascade" || nameParent == "tm" || nameParent == "indexterm" || nameParent == "term" || nameParent == "index-sort-as")
                {
                    parent.RemoveChild(pactBr);
                }
            }

            Dictionary<XmlNode, bool> dicIdxtrm = new Dictionary<XmlNode, bool>();
            var indexterms = xmlDoc.SelectNodes("//indexterm");
            foreach (XmlNode idxterm in indexterms)
            {
                if (!dicIdxtrm.ContainsKey(idxterm))
                {
                    var parent = idxterm.ParentNode;
                    var parentName = parent.Name;
                    var children = parent.SelectNodes("./indexterm");
                    for (int index = children.Count - 1; index >= 0; index--)
                    {
                        if (parentName != "indexterm")
                        {
                            parent.RemoveChild(children[index]);
                            parent.PrependChild(children[index]);
                        }
                        dicIdxtrm.Add(children[index], true);
                    }
                }
            }

            XmlWriterSettings xws = new XmlWriterSettings();
            xws.CheckCharacters = false;
            xws.Encoding = Encoding.Unicode;
            xws.Indent = true;
            xws.NamespaceHandling = NamespaceHandling.OmitDuplicates;
            xws.NewLineChars = "\r\n";
            xws.NewLineHandling = NewLineHandling.None;
            xws.NewLineOnAttributes = false;
            xws.OmitXmlDeclaration = false;
            using (var xw = XmlWriter.Create(str_fileOut, xws))
            {
                xmlDoc.Save(xw);
            }

            var textOut = File.ReadAllText(str_fileOut);
            textOut = Regex.Replace(textOut, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
            if (!String.IsNullOrEmpty(dtdText) && !String.IsNullOrWhiteSpace(dtdText))
            {
                textOut = textOut.Replace("<!-- RMLiang set here as DTD Part -->", dtdText);
                textOut = Regex.Replace(textOut, @"&(amp;)*lt;!--([\s\S]*?)--&(amp;)*gt;", "<!--$1-->");  
            }
            File.WriteAllText(str_fileOut, textOut, Encoding.Unicode);
        }

        public void modifyXliff(String str_fileIn, String str_fileOut)
        {
            var content = File.ReadAllText(str_fileIn);
            var nsdef = Regex.Match(content, @"(?<=<xliff\b[^<>]*xmlns[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            var nssdl = Regex.Match(content, @"(?<=<xliff\b[^<>]*xmlns:sdl[ \t]*=[ \t]*"")[^""]+(?="")").Value;
            content = Regex.Replace(content, @"&(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&amp;#38;$1");

            XmlReaderSettings xrs = new XmlReaderSettings();
            xrs.CheckCharacters = false;
            xrs.IgnoreWhitespace = false;
            xrs.NameTable = new NameTable();
            XmlNamespaceManager xnm = new XmlNamespaceManager(xrs.NameTable);
            xnm.AddNamespace("xlfns", nsdef);
            xnm.AddNamespace("sdlns", nssdl);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;

            StringReader sr = new StringReader(content);
            using (var xr = XmlReader.Create(sr, xrs))
            {
                xmlDoc.Load(xr);
            }

            var gNds_src = xmlDoc.SelectNodes("//xlfns:seg-source/xlfns:mrk//xlfns:g", xnm);
            if (gNds_src.Count >= 2)
            {
                Dictionary<String, XmlNode> dic_gNds = new Dictionary<string, XmlNode>();
                List<String> lstr_gIDs = new List<String>();
                foreach (XmlNode gNd_src in gNds_src)
                {
                    XmlElement gXe_src = (XmlElement)gNd_src;
                    var gxeID = gXe_src.GetAttribute("id");
                    var gTag = xmlDoc.SelectSingleNode("//sdlns:tag-defs/sdlns:tag[@id='" + gxeID + "']", xnm);
                    var bptTag = gTag.SelectSingleNode("./sdlns:bpt", xnm);
                    XmlElement bptXe = (XmlElement)bptTag;
                    if (bptXe.GetAttribute("name") == "uicontrol")
                    {
                        dic_gNds.Add(gxeID, gNd_src);
                        lstr_gIDs.Add(gxeID);
                    }
                }

                foreach (var gID in lstr_gIDs)
                {
                    if (dic_gNds[gID] != null)
                    {
                        var parent = dic_gNds[gID].ParentNode;
                        var parentName = parent.Name;
                        String gIDParent = "";
                        if (parentName == "g")
                        {
                            XmlElement parentXe = (XmlElement)parent;
                            gIDParent = parentXe.GetAttribute("id");
                            var parentTag = xmlDoc.SelectSingleNode("//sdlns:tag-defs/sdlns:tag[@id='" + gIDParent + "']", xnm);
                            var bptParent = parentTag.SelectSingleNode("./sdlns:bpt", xnm);
                            XmlElement bptParentXe = (XmlElement)bptParent;
                            parentName = bptParentXe.GetAttribute("name");
                        }

                        if (parentName == "menucascade")
                        {
                            var gChildren = parent.SelectNodes("./xlfns:g", xnm);
                            if (gChildren.Count >= 2)
                            {
                                List<XmlNode> lxn_gNds = new List<XmlNode>();
                                int int_uiCount = 0;
                                foreach (XmlNode gChild in gChildren)
                                {
                                    XmlElement gChildXe = (XmlElement)gChild;
                                    var gIDChild = gChildXe.GetAttribute("id");
                                    if (dic_gNds.ContainsKey(gIDChild) && dic_gNds[gIDChild] != null)
                                    {
                                        lxn_gNds.Add(gChild.Clone());
                                        dic_gNds[gIDChild] = null;
                                        int_uiCount++;
                                    }
                                }

                                if (int_uiCount == gChildren.Count)
                                {
                                    removeAllChildNodes(parent);
                                    foreach (var gNdK_src in lxn_gNds)
                                    {
                                        parent.AppendChild(gNdK_src);
                                    }

                                    var parent_tar = xmlDoc.SelectSingleNode("//xlfns:target/xlfns:mrk//xlfns:g[@id='" + gIDParent + "']", xnm);
                                    if (parent_tar != null)
                                    {
                                        var gNdsK_tar = parent_tar.SelectNodes("./xlfns:g", xnm);
                                        if (gNdsK_tar.Count >= 2)
                                        {
                                            lxn_gNds.Clear();
                                            foreach (XmlNode gNdK_tar in gNdsK_tar)
                                            {
                                                lxn_gNds.Add(gNdK_tar.Clone());
                                            }

                                            removeAllChildNodes(parent_tar);
                                            foreach (var gNd_tar in lxn_gNds)
                                            {
                                                parent_tar.AppendChild(gNd_tar);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            XmlWriterSettings xws = new XmlWriterSettings();
            xws.NewLineOnAttributes = false;
            xws.CheckCharacters = false;
            xws.Encoding = Encoding.UTF8;
            xws.Indent = false;
            xws.NamespaceHandling = NamespaceHandling.OmitDuplicates;
            xws.NewLineChars = "\r\n";
            xws.NewLineHandling = NewLineHandling.None;
            xws.OmitXmlDeclaration = false;
            using (var xw = XmlWriter.Create(str_fileOut, xws))
            {
                xmlDoc.Save(xw);
            }

            var textOut = File.ReadAllText(str_fileOut);
            textOut = Regex.Replace(textOut, @"&amp;#38;(?!amp;|lt;|gt;)(#\d+?;|[a-zA-Z]+?;)", "&$1");
            File.WriteAllText(str_fileOut, textOut, Encoding.UTF8);
        }

        public void modifyPreEngXML(String str_fileIn, String str_fileOut)
        {
            var content = File.ReadAllText(str_fileIn);
            var repC1 = Regex.Replace(content, @"</ph>\s+<ph\b", "</ph> <ph");
            var repC2 = Regex.Replace(repC1, @"([a-zA-Z\d]+)\s+<ph\b", "$1 <ph");
            var repC3 = Regex.Replace(repC2, @"</ph>\s+([a-zA-Z\d]+)", "</ph> $1");
            var repC4 = Regex.Replace(repC3, @"([\.\?\!])\s+<ph\b", "$1 <ph");
            var repC5 = Regex.Replace(repC4, @"</tm>\s+<tm\b", "</tm> <tm");
            File.WriteAllText(str_fileOut, repC5, Encoding.Unicode);
        }

        public void removeAllChildNodes(XmlNode parent)
        {
            var xnl_child = parent.ChildNodes;
            while (xnl_child.Count > 0)
            {
                parent.RemoveChild(xnl_child[0]);
            }
        }

        private void Form_ModifyFileForAlign_Load(object sender, EventArgs e)
        {
            this.tabControl_proces.Enabled = true;
            this.panel_set.Enabled = true;
            this.tb_pathIn.Text = "";
            this.tb_pathOut.Text = "";
            this.rBtn_TTX.Checked = true;
            this.rBtn_XML.Checked = false;
            this.rBtn_xliff.Checked = false;
            this.btn_run.Enabled = false;

            this.panel_set2.Enabled = true;
            this.tb_pathIn2.Text = "";
            this.tb_pathOut2.Text = "";
            this.btn_run2.Enabled = false;

            this.panel_proBar.Controls.Clear();
        }

        private void tb_pathIn_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void tb_pathOut_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn.Text) || String.IsNullOrEmpty(this.tb_pathOut.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut.Text))
                this.btn_run.Enabled = false;
            else
                this.btn_run.Enabled = true;
        }

        private void rBtn_TTX_CheckedChanged(object sender, EventArgs e)
        {
            b_TTX = this.rBtn_TTX.Checked;
        }

        private void rBtn_XML_CheckedChanged(object sender, EventArgs e)
        {
            b_XML = this.rBtn_XML.Checked;
        }

        private void rBtn_xliff_CheckedChanged(object sender, EventArgs e)
        {
            b_xliff = this.rBtn_xliff.Checked;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            this.panel_proBar.Controls.Clear();
            ProgressBar proBar_files = new ProgressBar();
            this.panel_proBar.Controls.Add(proBar_files);
            proBar_files.Dock = DockStyle.Fill;
            proBar_files.Minimum = 0;

            var str_pathIn = this.tb_pathIn.Text;
            var str_pathOut = this.tb_pathOut.Text;

            if (!Directory.Exists(str_pathIn))
            {
                MessageBox.Show("The Path Input does not exist.\r\n" + str_pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_pathIn.Text = "";
            }
            else
            {
                this.tabControl_proces.Enabled = false;

                if (b_TTX == true)
                {
                    var files = Directory.GetFiles(str_pathIn, "*.ttx", SearchOption.AllDirectories);
                    if (files.Length < 1)
                    {
                        MessageBox.Show("There is no any TTX type file in the Path Input.\r\n" + str_pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.tabControl_proces.Enabled = true;
                        this.tb_pathIn.Text = "";
                    }
                    else
                    {
                        proBar_files.Maximum = files.Length;
                        foreach (var file in files)
                        {
                            var fileOut = file.Replace(str_pathIn, str_pathOut);
                            if (File.Exists(fileOut))
                                File.Delete(fileOut);

                            if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                            modifyTTX(file, fileOut);
                            proBar_files.Value++;
                        }
                        MessageBox.Show("Done!!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (b_XML == true)
                {
                    var files = Directory.GetFiles(str_pathIn, "*.xml", SearchOption.AllDirectories);
                    if (files.Length < 1)
                    {
                        MessageBox.Show("There is no any XML type file in the Path Input.\r\n" + str_pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.tabControl_proces.Enabled = true;
                        this.tb_pathIn.Text = "";
                    }
                    else
                    {
                        proBar_files.Maximum = files.Length;
                        foreach (var file in files)
                        {
                            var fileOut = file.Replace(str_pathIn, str_pathOut);
                            if (File.Exists(fileOut))
                                File.Delete(fileOut);

                            if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                            modifyXML(file, fileOut);
                            proBar_files.Value++;
                        }
                        MessageBox.Show("Done!!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (b_xliff == true)
                {
                    var files = Directory.GetFiles(str_pathIn, "*.sdlxliff", SearchOption.AllDirectories);
                    if (files.Length < 1)
                    {
                        MessageBox.Show("There is no any XLIFF type file in the Path Input.\r\n" + str_pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.tabControl_proces.Enabled = true;
                        this.tb_pathIn.Text = "";
                    }
                    else
                    {
                        proBar_files.Maximum = files.Length;
                        foreach (var file in files)
                        {
                            var fileOut = file.Replace(str_pathIn, str_pathOut);
                            var NameNoEx = Path.GetFileNameWithoutExtension(fileOut);
                            if (!Regex.IsMatch(NameNoEx, @"[^\r\n\t]+\.xml$", RegexOptions.IgnoreCase))
                            {
                                var newNameNoEx = NameNoEx + ".xml";
                                fileOut = fileOut.Replace(NameNoEx, newNameNoEx);
                            }
                    
                            if (File.Exists(fileOut))
                                File.Delete(fileOut);

                            if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                                Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                            modifyXliff(file, fileOut);
                            proBar_files.Value++;
                        }
                        MessageBox.Show("Done!!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a file type you want to process.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                this.tabControl_proces.Enabled = true;
            }
        }

        private void tb_pathIn2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn2.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn2.Text) || String.IsNullOrEmpty(this.tb_pathOut2.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut2.Text))
                this.btn_run2.Enabled = false;
            else
                this.btn_run2.Enabled = true;
        }

        private void tb_pathOut2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_pathIn2.Text) || String.IsNullOrWhiteSpace(this.tb_pathIn2.Text) || String.IsNullOrEmpty(this.tb_pathOut2.Text) || String.IsNullOrWhiteSpace(this.tb_pathOut2.Text))
                this.btn_run2.Enabled = false;
            else
                this.btn_run2.Enabled = true;
        }

        private void btn_run2_Click(object sender, EventArgs e)
        {
            this.panel_proBar.Controls.Clear();
            ProgressBar proBar_files = new ProgressBar();
            this.panel_proBar.Controls.Add(proBar_files);
            proBar_files.Dock = DockStyle.Fill;
            proBar_files.Minimum = 0;

            var pathIn = this.tb_pathIn2.Text;
            var pathOut = this.tb_pathOut2.Text;
            if (!Directory.Exists(pathIn))
            {
                MessageBox.Show("The Path In does not exist.\r\n" + pathIn, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_pathIn2.Text = "";
            }
            else
            {
                this.tabControl_proces.Enabled = false;
                var files = Directory.GetFiles(pathIn, "*.xml", SearchOption.AllDirectories);
                if (files.Length < 1)
                {
                    MessageBox.Show("There is no any XML type file in the Path In.\r\n" + pathIn, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tabControl_proces.Enabled = true;
                    this.tb_pathIn2.Text = "";
                }
                else
                {
                    proBar_files.Maximum = files.Length;
                    foreach (var file in files)
                    { 
                        var fileOut = file.Replace(pathIn, pathOut);
                        if (File.Exists(fileOut))
                            File.Delete(fileOut);

                        if (!Directory.Exists(Path.GetDirectoryName(fileOut)))
                            Directory.CreateDirectory(Path.GetDirectoryName(fileOut));

                        modifyPreEngXML(file, fileOut);
                        proBar_files.Value++;
                    }
                    MessageBox.Show("Done!!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tabControl_proces.Enabled = true;
                }
            }
        }
    }
}
