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
    
    public partial class GetItemByBatchId_Result
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
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateAndTime { get; set; }
        public Nullable<System.DateTime> MofifiedDateAndTime { get; set; }
        public int DeletedBy { get; set; }
        public int IsDeleted1 { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
        public Nullable<int> CategoryID1 { get; set; }
        public string CatgoryName { get; set; }
        public string CategoryCode { get; set; }
        public Nullable<int> CategoryType { get; set; }
        public Nullable<int> CategoryParent { get; set; }
        public Nullable<int> TaxID { get; set; }
        public string TaxName { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> CreatedBy1 { get; set; }
        public Nullable<System.DateTime> CreatedDateAndTime1 { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDateAndTime { get; set; }
        public Nullable<int> DeletedbY1 { get; set; }
        public Nullable<int> IsDeleted2 { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime1 { get; set; }
        public string SCategory { get; set; }
    }
}