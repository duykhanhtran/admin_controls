using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_controls.PRE
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }
        #region Drag Form
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }
        #endregion

        private void ad_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f = new login();
            f.ShowDialog();
            this.Close();
        }

        private void lg_show_OnChange(object sender, EventArgs e)
        {
            if (lg_show.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
        bool Check_Fill()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is required !!!");
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required !!!");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BUS.AdminBLL admin = new BUS.AdminBLL();
            if(Check_Fill()==true)
            {
                tbl.tblAdmin ad = new tbl.tblAdmin("", txtUsername.Text, txtPassword.Text);
                if (admin.Check_Login(ref ad) == true)
                {
                    this.Hide();
                    PRE.Admin_Control sad = new PRE.Admin_Control(ad);
                    sad.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("The username or password is incorrect !!!");
            }
        }
    }
}
