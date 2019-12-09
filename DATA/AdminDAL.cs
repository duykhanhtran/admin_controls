using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace admin_controls.DATA
{
    class AdminDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public AdminDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllAdmins()
        {
            //tạo câu lệnh sql
            string sql = "SELECT * FROM ADMINS";
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
        public bool UpdateAdmin(tbl.tblAdmin ad)
        {
            string sql = "UPDATE ADMINS SET USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE ADMIN_ID = @ADMIN_ID COLLATE SQL_Latin1_General_CP1_CS_AS ";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ADMIN_ID", SqlDbType.VarChar).Value = ad.ADMIN_ID;
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = ad.USERNAME;
                cmd.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = ad.PASSWORD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool Check_Login(ref tbl.tblAdmin ad)
        {
            string sql = "SELECT COUNT (*) FROM ADMINS WHERE " +
                "USERNAME = '"+ad.USERNAME+ "' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                "AND PASSWORD = '" + ad.PASSWORD+ "' COLLATE SQL_Latin1_General_CP1_CS_AS";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                sql = "SELECT ADMIN_ID FROM ADMINS WHERE USERNAME = '" + ad.USERNAME + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                da = new SqlDataAdapter(sql, con);
                DataTable dad = new DataTable();
                da.Fill(dad);
                ad.ADMIN_ID = dad.Rows[0][0].ToString();
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
    }
}
