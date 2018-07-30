using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Automation;
using MyClassLib_rml;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using Perforce.P4;

namespace WorkTool
{
    public partial class Form_downloadP4files : Form
    {
        public Form_downloadP4files()
        {
            InitializeComponent();
        }

        private String str_cfgfile = Path.Combine(Form_Main.str_configFolder, "DownloadP4Files.ini");
        public static List<String> ls_filelist = new List<String>();

        private void initApp()
        {
            if (!System.IO.File.Exists(str_cfgfile))
            {
                ClassLib_RML.WriteValueToINI("Server", "Server1", "10.204.16.168:1667", str_cfgfile);
                ClassLib_RML.WriteValueToINI("User", "User1", "L10N02_Hisoft", str_cfgfile);
                ClassLib_RML.WriteValueToINI("Workspace", "Workspace1", "TM_ENG04", str_cfgfile);
                ClassLib_RML.WriteValueToINI("Password", "CurrentPWD", "Trend2018!", str_cfgfile);
            }

            var servers = ClassLib_RML.ReadKeysFromINI("Server", str_cfgfile);
            foreach (String server in servers)
            {
                this.comBox_Server.Items.Add(ClassLib_RML.ReadeValueFromINI("Server", server, str_cfgfile));
            }

            var users = ClassLib_RML.ReadKeysFromINI("User", str_cfgfile);
            foreach (String user in users)
            {
                this.comBox_User.Items.Add(ClassLib_RML.ReadeValueFromINI("User", user, str_cfgfile));
            }

            var workspaces = ClassLib_RML.ReadKeysFromINI("Workspace", str_cfgfile);
            foreach (String workspace in workspaces)
            {
                this.comBox_Workspace.Items.Add(ClassLib_RML.ReadeValueFromINI("Workspace", workspace, str_cfgfile));
            }

            this.tb_Password.Text = ClassLib_RML.ReadeValueFromINI("Password", "CurrentPWD", str_cfgfile);
        }

        private void addRunInfo(String str_runinfo)
        {
            this.tb_runinfo.Text = this.tb_runinfo.Text + "\r\n[" + DateTime.Now.ToString("HH:mm:ss") + "] " + str_runinfo;
        }

        private void Form_downloadP4files_Load(object sender, EventArgs e)
        {
            this.panel_set.Enabled = true;
            initApp();
            this.comBox_Server.SelectedIndex = 0;
            this.comBox_User.SelectedIndex = 0;
            this.comBox_Workspace.SelectedIndex = 0;
            this.tb_runinfo.Text = "You have not added the list of downloaded files. Please click \"Edit the Filelist of Download\" to add.";
            this.btn_download.Enabled = false;
        }

        private void btn_addServer_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.comBox_Server.Text) && !String.IsNullOrWhiteSpace(this.comBox_Server.Text))
            {
                if (!this.comBox_Server.Items.Contains(this.comBox_Server.Text))
                {
                    this.comBox_Server.Items.Add(this.comBox_Server.Text);
                    ClassLib_RML.WriteValueToINI("Server", "Server" + this.comBox_Server.Items.Count.ToString(), this.comBox_Server.Text, str_cfgfile);
                    addRunInfo("New server added successfully.");
                }
                else
                    MessageBox.Show("This server has existed in the list and no need to add again.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                this.comBox_Server.SelectedIndex = 0;
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.comBox_User.Text) && !String.IsNullOrWhiteSpace(this.comBox_User.Text))
            {
                if (!this.comBox_User.Items.Contains(this.comBox_User.Text))
                {
                    this.comBox_User.Items.Add(this.comBox_User.Text);
                    ClassLib_RML.WriteValueToINI("User", "User" + this.comBox_User.Items.Count.ToString(), this.comBox_User.Text, str_cfgfile);
                    addRunInfo("New user added successfully.");
                }
                else
                    MessageBox.Show("This user has existed in the list and no need to add again.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                this.comBox_User.SelectedIndex = 0;
        }

        private void btn_addWorkspace_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.comBox_Workspace.Text) && !String.IsNullOrWhiteSpace(this.comBox_Workspace.Text))
            {
                if (!this.comBox_Workspace.Items.Contains(this.comBox_Workspace.Text))
                {
                    this.comBox_Workspace.Items.Add(this.comBox_Workspace.Text);
                    ClassLib_RML.WriteValueToINI("Workspace", "Workspace" + this.comBox_Workspace.Items.Count.ToString(), this.comBox_Workspace.Text, str_cfgfile);
                    addRunInfo("New workspace added successfully.");
                }
                else
                    MessageBox.Show("This workspace has existed in the list and no need to add again.", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                this.comBox_Workspace.SelectedIndex = 0;
        }

        private void btn_updPassword_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tb_Password.Text) && !String.IsNullOrWhiteSpace(this.tb_Password.Text))
            {
                ClassLib_RML.WriteValueToINI("Password", "CurrentPWD", this.tb_Password.Text, str_cfgfile);
                addRunInfo("Password updated successfully.");
            }
            else
                this.tb_Password.Text = ClassLib_RML.ReadeValueFromINI("Password", "CurrentPWD", str_cfgfile);
        }

        private void btn_editFilelist_Click(object sender, EventArgs e)
        {
            Form_editFilelistForP4Dowload feflfp4d = new Form_editFilelistForP4Dowload();
            feflfp4d.ShowDialog();

            if (ls_filelist.Count >= 1)
            {
                addRunInfo("Notice: You have added " + ls_filelist.Count.ToString() + " file(s) to list.");
                this.btn_download.Enabled = true;
            }
            else
            {
                addRunInfo("Warning: You did not add downloaded files to list!");
                this.btn_download.Enabled = false;
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            this.tb_runinfo.Text = "------------------------------------ START ------------------------------------\r\n";
            var server = this.comBox_Server.Text;
            var user = this.comBox_User.Text;
            var workspace = this.comBox_Workspace.Text;
            var password = this.tb_Password.Text;
            this.panel_set.Enabled = false;
            this.btn_download.Enabled = false;

            try
            {
                Server conServer = new Server(new ServerAddress(server));
                Repository rep = new Repository(conServer);
                Connection con = rep.Connection;
                con.UserName = user;
                con.Client = new Client();
                con.Client.Name = workspace;
                con.Connect(null);
                Credential cred = con.Login(password, null, null);

                foreach (var file in ls_filelist)
                {
                    addRunInfo(file);
                    P4Command cmd = new P4Command(rep, "sync", true, file);
                    Options opts = new Options();
                    opts["-f"] = null;
                    var results = cmd.Run(opts);
                    String str_msgtext = "";
                    foreach (var msg in results.TaggedOutput)
                    {
                        if (msg.ContainsKey("totalFileCount"))
                            str_msgtext = str_msgtext + "\t" + "Total File Count: " + msg["totalFileCount"] +"\r\n";

                        if(msg.ContainsKey("change"))
                            str_msgtext = str_msgtext + "\t" + "ChangeList: " + msg["change"] + "\r\n";
                    }
                    this.tb_runinfo.Text = this.tb_runinfo.Text + "\r\n" + str_msgtext;
                }

                this.tb_runinfo.Text += "\r\n------------------------------------ END ------------------------------------";
                MessageBox.Show("Download completed!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (P4Exception p4ex)
            {
                this.tb_runinfo.Text += "\r\n------------------------------------ ERROR ------------------------------------";
                MessageBox.Show(p4ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }

            this.panel_set.Enabled = true;
            this.btn_download.Enabled = true;
        }
    }
}
