using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace admin_controls
{
    
    public partial class login : Form
    {
        #region Thu nhỏ form
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
        public login()
        {
            InitializeComponent();
        }
        private void adminlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRE.admin_login f = new PRE.admin_login();
            f.ShowDialog();
            this.Close();
        }
        private void ad_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lg_show_OnChange(object sender, EventArgs e)
        {
            if (lg_show.Checked == true)
                pass.UseSystemPasswordChar = false;
            else
                pass.UseSystemPasswordChar = true;
        }

        private void signup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signup f = new signup();
            f.ShowDialog();
            this.Show();
        }
    }
}
