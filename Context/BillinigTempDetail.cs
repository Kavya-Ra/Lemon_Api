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
    
    public partial class BillinigTempDetail
    {
        public int BillID { get; set; }
        public int BillNo { get; set; }
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public int Category { get; set; }
        public string TinNo { get; set; }
        public string ItemName { get; set; }
        public int UnitID { get; set; }
        public decimal Quantity { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal MRP { get; set; }
        public string TaxPercentage { get; set; }
        public decimal NetRate { get; set; }
        public decimal TaxAmount { get; set; }
        public int SalesMode { get; set; }
        public decimal Amount { get; set; }
        public int LoadingCharge { get; set; }
        public int LocationID { get; set; }
        public int IsBillingAccountable { get; set; }
        public string CategoryName { get; set; }
        public int Loading { get; set; }
        public decimal ActualBillAmount { get; set; }
        public int RetailBillNo { get; set; }
    }
}