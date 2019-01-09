using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class DashboardDAO
    {
        public static List<hoadon> getInvoicesToday()
        {
            DateTime today = DateTime.Now;
            List<hoadon> invoices = new List<hoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    invoices = dbContext.hoadons
                    .Include(x => x.chitiethoadons)
                    .Where(x => x.ngaylap.Value.Year == today.Year
                        && x.ngaylap.Value.Month == today.Month
                        && x.ngaylap.Value.Day == today.Day)
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                invoices = null;
            }
            return invoices;
        }

        public static List<chitiethoadon> getDetailInvoicesToday()
        {
            DateTime today = DateTime.Now;
            List<chitiethoadon> list = new List<chitiethoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    list = dbContext.chitiethoadons
                    .Include(x => x.thucuong.nhomthucuong)
                    .Where(x => x.hoadon.ngaylap.Value.Year == today.Year
                        && x.hoadon.ngaylap.Value.Month == today.Month
                        && x.hoadon.ngaylap.Value.Day == today.Day)
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
            }
            return list;
        }
    }
}
