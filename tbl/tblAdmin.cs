using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_controls.tbl
{
    public class tblAdmin
    {
        public string ADMIN_ID { set; get; }
        public string USERNAME { set; get; }
        public string PASSWORD { set; get; }
        public tblAdmin(string id, string un, string pw)
        {
            ADMIN_ID = id;
            USERNAME = un;
            PASSWORD = pw;
        }
    }
}
