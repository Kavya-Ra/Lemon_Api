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
    
    public partial class CompanyInfo
    {
        public int ID { get; set; }
        public int CompanyId { get; set; }
        public string TinNo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public string Address { get; set; }
        public string TelephoneNo { get; set; }
        public string MobileNO { get; set; }
        public string Citty { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string CSTNo { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime created_Date_And_Time { get; set; }
        public int ModifiedBy { get; set; }
        public Nullable<System.DateTime> Modified_Date_And_Time { get; set; }
        public int Deletedby { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
        public string GSTinNo { get; set; }
        public Nullable<int> BillNo_DS { get; set; }
        public string Email { get; set; }
    }
}
