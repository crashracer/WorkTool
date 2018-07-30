using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace WorkTool
{
    public partial class Form_CheckRegex : Form
    {
        public Form_CheckRegex()
        {
            InitializeComponent();
        }

        private void Form_CheckRegex_Load(object sender, EventArgs e)
        {
            this.tb_regExpr.Text = "";
            this.tb_text.Text = "";
            this.tb_matchText.Text = "";
            this.lab_info.Text = "";
            this.btn_chk.Enabled = false;
            this.btn_clear.Enabled = true;
        }

        private void tb_regExpr_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_regExpr.Text) || String.IsNullOrWhiteSpace(this.tb_regExpr.Text) || String.IsNullOrEmpty(this.tb_text.Text) || String.IsNullOrWhiteSpace(this.tb_text.Text))
                this.btn_chk.Enabled = false;
            else
                this.btn_chk.Enabled = true;
        }

        private void tb_text_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.tb_regExpr.Text) || String.IsNullOrWhiteSpace(this.tb_regExpr.Text) || String.IsNullOrEmpty(this.tb_text.Text) || String.IsNullOrWhiteSpace(this.tb_text.Text))
                this.btn_chk.Enabled = false;
            else
                this.btn_chk.Enabled = true;
        }

        private void btn_chk_Click(object sender, EventArgs e)
        {
            String str_regExp = this.tb_regExpr.Text;
            String str_text = this.tb_text.Text;
            this.tb_regExpr.Enabled = false;
            this.tb_text.Enabled = false;
            this.btn_chk.Enabled = false;
            this.tb_matchText.Text = "";

            Regex reg = new Regex(str_regExp);
            if (Regex.IsMatch(str_text, str_regExp))
            {
                this.lab_info.Text = "✔ Match Successful";
                this.lab_info.ForeColor = Color.Green;
                MatchCollection mc_matchs = reg.Matches(str_text);
                int int_idx = 0;
                String str_tmp = "";
                foreach (Match mat in mc_matchs)
                {
                    
                    int_idx++;
                    if (int_idx > 1)
                    {
                        str_tmp += "\r\n\r\n[Part " + int_idx.ToString() + "]\r\n" + mat.ToString();
                    }
                    else
                    {
                        str_tmp += "[Part " + int_idx.ToString() + "]\r\n" + mat.ToString();
                    }
                }
                this.tb_matchText.Text = str_tmp;
            }
            else
            {
                this.lab_info.Text = "✘ Match Failed";
                this.lab_info.ForeColor = Color.Red;
            }
            this.tb_regExpr.Enabled = true;
            this.tb_text.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.tb_regExpr.Text = "";
            this.tb_text.Text = "";
            this.tb_matchText.Text = "";
            this.lab_info.Text = "";
        }

        private void tb_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                this.tb_text.SelectAll();
        }
    }
}
