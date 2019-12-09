using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace admin_controls.BUS
{
    class TeacherBLL
    {
        DATA.TeacherDAL dalTC;
        public TeacherBLL()
        {
            dalTC = new DATA.TeacherDAL();
        }
        public DataTable getAllTeachers()
        {
            return dalTC.getAllTeachers();
        }
        public bool InsertTeacher(tbl.tblTeacher tc)
        {
            return dalTC.InsertTeacher(tc);
        }
        public bool UpdateTeacher(tbl.tblTeacher tc, string ID)
        {
            return dalTC.UpdateTeacher(tc, ID);
        }
        public bool DeleteTeacher(tbl.tblTeacher tc)
        {
            return dalTC.DeleteTeacher(tc);
        }
        public DataTable FindTeacher(string sb)
        {
            return dalTC.FindTeacher(sb);
        }
    }
}
