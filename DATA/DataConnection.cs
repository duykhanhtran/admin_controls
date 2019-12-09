using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace admin_controls.DATA
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source = ICY; Initial Catalog = dtbMTM; Integrated Security = True";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
