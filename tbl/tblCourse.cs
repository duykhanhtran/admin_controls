using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_controls.tbl
{
    class tblCourse
    {
        public string COURSE_ID { set; get; }
        public string COURSENAME { set; get; }
        public tblCourse(string id, string cn)
        {
            COURSE_ID = id;
            COURSENAME = cn;
        }
    }
}
