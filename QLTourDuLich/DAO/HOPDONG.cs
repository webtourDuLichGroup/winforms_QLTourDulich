//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            this.CHITIETHOPDONGs = new HashSet<CHITIETHOPDONG>();
        }
    
        public string MAHOPDONG { get; set; }
        public string MAKH { get; set; }
        public string MAKHACHSAN { get; set; }
        public System.DateTime THOIGIANDAT { get; set; }
        public decimal TONGTIEN { get; set; }
        public int SONGUOI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOPDONG> CHITIETHOPDONGs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual KHACHSAN KHACHSAN { get; set; }
    }
}
