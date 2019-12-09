using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace admin_controls.DATA
{
    partial class AllocationDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public AllocationDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllAllocations()
        {
            //tạo câu lệnh sql
            string sql = "SELECT T.COURSE_ID,TEACHER_ID,COURSENAME FROM TEACHING T JOIN COURSES C ON T.COURSE_ID = C.COURSE_ID";
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
        public bool InsertAllocation(tbl.tblAllocation c)
        {
            string sql = "INSERT INTO TEACHING VALUES(@TEACHER_ID,@COURSE_ID)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEACHER_ID", SqlDbType.VarChar).Value = c.TEACHER_ID;
                cmd.Parameters.Add("@COURSE_ID", SqlDbType.NVarChar).Value = c.COURSE_ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateAllocation(tbl.tblAllocation c, string cid, string tid)
        {
            string sql = "UPDATE TEACHING SET TEACHER_ID = @TEACHER_ID, COURSE_ID = @COURSE_ID " +
                                         "WHERE COURSE_ID = '"+cid+ "'  COLLATE SQL_Latin1_General_CP1_CS_AS " +
                                         "AND TEACHER_ID ='"+tid+ "' COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEACHER_ID", SqlDbType.VarChar).Value = c.TEACHER_ID;
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

        public bool DeleteAllocation(tbl.tblAllocation c)
        {
            string sql = "DELETE TEACHING WHERE TEACHER_ID = @TEACHER_ID  COLLATE SQL_Latin1_General_CP1_CS_AS AND COURSE_ID = @COURSE_ID COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TEACHER_ID", SqlDbType.VarChar).Value = c.TEACHER_ID;
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
        public DataTable FindAllocation(string sb)
        {
            string sql = "SELECT T.COURSE_ID,TEACHER_ID,COURSENAME FROM TEACHING T JOIN COURSES C ON T.COURSE_ID = C.COURSE_ID" +
                " WHERE T.COURSE_ID LIKE '%" + sb + "%' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                " OR COURSENAME LIKE N'%" + sb + "%' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                " OR TEACHER_ID LIKE '%" + sb + "%'  COLLATE SQL_Latin1_General_CP1_CS_AS ";
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
