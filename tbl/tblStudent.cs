using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_controls.tbl
{
    class tblStudent
    {
        public string STUDENT_ID { set; get; }
        public string USERNAME { set; get; }
        public string PASSWORD { set; get; }
        public string FULLNAME { set; get; }
        public string BIRTHDAY { set; get; }

        public tblStudent(string id, string un, string pw, string fn, string bd )
        {
            STUDENT_ID = id;
            USERNAME = un;
            PASSWORD = pw;
            FULLNAME = fn;
            BIRTHDAY = bd;
        }
    }
}
