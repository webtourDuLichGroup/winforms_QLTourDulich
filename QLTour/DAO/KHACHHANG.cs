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
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.HOPDONGs = new HashSet<HOPDONG>();
        }
    
        public string MAKH { get; set; }
        public string MALOAIKH { get; set; }
        public string TENKH { get; set; }
        public string GIOITINH { get; set; }
        public decimal SDT { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
    
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
        public virtual LOAIKHACHHANG LOAIKHACHHANG { get; set; }
    }
}
