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
    
    public partial class GetQuantityByItemID_Result
    {
        public int ProductID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal MRP { get; set; }
        public decimal WP { get; set; }
        public int CategoryID { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<decimal> stock { get; set; }
        public string ManufactureID { get; set; }
        public string Tax { get; set; }
        public string HSNCode { get; set; }
        public Nullable<decimal> CCP { get; set; }
        public Nullable<decimal> FCessRate { get; set; }
        public Nullable<decimal> TVMRate { get; set; }
        public Nullable<decimal> WayanadRate { get; set; }
        public Nullable<decimal> KasRate { get; set; }
        public Nullable<int> ItemUnitType { get; set; }
        public string Image { get; set; }
    }
}
