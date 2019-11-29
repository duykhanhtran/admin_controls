using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace admin_controls
{
    public partial class admin : Form
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
        public admin(string name)
        {
            InitializeComponent();
            ad_user.Text = name;
            ad_user.Show();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=ICY;Initial Catalog=QLTTN;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tc_dataTable = new DataTable();
        DataTable st_dataTable = new DataTable();
        DataTable c_dataTable = new DataTable();
        private void loading_teacher_data()
        {
            connection.Open();
            command = connection.CreateCommand(); //bat dau truy van
            command.CommandText = "SELECT * FROM TEACHERS";
            adapter.SelectCommand = command; //chuyen du lieu ve
            tc_dataTable.Clear(); //tạo một kho ảo để lưu trữ dữ liệu
            adapter.Fill(tc_dataTable);  // đổ dữ liệu vào kho
            connection.Close();
            ad_dgv_tc.DataSource = tc_dataTable; //đổ dữ liệu vào datagridview
        }
        private void loading_student_data()
        {
            connection.Open();
            command = connection.CreateCommand(); //bat dau truy van
            command.CommandText = "SELECT * FROM STUDENTS";
            adapter.SelectCommand = command; //chuyen du lieu ve
            st_dataTable.Clear(); //tạo một kho ảo để lưu trữ dữ liệu
            adapter.Fill(st_dataTable);  // đổ dữ liệu vào kho
            connection.Close();
            ad_dgv_st.DataSource = st_dataTable; //đổ dữ liệu vào datagridview
        }
        private void loading_course_data()
        {
            connection.Open();
            command = connection.CreateCommand(); //bat dau truy van
            command.CommandText = "SELECT * FROM COURSES";
            adapter.SelectCommand = command; //chuyen du lieu ve
            c_dataTable.Clear(); //tạo một kho ảo để lưu trữ dữ liệu
            adapter.Fill(c_dataTable);  // đổ dữ liệu vào kho
            connection.Close();
            ad_dgv_c.DataSource = c_dataTable; //đổ dữ liệu vào datagridview
        }
        private void blo_Click(object sender, EventArgs e)
        {
            this.Hide();
            login f = new login();
            f.ShowDialog();
            this.Close();
        }

        private void ad_bgv_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bgv.Location;
            ad_pat.Show();
            ad_pus.Hide();
            ad_pcs.Hide();
            ad_pdb.Hide();
            ad_pep.Hide();
        }

        private void ad_btm_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_btm.Location;
            loading_course_data();
            ad_pcs.Show();
            ad_pus.Hide();
            ad_pat.Hide();
            ad_pdb.Hide();
            ad_pep.Hide();
        }
        private void ad_bql_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bql.Location;
            loading_teacher_data();
            loading_student_data();
            ad_pus.Show();
            ad_pat.Hide();
            ad_pcs.Hide();
            ad_pdb.Hide();
            ad_pep.Hide();
        }

        private void ad_bdb_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bdb.Location;
            ad_pdb.Show();
            ad_pus.Hide();
            ad_pat.Hide();
            ad_pcs.Hide();
            ad_pep.Hide();
        }
        private void ad_bep_Click(object sender, EventArgs e)
        {
            ad_clicked.Location = ad_bep.Location;
            ad_pep.Show();
            ad_pdb.Hide();
            ad_pus.Hide();
            ad_pat.Hide();
            ad_pcs.Hide();
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
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (ad_p1.Width == 65)
            {
                ad_p1.Width = 252;
                title_bar.Location = new Point(252, 0);
                ad_user.Location = new Point(608, 5);
                ad_exit.Location = new Point(813, 5);
                ad_pat.Location = new Point(252, 38);
                pat1.Location = new Point(35, 90);
                ad_pus.Location = new Point(252, 38);
                pus1.Location = new Point(557, 45);
                pus2.Location = new Point(557, 310);
                ad_pdb.Location = new Point(252, 38);
                pdb1.Location = new Point(5, 60);
                ad_pep.Location = new Point(252, 38);
                pep2.Location = new Point(315,40);
                pep3.Location = new Point(315, 330);
                pepb2.Location = new Point(685, 507);
                pepb1.Location = new Point(685, 214);
                ad_pcs.Location = new Point(252, 38);
                pcs2.Location = new Point(4,39);
                pcs1.Location = new Point(497, 320);
            }
            else
            {
                ad_p1.Width = 65;
                title_bar.Location = new Point(65, 0);
                ad_user.Location = new Point(795, 5);
                ad_exit.Location = new Point(1000, 5);
                ad_pat.Location = new Point(65, 38);
                pat1.Location = new Point(170, 95);
                ad_pus.Location = new Point(65, 38);
                pus1.Location = new Point(650, 45);
                pus2.Location = new Point(650, 310);
                ad_pdb.Location = new Point(65, 38);
                pdb1.Location = new Point(110, 60);
                ad_pep.Location = new Point(65, 38);
                pep2.Location = new Point(400, 40);
                pep3.Location = new Point(400, 330);
                pepb2.Location = new Point(820, 507);
                pepb1.Location = new Point(820, 214);
                ad_pcs.Location = new Point(65, 38);
                pcs2.Location = new Point(118, 40);
                pcs1.Location = new Point(611, 320);
            }
        }
        private void ad_dgv_tc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ad_dgv_tc.CurrentRow.Index;
            ad_ttid.Text = ad_dgv_tc.Rows[i].Cells[0].Value.ToString();
            ad_ttun.Text = ad_dgv_tc.Rows[i].Cells[1].Value.ToString();
            ad_ttpw.Text = ad_dgv_tc.Rows[i].Cells[2].Value.ToString();
            ad_ttcid.Text = ad_dgv_tc.Rows[i].Cells[3].Value.ToString();
        }

        private void ad_btcup_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < ad_dgv_tc.Rows.Count - 1; i++)
                if (ad_dgv_tc.Rows[i].Cells[1].Value.ToString() == ad_ttun.Text&&
                    ad_dgv_tc.Rows[i].Cells[0].Value.ToString() != ad_ttid.Text)
                {
                    check = false;
                    break;
                }
            if (check == false)
            {
                MessageBox.Show("Username Has Already Existed", "Error");
            }
            else
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE TEACHERS SET " +
                    //   "TEACHER_ID = '"+ad_ttid.Text+"'," +
                    "TC_USERNAME = '" + ad_ttun.Text + "'," +
                    "TC_PASSWORD = '" + ad_ttpw.Text + "'," +
                    "COURSE_ID = '" + ad_ttcid.Text + "'" +
                    "WHERE TEACHER_ID = '" + ad_ttid.Text + "' ";
                command.ExecuteNonQuery();
                connection.Close();
                loading_teacher_data();
            }
        }

        private void ad_dgv_st_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ad_dgv_st.CurrentRow.Index;
            ad_tsid.Text = ad_dgv_st.Rows[i].Cells[0].Value.ToString();
            ad_tsun.Text = ad_dgv_st.Rows[i].Cells[1].Value.ToString();
            ad_tspw.Text = ad_dgv_st.Rows[i].Cells[2].Value.ToString();
            ad_tsfn.Text = ad_dgv_st.Rows[i].Cells[3].Value.ToString();
            ad_dsns.Text = ad_dgv_st.Rows[i].Cells[4].Value.ToString();
        }

        private void ad_bstup_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < ad_dgv_st.Rows.Count - 1; i++)
                if (ad_dgv_st.Rows[i].Cells[1].Value.ToString() == ad_tsun.Text &&
                    ad_dgv_st.Rows[i].Cells[0].Value.ToString() != ad_tsid.Text)
                {
                    check = false;
                    break;
                }
            if (check == false)
            {
                MessageBox.Show("Username Has Already Existed", "Error");
            }
            else
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE STUDENTS SET " +
                    //"STUDENT_ID = '" + ad_tsid.Text + "'," +
                    "ST_USERNAME = '" + ad_tsun.Text + "'," +
                    "ST_PASSWORD = '" + ad_tspw.Text + "'," +
                    "FULLNAME = '" + ad_tsfn.Text + "'," +
                    "NGAYSINH = '" + ad_dsns.Text + "'" +
                    "WHERE STUDENT_ID = '" + ad_tsid.Text + "' ";
                command.ExecuteNonQuery();
                connection.Close();
                loading_student_data();
            }
        }

        private void ad_at_bcr_Click(object sender, EventArgs e)
        {
            if (ad_at_tcp.Text != ad_at_tpw.Text)
                MessageBox.Show("Your password and confirmation password do not match", "Error");
            else
            {
                loading_teacher_data();
                bool cs_check = true;
                for (int i = 0; i <ad_dgv_tc.Rows.Count-1; i++)
                    if (ad_dgv_tc.Rows[i].Cells[0].Value.ToString()== ad_at_tid.Text ||
                        ad_dgv_tc.Rows[i].Cells[1].Value.ToString()== ad_at_tun.Text)
                    {
                        cs_check = false;
                        break;
                    }
                if(cs_check == false)
                {
                    MessageBox.Show("Teacher Has Already Existed", "Error");
                }
                else
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO TEACHERS VALUES (" +
                        "'" + ad_at_tid.Text + "'," +
                        "'" + ad_at_tun.Text + "'," +
                        "'" + ad_at_tpw.Text + "'," +
                        "'" + ad_at_tcid.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Add Teacher Succesfully", "");
                }
            }
        }

        private void ad_btd_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM TEACHERS " +
                "WHERE TEACHER_ID = '" + ad_ttid.Text + "'";
            command.ExecuteNonQuery();
            connection.Close();
            loading_teacher_data();
        }

        private void ad_dgv_c_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = ad_dgv_c.CurrentRow.Index;
            ad_tcid.Text = ad_dgv_c.Rows[i].Cells[0].Value.ToString();
            ad_tccn.Text = ad_dgv_c.Rows[i].Cells[1].Value.ToString();
            ad_tcpw.Text = ad_dgv_c.Rows[i].Cells[2].Value.ToString();
        }

        private void ad_bcup_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "UPDATE COURSES SET " +
                "COURSE_NAME = '" + ad_tccn.Text + "'," +
                "C_PASSWORD = '" + ad_tcpw.Text + "'" +
                "WHERE C_COURSE_ID = '" + ad_tcid.Text + "' ";
            command.ExecuteNonQuery();
            connection.Close();
            loading_course_data();
        }

        private void ad_bcdl_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM COURSES " +
                "WHERE C_COURSE_ID = '" + ad_tcid.Text + "'";
            command.ExecuteNonQuery();
            connection.Close();
            loading_course_data();
        }

        private void ad_cc_Click(object sender, EventArgs e)
        {   
             if (ad_cp.Text != ad_ccp.Text)
                 MessageBox.Show("Your password and confirmation password do not match", "Error");
             else
             {
                bool cs_check = true;
                for (int i = 0; i <ad_dgv_c.Rows.Count-1; i++)
                    if (ad_dgv_c.Rows[i].Cells[0].Value.ToString()==ad_cid.Text )
                      //  || ad_dgv_c.Rows[i].Cells[1].Value.ToString()==ad_cn.Text)
                    {
                        cs_check = false;
                        break;
                    }
                if(cs_check == false)
                {
                    MessageBox.Show("Course Has Already Existed", "Error");
                }
                else
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO COURSES VALUES (" +
                     "'" + ad_cid.Text + "'," +
                     "'" + ad_cn.Text + "'," +
                     "'" + ad_cp.Text + "')";
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Create Course Succesfully", "");
                    loading_course_data();
                }
                 
             }
        }

        private void ad_bsd_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM STUDENTS " +
                "WHERE STUDENT_ID = '" + ad_tsid.Text + "'";
            command.ExecuteNonQuery();
            connection.Close();
            loading_student_data();
        }
    }
}
