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
    
    public partial class Allocation
    {
        public int AlocId { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public int VanID { get; set; }
        public int LastBillNo { get; set; }
        public string B2CSeries { get; set; }
        public string B2BSeries { get; set; }
        public Nullable<int> B2CLastNo { get; set; }
        public Nullable<int> B2BLastNo { get; set; }
        public Nullable<int> BranchID { get; set; }
    }
}