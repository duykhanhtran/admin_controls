using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_controls.PRE
{
    public partial class ad_uc_ep : UserControl
    {
        public ad_uc_ep()
        {
            InitializeComponent();
        }
        bool Check_Pass_Fill()
        {
            if(String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Current Password is required !!!", "Error");
                return false;
            }
            if (String.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("New Password is required !!!", "Error");
                return false;
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Re-Enter New Password is required !!!", "Error");
                return false;
            }
            if(txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("The password and Confirm password do not match", "Error");
                return false;
            }
            return true;
        }
        bool Check_Username_Fill()
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Current Username is required !!!", "Error");
                return false;
            }
            if (String.IsNullOrEmpty(txtNewUsername.Text))
            {
                MessageBox.Show("New Username is required !!!", "Error");
                return false;
            }

            return true;
        }
        void Clear_All()
        {
            txtConfirmPassword.Text = "";
            txtNewPassword.Text = "";
            txtNewUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if(Check_Pass_Fill())
            {
                tbl.tblAdmin ad = new tbl.tblAdmin(Admin_Control.Admin.ADMIN_ID, Admin_Control.Admin.USERNAME, txtNewPassword.Text);
                BUS.AdminBLL admin = new BUS.AdminBLL();
                if (txtPassword.Text != Admin_Control.Admin.PASSWORD)
                    MessageBox.Show("Password is not correct!!!", "Error");
                else
                    if (admin.UpdateAdmin(ad) == false)
                    {
                        MessageBox.Show("Can not change password !!!", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Successfully!!!");
                        Admin_Control.Admin.PASSWORD = ad.PASSWORD;
                        Clear_All();
                    }

            }
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if (Check_Username_Fill())
            {
                tbl.tblAdmin ad = new tbl.tblAdmin(Admin_Control.Admin.ADMIN_ID, txtNewUsername.Text, Admin_Control.Admin.PASSWORD);
                BUS.AdminBLL admin = new BUS.AdminBLL();
                if (txtUsername.Text != Admin_Control.Admin.USERNAME)
                    MessageBox.Show("Username is not correct!!!", "Error");
                else
                    if (admin.UpdateAdmin(ad) == false)
                {
                    MessageBox.Show("Can not change username !!!", "Error");
                }
                else
                {
                    MessageBox.Show("Successfully!!!");
                    Admin_Control.Admin.USERNAME = ad.USERNAME;
                    Clear_All();
                }

            }
        }
    }
}
