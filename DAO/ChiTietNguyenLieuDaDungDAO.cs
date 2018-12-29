using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class ChiTietNguyenLieuDaDungDAO
    {
        public static bool insert(chitietnguyenlieudadung chitietnguyenlieudadung)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {

                    db.chitietnguyenlieudadungs.Add(chitietnguyenlieudadung);
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

        public static List<chitietnguyenlieudadung> getList()
        {
            List<chitietnguyenlieudadung> list = new List<chitietnguyenlieudadung>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                list = db.chitietnguyenlieudadungs
                   
                    .ToList();
            }
            return list;
        }

        public static IList<chitietnguyenlieudadung> getIList()
        {

            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                return db.chitietnguyenlieudadungs
                    .ToList();
            }
        }
    }
}
