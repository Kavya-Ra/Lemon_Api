//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuitappRest.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class CumsterPendingAmount
    {
        public int Slno { get; set; }
        public Nullable<int> RetailBillNo { get; set; }
        public Nullable<int> WholesaleBillNo { get; set; }
        public Nullable<int> PandingBillNo { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<decimal> PendingAmount { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public Nullable<decimal> CumBalaceAmount { get; set; }
        public Nullable<decimal> BillAmount { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> CumstomerId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
    }
}