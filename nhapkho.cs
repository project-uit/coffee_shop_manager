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
    
    public partial class nhapkho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhapkho()
        {
            this.chitietnhapkhoes = new HashSet<chitietnhapkho>();
        }
    
        public int idnhapkho { get; set; }
        public System.DateTime ngaynhap { get; set; }
        public int id_nhanvien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietnhapkho> chitietnhapkhoes { get; set; }
        public virtual nhanvien nhanvien { get; set; }
    }
}
