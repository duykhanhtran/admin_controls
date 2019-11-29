using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace admin_controls
{
    public partial class signup : Form
    {        
        #region Thu nhỏ và di chuyển form
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        #endregion
        public signup()
        {
            InitializeComponent();
            //set_click();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        void re_fill ()
        {
            if (fullname.Text == "") 
                fullname.Text = "Full Name";
            if (id.Text == "")
                id.Text = "Student ID";
            if (pass.Text == "")
                pass.Text = "Password";
            if (confirm.Text == "")
                confirm.Text = "Confirm Password";
            if (user.Text == "")
                user.Text = "User Name";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool kt = check_fill();
            if (kt == false)
                MessageBox.Show("The form havent been filled yet");
            else
            {
                if(pass.Text != confirm.Text)
                    MessageBox.Show("Your password and confirmation password do not match", "Error");
                else
                {

                }
            }
            this.Close();
        }
        protected bool check_fill()
        {
            if (confirm.Text == "" || pass.Text == "" || user.Text == ""|| id.Text ==""||fullname.Text=="")
                return false;
            if (confirm.Text == "Confirm Password" || pass.Text == "Password" || user.Text == "User Name" || id.Text == "Student ID" || fullname.Text == "Full Name")
                return false;
            return true;
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
            this.Close();
        }

        private void id_Click(object sender, EventArgs e)
        {
            re_fill();
            if (id.Text == "Student ID")
            {
                id.Text = "";
                return;
            }
        }

        private void fullname_Click(object sender, EventArgs e)
        {
            re_fill();
            if (fullname.Text == "Full Name")
            {
                fullname.Text = "";
                return;
            }
        }

        private void user_Click(object sender, EventArgs e)
        {
            re_fill();
            if (user.Text == "User Name")
            {
                user.Text = "";
                return;
            }
        }

        private void pass_Click(object sender, EventArgs e)
        {
            re_fill();
            if (pass.Text == "Password")
            {
                pass.Text = "";
                return;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            re_fill();
            if (confirm.Text == "Confirm Password")
            {
                confirm.Text = "";
                return;
            }
        }
    }
}
