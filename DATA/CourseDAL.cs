using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace admin_controls.DATA
{
    partial class CourseDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public CourseDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllCourses()
        {
            //tạo câu lệnh sql
            string sql = "SELECT * FROM CourseS";
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
        public bool InsertCourse(tbl.tblCourse c)
        {
            string sql = "INSERT INTO COURSES VALUES(@COURSE_ID,@COURSENAME)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@COURSE_ID", SqlDbType.VarChar).Value = c.COURSE_ID;
                cmd.Parameters.Add("@COURSENAME", SqlDbType.NVarChar).Value = c.COURSENAME;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateCourse(tbl.tblCourse c)
        {
            string sql = "UPDATE COURSES SET COURSENAME = @COURSENAME " +
                                         "WHERE COURSE_ID = @COURSE_ID COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@COURSE_ID", SqlDbType.VarChar).Value = c.COURSE_ID;
                cmd.Parameters.Add("@COURSENAME", SqlDbType.NVarChar).Value = c.COURSENAME;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteCourse(tbl.tblCourse c)
        {
            string sql = "DELETE COURSES WHERE COURSE_ID = @COURSE_ID COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@COURSE_ID", SqlDbType.VarChar).Value = c.COURSE_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindCourse(string sb)
        {
            string sql = "SELECT * FROM COURSES WHERE COURSE_ID LIKE '%" + sb + "%'  COLLATE SQL_Latin1_General_CP1_CS_AS " +
                "OR COURSENAME LIKE N'%" + sb + "%' COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
