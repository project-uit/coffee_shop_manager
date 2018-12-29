using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class NguyenLieuDaDungDAO
    {
        public static bool insert(nguyenlieudadung nguyenlieudadung)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    db.nguyenlieudadungs.Add(nguyenlieudadung);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }
    }
}
