using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class BeverageDAO
    {
        public static void insert(thucuong thucuong)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                thucuong.xoa_flag = false;
                db.thucuongs.Add(thucuong);
                db.SaveChanges();
            }
        }

        public static void delete(thucuong thucuong)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var delete = db.thucuongs.Where(x => x.id_thucuong == thucuong.id_thucuong).SingleOrDefault();
                if (delete != null)
                {
                    delete.xoa_flag = true;
                    db.SaveChanges();
                }
            }
        }

        public static void update(thucuong thucuong)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                var update = db.thucuongs.Where(x => x.id_thucuong == thucuong.id_thucuong).SingleOrDefault();
                if (update != null)
                {
                    update.tenthucuong = thucuong.tenthucuong;
                    update.giaban = thucuong.giaban;
                    update.id_nhomthucuong = thucuong.id_nhomthucuong;
                    db.SaveChanges();
                }
            }
        }
        /*
        *lấy danh sách thức uống chưa bị xóa
        */
        public static List<thucuong> getList()
        {
            List<thucuong> list = new List<thucuong>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                list = db.thucuongs
                    .Where(x => x.xoa_flag == false)
                    .Include(x => x.nhomthucuong)
                    .Include(x => x.chitietcongthucs)
                    .Include(x => x.chitiethoadons)
                    .ToList();
            }           
            return list;
        }
    }
}
