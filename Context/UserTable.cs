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
    
    public partial class UserTable
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConformPassword { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyID { get; set; }
        public string Company { get; set; }
        public int CSTNo { get; set; }
        public Nullable<int> UserRoleId { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime Created_Date_And_Time { get; set; }
        public int ModifiedBy { get; set; }
        public Nullable<System.DateTime> Modified_DateAndTime { get; set; }
        public int Deleted_BY { get; set; }
        public int IsDeleted { get; set; }
        public Nullable<System.DateTime> Deleted_Date_And_Time { get; set; }
        public Nullable<int> LocId { get; set; }
        public Nullable<int> RootId { get; set; }
        public int Status { get; set; }
    }
}
