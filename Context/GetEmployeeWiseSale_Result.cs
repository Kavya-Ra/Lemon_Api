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
    
    public partial class GetEmployeeWiseSale_Result
    {
        public int DSID { get; set; }
        public System.DateTime Date { get; set; }
        public string OrderNo { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> AdvanceAmo { get; set; }
        public decimal TotAmo { get; set; }
        public int OrderStatus { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int DeletedBy { get; set; }
        public System.DateTime DeletedDate { get; set; }
        public int IsDeletedBy { get; set; }
        public string SuitApps_id { get; set; }
        public Nullable<decimal> DISCOUNT { get; set; }
        public string discount_rate { get; set; }
        public string Customer_SuitAppsId { get; set; }
        public string Bill_Series { get; set; }
        public Nullable<int> Billno { get; set; }
        public Nullable<int> BillMode { get; set; }
        public string InvType { get; set; }
    }
}
