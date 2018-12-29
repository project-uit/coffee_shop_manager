using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace COFFEE_SHOP_MANAGER.DAO
{
    class ChiTietNhapKhoDAO
    {
        public static bool insert(chitietnhapkho chitietnhapkho)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    
                    db.chitietnhapkhoes.Add(chitietnhapkho);
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

        public static List<chitietnhapkho> getList()
        {
            List<chitietnhapkho> list = new List<chitietnhapkho>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                list = db.chitietnhapkhoes
                    .Include(x => x.khonguyenlieu)
                    .Include(x => x.nhapkho)
                    .ToList();
            }
            return list;
        }

        public static IList<chitietnhapkho> getIList()
        {

            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                return db.chitietnhapkhoes
                    
                    .ToList();
            }
        }
    }
}
