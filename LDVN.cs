//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class LDVN
    {
        public string ID_LD { get; set; }
        public string HoTenLD { get; set; }
        public Nullable<System.DateTime> NgaySinhLD { get; set; }
        public string DiaChi_LD { get; set; }
        public string GioiTinh { get; set; }
        public string Email_LD { get; set; }
        public string SDT_LD { get; set; }
        public string Chucvu { get; set; }
        public string ID_CQTQ { get; set; }
        public byte[] Anh { get; set; }
    
        public virtual Quyenhan Quyenhan { get; set; }
        public virtual CQTQ CQTQ { get; set; }
    }
}
