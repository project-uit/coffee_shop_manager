using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class NhapKhoDAO
    {
        public static bool insert(nhapkho nhapkho)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    db.nhapkhoes.Add(nhapkho);
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
