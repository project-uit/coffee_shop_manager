using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class ThemNguyenLieuDAO
    {
        public static bool insert(khonguyenlieu khonguyenlieu)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    khonguyenlieu.xoa_flag = false;
                    db.khonguyenlieux.Add(khonguyenlieu);
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

        public static bool update(khonguyenlieu khonguyenlieu)
        {
            // cai kho nguyen lieu null cmnr khonguyenlieu = null ne
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var update = db.khonguyenlieux.Where(x => x.idkhonguyenlieu == khonguyenlieu.idkhonguyenlieu ).SingleOrDefault();
                if (update != null)
                {
                    try
                    {
                        update.tennguyenlieu = khonguyenlieu.tennguyenlieu;
                        update.dinhluong = khonguyenlieu.dinhluong;
                        update.tendonvi_dinh_luong = khonguyenlieu.tendonvi_dinh_luong;
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                }
            }
            return false;
        }
        public static bool delete(khonguyenlieu khonguyenlieu)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var delete = db.khonguyenlieux.Where(x => x.idkhonguyenlieu == khonguyenlieu.idkhonguyenlieu).SingleOrDefault();
                if (delete != null)
                {
                    delete.xoa_flag = true;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public static List<khonguyenlieu> getList()
        {
            List<khonguyenlieu> list = new List<khonguyenlieu>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                list = db.khonguyenlieux
                    .Where(x => x.xoa_flag == false)
                    .Include(x => x.chitietnhapkhoes)
                    .Include(x => x.chitietnguyenlieudadungs)
                    .Include(x => x.chitietcongthucs)
                    .ToList();
            }
            return list;
        }

        public static IList<khonguyenlieu> getIList()
        {

            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                return db.khonguyenlieux
                    .Where(x => x.xoa_flag == false)
                    .ToList();
            }
        }

        public static bool UpdateDinhLuong(int id, double dinhluong)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
               khonguyenlieu khonguyenlieu = db.khonguyenlieux.Where(x => x.idkhonguyenlieu == id).SingleOrDefault();
                if(khonguyenlieu != null)
                {
                    khonguyenlieu.dinhluong = khonguyenlieu.dinhluong + dinhluong;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
