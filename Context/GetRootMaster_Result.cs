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
    
    public partial class GetRootMaster_Result
    {
        public int RootId { get; set; }
        public string RootName { get; set; }
        public string PlaceName { get; set; }
        public string FromPlace { get; set; }
        public string ToPlace { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> District { get; set; }
        public Nullable<int> Taluk { get; set; }
    }
}