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
    
    public partial class QUANLINHOMNGUOIDUNG
    {
        public int MaQlNguoiDung { get; set; }
        public Nullable<int> MaNhom { get; set; }
        public Nullable<int> MaNV { get; set; }
        public string GhiChu { get; set; }
    
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
        public virtual NHOMNGUOIDUNG NHOMNGUOIDUNG { get; set; }
    }
}
