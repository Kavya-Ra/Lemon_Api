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
    
    public partial class Unit
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDateAndTime { get; set; }
        public Nullable<System.DateTime> MofifiedDateAndTime { get; set; }
        public int DeletedBy { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> DeletedDateAndTime { get; set; }
    }
}
