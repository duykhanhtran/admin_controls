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

namespace admin_controls.PRE
{
    public partial class Admin_Control : Form
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
        #endregion
        #region Drag Form
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        private void title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void title_bar_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void title_bar_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        #endregion
        public static tbl.tblAdmin Admin;
        public Admin_Control(tbl.tblAdmin ad)
        {
            InitializeComponent();
            Admin = ad;
            txtAdUsername.Text = ad.USERNAME;
            txtAdUsername.Show();
        }

        private void ad_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ad_bdb_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bdb.Location;
            uc_db.Show();
            uc_us.Hide();
            uc_at.Hide();
            uc_cs.Hide();
            uc_ep.Hide(); 
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (ad_p1.Width == 65)
            {
                ad_p1.Width = 252;
                txtAdUsername.Location = new Point(608, 5);
                ad_exit.Location = new Point(813, 5);
                title_bar.Location = new Point(252, 0);
                //at
                uc_at.Location = new Point(252, 38);
                uc_at.pnlControl.Location = new Point(562, 37);
                //us
                uc_us.Location = new Point(252, 38);
                uc_us.pnlControl.Location = new Point(562, 37);
                //db
                uc_db.Location = new Point(252, 38);
                uc_db.pdb1.Location = new Point(5, 60);
                //ep
                uc_ep.Location = new Point(252, 38);
                uc_ep.pep2.Location = new Point(315, 40);
                uc_ep.pep3.Location = new Point(315, 330);
                uc_ep.btnChangeUsername.Location = new Point(685, 507);
                uc_ep.btnChangePassword.Location = new Point(685, 214);
                //cs
                uc_cs.Location = new Point(252, 38);
                uc_cs.pnlControl.Location = new Point(562, 37);
                //al
                uc_al.Location = new Point(252, 38);
                uc_al.pnlControl.Location = new Point(562, 37);
            }
            else
            {
                ad_p1.Width = 65;
                title_bar.Location = new Point(65, 0);
                txtAdUsername.Location = new Point(795, 5);
                ad_exit.Location = new Point(1000, 5);
                //at
                uc_at.Location = new Point(65, 38);
                uc_at.pnlControl.Location = new Point(650, 37);
                //us
                uc_us.Location = new Point(65, 38);
                uc_us.pnlControl.Location = new Point(650, 37);
                //db
                uc_db.Location = new Point(65, 38);
                uc_db.pdb1.Location = new Point(110, 60);
                //ep
                uc_ep.Location = new Point(65, 38);
                uc_ep.pep2.Location = new Point(400, 40);
                uc_ep.pep3.Location = new Point(400, 330);
                uc_ep.btnChangeUsername.Location = new Point(820, 507);
                uc_ep.btnChangePassword.Location = new Point(820, 214);
                //cs
                uc_cs.Location = new Point(65, 38);
                uc_cs.pnlControl.Location = new Point(650, 37);
                //al
                uc_al.Location = new Point(65, 38);
                uc_al.pnlControl.Location = new Point(650, 37);
            }
        }

        private void ad_bgv_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bgv.Location;
            BUS.TeacherBLL tc = new BUS.TeacherBLL();
            uc_at.dgvTeacher.DataSource = tc.getAllTeachers();
            uc_db.Hide();
            uc_us.Hide();
            uc_at.Show();
            uc_cs.Hide();
            uc_ep.Hide();
            uc_al.Hide();
        }
        private void ad_ba_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_ba.Location;
            BUS.AllocationBLL t = new BUS.AllocationBLL();
            uc_al.dgvAllocation.DataSource = t.getAllAllocations();
            uc_db.Hide();
            uc_us.Hide();
            uc_at.Hide();
            uc_cs.Hide();
            uc_ep.Hide();
            uc_al.Show();
        }
        private void ad_btm_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_btm.Location;
            BUS.CourseBLL c = new BUS.CourseBLL();
            uc_cs.ad_dgv_c.DataSource = c.getAllCourses();
            uc_db.Hide();
            uc_us.Hide();
            uc_at.Hide();
            uc_cs.Show();
            uc_ep.Hide();
            uc_al.Hide();
        }

        private void ad_bql_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bql.Location;
            BUS.StudentBLL st = new BUS.StudentBLL();
            uc_us.ad_dgv_st.DataSource = st.getAllStudents();
            uc_db.Hide();
            uc_us.Show();
            uc_at.Hide();
            uc_cs.Hide();
            uc_ep.Hide();
            uc_al.Hide();
        }

        private void ad_bep_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bep.Location;
            uc_db.Hide();
            uc_us.Hide();
            uc_at.Hide();
            uc_cs.Hide();
            uc_ep.Show();
            uc_al.Hide();
        } 
        private void ad_blo_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f = new login();
            f.ShowDialog();
            this.Close();
        }

    }
}
