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
    public partial class ad_uc_cs : UserControl
    {
        BUS.CourseBLL course = new BUS.CourseBLL();
        public ad_uc_cs()
        {
            InitializeComponent();
        }
        void Binding()
        {
            int i = ad_dgv_c.CurrentRow.Index;
            if(i>=0)
            {
                txtCourseID.Text = ad_dgv_c.Rows[i].Cells[0].Value.ToString();
                txtCoursename.Text = ad_dgv_c.Rows[i].Cells[1].Value.ToString();
            }
        }

        private void ad_dgv_c_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void ad_bcup_Click(object sender, EventArgs e)
        {
            tbl.tblCourse c = new tbl.tblCourse(txtCourseID.Text, txtCoursename.Text);
            if (course.UpdateCourse(c) == false)
                MessageBox.Show("Can not update this course !!!", "Error");
            else
                MessageBox.Show("Successfully Updated!!!");
            ad_dgv_c.DataSource = course.getAllCourses();
            ad_dgv_c.Show();
        }

        private void ad_bcdl_Click(object sender, EventArgs e)
        {
            tbl.tblCourse c = new tbl.tblCourse(txtCourseID.Text, txtCoursename.Text);
            if (course.DeleteCourse(c) == false)
                MessageBox.Show("Can not delete this course !!!", "Error");
            else
                MessageBox.Show("Successfully Deleted!!!");
            ad_dgv_c.DataSource = course.getAllCourses();
            ad_dgv_c.Show();
            Binding();
        }
        public bool Check_Fill()
        {
            if(String.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("Course ID is required", "Error");
                return false;
            }
            if (String.IsNullOrEmpty(txtCoursename.Text))
            {
                MessageBox.Show("Coursename is required", "Error");
                return false;
            }
            return true;
        }
        private void ad_cc_Click(object sender, EventArgs e)
        {
            if(Check_Fill())
            {
                tbl.tblCourse c = new tbl.tblCourse(txtCourseID.Text, txtCoursename.Text);
                if (course.InsertCourse(c) == false)
                    MessageBox.Show("Can not insert this course !!!", "Error");
                else
                    MessageBox.Show("Successfully Inserted!!!");
                ad_dgv_c.DataSource = course.getAllCourses();
                ad_dgv_c.Show();
                Binding();
            }
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                ad_dgv_c.DataSource = course.FindCourse(txtSearch.Text);
                ad_dgv_c.Show();
            }
            else
            {
                ad_dgv_c.DataSource = course.getAllCourses();
                ad_dgv_c.Show();
            }
        }
    }
}
