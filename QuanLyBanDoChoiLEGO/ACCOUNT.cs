//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanDoChoiLEGO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCOUNT
    {
        public int id { get; set; }
        public int id_staff { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public Nullable<byte> is_admin { get; set; }
    
        public virtual STAFF STAFF { get; set; }
    }
}
