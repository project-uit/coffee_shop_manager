﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quanlycafeEntities : DbContext
    {
        public quanlycafeEntities()
            : base("name=quanlycafeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chitietcongthuc> chitietcongthucs { get; set; }
        public virtual DbSet<chitiethoadon> chitiethoadons { get; set; }
        public virtual DbSet<chitietnguyenlieudadung> chitietnguyenlieudadungs { get; set; }
        public virtual DbSet<giamgia> giamgias { get; set; }
        public virtual DbSet<hoadon> hoadons { get; set; }
        public virtual DbSet<khonguyenlieu> khonguyenlieux { get; set; }
        public virtual DbSet<nguyenlieudadung> nguyenlieudadungs { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<nhapkho> nhapkhoes { get; set; }
        public virtual DbSet<nhomthucuong> nhomthucuongs { get; set; }
        public virtual DbSet<thucuong> thucuongs { get; set; }
    }
}
