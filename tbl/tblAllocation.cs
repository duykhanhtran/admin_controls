using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin_controls.tbl
{
    class tblAllocation
    {
        public string COURSE_ID { set; get; }
        public string TEACHER_ID { set; get; }
        public tblAllocation(string cid, string tid)
        {
            COURSE_ID = cid;
            TEACHER_ID = tid;
        }
    }
}
