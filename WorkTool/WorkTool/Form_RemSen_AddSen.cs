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

namespace WorkTool
{
    public partial class Form_RemSen_AddSen : Form
    {
        public Form_RemSen_AddSen()
        {
            InitializeComponent();
        }

        private void Form_RemSen_AddSen_Load(object sender, EventArgs e)
        {
            this.tb_enterSen.Text = "";
            this.btn_add.Enabled = false;
            this.lb_addSen.Items.Clear();
            this.btn_clear.Enabled = true;
            this.btn_save.Enabled = false;

            if (Form_RemoveSentence.al_addSen.Count > 0)
            {
                for (int idx = 0; idx < Form_RemoveSentence.al_addSen.Count; idx++)
                {
                    this.lb_addSen.Items.Add(Form_RemoveSentence.al_addSen[idx]);
                    this.lb_addSen.SelectedIndex = 0;
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.lb_addSen.Items.Clear();
            this.btn_save.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.lb_addSen.Items.Insert(0, this.tb_enterSen.Text);
            this.lb_addSen.SelectedIndex = 0;
            this.tb_enterSen.Text = "";
            this.btn_save.Enabled = true;
        }

        private void tb_enterSen_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_enterSen.Text) && !String.IsNullOrWhiteSpace(this.tb_enterSen.Text))
                this.btn_add.Enabled = true;
            else
                this.btn_add.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int int_addCount = 0;
            String str_keyName = ""; 
            Form_RemoveSentence.al_addSen.Clear();
            File.Delete(Form_RemoveSentence.str_cfgfile);

            for (int idx = 0; idx < this.lb_addSen.Items.Count; idx++)
            {
                int_addCount++;
                if(int_addCount < 10)
                    str_keyName = "Sentence_0" + int_addCount.ToString();
                else
                    str_keyName = "Sentence_" + int_addCount.ToString();

                Form_RemoveSentence.al_addSen.Add(this.lb_addSen.Items[idx]);
                ClassLib_RML.WriteValueToINI("REMOVE_SENTENCES", str_keyName, "$$Rem$$" + this.lb_addSen.Items[idx].ToString() + "$$Rem$$", Form_RemoveSentence.str_cfgfile);
            }
            this.Close();
        }
    }
}
