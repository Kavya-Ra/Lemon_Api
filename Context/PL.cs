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
    
    public partial class PL
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int ItemParent { get; set; }
        public int ItemType { get; set; }
        public int ItemGroup { get; set; }
        public decimal Amount { get; set; }
        public string ReflectsIn { get; set; }
        public int OrderInPreview { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int DeletedBy { get; set; }
        public int IsDeleted { get; set; }
        public System.DateTime CreatedDateAndTime { get; set; }
        public Nullable<System.DateTime> MoifiedDateAndTime { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
    }
}
