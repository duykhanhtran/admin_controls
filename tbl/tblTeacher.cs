using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_controls.tbl
{
    class tblTeacher
    {
        public string TEACHER_ID { set; get; }
        public string USERNAME { set; get; }
        public string PASSWORD { set; get; }

        public tblTeacher(string id, string un, string pw)
        {
            TEACHER_ID = id;
            USERNAME = un;
            PASSWORD = pw;
        }
    }
}
