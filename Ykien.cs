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
    
    public partial class Ykien
    {
        public int ID_Ykien { get; set; }
        public string ID_CD { get; set; }
        public string ID { get; set; }
        public string Title { get; set; }
        public string ND { get; set; }
        public Nullable<System.DateTime> Date_sent { get; set; }
    
        public virtual CDVN CDVN { get; set; }
    }
}
