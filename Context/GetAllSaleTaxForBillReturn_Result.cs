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
    
    public partial class GetAllSaleTaxForBillReturn_Result
    {
        public Nullable<int> RetailReturnNo { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public int RetailBillNo { get; set; }
        public System.DateTime BillDate { get; set; }
        public decimal BillAmount { get; set; }
        public string CustomerName { get; set; }
        public Nullable<decimal> NetRate { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
    }
}
