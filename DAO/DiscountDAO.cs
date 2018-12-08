using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class DiscountDAO
    {
        public static bool insert(giamgia giamgia)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    db.giamgias.Add(giamgia);
                    db.SaveChanges();
                    return true;
                }catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }

        public static bool delete(giamgia giamgia)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var delete = db.giamgias.Where(x => x.id_giamgia == giamgia.id_giamgia).SingleOrDefault();
                try
                {
                    db.giamgias.Remove(delete);
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

        public static List<giamgia> getList()
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                return db.giamgias.ToList();
            }
        }

        public static int isValid(giamgia giamgia)
        {
            DateTime today = DateTime.Today;
            if (giamgia.ngaybatdau > giamgia.ngayketthuc)
            {
                return 2;
            }
            if(giamgia.ngaybatdau <= today)
            {
                return 3;
            }
            return 1;
        }

        public static bool isAccepted(giamgia giamgia)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                DateTime? ngayketthuc = db.giamgias.Max(x => x.ngayketthuc);
                if(giamgia.ngaybatdau <= ngayketthuc)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
