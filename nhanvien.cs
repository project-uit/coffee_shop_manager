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
    
    public partial class nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhanvien()
        {
            this.nhapkhoes = new HashSet<nhapkho>();
        }
    
        public int id_nhanvien { get; set; }
        public string hoten { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public string cmnd { get; set; }
        public string diachi { get; set; }
        public decimal luong { get; set; }
        public string tentaikhoan { get; set; }
        public string matkhau { get; set; }
        public Nullable<int> quyen { get; set; }
        public Nullable<bool> xoa_flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhapkho> nhapkhoes { get; set; }
    }
}