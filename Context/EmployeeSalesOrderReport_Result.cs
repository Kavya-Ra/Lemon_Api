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
    
    public partial class EmployeeSalesOrderReport_Result
    {
        public int DSID { get; set; }
        public System.DateTime Date { get; set; }
        public string Orderno { get; set; }
        public int customerID { get; set; }
        public string Customer_SuitAppsId { get; set; }
        public Nullable<int> itemid { get; set; }
        public string Tax { get; set; }
        public Nullable<decimal> Tax_Amt { get; set; }
        public int UserID { get; set; }
        public Nullable<decimal> FcessAmt { get; set; }
        public Nullable<double> qty { get; set; }
        public Nullable<decimal> netamount { get; set; }
        public string itemname { get; set; }
        public decimal amount { get; set; }
        public Nullable<double> FreeQuantity { get; set; }
        public Nullable<decimal> rate { get; set; }
    }
}
