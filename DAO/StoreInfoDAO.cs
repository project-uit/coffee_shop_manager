using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class StoreInfoDAO
    {
        public static cuahang getInfo()
        {
            cuahang cuahang = new cuahang();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    cuahang = dbContext.cuahangs.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
            }
            return cuahang;
        }

        public static Boolean edit(cuahang cuahang)
        {
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    cuahang ch = dbContext.cuahangs.Find(cuahang.idcuahang);
                    ch.ten = cuahang.ten;
                    ch.diachi = cuahang.diachi;
                    ch.dienthoai = cuahang.dienthoai;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                return false;
            }
            return true;
        }
    }
}
