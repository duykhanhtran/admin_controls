using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace admin_controls.DATA
{
    class TeacherDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public TeacherDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllTeachers()
        {
            //tạo câu lệnh sql
            string sql = "SELECT * FROM TEACHERS";
            //tạo chuỗi kết nối
            SqlConnection con = dc.getConnect();
            //khởi tạo sql adapter
            da = new SqlDataAdapter(sql,con);
            // mở kết nối
            con.Open();
            // đổ dữ liệu
            DataTable dt = new DataTable();
            da.Fill(dt);
            //đóng
            con.Close();
            return dt;
        }
        public bool InsertTeacher(tbl.tblTeacher tc)
        {
            string sql = "INSERT INTO TEACHERS VALUES(@TEACHER_ID,@USERNAME,@PASSWORD)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEACHER_ID", SqlDbType.VarChar).Value = tc.TEACHER_ID;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = tc.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = tc.PASSWORD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateTeacher(tbl.tblTeacher tc,string ID)
        {
            string sql = "UPDATE TEACHERS SET TEACHER_ID = @TEACHER_ID,USERNAME = @USERNAME,PASSWORD = @PASSWORD " +
                " WHERE TEACHER_ID = '"+ID+ "' COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEACHER_ID", SqlDbType.VarChar).Value = tc.TEACHER_ID;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = tc.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = tc.PASSWORD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteTeacher(tbl.tblTeacher tc)
        {
            string sql = "DELETE TEACHERS WHERE TEACHER_ID = @TEACHER_ID COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEACHER_ID", SqlDbType.VarChar).Value = tc.TEACHER_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindTeacher (string sb)
        {
            string sql = "SELECT * FROM TEACHERS WHERE TEACHER_ID LIKE '%"+sb+ "%' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                " OR USERNAME LIKE '%" + sb + "%' COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql,con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
