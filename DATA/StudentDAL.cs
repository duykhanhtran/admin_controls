using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace admin_controls.DATA
{
    class StudentDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public StudentDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllStudents()
        {
            //tạo câu lệnh sql
            string sql = "SELECT * FROM STUDENTS";
            //tạo chuỗi kết nối
            SqlConnection con = dc.getConnect();
            //khởi tạo sql adapter
            da = new SqlDataAdapter(sql, con);
            // mở kết nối
            con.Open();
            // đổ dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            //đóng
            con.Close();
            return dt;
        }
        public bool InsertStudent(tbl.tblStudent st)
        {
            string sql = "INSERT INTO STUDENTS VALUES(@STUDENT_ID,@USERNAME,@PASSWORD,@FULLNAME,@BIRTHDAY)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@STUDENT_ID", SqlDbType.VarChar).Value = st.STUDENT_ID;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = st.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = st.PASSWORD;
                cmd.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = st.FULLNAME;
                cmd.Parameters.Add("@BIRTHDAY", SqlDbType.SmallDateTime).Value = st.BIRTHDAY;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateStudent(tbl.tblStudent st, string ID)
        {
            string sql = "UPDATE STUDENTS SET STUDENT_ID = @STUDENT_ID, USERNAME = @USERNAME," +
                             "PASSWORD = @PASSWORD, FULLNAME = @FULLNAME,BIRTHDAY = @BIRTHDAY " +
                                            " WHERE STUDENT_ID = '"+ID+ "' COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@STUDENT_ID", SqlDbType.VarChar).Value = st.STUDENT_ID;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = st.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = st.PASSWORD;
                cmd.Parameters.Add("@FULLNAME", SqlDbType.NVarChar).Value = st.FULLNAME;
                cmd.Parameters.Add("@BIRTHDAY", SqlDbType.SmallDateTime).Value = st.BIRTHDAY;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteStudent(tbl.tblStudent st)
        {
            string sql = "DELETE STUDENTS WHERE STUDENT_ID = @STUDENT_ID COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@STUDENT_ID", SqlDbType.VarChar).Value = st.STUDENT_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindStudent(string sb)
        {
            string sql = "SELECT * FROM STUDENTS WHERE STUDENT_ID LIKE '%" + sb + "%'  COLLATE SQL_Latin1_General_CP1_CS_AS " +
                                "OR USERNAME LIKE '%" + sb + "%'  COLLATE SQL_Latin1_General_CP1_CS_AS OR FULLNAME LIKE N'%" + sb + "%' COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Check_Login(tbl.tblStudent st)
        {
            string sql = "SELECT COUNT (*) FROM STUDENTS WHERE " +
                "USERNAME = '" + st.USERNAME + "' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                "AND PASSWORD = '" + st.PASSWORD + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                sql = "SELECT ADMIN_ID FROM ADMINS WHERE USERNAME = '" + st.USERNAME + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                da = new SqlDataAdapter(sql, con);
                DataTable dst = new DataTable();
                da.Fill(dst);
                st.STUDENT_ID = dst.Rows[0][0].ToString();
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
    }
}
