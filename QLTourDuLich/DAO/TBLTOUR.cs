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
    
    public partial class TBLTOUR
    {
        public TBLTOUR()
        {
            this.TBLHOPDONGs = new HashSet<TBLHOPDONG>();
        }
    
        public int MATOUR { get; set; }
        public int MAHANHTRINH { get; set; }
        public string MALOAITOUR { get; set; }
        public string TENTOUR { get; set; }
        public Nullable<int> TRANGTHAI { get; set; }
        public Nullable<double> GIATOUR { get; set; }
        public Nullable<System.DateTime> NGAYKHOIHANH { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public string HINHANH { get; set; }
    
        public virtual TBLHANHTRINH TBLHANHTRINH { get; set; }
        public virtual TBLLOAITOUR TBLLOAITOUR { get; set; }
        public virtual ICollection<TBLHOPDONG> TBLHOPDONGs { get; set; }
    }
}