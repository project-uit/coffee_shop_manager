using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class FormulaDAO
    {
        public static IList<khonguyenlieu> GetKhonguyenlieus()
        {
            IList<khonguyenlieu> list = new List<khonguyenlieu>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
               db.khonguyenlieux.Where(x => x.xoa_flag == false).ToList().ForEach(i=>{
                   khonguyenlieu temp = new khonguyenlieu();
                   temp.idkhonguyenlieu = i.idkhonguyenlieu;
                   string tendonvi = "(" + i.tendonvi_dinh_luong.Trim() + ")";
                   temp.tennguyenlieu = i.tennguyenlieu + " "+tendonvi.Trim();
                   list.Add(temp);
                });
                return list;
            }
        }
        public static bool insert(chitietcongthuc chitietcongthuc)
        {
            using(quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    db.chitietcongthucs.Add(chitietcongthuc);
                    db.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return false;  
        }
        public static bool delete(chitietcongthuc chitietcongthuc)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                try
                {
                    var delete = db.chitietcongthucs.Where(x => x.id_chitietcongthuc == chitietcongthuc.id_chitietcongthuc).SingleOrDefault();
                    if(delete != null)
                    {
                        db.chitietcongthucs.Remove(delete);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return false;
        }
        public static List<chitietcongthuc> loadFormulaByIdThucUong(int id_thucuong)
        {
            List<chitietcongthuc> chitietcongthucs = new List<chitietcongthuc>();
            using(quanlycafeEntities db = new quanlycafeEntities())
            {
                chitietcongthucs = db.chitietcongthucs.Where(x => x.id_thucuong == id_thucuong)
                    .Include(x => x.khonguyenlieu)
                    .Include(x => x.thucuong)
                    .ToList();
            }
            return chitietcongthucs;
        }

        public static bool isExist(int id_thucuong, int id_nguyenlieu)
        {
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                int count = db.chitietcongthucs.Where(x => x.id_thucuong == id_thucuong && x.idkhonguyenlieu == id_nguyenlieu).Count();
                if(count == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
