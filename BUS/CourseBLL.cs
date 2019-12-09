using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace admin_controls.BUS
{
    class CourseBLL 
    {
        DATA.CourseDAL dalC;
        public CourseBLL()
        {
            dalC = new DATA.CourseDAL();
        }
        public DataTable getAllCourses()
        {
            return dalC.getAllCourses();
        }
        public bool InsertCourse(tbl.tblCourse c)
        {
            return dalC.InsertCourse(c);
        }
        public bool UpdateCourse(tbl.tblCourse c)
        {
            return dalC.UpdateCourse(c);
        }
        public bool DeleteCourse(tbl.tblCourse c)
        {
            return dalC.DeleteCourse(c);
        }
        public DataTable FindCourse(string sb)
        {
            return dalC.FindCourse(sb);
        }
    }
}
