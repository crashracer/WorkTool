using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkTool
{
    public partial class Form_editFilelistForP4Dowload : Form
    {
        public Form_editFilelistForP4Dowload()
        {
            InitializeComponent();
        }

        private void Form_editFilelistForP4Dowload_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (Form_downloadP4files.ls_filelist.Count >= 1)
            {
                int rowcount = 0;
                this.dataGridView_filelist.Rows.Add(Form_downloadP4files.ls_filelist.Count);
                foreach (var file in Form_downloadP4files.ls_filelist)
                {
                    this.dataGridView_filelist.Rows[rowcount].Cells[0].Value = file;
                    rowcount++;
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_filelist.Rows.Count > 1)
            {
                for (int idxrow = this.dataGridView_filelist.Rows.Count - 2; idxrow >= 0; idxrow--)
                {
                    this.dataGridView_filelist.Rows.RemoveAt(idxrow);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Form_downloadP4files.ls_filelist.Clear();
            foreach (DataGridViewRow row in this.dataGridView_filelist.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value != null)
                {
                    var file = row.Cells[0].Value.ToString();
                    if (!String.IsNullOrEmpty(file) && !String.IsNullOrWhiteSpace(file))
                        Form_downloadP4files.ls_filelist.Add(file);
                }
            }

            if (Form_downloadP4files.ls_filelist.Count >= 1)
                this.Close();
            else
            { 
                if(MessageBox.Show("You did not add any downloaded file in the File List. \r\nDo you want to continue adding files?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    this.Close();
            }
        }
    }
}
