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
    
    public partial class PurchaseOrderDetail
    {
        public int PurchaseID { get; set; }
        public int ItemID { get; set; }
        public int ItemCategoryID { get; set; }
        public int SubcategoryID { get; set; }
        public string itemCode { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public int UnitID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal MRP { get; set; }
        public string TaxPercentage { get; set; }
        public decimal TaxAmount { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int LocationID { get; set; }
        public int IsAccountable { get; set; }
    }
}
