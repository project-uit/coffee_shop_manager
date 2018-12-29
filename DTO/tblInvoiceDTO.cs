using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFFEE_SHOP_MANAGER.DTO
{
    public class tblInvoiceDTO
    {
        public int idthucuong { get; set; }
        public string tenthucuong { get; set; }
        public string nhomthucuong { get; set; }
        public Nullable<decimal> giaban { get; set; }
        public int soluong { get; set; }
        public Nullable<decimal> thanhtien { get; set; }

        public tblInvoiceDTO() { }
        public tblInvoiceDTO(int idthucuong, string tenthucuong, string nhomthucuong, Nullable<decimal> giaban, int soluong, Nullable<decimal> thanhtien)
        {
            this.idthucuong = idthucuong;
            this.tenthucuong = tenthucuong;
            this.nhomthucuong = nhomthucuong;
            this.giaban = giaban;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }
    }
}
