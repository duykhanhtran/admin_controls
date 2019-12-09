using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace admin_controls.BUS
{
    class StudentBLL
    {
        DATA.StudentDAL dalST;
        public StudentBLL()
        {
            dalST = new DATA.StudentDAL();
        }
        public DataTable getAllStudents()
        {
            return dalST.getAllStudents();
        }
        public bool InsertStudent(tbl.tblStudent st)
        {
            return dalST.InsertStudent(st);
        }
        public bool UpdateStudent(tbl.tblStudent st, string ID)
        {
            return dalST.UpdateStudent(st,ID);
        }
        public bool DeleteStudent(tbl.tblStudent st)
        {
            return dalST.DeleteStudent(st);
        }
        public DataTable FindStudent (string sb)
        {
            return dalST.FindStudent(sb);
        }
    }
}
