using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WorkTool
{
    public partial class Form_renameFilePath : Form
    {
        public Form_renameFilePath()
        {
            InitializeComponent();
        }

        private string[] invalidchar = { "\\", "/", ":", "*", "?", "\"", "<", ">", "|"};

        private void Form_renameFilePath_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            this.tb_input.Text = "";
            this.tb_output.Text = "";
            this.tb_fileType.Text = "*.*";
            this.tb_Separator.Text = ";";
            this.lab_info.Text = "";
            this.btn_rename.Enabled = false;
            this.btn_restore.Enabled = false;
        }

        private void tb_input_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_input.Text) || String.IsNullOrWhiteSpace(this.tb_input.Text) || String.IsNullOrEmpty(this.tb_output.Text) || String.IsNullOrWhiteSpace(this.tb_output.Text))
            {
                this.btn_rename.Enabled = false;
                this.btn_restore.Enabled = false;
            }
            else
            {
                this.btn_rename.Enabled = true;
                this.btn_restore.Enabled = true;
            }
        }

        private void tb_output_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_input.Text) || String.IsNullOrWhiteSpace(this.tb_input.Text) || String.IsNullOrEmpty(this.tb_output.Text) || String.IsNullOrWhiteSpace(this.tb_output.Text))
            {
                this.btn_rename.Enabled = false;
                this.btn_restore.Enabled = false;
            }
            else
            {
                this.btn_rename.Enabled = true;
                this.btn_restore.Enabled = true;
            }
        }

        private void tb_Separator_TextChanged(object sender, EventArgs e)
        {
            if (invalidchar.Contains(this.tb_Separator.Text))
            {
                MessageBox.Show("Separator can not be the following characters:\r\n\\ / : * ? \" < > |", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.tb_Separator.Text = ";";
            }
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            var input = this.tb_input.Text;
            if (!Directory.Exists(input))
            {
                MessageBox.Show("The Input path does not exist.\r\n" + input, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_input.Text = "";
            }
            else
            {
                var output = this.tb_output.Text;
                var separator = this.tb_Separator.Text;
                var type = this.tb_fileType.Text;
                this.panel_set.Enabled = false;
                this.btn_rename.Enabled = false;
                this.btn_restore.Enabled = false;
                this.lab_info.Text = "Renaming......";

                var directories = Directory.GetDirectories(input);
                foreach (var directory in directories)
                {
                    var files = Directory.GetFiles(directory, type, SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        var tmp = file.Replace(directory + "\\", "");
                        var newname = tmp.Replace("\\", separator);
                        var fileout = Path.Combine(directory, newname);
                        fileout = fileout.Replace(input, output);
                        if (!Directory.Exists(Path.GetDirectoryName(fileout)))
                            Directory.CreateDirectory(Path.GetDirectoryName(fileout));

                        File.Copy(file, fileout);
                    }
                }

                MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lab_info.Text = "Rename completed!";
                this.panel_set.Enabled = true;
                this.btn_rename.Enabled = true;
                this.btn_restore.Enabled = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            var input = this.tb_input.Text;
            if (!Directory.Exists(input))
            {
                MessageBox.Show("The Input path does not exist.\r\n" + input, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tb_input.Text = "";
            }
            else
            {
                var output = this.tb_output.Text;
                var separator = this.tb_Separator.Text;
                var type = this.tb_fileType.Text;
                this.panel_set.Enabled = false;
                this.btn_rename.Enabled = false;
                this.btn_restore.Enabled = false;
                this.lab_info.Text = "Restoring......";

                var files = Directory.GetFiles(input, type, SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    var fileout = file.Replace(separator, "\\");
                    fileout = fileout.Replace(input, output);
                    if (!Directory.Exists(Path.GetDirectoryName(fileout)))
                        Directory.CreateDirectory(Path.GetDirectoryName(fileout));

                    File.Copy(file, fileout);
                }

                MessageBox.Show("Done!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lab_info.Text = "Restore completed!";
                this.panel_set.Enabled = true;
                this.btn_rename.Enabled = true;
                this.btn_restore.Enabled = true;
            }
        }      
    }
}
