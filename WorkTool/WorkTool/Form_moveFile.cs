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

namespace WorkTool
{
    public partial class Form_moveFile : Form
    {
        public Form_moveFile()
        {
            InitializeComponent();
        }

        public List<FileInfo> lfi_fileList;
        public String str_fileType;
        public String str_path;

        private void Form_moveFile_Load(object sender, EventArgs e)
        {
            
            lfi_fileList = new List<FileInfo>();

            this.tb_path.Text = "";
            this.tb_type.Text = "sdlppx";
            this.btn_run.Enabled = false;
            this.timer_listFiles.Enabled = false;
            this.timer_move.Enabled = false;

            ToolTip tt_lab_tip = new ToolTip();
            tt_lab_tip.SetToolTip(this.lab_tip, "Separated with \";\" like \"sdlppx;xml;txt\".");
            tt_lab_tip.AutoPopDelay = 9000;
            tt_lab_tip.InitialDelay = 100;
            tt_lab_tip.ReshowDelay = 200;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text) && !String.IsNullOrEmpty(this.tb_type.Text) && !String.IsNullOrWhiteSpace(this.tb_type.Text))
                this.btn_run.Enabled = true;
            else
                this.btn_run.Enabled = false;
        }

        private void tb_type_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_path.Text) && !String.IsNullOrWhiteSpace(this.tb_path.Text) && !String.IsNullOrEmpty(this.tb_type.Text) && !String.IsNullOrWhiteSpace(this.tb_type.Text))
                this.btn_run.Enabled = true;
            else
                this.btn_run.Enabled = false;
        }

        private void timer_listFiles_Tick(object sender, EventArgs e)
        {
            this.timer_listFiles.Enabled = false;
            List<FileInfo> l_files = new List<FileInfo>();
            ArrayList al_fileType = new ArrayList();

            al_fileType = ClassLib_RML.SplitString(str_fileType, ";");
            ClassLib_RML.GetFilesListOfFolder(str_path, true, l_files);

            foreach (FileInfo finfo in l_files)
            {
                for (int index = 0; index < al_fileType.Count; index++)
                {
                    if (finfo.Extension == "." + al_fileType[index])
                        lfi_fileList.Add(finfo);
                }
            }

            if (lfi_fileList.Count > 0)
                this.timer_move.Enabled = true;
            else
                MessageBox.Show("Can not find file to move!\r\nPlease check your file type setting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timer_move_Tick(object sender, EventArgs e)
        {
            this.timer_move.Enabled = false;
            int int_moveCount = 0;
            foreach (FileInfo finfo in lfi_fileList)
            {
                String str_fName = finfo.Name;
                Regex regx = new Regex(@"(?<=_)[a-z]{2}-[A-Z]{2}(?=_|-)");
                String str_newName = regx.Match(str_fName,0).ToString();
                //MessageBox.Show(str_newName);
                if (Regex.IsMatch(str_newName, @"[a-z]{2}-[A-Z]{2}"))
                {
                    String str_newPath = Path.Combine(str_path, str_newName);
                    str_newPath = Path.Combine(str_newPath, "ForTrans");
                    if (!Directory.Exists(str_newPath))
                        Directory.CreateDirectory(str_newPath);

                    str_newPath = Path.Combine(str_newPath, finfo.Name);
                    File.Move(finfo.FullName, str_newPath);
                    int_moveCount++;
                }
            }

            if (int_moveCount > 0)
                MessageBox.Show("DONE!\r\n" + int_moveCount + " moved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("FAIL!\r\n0 moved.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.tb_path.Enabled = true;
            this.tb_type.Enabled = true;
            this.tb_path.Text = "";
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            str_path = this.tb_path.Text;
            str_fileType = this.tb_type.Text;
            lfi_fileList.Clear();

            this.tb_path.Enabled = false;
            this.tb_type.Enabled = false;
            this.btn_run.Enabled = false;
            this.timer_listFiles.Enabled = true;
        }
    }
}
