//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoomsManagement.Database.ORM
{
    using System;
    
    public partial class tblBranchMST_LOAD_ALL_Result
    {
        public long BranchID { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public Nullable<long> BankID { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreationDateTime { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdationDateTime { get; set; }
    }
}
