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
    
    public partial class PURCHASE_BILL_DETAIL
    {
        public int id_bill { get; set; }
        public int id_product { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> cost { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
        public virtual PURCHASE_BILL PURCHASE_BILL { get; set; }
    }
}
