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
    public partial class ad_uc_at : UserControl
    {
        BUS.TeacherBLL teacher = new BUS.TeacherBLL();
        public ad_uc_at()
        {
            InitializeComponent();
        }
        public bool Check_Fill()
        {
            if (String.IsNullOrEmpty(txtTeacherID.Text))
            {
                MessageBox.Show("Teacher ID is required", "Error");
                return false;
            }  
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is required", "Error");
                return false;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Error");
                return false;
            }
            return true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbl.tblTeacher tc = new tbl.tblTeacher(txtTeacherID.Text, txtUsername.Text, txtPassword.Text);
            if (teacher.DeleteTeacher(tc) == false)
                MessageBox.Show("Can not delete this teacher !!!", "Error");
            else
                MessageBox.Show("Successfully Deleted !!!");
            dgvTeacher.DataSource = teacher.getAllTeachers();
            dgvTeacher.Show();
            Binding();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = dgvTeacher.CurrentRow.Index;
            string ID = dgvTeacher.Rows[index].Cells["TEACHER_ID"].Value.ToString();
            tbl.tblTeacher tc = new tbl.tblTeacher(txtTeacherID.Text, txtUsername.Text, txtPassword.Text);
            if (teacher.UpdateTeacher(tc, ID) == false)
                MessageBox.Show("Can not update this teacher !!!", "Error");
            else
                MessageBox.Show("Successfully Updated !!!");
            dgvTeacher.DataSource = teacher.getAllTeachers();
            dgvTeacher.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (Check_Fill())
            {
                tbl.tblTeacher tc = new tbl.tblTeacher(txtTeacherID.Text, txtUsername.Text, txtPassword.Text);
                if (teacher.InsertTeacher(tc) == false)
                    MessageBox.Show("Can not insert this teacher", "Error");
                else
                {
                    MessageBox.Show("Inserted Successfully");
                    dgvTeacher.DataSource = teacher.getAllTeachers();
                    dgvTeacher.Show();
                    Binding();
                }
            }
        }
        void Binding()
        {
            int i = dgvTeacher.CurrentRow.Index;
            if(i>=0)
            {
                txtTeacherID.Text = dgvTeacher.Rows[i].Cells[0].Value.ToString();
                txtUsername.Text = dgvTeacher.Rows[i].Cells[1].Value.ToString();
                txtPassword.Text = dgvTeacher.Rows[i].Cells[2].Value.ToString();
            }
        }
        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvTeacher.DataSource = teacher.FindTeacher(txtSearch.Text);
                dgvTeacher.Show();
            }
            else
            {
                dgvTeacher.DataSource = teacher.getAllTeachers();
                dgvTeacher.Show();
            }

        }
    }
}
