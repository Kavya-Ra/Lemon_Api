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
    
    public partial class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string CreditorAccount { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateAndTime { get; set; }
        public int ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateAndTime { get; set; }
        public int DeletedBy { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
    }
}