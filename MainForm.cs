using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//This is my first commit

namespace MiFaVPN
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> localGroups;/** You have to insert vpn groups*/
        private Dictionary<string, string> admins;/** users of administrators group */

        /// <summary>
        /// Run command
        /// </summary>
        /// <param name="Command">windows OS command</param>
        /// <returns>result of executing code</returns>
        private int ExecuteCommand(string Command)
        {
            this.Enabled = false;

            int eCode = 0;

            try
            {
                ProcessStartInfo ProcessInfo;
                Process process;

                ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + Command);
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = false;
                ProcessInfo.RedirectStandardError = true;
                ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;

                
                

                process = Process.Start(ProcessInfo);
                process.WaitForExit();

                this.Enabled = true;
                

                eCode = process.ExitCode;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                
            }

            return eCode;
            
        }


        /// <summary>
        /// Get All Users On The Server
        /// </summary>
        /// <returns></returns>
        private List<string> GetLocalUsers()
        {
            List<string> users = new List<string>();
            var path =
                string.Format("WinNT://{0},computer", Environment.MachineName);

            using (var computerEntry = new DirectoryEntry(path))
                foreach (DirectoryEntry childEntry in computerEntry.Children)
                    if (childEntry.SchemaClassName == "User")
                        users.Add(childEntry.Name);

            return users;
        }

        

       
        public MainForm()
        {
            

            InitializeComponent();

            localGroups = new Dictionary<string, string>();

            //you have to create key of dic on the local group of the server
            localGroups.Add("VPN 1M", "A month");
            localGroups.Add("VPN 3M", "3 months");
            localGroups.Add("VPN 6M", "6 months");
            localGroups.Add("VPN 12M", "A year");
            localGroups.Add("VPN Unlimit", "Unlimited");

            cbUserGroups.DataSource = new BindingSource(localGroups, null);
            cbUserGroups.DisplayMember = "value";
            cbUserGroups.ValueMember = "key";

            cbRenewUser_userGroups.DataSource = new BindingSource(localGroups, null);
            cbRenewUser_userGroups.DisplayMember = "value";
            cbRenewUser_userGroups.ValueMember = "key";

            
            //at first i added admins of the server manually, at next i want load from administators group
            //issue link : https://github.com/moqaniyani/VPNUsersManager/issues/1#issue-569691445
            admins = new Dictionary<string, string>();
            admins.Add("Milad Moqaniyani", "میلاد");
            admins.Add("Farhad Sabzehban", "فرهاد");

            cbAdmins.DataSource = new BindingSource(admins, null);
            cbAdmins.DisplayMember = "value";
            cbAdmins.ValueMember = "key";

            cb_selectUser.DataSource = GetLocalUsers();
            cbRenewUser_users.DataSource = GetLocalUsers();
            cbChangePassword_users.DataSource = GetLocalUsers();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbUserGroups.SelectedIndex = 0;

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);

            //you have to run commands as administrator of the server so
            //i try to run this app as administrator for users
            if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
            {
                MessageBox.Show("You have to run this application as Administrator");
                Application.Exit();
            }
        }

        private void bCreatUser_Click(object sender, EventArgs e)
        {
            string currentLoggedInUser = cbAdmins.SelectedValue.ToString();

            //build default commands for add user,password never expire,add user to vpn group
            string commandAddUser = "net user /add {0} {1} /expires:{2} /fullname:\"{3}\" /comment:\"Created by {4}\" /passwordchg:no /logonpasswordchg:no";
            string commandPasswordNeverExpires = "wmic useraccount where \"Name='{0}'\" set PasswordExpires=false";
            string commandAddToGroup = "net localgroup \"{0}\" {1} /add";

            
            DateTime expireDate = DateTime.Now;

            int exitCode = 0;

            //add users to selected vpn group command
            switch (cbUserGroups.SelectedValue.ToString())
            {
                case "VPN 1M":
                    exitCode = ExecuteCommand(string.Format(commandAddUser, txtUserName.Text, txtUserPassword.Text, expireDate.AddMonths(1).ToShortDateString(), txtFullUserName.Text, @currentLoggedInUser));
                    if(exitCode != 0)
                    {
                        MessageBox.Show("a problem on user creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exitCode = ExecuteCommand(string.Format(commandPasswordNeverExpires, txtUserName.Text));

                        if(exitCode != 0)
                        {
                            MessageBox.Show("a problem on never expire password of user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            exitCode = ExecuteCommand(string.Format(commandAddToGroup, cbUserGroups.SelectedValue.ToString(), txtUserName.Text));

                            if(exitCode != 0)
                            {
                                MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("New user added", "Info");
                            }
                        }
                    }  
                    break;
                case "VPN 3M":
                    exitCode = ExecuteCommand(string.Format(commandAddUser, txtUserName.Text, txtUserPassword.Text, expireDate.AddMonths(3).ToShortDateString(), txtFullUserName.Text, @currentLoggedInUser));
                    if (exitCode != 0)
                    {
                        MessageBox.Show("a problem on user creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exitCode = ExecuteCommand(string.Format(commandPasswordNeverExpires, txtUserName.Text));

                        if (exitCode != 0)
                        {
                            MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            exitCode = ExecuteCommand(string.Format(commandAddToGroup, cbUserGroups.SelectedValue.ToString(), txtUserName.Text));

                            if (exitCode != 0)
                            {
                                MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("New user added", "Info");
                            }
                        }
                    }
                    break;
                case "VPN 6M":
                    exitCode = ExecuteCommand(string.Format(commandAddUser, txtUserName.Text, txtUserPassword.Text, expireDate.AddMonths(6).ToShortDateString(), txtFullUserName.Text, @currentLoggedInUser));
                    if (exitCode != 0)
                    {
                        MessageBox.Show("a problem on user creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exitCode = ExecuteCommand(string.Format(commandPasswordNeverExpires, txtUserName.Text));

                        if (exitCode != 0)
                        {
                            MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            exitCode = ExecuteCommand(string.Format(commandAddToGroup, cbUserGroups.SelectedValue.ToString(), txtUserName.Text));

                            if (exitCode != 0)
                            {
                                MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("New user added", "Info");
                            }
                        }
                    }
                    break;
                case "VPN 12M":
                    exitCode = ExecuteCommand(string.Format(commandAddUser, txtUserName.Text, txtUserPassword.Text, expireDate.AddMonths(12).ToShortDateString(), txtFullUserName.Text, @currentLoggedInUser));
                    if (exitCode != 0)
                    {
                        MessageBox.Show("a problem on user creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exitCode = ExecuteCommand(string.Format(commandPasswordNeverExpires, txtUserName.Text));

                        if (exitCode != 0)
                        {
                            MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            exitCode = ExecuteCommand(string.Format(commandAddToGroup, cbUserGroups.SelectedValue.ToString(), txtUserName.Text));

                            if (exitCode != 0)
                            {
                                MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("New user added", "Info");
                            }
                        }
                    }
                    break;
                case "VPN Unlimit":
                    commandAddUser = "net user /add {0} {1} /fullname:\"{2}\" /comment:\"Created by {3}\" /passwordchg:no /logonpasswordchg:no";

                    exitCode = ExecuteCommand(string.Format(commandAddUser, txtUserName.Text, txtUserPassword.Text, txtFullUserName.Text, @currentLoggedInUser));
                    if (exitCode != 0)
                    {
                        MessageBox.Show("a problem on user creation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        exitCode = ExecuteCommand(string.Format(commandPasswordNeverExpires, txtUserName.Text));

                        if (exitCode != 0)
                        {
                            MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            exitCode = ExecuteCommand(string.Format(commandAddToGroup, cbUserGroups.SelectedValue.ToString(), txtUserName.Text));

                            if (exitCode != 0)
                            {
                                MessageBox.Show("a problem on adding user to a group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("New user added", "Info");
                            }
                        }
                    }
                    break;
            }

            cb_selectUser.DataSource = GetLocalUsers();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void tabPage_editUser_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_createUsers_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           
            
           
                    
            

        }


        private void btn_delUser_Click(object sender, EventArgs e)
        {
            try
            {
                //build command for remove user and execute
                string command = "net user {0} /DELETE";
                int exitCode = ExecuteCommand(string.Format(command, cb_selectUser.SelectedValue.ToString()));

                if(exitCode != 0)
                {
                    MessageBox.Show("a problem on remove user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("User removed","Info", MessageBoxButtons.OK, 
                        MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        
                    cb_selectUser.DataSource = GetLocalUsers();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_LoadCombo_Click(object sender, EventArgs e)
        {

            cb_selectUser.DataSource = GetLocalUsers();
            
        }

        private void cbRenewUsers_renew_Click(object sender, EventArgs e)
        {
            //build renewal users command and execut
            DateTime expireDate = DateTime.Now;

            int exitCode = 0;

            string commandRenewUser = "net user {0} /expires:{1}";

            switch (cbRenewUser_userGroups.SelectedValue.ToString())
            {
                case "VPN 1M":
                    exitCode = ExecuteCommand(string.Format(commandRenewUser, cbRenewUser_users.SelectedValue.ToString(), expireDate.AddMonths(1).ToShortDateString()));
                    break;
                case "VPN 3M":
                    exitCode = ExecuteCommand(string.Format(commandRenewUser, cbRenewUser_users.SelectedValue.ToString(), expireDate.AddMonths(3).ToShortDateString()));
                    break;
                case "VPN 12M":
                    exitCode = ExecuteCommand(string.Format(commandRenewUser, cbRenewUser_users.SelectedValue.ToString(), expireDate.AddMonths(12).ToShortDateString()));
                    break;
                case "VPN Unlimit":
                    exitCode = ExecuteCommand(string.Format(commandRenewUser, cbRenewUser_users.SelectedValue.ToString(), "never"));
                    break;
                default:
                    if (exitCode != 0)
                    {
                        MessageBox.Show("a problem on renewal the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

            if(exitCode == 0)
            {
                string message = string.Format("Selected user : {0} renewaled",cbRenewUser_users.SelectedValue.ToString());

                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            }
        }

        private void btChangePassword_changePassword_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbChangePassword_userPassword.Text.Trim()))
            {
                MessageBox.Show("Eneter the password please", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

                tbChangePassword_userPassword.Focus();
            }
            else
            {
                int exitCode = 0;

                string commandChangePassword = string.Format("net user {0} {1}", cbChangePassword_users.SelectedValue.ToString(), tbChangePassword_userPassword.Text);
                try
                {
                    exitCode = ExecuteCommand(string.Format(commandChangePassword, cbRenewUser_users.SelectedValue.ToString(), "never"));

                    if (exitCode == 0)
                    {
                        string message = string.Format("User password changed", cbChangePassword_users.SelectedValue.ToString());

                        MessageBox.Show(message, "پیام", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            
        }

        private void tabPage_changePassword_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application developed by Milad Moqaniyani"
                + Environment.NewLine
                + "Contact Information :"
                + Environment.NewLine
                + "--------------------"
                + Environment.NewLine
                + "Email: m.moqaniyani@gmail.com" + Environment.NewLine
                + "Tell: 09303229538" + Environment.NewLine
                + "TelegramID: @MiladMiFa" + Environment.NewLine
                + "=====================" + Environment.NewLine
                + "Developed For MiFa VPN , TelegramID \'@MiFaVPN\'" + Environment.NewLine
                + @"https://github.com/moqaniyani/VPN-Users-Manager"
                , "About This Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
