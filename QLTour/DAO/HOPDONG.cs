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
    
    public partial class HOPDONG
    {
        public int MaHD { get; set; }
        public Nullable<int> MaTour { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaKS { get; set; }
        public Nullable<System.DateTime> ThoiGianDat { get; set; }
        public Nullable<int> SoNguoiLon { get; set; }
        public Nullable<int> SoTreEm { get; set; }
        public string TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual KHACHSAN KHACHSAN { get; set; }
        public virtual TOUR TOUR { get; set; }
    }
}
