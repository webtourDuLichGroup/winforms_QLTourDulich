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
    
    public partial class DIADANH
    {
        public DIADANH()
        {
            this.DIADIEMs = new HashSet<DIADIEM>();
        }
    
        public string MaDiaDanh { get; set; }
        public string TenDiaDanh { get; set; }
    
        public virtual ICollection<DIADIEM> DIADIEMs { get; set; }
    }
}
