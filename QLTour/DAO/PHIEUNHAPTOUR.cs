//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUNHAPTOUR
    {
        public PHIEUNHAPTOUR()
        {
            this.CTPHIEUNHAP_TOUR = new HashSet<CTPHIEUNHAP_TOUR>();
        }
    
        public int MaPN { get; set; }
        public string TenPN { get; set; }
        public Nullable<System.DateTime> Ngaynhap { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        public virtual ICollection<CTPHIEUNHAP_TOUR> CTPHIEUNHAP_TOUR { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
