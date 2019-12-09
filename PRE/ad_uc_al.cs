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
    public partial class ad_uc_al : UserControl
    {
        BUS.AllocationBLL allocation = new BUS.AllocationBLL();
        public ad_uc_al()
        {
            InitializeComponent();
        }
        void Binding()
        {
            int i = dgvAllocation.CurrentRow.Index;
            if(i>=0)
            {
                txtTeacherID.Text = dgvAllocation.Rows[i].Cells["TEACHER_ID"].Value.ToString();
                txtCourseID.Text = dgvAllocation.Rows[i].Cells["COURSE_ID"].Value.ToString();
                txtCoursename.Text = dgvAllocation.Rows[i].Cells["COURSENAME"].Value.ToString();
            }
        }
        private void ad_dgv_tr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Binding();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbl.tblAllocation al = new tbl.tblAllocation(txtCourseID.Text, txtTeacherID.Text);
            if (allocation.DeleteAllocation(al) == false)
                MessageBox.Show("Can not delete this allocation !!!", "Error");
            else
                MessageBox.Show("Successfully Deleted !!!");
            dgvAllocation.DataSource = allocation.getAllAllocations();
            dgvAllocation.Show();
            Binding();
        }
        bool Check_Fill()
        {
            if(string.IsNullOrEmpty(txtTeacherID.Text))
            {
                MessageBox.Show("Teacher ID is required!!!", "Error");
                return false;
            }
            if (string.IsNullOrEmpty(txtCourseID.Text))
            {
                MessageBox.Show("Course ID is required!!!", "Error");
                return false;
            }
            return true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(Check_Fill())
            {
                tbl.tblAllocation al = new tbl.tblAllocation(txtCourseID.Text, txtTeacherID.Text);
                if (allocation.InsertAllocation(al) == false)
                    MessageBox.Show("Can not insert this allocation !!!", "Error");
                else
                    MessageBox.Show("Successfully !!!");
                dgvAllocation.DataSource = allocation.getAllAllocations();
                dgvAllocation.Show();
                Binding();
            } 
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int index = dgvAllocation.CurrentRow.Index;
            string tid = dgvAllocation.Rows[index].Cells["TEACHER_ID"].Value.ToString();
            string cid = dgvAllocation.Rows[index].Cells["COURSE_ID"].Value.ToString();
            tbl.tblAllocation al = new tbl.tblAllocation(txtCourseID.Text, txtTeacherID.Text);
            if (allocation.UpdateAllocation(al,cid,tid) == false)
                MessageBox.Show("Can not update this allocation !!!", "Error");
            else
                MessageBox.Show("Successfully !!!");
            dgvAllocation.DataSource = allocation.getAllAllocations();
            dgvAllocation.Show();
        }

        private void txtSearch_OnTextChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                dgvAllocation.DataSource = allocation.FindAllocation(txtSearch.Text);
                dgvAllocation.Show();
            }
            else
            {
                dgvAllocation.DataSource = allocation.getAllAllocations();
                dgvAllocation.Show();
            }
        }
    }
}
