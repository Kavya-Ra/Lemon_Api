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
    
    public partial class ItemPatternDetail
    {
        public int UnitID { get; set; }
        public string ItemName { get; set; }
        public int ItemID { get; set; }
        public string UnitName { get; set; }
        public decimal Discount { get; set; }
        public int TaxID { get; set; }
        public string Tax { get; set; }
        public decimal Sales_Price { get; set; }
        public decimal MRP { get; set; }
        public decimal ContainerRate { get; set; }
        public decimal LoadingCharge { get; set; }
        public int Quantity { get; set; }
        public decimal WholeSalePrice { get; set; }
        public string AddedUnit { get; set; }
        public int LevelNo { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateAndTime { get; set; }
        public Nullable<System.DateTime> MofifiedDateAndTime { get; set; }
        public int DeletedBy { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
        public string Pattern { get; set; }
        public int Count { get; set; }
    }
}