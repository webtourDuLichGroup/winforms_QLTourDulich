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
    
    public partial class LOAIKHACHSAN
    {
        public LOAIKHACHSAN()
        {
            this.KHACHSANs = new HashSet<KHACHSAN>();
        }
    
        public string MALOAIKS { get; set; }
        public string TENLOAI { get; set; }
    
        public virtual ICollection<KHACHSAN> KHACHSANs { get; set; }
    }
}