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
    
    public partial class GetSalesOrderSearch_Result
    {
        public string AccountName { get; set; }
        public Nullable<int> AccountID { get; set; }
        public string AccountCode { get; set; }
        public int SOID { get; set; }
        public System.DateTime Date { get; set; }
        public int OrderStatus { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string ItemName { get; set; }
        public int ItemID { get; set; }
        public decimal MRP { get; set; }
        public decimal WP { get; set; }
        public double Qty { get; set; }
        public Nullable<decimal> AdvanceAmo { get; set; }
        public decimal Amount { get; set; }
        public decimal TotAmo { get; set; }
    }
}
