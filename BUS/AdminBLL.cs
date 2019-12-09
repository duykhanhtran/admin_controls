using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace admin_controls.BUS
{
    class AdminBLL
    {
        DATA.AdminDAL dalAd;
        public AdminBLL()
        {
            dalAd = new DATA.AdminDAL();
        }
        public DataTable getAllAdmins()
        {
            return dalAd.getAllAdmins();
        }
        public bool UpdateAdmin(tbl.tblAdmin ad)
        {
            return dalAd.UpdateAdmin(ad);
        }
        public bool Check_Login(ref tbl.tblAdmin ad)
        {
            return dalAd.Check_Login(ref ad);
        }
    }
}
