using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DAO
{
    class StoreDAO
    {
        public static List<hoadon> getInvoices()
        {
            List<hoadon> invoices = new List<hoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    invoices = dbContext.hoadons
                        .Include(x => x.chitiethoadons)
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

        public static List<chitiethoadon> getInvoiceDetailsByInvoice(hoadon invoice)
        {
            List<chitiethoadon> invoiceDetails = new List<chitiethoadon>();
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    invoiceDetails = dbContext.chitiethoadons
                    .Where(x => x.id_hoadon == invoice.id_hoadon)
                    .Include(x=> x.hoadon)
                    .Include(x => x.thucuong)
                    .Include(x=> x.thucuong.nhomthucuong)
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                invoiceDetails = null;
            }
            return invoiceDetails;
        }

        public static Boolean addInvoice(hoadon invoice, List<chitiethoadon> listInvoiceDetail)
        {
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    dbContext.hoadons.Add(invoice);
                    dbContext.SaveChanges();
                    addListInvoiceDetail(invoice.id_hoadon, listInvoiceDetail);
                }
            }
            catch (Exception ex)
            {
                Console.Error.Write(ex);
                return false;
            }
            return true;
        }

        public static Boolean addListInvoiceDetail(int idInvoice, List<chitiethoadon> listInvoiceDetail)
        {
            try
            {
                using (quanlycafeEntities dbContext = new quanlycafeEntities())
                {
                    foreach (chitiethoadon invoiceDetail in listInvoiceDetail)
                    {
                        invoiceDetail.id_hoadon = idInvoice;
                        dbContext.chitiethoadons.Add(invoiceDetail);
                    }
                    
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
