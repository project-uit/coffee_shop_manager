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
    
    public partial class nguyenlieudadung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nguyenlieudadung()
        {
            this.chitietnguyenlieudadungs = new HashSet<chitietnguyenlieudadung>();
        }
    
        public int idnguyenlieudadung { get; set; }
        public Nullable<System.DateTime> ngaynhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietnguyenlieudadung> chitietnguyenlieudadungs { get; set; }
    }
}