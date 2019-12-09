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
    public partial class ad_uc_us : UserControl
    {
        BUS.StudentBLL student = new BUS.StudentBLL();
        public ad_uc_us()
        {
            InitializeComponent();
        }
        void Binding ()
        {
            int i = ad_dgv_st.CurrentRow.Index;
            if(i>=0)
            {
                txtStudentID.Text = ad_dgv_st.Rows[i].Cells[0].Value.ToString();
                txtStudentUsername.Text = ad_dgv_st.Rows[i].Cells[1].Value.ToString();
                txtStudentPassword.Text = ad_dgv_st.Rows[i].Cells[2].Value.ToString();
                txtStudentFullname.Text = ad_dgv_st.Rows[i].Cells[3].Value.ToString();
                dtpStudentBirthday.Text = ad_dgv_st.Rows[i].Cells[4].Value.ToString();
            }
            
        }
        private void ad_dgv_st_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void ad_bsd_Click(object sender, EventArgs e)
        {
            tbl.tblStudent st = new tbl.tblStudent(txtStudentID.Text, txtStudentUsername.Text, txtStudentPassword.Text, txtStudentFullname.Text, dtpStudentBirthday.Text);
            if(student.DeleteStudent(st) == false)
                MessageBox.Show("Can not delete this student !!!", "Error");
            else
                MessageBox.Show("Successfully Deleted !!!");
            ad_dgv_st.DataSource = student.getAllStudents();
            ad_dgv_st.Show();
            Binding();
        }

        private void ad_bstup_Click(object sender, EventArgs e)
        {
            int index = ad_dgv_st.CurrentRow.Index;
            string ID = ad_dgv_st.Rows[index].Cells["STUDENT_ID"].Value.ToString();
            tbl.tblStudent st = new tbl.tblStudent(txtStudentID.Text, txtStudentUsername.Text, txtStudentPassword.Text, txtStudentFullname.Text, dtpStudentBirthday.Text);
            if (student.UpdateStudent(st,ID) == false)
                MessageBox.Show("Can not update this student !!!", "Error");
            else
                MessageBox.Show("Successfully Updated !!!");
            ad_dgv_st.DataSource = student.getAllStudents();
            ad_dgv_st.Show();
        }
        bool Check_Fill()
        {
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Student ID is required!!!", "Error");
                return false;
            }
            if (string.IsNullOrEmpty(txtStudentUsername.Text))
            {
                MessageBox.Show("Username is required!!!", "Error");
                return false;
            }
            if (string.IsNullOrEmpty(txtStudentPassword.Text))
            {
                MessageBox.Show("Password is required!!!", "Error");
                return false;
            }
            if (string.IsNullOrEmpty(txtStudentFullname.Text))
            {
                MessageBox.Show("Fullname is required!!!", "Error");
                return false;
            }
            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(Check_Fill())
            {
                tbl.tblStudent st = new tbl.tblStudent(txtStudentID.Text, txtStudentUsername.Text, txtStudentPassword.Text, txtStudentFullname.Text, dtpStudentBirthday.Text);
                if (student.InsertStudent(st) == false)
                    MessageBox.Show("Can not create this student account !!!", "Error");
                else
                    MessageBox.Show("Successfully !!!");
                ad_dgv_st.DataSource = student.getAllStudents();
                ad_dgv_st.Show();
                Binding();
            } 
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))                
            {
                ad_dgv_st.DataSource = student.FindStudent(txtSearch.Text);
                ad_dgv_st.Show();
            }
            else
            {
                ad_dgv_st.DataSource = student.getAllStudents();
                ad_dgv_st.Show();
            }
        }
    }
}
