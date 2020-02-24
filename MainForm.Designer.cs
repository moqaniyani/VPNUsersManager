namespace VPNUserManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUserGroups = new System.Windows.Forms.ComboBox();
            this.bCreatUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAdmins = new System.Windows.Forms.ComboBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage_createUsers = new System.Windows.Forms.TabPage();
            this.tabPage_delUser = new System.Windows.Forms.TabPage();
            this.btn_LoadCombo = new System.Windows.Forms.Button();
            this.btn_delUser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_selectUser = new System.Windows.Forms.ComboBox();
            this.tabPage_renewUser = new System.Windows.Forms.TabPage();
            this.cbRenewUsers_renew = new System.Windows.Forms.Button();
            this.cbRenewUser_userGroups = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRenewUser_users = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_changePassword = new System.Windows.Forms.TabPage();
            this.btChangePassword_changePassword = new System.Windows.Forms.Button();
            this.tbChangePassword_userPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbChangePassword_users = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabPage_createUsers.SuspendLayout();
            this.tabPage_delUser.SuspendLayout();
            this.tabPage_renewUser.SuspendLayout();
            this.tabPage_changePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(86, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(292, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select VPN Group :";
            // 
            // cbUserGroups
            // 
            this.cbUserGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserGroups.FormattingEnabled = true;
            this.cbUserGroups.Location = new System.Drawing.Point(129, 127);
            this.cbUserGroups.Name = "cbUserGroups";
            this.cbUserGroups.Size = new System.Drawing.Size(249, 24);
            this.cbUserGroups.TabIndex = 4;
            // 
            // bCreatUser
            // 
            this.bCreatUser.Location = new System.Drawing.Point(353, 162);
            this.bCreatUser.Name = "bCreatUser";
            this.bCreatUser.Size = new System.Drawing.Size(75, 23);
            this.bCreatUser.TabIndex = 5;
            this.bCreatUser.Text = "Add User";
            this.bCreatUser.UseVisualStyleBackColor = true;
            this.bCreatUser.Click += new System.EventHandler(this.bCreatUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Password :";
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(114, 68);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserPassword.Size = new System.Drawing.Size(264, 23);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Full Name :";
            // 
            // txtFullUserName
            // 
            this.txtFullUserName.Location = new System.Drawing.Point(86, 10);
            this.txtFullUserName.Name = "txtFullUserName";
            this.txtFullUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFullUserName.Size = new System.Drawing.Size(292, 23);
            this.txtFullUserName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Who Created :";
            // 
            // cbAdmins
            // 
            this.cbAdmins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdmins.FormattingEnabled = true;
            this.cbAdmins.Location = new System.Drawing.Point(114, 97);
            this.cbAdmins.Name = "cbAdmins";
            this.cbAdmins.Size = new System.Drawing.Size(264, 24);
            this.cbAdmins.TabIndex = 3;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage_createUsers);
            this.tabs.Controls.Add(this.tabPage_delUser);
            this.tabs.Controls.Add(this.tabPage_renewUser);
            this.tabs.Controls.Add(this.tabPage_changePassword);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.RightToLeftLayout = true;
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(442, 220);
            this.tabs.TabIndex = 7;
            // 
            // tabPage_createUsers
            // 
            this.tabPage_createUsers.Controls.Add(this.label4);
            this.tabPage_createUsers.Controls.Add(this.bCreatUser);
            this.tabPage_createUsers.Controls.Add(this.label1);
            this.tabPage_createUsers.Controls.Add(this.cbAdmins);
            this.tabPage_createUsers.Controls.Add(this.txtUserName);
            this.tabPage_createUsers.Controls.Add(this.label5);
            this.tabPage_createUsers.Controls.Add(this.label2);
            this.tabPage_createUsers.Controls.Add(this.txtFullUserName);
            this.tabPage_createUsers.Controls.Add(this.cbUserGroups);
            this.tabPage_createUsers.Controls.Add(this.label3);
            this.tabPage_createUsers.Controls.Add(this.txtUserPassword);
            this.tabPage_createUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPage_createUsers.Name = "tabPage_createUsers";
            this.tabPage_createUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_createUsers.Size = new System.Drawing.Size(434, 191);
            this.tabPage_createUsers.TabIndex = 0;
            this.tabPage_createUsers.Text = "Creat New User";
            this.tabPage_createUsers.UseVisualStyleBackColor = true;
            this.tabPage_createUsers.Click += new System.EventHandler(this.tabPage_createUsers_Click);
            // 
            // tabPage_delUser
            // 
            this.tabPage_delUser.Controls.Add(this.btn_LoadCombo);
            this.tabPage_delUser.Controls.Add(this.btn_delUser);
            this.tabPage_delUser.Controls.Add(this.label6);
            this.tabPage_delUser.Controls.Add(this.cb_selectUser);
            this.tabPage_delUser.Location = new System.Drawing.Point(4, 25);
            this.tabPage_delUser.Name = "tabPage_delUser";
            this.tabPage_delUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_delUser.Size = new System.Drawing.Size(434, 191);
            this.tabPage_delUser.TabIndex = 1;
            this.tabPage_delUser.Text = "Remove User";
            this.tabPage_delUser.UseVisualStyleBackColor = true;
            this.tabPage_delUser.Click += new System.EventHandler(this.tabPage_editUser_Click);
            // 
            // btn_LoadCombo
            // 
            this.btn_LoadCombo.Location = new System.Drawing.Point(126, 155);
            this.btn_LoadCombo.Name = "btn_LoadCombo";
            this.btn_LoadCombo.Size = new System.Drawing.Size(148, 30);
            this.btn_LoadCombo.TabIndex = 6;
            this.btn_LoadCombo.Text = "Reload Users List";
            this.btn_LoadCombo.UseVisualStyleBackColor = true;
            this.btn_LoadCombo.Click += new System.EventHandler(this.btn_LoadCombo_Click);
            // 
            // btn_delUser
            // 
            this.btn_delUser.Location = new System.Drawing.Point(280, 155);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(148, 30);
            this.btn_delUser.TabIndex = 5;
            this.btn_delUser.Text = "Remove Selected User";
            this.btn_delUser.UseVisualStyleBackColor = true;
            this.btn_delUser.Click += new System.EventHandler(this.btn_delUser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Select User :";
            // 
            // cb_selectUser
            // 
            this.cb_selectUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_selectUser.FormattingEnabled = true;
            this.cb_selectUser.Location = new System.Drawing.Point(94, 6);
            this.cb_selectUser.Name = "cb_selectUser";
            this.cb_selectUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_selectUser.Size = new System.Drawing.Size(334, 24);
            this.cb_selectUser.TabIndex = 0;
            // 
            // tabPage_renewUser
            // 
            this.tabPage_renewUser.Controls.Add(this.cbRenewUsers_renew);
            this.tabPage_renewUser.Controls.Add(this.cbRenewUser_userGroups);
            this.tabPage_renewUser.Controls.Add(this.label8);
            this.tabPage_renewUser.Controls.Add(this.cbRenewUser_users);
            this.tabPage_renewUser.Controls.Add(this.label7);
            this.tabPage_renewUser.Location = new System.Drawing.Point(4, 25);
            this.tabPage_renewUser.Name = "tabPage_renewUser";
            this.tabPage_renewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_renewUser.Size = new System.Drawing.Size(434, 191);
            this.tabPage_renewUser.TabIndex = 2;
            this.tabPage_renewUser.Text = "User Renewal";
            this.tabPage_renewUser.UseVisualStyleBackColor = true;
            // 
            // cbRenewUsers_renew
            // 
            this.cbRenewUsers_renew.Location = new System.Drawing.Point(353, 162);
            this.cbRenewUsers_renew.Name = "cbRenewUsers_renew";
            this.cbRenewUsers_renew.Size = new System.Drawing.Size(75, 23);
            this.cbRenewUsers_renew.TabIndex = 8;
            this.cbRenewUsers_renew.Text = "Renewal";
            this.cbRenewUsers_renew.UseVisualStyleBackColor = true;
            this.cbRenewUsers_renew.Click += new System.EventHandler(this.cbRenewUsers_renew_Click);
            // 
            // cbRenewUser_userGroups
            // 
            this.cbRenewUser_userGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenewUser_userGroups.FormattingEnabled = true;
            this.cbRenewUser_userGroups.Location = new System.Drawing.Point(129, 50);
            this.cbRenewUser_userGroups.Name = "cbRenewUser_userGroups";
            this.cbRenewUser_userGroups.Size = new System.Drawing.Size(161, 24);
            this.cbRenewUser_userGroups.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Select VPN Group :";
            // 
            // cbRenewUser_users
            // 
            this.cbRenewUser_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRenewUser_users.FormattingEnabled = true;
            this.cbRenewUser_users.Location = new System.Drawing.Point(94, 20);
            this.cbRenewUser_users.Name = "cbRenewUser_users";
            this.cbRenewUser_users.Size = new System.Drawing.Size(196, 24);
            this.cbRenewUser_users.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select User :";
            // 
            // tabPage_changePassword
            // 
            this.tabPage_changePassword.Controls.Add(this.btChangePassword_changePassword);
            this.tabPage_changePassword.Controls.Add(this.tbChangePassword_userPassword);
            this.tabPage_changePassword.Controls.Add(this.label10);
            this.tabPage_changePassword.Controls.Add(this.cbChangePassword_users);
            this.tabPage_changePassword.Controls.Add(this.label9);
            this.tabPage_changePassword.Location = new System.Drawing.Point(4, 25);
            this.tabPage_changePassword.Name = "tabPage_changePassword";
            this.tabPage_changePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_changePassword.Size = new System.Drawing.Size(434, 191);
            this.tabPage_changePassword.TabIndex = 3;
            this.tabPage_changePassword.Text = "Change User Password";
            this.tabPage_changePassword.UseVisualStyleBackColor = true;
            this.tabPage_changePassword.Click += new System.EventHandler(this.tabPage_changePassword_Click);
            // 
            // btChangePassword_changePassword
            // 
            this.btChangePassword_changePassword.Location = new System.Drawing.Point(304, 158);
            this.btChangePassword_changePassword.Name = "btChangePassword_changePassword";
            this.btChangePassword_changePassword.Size = new System.Drawing.Size(124, 27);
            this.btChangePassword_changePassword.TabIndex = 4;
            this.btChangePassword_changePassword.Text = "Change Password";
            this.btChangePassword_changePassword.UseVisualStyleBackColor = true;
            this.btChangePassword_changePassword.Click += new System.EventHandler(this.btChangePassword_changePassword_Click);
            // 
            // tbChangePassword_userPassword
            // 
            this.tbChangePassword_userPassword.Location = new System.Drawing.Point(113, 45);
            this.tbChangePassword_userPassword.Name = "tbChangePassword_userPassword";
            this.tbChangePassword_userPassword.Size = new System.Drawing.Size(232, 23);
            this.tbChangePassword_userPassword.TabIndex = 3;
            this.tbChangePassword_userPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbChangePassword_userPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "New Password :";
            // 
            // cbChangePassword_users
            // 
            this.cbChangePassword_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangePassword_users.FormattingEnabled = true;
            this.cbChangePassword_users.Location = new System.Drawing.Point(94, 15);
            this.cbChangePassword_users.Name = "cbChangePassword_users";
            this.cbChangePassword_users.Size = new System.Drawing.Size(251, 24);
            this.cbChangePassword_users.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Select User :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "about";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VPN Users Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage_createUsers.ResumeLayout(false);
            this.tabPage_createUsers.PerformLayout();
            this.tabPage_delUser.ResumeLayout(false);
            this.tabPage_delUser.PerformLayout();
            this.tabPage_renewUser.ResumeLayout(false);
            this.tabPage_renewUser.PerformLayout();
            this.tabPage_changePassword.ResumeLayout(false);
            this.tabPage_changePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUserGroups;
        private System.Windows.Forms.Button bCreatUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAdmins;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage_createUsers;
        private System.Windows.Forms.TabPage tabPage_delUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_selectUser;
        private System.Windows.Forms.Button btn_delUser;
        private System.Windows.Forms.Button btn_LoadCombo;
        private System.Windows.Forms.TabPage tabPage_renewUser;
        private System.Windows.Forms.Button cbRenewUsers_renew;
        private System.Windows.Forms.ComboBox cbRenewUser_userGroups;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRenewUser_users;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage_changePassword;
        private System.Windows.Forms.Button btChangePassword_changePassword;
        private System.Windows.Forms.TextBox tbChangePassword_userPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbChangePassword_users;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}