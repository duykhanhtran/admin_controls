using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace admin_controls.BUS
{
    class AllocationBLL
    {
        DATA.AllocationDAL dalC;
        public AllocationBLL()
        {
            dalC = new DATA.AllocationDAL();
        }
        public DataTable getAllAllocations()
        {
            return dalC.getAllAllocations();
        }
        public bool InsertAllocation(tbl.tblAllocation c)
        {
            return dalC.InsertAllocation(c);
        }
        public bool UpdateAllocation(tbl.tblAllocation c, string cid, string tid)
        {
            return dalC.UpdateAllocation(c,cid,tid);
        }
        public bool DeleteAllocation(tbl.tblAllocation c)
        {
            return dalC.DeleteAllocation(c);
        }
        public DataTable FindAllocation(string sb)
        {
            return dalC.FindAllocation(sb);
        }
    }
}
