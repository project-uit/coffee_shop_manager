//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COFFEE_SHOP_MANAGER
{
    using System;
    using System.Collections.Generic;
    
    public partial class chitiethoadon
    {
        public int id_chitiethoadon { get; set; }
        public Nullable<int> id_hoadon { get; set; }
        public Nullable<int> id_thucuong { get; set; }
        public int soluong { get; set; }
        public Nullable<decimal> dongia { get; set; }
        public Nullable<decimal> thanhtien { get; set; }
    
        public virtual hoadon hoadon { get; set; }
        public virtual thucuong thucuong { get; set; }
    }
}
