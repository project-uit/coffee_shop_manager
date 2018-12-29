using COFFEE_SHOP_MANAGER.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class StatisticResourcesDAO
    {
        /*
         * Thống kê nguyên liệu theo tháng
         */
        public static List<ThongKeNguyenLieu> thongke(DateTime date)
        {
            int year = date.Year, month = date.Month;
            List<ThongKeNguyenLieu> list = new List<ThongKeNguyenLieu>();
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                db.khonguyenlieux.SqlQuery("select  knl.tennguyenlieu, sum(ctct.dinhluong*cthd.soluong) as dinhluong, knl.idkhonguyenlieu,knl.tendonvi_dinh_luong, knl.xoa_flag " +
                "from hoadon hd, chitiethoadon cthd, thucuong th, chitietcongthuc ctct, khonguyenlieu knl " +
                "where hd.id_hoadon = cthd.id_hoadon " +
                "and cthd.id_thucuong = th.id_thucuong " +
                "and ctct.id_thucuong = th.id_thucuong " +
                "and knl.idkhonguyenlieu = ctct.idkhonguyenlieu " +
                "and MONTH(hd.ngaylap) = @month and YEAR(hd.ngaylap) = @year "+
                "group by knl.tennguyenlieu, knl.idkhonguyenlieu, knl.xoa_flag, knl.tendonvi_dinh_luong",
                 new SqlParameter("month", month),
                 new SqlParameter("year", year)).ToList().ForEach(i=>
                 {
                     ThongKeNguyenLieu thongke = new ThongKeNguyenLieu();
                     thongke.idkhonguyenlieu = i.idkhonguyenlieu;
                     thongke.donvi = i.tendonvi_dinh_luong;
                     thongke.dinhluonglythuyet = i.dinhluong;
                     thongke.tennguyenlieu = i.tennguyenlieu;
                     list.Add(thongke);
                 });  
            }
            using (quanlycafeEntities db = new quanlycafeEntities())
            {
                db.khonguyenlieux.SqlQuery("select knl.tennguyenlieu, sum(ctnldd.dinhluong) as dinhluong,   knl.idkhonguyenlieu, knl.tendonvi_dinh_luong, knl.xoa_flag " +
                "from nguyenlieudadung nldd, chitietnguyenlieudadung ctnldd, khonguyenlieu knl " +
                "where nldd.idnguyenlieudadung = ctnldd.idnguyenlieudadung " +
                "and knl.idkhonguyenlieu = ctnldd.idkhonguyenlieu " +
                "and MONTH(nldd.ngaynhap) = @month and YEAR(nldd.ngaynhap) = @year " +
                "group by knl.tennguyenlieu,  knl.idkhonguyenlieu, knl.tendonvi_dinh_luong,knl.xoa_flag",
                new SqlParameter("month", month),
                new SqlParameter("year", year)).ToList().ForEach(i=>
                {
                    list.ForEach(j =>
                    {
                        if(i.idkhonguyenlieu == j.idkhonguyenlieu)
                        {
                            j.dinhluongthucte = i.dinhluong;
                            j.haohut = j.dinhluongthucte - j.dinhluonglythuyet;
                        }
                    });
                });
            }
            return list;
        }
    }
}
