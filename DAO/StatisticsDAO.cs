using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class StatictisDAO
    {
        public static List<chitiethoadon> getInvoiceDetailsByMonthYear(String month, String year)
        {
            List<chitiethoadon> invoiceDetail = new List<chitiethoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    invoiceDetail = dbContext.chitiethoadons
                    .Where(x => x.hoadon.ngaylap.Value.Month.ToString() == month
                        && x.hoadon.ngaylap.Value.Year.ToString() == year)
                    .Include(x => x.thucuong.nhomthucuong)
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                invoiceDetail = null;
            }
            return invoiceDetail;
        }

        public static List<hoadon> getInvoicesByYear(String year)
        {
            List<hoadon> invoices = new List<hoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    invoices = dbContext.hoadons
                    .Where(x => x.ngaylap.Value.Year.ToString() == year)
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

        public static List<hoadon> getInvoicesByMonthYear(String month, String year)
        {
            List<hoadon> invoices = new List<hoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    invoices = dbContext.hoadons
                    .Where(x => x.ngaylap.Value.Month.ToString() == month && x.ngaylap.Value.Year.ToString() == year)
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

        public static List<String> getListYearAvaiable()
        {
            List<String> years = new List<String>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    foreach (hoadon invoice in dbContext.hoadons.ToList())
                    {
                        years.Add(invoice.ngaylap.Value.Year.ToString());
                    }
                    years = years.Distinct().ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                years = null;
            }
            return years;
        }
    }
}
