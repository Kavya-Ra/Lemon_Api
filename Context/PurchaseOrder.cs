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
    
    public partial class PurchaseOrder
    {
        public int PurchaseID { get; set; }
        public int PurchaseNo { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public int PurchaseMode { get; set; }
        public int FYearID { get; set; }
        public int SupplierID { get; set; }
        public decimal Amount { get; set; }
        public int CheckAccountable { get; set; }
        public int LocationID { get; set; }
        public int IsAccountable { get; set; }
        public int IsPending { get; set; }
        public string TinNo { get; set; }
        public string Tax { get; set; }
        public int TaxTypeID { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateAndTime { get; set; }
        public int ModifiedBy { get; set; }
        public string NodifiedDateAndTime { get; set; }
        public int DeletedBy { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
        public int CompanyID { get; set; }
        public string TaxType { get; set; }
    }
}
